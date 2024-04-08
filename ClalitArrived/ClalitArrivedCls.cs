using LSEXT;
using LSSERVICEPROVIDERLib;
using Patholab_Common;
using Patholab_DAL_V1;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ClalitArrived
{

    [ComVisible ( true )]
    [ProgId ( "ClalitArrived.ClalitArrivedCls" )]
    public class ClalitArrivedCls : IWorkflowExtension
    {
        INautilusServiceProvider sp;


        public void Execute ( ref LSExtensionParameters Parameters )
        {
            try
            {


                string tableName = Parameters["TABLE_NAME"];

                sp = Parameters [ "SERVICE_PROVIDER" ];
                var rs = Parameters["RECORDS"];




                //       Debugger.Launch();
                //Recordset rs = Parameters["RECORDS"];
                string firstSDG = rs["SDG_ID"].Value.ToString();
                string NAME = rs["NAME"].Value.ToString();
                rs.MoveLast ( );
                string tableID = rs.Fields["SDG_ID"].Value.ToString();
                string workstationId = Parameters["WORKSTATION_ID"].ToString();
                long sdgId = long.Parse(tableID);
                var ntlCon = Utils.GetNtlsCon(sp);
                Utils.CreateConstring ( ntlCon );
                /////////////////////////////           
                var dal = new DataLayer ( );
                dal.Connect ( ntlCon );
                SDG sdg = dal.FindBy<SDG>(d => d.SDG_ID == sdgId).SingleOrDefault();
                
                string XmlDir;
                string pdfTemplate;

                //Get Directories
                PHRASE_HEADER SystemParams = dal.GetPhraseByName("System Parameters");

                //Get xml destination path
                SystemParams.PhraseEntriesDictonary.TryGetValue ( "XML Directory Clalit Receiving", out XmlDir );
                //BUILD PATH
                string outputXmlName= Path.GetDirectoryName(XmlDir)+@"\MDR_404_18_"+sdg.SDG_ID+"_"+dal.GetSysdate().ToString("yyyyMMddHHmmss")+"_"+".XML";

                //Get pdf template path
                SystemParams.PhraseEntriesDictonary.TryGetValue ( "Clalit Receiving Pdf", out pdfTemplate );



                var xmlReport = new ArrivedResponse(/*dal,*/ sdg, outputXmlName,pdfTemplate);
                xmlReport.GenerateFile ( );



            }
            catch ( Exception ex )
            {
                MessageBox.Show ( "נכשלה שליחת XML" );
                Logger.WriteLogFile ( ex );
            }
        }
    }
}
