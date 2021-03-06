﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 15.0.26323.1
// 
namespace SQLBasicUwp.SampleServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/SimpleDatabaseService")]
    public partial class CompositeType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool BoolValueField;
        
        private string StringValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SampleTable", Namespace="http://schemas.datacontract.org/2004/07/SimpleDatabaseService")]
    public partial class SampleTable : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string FirstNameField;
        
        private int IdField;
        
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SampleServiceReference.ISampleTableService")]
    public interface ISampleTableService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleTableService/GetData", ReplyAction="http://tempuri.org/ISampleTableService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleTableService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ISampleTableService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<SQLBasicUwp.SampleServiceReference.CompositeType> GetDataUsingDataContractAsync(SQLBasicUwp.SampleServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleTableService/GetSampleData", ReplyAction="http://tempuri.org/ISampleTableService/GetSampleDataResponse")]
        System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SQLBasicUwp.SampleServiceReference.SampleTable>> GetSampleDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleTableService/InsertSampleData", ReplyAction="http://tempuri.org/ISampleTableService/InsertSampleDataResponse")]
        System.Threading.Tasks.Task<SQLBasicUwp.SampleServiceReference.SampleTable> InsertSampleDataAsync(SQLBasicUwp.SampleServiceReference.SampleTable sample);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISampleTableService/DeleteSampleData", ReplyAction="http://tempuri.org/ISampleTableService/DeleteSampleDataResponse")]
        System.Threading.Tasks.Task<SQLBasicUwp.SampleServiceReference.SampleTable> DeleteSampleDataAsync(SQLBasicUwp.SampleServiceReference.SampleTable sample);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISampleTableServiceChannel : SQLBasicUwp.SampleServiceReference.ISampleTableService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SampleTableServiceClient : System.ServiceModel.ClientBase<SQLBasicUwp.SampleServiceReference.ISampleTableService>, SQLBasicUwp.SampleServiceReference.ISampleTableService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SampleTableServiceClient() : 
                base(SampleTableServiceClient.GetDefaultBinding(), SampleTableServiceClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ISampleTableService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleTableServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SampleTableServiceClient.GetBindingForEndpoint(endpointConfiguration), SampleTableServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleTableServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SampleTableServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleTableServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SampleTableServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SampleTableServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public System.Threading.Tasks.Task<SQLBasicUwp.SampleServiceReference.CompositeType> GetDataUsingDataContractAsync(SQLBasicUwp.SampleServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public System.Threading.Tasks.Task<System.Collections.ObjectModel.ObservableCollection<SQLBasicUwp.SampleServiceReference.SampleTable>> GetSampleDataAsync() {
            return base.Channel.GetSampleDataAsync();
        }
        
        public System.Threading.Tasks.Task<SQLBasicUwp.SampleServiceReference.SampleTable> InsertSampleDataAsync(SQLBasicUwp.SampleServiceReference.SampleTable sample) {
            return base.Channel.InsertSampleDataAsync(sample);
        }
        
        public System.Threading.Tasks.Task<SQLBasicUwp.SampleServiceReference.SampleTable> DeleteSampleDataAsync(SQLBasicUwp.SampleServiceReference.SampleTable sample) {
            return base.Channel.DeleteSampleDataAsync(sample);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISampleTableService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISampleTableService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:58422/SampleTableService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return SampleTableServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISampleTableService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return SampleTableServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISampleTableService);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_ISampleTableService,
        }
    }
}
