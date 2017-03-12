﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ZTBDService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Data", Namespace="http://schemas.datacontract.org/2004/07/ZTBD")]
    [System.SerializableAttribute()]
    public partial class Data : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ZTBDService.ComputerUsage ComputerUsageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ZTBDService.Temperature TemperatureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.ZTBDService.User UserField;
        
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
        public Client.ZTBDService.ComputerUsage ComputerUsage {
            get {
                return this.ComputerUsageField;
            }
            set {
                if ((object.ReferenceEquals(this.ComputerUsageField, value) != true)) {
                    this.ComputerUsageField = value;
                    this.RaisePropertyChanged("ComputerUsage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ZTBDService.Temperature Temperature {
            get {
                return this.TemperatureField;
            }
            set {
                if ((object.ReferenceEquals(this.TemperatureField, value) != true)) {
                    this.TemperatureField = value;
                    this.RaisePropertyChanged("Temperature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.ZTBDService.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ComputerUsage", Namespace="http://schemas.datacontract.org/2004/07/ZTBD")]
    [System.SerializableAttribute()]
    public partial class ComputerUsage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CPUField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double RAMField;
        
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
        public double CPU {
            get {
                return this.CPUField;
            }
            set {
                if ((this.CPUField.Equals(value) != true)) {
                    this.CPUField = value;
                    this.RaisePropertyChanged("CPU");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double RAM {
            get {
                return this.RAMField;
            }
            set {
                if ((this.RAMField.Equals(value) != true)) {
                    this.RAMField = value;
                    this.RaisePropertyChanged("RAM");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Temperature", Namespace="http://schemas.datacontract.org/2004/07/ZTBD")]
    [System.SerializableAttribute()]
    public partial class Temperature : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CPUField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GPUField;
        
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
        public int CPU {
            get {
                return this.CPUField;
            }
            set {
                if ((this.CPUField.Equals(value) != true)) {
                    this.CPUField = value;
                    this.RaisePropertyChanged("CPU");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GPU {
            get {
                return this.GPUField;
            }
            set {
                if ((this.GPUField.Equals(value) != true)) {
                    this.GPUField = value;
                    this.RaisePropertyChanged("GPU");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ZTBD")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MACField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PcNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Ip {
            get {
                return this.IpField;
            }
            set {
                if ((object.ReferenceEquals(this.IpField, value) != true)) {
                    this.IpField = value;
                    this.RaisePropertyChanged("Ip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MAC {
            get {
                return this.MACField;
            }
            set {
                if ((object.ReferenceEquals(this.MACField, value) != true)) {
                    this.MACField = value;
                    this.RaisePropertyChanged("MAC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PcName {
            get {
                return this.PcNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PcNameField, value) != true)) {
                    this.PcNameField = value;
                    this.RaisePropertyChanged("PcName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ZTBDService.IZTBDService")]
    public interface IZTBDService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZTBDService/InsertData", ReplyAction="http://tempuri.org/IZTBDService/InsertDataResponse")]
        void InsertData(Client.ZTBDService.Data data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZTBDService/InsertData", ReplyAction="http://tempuri.org/IZTBDService/InsertDataResponse")]
        System.Threading.Tasks.Task InsertDataAsync(Client.ZTBDService.Data data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZTBDService/GetData", ReplyAction="http://tempuri.org/IZTBDService/GetDataResponse")]
        Client.ZTBDService.Data[] GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZTBDService/GetData", ReplyAction="http://tempuri.org/IZTBDService/GetDataResponse")]
        System.Threading.Tasks.Task<Client.ZTBDService.Data[]> GetDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZTBDServiceChannel : Client.ZTBDService.IZTBDService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZTBDServiceClient : System.ServiceModel.ClientBase<Client.ZTBDService.IZTBDService>, Client.ZTBDService.IZTBDService {
        
        public ZTBDServiceClient() {
        }
        
        public ZTBDServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ZTBDServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZTBDServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZTBDServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertData(Client.ZTBDService.Data data) {
            base.Channel.InsertData(data);
        }
        
        public System.Threading.Tasks.Task InsertDataAsync(Client.ZTBDService.Data data) {
            return base.Channel.InsertDataAsync(data);
        }
        
        public Client.ZTBDService.Data[] GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<Client.ZTBDService.Data[]> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
    }
}
