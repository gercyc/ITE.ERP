using System;
using DevExpress.XtraBars;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Enumeradores;
using System.Linq;

namespace ITE.Fiscal.RegrasFiscais
{
    public partial class XFrmViewRegrasFiscais : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XFrmViewRegrasFiscais()
        {
            InitializeComponent();
        }

        private void btnNovo_ItemClick(object sender, ItemClickEventArgs e)
        {
            new XFrmAddRegraFiscal().ShowDialog();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.DataSource = new BalcaoContext().RegraFiscalDao.FindAll().OrderBy(r => r.CodigoRegraFiscal);
        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            var tipoSelect = gridView1.GetFocusedRow() as RegraFiscal;
            if (tipoSelect != null)
            {
                new XFrmAddRegraFiscal(tipoSelect, FormTypeAction.Visualizar).ShowDialog();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_ItemClick(null, null);
        }

        private void XFrmViewTiposMovimento_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }
    }
}