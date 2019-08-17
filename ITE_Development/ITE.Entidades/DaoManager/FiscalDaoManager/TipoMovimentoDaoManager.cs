using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Fiscal.RegrasFiscais.Managers
{
    public class TipoMovimentoDaoManager
    {
        public bool SaveTipoMovimento(TipoMovimento tipoMov)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    tipoMov.CentroCusto = null;
                    tipoMov.FormaPagamento = null;
                    tipoMov.LocalEstoque = null;

                    var result = ctx.TipoMovimentoDao.Save(tipoMov);
                    if (result)
                    {
                        XMessageIts.Mensagem("Parametrização de tipo de movimento incluída com sucesso!");
                        return result;
                    }

                }
            }
            catch (Exception ex)
            {

                XMessageIts.ExceptionMessage(ex);
            }
            return false;
        }
        public bool UpdateTipoMovimento(TipoMovimento tpMovNovo, TipoMovimento tpMovAntiga)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var tpMovUpdate = ctx.TipoMovimentoDao.Find(tpMovAntiga.IdTipoMovimento);

                    tpMovUpdate.Update(tpMovNovo);
                    tpMovUpdate.CentroCusto = null;
                    tpMovUpdate.FormaPagamento = null;
                    tpMovUpdate.LocalEstoque = null;
                    var result = ctx.TipoMovimentoDao.Update(tpMovUpdate);
                    if (result)
                    {
                        XMessageIts.Mensagem("Parametrização de tipo de movimento atualizada com sucesso!");
                        return result;
                    }

                }
            }
            catch (Exception ex)
            {

                XMessageIts.ExceptionMessage(ex);
            }
            return false;
        }
    }
}
