using ITSolution.Framework.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace ITE.Entidades.POCO.Financeiro
{
    [Table("AnexoLancamento")]
    public class AnexoLancamento : AbstractAttach
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAnexo { get; set; }

        public int IdLancamento { get; set; }

        [ForeignKey("IdLancamento ")]
        public LancamentoFinanceiro Lancamento{ get; set; }


        public AnexoLancamento()
        {
        }

        public AnexoLancamento(string path)
            :base(path)
        {
        }

        public void Update(AnexoLancamento anexo)
        {
            base.Update(anexo);
            this.IdLancamento = anexo.IdLancamento;
        }
    }
}
