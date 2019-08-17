using System;
using System.Windows.Forms;
using ITE.Entidades.POCO;
using ITSolution.Framework.Validador;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.DaoManager;
using ITSolution.Framework.Common.BaseClasses.Reports.Enumeradores;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmUsuarioView : DevExpress.XtraEditors.XtraForm
    {
        private Usuario usuarioAnt;
        private Usuario userLogado;

        public bool IsSave { get; private set; }

        public XFrmUsuarioView(Usuario userLogado)
        {
            InitializeComponent();
            this.userLogado = userLogado;
        }

        public XFrmUsuarioView(Usuario userLogado, Usuario user)
            : this(userLogado)
        {
            this.usuarioAnt = indexarUsuario(user);
        }

        private Usuario indexarUsuario(Usuario user)
        {
            if (user != null)
            {
                txtNome.Text = user.NomeUsuario;
                txtNomeUtilizador.Text = user.NomeUtilizador;
                txtSenha.Text = ASCIIEncodingIts.Decoded(user.Senha);
                txtSenhaConfirmacao.Text = txtSenha.Text;
                cbGrupoUsuario.AddItem<GrupoUsuario>(user.GrupoUsuario);

            }
            return user;
        }

        private Usuario indexarUsuario()
        {
            string nomeUsuario = txtNome.Text;
            string nomeUtil = txtNomeUtilizador.Text;
            string pw = txtSenha.Text;
            string pw2 = txtSenhaConfirmacao.Text;
            GrupoUsuario grupo = cbGrupoUsuario.SelectedItem as GrupoUsuario;
                    

            var novo = new Usuario(nomeUsuario, nomeUtil, pw, pw2, grupo);

            if (usuarioAnt != null)
                novo.IdUsuario = usuarioAnt.IdUsuario;
      

            return novo;
        }

        private void updateUsuario(Usuario novo, BalcaoContext ctx)
        {
            var current = ctx.UsuarioDao.Find(usuarioAnt.IdUsuario);

            if (current == null)
            {
                XMessageIts.Advertencia("Usuário a ser atualizado não foi encontrada");
                return;
            }

            // o grupo nao consta no update pq o usuario eh abstrato
            current.IdGrupoUsuario = novo.IdGrupoUsuario;

            current.Update(novo);

            if (ctx.UsuarioDao.Update(current))
            {
                XMessageIts.Mensagem("Usuário atualizado!");
                this.usuarioAnt.Update(current);
                this.usuarioAnt.GrupoUsuario = current.GrupoUsuario;


                if (usuarioAnt.IdUsuario == Entidades.UnitControl.UnitWork.Usuario.IdUsuario)
                {
                    Entidades.UnitControl.UnitWork.Usuario = current;
                }

                this.Dispose();
            }
        }

        private bool isUsuario(Usuario u)
        {
            if (ValidadorDTO.ValidateWarningAll(u))
            {
                if (userLogado != null)
                {
                    int admGroup = (int)TypeGroupUser.Administrador;
                    //se nao é o usuario adm q esta logado 
                    //e alguem esta tentando atribuir privilegio a um usuario
                    if (userLogado.IdGrupoUsuario != admGroup 
                        && u.IdGrupoUsuario == admGroup)
                    {
                        XMessageIts.Erro("Somente o administrador pode conceder privilégios a outros \"Usuários\"!",
                            "Acesso negado");
                    }
                    else//ok
                        return true;
                }
            }
            return false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Usuario novo = indexarUsuario();

            if ( isUsuario(novo))
            {
                IsSave = new UsuarioDaoManager().SaveUpdate(novo);
                if (IsSave)
                    this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var v = indexarUsuario();
            if (!String.IsNullOrWhiteSpace(v.NomeUsuario)
                && !String.IsNullOrWhiteSpace(v.Senha) && usuarioAnt == null)
            {

                var op = XMessageIts.Confirmacao("Cancelar inclusão de Usuario ?");

                if (op == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }

        }

        private void XFrmAddUsuario_Shown(object sender, EventArgs e)
        {
            if (usuarioAnt == null)
                btnRefresh_Click(null, null);
        }

        private void btnAddGrupo_Click(object sender, EventArgs e)
        {
            new XFrmGrupoUsuarioView().ShowDialog();
            btnRefresh_Click(null, null);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = await new BalcaoContext().GrupoUsuarioDao.FindAllAsync();

                cbGrupoUsuario.AddList<GrupoUsuario>(lista);
            }
            catch
            {
                //Whatever
            }
        }
    }
}