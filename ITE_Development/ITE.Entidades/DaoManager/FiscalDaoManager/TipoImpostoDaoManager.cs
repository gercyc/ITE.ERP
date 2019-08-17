using System;
using System.Linq;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager.FiscalDaoManager
{
    public class TipoImpostoDaoManager
    {
        public TipoImposto GetImpostoByCodigo(String codigoImposto)
        {
            using (var ctx = new BalcaoContext())
            {
                var imposto = ctx.TipoImpostoDao.Where(imp => imp.CodigoImposto == codigoImposto);

                return imposto.First();
            }
        }
    }
}
