/**
* Copyright (c) 2013, Filipe Rezende Campos. Todos os direitos reservados. ITSolution
* SOFTWARE/CONFIDENCIAL. O Uso está sujeito aos termos.
*
* 
*
*/
using ITSolution.Framework.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ITE.Entidades.POCO
{
    /// <summary>
    /// Classe de endereço
    ///  @author Filipe
    /// </summary>
    [Table("EnderecoCliFor")]
    public class EnderecoCliFor
    {


        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdEndereco { get; set; }

        public int IdCliForEndereco { get; set; }

        [ForeignKey("IdCliForEndereco")]
        public virtual CliFor CliFor { get; set; }

        //[Required]
        [Column("NomeEndereco")]
        [Display(Name = "Nome Endereço")]
        [StringLength(200)]
        public string NomeEndereco { get; set; }

        //Marcação caso o endereço não tenha número = S/N
        //[Required]
        [Column("NumeroEndereco")]
        [Display(Name = "Número do endereço")]
        [StringLength(20)]
        public string NumeroEndereco { get; set; }

        //[Required]
        [Column("Bairro")]
        [StringLength(200)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        //[Required]
        [Column("Complemento")]
        [StringLength(100)]
        public string Complemento { get; set; }

        //[Required]
        [Display(Name = "Cep")]
        [Column("Cep")]
        [StringLength(10,
            ErrorMessage = "Cep deve conter 8 ou nove digítos\nEx: 00000-000\n00000000")]
        public string Cep { get; set; }

        //[Required]
        [Column("Uf")]
        [StringLength(10)]
        [Display(Name = "Estado")]
        public string Uf { get; set; }

        //[Required]
        [StringLength(100)]
        [Column("Cidade")]
        public string Cidade { get; set; }

        //[Required]
        [StringLength(50)]
        [Column("Pais")]
        public string Pais { get; set; }

        //[Required]
        [Display(Name = "Tipo de endereço")]
        [StringLength(50)]
        [Column("TipoEndereco")]
        public string TipoEndereco { get; set; }

        [NotMapped]
        public string EnderecoParcial { get { return enderecoParcial(); } }

        public EnderecoCliFor() { }

        public EnderecoCliFor(string endereco, string numeroEndereco, string bairro,
            string complemento, string cep, string uf, string cidade, string tipoEndereco)
        {
            this.NomeEndereco = endereco;
            this.NumeroEndereco = numeroEndereco;
            this.Bairro = bairro;
            this.Complemento = complemento;
            this.Cep = string.IsNullOrEmpty(cep) ? null : cep.Replace(".", "");
            this.Uf = uf;
            this.Cidade = cidade;
            this.TipoEndereco = tipoEndereco;
        }

        /// <summary>
        /// Atualiza os dados de endereço com um endereço informado
        /// </summary>
        /// <param name="e"></param>
        public void Update(EnderecoCliFor e)
        {
            if (e != null)
            {
                this.NomeEndereco = e.NomeEndereco;
                this.NumeroEndereco = e.NumeroEndereco;
                this.TipoEndereco = e.TipoEndereco;
                this.Bairro = e.Bairro;
                this.Complemento = e.Complemento;
                this.Cidade = e.Cidade;
                this.Uf = e.Uf;
                this.Cep = e.Cep;
            }
        }

        /// <summary>
        /// Atualiza os dados de endereço com um endereço informado
        /// </summary>
        /// <param name="endereco"></param>
        public void Update(Endereco endereco)
        {
            if (endereco != null)
            {
                this.NomeEndereco = endereco.NomeEndereco;
                this.NumeroEndereco = endereco.NumeroEndereco;
                this.TipoEndereco = endereco.TipoEndereco;
                this.Bairro = endereco.Bairro;
                this.Complemento = endereco.Complemento;
                this.Cidade = endereco.Cidade;
                this.Uf = endereco.Uf;
                this.Cep = endereco.Cep;
            }
        }

        public string enderecoParcial()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.NomeEndereco);

            if (!string.IsNullOrEmpty(this.NumeroEndereco))
            {
                sb.Append(", ");
                sb.Append(this.NumeroEndereco);
            }

            if (!string.IsNullOrEmpty(this.Bairro))
            {
                sb.Append(", ");
                sb.Append(this.Bairro);
            }
            if (!string.IsNullOrEmpty(this.Complemento))
            {
                sb.Append(", ");
                sb.Append(this.Complemento);
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.NomeEndereco);

            if (!string.IsNullOrEmpty(this.NumeroEndereco))
            {
                sb.Append(", ");
                sb.Append(this.NumeroEndereco);
            }

            if (!string.IsNullOrEmpty(this.Bairro))
            {
                sb.Append(", ");
                sb.Append(this.Bairro);
            }
            if (!string.IsNullOrEmpty(this.Complemento))
            {
                sb.Append(", ");
                sb.Append(this.Complemento);
            }

            if (!string.IsNullOrEmpty(this.Cep))
            {
                sb.Append(", ");
                sb.Append(this.Cep);
            }

            if (!string.IsNullOrEmpty(this.Cidade))
            {
                sb.Append(", ");
                sb.Append(this.Cidade);
            }

            if (!string.IsNullOrEmpty(this.Uf))
            {
                sb.Append(" - ");
                sb.Append(this.Uf);
            }

            return sb.ToString();
        }

    }
}