using System.Linq;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager.FinanceiroDaoManager
{
    public class AnexoDaoManager
    {
        //Esse eh um relacionamento 1 para N

        public void UpdateAnexos(BalcaoContext ctx, LancamentoFinanceiro lancamento, LancamentoFinanceiro novo)
        {
            //add novos itens
            foreach (var item in novo.Anexos)
            {
                //atualizando e removendos os arquivos da lista atual
                //verifica se o arquivo atual esta na nova lista
                var currentItem = lancamento.Anexos.ToList().Find(i => i.IdAnexo == item.IdAnexo);
                if (currentItem == null)
                {
                    item.IdLancamento = lancamento.IdLancamento;
                    //adicione o item na lista
                    ctx.AnexoLancamentoDao.Save(item);
                }
            }
            updateItens(ctx, lancamento, novo);
        }

        private void updateItens(BalcaoContext ctx, LancamentoFinanceiro lancamento, LancamentoFinanceiro novo)
        {
            //atualizando os itens atuais
            for (int i = 0; i < lancamento.Anexos.Count; i++)
            {
                var item = lancamento.Anexos.ToList()[i];
                //verifica se o item atual ja esta na nova lista
                var itemAtualizado = novo.Anexos.ToList().Find(x => x.IdAnexo == item.IdAnexo);

                //se ele existe ou vou atualiza-lo
                if (itemAtualizado != null) {
                    var a = ctx.AnexoLancamentoDao.Find(itemAtualizado.IdAnexo);

                    //atualiza o item
                    item.Update(itemAtualizado);
                    ctx.AnexoLancamentoDao.Update(a);
                }

                //ele nao existe
                else
                {
                    var a = ctx.AnexoLancamentoDao.Find(item.IdAnexo);
                    // então ele nao faz parte da lista de arquivos
                    //marque o item para ser removido
                    ctx.AnexoLancamentoDao.Delete(a);
                }
            }
            lancamento.QuantidadeAnexos = lancamento.Anexos.Count;
        }
    }
}
