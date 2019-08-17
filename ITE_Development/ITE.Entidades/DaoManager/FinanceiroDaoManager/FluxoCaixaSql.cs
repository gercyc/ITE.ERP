using System;
using System.Data;
using System.Data.SqlClient;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager.BorderoManager
{
    public class FluxoCaixaSql
    {

        public DataTable FluxoCaixaAnual(int ano)
        {
            using (var ctx = new BalcaoContext())
            {
                string procedure = "P_ANALISE_FLUXO_CAIXA_ANUAL";
                var con = ctx.ConnectionSql;

                SqlParameter parametro = new SqlParameter("@Ano", ano);

                return con.ExecuteProcedure(procedure, parametro);
            }
        }

        public DataTable FluxoCaixaPorPeriodo(  DateTime dtInicial, DateTime dtFinal)
        {
            using (var ctx = new BalcaoContext())
            {
                var con = ctx.ConnectionSql;

                string procedure = "P_FLUXO_CAIXA_POR_PERIODO";

                SqlParameter p1 = new SqlParameter("@DataInicial", dtInicial);
                SqlParameter p2 = new SqlParameter("@DataFinal", dtFinal);

                return con.ExecuteProcedure(procedure, p1, p2);
            }
        }

        public DataTable AnaliseFluxoCaixa(int ano)
        {
            using (var ctx = new BalcaoContext())
            {
                string procedure = "P_ANALISE_FLUXO_CAIXA_ANUAL";

                var con = ctx.ConnectionSql;

                SqlParameter parametro = new SqlParameter("@Ano", ano);

                return con.ExecuteProcedure(procedure, parametro);
            }
        }

    }
}
