﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.34209
//
//     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
//     o código for regenerado.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 
namespace SolRia.Erp.MobileApp.Models.Saft {
    using System.Xml.Serialization;
    
    
    /// <observações/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://servicos.portaldasfinancas.gov.pt/sgdtpf/fileProcessingResult/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="https://servicos.portaldasfinancas.gov.pt/sgdtpf/fileProcessingResult/", IsNullable=false)]
    public partial class FileProcResult {
        
        private DocumentInfoType[] documentInfoField;
        
        private ErrorType[] errorField;
        
        /// <observações/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentInfo")]
        public DocumentInfoType[] DocumentInfo {
            get {
                return this.documentInfoField;
            }
            set {
                this.documentInfoField = value;
            }
        }
        
        /// <observações/>
        [System.Xml.Serialization.XmlElementAttribute("Error")]
        public ErrorType[] Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
    }
    
    /// <observações/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://servicos.portaldasfinancas.gov.pt/sgdtpf/fileProcessingResult/")]
    public partial class DocumentInfoType {
        
        private string documentNumberField;
        
        private string aTDocCodeIDField;
        
        /// <observações/>
        public string DocumentNumber {
            get {
                return this.documentNumberField;
            }
            set {
                this.documentNumberField = value;
            }
        }
        
        /// <observações/>
        public string ATDocCodeID {
            get {
                return this.aTDocCodeIDField;
            }
            set {
                this.aTDocCodeIDField = value;
            }
        }
    }
    
    /// <observações/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://servicos.portaldasfinancas.gov.pt/sgdtpf/fileProcessingResult/")]
    public partial class ErrorType {
        
        private string errorMessageField;
        
        private long lineNumberField;
        
        /// <observações/>
        public string ErrorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
            }
        }
        
        /// <observações/>
        public long LineNumber {
            get {
                return this.lineNumberField;
            }
            set {
                this.lineNumberField = value;
            }
        }
    }
}
