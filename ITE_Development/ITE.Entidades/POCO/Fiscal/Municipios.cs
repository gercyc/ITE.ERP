using ITSolution.Framework.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{
    [Table("Municipios")]
    public class Municipios : MunicipioIts
    {
        [Key]
        public int IdMunicipio { get; set; }
 
        public int IdUF { get; set; }

        public virtual UnidadeFederacao UnidadeFederacao { get; set; }

        //public virtual ICollection<Endereco> Endereco { get; set; }

        public Municipios()
        {
            //Endereco = new HashSet<Endereco>();
        }
        public Municipios(string nome, string codigoIbge, UnidadeFederacao uf)
        {
            this.NomeMunicipio = nome;
            this.CodigoIbge = codigoIbge;
            this.IdUF = uf.IdUF;
        }
        public  void Update(Municipios novo)
        {
            base.Update(novo);
            
            this.IdUF = novo.IdUF;
        }
      
    }
}
