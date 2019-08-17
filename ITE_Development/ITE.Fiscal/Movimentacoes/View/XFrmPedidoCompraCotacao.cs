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
using ITE.Fiscal.NFe.XMLSchemas.ClassesNFe;

namespace ITE.Fiscal.Movimentacoes.OutrasMovimentacoes
{
    public partial class XFrmPedidoCompraCotacao : DevExpress.XtraEditors.XtraForm
    {
        #region Variaveis internas
        public List<ItemMovimento> itensNota = new List<ItemMovimento>();
        public List<ItemMovimento> itensNotaCopy = new List<ItemMovimento>();
        public List<ImpostoItemMovimento> impostosRemovidos = new List<ImpostoItemMovimento>();
        public List<ItemMovimento> itensRemovidos = new List<ItemMovimento>();
        public Movimento movimentoCurrent;
        public FormTypeAction formTypeAction;
        public Usuario currentUser;
        private readonly EmpresaFilial filialCurrent;
        TypeFiltroMovimento typeFiltroMovimento;

        #endregion

        #region Construtores
        public XFrmPedidoCompraCotacao()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);
            xTraTabNF.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        //Criacao de nota fiscal
        public XFrmPedidoCompraCotacao(Usuario currentUser, TypeFiltroMovimento typeFiltroMovimento, EmpresaFilial filialCurrent) : this()
        {
            this.currentUser = currentUser;
            this.typeFiltroMovimento = typeFiltroMovimento;
            this.lookUpTipoMovimento1.TypeFiltroMovimento = typeFiltroMovimento;
            this.filialCurrent = filialCurrent;
            btnEditNF.Visible = false;
            btnSalvar.Enabled = true;

            //se for um movimento novo defina a filial do contexto.
            if (movimentoCurrent == null)
            {
                lookUpMatrizFilial1.FindSetMatrizFilial(filialCurrent.Matriz, filialCurrent);
            }
        }

        //Edição da nota fiscal
        public XFrmPedidoCompraCotacao(Movimento capaNF, FormTypeAction formTypeAction, TypeFiltroMovimento typeFiltroMovimento, Usuario currentUser) : this()
        {
            this.movimentoCurrent = capaNF;
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
            lookUpLocalEstoque1.ReadOnlyMode();
            barBtnEditarItem.Enabled = true;
            //desabilitar a ediçao se houver alguma parcela paga
            if (isParcelasPagas(capaNF) || capaNF.TipoMovimento.CategoriaTipoMovimento == TypeCategoriaTipoMovimento.Transferencia)
            {
                btnEditNF.Enabled = false;

                if (capaNF.TipoMovimento.CategoriaTipoMovimento == TypeCategoriaTipoMovimento.Transferencia)
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
        private void navItgContabFiscal_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTraTabNF.SelectedTabPage = xtraTabIntContabFiscal;
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
            var ctx = new BalcaoContext();
            var util = new MovimentoDaoManager();
            var nf = this.movimentoCurrent == null ? indexarMovimento(true) : this.movimentoCurrent;
            var novaNF = indexarMovimento(true);
            var acao = this.formTypeAction;
            try
            {
                //se estiver criando uma NF, ctx.Save(T)
                if (formTypeAction != FormTypeAction.Visualizar && ValidadorDTO.ValidateWarningAll(nf))
                {
                    var transaction = new MovimentoDaoManager().SalvarMovimento(nf);
                }

                //senao, ctx.Update(T)
                else
                {
                    var capaEdit = ctx.MovimentoSet.Find(movimentoCurrent.IdMovimento);//recupera a NF do banco
                                                                                       //indexar a nota zerando as referencias
                    nf.IdMovimento = capaEdit.IdMovimento;

                    var traUpdate = new MovimentoDaoManager().UpdateMovimentoFiscal(capaEdit, novaNF, itensRemovidos, currentUser);

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
            lookUpLocalEstoque1.ReadOnlyMode(false);
            btnSalvar.Enabled = true;
        }

        #endregion

        #region Eventos da aba dos itens
        //Adicionar item na nota em edicao
        private void barBtnAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddItemPedidoCotacao(this).ShowDialog();
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
            new XFrmAddItemPedidoCotacao(itemSelect, FormTypeAction.Alterar, this).ShowDialog();
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
                movimentoCurrent.ItensMovimento.Remove(itemSelect);
                itensNota.Remove(itemSelect);
                atualizarGridItems();
            }
        }
        #endregion

        #region Montagem dos caches do form: comboBox's

        private void XFrmEntradaNew_Shown(object sender, EventArgs e)
        {
            if (movimentoCurrent != null)
                indexarCamposNotaFiscal(movimentoCurrent);
        }



        #endregion

        #region Ações, metodos, etc

        //Calcula os totais da nota e atualiza os campos de texto   
        public Decimal CalculaTotaisNF()
        {
            var NFCalc = indexarMovimento(true);
            var totalNF = 0M;
            if (NFCalc != null)
            {
                var frete = ParseUtil.ToDecimal(txtVlrFrete.Text);
                var seguro = ParseUtil.ToDecimal(txtVlrSeguro.Text);
                var despesas = ParseUtil.ToDecimal(txtVlrDespesas.Text);
                var desconto = ParseUtil.ToDecimal(txtVlrDesconto.Text);

                totalNF = (frete + seguro + despesas + NFCalc.TotalProdutos) - desconto;
                txtVlrTotalNf.Text = totalNF.ToString("n2");
            }

            return totalNF;
        }

        private Movimento indexarMovimento(Boolean zerarReferencias = false)
        {
            Movimento movimentoAdd;
            var tipoMovimento = lookUpTipoMovimento1.TipoMovimento;

            int sequencial = 0;
            var cliForn = lookUpCliFor1.CliFor;
            var formaPagto = lookUpFormaPagamento1.FormaPagto;
            var centroCusto = lookUpCentroCusto1.CentroCusto;
            var localEstoque = lookUpLocalEstoque1.LocalEstoque;
            var filialNf = lookUpMatrizFilial1.Filial;
            var tipoNF = TypeDirecao.Entrada;
            var numNF = String.Format("{0:000000000}", ParseUtil.ToInt(txtNumNf.Text));
            var dtEmissaoNf = dtEmissao.Value.Date;
            var dtEntradaNf = dtEntrada.Value.Date;
            var indicadorFrete = rdTipoFrete.SelectedIndex;
            var valorFrete = ParseUtil.ToDecimal(txtVlrFrete.Text);
            var valorDesconto = ParseUtil.ToDecimal(txtVlrDesconto.Text);
            var valorBaseICMS = 0M; //ParseUtil.ToDecimal(txtVlrBaseICMS.Text);
            var valorICMS = 0M; // ParseUtil.ToDecimal(txtVlrICMS.Text);
            var valorBaseICMSST = 0M; // ParseUtil.ToDecimal(txtVlrBaseICMSST.Text);
            var valorICMSST = 0M; // ParseUtil.ToDecimal(txtVlrICMSST.Text);
            var valorSeguro = ParseUtil.ToDecimal(txtVlrSeguro.Text);
            var valorDespesas = ParseUtil.ToDecimal(txtVlrDespesas.Text);
            var valorTotalProdutos = 0M;
            var serie = txtSerie.Text;
            var subserie = txtSubSerie.Text;
            var observacoes = memoEditObservacoes.Text;

            //se foi escolhido um tipo de movimento..
            if (tipoMovimento != null)
            {
                //verificacao da direcao do movimento...
                if (tipoMovimento.Direcao == Entidades.Enumeradores.RegraFiscalEnum.TypeDirecao.Entrada)
                    tipoNF = TypeDirecao.Entrada;
                else
                    tipoNF = TypeDirecao.Saída;
            }

            movimentoAdd = new Movimento(cliForn, filialNf, tipoNF, numNF, dtEmissaoNf,
                dtEntradaNf, valorFrete, valorDesconto, valorBaseICMS, valorICMS,
                valorBaseICMSST, valorICMSST, valorSeguro, valorDespesas, valorTotalProdutos, /*Total NF*/0M, serie, subserie);
            movimentoAdd.CliFor = cliForn;

            foreach (var item in itensNota)
            {
                item.SequencialItem = sequencial + 1;
                item.IndicadorMovFisica = 0;
                item.Produto = item.Produto;
                valorTotalProdutos += item.TotalItem;
                movimentoAdd.ItensMovimento.Add(item);
                sequencial++;//incrementa o seq do item
            }

            movimentoAdd.TotalProdutos = movimentoAdd.CalculaTotalProdutos();
            movimentoAdd.TotalMovimento = movimentoAdd.CalcularTotaisNF();
            movimentoAdd.IndicadorFrete = indexModalidadeFrete(indicadorFrete);
            movimentoAdd.Observacoes = observacoes;

            movimentoAdd.Usuario = currentUser;
            movimentoAdd.IdUsuario = currentUser.IdUsuario;
            movimentoAdd.EmpresaFilial = filialNf;
            movimentoAdd.TipoMovimento = tipoMovimento;
            movimentoAdd.IdTipoMovimento = tipoMovimento.IdTipoMovimento;
            movimentoAdd.IdSituacao = 1;

            if (movimentoAdd.TipoMovimento.InformarCentro)
            {
                movimentoAdd.CentroCusto = centroCusto;
                movimentoAdd.IdCentroCusto = centroCusto.IdCentroCusto;
            }

            //gerar parcelas somente se o tpmov gerar faturamento
            if (movimentoAdd.TipoMovimento.GerarFaturamento)
            {
                movimentoAdd.FormaPagamento = formaPagto;
                movimentoAdd.IdFormaPagamento = formaPagto.IdFormaPagamento;
                movimentoAdd.GerarParcelas(movimentoAdd);
            }

            //se movimentar estoque, verificar se o local de estoque eh valido e usar para montar o objeto
            if (movimentoAdd.TipoMovimento.MovimentarEstoque && localEstoque != null)
            {
                movimentoAdd.LocalEstoque = localEstoque;
                movimentoAdd.IdLocalEstoque = localEstoque.IdLocalEstoque;
            }

            return movimentoAdd;
        }

        private void atualizarGridItems()
        {
            gridControlItensNF.DataSource = itensNota;
            gridControlItensNF.RefreshDataSource();
            gridControlItensNF.Refresh();
        }
        //preenche os controles com os dados da nota selecionada
        private Movimento indexarCamposNotaFiscal(Movimento movimento)
        {
            if (movimento != null)
            {
                lookUpMatrizFilial1.FindSetFilial(movimento.EmpresaFilial.CodigoFilial);
                lookUpMatrizFilial1.FindSetMatriz(movimento.EmpresaFilial.Matriz.CodigoMatriz);

                if (movimento.DirecaoMovimento == TypeDirecao.Entrada)
                    rdTipoNf.SelectedIndex = 0;
                else //"S"
                    rdTipoNf.SelectedIndex = 1;


                //Dados do fornecedor.
                lookUpCliFor1.FindSetCliFor(movimento.IdCliFor.ToString());

                lookUpTipoMovimento1.FindSetTpMov(movimento.TipoMovimento.CodigoTipoMovimento);
                dtEmissao.Value = movimento.DataEmissao;
                dtEntrada.Value = movimento.DataEntrada;
                txtSerie.Text = movimento.Serie;
                txtSubSerie.Text = movimento.SubSerie;
                txtNumNf.Text = movimento.NumeroMovimento;
                itensNota = movimento.ItensMovimento.ToList();
                gridControlItensNF.DataSource = itensNota;
                txtVlrFrete.Text = movimento.ValorFrete.Value.ToString("N2");
                txtVlrSeguro.Text = movimento.ValorSeguro.Value.ToString("N2");
                txtVlrDesconto.Text = movimento.ValorDesconto.Value.ToString("N2");
                txtVlrDespesas.Text = movimento.ValorDespesasAcessorias.Value.ToString("N2");
                //txtVlrBaseICMS.Text = movimento.ValorBaseICMS.Value.ToString("n2");
                //txtVlrBaseICMSST.Text = movimento.ValorBaseICMSST.Value.ToString("N2");
                //txtVlrICMS.Text = movimento.ValorICMS.Value.ToString("n2");
                //txtVlrICMSST.Text = movimento.ValorICMSST.Value.ToString("N2");
                txtVlrTotalNf.Text = movimento.TotalMovimento.ToString("N2");
                rdTipoFrete.SelectedIndex = setRadioFrete(movimento.IndicadorFrete);
                memoEditObservacoes.Text = movimento.Observacoes;
                chkGerarFat.Checked = movimento.TipoMovimento.GerarFaturamento;

                if (movimento.CentroCusto != null)
                    lookUpCentroCusto1.FindSetCentroCusto(movimento.CentroCusto.CodigoCentroCusto);

                if (movimento.FormaPagamento != null)
                    lookUpFormaPagamento1.FindSetFormaPagto(movimento.IdFormaPagamento.ToString());

                if (movimento.LocalEstoque != null)
                    lookUpLocalEstoque1.FindSetLocalEstoque(movimento.LocalEstoque.CodigoLocalEstoque);

                gridControlParcelas.DataSource = movimento.Parcelas.ToList();
                return movimento;
            }
            return null;
        }

        private List<Component[]> getComponents()
        {
            var v_Components = new List<Component[]>();

            //componentes que ficarão ReadyOnly
            var txtsForm = new Component[] { txtSerie, txtNumNf, txtSubSerie, txtVlrFrete, txtVlrSeguro, txtVlrDespesas, txtVlrDesconto, txtVlrTotalNf };

            v_Components.Add(txtsForm);

            //componentes que serão desabilitados
            var disableComps = new Component[] {lookUpMatrizFilial1, dtEmissao, dtEntrada, rdTipoNf, barBtnAddItem, barBtnEditarItem, barBtnRemoveItem, barBtnAtualizarDados
            , btnCalcNf,  rdTipoFrete, memoEditObservacoes, lookUpCliFor1, lookUpFormaPagamento1, lookUpTipoMovimento1};

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
                if (parcelasPagas >= 1)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Eventos gerais
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
    }
}