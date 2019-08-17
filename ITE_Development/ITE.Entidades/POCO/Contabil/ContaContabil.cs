using ITE.Entidades.Enumeradores.ContabilEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Contabil
{
    [Table("ContaContabil")]
    public class ContaContabil
    {
        [Key]
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdContaContabil { get; set; }

        [Required]
        public int IdMatriz { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Código conta contábil")]
        public string CodigoContaContabil { get; set; }

        [Display(Name = "Código reduzido")]
        [StringLength(100)]
        //Restrição UNIQUE
        [Index(IsUnique = true)]
        public string CodigoReduzido { get; set; }

        [Required]
        [Display(Name = "Descrição Conta")]
        [StringLength(200, MinimumLength = 3)]
        public string DescricaoContaContabil { get; set; }
        
        public TypeAnaliticaSintetica IndAnaliticaSintetica { get; set; } //enum

        public Nullable<TypeTipoContaSped> TipoContaSped { get; set; } //enum

        public TypeNaturezaConta Natureza { get; set; } //enum

        public int Nivel { get; set; } 
                
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data abertura")]
        public DateTime DataInclusao { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data alteração")]
        public Nullable<DateTime> DataAlteracao { get; set; }

        //Chaves estrangeiras
        [Display(Name = "Matriz")]
        [ForeignKey("IdMatriz")]
        public virtual EmpresaMatriz Matriz { get; set; }

        //public virtual ICollection<Lancamento> Lancamento { get; set; }

        public ContaContabil()
        {
            //this.Lancamento = new HashSet<Lancamento>();
        }

        public ContaContabil(EmpresaMatriz matriz, string codigoConta, string nomeConta) : this()
        {
            this.Matriz = matriz;
            this.IdMatriz = matriz.IdMatriz;
            this.CodigoContaContabil = codigoConta;
            this.DescricaoContaContabil = nomeConta;
            this.DataInclusao = DateTime.Now;
        }
        public override string ToString()
        {
            return this.CodigoContaContabil;
        }

        public void Update(ContaContabil novaConta)
        {
            this.CodigoContaContabil = novaConta.CodigoContaContabil;
            this.CodigoReduzido = novaConta.CodigoReduzido;
            this.DataAlteracao = DateTime.Now;
            this.DescricaoContaContabil = novaConta.DescricaoContaContabil;
            this.IdMatriz = novaConta.IdMatriz;
            this.IndAnaliticaSintetica = novaConta.IndAnaliticaSintetica;
            this.Matriz = novaConta.Matriz;
            this.Natureza = novaConta.Natureza;
            this.Nivel = novaConta.Nivel;
            this.TipoContaSped = novaConta.TipoContaSped;

        }

    }
}
