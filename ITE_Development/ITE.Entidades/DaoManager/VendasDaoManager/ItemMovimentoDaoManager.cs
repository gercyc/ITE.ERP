using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using System.Collections.Generic;
using System.Linq;

namespace ITE.Entidades.DaoManager
{
    public class ItemMovimentoDaoManager
    {

        public void UpdateItens(Movimento nf, Movimento novaNf, BalcaoContext ctx)
        {
            //add novos itens
            foreach (var item in novaNf.ItensMovimento)
            {
                //atualizando e removendos os itens da lista atual
                //verifica se o arquivo atual esta na nova lista
                var currentItem = nf.ItensMovimento.ToList().Find(i =>
                                                    i.IdProduto == item.IdProduto &&
                                                    i.IdItem == item.IdItem);
                if (currentItem == null)
                {
                    if (nf.TipoMovimento.GeraMovimentoFiscal)
                        //crie os impostos do item com base na regra fiscal escolhida
                        item.CriarImpostos(item.RegraFiscal);

                    //adicione o item na lista
                    nf.ItensMovimento.Add(item);
                }
            }
            updateItens(nf, novaNf, ctx);
        }

        private void updateItens(Movimento nf, Movimento novaNf, BalcaoContext ctx)
        {
            var itensRemover = new List<ItemMovimento>();

            //atualizando os itens atuais
            foreach (var item in nf.ItensMovimento)
            {
                //verifica se o item atual ja esta na nova lista
                var itemAtualizado = novaNf.ItensMovimento.ToList().Find(i =>
                       i.IdProduto == item.IdProduto &&
                       i.IdItem == item.IdItem);

                //se ele existe ou vou atualiza-lo
                if (itemAtualizado != null)
                {
                    //atualiza o item
                    item.Update(itemAtualizado);
                }

                //ele nao existe
                else
                    // então ele nao faz parte da lista de itens
                    //marque o item para ser removido
                    itensRemover.Add(item);
            }

            //cancela a referencia para o update no banco
            nf.ItensMovimento.ToList().ForEach(delegate (ItemMovimento i)
            {
                i.Produto = null;
                i.Cfop = null;
                i.RegraFiscal = null;

                i.ImpostosItemMovimento.ToList().ForEach(delegate (ImpostoItemMovimento ip)
                {
                    ip.SituacaoTributaria = null;
                    ip.TipoImposto = null;
                });
            });

            //remove os itens
            itensRemover.ToList().ForEach(delegate (ItemMovimento i)
            {
                //nf.ItensMovimento.Remove(i);
                removeItem(i);
            });
        }

        public void ClearImpostosItem(ItemMovimento item)
        {
            var ctx = new BalcaoContext();


            foreach (var imposto in item.ImpostosItemMovimento)
            {
                var impostoRemover = ctx.ImpostoItemMovimentoDao.Find(imposto.IdItemImposto);
                ctx.ImpostoItemMovimentoDao.Delete(impostoRemover);
                item.ImpostosItemMovimento.Remove(impostoRemover);
            }
        }
        private void removeItem(ItemMovimento item)
        {
            var ctx = new BalcaoContext();

            var itemRemover = ctx.ItemMovimentoDao.Find(item.IdItem);
            var traRemove = ctx.TransacoesProdutoDao.Where(t => t.IdMovimento == item.IdMovimento && t.IdProduto == item.IdProduto).FirstOrDefault();
            ctx.ItemMovimentoDao.Delete(itemRemover);

            if (traRemove != null)
                ctx.TransacoesProdutoDao.Delete(traRemove);

        }

    }
}
