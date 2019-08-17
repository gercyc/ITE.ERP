using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITE.Entidades.DaoManager.VendasDaoManager
{
    public class UnidadeMedidaDaoManager
    {
        private bool save(UnidadeMedida novo, BalcaoContext ctx)
        {
            //persiste o objeto
            if (ctx.UnidadeMedidaDao.Save(novo))
            {
                XMessageIts.Mensagem("Unidade de medida cadastrada com sucesso!");
                return true;
            }
            return false;
        }

        private bool update(UnidadeMedida novo, BalcaoContext ctx)
        {
            //passe o objeto pro contexto
            var current = ctx.UnidadeMedidaDao.Find(novo.IdUnidadeMedida);

            //atualiza o objeto encontrado com os dados do form
            current.Update(novo);

            if (ctx.UnidadeMedidaDao.Update(current))
            {
                XMessageIts.Mensagem("Alteração efetivada com sucesso.");
                return true;
            }
            return false;
        }

        public bool SaveUpdate(UnidadeMedida novo)
        {
            using (var ctx = new BalcaoContext())
            {
                if (novo.IdUnidadeMedida == 0)
                {
                    //a pk eh zero entao vou salvar
                    return save(novo, ctx);
                }
                else
                {
                    try
                    {
                        UnidadeMedida result = ctx.UnidadeMedidaDao
                                    .First(f => f.NomeUnidadeMedida == novo.NomeUnidadeMedida);

                        //se encontrei um forma de pagamento 
                        //que nao eh a igual a que foi informada
                        if (result.IdUnidadeMedida != novo.IdUnidadeMedida)
                        {
                            XMessageIts.Advertencia("Unidade de medida " + result.NomeUnidadeMedida + " já existe !");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        //nao encontrado 
                        LoggerUtilIts.ShowExceptionMessage(ex);
                    }
                    //sempre vai atualizar
                    return update(novo, ctx);
                }

            }
        }

        public void Delete(int id)
        {
            using (var ctx = new BalcaoContext())
            {
                var current = ctx.UnidadeMedidaDao.Find(id);

                var op = XMessageIts.Confirmacao("Deseje remover a unidade de medida " 
                    + current.NomeUnidadeMedida);

                if (op == DialogResult.Yes)
                {
                    if (ctx.UnidadeMedidaDao.Delete(current))
                        XMessageIts.Mensagem("Unidade de medida " + current.NomeUnidadeMedida + " removida com sucesso.");
                }
            }
        }
    }
}
