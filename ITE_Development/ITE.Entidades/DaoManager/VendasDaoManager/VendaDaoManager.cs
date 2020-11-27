using System;
using System.Linq;
using System.Data.Entity;
using ITE.Entidades.DaoManager.FinanceiroDaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITE.Entities.DaoManager.FinanceiroDaoManager;

namespace ITE.Entidades.DaoManager.VendasDaoManager
{
    /// <summary>
    /// Classe para controle de persistencia de uma venda/cotação    
    /// </summary>
    public class VendaDaoManager
    {
        /// <summary>
        /// Salva ou atualiza a venda
        /// </summary>
        /// <param name="novo"></param>
        /// <returns></returns>
        public bool FecharProposta(Venda novo)
        {
            if (novo.IdVenda != 0)
                return UpdateProposta(novo);
            else
                return SaveProposta(novo);
        }

        public bool SaveProposta(Venda novo)
        {
            using (var ctx = new BalcaoContext())
            {

                //cancelando a referencia dos produtos do itens
                //referencia cancelada para save
                //pq os itens vieram de outro form
                //e nao fazem parte deste contexto
                novo.ItensVendas.ToList().ForEach(i => i.Produto = null);

                var frmPagto = preparaVenda(ctx, novo);

                //informe o usuario que criou a venda para as parcelas
                foreach (var p in novo.Parcelas)
                {
                    p.RecCreatedBy = novo.IdUsuarioVenda;
                    p.RecCreatedDate = DateTime.Now;
                    p.ValorJuros = novo.ValorJuros;
                }

                var transation = ctx.VendaDao.Save(novo);

                concluirVenda(ctx, novo, frmPagto, transation);

                return transation;
            }
        }

        /// <summary>
        /// Atualiza a cotação remove ou insere itens quando necessário
        /// </summary>
        /// <param name="novo"></param>
        /// <returns></returns>
        public bool UpdateProposta(Venda novo)
        {
            using (var ctx = new BalcaoContext())
            {
                var itemManager = new ItemVendaDaoManager();
                //atualizando o contexto
                var current = ctx.VendaDao.Find(novo.IdVenda);

                //add\atualiza\remove os itens 
                itemManager.UpdateItens(current, novo);

                if (novo.TipoMovimento == TypeVenda.Venda)
                {
                    foreach (var p in novo.Parcelas)
                    {
                        p.RecModifyBy = novo.IdUsuarioVenda;
                        p.RecModifyDate = DateTime.Now;
                        p.RecCreatedBy = current.IdUsuarioVenda;//deixa o usuario q tava mesmo
                        p.RecCreatedDate = DateTime.Now;
                        p.ValorJuros = novo.ValorJuros;
                        //add a parcela para na cotação ja salva
                        current.Parcelas.Add(p);
                    }
                }

                //atualiza os dados da venda
                //data da venda nunca eh alterada
                current.Update(novo);

                //prepara a venda para ser persistida
                var frmPagto = preparaVenda(ctx, current);

                //efetiva a transação
                var transation = ctx.VendaDao.Update(current);

                //termina a venda
                concluirVenda(ctx, current, frmPagto, transation);

                return transation;
            }
        }

        public bool isCancelarVenda(Venda venda)
        {
            if (venda.StatusVenda == TypeStatusVenda.Cancelada)
            {
                XMessageIts.Advertencia("A venda \"" + venda.IdVenda + "\" já está cancelada",
                    "Atenção");
                return false;
            }
            else if (venda.StatusVenda != TypeStatusVenda.Paga || venda.StatusVenda == TypeStatusVenda.Parcial)
            {
                using (var ctx = new BalcaoContext())
                {
                    try
                    {
                        var v = ctx.VendaDao.Find(venda.IdVenda);
                        var parcelas = v.Parcelas.ToList();

                        var parcela = parcelas.First();

                        //se a primeira parcela foi paga
                        if (parcela.DataPagamento != null)
                        {
                            //faz quantos dias q foi pago
                            var dias = DataUtil.CalcularDias(parcela.DataPagamento.Value, DateTime.Now);

                            //prazo maximo para cancelamento
                            if (dias > 19)
                            {
                                XMessageIts.Advertencia("O prazo para cancelamento é no máximo 15 dias utéis !",
                                    "Atenção limite de tempo para cancelamento estogato!");
                                return false;
                            }
                        }

                        //se 
                        //se todas as parcela foram pagas
                        if (parcelas.Count(p => p.DataPagamento != null) == parcelas.Count)
                        {
                            XMessageIts.Erro("A venda \"" + venda.IdVenda + "\" foi totalmente paga e não pode cancelada !",
                            "Atenção");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        LoggerUtilIts.GenerateLogs(ex, "Falha na checagem de cancelamento de vendas");
                        return true;
                    }

                }
            }
            else
            {
                XMessageIts.Advertencia("Status da venda \"" + venda.IdVenda + "\" não permite cancelamento !");
                return false;
            }

            return true;
        }

        private FormaPagamento preparaVenda(BalcaoContext ctx, Venda venda)
        {
            //se for cotação nao vou salvar as parcelas
            //as parcela ficam na memoria se ele quiser imprime
            if (venda.TipoMovimento == TypeVenda.Cotacao)
                //Nao salve as parcelas
                venda.Parcelas.Clear();

            //vencimento da venda eh a ultima parcela
            if (venda.Parcelas.Count > 0)
                venda.DataVencimento = venda.Parcelas.Last().DataVencimento;

            var frmPagto = ctx.FormaPagamentoDao.Find(venda.IdFormaPagamentoVenda);

            //se for a vista
            if (frmPagto.TipoFormaPagamento == TypeFormaPagamento.Dinheiro)
            {
                //marca a venda como paga
                venda.StatusVenda = TypeStatusVenda.Paga;

            }
            return frmPagto;
        }

        private void concluirVenda(BalcaoContext ctx, Venda venda, FormaPagamento frmPagto, bool transation)
        {

            //se eh uma venda e foi persistido
            if (transation && venda.TipoMovimento == TypeVenda.Venda)
            {
                //add movimentação do estoque
                new ProdutoDaoManager().AddMovimentacaoProduto(venda);

                //se foi a vista
                if (frmPagto.TipoFormaPagamento == TypeFormaPagamento.Dinheiro)
                {
                    //conta do caixa em especie
                    var conta = ctx.ContaBancariaDao.Where(c => c.CodigoContaBancaria.Equals("0001")).FirstOrDefault();
                    //cria o extrato da venda a vista
                    new ExtratoDaoManager().GenerateExtrato(venda, conta);
                    //add o valor da venda no caixa
                    new CaixaDaoManager().AddMovimentoVenda(venda, TypeMovimentacaoMonetaria.Credito);

                }
                //atualize as parcelas que foram salvas 
                //add o numero da venda que ja foi salva na observação
                //mesmo se for a vista tem 1 parcela

                decimal desconto = venda.ValorDesconto / venda.Parcelas.Count;

                foreach (var p in venda.Parcelas)
                {
                    if (venda.Parcelas.Count == 1)
                        p.Observacao = "REF. VENDA Nº.: " + venda.IdVenda;
                    else
                        p.Observacao = "REF. VENDA Nº.: " + venda.IdVenda + " | PARCELA Nº: " + p.SequencialParcela;

                    p.ValorLancamento = p.ValorLancamento - desconto;

                    //a parcela acompanha a forma de pagamento da venda
                    p.IdFormaPagamento = venda.IdFormaPagamentoVenda;

                    if (frmPagto.TipoFormaPagamento == TypeFormaPagamento.Dinheiro)
                        p.StatusLancamento = TypeStatusLancamentoFinanceiro.Pago;

                    //atualiza o lançamento
                    ctx.LancamentoFinanceiroDao.Update(p);
                }


                //consistencia do estoque de produtos do tipo serviço
                //Produtos do tipo serviço nao possuem estoque fisico            
                foreach (var item in venda.ItensVendas)
                {
                    var p = ctx.ProdutoDao.Find(item.IdProduto);

                    //serviço sempre tera quantidade 1
                    //e nao gera transação
                    if (p.TipoItemProduto == TypeItemProduto.Servico)
                    {
                        p.QuantidadeProduto = 1;
                        ctx.ProdutoDao.Update(p);
                    }
                }

                //gera a comissao de venda se nao for a vista
                new ComissaoVendaDaoManager().AddComissaoVenda(venda);
            }

        }

        /// <summary>
        /// Cancela a proposta pelo ID
        /// </summary>
        /// <param name="ID"></param>ID
        /// <param name="user"></param>Usuário
        /// <returns></returns>true cancelado caso contrario false
        public bool CancelarVenda(Venda venda, Usuario user, string motivoCancelamento,
            DateTime dataCancel, bool estornar = true)
        {
            using (var ctx = new BalcaoContext())
            {
                var current = ctx.VendaDao.Find(venda.IdVenda);
                if (current != null && user != null)
                {

                    //atualiza status
                    current.StatusVenda = TypeStatusVenda.Cancelada;

                    //atualiza o status do lancamento
                    foreach (var p in current.Parcelas)
                    {
                        p.MotivoCancelamento = motivoCancelamento;
                        p.DataCancelamento = dataCancel;
                        p.StatusLancamento = TypeStatusLancamentoFinanceiro.Cancelado;
                        p.RecModifyBy = user.IdUsuario;
                        p.RecModifyDate = DateTime.Now;

                    }

                    //se for cotação nao ligo de jogar fora
                    if (current.TipoMovimento == TypeVenda.Cotacao)

                        return ctx.VendaDao.Delete(current);

                    else
                    {

                        //me ajuda quando eu faço coisa errada
                        if (motivoCancelamento.Equals("DELETE ON CASCADE"))
                        {
                            string procedure1 = "[" + ctx.DatabaseName + "].[dbo].[P_DELETAR_LANCAMENTO]";
                            string procedure2 = "[" + ctx.DatabaseName + "].[dbo].[P_DELETAR_VENDA]";

                            ctx.ConnectionSql.ExecuteProcedure(procedure1);
                            ctx.ConnectionSql.ExecuteProcedure(procedure2);

                            XMessageIts.Mensagem("Venda totalmente excluída com sucesso", "Atenção !!!");
                        }
                        else
                                //atualiza
                                if (ctx.VendaDao.Update(current))
                        {
                            //retorna os produtos para o estoque
                            new ProdutoDaoManager().EstornarMovimentacaoProduto(current);

                            //estornando o lanc. do caixa somente se a venda esta paga
                            //e se mandei estornar
                            if (current.StatusVenda == TypeStatusVenda.Paga && estornar)
                            {
                                //se houve falha avise
                                new CaixaDaoManager().AddMovimentoVenda(current, TypeMovimentacaoMonetaria.Estorno);

                            }

                            //atualiza o objeto referenciado caso esteja sendo exibido no grid
                            venda.Update(current);
                            venda.CliFor = current.CliFor;
                            venda.Parcelas = current.Parcelas;
                            venda.CentroCusto = current.CentroCusto;

                            return true;//ok
                        }

                    }

                }
                return false;
            }
        }

        public static Venda FindVenda(Venda venda)
        {
            using (var ctx = new BalcaoContext())
            {
                return ctx.VendaDao.Find(venda.IdVenda);
            }
        }
        public void DuplicarProposta(Venda venda)
        {
            var duplicata = new Venda();

            duplicata.Update(venda);

            //update nao realiza os comandos abaixo
            duplicata.IdUsuarioVenda = venda.IdUsuarioVenda;
            duplicata.IdVenda = 0;
            duplicata.NumeroParcelas = 0;
            duplicata.FormaPagamentoVenda = null;
            duplicata.CliFor = null;
            duplicata.CentroCusto = null;
            duplicata.FilialVenda = null;
            duplicata.DataVenda = DateTime.Now;
            duplicata.TipoMovimento = TypeVenda.Cotacao;
            duplicata.StatusVenda = TypeStatusVenda.Aberto;


            using (var ctx = new BalcaoContext())
            {

                venda = ctx.VendaDao.Find(venda.IdVenda);

                //cancela ref da venda nos itens
                foreach (var i in venda.ItensVendas)
                {
                    //cria venda item
                    var item = new ItemVenda();
                    //atualiza o item
                    item.UpdateItem(i);

                    duplicata.ItensVendas.Add(item);
                }
                //remove as parcelas
                duplicata.Parcelas.Clear();

                if (ctx.VendaDao.Save(duplicata))
                {
                    XMessageIts.Mensagem("Venda \"" + venda.IdVenda + "\" duplicada com sucesso!\n\n" +
                        "Cotação: Nº: " + duplicata.IdVenda,
                        "Duplicação realizada com sucesso");
                }

            }

        }

        /// <summary>
        /// Retorna uma IQueryable usada para geração do relatório da venda
        /// </summary>
        /// <param name="venda"></param>Venda
        /// <returns></returns>IQueryable
        public IQueryable GetDataSource(Venda venda)
        {
            using (var ctx = new BalcaoContext())
            {


                try
                {
                    var c = ctx.CliForDao.Find(venda.IdCliForVenda);
                    //se a lista de enderecos do cliente esta vazia
                    //e tem um endereco principal
                    if (c.Enderecos.Count == 0 && !string.IsNullOrEmpty(c.NomeEndereco))
                    {
                        //cria um endereco pra lista com os dados do endereco principal
                        //Esse metodo nao deveiria existir
                        //mas foi feito para exibir o endereco la na nota de venda
                        var end = new EnderecoCliFor
                        {
                            NomeEndereco = c.NomeEndereco,
                            NumeroEndereco = c.NumeroEndereco,
                            Bairro = c.Bairro,
                            Cidade = c.Cidade,
                            Uf = c.Uf,
                            Complemento = c.Complemento
                        };
                        //add o endereco la
                        c.Enderecos.Add(end);
                        //atualiza a lista de enderecos do cliente
                        ctx.CliForDao.Update(c);
                    }

                }
                catch (Exception ex)
                {
                    LoggerUtilIts.GenerateLogs(ex, "Falha ao add endereço principal na lista de endereços");
                }
                return ctx.VendaDao.Where(v => v.IdVenda == venda.IdVenda);
            }
        }

        /// <summary>
        /// Retorna uma IQueryable usada para geração do relatório da venda
        /// </summary>
        /// <param name="idVenda"></param>Chave primaria da venda
        /// <returns></returns>IQueryable
        public IQueryable GetDataSource(int idVenda)
        {
            using (var ctx = new BalcaoContext())
            {
                return ctx.VendaDao.Where(v => v.IdVenda == idVenda);
            }
        }

        /* NAO EH UM BOA PRATICA
        /// <summary>
        /// Cancela a proposta pelo ID
        /// </summary>
        /// <param name="ID"></param>ID
        /// <param name="user"></param>Usuário
        /// <returns></returns>true cancelado caso contrario false
        public bool DeleteProposta(int ID)
        {
            var ctx = new BalcaoContext();
            var current = ctx.VendaDao.Find(ID);
            if (current != null )
            {
                bool isEstorno = false;

                if (current.StatusVenda == TypeStatusVenda.Paga)
                    isEstorno = true;

                //cancele as parcelas
                current.Parcelas.Clear();

                //joga os itens fora
                current.ItensVendas.Clear();

                try
                {
                    //dropa os vinculos
                    var movimentos = ctx.MovimentoCaixaDao.Where(m => m.IdVenda == current.IdVenda).ToList();
                    var transacoes = ctx.TransacoesProdutoDao.Where(t => t.IdVenda == current.IdVenda).ToList();
                    var lanctos = ctx.LancamentoFinanceiroDao.Where(l => l.IdVenda == current.IdVenda).ToList();
                    foreach (var m in movimentos)
                        ctx.MovimentoCaixaDao.Delete(m);

                    //apaga as transacoes
                    foreach (var t in transacoes)
                        ctx.TransacoesProdutoDao.Delete(t);

                    foreach (var l in lanctos)
                    {
                        l.StatusLancamento = l.StatusLancamento = TypeStatusLancamentoFinanceiro.Cancelado;
                        ctx.LancamentoFinanceiroDao.Update(l);
                    }

                    //retorna os produtos para o estoque
                    new ProdutoDaoManager().EstornarMovimentacaoProduto(current);

                    //estornando o lanc. do caixa somente se proposta foi quitada
                    if (isEstorno)
                        new CaixaDaoManager().AddMovimentoVenda(current, TypeMovimentacaoMonetaria.Estorno);

                    //dropa a venda
                    return ctx.VendaDao.Delete(current);

                }
                catch(Exception ex)
                {
                    XMessageIts.MensagemExcecao( ex, "Falha ao dropar a venda");
                }

            }
            return false;
        }*/
    }
}
