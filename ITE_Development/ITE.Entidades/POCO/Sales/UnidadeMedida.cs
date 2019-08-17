using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Sales
{
    [Table("UnidadeMedida")]
    [Serializable]
    public class UnidadeMedida
    {
        [Key]//pk
        [Column]
        [Display(Name = "ID unidade de medida")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdUnidadeMedida { get; set; }

        //Sigla ou Codigo
        [Required]
        [Display(Name = "Código da unidade de medida")]
        [StringLength(50)]
        public string NomeUnidadeMedida { get; set; }

        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]  //Restricao UNIQUE
        [Display(Name = "Descrição unidade de medida")]
        public string Descricao { get; set; }
    
        public virtual ICollection<Produto> Produto { get; set; }


        public UnidadeMedida()
        {
            this.Produto = new HashSet<Produto>();
        }

        public UnidadeMedida(string nomeUnidadeMed):this()
        {
            this.NomeUnidadeMedida = nomeUnidadeMed;
        }
        public UnidadeMedida(string codigo, string nomeUnidadeMed) : this()
        {
            this.NomeUnidadeMedida = codigo;
            this.Descricao = nomeUnidadeMed;
        }
        public void Update(UnidadeMedida novo)
        {
            this.NomeUnidadeMedida = novo.NomeUnidadeMedida;
            this.Descricao = novo.Descricao;
        }

        public override String ToString()
        {
            return this.NomeUnidadeMedida;
        }
    }
}
