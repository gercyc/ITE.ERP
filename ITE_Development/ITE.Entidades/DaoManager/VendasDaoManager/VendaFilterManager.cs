using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.POCO;

namespace ITE.Entidades.DaoManager
{
    /// <summary>
    /// Essa classe utiliza o retorno IQueryable para aproveitar o retorno do metodo para geraçã do relatório
    /// </summary>
    public class VendaFilterManager
    {

        /// <summary>
        /// Busca vendas por dia informado
        /// </summary>
        /// <param name="dtInicio"></param>
        /// <returns></returns>
        public IQueryable<Venda> FindVendasDoDia(DateTime dtInicio)
        {
            using (var ctx = new BalcaoContext())
            {
                var vendas = ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda
                                                && v.DataVenda.Date == dtInicio.Date)
                                                .OrderBy(v => v.DataVenda);
                return vendas;
            }
        }

        /// <summary>
        /// Busca vendas por dia informado
        /// </summary>
        /// <param name="dtInicio"></param>
        /// <returns></returns>
        public IQueryable<Venda> FindVendasDoDia(DateTime dtInicio, TypeStatusVenda status)
        {
            using (var ctx = new BalcaoContext())
            {
                var vendas = ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda
                        && v.DataVenda.Date == dtInicio.Date
                        && v.StatusVenda == status)
                        .OrderBy(v => v.DataVenda);
                return vendas;
            }
        }

        /// <summary>
        /// Retorna vendas por intervalo de datas
        /// </summary>
        /// <param name="dtInicio"></param>
        /// <param name="dtFinal"></param>
        /// <returns></returns>
        public IQueryable<Venda> FindVendasByPeriodo(DateTime dtInicio, DateTime dtFinal)
        {
            var ctx = new BalcaoContext();
            var vendas = ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda
                                            && v.DataVenda.Date >= dtInicio.Date
                                            && v.DataVenda.Date <= dtFinal.Date)
                                            .OrderBy(v => v.DataVenda);

            return vendas;
        }

        public IQueryable<Venda> FindVendasByPeriodo(DateTime dtInicio, DateTime dtFinal,
            TypeStatusVenda status, TypeAgrupamentoVendas agrupar)
        {
            using (var ctx = new BalcaoContext())
            {

                //Saos as vendas em atraso e aos que vao vencer
                if (status == TypeStatusVenda.Aberto)
                {
                    var vendas = ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda
                                      && v.DataVenda.Date >= dtInicio.Date
                                     && v.DataVenda.Date <= dtFinal.Date);


                    vendas = vendas.Where(v => v.StatusVenda == TypeStatusVenda.Aberto
                                           || v.StatusVenda == TypeStatusVenda.Parcial
                                           || v.StatusVenda == TypeStatusVenda.Vencida)
                                           .OrderBy(v => v.DataVenda);

                    return vendas;

                }
                //StatusVenda.Quitada , StatusVenda.Vencida , StatusVenda.Cancelada
                else if (status != TypeStatusVenda.Todas)
                {

                    return ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda
                                                    && v.DataVenda.Date >= dtInicio.Date
                                                   && v.DataVenda.Date <= dtFinal.Date
                                                   && v.StatusVenda == status)
                                                   .OrderBy(v => v.DataVenda);
                }
                //Todas
                else

                    return ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda
                                                    && v.DataVenda.Date >= dtInicio.Date
                                                   && v.DataVenda.Date <= dtFinal.Date)
                                                   .OrderBy(v => v.DataVenda);

            }

        }


        /// <summary>
        /// Retorna vendas do cliente informado, dentro do período de datas desejado
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="dtInicio"></param>
        /// <param name="dtFinal"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public IQueryable<Venda> FindVendasByPeriodo(CliFor cliente, DateTime dtInicio, DateTime dtFinal,
            TypeStatusVenda status, TypeAgrupamentoVendas agrupar)
        {

            using (var ctx = new BalcaoContext())
            {
                //filtra pelo cliente


                //Saos as vendas em atraso e aos que vao vencer
                if (status == TypeStatusVenda.Aberto)
                {
                    var vendas = ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda
                                  && v.DataVenda.Date >= dtInicio.Date
                                  && v.DataVenda.Date <= dtFinal.Date
                                  && v.IdCliForVenda == cliente.IdCliFor);

                    vendas = vendas.Where(v => v.StatusVenda == TypeStatusVenda.Aberto
                                           || v.StatusVenda == TypeStatusVenda.Parcial
                                           || v.StatusVenda == TypeStatusVenda.Vencida)
                                           .OrderBy(v => v.DataVenda);

                    return vendas;

                }
                //StatusVenda.Quitada , StatusVenda.Vencida , StatusVenda.Cancelada
                else if (status != TypeStatusVenda.Todas)
                {

                    return ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda
                                                 && v.DataVenda.Date >= dtInicio.Date
                                                 && v.DataVenda.Date <= dtFinal.Date
                                                 && v.StatusVenda == status
                                                 && v.IdCliForVenda == cliente.IdCliFor)
                                                 .OrderBy(v => v.DataVenda);
                }
                //Todas
                else

                    return ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda
                                                    && v.DataVenda.Date >= dtInicio.Date
                                                   && v.DataVenda.Date <= dtFinal.Date
                                                     && v.IdCliForVenda == cliente.IdCliFor)
                                                     .OrderBy(v => v.DataVenda);

            }

        }
        

        /// <summary>
        /// Busca vendas em aberto vencendo no dia atual do sistema.
        /// </summary>
        /// <param name="dtInicio"></param>
        /// <returns></returns>
        public int FindVendasEmAberto()
        {
            var ctx = new BalcaoContext();
            var vendas = ctx.VendaDao.Where(v => v.TipoMovimento == TypeVenda.Venda &&
                                          v.DataVencimento == DateTime.Now.Date &&
                                          v.StatusVenda == TypeStatusVenda.Aberto)
                                          .Count();
            return vendas;
        }

    }
}
