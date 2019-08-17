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
    public partial class XFrmViewContaContabil : DevExpress.XtraEditors.XtraForm
    {
        private bool collapsed;
        private EmpresaMatriz matrizSelect;
        private readonly TreelistFocusRowChangedEvent _treeListFocusUtil;

        public XFrmViewContaContabil()
        {
            InitializeComponent();
            colIdConta.Visible = false;
            this._treeListFocusUtil = new TreelistFocusRowChangedEvent(treeListContas);
        }

        #region Metodos

        private async Task fillCbMatriz()
        {
            using (var ctx = new BalcaoContext())
            {
                var matriz = await ctx.EmpresaMatrizDao.FindAllAsync();
                if (cbMatrizFilter.Items.Count == 0)
                    cbMatrizFilter.Items.AddRange(matriz);

            }
        }

        //feito no design
        private void CreateColumns(TreeList treeList)
        {
            // Create two columns.
            treeList.BeginUpdate();

            TreeListColumn colMatriz = treeList.Columns.Add();
            colMatriz.Caption = "Matriz";
            colMatriz.VisibleIndex = 0;
            colMatriz.Width = 125;

            TreeListColumn col0 = treeList.Columns.Add();
            col0.Caption = "Código";
            col0.VisibleIndex = 0;
            col0.Width = 250;

            TreeListColumn col1 = treeList.Columns.Add();
            col1.Caption = "Descrição";
            col1.VisibleIndex = 1;
            col1.Width = 500;

            TreeListColumn col2 = treeList.Columns.Add();
            col2.Caption = "Reduzido";
            col2.VisibleIndex = 2;
            col1.Width = 150;

            TreeListColumn col3 = treeList.Columns.Add();
            col3.Caption = "ID";
            col3.VisibleIndex = 2;
            col3.Visible = false;


            treeList.EndUpdate();
        }

        private async Task fillTreeList()
        {
            //this._treeListFocusUtil.KeepFocusedRowChanged();
            treeListContas.ClearNodes();
            ///treeListContas.Columns.Clear();
            //  CreateColumns(treeListContas);

            treeListContas.BeginUnboundLoad();
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);
                List<ContaContabil> listContas;

                //se encontrou a matriz enviada por parametro...
                if (this.matrizSelect != null)
                {
                    //busca todas as contas da matriz escolhida
                    listContas = await ctx.ContasContabil.Where(m => m.Matriz.CodigoMatriz == matrizSelect.CodigoMatriz).Include(c => c.Matriz).ToListAsync();
                }
                else
                {
                    //busca todas as contas
                    listContas = await ctx.ContasContabil.Include(c => c.Matriz).ToListAsync();
                }

                if (listContas.Count > 0)
                {
                    var l = from cct in listContas
                            orderby cct.CodigoContaContabil
                            select new { cct.Matriz.CodigoMatriz, cct.CodigoContaContabil, cct.DescricaoContaContabil, cct.CodigoReduzido, cct.IdContaContabil };

                    TreeListNode level_0 = null;
                    TreeListNode level_1 = null;
                    TreeListNode level_2 = null;
                    TreeListNode level_3 = null;
                    TreeListNode level_4 = null;
                    dynamic v_LastConta = null;

                    foreach (var conta in l)
                    {
                        //substitui os paramentros por uma classe interna informando os parametros 
                        //que vc ja estava usando
                        var node = new NodeConta(conta).Node;
                        //se tiver 1 caractere: nodePrincipal.
                        if (conta.CodigoContaContabil.Length.Equals(1))
                        {
                            level_0 = treeListContas.AppendNode(node, null);
                        }
                        else if (conta.CodigoContaContabil.Length.Equals(3) && conta.CodigoContaContabil.Substring(0, 1) == v_LastConta.CodigoContaContabil.Substring(0, 1))
                        {
                            level_1 = treeListContas.AppendNode(node, level_0);
                        }
                        else if (conta.CodigoContaContabil.Length.Equals(5))
                        {
                            level_2 = treeListContas.AppendNode(node, level_1);
                        }
                        else if (conta.CodigoContaContabil.Length.Equals(8))
                        {
                            level_3 = treeListContas.AppendNode(node, level_2);
                        }
                        else
                        {
                            level_4 = treeListContas.AppendNode(node, level_3);
                        }

                        //guardar a conta anterior
                        v_LastConta = conta;
                    }

                    treeListContas.ExpandAll();
                    if (treeListContas.Nodes.Count > 0)
                        this._treeListFocusUtil.KeepFocusedRowChanged();

                    treeListContas.EndUnboundLoad();
                }
            }
        }

        #endregion

        #region Eventos
        private void XFrmViewContaContabil_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void treeListContas_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            //if (e.Node != null)
            //    if (e.Node.Id != 0)
            //        lastNode = e.Node;
        }

        //Ao selecionar alguma matriz..
        private void cbMatrizFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboEdit = sender as ComboBoxEdit;

            if (cbMatrizFilter.Items.Count > 0)
            {
                this.matrizSelect = comboEdit.EditValue as Entidades.POCO.EmpresaMatriz;
                XFrmWait.StartTask(fillTreeList(), "Carregando contas...");
            }
        }

        private void barExpandCollapse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (collapsed)
            {
                collapsed = false;
                treeListContas.ExpandAll();
            }
            else
            {
                collapsed = true;
                treeListContas.CollapseAll();
            }
        }

        private void treeListContas_DoubleClick(object sender, EventArgs e)
        {
            btnViewConta_ItemClick(null, null);
        }

        private void barBtnRemoveConta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var selectedConta = treeListContas.FocusedNode;
                    var v = treeListContas.GetDataRecordByNode(selectedConta) as ArrayList;
                    var cct = new ContaContabilDaoManager().GetContaByCodigo(v[1].ToString());

                    //verifica o uso da conta
                    var usoCred = ctx.PartidaContabilDao.Where(p => p.IdContaContabilCred == cct.IdContaContabil).Count();
                    var usoDeb = ctx.PartidaContabilDao.Where(p => p.IdContaContabilDeb == cct.IdContaContabil).Count();

                    if (usoCred >= 1 || usoDeb >= 1)
                    {
                        XMessageIts.Advertencia("Conta contábil já utilizada em lançamentos contábeis, não é possível a exclusão!");
                        return;
                    }

                    var msg = "Certeza que deseja excluir a conta " + cct.CodigoContaContabil + "?";

                    if (XMessageIts.Confirmacao(msg) == System.Windows.Forms.DialogResult.Yes)
                    {
                        var conta = ctx.ContaContabilDao.Find(cct.IdContaContabil);
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
            XFrmWait.StartTask(fillTreeList(), "Carregando contas...");

            //if (lastNode != null)
            //{
            //    treeListContas.SelectNode(lastNode);
            //}

        }

        private void btnViewConta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var selectedConta = treeListContas.FocusedNode;
                var v = treeListContas.GetDataRecordByNode(selectedConta) as ArrayList;
                var cct = new ContaContabilDaoManager().GetContaByCodigo(v[1].ToString());
                FormsUtil.ShowDialog(new XFrmAddContaContabil(cct, FormTypeAction.Alterar));
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


    }
}
