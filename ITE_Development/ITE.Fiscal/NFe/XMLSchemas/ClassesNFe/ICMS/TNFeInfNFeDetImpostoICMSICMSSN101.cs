namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN101 {
    
        private Torig origField;
    
        private TNFeInfNFeDetImpostoICMSICMSSN101CSOSN cSOSNField;
    
        private string pCredSNField;
    
        private string vCredICMSSNField;
    
        /// <remarks/>
        public Torig orig {
            get {
                return this.origField;
            }
            set {
                this.origField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN {
            get {
                return this.cSOSNField;
            }
            set {
                this.cSOSNField = value;
            }
        }
    
        /// <remarks/>
        public string pCredSN {
            get {
                return this.pCredSNField;
            }
            set {
                this.pCredSNField = value;
            }
        }
    
        /// <remarks/>
        public string vCredICMSSN {
            get {
                return this.vCredICMSSNField;
            }
            set {
                this.vCredICMSSNField = value;
            }
        }
    }
}