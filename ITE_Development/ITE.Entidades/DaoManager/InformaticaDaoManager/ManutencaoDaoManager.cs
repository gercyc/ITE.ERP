using System;
using System.Linq;
using ITE.Entidades.DaoManager.TIDaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.TI;
using ITE.Entidades.Repositorio;

namespace ITE.Entidades.DaoManager.InformaticaDaoManager
{
    public class ManutencaoDaoManager
    {
      
        public bool SaveManutencao(Manutencao novo)
        {
            //cancelando a referencia dos produtos do itens
            //referencia cancelada para save
            //pq os itens vieram de outro form
            //e nao fazem parte deste contexto
            novo.ItensManutencao.ToList().ForEach(i => i.Produto = null);

            using (var ctx = new BalcaoContext())
            {
                var lancto = new LancamentoFinanceiro(novo);

                ctx.LancamentoFinanceiroDao.Save(lancto);

                novo.Atendimento = null;

                LancamentoFinanceiro l = new LancamentoFinanceiro();

                l.ValorLancamento = novo.ValorManutencao;
                l.DataVencimento = DateTime.Now;

                l.IdCentroCusto = novo.IdCentroCusto;
                l.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;
                l.SequencialParcela = 1;

                l.TipoLancamento = TypeLancamentoFinanceiro.Receber;

                var a = ctx.AtendimentoDao.Find(novo.IdAtendimento);
                if (a != null)
                {
                    if (novo.StatusManutencao == TypeStatusManutencao.Encerrado)
                        a.StatusAtendimento = TypeStatusAtendimento.Encerrado;

                    ctx.AtendimentoDao.Update(a);
                }

                return ctx.ManutencaoDao.Save(novo);
            }
        }

        /// <summary>
        /// Salva ou atualiza a manutencao
        /// 
        /// Atualiza / remove ou insere itens quando necessário
        /// </summary>
        /// <param name="novo"></param>
        /// <returns></returns>
        public bool UpdateManutencao(Manutencao novo)
        {
            using (var ctx = new BalcaoContext())
            {
                var itemManager = new ItemManutencaoDaoManager();
                var pcManager = new ComputadorDaoManager();

                //atualizando o contexto
                var m = ctx.ManutencaoDao.Find(novo.IdManutencao);

                //add\atualiza\remove os itens 
                itemManager.UpdateItens(m, novo);

                pcManager.UpdatePCs(m, novo);

                //atualiza os dados da manutencao
                m.Update(novo);

                foreach (var item in m.ItensManutencao)
                {
                    item.Produto = null;
                }


                //efetiva a transação
                var transation = ctx.ManutencaoDao.Update(m);

                var a = ctx.AtendimentoDao.Find(novo.IdAtendimento);
                if (a != null)
                {
                    if (novo.StatusManutencao == TypeStatusManutencao.Encerrado)
                        a.StatusAtendimento = TypeStatusAtendimento.Encerrado;

                    ctx.AtendimentoDao.Update(a);
                }

                return transation;
            }
        }

        /// <summary>
        /// Retorna uma IQueryable usada para geração do relatório da manutencao
        /// </summary>
        /// <param name="manutencao"></param>Manutencao
        /// <returns></returns>IQueryable
        public IQueryable GetDataSource(Manutencao manutencao)
        {
            using (var ctx = new BalcaoContext())
            {
                return ctx.ManutencaoDao.Where(v => v.IdManutencao == manutencao.IdManutencao);
            }
        }

        /// <summary>
        /// Retorna uma IQueryable usada para geração do relatório da manutencao
        /// </summary>
        /// <param name="idManutencao"></param>Chave primaria da manutencao
        /// <returns></returns>IQueryable
        public IQueryable GetDataSource(int idManutencao)
        {
            using (var ctx = new BalcaoContext())
            {
                return ctx.ManutencaoDao.Where(v => v.IdManutencao == idManutencao);
            }
        }

    }
}
