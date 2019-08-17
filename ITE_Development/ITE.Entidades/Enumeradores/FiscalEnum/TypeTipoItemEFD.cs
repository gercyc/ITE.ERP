using System.ComponentModel;

namespace ITE.Entitidades.Enumeradores.FiscalEnum
{
    public enum TypeTipoItemEFD
    {
        [Description("Tipo de mercadoria não informado")] None = -1,
        [Description("00 – Mercadoria para Revenda")] MercadoriaparaRevenda = 0,
        [Description("01 – Matéria-Prima")] MateriaPrima = 1,
        [Description("02 – Embalagem")] Embalagem = 2,
        [Description("03 – Produto em Processo")] ProdutoemProcesso = 3,
        [Description("04 – Produto Acabado")] ProdutoAcabado = 4,
        [Description("05 – Subproduto")] Subproduto = 5,
        [Description("06 – Produto Intermediário")] ProdutoIntermediario = 6,
        [Description("07 – Material de Uso e Consumo")] MaterialdeUsoeConsumo = 7,
        [Description("08 – Ativo Imobilizado")] AtivoImobilizado = 8,
        [Description("09 – Serviços")] Servicos = 9,
        [Description("10 – Outros insumos")] Outrosinsumos = 10,
        [Description("99 – Outras")] Outras = 99,


    }
}
