using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;

namespace ITE.Entidades.DaoManager
{
    /// <summary>
    /// Tudo relacionado ao produto, implementar aqui
    /// </summary>
    public class ProdutoDaoManager
    {
        public Produto GetProdutoByDescricao(string descricao)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var task = ctx.ProdutoDao.Where(p => p.DescricaoProduto == descricao);
                    return task.First();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Produto nao encontrado pela descricao: " + descricao + "=>" + ex.Message);
            }

            return null;
        }

        public Produto GetProdutoByCodigoBarras(string codigoBarras)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var task = ctx.ProdutoDao.Where(p => p.CodigoBarras == codigoBarras);
                    return task.First();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Produto nao encontrado pelo codigo de barras " + codigoBarras + "=>" + ex.Message);
            }

            return null;
        }

        public IQueryable<CategoriaProduto> GetCategoriaByName(String nomeCategoria)
        {

            if (!String.IsNullOrEmpty(nomeCategoria))
            {
                using (var ctx = new BalcaoContext())
                {
                    return ctx.CategoriaProdutoDao.Where(c => c.NomeCategoriaProduto == nomeCategoria);
                }
            }
            else
                return null;
        }

        public IQueryable<UnidadeMedida> GetUnidadeMedidaByName(String nomeUnidadeMedida)
        {
            if (!String.IsNullOrEmpty(nomeUnidadeMedida))
            {
                using (var ctx = new BalcaoContext())
                {
                    return ctx.UnidadeMedidaDao.Where(u => u.NomeUnidadeMedida == nomeUnidadeMedida);
                }
            }
            else
                return null;
        }

        public decimal SetQuantidadeAtualProduto(int idProduto)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {

                    var prd = ctx.ProdutoDao.Find(idProduto);

                    if (prd.TipoItemProduto == TypeItemProduto.Produto)
                    {
                        var saidas = prd.TransacoesProduto
                            .Where(tra => tra.TipoTransacao == TypeTransacaoProduto.Saida
                                          && tra.IdProduto == prd.IdProduto)
                            .Sum(tr => tr.Quantidade);

                        var entradas = prd.TransacoesProduto
                            .Where(tra => tra.TipoTransacao == TypeTransacaoProduto.Entrada
                                          && tra.IdProduto == prd.IdProduto)
                            .Sum(tr => tr.Quantidade);

                        var vendaCancelada = prd.TransacoesProduto
                            .Where(tra => tra.TipoTransacao == TypeTransacaoProduto.Estorno
                                          && tra.IdProduto == prd.IdProduto)
                            .Sum(tr => tr.Quantidade);

                        prd.QuantidadeProduto = (entradas + vendaCancelada) - saidas;

                        ctx.ProdutoDao.Update(prd);
                    }

                    return prd.QuantidadeProduto;
                }
            }
            catch (Exception)
            {
                return 0M;
            }
        }

        public async Task<List<Produto>> GetProdutosAVenda()
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var produtos = await ctx.Produtos
                                .Include(p => p.CategoriaProduto)
                                .Include(p => p.UnidadeMedida)
                                .Where(p => p.QuantidadeProduto > 0 && p.PrecoVenda > 0)
                                .ToListAsync();
                return produtos;
            }
        }

        public async Task<bool> AjustarEstoque(List<Produto> produtoList, decimal estoque)
        {
            using (var ctx = new BalcaoContext())
            {

                int i = 0;
                int vCount = produtoList.Count;
                foreach (var p in produtoList)
                {
                    var pFind = ctx.ProdutoDao.Find(p.IdProduto);
                    var newQtde = ParseUtil.ToDecimal(estoque);
                    var alteracao = new AlteracaoProduto(p.IdProduto, "E", 0.0m, DateTime.Now,
                        p.PrecoVenda, p.PrecoCompra, p.QuantidadeProduto);
                    pFind.AlteracoesProduto.Add(alteracao);
                    pFind.QuantidadeProduto = GetNewQtdAjustarEstoqueProduto(pFind, newQtde);

                    if (pFind.QuantidadeProduto <= 0)
                        pFind.StatusProduto = TypeStatusProduto.SemEstoque;
                    else
                        pFind.StatusProduto = TypeStatusProduto.Ativo;

                    bool r = await ctx.ProdutoDao.UpdateAsync(pFind);

                    if (r)
                        //passa atualizacao pro objeto do grid
                        p.Update(pFind);

                    i++;
                }

                if (i == vCount)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public decimal GetQuantidadeAtualProduto(int idProduto)
        {
            try
            {
                var ctx = new BalcaoContext();

                var prd = ctx.ProdutoDao.Find(idProduto);

                if (prd.TipoItemProduto == TypeItemProduto.Produto)
                {
                    var saidas = prd.TransacoesProduto
                        .Where(tra => tra.TipoTransacao == TypeTransacaoProduto.Saida
                        && tra.IdProduto == prd.IdProduto).Sum(tr => tr.Quantidade);

                    var entradas = prd.TransacoesProduto
                        .Where(tra => tra.TipoTransacao == TypeTransacaoProduto.Entrada
                        && tra.IdProduto == prd.IdProduto).Sum(tr => tr.Quantidade);

                    var quantidadeProduto = entradas - saidas;
                    return quantidadeProduto;
                }

                return prd.QuantidadeProduto;
            }
            catch (Exception)
            {
                return 0M;
            }
        }

        public Boolean RecalculaEstoqueProduto(Produto p)
        {
            var ctx = new BalcaoContext();
            var idProduto = p.IdProduto;
            List<TransacoesProduto> traList = new List<TransacoesProduto>();
            var entradasitem = ctx.ItemMovimentoDao.FindAll().Where(itmEnt => itmEnt.IdProduto == idProduto);
            var saidasItem = ctx.ItemVendaDao.FindAll().Where(itmSai => itmSai.IdProduto == idProduto);

            //limpar as transacoes antigas, recalcular tudo de novo
            ctx.TransacoesProdutoDao.Delete(tra => tra.IdProduto == idProduto);

            var mergeEntradas = (from items in entradasitem /*Entradas*/
                                                            //where items.IdProduto == idProduto
                                 group items by items.Movimento.DataEmissao.Date into c
                                 select new
                                 {
                                     c.Key.Date,
                                     VlrUnitario = c.Sum(itm => itm.ValorUnitario),
                                     VlrTotal = c.Sum(itm => itm.TotalItem),
                                     Quantidade = c.Sum(itm => itm.Quantidade),
                                 });


            var mergeSaidas = (from items in saidasItem /*Saidas*/
                                                        //where items.IdProduto == idProduto
                               group items by items.Venda.DataVenda.Date into c
                               select new
                               {
                                   c.Key.Date,
                                   VlrUnitario = c.Sum(itm => itm.ValorUnitario),
                                   VlrTotal = c.Sum(itm => itm.TotalItem),
                                   Quantidade = c.Sum(itm => itm.Quantidade) * -1,
                               });

            var saidas = ctx.ItensVendas.Where(it => it.IdProduto == idProduto);
            var i = 0;

            foreach (var produtoEntrada in mergeEntradas)
            {
                var traEnt = new TransacoesProduto(produtoEntrada.Date, TypeTransacaoProduto.Entrada,
                    produtoEntrada.VlrUnitario, produtoEntrada.VlrTotal, produtoEntrada.Quantidade, String.Empty, idProduto, 1);
                traList.Add(traEnt);
            }

            foreach (var produtoSaida in mergeSaidas)
            {
                var traSai = new TransacoesProduto(produtoSaida.Date, TypeTransacaoProduto.Saida,
                    produtoSaida.VlrUnitario, produtoSaida.VlrTotal, produtoSaida.Quantidade, String.Empty, idProduto, 1);
                traList.Add(traSai);
            }

            foreach (var tra in traList)
            {
                ctx.TransacoesProdutoDao.Save(tra);
                i++;
            }

            if (i == traList.Count)
                return true;
            else
                return false;
        }

        public void AddMovimentacaoProduto(Venda venda, bool updateTra = false)
        {
            using (var ctx = new BalcaoContext())
            {
                if (updateTra)
                {
                    ctx.TransacoesProdutoDao.Delete(t => t.IdVenda == venda.IdVenda);
                }

                if (venda != null && venda.TipoMovimento == TypeVenda.Venda)
                {
                    foreach (var item in venda.ItensVendas)
                    {
                        var p = ctx.ProdutoDao.Find(item.IdProduto);
                        if (p.TipoItemProduto == TypeItemProduto.Produto)
                        {
                            var obs = "Venda " + venda.IdVenda; //task 94
                            var localEstoque = venda.LocalEstoque;
                            int idLocalEstoque = localEstoque != null ? idLocalEstoque = localEstoque.IdLocalEstoque : 1;

                            var traSai = new TransacoesProduto(venda.DataVenda.Date, TypeTransacaoProduto.Saida,
                                                item.ValorUnitario, item.TotalItem, item.Quantidade, obs, item.IdProduto, idLocalEstoque, venda.IdVenda);

                            ctx.TransacoesProdutoDao.Save(traSai);
                            SetQuantidadeAtualProduto(item.IdProduto);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Anula a saída originada da venda que está sendo cancelada
        /// </summary>
        /// <param name="venda"></param>
        /// <param name="updateTra"></param>
        public void EstornarMovimentacaoProduto(Venda venda, bool updateTra = false)
        {
            using (var ctx = new BalcaoContext())
            {

                if (updateTra)
                {
                    ctx.TransacoesProdutoDao.Delete(t => t.IdVenda == venda.IdVenda);
                }

                if (venda != null && venda.TipoMovimento == TypeVenda.Venda)
                {
                    foreach (var item in venda.ItensVendas.Where(p=>p.Produto.TipoItemProduto == TypeItemProduto.Produto))
                    {
                        var obsEstorno = "Cancelamento de venda: " + venda.IdVenda;
                        var traSai = new TransacoesProduto(venda.DataVenda.Date, TypeTransacaoProduto.Estorno,
                                            item.ValorUnitario, item.TotalItem, item.Quantidade, obsEstorno, item.IdProduto, 1, venda.IdVenda);

                        ctx.TransacoesProdutoDao.Save(traSai);
                        SetQuantidadeAtualProduto(item.IdProduto);
                    }
                }
            }
        }

        public void AddMovimentacaoProduto(Movimento notaFiscal, int idCapa, bool updateTra = false)
        {
            using (var ctx = new BalcaoContext())
            {
                var notaFiscalCurrent = ctx.MovimentoDao.Find(idCapa);
                if (updateTra)
                {
                    ctx.TransacoesProdutoDao.Delete(t => t.IdMovimento == notaFiscalCurrent.IdMovimento);
                }

                if (notaFiscal != null)
                {
                    var tipoMov = notaFiscal.TipoMovimento == null ? ctx.TipoMovimentoDao.Find(notaFiscal.IdTipoMovimento) : null;
                    if(tipoMov!=null)
                    notaFiscal.TipoMovimento = tipoMov;

                    if (notaFiscal.TipoMovimento != null)
                    {
                        //verifica se o tipo de movimento escolhido movimenta estoque..
                        if (notaFiscal.TipoMovimento.MovimentarEstoque)
                        {
                            foreach (var item in notaFiscalCurrent.ItensMovimento)
                            {
                                //busca o item do banco
                                var current_Item = ctx.ItemMovimentoDao.Find(item.IdItem);
                                var tipo = notaFiscal.DirecaoMovimento == TypeDirecao.Saída ? TypeTransacaoProduto.Saida : TypeTransacaoProduto.Entrada;

                                var obs = "NF " + notaFiscal.NumeroMovimento + " "+ tipo.ToString(); //task 94
                                var traEnt = new TransacoesProduto(notaFiscal.DataEntrada, tipo,
                                              item.ValorUnitario, item.TotalItem, item.Quantidade,
                                              obs, item.IdProduto, notaFiscal.IdLocalEstoque.Value, null, idCapa);

                                ctx.TransacoesProdutoDao.Save(traEnt);
                                SetQuantidadeAtualProduto(item.IdProduto);
                            }
                        }
                    }
                }
            }
        }

        public decimal GetNewQtdAjustarEstoqueProduto(Produto produto, decimal newQtde)
        {
            try
            {
                var estoqueAtual = GetQuantidadeAtualProdutoCache(produto);

                produto.QuantidadeProduto = GetQuantidadeAtualProdutoCache(produto);
                //se houver estoque, retire tudo e mantenha somente a qtd informada na tela para ajuste do estoque
                if (estoqueAtual > 0)
                {
                    var obsAjuste = "Retirada para ajuste de estoque";
                    var traAjuste = new TransacoesProduto(DateTime.Now, TypeTransacaoProduto.Saida,
                                                            0M, 0M, estoqueAtual, obsAjuste,
                                                            produto.IdProduto, 1);

                    //12/01/17, gercy: se o estoque estiver acima de 0, nao preciso fazer uma transacao de entrada.
                    obsAjuste = "Adição para ajustar o estoque";
                    var traAdicao = new TransacoesProduto(DateTime.Now, TypeTransacaoProduto.Entrada,
                                                            0M, 0M, newQtde, obsAjuste,
                                                            produto.IdProduto, 1);

                    produto.TransacoesProduto.Add(traAdicao);

                    //aqui sim eu retiro o estoque atual
                    produto.TransacoesProduto.Add(traAjuste);

                    estoqueAtual = GetQuantidadeAtualProdutoCache(produto);
                    return estoqueAtual;
                }
                //se estoque estiquer negativo, 'zerar' a qtd e adicionar a transacao de entrada para compor a quantidade informada
                else if (estoqueAtual < 0)
                {
                    //zerar primeiro
                    var obsAjuste = "Adição zerar o estoque";
                    var traAjuste = new TransacoesProduto(DateTime.Now, TypeTransacaoProduto.Entrada,
                                                            0M, 0M, estoqueAtual * -1, obsAjuste,
                                                            produto.IdProduto, 1);
                    //somente dps que estiver zerado eu lanco a transacao com a nova quantidade
                    obsAjuste = "Adição para ajustar o estoque";
                    var traAdicao = new TransacoesProduto(DateTime.Now, TypeTransacaoProduto.Entrada,
                                                            0M, 0M, newQtde, obsAjuste,
                                                            produto.IdProduto, 1);

                    produto.TransacoesProduto.Add(traAjuste);
                    produto.TransacoesProduto.Add(traAdicao);
                    estoqueAtual = GetQuantidadeAtualProdutoCache(produto);
                    return estoqueAtual;
                }
                //Se o estoque já estiver como 0, adicione uma nova tra para compor o saldo do prd
                else if (estoqueAtual == 0)
                {
                    var obsAjuste = "Adição para ajuste de estoque";
                    var traAjuste = new TransacoesProduto(DateTime.Now, TypeTransacaoProduto.Entrada,
                                                            0M, 0M, newQtde, obsAjuste,
                                                            produto.IdProduto, 1);
                    produto.TransacoesProduto.Add(traAjuste);
                    estoqueAtual = GetQuantidadeAtualProdutoCache(produto);
                    return estoqueAtual;
                }
                else
                {
                    return 0M;
                }
            }
            catch (Exception)
            {
                return 0M;
            }

        }

        /// <summary>
        /// Obtem a quantidade atual do produto sem consultar o banco, usa o que está no cache.
        /// 
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public decimal GetQuantidadeAtualProdutoCache(Produto produto)
        {
            try
            {
                if (produto.TipoItemProduto == TypeItemProduto.Produto)
                {
                    var saidas = produto.TransacoesProduto
                        .Where(tra => tra.TipoTransacao == TypeTransacaoProduto.Saida
                        && tra.IdProduto == produto.IdProduto).Sum(tr => tr.Quantidade);

                    var entradas = produto.TransacoesProduto
                        .Where(tra => tra.TipoTransacao == TypeTransacaoProduto.Entrada
                        && tra.IdProduto == produto.IdProduto).Sum(tr => tr.Quantidade);

                    var quantidadeProduto = entradas - saidas;
                    return quantidadeProduto;
                }

                return produto.QuantidadeProduto;
            }
            catch (Exception)
            {
                return 0M;
            }
        }

    }
}
