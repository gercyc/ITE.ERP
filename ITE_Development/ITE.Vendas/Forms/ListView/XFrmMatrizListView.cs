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
    public partial class XFrmMatrizListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmMatrizListView()
        {
            InitializeComponent();
        }

        private void btnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarMatriz(), "Carregando Empresas");
        }

        private async Task carregarMatriz()
        {
            //if (this.gridControlMatriz.InvokeRequired)
            var ctx = new BalcaoContext();

            var matrizList = await ctx.EmpresaMatrizDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlMatriz.DataSource = matrizList;
            }));
        }

        private void btnNovaMatriz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmMatrizView().ShowDialog();
        }

        private void XFrmGerenciarMatriz_Shown(object sender, EventArgs e)
        {
            btnAtualizar_ItemClick(null, null);
        }

        private void btnDetalhes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var matrizSelected = gridViewMatriz.GetFocusedRow() as EmpresaMatriz;
            if (matrizSelected != null)
            {
                new XFrmMatrizView(matrizSelected).ShowDialog();
                this.gridViewMatriz.RefreshData();
            }
        }

        private void gridViewMatriz_DoubleClick(object sender, EventArgs e)
        {
            btnDetalhes_ItemClick(null, null);
        }

        private void gridViewMatriz_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == colCnpj)
            {
                e.DisplayText = StringUtilIts.ToCpfCnpj(e.Value);
            }
        }
 
    }
}