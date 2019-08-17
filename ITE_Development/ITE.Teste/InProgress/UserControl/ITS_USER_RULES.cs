using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ITSolution.Framework.Entities
{


    public class ITS_USER_RULES
    {
        public ITS_USER_RULES()
        {
            ITS_GROUP_RELATION_RULES = new HashSet<ITS_GROUP_RELATION_RULES>();
        }

        [Key]
        [StringLength(38)]
        public string IdRegra { get; set; }

        [StringLength(10)]
        public string CodigoRegra { get; set; }

        [StringLength(50)]
        public string NomeRegra { get; set; }

        [StringLength(50)]
        public string DescricaoRegra { get; set; }

        public bool StatusRegra { get; set; }
        
        public virtual ICollection<ITS_GROUP_RELATION_RULES> ITS_GROUP_RELATION_RULES { get; set; }
    }
}
