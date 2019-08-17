using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;
using ITE.Entidades.Enumeradores.TipoMovimentoEnum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITE.Entidades.POCO.Sales;
using System.Collections.Generic;

namespace ITE.Entidades.POCO.Contabil
{
    [Serializable]
    [Table("TipoMovimento")]
    public class TipoMovimento
    {
        [Key]//pk                  
        [Display(Name = "ID Tipo Movimento")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdTipoMovimento { get; set; }

        #region Propriedades básicas
        [StringLength(6)]
        public string CodigoTipoMovimento { get; set; }
        [StringLength(200)]
        public string DescricaoTipoMovimento { get; set; }
        public TypeCategoriaTipoMovimento CategoriaTipoMovimento { get; set; }
        public TypeDirecao Direcao { get; set; }
        public TypeConfigNumeracao Numeracao { get; set; }
        public bool EmiteNFe { get; set; }

        public bool MovimentarEstoque { get; set; }
        public Nullable<int> IdLocalEstoque { get; set; }

        [ForeignKey("IdLocalEstoque")]
        public virtual LocalEstoque LocalEstoque { get; set; }

        public bool GeraMovimentoFiscal { get; set; }

        public ICollection<Movimento> Movimentos { get; set; }
        #endregion

        #region Financeiro
        public bool GerarFaturamento { get; set; }
        //public int ConfigFormaPagamento { get; set; }
        [ForeignKey("IdFormaPagamentoDefault")]
        public virtual FormaPagamento FormaPagamento { get; set; }
        public Nullable<int> IdFormaPagamentoDefault { get; set; }
        #endregion

        #region Contabil/Gerencial
        public bool InformarCentro { get; set; }
        //public int ConfigCentroCusto { get; set; }
        [ForeignKey("IdCentroCustoDefault")]
        public virtual CentroCusto CentroCusto { get; set; }
        public Nullable<int> IdCentroCustoDefault { get; set; }
        #endregion

        public TipoMovimento()
        {
            this.Movimentos = new HashSet<Movimento>();
        }
        public void Update(TipoMovimento novo)
        {
            this.CodigoTipoMovimento = novo.CodigoTipoMovimento;
            this.DescricaoTipoMovimento = novo.DescricaoTipoMovimento;
            this.CategoriaTipoMovimento = novo.CategoriaTipoMovimento;
            this.Direcao = novo.Direcao;
            this.MovimentarEstoque = novo.MovimentarEstoque;
            this.LocalEstoque = novo.LocalEstoque;
            this.IdLocalEstoque = novo.IdLocalEstoque;
            this.GeraMovimentoFiscal = novo.GeraMovimentoFiscal;
            this.EmiteNFe = novo.EmiteNFe;
            this.GerarFaturamento = novo.GerarFaturamento;
            this.FormaPagamento = novo.FormaPagamento;
            this.IdFormaPagamentoDefault = novo.IdFormaPagamentoDefault;

            this.InformarCentro = novo.InformarCentro;
            this.CentroCusto = novo.CentroCusto;
            this.IdCentroCustoDefault = novo.IdCentroCustoDefault;
        }
        public override string ToString()
        {
            return this.CodigoTipoMovimento + " - " + this.DescricaoTipoMovimento;
        }
    }
}
