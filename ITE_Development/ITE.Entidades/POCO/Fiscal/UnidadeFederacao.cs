using ITSolution.Framework.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("UnidadeFederacao")]
    public class UnidadeFederacao :UnidadeFederacaoIts
    {      

        [Key]
        public int IdUF { get; set; }
         
        public virtual ICollection<Municipios> Municipios { get; set; }

        //virtual removido => nao sera carregado
        public ICollection<InscricaoStFilial> InscricaoStFilial { get; set; }

        public UnidadeFederacao()
        {
            this.Municipios = new HashSet<Municipios>();
            this.InscricaoStFilial = new HashSet<InscricaoStFilial>();
        }
        public override string ToString()
        {
            return CodigoUF;
        }
    }
}
