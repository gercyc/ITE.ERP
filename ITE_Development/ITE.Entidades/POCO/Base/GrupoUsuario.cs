using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO
{
    [Serializable]
    [Table("GrupoUsuario")]
    public class GrupoUsuario
    {
       
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdGrupoUsuario { get; set; }

        [Required]
        [Display(Name = "Grupo Usuário")]
        [StringLength(50, MinimumLength = 4)]
        [Index(IsUnique = true)]//Restrição UNIQUE
        public string NomeGrupoUsuario { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
        
        public GrupoUsuario()
        {
            this.Usuarios = new HashSet<Usuario>();
        }

        public GrupoUsuario(String nomeGrupo)
        {
            this.NomeGrupoUsuario = nomeGrupo;
        }
        public override String ToString()
        {
            return NomeGrupoUsuario;
        }
    }
}
