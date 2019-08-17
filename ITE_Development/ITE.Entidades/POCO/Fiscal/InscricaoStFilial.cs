using ITE.Entidades.POCO.Fiscal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace ITE.Entidades.POCO.Fiscal
{
    /*
     
     Relacionamento das inscrições ST de cada filial
     Uma filial pode conter N inscrições ST em diferentes unidades de federações     
     1 : N
     
     */

    [Table("InscricaoStFilial")]
    public class InscricaoStFilial
    {
        [Key]
        [Column(Order = 0)]
        public int IdFilial { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string InscricaoEstadualSt { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdUf { get; set; }

        public virtual EmpresaFilial Filial { get; set; }

        public virtual UnidadeFederacao UnidadeFederacao { get; set; }
    }
}
