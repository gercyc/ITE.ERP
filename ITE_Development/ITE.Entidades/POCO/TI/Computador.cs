using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ITE.Entidades.POCO.TI
{
    [Serializable]
    [Table("Computador")]
    public class Computador : Computer
    {

        [Key]//pk
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//nao sera auto increment
        [Display(Name = "ID Computador")]
        public int IdComputador { get; set; }

        [Display(Name = "Manutenção")]
        public int IdManutencao { get; set; }

        [ForeignKey("IdManutencao")]
        public Manutencao Manutencao { get; set; }

        //Atributo embutido
        [Display(Name = "Sistema operacional")]
        public virtual SistemaOperacional SistemaOperacional { get; set; }


        public Computador()
        {
        }

        public Computador(string placaMae, string proc, string hd, string ram, string nomePC,
                string grupoTrabalho, SistemaOperacional so)
        {

            this.NomePlacaMae = placaMae;
            this.Processador = proc;
            this.Hd = hd;
            this.MemoriaRam = ram;
            this.SistemaOperacional = so;
            this.NomeComputador = nomePC;
            this.GrupoTrabalho = grupoTrabalho;
        }

        public override string ToString()
        {
            return NomePlacaMae + " - " + Processador;
        }

        public void Update(Computador novo)
        {

            this.NomePlacaMae = novo.NomePlacaMae;
            this.Processador = novo.Processador;
            this.Hd = novo.Hd;
            this.MemoriaRam = novo.MemoriaRam;

            this.SistemaOperacional = novo.SistemaOperacional;

            this.NomeComputador = novo.NomeComputador;
            this.GrupoTrabalho = novo.GrupoTrabalho;
        }

    }
}
