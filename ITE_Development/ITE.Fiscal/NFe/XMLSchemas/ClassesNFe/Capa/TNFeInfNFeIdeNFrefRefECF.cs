namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefECF {
    
        private TNFeInfNFeIdeNFrefRefECFMod modField;
    
        private string nECFField;
    
        private string nCOOField;
    
        /// <remarks/>
        public TNFeInfNFeIdeNFrefRefECFMod mod {
            get {
                return this.modField;
            }
            set {
                this.modField = value;
            }
        }
    
        /// <remarks/>
        public string nECF {
            get {
                return this.nECFField;
            }
            set {
                this.nECFField = value;
            }
        }
    
        /// <remarks/>
        public string nCOO {
            get {
                return this.nCOOField;
            }
            set {
                this.nCOOField = value;
            }
        }
    }
}