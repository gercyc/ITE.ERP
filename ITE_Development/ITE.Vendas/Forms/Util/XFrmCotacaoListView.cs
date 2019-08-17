using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITE.Reports.Relatorios;
using ITE.Vendas.Forms.ControleVenda;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Vendas.Forms.Util
{
    public partial class XFrmCotacaoListView : DevExpress.XtraEditors.XtraForm
    {
        private readonly Usuario _user;

        public XFrmCotacaoListView(Usuario user)
        {
            InitializeComponent();
            this._user = user;
        }

        private void XFrmAlterarCotacao_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private async Task carregarCotacoes()
        {
            using (var ctx = new BalcaoContext())
            {
                //if (gridControlProposta.InvokeRequired)
                var lista = await ctx.VendaDao.WhereAsync(v => v.TipoMovimento == TypeVenda.Cotacao);

                this.Invoke(new MethodInvoker(delegate
                {
                    gridControlProposta.DataSource = lista;
                    if (lista.Count == 0)
                        barEditNumVenda.EditValue = "";
                }));
            }
        }

        private void barBtnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewProposta.IsSelectOneRowWarning())
            {
                var cotacao = gridViewProposta.GetFocusedRow<Venda>();

                var login = new UnitWork();
                login.XFrmLogin.Text = "Alterar cotação";
                var u = login.GetAcessOrLogin(_user);

                if (u != null)
                {
                    var current = VendaDaoManager.FindVenda(cotacao);

                    new XFrmVenda(cotacao, u).ShowDialog();

                    //atualiza a linha do grid com os dado no banco
                    current = VendaDaoManager.FindVenda(cotacao);

                    cotacao.Update(current);

                    //se ela virou venda tira ela do grid
                    if (current.TipoMovimento == TypeVenda.Venda)
                        gridViewProposta.DeleteRow();

                    gridViewProposta.RefreshData();
                }
            }
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarCotacoes(), "Carregando Cotações");

            //1 Opcao
            //Task.Factory.StartNew(CarregarProposta);
            //Task.Run(() => CarregarProposta());
            // new Thread(CarregarProposta).Start();

            //2 Opcao
            //var lista = await new BalcaoContext().CotacaoDao.WhereAsync(v => !v.StatusProposta.Equals(StatusProduto.Cancelado.ToString()));
            //gridControlVendas.DataSource = lista;

            gridViewProposta.FocusedColumn = colIdCotacao;
            gridViewProposta_Click(null, null);


        }

        private void gridViewVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                barBtnAlterar_ItemClick(null, null);
        }

        private void gridViewProposta_Click(object sender, EventArgs e)
        {
            var x = gridViewProposta.GetFocusedRow() as Venda;

            if (x != null)
            {
                barEditNumVenda.EditValue = x.IdVenda.ToString();
            }
        }

        private void gridViewProposta_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridViewProposta_Click(null, null);
        }

        private void gridViewProposta_DoubleClick(object sender, EventArgs e)
        {
            barBtnAlterar_ItemClick(null, null);
        }

        private void barBtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var value = barEditNumVenda.EditValue;

            if (!string.IsNullOrWhiteSpace(value.ToString()) && !value.ToString().IsContainsLetters())
            {
                int num = ParseUtil.ToInt(value);
                if (num == -1)
                    XMessageIts.Advertencia("Para imprimir utilize o número da cotação!");
                else
                {
                    Venda v = Find(value);
                    if (v != null)
                        new RptNotaVenda(v).Run();
                }
            }
        }

        /// <summary>
        /// Obtém a proposta a partir do grid ou pelo número da proposta.
        /// </summary>
        /// <returns></returns>
        public Venda Find(object value)
        {
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()) && !value.ToString().IsContainsLetters())
            {
                var ID = ParseUtil.ToInt(value);
                using (var ctx = new BalcaoContext())
                {
                    var v = ctx.VendaDao.Find(ID);

                    if (v == null)
                    {
                        XMessageIts.Advertencia("Cotação não encontrada !", "Aviso");
                    }
                    else
                        return v;
                }
            }
            else
            {
                XMessageIts.Advertencia("Número da cotação é inválido!");
            }

            return null;
        }


    }
}