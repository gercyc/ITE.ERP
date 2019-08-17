namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdArma {
    
        private TNFeInfNFeDetProdArmaTpArma tpArmaField;
    
        private string nSerieField;
    
        private string nCanoField;
    
        private string descrField;
    
        /// <remarks/>
        public TNFeInfNFeDetProdArmaTpArma tpArma {
            get {
                return this.tpArmaField;
            }
            set {
                this.tpArmaField = value;
            }
        }
    
        /// <remarks/>
        public string nSerie {
            get {
                return this.nSerieField;
            }
            set {
                this.nSerieField = value;
            }
        }
    
        /// <remarks/>
        public string nCano {
            get {
                return this.nCanoField;
            }
            set {
                this.nCanoField = value;
            }
        }
    
        /// <remarks/>
        public string descr {
            get {
                return this.descrField;
            }
            set {
                this.descrField = value;
            }
        }
    }
}