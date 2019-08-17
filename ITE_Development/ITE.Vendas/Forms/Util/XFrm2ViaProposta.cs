using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Reports.Relatorios;
using ITE.Vendas.Forms.ControleVenda;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Vendas.Forms.Util
{
    public partial class XFrm2ViaProposta : DevExpress.XtraEditors.XtraForm
    {

        public XFrm2ViaProposta()
        {
            InitializeComponent();
        }

        private void gridViewProposta_DoubleClick(object sender, EventArgs e)
        {
            var x = gridViewProposta.GetFocusedRow() as Venda;
            if (x != null)
                barBtnDetail_ItemClick(null, null);
        }

        private async Task carregarProposta()
        {
            using (var ctx = new BalcaoContext())
            {
                var lista = await ctx.Vendas
                        .Include(v => v.CliFor)
                        .Include(v => v.ItensVendas)
                        .Include(v => v.Parcelas)
                        .Where(v => v.TipoMovimento == TypeVenda.Venda 
                                && v.StatusVenda != TypeStatusVenda.Cancelada)
                        .OrderByDescending(v => v.DataVenda)
                        .ToListAsync();
                gridControlProposta.DataSource = lista;
            }
        }

        private void barBtnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var value = barEditNumVenda.EditValue;
            if (!string.IsNullOrWhiteSpace(value.ToString()) && !value.ToString().IsContainsLetters())
            {
                int num = ParseUtil.ToInt(value);
                if (num == -1)
                    XMessageIts.Advertencia("Para imprimir utilize o número da venda!");
                else
                    this.Print(num);
            }
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarProposta(), "Carregando Vendas/Cotações");

            //1 Opcao
            //Task.Factory.StartNew(CarregarProposta);

            //2 Opcao
            //var lista = await new BalcaoContext().VendaDao.WhereAsync(v => !v.StatusProposta.Equals(StatusProduto.Cancelado.ToString()));
            //gridControlVendas.DataSource = lista;
        }

        private void gridViewVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                barBtnImprimir_ItemClick(null, null);
        }

        private void gridViewVendas_FocusedRowChanged(object sender,
            DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //foco na coluna da venda
            gridViewProposta.FocusedColumn = colIdVenda;
            //add o valor da venda no campo
            barEditNumVenda.EditValue = gridViewProposta.GetRowCellValue(e.FocusedRowHandle, colIdVenda);
        }

        private void XFrm2ViaProposta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Dispose();
        }

        private void barBtnDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //recupera pelo texto
            Venda v = this.Find(barEditNumVenda.EditValue);

            if (v != null)
                new XFrmDetalhesVenda(v as Venda).ShowDialog();
        }

        private void XFrm2ViaProposta_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }


        #region Interface de controle do form

        /// <summary>
        /// Obtém a proposta a partir do grid ou pelo número da proposta.
        /// </summary>
        /// <returns></returns>
        public Venda Find(object value)
        {
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()) && !value.ToString().IsContainsLetters())
            {
                var ID = ParseUtil.ToInt(value);
                using (var ctx = new BalcaoContext())
                {
                    var v = ctx.VendaDao.Find(ID);

                    if (v == null)
                    {
                        XMessageIts.Advertencia("Proposta não encontrada !", "Aviso");
                        barEditNumVenda.EditValue = "";
                    }
                    else
                        return v;
                }
            }
            else
            {
                XMessageIts.Advertencia("Número da venda/cotação é inválido!");
            }

            return null;
        }

        public void Print(object value)
        {
            Venda v = Find(value);
            if (v != null)
                new RptNotaVenda(v).Run();
        }

        #endregion
    }
}