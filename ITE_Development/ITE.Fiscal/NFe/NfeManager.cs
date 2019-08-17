using ITE.Entidades.DaoManager.LocalidadeDaoManager;
using ITE.Entidades.Enumeradores.NFeEnum;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.POCO.Fiscal.NFe;
using ITE.Entidades.Repositorio;
using ITE.Fiscal.NFe.XMLSchemas.ClassesNFe;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Globalization;
using ITSolution.Framework.Arquivos;
using System.Data.SqlClient;
using System.Xml.Schema;
using ITSolution.Framework.Beans.Forms;

namespace ITE.Fiscal.NFe
{
    public class NfeManager
    {
        private List<string> listValidacoes;
        public NfeManager()
        {
            this.listValidacoes = new List<string>();
        }
        /// <summary>
        /// Gera o XML da NFe com base no movimento. (Fazer melhorias e tratamentos)
        /// </summary>
        /// <param name="movimento"></param>
        /// <returns>Retorna o XML da nota fiscal eletronica sem assinatura</returns>
        public string GerarXml(Movimento movimento)
        {
            try
            {
                using (MemoryStream str = new MemoryStream())
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(TNFe));
                    //gerar o XML da NFe
                    var tnfe = GerarTNFeBasico(movimento);

                    //StringWriter strXmlNFe = new Utf8StringWriter();

                    var setting = new XmlWriterSettings()
                    {
                        OmitXmlDeclaration = false,
                        Encoding = Encoding.UTF8,
                        Indent = false,
                        NewLineHandling = NewLineHandling.None,
                        NewLineChars = string.Empty
                    };

                    var writer = XmlWriter.Create(str, setting);

                    //configuracao do namespace do XML
                    XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                    xmlSerializerNamespaces.Add("", "http://www.portalfiscal.inf.br/nfe");

                    //serializando.
                    xmlSerializer.Serialize(writer, tnfe, xmlSerializerNamespaces);

                    //gravar o XML em string
                    str.Position = 0;
                    var sr = new StreamReader(str);
                    var xm = sr.ReadToEnd();

                    writer.Close();

                    return xm;
                }
            }
            catch (Exception ex)
            {
                //XMessageIts.ExceptionMessageDetails(ex, "erro");
                return ex.Message;
            }
        }

        /// <summary>
        /// Gerar a nota fiscal eletronica no painel de NFe
        /// </summary>
        /// <param name="movimento"></param>
        /// <returns></returns>
        public bool GerarNFe(Movimento movimento)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var xml = GerarXml(movimento);

                    var nfeEstadual = new NFeEstadual()
                    {
                        ChaveAcesso = movimento.ChaveAcessoNf,
                        IdMovimento = movimento.IdMovimento,
                        StatusXml = TypeStatusEnvioNFe.XmlGerado,
                        XmlNfe = xml
                    };
                    if (ctx.NFeEstadualDao.Save(nfeEstadual))
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Erro ao gerar NFe!");
                return false;
            }
        }

        /// <summary>
        /// Gerar informacoes do ICMS..
        /// </summary>
        /// <param name="imposto"></param>
        /// <returns></returns>
        private object gerarImpostoICMS(ImpostoItemMovimento imposto)
        {
            var detICMS = new TNFeInfNFeDetImpostoICMS();
            // Gets a NumberFormatInfo associated with the en-US culture.
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalSeparator = ".";

            if (imposto.TipoImposto.CodigoImposto == "ICMS")
            {
                //icms cst 00
                if (imposto.SituacaoTributaria.CodigoCst == "000")
                {
                    var icms00 = new TNFeInfNFeDetImpostoICMSICMS00()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        modBC = TypeModalidadeBaseCalculoICMS.ValorOperacao,
                        orig = Torig.Nacional,
                        pFCP = "0.00",
                        pICMS = imposto.Aliquota.ToString(nfi),
                        vBC = imposto.BaseCalculo.ToString(nfi),
                        vFCP = "0.00",
                        vICMS = imposto.ValorImposto.ToString(nfi)
                    };
                    detICMS.DetalheICMS = icms00;
                }
                //icms cst 10
                else if (imposto.SituacaoTributaria.CodigoCst == "010")
                {
                    var icms10 = new TNFeInfNFeDetImpostoICMSICMS10()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        modBC = TypeModalidadeBaseCalculoICMS.ValorOperacao,
                        orig = Torig.Nacional,
                        pFCP = "0.00",
                        pICMS = "0.00",
                        vBC = imposto.BaseCalculo.ToString(nfi),
                        vFCP = "0.00",
                        vICMS = imposto.ValorImposto.ToString(nfi)
                    };
                    detICMS.DetalheICMS = icms10;
                }
                //icms cst 20
                else if (imposto.SituacaoTributaria.CodigoCst == "020")
                {
                    var icms20 = new TNFeInfNFeDetImpostoICMSICMS20()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        modBC = TypeModalidadeBaseCalculoICMS.ValorOperacao,
                        orig = Torig.Nacional,
                        pFCP = "0.00",
                        pICMS = "0.00",
                        vBC = imposto.BaseCalculo.ToString(nfi),
                        vFCP = "0.00",
                        vICMS = imposto.ValorImposto.ToString(nfi)
                    };
                    detICMS.DetalheICMS = icms20;
                }
                //icms cst 30
                else if (imposto.SituacaoTributaria.CodigoCst == "030")
                {
                    var icms30 = new TNFeInfNFeDetImpostoICMSICMS30()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        modBCST = TypeModalidadeBaseCalculoICMS.ValorOperacao,
                        orig = Torig.Nacional,
                        pICMSST = imposto.Aliquota.ToString(nfi),
                        vBCST = imposto.BaseCalculo.ToString(nfi),
                        vICMSST = imposto.ValorImposto.ToString(nfi),
                    };
                    detICMS.DetalheICMS = icms30;
                }
                //icms cst 40, 41, 50 ou 51
                else if (new List<string>() { "040", "041", "050", "051" }.Contains(imposto.SituacaoTributaria.CodigoCst))
                {
                    var icms40 = new TNFeInfNFeDetImpostoICMSICMS40()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        orig = Torig.Nacional,
                        motDesICMS = TypeMotivoDesoneracaoICMS40.Outros,
                        vICMSDeson = imposto.ValorImposto.ToString(nfi)
                    };
                    detICMS.DetalheICMS = icms40;
                }
                //icms cst 51/20
                else if (imposto.SituacaoTributaria.CodigoCst == "020")
                {
                    var icms51 = new TNFeInfNFeDetImpostoICMSICMS51()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        modBC = TypeModalidadeBaseCalculoICMS.ValorOperacao,
                        orig = Torig.Nacional,
                        pFCP = "0.00",
                        pICMS = "0.00",
                        vBC = imposto.BaseCalculo.ToString(nfi),
                        vFCP = "0.00",
                        vICMS = imposto.ValorImposto.ToString(nfi)
                    };
                    detICMS.DetalheICMS = icms51;
                }
                //icms cst 60
                else if (imposto.SituacaoTributaria.CodigoCst == "060")
                {
                    var icms60 = new TNFeInfNFeDetImpostoICMSICMS60()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        orig = Torig.Nacional,
                        pFCPSTRet = "0.00",
                        pST = imposto.Aliquota.ToString(nfi),
                        vBCSTRet = imposto.BaseCalculo.ToString(nfi),
                        vICMSSTRet = imposto.ValorImposto.ToString(nfi)
                    };
                    detICMS.DetalheICMS = icms60;
                }
                //icms cst 70
                else if (imposto.SituacaoTributaria.CodigoCst == "070")
                {
                    var icms70 = new TNFeInfNFeDetImpostoICMSICMS70()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        modBC = TypeModalidadeBaseCalculoICMS.ValorOperacao,
                        orig = Torig.Nacional,
                        pFCP = "0.00",
                        pICMS = "0.00",
                        vBC = imposto.BaseCalculo.ToString(nfi),
                        vFCP = "0.00",
                        vICMS = imposto.ValorImposto.ToString(nfi)
                    };
                    detICMS.DetalheICMS = icms70;
                }
                //icms cst 90
                else if (imposto.SituacaoTributaria.CodigoCst == "090")
                {
                    var icms90 = new TNFeInfNFeDetImpostoICMSICMS90()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        modBC = TypeModalidadeBaseCalculoICMS.ValorOperacao,
                        orig = Torig.Nacional,
                        pFCP = "0.00",
                        pICMS = "0.00",
                        vBC = imposto.BaseCalculo.ToString(nfi),
                        vFCP = "0.00",
                        vICMS = imposto.ValorImposto.ToString(nfi)
                    };
                    detICMS.DetalheICMS = icms90;
                }
            }

            return detICMS;
        }
        /// <summary>
        /// Gerar informacoes do PIS
        /// </summary>
        /// <param name="imposto"></param>
        /// <returns></returns>
        private TNFeInfNFeDetImpostoPIS gerarImpostoPIS(ImpostoItemMovimento imposto)
        {
            var detPIS = new TNFeInfNFeDetImpostoPIS();
            // Gets a NumberFormatInfo associated with the en-US culture.
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalSeparator = ".";

            if (imposto.TipoImposto.CodigoImposto == "PIS")
            {
                if (imposto.SituacaoTributaria.CodigoCst == "01" || imposto.SituacaoTributaria.CodigoCst == "02")
                {
                    var pisAliq = new TNFeInfNFeDetImpostoPISPISAliq()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        pPIS = imposto.Aliquota.ToString(nfi),
                        vBC = imposto.BaseCalculo.ToString(nfi),
                        vPIS = imposto.ValorImposto.ToString(nfi)
                    };

                    detPIS.DetalhePIS = pisAliq;
                }
            }

            return detPIS;
        }
        /// <summary>
        /// Gerar informacoes do COFINS
        /// </summary>
        /// <param name="imposto"></param>
        /// <returns></returns>
        private TNFeInfNFeDetImpostoCOFINS gerarImpostoCOFINS(ImpostoItemMovimento imposto)
        {
            var detCOFINS = new TNFeInfNFeDetImpostoCOFINS();
            // Gets a NumberFormatInfo associated with the en-US culture.
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalSeparator = ".";

            if (imposto.TipoImposto.CodigoImposto == "COFINS")
            {
                if (imposto.SituacaoTributaria.CodigoCst == "01" || imposto.SituacaoTributaria.CodigoCst == "02")
                {
                    var pisAliq = new TNFeInfNFeDetImpostoCOFINSCOFINSAliq()
                    {
                        CST = imposto.SituacaoTributaria.CodigoCst,
                        pCOFINS = imposto.Aliquota.ToString(nfi),
                        vBC = imposto.BaseCalculo.ToString(nfi),
                        vCOFINS = imposto.ValorImposto.ToString(nfi)
                    };

                    detCOFINS.DetalheCOFINS = pisAliq;
                }
            }

            return detCOFINS;
        }

        /// <summary>
        /// Assinar um documento eletronico. Ainda em dev.
        /// Ref.: https://www.profissionaisti.com.br/2010/07/assinando-digitalmente-um-xml-usando-c/
        /// </summary>
        /// <param name="nfe"></param>
        /// <returns></returns>
        public bool AssinarNFe(NFeEstadual nfe)
        {
            X509Certificate2Collection certificados;
            //certificados instalados no store da maquina
            X509Store store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            //abre o store
            store.Open(OpenFlags.ReadOnly);
            //lista dos certificados
            certificados = store.Certificates;

            foreach (X509Certificate2 cert in certificados)
            {
                if (cert.HasPrivateKey && cert.NotAfter > DateTime.Now && cert.NotBefore < DateTime.Now)
                {

                }
            }

            store.Close();
            return true;
        }

        /// <summary>
        /// Grava o lote no banco para envio..
        /// </summary>
        /// <param name="notas"></param>
        /// <returns></returns>
        public bool GerarLoteEnvio(List<NFeEstadual> notas)
        {
            try
            {
                XmlSerializer xmlSerializer;
                //cria o lote..
                var loteEnvio = new TEnviNFe()
                {
                    idLote = getNewLoteEnvioNFeNumber(),
                    indSinc = TEnviNFeIndSinc.Item1,
                    versao = "3.10",
                    NFe = new TNFe[notas.Count]
                };

                //posicao do array de notas
                var i = 0;

                //percorro cada nf selecionada, já que serializei, vou deserializar..
                foreach (var nf in notas)
                {
                    //sei que eh um TNFe
                    xmlSerializer = new XmlSerializer(typeof(TNFe));
                    //passo o conteudo do xml para StringReader e dps pro txtReaader
                    TextReader r = new StringReader(nf.XmlNfe);

                    //deSerializando...
                    var nfDeserialized = xmlSerializer.Deserialize(r);
                    //definindo o valor da posicao 'i'
                    loteEnvio.NFe[i] = (TNFe)nfDeserialized;

                    i++;
                }

                using (MemoryStream str = new MemoryStream())
                {
                    xmlSerializer = new XmlSerializer(typeof(TEnviNFe));
                    var setting = new XmlWriterSettings()
                    {
                        OmitXmlDeclaration = false,
                        Encoding = Encoding.UTF8,
                        Indent = false,
                        NewLineHandling = NewLineHandling.None,
                        NewLineChars = string.Empty
                    };

                    var writer = XmlWriter.Create(str, setting);

                    //configuracao do namespace do XML
                    XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                    xmlSerializerNamespaces.Add("", "http://www.portalfiscal.inf.br/nfe");

                    //serializando.
                    xmlSerializer.Serialize(writer, loteEnvio, xmlSerializerNamespaces);

                    //gravar o XML em string
                    str.Position = 0;
                    var sr = new StreamReader(str);
                    var stringLote = sr.ReadToEnd();

                    var loteSave = new LoteEnvioNFe()
                    {
                        ConteudoLote = stringLote,
                        NumeroLote = loteEnvio.idLote
                    };
                    var ctx = new BalcaoContext();
                    var result = ctx.LoteEnvioNFeDao.Save(loteSave);

                    if (result)
                    {
                        //se criou o lote com sucesso, atualize no painel o numero do lote

                        notas.ForEach(n =>
                        {
                            var nfPainelBd = ctx.NFeEstadualDao.Find(n.IdNfe);

                            if (nfPainelBd != null)
                            {
                                nfPainelBd.IdLoteEnvio = loteSave.IdLoteNfe;
                                ctx.NFeEstadualDao.Update(nfPainelBd);
                            }
                        });

                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Erro ao gerar o lote para envio das notas selecionadas", "Erro gerar lote para envio");
                return false;
            }
        }

        private string getNewLoteEnvioNFeNumber()
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var nextNumber = ctx.ConnectionSql.ExecuteQueryDataTable("SELECT NEXT VALUE FOR SEQ_NUM_LOTE_NFE").Rows[0][0];
                    return nextNumber.ToString();
                }
            }
            catch (SqlException ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Falha ao obter a numeração do lote.", "Erro ao obter sequência");
                return string.Empty;
            }
        }

        #region metodos que geram as partes do XML

        /// <summary>
        /// Gera os dados básicos da NF. Cabeçalho: Identificacao da NFe, informacoes da NFe, dados do emitente, destinatario
        /// </summary>
        /// <param name="movimento"></param>
        /// <returns></returns>
        private TNFe GerarTNFeBasico(Movimento movimento)
        {
            try
            {
                var localManager = new LocalidadeDaoManager();

                var emitente = movimento.EmpresaFilial;
                var municEmitente = localManager.GetMunicipioByNome(emitente.Cidade);
                var ufEmitente = localManager.GetUfByCodigo(emitente.Uf);

                var destinatario = movimento.CliFor;
                var municDestinatario = localManager.GetMunicipioByNome(destinatario.Cidade);
                var ufDestinatario = localManager.GetUfByCodigo(destinatario.Uf);

                //informacoes basicas da nota fiscal
                var tnfe = new TNFe()
                {
                    infNFe = new TNFeInfNFe()
                    {
                        Id = "NFe" + movimento.ChaveAcessoNf,
                        versao = "4.00",
                        ide = new TNFeInfNFeIde()
                        {
                            cUF = ufEmitente.CodigoIBGE, //uf do emitente (cod ibge)
                            cNF = "99999",
                            natOp = movimento.TipoMovimento.DescricaoTipoMovimento,
                            mod = movimento.ModeloDocumentoFiscal.CodigoModelo,
                            serie = movimento.Serie,
                            nNF = ParseUtil.ToInt(movimento.NumeroMovimento).ToString(),
                            dhEmi = movimento.DataEmissao.ToString(),
                            dhSaiEnt = movimento.DataEntrada.ToString(),
                            tpNF = ParseUtil.ToInt(movimento.DirecaoMovimento).ToString(), //entrada ou saida
                            idDest = TNFeInfNFeIdeIdDest.Interna,
                            cMunFG = municEmitente.CodigoIbge, //codigo uf do ibge. tratar
                            tpImp = TNFeInfNFeIdeTpImp.DanfeRetrato,
                            tpEmis = TNFeInfNFeIdeTpEmis.Normal,
                            cDV = "9", //digito verificador. tratar
                            tpAmb = TAmb.Homologacao,
                            finNFe = TFinNFe.NFeNormal,
                            indFinal = TNFeInfNFeIdeIndFinal.Nao,
                            indPres = TNFeInfNFeIdeIndPres.NaoPresencial,
                            procEmi = TProcEmi.Contribuinte,
                            verProc = "1"
                        },
                        emit = new TNFeInfNFeEmit()
                        {
                            xNome = emitente.RazaoSocial,
                            xFant = emitente.NomeFantasia,
                            IE = emitente.InscricaoEstadual,
                            IM = emitente.InscricaoMunicipal,
                            CRT = TNFeInfNFeEmitCRT.SimplesNacional,
                            TipoDocumentoEmitente = TipoDocumentoEmitente.CNPJ,
                            TipoDocEmitente = emitente.Cnpj.FixString(),

                            enderEmit = new TEnderEmi()
                            {
                                CEP = emitente.Cep.FixString(),
                                cMun = municEmitente.CodigoIbge,
                                xMun = municEmitente.NomeMunicipio,
                                xPais = emitente.Pais,
                                fone = emitente.Telefone.FixString(),
                                nro = emitente.NumeroEndereco,
                                xCpl = emitente.Complemento,
                                UF = emitente.Uf,
                                xBairro = emitente.Bairro,
                                xLgr = emitente.NomeEndereco
                            }
                        },

                        dest = new TNFeInfNFeDest()
                        {
                            TipoDocumentoDestinatario = TipoDocumentoDestinatario.CNPJ,
                            TipoDocumento = destinatario.CpfCnpj.FixString(),
                            email = destinatario.Email,
                            IE = destinatario.InscricaoEstadual,
                            IM = destinatario.InscricaoMunicipal,
                            indIEDest = TNFeInfNFeDestIndIEDest.NaoContribuinte,
                            xNome = destinatario.RazaoSocial,

                            enderDest = new TEndereco()
                            {
                                CEP = destinatario.Cep.FixString(),
                                cMun = municDestinatario.CodigoIbge,
                                xMun = municDestinatario.NomeMunicipio,
                                cPais = destinatario.Pais,
                                xPais = destinatario.Pais,
                                fone = destinatario.Telefone.FixString(),
                                nro = destinatario.NumeroEndereco,
                                UF = destinatario.Uf,
                                xBairro = destinatario.Bairro,
                                xCpl = destinatario.Complemento,
                                xLgr = destinatario.NomeEndereco
                            }
                        }
                    }
                };

                GerarTNFeDetalhes(movimento, tnfe);
                tnfe.infNFe.total = GerarTotalNFe(movimento);
                tnfe.infNFe.transp = GerarDadosTransporte(movimento);
                tnfe.infNFe.infAdic = GerarDadosAdicionais(movimento);


                return tnfe;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Gerar os detalhes da NFe - Itens, impostos
        /// </summary>
        /// <param name="movimento"></param>
        /// <param name="tnfe"></param>
        /// <returns></returns>
        private TNFeInfNFeDet GerarTNFeDetalhes(Movimento movimento, TNFe tnfe)
        {
            try
            {
                // Gets a NumberFormatInfo associated with the en-US culture.
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                nfi.NumberDecimalSeparator = ".";

                //gera detalhes de item e imposto
                var i = 1; //indice

                //inicializando o array, maximo 990 itens por NFe
                tnfe.infNFe.det = new TNFeInfNFeDet[990];

                var det = new TNFeInfNFeDet();

                foreach (var prod in movimento.ItensMovimento)
                {
                    //numero do item
                    det.nItem = i.ToString();

                    //gerar detalhe dos produtos
                    det.prod = new TNFeInfNFeDetProd()
                    {
                        cProd = prod.Produto.CodigoBarras,
                        xProd = prod.Produto.DescricaoProduto,
                        cEAN = "",
                        CFOP = prod.Cfop.CodigoCfop,
                        CEST = "",
                        cEANTrib = "",
                        indTot = TNFeInfNFeDetProdIndTot.ValorProdutoCompoeTotalNF,
                        NCM = prod.Produto.CodigoNCM,
                        qCom = prod.Quantidade.ToString(nfi),
                        qTrib = prod.Quantidade.ToString(nfi),
                        uCom = prod.Produto.UnidadeMedida.NomeUnidadeMedida,
                        uTrib = prod.Produto.UnidadeMedida.NomeUnidadeMedida,
                        vDesc = "0.00",
                        vFrete = "0.00",
                        vOutro = "0.00",
                        vSeg = "0.00",
                        vUnCom = prod.ValorUnitario.ToString(nfi),
                        vUnTrib = prod.ValorUnitario.ToString(nfi),
                        vProd = prod.TotalItem.ToString(nfi)
                    };

                    var impostosItem = new TNFeInfNFeDetImposto();
                    det.imposto = impostosItem;
                    det.imposto.Items = new object[prod.ImpostosItemMovimento.Count];

                    //gerar impostos
                    foreach (var imp in prod.ImpostosItemMovimento)
                    {
                        if (imp.TipoImposto.CodigoImposto == "PIS")
                            det.imposto.PIS = gerarImpostoPIS(imp);

                        else if (imp.TipoImposto.CodigoImposto == "COFINS")
                            det.imposto.COFINS = gerarImpostoCOFINS(imp);

                        else if (imp.TipoImposto.CodigoImposto == "ICMS")
                            det.imposto.Items[i] = gerarImpostoICMS(imp);

                    }

                    //adicionando o item no array de detalhes da NF
                    tnfe.infNFe.det[i] = det;
                    i++;
                }

                return det;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private TNFeInfNFeTotal GerarTotalNFe(Movimento movimento)
        {
            try
            {
                // Gets a NumberFormatInfo associated with the en-US culture.
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                nfi.NumberDecimalSeparator = ".";

                //totais
                var total = new TNFeInfNFeTotal()
                {
                    ICMSTot = new TNFeInfNFeTotalICMSTot()
                    {
                        vBC = movimento.ValorBaseICMS.Value.ToString(nfi),
                        vBCST = movimento.ValorBaseICMSST.Value.ToString(nfi),
                        vDesc = movimento.ValorDesconto.Value.ToString(nfi),
                        vFrete = movimento.ValorFrete.Value.ToString(nfi),
                        vICMS = movimento.ValorICMS.Value.ToString(nfi),
                        vST = movimento.ValorICMSST.Value.ToString(nfi),
                        vOutro = movimento.ValorDespesasAcessorias.Value.ToString(nfi),
                        vProd = movimento.TotalProdutos.ToString(nfi),
                        vNF = movimento.TotalMovimento.ToString(nfi),
                        vSeg = movimento.ValorSeguro.Value.ToString(nfi),
                        vPIS = movimento.ObtemValorImposto(3).ToString(nfi),
                        vCOFINS = movimento.ObtemValorImposto(4).ToString(nfi)
                    }
                };

                return total;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private TNFeInfNFeTransp GerarDadosTransporte(Movimento movimento)
        {
            try
            {
                //informacoes de transporte
                var transp = new TNFeInfNFeTransp()
                {
                    modFrete = movimento.IndicadorFrete
                };

                transp.transporta = GerardadosTransportador(movimento);

                return transp;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private TNFeInfNFeTranspTransporta GerardadosTransportador(Movimento movimento)
        {
            try
            {
                //se tem dados do transportador gere na NF
                if (movimento.Transportador != null)
                {
                    var transpMov = movimento.Transportador;
                    var tpDoc = transpMov.CpfCnpjTransportador.FixString().Length > 9 ? TypeTipoDocumentoNFe.CNPJ : TypeTipoDocumentoNFe.CPF;

                    var transporta = new TNFeInfNFeTranspTransporta()
                    {
                        IE = transpMov.InscricaoEstadualTransportador.FixString(),
                        UF = transpMov.UFTransportador,
                        xEnder = transpMov.EnderecoTransportador,
                        xMun = transpMov.MunicipioTransportador,
                        xNome = transpMov.RazaoSocialTransportador,
                        TipoDocumentoTransportador = tpDoc,
                        CpfCnpjTransportador = transpMov.CpfCnpjTransportador.FixString()
                    };
                    //define o transportador da NFe
                    return transporta;
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private TNFeInfNFeInfAdic GerarDadosAdicionais(Movimento movimento)
        {
            try
            {
                var infAdic = new TNFeInfNFeInfAdic()
                {
                    infCpl = movimento.Observacoes
                };

                return infAdic;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ValidarXml(string xml, string schema)
        {
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            XmlReaderSettings settings = new XmlReaderSettings()
            {
                ValidationType = ValidationType.Schema,
                Schemas = schemaSet
            };
            schemaSet.Add(null, schema);
            settings.ValidationEventHandler += Settings_ValidationEventHandler;
            StringReader stringReader = new StringReader(xml);

            XmlReader reader = XmlReader.Create(stringReader, settings);

            try
            {
                while (reader.Read()) { }
            }
            catch (XmlException xmlE)
            {
                Console.WriteLine(xmlE.Message);
            }
            finally
            {
                reader.Close();
            }

            if (listValidacoes.Count > 0)
            {
                XFrmOptionPane.ShowListTextArea(listValidacoes, "Erros encontrados na valicação do XML");
                return false;
            }
            else
                return true;
        }

        private void Settings_ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            this.listValidacoes.Add("Erro de validação -> " + e.Message);
            this.listValidacoes.Add("----------------------------------------");
        }

        #endregion
    }

}
