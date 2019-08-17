using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.POCO.TI;
using ITE.Entidades.Enumeradores;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Financeiro.POCO;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;
using System.Linq;
using ITE.Entidades.Enumeradores.FinanceiroEnum;
using ITE.Entidades.POCO.CE;
using ITSolution.Framework.Entities.POCO;

namespace ITE.Entidades.POCO.Financeiro
{
    [Serializable]
    [Table("LancamentoFinanceiro")]
    public class LancamentoFinanceiro
    {

        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdLancamento { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DataLancamento { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Valor do lançamento deve ser maior que 1")]
        [Display(Name = "Valor do Lançamento")]
        public decimal ValorLancamento { get; set; }

        public decimal ValorJuros { get; set; }

        [Required]
        [Display(Name = "Data da Vencimento")]
        public DateTime DataVencimento { get; set; }

        public DateTime? DataPagamento { get; set; }

        [StringLength(150)]
        public string MotivoCancelamento { get; set; }

        public DateTime? DataCancelamento { get; set; }


        [Required]
        [Display(Name = "Prazo em dias da parcela")]
        public int DiasPrazo { get; set; }

        [Column(TypeName = "Text")]
        public String Observacao { get; set; }

        public int SequencialParcela { get; set; }

        [Display(Name = "Status do Lançamento Financeiro")]
        public TypeStatusLancamentoFinanceiro StatusLancamento { get; set; }

        [Display(Name = "Tipo do Lançamento Financeiro")]
        public TypeLancamentoFinanceiro TipoLancamento { get; set; }

        public int QuantidadeAnexos { get; set; }
        public Nullable<int> IdContrato { get; set; }
        [ForeignKey("IdContrato")]
        public virtual ItsContrato Contrato { get; set; }

        [Display(Name = "Comprovante de pagamento do Pagamento")]
        public virtual ICollection<AnexoLancamento> Anexos { get; set; }

        //removido virtual nao sera carregado
        public virtual ICollection<Baixa> Baixas { get; set; }

        public virtual ICollection<ExtratoBancario> Extratos { get; set; }

        #region Chaves estrangeiras
        //Atribuindo a propriedade das chaves
        //O atributo ForeignKey indica qual propriedade na classe 
        //representa cc campo que corresponde à chave estrangeira entre as tabelas. 
        //Note que no exemplo abaixo cc atributo ForeignKey está acima da propriedade que representa 
        //a navegação entre as duas entidades.

        public Nullable<int> IdVenda { get; set; }

        [ForeignKey("IdVenda")]
        public virtual Venda Venda { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Cliente não foi informado")]
        public int IdCliFor { get; set; }

        [ForeignKey("IdCliFor")]
        public virtual CliFor CliFor { get; set; }

        //Chaves estrangeiras
        [Display(Name = "Centro de custo")]
        [ForeignKey("IdCentroCusto")]
        public virtual CentroCusto CentroCusto { get; set; }

        [Display(Name = "Centro de custo")]
        [Range(1, int.MaxValue, ErrorMessage = "Centro de custo não foi informado")]
        public Nullable<int> IdCentroCusto { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "Filial não foi informada")]
        public int IdFilial { get; set; }

        [ForeignKey("IdFilial")]
        public virtual EmpresaFilial Filial { get; set; }

        public Nullable<int> IdFormaPagamento { get; set; }

        [ForeignKey("IdFormaPagamento ")]
        public virtual FormaPagamento FormaPagamento { get; set; }

        public Nullable<int> IdNotaFiscal { get; set; }

        [ForeignKey("IdNotaFiscal")]
        public virtual Movimento NotaFiscal { get; set; }

        public Nullable<int> IdComissaoVenda { get; set; }

        [ForeignKey("IdComissaoVenda")]
        public virtual ComissaoVendaUsuario ComissaoVendaUsuario { get; set; }

        #region Rastreamento


        [Display(Name = "Usuário")]
        [Range(1, int.MaxValue, ErrorMessage = "Usuário do lançamento não foi informado")]
        public int RecCreatedBy { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("RecCreatedBy")]
        public virtual Usuario UsuarioRecCreatedBy { get; set; }

        //Usuario que alterou o lançamento
        public Nullable<int> RecModifyBy { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("RecModifyBy")]
        public virtual Usuario UsuarioRecModifyBy { get; set; }

        //data da alteração do lançamento
        public Nullable<DateTime> RecCreatedDate { get; set; }

        public Nullable<DateTime> RecModifyDate { get; set; }

        #endregion 

        #endregion Chaves estrangeiras


        #region Nao mapeado - Utilizado somente para controle interno
        [NotMapped]
        public Image Image
        {
            get
            {

                switch (this.StatusLancamento)
                {
                    case TypeStatusLancamentoFinanceiro.Aberto:
                        return Properties.Resources.status_16x16;

                    case TypeStatusLancamentoFinanceiro.Vencido:
                        return Properties.Resources.index_16x16;

                    case TypeStatusLancamentoFinanceiro.Pago:
                        return Properties.Resources.flag_success;

                    case TypeStatusLancamentoFinanceiro.Cancelado:
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

        [NotMapped]
        public Image AttachmentIco
        {
            get
            {
                //se tem anexos coloca icone
                if (this.QuantidadeAnexos > 0)
                    return Properties.Resources.attachment_16x16;

                return Properties.Resources.blank;
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
                return this.ValorLancamento + this.ValorJuros;
            }
        }


        /*
        public Decimal TotalAberto { get; set; }
        public Decimal TotalJuros { get; set; }
        public Decimal TotalRecebido { get; set; }*/

        #endregion Nao mapeado - Utilizado somente para controle interno

        public LancamentoFinanceiro()
        {
            this.RecCreatedDate = DateTime.Now;
            this.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;
            this.DataLancamento = DateTime.Now;
            this.Baixas = new HashSet<Baixa>();
            this.Extratos = new HashSet<ExtratoBancario>();
            this.Anexos = new HashSet<AnexoLancamento>();
            this.DiasPrazo = 1;
        }

        public LancamentoFinanceiro(Manutencao m) : this()
        {
            //this.RecCreatedBy; //a fazer
            this.IdCentroCusto = m.IdCentroCusto;
            this.IdFilial = m.IdFilial;
            this.IdCliFor = m.Atendimento.IdCliente;

            this.DataLancamento = DateTime.Now;
            this.DataVencimento = DateTime.Now;
            this.ValorLancamento = m.ValorManutencao;
            this.ValorJuros = 0;
            this.DiasPrazo = 0;
            this.SequencialParcela = 1;

            this.TipoLancamento = TypeLancamentoFinanceiro.Receber;

            this.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;

            if (m.StatusManutencao == TypeStatusManutencao.Encerrado)
            {
                this.StatusLancamento = TypeStatusLancamentoFinanceiro.Pago;
                this.DataPagamento = DateTime.Now;

            }
            this.QuantidadeAnexos = this.Anexos.Count;
            this.Observacao = "Manutenção Nº " + m.IdManutencao;

        }


        /// <summary>
        /// Cria uma lançamento a partir da venda
        /// </summary>
        /// <param name="venda"></param>
        public LancamentoFinanceiro(Venda venda) : this()
        {
            this.RecCreatedBy = venda.IdUsuarioVenda;
            this.RecCreatedDate = DateTime.Now;

            this.IdCentroCusto = venda.IdCentroCusto;
            this.IdFilial = venda.IdFilial;
            this.IdCliFor = venda.IdCliForVenda;
            this.DiasPrazo = 0;
            this.ValorJuros = 0;
            this.SequencialParcela = 1;
            this.DataLancamento = venda.DataVenda;
            this.ValorLancamento = venda.TotalVenda;
            this.DataVencimento = venda.DataVencimento;
            this.DataPagamento = DateTime.Now;
            this.CliFor = venda.CliFor;
            venda.NumeroParcelas = 1;
            this.DataPagamento = DateTime.Now;
            this.TipoLancamento = TypeLancamentoFinanceiro.Receber;
            this.StatusLancamento = TypeStatusLancamentoFinanceiro.Pago;
        }


        public LancamentoFinanceiro(Movimento notaFiscal) : this()
        {
            this.RecCreatedBy = notaFiscal.IdUsuario;
            this.RecCreatedDate = DateTime.Now;
            this.IdCentroCusto = notaFiscal.IdCentroCusto;
            this.IdFilial = notaFiscal.IdFilial;
            this.IdCliFor = notaFiscal.IdCliFor.Value;
            this.DataLancamento = notaFiscal.DataEmissao;

            if (notaFiscal.DirecaoMovimento == TypeDirecao.Saída) //nota de saída
                this.TipoLancamento = TypeLancamentoFinanceiro.Receber;
            else                         //nota de entrada
                this.TipoLancamento = TypeLancamentoFinanceiro.Pagar;

        }

        //parcela criada na venda
        public LancamentoFinanceiro(Venda venda, Decimal valorParcela, DateTime dtParcela, DateTime dtVencimento, int seqParcela,
            TypeStatusLancamentoFinanceiro status) : this()

        {
            this.IdCliFor = venda.IdCliForVenda;
            this.IdFilial = venda.IdFilial;
            this.IdCentroCusto = venda.IdCentroCusto;
            this.ValorLancamento = valorParcela;
            this.ValorJuros = 0;
            this.DataLancamento = venda.DataVenda;
            this.DataVencimento = dtVencimento;
            this.DiasPrazo = DataUtil.CalcularDias(dtParcela, dtVencimento);
            this.SequencialParcela = seqParcela;
            this.StatusLancamento = status;

            if (this.DiasPrazo < 0)
                this.DiasPrazo = 0;

            this.TipoLancamento = TypeLancamentoFinanceiro.Receber;
        }

        //parcela criada quando existir saldo restante
        public LancamentoFinanceiro(Nullable<int> idVenda, Decimal valorParcela, DateTime dtVencimento,
            int seqParcela, TypeStatusLancamentoFinanceiro status, String historico, Int32 idCliFor)

        {
            this.IdVenda = idVenda;
            this.ValorLancamento = valorParcela;
            this.ValorJuros = 0;
            this.DataVencimento = dtVencimento;
            this.DiasPrazo = DataUtil.CalcularDias(dtVencimento, dtVencimento);
            this.SequencialParcela = seqParcela;
            this.StatusLancamento = status;
            this.Observacao = historico;
            this.IdCliFor = idCliFor;
        }


        public LancamentoFinanceiro(ComissaoVendaUsuario comissao)
        {
            //gera um lançamento unico para essa comissa
            //cria uma comissao com base na venda e gera o lancamento
            //faturando a comissão do usuário
            this.RecCreatedBy = comissao.Venda.IdUsuarioVenda;
            this.RecCreatedDate = DateTime.Now;

            this.IdCentroCusto = comissao.Venda.IdCentroCusto;
            this.IdFilial = comissao.Venda.IdFilial;
            this.IdCliFor = comissao.Venda.IdCliForVenda;
            this.DiasPrazo = 0;
            this.ValorJuros = 0;
            //gera a sequencia correta da comissao sendo gerado
            this.SequencialParcela = comissao.Venda.Comissoes.ToList().Count(c => c.StatusComissao == TypeStatusComissaoVenda.Faturado) + 1;
            this.DataLancamento = comissao.Venda.DataVenda;
            this.ValorLancamento = comissao.Venda.TotalVenda;
            this.DataVencimento = comissao.Venda.DataVencimento;

            this.DataPagamento = DateTime.Now;
            this.TipoLancamento = TypeLancamentoFinanceiro.Receber;
            this.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;

            //comissao eh sempre a pagar
            this.TipoLancamento = TypeLancamentoFinanceiro.Pagar;
            //comissao integral
            this.ValorLancamento = comissao.ValorComissao;
            //histórico
            this.Observacao = "COMISSÃO VENDA Nº: " + comissao.Venda.IdVenda + " PARCELA Nº:" + this.SequencialParcela;

            //forma de pagamento é dinheiro
            this.IdFormaPagamento = 1;
            //vincula na comissao
            this.IdComissaoVenda = comissao.IdComissaoVenda;
            //vincula a venda
            this.IdVenda = comissao.Venda.IdVenda;
        }

        public void Update(LancamentoFinanceiro novo, bool updateAll = false)
        {

            this.ValorJuros = novo.ValorJuros;
            this.ValorLancamento = novo.ValorLancamento;
            this.UsuarioRecModifyBy = novo.UsuarioRecModifyBy;

            this.RecModifyDate = novo.RecModifyDate;
            //quem seta a data de pagamento eh somente o wizard
            //entao eu vo deixar atualizar essa data somente se ela ja existir
            if (novo.DataPagamento != null)
                this.DataPagamento = novo.DataPagamento;
            this.DataLancamento = novo.DataLancamento;
            this.DataVencimento = novo.DataVencimento;

            this.DiasPrazo = DataUtil.CalcularDias(DataLancamento, DataVencimento);

            this.IdCliFor = novo.IdCliFor;
            this.IdFilial = novo.IdFilial;
            this.IdCentroCusto = novo.IdCentroCusto;
            this.IdFormaPagamento = novo.IdFormaPagamento;
            this.IdVenda = novo.IdVenda;

            this.Observacao = novo.Observacao;
            if (novo.SequencialParcela == 0)
                this.SequencialParcela = 1;
            this.StatusLancamento = novo.StatusLancamento;
            this.TipoLancamento = novo.TipoLancamento;
            this.MotivoCancelamento = novo.MotivoCancelamento;

            this.QuantidadeAnexos = novo.Anexos.Count;
            ValidarLancamento();

            if (updateAll)
            {
                this.CliFor = novo.CliFor;
                this.Filial = novo.Filial;
                this.CentroCusto = novo.CentroCusto;
            }
        }

        public void Update(Movimento notaFiscal)
        {
            this.ValorLancamento = notaFiscal.TotalMovimento / notaFiscal.FormaPagamento.NumeroParcelas;
            this.RecModifyBy = notaFiscal.IdUsuario;
            this.RecModifyDate = DateTime.Now;
            this.DataLancamento = notaFiscal.DataEntrada;
            this.DiasPrazo = DataUtil.CalcularDias(DataLancamento, DataVencimento);
            if (notaFiscal.IdCliFor != null)
                this.IdCliFor = notaFiscal.IdCliFor.Value;
            this.IdFilial = notaFiscal.IdFilial;
            this.IdCentroCusto = notaFiscal.IdCentroCusto;
            ValidarLancamento();
        }

        public void ValidarLancamento()
        {
            if (this.StatusLancamento != TypeStatusLancamentoFinanceiro.Pago
                && this.StatusLancamento != TypeStatusLancamentoFinanceiro.Cancelado)
            {
                this.StatusLancamento = this.DataVencimento <= DateTime.Now
                    ? TypeStatusLancamentoFinanceiro.Vencido
                    : TypeStatusLancamentoFinanceiro.Aberto;

                //if (this.DataVencimento <= DateTime.Now)
                //    this.StatusLancamento = TypeStatusLancamentoFinanceiro.Vencido;
                //else
                //    this.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;
            }

            if (this.DiasPrazo < 0)
                this.DiasPrazo = 0;
        }

        //Manualmente implementando
        public LancamentoFinanceiro Clone()
        {
            LancamentoFinanceiro novo = new LancamentoFinanceiro();

            novo.Update(this);
            //usuario que criou
            novo.RecCreatedBy = this.RecCreatedBy;
            novo.RecCreatedDate = this.RecCreatedDate;

            //usuario que modificou
            novo.RecModifyBy = this.RecModifyBy;
            novo.RecModifyDate = this.RecModifyDate;

            novo.DataVencimento = this.DataVencimento;
            novo.SequencialParcela = this.SequencialParcela;
            novo.ValorLancamento = this.ValorLancamento;

            //return (LancamentoFinanceiro)this.MemberwiseClone();
            return novo;
        }

        public override string ToString()
        {
            return SequencialParcela + "x\t" +
                TotalLancamento.ToString("N2") +
                "\t" + DataVencimento.ToShortDateString();
        }
    }
}
