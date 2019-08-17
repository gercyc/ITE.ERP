using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Vou usar essa classe depois para fazer media de consumo de veiculos da empresa
namespace ITE.Entidades.POCO.Logistica
{
    [Table("Veiculo")]//nao vou usar essa tabela por enquanto
    public class Veiculo
    {
        [Key] //pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //sera auto increment
        public int IdVeiculo { get; set; }

        [StringLength(50)]
        public string Marca { get; set; }

        [StringLength(50)]
        public string Modelo { get; set; }

        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }

        [StringLength(10)]
        public string Placa { get; set; }

    }
}