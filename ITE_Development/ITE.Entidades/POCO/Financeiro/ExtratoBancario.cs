using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ITE.Entidades.POCO.Financeiro
{
    [Table("ExtratoBancario")]
    public class ExtratoBancario
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdExtrato { get; set; }

        [Required]
        [Display(Name = "Histórico")]
        [StringLength(200, MinimumLength = 4)]
        [Column(TypeName = "varchar")]
        public string Historico { get; set; }
        public TypeExtratoBancario TipoExtrato { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime DataExtrato { get; set; }
        public Nullable<DateTime> DataEstorno { get; set; }
        public Nullable<DateTime> DataCompensacao { get; set; }
        public decimal ValorExtrato { get; set; }
        public string NumeroCheque { get; set; }
        public Nullable<DateTime> DataChequePreDatado { get; set; }
        public string BancoCheque { get; set; }
        public string AgenciaCheque { get; set; }
        public string NumeroContaEmissorCheque { get; set; }
        public string EmissorCheque { get; set; }
        public bool Compensado { get; set; }

        #region Nao mapeado
        [NotMapped]
        public Image ImageTipoExtrato
        {
            get
            {
                if(this.ValorExtrato > 0)
                    return Properties.Resources.caixa_Credito;
                else
                    return Properties.Resources.caixa_Debito;
            }
        }
        #endregion

        #region Chave estrangeira

        //Cada extrato pode ser relacionado a um lancamento financeiro
        //ou pode nao ter relacao com nenhum, por isso pode ser nulo
        public int? IdLancamento { get; set; }
        [ForeignKey("IdLancamento")]
        public virtual LancamentoFinanceiro LancamentoFinanceiro { get; set; }

        //cada extrato é relacionado a uma conta
        public int IdContaBancaria { get; set; }
        [ForeignKey("IdContaBancaria")]
        public virtual ContaBancaria ContaBancaria { get; set; }

        public int? IdCentroCusto { get; set; }
        [ForeignKey("IdCentroCusto")]
        public virtual CentroCusto CentroCusto { get; set; }

        public int? IdFilial { get; set; }
        [ForeignKey("IdFilial")]
        public virtual EmpresaFilial FilialExtrato { get; set; }
        #endregion

        public ExtratoBancario()
        {

        }
        public ExtratoBancario(TypeExtratoBancario tipoExtrato, DateTime dataExtrato, decimal valorExtrato, int idConta, int idLancamento, string historico, int? idCentroCusto, int idFilial, Nullable<DateTime> dataEstorno = null)
        {
            this.IdCentroCusto = idCentroCusto;
            this.IdFilial = idFilial;
            this.Historico = historico;
            this.IdLancamento = idLancamento;
            this.TipoExtrato = tipoExtrato;
            this.DataExtrato = dataExtrato;
            this.IdContaBancaria = idConta;
            if (tipoExtrato == TypeExtratoBancario.SaqueManual || tipoExtrato == TypeExtratoBancario.SaqueNaBaixa)
                this.ValorExtrato = valorExtrato * -1;
            else
                this.ValorExtrato = valorExtrato;

            if (dataEstorno != null)
                this.DataEstorno = dataEstorno.Value;

        }
        public void CompensarExtrato(DateTime dtComp)
        {
            this.Compensado = true;
            this.DataCompensacao = dtComp;
        }
        public void Update(ExtratoBancario novo)
        {
            this.Historico = novo.Historico;
            this.CentroCusto = novo.CentroCusto;
            this.IdCentroCusto = novo.IdCentroCusto;
            this.Compensado = novo.Compensado;
            this.DataCompensacao = novo.DataCompensacao;

            //cheque
            this.NumeroCheque = novo.NumeroCheque;
            this.BancoCheque = novo.BancoCheque;
            this.NumeroContaEmissorCheque = novo.NumeroContaEmissorCheque;
            this.EmissorCheque = novo.EmissorCheque;
            this.AgenciaCheque = novo.AgenciaCheque;

            if (novo.DataChequePreDatado != null)
                this.DataChequePreDatado = novo.DataChequePreDatado;
            else
                this.DataChequePreDatado = null;
        }
    }
}
