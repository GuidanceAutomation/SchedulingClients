﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulingClients.Core.MapServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OccupyingMandateProgressDto", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps.Dtos")]
    [System.SerializableAttribute()]
    public partial class OccupyingMandateProgressDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SchedulingClients.Core.MapServiceReference.OccupyingMandateMapItemDto[] OccupyingMandateMapItemDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GACore.Architecture.OccupyingMandateState OccupyingMandateStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan TimeoutRemainingField;
        
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
        public SchedulingClients.Core.MapServiceReference.OccupyingMandateMapItemDto[] OccupyingMandateMapItemData {
            get {
                return this.OccupyingMandateMapItemDataField;
            }
            set {
                if ((object.ReferenceEquals(this.OccupyingMandateMapItemDataField, value) != true)) {
                    this.OccupyingMandateMapItemDataField = value;
                    this.RaisePropertyChanged("OccupyingMandateMapItemData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GACore.Architecture.OccupyingMandateState OccupyingMandateState {
            get {
                return this.OccupyingMandateStateField;
            }
            set {
                if ((this.OccupyingMandateStateField.Equals(value) != true)) {
                    this.OccupyingMandateStateField = value;
                    this.RaisePropertyChanged("OccupyingMandateState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan TimeoutRemaining {
            get {
                return this.TimeoutRemainingField;
            }
            set {
                if ((this.TimeoutRemainingField.Equals(value) != true)) {
                    this.TimeoutRemainingField = value;
                    this.RaisePropertyChanged("TimeoutRemaining");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OccupyingMandateMapItemDto", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps.Dtos")]
    [System.SerializableAttribute()]
    public partial class OccupyingMandateMapItemDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsOccupiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MapItemIdField;
        
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
        public bool IsOccupied {
            get {
                return this.IsOccupiedField;
            }
            set {
                if ((this.IsOccupiedField.Equals(value) != true)) {
                    this.IsOccupiedField = value;
                    this.RaisePropertyChanged("IsOccupied");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MapItemId {
            get {
                return this.MapItemIdField;
            }
            set {
                if ((this.MapItemIdField.Equals(value) != true)) {
                    this.MapItemIdField = value;
                    this.RaisePropertyChanged("MapItemId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MoveDto", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps.Dtos")]
    [System.SerializableAttribute()]
    public partial class MoveDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AliasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DestinationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SourceIdField;
        
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
        public int DestinationId {
            get {
                return this.DestinationIdField;
            }
            set {
                if ((this.DestinationIdField.Equals(value) != true)) {
                    this.DestinationIdField = value;
                    this.RaisePropertyChanged("DestinationId");
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
        public int SourceId {
            get {
                return this.SourceIdField;
            }
            set {
                if ((this.SourceIdField.Equals(value) != true)) {
                    this.SourceIdField = value;
                    this.RaisePropertyChanged("SourceId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NodeDto", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps.Dtos")]
    [System.SerializableAttribute()]
    public partial class NodeDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AliasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double HeadingRadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GACore.Architecture.ServiceType[] ServicesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double YField;
        
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
        public double HeadingRad {
            get {
                return this.HeadingRadField;
            }
            set {
                if ((this.HeadingRadField.Equals(value) != true)) {
                    this.HeadingRadField = value;
                    this.RaisePropertyChanged("HeadingRad");
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
        public GACore.Architecture.ServiceType[] Services {
            get {
                return this.ServicesField;
            }
            set {
                if ((object.ReferenceEquals(this.ServicesField, value) != true)) {
                    this.ServicesField = value;
                    this.RaisePropertyChanged("Services");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ParameterDto", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps")]
    [System.SerializableAttribute()]
    public partial class ParameterDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AGVTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AliasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DataTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ParameterIdField;
        
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
        public int AGVType {
            get {
                return this.AGVTypeField;
            }
            set {
                if ((this.AGVTypeField.Equals(value) != true)) {
                    this.AGVTypeField = value;
                    this.RaisePropertyChanged("AGVType");
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
        public string DataType {
            get {
                return this.DataTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.DataTypeField, value) != true)) {
                    this.DataTypeField = value;
                    this.RaisePropertyChanged("DataType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ParameterId {
            get {
                return this.ParameterIdField;
            }
            set {
                if ((this.ParameterIdField.Equals(value) != true)) {
                    this.ParameterIdField = value;
                    this.RaisePropertyChanged("ParameterId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WaypointDto", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps.Dtos")]
    [System.SerializableAttribute()]
    public partial class WaypointDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double HeadingRadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double YField;
        
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
        public double HeadingRad {
            get {
                return this.HeadingRadField;
            }
            set {
                if ((this.HeadingRadField.Equals(value) != true)) {
                    this.HeadingRadField = value;
                    this.RaisePropertyChanged("HeadingRad");
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
        public double X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MapServiceReference.IMapService", CallbackContract=typeof(SchedulingClients.Core.MapServiceReference.IMapServiceCallback))]
    public interface IMapService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAPISemVer", ReplyAction="http://tempuri.org/IService/GetAPISemVerResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto> GetAPISemVer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAPISemVer", ReplyAction="http://tempuri.org/IService/GetAPISemVerResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto>> GetAPISemVerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionService/SubscriptionHeartbeat", ReplyAction="http://tempuri.org/ISubscriptionService/SubscriptionHeartbeatResponse")]
        void SubscriptionHeartbeat(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISubscriptionService/SubscriptionHeartbeat", ReplyAction="http://tempuri.org/ISubscriptionService/SubscriptionHeartbeatResponse")]
        System.Threading.Tasks.Task SubscriptionHeartbeatAsync(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/ClearOccupyingMandate", ReplyAction="http://tempuri.org/IMapService/ClearOccupyingMandateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.OccupyingMandateProgressDto>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.MoveDto[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.NodeDto[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.ParameterDto[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.WaypointDto[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto>))]
        GAAPICommon.Core.Dtos.ServiceCallResultDto ClearOccupyingMandate();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/ClearOccupyingMandate", ReplyAction="http://tempuri.org/IMapService/ClearOccupyingMandateResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto> ClearOccupyingMandateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetOccupyingMandateProgressData", ReplyAction="http://tempuri.org/IMapService/GetOccupyingMandateProgressDataResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.OccupyingMandateProgressDto> GetOccupyingMandateProgressData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetOccupyingMandateProgressData", ReplyAction="http://tempuri.org/IMapService/GetOccupyingMandateProgressDataResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.OccupyingMandateProgressDto>> GetOccupyingMandateProgressDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/SetOccupyingMandate", ReplyAction="http://tempuri.org/IMapService/SetOccupyingMandateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.OccupyingMandateProgressDto>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.MoveDto[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.NodeDto[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.ParameterDto[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.WaypointDto[]>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GAAPICommon.Core.Dtos.ServiceCallResultDto<GAAPICommon.Core.Dtos.SemVerDto>))]
        GAAPICommon.Core.Dtos.ServiceCallResultDto SetOccupyingMandate(int[] mapItemIds, System.TimeSpan timeout);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/SetOccupyingMandate", ReplyAction="http://tempuri.org/IMapService/SetOccupyingMandateResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto> SetOccupyingMandateAsync(int[] mapItemIds, System.TimeSpan timeout);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllMoveData", ReplyAction="http://tempuri.org/IMapService/GetAllMoveDataResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.MoveDto[]> GetAllMoveData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllMoveData", ReplyAction="http://tempuri.org/IMapService/GetAllMoveDataResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.MoveDto[]>> GetAllMoveDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllNodeData", ReplyAction="http://tempuri.org/IMapService/GetAllNodeDataResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.NodeDto[]> GetAllNodeData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllNodeData", ReplyAction="http://tempuri.org/IMapService/GetAllNodeDataResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.NodeDto[]>> GetAllNodeDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllParameterData", ReplyAction="http://tempuri.org/IMapService/GetAllParameterDataResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.ParameterDto[]> GetAllParameterData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllParameterData", ReplyAction="http://tempuri.org/IMapService/GetAllParameterDataResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.ParameterDto[]>> GetAllParameterDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetTrajectory", ReplyAction="http://tempuri.org/IMapService/GetTrajectoryResponse")]
        GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.WaypointDto[]> GetTrajectory(int moveId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetTrajectory", ReplyAction="http://tempuri.org/IMapService/GetTrajectoryResponse")]
        System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.WaypointDto[]>> GetTrajectoryAsync(int moveId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMapServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/OnCallback", ReplyAction="http://tempuri.org/IMapService/OnCallbackResponse")]
        void OnCallback(SchedulingClients.Core.MapServiceReference.OccupyingMandateProgressDto callbackObject);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMapServiceChannel : SchedulingClients.Core.MapServiceReference.IMapService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MapServiceClient : System.ServiceModel.DuplexClientBase<SchedulingClients.Core.MapServiceReference.IMapService>, SchedulingClients.Core.MapServiceReference.IMapService {
        
        public MapServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MapServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MapServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MapServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MapServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto ClearOccupyingMandate() {
            return base.Channel.ClearOccupyingMandate();
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto> ClearOccupyingMandateAsync() {
            return base.Channel.ClearOccupyingMandateAsync();
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.OccupyingMandateProgressDto> GetOccupyingMandateProgressData() {
            return base.Channel.GetOccupyingMandateProgressData();
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.OccupyingMandateProgressDto>> GetOccupyingMandateProgressDataAsync() {
            return base.Channel.GetOccupyingMandateProgressDataAsync();
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto SetOccupyingMandate(int[] mapItemIds, System.TimeSpan timeout) {
            return base.Channel.SetOccupyingMandate(mapItemIds, timeout);
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto> SetOccupyingMandateAsync(int[] mapItemIds, System.TimeSpan timeout) {
            return base.Channel.SetOccupyingMandateAsync(mapItemIds, timeout);
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.MoveDto[]> GetAllMoveData() {
            return base.Channel.GetAllMoveData();
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.MoveDto[]>> GetAllMoveDataAsync() {
            return base.Channel.GetAllMoveDataAsync();
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.NodeDto[]> GetAllNodeData() {
            return base.Channel.GetAllNodeData();
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.NodeDto[]>> GetAllNodeDataAsync() {
            return base.Channel.GetAllNodeDataAsync();
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.ParameterDto[]> GetAllParameterData() {
            return base.Channel.GetAllParameterData();
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.ParameterDto[]>> GetAllParameterDataAsync() {
            return base.Channel.GetAllParameterDataAsync();
        }
        
        public GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.WaypointDto[]> GetTrajectory(int moveId) {
            return base.Channel.GetTrajectory(moveId);
        }
        
        public System.Threading.Tasks.Task<GAAPICommon.Core.Dtos.ServiceCallResultDto<SchedulingClients.Core.MapServiceReference.WaypointDto[]>> GetTrajectoryAsync(int moveId) {
            return base.Channel.GetTrajectoryAsync(moveId);
        }
    }
}
