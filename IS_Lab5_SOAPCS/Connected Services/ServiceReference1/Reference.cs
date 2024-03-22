﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://soapsoapsoap.com/", ConfigurationName="ServiceReference1.MyFirstSOAPInterface")]
    public interface MyFirstSOAPInterface
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://soapsoapsoap.com/MyFirstSOAPInterface/getDaysBetweenDatesRequest", ReplyAction="http://soapsoapsoap.com/MyFirstSOAPInterface/getDaysBetweenDatesResponse")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<long> getDaysBetweenDatesAsync(string arg0, string arg1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://soapsoapsoap.com/MyFirstSOAPInterface/getHelloWorldAsStringRequest", ReplyAction="http://soapsoapsoap.com/MyFirstSOAPInterface/getHelloWorldAsStringResponse")]
        [System.ServiceModel.DataContractFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getHelloWorldAsStringAsync(string arg0);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface MyFirstSOAPInterfaceChannel : ServiceReference1.MyFirstSOAPInterface, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class MyFirstSOAPInterfaceClient : System.ServiceModel.ClientBase<ServiceReference1.MyFirstSOAPInterface>, ServiceReference1.MyFirstSOAPInterface
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MyFirstSOAPInterfaceClient() : 
                base(MyFirstSOAPInterfaceClient.GetDefaultBinding(), MyFirstSOAPInterfaceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.MyFirstWebServicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyFirstSOAPInterfaceClient(EndpointConfiguration endpointConfiguration) : 
                base(MyFirstSOAPInterfaceClient.GetBindingForEndpoint(endpointConfiguration), MyFirstSOAPInterfaceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyFirstSOAPInterfaceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MyFirstSOAPInterfaceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyFirstSOAPInterfaceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MyFirstSOAPInterfaceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MyFirstSOAPInterfaceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<long> getDaysBetweenDatesAsync(string arg0, string arg1)
        {
            return base.Channel.getDaysBetweenDatesAsync(arg0, arg1);
        }
        
        public System.Threading.Tasks.Task<string> getHelloWorldAsStringAsync(string arg0)
        {
            return base.Channel.getHelloWorldAsStringAsync(arg0);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.MyFirstWebServicePort))
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
            if ((endpointConfiguration == EndpointConfiguration.MyFirstWebServicePort))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:53359/ws/first");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MyFirstSOAPInterfaceClient.GetBindingForEndpoint(EndpointConfiguration.MyFirstWebServicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MyFirstSOAPInterfaceClient.GetEndpointAddress(EndpointConfiguration.MyFirstWebServicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            MyFirstWebServicePort,
        }
    }
}