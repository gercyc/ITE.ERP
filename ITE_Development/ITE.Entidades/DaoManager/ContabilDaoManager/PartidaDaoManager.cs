using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.POCO.Contabil;
using System;

namespace ITE.Entidades.DaoManager.ContabilDaoManager
{
    public class PartidaoDaoManager
    {

        public void UpdatePartidas(LancamentoContabil currentLanc, LancamentoContabil novo)
        {
            //add novos itens
            foreach (var item in novo.Partidas)
            {
                //atualizando e removendos os arquivos da lista atual
                //verifica se o arquivo atual esta na nova lista
                var currentItem = currentLanc.Partidas.ToList().Find(i =>
                                                    i.IdPartida == item.IdPartida );
                if (currentItem == null)
                {
                    //item.IdPartida = Guid.NewGuid();
                    //adicione o item na lista
                    currentLanc.Partidas.Add(item);
                }
            }
            updatePartidas(currentLanc, novo);
        }

        private void updatePartidas(LancamentoContabil partida, LancamentoContabil novo)
        {
            var itensRemover = new List<PartidaContabil>();

            //atualizando os itens atuais
            foreach (var item in partida.Partidas)
            {
                //verifica se o item atual ja esta na nova lista
                var itemAtualizado = novo.Partidas.ToList().Find(i =>
                       i.IdPartida == item.IdPartida && i.SequencialPartida == item.SequencialPartida);

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
            //partida.Partidas.ToList().ForEach(i => i.LancamentoContabil = null);

            //remove os itens
            itensRemover.ToList().ForEach(delegate (PartidaContabil i)
            {
                partida.Partidas.Remove(i);
            });

        }
    }
}
