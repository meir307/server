﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace globalsms_api
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="apiGlobalSms", ConfigurationName="globalsms_api.WsSMSSoap")]
    public interface WsSMSSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="apiGlobalSms/getBalance", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> getBalanceAsync(string ApiKey);
        
        [System.ServiceModel.OperationContractAttribute(Action="apiGlobalSms/sendSmsToRecipients", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> sendSmsToRecipientsAsync(string ApiKey, string txtOriginator, string destinations, string txtSMSmessage, string dteToDeliver, string txtAddInf);
        
        [System.ServiceModel.OperationContractAttribute(Action="apiGlobalSms/getFutureDeliveries", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<globalsms_api.getFutureDeliveriesResponseGetFutureDeliveriesResult> getFutureDeliveriesAsync(string ApiKey);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="apiGlobalSms/deleteFutureDelivery", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<globalsms_api.deleteFutureDeliveryResponse> deleteFutureDeliveryAsync(globalsms_api.deleteFutureDeliveryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="apiGlobalSms/getSmsDeliveryStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<globalsms_api.getSmsDeliveryStatusResponseGetSmsDeliveryStatusResult> getSmsDeliveryStatusAsync(string ApiKey, int DAY, int MONTH, int YEAR);
        
        [System.ServiceModel.OperationContractAttribute(Action="apiGlobalSms/getSmsDeliveryStatus_addInf", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<globalsms_api.getSmsDeliveryStatus_addInfResponseGetSmsDeliveryStatus_addInfResult> getSmsDeliveryStatus_addInfAsync(string ApiKey, string addInfs);
        
        [System.ServiceModel.OperationContractAttribute(Action="apiGlobalSms/getSmsResponses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<globalsms_api.getSmsResponsesResponseGetSmsResponsesResult> getSmsResponsesAsync(string ApiKey, int DAY, int MONTH, int YEAR, int lastResponseID);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="apiGlobalSms")]
    public partial class getFutureDeliveriesResponseGetFutureDeliveriesResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteFutureDelivery", WrapperNamespace="apiGlobalSms", IsWrapped=true)]
    public partial class deleteFutureDeliveryRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="apiGlobalSms", Order=0)]
        public string ApiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="apiGlobalSms", Order=1)]
        public string txtAddInf;
        
        public deleteFutureDeliveryRequest()
        {
        }
        
        public deleteFutureDeliveryRequest(string ApiKey, string txtAddInf)
        {
            this.ApiKey = ApiKey;
            this.txtAddInf = txtAddInf;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="deleteFutureDeliveryResponse", WrapperNamespace="apiGlobalSms", IsWrapped=true)]
    public partial class deleteFutureDeliveryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="apiGlobalSms", Order=0)]
        public string deleteFutureDeliveryResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="apiGlobalSms", Order=1)]
        public string txtAddInf;
        
        public deleteFutureDeliveryResponse()
        {
        }
        
        public deleteFutureDeliveryResponse(string deleteFutureDeliveryResult, string txtAddInf)
        {
            this.deleteFutureDeliveryResult = deleteFutureDeliveryResult;
            this.txtAddInf = txtAddInf;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="apiGlobalSms")]
    public partial class getSmsDeliveryStatusResponseGetSmsDeliveryStatusResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="apiGlobalSms")]
    public partial class getSmsDeliveryStatus_addInfResponseGetSmsDeliveryStatus_addInfResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="apiGlobalSms")]
    public partial class getSmsResponsesResponseGetSmsResponsesResult
    {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.XmlElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface WsSMSSoapChannel : globalsms_api.WsSMSSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class WsSMSSoapClient : System.ServiceModel.ClientBase<globalsms_api.WsSMSSoap>, globalsms_api.WsSMSSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WsSMSSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WsSMSSoapClient.GetBindingForEndpoint(endpointConfiguration), WsSMSSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsSMSSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WsSMSSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsSMSSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WsSMSSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsSMSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> getBalanceAsync(string ApiKey)
        {
            return base.Channel.getBalanceAsync(ApiKey);
        }
        
        public System.Threading.Tasks.Task<string> sendSmsToRecipientsAsync(string ApiKey, string txtOriginator, string destinations, string txtSMSmessage, string dteToDeliver, string txtAddInf)
        {
            return base.Channel.sendSmsToRecipientsAsync(ApiKey, txtOriginator, destinations, txtSMSmessage, dteToDeliver, txtAddInf);
        }
        
        public System.Threading.Tasks.Task<globalsms_api.getFutureDeliveriesResponseGetFutureDeliveriesResult> getFutureDeliveriesAsync(string ApiKey)
        {
            return base.Channel.getFutureDeliveriesAsync(ApiKey);
        }
        
        public System.Threading.Tasks.Task<globalsms_api.deleteFutureDeliveryResponse> deleteFutureDeliveryAsync(globalsms_api.deleteFutureDeliveryRequest request)
        {
            return base.Channel.deleteFutureDeliveryAsync(request);
        }
        
        public System.Threading.Tasks.Task<globalsms_api.getSmsDeliveryStatusResponseGetSmsDeliveryStatusResult> getSmsDeliveryStatusAsync(string ApiKey, int DAY, int MONTH, int YEAR)
        {
            return base.Channel.getSmsDeliveryStatusAsync(ApiKey, DAY, MONTH, YEAR);
        }
        
        public System.Threading.Tasks.Task<globalsms_api.getSmsDeliveryStatus_addInfResponseGetSmsDeliveryStatus_addInfResult> getSmsDeliveryStatus_addInfAsync(string ApiKey, string addInfs)
        {
            return base.Channel.getSmsDeliveryStatus_addInfAsync(ApiKey, addInfs);
        }
        
        public System.Threading.Tasks.Task<globalsms_api.getSmsResponsesResponseGetSmsResponsesResult> getSmsResponsesAsync(string ApiKey, int DAY, int MONTH, int YEAR, int lastResponseID)
        {
            return base.Channel.getSmsResponsesAsync(ApiKey, DAY, MONTH, YEAR, lastResponseID);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WsSMSSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WsSMSSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WsSMSSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://api.itnewsletter.co.il/webservices/wssms.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WsSMSSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://api.itnewsletter.co.il/webservices/wssms.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WsSMSSoap,
            
            WsSMSSoap12,
        }
    }
}
