﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
[System.Xml.Serialization.XmlRootAttribute("ClinicalDocument", Namespace="urn:hl7-org:v3", IsNullable=false)]
public partial class MR_ClinicalDocument {
    
    private MessageInfo messageInfoField;
    
    private II idField;
    
    private CE codeField;
    
    private ED textField;
    
    private CE statusCodeField;
    
    private CE confidentialityCodeField;
    
    private CE storageCodeField;
    
    private TS copyTimeField;
    
    private Authenticator[] authenticatorField;
    
    private Authenticator legalAuthenticatorField;
    
    private Author[] authorField;
    
    private Custodian custodianField;
    
    private Subject subjectField;
    
    private Component componentOfField;
    
    private informationRecipient[] informationRecipientField;
    
    private inFulfillmentOf[] inFulfillmentOfField;
    
    private CE priorityField;
    
    /// <remarks/>
    public MessageInfo MessageInfo {
        get {
            return this.messageInfoField;
        }
        set {
            this.messageInfoField = value;
        }
    }
    
    /// <remarks/>
    public II id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public CE code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    public ED text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    public CE statusCode {
        get {
            return this.statusCodeField;
        }
        set {
            this.statusCodeField = value;
        }
    }
    
    /// <remarks/>
    public CE confidentialityCode {
        get {
            return this.confidentialityCodeField;
        }
        set {
            this.confidentialityCodeField = value;
        }
    }
    
    /// <remarks/>
    public CE storageCode {
        get {
            return this.storageCodeField;
        }
        set {
            this.storageCodeField = value;
        }
    }
    
    /// <remarks/>
    public TS copyTime {
        get {
            return this.copyTimeField;
        }
        set {
            this.copyTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("authenticator")]
    public Authenticator[] authenticator {
        get {
            return this.authenticatorField;
        }
        set {
            this.authenticatorField = value;
        }
    }
    
    /// <remarks/>
    public Authenticator legalAuthenticator {
        get {
            return this.legalAuthenticatorField;
        }
        set {
            this.legalAuthenticatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("author")]
    public Author[] author {
        get {
            return this.authorField;
        }
        set {
            this.authorField = value;
        }
    }
    
    /// <remarks/>
    public Custodian custodian {
        get {
            return this.custodianField;
        }
        set {
            this.custodianField = value;
        }
    }
    
    /// <remarks/>
    public Subject subject {
        get {
            return this.subjectField;
        }
        set {
            this.subjectField = value;
        }
    }
    
    /// <remarks/>
    public Component componentOf {
        get {
            return this.componentOfField;
        }
        set {
            this.componentOfField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("informationRecipient")]
    public informationRecipient[] informationRecipient {
        get {
            return this.informationRecipientField;
        }
        set {
            this.informationRecipientField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("inFulfillmentOf")]
    public inFulfillmentOf[] inFulfillmentOf {
        get {
            return this.inFulfillmentOfField;
        }
        set {
            this.inFulfillmentOfField = value;
        }
    }
    
    /// <remarks/>
    public CE priority {
        get {
            return this.priorityField;
        }
        set {
            this.priorityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class MessageInfo {
    
    private string messageIdField;
    
    private System.DateTime dateSentField;
    
    private string bpmIdField;
    
    private string fileCreationTimeField;
    
    private string preProcessedTimeField;
    
    private MessageInfoValue[] propertyLineField;
    
    /// <remarks/>
    public string MessageId {
        get {
            return this.messageIdField;
        }
        set {
            this.messageIdField = value;
        }
    }
    
    /// <remarks/>
    [XmlIgnore]
    public System.DateTime DateSent
    {
        get
        {
            return this.dateSentField;
        }
        set
        {
            this.dateSentField = value;
        }
    }


    [XmlElement("DateSent")]
    public string DateSentString
    {
        get { return this.dateSentField.ToString("yyyy-MM-ddTHH:mm:ss"); }
        set { this.dateSentField = System.DateTime.Parse(value); }
    }
    /// <remarks/>
    public string BpmId {
        get {
            return this.bpmIdField;
        }
        set {
            this.bpmIdField = value;
        }
    }
    
    /// <remarks/>
    public string FileCreationTime {
        get {
            return this.fileCreationTimeField;
        }
        set {
            this.fileCreationTimeField = value;
        }
    }
    
    /// <remarks/>
    public string PreProcessedTime {
        get {
            return this.preProcessedTimeField;
        }
        set {
            this.preProcessedTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("value", IsNullable=false)]
    public MessageInfoValue[] PropertyLine {
        get {
            return this.propertyLineField;
        }
        set {
            this.propertyLineField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:hl7-org:v3")]
public partial class MessageInfoValue {
    
    private string nameField;
    
    private string[] textField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class ServiceEvent {
    
    private II[] idField;
    
    private CE codeField;
    
    private TS effectiveTimeField;
    
    private CE priorityCodeField;
    
    private CE statusCodeField;
    
    private informationRecipient performerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("id")]
    public II[] id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public CE code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    public TS effectiveTime {
        get {
            return this.effectiveTimeField;
        }
        set {
            this.effectiveTimeField = value;
        }
    }
    
    /// <remarks/>
    public CE priorityCode {
        get {
            return this.priorityCodeField;
        }
        set {
            this.priorityCodeField = value;
        }
    }
    
    /// <remarks/>
    public CE statusCode {
        get {
            return this.statusCodeField;
        }
        set {
            this.statusCodeField = value;
        }
    }
    
    /// <remarks/>
    public informationRecipient performer {
        get {
            return this.performerField;
        }
        set {
            this.performerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class II {
    
    private string rootField;
    
    private string extensionField;
    
    private string assigningAuthorityNameField;
    
    private bool displayableField;
    
    private bool displayableFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string root {
        get {
            return this.rootField;
        }
        set {
            this.rootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string extension {
        get {
            return this.extensionField;
        }
        set {
            this.extensionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assigningAuthorityName {
        get {
            return this.assigningAuthorityNameField;
        }
        set {
            this.assigningAuthorityNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool displayable {
        get {
            return this.displayableField;
        }
        set {
            this.displayableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool displayableSpecified {
        get {
            return this.displayableFieldSpecified;
        }
        set {
            this.displayableFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class CE {
    
    private string codeField;
    
    private string codeSystemField;
    
    private string codeSystemNameField;
    
    private string codeSystemVersionField;
    
    private string displayNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string codeSystem {
        get {
            return this.codeSystemField;
        }
        set {
            this.codeSystemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemName {
        get {
            return this.codeSystemNameField;
        }
        set {
            this.codeSystemNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string codeSystemVersion {
        get {
            return this.codeSystemVersionField;
        }
        set {
            this.codeSystemVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName {
        get {
            return this.displayNameField;
        }
        set {
            this.displayNameField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(TS_inc))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class TS {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class TS_inc : TS {
    
    private bool inclusiveField;
    
    public TS_inc() {
        this.inclusiveField = true;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool inclusive {
        get {
            return this.inclusiveField;
        }
        set {
            this.inclusiveField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class informationRecipient {
    
    private AssignedPerson assignedPersonField;
    
    private AssignedCustodian assignedCustodianField;
    
    private string typeCodeField;
    
    /// <remarks/>
    public AssignedPerson AssignedPerson {
        get {
            return this.assignedPersonField;
        }
        set {
            this.assignedPersonField = value;
        }
    }
    
    /// <remarks/>
    public AssignedCustodian AssignedCustodian {
        get {
            return this.assignedCustodianField;
        }
        set {
            this.assignedCustodianField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string typeCode {
        get {
            return this.typeCodeField;
        }
        set {
            this.typeCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class AssignedPerson {
    
    private CE codeField;
    
    private Person assignedPersonField;
    
    /// <remarks/>
    public CE code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    public Person assignedPerson {
        get {
            return this.assignedPersonField;
        }
        set {
            this.assignedPersonField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class Person {
    
    private EN nameField;
    
    private LicensedEntity[] licenseField;
    
    /// <remarks/>
    public EN name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("license")]
    public LicensedEntity[] license {
        get {
            return this.licenseField;
        }
        set {
            this.licenseField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class EN {
    
    private string[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    private string[] textField;
    
    private string useField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("delimiter", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("family", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("given", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("prefix", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("suffix", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public string[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string use {
        get {
            return this.useField;
        }
        set {
            this.useField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3", IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    delimiter,
    
    /// <remarks/>
    family,
    
    /// <remarks/>
    given,
    
    /// <remarks/>
    prefix,
    
    /// <remarks/>
    suffix,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class LicensedEntity {
    
    private CE codeField;
    
    /// <remarks/>
    public CE code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class AssignedCustodian {
    
    private Organization organizationField;
    
    /// <remarks/>
    public Organization Organization {
        get {
            return this.organizationField;
        }
        set {
            this.organizationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class Organization {
    
    private II idField;
    
    private CE codeField;
    
    private TEL[] telecomField;
    
    /// <remarks/>
    public II id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public CE code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("telecom")]
    public TEL[] telecom {
        get {
            return this.telecomField;
        }
        set {
            this.telecomField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class TEL {
    
    private string valueField;
    
    private string useField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string use {
        get {
            return this.useField;
        }
        set {
            this.useField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class inFulfillmentOf {
    
    private ServiceEvent orderField;
    
    /// <remarks/>
    public ServiceEvent order {
        get {
            return this.orderField;
        }
        set {
            this.orderField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class PQ {
    
    private string valueField;
    
    private string unitField;
    
    public PQ() {
        this.unitField = "";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    [System.ComponentModel.DefaultValueAttribute("")]
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class IVL_TS {
    
    private object[] itemsField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("center", typeof(TS))]
    [System.Xml.Serialization.XmlElementAttribute("high", typeof(TS_inc))]
    [System.Xml.Serialization.XmlElementAttribute("low", typeof(IVL_TSLow))]
    [System.Xml.Serialization.XmlElementAttribute("width", typeof(PQ))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:hl7-org:v3")]
public partial class IVL_TSLow : TS {
    
    private bool inclusiveField;
    
    public IVL_TSLow() {
        this.inclusiveField = true;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool inclusive {
        get {
            return this.inclusiveField;
        }
        set {
            this.inclusiveField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class EncounterEvent {
    
    private II idField;
    
    private CE codeField;
    
    private IVL_TS effectiveTimeField;
    
    /// <remarks/>
    public II id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public CE code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    public IVL_TS effectiveTime {
        get {
            return this.effectiveTimeField;
        }
        set {
            this.effectiveTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class Component {
    
    private EncounterEvent encounterEventField;
    
    /// <remarks/>
    public EncounterEvent encounterEvent {
        get {
            return this.encounterEventField;
        }
        set {
            this.encounterEventField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class PN {
    
    private string[] itemsField;
    
    private ItemsChoiceType1[] itemsElementNameField;
    
    private string[] textField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("delimiter", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("family", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("given", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("prefix", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("suffix", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public string[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType1[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3", IncludeInSchema=false)]
public enum ItemsChoiceType1 {
    
    /// <remarks/>
    delimiter,
    
    /// <remarks/>
    family,
    
    /// <remarks/>
    given,
    
    /// <remarks/>
    prefix,
    
    /// <remarks/>
    suffix,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class SubjectPerson {
    
    private PN nameField;
    
    private TS birthTimeField;
    
    /// <remarks/>
    public PN name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public TS birthTime {
        get {
            return this.birthTimeField;
        }
        set {
            this.birthTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class SubjectRole {
    
    private CE codeField;
    
    private SubjectPerson documentSubjectField;
    
    private string classCodeField;
    
    /// <remarks/>
    public CE code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    public SubjectPerson documentSubject {
        get {
            return this.documentSubjectField;
        }
        set {
            this.documentSubjectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string classCode {
        get {
            return this.classCodeField;
        }
        set {
            this.classCodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class Subject {
    
    private SubjectRole subjectRoleField;
    
    /// <remarks/>
    public SubjectRole subjectRole {
        get {
            return this.subjectRoleField;
        }
        set {
            this.subjectRoleField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class Custodian {
    
    private AssignedCustodian assignedCustodianField;
    
    /// <remarks/>
    public AssignedCustodian assignedCustodian {
        get {
            return this.assignedCustodianField;
        }
        set {
            this.assignedCustodianField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class AssignedAuthor {
    
    private CE codeField;
    
    /// <remarks/>
    public CE code {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class Author {
    
    private AssignedAuthor assignedAuthorField;
    
    /// <remarks/>
    public AssignedAuthor assignedAuthor {
        get {
            return this.assignedAuthorField;
        }
        set {
            this.assignedAuthorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class Authenticator {
    
    private TS timeField;
    
    private AssignedPerson assignedPersonField;
    
    /// <remarks/>
    public TS time {
        get {
            return this.timeField;
        }
        set {
            this.timeField = value;
        }
    }
    
    /// <remarks/>
    public AssignedPerson AssignedPerson {
        get {
            return this.assignedPersonField;
        }
        set {
            this.assignedPersonField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
public partial class ED {
    
    private EDRepresentation representationField;
    
    private string mediaTypeField;
    
    private string languageField;
    
    private string compressionField;
    
    private EDAttached attachedField;
    
    private byte[] integrityCheckField;
    
    private string integrityCheckAlgorithmField;
    
    private string[] textField;
    
    public ED() {
        this.representationField = EDRepresentation.B64;
        this.attachedField = EDAttached.EMBD;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(EDRepresentation.B64)]
    public EDRepresentation representation {
        get {
            return this.representationField;
        }
        set {
            this.representationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string mediaType {
        get {
            return this.mediaTypeField;
        }
        set {
            this.mediaTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string language {
        get {
            return this.languageField;
        }
        set {
            this.languageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string compression {
        get {
            return this.compressionField;
        }
        set {
            this.compressionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(EDAttached.EMBD)]
    public EDAttached attached {
        get {
            return this.attachedField;
        }
        set {
            this.attachedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="base64Binary")]
    public byte[] integrityCheck {
        get {
            return this.integrityCheckField;
        }
        set {
            this.integrityCheckField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
    public string integrityCheckAlgorithm {
        get {
            return this.integrityCheckAlgorithmField;
        }
        set {
            this.integrityCheckAlgorithmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:hl7-org:v3")]
public enum EDRepresentation {
    
    /// <remarks/>
    B64,
    
    /// <remarks/>
    TXT,
    
    /// <remarks/>
    BIN,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:hl7-org:v3")]
public enum EDAttached {
    
    /// <remarks/>
    EMBD,
    
    /// <remarks/>
    LINK,
}