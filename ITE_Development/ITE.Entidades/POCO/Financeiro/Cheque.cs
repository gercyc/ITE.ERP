using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Enumeradores.BorderoEnum;
using ITSolution.Framework.Util;

namespace ITE.Entidades.POCO.Bordero
{
    //Essa classe sera somente para calculo em tempo de execucação
    //Essa classe sera unificada com o ExtratoBancario

    [Table("Cheque")]
    public class Cheque
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdCheque { get; set; }

        [StringLength(45)]
        [Column]
        [Display(Name = "Número Cheque")]
        public string NumeroCheque { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Abertura")]
        [Column]
        public DateTime DataLancamento { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Vencimento")]
        [Column(TypeName = "Date")]
        public DateTime DataVencimento { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Column(TypeName = "Date")]
        public DateTime? DataCompensacao { get; set; }

        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public virtual CliFor Cliente { get; set; }

        [Column]
        public int Prazo { get; set; }

        [Column]
        public int Compensacao { get; set; }

        [NotMapped]
        public int PrazoTotal { get; set; }

        [Display(Name = "Taxa Juros %")]
        [Range(1, double.MaxValue, ErrorMessage = "Valor do juros deve ser no minímo 1%.")]
        [Column]
        public decimal TaxaJuros { get; set; }

        [Display(Name = "Valor Líquido")]
        [Column]
        public decimal ValorLiquido { get; set; }

        [Column]
        [Display(Name = "Valor Juros")]
        public decimal ValorJuros { get; set; }

        [Column]
        [Display(Name = "Valor Lançamento")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Valor do cheque não pode ser zero.")]
        public decimal ValorCheque { get; set; }

        [Column]
        [Required]
        [Display(Name = "Tipo Lançamento")]
        public TypeLancamentoFinanceiro TipoLancamento { get; set; }

        [Display(Name = "Observação")]
        [StringLength(300, MinimumLength = 0)]
        [Column(TypeName = "Text")]
        public String Observacao { get; set; }

        [Column]
        [Required]
        [Display(Name = "Situação Cheque")]
        public TypeSituacaoCheque Situacao { get; set; }

        [NotMapped]
        public int Sequencial { get; set; }

        #region Nao mapeado - Utilizado somente para controle interno
        [NotMapped]
        public Image Image
        {
            get
            {

                switch (this.Situacao)
                {
                    case TypeSituacaoCheque.Aberto:
                        return Properties.Resources.status_16x16;

                    case TypeSituacaoCheque.Vencido:
                        return Properties.Resources.index_16x16;

                    case TypeSituacaoCheque.Compensado:
                        return Properties.Resources.flag_success;

                    case TypeSituacaoCheque.Cancelado:
                        return Properties.Resources.cancel_16x16;

                    default:
                        return null;
                }
            }
        }

        [NotMapped]
        public Image ImageNatureza
        {
            get
            {
                switch (this.TipoLancamento)
                {
                    case TypeLancamentoFinanceiro.Pagar:
                        return Properties.Resources.caixa_Debito;

                    case TypeLancamentoFinanceiro.Receber:
                        return Properties.Resources.caixa_Credito;

                    default:
                        return null;
                }
            }
        }


        /// <summary>
        ///Valor do lançamento mais juros
        /// </summary>
        [NotMapped]
        public decimal TotalLancamento
        {
            get
            {
                return this.ValorCheque + this.ValorJuros;
            }
        }

        /*
        public Decimal TotalAberto { get; set; }
        public Decimal TotalJuros { get; set; }
        public Decimal TotalRecebido { get; set; }*/

        #endregion Nao mapeado - Utilizado somente para controle interno

        public Cheque()
        {
        }
       
        /// <summary>
        /// Calcula o cheque no construtor 
        /// </summary>
        /// <param name="cc"></param>
        /// <param name="dataLan"></param>
        /// <param name="dataVenc"></param>
        /// <param name="valor"></param>
        /// <param name="prazo"></param>
        /// <param name="comp"></param>
        /// <param name="taxaJuros"></param>
        /// <param name="numCh"></param>
        /// <param name="obs"></param>
        /// <param name="tipo"></param>
        public Cheque(CliFor cc, DateTime dataLan, DateTime dataVenc, decimal valor, int prazo, int comp, decimal taxaJuros,
            string numCh, string obs, TypeLancamentoFinanceiro tipo)
        {

            this.DataLancamento = dataLan;
            this.DataVencimento = dataVenc;

            this.ValorCheque = valor;
            this.NumeroCheque = numCh;
            this.Observacao = obs;
            this.TaxaJuros = taxaJuros;
            this.Prazo = prazo;
            this.Compensacao = comp;

            this.PrazoTotal = prazo + comp;
            this.ValorJuros = CalcularJuros(ValorCheque, TaxaJuros, PrazoTotal);
            this.ValorLiquido = this.ValorCheque - this.ValorJuros;

            this.TipoLancamento = tipo;

            this.IdCliente = cc.IdCliFor;

            if (this.DataVencimento <= DateTime.Now)
                this.Situacao = TypeSituacaoCheque.Vencido;
            else
                this.Situacao = TypeSituacaoCheque.Aberto;
        }

        public decimal CalcularJuros(decimal valorCheque, decimal taxaJuros, int prazo)
        {
            //taxaJuros / 100
            taxaJuros = taxaJuros / 100;

            //valorCheque * taxaJuros
            valorCheque = valorCheque * taxaJuros;

            //valorCheque / 30
            valorCheque = valorCheque / 30;

            //valorCheque * prazo 
            valorCheque = valorCheque * Prazo;


            return ParseUtil.ToDecimal(valorCheque, 2);
        }

        public static void CalcularCheque(Cheque cheque)
        {

            //setando prazo total para calculo dos valorJuros
            cheque.Prazo = cheque.Prazo;
            cheque.PrazoTotal = cheque.Prazo + cheque.Compensacao;

            //fazendo os calculos dos valores da estrutura
            cheque.ValorJuros = cheque.CalcularJuros(cheque.ValorCheque, cheque.TaxaJuros, cheque.PrazoTotal);

            //seta o valor liquido
            cheque.ValorLiquido = cheque.ValorCheque - cheque.ValorJuros;

        }

        private static decimal TotalPorTipo(List<Cheque> cheques, TypeLancamentoFinanceiro tipo)
        {
            cheques = cheques.Where(ch => ch.TipoLancamento == tipo).ToList();
            var result = cheques.Sum(ch => ch.ValorCheque);

            return result;
        }

        public static decimal CreditoSum(List<Cheque> cheques)
        {
            return TotalPorTipo(cheques, TypeLancamentoFinanceiro.Receber);
        }

        public static decimal DebitoSum(List<Cheque> cheques)
        {
            return TotalPorTipo(cheques, TypeLancamentoFinanceiro.Pagar);
        }

        public override string ToString()
        {
            return IdCheque + " | " + ValorCheque;
        }
    }
}
