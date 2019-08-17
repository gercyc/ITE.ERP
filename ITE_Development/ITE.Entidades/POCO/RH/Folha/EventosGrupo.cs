using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.RH.Folha
{
    [Serializable]
    [Table("EventosGrupo")]
    public class EventosGrupo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvtGrupo { get; set; }
        public int IdGrupoEvento { get; set; }
        public int IdEvento { get; set; }
        public bool ImprimirHolerite { get; set; }

        [NotMapped]
        public bool Removed { get; set; }

        [ForeignKey("IdEvento")]
        public virtual Evento Evento { get; set; }
        [ForeignKey("IdGrupoEvento")]
        public virtual GrupoEvento Grupo { get; set; }

        public void Update(EventosGrupo novo)
        {
            this.IdEvento = novo.IdEvento;
            this.IdGrupoEvento = novo.IdGrupoEvento;
            this.ImprimirHolerite = novo.ImprimirHolerite;
        }
    }
}
