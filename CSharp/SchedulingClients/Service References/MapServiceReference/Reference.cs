﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulingClients.MapServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
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
        private SchedulingClients.MapServiceReference.ServiceCode ServiceCodeField;
        
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
        public SchedulingClients.MapServiceReference.ServiceCode ServiceCode {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MoveData", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps")]
    [System.SerializableAttribute()]
    public partial class MoveData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NodeData", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps")]
    [System.SerializableAttribute()]
    public partial class NodeData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AliasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double HeadingRadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MapItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SchedulingClients.MapServiceReference.ServiceType[] ServicesField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SchedulingClients.MapServiceReference.ServiceType[] Services {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceType", Namespace="http://schemas.datacontract.org/2004/07/Mapping")]
    public enum ServiceType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Charge = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Park = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fault = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ManualLoadHandling = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Execution = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParameterData", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps")]
    [System.SerializableAttribute()]
    public partial class ParameterData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WaypointData", Namespace="http://schemas.datacontract.org/2004/07/Scheduling.Services.Maps")]
    [System.SerializableAttribute()]
    public partial class WaypointData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MapServiceReference.IMapService")]
    public interface IMapService {
        
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/ClearBlockingMandate", ReplyAction="http://tempuri.org/IMapService/ClearBlockingMandateResponse")]
        System.Tuple<bool, SchedulingClients.MapServiceReference.ServiceCallData> ClearBlockingMandate(int mandateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/ClearBlockingMandate", ReplyAction="http://tempuri.org/IMapService/ClearBlockingMandateResponse")]
        System.Threading.Tasks.Task<System.Tuple<bool, SchedulingClients.MapServiceReference.ServiceCallData>> ClearBlockingMandateAsync(int mandateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllMoveData", ReplyAction="http://tempuri.org/IMapService/GetAllMoveDataResponse")]
        System.Tuple<SchedulingClients.MapServiceReference.MoveData[], SchedulingClients.MapServiceReference.ServiceCallData> GetAllMoveData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllMoveData", ReplyAction="http://tempuri.org/IMapService/GetAllMoveDataResponse")]
        System.Threading.Tasks.Task<System.Tuple<SchedulingClients.MapServiceReference.MoveData[], SchedulingClients.MapServiceReference.ServiceCallData>> GetAllMoveDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllNodeData", ReplyAction="http://tempuri.org/IMapService/GetAllNodeDataResponse")]
        System.Tuple<SchedulingClients.MapServiceReference.NodeData[], SchedulingClients.MapServiceReference.ServiceCallData> GetAllNodeData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllNodeData", ReplyAction="http://tempuri.org/IMapService/GetAllNodeDataResponse")]
        System.Threading.Tasks.Task<System.Tuple<SchedulingClients.MapServiceReference.NodeData[], SchedulingClients.MapServiceReference.ServiceCallData>> GetAllNodeDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllParameterData", ReplyAction="http://tempuri.org/IMapService/GetAllParameterDataResponse")]
        System.Tuple<SchedulingClients.MapServiceReference.ParameterData[], SchedulingClients.MapServiceReference.ServiceCallData> GetAllParameterData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetAllParameterData", ReplyAction="http://tempuri.org/IMapService/GetAllParameterDataResponse")]
        System.Threading.Tasks.Task<System.Tuple<SchedulingClients.MapServiceReference.ParameterData[], SchedulingClients.MapServiceReference.ServiceCallData>> GetAllParameterDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetTrajectory", ReplyAction="http://tempuri.org/IMapService/GetTrajectoryResponse")]
        System.Tuple<SchedulingClients.MapServiceReference.WaypointData[], SchedulingClients.MapServiceReference.ServiceCallData> GetTrajectory(int moveId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/GetTrajectory", ReplyAction="http://tempuri.org/IMapService/GetTrajectoryResponse")]
        System.Threading.Tasks.Task<System.Tuple<SchedulingClients.MapServiceReference.WaypointData[], SchedulingClients.MapServiceReference.ServiceCallData>> GetTrajectoryAsync(int moveId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/RegisterBlockingMandate", ReplyAction="http://tempuri.org/IMapService/RegisterBlockingMandateResponse")]
        System.Tuple<bool, SchedulingClients.MapServiceReference.ServiceCallData> RegisterBlockingMandate(int[] mapItemIds, int mandateId, int millisecondsTimeout);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMapService/RegisterBlockingMandate", ReplyAction="http://tempuri.org/IMapService/RegisterBlockingMandateResponse")]
        System.Threading.Tasks.Task<System.Tuple<bool, SchedulingClients.MapServiceReference.ServiceCallData>> RegisterBlockingMandateAsync(int[] mapItemIds, int mandateId, int millisecondsTimeout);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMapServiceChannel : SchedulingClients.MapServiceReference.IMapService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MapServiceClient : System.ServiceModel.ClientBase<SchedulingClients.MapServiceReference.IMapService>, SchedulingClients.MapServiceReference.IMapService {
        
        public MapServiceClient() {
        }
        
        public MapServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MapServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MapServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public System.Tuple<bool, SchedulingClients.MapServiceReference.ServiceCallData> ClearBlockingMandate(int mandateId) {
            return base.Channel.ClearBlockingMandate(mandateId);
        }
        
        public System.Threading.Tasks.Task<System.Tuple<bool, SchedulingClients.MapServiceReference.ServiceCallData>> ClearBlockingMandateAsync(int mandateId) {
            return base.Channel.ClearBlockingMandateAsync(mandateId);
        }
        
        public System.Tuple<SchedulingClients.MapServiceReference.MoveData[], SchedulingClients.MapServiceReference.ServiceCallData> GetAllMoveData() {
            return base.Channel.GetAllMoveData();
        }
        
        public System.Threading.Tasks.Task<System.Tuple<SchedulingClients.MapServiceReference.MoveData[], SchedulingClients.MapServiceReference.ServiceCallData>> GetAllMoveDataAsync() {
            return base.Channel.GetAllMoveDataAsync();
        }
        
        public System.Tuple<SchedulingClients.MapServiceReference.NodeData[], SchedulingClients.MapServiceReference.ServiceCallData> GetAllNodeData() {
            return base.Channel.GetAllNodeData();
        }
        
        public System.Threading.Tasks.Task<System.Tuple<SchedulingClients.MapServiceReference.NodeData[], SchedulingClients.MapServiceReference.ServiceCallData>> GetAllNodeDataAsync() {
            return base.Channel.GetAllNodeDataAsync();
        }
        
        public System.Tuple<SchedulingClients.MapServiceReference.ParameterData[], SchedulingClients.MapServiceReference.ServiceCallData> GetAllParameterData() {
            return base.Channel.GetAllParameterData();
        }
        
        public System.Threading.Tasks.Task<System.Tuple<SchedulingClients.MapServiceReference.ParameterData[], SchedulingClients.MapServiceReference.ServiceCallData>> GetAllParameterDataAsync() {
            return base.Channel.GetAllParameterDataAsync();
        }
        
        public System.Tuple<SchedulingClients.MapServiceReference.WaypointData[], SchedulingClients.MapServiceReference.ServiceCallData> GetTrajectory(int moveId) {
            return base.Channel.GetTrajectory(moveId);
        }
        
        public System.Threading.Tasks.Task<System.Tuple<SchedulingClients.MapServiceReference.WaypointData[], SchedulingClients.MapServiceReference.ServiceCallData>> GetTrajectoryAsync(int moveId) {
            return base.Channel.GetTrajectoryAsync(moveId);
        }
        
        public System.Tuple<bool, SchedulingClients.MapServiceReference.ServiceCallData> RegisterBlockingMandate(int[] mapItemIds, int mandateId, int millisecondsTimeout) {
            return base.Channel.RegisterBlockingMandate(mapItemIds, mandateId, millisecondsTimeout);
        }
        
        public System.Threading.Tasks.Task<System.Tuple<bool, SchedulingClients.MapServiceReference.ServiceCallData>> RegisterBlockingMandateAsync(int[] mapItemIds, int mandateId, int millisecondsTimeout) {
            return base.Channel.RegisterBlockingMandateAsync(mapItemIds, mandateId, millisecondsTimeout);
        }
    }
}
