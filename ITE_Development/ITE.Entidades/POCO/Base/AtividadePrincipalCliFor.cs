using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO
{
    [Table("AtividadePrincipalCliFor")]
    public class AtividadePrincipalCliFor
    {

        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdAtividade { get; set; }

        public int IdCliFor { get; set; }

        [ForeignKey("IdCliFor")]
        public CliFor CliFor { get; set; }

        public AtividadePrincipalCliFor()
        {

        }
        public AtividadePrincipalCliFor(string text, string code)
        {

        }
    }
}