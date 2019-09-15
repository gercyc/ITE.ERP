using ITE.Entidades.POCO;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Util;
using System;
using System.Linq;
using ITE.Entidades.POCO.Sales;

namespace ITE.Entidades.DaoManager
{
    public class ClienteDaoManager
    {
        public CliFor GetClienteById(int idCliFor)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);
                try
                {
                    return ctx.CliForDao.Where(c => c.IdCliFor == idCliFor).First();

                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public CliFor GetClienteByNome(string nome)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);
                try
                {
                    return ctx.CliForDao.Where(c => c.RazaoSocial == nome).First();

                }
                catch (Exception ex)
                {
                    LoggerUtilIts.ShowExceptionLogs(ex);
                    if (nome.Equals("CONSUMIDOR"))
                    {
                        Console.WriteLine("CONSUMIDOR NOT FOUND => Criando ...");
                        CliFor c = new CliFor
                        {
                            RazaoSocial = nome,
                            TipoCliente = ITSolution.Framework.Enumeradores.TypeCliente.Fisica,
                            Classificacao = TypeClassificaoCliente.Cliente,
                            CpfCnpj = "00000000000",

                        };

                        if (ctx.CliForDao.Save(c))
                            return c;
                    }
                    return null;
                }
            }
        }

        /// <summary>
        /// Retorna uma IQueryable usada para geração do relatório da venda
        /// </summary>
        /// <param name="cliFor"></param>Venda
        /// <returns></returns>IQueryable
        public IQueryable GetDataSource(CliFor cliFor)
        {
            using (var ctx = new BalcaoContext())
            {
                return ctx.CliForDao.Where(c => c.IdCliFor == cliFor.IdCliFor);
            }
        }

        /// <summary>
        /// Retorna uma IQueryable usada para geração do relatório da venda
        /// </summary>
        /// <param name="cliFor"></param>Venda
        /// <returns></returns>IQueryable
        public IQueryable<CliFor> GetDataSource(CliFor cliFor, TypeStatusVenda status)
        {
            using (var ctx = new BalcaoContext())
            {

                var query = ctx.CliForDao.Where(c => c.IdCliFor == cliFor.IdCliFor);
                var cliente = query.FirstOrDefault();

                //filtro para o status
                IQueryable<Venda> vendasPeriodo = null;

                //a vencer ou vencidas
                if (status == TypeStatusVenda.Aberto)
                {

                    //filtra as vendas nao vencidas e vencidas
                    vendasPeriodo = cliente.Vendas.AsQueryable().Where(v => v.StatusVenda == TypeStatusVenda.Aberto
                                              || v.StatusVenda == TypeStatusVenda.Vencida);
                }
                //filtre pelo status
                else if (status != TypeStatusVenda.Todas)
                {
                    vendasPeriodo = cliente.Vendas.AsQueryable().Where(v => v.StatusVenda == status);
                }
                else//traz tudo
                {
                    vendasPeriodo = cliente.Vendas.AsQueryable();
                }
                cliente.Vendas = vendasPeriodo.ToList();

                return query;
            }
        }


        /// <summary>
        /// Retorna uma IQueryable usada para geração do relatório da venda
        /// </summary>
        /// <param name="idCliFor">Chave primaria da venda</param>
        /// <returns>IQueryable</returns>
        public IQueryable GetDataSource(Int32 idCliFor)
        {
            using (var ctx = new BalcaoContext())
            {
                return ctx.CliForDao.Where(c => c.IdCliFor == idCliFor);
            }
        }

        public bool Save(CliFor novo)
        {
            using (var ctx = new BalcaoContext())
            {
                return ctx.CliForDao.Save(novo);
            }
        }

        public bool Update(CliFor novo)
        {
            using (var ctx = new BalcaoContext())
            {

                try
                {
                    var current = ctx.CliFors.Find(novo.IdCliFor);

                    //atualiza o cliente
                    current.Update(novo);

                    //CRUD Enderecos
                    UpdateEnderecosCliFor(current, novo, ctx);

                    //CRUD contas bancarias
                    UpdateContasCliFor(current, novo, ctx);

                    //CRUD Atividades
                    UpdateAtividadePrincipalCliFor(current, novo, ctx);
                    UpdateAtividadesSecundariasCliFor(current, novo, ctx);

                    //atualiza o cliFor
                    return ctx.CliForDao.Update(current);

                }
                catch
                {
                    return false;
                }
            }
        }

        private void UpdateEnderecosCliFor(CliFor cliente, CliFor novo, BalcaoContext ctx)
        {
            novo.UpdateEnderecoPrincipal();

            var enderecos = cliente.Enderecos.ToList();
            var EnderecosNovos = novo.Enderecos.ToList();

            //preparar a lista atualizar
            //verificando se arquivos foram removidos
            foreach (var end in enderecos)
            {
                //atualizando e removendos os arquivos da lista atual
                //verifica se o arquivo atual esta na nova lista
                var endAtualizado = EnderecosNovos.Find(e => e.IdEndereco == end.IdEndereco);

                //se ele existe ou vou atualiza-lo
                if (endAtualizado != null)
                    //atualiza o arquivo
                    end.Update(endAtualizado);

                //ele nao existe
                else
                {
                    //se for null então ele nao faz parte da lista de arquivos
                    //marque esse arquivo para ser removido
                    ctx.EnderecoCliForDao.Entry.SetStateDeleted(end);
                }
            }

            EnderecosNovos.ForEach(delegate (EnderecoCliFor end)
            {
                //se igual a zero um novo foi criado                
                if (end.IdEndereco == 0)
                {
                    end.IdCliForEndereco = cliente.IdCliFor;
                    cliente.Enderecos.Add(end);
                }
            });


        }

        private void UpdateContasCliFor(CliFor cliente, CliFor novo, BalcaoContext ctx)
        {
            var contas = cliente.ContasBancariasCliFor.ToList();
            var contasNovas = novo.ContasBancariasCliFor.ToList();

            //preparar a lista atualizar
            //verificando se arquivos foram removidos
            foreach (var cont in contas)
            {
                //atualizando e removendos os arquivos da lista atual
                //verifica se o arquivo atual esta na nova lista
                var contaAtualizada = contasNovas.Find(e => e.IdContaCliFor == cont.IdContaCliFor);

                //se ele existe ou vou atualiza-lo
                if (contaAtualizada != null)
                    //atualiza o arquivo
                    cont.Update(contaAtualizada);

                //ele nao existe
                else
                {
                    //se for null então ele nao faz parte da lista de arquivos
                    //marque esse arquivo para ser removido
                    ctx.ContaBancariaCliForDao.Entry.SetStateDeleted(cont);
                }
            }

            contasNovas.ForEach(delegate (ContaBancariaCliFor cont)
            {
                //se igual a zero um novo foi criado                
                if (cont.IdContaCliFor == 0)
                {
                    cont.IdCliFor = cliente.IdCliFor;
                    cliente.ContasBancariasCliFor.Add(cont);
                }
            });
        }

        private void UpdateAtividadePrincipalCliFor(CliFor cliente, CliFor novo, BalcaoContext ctx)
        {
            var atv = cliente.AtividadesPrincipais.ToList();
            var atvNew = novo.AtividadesPrincipais.ToList();

            //preparar a lista atualizar
            //verificando se arquivos foram removidos
            foreach (var a in atv)
            {
                //atualizando e removendos os arquivos da lista atual
                //verifica se o arquivo atual esta na nova lista
                var atvAtualizado = atvNew.Find(e => e.IdAtividade == a.IdAtividade);

                //se ele existe ou vou atualiza-lo
                if (atvAtualizado != null)
                    //atualiza o arquivo
                    //a.Update(atvAtualizado);
                    Console.WriteLine("a.Update(atvAtualizado)");
                //ele nao existe
                else
                {
                    //se for null então ele nao faz parte da lista de arquivos
                    //marque esse arquivo para ser removido
                    ctx.AtividadePrincipalCliForDao.Entry.SetStateDeleted(a);
                }
            }

            atvNew.ForEach(delegate (AtividadePrincipalCliFor a)
            {
                //se igual a zero um novo foi criado                
                if (a.IdAtividade == 0)
                {
                    a.IdCliFor = cliente.IdCliFor;
                    cliente.AtividadesPrincipais.Add(a);
                }
            });

        }


        private void UpdateAtividadesSecundariasCliFor(CliFor cliente, CliFor novo, BalcaoContext ctx)
        {
            var atv = cliente.AtividadesSecundarias.ToList();
            var atvNew = novo.AtividadesSecundarias.ToList();

            //preparar a lista atualizar
            //verificando se arquivos foram removidos
            foreach (var a in atv)
            {
                //atualizando e removendos os arquivos da lista atual
                //verifica se o arquivo atual esta na nova lista
                var atvAtualizado = atvNew.Find(e => e.IdAtividade == a.IdAtividade);

                //se ele existe ou vou atualiza-lo
                if (atvAtualizado != null)
                    //atualiza o arquivo
                    Console.WriteLine("a.Update(atvAtualizado)");

                //ele nao existe
                else
                {
                    //se for null então ele nao faz parte da lista de arquivos
                    //marque esse arquivo para ser removido
                    ctx.AtividadeSecundariaCliForDao.Entry.SetStateDeleted(a);
                }
            }

            atvNew.ForEach(delegate (AtividadeSecundariaCliFor a)
            {
                //se igual a zero um novo foi criado                
                if (a.IdAtividade == 0)
                {
                    a.IdCliFor = cliente.IdCliFor;
                    cliente.AtividadesSecundarias.Add(a);
                }
            });

        }

    }
}
