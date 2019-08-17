using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITE.Vendas.Forms.ControleVenda;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;

namespace ITE.Forms.OldVersion
{
    public partial class XFrmCancelarVenda : DevExpress.XtraEditors.XtraForm
    {         
        private Usuario user;

        public XFrmCancelarVenda(Usuario user)
        {
            InitializeComponent();
            this.user = user;            
 
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        private async Task carregarVendas()
        {
            //apenas vendas
            var lista = await new BalcaoContext().VendaDao.WhereAsync(v =>
            v.TipoMovimento == TypeVenda.Venda);

            var result = lista.Where(v => v.StatusVenda != TypeStatusVenda.Cancelada);

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlProposta.DataSource = result.OrderByDescending(v => v.IdVenda);
            }));
        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = new UnitWork().GetAcessOrLogin(user);
            if (result != null)
            {
                //var venda = this.util.Find(barTxtId.EditValue);
                //if (venda != null)
                    //this.util.CancelarVenda(venda);

            }
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarVendas(), "Carregando Vendas");

            //1 Opcao
            //Task.Factory.StartNew(CarregarProposta);
            //Task.Run(() => CarregarProposta());
            // new Thread(CarregarProposta).Start();

            //2 Opcao
            //var lista = await new BalcaoContext().VendaDao.WhereAsync(v => !v.StatusProposta.Equals(StatusProduto.Cancelado.ToString()));
            //gridControlVendas.DataSource = lista;

            gridViewProposta.FocusedColumn = colIdVenda;
            gridViewVendas_Click(null, null);
        }

        private void gridViewVendas_Click(object sender, EventArgs e)
        {
           
        }

        private void gridViewVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                barBtnCancelar_ItemClick(null, null);
        }

        private void gridViewVendas_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gridViewVendas_Click(null, null);
        }

        private void XFrmCancelarProposta_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void gridViewProposta_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            barTxtId.EditValue = gridViewProposta.GetRowCellValue(e.FocusedRowHandle, colIdVenda);
        }

        private void gridViewProposta_DoubleClick(object sender, EventArgs e)
        {
            var x = gridViewProposta.GetFocusedRow() as Venda;

            if (x != null)
            {
                new XFrmDetalhesVenda(x).ShowDialog();
            }
        }
    }
}