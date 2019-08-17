using System.ComponentModel;

namespace ITE.Entidades.Enumeradores.TipoMovimentoEnum
{
    public enum TypeCategoriaTipoMovimento
    {
        /*Setor de compras -> cria um orçamento/cotação para comprar produtos para a empresa*/
        [Description("Cotação")]
        Cotacao = 1,

        /*Setor de compras efetiva uma cotação (compra o item)        
        então, a cotaçao é convertida -> Cria pedido de compra ou venda*/
        [Description("Pedido de compra")]
        PedidoCompra = 2,
        [Description("Pedido de venda")]
        PedidoVenda = 3,

        /*Setor de compras/vendas recebe/envia a mercadoria
        é gerada a nota fiscal e o faturamento/financeiro, criando os lançamentos a pagar ou a receber-> */
        [Description("Nota fiscal de mercadorias")]
        NotaFiscalMercadorias = 4,
        [Description("Nota fiscal de serviço")]
        NotaFiscalServico = 5,
        [Description("Nota fiscal conjugada")]
        NotaFiscalConjugada = 6,
        [Description("Nota fiscal de exportação")]
        NotaFiscalExportacao = 7,
        [Description("Nota fiscal de importação")]
        NotaFiscalImportacao = 8,

        /*Criaçao de movimento simples para movimentar o estoque de produtos */
        [Description("Movimentação de estoque")]
        MovimentoEstoque = 9,

        /*Outras movimentacoes sem regras especificas*/
        [Description("Outras saídas não fiscal")]
        SimplesFaturamento = 10,
        [Description("Outras entradas não fiscal")]
        SimplesEntradas = 11,
        [Description("Transferência entre locais de estoque")]
        Transferencia = 12
    }
}
