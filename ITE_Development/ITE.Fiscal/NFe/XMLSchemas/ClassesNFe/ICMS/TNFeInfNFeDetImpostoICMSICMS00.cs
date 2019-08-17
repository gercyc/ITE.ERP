namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Tributação pelo ICMS00 - Tributada integralmente
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS00
    {

        private Torig origField;

        private string cSTField;

        private TypeModalidadeBaseCalculoICMS modBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private string pFCPField;

        private string vFCPField;

        /// <summary>
        ///Origem da mercadoria ICMS 00: 
        ///0 - Nacional 
        ///1 - Estrangeira - Importação direta 
        ///2 - Estrangeira - Adquirida no mercado interno
        /// </summary>
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        /// <summary>
        /// Código da situação tributária CST ICMS
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
        /// Modalidade de determinação da BC do ICMS:
        /// 0 - Margem Valor Agregado(%);
        /// 1 - Pauta(valor);
        /// 2 - Preço Tabelado Máximo(valor);
        /// 3 - Valor da Operação.
        /// </summary>
        public TypeModalidadeBaseCalculoICMS modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        /// <summary>
        /// Valor da BC do ICMS
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
        /// Alíquota do ICMS
        /// </summary>
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        /// <summary>
        /// Valor do ICMS
        /// </summary>
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        /// <summary>
        /// Percentual de ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        public string pFCP
        {
            get
            {
                return this.pFCPField;
            }
            set
            {
                this.pFCPField = value;
            }
        }

        /// <summary>
        /// Valor do ICMS relativo ao Fundo de Combate à Pobreza (FCP).
        /// </summary>
        public string vFCP
        {
            get
            {
                return this.vFCPField;
            }
            set
            {
                this.vFCPField = value;
            }
        }
    }
}