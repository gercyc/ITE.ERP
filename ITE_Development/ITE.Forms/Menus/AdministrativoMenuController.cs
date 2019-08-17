using ITE.Fiscal.RegrasFiscais;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO;
using ITE.RH.Forms.Folha;
using System.Windows.Forms;
using ITE.Contabil.Forms.ListView;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.UnitControl;
using ITE.Entidades.Enumeradores.TipoMovimentoEnum;
using ITE.Fiscal.ListView;
using ITE.Fiscal.Movimentacoes.ListView;
using ITE.RH.Forms.ListView;
using ITE.Vendas.Forms.Administrativo;
using ITSolution.Framework.Forms;
using ITE.Fiscal.TpMovimento;
using ITE.Contabil.Desenvolvimento.Lotes;
using ITE.Contabil.Desenvolvimento.Lancamentos;
using ITE.Fiscal.CentralFiscal;

namespace ITE.Forms.Menus
{
    public class AdministrativoMenuController
    {

        private XFrmGerenciarMovimento _xFrmGerenciarNfEntradas;
        private XFrmGerenciarMovimento _xFrmGerenciarNfSaidas;
        private XFrmGerenciarMovimento _xFrmGerenciarEstoque;
        private XFrmPainelNFe _xFrmPainelNFe;
        private XFrmViewCfop _xFrmViewCfop;
        private XFrmImpostoListView _xFrmViewImposto;
        private XFrmSituacaoTributariaListView _xFrmSituacaoTributariaView;
        private XFrmFuncionarioListView _xFrmGerenciarFuncionarioList;
        private XFrmFuncaoListView _xFrmGerenciarFuncaoList;
        private XFrmEventoListView _xFrmGerenciarEventoList;
        private XFrmDepartamentoListView _xFrmGerenciarDepartamentoList;
        private XFrmViewCompetencias _xFrmGerenciarCompetencias;
        private XFrmViewRegrasFiscais _xFrmGerenciarTiposMovimento;
        private XFrmViewCentroCustoTree _xFrmViewCentroCustoTree;
        private XFrmSetMatrizFilial _xFrmSetMatFilial;
        private XFrmViewContaContabil _xFrmViewContaContabil;
        private XFrmViewMantContaContabil _xFrmViewMantContaContabil;
        private XFrmMovimentoParametrizadoListView _xFrmViewTpMovimento;
        private XFrmLoteContabilView _xFrmLoteContabilView;
        private XFrmLancamentosContabeisView _xFrmLancamentosContabeisView;
        private XFrmGrupoEventoListView _xFrmGrupoEventoListView;

        //Recurso compartilhado
        private readonly XFrmMenu _menu;

        private XFrmAgendaContatos _xFrmAgendaContatos;

        public AdministrativoMenuController(XFrmMenu menu)
        {
            this._menu = menu;
        }

        internal void ManagerNFs(Usuario currentUser, TypeFiltroMovimento typeFiltroMovimento, EmpresaFilial filial)
        {
            //tava chamando apenas uma tela
            //chamava a outra tela so se a outra nao existisse
            if(typeFiltroMovimento == TypeFiltroMovimento.Entradas)
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarNfEntradas))
                    this._xFrmGerenciarNfEntradas = new XFrmGerenciarMovimento(currentUser, typeFiltroMovimento, filial);

                FormsUtil.Show(_xFrmGerenciarNfEntradas, this._menu);
            }

            if (typeFiltroMovimento == TypeFiltroMovimento.Saidas)
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarNfSaidas))
                    this._xFrmGerenciarNfSaidas = new XFrmGerenciarMovimento(currentUser, typeFiltroMovimento, filial);
                FormsUtil.Show(_xFrmGerenciarNfSaidas, this._menu);
            }
            if (typeFiltroMovimento == TypeFiltroMovimento.Estoque)
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarEstoque))
                    this._xFrmGerenciarEstoque = new XFrmGerenciarMovimento(currentUser, typeFiltroMovimento, filial);
                FormsUtil.Show(_xFrmGerenciarEstoque, this._menu);
            }
        }
        internal void PainelNFe()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmPainelNFe))
                this._xFrmPainelNFe = new XFrmPainelNFe();

            FormsUtil.Show(_xFrmPainelNFe, this._menu);
        }
        internal void ManagerTributos()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmViewImposto))
            {
                this._xFrmViewImposto = new XFrmImpostoListView();
            }

            FormsUtil.Show(_xFrmViewImposto, _menu);
        }

        internal void SitTributaria()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmSituacaoTributariaView))
            {
                this._xFrmSituacaoTributariaView = new XFrmSituacaoTributariaListView();
            }

            FormsUtil.Show(_xFrmSituacaoTributariaView, this._menu);
        }

        internal void Cfop()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmViewCfop))
            {
                this._xFrmViewCfop = new XFrmViewCfop();
            }

            FormsUtil.Show(_xFrmViewCfop, _menu);
        }

        internal void RegrasFiscais()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarTiposMovimento))
            {
                this._xFrmGerenciarTiposMovimento = new XFrmViewRegrasFiscais();
            }

            FormsUtil.Show(this._xFrmGerenciarTiposMovimento, _menu);

        }

        internal void ManagerCentroCusto()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmViewCentroCustoTree))
            {
                this._xFrmViewCentroCustoTree = new XFrmViewCentroCustoTree();
            }

            FormsUtil.Show(this._xFrmViewCentroCustoTree, _menu);
        }
        internal void ManutencaoContasContabeis()
        {
            if (FormsUtil.isFormDisposedOrNull(this._xFrmViewMantContaContabil))
                this._xFrmViewMantContaContabil = new XFrmViewMantContaContabil();

            FormsUtil.Show(this._xFrmViewMantContaContabil, _menu);
        }
        internal void ManagerPlanoContas()
        {
            if (FormsUtil.isFormDisposedOrNull(this._xFrmViewContaContabil))
                this._xFrmViewContaContabil = new XFrmViewContaContabil();

            FormsUtil.Show(this._xFrmViewContaContabil, _menu);
        }
        //Group 2
        internal void ManagerFuncionarios()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarFuncionarioList))
                this._xFrmGerenciarFuncionarioList = new XFrmFuncionarioListView();
            FormsUtil.Show(_xFrmGerenciarFuncionarioList, this._menu);
        }

        internal void ManagerDepartamentos()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarDepartamentoList))
                this._xFrmGerenciarDepartamentoList = new XFrmDepartamentoListView();
            FormsUtil.Show(_xFrmGerenciarDepartamentoList, this._menu);
        }

        internal void ManagerFolhaPagamento(Usuario currentUser)
        {
            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser))
            {
                var f = UnitWork.Filial;

                if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarCompetencias))
                    this._xFrmGerenciarCompetencias = new XFrmViewCompetencias(currentUser, f);                
                //se o usuario logado possui privilegios
                FormsUtil.Show(this._xFrmGerenciarCompetencias, this._menu);
            }
        }

        internal void ManagerGrupoEventos(Usuario currentUser)
        {
            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser))
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmGrupoEventoListView))
                    this._xFrmGrupoEventoListView = new XFrmGrupoEventoListView();
                //se o usuario logado possui privilegios
                FormsUtil.Show(this._xFrmGrupoEventoListView, this._menu);
            }
        }

        internal void ManagerFuncoes()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarFuncaoList))
                this._xFrmGerenciarFuncaoList = new XFrmFuncaoListView();
            FormsUtil.Show(_xFrmGerenciarFuncaoList, this._menu);
        }

        internal void ManagerEventos()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmGerenciarEventoList))
                this._xFrmGerenciarEventoList = new XFrmEventoListView();
            FormsUtil.Show(_xFrmGerenciarEventoList, this._menu);
        }

        internal void MonitorarFilial()
        {
            if (UnitWork.Filial == null )
            {
                UnitWork.Filial = new EmpresaFilial();
                if(FormsUtil.isFormDisposedOrNull(this._xFrmSetMatFilial))
                    _xFrmSetMatFilial = new XFrmSetMatrizFilial();


                if (this._xFrmSetMatFilial.Visible == false)
                {
                    FileManagerIts.DeleteFile(UnitWork.PREFERENCIAS);
                    _xFrmSetMatFilial.Text = "Conexão com nova base detectada";
                    _xFrmSetMatFilial.ChangeIconBtnOk(Properties.Resources.bolocalization_16x16);

                    _xFrmSetMatFilial.ShowDialog();

                    if (!_xFrmSetMatFilial.IsFilial)
                    {
                        MessageBoxTick.Show("Seleção de matriz cancelada o programa será encerrado!", 
                            "Atenção", 5);//5 segundso
                        Application.Exit();
                    }
                }
            }

        }
        internal void ManageTiposMovimento()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmViewTpMovimento))
            {
                this._xFrmViewTpMovimento = new XFrmMovimentoParametrizadoListView();
            }
            FormsUtil.Show(_xFrmViewTpMovimento, this._menu);
        }
        internal void ManagerLancamentosContabeis(Usuario currentUser)
        {
            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser))
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmLancamentosContabeisView))
                    this._xFrmLancamentosContabeisView = new XFrmLancamentosContabeisView(currentUser);
                //se o usuario logado possui privilegios
                FormsUtil.Show(this._xFrmLancamentosContabeisView, this._menu);
            }
        }
        internal void ManagerLotesContabeis(Usuario currentUser)
        {
            if (this._menu.Controller.UserControl.AcessOrLogin(currentUser))
            {
                if (FormsUtil.isFormDisposedOrNull(_xFrmLoteContabilView))
                    this._xFrmLoteContabilView = new XFrmLoteContabilView(currentUser, _menu);
                //se o usuario logado possui privilegios
                FormsUtil.Show(this._xFrmLoteContabilView, this._menu);
            }
        }
        internal void Agenda()
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmAgendaContatos))
            {
                this._xFrmAgendaContatos = new XFrmAgendaContatos();
            }
            FormsUtil.Show(_xFrmAgendaContatos, this._menu);
        }
    }
}
