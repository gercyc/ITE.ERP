using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Sales
{
    [Serializable]
    [Table("CategoriaProduto")]
    public class CategoriaProduto
    {

        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdCategoriaProduto { get; set; }

        [Required]
        [Display(Name = "Categoria do Produto")]
        [StringLength(50, MinimumLength = 4)]
        [Index(IsUnique = true)]//Restrição UNIQUE
        public string NomeCategoriaProduto { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }

        public CategoriaProduto()
        {
            this.Produtos = new HashSet<Produto>();
        }

        public CategoriaProduto(String nomeCat)
        {
            this.NomeCategoriaProduto = nomeCat;
        }

        public void Update(CategoriaProduto novo)
        {
            this.NomeCategoriaProduto = novo.NomeCategoriaProduto;
        }

        public override string ToString()
        {
            return NomeCategoriaProduto;
        }
    }
}
