using ITE.Entidades.Enumeradores.RegraFiscalEnum;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.Sales;
using ITE.Fiscal.NFe.XMLSchemas.ClassesNFe;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ITE.Entidades.POCO.Fiscal
{

    [Serializable]
    [Table("Movimento")]
    public class Movimento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMovimento { get; set; }

        public Nullable<int> IdCliFor { get; set; }

        [ForeignKey("IdCliFor")]
        public virtual CliFor CliFor { get; set; }

        public int IdFilial { get; set; }

        [ForeignKey("IdFilial")]
        public virtual EmpresaFilial EmpresaFilial { get; set; }

        public Nullable<int> IdModelo { get; set; }

        [ForeignKey("IdModelo")]
        public virtual ModeloDocumentoFiscal ModeloDocumentoFiscal { get; set; }

        public int IdSituacao { get; set; }

        [ForeignKey("IdSituacao")]
        public virtual SituacaoDocumentoFiscal SituacaoDocumentoFiscal { get; set; }

        public DateTime DataEntrada { get; set; }

        public DateTime DataEmissao { get; set; }

        [StringLength(10)]
        public string NumeroMovimento { get; set; }

        [StringLength(44)]
        public string ChaveAcessoNf { get; set; }

        public decimal TotalMovimento { get; set; }

        public decimal TotalProdutos { get; set; }

        public decimal? ValorFrete { get; set; }

        public decimal? ValorDesconto { get; set; }

        public decimal? ValorBaseICMS { get; set; }

        public decimal? ValorICMS { get; set; }

        public decimal? ValorBaseICMSST { get; set; }

        public decimal? ValorICMSST { get; set; }

        public decimal? ValorSeguro { get; set; }

        [Column("ValorDespesas")]
        public decimal? ValorDespesasAcessorias { get; set; }
        public TypeDirecao DirecaoMovimento { get; set; }

        [StringLength(8000)]
        public string Serie { get; set; }

        [StringLength(8000)]
        public string SubSerie { get; set; }

        [StringLength(8000)]
        public string Observacoes { get; set; }

        [Required]
        public TypeModalidadeFrete IndicadorFrete { get; set; }

        public Nullable<int> IdFormaPagamento { get; set; }

        [ForeignKey("IdFormaPagamento")]
        public virtual FormaPagamento FormaPagamento { get; set; }

        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public Nullable<int> IdCentroCusto { get; set; }

        [ForeignKey("IdCentroCusto")]
        public virtual CentroCusto CentroCusto { get; set; }
        public Nullable<int> IdLocalEstoque { get; set; }

        [ForeignKey("IdLocalEstoque")]
        public virtual LocalEstoque LocalEstoque { get; set; }

        public int IdTipoMovimento { get; set; }
        public virtual TransportadorMovimento Transportador { get; set; }

        [ForeignKey("IdTipoMovimento")]
        public virtual TipoMovimento TipoMovimento { get; set; }

        public virtual ICollection<ItemMovimento> ItensMovimento { get; set; }

        public virtual ICollection<TransacoesProduto> TransacoesProdutos { get; set; }

        public virtual ICollection<LancamentoFinanceiro> Parcelas { get; set; }

        public Movimento()
        {
            this.TransacoesProdutos = new HashSet<TransacoesProduto>();
            this.ItensMovimento = new HashSet<ItemMovimento>();
            this.Parcelas = new HashSet<LancamentoFinanceiro>();
        }

        public Movimento(
            CliFor cliForn, ModeloDocumentoFiscal modeloNf, EmpresaFilial filialNf,
            TypeDirecao direcaoMov, string numNF, DateTime dtEmissaoNf, DateTime dtEntradaNf, int situacaoDocumento,
            string chaveAcessoNf, decimal valorFrete, decimal valorDesconto, decimal valorBaseICMS,
            decimal valorICMS, decimal valorBaseICMSST, decimal valorICMSST, decimal valorSeguro,
            decimal valorDespesas, decimal valorTotalProdutos, decimal totalNF, string serie, string subserie)
        {
            ItensMovimento = new HashSet<ItemMovimento>();
            this.Parcelas = new HashSet<LancamentoFinanceiro>();
            this.IdCliFor = cliForn.IdCliFor;
            this.IdModelo = modeloNf.IdModelo;
            this.IdFilial = filialNf.IdFilial;
            this.DirecaoMovimento = direcaoMov;
            this.NumeroMovimento = numNF;
            this.DataEmissao = dtEmissaoNf;
            this.DataEntrada = dtEntradaNf;
            this.IdSituacao = situacaoDocumento;
            this.ChaveAcessoNf = chaveAcessoNf;
            this.ValorFrete = valorFrete;
            this.ValorDesconto = valorDesconto;
            this.ValorBaseICMS = valorBaseICMS;
            this.ValorICMS = valorICMS;
            this.ValorBaseICMSST = valorBaseICMSST;
            this.ValorICMSST = valorICMSST;
            this.ValorSeguro = valorSeguro;
            this.ValorDespesasAcessorias = valorDespesas;
            this.TotalProdutos = valorTotalProdutos;
            this.TotalMovimento = totalNF;
            this.Serie = serie;
            this.SubSerie = subserie;
        }

        //Movimento nao fiscal
        public Movimento(
            CliFor cliForn, EmpresaFilial filialNf,
            TypeDirecao direcaoMov, string numNF, DateTime dtEmissaoNf, DateTime dtEntradaNf,
            decimal valorFrete, decimal valorDesconto, decimal valorBaseICMS,
            decimal valorICMS, decimal valorBaseICMSST, decimal valorICMSST, decimal valorSeguro,
            decimal valorDespesas, decimal valorTotalProdutos, decimal totalNF, string serie, string subserie)
        {
            ItensMovimento = new HashSet<ItemMovimento>();
            this.Parcelas = new HashSet<LancamentoFinanceiro>();

            if (cliForn != null)
                this.IdCliFor = cliForn.IdCliFor;

            this.IdFilial = filialNf.IdFilial;
            this.DirecaoMovimento = direcaoMov;
            this.NumeroMovimento = numNF;
            this.DataEmissao = dtEmissaoNf;
            this.DataEntrada = dtEntradaNf;
            this.ValorFrete = valorFrete;
            this.ValorDesconto = valorDesconto;
            this.ValorBaseICMS = valorBaseICMS;
            this.ValorICMS = valorICMS;
            this.ValorBaseICMSST = valorBaseICMSST;
            this.ValorICMSST = valorICMSST;
            this.ValorSeguro = valorSeguro;
            this.ValorDespesasAcessorias = valorDespesas;
            this.TotalProdutos = valorTotalProdutos;
            this.TotalMovimento = totalNF;
            this.Serie = serie;
            this.SubSerie = subserie;
        }

        public void Update(Movimento capa, Nullable<bool> cancelaReferencia = false)
        {
            if (capa != null)
            {
                this.IdCliFor = capa.IdCliFor;
                this.IdModelo = capa.IdModelo;
                this.IdFilial = capa.IdFilial;
                this.IdFormaPagamento = capa.IdFormaPagamento;
                this.IdTipoMovimento = capa.IdTipoMovimento;
                this.IdLocalEstoque = capa.IdLocalEstoque;
                this.IdCentroCusto = capa.IdCentroCusto;
                this.TipoMovimento = capa.TipoMovimento;
                this.NumeroMovimento = capa.NumeroMovimento;
                this.DataEmissao = capa.DataEmissao;
                this.DataEntrada = capa.DataEntrada;
                this.IdSituacao = capa.IdSituacao;
                this.ChaveAcessoNf = capa.ChaveAcessoNf;
                this.ValorFrete = capa.ValorFrete;
                this.ValorDesconto = capa.ValorDesconto;
                this.ValorBaseICMS = capa.ValorBaseICMS;
                this.ValorICMS = capa.ValorICMS;
                this.ValorBaseICMSST = capa.ValorBaseICMSST;
                this.ValorICMSST = capa.ValorICMSST;
                this.ValorSeguro = capa.ValorSeguro;
                this.ValorDespesasAcessorias = capa.ValorDespesasAcessorias;
                this.TotalProdutos = capa.TotalProdutos;
                this.TotalMovimento = capa.TotalMovimento;
                this.Serie = capa.Serie;
                this.SubSerie = capa.SubSerie;
                this.Observacoes = capa.Observacoes;

                this.CliFor = capa.CliFor;
                this.CentroCusto = capa.CentroCusto;
                this.EmpresaFilial = capa.EmpresaFilial;
                this.FormaPagamento = capa.FormaPagamento;
                this.ModeloDocumentoFiscal = capa.ModeloDocumentoFiscal;
                this.SituacaoDocumentoFiscal = capa.SituacaoDocumentoFiscal;
                this.Usuario = capa.Usuario;

                if (this.Transportador != null)
                {
                    this.Transportador.Update(capa.Transportador);
                }
                else
                    this.Transportador = capa.Transportador;


                //this.Transportador = capa.Transportador;
                if (cancelaReferencia == true)
                {
                    this.CliFor = null;
                    this.CentroCusto = null;
                    this.EmpresaFilial = null;
                    this.FormaPagamento = null;
                    this.ModeloDocumentoFiscal = null;
                    this.SituacaoDocumentoFiscal = null;
                    this.Usuario = null;
                }
            }

            CalculaValoresIcms();
        }

        public decimal CalcularTotaisNF()
        {
            var totalNF = 0M;

            totalNF = (this.ValorFrete.Value +
                        this.ValorSeguro.Value +
                        this.ValorDespesasAcessorias.Value +
                        this.TotalProdutos)
                        - this.ValorDesconto.Value;

            return totalNF;
        }
        public decimal CalculaTotalProdutos()
        {

            //pode mandar o linq trazer a soma tbm
            //bem suave em uma linha 
            //var total = this.NotaFiscalItems.Sum(i => i.TotalItem);

            var totalProdutos = 0M;
            if (this.ItensMovimento != null)
            {
                this.ItensMovimento.ToList().ForEach(it => { totalProdutos += it.TotalItem; });
            }
            return totalProdutos;
        }

        public decimal ObtemBaseImposto(int idImposto)
        {
            var baseImposto = 0M;
            if (this.ItensMovimento != null)
            {
                this.ItensMovimento.ToList().ForEach(it =>
                {
                    if (it.ImpostosItemMovimento != null)
                    {
                        it.ImpostosItemMovimento.ToList()
                        .Where(ip => ip.IdImposto == idImposto).ToList()
                        .ForEach(imp => { baseImposto += imp.BaseCalculo; });
                    }
                });
            }
            return baseImposto;
        }
        public decimal ObtemValorImposto(int idImposto)
        {
            var valorImposto = 0M;
            if (this.ItensMovimento != null)
            {
                this.ItensMovimento.ToList().ForEach(it =>
                {
                    if (it.ImpostosItemMovimento != null)
                    {
                        it.ImpostosItemMovimento.ToList()
                        .Where(ip => ip.IdImposto == idImposto).ToList()
                        .ForEach(imp => { valorImposto += imp.ValorImposto; });
                    }
                });
            }
            return valorImposto;
        }
        public void CalculaValoresIcms()
        {
            this.ValorBaseICMS = ObtemBaseImposto(2);
            this.ValorICMS = ObtemValorImposto(2);
            this.ValorBaseICMSST = ObtemBaseImposto(5);
            this.ValorBaseICMSST = ObtemValorImposto(5);
        }
        public void GerarParcelas(Movimento notaFiscal)
        {
            if (notaFiscal != null)
            {
                LancamentoFinanceiro lancamento;
                LancamentoFinanceiro lancamentoAnterior = new LancamentoFinanceiro(notaFiscal);
                int numParcelas = notaFiscal.FormaPagamento.NumeroParcelas;
                int sequencial = 1;
                this.Parcelas.Clear();

                //se for a vista, criar somente uma parcela
                if (notaFiscal.FormaPagamento.TipoFormaPagamento == Enumeradores.TypeFormaPagamento.Dinheiro)
                {
                    lancamento = new LancamentoFinanceiro(notaFiscal);

                    lancamento.SequencialParcela = 1;
                    lancamento.DiasPrazo = 0;
                    lancamento.DataVencimento = notaFiscal.DataEmissao;

                    lancamento.Observacao = "NF Nº " + notaFiscal.NumeroMovimento + " DE " + notaFiscal.CliFor.RazaoSocial
                    + ". LANCTO Nº " + sequencial + " DE " + numParcelas;

                    lancamento.IdNotaFiscal = notaFiscal.IdMovimento;
                    lancamento.ValorLancamento = notaFiscal.TotalMovimento / numParcelas;
                    lancamento.IdFormaPagamento = notaFiscal.IdFormaPagamento;
                    lancamento.IdCentroCusto = notaFiscal.IdCentroCusto;
                    lancamento.SequencialParcela = sequencial;
                    lancamento.RecCreatedBy = notaFiscal.IdUsuario;
                    lancamento.RecCreatedDate = DateTime.Now;
                    this.Parcelas.Add(lancamento);
                }
                //senao continue com a criacao das demais parcelas
                else
                {

                    for (int i = 0; i < numParcelas; i++)
                    {
                        lancamento = new LancamentoFinanceiro(notaFiscal);

                        lancamento.SequencialParcela = i;

                        //se for a 1a parcela, calcular dias de prazo e data de vencimento com base na emissao da nota
                        if (sequencial == 1)
                        {
                            lancamento.DiasPrazo = DataUtil.CalcularDias(notaFiscal.DataEmissao, DataUtil.GetNextDate(notaFiscal.DataEmissao));
                            lancamento.DataVencimento = DataUtil.GetNextDate(notaFiscal.DataEmissao);
                        }
                        //senao use o objeto 'lancamentoAnterior'
                        else
                        {
                            lancamento.DiasPrazo = DataUtil.CalcularDias(notaFiscal.DataEmissao, DataUtil.GetNextDate(lancamentoAnterior.DataVencimento));
                            lancamento.DataVencimento = DataUtil.GetNextDate(lancamentoAnterior.DataVencimento);
                        }

                        lancamento.Observacao = "NF Nº " + notaFiscal.NumeroMovimento + " DE " + notaFiscal.CliFor.RazaoSocial
                        + ". LANCTO Nº " + sequencial + " DE " + numParcelas;

                        lancamento.IdNotaFiscal = notaFiscal.IdMovimento;
                        lancamento.ValorLancamento = notaFiscal.TotalMovimento / numParcelas;
                        lancamento.IdFormaPagamento = notaFiscal.IdFormaPagamento;
                        lancamento.SequencialParcela = sequencial;

                        lancamentoAnterior = lancamento;
                        this.Parcelas.Add(lancamento);
                        //i++;
                        sequencial++;
                    }
                }
            }
        }
        public Movimento Clone(Movimento notafiscal)
        {
            return (Movimento)this.MemberwiseClone();
        }

    }
}
