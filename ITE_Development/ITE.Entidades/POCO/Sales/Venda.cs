
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using ITE.Entidades.POCO.Fiscal;

namespace ITE.Entidades.POCO.Sales
{
    //Considere a venda dona do relacionamento
    //Ela q eh chave para poder persistir as parcelas e seus itens
    [Table("Venda")]
    public class Venda
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdVenda { get; set; }

        [Display(Name = "Filial")]
        [Range(1, int.MaxValue, ErrorMessage = "Filial não informada")]
        public int IdFilial { get; set; }

        [Display(Name = "Cliente")]
        [Range(1, int.MaxValue, ErrorMessage = "Cliente não informado")]
        public int IdCliForVenda { get; set; }

        [Display(Name = "Usuário")]
        [Range(1, int.MaxValue, ErrorMessage = "Usuário não informado")]
        public int IdUsuarioVenda { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Forma de pagamento não informada")]
        [Display(Name = "Forma de pagamento")]
        public int IdFormaPagamentoVenda { get; set; }

        public Nullable<int> IdCentroCusto { get; set; }//setado no form inicial da venda

        [ForeignKey("IdCentroCusto")]
        public virtual CentroCusto CentroCusto { get; set; }

        [ForeignKey("IdCliForVenda")]
        public virtual CliFor CliFor { get; set; }

        [ForeignKey("IdUsuarioVenda")]
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("IdFormaPagamentoVenda")]
        public virtual FormaPagamento FormaPagamentoVenda { get; set; }

        [ForeignKey("IdFilial")]
        public virtual EmpresaFilial FilialVenda { get; set; }

        [Required]
        [Display(Name = "Data da Venda"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataVenda { get; set; }

        [Required]
        [Display(Name = "Data de Vencimento"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]

        public DateTime DataVencimento { get; set; }

        [Required]
        [Display(Name = "Total de venda")]
        public decimal TotalVenda { get; set; }

        [Required]
        [Display(Name = "Valor Desconto")]
        public decimal ValorDesconto { get; set; }

        [Display(Name = "Número de Parcelas")]
        //[Range(1, int.MaxValue, ErrorMessage = "Número de parcelas não pode ser 0")]
        public int NumeroParcelas { get; set; }

        [Display(Name = "Observação")]
        [StringLength(300, MinimumLength = 0)]
        [Column(TypeName = "Text")]
        public String Observacao { get; set; }

        [Required]
        [Display(Name = "Desconto %")]
        public decimal Desconto { get; set; }

        [Display(Name = "Número de itens")]
        [Range(1, int.MaxValue, ErrorMessage = "Número de itens não pode ser 0")]
        public int NumeroItens { get; set; }

        [Column("StatusVenda")]
        [Range(0, int.MaxValue, ErrorMessage = "Status da Venda não informado")]
        [Required(ErrorMessage = "Informe o status da venda")]
        [Display(Name = "Status da proposta")]
        public TypeStatusVenda StatusVenda { get; set; }

        [Display(Name = "Tipo Movimento")]
        public TypeVenda TipoMovimento { get; set; }

        [StringLength(45)]
        public string CodigoInterno { get; set; }

        [Required]
        [Display(Name = "Itens de venda")]
        public virtual ICollection<ItemVenda> ItensVendas { get; set; }

        public virtual ICollection<LancamentoFinanceiro> Parcelas { get; set; }

        //Apenas para fazer o relacionamento entre movimento e a venda
        public ICollection<MovimentoCaixa> MovimentosCaixa { get; set; }


        #region Nao mapeado - Utilizado somente para controle interno

        [NotMapped]
        public Image Image
        {
            get
            {
                switch (this.StatusVenda)
                {
                    case TypeStatusVenda.Aberto:
                        return Properties.Resources.status_16x16;

                    case TypeStatusVenda.Vencida:
                        //se nao avise
                        return Properties.Resources.index_16x16;


                    case TypeStatusVenda.Paga:
                        return Properties.Resources.flag_success;

                    case TypeStatusVenda.Cancelada:
                        //se nao avise
                        return Properties.Resources.cancel_16x16;

                    default:
                        //se nao avise
                        return Properties.Resources.about_16x16;
                }
            }
        }

        [NotMapped]
        public decimal ValorRecebido { get; set; }

        [NotMapped]
        public decimal ValorTroco { get; set; }

        [NotMapped]
        public decimal ValorJuros { get; set; }

        [NotMapped]
        public LocalEstoque LocalEstoque { get; set; }
        public ICollection<ComissaoVendaUsuario> Comissoes { get; set; }

        #endregion Nao mapeado - Utilizado somente para controle interno

        public Venda()
        {
            this.Comissoes = new HashSet<ComissaoVendaUsuario>();
            this.ItensVendas = new HashSet<ItemVenda>();
            this.Parcelas = new HashSet<LancamentoFinanceiro>();
            this.NumeroParcelas = 0;
            this.DataVenda = DateTime.Now;
            this.DataVencimento = DateTime.Now;
            this.StatusVenda = TypeStatusVenda.Aberto;
        }

        public Venda(Usuario user, List<ItemVenda> itens)
            : this()
        {
            this.IdUsuarioVenda = user != null ? user.IdUsuario : 0;
            decimal total = 0;
            foreach (var item in itens)
            {
                total += item.TotalItem;
            }
            this.TotalVenda = total - ValorDesconto;
            this.NumeroItens = itens.Count;
            this.ItensVendas = itens;
        }

        public Venda(Usuario user, CliFor cliFor, List<ItemVenda> itens)
            : this(user, itens)
        {
            this.IdCliForVenda = cliFor != null ? cliFor.IdCliFor : 0;
        }

        public Venda Clone()
        {
            return (Venda)this.MemberwiseClone();
        }

        public Venda(int idVenda, CliFor cliFor, decimal totalVenda, TypeStatusVenda statusVenda, DateTime dataVenda)
        {
            this.IdVenda = idVenda;
            this.CliFor = cliFor;
            this.TotalVenda = totalVenda;
            this.StatusVenda = statusVenda;
            this.DataVenda = dataVenda;
        }

        public void AddItensVenda(List<ItemVenda> itensVenda)
        {
            foreach (ItemVenda item in itensVenda)
            {
                this.ItensVendas.Add(item);
            }
            this.NumeroItens = itensVenda.Count;
        }

        /// <summary>
        /// Add as parcela referente a forma de pagamento informada
        /// </summary>
        /// <param name="parcelamento"></param>
        public void AddParcelas(List<LancamentoFinanceiro> parcelamento)
        {
            this.NumeroParcelas = parcelamento.Count;

            foreach (var parcela in parcelamento)
            {
                this.Parcelas.Add(parcela);
            }
        }

        /// <summary>
        /// Usa o total atual da venda
        /// </summary>
        /// <returns></returns>
        public decimal AtualizaTotalVenda()
        {
            return (TotalVenda - ValorDesconto);
        }

        public decimal CalculaTotalVenda(decimal totalVenda, decimal vlrDesconto)
        {

            return (totalVenda - vlrDesconto);
        }

        public decimal CalculaTotalVenda(decimal totalVenda, decimal vlrJuros, decimal vlrDesconto)
        {

            return (totalVenda + vlrJuros) - vlrDesconto;
        }

        /// <summary>
        /// Retorna o total de juros em cada parcela
        /// </summary>
        public decimal CalculaJurosVenda(decimal totalVenda, decimal juros , List<LancamentoFinanceiro> parcelas)
        {
            decimal total = 0;
            this.ValorJuros = totalVenda * (juros / 100);
            foreach (var p in parcelas)
            {
                p.ValorJuros = this.ValorJuros;
                total += this.ValorJuros;
            }
            return total ;
        }

        /// <summary>
        /// Calcula a porcentagem(%) do desconto
        /// </summary>
        /// <param name="totalVenda"></param>Valor da venda
        /// <param name="valorDesconto"></param>Valor do desconto em reais R$
        /// <returns></returns>Valor da porcentamge de desconto
        public decimal CalculaDesconto(decimal totalVenda, decimal valorDesconto)
        {
            if (valorDesconto == 0) return 0;
            //regra de 3
            //totalVenda    ========== 100%
            //valorDesconto ==========  x
            var desconto = (valorDesconto * 100) / totalVenda;

            return desconto;
        }

        /// <summary>
        /// Calcula o valor do desconto em reais R$
        /// </summary>
        /// <param name="totalVenda"></param>Total da venda
        /// <param name="desconto"></param>Valor do desconto em porcentagem %
        /// <returns></returns>
        public decimal CalculaValorDesconto(decimal totalVenda, decimal desconto)
        {
            return (totalVenda * desconto) / 100;
        }

        public decimal CalculaValorParcela(decimal totalVenda, int numeroParcelas)
        {
            if (numeroParcelas > 1)
            {
                return (totalVenda / numeroParcelas);
            }
            return totalVenda;
        }

        /// <summary>
        /// Atualiza os dados da venda        
        /// </summary>
        /// <param name="venda"></param>
        public void Update(Venda venda, bool updateAll=false)
        {
            this.IdCliForVenda = venda.IdCliForVenda;

            //usuario da venda eh o primeiro q fizer a venda
            //isso garante que a comissao nao seja desviada caso alguem altere a venda
            //a pedido
            //this.IdUsuarioVenda = venda.IdUsuarioVenda;

            this.IdCentroCusto = venda.IdCentroCusto;
            this.IdFormaPagamentoVenda = venda.IdFormaPagamentoVenda;
            this.IdFilial = venda.IdFilial;

            this.DataVenda = venda.DataVenda;
            this.DataVencimento = venda.DataVencimento;

            this.NumeroParcelas = venda.NumeroParcelas;
            this.Observacao = venda.Observacao;
            this.ValorDesconto = venda.ValorDesconto;
            this.Observacao = venda.Observacao;
            this.TotalVenda = venda.TotalVenda;
            this.TipoMovimento = venda.TipoMovimento;
            this.StatusVenda = venda.StatusVenda;
            this.NumeroItens = venda.NumeroItens;

            if (updateAll)
            {
                this.CliFor = venda.CliFor;
                this.CentroCusto = venda.CentroCusto;
                this.Parcelas = venda.Parcelas;
                this.FilialVenda = venda.FilialVenda;
                this.FormaPagamentoVenda = venda.FormaPagamentoVenda;
            }
        }

        public void ValidarStatus()
        {
            if (this.StatusVenda != TypeStatusVenda.Paga
                && this.StatusVenda != TypeStatusVenda.Cancelada)
            {
                this.StatusVenda = this.DataVencimento <= DateTime.Now
                    ? TypeStatusVenda.Vencida
                    : TypeStatusVenda.Aberto;

            }
        }

        public override string ToString()
        {
            return IdVenda + " | " + TotalVenda;
        }

    }
}
