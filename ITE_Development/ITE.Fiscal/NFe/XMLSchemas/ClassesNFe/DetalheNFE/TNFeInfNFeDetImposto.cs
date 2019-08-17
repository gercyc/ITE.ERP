namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Tributos incidentes nos produtos ou serviços da NF-e
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImposto {
    
        private string vTotTribField;
    
        private object[] itemsField;
    
        private TNFeInfNFeDetImpostoPIS pISField;
    
        private TNFeInfNFeDetImpostoPISST pISSTField;
    
        private TNFeInfNFeDetImpostoCOFINS cOFINSField;
    
        private TNFeInfNFeDetImpostoCOFINSST cOFINSSTField;
    
        private TNFeInfNFeDetImpostoICMSUFDest iCMSUFDestField;
    
        /// <remarks/>
        public string vTotTrib {
            get {
                return this.vTotTribField;
            }
            set {
                this.vTotTribField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ICMS", typeof(TNFeInfNFeDetImpostoICMS))]
        [System.Xml.Serialization.XmlElementAttribute("II", typeof(TNFeInfNFeDetImpostoII))]
        [System.Xml.Serialization.XmlElementAttribute("IPI", typeof(TIpi))]
        [System.Xml.Serialization.XmlElementAttribute("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeDetImpostoPIS PIS {
            get {
                return this.pISField;
            }
            set {
                this.pISField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeDetImpostoPISST PISST {
            get {
                return this.pISSTField;
            }
            set {
                this.pISSTField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINS COFINS {
            get {
                return this.cOFINSField;
            }
            set {
                this.cOFINSField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSST COFINSST {
            get {
                return this.cOFINSSTField;
            }
            set {
                this.cOFINSSTField = value;
            }
        }
    
        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSUFDest ICMSUFDest {
            get {
                return this.iCMSUFDestField;
            }
            set {
                this.iCMSUFDestField = value;
            }
        }
    }
}