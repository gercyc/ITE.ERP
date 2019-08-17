using ITE.Entidades.POCO.TI;
using System.Collections.Generic;
using System.Linq;

namespace ITE.Entidades.DaoManager.TIDaoManager
{
    public class ItemManutencaoDaoManager
    {

        public void UpdateItens(Manutencao m, Manutencao novo)
        {
            //add novos itens
            foreach (var item in novo.ItensManutencao)
            {
                //atualizando e removendos os arquivos da lista atual
                //verifica se o arquivo atual esta na nova lista
                var currentItem = m.ItensManutencao.ToList().Find(i =>
                                                    i.IdProdutoManutencao == item.IdProdutoManutencao &&
                                                    i.IdManutencao == item.IdManutencao);
                if (currentItem == null)
                    //adicione o item na lista
                    m.ItensManutencao.Add(item);
            }
            updateItens(m, novo);
        }

        private void updateItens(Manutencao m, Manutencao novo)
        {
            var itensRemover = new List<ItemManutencao>();

            //atualizando os itens atuais
            foreach (var item in m.ItensManutencao)
            {

                //verifica se o item atual ja esta na nova lista
                var itemAtualizado = novo.ItensManutencao.ToList().Find(i =>
                       i.IdProdutoManutencao == item.IdProdutoManutencao &&
                       i.IdManutencao == item.IdManutencao);

                //se ele existe ou vou atualiza-lo
                if (itemAtualizado != null)
                {
                    //atualiza o item
                    item.Update(itemAtualizado);
                }

                //ele nao existe
                else
                    // então ele nao faz parte da lista de arquivos
                    //marque o item para ser removido
                    itensRemover.Add(item);
            }

            //cancela a referencia para o update no banco
            m.ItensManutencao.ToList().ForEach(i => i.Produto = null);


            //remove os itens
            itensRemover.ToList().ForEach(delegate (ItemManutencao i)
            {
                m.ItensManutencao.Remove(i);
            });
        }
    }
}
