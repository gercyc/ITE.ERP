using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.DaoManager.SlateManager;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Ardosia.Minning;
using ITE.Entidades.Repositorio;
using ITE.Reports.Relatorios.ArdosiaReport;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Slate.Forms.ControleCarga.ListView
{
    public partial class XFrmOrdemCargaListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Usuario Usuario { get; set; }

        private XFrmOrdemCargaListView()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        public XFrmOrdemCargaListView(Usuario user) : this()
        {
            this.Usuario = user;
        }

        public async Task<List<OrdemCarga>> GetSales()
        {
            using (var ctx = new SlateContext())
            {
                DateTime dtInicio = dtEditInicio.Value;
                DateTime dtFim = dtEditFinal.Value;
                var result = await ctx.OrdensCargas
                    .Where(l=>l.DataCarregamento >= dtInicio && l.DataCarregamento <= dtFim)
                    .ToListAsync();

                return result;
            }
        }

        private async Task carregarOrdemCargas()
        {
            gridViewOrdemCargas.FindFilterText = searchControl1.Text;

            var result = await GetSales();
            this.gridControlProposta.Invoke(new MethodInvoker(delegate
            {
                gridControlProposta.DataSource = result;
            }));

        }

        private void setDate(DateTime dtInicio, DateTime dtFim)
        {
            this.dtEditInicio.Value = dtInicio;
            this.dtEditFinal.Value = dtFim;
        }

        #region Eventos

        private void barBtnImprir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (gridViewOrdemCargas.IsSelectOneRowWarning())
            {
                var o = gridViewOrdemCargas.GetFocusedRow<OrdemCarga>();
                if (o != null)
                    new RptOrdemCarga(o).Run();
            }
        }

        private void barBtnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewOrdemCargas.IsSelectOneRowWarning() && this.Usuario.IsAdmin)
            {
                var ordem = gridViewOrdemCargas.GetFocusedRow<OrdemCarga>();

                var op = XMessageIts.Confirmacao("Deseja cancelar a ordem de carga: " + ordem.IdOrdemCarga + " ?");
                if (op == DialogResult.Yes)
                {
                    if (new OrdemCargaDaoManager().CancelarOrdemCarga(ordem))
                    {
                        searchControl1.EditValue = ordem.IdOrdemCarga.ToString();
                        gridViewOrdemCargas.RefreshData();
                    }
                }
            }
            else
            {
                XMessageIts.Erro("Você não tem permissão para realizar está tarefa !", "*** Acesso Negado ***");
            }
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarOrdemCargas(), "Carregando OrdemCargas e Cotações");

            //1 Opcao
            //Task.Factory.StartNew(CarregarProposta);
            //Task.Run(() => CarregarProposta());
            // new Thread(CarregarProposta).Start();

            //2 Opcao
            //var lista = await new SlateContext().OrdemCargaDao.WhereAsync(v => !v.StatusProposta.Equals(StatusProduto.Cancelado.ToString()));
            //gridControlOrdemCargas.DataSource = lista;


        }

        private void barBtnAlterar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewOrdemCargas.IsSelectOneRowWarning())
            {
                var row= gridViewOrdemCargas.GetFocusedRow<OrdemCarga>();
                var os = OrdemCargaDaoManager.FindOrdemCarga(row);

                var frmOs = new View.XFrmOrdemCarga(os, this.Usuario);
                
                frmOs.ShowDialog();

                if (frmOs.isUpdateOrdemCarga)
                {
                    row.Update(OrdemCargaDaoManager.FindOrdemCarga(row));
                    gridViewOrdemCargas.RefreshData();
                }
            }
        }

        private void XFrmUtilOrdemCarga_Shown(object sender, EventArgs e)
        {
            this.cbFiltro.SelectedIndex = 1;
            barBtnAtualizar_ItemClick(null, null);
        }

        private void gridViewProposta_DoubleClick(object sender, EventArgs e)
        {
            barBtnDetalhes_ItemClick(null, null);
        }

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
                var ID = ParseUtil.ToInt(pesquisa);
                if (!string.IsNullOrEmpty(pesquisa))
                {
                    //encapsular isso posteriormente
                    using (var ctx = new SlateContext())
                    {
                        ctx.LazyLoading(false);
                        List<OrdemCarga> lista;
                        if (ID > 0)
                        {

                            //carregando apenas o que for visivel
                            lista = await ctx.OrdensCargas
                                            .Include(v => v.Cliente)
                                            .Include(v => v.Usuario)
                                            .Where(v => v.IdOrdemCarga == ID)
                                            .ToListAsync();
                        }
                        else
                        {


                            lista = await ctx.OrdensCargas
                                            .Include(v => v.Cliente)
                                            .Include(v => v.Usuario)
                                            .Where(l => l.Cliente.RazaoSocial.Contains(pesquisa))
                                                .ToListAsync();
                        }

                        gridControlProposta.DataSource = lista;


                        this.gridViewOrdemCargas.FindFilterText = pesquisa;
                    }
                }

            }
        }

        private void barBtnDetalhes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewOrdemCargas.IsSelectOneRowWarning())
            {
                var o = gridViewOrdemCargas.GetFocusedRow<OrdemCarga>();
                var ordem = OrdemCargaDaoManager.FindOrdemCarga(o);
                new View.XFrmDetalhesOrdemCarga(ordem).ShowDialog();
            }
        }

        private void gridViewOrdemCargas_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //if (e.Action == CollectionChangeAction.Refresh)
            //gridViewOrdemCargas.UnselectRow(gridViewOrdemCargas.FocusedRowHandle);

            if (e.Action == CollectionChangeAction.Add)
            {

            }
        }


        private void barBtnOrdemCarga_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ITE.Slate.Forms.ControleCarga.View.XFrmOrdemCarga(Usuario).ShowDialog();
        }

        private void barBtnExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewOrdemCargas.ExportXlsxToDisk();
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFiltro.SelectedIndex;
            //0 nao faz nada
            if (index != 0)
            {
                DateTime dt1 = dtEditInicio.Value;
                DateTime dt2 = dtEditFinal.Value;
                int mes = DateTime.Now.Month;
                //Por Período
                //Próximo Mês
                //Mês Atual
                //Mês Anterior
                //Por Dia
                //Por Ano
                switch (index)
                {


                    //Mês Atual
                    case 1:
                        dt1 = DataUtil.GetDataInicialDoMes(mes);
                        dt2 = DataUtil.GetDataFinalDoMes(mes);

                        break;

                    //Mês Anterior

                    case 2:
                        mes = DateTime.Now.Month - 1;
                        dt1 = DataUtil.GetDataInicialDoMes(mes);
                        dt2 = DataUtil.GetDataFinalDoMes(mes);
                        break;


                    //Por Dia
                    case 3:
                        dt1 = DateTime.Now;
                        dt2 = DateTime.Now;
                        break;

                    //Por Ano
                    case 4:
                        //Todas as vendas em aberto do ano recorrente
                        dt1 = DataUtil.GetDataInicialDoMes(1);
                        dt2 = DataUtil.GetDataFinalDoMes(12);
                        break;
                }
                setDate(dt1, dt2);
            }

        }

        private async void btnFiltrarOrdens_Click(object sender, EventArgs e)
        {

            using (var ctx = new SlateContext())
            {
                gridViewOrdemCargas.FindFilterText = "";
                var dtInicio = dtEditInicio.Value.Date.ValidateDate();
                var dtFim = dtEditFinal.Value.Date.ValidateDate();

                var lista = await ctx.OrdemCargaDao
                    .WhereAsync(p => p.DataCarregamento >= dtInicio
                                     && p.DataCarregamento <= dtFim);
                gridControlProposta.DataSource = lista;
                gridViewOrdemCargas.ExpandAllGroups();

            }

        }

        private void dtEditInicio_Leave(object sender, EventArgs e)
        {
            this.cbFiltro.SelectedIndex = 0;
        }

        private void dtEditInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFiltrarOrdens_Click(null, null);
        }
        #endregion Eventos
    }
}