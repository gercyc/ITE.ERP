namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Tributação pelo ICMS 40
    /// 40 - Isenta 
    /// 41 - Não tributada
    /// 50 - Suspensão
    /// 51 - Diferimento
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS40
    {

        private Torig origField;

        private string cSTField;

        private string vICMSDesonField;

        private TypeMotivoDesoneracaoICMS40 motDesICMSField;

        /// <summary>
        ///Origem da mercadoria ICMS 30: 
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
        /// Tributação pelo ICMS 
        ///40 - Isenta 
        ///41 - Não tributada 
        ///50 - Suspensão 
        ///51 - Diferimento
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
        /// O valor do ICMS será informado apenas nas operações com veículos beneficiados com a desoneração condicional do ICMS.
        /// </summary>
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        /// <summary>
        /// Este campo será preenchido quando o campo anterior estiver preenchido.
        ///Informar o motivo da desoneração:
        ///1 – Táxi;
        ///3 – Produtor Agropecuário;
        ///4 – Frotista/Locadora;
        ///5 – Diplomático/Consular;
        ///6 – Utilitários e Motocicletas da Amazônia Ocidental e Áreas de Livre Comércio(Resolução 714/88 e 790/94 – CONTRAN e suas alterações);
        ///7 – SUFRAMA;
        ///8 - Venda a órgão Público;
        ///9 – Outros
        ///10- Deficiente Condutor
        ///11- Deficiente não condutor
        ///16 - Olimpíadas Rio 2016
        /// </summary>
        public TypeMotivoDesoneracaoICMS40 motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }
    }
}