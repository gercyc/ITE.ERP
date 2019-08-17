using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("Cfops")]
    public class Cfops
    {
    
        [Key]
        public int IdCfop { get; set; }

        [Required]
        [StringLength(4)]
        public string CodigoCfop { get; set; }

        [Required]
        [StringLength(500)]
        public string DescricaoCfop { get; set; }

        //public virtual ICollection<NotaFiscalItem> NotaFiscalItem { get; set; }
        public Cfops()
        {
            //NotaFiscalItem = new HashSet<NotaFiscalItem>();
        }

        public Cfops(string codigo, string descricao)
        {
            this.CodigoCfop = codigo;
            this.DescricaoCfop = descricao;
        }
        public void Update(Cfops novo)
        {
            this.CodigoCfop = novo.CodigoCfop;
            this.DescricaoCfop = novo.DescricaoCfop;
        }
        public override string ToString()
        {
            return CodigoCfop;
        }
    }
}
