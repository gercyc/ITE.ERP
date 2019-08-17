using System;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Beans.ProgressBar;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.POCO.TI;
using ITE.Entidades.Enumeradores;
using ITE.Informatica.Forms.Cadastro;

namespace ITE.Informatica.Forms.View
{
    public partial class XFrmViewManutencao : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public XFrmViewManutencao()
        {
            InitializeComponent();
        }

        private async Task carregarInfo()
        {
            var result = await new BalcaoContext().
                ManutencaoDao.FindAllAsync();
            gridControl1.DataSource = result;
        }

        #region Eventos
        private void XFrmInfoManutencao_Shown(object sender, EventArgs e)
        {
            barBtnRefresh_ItemClick(null, null);
        }

        private void barBtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

        private void barBtnVisualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                var m = gridView1.GetFocusedRow() as Manutencao;

                new XFrmAddManutencao(m).ShowDialog();

                if (m.StatusManutencao != TypeStatusManutencao.Encerrado)
                    gridControl1.RefreshDataSource();
            }


        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarInfo());
        }

        private void barBtnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridView1.IsSelectOneRowWarning())
            {

                var op = XMessageIts.Confirmacao("Deseja apagar os dados da manutenação", "Atenção");
                if (op == DialogResult.OK)
                {
                    using (var ctx = new BalcaoContext())
                    {
                        var row = gridView1.GetFocusedRow<Manutencao>();
                        var r = ctx.ManutencaoDao.Find(row.IdManutencao);
                        //ctx.ManutencaoDao.Delete(r);
                        r.StatusManutencao = TypeStatusManutencao.Cancelado;
                        //atualiza no grid
                        row.Update(r);
                    }
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            barBtnEditar_ItemClick(null, null);
        }

        private void barBtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //fazer dps
        }

        private void barBtnNewManutencao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddManutencao().ShowDialog();
        }


        #endregion

        #region Master Row Itens Manutenção

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            var m = gridView1.GetRow(e.RowHandle) as Manutencao;
            e.IsEmpty = m.ItensManutencao.Count == 0;
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "ItensManutencao";
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            var o = gridView1.GetRow(e.RowHandle) as Manutencao;
            var bs = new BindingSource(o, "ItensManutencao");
            var ds = bs.DataSource as Manutencao;
            List<ItemManutencao> items = ds.ItensManutencao.ToList();
            var query = from i in items
                select new
                {
                    i.Produto.DescricaoProduto,
                    i.Produto.UnidadeMedida.NomeUnidadeMedida,
                    i.Produto.CategoriaProduto.NomeCategoriaProduto,
                    i.Quantidade,
                    i.ValorUnitario,
                    i.Desconto,
                    i.TotalItem,
                };
            bs.DataSource = query.ToList();
            e.ChildList = bs;
        }
        #endregion

    }
}
