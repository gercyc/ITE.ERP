using System;
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
    public partial class XFrmDepartamentoListView : DevExpress.XtraEditors.XtraForm
    {
        public XFrmDepartamentoListView()
        {
            InitializeComponent();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarDeptos(), "Carregando departamentos...");
        }

        private async Task carregarDeptos()
        {
            var ctx = new BalcaoContext();

            var deptos = await ctx.DepartamentoDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlDeptos.DataSource = deptos;
            }));
            Console.WriteLine("Task Completed");
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var deptoSelect = GridViewUtil.GetFocusedRow<Departamento>(gridViewDeptos);
            if (deptoSelect != null)
            {
                new XFrmAddDepartamento(deptoSelect).ShowDialog();
            }
        }

        private void btnNovoDepto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddDepartamento().ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctx = new BalcaoContext();
            var deptoSelect = GridViewUtil.GetFocusedRow<Departamento>(gridViewDeptos);
            if (deptoSelect != null)
            {
                var dResult = XMessageIts.Confirmacao(@"Certeza que deseja excluir o departamento 
                    selecionado? Ele será excluído somente se não houver nenhum 
                    funcionário vinculado a ele.");
                if (dResult == DialogResult.Yes)
                {
                    var deptoRemove = ctx.DepartamentoDao.Find(deptoSelect.IdDepartamento);
                    if (ctx.DepartamentoDao.Delete(deptoRemove))
                    {
                        XMessageIts.Mensagem("Departamento removido com sucesso!", "Sucesso");
                        btnRefresh_ItemClick(null, null);
                    }
                    else
                    {
                        XMessageIts.Erro("Departamento não removido! Está vinculado a funcionários!", "Erro");
                    }
                }
            }
        }

        private void XFrmGerenciarDepartamento_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void gridViewDeptos_DoubleClick(object sender, EventArgs e)
        {
            btnEditar_ItemClick(null, null);
        }
    }
}