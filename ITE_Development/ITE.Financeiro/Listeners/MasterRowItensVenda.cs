using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using ITSolution.Framework.Listeners.GridViewEvents;
using System.Collections;
using ITE.Entidades.POCO.Sales;

namespace ITE.Financeiro.Listeners
{
    public class MasterRowItensVenda : AbstractMasterRow
    {
        public MasterRowItensVenda(GridView gridView) : base(gridView, "ItensVendas")
        {

        }

        public override IList MasterRowGetChildList(MasterRowGetChildListEventArgs e)
        {
            var o = _gridView.GetRow(e.RowHandle) as Venda;
            var bs = new BindingSource(o, this._relationName);
            var ds = bs.DataSource as Venda;
            List<ItemVenda> items = ds.ItensVendas.ToList();
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
            var lista = query.ToList();
            bs.DataSource = lista;
            return lista;
        }

        public override bool MasterRowEmpty(MasterRowEmptyEventArgs e)
        {
            var m = _gridView.GetRow(e.RowHandle) as Venda;
            return m.ItensVendas.Count == 0;
        }

    }
}
