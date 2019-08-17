using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ITE.Entidades.DaoManager.ContabilDaoManager
{
    public class ContaContabilDaoManager
    {
        public List<ContaContabil> GetAllContas()
        {
            var ctx = ITEGenericContext<ContaContabil>.Instance;
            ctx.Database.Log = Console.WriteLine;
            return ctx.Dao.FindAll();
        }
        public ContaContabil GetContaByCodigo(string codigoConta)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var contaFind = ctx.ContaContabilDao.First(c => c.CodigoContaContabil == codigoConta);
                    return contaFind;
                }
            }
            catch (Exception ex)
            {
                XMessageIts.Advertencia("Conta contábil não encontrada");
                XMessageIts.ExceptionMessage(ex);

            }
            return null;
        }

        public bool SaveContaContabil(ContaContabil conta)
        {
            try
            {
                if (VerifyCodReduzido(conta.CodigoReduzido))
                {
                    XMessageIts.Advertencia("Código reduzido já utilizado, por favor utilize outro.");
                    return false;
                }

                using (var ctx = new BalcaoContext())
                {
                    conta.Matriz = null;
                    conta.Nivel = GetNivelContaContabil(conta.CodigoContaContabil);
                    var result = ctx.ContaContabilDao.Save(conta);
                    if (result)
                    {
                        XMessageIts.Mensagem("Conta contábil incluída com sucesso!");
                        return result;
                    }

                }
            }
            catch (Exception ex)
            {

                XMessageIts.ExceptionMessage(ex);
            }
            return false;
        }
        public bool UpdateContaContabil(ContaContabil contaNova, ContaContabil contaAntiga)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var contaUpdate = ctx.ContaContabilDao.Find(contaAntiga.IdContaContabil);                    
                    contaUpdate.Update(contaNova);
                    contaUpdate.Nivel = GetNivelContaContabil(contaUpdate.CodigoContaContabil);
                    contaUpdate.Matriz = null;
                    var result = ctx.ContaContabilDao.Update(contaUpdate);
                    if (result)
                    {
                        XMessageIts.Mensagem("Conta contábil atualizada com sucesso!");
                        return result;
                    }

                }
            }
            catch (Exception ex)
            {

                XMessageIts.ExceptionMessage(ex);
            }
            return false;
        }
        public int GetNivelContaContabil(string codigoConta)
        {
            if (codigoConta.Length == 1)
            {
                return 1;
            }
            else if (codigoConta.Length == 3)
            {
                return 2;
            }
            else if (codigoConta.Length == 5)
            {
                return 3;
            }
            else if (codigoConta.Length == 8)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }

        /// <summary>
        /// Verifica se um codigo reduzido ja foi utilizado. True se sim, false se não foi usado ainda
        /// </summary>
        /// <param name="codigoReduzido"></param>
        /// <returns></returns>
        public bool VerifyCodReduzido(string codigoReduzido)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var conta = ctx.ContaContabilDao.Where(c => c.CodigoReduzido == codigoReduzido).First();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
