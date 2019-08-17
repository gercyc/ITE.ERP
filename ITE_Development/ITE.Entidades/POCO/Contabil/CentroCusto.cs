using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.POCO.TI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Contabil
{
    [Serializable]
    [Table("CentroCusto")]
    public class CentroCusto
    {

        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdCentroCusto { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Matriz não informada")]
        [Required(ErrorMessage = "ID Matriz")]
        public int IdMatriz { get; set; }

        [Required]
        [Display(Name = "Código Centro Custo")]
        [StringLength(200, MinimumLength = 1)]
        [Column(TypeName = "varchar")]
        public string CodigoCentroCusto { get; set; }


        [Required]
        [Display(Name = "Centro Custo")]
        [StringLength(200, MinimumLength = 3)]
        //Restrição UNIQUE
        [Index(IsUnique = true)]
        [Column(TypeName = "varchar")]
        public string NomeCentroCusto { get; set; }

        [Required]
        [Display(Name = "Data de Inclusão")]
        [Column]
        public DateTime DataAbertura { get; set; }

        [ForeignKey("IdMatriz")]
        public virtual EmpresaMatriz Matriz { get; set; }

        public Nullable<int> ParentId { get; set; }

        public ICollection<Manutencao> Manutencoes { get; set; }

        public ICollection<ExtratoBancario> Extratos { get; set; }

        public ICollection<LancamentoFinanceiro> Lancamentos { get; set; }

        public ICollection<Movimento> NotasFiscais { get; set; }

        public ICollection<Venda> Vendas { get; set; }

        public CentroCusto()
        {            
            this.DataAbertura = DateTime.Now;
            this.Extratos = new HashSet<ExtratoBancario>();
            this.Lancamentos = new HashSet<LancamentoFinanceiro>();
            this.Manutencoes = new HashSet<Manutencao>();
            this.NotasFiscais = new HashSet<Movimento>();
            this.Vendas = new HashSet<Venda>();

        }
        public CentroCusto(EmpresaMatriz matriz, string codigoCentro, string nomeCentroCusto) : this()
        {
            
            this.IdMatriz = matriz.IdMatriz;
            this.CodigoCentroCusto = codigoCentro;
            this.NomeCentroCusto = nomeCentroCusto;

        }


        public void Update(CentroCusto novo)
        {
            //atualizando objeto
            this.NomeCentroCusto = novo.NomeCentroCusto;
            this.CodigoCentroCusto = novo.CodigoCentroCusto;
            this.IdMatriz = novo.IdMatriz;
            this.ParentId = novo.ParentId;
        }

        public override string ToString()
        {
            return this.NomeCentroCusto;
        }

    }
}
