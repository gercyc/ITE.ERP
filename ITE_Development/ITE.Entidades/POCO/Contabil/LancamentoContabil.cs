using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.Contabil
{
    public class LancamentoContabil
    {
        #region Atributos
        [Key]//pk
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLancamentoContabil { get; set; }
        public int IdMatriz { get; set; }
        public string NumeroLancamento { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public decimal ValorDebito { get; set; }
        public decimal ValorCredito { get; set; }
        public decimal Valor { get; set; }
        public int? IdLoteOrigem { get; set; }
        public int IdUsuario { get; set; }
        public int? IdUsuarioAlter { get; set; }
        public DateTime DataCriacao { get; set; }
        public Nullable<DateTime> DataAlteracao { get; set; }
        public virtual ICollection<PartidaContabil> Partidas { get; set; }

        #endregion

        #region ForeignKeys

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
        [ForeignKey("IdUsuarioAlter")]
        public virtual Usuario UsuarioAlteracao { get; set; }

        [ForeignKey("IdMatriz")]
        public virtual EmpresaMatriz Matriz { get; set; }

        [ForeignKey("IdLoteOrigem")]
        public virtual LoteContabil LoteOrigem { get; set; }

        #endregion

        #region Construtores
        public LancamentoContabil()
        {
            //this.IdLancamentoContabil = newGuidID();
            this.Partidas = new HashSet<PartidaContabil>();
        }

        //novo lancamento
        public LancamentoContabil(EmpresaMatriz matriz, DateTime dataLancamento, Usuario usuario) : this()
        {
           // this.IdLancamentoContabil = newGuidID();
            //this.Matriz = matriz;
            this.IdMatriz = matriz.IdMatriz;
            this.DataLancamento = dataLancamento;
            //this.Usuario = usuario;
            this.IdUsuario = usuario.IdUsuario;

            this.DataCriacao = DateTime.Now;
        }
        #endregion

        #region Métodos
        public void Update(LancamentoContabil novo)
        {
            this.Descricao = novo.Descricao;
            this.DataLancamento = novo.DataLancamento;
            //this.UsuarioAlteracao = novo.Usuario;
            this.IdUsuarioAlter = novo.IdUsuario;
            this.DataAlteracao = DateTime.Now;

            //atualiza os valores do lanctos
            this.Valor = novo.GetValor();
            this.ValorDebito = novo.GetValoresDebito();
            this.ValorCredito = novo.GetValoresCredito();
        }
        public decimal GetValoresDebito()
        {
            return this.Partidas.Where(p => p.IdContaContabilDeb != 0).Sum(p => p.ValorPartida);
        }
        public decimal GetValoresCredito()
        {
            return this.Partidas.Where(p => p.IdContaContabilCred != 0).Sum(p => p.ValorPartida);
        }
        public decimal GetValor()
        {
            return this.Partidas.Sum(p => p.ValorPartida);
        }
        public LancamentoContabil Clone()
        {
            return (LancamentoContabil)this.MemberwiseClone();
        }
        #endregion
    }
}
