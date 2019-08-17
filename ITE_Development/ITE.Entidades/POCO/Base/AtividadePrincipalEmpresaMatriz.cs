using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITSolution.Framework.Web.JSON;

namespace ITE.Entidades.POCO
{
    [Table("AtividadePrincipalEmpresaMatriz")]
    public class AtividadePrincipalEmpresaMatriz : ModelLayout
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdAtividade { get; set; }

        public int IdMatriz { get; set; }

        [ForeignKey("IdMatriz")]
        public EmpresaMatriz Matriz { get; set; }

        public AtividadePrincipalEmpresaMatriz()
        {

        }
        public AtividadePrincipalEmpresaMatriz(string text, string code) : base(text, code)
        {

        }
    }
}