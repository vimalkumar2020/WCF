﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IISTestWeb.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JobOpeningModel", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class JobOpeningModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ExperienceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Experience {
            get {
                return this.ExperienceField;
            }
            set {
                if ((this.ExperienceField.Equals(value) != true)) {
                    this.ExperienceField = value;
                    this.RaisePropertyChanged("Experience");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IJobOpeningService")]
    public interface IJobOpeningService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobOpeningService/GetJobOpening", ReplyAction="http://tempuri.org/IJobOpeningService/GetJobOpeningResponse")]
        IISTestWeb.ServiceReference1.JobOpeningModel[] GetJobOpening();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobOpeningService/GetJobOpening", ReplyAction="http://tempuri.org/IJobOpeningService/GetJobOpeningResponse")]
        System.Threading.Tasks.Task<IISTestWeb.ServiceReference1.JobOpeningModel[]> GetJobOpeningAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobOpeningService/GetJobOpeningByRole", ReplyAction="http://tempuri.org/IJobOpeningService/GetJobOpeningByRoleResponse")]
        IISTestWeb.ServiceReference1.JobOpeningModel[] GetJobOpeningByRole(string role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobOpeningService/GetJobOpeningByRole", ReplyAction="http://tempuri.org/IJobOpeningService/GetJobOpeningByRoleResponse")]
        System.Threading.Tasks.Task<IISTestWeb.ServiceReference1.JobOpeningModel[]> GetJobOpeningByRoleAsync(string role);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJobOpeningServiceChannel : IISTestWeb.ServiceReference1.IJobOpeningService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobOpeningServiceClient : System.ServiceModel.ClientBase<IISTestWeb.ServiceReference1.IJobOpeningService>, IISTestWeb.ServiceReference1.IJobOpeningService {
        
        public JobOpeningServiceClient() {
        }
        
        public JobOpeningServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobOpeningServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobOpeningServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobOpeningServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public IISTestWeb.ServiceReference1.JobOpeningModel[] GetJobOpening() {
            return base.Channel.GetJobOpening();
        }
        
        public System.Threading.Tasks.Task<IISTestWeb.ServiceReference1.JobOpeningModel[]> GetJobOpeningAsync() {
            return base.Channel.GetJobOpeningAsync();
        }
        
        public IISTestWeb.ServiceReference1.JobOpeningModel[] GetJobOpeningByRole(string role) {
            return base.Channel.GetJobOpeningByRole(role);
        }
        
        public System.Threading.Tasks.Task<IISTestWeb.ServiceReference1.JobOpeningModel[]> GetJobOpeningByRoleAsync(string role) {
            return base.Channel.GetJobOpeningByRoleAsync(role);
        }
    }
}