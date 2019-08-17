namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePagDetPag {
    
        private TNFeInfNFePagDetPagTPag tPagField;
    
        private string vPagField;
    
        private TNFeInfNFePagDetPagCard cardField;
    
        /// <remarks/>
        public TNFeInfNFePagDetPagTPag tPag {
            get {
                return this.tPagField;
            }
            set {
                this.tPagField = value;
            }
        }
    
        /// <remarks/>
        public string vPag {
            get {
                return this.vPagField;
            }
            set {
                this.vPagField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFePagDetPagCard card {
            get {
                return this.cardField;
            }
            set {
                this.cardField = value;
            }
        }
    }
}