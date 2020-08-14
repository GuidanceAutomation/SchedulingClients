﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulingClients.Core.AgentServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AgentDto", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Agents.Dtos")]
    [System.SerializableAttribute()]
    public partial class AgentDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GACore.Architecture.AgentLifetimeState AgentLifetimeStateField;
        
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
        public GACore.Architecture.AgentLifetimeState AgentLifetimeState {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AgentServiceReference.IAgentService")]
    public interface IAgentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAPISemVer", ReplyAction="http://tempuri.org/IService/GetAPISemVerResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto> GetAPISemVer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAPISemVer", ReplyAction="http://tempuri.org/IService/GetAPISemVerResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto>> GetAPISemVerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/GetAllAgentData", ReplyAction="http://tempuri.org/IAgentService/GetAllAgentDataResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.AgentServiceReference.AgentDto[]> GetAllAgentData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/GetAllAgentData", ReplyAction="http://tempuri.org/IAgentService/GetAllAgentDataResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.AgentServiceReference.AgentDto[]>> GetAllAgentDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/GetAllAgentsInLifetimeState", ReplyAction="http://tempuri.org/IAgentService/GetAllAgentsInLifetimeStateResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.AgentServiceReference.AgentDto[]> GetAllAgentsInLifetimeState(GACore.Architecture.AgentLifetimeState agentLifetimeState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/GetAllAgentsInLifetimeState", ReplyAction="http://tempuri.org/IAgentService/GetAllAgentsInLifetimeStateResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.AgentServiceReference.AgentDto[]>> GetAllAgentsInLifetimeStateAsync(GACore.Architecture.AgentLifetimeState agentLifetimeState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/SetAgentLifetimeState", ReplyAction="http://tempuri.org/IAgentService/SetAgentLifetimeStateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.AgentServiceReference.AgentDto[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto>))]
        GAAPICommon.Core.Dtos.ServiceCallResultDto SetAgentLifetimeState(int agentId, GACore.Architecture.AgentLifetimeState desiredState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAgentService/SetAgentLifetimeState", ReplyAction="http://tempuri.org/IAgentService/SetAgentLifetimeStateResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto> SetAgentLifetimeStateAsync(int agentId, GACore.Architecture.AgentLifetimeState desiredState);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAgentServiceChannel : SchedulingClients.Core.AgentServiceReference.IAgentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AgentServiceClient : System.ServiceModel.ClientBase<SchedulingClients.Core.AgentServiceReference.IAgentService>, SchedulingClients.Core.AgentServiceReference.IAgentService {
        
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
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto> GetAPISemVer() {
            return base.Channel.GetAPISemVer();
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto>> GetAPISemVerAsync() {
            return base.Channel.GetAPISemVerAsync();
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.AgentServiceReference.AgentDto[]> GetAllAgentData() {
            return base.Channel.GetAllAgentData();
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.AgentServiceReference.AgentDto[]>> GetAllAgentDataAsync() {
            return base.Channel.GetAllAgentDataAsync();
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.AgentServiceReference.AgentDto[]> GetAllAgentsInLifetimeState(GACore.Architecture.AgentLifetimeState agentLifetimeState) {
            return base.Channel.GetAllAgentsInLifetimeState(agentLifetimeState);
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.AgentServiceReference.AgentDto[]>> GetAllAgentsInLifetimeStateAsync(GACore.Architecture.AgentLifetimeState agentLifetimeState) {
            return base.Channel.GetAllAgentsInLifetimeStateAsync(agentLifetimeState);
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto SetAgentLifetimeState(int agentId, GACore.Architecture.AgentLifetimeState desiredState) {
            return base.Channel.SetAgentLifetimeState(agentId, desiredState);
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto> SetAgentLifetimeStateAsync(int agentId, GACore.Architecture.AgentLifetimeState desiredState) {
            return base.Channel.SetAgentLifetimeStateAsync(agentId, desiredState);
        }
    }
}
