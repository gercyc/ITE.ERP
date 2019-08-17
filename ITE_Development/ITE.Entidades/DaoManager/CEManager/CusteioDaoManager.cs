using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITE.Entidades.POCO.CE;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;

namespace ITE.Entidades.DaoManager.CEManager
{

    /// <summary>
    /// Salva ou atualiza um cálculo de importação
    /// </summary>
    public class CusteioDaoManager
    {
        /// <summary>
        /// Salva ou atualiza a Custeio
        /// </summary>
        /// <param name="novo"></param>
        /// <returns></returns>
        public void SaveUpdate(Custeio novo)
        {
            if (novo.IdCusteio != 0)
            {
                if (Update(novo))
                {
                    XMessageIts.Mensagem("Custeio atualizado.");
                }
            }
            else
            {
                if (Save(novo))
                    XMessageIts.Mensagem("Custeio salvo.");
            }
        }

        public bool Save(Custeio novo)
        {
            using (var ctx = new BalcaoContext())
            {
                //cancelando a referencia dos produtos do itens
                //referencia cancelada para save
                //pq os itens vieram de outro form
                //e nao fazem parte deste contexto
                novo.Usuario = null;

                novo.Cliente = null;

                return ctx.CusteioDao.Save(novo);
            }
        }

        /// <summary>
        /// Atualiza a cotação remove ou insere itens quando necessário
        /// </summary>
        /// <param name="novo"></param>
        /// <returns></returns>
        public bool Update(Custeio novo)
        {
            using (var ctx = new BalcaoContext())
            {

                //atualizando o contexto
                var current = ctx.CusteioDao.Find(novo.IdCusteio);

                //atualiza os dados da Custeio
                current.Update(novo);

                //update mercadorias
                UpdateMercadorias(novo, current);

                //udpate despesas
                UpdateDespesas(novo, current);

                //udpate cotações
                UpdateCotacoes(novo, current);

                //efetiva a transação
                return ctx.CusteioDao.Update(current);

            }
        }


        private void UpdateMercadorias(Custeio novo, Custeio current)
        {

            var itensCurrent = current.ItensCusteio;

            //atualize as mercadorias
            foreach (var newItem in novo.ItensCusteio)
            {
                if (newItem.IdItemCusteio < 1)
                    current.ItensCusteio.Add(newItem);
                else
                {
                    var itemCurrent = itensCurrent.Where(i => i.IdItemCusteio == newItem.IdItemCusteio)
                        .First();

                    itemCurrent.Update(newItem);
                }

            }
        }

        private void UpdateDespesas(Custeio novo, Custeio current)
        {

            var itensCurrent = current.DespesasCusteio;

            //atualize as despesas
            foreach (var newItem in novo.DespesasCusteio)
            {
                if (newItem.IdDespesaCusteio < 1)
                    current.DespesasCusteio.Add(newItem);
                else
                {
                    var itemCurrent = itensCurrent.Where(i => i.IdDespesaCusteio == newItem.IdDespesaCusteio)
                        .First();

                    itemCurrent.Update(newItem);
                }
            }
        }

        private void UpdateCotacoes(Custeio novo, Custeio current)
        {

            var itensCurrent = current.CotacoesMoeda;

            //atualize as despesas
            foreach (var newItem in novo.CotacoesMoeda)
            {
                if (newItem.IdCotacaoCusteio < 1)
                    current.CotacoesMoeda.Add(newItem);
                else
                {
                    var itemCurrent = itensCurrent.Where(i => i.IdCotacaoCusteio == newItem.IdCotacaoCusteio)
                        .First();

                    itemCurrent.Update(newItem);
                }
            }
        }


        #region DML
        public static Custeio FindCusteio(Custeio ci)
        {
            using (var ctx = new BalcaoContext(false))
            {
                try
                {


                    return ctx.Custeios
                                            .Include(c => c.Cliente)
                                            .Include(c => c.Usuario)
                                            .Include(c => c.DespesasCusteio)
                                            .Include(c => c.ItensCusteio)
                                            .First(c => c.IdCusteio == ci.IdCusteio);
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        public async Task<List<Custeio>> FindCusteioLikeCliente(string search)
        {
            using (var ctx = new BalcaoContext(false))
            {
                var lancamentos = await ctx.Custeios
                                        .Include(c => c.Cliente)
                                        .Include(c => c.Usuario)
                                        .Where(l => l.Cliente.RazaoSocial.Contains(search))
                                        .ToListAsync();
                return lancamentos;

            }
        }

        public async Task<List<Custeio>> FindCusteiosFromCurrentYear()

        {

            using (var ctx = new BalcaoContext(false))
            {

                var lista = await ctx.Custeios
                                        .Include(c => c.Cliente)
                                        .Include(c => c.Usuario)
                                        .Where(c => c.DataCalculo.Year == DateTime.Now.Year)
                                        .ToListAsync();
                return lista;

            }
        }

        #endregion
    }
}
