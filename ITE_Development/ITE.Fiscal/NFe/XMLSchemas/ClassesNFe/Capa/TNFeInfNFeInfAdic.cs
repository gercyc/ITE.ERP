namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdic {
    
        private string infAdFiscoField;
    
        private string infCplField;
    
        private TNFeInfNFeInfAdicObsCont[] obsContField;
    
        private TNFeInfNFeInfAdicObsFisco[] obsFiscoField;
    
        private TNFeInfNFeInfAdicProcRef[] procRefField;
    
        /// <remarks/>
        public string infAdFisco {
            get {
                return this.infAdFiscoField;
            }
            set {
                this.infAdFiscoField = value;
            }
        }
    
        /// <remarks/>
        public string infCpl {
            get {
                return this.infCplField;
            }
            set {
                this.infCplField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("obsCont")]
        public TNFeInfNFeInfAdicObsCont[] obsCont {
            get {
                return this.obsContField;
            }
            set {
                this.obsContField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("obsFisco")]
        public TNFeInfNFeInfAdicObsFisco[] obsFisco {
            get {
                return this.obsFiscoField;
            }
            set {
                this.obsFiscoField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("procRef")]
        public TNFeInfNFeInfAdicProcRef[] procRef {
            get {
                return this.procRefField;
            }
            set {
                this.procRefField = value;
            }
        }
    }
}