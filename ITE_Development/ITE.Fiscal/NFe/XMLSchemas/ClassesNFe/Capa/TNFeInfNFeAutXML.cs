namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Pessoas autorizadas para o download do XML da NF-e
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAutXML {
    
        private string descTipoDocAutXmlField;
    
        private TipoDocAutXml tipoDocAutXmlField;
    
        /// <summary>
        /// Descricao do Tipo de documento da pessoa autorizada a baixar o xml
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("TipoDocAutXml")]
        public string DescTipoDocAutXml
        {
            get {
                return this.descTipoDocAutXmlField;
            }
            set {
                this.descTipoDocAutXmlField = value;
            }
        }

        /// <summary>
        /// Descricao do Tipo de documento da pessoa autorizada a baixar o xml
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public TipoDocAutXml TipoDocAutXml
        {
            get {
                return this.tipoDocAutXmlField;
            }
            set {
                this.tipoDocAutXmlField = value;
            }
        }
    }
}