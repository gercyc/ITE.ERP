using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITSolution.Framework.Web.JSON;

namespace ITE.Entidades.POCO
{
    [Table("AtividadeSecundariaEmpresaFilial")]
    public class AtividadeSecundariaEmpresaFilial : ModelLayout
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdAtividade { get; set; }

        public int IdFilial { get; set; }

        [ForeignKey("IdFilial")]
        public EmpresaFilial EmpresaFilial { get; set; }

        public AtividadeSecundariaEmpresaFilial()
        {

        }
        public AtividadeSecundariaEmpresaFilial(string text, string code) : base(text, code)
        {

        }
    }
}