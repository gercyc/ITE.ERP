using System;
using System.Windows.Forms;
using ITE.Contabil.Forms.View;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;

namespace ITE.Contabil.Forms.ListView
{
    public partial class XFrmViewCentroCusto : DevExpress.XtraEditors.XtraForm
    {
        public XFrmViewCentroCusto()
        {
            InitializeComponent();
        }

        private void XFrmInfoCentroCusto_Load(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);

        }
        private void updateGridView()
        {
            using (var ctx = new BalcaoContext())
            {
                gridControlCentroCusto.DataSource = ctx.CentroCustoDao.FindAll();
            }
        }

        private void btnVisualizarCentroCusto_Click(object sender, EventArgs e)
        {
            CentroCusto cc = gridViewCentroCusto.GetFocusedRow() as CentroCusto;

            if (GridViewUtil.IsSelectOneRowWarning(gridViewCentroCusto))
            {
                new XFrmAddCentroCusto(cc).ShowDialog();
            }
            else
            {
                XMessageIts.Mensagem("Selecione a linha a ser visualizada.");
            }
        }

        private void btnNovoCentroCusto_Click(object sender, EventArgs e)
        {
            new XFrmAddCentroCusto().ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void barBtnEditarCc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewCentroCusto.IsSelectOneRowWarning())
            {
                CentroCusto cc = gridViewCentroCusto.GetFocusedRow<CentroCusto>();
                new XFrmAddCentroCusto(cc).ShowDialog();
                gridViewCentroCusto.RefreshData();
            }
        }

        private void barBtnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewCentroCusto.IsSelectOneRowWarning())
            {
                CentroCusto cc = gridViewCentroCusto.GetFocusedRow() as CentroCusto;

                var op = XMessageIts.Confirmacao("Deseja realmente excluir o Centro de custo \""
                    + cc.NomeCentroCusto + "\" ?");

                if (op == DialogResult.Yes)
                {
                    using (var ctx = new BalcaoContext())
                    {

                        //if (new CentroCustoDaoManager().CheckUsoCentroCusto(cc))
                            //cc = ctx.CentroCustoDao.Find(cc.IdCentroCusto);

                        if (ctx.CentroCustoDao.Delete(cc))
                        {
                            XMessageIts.Mensagem("Centro custo \"" + cc.NomeCentroCusto + " \" removido com sucesso");
                        }
                        else
                        {
                            XMessageIts.Advertencia("Você não pode excluir centro de custo \""
                                + cc.NomeCentroCusto + "\" que possui contas ativas.",
                                "Operação não permitida !");
                        }
                    }
                }
            }
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            updateGridView();
        }

        private void barBtnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddCentroCusto().ShowDialog();
            barBtnAtualizar_ItemClick(null, null);

        }

        private void gridViewCentroCusto_DoubleClick(object sender, EventArgs e)
        {
            barBtnEditarCc_ItemClick(null, null);
        }
    }
}