using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using ITSolution.Framework.Listeners.GridViewEvents;
using System.Collections;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using System.Data.Entity;

namespace ITE.Financeiro.Listeners
{
    public class MasterRowComissaoVenda : AbstractMasterRow
    {
        public MasterRowComissaoVenda(GridView gridView) : base(gridView, "Comissoes")
        {
        }


        public override IList MasterRowGetChildList(MasterRowGetChildListEventArgs e)
        {
            var o = _gridView.GetRow(e.RowHandle) as Venda;

            if (ChildChanged)
            {
                using (var ctx = new BalcaoContext())
                {
                    try
                    {
                        o = ctx.Vendas.Where(v => v.IdVenda == o.IdVenda)
                            .Include(v => v.Comissoes).First();
                    }
                    catch (System.Exception)
                    {
                    }
                }
            }
            var bs = new BindingSource(o, this._relationName);
            var ds = bs.DataSource as Venda;
            var items = ds.Comissoes.ToList();
            var query = from i in items
                        select new ComissaoVendaUsuario
                        {
                            Image = i.Image,
                            StatusComissao = i.StatusComissao,
                            ValorFaturado = i.ValorFaturado,
                            PorcentagemComissao = i.PorcentagemComissao,
                            ValorComissao = i.ValorComissao,
                        };
            var lista = query.ToList();
            bs.DataSource = lista;
            return lista;
        }

        public override bool MasterRowEmpty(MasterRowEmptyEventArgs e)
        {
            var v = _gridView.GetRow(e.RowHandle) as Venda;

            return v.Comissoes.Count == 0;
        }

    }
}
