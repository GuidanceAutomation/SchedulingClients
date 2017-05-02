﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulingClients.JobStateServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JobStateData", Namespace="http://schemas.datacontract.org/2004/07/SchedulingServices")]
    [System.SerializableAttribute()]
    public partial class JobStateData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AssignedAgentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int JobIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SchedulingClients.JobStateServiceReference.JobStatus JobStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SchedulingClients.JobStateServiceReference.TaskStateData[] TasksField;
        
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
        public int AssignedAgentId {
            get {
                return this.AssignedAgentIdField;
            }
            set {
                if ((this.AssignedAgentIdField.Equals(value) != true)) {
                    this.AssignedAgentIdField = value;
                    this.RaisePropertyChanged("AssignedAgentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int JobId {
            get {
                return this.JobIdField;
            }
            set {
                if ((this.JobIdField.Equals(value) != true)) {
                    this.JobIdField = value;
                    this.RaisePropertyChanged("JobId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SchedulingClients.JobStateServiceReference.JobStatus JobStatus {
            get {
                return this.JobStatusField;
            }
            set {
                if ((this.JobStatusField.Equals(value) != true)) {
                    this.JobStatusField = value;
                    this.RaisePropertyChanged("JobStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SchedulingClients.JobStateServiceReference.TaskStateData[] Tasks {
            get {
                return this.TasksField;
            }
            set {
                if ((object.ReferenceEquals(this.TasksField, value) != true)) {
                    this.TasksField = value;
                    this.RaisePropertyChanged("Tasks");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JobStatus", Namespace="http://schemas.datacontract.org/2004/07/SchedulingServices")]
    public enum JobStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Assembly = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Assigning = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Waiting = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InProgress = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Complete = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aborted = 5,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaskStateData", Namespace="http://schemas.datacontract.org/2004/07/SchedulingServices")]
    [System.SerializableAttribute()]
    public partial class TaskStateData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MetaDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TaskIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SchedulingClients.JobStateServiceReference.TaskStatus TaskStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TaskTypeField;
        
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
        public string MetaData {
            get {
                return this.MetaDataField;
            }
            set {
                if ((object.ReferenceEquals(this.MetaDataField, value) != true)) {
                    this.MetaDataField = value;
                    this.RaisePropertyChanged("MetaData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TaskId {
            get {
                return this.TaskIdField;
            }
            set {
                if ((this.TaskIdField.Equals(value) != true)) {
                    this.TaskIdField = value;
                    this.RaisePropertyChanged("TaskId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SchedulingClients.JobStateServiceReference.TaskStatus TaskStatus {
            get {
                return this.TaskStatusField;
            }
            set {
                if ((this.TaskStatusField.Equals(value) != true)) {
                    this.TaskStatusField = value;
                    this.RaisePropertyChanged("TaskStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TaskType {
            get {
                return this.TaskTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TaskTypeField, value) != true)) {
                    this.TaskTypeField = value;
                    this.RaisePropertyChanged("TaskType");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TaskStatus", Namespace="http://schemas.datacontract.org/2004/07/SchedulingServices")]
    public enum TaskStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unstarted = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InProgress = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Completed = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aborted = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Assembly = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JobStateServiceReference.IJobStateService")]
    public interface IJobStateService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobStateService/GetJobState", ReplyAction="http://tempuri.org/IJobStateService/GetJobStateResponse")]
        SchedulingClients.JobStateServiceReference.JobStateData GetJobState(int jobId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobStateService/GetJobState", ReplyAction="http://tempuri.org/IJobStateService/GetJobStateResponse")]
        System.Threading.Tasks.Task<SchedulingClients.JobStateServiceReference.JobStateData> GetJobStateAsync(int jobId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJobStateServiceChannel : SchedulingClients.JobStateServiceReference.IJobStateService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobStateServiceClient : System.ServiceModel.ClientBase<SchedulingClients.JobStateServiceReference.IJobStateService>, SchedulingClients.JobStateServiceReference.IJobStateService {
        
        public JobStateServiceClient() {
        }
        
        public JobStateServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobStateServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobStateServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobStateServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SchedulingClients.JobStateServiceReference.JobStateData GetJobState(int jobId) {
            return base.Channel.GetJobState(jobId);
        }
        
        public System.Threading.Tasks.Task<SchedulingClients.JobStateServiceReference.JobStateData> GetJobStateAsync(int jobId) {
            return base.Channel.GetJobStateAsync(jobId);
        }
    }
}