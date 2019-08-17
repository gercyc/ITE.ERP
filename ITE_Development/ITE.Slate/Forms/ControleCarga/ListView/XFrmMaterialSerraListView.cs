using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Ardosia.ProductionSlate;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

/**
 * Copyright (produto) 2013, ITSolution Business Intelligence. Todos os direitos reservados. ITE
 * SOFTWARE/CONFIDENCIAL. O Uso está sujeito aos termos.
 * 
 * 
 * GridControl EnableAppearenceEvenRow e OddRow
 * 
 */
namespace ITE.Slate.Forms.ControleCarga.ListView
{
    public partial class XFrmMaterialSerraListView : DevExpress.XtraEditors.XtraForm
    {
        private Usuario _user;

        public XFrmMaterialSerraListView(Usuario user)
        {
            this._user = user;
            InitializeComponent();

            if (!user.IsAdmin)
                gridViewMaterialSerras.Columns.Remove(colPrecoVenda);

        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarMaterialSerras(), "Carregando Materiais");
        }

        private async Task carregarMaterialSerras()
        {
            try
            {
                //cortou pra mais da metade os selects
                using (var ctx = new SlateContext())
                {
                    var produtos = await ctx.MaterialSerraDao.FindAllAsync();

                    this.gridControlMaterialSerras.DataSource = produtos;
                    this.gridViewMaterialSerras.FindFilterText = "";
                    this.gridViewMaterialSerras.Focus();

                }
            }
            catch (Exception ex)
            {
                LoggerUtilIts.ShowExceptionMessage(ex);
            }

        }


        private void barBtnEditarMaterialSerra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewMaterialSerras.IsSelectOneRowWarning() && this._user.IsAdmin)
            {
                var p = gridViewMaterialSerras.GetFocusedRow<MaterialSerra>();

                new ITE.Slate.Forms.ControleCarga.View.XFrmAddMaterialSerra(p).ShowDialog();
                //atualize os dados do grid
                gridViewMaterialSerras.RefreshData();
            }
            else
                XMessageIts.Advertencia("Você não tem permissão para realizar esta ação!", "Acesso negado!");
        }

        private void gridViewMaterialSerras_DoubleClick(object sender, EventArgs e)
        {
            barBtnEditarMaterialSerra_ItemClick(null, null);
        }

        private void XFrmGerenciarMaterialSerraNovo_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void btnAddMaterialSerra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //congela a instancia anterior
            new ITE.Slate.Forms.ControleCarga.View.XFrmAddMaterialSerra(_user).ShowDialog();
            gridViewMaterialSerras.RefreshData();
        }


        private async void searchControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = "" + searchControl1.EditValue;
                if (!string.IsNullOrEmpty(search))
                {
                    using (var ctx = new SlateContext(false))
                    {
                        //carregando apenas o cliente do lancamento
                        var lista = await ctx.MaterialSerraDao
                                              .Where(p => p.NomeMaterial.Contains(search))
                                              .ToListAsync();

                        this.gridViewMaterialSerras.FindFilterText = search;
                        gridControlMaterialSerras.DataSource = lista;
                    }

                }
            }
        }

        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            string search = "" + searchControl1.EditValue;

            if (string.IsNullOrEmpty(search))
            {
                barBtnAtualizar_ItemClick(null, null);
            }
        }

    }
}