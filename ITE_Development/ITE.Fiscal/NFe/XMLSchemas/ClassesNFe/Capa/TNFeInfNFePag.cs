namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePag {
    
        private TNFeInfNFePagDetPag[] detPagField;
    
        private string vTrocoField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("detPag")]
        public TNFeInfNFePagDetPag[] detPag {
            get {
                return this.detPagField;
            }
            set {
                this.detPagField = value;
            }
        }
    
        /// <remarks/>
        public string vTroco {
            get {
                return this.vTrocoField;
            }
            set {
                this.vTrocoField = value;
            }
        }
    }
}