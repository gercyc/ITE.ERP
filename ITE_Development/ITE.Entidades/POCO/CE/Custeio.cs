using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.CE
{

    [Serializable]
    [Table("Custeio")]
    public class Custeio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdCusteio { get; set; }

        public Nullable<int> IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public virtual CliFor Cliente { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime DataCalculo { get; set; }

        [StringLength(20)]
        public string NumeroProcesso { get; set; }

        public decimal ValorFobTotal { get; set; }

        public decimal ValorCapatazia { get; set; }

        public decimal ValorCif { get; set; }

        [StringLength(100)]
        public string Fabricante { get; set; }

        [StringLength(100)]
        public string Exportador { get; set; }

        [StringLength(100, MinimumLength = 0)]
        public string Incoterms { get; set; }

        [StringLength(100)]
        public string PortoOrigem { get; set; }

        [StringLength(100)]
        public string PortoDestino { get; set; }

        [StringLength(100)]
        public string PaisOrigem { get; set; }

        [StringLength(100)]
        public string PaisDestino { get; set; }

        [StringLength(200)]
        public String Observacao { get; set; }

        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public decimal ValorMoedaReais { get; set; }

        //Tudo é feito em cima desse valor
        public decimal ValorMoedaEstrangeira { get; set; }

        public int QuantideContainer { get; set; }

        [Required]
        [StringLength(100)]
        public string Container { get; set; }

        public decimal PISTotal { get; set; }

        public decimal CofinsTotal { get; set; }

        public decimal ICMSTotal { get; set; }

        public decimal IITotal { get; set; }

        public decimal IPITotal { get; set; }

        public decimal ICMSSTTotal { get; set; }

        public decimal TotalCusteio { get; set; }

        #region Not mapped - Calculando em com base nos valores ja persistidos

        [NotMapped]
        public decimal CapataziaEstrangeira { get { return this.CalcCapataziaEstrangeira(); } }

        [NotMapped]
        public decimal IITotalEstrangeira { get { return this.CalcIITotalEstrangeira(); } }

        [NotMapped]
        public decimal IPITotalEstrangeira { get { return this.CalcIPITotalEstrangeira(); } }

        [NotMapped]
        public decimal PISTotalEstrangeira { get { return this.CalcPISTotalEstrangeira(); } }

        [NotMapped]
        public decimal CofinsTotalEstrangeira { get { return this.CalcCofinsTotalEstrangeira(); } }

        [NotMapped]
        public decimal ICMSMoedaEstrangeira { get { return this.CalcICMSMoedaEstrangeira(); } }
        [NotMapped]
        public decimal ICMSSTMoedaEstrangeira { get { return this.CalcICMSSTMoedaEstrangeira(); } }

        #endregion

        public virtual ICollection<ItemCusteio> ItensCusteio { get; set; }

        public virtual ICollection<DespesaCusteio> DespesasCusteio { get; set; }

        public virtual ICollection<CotacaoCusteio> CotacoesMoeda { get; set; }


        public Custeio()
        {
            this.ItensCusteio = new HashSet<ItemCusteio>();
            this.DespesasCusteio = new HashSet<DespesaCusteio>();
            this.CotacoesMoeda = new HashSet<CotacaoCusteio>();
        }



        public void Update(Custeio novo)
        {
            IdCliente = novo.IdCliente;

            DataCalculo = novo.DataCalculo;
            NumeroProcesso = novo.NumeroProcesso;
            ValorFobTotal = novo.ValorFobTotal;
            ValorCapatazia = novo.ValorCapatazia;
            ValorCif = novo.ValorCif;
            Fabricante = novo.Fabricante;
            Exportador = novo.Exportador;
            Incoterms = novo.Incoterms;
            PortoOrigem = novo.PortoOrigem;
            PortoDestino = novo.PortoDestino;
            PaisOrigem = novo.PaisOrigem;
            PaisDestino = novo.PaisDestino;
            Observacao = novo.Observacao;
            ValorMoedaReais = novo.ValorMoedaReais;
            ValorMoedaEstrangeira = novo.ValorMoedaEstrangeira;
            QuantideContainer = novo.QuantideContainer;
            Container = novo.Container;
            PISTotal = novo.PISTotal;
            CofinsTotal = novo.CofinsTotal;
            ICMSTotal = novo.ICMSTotal;
            IITotal = novo.IITotal;
            IPITotal = novo.IPITotal;
            ICMSSTTotal = novo.ICMSSTTotal;
            TotalCusteio = novo.TotalCusteio;

            Usuario = novo.Usuario;
            Cliente = novo.Cliente;

        }
    }
}
