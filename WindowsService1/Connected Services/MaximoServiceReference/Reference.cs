﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsService1.MaximoServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ibm.com/maximo/wsdl/SAGE_CCINTMXSUPPLIERS", ConfigurationName="MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortType")]
    public interface SAGE_CCINTMXSUPPLIERSPortType {
        
        // CODEGEN: Generating message contract since the operation SyncCCINTMXVENDOR is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="urn:processDocument", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORResponse SyncCCINTMXVENDOR(WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:processDocument", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORResponse> SyncCCINTMXVENDORAsync(WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ibm.com/maximo")]
    public partial class SyncCCINTMXVENDORType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private CCINTMXVENDOR_COMPANIESType[] cCINTMXVENDORSetField;
        
        private System.DateTime creationDateTimeField;
        
        private bool creationDateTimeFieldSpecified;
        
        private string baseLanguageField;
        
        private string transLanguageField;
        
        private string messageIDField;
        
        private string maximoVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("COMPANIES", IsNullable=false)]
        public CCINTMXVENDOR_COMPANIESType[] CCINTMXVENDORSet {
            get {
                return this.cCINTMXVENDORSetField;
            }
            set {
                this.cCINTMXVENDORSetField = value;
                this.RaisePropertyChanged("CCINTMXVENDORSet");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime creationDateTime {
            get {
                return this.creationDateTimeField;
            }
            set {
                this.creationDateTimeField = value;
                this.RaisePropertyChanged("creationDateTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creationDateTimeSpecified {
            get {
                return this.creationDateTimeFieldSpecified;
            }
            set {
                this.creationDateTimeFieldSpecified = value;
                this.RaisePropertyChanged("creationDateTimeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string baseLanguage {
            get {
                return this.baseLanguageField;
            }
            set {
                this.baseLanguageField = value;
                this.RaisePropertyChanged("baseLanguage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transLanguage {
            get {
                return this.transLanguageField;
            }
            set {
                this.transLanguageField = value;
                this.RaisePropertyChanged("transLanguage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string messageID {
            get {
                return this.messageIDField;
            }
            set {
                this.messageIDField = value;
                this.RaisePropertyChanged("messageID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maximoVersion {
            get {
                return this.maximoVersionField;
            }
            set {
                this.maximoVersionField = value;
                this.RaisePropertyChanged("maximoVersion");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ibm.com/maximo")]
    public partial class CCINTMXVENDOR_COMPANIESType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string mAXINTERRORMSGField;
        
        private MXStringType aDDRESS1Field;
        
        private MXStringType aDDRESS2Field;
        
        private MXStringType aDDRESS3Field;
        
        private MXStringType aDDRESS4Field;
        
        private MXStringType cOMPANYField;
        
        private MXStringType cONTACTField;
        
        private MXStringType cURRENCYCODEField;
        
        private MXBooleanType dISABLEDField;
        
        private MXStringType fREIGHTTERMS_LONGDESCRIPTIONField;
        
        private MXStringType hOMEPAGEField;
        
        private MXLangStringType nAMEField;
        
        private MXLangStringType nAME_LONGDESCRIPTIONField;
        
        private MXStringType oRGIDField;
        
        private MXStringType pHONEField;
        
        private MXDomainType tYPEField;
        
        private CCINTMXVENDOR_COMPCONTACTType[] cOMPCONTACTField;
        
        private ProcessingActionType actionField;
        
        private bool actionFieldSpecified;
        
        private string relationshipField;
        
        private string deleteForInsertField;
        
        private string transLanguageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string MAXINTERRORMSG {
            get {
                return this.mAXINTERRORMSGField;
            }
            set {
                this.mAXINTERRORMSGField = value;
                this.RaisePropertyChanged("MAXINTERRORMSG");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public MXStringType ADDRESS1 {
            get {
                return this.aDDRESS1Field;
            }
            set {
                this.aDDRESS1Field = value;
                this.RaisePropertyChanged("ADDRESS1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public MXStringType ADDRESS2 {
            get {
                return this.aDDRESS2Field;
            }
            set {
                this.aDDRESS2Field = value;
                this.RaisePropertyChanged("ADDRESS2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public MXStringType ADDRESS3 {
            get {
                return this.aDDRESS3Field;
            }
            set {
                this.aDDRESS3Field = value;
                this.RaisePropertyChanged("ADDRESS3");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public MXStringType ADDRESS4 {
            get {
                return this.aDDRESS4Field;
            }
            set {
                this.aDDRESS4Field = value;
                this.RaisePropertyChanged("ADDRESS4");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public MXStringType COMPANY {
            get {
                return this.cOMPANYField;
            }
            set {
                this.cOMPANYField = value;
                this.RaisePropertyChanged("COMPANY");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public MXStringType CONTACT {
            get {
                return this.cONTACTField;
            }
            set {
                this.cONTACTField = value;
                this.RaisePropertyChanged("CONTACT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public MXStringType CURRENCYCODE {
            get {
                return this.cURRENCYCODEField;
            }
            set {
                this.cURRENCYCODEField = value;
                this.RaisePropertyChanged("CURRENCYCODE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public MXBooleanType DISABLED {
            get {
                return this.dISABLEDField;
            }
            set {
                this.dISABLEDField = value;
                this.RaisePropertyChanged("DISABLED");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public MXStringType FREIGHTTERMS_LONGDESCRIPTION {
            get {
                return this.fREIGHTTERMS_LONGDESCRIPTIONField;
            }
            set {
                this.fREIGHTTERMS_LONGDESCRIPTIONField = value;
                this.RaisePropertyChanged("FREIGHTTERMS_LONGDESCRIPTION");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public MXStringType HOMEPAGE {
            get {
                return this.hOMEPAGEField;
            }
            set {
                this.hOMEPAGEField = value;
                this.RaisePropertyChanged("HOMEPAGE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public MXLangStringType NAME {
            get {
                return this.nAMEField;
            }
            set {
                this.nAMEField = value;
                this.RaisePropertyChanged("NAME");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public MXLangStringType NAME_LONGDESCRIPTION {
            get {
                return this.nAME_LONGDESCRIPTIONField;
            }
            set {
                this.nAME_LONGDESCRIPTIONField = value;
                this.RaisePropertyChanged("NAME_LONGDESCRIPTION");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public MXStringType ORGID {
            get {
                return this.oRGIDField;
            }
            set {
                this.oRGIDField = value;
                this.RaisePropertyChanged("ORGID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public MXStringType PHONE {
            get {
                return this.pHONEField;
            }
            set {
                this.pHONEField = value;
                this.RaisePropertyChanged("PHONE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public MXDomainType TYPE {
            get {
                return this.tYPEField;
            }
            set {
                this.tYPEField = value;
                this.RaisePropertyChanged("TYPE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("COMPCONTACT", Order=16)]
        public CCINTMXVENDOR_COMPCONTACTType[] COMPCONTACT {
            get {
                return this.cOMPCONTACTField;
            }
            set {
                this.cOMPCONTACTField = value;
                this.RaisePropertyChanged("COMPCONTACT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ProcessingActionType action {
            get {
                return this.actionField;
            }
            set {
                this.actionField = value;
                this.RaisePropertyChanged("action");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified {
            get {
                return this.actionFieldSpecified;
            }
            set {
                this.actionFieldSpecified = value;
                this.RaisePropertyChanged("actionSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
                this.RaisePropertyChanged("relationship");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deleteForInsert {
            get {
                return this.deleteForInsertField;
            }
            set {
                this.deleteForInsertField = value;
                this.RaisePropertyChanged("deleteForInsert");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transLanguage {
            get {
                return this.transLanguageField;
            }
            set {
                this.transLanguageField = value;
                this.RaisePropertyChanged("transLanguage");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ibm.com/maximo")]
    public partial class MXStringType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool changedField;
        
        private bool changedFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool changed {
            get {
                return this.changedField;
            }
            set {
                this.changedField = value;
                this.RaisePropertyChanged("changed");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool changedSpecified {
            get {
                return this.changedFieldSpecified;
            }
            set {
                this.changedFieldSpecified = value;
                this.RaisePropertyChanged("changedSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ibm.com/maximo")]
    public partial class SyncCCINTMXVENDORResponseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.DateTime creationDateTimeField;
        
        private bool creationDateTimeFieldSpecified;
        
        private string baseLanguageField;
        
        private string transLanguageField;
        
        private string messageIDField;
        
        private string maximoVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime creationDateTime {
            get {
                return this.creationDateTimeField;
            }
            set {
                this.creationDateTimeField = value;
                this.RaisePropertyChanged("creationDateTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool creationDateTimeSpecified {
            get {
                return this.creationDateTimeFieldSpecified;
            }
            set {
                this.creationDateTimeFieldSpecified = value;
                this.RaisePropertyChanged("creationDateTimeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string baseLanguage {
            get {
                return this.baseLanguageField;
            }
            set {
                this.baseLanguageField = value;
                this.RaisePropertyChanged("baseLanguage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transLanguage {
            get {
                return this.transLanguageField;
            }
            set {
                this.transLanguageField = value;
                this.RaisePropertyChanged("transLanguage");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string messageID {
            get {
                return this.messageIDField;
            }
            set {
                this.messageIDField = value;
                this.RaisePropertyChanged("messageID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maximoVersion {
            get {
                return this.maximoVersionField;
            }
            set {
                this.maximoVersionField = value;
                this.RaisePropertyChanged("maximoVersion");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ibm.com/maximo")]
    public partial class CCINTMXVENDOR_COMPCONTACTType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private MXStringType cONTACTField;
        
        private MXStringType eMAILField;
        
        private MXStringType pOSITIONField;
        
        private MXStringType vOICEPHONEField;
        
        private ProcessingActionType actionField;
        
        private bool actionFieldSpecified;
        
        private string relationshipField;
        
        private string deleteForInsertField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public MXStringType CONTACT {
            get {
                return this.cONTACTField;
            }
            set {
                this.cONTACTField = value;
                this.RaisePropertyChanged("CONTACT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public MXStringType EMAIL {
            get {
                return this.eMAILField;
            }
            set {
                this.eMAILField = value;
                this.RaisePropertyChanged("EMAIL");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public MXStringType POSITION {
            get {
                return this.pOSITIONField;
            }
            set {
                this.pOSITIONField = value;
                this.RaisePropertyChanged("POSITION");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public MXStringType VOICEPHONE {
            get {
                return this.vOICEPHONEField;
            }
            set {
                this.vOICEPHONEField = value;
                this.RaisePropertyChanged("VOICEPHONE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ProcessingActionType action {
            get {
                return this.actionField;
            }
            set {
                this.actionField = value;
                this.RaisePropertyChanged("action");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified {
            get {
                return this.actionFieldSpecified;
            }
            set {
                this.actionFieldSpecified = value;
                this.RaisePropertyChanged("actionSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relationship {
            get {
                return this.relationshipField;
            }
            set {
                this.relationshipField = value;
                this.RaisePropertyChanged("relationship");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deleteForInsert {
            get {
                return this.deleteForInsertField;
            }
            set {
                this.deleteForInsertField = value;
                this.RaisePropertyChanged("deleteForInsert");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ibm.com/maximo")]
    public enum ProcessingActionType {
        
        /// <remarks/>
        Add,
        
        /// <remarks/>
        Change,
        
        /// <remarks/>
        Replace,
        
        /// <remarks/>
        Delete,
        
        /// <remarks/>
        AddChange,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ibm.com/maximo")]
    public partial class MXDomainType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string maxvalueField;
        
        private bool changedField;
        
        private bool changedFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maxvalue {
            get {
                return this.maxvalueField;
            }
            set {
                this.maxvalueField = value;
                this.RaisePropertyChanged("maxvalue");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool changed {
            get {
                return this.changedField;
            }
            set {
                this.changedField = value;
                this.RaisePropertyChanged("changed");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool changedSpecified {
            get {
                return this.changedFieldSpecified;
            }
            set {
                this.changedFieldSpecified = value;
                this.RaisePropertyChanged("changedSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ibm.com/maximo")]
    public partial class MXLangStringType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool changedField;
        
        private bool changedFieldSpecified;
        
        private bool languageEnabledField;
        
        private bool languageEnabledFieldSpecified;
        
        private string valueField;
        
        public MXLangStringType() {
            this.languageEnabledField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool changed {
            get {
                return this.changedField;
            }
            set {
                this.changedField = value;
                this.RaisePropertyChanged("changed");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool changedSpecified {
            get {
                return this.changedFieldSpecified;
            }
            set {
                this.changedFieldSpecified = value;
                this.RaisePropertyChanged("changedSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool languageEnabled {
            get {
                return this.languageEnabledField;
            }
            set {
                this.languageEnabledField = value;
                this.RaisePropertyChanged("languageEnabled");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool languageEnabledSpecified {
            get {
                return this.languageEnabledFieldSpecified;
            }
            set {
                this.languageEnabledFieldSpecified = value;
                this.RaisePropertyChanged("languageEnabledSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ibm.com/maximo")]
    public partial class MXBooleanType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool changedField;
        
        private bool changedFieldSpecified;
        
        private bool valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool changed {
            get {
                return this.changedField;
            }
            set {
                this.changedField = value;
                this.RaisePropertyChanged("changed");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool changedSpecified {
            get {
                return this.changedFieldSpecified;
            }
            set {
                this.changedFieldSpecified = value;
                this.RaisePropertyChanged("changedSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SyncCCINTMXVENDORRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.ibm.com/maximo", Order=0)]
        public WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORType SyncCCINTMXVENDOR;
        
        public SyncCCINTMXVENDORRequest() {
        }
        
        public SyncCCINTMXVENDORRequest(WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORType SyncCCINTMXVENDOR) {
            this.SyncCCINTMXVENDOR = SyncCCINTMXVENDOR;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SyncCCINTMXVENDORResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SyncCCINTMXVENDORResponse", Namespace="http://www.ibm.com/maximo", Order=0)]
        public WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORResponseType SyncCCINTMXVENDORResponse1;
        
        public SyncCCINTMXVENDORResponse() {
        }
        
        public SyncCCINTMXVENDORResponse(WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORResponseType SyncCCINTMXVENDORResponse1) {
            this.SyncCCINTMXVENDORResponse1 = SyncCCINTMXVENDORResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SAGE_CCINTMXSUPPLIERSPortTypeChannel : WindowsService1.MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SAGE_CCINTMXSUPPLIERSPortTypeClient : System.ServiceModel.ClientBase<WindowsService1.MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortType>, WindowsService1.MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortType {
        
        public SAGE_CCINTMXSUPPLIERSPortTypeClient() {
        }
        
        public SAGE_CCINTMXSUPPLIERSPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SAGE_CCINTMXSUPPLIERSPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SAGE_CCINTMXSUPPLIERSPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SAGE_CCINTMXSUPPLIERSPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORResponse WindowsService1.MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortType.SyncCCINTMXVENDOR(WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORRequest request) {
            return base.Channel.SyncCCINTMXVENDOR(request);
        }
        
        public WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORResponseType SyncCCINTMXVENDOR(WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORType SyncCCINTMXVENDOR1) {
            WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORRequest inValue = new WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORRequest();
            inValue.SyncCCINTMXVENDOR = SyncCCINTMXVENDOR1;
            WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORResponse retVal = ((WindowsService1.MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortType)(this)).SyncCCINTMXVENDOR(inValue);
            return retVal.SyncCCINTMXVENDORResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORResponse> WindowsService1.MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortType.SyncCCINTMXVENDORAsync(WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORRequest request) {
            return base.Channel.SyncCCINTMXVENDORAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORResponse> SyncCCINTMXVENDORAsync(WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORType SyncCCINTMXVENDOR) {
            WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORRequest inValue = new WindowsService1.MaximoServiceReference.SyncCCINTMXVENDORRequest();
            inValue.SyncCCINTMXVENDOR = SyncCCINTMXVENDOR;
            return ((WindowsService1.MaximoServiceReference.SAGE_CCINTMXSUPPLIERSPortType)(this)).SyncCCINTMXVENDORAsync(inValue);
        }
    }
}
