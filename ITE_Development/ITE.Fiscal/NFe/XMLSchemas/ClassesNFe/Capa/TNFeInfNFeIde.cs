namespace ITE.Fiscal.NFe.XMLSchemas.ClassesNFe
{
    /// <summary>
    /// identificação da NF-e
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIde
    {

        private string cUFField;

        private string cNFField;

        private string natOpField;

        private string modField;

        private string serieField;

        private string nNFField;

        private string dhEmiField;

        private string dhSaiEntField;

        private string tpNFField;

        private TNFeInfNFeIdeIdDest idDestField;

        private string cMunFGField;

        private TNFeInfNFeIdeTpImp tpImpField;

        private TNFeInfNFeIdeTpEmis tpEmisField;

        private string cDVField;

        private TAmb tpAmbField;

        private TFinNFe finNFeField;

        private TNFeInfNFeIdeIndFinal indFinalField;

        private TNFeInfNFeIdeIndPres indPresField;

        private TProcEmi procEmiField;

        private string verProcField;

        private string dhContField;

        private string xJustField;

        private TNFeInfNFeIdeNFref[] nFrefField;

        /// <summary>
        /// Código da UF do emitente do Documento Fiscal. Utilizar a Tabela do IBGE.
        /// </summary>
        public string cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        /// <summary>
        /// Código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para cada NF-e.
        /// </summary>
        public string cNF
        {
            get
            {
                return this.cNFField;
            }
            set
            {
                this.cNFField = value;
            }
        }

        /// <summary>
        /// Descrição da Natureza da Operação
        /// </summary>
        public string natOp
        {
            get
            {
                return this.natOpField;
            }
            set
            {
                this.natOpField = value;
            }
        }

        /// <summary>
        /// Código do modelo do Documento Fiscal. 55 = NF-e; 65 = NFC-e.
        /// </summary>
        public string mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <summary>
        /// Serie do documento
        /// </summary>
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <summary>
        /// Número do Documento Fiscal
        /// </summary>
        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }

        /// <summary>
        /// Data e Hora de emissão do Documento Fiscal (AAAA-MM-DDThh:mm:ssTZD) ex.: 2012-09-01T13:00:00-03:00
        /// </summary>
        public string dhEmi
        {
            get
            {
                return this.dhEmiField;
            }
            set
            {
                this.dhEmiField = value;
            }
        }

        /// <summary>
        /// Data e Hora da saída ou de entrada da mercadoria / produto (AAAA-MM-DDTHH:mm:ssTZD)
        /// </summary>
        public string dhSaiEnt
        {
            get
            {
                return this.dhSaiEntField;
            }
            set
            {
                this.dhSaiEntField = value;
            }
        }

        /// <summary>
        /// Tipo nota fiscal. 0 - Entrada, 1 - Saida
        /// </summary>
        public string tpNF
        {
            get
            {
                return this.tpNFField;
            }
            set
            {
                this.tpNFField = value;
            }
        }

        /// <summary>
        /// Identificador de Local de destino da operação (1-Interna;2-Interestadual;3-Exterior)
        /// </summary>
        public TNFeInfNFeIdeIdDest idDest
        {
            get
            {
                return this.idDestField;
            }
            set
            {
                this.idDestField = value;
            }
        }

        /// <summary>
        /// Código do Município de Ocorrência do Fato Gerador (utilizar a tabela do IBGE)
        /// </summary>
        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

        /// <summary>
        /// Formato de impressão do DANFE (0-sem DANFE;1-DANFe Retrato; 2-DANFe Paisagem;3-DANFe Simplificado; 4-DANFe NFC-e;5-DANFe NFC-e em mensagem eletrônica)
        /// </summary>
        public TNFeInfNFeIdeTpImp tpImp
        {
            get
            {
                return this.tpImpField;
            }
            set
            {
                this.tpImpField = value;
            }
        }

        /// <summary>
        /// Forma de emissão da NF-e: 
        /// 1 - Normal; 
        /// 2 - Contingência FS; 
        /// 3 - Contingência SCAN; 
        /// 4 - Contingência DPEC; 
        /// 5 - Contingência FSDA; 
        /// 6 - Contingência SVC - AN; 
        /// 7 - Contingência SVC - RS; 9 - Contingência off-line NFC-e
        /// </summary>
        public TNFeInfNFeIdeTpEmis tpEmis
        {
            get
            {
                return this.tpEmisField;
            }
            set
            {
                this.tpEmisField = value;
            }
        }

        /// <summary>
        /// Digito Verificador da Chave de Acesso da NF-e
        /// </summary>
        public string cDV
        {
            get
            {
                return this.cDVField;
            }
            set
            {
                this.cDVField = value;
            }
        }

        /// <summary>
        /// Identificação do Ambiente:
        ///1 - Produção
        ///2 - Homologação
        /// </summary>
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <summary>
        /// Finalidade da emissão da NF-e:
        ///1 - NFe normal
        ///2 - NFe complementar
        ///3 - NFe de ajuste
        ///4 - Devolução/Retorno
        /// </summary>
        public TFinNFe finNFe
        {
            get
            {
                return this.finNFeField;
            }
            set
            {
                this.finNFeField = value;
            }
        }

        /// <summary>
        /// Indica operação com consumidor final (0-Não;1-Consumidor Final)
        /// </summary>
        public TNFeInfNFeIdeIndFinal indFinal
        {
            get
            {
                return this.indFinalField;
            }
            set
            {
                this.indFinalField = value;
            }
        }

        /// <summary>
        /// Indicador de presença do comprador no estabelecimento comercial no momento da operação
        ///(0-Não se aplica(ex.: Nota Fiscal complementar ou de ajuste;
        ///1-Operação presencial;
        ///2-Não presencial, internet;
        ///3-Não presencial, teleatendimento;
        ///4-NFC-e entrega em domicílio;
        ///5-Operação presencial, fora do estabelecimento;
        ///9-Não presencial, outros)
        /// </summary>
        public TNFeInfNFeIdeIndPres indPres
        {
            get
            {
                return this.indPresField;
            }
            set
            {
                this.indPresField = value;
            }
        }

        /// <summary>
        /// Processo de emissão utilizado com a seguinte codificação:
        ///0 - emissão de NF-e com aplicativo do contribuinte;
        ///1 - emissão de NF-e avulsa pelo Fisco;
        ///2 - emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco;
        ///3- emissão de NF-e pelo contribuinte com aplicativo fornecido pelo Fisco.
        /// </summary>
        public TProcEmi procEmi
        {
            get
            {
                return this.procEmiField;
            }
            set
            {
                this.procEmiField = value;
            }
        }

        /// <summary>
        /// versão do aplicativo utilizado no processo de emissão
        /// </summary>
        public string verProc
        {
            get
            {
                return this.verProcField;
            }
            set
            {
                this.verProcField = value;
            }
        }

        /// <summary>
        /// Informar a data e hora de entrada em contingência contingência no formato  (AAAA-MM-DDThh:mm:ssTZD) ex.: 2012-09-01T13:00:00-03:00.
        /// </summary>
        public string dhCont
        {
            get
            {
                return this.dhContField;
            }
            set
            {
                this.dhContField = value;
            }
        }

        /// <summary>
        /// Informar a Justificativa da entrada
        /// </summary>
        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        /// <summary>
        /// Grupo de infromações da NF referenciada
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("NFref")]
        public TNFeInfNFeIdeNFref[] NFref
        {
            get
            {
                return this.nFrefField;
            }
            set
            {
                this.nFrefField = value;
            }
        }
    }
}