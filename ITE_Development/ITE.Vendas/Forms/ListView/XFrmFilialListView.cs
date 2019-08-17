using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Util;

namespace ITE.Vendas.Forms.ListView
{
    public partial class XFrmFilialListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmFilialListView()
        {
            InitializeComponent();
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarFilial(), "Carregando Filiais");
        }

        private async Task carregarFilial()
        {
            //if (this.gridControlFiliais.InvokeRequired)
            var ctx = new BalcaoContext();

            var filialList = await ctx.EmpresaFilialDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlFiliais.DataSource = filialList;
            }));
        }

        private void btnNovaFilial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmFilialView().ShowDialog();
        }

        private void XGrmGerenciarFilial_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void btnDetalhes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var filialSelected = gridViewFiliais.GetFocusedRow() as EmpresaFilial;
            if (filialSelected != null)
            {
                new XFrmFilialView(filialSelected).ShowDialog();
                this.gridViewFiliais.RefreshData();
            }
        }

        private void gridViewFiliais_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == colCnpj)
            {
                e.DisplayText = StringUtilIts.ToCpfCnpj(e.Value);
            }
        }
    }
}