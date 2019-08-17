namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNFP {
    
        private TCodUfIBGE cUFField;
    
        private string aAMMField;
    
        private string itemField;
    
        private ItemChoiceType itemElementNameField;
    
        private string ieField;
    
        private TNFeInfNFeIdeNFrefRefNFPMod modField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    
        /// <remarks/>
        public string IE {
            get {
                return this.ieField;
            }
            set {
                this.ieField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeIdeNFrefRefNFPMod mod {
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