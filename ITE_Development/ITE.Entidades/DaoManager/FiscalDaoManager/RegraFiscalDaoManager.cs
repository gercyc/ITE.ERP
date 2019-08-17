using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager.FiscalDaoManager
{
    public class RegraFiscalDaoManager
    {
        public bool UpdateRegraFiscal(RegraFiscal p_regraFiscal, List<ImpostosRegraFiscal> impostosRemovidos = null)
        {
            using (var ctx = new BalcaoContext())
            {
                var curr_regraFiscal = ctx.RegraFiscalDao.Find(p_regraFiscal.IdRegraFiscal);

                //se a qtd de itens for igual, somente atualize cada item
                if (curr_regraFiscal.ImpostosRegraFiscal.Count == p_regraFiscal.ImpostosRegraFiscal.Count)
                {
                    int i = 0;

                    foreach (var imp in curr_regraFiscal.ImpostosRegraFiscal)
                    {
                        if (impostosRemovidos != null && impostosRemovidos.Count > 0)
                        {
                            foreach (var impRemovido in impostosRemovidos)
                            {
                                var del = curr_regraFiscal.ImpostosRegraFiscal.ToList()
                                    .Where(impR => impR.IdImpostoRegraFical == impRemovido.IdImpostoRegraFical).FirstOrDefault();

                                ctx.ImpostosRegraFiscalDao.Delete(del);
                            }
                        }

                        imp
                            .Update(p_regraFiscal.ImpostosRegraFiscal
                            .Where(ip => ip.IdImpostoRegraFical == imp.IdImpostoRegraFical).FirstOrDefault());


                        i++;
                    }
                }

                foreach (var p_new in p_regraFiscal.ImpostosRegraFiscal)
                {
                    if (p_new.IdImpostoRegraFical == 0)
                    {
                        curr_regraFiscal.ImpostosRegraFiscal.Add(p_new);
                    }
                }
                curr_regraFiscal.Update(p_regraFiscal);
                curr_regraFiscal.ImpostosRegraFiscal.ToList().ForEach(ip =>
                {
                    ip.TipoImposto = null;
                    ip.SituacaoTributaria = null;
                });

                return ctx.RegraFiscalDao.Update(curr_regraFiscal);
            }

        }

        public void ZerarReferencias(RegraFiscal tipoMovimento)
        {
            foreach (var item in tipoMovimento.ImpostosRegraFiscal)
            {
                item.SituacaoTributaria = null;
                item.TipoImposto = null;
            }
        }

    }
}
