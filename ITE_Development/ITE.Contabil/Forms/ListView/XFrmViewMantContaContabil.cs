using System;
using System.Collections;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using ITE.Contabil.Forms.View;
using ITE.Entidades.DaoManager.ContabilDaoManager;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO;
using ITSolution.Framework.Eventos.GridViewEvents;
using ITSolution.Framework.Mensagem;

namespace ITE.Contabil.Forms.ListView
{
    public partial class XFrmViewMantContaContabil : DevExpress.XtraEditors.XtraForm
    {
        private EmpresaMatriz matrizSelect;
        private readonly FocusRowChangedEvent _focusRowChangedEvent;

        public XFrmViewMantContaContabil()
        {
            InitializeComponent();
            this._focusRowChangedEvent = new FocusRowChangedEvent(gridView1);
        }

        #region Metodos
        private async Task fillGridContas(EmpresaMatriz matriz = null)
        {
            using (var ctx = new BalcaoContext())
            {
                var contas = await ctx.ContaContabilDao.FindAllAsync();

                //se escolheu alguma matriz...
                if (matriz != null)
                    contas = await ctx.ContaContabilDao.WhereAsync(c => c.Matriz.CodigoMatriz == matriz.CodigoMatriz);

                gridControl1.DataSource = contas.OrderBy(c=>c.CodigoContaContabil);

                if (contas != null)
                    _focusRowChangedEvent.KeepFocusedRowChanged();
            }
        }
        private async Task fillCbMatriz()
        {
            using (var ctx = new BalcaoContext())
            {
                var matriz = await ctx.EmpresaMatrizDao.FindAllAsync();
                if (cbMatrizFilter.Items.Count == 0)
                    cbMatrizFilter.Items.AddRange(matriz);
            }
        }

        #endregion

        #region Eventos
        private void XFrmViewContaContabil_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        //Ao selecionar alguma matriz..
        private void cbMatrizFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboEdit = sender as ComboBoxEdit;

            if (cbMatrizFilter.Items.Count > 0)
            {
                this.matrizSelect = comboEdit.EditValue as Entidades.POCO.EmpresaMatriz;
                XFrmWait.StartTask(fillGridContas(), "Carregando contas...");
            }
        }

        private void barBtnRemoveConta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var selectedConta = gridView1.GetFocusedRow<ContaContabil>();

                    //verifica o uso da conta
                    var usoCred = ctx.PartidaContabilDao.Where(p => p.IdContaContabilCred == selectedConta.IdContaContabil).Count();
                    var usoDeb = ctx.PartidaContabilDao.Where(p => p.IdContaContabilDeb == selectedConta.IdContaContabil).Count();

                    if (usoCred >= 1 || usoDeb >= 1)
                    {
                        XMessageIts.Advertencia("Conta contábil já utilizada em lançamentos contábeis, não é possível a exclusão!");
                        return;
                    }

                    var msg = "Certeza que deseja excluir a conta " + selectedConta.CodigoContaContabil + "?";

                    if (XMessageIts.Confirmacao(msg) == System.Windows.Forms.DialogResult.Yes)
                    {
                        var conta = ctx.ContaContabilDao.Find(selectedConta.IdContaContabil);
                        if (ctx.ContaContabilDao.Delete(conta))
                            XMessageIts.Mensagem("Conta excluída com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
        }
        #endregion

        #region Eventos dos botões do barManager
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(fillCbMatriz(), "Carregando matriz...");
            XFrmWait.StartTask(fillGridContas(), "Carregando contas...");

        }

        private void btnViewConta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var selectedConta = gridView1.GetFocusedRow<ContaContabil>();
                FormsUtil.ShowDialog(new XFrmAddContaContabil(selectedConta, FormTypeAction.Alterar));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void btnNovaConta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormsUtil.ShowDialog(new XFrmAddContaContabil());
        }

        #endregion

        private class NodeConta
        {
            public object[] Node { get; private set; }

            public NodeConta(dynamic o)
            {
                this.Node = new object[] { o.CodigoMatriz, o.CodigoContaContabil, o.DescricaoContaContabil, o.CodigoReduzido };
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            btnViewConta_ItemClick(null, null);
        }
    }
}
