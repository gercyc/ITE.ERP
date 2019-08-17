using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ITE.Entidades.DaoManager.ContabilDaoManager
{
    public class LoteContabilDaoManager
    {
        public bool SaveLote(LoteContabil lote)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    lote.Matriz = null;
                    lote.newGuidID();
                    lote.NumeroLote = GetNewLoteNumber();
                    return ctx.LoteContabilDao.Save(lote);
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Ocorreu um erro ao salvar o lote.", "Erro");
                return false;
            }
        }
        public bool Update(LoteContabil novo)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var current = ctx.LoteContabilDao.Find(novo.IdLote);
                    current.Update(novo);
                    return ctx.LoteContabilDao.Update(current);
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Ocorreu um erro ao salvar o lote.", "Erro");
                return false;
            }
        }
        private string GetNewLoteNumber()
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {

                    var nextNumber = ctx.ConnectionSql.ExecuteQueryDataTable("SELECT NEXT VALUE FOR SEQ_NUM_LOTECONTABIL").Rows[0][0];

                    var strNumber = String.Format("{0:000000000}", nextNumber);
                    return strNumber;
                }
            }
            catch (SqlException ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Falha ao obter a numeração do lote.", "Erro ao obter sequência");
                return string.Empty;
            }
        }
    }
}
