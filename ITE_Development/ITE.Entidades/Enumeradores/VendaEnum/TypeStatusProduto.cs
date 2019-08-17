using System.ComponentModel;

namespace ITE.Entidades.Enumeradores
{
    /// <summary>
    /// Enumerador para o Produto e a Venda
    /// </summary>
    public enum TypeStatusProduto
    {

        [Description("Ativo")]
        Ativo = 0,
        [Description("Inativo")]
        Invativo = 1,
        [Description("Sem Estoque")]
        SemEstoque = 2,


    }
}
