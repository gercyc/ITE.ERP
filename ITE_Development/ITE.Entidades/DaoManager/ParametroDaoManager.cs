using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.POCO.Financeiro;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Entities;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Dao.Contexto;
using ITSolution.Framework.Enumeradores;

namespace ITE.Entidades.DaoManager
{
    public class ParametroDaoManager : ParametroManager
    {
        public static void AddContaBancariaDefault(ContaBancaria cb)
        {
            if (cb != null)
            {
                using (var ctx = new BalcaoContext())
                {
                    string codigo = TypeParametro.conta_bancaria.ToString();
                    //se isso der certo eh pra atualiza a conta
                    try
                    {
                        var r = ctx.ParametroDao.Where(p => p.CodigoParametro == codigo).First();
                        r.ValorParametro = "" + cb.IdContaBancaria;

                        ctx.ParametroDao.Update(r);
                    }
                    catch
                    {
                        //deu errado coloque a conta
                        var param = new Parametro(codigo, cb.IdContaBancaria.ToString());
                        ctx.ParametroDao.Save(param);
                    }
                }

            }
            else
            {
                using (var ctx = new BalcaoContext())
                {
                    var conta = new ContaBancaria(ctx.EmpresaFilialDao.First(), "0001", "Caixa espécie", 0.00m, DateTime.Now);
                    ctx.ContaBancariaDao.Save(conta);
                }
            }
        }

        public static CentroCusto GetCentroCustoVenda()
        {
            using (var ctx = new BalcaoContext())
            {
                string codigo = TypeParametro.centro_custo_venda.ToString();
                try
                {

                    Parametro param = ctx.ParametroDao.Where(
                            c => c.CodigoParametro == codigo)
                        .First();

                    var cc = ctx.CentroCustoDao.Find(ParseUtil.ToInt(param.ValorParametro));

                    return cc;
                }
                catch (Exception ex)
                {

                    string msg = "Falha ao localizar o centro de custo da venda";

                    FileManagerIts.AppendTextFileException(@"C:\Logs\its\excecoes\" + ex.GetType().ToString() + ".txt", ex);

                    throw new Exception(msg);
                }
            }
        }

        public static ContaBancaria GetContaBancaria()
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    return ctx.ContaBancariaDao.First();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    LoggerUtilIts.GenerateLogs(ex, "Conta bancária do sistema não encontrada");
                    return null;
                }
            }
        }


        public static ContaBancaria GetContaBancariaDefault()
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    string codigo = TypeParametro.conta_bancaria.ToString();
                    var param = ctx.ParametroDao.Where(
                        c => String.Equals(c.CodigoParametro, codigo)).First();

                    var cb = ctx.ContaBancariaDao.Find(ParseUtil.ToInt(param.ValorParametro));

                    return cb;
                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionLogs(ex);
                    //whatever => azaaaar
                    return null;
                }
            }
        }
        public static bool CheckLocalEstoque()
        {
            using (var ctx = new BalcaoContext())
            {
                {
                    try
                    {
                        return ctx.LocalEstoqueDao.CheckFirst();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Nenhum local de estoque:\n" + ex.Message);
                        //nao existe local de estoque
                        return false;
                    }
                }
            }
        }


        public void UpdateParamFromCodigo(List<Parametro> parametros)
        {

            int i = 0;
            using (var ctx = new BalcaoContext())
            {
                foreach (var param in parametros)
                {

                    try
                    {

                        var current = ctx.ParametroDao.Where(p =>
                                p.CodigoParametro == param.CodigoParametro)
                            .First();

                        current.Update(param);

                        if (ctx.ParametroDao.Update(current))
                            i++;
                    }
                    catch (Exception ex)
                    {
                        LoggerUtilIts.GenerateLogs(ex);

                    }
                }

                if (i == parametros.Count)//todos
                    XMessageIts.Mensagem("As definições do sistema foram atualizadas.");
                else if (i == 0)//nenhum
                    XMessageIts.Erro("Não foi possível atualizar as preferências.", "Falha no sistema");
                else //else if (i != parametros.Count) //uma ou mais
                    XMessageIts.Advertencia("Uma ou mais preferências não foram atualizadas", "Atenção");

            }


        }
        public void UpdateParamFromCodigo(Parametro param)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {

                    var current = ctx.ParametroDao.Where(p =>
                            p.CodigoParametro == param.CodigoParametro)
                        .First();

                    current.Update(param);

                    ctx.ParametroDao.Update(current);
                }
            }
            catch (Exception ex)
            {
                LoggerUtilIts.GenerateLogs(ex);
                if (!string.IsNullOrEmpty(param.DescricaoParametro))
                    XMessageIts.Erro("Não foi possível atualizar a preferência:\n" + param.DescricaoParametro);
                else
                    XMessageIts.Erro("Não foi possível atualizar uma ou mais preferência");

            }

        }

    }
}
