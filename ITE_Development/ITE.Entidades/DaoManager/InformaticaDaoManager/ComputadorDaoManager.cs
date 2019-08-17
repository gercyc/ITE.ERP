using ITE.Entidades.POCO.TI;
using System.Collections.Generic;
using System.Linq;

namespace ITE.Entidades.DaoManager.TIDaoManager
{
    public class ComputadorDaoManager
    {

        public void UpdatePCs(Manutencao m, Manutencao novo)
        {
            //add novos itens
            foreach (var item in novo.Computadores)
            {
                //atualizando e removendos os arquivos da lista atual
                //verifica se o arquivo atual esta na nova lista
                var currentItem = m.Computadores.ToList().Find(i =>
                                                    i.IdComputador == item.IdComputador &&
                                                    i.IdManutencao == item.IdManutencao);
                if (currentItem == null)
                    //adicione o item na lista
                    m.Computadores.Add(item);
            }
            updatePcs(m, novo);
        }

        private void updatePcs(Manutencao m, Manutencao novo)
        {
            var itensRemover = new List<Computador>();

            //atualizando os itens atuais
            foreach (var item in m.Computadores)
            {

                //verifica se o item atual ja esta na nova lista
                var itemAtualizado = novo.Computadores.ToList().Find(i =>
                       i.IdComputador == item.IdComputador &&
                       i.IdManutencao == item.IdManutencao);

                //se ele existe ou vou atualiza-lo
                if (itemAtualizado != null)
                {
                    //atualiza o item //nao precisa
                    //item.Update(itemAtualizado);
                }

                //ele nao existe
                else
                    // então ele nao faz parte da lista de arquivos
                    //marque o item para ser removido
                    itensRemover.Add(item);
            }

       

            //remove os itens
            itensRemover.ToList().ForEach(delegate (Computador i)
                {
                    m.Computadores.Remove(i);
                });
        }
    }
}
