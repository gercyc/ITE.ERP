using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager.FiscalDaoManager
{
    public class SitTributDaoManager
    {

        public List<SituacaoTributaria> GetCstByIdImposto(Int32 idImposto)
        {
            using (var ctx = new BalcaoContext())
            {
                var listaCST = ctx.SituacaoTributariaDao.Where(cst => cst.IdImposto == idImposto);

                return listaCST.ToList();
            }
        }
    }
}
