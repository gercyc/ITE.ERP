using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Financeiro.Forms.Wizard;
using ITE.Reports.Relatorios;
using ITE.Vendas.Forms.ControleVenda;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Financeiro.Forms.ListView
{
    public partial class XFrmVendaListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly MasterRowItensVenda masterRowVenda;

        //Necessario ter acesso para chegar aqui
        public Usuario Usuario { get; set; }

        private XFrmVendaListView()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);
            this.masterRowVenda = new MasterRowItensVenda(gridView1);
        }

        public XFrmVendaListView(Usuario user) : this()
        {
            this.Usuario = user;
        }

        public async Task<List<Venda>> GetSales()
        {
            using (var ctx = new BalcaoContext())
            {
                var result = await ctx.Vendas
                    .Include(v => v.CliFor)
                    .Include(v => v.FormaPagamentoVenda)
                    .Include(v => v.ItensVendas)
                    .Include(v => v.Parcelas)
                    .Where(v => v.TipoMovimento == TypeVenda.Venda)
                    .OrderByDescending(v => v.DataVenda)
                    .ToListAsync();

                return result;
            }
        }

        private async Task carregarVendas()
        {
            gridView1.FindFilterText = "";

            var result = await GetSales();
            this.gridControlProposta.Invoke(new MethodInvoker(delegate
            {
                gridControlProposta.DataSource = result;

            }));

        }

        #region Eventos
        private void barBtnImprir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (gridView1.IsSelectOneRowWarning())
            {
                var v = gridView1.GetFocusedRow<Venda>();
                if (v != null)
                    new RptNotaVenda(v).Run();
            }
        }

        private void barBtnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                var venda = gridView1.GetFocusedRow<Venda>();

                if (new VendaDaoManager().isCancelarVenda(venda))
                {
                    searchControl1.EditValue = venda.IdVenda.ToString();
                    var wizardCancel = new XFrmWizardCancelamentoVenda(venda);
                    wizardCancel.ShowDialog();

                    if (wizardCancel.IsVendaCancel)
                        VendaDaoManager.FindVenda(venda);

                    gridView1.RefreshData();
                }
            }
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarVendas(), "Carregando Vendas e Cotações");

            //1 Opcao
            //Task.Factory.StartNew(CarregarProposta);
            //Task.Run(() => CarregarProposta());
            // new Thread(CarregarProposta).Start();

            //2 Opcao
            //var lista = await new BalcaoContext().VendaDao.WhereAsync(v => !v.StatusProposta.Equals(StatusProduto.Cancelado.ToString()));
            //gridControlVendas.DataSource = lista;


        }

        private void barBtnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {

                Venda cotacao = VendaDaoManager.FindVenda(gridView1.GetFocusedRow<Venda>());
                if (cotacao.TipoMovimento == TypeVenda.Cotacao)
                {
                    new XFrmVenda(cotacao, this.Usuario).ShowDialog();

                    if (cotacao.TipoMovimento == TypeVenda.Venda)
                        gridView1.DeleteSelectedRows();

                    gridView1.RefreshData();
                }
                else
                    XMessageIts.Advertencia("Proposta não permite alteração!", "Atenção");
            }
        }

        private void XFrmUtilVenda_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void gridViewProposta_DoubleClick(object sender, EventArgs e)
        {
            barBtnDetalhes_ItemClick(null, null);
        }

        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            string search = "" + searchControl1.EditValue;

            if (string.IsNullOrEmpty(search))
            {
                barBtnAtualizar_ItemClick(null, null);

            }
        }

        private async void searchControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pesquisa = "" + searchControl1.EditValue;
                var ID = ParseUtil.ToInt(pesquisa);
                if (!string.IsNullOrEmpty(pesquisa))
                {
                    //encapsular isso posteriormente
                    using (var ctx = new BalcaoContext())
                    {
                        ctx.LazyLoading(false);
                        List<Venda> lista;
                        if (ID > 0)
                        {

                            //carregando apenas o que for visivel
                            lista = await ctx.Vendas
                                            .Include(v => v.CliFor)
                                            .Include(v => v.FormaPagamentoVenda)
                                            .Include(v => v.Usuario)
                                            .Where(v => v.IdVenda == ID)
                                            .ToListAsync();
                        }
                        else
                        {


                            lista = await ctx.Vendas
                                            .Include(v => v.CliFor)
                                            .Include(v => v.FormaPagamentoVenda)
                                            .Include(v => v.Usuario)
                                            .Where(l => l.CliFor.RazaoSocial.Contains(pesquisa))
                                                .ToListAsync();
                        }

                        gridControlProposta.DataSource = lista;


                        this.gridView1.FindFilterText = pesquisa;
                    }
                }

            }
        }

        private void barBtnDetalhes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                Venda v = VendaDaoManager.FindVenda(gridView1.GetFocusedRow<Venda>());
                new XFrmDetalhesVenda(v).ShowDialog();
            }
        }

        private void barBtnDuplicar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                var duplicata = gridView1.GetFocusedRow<Venda>();

                var op = XMessageIts.Confirmacao("Deseja realmente duplicar a proposta \"" + duplicata.IdVenda + "\" ?");

                if (op == DialogResult.Yes)
                {
                    new VendaDaoManager().DuplicarProposta(duplicata);
                    barBtnAtualizar_ItemClick(null, null);
                }
            }


        }

        private void barBtnBaixarVenda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {


                var row = gridView1.GetFocusedRow<Venda>();

                //recupera a venda 
                var current = ctx.VendaDao.Find(row.IdVenda);

                var parcelas = row.Parcelas.Where(p =>
                            p.StatusLancamento != TypeStatusLancamentoFinanceiro.Cancelado &&
                            p.StatusLancamento != TypeStatusLancamentoFinanceiro.Pago).ToList();

                //termina o contexto
                ctx.VendaDao.Dispose();

                if (row.TipoMovimento != TypeVenda.Venda)
                {
                    XMessageIts.Advertencia("Uma cotação não pode ser baixada !");

                }
                else
                {
                    if (row.StatusVenda == TypeStatusVenda.Paga)
                    {
                        XMessageIts.Mensagem("A venda selecionada está paga!", "Atenção");
                    }
                    else if (row.StatusVenda == TypeStatusVenda.Cancelada)
                    {
                        XMessageIts.Mensagem("A venda selecionada foi cancelada e não foi pode ser baixada!", "Aviso");
                    }
                    else if (parcelas.Count > 0)
                    {
                        XFrmWizardBaixaLancamento wizard = new XFrmWizardBaixaLancamento(parcelas);

                        wizard.ShowDialog();

                        if (wizard.IsBaixa)
                        {
                            //recupera a venda de outros contexto pq ela foi atualizada
                            //de outro contexto
                            //por isso preciso da nova referencia
                            current = new BalcaoContext().VendaDao.Find(row.IdVenda);

                            //atualiza no grid
                            row.Update(current);

                            //notifica o grid da atualização
                            gridView1.RefreshData();
                        }
                    }
                    else
                    {
                        XMessageIts.Mensagem("A venda não possui parcela(s) a ser(em) baixada(s)!");
                    }
                }

            }
        }


        private void gridViewVendas_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //if (e.Action == CollectionChangeAction.Refresh)
            //gridView1.UnselectRow(gridView1.FocusedRowHandle);

            if (e.Action == CollectionChangeAction.Add)
            {

            }
        }

        #endregion

        private void barBtnExportXlsx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ExportXlsxDirect();
        }

        private void barBtnExpandirMasterRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.masterRowVenda.ExpandCollapseAllRows();
        }
    }
}