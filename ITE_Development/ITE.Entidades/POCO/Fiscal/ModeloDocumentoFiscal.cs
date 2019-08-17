using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{
    [Serializable]
    [Table("ModeloDocumentoFiscal")]
    public class ModeloDocumentoFiscal
    {
        public ModeloDocumentoFiscal()
        {
            //this.NotasFiscais = new HashSet<NotaFiscalCapa>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdModelo { get; set; }

        [Required]
        [StringLength(2)]
        public string CodigoModelo { get; set; }

        [Required]
        [StringLength(255)]
        public string DescricaoModelo { get; set; }

        //virtual removido => nao sera carregado
        public ICollection<Movimento> NotasFiscaisCapa { get; set; }

        public override string ToString()
        {
            return CodigoModelo + " - " + DescricaoModelo;
        }
    }
}
