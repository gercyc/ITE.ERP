using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO
{
    [Table("AtividadeSecundariaCliFor")]
    public class AtividadeSecundariaCliFor
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdAtividade { get; set; }

        public int IdCliFor { get; set; }

        [ForeignKey("IdCliFor")]
        public CliFor CliFor { get; set; }

        public AtividadeSecundariaCliFor()
        {

        }
        public AtividadeSecundariaCliFor(string text, string code)
        {

        }
    }
}