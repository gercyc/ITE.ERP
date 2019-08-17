using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.DaoManager.LocalidadeDaoManager
{
    public class LocalidadeDaoManager
    {
        public UnidadeFederacao GetUfByCodigo(string codUF)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var uf = ctx.UnidadeFederacaoDao.Where(u => u.CodigoUF == codUF).FirstOrDefault();
                    return uf;
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Falha ao obter a UF");
                return null;
            }
        }
        public Municipios GetMunicipioByNome(string municipio)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var cidade = ctx.MunicipiosDao.Where(m => m.NomeMunicipio.ToUpper() == municipio.ToUpper()).FirstOrDefault();
                    return cidade;
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Falha ao obter a município");
                return null;
            }
        }
    }
}
