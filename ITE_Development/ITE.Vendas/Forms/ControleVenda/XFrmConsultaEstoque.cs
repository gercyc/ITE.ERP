using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Enumeradores;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using System.Data.Entity;
using ITSolution.Framework.GuiUtil;

namespace ITE.Vendas.Forms.ControleVenda
{
    public partial class XFrmConsultaEstoque : DevExpress.XtraEditors.XtraForm
    {
        public XFrmConsultaEstoque()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }
        public XFrmConsultaEstoque(Produto p) : this()
        {
            IndexardadosProduto(p);
        }
        private async void IndexardadosProduto(Produto p)
        {
            try
            {
                if (p != null)
                {
                    using (var ctx = new BalcaoContext())
                    {
                        lookUpProduto1.FindSetProduto(p.IdProduto);
                        this.Text = this.Text + " " + p.DescricaoProduto;

                        ctx.LazyLoading(true);
                        var pCurrent = await ctx.Produtos.Where(pr => pr.IdProduto == p.IdProduto)
                            .Include(prd => prd.TransacoesProduto)
                            .FirstOrDefaultAsync();

                        //obtem as movimentacoes dos produtos agrupados por local de estoque e saldo em cada local. Encapsular dps.
                        var q = pCurrent.TransacoesProduto.GroupBy(l => l.LocalEstoque.CodigoLocalEstoque)
                            .Select(s => new SaldoByLocalEstoque
                            {
                                CodigoLocal = s.First().LocalEstoque.CodigoLocalEstoque,
                                Quantidade = (s.Where(t=>t.TipoTransacao == TypeTransacaoProduto.Entrada) != null ?
                                s.Where(t => t.TipoTransacao == TypeTransacaoProduto.Entrada).Sum(qt=>qt.Quantidade) : 0M)
                                -
                                (s.Where(t => t.TipoTransacao == TypeTransacaoProduto.Saida) != null ?
                                s.Where(t => t.TipoTransacao == TypeTransacaoProduto.Saida).Sum(qt => qt.Quantidade) : 0M),
                                Valor = 0M
                            });

                        //from p1 in pCurrent.TransacoesProduto
                        //        group p1.LocalEstoque.CodigoLocalEstoque
                                
                        //        by new
                        //        {
                        //            Local = p1.LocalEstoque.CodigoLocalEstoque,
                        //            Tipo = p1.TipoTransacao,
                        //            p1.Quantidade,
                        //            p1.ValorTotal
                        //        }
                        //        into grp
                        //        select new { grp.Key, grp.Key.Quantidade, grp.Key.Valor };

                        //foreach (var item in q)
                        //{
                        //    var sld = new SaldoByLocalEstoque()
                        //    {
                        //        CodigoLocal = item.Key.Local,
                        //        Quantidade = item.Quantidade
                        //    };
                        //    //exiba valor somente se quantidade eh maior que 0.
                        //    sld.Valor = sld.Quantidade > 0 ? item.Valor : 0M;

                        //    saldos.Add(sld);
                        //}

                        gridControlSaldoLoc.DataSource = q.ToList();

                        var entradas = pCurrent.TransacoesProduto.ToList().Where(t => t.TipoTransacao == TypeTransacaoProduto.Entrada);
                        var saidas = pCurrent.TransacoesProduto.ToList().Where(t => t.TipoTransacao == TypeTransacaoProduto.Saida);

                        var vlrMedioEntradas = 0M;
                        var qtdEntrada = 0M;

                        var vlrMedioSaidas = 0M;
                        var qtdSaida = 0M;

                        if (entradas.Count() > 0)
                        {
                            vlrMedioEntradas = entradas.Sum(v => v.ValorTotal);
                            qtdEntrada = entradas.Sum(e => e.Quantidade);
                            vlrMedioEntradas = vlrMedioEntradas / qtdEntrada;
                        }

                        if (saidas.Count() > 0)
                        {
                            vlrMedioSaidas = saidas.Sum(v => v.ValorTotal);
                            qtdSaida = saidas.Sum(e => e.Quantidade);
                            vlrMedioSaidas = vlrMedioSaidas / qtdSaida;
                        }

                        var saldoFisico = (qtdEntrada - qtdSaida);

                        gridControlEntradas.DataSource = entradas;
                        gridControlSaidas.DataSource = saidas;
                        txtCategoria.Text = pCurrent.CategoriaProduto.NomeCategoriaProduto;
                        rdTipoProduto.SelectedIndex = (int)p.TipoItemProduto;

                        txtPrecoMedioVendas.Text = vlrMedioSaidas.ToString("n2");
                        txtCustoMedio.Text = vlrMedioEntradas.ToString("n2");
                        //txtTotEntradas.Text = qtdEntrada.ToString("n3");
                        //txtTotSaidas.Text = qtdSaida.ToString("n3");
                        txtSaldoEstoque.Text = saldoFisico.ToString("n3");
                        //txtSaldoFisico.Text = saldoFisico.ToString("n3");
                        txtSaldoFisico2.Text = saldoFisico.ToString("n3");
                    }

                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }
        internal class SaldoByLocalEstoque
        {
            public string CodigoLocal { get; set; }
            public decimal Valor { get; set; }
            public decimal Quantidade { get; set; }
        }
    }
}