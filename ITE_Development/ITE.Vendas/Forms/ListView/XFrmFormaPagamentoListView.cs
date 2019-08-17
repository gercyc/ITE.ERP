using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;

namespace ITE.Vendas.Forms.ListView
{
    public partial class XFrmFormaPagamentoListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Usuario User { get; set; }

        public XFrmFormaPagamentoListView()
        {
            InitializeComponent();
        }

        public XFrmFormaPagamentoListView(Usuario user) : this()
        {
            // Construtor padrão, recebe o usuário logado no sistema
            this.User = user;
        }


        private void XFrmGerenciarFormasPagto_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void barBtnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var xFrmPagto = new XFrmFormaPagamentoView();
            
            xFrmPagto.ShowDialog();

            if (xFrmPagto.IsSave)
            {
                barBtnAtualizar_ItemClick(null, null);
                gridViewFormasPagto.FocusLastRow();
            }
        
        }

        private void barBtnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (gridViewFormasPagto.IsSelectOneRowWarning())
            {
                var frmPagto = gridViewFormasPagto.GetFocusedRow() as FormaPagamento;
                new XFrmFormaPagamentoView(frmPagto).ShowDialog();
                gridViewFormasPagto.FocusCurrentRow();
            }

        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarFormasPagto());
        }

        private async Task carregarFormasPagto()
        {
            var result = await new BalcaoContext().FormaPagamentoDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlFormasPagto.DataSource = result;

            }));
        }
        private void gridViewFormasPagto_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewFormasPagto.IsSelectOneRowWarning())
            {
                var formaPagtoSelected = gridViewFormasPagto.GetFocusedRow() as FormaPagamento;
                new XFrmFormaPagamentoView(formaPagtoSelected).ShowDialog();
            }
        }

        private void barBtnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewFormasPagto.IsSelectOneRowWarning())
            {
                var ctx = new BalcaoContext();
                var frmCurrent = gridViewFormasPagto.GetFocusedRow<FormaPagamento>();

                var op = XMessageIts.Confirmacao("Deseje remover a forma de pagamento " + frmCurrent.NomeFormaPagamento);

                if (op == DialogResult.Yes)
                {
                    if (ctx.FormaPagamentoDao.Delete(frmCurrent))
                        XMessageIts.Mensagem("Forma de pagamento " + frmCurrent.NomeFormaPagamento + " removida com sucesso.");
                }
            }

        }
    }
}