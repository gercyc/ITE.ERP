using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Forms;

namespace ITE.Teste.LinqTest
{
    public class LinqTestes
    {

        public List<Municipios> FindAll()
        {
            var ctx = new ITEGenericContext<Municipios>();

            var frm = new XFrmExcelManager();

            var query = from l in ctx.DbSet select l;

            return query.Distinct().ToList();
                        
            //var lista = from l in Lancamentos
            //            join sc in Contas on l.IdContaCusto equals sc.IdContaCusto
            //            join cc in Centros on sc.IdCentroCusto equals cc.IdCentroCusto
            //            where l.IdContaCusto == 1
            //            select new { Lancamentos = l.ValorLancamento, Contas = sc.NomeContaCusto };

            //frm.FillGrid<Municipios>(ctx);

            //frm.ShowDialog()
        }
    }
}
