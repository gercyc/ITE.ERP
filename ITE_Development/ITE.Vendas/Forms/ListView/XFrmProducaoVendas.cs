using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Sales;
using ITE.Vendas.Forms.ControleVenda;

namespace ITE.Vendas.Forms.ListView
{
    /// <summary>
    /// Demonstrativo de produção de vendas
    /// </summary>
    public partial class XFrmProducaoVendas : DevExpress.XtraEditors.XtraForm
    {
        private List<Venda> vendas;

        public XFrmProducaoVendas()
        {
            InitializeComponent();

            this.panelSomatorio1.AddSomatorio(this.gridControl1, this.gridViewVendas);
        }

        public XFrmProducaoVendas(List<Venda> vendas)
            : this()
        {
            this.vendas = vendas;
        }


        private void carregarVendas()
        {
            //if (gridControl1.InvokeRequired)

            this.Invoke(new MethodInvoker(delegate
            {
                gridControl1.DataSource = this.vendas;
                this.gridViewVendas.Focus();

            }));

            //total das vendas 
            Decimal totalVendas = this.vendas.Sum(c => c.TotalVenda);

            //somente a vista, dinheiro
            Decimal totalVendasaVista = vendas.Where(v =>
                    v.FormaPagamentoVenda.TipoFormaPagamento == TypeFormaPagamento.Dinheiro)
                    .Sum(v => v.TotalVenda);//vendas

            //total somente de vendas a prazo           // != 1 
            Decimal totalVendasaPrazo = vendas.Where(v =>
                    v.FormaPagamentoVenda.TipoFormaPagamento != TypeFormaPagamento.Dinheiro)
                    .Sum(v => v.TotalVenda);//vendas

            //total de descontos nas vendas 
            Decimal totalDesconto = vendas.Where(v =>
                    v.FormaPagamentoVenda.TipoFormaPagamento != TypeFormaPagamento.Dinheiro)
                    .Sum(v => v.ValorDesconto); //descontos

            //total de lucro nas vendas 
            Decimal totalLiquido = 0m;

            //soma todos os preços de compra dos produtos vendidos
            foreach (var v in vendas)
            {
                totalLiquido += v.ItensVendas.ToList().Sum(i => i.Produto.PrecoCompra);
            }
            totalLiquido = totalVendas - totalDesconto - totalLiquido;

            //setar os labels
            lblTotalVendas.Text = "R$ " + totalVendas.ToString("N2");
            lblTotalVendasAvista.Text = "R$ " + totalVendasaVista.ToString("N2");
            lblTotalVendasPrazo.Text = "R$ " + totalVendasaPrazo.ToString("N2");
            lblTotalDesconto.Text = "R$ " + totalDesconto.ToString("N2");
            lblTotalLiquido.Text = "R$ " + totalLiquido.ToString("N2");

        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            carregarVendas();
        }

        private void XFrmProducao_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void gridViewVendas_DoubleClick(object sender, EventArgs e)
        {
            showVendaDetails();
        }

        private void showVendaDetails()
        {
            var row = gridViewVendas.GetFocusedRow() as Venda;
            if (row != null)
            {
                new XFrmDetalhesVenda(row).ShowDialog();
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                showVendaDetails();
        }

        private void XFrmProducao_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}