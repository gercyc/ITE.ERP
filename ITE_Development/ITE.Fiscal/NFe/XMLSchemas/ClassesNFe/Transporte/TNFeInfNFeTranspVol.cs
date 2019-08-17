namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVol {
    
        private string qVolField;
    
        private string espField;
    
        private string marcaField;
    
        private string nVolField;
    
        private string pesoLField;
    
        private string pesoBField;
    
        private TNFeInfNFeTranspVolLacres[] lacresField;
    
        /// <remarks/>
        public string qVol {
            get {
                return this.qVolField;
            }
            set {
                this.qVolField = value;
            }
        }
    
        /// <remarks/>
        public string esp {
            get {
                return this.espField;
            }
            set {
                this.espField = value;
            }
        }
    
        /// <remarks/>
        public string marca {
            get {
                return this.marcaField;
            }
            set {
                this.marcaField = value;
            }
        }
    
        /// <remarks/>
        public string nVol {
            get {
                return this.nVolField;
            }
            set {
                this.nVolField = value;
            }
        }
    
        /// <remarks/>
        public string pesoL {
            get {
                return this.pesoLField;
            }
            set {
                this.pesoLField = value;
            }
        }
    
        /// <remarks/>
        public string pesoB {
            get {
                return this.pesoBField;
            }
            set {
                this.pesoBField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lacres")]
        public TNFeInfNFeTranspVolLacres[] lacres {
            get {
                return this.lacresField;
            }
            set {
                this.lacresField = value;
            }
        }
    }
}