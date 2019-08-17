using ITE.RH.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH.Folha
{

    /// <summary>
    /// Movimentacao financeira de cada funcionario da competencia em memoria
    /// </summary>
    [Table("FichaFinanceiraFuncionario")]
    public class FichaFinanceiraFuncionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFichaFinanFunc { get; set; } //pk da tabela, unico

        public int IdFuncionarioCompetencia { get; set; }

        [ForeignKey("IdFuncionarioCompetencia")]
        public virtual FuncionarioCompetencia FuncionarioCompetencia { get; set; }

        public DateTime DataRef { get; set; }

        public int IdEvento { get; set; }

        [ForeignKey("IdEvento")]
        public virtual Evento Evento { get; set; }

        public decimal ValorMovimento { get; set; }

        /// <summary>
        /// Indica se o mov. é Valor ou Hora ou Referencia 
        /// </summary>
        public TypeReferenciaEvento Referencia { get; set; }

        public decimal Quantidade { get; set; }

        #region NotMapped

        [NotMapped]
        public Decimal? Proventos
        {
            get
            {
                if (this.Evento.TipoEvento == TypeEvento.Provento)
                    return this.ValorMovimento;
                else
                    return null;
            }
        }

        [NotMapped]
        public Decimal? Descontos
        {
            get
            {
                if (this.Evento.TipoEvento == TypeEvento.Desconto)
                    return this.ValorMovimento;
                else
                    return null;
            }
        }

        #endregion

        public FichaFinanceiraFuncionario()
        {

        }
        public FichaFinanceiraFuncionario(FuncionarioCompetencia funcionarioComp, Evento evento, decimal valor, TypeReferenciaEvento tipoReferencia, DateTime dataRef, decimal quantidade)
        {
            this.IdFuncionarioCompetencia = funcionarioComp.IdFuncionario;
            this.IdEvento = evento.IdEvento;
            this.ValorMovimento = valor;
            this.Referencia = tipoReferencia;
            this.DataRef = dataRef;
            this.Quantidade = quantidade;
        }
        public FichaFinanceiraFuncionario(FuncionarioCompetencia funcionarioComp, Evento evento, decimal valor, TypeReferenciaEvento tipoReferencia, decimal quantidade)
        {
            this.IdFuncionarioCompetencia = funcionarioComp.IdFuncionario;
            this.IdEvento = evento.IdEvento;
            this.ValorMovimento = valor;
            this.Referencia = tipoReferencia;
            this.Quantidade = quantidade;
        }
        public void Update(FichaFinanceiraFuncionario novo)
        {
            this.ValorMovimento = novo.ValorMovimento;
        }
    }
}
