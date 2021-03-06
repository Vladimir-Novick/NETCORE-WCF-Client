﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace ServiceReference1
{
    using System.Runtime.Serialization;
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SayHelloRequest", Namespace="http://schemas.datacontract.org/2004/07/Service.Contract")]
    public partial class SayHelloRequest : object
    {
        private string NameField;
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SayHelloResponse", Namespace="http://schemas.datacontract.org/2004/07/Service.Contract")]
    public partial class SayHelloResponse : object
    {
        private string HelloMessageField;
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HelloMessage
        {
            get
            {
                return this.HelloMessageField;
            }
            set
            {
                this.HelloMessageField = value;
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISayHelloService")]
    public interface ISayHelloService
    {
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISayHelloService/SayHello", ReplyAction="http://tempuri.org/ISayHelloService/SayHelloResponse")]
        System.Threading.Tasks.Task<ServiceReference1.SayHelloResponse> SayHelloAsync(ServiceReference1.SayHelloRequest request);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISayHelloService/SampleMethod", ReplyAction="http://tempuri.org/ISayHelloService/SampleMethodResponse")]
        System.Threading.Tasks.Task<string> SampleMethodAsync(string msg);
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISayHelloService/ServiceAsyncMethod", ReplyAction="http://tempuri.org/ISayHelloService/ServiceAsyncMethodResponse")]
        System.Threading.Tasks.Task<string> ServiceAsyncMethodAsync(string msg);
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface ISayHelloServiceChannel : ServiceReference1.ISayHelloService, System.ServiceModel.IClientChannel
    {
    }
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class SayHelloServiceClient : System.ServiceModel.ClientBase<ServiceReference1.ISayHelloService>, ServiceReference1.ISayHelloService
    {
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        public SayHelloServiceClient() : 
                base(SayHelloServiceClient.GetDefaultBinding(), SayHelloServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISayHelloService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        public SayHelloServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SayHelloServiceClient.GetBindingForEndpoint(endpointConfiguration), SayHelloServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        public SayHelloServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SayHelloServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        public SayHelloServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SayHelloServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        public SayHelloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        public System.Threading.Tasks.Task<ServiceReference1.SayHelloResponse> SayHelloAsync(ServiceReference1.SayHelloRequest request)
        {
            return base.Channel.SayHelloAsync(request);
        }
        public System.Threading.Tasks.Task<string> SampleMethodAsync(string msg)
        {
            return base.Channel.SampleMethodAsync(msg);
        }
        public System.Threading.Tasks.Task<string> ServiceAsyncMethodAsync(string msg)
        {
            return base.Channel.ServiceAsyncMethodAsync(msg);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISayHelloService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISayHelloService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:50703/SayHelloService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SayHelloServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISayHelloService);
        }
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SayHelloServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISayHelloService);
        }
        public enum EndpointConfiguration
        {
            BasicHttpBinding_ISayHelloService,
        }
    }
}
