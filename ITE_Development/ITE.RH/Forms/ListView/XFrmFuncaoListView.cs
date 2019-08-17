using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO.RH;
using ITE.Entidades.Repositorio;
using ITE.RH.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;

namespace ITE.RH.Forms.ListView
{
    public partial class XFrmFuncaoListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmFuncaoListView()
        {
            InitializeComponent();
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarFuncoes(), "Carregando funções...");
        }
        private async Task carregarFuncoes()
        {
            //if (this.gridControlFuncao.InvokeRequired)
            //{
            var ctx = new BalcaoContext();

            var filialList = await ctx.FuncaoDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlFuncao.DataSource = filialList;
            }));

        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var funcaoSelect = gridViewFuncao.GetFocusedRow<Funcao>();
            if (funcaoSelect != null)
            {
                new XFrmAddFuncao(funcaoSelect).ShowDialog();
            }
        }

        private void btnNovaFuncao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddFuncao().ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctx = new BalcaoContext();
            var funcaoSelect = GridViewUtil.GetFocusedRow<Funcao>(gridViewFuncao);
            if (funcaoSelect != null)
            {
                var dResult = XMessageIts.Confirmacao(@"Certeza que deseja excluir a função 
                    selecionada? Ela será excluída somente se não houver nenhum 
                    funcionário vinculado a ela.");
                if (dResult == DialogResult.Yes)
                {
                    var funcaoRemove = ctx.FuncaoDao.Find(funcaoSelect.IdFuncao);
                    if (ctx.FuncaoDao.Delete(funcaoRemove))
                    {
                        XMessageIts.Mensagem("Função removida com sucesso!", "Sucesso");
                        btnRefresh_ItemClick(null, null);
                    }
                    else
                    {
                        XMessageIts.Erro("Função não removida! Está vinculado a funcionários!", "Erro");
                    }
                }
            }
        }

        private void XFrmGerenciarFuncao_Shown(object sender, System.EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void gridViewFuncao_DoubleClick(object sender, System.EventArgs e)
        {
            btnEditar_ItemClick(null, null);
        }
    }
}