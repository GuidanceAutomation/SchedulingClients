﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulingClients.AgentServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgentData", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Agents")]
    [System.SerializableAttribute()]
    public partial class AgentData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SchedulingClients.AgentServiceReference.AgentLifetimeState AgentLifetimeStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AliasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Net.IPAddress IPAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public SchedulingClients.AgentServiceReference.AgentLifetimeState AgentLifetimeState {
            get {
                return this.AgentLifetimeStateField;
            }
            set {
                if ((this.AgentLifetimeStateField.Equals(value) != true)) {
                    this.AgentLifetimeStateField = value;
                    this.RaisePropertyChanged("AgentLifetimeState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Alias {
            get {
                return this.AliasField;
            }
            set {
                if ((object.ReferenceEquals(this.AliasField, value) != true)) {
                    this.AliasField = value;
                    this.RaisePropertyChanged("Alias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Net.IPAddress IPAddress {
            get {
                return this.IPAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IPAddressField, value) != true)) {
                    this.IPAddressField = value;
                    this.RaisePropertyChanged("IPAddress");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceCallData", Namespace="http://schemas.datacontract.org/2004/07/Services")]
    [System.SerializableAttribute()]
    public partial class ServiceCallData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SchedulingClients.AgentServiceReference.ServiceCode ServiceCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SchedulingClients.AgentServiceReference.ServiceCode ServiceCode {
            get {
                return this.ServiceCodeField;
            }
            set {
                if ((this.ServiceCodeField.Equals(value) != true)) {
                    this.ServiceCodeField = value;
                    this.RaisePropertyChanged("ServiceCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source {
            get {
                return this.SourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceField, value) != true)) {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AgentLifetimeState", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Core")]
    public enum AgentLifetimeState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OutOfService = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InService = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Decommissioned = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceCode", Namespace="http://schemas.datacontract.org/2004/07/Services")]
    public enum ServiceCode : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NOERROR = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SERVICENOTCONFIGURED = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CLIENTEXCEPTION = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        COMMITJOBFAILED = 1001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CREATEJOBFAILED = 1002,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CREATEUNORDEREDLISTTASKFAILED = 1003,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CREATEPIPELINEDTASKFAILED = 1004,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CREATEORDEREDLISTTASKFAILED = 1005,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CREATESERVICINGTASKFAILED = 1006,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NOTACCEPTINGNEWJOBS = 1007,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DIRECTIVENOTALLOWED = 1008,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INVALIDNODETASKID = 1009,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CREATESLEEPINGTASKFAILED = 1010,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CREATEMOVINGTASKFAILED = 1011,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FINALISETASKFAILED = 1012,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BEGINEDITINGJOBFAILED = 1013,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FINISHEDITINGJOBFAILED = 1014,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BEGINEDITINGTASKFAILED = 1015,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FINISHEDITINGTASKFAILED = 1016,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ABORTALLJOBSFAILED = 2001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ABORTALLJOBSFORAGENTFAILED = 2002,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ABORTJOBFAILED = 2003,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETACTIVEJOBSFORAGENTFAILED = 2004,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ABORTTASKFAILED = 2005,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RESOLVEFAULTEDJOBFAILED = 2006,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RESOLVEFAULTEDTASKFAILED = 2007,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETJOBSTATEFAILED = 3001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INVALIDJOBID = 3002,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INVALIDTASKID = 3003,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETALLMOVEDATAFAILED = 4001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETALLNODEDATAFAILED = 4002,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETMAPPINGKEYCARDSIGNATUREFAILED = 4003,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETTRAJECTORYFAILED = 4004,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INVALIDMOVEID = 4005,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REGISTERBLOCKINGMANDATEFAILED = 4006,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CLEARBLOCKINGMANDATEFAILED = 4007,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETOUTSTANDINGSERVICEREQUESTSFAILED = 5001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SETSERVICECOMPLETEFAILED = 5002,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETALLAGENTDATAFAILED = 6001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETALLAGENTSINLIFETIMESTATEFAILED = 6002,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        COMMITINSTRUCTIONFAILED = 7001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REQUESTFREEZEFAILED = 7002,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REQUESTUNFREEZEFAILED = 7003,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INCORRECTNUMBEROFBYTES = 7004,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        COMMITEXTENDEDWAYPOINTSFAILED = 7005,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETKINGPINDESCRIPTIONFAILED = 7008,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CREATEVIRTUALVEHICLEFAILED = 7009,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        REMOVEVEHICLEFAILED = 7010,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SETPOSEFAILED = 7011,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RESETKINGPINFAILED = 7012,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DOWNLOADFAILED = 8001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UPLOADFAILED = 8002,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETFILENAMESFAILED = 8003,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        INVALIDAGENTID = 9001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETSCHEDULERVERSIONFAILED = 10001,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GETPLUGINVERSIONSFAILED = 10002,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AgentServiceReference.IAgentService")]
    public interface IAgentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VersionMajor", ReplyAction="http://tempuri.org/IService/VersionMajorResponse")]
        int VersionMajor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VersionMajor", ReplyAction="http://tempuri.org/IService/VersionMajorResponse")]
        System.Threading.Tasks.Task<int> VersionMajorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VersionMinor", ReplyAction="http://tempuri.org/IService/VersionMinorResponse")]
        int VersionMinor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VersionMinor", ReplyAction="http://tempuri.org/IService/VersionMinorResponse")]
        System.Threading.Tasks.Task<int> VersionMinorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VersionPatch", ReplyAction="http://tempuri.org/IService/VersionPatchResponse")]
        int VersionPatch();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VersionPatch", ReplyAction="http://tempuri.org/IService/VersionPatchResponse")]
        System.Threading.Tasks.Task<int> VersionPatchAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/GetAllAgentData", ReplyAction="http://tempuri.org/IAgentService/GetAllAgentDataResponse")]
        System.Tuple<SchedulingClients.AgentServiceReference.AgentData[], SchedulingClients.AgentServiceReference.ServiceCallData> GetAllAgentData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/GetAllAgentData", ReplyAction="http://tempuri.org/IAgentService/GetAllAgentDataResponse")]
        System.Threading.Tasks.Task<System.Tuple<SchedulingClients.AgentServiceReference.AgentData[], SchedulingClients.AgentServiceReference.ServiceCallData>> GetAllAgentDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/GetAllAgentsInLifetimeState", ReplyAction="http://tempuri.org/IAgentService/GetAllAgentsInLifetimeStateResponse")]
        System.Tuple<SchedulingClients.AgentServiceReference.AgentData[], SchedulingClients.AgentServiceReference.ServiceCallData> GetAllAgentsInLifetimeState(SchedulingClients.AgentServiceReference.AgentLifetimeState lifetimeState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/GetAllAgentsInLifetimeState", ReplyAction="http://tempuri.org/IAgentService/GetAllAgentsInLifetimeStateResponse")]
        System.Threading.Tasks.Task<System.Tuple<SchedulingClients.AgentServiceReference.AgentData[], SchedulingClients.AgentServiceReference.ServiceCallData>> GetAllAgentsInLifetimeStateAsync(SchedulingClients.AgentServiceReference.AgentLifetimeState lifetimeState);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAgentServiceChannel : SchedulingClients.AgentServiceReference.IAgentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AgentServiceClient : System.ServiceModel.ClientBase<SchedulingClients.AgentServiceReference.IAgentService>, SchedulingClients.AgentServiceReference.IAgentService {
        
        public AgentServiceClient() {
        }
        
        public AgentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AgentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int VersionMajor() {
            return base.Channel.VersionMajor();
        }
        
        public System.Threading.Tasks.Task<int> VersionMajorAsync() {
            return base.Channel.VersionMajorAsync();
        }
        
        public int VersionMinor() {
            return base.Channel.VersionMinor();
        }
        
        public System.Threading.Tasks.Task<int> VersionMinorAsync() {
            return base.Channel.VersionMinorAsync();
        }
        
        public int VersionPatch() {
            return base.Channel.VersionPatch();
        }
        
        public System.Threading.Tasks.Task<int> VersionPatchAsync() {
            return base.Channel.VersionPatchAsync();
        }
        
        public System.Tuple<SchedulingClients.AgentServiceReference.AgentData[], SchedulingClients.AgentServiceReference.ServiceCallData> GetAllAgentData() {
            return base.Channel.GetAllAgentData();
        }
        
        public System.Threading.Tasks.Task<System.Tuple<SchedulingClients.AgentServiceReference.AgentData[], SchedulingClients.AgentServiceReference.ServiceCallData>> GetAllAgentDataAsync() {
            return base.Channel.GetAllAgentDataAsync();
        }
        
        public System.Tuple<SchedulingClients.AgentServiceReference.AgentData[], SchedulingClients.AgentServiceReference.ServiceCallData> GetAllAgentsInLifetimeState(SchedulingClients.AgentServiceReference.AgentLifetimeState lifetimeState) {
            return base.Channel.GetAllAgentsInLifetimeState(lifetimeState);
        }
        
        public System.Threading.Tasks.Task<System.Tuple<SchedulingClients.AgentServiceReference.AgentData[], SchedulingClients.AgentServiceReference.ServiceCallData>> GetAllAgentsInLifetimeStateAsync(SchedulingClients.AgentServiceReference.AgentLifetimeState lifetimeState) {
            return base.Channel.GetAllAgentsInLifetimeStateAsync(lifetimeState);
        }
    }
}
