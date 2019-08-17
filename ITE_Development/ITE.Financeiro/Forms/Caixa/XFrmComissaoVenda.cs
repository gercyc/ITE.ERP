using System;
using System.Threading.Tasks;
using ITE.Entities.DaoManager.FinanceiroDaoManager;
using ITE.Vendas.Forms.ControleVenda;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;
using System.Linq;

using ITE.Entidades.Enumeradores.FinanceiroEnum;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.Sales;
using ITE.Financeiro.Forms.Wizard;
using ITE.Financeiro.Listeners;
using System.Collections.Generic;
using ITE.Entidades.POCO;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.Enumeradores;

namespace ITE.Financeiro.Forms.Caixa
{
    public partial class XFrmComissaoVenda : DevExpress.XtraEditors.XtraForm
    {
        public XFrmComissaoVenda()
        {
            InitializeComponent();
            //mes atual
            cbFiltro.SelectedIndex = 1;
            //agora por periodo
            cbFiltro.SelectedIndex = 0;
            //master row
            this.masterRowComissao = new MasterRowComissaoVenda(this.gridViewComissoes);
            //status de comissao
            this.cbSituacaoComissao.AddEnumValues<TypeStatusComissaoVenda>();
            //garante o index
            this.cbSituacaoComissao.SelectedIndex = 0;

        }

        #region Metodos

        private async Task loadVendedores()
        {
            using (var ctx = new BalcaoContext())
            {
                var users = await ctx.UsuarioDao.FindAllAsync();
                searchLkpUser.BeginInvoke(new Action(() =>
                {
                    searchLkpUser.Properties.DataSource = users;
                    searchLkpViewUser.RefreshData();
                }));

            }

        }

        private void baixarComissoes(Venda venda, TypeFaturamentoComissao type)
        {
            try
            {
                var comissoes = createComissoes(venda, type);
                var wizardBaixa = new XFrmWizardBaixaLancamento(comissoes, type);

                wizardBaixa.ShowDialog();

                if (wizardBaixa.IsBaixa)
                {

                    this.masterRowComissao.NotifyChidlChanged();
                    gridViewComissoes.RefreshData();
                }
            }
            catch (Exception ex)
            {

                XMessageIts.ExceptionMessageDetails(ex, "Não foi possível baixar as comissões da venda");
            }
        }

        /// <summary>
        /// Gerar as comissoes da venda
        /// </summary>
        /// <param name="venda"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private List<LancamentoFinanceiro> createComissoes(Venda venda, TypeFaturamentoComissao type)
        {
            var lancamentos = new List<LancamentoFinanceiro>();
            var comissoes = venda.Comissoes.Where(c => c.StatusComissao != TypeStatusComissaoVenda.Faturado);
            if (type == TypeFaturamentoComissao.Integral)
            {
                //gera um lançamento unico para essa comissa
                //cria uma comissao com base na venda e gera o lancamento
                //faturando a comissão do usuário
                var lancto = new LancamentoFinanceiro(venda)
                {
                    //status da lancamento (comissao)
                    StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto,
                    //comissao eh sempre a pagar
                    TipoLancamento = TypeLancamentoFinanceiro.Pagar,
                    //comissao integral => todas as comissoes
                    ValorLancamento = venda.Comissoes.Sum(cv => cv.ValorComissao),
                    //histórico
                    Observacao = "COMISSÃO INTEGRAL VENDA Nº: " + venda.IdVenda,
                    //forma de pagamento é dinheiro
                    IdFormaPagamento = 1,
                    //informe a venda
                    IdVenda = venda.IdVenda,

                };

                //add
                lancamentos.Add(lancto);
            }
            else
            {
                foreach (var cv in comissoes)
                {
                    //gera um lançamento unico para essa comissa
                    //cria uma comissao com base na venda e gera o lancamento
                    //faturando a comissão do usuário
                    var lancto = new LancamentoFinanceiro(cv);

                    //add
                    lancamentos.Add(lancto);
                }
            }

            return lancamentos;
        }

        #endregion

        #region Eventos

        private void XFrmCaixaVendas_Shown(object sender, EventArgs e)
        {
            Task.Run(() => loadVendedores());
            barBtnRefresh_ItemClick(null, null);

        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnFiltrar_Click(null, null);
        }

        private void barBtnFaturarComissaoIntegral_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewComissoes.IsSelectOneRowWarning())
            {
                var venda = gridViewComissoes.GetFocusedRow<Venda>();
                var lanctos = venda.Comissoes.ToList();
                bool faturar = true;
                if (lanctos.Any(l => l.StatusComissao == TypeStatusComissaoVenda.Faturado))
                {
                    var op = XMessageIts.Confirmacao("Uma ou mais comissões desta venda já foram faturadas!\n\n" +
                                            "Deseja faturar todas as comissões restantes ?");

                    if (op == System.Windows.Forms.DialogResult.No)
                        faturar = false;

                }

                if (faturar)
                    baixarComissoes(venda, TypeFaturamentoComissao.Integral);
            }
        }

        private void barBtnFaturarComissaoParcial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewComissoes.IsSelectOneRowWarning())
            {

                var venda = gridViewComissoes.GetFocusedRow<Venda>();
                var lanctos = venda.Comissoes.ToList();

                if (lanctos.Count == 1)
                {
                    XMessageIts.Mensagem("O faturamento parcial da comissão é permitido somente para vendas com mais de parcela.\n\n" +
                        "Utilize a opção :" + barBtnFaturarComissaoIntegral.Caption, "Aviso");
                }
                else if (lanctos.TrueForAll(l => l.StatusComissao == TypeStatusComissaoVenda.Faturado))
                {
                    XMessageIts.Advertencia("As comissões desta venda já foram faturadas!\n",
                                            "Atenção - Operação não permitida");
                }
                else
                {
                    baixarComissoes(venda, TypeFaturamentoComissao.Parcial);
                }
            }
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dtInicio.DateTime.Date;
            DateTime dt2 = dtFinal.DateTime.Date;
            var status = (TypeStatusComissaoVenda)cbSituacaoComissao.SelectedIndex;
            var user = searchLkpViewUser.GetFocusedRow<Usuario>();

            var comissoes = Task.Run(() =>
                new ComissaoVendaDaoManager().FiltrarComissaoVendas(dt1, dt2, user, status));

            btnFiltrar.Enabled = false;
            gridControl1.DataSource = await comissoes;

            btnFiltrar.Enabled = true;
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFiltro.SelectedIndex;
            int mes = 1;
            DateTime dt1 = dtInicio.DateTime;
            DateTime dt2 = dtFinal.DateTime;
            //Por Período 0
            //Próximo Mês 1
            //Mês Atual 2
            //Mês Anterior 3
            //Por Dia 4
            //Por Ano 5
            switch (index)
            {
                //Por período
                case 0:
                    break;

                //Mês Atual
                case 1:
                    mes = DateTime.Now.Month;
                    dt1 = DataUtil.GetDataInicialDoMes(mes);
                    dt2 = DataUtil.GetDataFinalDoMes(mes);

                    break;

                //Mês Anterior

                case 2:
                    mes = DateTime.Now.Month - 1;
                    dt1 = DataUtil.GetDataInicialDoMes(mes);
                    dt2 = DataUtil.GetDataFinalDoMes(mes);
                    break;


                //Por Dia
                case 3:
                    dt1 = DateTime.Now;
                    dt2 = DateTime.Now;
                    break;

                //Por Ano
                case 4:
                    //Todas as vendas em aberto do ano recorrente
                    dt1 = DataUtil.GetDataInicialDoMes(1);
                    dt2 = DataUtil.GetDataFinalDoMes(12);
                    break;

                default:
                    break;
            }
            this.dtInicio.DateTime = dt1;
            this.dtFinal.DateTime = dt2;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var row = gridViewComissoes.GetFocusedRow() as Venda;

            if (row != null)
            {
                var v = VendaDaoManager.FindVenda(row);
                new XFrmDetalhesVenda(v).ShowDialog();
            }
        }

        private void btnToggleSwitchUser_Toggled(object sender, EventArgs e)
        {
            searchLkpUser.ReadOnly = !btnToggleSwitchUser.IsOn;
        }

        private void barBtnExpandCollapse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.masterRowComissao.ExpandCollapseAllRows();
        }

        private void barBtnPrintReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void searchLkpUser_EditValueChanged(object sender, EventArgs e)
        {
            btnFiltrar_Click(null, null);
        }

        private void dtInicio_Leave(object sender, EventArgs e)
        {
            cbFiltro.SelectedIndex = 0;
        }


        #endregion
    }
}
