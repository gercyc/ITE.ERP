using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.Enumeradores.TipoMovimentoEnum;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITE.Fiscal.Movimentacoes.NotaFiscal;
using ITE.Fiscal.Movimentacoes.OutrasMovimentacoes;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System.Xml.Serialization;
using System.Xml;
using ITSolution.Framework.Eventos.GridViewEvents;
using ITE.Fiscal.NFe;

namespace ITE.Fiscal.Movimentacoes.ListView
{
    public partial class XFrmGerenciarMovimento : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly Usuario currentUser;
        private readonly EmpresaFilial filialCurrent;
        private readonly TypeFiltroMovimento typeFiltroMovimento;
        private string codigoTpMov;
        private readonly FocusRowChangedEvent _gridFocusUtil;

        public XFrmGerenciarMovimento(Usuario currentUser, TypeFiltroMovimento typeFiltroMovimento, EmpresaFilial filialCurrent)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.typeFiltroMovimento = typeFiltroMovimento;
            this.filialCurrent = filialCurrent;
            this._gridFocusUtil = new FocusRowChangedEvent(gridViewEntradas);

            if (typeFiltroMovimento == TypeFiltroMovimento.Entradas)
                this.Text = "Movimentos de compras/entradas";
            else if (typeFiltroMovimento == TypeFiltroMovimento.Saidas)
                this.Text = "Movimentos de saídas/faturamento";
            else
                this.Text = "Movimentos de transferências/estoque";

            indexarMultiSelCombo();
        }

        #region Eventos gerais
        private void btnCancelarNotaFiscal_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.gridViewEntradas.IsSelectOneRowWarning())
            {
                var op = XMessageIts.Confirmacao("Confirmar cancelamento da nota fiscal ?");

                if (op == DialogResult.Yes)
                {
                    XMessageIts.Mensagem("Opção não disponivel!");
                    //var row = gridViewEntradas.GetFocusedRow<Movimento>();
                    //GERCY
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!String.IsNullOrEmpty(codigoTpMov))
                XFrmWait.StartTask(carregarNotas(codigoTpMov.ToString()), "Carregando Notas Fiscais");
        }

        private void XFrmGerenciarEntrada_Shown(object sender, EventArgs e)
        {
            btnRefresh_ItemClick(null, null);
        }

        private void barBtnAddNf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmNotaFiscal(currentUser, typeFiltroMovimento, filialCurrent).ShowDialog();
        }
        private void barBtnNewMovSimples_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmPedidoCompraCotacao(currentUser, typeFiltroMovimento, filialCurrent).ShowDialog();
        }

        private void gridControlEntradas_DoubleClick(object sender, EventArgs e)
        {
            var notaFiscal = GridViewUtil.GetFocusedRow<Movimento>(gridViewEntradas);

            if (notaFiscal != null)
            {
                if (notaFiscal.TipoMovimento.GeraMovimentoFiscal)
                    new XFrmNotaFiscal(notaFiscal, FormTypeAction.Visualizar, typeFiltroMovimento, currentUser).ShowDialog();
                else
                    new XFrmPedidoCompraCotacao(notaFiscal, FormTypeAction.Visualizar, typeFiltroMovimento, currentUser).ShowDialog();
            }
        }
        private void barBtnSelectColunm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewEntradas.ColumnsCustomization();
        }

        private void barBtnFilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewEntradas.ShowFilterEditor(colNumeroNf);
        }

        private void cbTiposMovimento_EditValueChanged(object sender, EventArgs e)
        {
            cbTiposMovimento.SeparatorChar = '|';
            var selecteds = cbTiposMovimento.GetCheckedItems();
            var ctx = new BalcaoContext();
            ctx.Database.Log = Console.WriteLine;
            if (!String.IsNullOrEmpty(selecteds.ToString()))
            {
                var codigos = selecteds.ToString().Split('|').ToArray();
                var listCodigos = new List<string>();
                foreach (var cod in codigos)
                {
                    var newCod = cod.Substring(0, 7);
                    listCodigos.Add(newCod.TrimEnd());
                }
                var listMovs = ctx.MovimentoSet.Where(m => listCodigos.Contains(m.TipoMovimento.CodigoTipoMovimento));
                gridControlEntradas.DataSource = listMovs.ToList();
                gridControlEntradas.Update();
                Console.WriteLine(selecteds);
            }
        }

        private void barBtnFitCol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewEntradas.BestFitColumns();
        }


        #endregion

        #region MasterdetailRow
        private void gridViewEntradas_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {

            //NotaFiscalCapa c = (NotaFiscalCapa)gridViewEntradas.GetRow(e.RowHandle);
            //e.IsEmpty = c.NotaFiscalItems.Count == 0;
        }

        private void gridViewEntradas_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            //e.RelationCount = 1;
        }

        private void gridViewEntradas_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            //e.RelationName = "NotaFiscalItems";

        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            //NotaFiscalCapa c = (NotaFiscalCapa)gridViewEntradas.GetRow(e.RowHandle);
            //var bs = new BindingSource(c, "NotaFiscalItems");
            //var ds = bs.DataSource as NotaFiscalCapa;
            //List<NotaFiscalItem> items = ds.NotaFiscalItems.ToList();
            //var query = from p in items
            //            select new { p.SequencialItem, p.Produto.DescricaoProduto, p.Quantidade, p.ValorUnitario, p.TotalItem, p.Cfop.CodigoCfop, p.RegraFiscal };
            //bs.DataSource = query.ToList();
            //e.ChildList = bs;
        }
        #endregion

        #region Metodos
        private async Task carregarNotas(string tipo)
        {
            var ctx = new BalcaoContext();

            //if (gridControlEntradas.InvokeRequired)
            var notasFiscais = await ctx.MovimentoDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
                gridControlEntradas.DataSource = notasFiscais.Where(m => m.TipoMovimento.CodigoTipoMovimento.StartsWith(codigoTpMov));
                this._gridFocusUtil.KeepFocusedRowChanged();
                this.gridViewEntradas.Focus();
            }));
        }
        //Indexar o comboMulti itens
        private void indexarMultiSelCombo()
        {
            var ctx = new BalcaoContext();
            var cod = ParseUtil.ToInt(typeFiltroMovimento).ToString();
            this.codigoTpMov = cod;
            var list = ctx.TipoMovimentoDao.Where(tp => tp.CodigoTipoMovimento.StartsWith(cod.ToString())).ToArray();
            cbTiposMovimento.Items.AddRange(list);
        }
        #endregion

        private void barSubGerarXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var notaFiscal = GridViewUtil.GetFocusedRow<Movimento>(gridViewEntradas);
                    var manager = new NfeManager();

                    manager.GerarNFe(notaFiscal);

                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmTransferenciaEstoque().ShowDialog();
        }
    }
}