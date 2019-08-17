using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Financeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITSolution.Framework.Entities.POCO
{
    [Table("ITS_CONTRACT")]
    public class ItsContrato
    {
        [Key]//pk
        [Column("IdContrato")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdContrato { get; set; }

        public int IdCliente { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime DataAdesao { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime? DataEncerramento { get; set; }

        public decimal ValorMensalidade { get; set; }

        [ForeignKey("IdCliente")]
        public virtual CliFor Cliente { get; set; }

        
        public virtual ICollection<LancamentoFinanceiro> Mensalidades { get; set; }

    }
}
