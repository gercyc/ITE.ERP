namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNF {
    
        private TCodUfIBGE cUFField;
    
        private string aAMMField;
    
        private string cNPJField;
    
        private TNFeInfNFeIdeNFrefRefNFMod modField;
    
        private string serieField;
    
        private string nNFField;
    
        /// <remarks/>
        public TCodUfIBGE cUF {
            get {
                return this.cUFField;
            }
            set {
                this.cUFField = value;
            }
        }
    
        /// <remarks/>
        public string AAMM {
            get {
                return this.aAMMField;
            }
            set {
                this.aAMMField = value;
            }
        }
    
        /// <remarks/>
        public string CNPJ {
            get {
                return this.cNPJField;
            }
            set {
                this.cNPJField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeIdeNFrefRefNFMod mod {
            get {
                return this.modField;
            }
            set {
                this.modField = value;
            }
        }
    
        /// <remarks/>
        public string serie {
            get {
                return this.serieField;
            }
            set {
                this.serieField = value;
            }
        }
    
        /// <remarks/>
        public string nNF {
            get {
                return this.nNFField;
            }
            set {
                this.nNFField = value;
            }
        }
    }
}