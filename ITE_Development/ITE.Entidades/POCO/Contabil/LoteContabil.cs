using ITE.Entidades.Enumeradores.ContabilEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.Contabil
{
    public class LoteContabil
    {
        public LoteContabil()
        {

            this.LancamentosLote = new HashSet<LancamentoContabil>();
        }

        [Key]//pk
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLote { get; set; }
        public int IdMatriz { get; set; }
        public string NumeroLote { get; set; }
        public string DescricaoLote { get; set; }
        public DateTime DataInicial { get; set; }
        public Nullable<DateTime> DataFinal { get; set; }
        public decimal ValorDebito { get; set; }
        public decimal ValorCredito { get; set; }
        public decimal Valor { get; set; }
        public TypeOrigemLoteContabil OrigemLote { get; set; }
        public TypeStatusLoteContabil StatusLote { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public ICollection<LancamentoContabil> LancamentosLote { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("IdMatriz")]
        public virtual EmpresaMatriz Matriz { get; set; }

        public void Update(LoteContabil novo)
        {
            this.DescricaoLote = novo.DescricaoLote;
            this.DataInicial = novo.DataInicial;
            this.DataFinal = novo.DataFinal;
        }
        public Guid newGuidID()
        {
            return Guid.NewGuid();
        }

    }
}
