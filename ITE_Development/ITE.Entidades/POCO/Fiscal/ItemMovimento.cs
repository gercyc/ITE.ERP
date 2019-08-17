using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITE.Entidades.POCO.Sales;

namespace ITE.Entidades.POCO.Fiscal
{
    /// <summary>
    /// Falar sobre o diagrama de classe 
    /// </summary>
    [Serializable]
    [Table("ItemMovimento")]
    public class ItemMovimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdItem { get; set; }
        public int IdMovimento { get; set; }
        public int IdProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal TotalItem { get; set; }
        public int? IdCfop { get; set; }
        public int SequencialItem { get; set; }
        public decimal ValorDesconto { get; set; }
        public int IndicadorMovFisica { get; set; }//0 = SIM, 1 = NÃO      

        public int? IdRegraFiscal { get; set; }

        #region Chaves estrangeiras
        [ForeignKey("IdCfop")]
        public virtual Cfops Cfop { get; set; }
        [ForeignKey("IdMovimento")]
        public virtual Movimento Movimento { get; set; }
        [ForeignKey("IdProduto")]
        public virtual Produto Produto { get; set; }
        [ForeignKey("IdRegraFiscal")]
        public virtual RegraFiscal RegraFiscal { get; set; }
        #endregion

        public virtual ICollection<ImpostoItemMovimento> ImpostosItemMovimento { get; set; }

        public ItemMovimento()
        {
            this.ImpostosItemMovimento = new HashSet<ImpostoItemMovimento>();
        }
        public ItemMovimento(Produto produto, Decimal valorUnitario, Decimal quantidade, List<ImpostoItemMovimento> impostos, Cfops cfopItem)
        {
            this.ImpostosItemMovimento = new HashSet<ImpostoItemMovimento>();
            IdProduto = produto != null ? produto.IdProduto : 0;
            IdCfop = cfopItem != null ? cfopItem.IdCfop : 0;
            Produto = produto;
            Cfop = cfopItem;
            //NotaFiscalItemImposto = impostos;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            TotalItem = quantidade * valorUnitario;
            foreach (var item in impostos)
            {
                ImpostosItemMovimento.Add(item);
            }            
        }
        public ItemMovimento(Produto produto, Decimal valorUnitario, Decimal quantidade)
        {
            ImpostosItemMovimento = new HashSet<ImpostoItemMovimento>();
            IdProduto = produto != null ? produto.IdProduto : 0;
            Produto = produto;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            TotalItem = quantidade * valorUnitario;
        }
        public void Update(ItemMovimento item)
        {
            if (item != null)
            {
                IdProduto = item.IdProduto;
                IdCfop = item.IdCfop;
                Produto = item.Produto;
                Cfop = item.Cfop;
                ValorUnitario = item.ValorUnitario;
                Quantidade = item.Quantidade;
                TotalItem = ValorUnitario * Quantidade;
                IdRegraFiscal = item.IdRegraFiscal;
                RegraFiscal = item.RegraFiscal;

                }
            }

        public void CriarImpostos(RegraFiscal regraFiscal)
        {
            foreach (var impostoTipoMov in regraFiscal.ImpostosRegraFiscal)
            {
                ImpostoItemMovimento impostoAdd = new ImpostoItemMovimento();
                impostoAdd.IdItem = this.IdItem;
                impostoAdd.Aliquota = impostoTipoMov.Aliquota;
                impostoAdd.BaseCalculo = this.TotalItem;
                impostoAdd.IdCst = impostoTipoMov.IdCst;
                impostoAdd.IdImposto = impostoTipoMov.IdImposto;
                impostoAdd.TipoImposto = impostoTipoMov.TipoImposto;
                impostoAdd.TpSitImposto = impostoTipoMov.TipoLancImposto;
                impostoAdd.ValorImposto = impostoAdd.CalcularVlrImposto();
                impostoAdd.SituacaoTributaria = impostoTipoMov.SituacaoTributaria;

                this.ImpostosItemMovimento.Add(impostoAdd);
            }
        }
        public void ClearImpostos()
        {
            this.ImpostosItemMovimento.Clear();
        }

        public ItemMovimento Clone()
        {
            return (ItemMovimento)this.MemberwiseClone();
        }

      
    }
}
