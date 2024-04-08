using Patholab_Common;
using Patholab_DAL_V1;
using System;
using System.Globalization;
//using MR_ClinicalDocument;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace ClalitArrived
{
    public class ArrivedResponse
    {

        //    DataLayer _dal;
        private string newEntry;
        private MR_ClinicalDocument data;
        private string _outputXmlName;



        public ArrivedResponse (/* DataLayer dal,*/ SDG sdg, string outputXmlName, string pdfTemplate )
        {
            try
            {
                if ( sdg.SDG_USER.U_ORDER.U_ORDER_USER.U_CUSTOMER1.U_CUSTOMER_USER.U_CLALIT == null ||
                                  sdg.SDG_USER.U_ORDER.U_ORDER_USER.U_CUSTOMER1.U_CUSTOMER_USER.U_CLALIT != "T" )
                {
                    MessageBox.Show ( "הלקוח אינו כללית,לא יישלח אישור הגעה!", "Nautilus", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading );
                    CreateFile = false;
                    return;
                }


                CreateFile = true;
                _outputXmlName = outputXmlName;
                var SdgId = sdg.SDG_ID;


                CE snomedCodes;

                string loincResult;
                string loincRDescription;
                if ( sdg.NAME.StartsWith ( "P" ) )
                {
                    loincResult = "31195-1";
                    loincRDescription = "CYTO SOFT TISS FNA";
                }
                else
                {
                    loincResult = "10780-5";
                    loincRDescription = "CAE STN TISS";
                }
                if ( loincResult != "" )
                {
                    snomedCodes = new CE
                    {
                        //displayName = "EMG-ENG",
                        codeSystemName = "LOINC",
                        code = loincResult,
                        displayName = loincRDescription
                    };
                }
                else
                {
                    snomedCodes = new CE { };
                }

                Authenticator[] authenticators = new Authenticator[1];
                int inspectionIndex = 0;

                inspectionIndex++;

                authenticators [ inspectionIndex - 1 ] = new Authenticator
                {
                    time = new TS
                    {
                        //adi comment will be "<time/>"
                        //   value = inspectionDate.ToString ( "yyyyMMdd" ),
                    },
                    AssignedPerson = new AssignedPerson
                    {
                        assignedPerson = new Person
                        {
                            license = new LicensedEntity [ ]{
                                            new LicensedEntity{
                                                // licence nbr
                                                code= new CE{
                                                    code=
                                                    "99",
                                                }
                                            },
                                        },
                            name = new EN
                            {
                                ItemsElementName = new ItemsChoiceType [ 3/*5*/ ]{
                                         //     ItemsChoiceType.delimiter,
                                              ItemsChoiceType.prefix,
                                         //     ItemsChoiceType.suffix,
                                              ItemsChoiceType.given,
                                              ItemsChoiceType.family,

                                         }
                                    ,
                                Items = new string [ 3/*5*/  ]
                                 {
                                     //     "",
                                     "לא ידוע",
                                       //    "",                                           
                                   "לא ידוע",  "לא ידוע",
                                 }
                            }
                        }
                    }
                };


                string uuid = System.Guid.NewGuid().ToString();


                //update status is  2, delete is 3
                newEntry = "1";
                CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                culture.DateTimeFormat.LongTimePattern = culture.DateTimeFormat.SortableDateTimePattern;
                culture.DateTimeFormat.ShortTimePattern = culture.DateTimeFormat.SortableDateTimePattern;
                Thread.CurrentThread.CurrentCulture = culture;

                DateTime sendTime = DateTime.Now;

                //convert pdf file to base 64

                //: enapsulate the pdf 
                byte[] pdfBytes = File.ReadAllBytes(pdfTemplate);
                string[] pdfBase64 = new string[1];
                pdfBase64 [ 0 ] = Convert.ToBase64String ( pdfBytes );



                data = new MR_ClinicalDocument { };

                data.MessageInfo = new MessageInfo
                {
                    //מספר יחודי לכל 
                    MessageId = uuid,
                    DateSent = sendTime,
                };



                MessageInfoValue msginval = CreateMsginfval ( "TestStatusCode" , "210");
                MessageInfoValue msginval2 = CreateMsginfval ("TestStatusName","אישור קבלה" );


                data.MessageInfo.PropertyLine = new MessageInfoValue [ ] { msginval, msginval2 };





                data.id = new II
                {
                    extension = uuid,
                    //root = uuid,
                };

                //חלק זה הוא קוד הסנומד של התוצאה
                data.code = snomedCodes;
                data.text = new ED
                {
                    attached = EDAttached.EMBD,
                    Text = pdfBase64,
                };
                data.statusCode = new CE
                {
                    code = newEntry,
                };

                //האם המידע חסוי
                data.confidentialityCode = new CE
                {
                    code = Convert.ToInt32 ( false ).ToString ( ),
                };
                data.storageCode = new CE
                {
                    displayName = "PDF",
                    code = "9",
                };
                data.copyTime = new TS
                {
                    value = sendTime.ToString ( "yyyyMMddHHmm", CultureInfo.InvariantCulture ),
                };
                data.authenticator = authenticators;
                data.author = new Author [ 1 ]
                    {
                        new Author{
                            assignedAuthor=new AssignedAuthor{
                                //קוד המערכת התפעולית שהפיקה את הסיכום
                                code=new CE{
                                    code="404",
                                }
                            }
                        }
                    };
                data.custodian = new Custodian
                {
                    assignedCustodian = new AssignedCustodian
                    {
                        Organization = new Organization
                        {
                            id = new II
                            {
                                // ספק חיצוני --קוד מוסד מבצע 
                                root = "997",
                            },
                            code = new CE
                            {
                                //קוד יחידה מבצעת – מחלקה/מכון 
                                code = "7203",
                            }


                        }

                    }
                };
                data.subject = new Subject
                {
                    subjectRole = new SubjectRole
                    {
                        classCode = ClassCodeFromSdgName ( sdg ),
                        code = new CE
                        {
                            //מס זיהוי מטופל 
                            //todo:deal with passport
                            code = truncZeroAndBikoret ( sdg.SDG_USER.CLIENT.NAME ),
                            codeSystem = "1",
                        },
                        documentSubject = new SubjectPerson
                        {
                            name = new PN
                            {
                                ItemsElementName = new ItemsChoiceType1 [ 3 ]
                                   {
                                    ItemsChoiceType1.family,
                                    ItemsChoiceType1.given,
                                    ItemsChoiceType1.suffix,
                                   },
                                Items = new string [ 3 ]
                                   {
                                      sdg.SDG_USER.CLIENT.CLIENT_USER.U_LAST_NAME,
                                      sdg.SDG_USER.CLIENT.CLIENT_USER.U_FIRST_NAME,
                                       ""
                                   },
                            },

                        }
                    },

                };
                if ( sdg.SDG_USER.CLIENT.CLIENT_USER.U_DATE_OF_BIRTH != null )
                {
                    data.subject.subjectRole.documentSubject.birthTime = new TS
                    {
                        value = toYYMMDDFormat ( sdg.SDG_USER.CLIENT.CLIENT_USER.U_DATE_OF_BIRTH ),
                    };
                }
                else
                {
                    data.subject.subjectRole.documentSubject.birthTime = new TS { };
                }
                data.componentOf = new Component
                {
                    encounterEvent = new EncounterEvent
                    {
                        code = new CE
                        {
                            code = sdg.SDG_ID.ToString ( ),
                        },
                        effectiveTime = new IVL_TS
                        {

                            value = toYYMMDDFormat ( sdg.CREATED_ON ),
                        }
                    },
                };
                if ( sdg.SDG_USER.U_IMPLEMENTING_PHYSICIAN != null )
                {


                    U_CLINIC clinic = sdg.SDG_USER.IMPLEMENTING_CLINIC;

                    SUPPLIER physician = sdg.SDG_USER.IMPLEMENTING_PHYSICIAN;
                    //use the bottom form data if avaylable
                    if ( sdg.SDG_USER.REFERRAL_PHYSICIAN_CLINIC != null )
                    {
                        clinic = sdg.SDG_USER.REFERRAL_PHYSICIAN_CLINIC;
                        if ( sdg.SDG_USER.REFERRING_PHYSIC != null ) physician = sdg.SDG_USER.REFERRING_PHYSIC;
                    }

                    string suplierFirstName = physician.SUPPLIER_USER.U_FIRST_NAME;

                    string suplierGivenName = physician.SUPPLIER_USER.U_LAST_NAME;
                    if ( !string.IsNullOrEmpty ( suplierFirstName ) ) suplierGivenName = suplierFirstName + " " + suplierGivenName;
                    data.informationRecipient = new informationRecipient [ 1 ];
                    data.informationRecipient [ 0 ] = new informationRecipient ( );
                    data.informationRecipient [ 0 ].AssignedPerson = new AssignedPerson ( );
                    data.informationRecipient [ 0 ].AssignedPerson.assignedPerson = new Person ( );

                    data.informationRecipient [ 0 ].AssignedPerson.assignedPerson.name = new EN ( );
                    data.informationRecipient [ 0 ].AssignedPerson.assignedPerson.name.ItemsElementName = new ItemsChoiceType [ 3 ]
                                                                {

                                                                    ItemsChoiceType.prefix,
                                                                    ItemsChoiceType.family,
                                                                    ItemsChoiceType.given,

                                                                };
                    //.Replace('"', ' ')
                    data.informationRecipient [ 0 ].AssignedPerson.assignedPerson.name.Items = new string [ 3 ]
                        {
                            physician.SUPPLIER_USER.U_DEGREE ?? "",
                            "",
                            suplierGivenName ?? "",
                        };
                    data.informationRecipient [ 0 ].AssignedPerson.assignedPerson.license = new LicensedEntity [ 1 ]
                        {
                            new LicensedEntity
                                {
                                    // link to refering
                                    code =
                                        new CE()
                                            {
                                                code =
                                                    physician
                                                        .NAME ?? ""
                                            }
                                }
                        };
                    data.informationRecipient [ 0 ].AssignedCustodian = new AssignedCustodian
                    {
                        Organization = new Organization
                        {

                            id = new II
                            {
                                assigningAuthorityName = clinic == null ? "" : clinic.NAME,
                                extension = clinic == null ? "" : clinic.U_CLINIC_USER.U_CLINIC_CODE ?? ""
                                // link to customer
                                //extension=currentSDg.SDG_USER.u_customer.u_customer_code
                            }
                        }
                    };
                    //data.informationRecipient = new informationRecipient[1]
                    //    {
                    //        new informationRecipient
                    //            {
                    //                AssignedPerson = new AssignedPerson
                    //                    {
                    //                        assignedPerson = new Person
                    //                            {
                    //                                name = new EN
                    //                                    {
                    //                                        ItemsElementName = new ItemsChoiceType[3]
                    //                                            {

                    //                                                ItemsChoiceType.prefix,
                    //                                                ItemsChoiceType.family,
                    //                                                ItemsChoiceType.given,

                    //                                            }
                    //                                        ,
                    //                                        Items = new string[3]
                    //                                            {
                    //                                                physician.SUPPLIER_USER.U_DEGREE.Replace('"',' ') ?? "",
                    //                                                "",
                    //                                                suplierGivenName?? "",
                    //                                            }
                    //                                    },
                    //            license = new LicensedEntity[1]
                    //                {
                    //                    new LicensedEntity
                    //                        {
                    //                            // link to refering
                    //                            code =
                    //                                new CE()
                    //                                    {
                    //                                        code =
                    //                                            physician
                    //                                               .NAME ?? ""
                    //                                    }
                    //                        }
                    //                }
                    //        }
                    //},
                    //            AssignedCustodian = new AssignedCustodian
                    //                {
                    //                    Organization = new Organization
                    //                        {

                    //                            id = new II
                    //                                {
                    //                                  assigningAuthorityName = clinic==null? "" :clinic.NAME,
                    //                                  extension = clinic==null? "" :clinic.U_CLINIC_USER.U_CLINIC_CODE??""
                    //                                    // link to customer
                    //                                    //extension=currentSDg.SDG_USER.u_customer.u_customer_code
                    //                                }
                    //                        }
                    //                }

                    //        }

                    //};
                }
                //todo: check ini fukfilment:
                //4.2	פרטי הפניה





            }
            catch ( Exception ex )
            {

                MessageBox.Show ( "נכשלה שליחת התוצאה" );
                CreateFile = false;
                Logger.WriteLogFile ( ex );
            }

        }

        private MessageInfoValue CreateMsginfval ( string name, string text )
        {
            var msginval=new MessageInfoValue();
            msginval.name = name;
            msginval.Text = new string [ 1 ];
            msginval.Text [ 0 ] = text;
            return msginval;
        }

        private string ClassCodeFromSdgName ( SDG sdg )
        {
            if ( sdg.NAME.First ( ) == 'P' )
                return "CYT";
            else
                return "PAT";
        }

        private string toYYMMDDFormat ( DateTime? dateVal )
        {
            if ( dateVal.HasValue )
                return ( ( DateTime ) dateVal ).ToString ( "yyyyMMdd" );
            else
                return "";
        }

        private string truncZeroAndBikoret ( string GovIdNumber )
        {
            if ( GovIdNumber == null ) return "";
            GovIdNumber = GovIdNumber.Substring ( 0, GovIdNumber.Length - 1 );
            if ( GovIdNumber == "" ) return "";
            while ( GovIdNumber.First ( ) == '0' ) GovIdNumber = GovIdNumber.Substring ( 1 );
            return GovIdNumber;
        }
        bool CreateFile;
        public void GenerateFile ( )
        {
            if ( !CreateFile )
                return;
            try
            {
                var serializer = new XmlSerializer(typeof(MR_ClinicalDocument));
                Directory.CreateDirectory ( Path.GetDirectoryName ( _outputXmlName ) );
                using ( var stream = new StreamWriter ( _outputXmlName ) )
                    serializer.Serialize ( stream, data );
            }
            catch ( Exception ex )
            {
                //     MessageBox.Show("נכשלה שליחת התוצאה");
                Logger.WriteLogFile ( ex );
            }

        }
        private string nvl ( string stringOrNull )
        {
            return stringOrNull == null ? "" : stringOrNull;
        }
    }
}
