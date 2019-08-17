namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Dados dos produtos e serviços da NF-e
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProd
    {

        private string cProdField;

        private string cEANField;

        private string xProdField;

        private string nCMField;

        private string[] nVEField;

        private string cESTField;

        private TNFeInfNFeDetProdIndEscala indEscalaField;

        private bool indEscalaFieldSpecified;

        private string cNPJFabField;

        private string cBenefField;

        private string eXTIPIField;

        private string cFOPField;

        private string uComField;

        private string qComField;

        private string vUnComField;

        private string vProdField;

        private string cEANTribField;

        private string uTribField;

        private string qTribField;

        private string vUnTribField;

        private string vFreteField;

        private string vSegField;

        private string vDescField;

        private string vOutroField;

        private TNFeInfNFeDetProdIndTot indTotField;

        private TNFeInfNFeDetProdDI[] diField;

        private TNFeInfNFeDetProdDetExport[] detExportField;

        private string xPedField;

        private string nItemPedField;

        private string nFCIField;

        private TNFeInfNFeDetProdRastro[] rastroField;

        private object[] infoEspecificasProdutosField;

        /// <summary>
        /// Código do produto ou serviço. Preencher com CFOP caso se trate de itens não relacionados com mercadorias/produto e que o contribuinte não possua codificação própria Formato ”CFOP9999”.
        /// </summary>
        public string cProd
        {
            get
            {
                return this.cProdField;
            }
            set
            {
                this.cProdField = value;
            }
        }

        /// <summary>
        /// GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
        /// </summary>
        public string cEAN
        {
            get
            {
                return this.cEANField;
            }
            set
            {
                this.cEANField = value;
            }
        }

        /// <summary>
        /// Descrição do produto ou serviço
        /// </summary>
        public string xProd
        {
            get
            {
                return this.xProdField;
            }
            set
            {
                this.xProdField = value;
            }
        }

        /// <summary>
        /// Código NCM (8 posições), será permitida a informação do gênero (posição do capítulo do NCM) quando a operação não for de comércio exterior (importação/exportação) ou o produto não seja tributado pelo IPI. Em caso de item de serviço ou item que não tenham produto (Ex. transferência de crédito, crédito do ativo imobilizado, etc.), informar o código 00 (zeros) (v2.0)
        /// </summary>
        public string NCM
        {
            get
            {
                return this.nCMField;
            }
            set
            {
                this.nCMField = value;
            }
        }

        /// <summary>
        /// Nomenclatura de Valor aduaneio e Estatístico
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("NVE")]
        public string[] NVE
        {
            get
            {
                return this.nVEField;
            }
            set
            {
                this.nVEField = value;
            }
        }

        /// <summary>
        /// Codigo especificador da Substuicao Tributaria - CEST, que identifica a mercadoria sujeita aos regimes de  substituicao tributária e de antecipação do recolhimento  do imposto
        /// </summary>
        public string CEST
        {
            get
            {
                return this.cESTField;
            }
            set
            {
                this.cESTField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public TNFeInfNFeDetProdIndEscala indEscala
        {
            get
            {
                return this.indEscalaField;
            }
            set
            {
                this.indEscalaField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indEscalaSpecified
        {
            get
            {
                return this.indEscalaFieldSpecified;
            }
            set
            {
                this.indEscalaFieldSpecified = value;
            }
        }

        /// <summary>
        /// CNPJ do Fabricante da Mercadoria, obrigatório para produto em escala NÃO relevante.
        /// </summary>
        public string CNPJFab
        {
            get
            {
                return this.cNPJFabField;
            }
            set
            {
                this.cNPJFabField = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string cBenef
        {
            get
            {
                return this.cBenefField;
            }
            set
            {
                this.cBenefField = value;
            }
        }

        /// <summary>
        /// Código EX TIPI (3 posições)
        /// </summary>
        public string EXTIPI
        {
            get
            {
                return this.eXTIPIField;
            }
            set
            {
                this.eXTIPIField = value;
            }
        }

        /// <summary>
        /// Cfop
        /// </summary>
        public string CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        /// <summary>
        /// Unidade comercial
        /// </summary>
        public string uCom
        {
            get
            {
                return this.uComField;
            }
            set
            {
                this.uComField = value;
            }
        }

        /// <summary>
        ///  Quantidade Comercial  do produto, alterado para aceitar de 0 a 4 casas decimais e 11 inteiros.
        /// </summary>
        public string qCom
        {
            get
            {
                return this.qComField;
            }
            set
            {
                this.qComField = value;
            }
        }

        /// <summary>
        ///Valor unitário de comercialização  - alterado para aceitar 0 a 10 casas decimais e 11 inteiros
        /// </summary>
        public string vUnCom
        {
            get
            {
                return this.vUnComField;
            }
            set
            {
                this.vUnComField = value;
            }
        }

        /// <summary>
        /// Valor bruto do produto ou serviço.
        /// </summary>
        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        /// <summary>
        /// GTIN (Global Trade Item Number) da unidade tributável, antigo código EAN ou código de barras
        /// </summary>
        public string cEANTrib
        {
            get
            {
                return this.cEANTribField;
            }
            set
            {
                this.cEANTribField = value;
            }
        }

        /// <summary>
        /// Unidade Tributável
        /// </summary>
        public string uTrib
        {
            get
            {
                return this.uTribField;
            }
            set
            {
                this.uTribField = value;
            }
        }

        /// <summary>
        /// Quantidade Tributável - alterado para aceitar de 0 a 4 casas decimais e 11 inteiros
        /// </summary>
        public string qTrib
        {
            get
            {
                return this.qTribField;
            }
            set
            {
                this.qTribField = value;
            }
        }

        /// <summary>
        /// Valor unitário de tributação - - alterado para aceitar 0 a 10 casas decimais e 11 inteiros
        /// </summary>
        public string vUnTrib
        {
            get
            {
                return this.vUnTribField;
            }
            set
            {
                this.vUnTribField = value;
            }
        }

        /// <summary>
        /// Valor Total do Frete
        /// </summary>
        public string vFrete
        {
            get
            {
                return this.vFreteField;
            }
            set
            {
                this.vFreteField = value;
            }
        }

        /// <summary>
        /// Valor Total do Seguro
        /// </summary>
        public string vSeg
        {
            get
            {
                return this.vSegField;
            }
            set
            {
                this.vSegField = value;
            }
        }

        /// <summary>
        /// Valor do Desconto
        /// </summary>
        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        /// <summary>
        /// Outras despesas acessórias
        /// </summary>
        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        /// <summary>
        /// Este campo deverá ser preenchido com:
        ///0 – o valor do item(vProd) não compõe o valor total da NF-e(vProd)
        ///1  – o valor do item(vProd) compõe o valor total da NF-e(vProd)
        /// </summary>
        public TNFeInfNFeDetProdIndTot indTot
        {
            get
            {
                return this.indTotField;
            }
            set
            {
                this.indTotField = value;
            }
        }

        /// <summary>
        /// Delcaração de Importação (NT 2011/004)
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DI")]
        public TNFeInfNFeDetProdDI[] DI
        {
            get
            {
                return this.diField;
            }
            set
            {
                this.diField = value;
            }
        }

        /// <summary>
        /// Detalhe da exportação
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("detExport")]
        public TNFeInfNFeDetProdDetExport[] detExport
        {
            get
            {
                return this.detExportField;
            }
            set
            {
                this.detExportField = value;
            }
        }

        /// <summary>
        /// pedido de compra - Informação de interesse do emissor para controle do B2B.
        /// </summary>
        public string xPed
        {
            get
            {
                return this.xPedField;
            }
            set
            {
                this.xPedField = value;
            }
        }

        /// <summary>
        /// Número do Item do Pedido de Compra - Identificação do número do item do pedido de Compra
        /// </summary>
        public string nItemPed
        {
            get
            {
                return this.nItemPedField;
            }
            set
            {
                this.nItemPedField = value;
            }
        }

        /// <summary>
        /// Número de controle da FCI - Ficha de Conteúdo de Importação.
        /// </summary>
        public string nFCI
        {
            get
            {
                return this.nFCIField;
            }
            set
            {
                this.nFCIField = value;
            }
        }

        /// <summary>
        /// Rastro do produto
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("rastro")]
        public TNFeInfNFeDetProdRastro[] rastro
        {
            get
            {
                return this.rastroField;
            }
            set
            {
                this.rastroField = value;
            }
        }

        /// <summary>
        /// Informações específicas de produtos e serviços. Arma, combustiveis, medicamentos, RECOPI, veículos
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("arma", typeof(TNFeInfNFeDetProdArma))]
        [System.Xml.Serialization.XmlElementAttribute("comb", typeof(TNFeInfNFeDetProdComb))]
        [System.Xml.Serialization.XmlElementAttribute("med", typeof(TNFeInfNFeDetProdMed))]
        [System.Xml.Serialization.XmlElementAttribute("nRECOPI", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("veicProd", typeof(TNFeInfNFeDetProdVeicProd))]
        public object[] InfoEspecificasProdutos
        {
            get
            {
                return this.infoEspecificasProdutosField;
            }
            set
            {
                this.infoEspecificasProdutosField = value;
            }
        }
    }
}