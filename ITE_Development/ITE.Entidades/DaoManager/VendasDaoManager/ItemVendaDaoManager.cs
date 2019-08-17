using ITE.Entidades.POCO.Sales;
using System.Collections.Generic;
using System.Linq;

namespace ITE.Entidades.DaoManager
{
    public class ItemVendaDaoManager
    {

        public void UpdateItens(Venda venda, Venda novo)
        {
            //add novos itens
            foreach (var item in novo.ItensVendas)
            {
                //atualizando e removendos os arquivos da lista atual
                //verifica se o arquivo atual esta na nova lista
                var currentItem = venda.ItensVendas.ToList().Find(i =>
                                                    i.IdProduto == item.IdProduto &&
                                                    i.IdVenda == item.IdVenda);
                if (currentItem == null)
                    //adicione o item na lista
                    venda.ItensVendas.Add(item);
            }
            updateItens(venda, novo);
        }

        private void updateItens(Venda venda, Venda novo)
        {
            var itensRemover = new List<ItemVenda>();

            //atualizando os itens atuais
            foreach (var item in venda.ItensVendas)
            {
                //verifica se o item atual ja esta na nova lista
                var itemAtualizado = novo.ItensVendas.ToList().Find(i =>
                       i.IdProduto == item.IdProduto &&
                       i.IdVenda == item.IdVenda);

                //se ele existe ou vou atualiza-lo
                if (itemAtualizado != null)
                    //atualiza o item
                    item.Update(itemAtualizado);

                //ele nao existe
                else
                    // então ele nao faz parte da lista de arquivos
                    //marque o item para ser removido
                    itensRemover.Add(item);
            }

            //cancela a referencia para o update no banco
            venda.ItensVendas.ToList().ForEach(i => i.Produto = null);

            //remove os itens
            itensRemover.ToList().ForEach(delegate (ItemVenda i)
            {
                venda.ItensVendas.Remove(i);
            });

            venda.NumeroItens = venda.ItensVendas.Count;
        }
    }
}
