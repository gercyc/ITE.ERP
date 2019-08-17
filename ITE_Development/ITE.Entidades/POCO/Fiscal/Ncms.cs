using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("Ncms")]
    public class Ncms
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNcm { get; set; }

        [Required]
        [StringLength(8)]
        public string CodigoNcm { get; set; }

        [Required]
        [StringLength(255)]
        public string DescricaoNcm { get; set; }

        public DateTime DataCadastro { get; set; }

        [Required]
        [StringLength(50)]
        public string UnidadeMedida { get; set; }

        public decimal AliquotaII { get; set; }
        public decimal AliquotaIPI { get; set; }
        public decimal AliquotaPIS { get; set; }
        public decimal AliquotaCOFINS { get; set; }
        public decimal AliquotaICMS { get; set; }
        public decimal AliquotaICMSST { get; set; }

        //public virtual ICollection<Produto> Produto { get; set; }


        public Ncms()
        {
            //  Produto = new HashSet<Produto>();
            this.DataCadastro = DateTime.Now;
        }

        public override string ToString()
        {
            return CodigoNcm + " " + DescricaoNcm+ " " + UnidadeMedida;
        }
    }
}
