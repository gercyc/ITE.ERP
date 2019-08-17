using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITE.Entidades.Enumeradores.CEEnums;

namespace ITE.Entidades.POCO.CE
{
    [Table("DespesaCusteio")]
    public class DespesaCusteio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdDespesaCusteio { get; set; }

        public long IdCusteio { get; set; }

        [StringLength(150)]
        public string DiscriminacaoDespesa { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Valor do lançamento deve ser maior que 1")]
        [Display(Name = "Valor do Lançamento")]
        public decimal ValorDespesa { get; set; }

        public decimal ValorAliquota { get; set; }

        public TypeDespesaCusteio Tipo { get; set; }

        [NotMapped]
        public int Sequencial { get; set; }

        #region Chaves estrangeiras

        //Atribuindo a propriedade das chaves
        //O atributo ForeignKey indica qual propriedade na classe 
        //representa cc campo que corresponde à chave estrangeira entre as tabelas. 
        //Note que no exemplo abaixo cc atributo ForeignKey está acima da propriedade que representa 
        //a navegação entre as duas entidades.


        [ForeignKey("IdCusteio")]
        public Custeio Custeio { get; set; }

        #endregion

        public DespesaCusteio()
        {

        }

        public DespesaCusteio(string discriminacaoDespesa, decimal valorDespesa,
            decimal valorAliquota, TypeDespesaCusteio tipo)
        {
            DiscriminacaoDespesa = discriminacaoDespesa;
            ValorDespesa = valorDespesa;
            ValorAliquota = valorAliquota;
            Tipo = tipo;
        }

        public void Update(DespesaCusteio novo)
        {
            IdCusteio = novo.IdCusteio;
            DiscriminacaoDespesa = novo.DiscriminacaoDespesa;
            ValorDespesa = novo.ValorDespesa;
            ValorAliquota = novo.ValorAliquota;
            Tipo = novo.Tipo;
            Sequencial = novo.Sequencial;
        }
    }
}
