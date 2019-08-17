using System;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using ITE.Entidades.POCO.RH;
using ITE.Entidades.Repositorio;
using ITE.RH.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;

/// <summary>
/// Classe esqueleto de CRUD
/// Os botoes foram ocultados
/// ToolBarLocation
/// ShowApplicationButton
/// </summary>
namespace ITE.RH.Forms.ListView
{
    public partial class XFrmFuncionarioListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XFrmFuncionarioListView()
        {
            InitializeComponent();

        }
        private async Task carregarFuncionarios()
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var lista = await ctx.FuncionarioDao.FindAllAsync();
                    gridControlFuncionario.DataSource = lista;
                }
            }
            catch (Exception)
            {
                
            }
        }

        #region Eventos

        private void barBtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarFuncionarios(), "Carregando Funcionários...");
        }

        private void barBtnNovo_ItemClick(object sender, ItemClickEventArgs e)
        {
            new XFrmAddFuncionario().ShowDialog();
        }

        private void barBtnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GridViewUtil.IsSelectOneRowWarning(gridViewFuncionario))
            {
                var func = gridViewFuncionario.GetFocusedRow() as Funcionario;

                new XFrmAddFuncionario(func).ShowDialog();
            }
        }

        private void barBtnAlterarSituacao_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GridViewUtil.IsSelectOneRowWarning(gridViewFuncionario))
            {
                var func = gridViewFuncionario.GetFocusedRow() as Funcionario;

                new XFrmHistoricoSituacao(func).ShowDialog();
            }
        }

        private void barBtnAlterarSalario_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GridViewUtil.IsSelectOneRowWarning(gridViewFuncionario))
            {
                var func = gridViewFuncionario.GetFocusedRow() as Funcionario;

                new XFrmHistoricoSalario(func).ShowDialog();
            }
        }

        private void batBtnAlterarDepto_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GridViewUtil.IsSelectOneRowWarning(gridViewFuncionario))
            {
                var func = gridViewFuncionario.GetFocusedRow() as Funcionario;

                new XFrmHistoricoDepartamento(func).ShowDialog();
            }
        }

        private void batBtnAlterarFuncao_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (GridViewUtil.IsSelectOneRowWarning(gridViewFuncionario))
            {
                var func = gridViewFuncionario.GetFocusedRow() as Funcionario;

                new XFrmHistoricoFuncao(func).ShowDialog();
            }
        }

        private void XFrmGerenciarFuncionario_Shown(object sender, EventArgs e)
        {
            barBtnRefresh_ItemClick(null, null);
        }

        private void gridViewFuncionario_DoubleClick(object sender, EventArgs e)
        {
            barBtnEditar_ItemClick(null, null);
        }
        #endregion Eventos

    }
}