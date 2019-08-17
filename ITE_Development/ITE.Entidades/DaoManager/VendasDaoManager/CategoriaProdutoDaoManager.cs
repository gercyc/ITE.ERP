using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System;

namespace ITE.Entidades.DaoManager.VendasDaoManager
{
    public class CategoriaProdutoDaoManager
    {
        private bool save(CategoriaProduto novo, BalcaoContext ctx)
        {
            //persiste o objeto
            if (ctx.CategoriaProdutoDao.Save(novo))
            {
                XMessageIts.Mensagem("Categoria cadastrada com sucesso!");
                return true;
            }
            return false;
        }

        private bool update(CategoriaProduto novo, BalcaoContext ctx)
        {
            //passe o objeto pro contexto
            var current = ctx.CategoriaProdutoDao.Find(novo.IdCategoriaProduto);

            //atualiza o objeto encontrado com os dados do form
            current.Update(novo);

            if (ctx.CategoriaProdutoDao.Update(current))
            {
                XMessageIts.Mensagem("Alteração efetivada com sucesso.");
                return true;
            }
            return false;
        }

        public bool SaveUpdate(CategoriaProduto novo)
        {
            using (var ctx = new BalcaoContext())
            {

                if (novo.IdCategoriaProduto == 0)
                {
                    //nova tupla
                    return save(novo, ctx);

                }
                else
                {
                    try
                    {
                        //procure o regstro
                        CategoriaProduto result = ctx.CategoriaProdutoDao
                                    .First(f => f.NomeCategoriaProduto == novo.NomeCategoriaProduto);

                        //se encontrei uma forma de pagamento 
                        //que nao eh a igual a pk do registro selecionado
                        if (result.IdCategoriaProduto != novo.IdCategoriaProduto)
                        {
                            XMessageIts.Advertencia("Categoria " + result.NomeCategoriaProduto + " já existe !");
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