using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Sales
{
    [Serializable]
    [Table("TransacoesProduto")]
    public class TransacoesProduto
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRegistro { get; set; }
        public DateTime DataTransacao { get; set; }
        public TypeTransacaoProduto TipoTransacao { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Quantidade { get; set; }
        public string Observacao { get; set; }
        public int IdProduto { get; set; }
        [ForeignKey("IdProduto")]
        public virtual Produto Produto { get; set; }

        public int? IdMovimento { get; set; }

        public int? IdVenda { get; set; }

        public int? IdUsuario { get; set; }

        public int IdLocalEstoque { get; set; }

        [ForeignKey("IdLocalEstoque")]
        public virtual LocalEstoque LocalEstoque { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario{ get; set; }

        [ForeignKey("IdMovimento")]
        public virtual Movimento Movimento { get; set; }

        [ForeignKey("IdVenda")]
        public virtual Venda Venda { get; set; }



        public TransacoesProduto()
        {
        }

        public TransacoesProduto(DateTime dataTransacao, TypeTransacaoProduto tipoTransacao, Decimal valorUnitario,
            Decimal valorTotal, Decimal quantidade, string observacao, int idProduto, int idLocalEstoque, int? idVenda = null, int? idMovimento = null)
        {
            this.DataTransacao = dataTransacao;
            this.TipoTransacao = tipoTransacao;
            this.ValorUnitario = valorUnitario;
            this.ValorTotal = valorTotal;
            this.Quantidade = quantidade;
            this.Observacao = observacao;
            this.IdProduto = idProduto;
            this.IdLocalEstoque = idLocalEstoque;
            this.IdVenda = idVenda;
            this.IdMovimento = idMovimento;
        }

    }
}
