using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Enumeradores;
using ITE.Entidades.POCO.Fiscal;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using ITE.Entidades.DaoManager.FiscalDaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Enumeradores.TipoMovimentoEnum;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;
using ITE.Entidades.Enumeradores.NFeEnum;
using ITE.Fiscal.NFe.XMLSchemas.ClassesNFe;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;

namespace ITE.Fiscal.Movimentacoes.NotaFiscal
{
    public partial class XFrmNotaFiscal : DevExpress.XtraEditors.XtraForm
    {
        #region Variaveis internas
        public List<ItemMovimento> itensNota = new List<ItemMovimento>();
        public List<ItemMovimento> itensNotaCopy = new List<ItemMovimento>();
        public List<ImpostoItemMovimento> impostosRemovidos = new List<ImpostoItemMovimento>();
        public List<ItemMovimento> itensRemovidos = new List<ItemMovimento>();
        public Movimento capa;
        public FormTypeAction formTypeAction;
        public Usuario currentUser;
        private readonly EmpresaFilial filialCurrent;
        private TypeFiltroMovimento typeFiltroMovimento;
        public Movimento NotaFiscal { get; private set; }
        private bool isMovimentoValid = false;
        #endregion

        #region Construtores
        public XFrmNotaFiscal()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);
            xTraTabNF.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        //Criacao de nota fiscal
        public XFrmNotaFiscal(Usuario currentUser, TypeFiltroMovimento typeFiltroMovimento, EmpresaFilial filialCurrent) : this()
        {
            this.currentUser = currentUser;
            this.typeFiltroMovimento = typeFiltroMovimento;
            this.lookUpTipoMovimento1.TypeFiltroMovimento = typeFiltroMovimento;
            this.filialCurrent = filialCurrent;
            btnEditNF.Visible = false;
            btnSalvar.Enabled = true;

            //se for um movimento novo defina a filial do contexto.
            if (capa == null)
            {
                lookUpMatrizFilial1.FindSetMatrizFilial(filialCurrent.Matriz, filialCurrent);
            }
        }

        //Edição da nota fiscal
        public XFrmNotaFiscal(Movimento capaNF, FormTypeAction formTypeAction, TypeFiltroMovimento typeFiltroMovimento, Usuario currentUser) : this()
        {
            this.capa = capaNF;
            this.formTypeAction = formTypeAction;
            this.currentUser = currentUser;
            this.typeFiltroMovimento = typeFiltroMovimento;
            this.lookUpTipoMovimento1.TypeFiltroMovimento = typeFiltroMovimento;
            btnEditNF.Visible = true;
            //deixar readyOnly os textEdits
            ComponenteUtil.ReadyOnly(true, getComponents()[0]);
            //desabilitar os componentes
            ComponenteUtil.DesabilitarComponentes(getComponents()[1]);
            //desabilitar os lookups ITS
            lookUpCentroCusto1.ReadOnlyMode();
            lookUpFormaPagamento1.ReadOnlyMode();
            lookUpMatrizFilial1.ReadyOnlyMode();
            lookUpCliFor1.ReadOnlyMode();
            lookUpTipoMovimento1.ReadOnlyMode();
            lookUpModeloDocFiscal1.ReadOnlyMode();
            lookUpLocalEstoque1.ReadOnlyMode();
            //desabilitar a ediçao se houver alguma parcela paga
            if (isParcelasPagas(capaNF) || capa.TipoMovimento.CategoriaTipoMovimento == TypeCategoriaTipoMovimento.Transferencia)
            {
                btnEditNF.Enabled = false;

                if (capa.TipoMovimento.CategoriaTipoMovimento == TypeCategoriaTipoMovimento.Transferencia)
                    lbMensagem.Visible = true;

            }

        }

        #endregion

        #region Eventos do NavBar. Troca das guias da nota fiscal
        private void navInfoFrete_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTraTabNF.SelectedTabPage = xtraTabFrete;
        }

        private void navItgFinanceira_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTraTabNF.SelectedTabPage = xtraTabItgFinanceira;
        }
        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTraTabNF.SelectedTabPage = xtraTabValores;
        }
        private void btnCabecalhoView_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTraTabNF.SelectedTabPage = xtraTabCabecalho;
        }

        private void btnItensView_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTraTabNF.SelectedTabPage = xtraTabItensNF;
        }
        private void navInfoObservacoes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTraTabNF.SelectedTabPage = xtraTabObserv;
        }
        private void navItgContabFiscal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTraTabNF.SelectedTabPage = xtraTabItgContabFiscal;
        }
        #endregion

        #region Eventos dos botões
        //Fecha o form
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Salvar nota fiscal
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                valida();
                dxValidadorNF.Validate();
                if (isMovimentoValid)
                {


                    var ctx = new BalcaoContext();
                    var util = new MovimentoDaoManager();
                    var nf = this.capa == null ? indexarNotaFiscal(true) : this.capa;
                    var novaNF = indexarNotaFiscal(true);
                    var acao = this.formTypeAction;

                    //VALIDACOES DA NOTA FISCAL
                    var listErros = util.ValidarNotaFiscalInclusao(novaNF, acao);
                    var validador = new XFrmListaValidacaoNF(listErros);


                    if (listErros.Count > 0)
                    {
                        validador.ShowDialog();
                    }

                    //se estiver criando uma NF, ctx.Save(T)
                    if (formTypeAction != FormTypeAction.Visualizar && ValidadorDTO.ValidateWarningAll(nf))
                    {
                        //se clicou em Continuar na tela dos erros...
                        if (!validador.Return)
                        {
                            IMovimentoDaoManager m =
                                 new MovimentoDaoManager();
                            //var transaction = new MovimentoDaoManager().
                            m.SalvarMovimento(nf);
                        }
                    }

                    //senao, ctx.Update(T)
                    else
                    {
                        //recupera o movimento do banco
                        //indexar a nota zerando as referencias
                        var capaEdit = ctx.MovimentoSet.Find(capa.IdMovimento);

                        nf.IdMovimento = capaEdit.IdMovimento;

                        //se clicou em Continuar...
                        if (!validador.Return)
                        {
                            IMovimentoDaoManager m =
                                new MovimentoDaoManager();
                            m.UpdateMovimentoFiscal(capaEdit, novaNF, itensRemovidos, currentUser);
                        }
                    }
                }
            }
            catch (DbUpdateException db)
            {
                XMessageIts.ExceptionMessageDetails(db, "Dados em duplicidade! Vefique todos os campos e se já não existe uma nota fiscal com os mesmos dados!");
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Ocorreu um erro na inclusão/atualização da nota fiscal");
            }
        }
        private void bntEditar_Click(object sender, EventArgs e)
        {
            //deixa readyOnly false
            ComponenteUtil.ReadyOnly(false, getComponents()[0]);
            //ativa os outros componentes
            ComponenteUtil.HabilitarComponentes(getComponents()[1]);
            //habilitar os lookups ITS
            lookUpCentroCusto1.ReadOnlyMode(false);
            lookUpFormaPagamento1.ReadOnlyMode(false);
            lookUpMatrizFilial1.ReadyOnlyMode(false);
            lookUpCliFor1.ReadOnlyMode(false);
            lookUpTipoMovimento1.ReadOnlyMode(false);
            lookUpModeloDocFiscal1.ReadOnlyMode(false);
            lookUpTransportador.ReadOnlyMode(false);
            lookUpLocalEstoque1.ReadOnlyMode(false);
            btnSalvar.Enabled = true;
        }

        private void lookUpTransportador_Leave(object sender, EventArgs e)
        {
            var transportador = lookUpTransportador.CliFor;
            indexarDadosTransportador(transportador);

        }

        #endregion

        #region Eventos da aba dos itens
        //Adicionar item na nota em edicao
        private void barBtnAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddItemNF_NEW(this).ShowDialog();
            //Se adicionou o item, atualize o grid
            if (itensNota != null)
                atualizarGridItems();
        }
        //atualizar o grid com os itens da NF
        private void barBtnAtualizarDados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            atualizarGridItems();
        }
        //calcula os valores da nota em edicao/criacao
        private void btnCalcNf_Click(object sender, EventArgs e)
        {
            CalculaTotaisNF();
        }
        //Editar o item selecionado
        private void barBtnEditarItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var itemSelect = GridViewUtil.GetFocusedRow<ItemMovimento>(gridViewItensNF);
            new XFrmAddItemNF_NEW(itemSelect, FormTypeAction.Alterar, this).ShowDialog();
            atualizarGridItems();

            //para edicao, passar o item selecionado como parametro e a ação do formulario
            //if (formTypeAction == FormTypeAction.Visualizar)
            //{
            //    var itemSelect = XGridViewUtil.GetFocusedRow<NotaFiscalItem>(gridViewItensNF);

            //    new XFrmAddItemNF_NEW(itemSelect, formTypeAction, this).ShowDialog();
            //    atualizarGridItems();
            //}//senao, passar o form atual para adicao dos itens
            //else
            //{
            //    var itemSelect = XGridViewUtil.GetFocusedRow<NotaFiscalItem>(gridViewItensNF);
            //    new XFrmAddItemNF_NEW(itemSelect).ShowDialog();
            //    atualizarGridItems();
            //}
        }
        //remover o item selecionado.
        private void barBtnRemoveItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var itemSelect = GridViewUtil.GetFocusedRow<ItemMovimento>(gridViewItensNF);
            if (itemSelect != null)
            {
                itensRemovidos.Add(itemSelect);
                capa.ItensMovimento.Remove(itemSelect);
                itensNota.Remove(itemSelect);
                atualizarGridItems();
            }
        }
        #endregion

        #region Montagem dos caches do form: comboBox's

        private void XFrmEntradaNew_Shown(object sender, EventArgs e)
        {
            if (capa != null)
                indexarCamposNotaFiscal(capa);
        }
        private void lookUpTipoMovimento1_Leave(object sender, EventArgs e)
        {
            var tpMov = lookUpTipoMovimento1.TipoMovimento;

            if (tpMov != null)
            {
                if (tpMov.FormaPagamento != null)
                    lookUpFormaPagamento1.FormaPagto = tpMov.FormaPagamento;
                if (tpMov.CentroCusto != null)
                    lookUpCentroCusto1.CentroCusto = tpMov.CentroCusto;

                if (tpMov.LocalEstoque != null)
                    lookUpLocalEstoque1.LocalEstoque = tpMov.LocalEstoque;

                chkGerarFat.Checked = tpMov.GerarFaturamento;
                if (tpMov.Direcao == Entidades.Enumeradores.RegraFiscalEnum.TypeDirecao.Entrada)
                    rdTipoNf.SelectedIndex = 0;
                else
                    rdTipoNf.SelectedIndex = 1;
            }
        }
        #endregion

        #region Ações, metodos, etc

        //Calcula os totais da nota e atualiza os campos de texto   
        public Decimal CalculaTotaisNF()
        {
            var NFCalc = indexarNotaFiscal(true);
            var totalNF = 0M;
            if (NFCalc != null)
            {
                var frete = ParseUtil.ToDecimal(txtVlrFrete.Text);
                var seguro = ParseUtil.ToDecimal(txtVlrSeguro.Text);
                var despesas = ParseUtil.ToDecimal(txtVlrDespesas.Text);
                var desconto = ParseUtil.ToDecimal(txtVlrDesconto.Text);

                totalNF = (frete + seguro + despesas + NFCalc.TotalProdutos) - desconto;
                //preenche os textBox
                txtVlrTotalNf.Text = totalNF.ToString("n2");
                txtVlrBaseICMS.Text = NFCalc.ValorBaseICMS.Value.ToString("N2");
                txtVlrBaseICMSST.Text = NFCalc.ValorBaseICMSST.Value.ToString("N2");
                txtVlrICMS.Text = NFCalc.ValorICMS.Value.ToString("N2");
                txtVlrICMSST.Text = NFCalc.ValorICMSST.Value.ToString("N2");
            }

            return totalNF;
        }

        private Movimento indexarNotaFiscal(Boolean zerarReferencias = false)
        {
            Movimento notaFiscalAdd;
            int sequencial = 0;
            var cliForn = lookUpCliFor1.CliFor;

            var modeloNf = lookUpModeloDocFiscal1.ModeloDocumentoFiscal;

            var formaPagto = lookUpFormaPagamento1.FormaPagto;
            var centroCusto = lookUpCentroCusto1.CentroCusto;

            var filialNf = lookUpMatrizFilial1.Filial;
            var tipoNF = rdTipoNf.SelectedIndex == 0 ? TypeDirecao.Entrada : TypeDirecao.Saída;
            var numNF = String.Format("{0:000000000}", ParseUtil.ToInt(txtNumNf.Text));
            var dtEmissaoNf = dtEmissao.Value.Date;
            var dtEntradaNf = dtEntrada.Value.Date;
            var situacaoDocumento = 1; //sempre na inclusao será "Documento Regular", caso seja lancamento de uma
                                       //nf já existente que foi cancelada, devera ser feito o cancelamento depois de salvar
            var indicadorFrete = rdTipoFrete.SelectedIndex;
            var chaveAcessoNf = txtChaveAcessoNf.Text;
            var valorFrete = ParseUtil.ToDecimal(txtVlrFrete.Text);
            var valorDesconto = ParseUtil.ToDecimal(txtVlrDesconto.Text);
            var valorBaseICMS = 0M; //ParseUtil.ToDecimal(txtVlrBaseICMS.Text);
            var valorICMS = 0M; // ParseUtil.ToDecimal(txtVlrICMS.Text);
            var valorBaseICMSST = 0M; // ParseUtil.ToDecimal(txtVlrBaseICMSST.Text);
            var valorICMSST = 0M; // ParseUtil.ToDecimal(txtVlrICMSST.Text);
            var valorSeguro = ParseUtil.ToDecimal(txtVlrSeguro.Text);
            var valorDespesas = ParseUtil.ToDecimal(txtVlrDespesas.Text);
            var valorTotalProdutos = 0M;
            var serie = txtSerieNf.Text;
            var subserie = txtSubSerie.Text;
            var observacoes = memoEditObservacoes.Text;
            var localEstoque = lookUpLocalEstoque1.LocalEstoque;
            var tipoMovimento = lookUpTipoMovimento1.TipoMovimento;

            notaFiscalAdd = new Movimento(cliForn, modeloNf, filialNf, tipoNF, numNF, dtEmissaoNf,
                dtEntradaNf, situacaoDocumento, chaveAcessoNf, valorFrete, valorDesconto, valorBaseICMS, valorICMS,
                valorBaseICMSST, valorICMSST, valorSeguro, valorDespesas, valorTotalProdutos, /*Total NF*/0M, serie, subserie);
            notaFiscalAdd.CliFor = cliForn;
            //notaFiscalAdd.SituacaoDocumentoFiscal = situacaoDocumento;
            notaFiscalAdd.ModeloDocumentoFiscal = modeloNf;

            foreach (var item in itensNota)
            {
                item.SequencialItem = sequencial + 1;
                item.IndicadorMovFisica = 0;
                item.Produto = item.Produto;
                item.Cfop = item.Cfop;
                valorTotalProdutos += item.TotalItem;
                notaFiscalAdd.ItensMovimento.Add(item);

                foreach (var imposto in item.ImpostosItemMovimento)
                {
                    //somando os valores da base e imposto da capa
                    if (imposto.IdImposto == 2) //ICMS
                    {
                        notaFiscalAdd.ValorBaseICMS += imposto.BaseCalculo;
                        notaFiscalAdd.ValorICMS += imposto.ValorImposto;
                    }
                    else if (imposto.IdImposto == 5) //ICMS-ST
                    {
                        notaFiscalAdd.ValorBaseICMSST += imposto.BaseCalculo;
                        notaFiscalAdd.ValorICMSST += imposto.ValorImposto;
                    }
                    //zerando a referencia para impostos e situacao tributaria
                    imposto.TipoImposto = imposto.TipoImposto;
                    imposto.SituacaoTributaria = imposto.SituacaoTributaria;
                }
                sequencial++;//incrementa o seq do item
            }
            var totalNF = (valorTotalProdutos + valorFrete + valorSeguro + valorDespesas) - valorDesconto;

            notaFiscalAdd.TotalProdutos = notaFiscalAdd.CalculaTotalProdutos();
            notaFiscalAdd.TotalMovimento = notaFiscalAdd.CalcularTotaisNF();
            notaFiscalAdd.IndicadorFrete = indexModalidadeFrete(indicadorFrete);
            notaFiscalAdd.Observacoes = observacoes;
            notaFiscalAdd.FormaPagamento = formaPagto;
            notaFiscalAdd.IdFormaPagamento = formaPagto.IdFormaPagamento;
            notaFiscalAdd.CentroCusto = centroCusto;
            notaFiscalAdd.IdCentroCusto = centroCusto.IdCentroCusto;
            notaFiscalAdd.Usuario = currentUser;
            notaFiscalAdd.IdUsuario = currentUser.IdUsuario;
            notaFiscalAdd.GerarParcelas(notaFiscalAdd);
            notaFiscalAdd.EmpresaFilial = filialNf;
            notaFiscalAdd.LocalEstoque = localEstoque;
            notaFiscalAdd.IdLocalEstoque = localEstoque.IdLocalEstoque;
            notaFiscalAdd.TipoMovimento = tipoMovimento;
            notaFiscalAdd.IdTipoMovimento = tipoMovimento.IdTipoMovimento;

            //indexar transportador
            notaFiscalAdd.Transportador = indexarDadosTransportador(lookUpTransportador.CliFor);

            return notaFiscalAdd;
        }

        private void atualizarGridItems()
        {
            gridControlItensNF.DataSource = itensNota;
            gridControlItensNF.RefreshDataSource();
            gridControlItensNF.Refresh();
        }
        //preenche os controles com os dados da nota selecionada
        private Movimento indexarCamposNotaFiscal(Movimento notaFiscal)
        {
            if (notaFiscal != null)
            {
                if (notaFiscal.EmpresaFilial != null)
                {
                    lookUpMatrizFilial1.FindSetFilial(notaFiscal.EmpresaFilial.CodigoFilial);
                    lookUpMatrizFilial1.FindSetMatriz(notaFiscal.EmpresaFilial.Matriz.CodigoMatriz);
                }

                if (notaFiscal.IdCliFor != null)
                    lookUpCliFor1.FindSetCliFor(notaFiscal.IdCliFor.ToString());

                if (notaFiscal.TipoMovimento != null)
                    lookUpTipoMovimento1.FindSetTpMov(notaFiscal.TipoMovimento.CodigoTipoMovimento);

                if (notaFiscal.ModeloDocumentoFiscal != null)
                    lookUpModeloDocFiscal1.FindSetModelo(notaFiscal.ModeloDocumentoFiscal.CodigoModelo);

                if (notaFiscal.CentroCusto != null)
                    lookUpCentroCusto1.FindSetCentroCusto(notaFiscal.CentroCusto.CodigoCentroCusto);

                if (notaFiscal.IdFormaPagamento != null)
                    lookUpFormaPagamento1.FindSetFormaPagto(notaFiscal.IdFormaPagamento.ToString());

                if (notaFiscal.LocalEstoque != null)
                    lookUpLocalEstoque1.FindSetLocalEstoque(notaFiscal.LocalEstoque.CodigoLocalEstoque);


                if (notaFiscal.DirecaoMovimento == TypeDirecao.Entrada)
                    rdTipoNf.SelectedIndex = 0;
                else //"Saida"
                    rdTipoNf.SelectedIndex = 1;

                dtEmissao.Value = notaFiscal.DataEmissao;
                dtEntrada.Value = notaFiscal.DataEntrada;
                txtSerieNf.Text = notaFiscal.Serie;
                txtSubSerie.Text = notaFiscal.SubSerie;
                txtNumNf.Text = notaFiscal.NumeroMovimento;
                txtChaveAcessoNf.Text = notaFiscal.ChaveAcessoNf;
                itensNota = notaFiscal.ItensMovimento.ToList();
                gridControlItensNF.DataSource = itensNota;
                txtVlrFrete.Text = notaFiscal.ValorFrete.Value.ToString("N2");
                txtVlrSeguro.Text = notaFiscal.ValorSeguro.Value.ToString("N2");
                txtVlrDesconto.Text = notaFiscal.ValorDesconto.Value.ToString("N2");
                txtVlrDespesas.Text = notaFiscal.ValorDespesasAcessorias.Value.ToString("N2");
                txtVlrBaseICMS.Text = notaFiscal.ValorBaseICMS.Value.ToString("n2");
                txtVlrBaseICMSST.Text = notaFiscal.ValorBaseICMSST.Value.ToString("N2");
                txtVlrICMS.Text = notaFiscal.ValorICMS.Value.ToString("n2");
                txtVlrICMSST.Text = notaFiscal.ValorICMSST.Value.ToString("N2");
                txtVlrTotalNf.Text = notaFiscal.TotalMovimento.ToString("N2");
                rdTipoFrete.SelectedIndex = setRadioFrete(notaFiscal.IndicadorFrete);
                memoEditObservacoes.Text = notaFiscal.Observacoes;
                chkGerarFat.Checked = notaFiscal.TipoMovimento.GerarFaturamento;
                gridControlParcelas.DataSource = notaFiscal.Parcelas.ToList();
                if (notaFiscal.Transportador != null && notaFiscal.Transportador.Transportador != null)
                    indexarDadosTransportador(notaFiscal.Transportador.Transportador);
                return notaFiscal;

            }
            return null;
        }

        private List<Component[]> getComponents()
        {
            var v_Components = new List<Component[]>();

            //componentes que ficarão ReadyOnly
            var txtsForm = new Component[] { txtSerieNf, txtNumNf, txtSubSerie, txtChaveAcessoNf, txtVlrFrete, txtVlrSeguro, txtVlrDespesas, txtVlrDesconto, txtVlrBaseICMS, txtVlrBaseICMSST, txtVlrICMS, txtVlrICMSST, txtVlrTotalNf, txtRazSocTransportador, txtEndTransp, txtNumEndTransp, txtIETransp, txtMuncTransporta, txtUfTranspo, txtMunicipioTranporta, txtCompEndTransp, txtCnpjTransport };
            lookUpTransportador.ReadOnlyMode(true);
            v_Components.Add(txtsForm);

            //componentes que serão desabilitados
            var disableComps = new Component[] {lookUpMatrizFilial1, dtEmissao, dtEntrada, rdTipoNf, lookUpCliFor1, barBtnAddItem, barBtnEditarItem, barBtnRemoveItem, barBtnAtualizarDados
            , btnCalcNf,  rdTipoFrete, memoEditObservacoes, lookUpMatrizFilial1, lookUpFormaPagamento1, cbTpDocTransportador};

            v_Components.Add(disableComps);

            return v_Components;
        }

        /// <summary>
        /// se exitir mais de 1 parcela ja paga, nao e possivel editar a nota fiscal
        /// </summary>
        /// <param name="notaFiscal"></param>
        /// <returns></returns>
        private bool isParcelasPagas(Movimento notaFiscal)
        {
            if (notaFiscal != null)
            {
                var parcelasPagas = notaFiscal.Parcelas.Where(p => p.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago).Count();
                //se tiver alguma parcela paga
                if (parcelasPagas > 1)
                {
                    return true;
                }
            }
            return false;
        }

        private TransportadorMovimento indexarDadosTransportador(CliFor cliFor)
        {
            if (cliFor != null)
            {
                txtRazSocTransportador.Text = cliFor.RazaoSocial;
                txtCnpjTransport.Text = cliFor.CpfCnpj;
                txtEndTransp.Text = cliFor.NomeEndereco;
                txtNumEndTransp.Text = cliFor.NumeroEndereco;
                txtCompEndTransp.Text = cliFor.Complemento;
                txtIETransp.Text = cliFor.InscricaoMunicipal;
                txtMunicipioTranporta.Text = cliFor.Cidade;
                txtUfTranspo.Text = cliFor.Uf;
                cbTpDocTransportador.SelectedItem =
                    cliFor.TipoCliente == TypeCliente.Juridica ? cbTpDocTransportador.SelectedIndex = 0 : cbTpDocTransportador.SelectedIndex = 1;

                var tpDoc = indexTpDoc();

                lookUpTransportador.FindSetCliFor(cliFor.IdCliFor.ToString());

                var transp = new TransportadorMovimento()
                {
                    IdCliForTransportador = cliFor.IdCliFor,
                    InscricaoEstadualTransportador = cliFor.InscricaoEstadual,
                    MunicipioTransportador = cliFor.Cidade,
                    UFTransportador = cliFor.Uf,
                    RazaoSocialTransportador = cliFor.RazaoSocial,
                    EnderecoTransportador = cliFor.NomeEndereco + ", " + cliFor.NumeroEndereco + ", " + cliFor.Bairro + " - " + cliFor.Complemento,
                    TipoDocTransportador = tpDoc,
                    CpfCnpjTransportador = txtCnpjTransport.Text
                };

                return transp;
            }
            return null;
        }
        private TypeTipoDocumentoNFe indexTpDoc()
        {
            if (cbTpDocTransportador.SelectedIndex == 0)
                return TypeTipoDocumentoNFe.CNPJ;
            else
                return TypeTipoDocumentoNFe.CPF;
        }

        private TypeModalidadeFrete indexModalidadeFrete(int selectedItem)
        {
            if (selectedItem == 0)
                return TypeModalidadeFrete.PorContaRemetenteCIF;
            else if (selectedItem == 1)
                return TypeModalidadeFrete.DestinatarioOuRemetenteFOB;
            else if (selectedItem == 2)
                return TypeModalidadeFrete.PorContaTerceiros;
            else
                return TypeModalidadeFrete.SemOcorrenciaFrete;
        }
        private int setRadioFrete(TypeModalidadeFrete modalidadeFrete)
        {
            if (modalidadeFrete == TypeModalidadeFrete.PorContaRemetenteCIF)
                return 0;
            else if (modalidadeFrete == TypeModalidadeFrete.DestinatarioOuRemetenteFOB)
                return 1;
            else if (modalidadeFrete == TypeModalidadeFrete.PorContaTerceiros)
                return 2;
            else
                return 3;
        }

        #endregion

        #region Testes validacao pelo dxValidationProvider
        private class ValidarObjetoNulo : ValidationRule
        {
            public override bool Validate(Control control, object value)
            {
                if (value != null)
                    return true;
                else
                    return false;
            }
        }
        private void valida()
        {
            ValidarObjetoNulo validarObjetoNulo = new ValidarObjetoNulo();
            validarObjetoNulo.ErrorText = "Por favor informe um valor.";
            validarObjetoNulo.ErrorType = ErrorType.Warning;

            dxValidadorNF.SetValidationRule(txtNumNf, validarObjetoNulo);
            dxValidadorNF.SetValidationRule(txtSerieNf, validarObjetoNulo);
            dxValidadorNF.SetValidationRule(lookUpTipoMovimento1.TextCodigoCentroTpMov, validarObjetoNulo);
            dxValidadorNF.SetValidationRule(lookUpCliFor1.TextCodCliFor, validarObjetoNulo);
            dxValidadorNF.SetValidationRule(lookUpLocalEstoque1.TextCodigoLocalEstoque, validarObjetoNulo);
            dxValidadorNF.SetValidationRule(lookUpCentroCusto1.TextCodigoCentroCusto, validarObjetoNulo);
        }

        private void dxValidadorNF_ValidationSucceeded(object sender, ValidationSucceededEventArgs e)
        {
            this.isMovimentoValid = true;
        }

        private void dxValidadorNF_ValidationFailed(object sender, ValidationFailedEventArgs e)
        {
            this.isMovimentoValid = false;
        }

        #endregion


    }
}