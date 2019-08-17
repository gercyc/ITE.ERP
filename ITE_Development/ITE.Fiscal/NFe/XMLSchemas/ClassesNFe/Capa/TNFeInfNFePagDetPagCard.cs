namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePagDetPagCard {
    
        private TNFeInfNFePagDetPagCardTpIntegra tpIntegraField;
    
        private string cNPJField;
    
        private TNFeInfNFePagDetPagCardTBand tBandField;
    
        private bool tBandFieldSpecified;
    
        private string cAutField;
    
        /// <remarks/>
        public TNFeInfNFePagDetPagCardTpIntegra tpIntegra {
            get {
                return this.tpIntegraField;
            }
            set {
                this.tpIntegraField = value;
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
        public TNFeInfNFePagDetPagCardTBand tBand {
            get {
                return this.tBandField;
            }
            set {
                this.tBandField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tBandSpecified {
            get {
                return this.tBandFieldSpecified;
            }
            set {
                this.tBandFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public string cAut {
            get {
                return this.cAutField;
            }
            set {
                this.cAutField = value;
            }
        }
    }
}