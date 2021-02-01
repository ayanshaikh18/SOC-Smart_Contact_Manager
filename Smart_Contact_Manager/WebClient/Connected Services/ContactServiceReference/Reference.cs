﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.ContactServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/Backend_Service.Models")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ContactIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhotoPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public int ContactId {
            get {
                return this.ContactIdField;
            }
            set {
                if ((this.ContactIdField.Equals(value) != true)) {
                    this.ContactIdField = value;
                    this.RaisePropertyChanged("ContactId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhotoPath {
            get {
                return this.PhotoPathField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoPathField, value) != true)) {
                    this.PhotoPathField = value;
                    this.RaisePropertyChanged("PhotoPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ContactServiceReference.IContactService")]
    public interface IContactService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetContacts", ReplyAction="http://tempuri.org/IContactService/GetContactsResponse")]
        WebClient.ContactServiceReference.Contact[] GetContacts(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetContacts", ReplyAction="http://tempuri.org/IContactService/GetContactsResponse")]
        System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact[]> GetContactsAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/AddContact", ReplyAction="http://tempuri.org/IContactService/AddContactResponse")]
        WebClient.ContactServiceReference.Contact1 AddContact(WebClient.ContactServiceReference.Contact1 request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/AddContact", ReplyAction="http://tempuri.org/IContactService/AddContactResponse")]
        System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact1> AddContactAsync(WebClient.ContactServiceReference.Contact1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetContact", ReplyAction="http://tempuri.org/IContactService/GetContactResponse")]
        WebClient.ContactServiceReference.Contact1 GetContact(WebClient.ContactServiceReference.Contact1 request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetContact", ReplyAction="http://tempuri.org/IContactService/GetContactResponse")]
        System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact1> GetContactAsync(WebClient.ContactServiceReference.Contact1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/UpdateContact", ReplyAction="http://tempuri.org/IContactService/UpdateContactResponse")]
        WebClient.ContactServiceReference.Contact1 UpdateContact(WebClient.ContactServiceReference.Contact1 request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/UpdateContact", ReplyAction="http://tempuri.org/IContactService/UpdateContactResponse")]
        System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact1> UpdateContactAsync(WebClient.ContactServiceReference.Contact1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/DeleteContact", ReplyAction="http://tempuri.org/IContactService/DeleteContactResponse")]
        WebClient.ContactServiceReference.Contact1 DeleteContact(WebClient.ContactServiceReference.Contact1 request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/DeleteContact", ReplyAction="http://tempuri.org/IContactService/DeleteContactResponse")]
        System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact1> DeleteContactAsync(WebClient.ContactServiceReference.Contact1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Contact", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Contact1 {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int ContactId;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public int UserId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Description;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string Email;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string PhoneNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string PhotoPath;
        
        public Contact1() {
        }
        
        public Contact1(int ContactId, int UserId, string Description, string Email, string Name, string PhoneNumber, string PhotoPath) {
            this.ContactId = ContactId;
            this.UserId = UserId;
            this.Description = Description;
            this.Email = Email;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.PhotoPath = PhotoPath;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContactServiceChannel : WebClient.ContactServiceReference.IContactService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContactServiceClient : System.ServiceModel.ClientBase<WebClient.ContactServiceReference.IContactService>, WebClient.ContactServiceReference.IContactService {
        
        public ContactServiceClient() {
        }
        
        public ContactServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebClient.ContactServiceReference.Contact[] GetContacts(int userId) {
            return base.Channel.GetContacts(userId);
        }
        
        public System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact[]> GetContactsAsync(int userId) {
            return base.Channel.GetContactsAsync(userId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ContactServiceReference.Contact1 WebClient.ContactServiceReference.IContactService.AddContact(WebClient.ContactServiceReference.Contact1 request) {
            return base.Channel.AddContact(request);
        }
        
        public void AddContact(ref int ContactId, ref int UserId, ref string Description, ref string Email, ref string Name, ref string PhoneNumber, ref string PhotoPath) {
            WebClient.ContactServiceReference.Contact1 inValue = new WebClient.ContactServiceReference.Contact1();
            inValue.ContactId = ContactId;
            inValue.UserId = UserId;
            inValue.Description = Description;
            inValue.Email = Email;
            inValue.Name = Name;
            inValue.PhoneNumber = PhoneNumber;
            inValue.PhotoPath = PhotoPath;
            WebClient.ContactServiceReference.Contact1 retVal = ((WebClient.ContactServiceReference.IContactService)(this)).AddContact(inValue);
            ContactId = retVal.ContactId;
            UserId = retVal.UserId;
            Description = retVal.Description;
            Email = retVal.Email;
            Name = retVal.Name;
            PhoneNumber = retVal.PhoneNumber;
            PhotoPath = retVal.PhotoPath;
        }
        
        public System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact1> AddContactAsync(WebClient.ContactServiceReference.Contact1 request) {
            return base.Channel.AddContactAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ContactServiceReference.Contact1 WebClient.ContactServiceReference.IContactService.GetContact(WebClient.ContactServiceReference.Contact1 request) {
            return base.Channel.GetContact(request);
        }
        
        public void GetContact(ref int ContactId, ref int UserId, ref string Description, ref string Email, ref string Name, ref string PhoneNumber, ref string PhotoPath) {
            WebClient.ContactServiceReference.Contact1 inValue = new WebClient.ContactServiceReference.Contact1();
            inValue.ContactId = ContactId;
            inValue.UserId = UserId;
            inValue.Description = Description;
            inValue.Email = Email;
            inValue.Name = Name;
            inValue.PhoneNumber = PhoneNumber;
            inValue.PhotoPath = PhotoPath;
            WebClient.ContactServiceReference.Contact1 retVal = ((WebClient.ContactServiceReference.IContactService)(this)).GetContact(inValue);
            ContactId = retVal.ContactId;
            UserId = retVal.UserId;
            Description = retVal.Description;
            Email = retVal.Email;
            Name = retVal.Name;
            PhoneNumber = retVal.PhoneNumber;
            PhotoPath = retVal.PhotoPath;
        }
        
        public System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact1> GetContactAsync(WebClient.ContactServiceReference.Contact1 request) {
            return base.Channel.GetContactAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ContactServiceReference.Contact1 WebClient.ContactServiceReference.IContactService.UpdateContact(WebClient.ContactServiceReference.Contact1 request) {
            return base.Channel.UpdateContact(request);
        }
        
        public void UpdateContact(ref int ContactId, ref int UserId, ref string Description, ref string Email, ref string Name, ref string PhoneNumber, ref string PhotoPath) {
            WebClient.ContactServiceReference.Contact1 inValue = new WebClient.ContactServiceReference.Contact1();
            inValue.ContactId = ContactId;
            inValue.UserId = UserId;
            inValue.Description = Description;
            inValue.Email = Email;
            inValue.Name = Name;
            inValue.PhoneNumber = PhoneNumber;
            inValue.PhotoPath = PhotoPath;
            WebClient.ContactServiceReference.Contact1 retVal = ((WebClient.ContactServiceReference.IContactService)(this)).UpdateContact(inValue);
            ContactId = retVal.ContactId;
            UserId = retVal.UserId;
            Description = retVal.Description;
            Email = retVal.Email;
            Name = retVal.Name;
            PhoneNumber = retVal.PhoneNumber;
            PhotoPath = retVal.PhotoPath;
        }
        
        public System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact1> UpdateContactAsync(WebClient.ContactServiceReference.Contact1 request) {
            return base.Channel.UpdateContactAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ContactServiceReference.Contact1 WebClient.ContactServiceReference.IContactService.DeleteContact(WebClient.ContactServiceReference.Contact1 request) {
            return base.Channel.DeleteContact(request);
        }
        
        public void DeleteContact(ref int ContactId, ref int UserId, ref string Description, ref string Email, ref string Name, ref string PhoneNumber, ref string PhotoPath) {
            WebClient.ContactServiceReference.Contact1 inValue = new WebClient.ContactServiceReference.Contact1();
            inValue.ContactId = ContactId;
            inValue.UserId = UserId;
            inValue.Description = Description;
            inValue.Email = Email;
            inValue.Name = Name;
            inValue.PhoneNumber = PhoneNumber;
            inValue.PhotoPath = PhotoPath;
            WebClient.ContactServiceReference.Contact1 retVal = ((WebClient.ContactServiceReference.IContactService)(this)).DeleteContact(inValue);
            ContactId = retVal.ContactId;
            UserId = retVal.UserId;
            Description = retVal.Description;
            Email = retVal.Email;
            Name = retVal.Name;
            PhoneNumber = retVal.PhoneNumber;
            PhotoPath = retVal.PhotoPath;
        }
        
        public System.Threading.Tasks.Task<WebClient.ContactServiceReference.Contact1> DeleteContactAsync(WebClient.ContactServiceReference.Contact1 request) {
            return base.Channel.DeleteContactAsync(request);
        }
    }
}