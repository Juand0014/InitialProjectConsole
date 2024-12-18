﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RCISERVICES
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RCISERVICES.WSOrquestadorSoap")]
    public interface WSOrquestadorSoap
    {
        
        // CODEGEN: Generating message contract since message GetContractRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetContract", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        RCISERVICES.GetContractResponse GetContract(RCISERVICES.GetContractRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetContract", ReplyAction="*")]
        System.Threading.Tasks.Task<RCISERVICES.GetContractResponse> GetContractAsync(RCISERVICES.GetContractRequest request);
        
        // CODEGEN: Generating message contract since message ReportContractsStatusRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReportContractsStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        RCISERVICES.ReportContractsStatusResponse ReportContractsStatus(RCISERVICES.ReportContractsStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReportContractsStatus", ReplyAction="*")]
        System.Threading.Tasks.Task<RCISERVICES.ReportContractsStatusResponse> ReportContractsStatusAsync(RCISERVICES.ReportContractsStatusRequest request);
        
        // CODEGEN: Generating message contract since message GetAccessTokenRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAccessToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        RCISERVICES.GetAccessTokenResponse GetAccessToken(RCISERVICES.GetAccessTokenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAccessToken", ReplyAction="*")]
        System.Threading.Tasks.Task<RCISERVICES.GetAccessTokenResponse> GetAccessTokenAsync(RCISERVICES.GetAccessTokenRequest request);
        
        // CODEGEN: Generating message contract since message GetDepositRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDeposit", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        RCISERVICES.GetDepositResponse GetDeposit(RCISERVICES.GetDepositRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDeposit", ReplyAction="*")]
        System.Threading.Tasks.Task<RCISERVICES.GetDepositResponse> GetDepositAsync(RCISERVICES.GetDepositRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Header_Token_Orchestrator : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string sourceField;
        
        private string userNameField;
        
        private string tokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
                this.RaisePropertyChanged("Source");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
                this.RaisePropertyChanged("Token");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Header_Orchestrator : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string userNameField;
        
        private string passwordField;
        
        private string sourceField;
        
        private string resortIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
                this.RaisePropertyChanged("Source");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ResortID
        {
            get
            {
                return this.resortIDField;
            }
            set
            {
                this.resortIDField = value;
                this.RaisePropertyChanged("ResortID");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetContract", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetContractRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string XMLString;
        
        public GetContractRequest()
        {
        }
        
        public GetContractRequest(RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator, string XMLString)
        {
            this.Header_Token_Orchestrator = Header_Token_Orchestrator;
            this.XMLString = XMLString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetContractResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetContractResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string GetContractResult;
        
        public GetContractResponse()
        {
        }
        
        public GetContractResponse(string GetContractResult)
        {
            this.GetContractResult = GetContractResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReportContractsStatus", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ReportContractsStatusRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int IDTransaction;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string ResortID;
        
        public ReportContractsStatusRequest()
        {
        }
        
        public ReportContractsStatusRequest(RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator, int IDTransaction, string ResortID)
        {
            this.Header_Token_Orchestrator = Header_Token_Orchestrator;
            this.IDTransaction = IDTransaction;
            this.ResortID = ResortID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReportContractsStatusResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ReportContractsStatusResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string ReportContractsStatusResult;
        
        public ReportContractsStatusResponse()
        {
        }
        
        public ReportContractsStatusResponse(string ReportContractsStatusResult)
        {
            this.ReportContractsStatusResult = ReportContractsStatusResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAccessToken", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAccessTokenRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public RCISERVICES.Header_Orchestrator Header_Orchestrator;
        
        public GetAccessTokenRequest()
        {
        }
        
        public GetAccessTokenRequest(RCISERVICES.Header_Orchestrator Header_Orchestrator)
        {
            this.Header_Orchestrator = Header_Orchestrator;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAccessTokenResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAccessTokenResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string GetAccessTokenResult;
        
        public GetAccessTokenResponse()
        {
        }
        
        public GetAccessTokenResponse(string GetAccessTokenResult)
        {
            this.GetAccessTokenResult = GetAccessTokenResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDeposit", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDepositRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string CustomerCPF;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string CustomerName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string ResortId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string UnitName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string StartDate;
        
        public GetDepositRequest()
        {
        }
        
        public GetDepositRequest(RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator, string CustomerCPF, string CustomerName, string ResortId, string UnitName, string StartDate)
        {
            this.Header_Token_Orchestrator = Header_Token_Orchestrator;
            this.CustomerCPF = CustomerCPF;
            this.CustomerName = CustomerName;
            this.ResortId = ResortId;
            this.UnitName = UnitName;
            this.StartDate = StartDate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDepositResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDepositResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string GetDepositResult;
        
        public GetDepositResponse()
        {
        }
        
        public GetDepositResponse(string GetDepositResult)
        {
            this.GetDepositResult = GetDepositResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface WSOrquestadorSoapChannel : RCISERVICES.WSOrquestadorSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class WSOrquestadorSoapClient : System.ServiceModel.ClientBase<RCISERVICES.WSOrquestadorSoap>, RCISERVICES.WSOrquestadorSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WSOrquestadorSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WSOrquestadorSoapClient.GetBindingForEndpoint(endpointConfiguration), WSOrquestadorSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSOrquestadorSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WSOrquestadorSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSOrquestadorSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WSOrquestadorSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSOrquestadorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RCISERVICES.GetContractResponse RCISERVICES.WSOrquestadorSoap.GetContract(RCISERVICES.GetContractRequest request)
        {
            return base.Channel.GetContract(request);
        }
        
        public string GetContract(RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator, string XMLString)
        {
            RCISERVICES.GetContractRequest inValue = new RCISERVICES.GetContractRequest();
            inValue.Header_Token_Orchestrator = Header_Token_Orchestrator;
            inValue.XMLString = XMLString;
            RCISERVICES.GetContractResponse retVal = ((RCISERVICES.WSOrquestadorSoap)(this)).GetContract(inValue);
            return retVal.GetContractResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RCISERVICES.GetContractResponse> RCISERVICES.WSOrquestadorSoap.GetContractAsync(RCISERVICES.GetContractRequest request)
        {
            return base.Channel.GetContractAsync(request);
        }
        
        public System.Threading.Tasks.Task<RCISERVICES.GetContractResponse> GetContractAsync(RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator, string XMLString)
        {
            RCISERVICES.GetContractRequest inValue = new RCISERVICES.GetContractRequest();
            inValue.Header_Token_Orchestrator = Header_Token_Orchestrator;
            inValue.XMLString = XMLString;
            return ((RCISERVICES.WSOrquestadorSoap)(this)).GetContractAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RCISERVICES.ReportContractsStatusResponse RCISERVICES.WSOrquestadorSoap.ReportContractsStatus(RCISERVICES.ReportContractsStatusRequest request)
        {
            return base.Channel.ReportContractsStatus(request);
        }
        
        public string ReportContractsStatus(RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator, int IDTransaction, string ResortID)
        {
            RCISERVICES.ReportContractsStatusRequest inValue = new RCISERVICES.ReportContractsStatusRequest();
            inValue.Header_Token_Orchestrator = Header_Token_Orchestrator;
            inValue.IDTransaction = IDTransaction;
            inValue.ResortID = ResortID;
            RCISERVICES.ReportContractsStatusResponse retVal = ((RCISERVICES.WSOrquestadorSoap)(this)).ReportContractsStatus(inValue);
            return retVal.ReportContractsStatusResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RCISERVICES.ReportContractsStatusResponse> RCISERVICES.WSOrquestadorSoap.ReportContractsStatusAsync(RCISERVICES.ReportContractsStatusRequest request)
        {
            return base.Channel.ReportContractsStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<RCISERVICES.ReportContractsStatusResponse> ReportContractsStatusAsync(RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator, int IDTransaction, string ResortID)
        {
            RCISERVICES.ReportContractsStatusRequest inValue = new RCISERVICES.ReportContractsStatusRequest();
            inValue.Header_Token_Orchestrator = Header_Token_Orchestrator;
            inValue.IDTransaction = IDTransaction;
            inValue.ResortID = ResortID;
            return ((RCISERVICES.WSOrquestadorSoap)(this)).ReportContractsStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RCISERVICES.GetAccessTokenResponse RCISERVICES.WSOrquestadorSoap.GetAccessToken(RCISERVICES.GetAccessTokenRequest request)
        {
            return base.Channel.GetAccessToken(request);
        }
        
        public string GetAccessToken(RCISERVICES.Header_Orchestrator Header_Orchestrator)
        {
            RCISERVICES.GetAccessTokenRequest inValue = new RCISERVICES.GetAccessTokenRequest();
            inValue.Header_Orchestrator = Header_Orchestrator;
            RCISERVICES.GetAccessTokenResponse retVal = ((RCISERVICES.WSOrquestadorSoap)(this)).GetAccessToken(inValue);
            return retVal.GetAccessTokenResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RCISERVICES.GetAccessTokenResponse> RCISERVICES.WSOrquestadorSoap.GetAccessTokenAsync(RCISERVICES.GetAccessTokenRequest request)
        {
            return base.Channel.GetAccessTokenAsync(request);
        }
        
        public System.Threading.Tasks.Task<RCISERVICES.GetAccessTokenResponse> GetAccessTokenAsync(RCISERVICES.Header_Orchestrator Header_Orchestrator)
        {
            RCISERVICES.GetAccessTokenRequest inValue = new RCISERVICES.GetAccessTokenRequest();
            inValue.Header_Orchestrator = Header_Orchestrator;
            return ((RCISERVICES.WSOrquestadorSoap)(this)).GetAccessTokenAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RCISERVICES.GetDepositResponse RCISERVICES.WSOrquestadorSoap.GetDeposit(RCISERVICES.GetDepositRequest request)
        {
            return base.Channel.GetDeposit(request);
        }
        
        public string GetDeposit(RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator, string CustomerCPF, string CustomerName, string ResortId, string UnitName, string StartDate)
        {
            RCISERVICES.GetDepositRequest inValue = new RCISERVICES.GetDepositRequest();
            inValue.Header_Token_Orchestrator = Header_Token_Orchestrator;
            inValue.CustomerCPF = CustomerCPF;
            inValue.CustomerName = CustomerName;
            inValue.ResortId = ResortId;
            inValue.UnitName = UnitName;
            inValue.StartDate = StartDate;
            RCISERVICES.GetDepositResponse retVal = ((RCISERVICES.WSOrquestadorSoap)(this)).GetDeposit(inValue);
            return retVal.GetDepositResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RCISERVICES.GetDepositResponse> RCISERVICES.WSOrquestadorSoap.GetDepositAsync(RCISERVICES.GetDepositRequest request)
        {
            return base.Channel.GetDepositAsync(request);
        }
        
        public System.Threading.Tasks.Task<RCISERVICES.GetDepositResponse> GetDepositAsync(RCISERVICES.Header_Token_Orchestrator Header_Token_Orchestrator, string CustomerCPF, string CustomerName, string ResortId, string UnitName, string StartDate)
        {
            RCISERVICES.GetDepositRequest inValue = new RCISERVICES.GetDepositRequest();
            inValue.Header_Token_Orchestrator = Header_Token_Orchestrator;
            inValue.CustomerCPF = CustomerCPF;
            inValue.CustomerName = CustomerName;
            inValue.ResortId = ResortId;
            inValue.UnitName = UnitName;
            inValue.StartDate = StartDate;
            return ((RCISERVICES.WSOrquestadorSoap)(this)).GetDepositAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WSOrquestadorSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WSOrquestadorSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WSOrquestadorSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://www.rci-nea.com:447/WSOrquestador/WSOrquestador.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WSOrquestadorSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://www.rci-nea.com:447/WSOrquestador/WSOrquestador.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WSOrquestadorSoap,
            
            WSOrquestadorSoap12,
        }
    }
}
