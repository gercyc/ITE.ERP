namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TVeiculo {
    
        private string placaField;
    
        private TUf ufField;
    
        private string rNTCField;
    
        /// <remarks/>
        public string placa {
            get {
                return this.placaField;
            }
            set {
                this.placaField = value;
            }
        }
    
        /// <remarks/>
        public TUf UF {
            get {
                return this.ufField;
            }
            set {
                this.ufField = value;
            }
        }
    
        /// <remarks/>
        public string RNTC {
            get {
                return this.rNTCField;
            }
            set {
                this.rNTCField = value;
            }
        }
    }
}