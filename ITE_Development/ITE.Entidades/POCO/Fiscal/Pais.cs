using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("Pais")]
    public class Pais
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPais { get; set; }
    
        [StringLength(3)]
        public string CodigoSiscomex { get; set; }

        [StringLength(50)]
        public string NomePais { get; set; }

        public Pais()
        {
            
        }
        public Pais(string nomePais)
        {
            NomePais = nomePais;
        }

        public override string ToString()
        {
            return NomePais;
        }
    }
}
