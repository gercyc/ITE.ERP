using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Helpers;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores.TipoMovimentoEnum;
using ITE.Entidades.POCO;
using ITE.Entidades.UnitControl;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Dao.Contexto;
using ITSolution.Framework.Entities;
using ITSolution.Framework.Forms;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Admin.Forms.ContextUtil;
using System.Linq;
using ITSolution.Framework.BaseInterfaces;
using DevExpress.XtraBars.Ribbon;
using ITSolution.Framework.BaseClasses;

namespace ITE.Forms.Menus
{

    /// <summary>
    /// Menu principal
    /// Customizações
    /// Form Title Bar Skinning
    /// When a Windows Aero scheme is applied (in Windows Vista, for instance), 
    /// the title bar skinning feature is not applied to RibbonForms unless the 
    /// RibbonForm.AllowFormGlass option is set to False.    
    /// RibbonStyle: Office 2013
    /// </summary>
    public partial class XFrmMenu : DevExpress.XtraBars.Ribbon.RibbonForm, IITSDesktop
    {
        #region Variaveis
        private Usuario _currentUser;
        private List<Mensagem> _alerts = new List<Mensagem>();
        private List<Mensagem> _help = new List<Mensagem>();
        private List<Mensagem> _system = new List<Mensagem>();
        private SuperToolTip _superToolTip1 = new SuperToolTip();
        private ToolTipItem _toolTipItem1 = new ToolTipItem();
        private ITSApplication _application;
        public IITSTools ITSTools { get { return _application; } }
        internal MenuController Controller { get; private set; }

        public DialogResult ResultLogin => throw new NotImplementedException();
        #endregion

        #region Construtores

        private XFrmMenu()
        {
            InitializeComponent();
            ChangeCaptionContext();
            //_application = new ITSApplication(this);
            timer1.Start();
        }

        public XFrmMenu(Usuario user, ITSApplication _application) : this()
        {
            //ache o nome do usuário
            this.setCurrentUser(user);
            //listComponents();
            this._application = _application;
            this._application.AncestorDesktop = Desktop;
           
        }
        private void listComponents()
        {
            var i = 2;
            var iMnuPai = 1;

            var dict = new Dictionary<string, string>();

            foreach (DevExpress.XtraBars.Ribbon.RibbonPage page in this.Ribbon.Pages)
            {
                dict.Add(iMnuPai.ToString(), "|" + page.Name + "|" + "null|" + page.Visible.ToString() + "|" + page.Text + "|" + page.GetType().ToString());

                foreach (DevExpress.XtraBars.Ribbon.RibbonPageGroup group in page.Groups)
                {

                    dict.Add(i.ToString(), "|" + group.Name + "|" + iMnuPai + "|" + group.Visible.ToString() + "|" + group.Text + "|" + group.GetType().ToString());
                    i++;
                    foreach (BarItemLink itmGroup in group.ItemLinks)
                    {
                        var n = itmGroup.Item.Name;

                        dict.Add(i.ToString(), "|" + n + "|" + iMnuPai + "|" + itmGroup.Visible.ToString() + "|" + itmGroup.Caption + "|" + itmGroup.GetType().ToString());
                        i++;
                    }
                }
                iMnuPai = dict.Count + 1;
                i++;

            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + item.Value);
            }
        }
        #endregion

        #region Metodos

        public void Run()
        {

            this.ShowDialog();
        }

        private void setCurrentUser(Usuario user)
        {
            this._currentUser = user;

            if (user == null)
            {
                MessageBoxBlack.Advertencia("Usuário operador não informado ao menu prinicpal", "Atenção");

                LoggerUtilIts.GenerateLogs(new Exception("User not found for XFrmMenu"));

                Application.Exit();
            }
            if (UnitWork.Filial == null)
                navBarUnitWork_LinkClicked(null, null);

            UnitWork.Usuario = user;

            //Define o skin do menu utilizado pelo usuário  
            string skin = user.Skin;

            //se existe um 
            if (!string.IsNullOrEmpty(skin))
            {
                SkinHelper.InitSkinGallery(skinRibbonGalleryBarItem1);
                defaultLookAndFeel1.LookAndFeel.SkinName = skin;
            }

            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = skin;

            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Blue";
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2013 Light Gray";

            //Eh mais elegante e legivel o nome da pessoa do que o nickname
            this.lbUserLogado.Caption = user.NomeUsuario;
            this.dtAtual.Caption = DateTime.Now.Date.ToShortDateString();


            //somente eu poss usar essa funcionalidade
            if (user.NomeUtilizador == "filipe"/*
                || user.NomeUtilizador == "admin"
                || user.NomeUtilizador == "gercy" && user.IsAdmin*/)
            {
                this.ribbonPageGroupInformatica.Visible = true;

                this.ribbonPageGroupSystem.Visible = true;
                this.ribbonPageGroupUtil.Visible = true;
                this.barBtnRestauracao.Visibility = BarItemVisibility.Always;
            }

        }

        public void AddMsgsGrid(Mensagem mensagem, OptionTabFooter optionTab)
        {
            //ativa a aba que esta sendo chamada pela msg
            setTabMsg(optionTab);

            //exibe o dock
            dockPainelFooter.Show();

            //adiciona cada mensagem nova ao form principal
            if (optionTab == OptionTabFooter.Alert)
            {
                this._alerts.Add(mensagem);
                this._alerts.Reverse();
                this.gridControlAlerts.DataSource = _alerts;
                this.gridControlAlerts.RefreshDataSource();
            }
            else if (optionTab == OptionTabFooter.Help)
            {
                this._help.Add(mensagem);
                this._help.Reverse();
                this.gridControlHelp.DataSource = _help;
                this.gridControlHelp.RefreshDataSource();
            }
            else
            {
                this._system.Add(mensagem);
                this._system.Reverse();
                this.gridControlSystem.DataSource = _system;
                this.gridControlSystem.RefreshDataSource();
            }

        }

        internal void ChangeCaptionContext()
        {
            this.Controller = MenuController.controller(this);
            this.navBarContexto.Caption = "Matriz: "
                                          + UnitWork.Filial.CodigoFilial + " | "
                                          + UnitWork.Filial.RazaoSocial;

        }

        internal void setTabMsg(OptionTabFooter option)
        {
            if (option == OptionTabFooter.Alert)
            {
                xtraTabPai.SelectedTabPageIndex = 1;
            }
            else if (option == OptionTabFooter.Help)
            {
                xtraTabPai.SelectedTabPageIndex = 2;
            }
            else
            {
                xtraTabPai.SelectedTabPageIndex = 3;
            }
        }

        #endregion

        #region Page 1 Eventos - Vendas

        private void barBtnProposta_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.VendasController.NovaProposta(_currentUser);
        }

        private void barBtn2ViaProposta_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.VendasController.SegundaViaProposta();
        }

        private void barBtnAlterarCotacao_ItemClick(object sender, ItemClickEventArgs e)
        {

            this.Controller.VendasController.AlterarCotacao(_currentUser);
            //if (FormsUtil.isFormDisposedOrNull(xFrmAlterarCotacao))
            //    this.xFrmAlterarCotacao = new XFrmAlterarCotacao(user);
            //FormsUtil.Show(xFrmAlterarCotacao, this);

        }

        private void barBtnCancelaProposta_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.VendasController.CancelaProposta(_currentUser);

        }

        private void barBtnUtil_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.FinanceiroController.UtilVendas(_currentUser);

        }

        private void barBtnInfoVenda_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.VendasController.InfoVenda(_currentUser);

        }

        #endregion

        #region Page 2 Eventos - Cadastro/Consultas

        private void barBtnGerenciarCliFor_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.ManagerCliFor();
        }

        private void barBtnGerenciarProduto_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.ManagerProduct(_currentUser);
        }

        private void barBtnLcEstoque_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.ManagerLocalEstoque();
        }

        private void btnUnidadesMedida_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.ManagerUnidadeMedida(_currentUser);
        }

        private void barBtnNcms_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.Ncms();
        }

        private void barBtnMatriz_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.ManagerMatrizes();
        }

        private void barBtnFiliais_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.ManagerFiliais();
        }

        private void barBtnMunicipio_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.ManagerMunicipios();
        }

        private void barBtnPais_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.Countries();

        }

        private void barBtnUfs_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.CadastroController.Ufs();
        }

        #endregion

        #region Page 3 Eventos - Financeiro

        private void barBtnCheque_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.FinanceiroController.Cheques();
        }

        private void barBtnFluxoCaixa_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnControleCaixa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.FinanceiroController.ControleCaixa(_currentUser);

        }

        private void btnContasReceber_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.FinanceiroController.ManagerContasPagarReceber(_currentUser);

        }

        private void btnExtrato_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.FinanceiroController.ManagerExtratos(_currentUser);


        }

        private void btnFormasPagto_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.FinanceiroController.ManagerFormasPagto(_currentUser);


        }

        private void btnContasBancarias_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.FinanceiroController.ManagerContasBancarias(_currentUser);

        }

        private void barBtnCambio_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.FinanceiroController.CotacaoCambial();
        }

        private void barBtnHistoricoCambial_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.FinanceiroController.HistoricoCambial();
        }

        #endregion

        #region Page 4 Eventos - Administrativo

        //Compras/Entradas
        private void barBtnGerenciarEntradas_ItemClick(object sender, ItemClickEventArgs e)
        {
            var filial = UnitWork.Filial;
            Controller.AdministrativoController.ManagerNFs(_currentUser, TypeFiltroMovimento.Entradas, filial);
        }

        //Vendas/Faturamento
        private void barBtnGerenciarSaidas_ItemClick(object sender, ItemClickEventArgs e)
        {
            var filial = UnitWork.Filial;
            Controller.AdministrativoController.ManagerNFs(_currentUser, TypeFiltroMovimento.Saidas, filial);
        }
        //Estoque/Transferencias
        private void barBtnGerenciarTransferencias_ItemClick(object sender, ItemClickEventArgs e)
        {
            var filial = UnitWork.Filial;
            Controller.AdministrativoController.ManagerNFs(_currentUser, TypeFiltroMovimento.Estoque, filial);
        }

        private void barBtnTributos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManagerTributos();
        }

        private void barBtnSitTributaria_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.SitTributaria();
        }

        private void barBtnCfop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.Cfop();
        }

        private void barBtnRegrasFiscaisTiposMov_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.RegrasFiscais();

        }
        private void barBtnPlanoContas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManagerPlanoContas();
        }
        private void btnMantContas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManutencaoContasContabeis();
        }
        private void barBtnCentroCusto_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManagerCentroCusto();

        }
        private void btnPainelNFe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.PainelNFe();
        }

        /*RH */

        private void btnFuncionario_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManagerFuncionarios();

        }

        private void btnDepto_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManagerDepartamentos();

        }

        private void btnFuncao_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManagerFuncoes();
        }

        private void btnEvento_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManagerEventos();

        }

        private void barBtnFolhaPagto_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.AdministrativoController.ManagerFolhaPagamento(_currentUser);
        }

        private void barBtnGrpEventos_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.AdministrativoController.ManagerGrupoEventos(_currentUser);
        }
        private void barBtnTiposMovimento_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.AdministrativoController.ManageTiposMovimento();
        }

        private void barBtnLotesCont_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManagerLancamentosContabeis(_currentUser);
        }

        private void barBtnLoteContabil_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.AdministrativoController.ManagerLotesContabeis(_currentUser);
        }

        #endregion 

        #region Page 5 Eventos - Central de Relatórios

        private void barBtnCriarRelatorio_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.ReportController.CreateReport(this._currentUser);
        }

        private void barBtnDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.ReportController.CreateDashboard(_currentUser);
        }

        private void btnReportSpool_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.ReportController.ReportSpool();
        }

        private void barBtnCentProcess_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.ReportController.CentralProcesses();
        }

        #endregion

        #region Page 6 Eventos - Informática

        private void barBtnAtendimentos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Controller.InformaticaController.ManagerAtendimentos();

        }

        private void barBtnInfoManutencao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Controller.InformaticaController.ManagerManutencoes();
        }

        #endregion

        #region Page 7 Eventos - Sistema

        private void barBtnGerenciarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.SistemaController.UserControl(_currentUser);
        }

        private void barBtnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.SistemaController.Backup();
        }

        private void barBtnRestauracao_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.SistemaController.RestauracaoBackup(_currentUser);
        }

        private void barBtnPdfToText_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.SistemaController.PdfToText();
        }

        private void barBtnDigitalizacao_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.SistemaController.Digitalizacao();
        }

        private void barBtnConfigParam_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.SistemaController.InfoParam();
        }

        private void navBarUnitWork_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Controller.SistemaController.ChangeUnitWork(_currentUser);

        }

        private void navBarConfig_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Controller.SistemaController.AlterConnection(_currentUser);
        }
        #endregion

        #region Page 8 - CE
        private void barBtnCusteio_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.CEController.CalcularCusteio(_currentUser);
        }
        private void barBtnListCusteios_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.CEController.GerenciarCusteios(_currentUser);
        }

        #endregion

        #region Eventos - XFrmMenu

        private void XFrmMenuBalcao_Shown(object sender, EventArgs e)
        {
            if (UnitWork.Filial == null)
            {
                this.barBtnProposta.Enabled = false;
                this.navBarContexto.Enabled = false;
                var op = XMessageIts.Confirmacao("Matriz/Filial não localizada !\n\n"
                                                 + "Para realizar venda(s), é necessario cadastrar uma matriz e filial\n\n"
                                                 + "Cadastrar agora ?", "Aviso");

                if (op == DialogResult.Yes)
                {
                    new XFrmMatrizView().ShowDialog();

                    //se o usuario burro nao clicou em cancelar verifica se cadastrou
                    if (new EmpresaDaoManager().CheckMatrizFilial())
                    {
                        new XFrmFilialView().ShowDialog();
                    }
                }

            }
            else
            {
                this.barBtnProposta.Enabled = true;
                this.navBarContexto.Enabled = true;
            }

            //bool isRotina = isRotinaChecagem();
            //if (isRotina == false)
            //vai roda a rotina sempre que eu abrir o programa
            Task.Run(() => taskInitial());
        }

        private void XFrmMenuBalcao_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void XFrmMenuRibbon_FormClosing(object sender, FormClosingEventArgs e)
        {
            var op = XMessageIts.Confirmacao("Deseja encerrar o ITE Solution ?", "Atenção");

            if (op == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
                e.Cancel = true;
        }

        private void skinRibbonGalleryBarItem1_GalleryItemClick(object sender,
            DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            if (e.Item.Checked && _currentUser != null)
            {
                //e.Item.Caption => nome com a versao traduzida eh rejeitado.
                //eu preciso do nome original do skin para poder ajustar

                //todos os skins foram mapeados para uma tabela do banco
                //salve o tema do usuario
                new UsuarioDaoManager().SaveSkin(_currentUser, e.Item.Caption);

            }
        }

        private void tsButtonLimpar_Click(object sender, EventArgs e)
        {
            _alerts.Clear();
            _help.Clear();
            _system.Clear();

            gridControlSystem.DataSource = _system;
            gridControlSystem.Refresh();
            gridControlSystem.RefreshDataSource();

            gridControlHelp.DataSource = _help;
            gridControlHelp.Refresh();
            gridControlHelp.RefreshDataSource();

            gridControlAlerts.DataSource = _alerts;
            gridControlAlerts.Refresh();
            gridControlAlerts.RefreshDataSource();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Controller.AdministrativoController.MonitorarFilial();

            this.MonitorarStatusConexao();

            if (this._currentUser != UnitWork.Usuario)
                this._currentUser = UnitWork.Usuario;
        }

        private void lbUserLogado_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            var user = Controller.UserControl.Login();

            if (user != null)
            {
                this.setCurrentUser(user);
            }
        }

        private bool isRotinaChecagem()
        {
            string rotinaChecagem = Path.Combine(Application.StartupPath, "r_ch_vendas_lanctos");
            var dataAtual = DateTime.Now.Date;
            if (File.Exists(rotinaChecagem) == false)
            {
                //cria o arquivo
                FileManagerIts.CreateFile(rotinaChecagem);
            }
            try
            {
                string checagem = FileManagerIts.GetDataStringFile(rotinaChecagem);
                Nullable<DateTime> data = DataUtil.ToDate(checagem).Date;

                if (data == dataAtual)
                {
                    return true;
                }
                else
                    //registra a ocorrencia da rotina no dia
                    FileManagerIts.OverWriteOnFile(rotinaChecagem, dataAtual.ToShortDateString());
            }
            catch (Exception)
            {
                FileManagerIts.DeleteFile(rotinaChecagem);

            }
            return false;


        }

        private void MonitorarStatusConexao()
        {
            if (RedeUtil.IsNetworkAvailable())
            {
                _toolTipItem1.Text = "Trabalhando online";
                barStaticFlagNet.Caption = "Online";
                barStaticIcoNet.Glyph = Properties.Resources.bolocalization_16x16;
            }
            else
            {
                _toolTipItem1.Text = "Trabalhando offline";
                barStaticFlagNet.Caption = "Offline";
                barStaticIcoNet.Glyph = Properties.Resources.country_16x16;
            }
            _superToolTip1.Items.Clear();

            _superToolTip1.Items.Add(_toolTipItem1);
            barStaticFlagNet.SuperTip = _superToolTip1;
        }

        private void taskInitial()
        {
            try
            {
                int vendas = Controller.SistemaController.CheckVendasLancamentos();

                if (vendas > 0)
                {
                    dockPainelFooter.BeginInvoke(new Action(() =>
                    {
                        AddMsgsGrid(new Mensagem("Olá, você possui contas vencida(s)/vencendo hoje."),
                            OptionTabFooter.Alert);
                    }));
                }

                int competenciasEdicao = Controller.SistemaController.GetCompetenciasEmEdicao();

                if (competenciasEdicao > 0)
                {
                    dockPainelFooter.BeginInvoke(new Action(() =>
                    {
                        AddMsgsGrid(new Mensagem("Existem competências da folha de pagamento em edição. Visite o módulo RH."),
                            OptionTabFooter.Alert);
                    }));
                }
                //verificar se existe local de estoque antes de vender
                if (ParametroDaoManager.GetContaBancaria() == null)
                {
                    ParametroDaoManager.AddContaBancariaDefault(null);
                    //XMessageIts.Advertencia("Para funcionamento adequado do sistema é necessário uma conta para crédito/débito.", 
                    //  "Atenção contate o administrador !!!");

                }

                loadLembretes();
            }
            catch (Exception ex)
            {
                dockPainelFooter.BeginInvoke(new Action(() =>
                {
                    AddMsgsGrid(new Mensagem(ex.Message), OptionTabFooter.System);

                }));
            }
        }

        private void loadLembretes()
        {
            this.gridControl1.BeginInvoke(new Action(async () =>
            {
                using (var ctx = new ITSolutionContext())
                {
                    var lista = await ctx.LembreteDao.FindAllAsync();

                    gridControl1.DataSource = lista;
                    tileView1.RefreshData();
                    if (tileView1.DataRowCount > 0)
                        dockPanelRight.Visibility = DockVisibility.Visible;

                }
            }));
        }

        private void barBtnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            new XFrmLogoIts().ShowDialog();
        }

        private void barBtnAgenda_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controller.AdministrativoController.Agenda();
        }

        private void barBtnAddLembrete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new XFrmLembrete();

            frm.ShowDialog();

            if (frm.IsUpdate)
            {
                loadLembretes();

            }
        }

        private void barBtnDelLembrete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var l = tileView1.GetFocusedRow() as Lembrete;

            if (l != null)
            {
                if (new LembreteDaoManager().Delete(l))
                    loadLembretes();
            }
            else
            {
                XMessageIts.Advertencia("Selecione o lembrete a ser removido");
            }
        }

        private void barBtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            loadLembretes();
        }

        private void barBtnEditarLembrete_ItemClick(object sender, ItemClickEventArgs e)
        {
            var l = tileView1.GetFocusedRow() as Lembrete;

            var frm = new XFrmLembrete(l);

            frm.ShowDialog();

            if (frm.IsUpdate)
            {
                l.Update(frm.Lembrete);
                tileView1.RefreshData();
                loadLembretes();
                //PRECISEI A ATUALIZAR O VIEW 2x
            }
        }

        private void tileView1_DoubleClick(object sender, EventArgs e)
        {
            barBtnEditarLembrete_ItemClick(null, null);
        }

        public void SetMenu(RibbonControl ribbonControl)
        {

        }

        public FormWindowState SetFormWindowState(FormWindowState formWindowState)
        {
            return FormWindowState.Maximized;
        }

        public Type GetApplicationObj()
        {
            return typeof(ITSApplication);
        }
        public IITSDesktop Desktop
        {
            get
            {
                return this;
            }
        }
    }

    #endregion

}