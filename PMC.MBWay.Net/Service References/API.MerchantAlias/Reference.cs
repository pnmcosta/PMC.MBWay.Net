﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMC.MBWay.Net.API.MerchantAlias {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/", ConfigurationName="API.MerchantAlias.MerchantAliasWSCreate")]
    public interface MerchantAliasWSCreate {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://alias.services.merchant.channelmanagermsp.sibs/MerchantAliasWS/createMerch" +
            "antAliasRequest", ReplyAction="http://alias.services.merchant.channelmanagermsp.sibs/MerchantAliasWS/createMerch" +
            "antAliasResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasResponse createMerchantAlias(PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasRequest1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/")]
    public partial class createMerchantAliasRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageTypeField;
        
        private alias aliasField;
        
        private merchant merchantField;
        
        private messageProperties messagePropertiesField;
        
        private alias newAliasField;
        
        public createMerchantAliasRequest() {
            this.messageTypeField = "N0001";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string messageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
                this.RaisePropertyChanged("messageType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public alias alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
                this.RaisePropertyChanged("alias");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public merchant merchant {
            get {
                return this.merchantField;
            }
            set {
                this.merchantField = value;
                this.RaisePropertyChanged("merchant");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public messageProperties messageProperties {
            get {
                return this.messagePropertiesField;
            }
            set {
                this.messagePropertiesField = value;
                this.RaisePropertyChanged("messageProperties");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public alias newAlias {
            get {
                return this.newAliasField;
            }
            set {
                this.newAliasField = value;
                this.RaisePropertyChanged("newAlias");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/")]
    public partial class alias : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string aliasNameField;
        
        private string aliasTypeCdeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string aliasName {
            get {
                return this.aliasNameField;
            }
            set {
                this.aliasNameField = value;
                this.RaisePropertyChanged("aliasName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string aliasTypeCde {
            get {
                return this.aliasTypeCdeField;
            }
            set {
                this.aliasTypeCdeField = value;
                this.RaisePropertyChanged("aliasTypeCde");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/")]
    public partial class removeMerchantAliasResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private alias aliasField;
        
        private string statusCodeField;
        
        private System.DateTime timestampField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public alias alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
                this.RaisePropertyChanged("alias");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("statusCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/")]
    public partial class removeMerchantAliasRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageTypeField;
        
        private alias aliasField;
        
        private merchant merchantField;
        
        private messageProperties messagePropertiesField;
        
        public removeMerchantAliasRequest() {
            this.messageTypeField = "N0002";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string messageType {
            get {
                return this.messageTypeField;
            }
            set {
                this.messageTypeField = value;
                this.RaisePropertyChanged("messageType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public alias alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
                this.RaisePropertyChanged("alias");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public merchant merchant {
            get {
                return this.merchantField;
            }
            set {
                this.merchantField = value;
                this.RaisePropertyChanged("merchant");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public messageProperties messageProperties {
            get {
                return this.messagePropertiesField;
            }
            set {
                this.messagePropertiesField = value;
                this.RaisePropertyChanged("messageProperties");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/")]
    public partial class merchant : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string iPAddressField;
        
        private string posIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string iPAddress {
            get {
                return this.iPAddressField;
            }
            set {
                this.iPAddressField = value;
                this.RaisePropertyChanged("iPAddress");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string posId {
            get {
                return this.posIdField;
            }
            set {
                this.posIdField = value;
                this.RaisePropertyChanged("posId");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/")]
    public partial class messageProperties : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string channelField;
        
        private string apiVersionField;
        
        private string channelTypeCodeField;
        
        private string networkCodeField;
        
        private string serviceTypeField;
        
        private System.DateTime timestampField;
        
        public messageProperties() {
            this.channelField = "01";
            this.apiVersionField = "1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string channel {
            get {
                return this.channelField;
            }
            set {
                this.channelField = value;
                this.RaisePropertyChanged("channel");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string apiVersion {
            get {
                return this.apiVersionField;
            }
            set {
                this.apiVersionField = value;
                this.RaisePropertyChanged("apiVersion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string channelTypeCode {
            get {
                return this.channelTypeCodeField;
            }
            set {
                this.channelTypeCodeField = value;
                this.RaisePropertyChanged("channelTypeCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string networkCode {
            get {
                return this.networkCodeField;
            }
            set {
                this.networkCodeField = value;
                this.RaisePropertyChanged("networkCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string serviceType {
            get {
                return this.serviceTypeField;
            }
            set {
                this.serviceTypeField = value;
                this.RaisePropertyChanged("serviceType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/")]
    public partial class createMerchantAliasResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private alias aliasField;
        
        private string operationIdField;
        
        private string statusCodeField;
        
        private System.DateTime timestampField;
        
        private string tokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public alias alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
                this.RaisePropertyChanged("alias");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string operationId {
            get {
                return this.operationIdField;
            }
            set {
                this.operationIdField = value;
                this.RaisePropertyChanged("operationId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("statusCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
                this.RaisePropertyChanged("token");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="createMerchantAlias", WrapperNamespace="http://alias.services.merchant.channelmanagermsp.sibs/", IsWrapped=true)]
    public partial class createMerchantAliasRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasRequest arg0;
        
        public createMerchantAliasRequest1() {
        }
        
        public createMerchantAliasRequest1(PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasRequest arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createMerchantAliasResponse", WrapperNamespace="http://alias.services.merchant.channelmanagermsp.sibs/", IsWrapped=true)]
    public partial class createMerchantAliasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasResult @return;
        
        public createMerchantAliasResponse() {
        }
        
        public createMerchantAliasResponse(PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasResult @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MerchantAliasWSCreateChannel : PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSCreate, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MerchantAliasWSCreateClient : System.ServiceModel.ClientBase<PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSCreate>, PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSCreate {
        
        public MerchantAliasWSCreateClient() {
        }
        
        public MerchantAliasWSCreateClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MerchantAliasWSCreateClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MerchantAliasWSCreateClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MerchantAliasWSCreateClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasResponse PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSCreate.createMerchantAlias(PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasRequest1 request) {
            return base.Channel.createMerchantAlias(request);
        }
        
        public PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasResult createMerchantAlias(PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasRequest arg0) {
            PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasRequest1 inValue = new PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasRequest1();
            inValue.arg0 = arg0;
            PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasResponse retVal = ((PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSCreate)(this)).createMerchantAlias(inValue);
            return retVal.@return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/", ConfigurationName="API.MerchantAlias.MerchantAliasWSRemove")]
    public interface MerchantAliasWSRemove {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://alias.services.merchant.channelmanagermsp.sibs/MerchantAliasWS/removeMerch" +
            "antAliasRequest", ReplyAction="http://alias.services.merchant.channelmanagermsp.sibs/MerchantAliasWS/removeMerch" +
            "antAliasResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasResponse removeMerchantAlias(PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="removeMerchantAlias", WrapperNamespace="http://alias.services.merchant.channelmanagermsp.sibs/", IsWrapped=true)]
    public partial class removeMerchantAliasRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasRequest arg0;
        
        public removeMerchantAliasRequest1() {
        }
        
        public removeMerchantAliasRequest1(PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasRequest arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="removeMerchantAliasResponse", WrapperNamespace="http://alias.services.merchant.channelmanagermsp.sibs/", IsWrapped=true)]
    public partial class removeMerchantAliasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://alias.services.merchant.channelmanagermsp.sibs/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasResult @return;
        
        public removeMerchantAliasResponse() {
        }
        
        public removeMerchantAliasResponse(PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasResult @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MerchantAliasWSRemoveChannel : PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSRemove, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MerchantAliasWSRemoveClient : System.ServiceModel.ClientBase<PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSRemove>, PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSRemove {
        
        public MerchantAliasWSRemoveClient() {
        }
        
        public MerchantAliasWSRemoveClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MerchantAliasWSRemoveClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MerchantAliasWSRemoveClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MerchantAliasWSRemoveClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasResponse PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSRemove.removeMerchantAlias(PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasRequest1 request) {
            return base.Channel.removeMerchantAlias(request);
        }
        
        public PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasResult removeMerchantAlias(PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasRequest arg0) {
            PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasRequest1 inValue = new PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasRequest1();
            inValue.arg0 = arg0;
            PMC.MBWay.Net.API.MerchantAlias.removeMerchantAliasResponse retVal = ((PMC.MBWay.Net.API.MerchantAlias.MerchantAliasWSRemove)(this)).removeMerchantAlias(inValue);
            return retVal.@return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.sibsmerchant.com/", ConfigurationName="API.MerchantAlias.CreateMerchantAliasAsyncResult")]
    public interface CreateMerchantAliasAsyncResult {
        
        // CODEGEN: Parameter 'arg0' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.sibsmerchant.com/CreateMerchantAliasAsyncResult/createAliasRes" +
            "ultRequest", ReplyAction="http://webservices.sibsmerchant.com/CreateMerchantAliasAsyncResult/createAliasRes" +
            "ultResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        PMC.MBWay.Net.API.MerchantAlias.createAliasResultResponse createAliasResult(PMC.MBWay.Net.API.MerchantAlias.createAliasResultRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createAliasResult", WrapperNamespace="http://webservices.sibsmerchant.com/", IsWrapped=true)]
    public partial class createAliasResultRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.sibsmerchant.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasResult arg0;
        
        public createAliasResultRequest() {
        }
        
        public createAliasResultRequest(PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasResult arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createAliasResultResponse", WrapperNamespace="http://webservices.sibsmerchant.com/", IsWrapped=true)]
    public partial class createAliasResultResponse {
        
        public createAliasResultResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CreateMerchantAliasAsyncResultChannel : PMC.MBWay.Net.API.MerchantAlias.CreateMerchantAliasAsyncResult, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateMerchantAliasAsyncResultClient : System.ServiceModel.ClientBase<PMC.MBWay.Net.API.MerchantAlias.CreateMerchantAliasAsyncResult>, PMC.MBWay.Net.API.MerchantAlias.CreateMerchantAliasAsyncResult {
        
        public CreateMerchantAliasAsyncResultClient() {
        }
        
        public CreateMerchantAliasAsyncResultClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreateMerchantAliasAsyncResultClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateMerchantAliasAsyncResultClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateMerchantAliasAsyncResultClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PMC.MBWay.Net.API.MerchantAlias.createAliasResultResponse PMC.MBWay.Net.API.MerchantAlias.CreateMerchantAliasAsyncResult.createAliasResult(PMC.MBWay.Net.API.MerchantAlias.createAliasResultRequest request) {
            return base.Channel.createAliasResult(request);
        }
        
        public void createAliasResult(PMC.MBWay.Net.API.MerchantAlias.createMerchantAliasResult arg0) {
            PMC.MBWay.Net.API.MerchantAlias.createAliasResultRequest inValue = new PMC.MBWay.Net.API.MerchantAlias.createAliasResultRequest();
            inValue.arg0 = arg0;
            PMC.MBWay.Net.API.MerchantAlias.createAliasResultResponse retVal = ((PMC.MBWay.Net.API.MerchantAlias.CreateMerchantAliasAsyncResult)(this)).createAliasResult(inValue);
        }
    }
}
