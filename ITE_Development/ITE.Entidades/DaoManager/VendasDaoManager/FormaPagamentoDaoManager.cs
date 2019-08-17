using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.DaoManager.VendasDaoManager
{
    public class FormaPagamentoDaoManager
    {
        private bool save(FormaPagamento novo, BalcaoContext ctx)
        {
            //persiste o objeto
            if (ctx.FormaPagamentoDao.Save(novo))
            {
                XMessageIts.Mensagem("Forma de pagamento cadastrada com sucesso!");
                return true;
            }
            return false;
        }

        private bool update(FormaPagamento novo, BalcaoContext ctx)
        {
            //passe o objeto pro contexto
            var current = ctx.FormaPagamentoDao.Find(novo.IdFormaPagamento);

            //atualiza o objeto encontrado com os dados do form
            current.Update(novo);

            if (ctx.FormaPagamentoDao.Update(current))
            {
                XMessageIts.Mensagem("Alteração efetivada com sucesso.");
                return true;
            }
            return false;
        }

        public bool SaveUpdate(FormaPagamento novo)
        {
            using (var ctx = new BalcaoContext())
            {

                if (novo.IdFormaPagamento == 0)
                {
                    //nova tupla
                    return save(novo, ctx);

                }
                else
                {
                    try
                    {
                        //procure o regstro
                        FormaPagamento result = ctx.FormaPagamentoDao
                                    .First(f => f.NomeFormaPagamento == novo.NomeFormaPagamento);

                        //se encontrei uma forma de pagamento 
                        //que nao eh a igual a pk do registro selecionado
                        if (result.IdFormaPagamento != novo.IdFormaPagamento)
                        {
                            XMessageIts.Advertencia("Forma de pagamento " + result.NomeFormaPagamento + " já existe !");
                            return false;

                        }

                        //atualize o registro
                        return update(novo, ctx);
                    }
                    catch (Exception ex)
                    {
                        //nada encontrado pode atualizar
                        LoggerUtilIts.ShowExceptionMessage(ex);

                        //a pk nao eh a mesma a sendo editadava entao atualize
                        return update(novo, ctx);

                    }
                }
            }
        }
    }
}