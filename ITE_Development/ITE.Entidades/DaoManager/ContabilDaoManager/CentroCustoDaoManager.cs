using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System;
using System.Linq;

namespace ITE.Entidades.DaoManager.ContabilDaoManager
{
    public class CentroCustoDaoManager
    {
        private bool save(CentroCusto novo, BalcaoContext ctx)
        {
            //persiste o objeto
            if (ctx.CentroCustoDao.Save(novo))
            {
                XMessageIts.Mensagem("Centro de custo incluso no sistema!");
                return true;
            }
            return false;
        }

        private bool update(CentroCusto novo, BalcaoContext ctx)
        {
            //passe o objeto pro contexto
            var current = ctx.CentroCustoDao.Find(novo.IdCentroCusto);

            //atualiza o objeto encontrado com os dados do form
            current.Update(novo);

            if (ctx.CentroCustoDao.Update(current))
            {
                XMessageIts.Mensagem("Alteração efetivada com sucesso.");

                return true;
            }
            return false;
        }

        public string GetNextCodigo()
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    CentroCusto result = ctx.CentroCustoDao.Last();

                    int codigo = ParseUtil.ToInt(result.IdCentroCusto) + 1;

                    if (codigo.ToString().Length == 1)
                        return "0" + codigo;

                    return codigo.ToString();
                }
                catch (Exception)
                {
                    return "01";
                }
            }
        }

        public bool SaveUpdate(CentroCusto novo)
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    //verificando codigo
                    CentroCusto result = ctx.CentroCustoDao
                                .Where(f => f.CodigoCentroCusto == novo.CodigoCentroCusto)
                                .FirstOrDefault();

                    //se encontrei um centro de custo
                    //que nao eh a igual a que foi informada
                    if (result != null && result.IdCentroCusto != novo.IdCentroCusto)
                    {
                        XMessageIts.Advertencia("Código \"" + result.CodigoCentroCusto + "\" já foi utilizado!");
                        return false;

                    }
                    //verfique o nome
                    result = ctx.CentroCustoDao
                              .Where(f => f.NomeCentroCusto == novo.NomeCentroCusto)
                              .FirstOrDefault();

                    //se encontrei um centro de custo
                    //que nao eh a igual a que foi informada
                    if (result != null && result.IdCentroCusto != novo.IdCentroCusto)
                    {
                        XMessageIts.Advertencia("Nome do centro de custo \"" + result.NomeCentroCusto + "\" já existe !");
                        return false;

                    }
                    //a pk eh zero entao vou salvar
                    if (novo.IdCentroCusto == 0)
                        return save(novo, ctx);
                    //entao atualize
                    return update(novo, ctx);

                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionMessage(ex);
                    //nao achei entao salve
                    return save(novo, ctx);
                }
            }
        }
        public CentroCusto GetCentroByCodigo(string codigoCentro)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var centroFind = ctx.CentroCustoDao.First(c => c.CodigoCentroCusto == codigoCentro);
                    return centroFind;
                }
            }
            catch (Exception ex)
            {
                XMessageIts.Advertencia("Centro de custo não encontrado!");
                XMessageIts.ExceptionMessage(ex);

            }
            return null;
        }
    }
}
