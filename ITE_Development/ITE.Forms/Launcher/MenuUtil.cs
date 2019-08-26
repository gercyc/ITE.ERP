using ITE.Entidades.POCO;
using ITE.Entidades.DaoManager;
using ITE.Entidades.UnitControl;
using ITE.Entidades.Repositorio;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Dao.Contexto;
using ITSolution.Framework.Listeners;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Forms.Menus;
using ITE.Vendas.Forms.Administrativo;
using ITSolution.Reports.Repositorio;
using ITSolution.Framework.Web.Bacen;
using System.Linq;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using ITSolution.Framework.BaseClasses;
using ITSolution.Framework.BaseInterfaces;
using ITSolution.Framework.BaseClasses.License;
using ITSolution.Framework.BaseClasses.License.POCO;

namespace ITE.Forms.Launcher
{
    public class MenuUtil : ActionLogin
    {
        private BalcaoContext _ctx;
        private ITSolution.Framework.Forms.XFrmLogin _xFrmLogin;
        private ITSApplication _application;
        private Task<Usuario> _taskLogin;
        private bool _isLoginAutoFailed;
        private bool _isInit;
        //Esse form a seta a matriz e filial estatica no LoginControl
        private XFrmSetMatrizFilial _xFrmMatrizFilial;

        public MenuUtil()
        {
            this.setTheme();
            _application = new ITSApplication();
            this._xFrmLogin = new ITSolution.Framework.Forms.XFrmLogin(this);

        }

        public void Run(string logon = null)
        {
            try
            {
                logon = retryLogon(logon);
                this._xFrmLogin.Text = "Acesso ao sistema:";

                this._isLoginAutoFailed = false;

                //se nao informe
                if (string.IsNullOrEmpty(logon))
                {
                    //action form do login dispara o invokeMenu
                    //faça login primeiro
                    this._xFrmLogin.ShowDialog();

                    //se foi cancelado
                    if (this._xFrmLogin.IsCancel)
                    {
                        //termina aplicação
                        Application.Exit();
                        return;
                    }
                    else
                    {
                        //espera e invoca
                        waitRun();
                    }
                }
                else
                {
                    //chama a task
                    _taskLogin = Task.Run(() => doWorkAsync(logon, null));

                    //espera e invoca
                    waitRun();
                }
            }
            catch (Exception ex)
            {
                string msg = "Erro desconhecido!. Contate o administrador ou verifique o log de eventos!";
                LoggerUtilIts.GenerateLogs(ex, msg);
                XMessageIts.ExceptionMessageDetails(ex, msg);
                //Environment.Exit(0); //nao fechar a aplicação em TODAS as exceptions
            }
        }

        /// <summary>
        ///Acao de login com verifcacao no no banco de dados
        /// Acesso sera feito somente pra manipular o form do login
        /// </summary>
        /// <param name="logon"></param>Login informado ID/Nome Utilizador
        /// <param name="senha"></param>Senha
        /// <returns></returns>true logado false nao logado
        public bool Login(string logon, string senha)
        {
            //se foi inciado
            if (this._isInit)
            {
                //rode sequencialmente
                //rodando a tarefa nao asscrinono consigo manipular 
                //o form do login livremente liberando o form somente
                //quando o login for aceito pelo banco de dados
                UnitWork.Usuario = doWork(logon, senha);
                //se logou deixei entrar
                if (UnitWork.Usuario != null)
                    this._xFrmLogin.Dispose();
            }
            else
            {
                //rode assincrono para iniciar o EF
                //rodando essa tarefa a assincrona os metodo do botao login
                //e o metodo Login da interface rodando em paralelo
                //isso implica que o form do login nao eh fechado
                //impedindo a chamada do form menu
                this._taskLogin = Task.Run(() => doWorkAsync(logon, senha));

            }
            return true;
        }

        //Acao disparada pelo botao de login
        //Sequencialmente
        private Usuario doWork(string logon, string senha)
        {
            //aqui eu ja tenho contexto iniciado

            //traz um usuario indexado do banco
            Usuario user = new UsuarioDaoManager().IsLogin(logon, senha);

            //seta o usuario
            UnitWork.Usuario = user;

            if (user == null)
            {
                MessageBoxBlack.Show("Usuário ou senha inválidos.", "Atenção");

                this._xFrmLogin.BringToFront();
            }
            else
            {
                //login no servidor
                _application.ITSTools.Login(logon, senha);

                //use o tema do user
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = user.Skin;

                //agora sim feche essa janela 
                this._xFrmLogin.DisposeOnLogin = true;

                this._xFrmLogin.Dispose();

                //seta a matriz e filial
                this.setMatrizFilial(_ctx);
            }

            return user;
        }

        //Acao disparada pelo botao de login
        //Totalmente assicrono
        private async Task<Usuario> doWorkAsync(string logon, string senha)
        {
            Usuario user = new Usuario();

            bool result = await WaitEntityFramework.StartTask<Usuario>(taskInitEF());

            //aqui tenho um contexto rodando assincrono
            if (result)
            {
                //ja iniciou nao precisa roda a barra denovo
                //isso impede que outro contexto seja iniciado
                this._isInit = true;

                //traz um usuario indexado do banco
                if (senha == null)
                    //a senha nunca chega nula a nao ser q eu aponte intencionalmente
                    user = new UsuarioDaoManager().FindUserByNameOrId(logon);
                else
                    user = new UsuarioDaoManager().IsLogin(logon, senha);

                //seta o usuario
                UnitWork.Usuario = user;

                if (user == null)
                {
                    //recria
                    this._xFrmLogin = new ITSolution.Framework.Forms.XFrmLogin(this);

                    //nao feche essa janela ate logar corretamente
                    this._xFrmLogin.DisposeOnLogin = false;

                    //marque false
                    //mesmo que o form marque true
                    //no banco de dados foi negado o acesso
                    this._xFrmLogin.IsLogin = false;

                    //agora nem esconde esse form mais
                    //fica amarrado ate logar corretamente
                    this._xFrmLogin.IsHideOnLogin = false;

                    //mostre o botao de cadastro na tela
                    //so deixe cadastrar no inicio se nao tiver usuarios
                    if (_ctx.UsuarioDao.FindAll().Count == 0)
                    {
                        //se nao coloquei o botao na tela
                        if (this._xFrmLogin.ActionBtn == null)
                        {
                            this._xFrmLogin.ActionBtn = addUsuario();
                            this._xFrmLogin.BtnAction.Visible = true;
                        }
                    }

                    //se o login automatico falhou
                    if (this._isLoginAutoFailed)
                    {
                        //apaguei as preferencias
                        //implica e fazer todo o processo novamente
                        File.Delete(UnitWork.PREFERENCIAS);
                    }

                    MessageBoxBlack.Show("Usuário \"" + logon + "\" ou senha inválido(s).", "Atenção");


                }
                else
                {
                    //use o tema do user
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = user.Skin;
                    this._xFrmLogin.IsLogin = true;
                    //login no servidor
                    _application.ITSTools.Login(logon, senha);
                    //agora sim feche essa janela 
                    this._xFrmLogin.DisposeOnLogin = true;

                    //seta a matriz e filial
                    setMatrizFilial(_ctx);
                }

            }


            return user;
        }

        /// <summary>
        /// Cria um contexto
        /// </summary>
        /// <returns></returns>O Contexto
        private BalcaoContext createCtx()
        {
            try
            {
                //retorna o pai
                this._ctx = new BalcaoContext();

                using (var ctxIts = new ITSolutionContext())
                {
                    ctxIts.LazyLoading(false);
                    ctxIts.LembreteDao.Find(1);
                }


                //apenas invoca o mesmo para criação das tabelas
                using (var ctxRpt = new ReportContext())
                {
                    ctxRpt.LazyLoading(false);
                    ctxRpt.ReportGroupDao.Find(1);
                }

                using (var ctxCambio = new CambioContext())
                {
                    ctxCambio.LazyLoading(false);
                    ctxCambio.MoedaDao.Find(1);
                }

            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionJustMessage(ex, "Falha na inicialização do controlador do contexto!", "Falha no Sistema");
                Application.Exit();
                Environment.Exit(0);
            }

            return _ctx;

        }

        /// <summary>
        /// Inicia o contexto de forma assincrona
        /// </summary>
        /// <returns></returns>
        private async Task<DbContextIts> taskInitEF()
        {
            return await Task.Run(() => createCtx());
        }

        /// <summary>
        /// Aguarde o fim da tarefa e invoca o menu se o contexto foi iniciado e o usuário logado corretamente
        /// </summary>
        private void waitRun()
        {
            try
            {
                _taskLogin.Wait();

            }
            catch (Exception ex)
            {
                string msg = "Ocorreu um erro não identificado !";
                LoggerUtilIts.GenerateLogs(ex, msg);
                XMessageIts.ExceptionJustMessage(ex, msg, "Falha no sistema !");
                throw ex;
            }//se nao conseguiu logar deu ruim
            if (this._xFrmLogin.IsLogin == false)
            {
                //faz tudo denovo mas dessa vez fica amarrado
                //ou seja nao vai fechar o form ate logar corretamente
                this._xFrmLogin.ShowDialog();
            }

            Console.WriteLine("Task Done");

            if (this._xFrmMatrizFilial == null || this._xFrmMatrizFilial.IsFilial == false || this._xFrmMatrizFilial.IsCancel)
            {
                Application.Exit();
            }
            else
            {


                Usuario user = _taskLogin.Result;
                //se algum deles existe
                if (user != null || UnitWork.Usuario != null)
                {
                    //se o primeiro usuario falhou
                    if (user == null)
                        //entao esse aqui ta ok
                        user = UnitWork.Usuario;

                    //garante o fim da Task
                    _taskLogin.Dispose();

                    //invoka a thread que amarra o menu principal
                    var licManager = new LicenseDaoManager();
                    var lic = licManager.GetValidLicense();

                    if (lic != null)
                    {
                        var menu = new XFrmMenu(user, _application);
                        verifyMenu(menu, lic.LicenseDataUnSerialized.ActiveMenus);
                        Application.Run(menu);
                    }
                    else
                        Application.Exit();

                }
            }
        }
        private void verifyMenu(XFrmMenu menu, List<ItsMenu> activeMenus)
        {
            foreach (var mnu_item in activeMenus)
            {
                foreach (RibbonPage page in menu.Ribbon.Pages)
                {
                    if (page.Name == mnu_item.NomeMenu)
                        page.Visible = mnu_item.Status;

                    foreach (RibbonPageGroup grp in page.Groups)
                    {
                        if (grp.Name == mnu_item.NomeMenu)
                            grp.Visible = mnu_item.Status;

                        foreach (BarItemLink btn in grp.ItemLinks)
                        {
                            if (btn.Item.Name == mnu_item.NomeMenu)
                            {
                                btn.Visible = mnu_item.Status;

                                if (btn.Item.Visibility == BarItemVisibility.Never && mnu_item.Status)
                                    btn.Item.Visibility = BarItemVisibility.Always;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Seta os grupo de skin disponiveis do DevExpress
        /// Achamada deste metodo deve ser obrigatóriamente antes da inicialização de qualquer form
        /// </summary>
        private void setTheme()
        {
            // The following line provides localization for the application's user interface. 
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("pt-BR");

            // The following line provides localization for data formats. 
            Thread.CurrentThread.CurrentCulture =
                new CultureInfo("pt-BR");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            //use o tema DEFAULT do VS
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Visual Studio 2013 Blue";

        }

        private void setMatrizFilial(BalcaoContext ctx)
        {
            //prepara para seleção de contexto
            this._xFrmMatrizFilial = new XFrmSetMatrizFilial();
            //verifica as filiais
            var empAll = ctx.EmpresaFilialDao.FindAll();

            //confirma no banco se exite filial
            //se usou as preferencia ou selecionou 
            //evita nulllpointer 
            if (empAll.Count == 0)
            {
                UnitWork.Filial = new EmpresaFilial();
                //apaga qualquer config ant
                this._xFrmMatrizFilial.DeletePreferences();

            }
            else
            {
                //seta as preferencias definidas
                this._xFrmMatrizFilial.SetPreferences(ctx);

                if (!_xFrmMatrizFilial.IsFilial)
                {
                    //se tem so uma use essa mesmo
                    if (empAll.Count == 1)
                    {
                        //use esta
                        UnitWork.Filial = empAll[0];

                    }
                }
            }

            //a matriz foi encontrada e setada no form 
            //ainda e possivel q nao seja feita a entra automatica 
            //entao check se é pra chamar a tela
            if (_xFrmMatrizFilial.IsInvoke)
            {
                //mostra os dados de configuação e tente selecionar
                _xFrmMatrizFilial.ShowDialog();
            }
            //se nao vai selecionar isInvoke vai ser false

        }

        /// <summary>
        /// Recupera o nome de usuário no arquivo de preferências
        /// </summary>
        /// <param name="logon"></param>
        /// <returns></returns>
        private string retryLogon(string logon)
        {
            if (logon == null)
            {

                List<string> preferencias = FileManagerIts.GetDataFile(UnitWork.PREFERENCIAS);
                if (preferencias.Count > 3)
                {
                    try
                    {
                        //recupera do arquivo o logon
                        return ASCIIEncodingIts.Decoded(preferencias[3]);

                    }
                    catch (Exception ex)
                    {
                        LoggerUtilIts.ShowExceptionLogs(ex);

                        FileManagerIts.DeleteFile(UnitWork.PREFERENCIAS);
                        return null;
                    }
                }
            }
            return logon;
        }

        //chama a tela para adicionar usando atraves do delegate
        private MethodInvoker addUsuario()
        {
            //executa essa acao la no metodo 
            var actionAddCli = new MethodInvoker(delegate
            {
                var frm = new XFrmUsuarioView(null);

                frm.ShowDialog();

            });
            return actionAddCli;
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
    }
}
