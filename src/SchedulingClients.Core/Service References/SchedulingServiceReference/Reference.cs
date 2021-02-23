﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulingClients.Core.SchedulingServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SchedulerStateDto", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Scheduling")]
    [System.SerializableAttribute()]
    public partial class SchedulerStateDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte CycleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid InstanceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GAAPICommon.Core.Dtos.SpotManagerStateDto SpotManagerStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan UpTimeField;
        
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
        public byte Cycle {
            get {
                return this.CycleField;
            }
            set {
                if ((this.CycleField.Equals(value) != true)) {
                    this.CycleField = value;
                    this.RaisePropertyChanged("Cycle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid InstanceId {
            get {
                return this.InstanceIdField;
            }
            set {
                if ((this.InstanceIdField.Equals(value) != true)) {
                    this.InstanceIdField = value;
                    this.RaisePropertyChanged("InstanceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GAAPICommon.Core.Dtos.SpotManagerStateDto SpotManagerState {
            get {
                return this.SpotManagerStateField;
            }
            set {
                if ((object.ReferenceEquals(this.SpotManagerStateField, value) != true)) {
                    this.SpotManagerStateField = value;
                    this.RaisePropertyChanged("SpotManagerState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan UpTime {
            get {
                return this.UpTimeField;
            }
            set {
                if ((this.UpTimeField.Equals(value) != true)) {
                    this.UpTimeField = value;
                    this.RaisePropertyChanged("UpTime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SchedulingServiceReference.ISchedulingService", CallbackContract=typeof(SchedulingClients.Core.SchedulingServiceReference.ISchedulingServiceCallback))]
    public interface ISchedulingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAPISemVer", ReplyAction="http://tempuri.org/IService/GetAPISemVerResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto> GetAPISemVer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAPISemVer", ReplyAction="http://tempuri.org/IService/GetAPISemVerResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto>> GetAPISemVerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionService/SubscriptionHeartbeat", ReplyAction="http://tempuri.org/ISubscriptionService/SubscriptionHeartbeatResponse")]
        void SubscriptionHeartbeat(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionService/SubscriptionHeartbeat", ReplyAction="http://tempuri.org/ISubscriptionService/SubscriptionHeartbeatResponse")]
        System.Threading.Tasks.Task SubscriptionHeartbeatAsync(System.Guid guid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISchedulingServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISchedulingService/OnCallback", ReplyAction="http://tempuri.org/ISchedulingService/OnCallbackResponse")]
        void OnCallback(SchedulingClients.Core.SchedulingServiceReference.SchedulerStateDto callbackObject);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISchedulingServiceChannel : SchedulingClients.Core.SchedulingServiceReference.ISchedulingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SchedulingServiceClient : System.ServiceModel.DuplexClientBase<SchedulingClients.Core.SchedulingServiceReference.ISchedulingService>, SchedulingClients.Core.SchedulingServiceReference.ISchedulingService {
        
        public SchedulingServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public SchedulingServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public SchedulingServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public SchedulingServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public SchedulingServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto> GetAPISemVer() {
            return base.Channel.GetAPISemVer();
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto>> GetAPISemVerAsync() {
            return base.Channel.GetAPISemVerAsync();
        }
        
        public void SubscriptionHeartbeat(System.Guid guid) {
            base.Channel.SubscriptionHeartbeat(guid);
        }
        
        public System.Threading.Tasks.Task SubscriptionHeartbeatAsync(System.Guid guid) {
            return base.Channel.SubscriptionHeartbeatAsync(guid);
        }
    }
}
