﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValidadorDIME {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoRetorno", Namespace="http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS")]
    [System.SerializableAttribute()]
    public partial class DtoRetorno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ValidadorDIME.DtoErro[] ErrosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public ValidadorDIME.DtoErro[] Erros {
            get {
                return this.ErrosField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrosField, value) != true)) {
                    this.ErrosField = value;
                    this.RaisePropertyChanged("Erros");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoErro", Namespace="http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS")]
    [System.SerializableAttribute()]
    public partial class DtoErro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Nullable<int> LinhaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Nullable<int> Linha {
            get {
                return this.LinhaField;
            }
            set {
                if ((this.LinhaField.Equals(value) != true)) {
                    this.LinhaField = value;
                    this.RaisePropertyChanged("Linha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Mensagem {
            get {
                return this.MensagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemField, value) != true)) {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS", ConfigurationName="ValidadorDIME.ValidadorDimeSoap")]
    public interface ValidadorDimeSoap {
        
        // CODEGEN: Generating message contract since element name pDime from namespace http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS/Val" +
            "idarDime", ReplyAction="*")]
        ValidadorDIME.ValidarDimeResponse ValidarDime(ValidadorDIME.ValidarDimeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS/Val" +
            "idarDime", ReplyAction="*")]
        System.Threading.Tasks.Task<ValidadorDIME.ValidarDimeResponse> ValidarDimeAsync(ValidadorDIME.ValidarDimeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarDimeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarDime", Namespace="http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS", Order=0)]
        public ValidadorDIME.ValidarDimeRequestBody Body;
        
        public ValidarDimeRequest() {
        }
        
        public ValidarDimeRequest(ValidadorDIME.ValidarDimeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS")]
    public partial class ValidarDimeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string pDime;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pUsuario;
        
        public ValidarDimeRequestBody() {
        }
        
        public ValidarDimeRequestBody(string pDime, string pUsuario) {
            this.pDime = pDime;
            this.pUsuario = pUsuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidarDimeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidarDimeResponse", Namespace="http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS", Order=0)]
        public ValidadorDIME.ValidarDimeResponseBody Body;
        
        public ValidarDimeResponse() {
        }
        
        public ValidarDimeResponse(ValidadorDIME.ValidarDimeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://webservices.sathomologa.sef.sc.gov.br/Sat.Declaracao.Dime.Validador.WS")]
    public partial class ValidarDimeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ValidadorDIME.DtoRetorno ValidarDimeResult;
        
        public ValidarDimeResponseBody() {
        }
        
        public ValidarDimeResponseBody(ValidadorDIME.DtoRetorno ValidarDimeResult) {
            this.ValidarDimeResult = ValidarDimeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ValidadorDimeSoapChannel : ValidadorDIME.ValidadorDimeSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ValidadorDimeSoapClient : System.ServiceModel.ClientBase<ValidadorDIME.ValidadorDimeSoap>, ValidadorDIME.ValidadorDimeSoap {
        
        public ValidadorDimeSoapClient() {
        }
        
        public ValidadorDimeSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ValidadorDimeSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidadorDimeSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ValidadorDimeSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ValidadorDIME.ValidarDimeResponse ValidadorDIME.ValidadorDimeSoap.ValidarDime(ValidadorDIME.ValidarDimeRequest request) {
            return base.Channel.ValidarDime(request);
        }
        
        public ValidadorDIME.DtoRetorno ValidarDime(string pDime, string pUsuario) {
            ValidadorDIME.ValidarDimeRequest inValue = new ValidadorDIME.ValidarDimeRequest();
            inValue.Body = new ValidadorDIME.ValidarDimeRequestBody();
            inValue.Body.pDime = pDime;
            inValue.Body.pUsuario = pUsuario;
            ValidadorDIME.ValidarDimeResponse retVal = ((ValidadorDIME.ValidadorDimeSoap)(this)).ValidarDime(inValue);
            return retVal.Body.ValidarDimeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ValidadorDIME.ValidarDimeResponse> ValidadorDIME.ValidadorDimeSoap.ValidarDimeAsync(ValidadorDIME.ValidarDimeRequest request) {
            return base.Channel.ValidarDimeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ValidadorDIME.ValidarDimeResponse> ValidarDimeAsync(string pDime, string pUsuario) {
            ValidadorDIME.ValidarDimeRequest inValue = new ValidadorDIME.ValidarDimeRequest();
            inValue.Body = new ValidadorDIME.ValidarDimeRequestBody();
            inValue.Body.pDime = pDime;
            inValue.Body.pUsuario = pUsuario;
            return ((ValidadorDIME.ValidadorDimeSoap)(this)).ValidarDimeAsync(inValue);
        }
    }
}