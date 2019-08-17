﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.Base
{
    [Serializable]
    [Table("ITS_MENU")]
    public class ItsMenu
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdMenu { get; set; }
        [StringLength(300)]
        public string NomeMenu { get; set; }
        public Nullable<int> MenuPai { get; set; }
        public bool Status { get; set; }
        [StringLength(500)]
        public string MenuText { get; set; }
        [StringLength(50)]
        public string MenuType { get; set; }
        public ItsMenu()
        {
        }
    }
}
