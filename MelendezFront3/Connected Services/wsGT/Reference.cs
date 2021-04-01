﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MelendezFront3.wsGT {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://generictransfer.com/", ConfigurationName="wsGT.wsGenerarPlanoSoap")]
    public interface wsGenerarPlanoSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/GenerarPlanoXML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MelendezFront3.wsGT.GenerarPlanoXMLResponse GenerarPlanoXML(MelendezFront3.wsGT.GenerarPlanoXMLRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/GenerarPlanoXML", ReplyAction="*")]
        System.Threading.Tasks.Task<MelendezFront3.wsGT.GenerarPlanoXMLResponse> GenerarPlanoXMLAsync(MelendezFront3.wsGT.GenerarPlanoXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/ImportarDatosXML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MelendezFront3.wsGT.ImportarDatosXMLResponse ImportarDatosXML(MelendezFront3.wsGT.ImportarDatosXMLRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/ImportarDatosXML", ReplyAction="*")]
        System.Threading.Tasks.Task<MelendezFront3.wsGT.ImportarDatosXMLResponse> ImportarDatosXMLAsync(MelendezFront3.wsGT.ImportarDatosXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/ImportarDatosDS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MelendezFront3.wsGT.ImportarDatosDSResponse ImportarDatosDS(MelendezFront3.wsGT.ImportarDatosDSRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/ImportarDatosDS", ReplyAction="*")]
        System.Threading.Tasks.Task<MelendezFront3.wsGT.ImportarDatosDSResponse> ImportarDatosDSAsync(MelendezFront3.wsGT.ImportarDatosDSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/ImportarDatosTablasXML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MelendezFront3.wsGT.ImportarDatosTablasXMLResponse ImportarDatosTablasXML(MelendezFront3.wsGT.ImportarDatosTablasXMLRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/ImportarDatosTablasXML", ReplyAction="*")]
        System.Threading.Tasks.Task<MelendezFront3.wsGT.ImportarDatosTablasXMLResponse> ImportarDatosTablasXMLAsync(MelendezFront3.wsGT.ImportarDatosTablasXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/ImportarDatosTablasDS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MelendezFront3.wsGT.ImportarDatosTablasDSResponse ImportarDatosTablasDS(MelendezFront3.wsGT.ImportarDatosTablasDSRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://generictransfer.com/ImportarDatosTablasDS", ReplyAction="*")]
        System.Threading.Tasks.Task<MelendezFront3.wsGT.ImportarDatosTablasDSResponse> ImportarDatosTablasDSAsync(MelendezFront3.wsGT.ImportarDatosTablasDSRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GenerarPlanoXML", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class GenerarPlanoXMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public int idDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string strNombreDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=2)]
        public int idCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=3)]
        public string strCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=4)]
        public string strUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=5)]
        public string strClave;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=6)]
        public System.Data.DataSet dsFuenteDatos;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=7)]
        public string Path;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=8)]
        public string strResultado;
        
        public GenerarPlanoXMLRequest() {
        }
        
        public GenerarPlanoXMLRequest(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, System.Data.DataSet dsFuenteDatos, string Path, string strResultado) {
            this.idDocumento = idDocumento;
            this.strNombreDocumento = strNombreDocumento;
            this.idCompania = idCompania;
            this.strCompania = strCompania;
            this.strUsuario = strUsuario;
            this.strClave = strClave;
            this.dsFuenteDatos = dsFuenteDatos;
            this.Path = Path;
            this.strResultado = strResultado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GenerarPlanoXMLResponse", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class GenerarPlanoXMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public string GenerarPlanoXMLResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string Path;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=2)]
        public string strResultado;
        
        public GenerarPlanoXMLResponse() {
        }
        
        public GenerarPlanoXMLResponse(string GenerarPlanoXMLResult, string Path, string strResultado) {
            this.GenerarPlanoXMLResult = GenerarPlanoXMLResult;
            this.Path = Path;
            this.strResultado = strResultado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImportarDatosXML", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class ImportarDatosXMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public int idDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string strNombreDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=2)]
        public int idCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=3)]
        public string strCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=4)]
        public string strUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=5)]
        public string strClave;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=6)]
        public string strFuenteDatos;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=7)]
        public string Path;
        
        public ImportarDatosXMLRequest() {
        }
        
        public ImportarDatosXMLRequest(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, string strFuenteDatos, string Path) {
            this.idDocumento = idDocumento;
            this.strNombreDocumento = strNombreDocumento;
            this.idCompania = idCompania;
            this.strCompania = strCompania;
            this.strUsuario = strUsuario;
            this.strClave = strClave;
            this.strFuenteDatos = strFuenteDatos;
            this.Path = Path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImportarDatosXMLResponse", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class ImportarDatosXMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public string ImportarDatosXMLResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string Path;
        
        public ImportarDatosXMLResponse() {
        }
        
        public ImportarDatosXMLResponse(string ImportarDatosXMLResult, string Path) {
            this.ImportarDatosXMLResult = ImportarDatosXMLResult;
            this.Path = Path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImportarDatosDS", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class ImportarDatosDSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public int idDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string strNombreDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=2)]
        public int idCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=3)]
        public string strCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=4)]
        public string strUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=5)]
        public string strClave;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=6)]
        public System.Data.DataSet dsFuenteDatos;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=7)]
        public string Path;
        
        public ImportarDatosDSRequest() {
        }
        
        public ImportarDatosDSRequest(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, System.Data.DataSet dsFuenteDatos, string Path) {
            this.idDocumento = idDocumento;
            this.strNombreDocumento = strNombreDocumento;
            this.idCompania = idCompania;
            this.strCompania = strCompania;
            this.strUsuario = strUsuario;
            this.strClave = strClave;
            this.dsFuenteDatos = dsFuenteDatos;
            this.Path = Path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImportarDatosDSResponse", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class ImportarDatosDSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public string ImportarDatosDSResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string Path;
        
        public ImportarDatosDSResponse() {
        }
        
        public ImportarDatosDSResponse(string ImportarDatosDSResult, string Path) {
            this.ImportarDatosDSResult = ImportarDatosDSResult;
            this.Path = Path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImportarDatosTablasXML", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class ImportarDatosTablasXMLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public int idDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string strNombreDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=2)]
        public int idCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=3)]
        public string strCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=4)]
        public string strUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=5)]
        public string strClave;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=6)]
        public string strFuenteDatos;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=7)]
        public string tsProceso;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=8)]
        public string Path;
        
        public ImportarDatosTablasXMLRequest() {
        }
        
        public ImportarDatosTablasXMLRequest(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, string strFuenteDatos, string tsProceso, string Path) {
            this.idDocumento = idDocumento;
            this.strNombreDocumento = strNombreDocumento;
            this.idCompania = idCompania;
            this.strCompania = strCompania;
            this.strUsuario = strUsuario;
            this.strClave = strClave;
            this.strFuenteDatos = strFuenteDatos;
            this.tsProceso = tsProceso;
            this.Path = Path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImportarDatosTablasXMLResponse", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class ImportarDatosTablasXMLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public string ImportarDatosTablasXMLResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string Path;
        
        public ImportarDatosTablasXMLResponse() {
        }
        
        public ImportarDatosTablasXMLResponse(string ImportarDatosTablasXMLResult, string Path) {
            this.ImportarDatosTablasXMLResult = ImportarDatosTablasXMLResult;
            this.Path = Path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImportarDatosTablasDS", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class ImportarDatosTablasDSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public int idDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string strNombreDocumento;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=2)]
        public int idCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=3)]
        public string strCompania;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=4)]
        public string strUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=5)]
        public string strClave;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=6)]
        public System.Data.DataSet dsFuenteDatos;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=7)]
        public string tsProceso;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=8)]
        public string Path;
        
        public ImportarDatosTablasDSRequest() {
        }
        
        public ImportarDatosTablasDSRequest(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, System.Data.DataSet dsFuenteDatos, string tsProceso, string Path) {
            this.idDocumento = idDocumento;
            this.strNombreDocumento = strNombreDocumento;
            this.idCompania = idCompania;
            this.strCompania = strCompania;
            this.strUsuario = strUsuario;
            this.strClave = strClave;
            this.dsFuenteDatos = dsFuenteDatos;
            this.tsProceso = tsProceso;
            this.Path = Path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ImportarDatosTablasDSResponse", WrapperNamespace="http://generictransfer.com/", IsWrapped=true)]
    public partial class ImportarDatosTablasDSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=0)]
        public string ImportarDatosTablasDSResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://generictransfer.com/", Order=1)]
        public string Path;
        
        public ImportarDatosTablasDSResponse() {
        }
        
        public ImportarDatosTablasDSResponse(string ImportarDatosTablasDSResult, string Path) {
            this.ImportarDatosTablasDSResult = ImportarDatosTablasDSResult;
            this.Path = Path;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsGenerarPlanoSoapChannel : MelendezFront3.wsGT.wsGenerarPlanoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsGenerarPlanoSoapClient : System.ServiceModel.ClientBase<MelendezFront3.wsGT.wsGenerarPlanoSoap>, MelendezFront3.wsGT.wsGenerarPlanoSoap {
        
        public wsGenerarPlanoSoapClient() {
        }
        
        public wsGenerarPlanoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsGenerarPlanoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsGenerarPlanoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsGenerarPlanoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MelendezFront3.wsGT.GenerarPlanoXMLResponse MelendezFront3.wsGT.wsGenerarPlanoSoap.GenerarPlanoXML(MelendezFront3.wsGT.GenerarPlanoXMLRequest request) {
            return base.Channel.GenerarPlanoXML(request);
        }
        
        public string GenerarPlanoXML(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, System.Data.DataSet dsFuenteDatos, ref string Path, ref string strResultado) {
            MelendezFront3.wsGT.GenerarPlanoXMLRequest inValue = new MelendezFront3.wsGT.GenerarPlanoXMLRequest();
            inValue.idDocumento = idDocumento;
            inValue.strNombreDocumento = strNombreDocumento;
            inValue.idCompania = idCompania;
            inValue.strCompania = strCompania;
            inValue.strUsuario = strUsuario;
            inValue.strClave = strClave;
            inValue.dsFuenteDatos = dsFuenteDatos;
            inValue.Path = Path;
            inValue.strResultado = strResultado;
            MelendezFront3.wsGT.GenerarPlanoXMLResponse retVal = ((MelendezFront3.wsGT.wsGenerarPlanoSoap)(this)).GenerarPlanoXML(inValue);
            Path = retVal.Path;
            strResultado = retVal.strResultado;
            return retVal.GenerarPlanoXMLResult;
        }
        
        public System.Threading.Tasks.Task<MelendezFront3.wsGT.GenerarPlanoXMLResponse> GenerarPlanoXMLAsync(MelendezFront3.wsGT.GenerarPlanoXMLRequest request) {
            return base.Channel.GenerarPlanoXMLAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MelendezFront3.wsGT.ImportarDatosXMLResponse MelendezFront3.wsGT.wsGenerarPlanoSoap.ImportarDatosXML(MelendezFront3.wsGT.ImportarDatosXMLRequest request) {
            return base.Channel.ImportarDatosXML(request);
        }
        
        public string ImportarDatosXML(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, string strFuenteDatos, ref string Path) {
            MelendezFront3.wsGT.ImportarDatosXMLRequest inValue = new MelendezFront3.wsGT.ImportarDatosXMLRequest();
            inValue.idDocumento = idDocumento;
            inValue.strNombreDocumento = strNombreDocumento;
            inValue.idCompania = idCompania;
            inValue.strCompania = strCompania;
            inValue.strUsuario = strUsuario;
            inValue.strClave = strClave;
            inValue.strFuenteDatos = strFuenteDatos;
            inValue.Path = Path;
            MelendezFront3.wsGT.ImportarDatosXMLResponse retVal = ((MelendezFront3.wsGT.wsGenerarPlanoSoap)(this)).ImportarDatosXML(inValue);
            Path = retVal.Path;
            return retVal.ImportarDatosXMLResult;
        }
        
        public System.Threading.Tasks.Task<MelendezFront3.wsGT.ImportarDatosXMLResponse> ImportarDatosXMLAsync(MelendezFront3.wsGT.ImportarDatosXMLRequest request) {
            return base.Channel.ImportarDatosXMLAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MelendezFront3.wsGT.ImportarDatosDSResponse MelendezFront3.wsGT.wsGenerarPlanoSoap.ImportarDatosDS(MelendezFront3.wsGT.ImportarDatosDSRequest request) {
            return base.Channel.ImportarDatosDS(request);
        }
        
        public string ImportarDatosDS(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, System.Data.DataSet dsFuenteDatos, ref string Path) {
            MelendezFront3.wsGT.ImportarDatosDSRequest inValue = new MelendezFront3.wsGT.ImportarDatosDSRequest();
            inValue.idDocumento = idDocumento;
            inValue.strNombreDocumento = strNombreDocumento;
            inValue.idCompania = idCompania;
            inValue.strCompania = strCompania;
            inValue.strUsuario = strUsuario;
            inValue.strClave = strClave;
            inValue.dsFuenteDatos = dsFuenteDatos;
            inValue.Path = Path;
            MelendezFront3.wsGT.ImportarDatosDSResponse retVal = ((MelendezFront3.wsGT.wsGenerarPlanoSoap)(this)).ImportarDatosDS(inValue);
            Path = retVal.Path;
            return retVal.ImportarDatosDSResult;
        }
        
        public System.Threading.Tasks.Task<MelendezFront3.wsGT.ImportarDatosDSResponse> ImportarDatosDSAsync(MelendezFront3.wsGT.ImportarDatosDSRequest request) {
            return base.Channel.ImportarDatosDSAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MelendezFront3.wsGT.ImportarDatosTablasXMLResponse MelendezFront3.wsGT.wsGenerarPlanoSoap.ImportarDatosTablasXML(MelendezFront3.wsGT.ImportarDatosTablasXMLRequest request) {
            return base.Channel.ImportarDatosTablasXML(request);
        }
        
        public string ImportarDatosTablasXML(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, string strFuenteDatos, string tsProceso, ref string Path) {
            MelendezFront3.wsGT.ImportarDatosTablasXMLRequest inValue = new MelendezFront3.wsGT.ImportarDatosTablasXMLRequest();
            inValue.idDocumento = idDocumento;
            inValue.strNombreDocumento = strNombreDocumento;
            inValue.idCompania = idCompania;
            inValue.strCompania = strCompania;
            inValue.strUsuario = strUsuario;
            inValue.strClave = strClave;
            inValue.strFuenteDatos = strFuenteDatos;
            inValue.tsProceso = tsProceso;
            inValue.Path = Path;
            MelendezFront3.wsGT.ImportarDatosTablasXMLResponse retVal = ((MelendezFront3.wsGT.wsGenerarPlanoSoap)(this)).ImportarDatosTablasXML(inValue);
            Path = retVal.Path;
            return retVal.ImportarDatosTablasXMLResult;
        }
        
        public System.Threading.Tasks.Task<MelendezFront3.wsGT.ImportarDatosTablasXMLResponse> ImportarDatosTablasXMLAsync(MelendezFront3.wsGT.ImportarDatosTablasXMLRequest request) {
            return base.Channel.ImportarDatosTablasXMLAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MelendezFront3.wsGT.ImportarDatosTablasDSResponse MelendezFront3.wsGT.wsGenerarPlanoSoap.ImportarDatosTablasDS(MelendezFront3.wsGT.ImportarDatosTablasDSRequest request) {
            return base.Channel.ImportarDatosTablasDS(request);
        }
        
        public string ImportarDatosTablasDS(int idDocumento, string strNombreDocumento, int idCompania, string strCompania, string strUsuario, string strClave, System.Data.DataSet dsFuenteDatos, string tsProceso, ref string Path) {
            MelendezFront3.wsGT.ImportarDatosTablasDSRequest inValue = new MelendezFront3.wsGT.ImportarDatosTablasDSRequest();
            inValue.idDocumento = idDocumento;
            inValue.strNombreDocumento = strNombreDocumento;
            inValue.idCompania = idCompania;
            inValue.strCompania = strCompania;
            inValue.strUsuario = strUsuario;
            inValue.strClave = strClave;
            inValue.dsFuenteDatos = dsFuenteDatos;
            inValue.tsProceso = tsProceso;
            inValue.Path = Path;
            MelendezFront3.wsGT.ImportarDatosTablasDSResponse retVal = ((MelendezFront3.wsGT.wsGenerarPlanoSoap)(this)).ImportarDatosTablasDS(inValue);
            Path = retVal.Path;
            return retVal.ImportarDatosTablasDSResult;
        }
        
        public System.Threading.Tasks.Task<MelendezFront3.wsGT.ImportarDatosTablasDSResponse> ImportarDatosTablasDSAsync(MelendezFront3.wsGT.ImportarDatosTablasDSRequest request) {
            return base.Channel.ImportarDatosTablasDSAsync(request);
        }
    }
}