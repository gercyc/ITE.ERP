using System;
using System.Windows.Forms;
using ITE.Contabil.Forms.View;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using System.Threading.Tasks;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using System.Collections;
using ITE.Entidades.DaoManager.ContabilDaoManager;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Util;

namespace ITE.Contabil.Forms.ListView
{
    public partial class XFrmViewCentroCustoTree : DevExpress.XtraEditors.XtraForm
    {
        private bool collapsed;

        public XFrmViewCentroCustoTree()
        {
            InitializeComponent();
        }

        private void XFrmViewCentroCustoTree_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }
        private void barBtnEditarCc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var node = treeListCentros.FocusedNode;
                var v = treeListCentros.GetDataRecordByNode(node) as ArrayList;
                var cct = new CentroCustoDaoManager().GetCentroByCodigo(v[0].ToString());
                var frm = new XFrmAddCentroCusto(cct);

                frm.ShowDialog();

                cct = frm.CentroCusto;
                node.SetValue(treeListColumn1, cct.CodigoCentroCusto);
                node.SetValue(treeListColumn2, cct.NomeCentroCusto);
                 treeListCentros.RefreshNode(node);
            }
            catch (Exception ex)
            {
                XMessageIts.Mensagem("Centro de custo não pode ser editado");

                LoggerUtilIts.GenerateLogs(ex);
            }
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(fillTreeList());
        }

        private void barBtnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddCentroCusto().ShowDialog();
            barBtnAtualizar_ItemClick(null, null);

        }

        private async Task fillTreeList()
        {
            treeListCentros.ClearNodes();
            treeListCentros.BeginUnboundLoad();

            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var listCentros = await ctx.CentroCustoDao.FindAllAsync();
                var l = from cc in listCentros
                        orderby cc.CodigoCentroCusto
                        select new { cc.CodigoCentroCusto, cc.NomeCentroCusto, cc.ParentId };

                TreeListNode level_0 = null;
                TreeListNode level_1 = null;
                //dynamic v_LastCentro = null;


                foreach (var centro in l)
                {
                    //substitui os paramentros por uma classe interna informando os parametros 
                    //que vc ja estava usando
                    var node = new NodCentro(centro).Node;
                    //se tiver 1 caractere: nodePrincipal.
                    if (centro.ParentId == null)
                    {
                        level_0 = treeListCentros.AppendNode(node, null);
                    }

                    else
                    {
                        level_1 = treeListCentros.AppendNode(node, level_0);
                    }

                }
                treeListCentros.ExpandAll();
                treeListCentros.EndUnboundLoad();
            }
        }

        private void barBtnExpCollapse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (collapsed)
            {
                collapsed = false;
                treeListCentros.ExpandAll();
            }
            else
            {
                collapsed = true;
                treeListCentros.CollapseAll();
            }
            
        }


        private class NodCentro
        {
            public object[] Node { get; private set; }

            public NodCentro(dynamic o)
            {
                this.Node = new object[] { o.CodigoCentroCusto, o.NomeCentroCusto };
            }
        }

        /*

        private void CreateColumns(TreeList treeList)
        {
            // Create two columns.
            treeList.BeginUpdate();

            TreeListColumn col0 = treeList.Columns.Add();
            col0.Caption = "Código";
            col0.VisibleIndex = 0;
            col0.Width = 250;

            TreeListColumn col1 = treeList.Columns.Add();
            col1.Caption = "Descrição";
            col1.VisibleIndex = 1;
            col1.Width = 500;

            treeList.EndUpdate();
        }*/


    }
}
 