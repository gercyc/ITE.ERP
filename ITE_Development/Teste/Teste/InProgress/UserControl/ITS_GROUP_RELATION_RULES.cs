using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Teste
{


    public class ITS_GROUP_RELATION_RULES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(38)]
        public string IdRegra { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdGrupo { get; set; }

        public virtual ITS_USER_RULES ITS_USER_RULES { get; set; }
    }
}
