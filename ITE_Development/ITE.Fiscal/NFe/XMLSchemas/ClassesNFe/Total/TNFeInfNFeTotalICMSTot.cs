namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// Totais referentes ao ICMS
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalICMSTot
    {

        private string vBCField;

        private string vICMSField;

        private string vICMSDesonField;

        private string vFCPUFDestField;

        private string vICMSUFDestField;

        private string vICMSUFRemetField;

        private string vFCPField;

        private string vBCSTField;

        private string vSTField;

        private string vFCPSTField;

        private string vFCPSTRetField;

        private string vProdField;

        private string vFreteField;

        private string vSegField;

        private string vDescField;

        private string vIIField;

        private string vIPIField;

        private string vIPIDevolField;

        private string vPISField;

        private string vCOFINSField;

        private string vOutroField;

        private string vNFField;

        private string vTotTribField;

        /// <summary>
        /// BC do ICMS
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
        /// Valor Total do ICMS
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
        /// Valor Total do ICMS desonerado
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
        /// Valor total do ICMS relativo ao Fundo de Combate à Pobreza (FCP) para a UF de destino.
        /// </summary>
        public string vFCPUFDest
        {
            get
            {
                return this.vFCPUFDestField;
            }
            set
            {
                this.vFCPUFDestField = value;
            }
        }

        /// <summary>
        /// Valor total do ICMS de partilha para a UF do destinatário
        /// </summary>
        public string vICMSUFDest
        {
            get
            {
                return this.vICMSUFDestField;
            }
            set
            {
                this.vICMSUFDestField = value;
            }
        }

        /// <summary>
        /// Valor total do ICMS de partilha para a UF do remetente
        /// </summary>
        public string vICMSUFRemet
        {
            get
            {
                return this.vICMSUFRemetField;
            }
            set
            {
                this.vICMSUFRemetField = value;
            }
        }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza).
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

        /// <summary>
        /// BC do ICMS ST
        /// </summary>
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        /// <summary>
        /// Valor Total do ICMS ST
        /// </summary>
        public string vST
        {
            get
            {
                return this.vSTField;
            }
            set
            {
                this.vSTField = value;
            }
        }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza) retido por substituição tributária.
        /// </summary>
        public string vFCPST
        {
            get
            {
                return this.vFCPSTField;
            }
            set
            {
                this.vFCPSTField = value;
            }
        }

        /// <summary>
        /// Valor Total do FCP (Fundo de Combate à Pobreza) retido anteriormente por substituição tributária.
        /// </summary>
        public string vFCPSTRet
        {
            get
            {
                return this.vFCPSTRetField;
            }
            set
            {
                this.vFCPSTRetField = value;
            }
        }

        /// <summary>
        /// Valor Total dos produtos e serviços
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
        /// Valor Total do Desconto
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
        /// Valor Total do II
        /// </summary>
        public string vII
        {
            get
            {
                return this.vIIField;
            }
            set
            {
                this.vIIField = value;
            }
        }

        /// <summary>
        /// Valor Total do IPI
        /// </summary>
        public string vIPI
        {
            get
            {
                return this.vIPIField;
            }
            set
            {
                this.vIPIField = value;
            }
        }

        /// <summary>
        /// Valor Total do IPI devolvido. Deve ser informado quando preenchido o Grupo Tributos Devolvidos na emissão de nota finNFe=4 (devolução) nas operações com não contribuintes do IPI. Corresponde ao total da soma dos campos id: UA04.
        /// </summary>
        public string vIPIDevol
        {
            get
            {
                return this.vIPIDevolField;
            }
            set
            {
                this.vIPIDevolField = value;
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

        /// <summary>
        /// Valor do COFINS
        /// </summary>
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        /// <summary>
        /// Outras Despesas acessórias
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
        /// Valor Total da NF-e
        /// </summary>
        public string vNF
        {
            get
            {
                return this.vNFField;
            }
            set
            {
                this.vNFField = value;
            }
        }

        /// <summary>
        /// Valor estimado total de impostos federais, estaduais e municipais
        /// </summary>
        public string vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }
    }
}