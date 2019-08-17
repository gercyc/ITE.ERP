using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores.FinanceiroEnum;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ITE.Entities.DaoManager.FinanceiroDaoManager
{
    public class ComissaoVendaDaoManager
    {
        public async Task<List<Venda>> FiltrarComissaoVendas(DateTime dtInicio, DateTime dtFim, Usuario user,
            TypeStatusComissaoVenda status)
        {
            using (var ctx = new BalcaoContext(false))
            {

                if (user == null)
                {
                    IQueryable<Venda> query = from comissao in ctx.ComissoesVenda
                                                  //join comissao in ctx.ComissoesVenda on venda.IdVenda equals comissao.IdVenda
                                              where DbFunctions.TruncateTime(comissao.Venda.DataVenda) >= dtInicio &&
                                                    DbFunctions.TruncateTime(comissao.Venda.DataVenda) <= dtFim &&
                                                    comissao.StatusComissao == status
                                              select comissao.Venda; // new { Venda = venda, Comissao = comissao };

                    //select only sales with Comissoes
                    return await query.GroupBy(v => v.IdVenda)
                                        .Select(v => v.FirstOrDefault())
                                        .Include(v => v.CliFor)
                                        .Include(v => v.Usuario)
                                        .Include(v => v.CliFor)
                                        .Include(v => v.Comissoes)
                                        .ToListAsync();

                }
                else
                {
                    IQueryable<Venda> query = from comissao in ctx.ComissoesVenda
                                              where DbFunctions.TruncateTime(comissao.Venda.DataVenda) >= dtInicio &&
                                                    DbFunctions.TruncateTime(comissao.Venda.DataVenda) <= dtFim &&
                                                    comissao.StatusComissao == status &&
                                                    comissao.Venda.IdUsuarioVenda == user.IdUsuario//vendedor
                                              select comissao.Venda;

                    //select only sales with Comissoes
                    return await query.GroupBy(v => v.IdVenda)
                        .Select(v => v.FirstOrDefault())
                        .Include(v => v.CliFor)
                        .Include(v => v.Usuario)
                        .Include(v => v.Comissoes)
                        .Include(v => v.CliFor)
                        .ToListAsync();
                }
            }

        }


        /// <summary>
        /// Cria as comissões ao realizar uma venda
        /// </summary>
        /// <param name="venda"></param>
        public void AddComissaoVenda(Venda venda)
        {
            using (var ctx = new BalcaoContext(false))
            {
                
                var cliFor = new ClienteDaoManager().GetClienteById(venda.IdCliForVenda);

                //consumidor nao permite comissão
                if (cliFor.RazaoSocial != "CONSUMIDOR")
                {
                    var user = ctx.UsuarioDao.Find(venda.IdUsuarioVenda);
                    venda.Usuario = user;
                    //gera comissão de venda
                    foreach (var lancamento in venda.Parcelas)
                    {
                        var comissao = new ComissaoVendaUsuario(venda, lancamento, user);
                        ctx.ComissaoVendaUsuarioDao.Save(comissao);
                    }
                }
            }

        }

        /// <summary>
        /// Fatura a comissao de venda gerandos os lançamentos financeiros.
        /// </summary>
        /// <param name="venda"></param>
        /// <returns></returns>
        public bool FaturarComissao(List<LancamentoFinanceiro> lancamentosComissoes, TypeFaturamentoComissao type)
        {
            //using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required,
            //            new TransactionOptions() { IsolationLevel = IsolationLevel.Serializable }))
            //{
            var lancamento = lancamentosComissoes.First();
            int idVenda = lancamento.IdVenda.Value;
            try
            {
                using (var ctx = new BalcaoContext())
                {

                    if (type == TypeFaturamentoComissao.Integral)
                    {
                        //limpe todas as comissoes
                        ctx.ComissaoVendaUsuarioDao.Delete(c => c.IdVenda == idVenda);

                        //recupere a venda
                        var venda = ctx.VendaDao.Find(idVenda);
                        //crie uma nova comissão
                        var comissao = new ComissaoVendaUsuario(venda);
                        //crie o lançamento da comissão
                        comissao.Lancamentos.Add(lancamento);
                        //crie a nova comissão
                        ctx.ComissaoVendaUsuarioDao.Save(comissao);
                    }
                    else
                    {

                        //salva o lançamento
                        foreach (var lancto in lancamentosComissoes)
                        {
                            lancto.CliFor = null;
                            ctx.LancamentoFinanceiroDao.Save(lancto);

                            var cv = ctx.ComissaoVendaUsuarioDao.Find(lancto.IdComissaoVenda);

                            cv.FaturarComissao();

                            ctx.ComissaoVendaUsuarioDao.Update(cv);

                        }
                    }

                    return true;// XMessageIts.Mensagem("Comissão da venda nº: " + idVenda + " faturada com sucesso");
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionJustMessage(ex, "Não foi possivel faturar comissão da venda nº: " + idVenda);
                throw ex;
            }
        }
    }
}

