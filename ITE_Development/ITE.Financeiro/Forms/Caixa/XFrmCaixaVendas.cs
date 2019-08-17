using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.ControleVenda;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;

namespace ITE.Financeiro.Forms.Caixa
{
    public partial class XFrmCaixaVendas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<MovimentoCaixa> _movimentos;
        private Usuario _user;
        private Usuario _userSelect;
        private readonly XFrmFluxoCaixaVendas _xFrmFluxo;

        public XFrmCaixaVendas(Usuario user)
        {
            InitializeComponent();
            panelSum1.AddSomatorio(gridControl1, gridView1);
            this._xFrmFluxo = new XFrmFluxoCaixaVendas();
            cbFiltro_SelectedIndexChanged(null, null);
            var ctx = new BalcaoContext();
            ctx.LazyLoading(false);
            var users = ctx.UsuarioDao.FindAll();
            //carrega o layout dentro do projeto
            gridSearchLookUpEditViewUser.RestoreViewFromResource(Assembly.GetExecutingAssembly(),
                "ITE.Financeiro.Resources.layout_user_single.xml");
            this._user = user;
            repSearchLookUpEditUser.DataSource = users;
            gridSearchLookUpEditViewUser.RefreshData();

        }

        private async Task atualizar()
        {
            var manager = new CaixaDaoManager();
            if (barToggleSwitchUser.Checked)
                _userSelect = barEditUsers.EditValue as Usuario;
            else
                _userSelect = null;

            this._movimentos = await manager
                .GetMovimentosByPeriodo(dtInicio.DateTime.Date, dtFinal.DateTime.Date, 
                _userSelect);

            this.gridControl1.BeginInvoke(new Action(() =>
            {
               this. gridControl1.DataSource = this._movimentos;

            }));
            this.lblSaldoDinheiro.BeginInvoke(new Action(() =>
            {
                decimal saldo = manager.GetSaldoDinheiro();
                if(saldo < 0)
                {
                    this.lblSaldoDinheiro.ForeColor = System.Drawing.Color.Red;
                    this.barBtnSaqueCaixa.Enabled = false;
                }
                else
                {
                    this.barBtnSaqueCaixa.Enabled = true;
                    this.lblSaldoDinheiro.ForeColor = System.Drawing.Color.Black;
                }
                this.lblSaldoDinheiro.Text = "Saldo em dinheiro: R$ " + saldo.ToString("N2");

            }));

        }

        #region Eventos

        private void XFrmCaixaVendas_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }
        private void barBtnDeposito_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddMovimentoCaixa(TypeMovimentacaoMonetaria.Credito).ShowDialog();
        }

        private void barBtnSaqueCaixa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            new XFrmAddMovimentoCaixa(TypeMovimentacaoMonetaria.Debito).ShowDialog();
        }

        private void btnFluxoCaixa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this._xFrmFluxo.Show(this._movimentos);
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(atualizar());
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            XFrmWait.StartTask(atualizar(), "Atualizando indicadores");
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbFiltro.SelectedIndex;
            int mes = 1;
            DateTime dt1 = dtInicio.DateTime;
            DateTime dt2 = dtFinal.DateTime;
            //Por Período 0
            //Próximo Mês 1
            //Mês Atual 2
            //Mês Anterior 3
            //Por Dia 4
            //Por Ano 5
            this.pnlPeriodo.Enabled = false;
            switch (index)
            {
                //Por período
                case 0:
                    this.pnlPeriodo.Enabled = true;
                    break;

                //Mês Atual
                case 1:
                    mes = DateTime.Now.Month;
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

                default:
                    break;
            }
            this.dtInicio.DateTime = dt1;
            this.dtFinal.DateTime = dt2;

        }



        #endregion

        private void barToggleSwitchUser_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            repSearchLookUpEditUser.ReadOnly = !barToggleSwitchUser.Checked;
            this.barEditUsers.EditValue = null;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var row = gridView1.GetFocusedRow<MovimentoCaixa>();

            if (row != null && row.IdVenda!=null)
            {
                using (var ctx = new BalcaoContext())
                {
                    new XFrmDetalhesVenda(ctx.VendaDao.Find(row.IdVenda)).ShowDialog();
                }
            }
        }
    }
}