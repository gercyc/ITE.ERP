using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.DaoManager.VendasDaoManager
{
    public class TransacoesProdutoManager
    {

        public void AddTransacao(Produto current, TypeTransacaoProduto type, decimal estoque)
        {
            if (type == TypeTransacaoProduto.Saida)
            {
                var traAjuste = new TransacoesProduto(DateTime.Now, TypeTransacaoProduto.Saida,
                                                        0M, 0M, estoque, "Retirada para ajuste de estoque",
                                                         current.IdProduto, 1);
                current.TransacoesProduto.Add(traAjuste);
            }
            else if (type == TypeTransacaoProduto.Entrada)
            {
                var traAdicao = new TransacoesProduto(DateTime.Now, TypeTransacaoProduto.Entrada,
                                                        0M, 0M, estoque,
                                                        "Adição para ajustar o estoque",
                                                        current.IdProduto, 1);

                current.TransacoesProduto.Add(traAdicao);

            }

            else if (type == TypeTransacaoProduto.Alteracao)
            {
                    if (current.QuantidadeProduto > 0)
                {
                    var traAjuste = new TransacoesProduto(DateTime.Now, TypeTransacaoProduto.Alteracao,
                                                            0M, 0M, estoque,
                                                            "Zeragem de estoque",
                                                            current.IdProduto, 1);
                    current.TransacoesProduto.Add(traAjuste);
                }
            }
          
        }
    }
}
