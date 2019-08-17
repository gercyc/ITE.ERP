using System;
using System.Linq;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager
{
    public class EmpresaDaoManager
    {


        public bool CheckMatrizFilial()
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    return (ctx.EmpresaMatrizDao.First() != null);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public EmpresaMatriz FindMatrizByCodigo(string codMatriz)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {

                    var emp = ctx.EmpresaMatrizDao.Where(m => m.CodigoMatriz == codMatriz).FirstOrDefault();

                    return emp;
                }

            }
            catch
            {
                return null;
            }
        }

        public EmpresaFilial FindFilialByCodigo(string codFilial)
        {
            try

            {
                using (var ctx = new BalcaoContext())
                {
                    return ctx.EmpresaFilialDao.Where(f => f.CodigoFilial == codFilial)
                        .FirstOrDefault();
                }

            }
            catch
            {
                return null;
            }
        }
    }
}
