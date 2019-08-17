using ITE.Entidades.POCO;
using ITE.Entidades.DaoManager;
using ITE.Vendas.Forms.ControleVenda;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.GuiUtil;
using ITE.Vendas.Forms.View;
using ITE.Entidades.UnitControl;
using System;
using ITE.Forms.OldVersion;
using ITE.Vendas.Forms.Util;
using ITSolution.Framework.Dao.Contexto;
using ITSolution.Framework.Enumeradores;

namespace ITE.Forms.Menus
{
    public class VendaMenuController
    {
        private readonly XFrmMenu _menu;

        //Composicoes do menu
        private XFrm2ViaProposta _xFrm2ViaProposta;
        private XFrmCancelarVenda _xFrmCancelarVenda;
        private XFrmCotacaoListView _xFrmAlterarCotacao;
        private XFrmFiltrarVenda _xFrmConsultarVenda;

        public VendaMenuController(XFrmMenu menu)
        {
            this._menu = menu;
        }

        internal void NovaProposta(Usuario user)
        {

            //verificar se existe local de estoque antes de vender
            if (ParametroDaoManager.GetCentroCustoVenda() == null)
            {
                Console.WriteLine("Centro de custo nao encontrado");
                XMessageIts.Mensagem("Para iniciar uma venda é necessário o cadastrar um centro de custo!");
            }

            if (!ParametroDaoManager.CheckLocalEstoque())
            {
                var op = XMessageIts.Confirmacao("Não existe um local de estoque cadastrado.\n\n" +
                    "Desejar cadastrar local de estoque ?",
                    "Atenção");

                if (op == System.Windows.Forms.DialogResult.Yes)
                    new XFrmLocalEstoqueView().ShowDialog();
            }
            else
            {
                XFrmVenda xFrmVenda;
                //venda com login
                if (ParametroManager.GetStatusParamByCodigo(TypeParametro.exigir_login_venda.ToString()))
                {
                    var login = new UnitWork();

                    var userLogin = login.Login();

                    if (userLogin != null)
                    {

                        xFrmVenda = new XFrmVenda(userLogin);
                        //invoke o form em dialogo
                        xFrmVenda.ShowDialog();
                    }
                }
                //sem login na venda
                else
                {
                    xFrmVenda = new XFrmVenda(user);

                    //invoke o form em dialogo
                    xFrmVenda.ShowDialog();
                }


            }
        }

        internal void SegundaViaProposta()
        {

            if (FormsUtil.isFormDisposedOrNull(_xFrm2ViaProposta))
            {
                this._xFrm2ViaProposta = new XFrm2ViaProposta();
            }
            FormsUtil.Show(_xFrm2ViaProposta, _menu);
        }

        internal void AlterarCotacao(Usuario user)
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmAlterarCotacao))
            {
                this._xFrmAlterarCotacao = new XFrmCotacaoListView(user);
            }
            FormsUtil.Show(_xFrmAlterarCotacao, _menu);

        }

        internal void CancelaProposta(Usuario user)
        {
            if (FormsUtil.isFormDisposedOrNull(this._xFrmCancelarVenda))
                this._xFrmCancelarVenda = new XFrmCancelarVenda(user);

            FormsUtil.Show(_xFrmCancelarVenda, _menu);
        }

        internal void InfoVenda(Usuario user)
        {
            if (new UnitWork().AcessOrLogin(user))
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmConsultarVenda))
                {
                    this._xFrmConsultarVenda = new XFrmFiltrarVenda();
                }
                //se o usuario logado possui privilegios
                FormsUtil.Show(this._xFrmConsultarVenda, _menu);
            }
        }

    }

}
