using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Entities;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Forms;

namespace ITE.Forms.OldVersion
{
    public partial class XFrmConfigParam_OLD : DevExpress.XtraEditors.XtraForm
    {
        private List<Parametro> _parametros;
        public XFrmConfigParam_OLD()
        {
            _parametros = new List<Parametro>();
            InitializeComponent();
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void XFrmConfigParam_Shown(object sender, EventArgs e)
        {
            barBtRefresh_ItemClick(null, null);
        }


        private async Task carregarParametros()
        {
            var ctx = new BalcaoContext();

            //if (gridControlParam.InvokeRequired)
            var parametros = await ctx.ParametroDao.FindAllAsync();
            this.Invoke(new MethodInvoker(delegate
            {
                this._parametros = parametros;
                gridControlParam.DataSource = this._parametros;
                this.gridViewParam.SelectRows(0, 0);
                this.gridViewParam.Focus();
            }));

        }

        private void barBtRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarParametros(), "Carregando Configurações");
        }

        private void gridViewParam_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void gridViewParam_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colStatusParametro)
            {
                var row = gridViewParam.GetFocusedRow<Parametro>();
                row.StatusParametro = (bool)e.Value;
                var ctx = new BalcaoContext();
                var current = ctx.ParametroDao.Find(row.CodigoParametro);
                current.StatusParametro = row.StatusParametro;
                ctx.ParametroDao.Update(current);
            }
        }

        private void gridViewParam_DoubleClick(object sender, EventArgs e)
        {
            var row = gridViewParam.GetFocusedRow<Parametro>();
            if (row != null && row.CodigoParametro.Equals("centro_custo_venda"))
            {

                var ctx = new BalcaoContext();
                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Columns = new string[] { "Matriz.CodigoMatriz", "CodigoCentroCusto", "NomeCentroCusto" },
                    Order = "CodigoCentroCusto",
                    Title = "Localizar centro de custo:",
                    DynamicObject = null
                };
                
                var selected = XFrmFindEntity.ShowDialogFindEntity<CentroCusto>(paramsFind);

                var param = ctx.ParametroDao.Find("centro_custo_venda");

                if (selected != null)
                {
                    param.ValorParametro = "" + selected.IdCentroCusto;
                    ctx.ParametroDao.Update(param);
                }
            }
        }
    }
}