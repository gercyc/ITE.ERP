using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager.VendasDaoManager
{
    public class ImpostoItemMovimentoDaoManager
    {
        public void UpdateItens(Movimento nf, Movimento novaNf, BalcaoContext ctx)
        {
            //add novos itens
            foreach (var item in novaNf.ItensMovimento)
            {
                //cada item tem uma lista de impostos
                foreach (var imp in item.ImpostosItemMovimento)
                {
                    //atualizando e removendos os itens da lista atual
                    //verifica se o arquivo atual esta na nova lista
                    var currentItem = item.ImpostosItemMovimento.ToList()
                        .Find(i => i.IdImposto == imp.IdImposto &&
                                    i.IdItem == imp.IdItem);

                    if (currentItem == null)
                    {
                        if (novaNf.TipoMovimento.GeraMovimentoFiscal)
                            //crie os impostos do item com base na regra fiscal escolhida
                            item.CriarImpostos(item.RegraFiscal);
                    }
                }
                updateItens(nf, novaNf, ctx);

            }

        }

        private void updateItens(Movimento nf, Movimento novaNf, BalcaoContext ctx)
        {
            var impostosRemover = new List<ImpostoItemMovimento>();

            //atualizando os itens do bancos
            foreach (var item in nf.ItensMovimento)
            {
                //cada item tem uma lista de impostos
                foreach (var imp in item.ImpostosItemMovimento)
                {
                    //atualizando e removendos os itens da lista atual
                    //verifica se o arquivo atual esta na nova lista
                    foreach (var itemNewMov in novaNf.ItensMovimento)
                    {
                        if (novaNf.TipoMovimento.GeraMovimentoFiscal)
                        {
                            //limpo os impostos que existem, somente se a regra fiscal foi alterada
                            if (item.IdRegraFiscal != itemNewMov.IdRegraFiscal)
                            {
                                impostosRemover.Add(imp);
                                //crio novos impostos, com base no item que já foi atualizado
                                //item.CriarImpostos(itemNewMov.RegraFiscal);
                            }
                        }
                    }
                }
                foreach (var itemNewMov in novaNf.ItensMovimento)
                {
                    if (novaNf.TipoMovimento.GeraMovimentoFiscal)
                    {
                        //limpo os impostos que existem, somente se a regra fiscal foi alterada
                        if (item.IdRegraFiscal != itemNewMov.IdRegraFiscal)
                        {
                            //crio novos impostos, com base no item que já foi atualizado
                            item.CriarImpostos(itemNewMov.RegraFiscal);
                        }
                    }
                }

                if (item.ImpostosItemMovimento.Count == 0 && item.IdRegraFiscal != null)
                {
                    foreach (var itmNewNF in novaNf.ItensMovimento)
                    {
                        item.CriarImpostos(itmNewNF.RegraFiscal);
                    }
                }
            }

            //cancela a referencia para o update no banco
            nf.ItensMovimento.ToList().ForEach(delegate (ItemMovimento i)
                {
                    i.ImpostosItemMovimento.ToList().ForEach(delegate (ImpostoItemMovimento ip)
                    {
                        //ip.SituacaoTributaria = null;
                        //ip.TipoImposto = null;
                    });
                });

            //remove os impostos
            foreach (var imp in impostosRemover)
            {
                deleteImpostosItem(imp);                
            }
        }
        private void deleteImpostosItem(ImpostoItemMovimento imposto)
        {
            var ctx = new BalcaoContext();
            var impostoRemover = ctx.ImpostoItemMovimentoDao.Find(imposto.IdItemImposto);
            ctx.ImpostoItemMovimentoDao.Delete(impostoRemover);
            //item.ImpostosItemMovimento.Remove(impostoRemover);

        }
    }
}
