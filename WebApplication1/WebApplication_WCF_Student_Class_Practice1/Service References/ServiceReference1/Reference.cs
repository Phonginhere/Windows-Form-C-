//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication_WCF_Student_Class_Practice1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="class", Namespace="http://schemas.datacontract.org/2004/07/WcfService_WCF_Student_Class_Practice_1")]
    [System.SerializableAttribute()]
    public partial class @class : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int classIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string classNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication_WCF_Student_Class_Practice1.ServiceReference1.student[] studentsField;
        
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
        public int classId {
            get {
                return this.classIdField;
            }
            set {
                if ((this.classIdField.Equals(value) != true)) {
                    this.classIdField = value;
                    this.RaisePropertyChanged("classId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string className {
            get {
                return this.classNameField;
            }
            set {
                if ((object.ReferenceEquals(this.classNameField, value) != true)) {
                    this.classNameField = value;
                    this.RaisePropertyChanged("className");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication_WCF_Student_Class_Practice1.ServiceReference1.student[] students {
            get {
                return this.studentsField;
            }
            set {
                if ((object.ReferenceEquals(this.studentsField, value) != true)) {
                    this.studentsField = value;
                    this.RaisePropertyChanged("students");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="student", Namespace="http://schemas.datacontract.org/2004/07/WcfService_WCF_Student_Class_Practice_1")]
    [System.SerializableAttribute()]
    public partial class student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication_WCF_Student_Class_Practice1.ServiceReference1.@class classField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int classIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string studentEmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int studentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string studentNameField;
        
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
        public WebApplication_WCF_Student_Class_Practice1.ServiceReference1.@class @class {
            get {
                return this.classField;
            }
            set {
                if ((object.ReferenceEquals(this.classField, value) != true)) {
                    this.classField = value;
                    this.RaisePropertyChanged("class");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int classId {
            get {
                return this.classIdField;
            }
            set {
                if ((this.classIdField.Equals(value) != true)) {
                    this.classIdField = value;
                    this.RaisePropertyChanged("classId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string studentEmail {
            get {
                return this.studentEmailField;
            }
            set {
                if ((object.ReferenceEquals(this.studentEmailField, value) != true)) {
                    this.studentEmailField = value;
                    this.RaisePropertyChanged("studentEmail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int studentId {
            get {
                return this.studentIdField;
            }
            set {
                if ((this.studentIdField.Equals(value) != true)) {
                    this.studentIdField = value;
                    this.RaisePropertyChanged("studentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string studentName {
            get {
                return this.studentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.studentNameField, value) != true)) {
                    this.studentNameField = value;
                    this.RaisePropertyChanged("studentName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClasses", ReplyAction="http://tempuri.org/IService1/GetClassesResponse")]
        WebApplication_WCF_Student_Class_Practice1.ServiceReference1.@class[] GetClasses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetClasses", ReplyAction="http://tempuri.org/IService1/GetClassesResponse")]
        System.Threading.Tasks.Task<WebApplication_WCF_Student_Class_Practice1.ServiceReference1.@class[]> GetClassesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudent", ReplyAction="http://tempuri.org/IService1/GetStudentResponse")]
        WebApplication_WCF_Student_Class_Practice1.ServiceReference1.student[] GetStudent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudent", ReplyAction="http://tempuri.org/IService1/GetStudentResponse")]
        System.Threading.Tasks.Task<WebApplication_WCF_Student_Class_Practice1.ServiceReference1.student[]> GetStudentAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication_WCF_Student_Class_Practice1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication_WCF_Student_Class_Practice1.ServiceReference1.IService1>, WebApplication_WCF_Student_Class_Practice1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication_WCF_Student_Class_Practice1.ServiceReference1.@class[] GetClasses() {
            return base.Channel.GetClasses();
        }
        
        public System.Threading.Tasks.Task<WebApplication_WCF_Student_Class_Practice1.ServiceReference1.@class[]> GetClassesAsync() {
            return base.Channel.GetClassesAsync();
        }
        
        public WebApplication_WCF_Student_Class_Practice1.ServiceReference1.student[] GetStudent() {
            return base.Channel.GetStudent();
        }
        
        public System.Threading.Tasks.Task<WebApplication_WCF_Student_Class_Practice1.ServiceReference1.student[]> GetStudentAsync() {
            return base.Channel.GetStudentAsync();
        }
    }
}
