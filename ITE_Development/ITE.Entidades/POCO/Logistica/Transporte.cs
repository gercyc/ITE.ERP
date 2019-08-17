using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Logistica
{
    [Table("Transporte")]
    public class Transporte
    {
        [Key] //pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //sera auto increment
        public int IdTransporte { get; set; }

        public int? IdTransportadora { get; set; }

        [ForeignKey("IdTransportadora")]
        public CliFor Transportadora { get; set; }

        [StringLength(50, MinimumLength = 0)]
        public string NomeMotorista  { get; set; }

        [StringLength(10, MinimumLength = 0)]
        public string PlacaVeiculo { get; set; }

        public decimal ValorFrete { get; set; }

    }
}
