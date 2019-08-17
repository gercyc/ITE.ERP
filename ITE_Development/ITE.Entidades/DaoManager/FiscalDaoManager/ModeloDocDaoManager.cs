using System;
using System.Linq;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager.FiscalDaoManager
{
    public class ModeloDocDaoManager
    {
        public ModeloDocumentoFiscal GetModeloByNome(string nome)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    return ctx.ModeloDocumentoFiscalDao.Where(m => m.CodigoModelo == nome.Substring(0, 2)).FirstOrDefault();
                }
            }
            catch (ArgumentNullException)
            {

                return null;
            }
            catch (InvalidOperationException)
            {
                return null;
            }
        }
    }
}
