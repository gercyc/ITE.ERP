namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Informações da Nota Fiscal eletrônica
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFe {
    
        private TNFeInfNFeIde ideField;
    
        private TNFeInfNFeEmit emitField;
    
        private TNFeInfNFeAvulsa avulsaField;
    
        private TNFeInfNFeDest destField;
    
        private TLocal retiradaField;
    
        private TLocal entregaField;
    
        private TNFeInfNFeAutXML[] autXMLField;
    
        private TNFeInfNFeDet[] detField;
    
        private TNFeInfNFeTotal totalField;
    
        private TNFeInfNFeTransp transpField;
    
        private TNFeInfNFeCobr cobrField;
    
        private TNFeInfNFePag pagField;
    
        private TNFeInfNFeInfAdic infAdicField;
    
        private TNFeInfNFeExporta exportaField;
    
        private TNFeInfNFeCompra compraField;
    
        private TNFeInfNFeCana canaField;
    
        private string versaoField;
    
        private string idField;

        /// <summary>
        /// identificação da NF-e
        /// </summary>
        public TNFeInfNFeIde ide {
            get {
                return this.ideField;
            }
            set {
                this.ideField = value;
            }
        }

        /// <summary>
        /// Identificação do emitente
        /// </summary>
        public TNFeInfNFeEmit emit {
            get {
                return this.emitField;
            }
            set {
                this.emitField = value;
            }
        }

        /// <summary>
        /// Emissão de avulsa, informar os dados do Fisco emitente
        /// </summary>
        public TNFeInfNFeAvulsa avulsa {
            get {
                return this.avulsaField;
            }
            set {
                this.avulsaField = value;
            }
        }

        /// <summary>
        /// Identificação do Destinatário
        /// </summary>
        public TNFeInfNFeDest dest {
            get {
                return this.destField;
            }
            set {
                this.destField = value;
            }
        }

        /// <summary>
        /// Identificação do Local de Retirada (informar apenas quando for diferente do endereço do remetente)
        /// </summary>
        public TLocal retirada {
            get {
                return this.retiradaField;
            }
            set {
                this.retiradaField = value;
            }
        }

        /// <summary>
        /// Identificação do Local de Entrega (informar apenas quando for diferente do endereço do destinatário)
        /// </summary>
        public TLocal entrega {
            get {
                return this.entregaField;
            }
            set {
                this.entregaField = value;
            }
        }

        /// <summary>
        /// Pessoas autorizadas para o download do XML da NF-e
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("autXML")]
        public TNFeInfNFeAutXML[] autXML {
            get {
                return this.autXMLField;
            }
            set {
                this.autXMLField = value;
            }
        }

        /// <summary>
        /// Dados dos detalhes da NF-e
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("det")]
        public TNFeInfNFeDet[] det {
            get {
                return this.detField;
            }
            set {
                this.detField = value;
            }
        }

        /// <summary>
        /// Dados dos totais da NF-e
        /// </summary>
        public TNFeInfNFeTotal total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }

        /// <summary>
        /// Dados dos transportes da NF-e
        /// </summary>
        public TNFeInfNFeTransp transp {
            get {
                return this.transpField;
            }
            set {
                this.transpField = value;
            }
        }

        /// <summary>
        /// Dados da cobrança da NF-e
        /// </summary>
        public TNFeInfNFeCobr cobr {
            get {
                return this.cobrField;
            }
            set {
                this.cobrField = value;
            }
        }

        /// <summary>
        /// Dados de Pagamento. Obrigatório apenas para (NFC-e) NT 2012/004
        /// </summary>
        public TNFeInfNFePag pag {
            get {
                return this.pagField;
            }
            set {
                this.pagField = value;
            }
        }

        /// <summary>
        /// Informações adicionais da NF-e
        /// </summary>
        public TNFeInfNFeInfAdic infAdic {
            get {
                return this.infAdicField;
            }
            set {
                this.infAdicField = value;
            }
        }

        /// <summary>
        /// Informações de exportação
        /// </summary>
        public TNFeInfNFeExporta exporta {
            get {
                return this.exportaField;
            }
            set {
                this.exportaField = value;
            }
        }

        /// <summary>
        /// Informações de compras  (Nota de Empenho, Pedido e Contrato). Opcional
        /// </summary>
        public TNFeInfNFeCompra compra {
            get {
                return this.compraField;
            }
            set {
                this.compraField = value;
            }
        }

        /// <summary>
        /// Informações de registro aquisições de cana
        /// </summary>
        public TNFeInfNFeCana cana {
            get {
                return this.canaField;
            }
            set {
                this.canaField = value;
            }
        }

        /// <summary>
        /// Versão do leiaute (v4.00)
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <summary>
        /// Versão do leiaute (v4.00)
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao {
            get {
                return this.versaoField;
            }
            set {
                this.versaoField = value;
            }
        }

        
    }
}