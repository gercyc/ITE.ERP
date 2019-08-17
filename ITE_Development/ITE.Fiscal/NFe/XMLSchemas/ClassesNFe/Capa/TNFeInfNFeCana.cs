namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCana {
    
        private string safraField;
    
        private string refField;
    
        private TNFeInfNFeCanaForDia[] forDiaField;
    
        private string qTotMesField;
    
        private string qTotAntField;
    
        private string qTotGerField;
    
        private TNFeInfNFeCanaDeduc[] deducField;
    
        private string vForField;
    
        private string vTotDedField;
    
        private string vLiqForField;
    
        /// <remarks/>
        public string safra {
            get {
                return this.safraField;
            }
            set {
                this.safraField = value;
            }
        }
    
        /// <remarks/>
        public string @ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("forDia")]
        public TNFeInfNFeCanaForDia[] forDia {
            get {
                return this.forDiaField;
            }
            set {
                this.forDiaField = value;
            }
        }
    
        /// <remarks/>
        public string qTotMes {
            get {
                return this.qTotMesField;
            }
            set {
                this.qTotMesField = value;
            }
        }
    
        /// <remarks/>
        public string qTotAnt {
            get {
                return this.qTotAntField;
            }
            set {
                this.qTotAntField = value;
            }
        }
    
        /// <remarks/>
        public string qTotGer {
            get {
                return this.qTotGerField;
            }
            set {
                this.qTotGerField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deduc")]
        public TNFeInfNFeCanaDeduc[] deduc {
            get {
                return this.deducField;
            }
            set {
                this.deducField = value;
            }
        }
    
        /// <remarks/>
        public string vFor {
            get {
                return this.vForField;
            }
            set {
                this.vForField = value;
            }
        }
    
        /// <remarks/>
        public string vTotDed {
            get {
                return this.vTotDedField;
            }
            set {
                this.vTotDedField = value;
            }
        }
    
        /// <remarks/>
        public string vLiqFor {
            get {
                return this.vLiqForField;
            }
            set {
                this.vLiqForField = value;
            }
        }
    }
}