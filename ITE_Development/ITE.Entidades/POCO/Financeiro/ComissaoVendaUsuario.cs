using ITE.Entidades.POCO.Sales;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using ITE.Entidades.Enumeradores.FinanceiroEnum;
using ITE.Entidades.Enumeradores;

namespace ITE.Entidades.POCO.Financeiro
{
    /*Essa classe utiliza chave primaria composta*/
    [Table("ComissaoVendaUsuario")]
    public class ComissaoVendaUsuario
    {
        [Display(Name = "ID Comissão")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdComissaoVenda { get; set; }

        [Column("IdVenda")]
        [Display(Name = "Nº Venda")]
        [Range(1, int.MaxValue, ErrorMessage = "Venda não informada")]
        public int IdVenda { get; set; }

        [Required]
        [Display(Name = "Valor Faturado")]
        public decimal ValorFaturado { get; set; }


        [Required]
        [Display(Name = "Comissão R$")]
        public decimal ValorComissao { get; set; }

        [Required]
        [Display(Name = "Comissão %")]
        public decimal PorcentagemComissao { get; set; }


        [Display(Name = "Situação")]
        public TypeStatusComissaoVenda StatusComissao { get; set; }


        [ForeignKey("IdVenda")]
        public virtual Venda Venda { get; set; }

        private Image _image;
        [NotMapped]
        public Image Image
        {
            get
            {
                switch (this.StatusComissao)
                {
                    case TypeStatusComissaoVenda.Pendente:
                        return Properties.Resources.status_16x16;

                    case TypeStatusComissaoVenda.Faturado:
                        return  Properties.Resources.apply_16x16;

                    default:
                        return Properties.Resources.cancel_16x16;
                }
            }
            set
            {
                this._image = value;
                
            }
        }


        public ICollection<LancamentoFinanceiro> Lancamentos { get; set; }

        public ComissaoVendaUsuario()
        {
            this.StatusComissao = TypeStatusComissaoVenda.Pendente;
            this.Lancamentos = new HashSet<LancamentoFinanceiro>();

        }

        /// <summary>
        /// Gerar a comissão de venda a partir da venda
        /// </summary>
        /// <param name="venda"></param>
        public ComissaoVendaUsuario(Venda venda) : this()
        {
            this.IdVenda = venda.IdVenda;
            this.StatusComissao = TypeStatusComissaoVenda.Faturado;
            //comissão do usuário
            this.PorcentagemComissao = venda.Usuario.PorcentagemComissao;
            this.ValorFaturado = venda.TotalVenda;
            this.CalculaComissao();
        }

        /// <summary>
        /// Gerar a comissão de venda a partir do lançamento
        /// </summary>
        /// <param name="venda"></param>
        /// <param name="lancamento">Lançamento valor faturado</param>
        /// <param name="user">Vendedor</param>
        public ComissaoVendaUsuario(Venda venda, LancamentoFinanceiro lancamento, Usuario user) : this()
        {
            this.IdVenda = venda.IdVenda;
            //histórico
            lancamento.Observacao = "COMISSÂO VENDA Nº: " + lancamento.IdVenda;
            lancamento.TipoLancamento = TypeLancamentoFinanceiro.Pagar;
            //comissão do usuário
            this.PorcentagemComissao = user.PorcentagemComissao;
            this.ValorFaturado = lancamento.ValorLancamento;

            this.CalculaComissao();

            if (lancamento.IdVenda != null)
                this.IdVenda = lancamento.IdVenda.Value;
        }
        /// <summary>
        /// Calcula o valor da comissao
        /// </summary>
        public void CalculaComissao()
        {
            this.ValorComissao = this.ValorFaturado * (this.PorcentagemComissao / 100);
        }

        public void Update(ComissaoVendaUsuario comissao)
        {
            this.IdVenda = comissao.IdVenda;
            this.PorcentagemComissao = comissao.PorcentagemComissao;
            this.ValorFaturado = comissao.ValorFaturado;
            this.StatusComissao = comissao.StatusComissao;
            this.CalculaComissao();
        }
        public void FaturarComissao()
        {
            this.StatusComissao = TypeStatusComissaoVenda.Faturado;
        }
        public void FaturarComissao(Venda venda, LancamentoFinanceiro lancamento)
        {
            this.IdVenda = venda.IdVenda;
            this.PorcentagemComissao = venda.Usuario.PorcentagemComissao;
            this.ValorFaturado = lancamento.ValorLancamento;
            this.StatusComissao = TypeStatusComissaoVenda.Faturado;
            this.CalculaComissao();

            //comissao eh sempre a pagar
            lancamento.TipoLancamento = TypeLancamentoFinanceiro.Pagar;
                //comissao integral
            lancamento.ValorLancamento = this.ValorComissao;
                //histórico
            lancamento.Observacao = "COMISSÂO VENDA Nº: " + venda.IdVenda;
             
            //cria a fatura
            this.Lancamentos.Add(lancamento);
        }
    }
}
