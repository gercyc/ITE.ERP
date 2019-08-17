using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{
    [Serializable]
    [Table("SituacaoDocumentoFiscal")]
    public class SituacaoDocumentoFiscal
    {
        [Key]
        public int IdSituacao { get; set; }

        [Required]
        [StringLength(2)]
        public string CodigoSituacao { get; set; }

        [Required]
        [StringLength(255)]
        public string DescricaoSituacao { get; set; }

        [StringLength(3)]
        public string TipoSituacao { get; set; }

        //removido virtual nao sera carregado
        public ICollection<Movimento> NotasFiscaisCapa { get; set; }

        public SituacaoDocumentoFiscal()
        {
            this.NotasFiscaisCapa = new HashSet<Movimento>();
        }

        public override string ToString()
        {
            return CodigoSituacao ;
        }
    }
}
