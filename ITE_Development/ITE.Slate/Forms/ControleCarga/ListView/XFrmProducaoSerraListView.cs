using System;
using System.Threading.Tasks;
using ITE.Entidades.Enumeradores.SlateEnums;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;

namespace ITE.Slate.Forms.ControleCarga.ListView
{
    public partial class XFrmProducaoSerraListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly Usuario _user;

        #region Construtores

        public XFrmProducaoSerraListView(Usuario user)
        {
            InitializeComponent();
            this._user = user;

            if (this._user != null && !this._user.IsAdmin)
                gridViewProducaoSerra.Columns.Remove(colTotalUnitario);

            cbFiltro.SelectedIndex = 1;
            cbFiltro.SelectedIndex = 0;
        }

        #endregion Construtores 

        #region Metodos

        //tirando os anexos a performace aumenta significativamente
        //entao os anexos serao caregados somente quando precisar visualizalos
        private async Task carregarProducaoSerra()
        {
            using (var ctx = new SlateContext())
            {

                gridViewProducaoSerra.FindFilterText = "";
                var data = DateTime.Now;
                int mes = data.Month;
                int ano = data.Year;

                var lista = await ctx.ProducaoSerraDao
                    .WhereAsync(p => p.DataProducao.Month == mes
                            && p.DataProducao.Year == ano);

                gridControlProducaoSerra.DataSource = lista;
                gridViewProducaoSerra.ExpandAllGroups();
            }


        }


        public void RefreshItemClick()
        {
            XFrmWait.StartTask(carregarProducaoSerra(), "Carregando Lançamentos");

        }


        #endregion

        #region Eventos Gerenciamento/Outros

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshItemClick();
        }


        private void barBtnAddSerra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ITE.Slate.Forms.ControleCarga.View.XFrmAddSerra().ShowDialog();

        }
        private void barBtnAddProducaoSerra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ITE.Slate.Forms.ControleCarga.View.XFrmAddProducaoSerra(_user).ShowDialog();
        }
        private void XFrmProducaoSerraListView_Shown(object sender, EventArgs e)
        {
            barBtnRefresh_ItemClick(null, null);
        }



        #endregion


        #region Eventos Utilitarios
        private void barBtnImportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new ITE.Slate.Forms.ControleCarga.Model.XFrmProducaoPedreiraImport(_user, TypeImport.Producao).Show();
            //XFrmWait.ShowSplashScreen("Importando Produção");
            //new ModelProducaoSerra(_user).ImportarProducaoFromTemplate();
            //XFrmWait.CloseSplashScreen();
        }
        private void btnPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewProducaoSerra.ShowPrintPreview();
        }

        private void btnExpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewProducaoSerra.ExportXlsxToDisk();


        }


        #endregion

        #region Eventos do grid


        #endregion

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFiltro.SelectedIndex;
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
        private void setDate(DateTime dtInicio, DateTime dtFim)
        {
            this.dtEditInicio.Value = dtInicio;
            this.dtEditFinal.Value = dtFim;
        }

        private async void btnFiltrarProducao_Click(object sender, EventArgs e)
        {
            using (var ctx = new SlateContext())
            {
                gridViewProducaoSerra.FindFilterText = "";
                var dtInicio = dtEditInicio.Value.Date;
                var dtFim = dtEditFinal.Value.Date;

                var lista = await ctx.ProducaoSerraDao
                    .WhereAsync(p => p.DataProducao >= dtInicio
                                     && p.DataProducao <= dtFim);
                gridControlProducaoSerra.DataSource = lista;
                gridViewProducaoSerra.ExpandAllGroups();

            }

        }

        private void XFrmProducaoSerraListView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Modifiers == System.Windows.Forms.Keys.Control && e.KeyCode == System.Windows.Forms.Keys.Enter)
                btnFiltrarProducao_Click(null, null);
        }
    }
}