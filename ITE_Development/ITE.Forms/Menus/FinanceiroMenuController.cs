using ITE.Entidades.POCO;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.UnitControl;
using ITE.Financeiro.Forms.Bordero;
using ITE.Financeiro.Forms.Caixa;
using ITE.Financeiro.Forms.ListView;
using ITE.Vendas.Forms.ListView;
using ITSolution.Framework.Web.Bacen;

namespace ITE.Forms.Menus
{
    public class FinanceiroMenuController
    {
        private XFrmCaixaVendas _xFrmCaixaVendas;
        private XFrmContaBancariaListView _xFrmContaBancariaListView;
        private XFrmLancamentoFinanceiroListView _xFrmViewLancamentoFinanceiroListView;
        private XFrmFormaPagamentoListView _xFrmFormaPagamentoListView;
        private XFrmViewExtratoBancario _xFrmExtratoBancarioListView;
        private XFrmVendaListView _xFrmUtilVendaList;
        private XFrmChequeListView _xFrmChequeListView;
        //Recurso Compartilhado
        private readonly XFrmMenu _menu;

        private XFrmCambio _xFrmCambio;
        private XFrmHistoricoMoedas _xFrmHistoricoMoedas;
        public FinanceiroMenuController(XFrmMenu menu)
        {
            this._menu = menu;
        }


        internal void ControleCaixa(Usuario currentUser)
        {
            if (FormsUtil.isFormDisposedOrNull(this._xFrmCaixaVendas))
                this._xFrmCaixaVendas = new XFrmCaixaVendas(currentUser);

            FormsUtil.Show(this._xFrmCaixaVendas, this._menu);
        }

        internal void ManagerContasPagarReceber(Usuario currentUser)
        {

            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser))
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmViewLancamentoFinanceiroListView))
                    this._xFrmViewLancamentoFinanceiroListView = new XFrmLancamentoFinanceiroListView(currentUser, this._menu);

                FormsUtil.Show(_xFrmViewLancamentoFinanceiroListView, this._menu);
            }


        }

        internal void ManagerFormasPagto(Usuario currentUser)
        {
            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser))
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmFormaPagamentoListView))
                    this._xFrmFormaPagamentoListView = new XFrmFormaPagamentoListView(currentUser);

                else
                    this._xFrmFormaPagamentoListView.User = currentUser;
                FormsUtil.Show(_xFrmFormaPagamentoListView, this._menu);
            }
        }

        internal void ManagerContasBancarias(Usuario currentUser)
        {

            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser))
            {

                if (FormsUtil.isFormDisposedOrNull(_xFrmContaBancariaListView))
                    this._xFrmContaBancariaListView = new XFrmContaBancariaListView();

                FormsUtil.Show(_xFrmContaBancariaListView, this._menu);
            }
        }

        internal void ManagerExtratos(Usuario currentUser){

            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser))
            {

                if (FormsUtil.isFormDisposedOrNull(_xFrmExtratoBancarioListView))
                    this._xFrmExtratoBancarioListView = new XFrmViewExtratoBancario();

                FormsUtil.Show(_xFrmExtratoBancarioListView, this._menu);
            }
        }


        internal void UtilVendas(Usuario currentUser)
        {
            if (new UnitWork().AcessOrLogin(currentUser))
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmUtilVendaList))
                {
                    this._xFrmUtilVendaList = new XFrmVendaListView(currentUser);
                }
                //se o usuario logado possui privilegios
                this._xFrmUtilVendaList.Show();
                this._xFrmUtilVendaList.BringToFront();
            }
        }

        public void Cheques()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmChequeListView))
                this._xFrmChequeListView = new XFrmChequeListView();

            FormsUtil.Show(_xFrmChequeListView, this._menu);
        }


        public void HistoricoCambial()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmHistoricoMoedas))
                this._xFrmHistoricoMoedas = new XFrmHistoricoMoedas();

            FormsUtil.Show(_xFrmHistoricoMoedas, this._menu);
        }

        public void CotacaoCambial()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmCambio))
                this._xFrmCambio = new XFrmCambio();

            FormsUtil.Show(_xFrmCambio);
        }
    }
}
