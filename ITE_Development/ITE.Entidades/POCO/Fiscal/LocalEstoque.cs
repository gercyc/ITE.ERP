using ITE.Entidades.POCO.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.Fiscal
{


    [Serializable]
    [Table("LocalEstoque")]
    public class LocalEstoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLocalEstoque { get; set; }

        [Required]
        [StringLength(4)]
        public string CodigoLocalEstoque { get; set; }

        [Required]
        [StringLength(150)]
        public string NomeLocalEstoque { get; set; }

        public int IdFilial { get; set; }

        //[Required]
        [StringLength(150)]
        public string NomeEndereco { get; set; }

        //[Required]
        [StringLength(10)]
        public string NumeroEndereco { get; set; }

        //[Required]
        [StringLength(15)]
        public string ComplementoEndereco { get; set; }

        //[Required]
        [StringLength(50)]
        public string Bairro { get; set; }

        //[Required]
        [StringLength(50)]
        public string Cep { get; set; }

        [Required]
        [StringLength(2)]
        public string Uf { get; set; }

        [Required]
        [StringLength(100)]
        public string Municipio { get; set; }

        [ForeignKey("IdFilial")]
        public virtual EmpresaFilial Filial { get; set; }

        public ICollection<TransacoesProduto> TransacoesProduto { get;  set; }

        public ICollection<Movimento> Movimentos { get; set; }

        public LocalEstoque()
        {
            this.Movimentos = new HashSet<Movimento>();
        }

        public LocalEstoque(string codigo, string nomeLocal, int idFilial, string uf, string municipio)
        {
            this.CodigoLocalEstoque = codigo;
            this.NomeLocalEstoque = nomeLocal;
            this.IdFilial = idFilial;
            this.Uf = uf;
            this.Municipio = municipio;
        }
        public void Update(LocalEstoque novo)
        {
            this.NomeLocalEstoque = novo.NomeLocalEstoque;
            this.IdFilial = novo.IdFilial;
            this.Bairro = novo.Bairro;
            this.Cep = novo.Cep;
            this.ComplementoEndereco = novo.ComplementoEndereco;
            this.Municipio = novo.Municipio;
            this.NomeEndereco = novo.NomeEndereco;
            this.NumeroEndereco = novo.NumeroEndereco;
            this.Uf = novo.Uf;
        }

        public override string ToString()
        {
            return this.NomeLocalEstoque;
        }
    }
}
