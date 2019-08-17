using ITE.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Sales
{
    [Serializable]
    [Table("FormaPagamento")]
    public class FormaPagamento
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdFormaPagamento { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        [Display(Name = "Forma de pagamento")]
        [Index(IsUnique = true)]//Restrição UNIQUE
        public string NomeFormaPagamento { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        [Range(1, int.MaxValue, ErrorMessage = "Classificação do pagamento não informado")]
        public TypeFormaPagamento TipoFormaPagamento { get; set; }

        [Required(ErrorMessage = "Quantidade de parcela não informado")]
        [Display(Name = "Quantidade de parcelas")]
        public int NumeroParcelas { get; set; }

        //removido virtual 
        public ICollection<Venda> Vendas { get; set; }

        public FormaPagamento()
        {
            this.Vendas = new HashSet<Venda>();
        }

        public FormaPagamento(string descricao, TypeFormaPagamento tipo, int numeroParcelas)
        {
            this.NomeFormaPagamento = descricao;
            this.TipoFormaPagamento = tipo;
            this.NumeroParcelas = numeroParcelas;
        }

        public override string ToString()
        {
            return NomeFormaPagamento;
        }

        public void Update(FormaPagamento frmPagto)
        {
            this.TipoFormaPagamento = frmPagto.TipoFormaPagamento;
            this.NumeroParcelas = frmPagto.NumeroParcelas;
            this.NomeFormaPagamento = frmPagto.NomeFormaPagamento;
        }

    }
}
