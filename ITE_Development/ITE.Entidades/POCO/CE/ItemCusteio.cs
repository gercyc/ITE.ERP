using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.CE
{
    [Table("ItemCusteio")]
    public class ItemCusteio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdItemCusteio { get; set; }

        public long IdCusteio { get; set; }

        //0000.00.00 => 2 digitos sendo "."
        [StringLength(10)]
        public string Ncm { get; set; }

        [Required]
        [Display(Name = "Mercadoria")]
        [StringLength(200, MinimumLength = 3)]
        public string Mercadoria { get; set; }

        public decimal TotalUnitarioFob { get; set; }

        public decimal TotalFob { get; set; }

        public decimal Quantidade { get; set; }

        public decimal Peso { get; set; }

        public decimal ValorReais { get; set; }

        public decimal ValorMoedaEstrangeira { get; set; }

        public decimal II { get; set; }

        public decimal IPI { get; set; }

        public decimal PIS { get; set; }

        public decimal Cofins { get; set; }
        public decimal ICMS { get; set; }
        public decimal ICMSST { get; set; }

        public int Sequencial { get; set; }

        [ForeignKey("IdCusteio")]
        public virtual Custeio Custeio { get; set; }

        #region Not Mapped 

        //Extra Fields 

        #endregion

        public ItemCusteio()
        {

        }

        public ItemCusteio(string ncm, string mercadoria, decimal totalUnitarioFob,
            decimal quantidade, decimal peso, decimal valorReais, decimal valorMoedaEstrangeira,
            decimal iI, decimal iPI, decimal pIS, decimal cofins)
        {
            Ncm = ncm;
            Mercadoria = mercadoria;
            TotalUnitarioFob = totalUnitarioFob;
            Quantidade = quantidade;
            Peso = peso;
            ValorReais = valorReais;
            ValorMoedaEstrangeira = valorMoedaEstrangeira;
            II = iI;
            IPI = iPI;
            PIS = pIS;
            Cofins = cofins;
        }

        public void Update(ItemCusteio novo)
        {
            IdCusteio = novo.IdCusteio;
            Ncm = novo.Ncm;
            Mercadoria = novo.Mercadoria;
            TotalUnitarioFob = novo.TotalUnitarioFob;
            TotalFob = novo.TotalFob;
            Quantidade = novo.Quantidade;
            Peso = novo.Peso;
            ValorReais = novo.ValorReais;
            ValorMoedaEstrangeira = novo.ValorMoedaEstrangeira;
            II = novo.II;
            IPI = novo.IPI;
            PIS = novo.PIS;
            Cofins = novo.Cofins;
            ICMS = novo.ICMS;
            ICMSST = novo.ICMSST;
            Sequencial = novo.Sequencial;
        }
    }
}
