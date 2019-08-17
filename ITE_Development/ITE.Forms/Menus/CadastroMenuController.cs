using System;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO;
using ITE.Fiscal.ListView;
using ITE.Vendas.Forms.ListView;
using DevExpress.XtraBars.Ribbon;

namespace ITE.Forms.Menus
{
    public class CadastroMenuController
    {

        private XFrmProdutoListView _xFrmViewProduto;
        private XFrmCliForListView _xFrmViewCliFor;
        private XFrmLocalEstoqueListView _xFrmViewLocalEstoque;
        private XFrmMatrizListView _xFrmViewMatriz;
        private XFrmFilialListView _xFrmViewFilial;
        private XFrmUnidMedidaListView _xFrmViewUnidMedidas;
        private XFrmMunicipioListView _xFrmViewMunicipio;
        private XFrmNcmListView _xFrmViewNcm;

        //private XFrmViewPais XFrmViewPais;
        //private XFrmViewUf xFrmViewUf;
        //Recurso Compartilhado
        private readonly XFrmMenu _menu;

        public CadastroMenuController(XFrmMenu menu)
        {
            this._menu = menu;
        }

        internal void ManagerCliFor()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmViewCliFor))
            {
                this._xFrmViewCliFor = new XFrmCliForListView();
            }
            FormsUtil.Show(this._xFrmViewCliFor, this._menu);
        }

        internal void ManagerProduct(Usuario currentUser)
        {
            _menu.ITSTools.ShowTransaction(new XFrmProdutoListView(currentUser));
            //if (FormsUtil.isFormDisposedOrNull(_xFrmViewProduto))
            //{
            //    this._xFrmViewProduto = new XFrmProdutoListView(currentUser);
            //}
            //FormsUtil.Show(this._xFrmViewProduto, this._menu);
        }


        internal void ManagerLocalEstoque()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmViewLocalEstoque))
            {
                this._xFrmViewLocalEstoque = new XFrmLocalEstoqueListView();
            }
            FormsUtil.Show(_xFrmViewLocalEstoque, this._menu);
        }

        internal void ManagerMunicipios()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmViewMunicipio))
            {
                this._xFrmViewMunicipio = new XFrmMunicipioListView();
            }

            FormsUtil.Show(_xFrmViewMunicipio, this._menu);
        }

        internal void Countries()
        {
            throw new NotImplementedException();
        }


        internal void Ufs()
        {
            throw new NotImplementedException();
        }

        internal void ManagerUnidadeMedida(Usuario currentUser)
        {
            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser))
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmViewUnidMedidas))
                    this._xFrmViewUnidMedidas = new XFrmUnidMedidaListView(currentUser);

                FormsUtil.Show(_xFrmViewUnidMedidas, this._menu);
            }
        }

        internal void Ncms()
        {

            if (FormsUtil.isFormDisposedOrNull(_xFrmViewNcm))
                this._xFrmViewNcm = new XFrmNcmListView();

            FormsUtil.Show(_xFrmViewNcm, this._menu);
        }

        internal void ManagerMatrizes()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmViewMatriz))
            {
                this._xFrmViewMatriz = new XFrmMatrizListView();
            }
            FormsUtil.Show(_xFrmViewMatriz, this._menu);
        }

        internal void ManagerFiliais()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmViewFilial))
            {
                this._xFrmViewFilial = new XFrmFilialListView();
            }
            FormsUtil.Show(_xFrmViewFilial, this._menu);
        }
    }
}
