﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yakuza.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ExamenSoap")]
    public interface ExamenSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Yakuza.ServiceReference1.HelloWorldResponse HelloWorld(Yakuza.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Yakuza.ServiceReference1.HelloWorldResponse> HelloWorldAsync(Yakuza.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name nombre1 from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/compararCadenas", ReplyAction="*")]
        Yakuza.ServiceReference1.compararCadenasResponse compararCadenas(Yakuza.ServiceReference1.compararCadenasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/compararCadenas", ReplyAction="*")]
        System.Threading.Tasks.Task<Yakuza.ServiceReference1.compararCadenasResponse> compararCadenasAsync(Yakuza.ServiceReference1.compararCadenasRequest request);
        
        // CODEGEN: Generating message contract since element name showTipoDeTarjetasResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/showTipoDeTarjetas", ReplyAction="*")]
        Yakuza.ServiceReference1.showTipoDeTarjetasResponse showTipoDeTarjetas(Yakuza.ServiceReference1.showTipoDeTarjetasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/showTipoDeTarjetas", ReplyAction="*")]
        System.Threading.Tasks.Task<Yakuza.ServiceReference1.showTipoDeTarjetasResponse> showTipoDeTarjetasAsync(Yakuza.ServiceReference1.showTipoDeTarjetasRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Yakuza.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Yakuza.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Yakuza.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Yakuza.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class compararCadenasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="compararCadenas", Namespace="http://tempuri.org/", Order=0)]
        public Yakuza.ServiceReference1.compararCadenasRequestBody Body;
        
        public compararCadenasRequest() {
        }
        
        public compararCadenasRequest(Yakuza.ServiceReference1.compararCadenasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class compararCadenasRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre2;
        
        public compararCadenasRequestBody() {
        }
        
        public compararCadenasRequestBody(string nombre1, string nombre2) {
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class compararCadenasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="compararCadenasResponse", Namespace="http://tempuri.org/", Order=0)]
        public Yakuza.ServiceReference1.compararCadenasResponseBody Body;
        
        public compararCadenasResponse() {
        }
        
        public compararCadenasResponse(Yakuza.ServiceReference1.compararCadenasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class compararCadenasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string compararCadenasResult;
        
        public compararCadenasResponseBody() {
        }
        
        public compararCadenasResponseBody(string compararCadenasResult) {
            this.compararCadenasResult = compararCadenasResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class showTipoDeTarjetasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="showTipoDeTarjetas", Namespace="http://tempuri.org/", Order=0)]
        public Yakuza.ServiceReference1.showTipoDeTarjetasRequestBody Body;
        
        public showTipoDeTarjetasRequest() {
        }
        
        public showTipoDeTarjetasRequest(Yakuza.ServiceReference1.showTipoDeTarjetasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class showTipoDeTarjetasRequestBody {
        
        public showTipoDeTarjetasRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class showTipoDeTarjetasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="showTipoDeTarjetasResponse", Namespace="http://tempuri.org/", Order=0)]
        public Yakuza.ServiceReference1.showTipoDeTarjetasResponseBody Body;
        
        public showTipoDeTarjetasResponse() {
        }
        
        public showTipoDeTarjetasResponse(Yakuza.ServiceReference1.showTipoDeTarjetasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class showTipoDeTarjetasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Yakuza.ServiceReference1.ArrayOfString showTipoDeTarjetasResult;
        
        public showTipoDeTarjetasResponseBody() {
        }
        
        public showTipoDeTarjetasResponseBody(Yakuza.ServiceReference1.ArrayOfString showTipoDeTarjetasResult) {
            this.showTipoDeTarjetasResult = showTipoDeTarjetasResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ExamenSoapChannel : Yakuza.ServiceReference1.ExamenSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExamenSoapClient : System.ServiceModel.ClientBase<Yakuza.ServiceReference1.ExamenSoap>, Yakuza.ServiceReference1.ExamenSoap {
        
        public ExamenSoapClient() {
        }
        
        public ExamenSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExamenSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExamenSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExamenSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Yakuza.ServiceReference1.HelloWorldResponse Yakuza.ServiceReference1.ExamenSoap.HelloWorld(Yakuza.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Yakuza.ServiceReference1.HelloWorldRequest inValue = new Yakuza.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Yakuza.ServiceReference1.HelloWorldRequestBody();
            Yakuza.ServiceReference1.HelloWorldResponse retVal = ((Yakuza.ServiceReference1.ExamenSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Yakuza.ServiceReference1.HelloWorldResponse> Yakuza.ServiceReference1.ExamenSoap.HelloWorldAsync(Yakuza.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Yakuza.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            Yakuza.ServiceReference1.HelloWorldRequest inValue = new Yakuza.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Yakuza.ServiceReference1.HelloWorldRequestBody();
            return ((Yakuza.ServiceReference1.ExamenSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Yakuza.ServiceReference1.compararCadenasResponse Yakuza.ServiceReference1.ExamenSoap.compararCadenas(Yakuza.ServiceReference1.compararCadenasRequest request) {
            return base.Channel.compararCadenas(request);
        }
        
        public string compararCadenas(string nombre1, string nombre2) {
            Yakuza.ServiceReference1.compararCadenasRequest inValue = new Yakuza.ServiceReference1.compararCadenasRequest();
            inValue.Body = new Yakuza.ServiceReference1.compararCadenasRequestBody();
            inValue.Body.nombre1 = nombre1;
            inValue.Body.nombre2 = nombre2;
            Yakuza.ServiceReference1.compararCadenasResponse retVal = ((Yakuza.ServiceReference1.ExamenSoap)(this)).compararCadenas(inValue);
            return retVal.Body.compararCadenasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Yakuza.ServiceReference1.compararCadenasResponse> Yakuza.ServiceReference1.ExamenSoap.compararCadenasAsync(Yakuza.ServiceReference1.compararCadenasRequest request) {
            return base.Channel.compararCadenasAsync(request);
        }
        
        public System.Threading.Tasks.Task<Yakuza.ServiceReference1.compararCadenasResponse> compararCadenasAsync(string nombre1, string nombre2) {
            Yakuza.ServiceReference1.compararCadenasRequest inValue = new Yakuza.ServiceReference1.compararCadenasRequest();
            inValue.Body = new Yakuza.ServiceReference1.compararCadenasRequestBody();
            inValue.Body.nombre1 = nombre1;
            inValue.Body.nombre2 = nombre2;
            return ((Yakuza.ServiceReference1.ExamenSoap)(this)).compararCadenasAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Yakuza.ServiceReference1.showTipoDeTarjetasResponse Yakuza.ServiceReference1.ExamenSoap.showTipoDeTarjetas(Yakuza.ServiceReference1.showTipoDeTarjetasRequest request) {
            return base.Channel.showTipoDeTarjetas(request);
        }
        
        public Yakuza.ServiceReference1.ArrayOfString showTipoDeTarjetas() {
            Yakuza.ServiceReference1.showTipoDeTarjetasRequest inValue = new Yakuza.ServiceReference1.showTipoDeTarjetasRequest();
            inValue.Body = new Yakuza.ServiceReference1.showTipoDeTarjetasRequestBody();
            Yakuza.ServiceReference1.showTipoDeTarjetasResponse retVal = ((Yakuza.ServiceReference1.ExamenSoap)(this)).showTipoDeTarjetas(inValue);
            return retVal.Body.showTipoDeTarjetasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Yakuza.ServiceReference1.showTipoDeTarjetasResponse> Yakuza.ServiceReference1.ExamenSoap.showTipoDeTarjetasAsync(Yakuza.ServiceReference1.showTipoDeTarjetasRequest request) {
            return base.Channel.showTipoDeTarjetasAsync(request);
        }
        
        public System.Threading.Tasks.Task<Yakuza.ServiceReference1.showTipoDeTarjetasResponse> showTipoDeTarjetasAsync() {
            Yakuza.ServiceReference1.showTipoDeTarjetasRequest inValue = new Yakuza.ServiceReference1.showTipoDeTarjetasRequest();
            inValue.Body = new Yakuza.ServiceReference1.showTipoDeTarjetasRequestBody();
            return ((Yakuza.ServiceReference1.ExamenSoap)(this)).showTipoDeTarjetasAsync(inValue);
        }
    }
}
