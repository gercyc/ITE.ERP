using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Sales;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ITE.Entidades.POCO.Financeiro
{
    /// <summary>
    /// Movimento de caixa das vendas
    /// </summary>
    [Table("MovimentoCaixa")]
    public class MovimentoCaixa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMovimento { get; set; }

        [Column("IdVenda")]
        [Display(Name = "Nº Venda")]
        public int? IdVenda { get; set; }

        [ForeignKey("IdVenda")]
        public virtual Venda Venda { get; set; }

        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }


        [Range(1, double.MaxValue, ErrorMessage = "Valor do lançamento não menor ou igual 0")]
        [Display(Name = "Valor Movimento")]
        public decimal ValorMovimento { get; set; }

        //Tipo deve ser Crédito ou Débito
        [Display(Name = "Espécie")]
        public TypeMovimentacaoMonetaria TipoMov { get; set; }

        [Display(Name = "Data Movimento")]
        public DateTime DataMovimento { get; set; }

        [Required]
        [StringLength(500)]
        [Display(Name = "Histórico de Movimento")]
        public string HistoricoMov { get; set; }
        /// <summary>
        /// Nao mapeado
        /// </summary>
        [NotMapped]
        public decimal Saldo { get; set; }


        public Image Image
        {
            get
            {
                switch (this.TipoMov)
                {
                    case TypeMovimentacaoMonetaria.Credito:
                        return Properties.Resources.caixa_Credito;

                    case TypeMovimentacaoMonetaria.Debito:
                        return Properties.Resources.caixa_Debito;

                    case TypeMovimentacaoMonetaria.Estorno:
                        return Properties.Resources.caixa_Debito;

                    default:
                        return null;
                }
            }
        }

        public MovimentoCaixa()
        {

        }
        /// <summary>
        /// Movimento de caixa quando realizar uma venda
        /// </summary>
        /// <param name="venda"></param>
        public MovimentoCaixa(Venda venda, TypeMovimentacaoMonetaria tipoMov, string historicoMovimento)
        {
            this.IdVenda = venda.IdVenda;
            this.IdUsuario = venda.IdUsuarioVenda;
            this.TipoMov = tipoMov;
            this.ValorMovimento = venda.TotalVenda-venda.ValorDesconto;
            this.DataMovimento = DateTime.Now;
            this.HistoricoMov = historicoMovimento;
        }
 
        public MovimentoCaixa(decimal valorMov, string historico)
        {
            this.ValorMovimento = valorMov;
            this.HistoricoMov = historico;
        }

    }
}
