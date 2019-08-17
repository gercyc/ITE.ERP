using ITE.Entidades.POCO;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Listeners;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ITE.Entidades.Enumeradores;
using System.Collections.Generic;

namespace ITE.Entidades.UnitControl
{
    /// <summary>
    /// Classe de controle de regra com base em um usuário existente no sistema
    /// Encapsulador da classe XFrmLogin para usuários: vendedor, gerente, administrador etc
    /// </summary>
    public class UnitWork : ActionLogin
    {
        public static string PREFERENCIAS = Path.Combine(Application.StartupPath, "preferences");
        public static Usuario Usuario { get; set; }
        public static EmpresaFilial Filial { get; set; }
        public ITSolution.Framework.Forms.XFrmLoginRestrito XFrmLogin { get; set; }
        public UsuarioDaoManager UserManager { get; set; }

        public UnitWork(UsuarioDaoManager userManager)
        {
            this.UserManager = userManager;
            this.XFrmLogin = new ITSolution.Framework.Forms.XFrmLoginRestrito(this);
            AddUserAutoComplete();
            this.XFrmLogin.CleanOnStart = false;
            this.XFrmLogin.Text = "Login: ";

        }

        public UnitWork()
            : this(new UsuarioDaoManager())
        {

        }

        /// <summary>
        /// O campo de texto do usuário passa a ter auto complete
        /// </summary>
        public void AddUserAutoComplete()
        {
            using (var ctx = new BalcaoContext())
            {
                List<UserView> names = (from u in ctx.Usuarios
                             select new UserView
                             {
                                 Nickname = u.NomeUtilizador
                             }).ToList<UserView>();

                AutoCompleteIts.AddAutoCompleteTextEdit(this.XFrmLogin.GetTextNomeUsuario(), names);
            }

        }
    
        /// <summary>
        /// Realiza login
        /// </summary>
        /// <param name="title"></param>Titulo
        /// <param name="action"></param>Ação de cadastrar usuario
        /// <returns></returns>
        public Usuario Login(string title = null)
        {
            if (FormsUtil.isFormDisposedOrNull(this.XFrmLogin))
                this.XFrmLogin = new ITSolution.Framework.Forms.XFrmLoginRestrito(this);

            if (title != null)
                this.XFrmLogin.Text = title;

            this.XFrmLogin.Run();

            if (this.XFrmLogin.IsCancel)
                return null;

            return this.IsLogin();
        }

        /// <summary>
        /// Ação de Login para RbbFrmLogin
        /// Verifica se o usuário existe no banco de dados
        /// </summary>
        /// <returns></returns>
        public bool Login(string logon, string senha)
        {
            try
            {
                Usuario user = null;
                //codifica a senha pois ela foi criptografa no banco
                //entao nao sabemos qual é a verdadeira senha
                var result = ASCIIEncodingIts.Coded(senha);

                using (var ctx = new BalcaoContext())
                {
                    if (StringUtilIts.IsContainsLetters(logon))
                    {
                        //busca o User com a senha codificada
                        user = ctx.UsuarioDao
                          .Where(u => u.NomeUtilizador == logon && u.Senha == result)
                          .FirstOrDefault();
                    }
                    else
                    {

                        //tente pelo ID
                        var id = ParseUtil.ToInt(logon);

                        user = ctx.UsuarioDao
                               .Where(u => u.IdUsuario == id && u.Senha == result).FirstOrDefault();

                    }

                    if (!this.XFrmLogin.IsDisposed)
                        this.XFrmLogin.Dispose();
                    //True Valido
                    //False invalido
                    var isLogado = user != null;

                    if (isLogado)
                    {
                        this.XFrmLogin.UserName = user.NomeUsuario;

                    }

                    return isLogado;
                }
            }
            catch (System.Reflection.TargetInvocationException ex)
            {
                XMessageIts.ExceptionMessage(ex);
                return false;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
                return false;
            }
        }

        /// <summary>
        /// Login com permissao para admin e gerente
        /// </summary>
        /// <returns></returns>
        public bool LoginAreaRestrista(string title = null)
        {
            this.XFrmLogin = new ITSolution.Framework.Forms.XFrmLoginRestrito(this);

            this.XFrmLogin.Text = title != null ? title : this.XFrmLogin.Text;
            this.XFrmLogin.Run();

            if (!this.XFrmLogin.IsCancel)
            {
                if (this.UserManager.IsSuperUser(this.XFrmLogin.UserName))
                {
                    return true;
                }
                else
                {
                    XMessageIts.Advertencia("Acesso Negado", "Área restrita !!!");
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica se o usuário tem permissão ou chama a tem de login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>true se trem permissão ou se conseguiu logar contrário false
        public bool AcessOrLogin(Usuario user, string title = null)
        {
            if (user == null) return false;
            if (title != null)
                this.XFrmLogin.Text = title;

            //se o usuario logado nao possui privilegios
            if (!this.UserManager.IsSuperUser(user.NomeUtilizador))
            {
                //faça login e verifique se foi logado
                return this.LoginAreaRestrista();
            }
            //ta ok
            return true;
        }

        /// <summary>
        /// Verifica se o usuário tem permissão ou chama a tem de login
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>true se trem permissão ou se conseguiu logar contrário false
        public Usuario GetAcessOrLogin(Usuario user)
        {
            var lc = new UnitWork();

            //se o usuario logado nao possui privilegios
            if (!lc.UserManager.IsSuperUser(user.NomeUtilizador))
            {
                //faça login e verifique se foi logado
                var novo_user = this.Login();

                //para aqui
                if (!lc.UserManager.IsSuperUser(novo_user))
                {
                    XMessageIts.Advertencia("Acesso Negado", "Área restrita !!!");
                    return null;
                }
                //tbm ta ok
                return novo_user;
            }
            //permita o acesso sem login
            return user;
        }

        /// <summary>
        /// Retorna o usuário se logado com sucesso ou null
        /// </summary>
        /// <returns></returns>usuário se logado caso contrário null
        public Usuario IsLogin()
        {
            if (this.XFrmLogin.IsLogin)
            {

                return this.UserManager.FindUserByNameOrId(this.XFrmLogin.UserName);
            }
            return null;
        }

        /// <summary>
        /// Verifica se o usuário informado existe no sistema
        /// </summary>
        /// <param name="user"></param>Nome de usuário a ser verificado
        /// <returns></returns>usuário existe caso contrário null
        public Usuario IsLogin(string user)
        {
            try
            {
                return this.UserManager.FindUserByNameOrId(user);
            }
            catch (Exception)
            {
                return null;
            }
        }


        #region Controller SQL via lambda

        static void UpdateAdressCliFor()
        {
            var ctx = new BalcaoContext();

            var all = ctx.CliForDao.FindAll();

            foreach (var c in all)
            {
                var ends = c.Enderecos;

                if (ends.Count > 0)
                {
                    var e = ends.FirstOrDefault();
                    c.NomeEndereco = e.NomeEndereco;
                    c.NumeroEndereco = e.NumeroEndereco;
                    c.NumeroEndereco = e.Complemento;
                    e.TipoEndereco = e.TipoEndereco;
                    c.Bairro = e.Bairro;
                    c.Cep = e.Cep;
                    c.Cidade = e.Cidade;

                    ctx.CliForDao.Update(c);
                }
            }


        }


        public static void FixVendas()
        {
            var ctx = new BalcaoContext();

            var all = ctx.VendaDao.FindAll();

            foreach (var v in all)
            {
                int i = 0;
                foreach (var p in v.Parcelas)
                {
                    if (p.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago)
                        i++;
                }

                //se todas as parcelas foram pagas
                if (i == v.Parcelas.Count || v.FormaPagamentoVenda.TipoFormaPagamento == TypeFormaPagamento.Dinheiro)
                {
                    v.StatusVenda = TypeStatusVenda.Paga;
                    ctx.VendaDao.Update(v);
                }
            }

        }

        public static void FixStatusLanctos()
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);
                var lts = ctx.LancamentoFinanceiroDao.FindAll();
                foreach (var lan in lts)
                {
                    if (lan.IdVenda != null)
                    {
                        var x = ctx.VendaDao.Find(lan.IdVenda);
                        DateTime dt = DateTime.Now;
                        int interval1 = DataUtil.CalcularDias(DateTime.Now, lan.DataVencimento);

                        if (lan.DataVencimento < dt)
                        {
                            lan.StatusLancamento = TypeStatusLancamentoFinanceiro.Vencido;
                        }
                        else
                            lan.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;

                        if (lan.DataPagamento != null)
                        {
                            lan.StatusLancamento = TypeStatusLancamentoFinanceiro.Pago;
                            x.StatusVenda = TypeStatusVenda.Paga;
                        }

                        ctx.VendaDao.Update(x);
                    }
                }
            }
        }

        #endregion

    }
}
