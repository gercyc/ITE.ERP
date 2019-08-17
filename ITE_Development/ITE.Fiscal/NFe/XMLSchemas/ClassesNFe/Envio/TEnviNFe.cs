namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Tipo Pedido de Concessão de Autorização da Nota Fiscal Eletrônica (Lote)
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("enviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TEnviNFe
    {

        private string idLoteField;

        private TEnviNFeIndSinc indSincField;

        private TNFe[] nFeField;

        private string versaoField;

        /// <summary>
        /// Id do lote.
        /// </summary>
        public string idLote
        {
            get
            {
                return this.idLoteField;
            }
            set
            {
                this.idLoteField = value;
            }
        }

        /// <summary>
        /// Indicador de processamento síncrono. 0=NÃO; 1=SIM=Síncrono
        /// </summary>
        public TEnviNFeIndSinc indSinc
        {
            get
            {
                return this.indSincField;
            }
            set
            {
                this.indSincField = value;
            }
        }

        /// <summary>
        /// Notas fiscais que pertencem ao lote
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("NFe")]
        public TNFe[] NFe
        {
            get
            {
                return this.nFeField;
            }
            set
            {
                this.nFeField = value;
            }
        }

        /// <summary>
        /// Versao do layout
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }
}