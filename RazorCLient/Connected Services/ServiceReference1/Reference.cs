﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System;
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="StudentList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="Student")]
    public class StudentList : System.Collections.Generic.List<ServiceReference1.Student>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    public partial class Student : ServiceReference1.People
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.City))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.People))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.Lecturer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.Student))]
    public partial class BaseEntity : object
    {
        
        private int IdField;
        
        private int idField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    public partial class City : ServiceReference1.BaseEntity
    {
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="People", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.Lecturer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceReference1.Student))]
    public partial class People : ServiceReference1.BaseEntity
    {
        
        private ServiceReference1.City CityField;
        
        private string FnameField;
        
        private string LnameField;
        
        private int PhoneField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.City City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fname
        {
            get
            {
                return this.FnameField;
            }
            set
            {
                this.FnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lname
        {
            get
            {
                return this.LnameField;
            }
            set
            {
                this.LnameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lecturer", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    public partial class Lecturer : ServiceReference1.People
    {
        
        private string DepartmentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Department
        {
            get
            {
                return this.DepartmentField;
            }
            set
            {
                this.DepartmentField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="LecturerList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="Lecturer")]
    public class LecturerList : System.Collections.Generic.List<ServiceReference1.Lecturer>
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary10")]
    public partial class CompositeType : object
    {
        
        private bool BoolValueField;
        
        private string StringValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue
        {
            get
            {
                return this.BoolValueField;
            }
            set
            {
                this.BoolValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue
        {
            get
            {
                return this.StringValueField;
            }
            set
            {
                this.StringValueField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sum", ReplyAction="http://tempuri.org/IService1/SumResponse")]
        decimal Sum(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sum", ReplyAction="http://tempuri.org/IService1/SumResponse")]
        System.Threading.Tasks.Task<decimal> SumAsync(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentList", ReplyAction="http://tempuri.org/IService1/GetStudentListResponse")]
        ServiceReference1.StudentList GetStudentList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentList", ReplyAction="http://tempuri.org/IService1/GetStudentListResponse")]
        System.Threading.Tasks.Task<ServiceReference1.StudentList> GetStudentListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentListById", ReplyAction="http://tempuri.org/IService1/GetStudentListByIdResponse")]
        ServiceReference1.StudentList GetStudentListById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentListById", ReplyAction="http://tempuri.org/IService1/GetStudentListByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.StudentList> GetStudentListByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentListByName", ReplyAction="http://tempuri.org/IService1/GetStudentListByNameResponse")]
        ServiceReference1.StudentList GetStudentListByName(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentListByName", ReplyAction="http://tempuri.org/IService1/GetStudentListByNameResponse")]
        System.Threading.Tasks.Task<ServiceReference1.StudentList> GetStudentListByNameAsync(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDeleteStudent", ReplyAction="http://tempuri.org/IService1/GetDeleteStudentResponse")]
        int GetDeleteStudent(ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDeleteStudent", ReplyAction="http://tempuri.org/IService1/GetDeleteStudentResponse")]
        System.Threading.Tasks.Task<int> GetDeleteStudentAsync(ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLecturertList", ReplyAction="http://tempuri.org/IService1/GetLecturertListResponse")]
        ServiceReference1.LecturerList GetLecturertList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLecturertList", ReplyAction="http://tempuri.org/IService1/GetLecturertListResponse")]
        System.Threading.Tasks.Task<ServiceReference1.LecturerList> GetLecturertListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLecturertListById", ReplyAction="http://tempuri.org/IService1/GetLecturertListByIdResponse")]
        ServiceReference1.LecturerList GetLecturertListById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLecturertListById", ReplyAction="http://tempuri.org/IService1/GetLecturertListByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.LecturerList> GetLecturertListByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLecturertListByName", ReplyAction="http://tempuri.org/IService1/GetLecturertListByNameResponse")]
        ServiceReference1.LecturerList GetLecturertListByName(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetLecturertListByName", ReplyAction="http://tempuri.org/IService1/GetLecturertListByNameResponse")]
        System.Threading.Tasks.Task<ServiceReference1.LecturerList> GetLecturertListByNameAsync(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDeleteLecturer", ReplyAction="http://tempuri.org/IService1/GetDeleteLecturerResponse")]
        int GetDeleteLecturer(ServiceReference1.Lecturer lecturer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDeleteLecturer", ReplyAction="http://tempuri.org/IService1/GetDeleteLecturerResponse")]
        System.Threading.Tasks.Task<int> GetDeleteLecturerAsync(ServiceReference1.Lecturer lecturer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ServiceReference1.CompositeType GetDataUsingDataContract(ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ServiceReference1.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string GetData(int value)
        {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value)
        {
            return base.Channel.GetDataAsync(value);
        }
        
        public decimal Sum(int n1, int n2)
        {
            return base.Channel.Sum(n1, n2);
        }
        
        public System.Threading.Tasks.Task<decimal> SumAsync(int n1, int n2)
        {
            return base.Channel.SumAsync(n1, n2);
        }
        
        public ServiceReference1.StudentList GetStudentList()
        {
            return base.Channel.GetStudentList();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.StudentList> GetStudentListAsync()
        {
            return base.Channel.GetStudentListAsync();
        }
        
        public ServiceReference1.StudentList GetStudentListById(int id)
        {
            return base.Channel.GetStudentListById(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.StudentList> GetStudentListByIdAsync(int id)
        {
            return base.Channel.GetStudentListByIdAsync(id);
        }
        
        public ServiceReference1.StudentList GetStudentListByName(string firstName, string lastName)
        {
            return base.Channel.GetStudentListByName(firstName, lastName);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.StudentList> GetStudentListByNameAsync(string firstName, string lastName)
        {
            return base.Channel.GetStudentListByNameAsync(firstName, lastName);
        }
        
        public int GetDeleteStudent(ServiceReference1.Student student)
        {
            return base.Channel.GetDeleteStudent(student);
        }
        
        public System.Threading.Tasks.Task<int> GetDeleteStudentAsync(ServiceReference1.Student student)
        {
            return base.Channel.GetDeleteStudentAsync(student);
        }
        
        public ServiceReference1.LecturerList GetLecturertList()
        {
            return base.Channel.GetLecturertList();
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.LecturerList> GetLecturertListAsync()
        {
            return base.Channel.GetLecturertListAsync();
        }
        
        public ServiceReference1.LecturerList GetLecturertListById(int id)
        {
            return base.Channel.GetLecturertListById(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.LecturerList> GetLecturertListByIdAsync(int id)
        {
            return base.Channel.GetLecturertListByIdAsync(id);
        }
        
        public ServiceReference1.LecturerList GetLecturertListByName(string firstName, string lastName)
        {
            return base.Channel.GetLecturertListByName(firstName, lastName);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.LecturerList> GetLecturertListByNameAsync(string firstName, string lastName)
        {
            return base.Channel.GetLecturertListByNameAsync(firstName, lastName);
        }
        
        public int GetDeleteLecturer(ServiceReference1.Lecturer lecturer)
        {
            return base.Channel.GetDeleteLecturer(lecturer);
        }
        
        public System.Threading.Tasks.Task<int> GetDeleteLecturerAsync(ServiceReference1.Lecturer lecturer)
        {
            return base.Channel.GetDeleteLecturerAsync(lecturer);
        }
        
        public ServiceReference1.CompositeType GetDataUsingDataContract(ServiceReference1.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ServiceReference1.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfServiceLibrary10/Service1/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }

        internal int GetInsertStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
