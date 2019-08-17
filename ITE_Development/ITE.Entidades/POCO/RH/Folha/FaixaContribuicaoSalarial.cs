using ITE.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.RH.Folha
{
    [Table("FaixaContribuicaoEncargos")]
    public class FaixaContribuicaoSalarial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFaixaEncargo { get; set; }
        public TypeEncargoSalarial TipoContribuicao { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public DateTime? VigenciaFinal { get; set; }
        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
        public decimal AliquotaEncargo { get; set; }
        public decimal ValorDeducao { get; set; }

    }
}
