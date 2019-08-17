using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.Administrativo;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Eventos.GridViewEvents;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;

namespace ITE.Vendas.Forms.ListView
{
    public partial class XFrmCliForListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CliFor ClienteFocused { get; set; }
        private readonly FocusRowChangedEvent _gridFocusUtil;

        public XFrmCliForListView()
        {
            InitializeComponent();
            this._gridFocusUtil = new FocusRowChangedEvent(gridViewCliente);
        }

        public XFrmCliForListView(CliFor cliFor)
            : this()
        {

            this.WindowState = FormWindowState.Normal;
            this.colCelular.Visible = false;
            this.colTelefoneComercial.Visible = false;
            this.colEmail.Visible = false;
            this.MaximizeBox = false;
            this.gridViewCliente.Appearance.Row.Font = new Font("Tahoma", 9F);


            this.gridControlCliente.DataSource = cliFor;
        }

        private async Task carregarCliFor()
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);
                //performance em ate 60% mais rapido
                var lista = await ctx.CliFors
                    .Include(c => c.Enderecos)
                    .Include(c => c.AtividadesPrincipais)
                    .Include(c => c.AtividadesSecundarias)
                    .Include(c => c.ContasBancariasCliFor)
                    .ToListAsync();

                gridViewCliente.FindFilterText = "";
                gridControlCliente.DataSource = lista;

                if (lista != null)
                    this._gridFocusUtil.KeepFocusedRowChanged();

            }
        }

        #region Eventos
        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarCliFor(), "Carregando Clientes");

        }

        private void barBtnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var xFrmCliFor = new XFrmCliForView();
            xFrmCliFor.ShowDialog();

            if (xFrmCliFor.IsSave)
            {
                barBtnAtualizar_ItemClick(null, null);

            }
        }

        private void barBtnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var c = gridViewCliente.GetFocusedRow() as CliFor;
            if (c != null && c.RazaoSocial != "CONSUMIDOR")
                new XFrmCliForView(c).ShowDialog();
        }

        private void gridViewCliente_DoubleClick(object sender, EventArgs e)
        {
            barBtnAlterar_ItemClick(null, null);
        }

        private void gridViewCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                barBtnAlterar_ItemClick(null, null);
        }

        private void gridViewCliente_CustomColumnDisplayText(object sender,
            DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == colCpfCnpj)
            {
                string cpfCnpj = StringUtilIts.ToCpfCnpj(StringUtilIts.FixString("" + e.Value));
                e.DisplayText = cpfCnpj;
            }
        }

        private void XFrmGerenciarCliFor_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void barBtnCreditos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewCliente.IsSelectOneRowWarning())
                new XFrmCreditoCliente(gridViewCliente.GetFocusedRow<CliFor>()).Show();
        }
        #endregion

        #region Search Control
        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            string search = "" + searchControl1.EditValue;

            if (string.IsNullOrEmpty(search))
            {
                barBtnAtualizar_ItemClick(null, null);

            }
        }

        private async void searchControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pesquisa = "" + searchControl1.EditValue;
                if (!string.IsNullOrEmpty(pesquisa))
                {

                    using (var ctx = new BalcaoContext())
                    {

                        ctx.LazyLoading(false);

                        //carregando apenas os clientes
                        var lista = await ctx.CliFors
                            .Include(c => c.Enderecos)
                            .Include(c => c.AtividadesPrincipais)
                            .Include(c => c.AtividadesSecundarias)
                            .Where(c => c.RazaoSocial.Contains(pesquisa))
                            .ToListAsync();

                        gridControlCliente.DataSource = lista;
                        this.gridViewCliente.FindFilterText = pesquisa;
                    }
                }

            }
        }

        #endregion

    }
}
