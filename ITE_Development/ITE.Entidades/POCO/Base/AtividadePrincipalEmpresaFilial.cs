using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO
{
    [Table("AtividadePrincipalEmpresaFilial")]
    public class AtividadePrincipalEmpresaFilial
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdAtividade { get; set; }

        public int IdFilial { get; set; }

        [ForeignKey("IdFilial")]
        public EmpresaFilial EmpresaFilial { get; set; }

        public AtividadePrincipalEmpresaFilial()
        {

        }
        public AtividadePrincipalEmpresaFilial(string text, string code)
        {

        }
    }
}