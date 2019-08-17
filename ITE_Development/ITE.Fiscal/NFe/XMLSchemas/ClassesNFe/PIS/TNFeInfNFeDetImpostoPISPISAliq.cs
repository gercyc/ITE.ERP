namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Código de Situação Tributária do PIS.
    /// 01 – Operação Tributável - Base de Cálculo = Valor da Operação Alíquota Normal(Cumulativo/Não Cumulativo);
    /// 02 - Operação Tributável - Base de Calculo = Valor da Operação(Alíquota Diferenciada);
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISAliq
    {

        private string cSTField;

        private string vBCField;

        private string pPISField;

        private string vPISField;

        /// <summary>
        /// Codigo CST do PIS Tributado. 01 ou 02
        /// </summary>
        public string CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        /// <summary>
        /// Valor da base de calculo do PIS tributado
        /// </summary>
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        /// <summary>
        /// Valor da aliquota do PIS em percentual
        /// </summary>
        public string pPIS
        {
            get
            {
                return this.pPISField;
            }
            set
            {
                this.pPISField = value;
            }
        }

        /// <summary>
        /// Valor do PIS 
        /// </summary>
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }
}