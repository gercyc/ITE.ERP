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
    [Table("GrupoEvento")]
    public class GrupoEvento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGrupoEvento { get; set; }

        [Display(Name = "Código do grupo de eventos")]
        [Required(ErrorMessage = "Código do grupo não foi informado")]
        [StringLength(5, MinimumLength = 3)]
        public string CodigoGrupo { get; set; }

        [Display(Name = "Descrição do grupo de eventos")]
        [Required(ErrorMessage = "Descrição do grupo não foi informado")]
        public string DescricaoGrupo { get; set; }
        public string Observacoes { get; set; }

        public virtual ICollection<EventosGrupo> EventosGrupo { get; set; }

        public GrupoEvento()
        {
            this.EventosGrupo = new HashSet<EventosGrupo>();
        }
        public override string ToString()
        {
            return this.CodigoGrupo + " - " + this.DescricaoGrupo;
        }
        public void Update(GrupoEvento novo)
        {
            this.CodigoGrupo = novo.CodigoGrupo;
            this.DescricaoGrupo = novo.DescricaoGrupo;
            this.Observacoes = novo.Observacoes;

            //percorre os eventos que nao foram removidos
            foreach (var evt in novo.EventosGrupo.Where(e => e.Removed != true))
            {
                //percorre os eventos do objeto atual, atualizando-os
                foreach (var item in this.EventosGrupo.Where(e => e.IdEvento == evt.IdEvento))
                {
                    item.Update(evt);
                }

                if (evt.IdEvtGrupo == 0)
                    this.EventosGrupo.Add(evt);
            }
        }

    }
}
