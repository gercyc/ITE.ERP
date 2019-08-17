using System;
using System.Windows.Forms;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Listeners;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraEditors;

namespace ITSolution.Framework.Beans.Forms
{
    public partial class XFrmLoginOld : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /// <summary>
        /// true Login efetuado caso contrário false
        /// </summary>
        public bool IsLogin { set; get; }
        /// <summary>
        /// Ação a ser invocada a após a permissão login
        /// </summary>
        private ActionLogin action;
        /// <summary>
        /// Usuário que está realizando Login
        /// </summary>
        public String UserName { get; set; }
        public String Password { get; set; }
        public bool IsCancel { get; set; }
        /// <summary>
        ///Limpa os campos sempre que o form é exibido
        /// </summary>
        public bool CleanOnStart { get; set; }

        public LabelControl LabelLogin { get { return this.lblLogin; } }

        public Delegate ActionBtn { get; set; }
        public SimpleButton BtnAction { get { return btnActionBtn; } }
        #region Construtores
        private XFrmLoginOld()
        {
            InitializeComponent();
            this.ActiveControl = this.txtNome;
            this.txtNome.Focus();


        }

        public XFrmLoginOld(ActionLogin actionLogin)
            : this()
        {
            this.action = actionLogin;
        }
        #endregion

        #region Metodos 

        private Usuario indexarDados()
        {
            string nomeUsuario = txtNome.Text;
            string pw = txtSenha.Text;

            return new Usuario(nomeUsuario, pw);
        }

        public void Run()
        {
            //Show();
            this.ShowDialog();
        }


        public TextBox GetTextNomeUsuario()
        {
            return this.txtNome;
        }

        #endregion

        #region Eventos
        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario user = indexarDados();
            //verifica a consistencia dos dados
            if (ValidadorDTO.ValidateWarningAll(user))
            {
                //tenta fazer Login
                IsLogin = action.Login(user.Nome, user.Senha);

                if (IsLogin)
                {
                    this.UserName = user.Nome;
                    this.Password = user.Senha;
                    this.IsCancel = false;
                }
                else
                {
                    XMessageIts.Advertencia("Usuário ou senha inválido");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsCancel = true;
            this.Dispose();
        }

        private void XFrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnCancelar_Click(null, null);

            else if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control)
            {
                //Chame a tela para procurar ClienteIts
                btnLogar_Click(null, null);

            }

        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(txtNome.Text) && String.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    txtSenha.Focus();
                }
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(txtNome.Text) && !String.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    btnLogar_Click(null, null);
                }
            }

        }

        #endregion Eventos

        #region Classe interna

        /// <summary>
        /// Classe para uso interno no Form
        /// </summary>
        internal class Usuario
        {
            [Required]
            [StringLength(50, MinimumLength = 1)]
            public String Nome { get; set; }

            [Required]
            [StringLength(40, MinimumLength = 1)]
            public String Senha { get; set; }

            [Required]
            public DateTime DataInclusao { get; set; }

            public Usuario(string nome, string senha)
            {
                this.Nome = nome;
                this.Senha = senha;
            }
        }


        #endregion

        private void XFrmLogin_Load(object sender, EventArgs e)
        {
            if (this.CleanOnStart)
            {
                this.txtNome.Text = "";
                this.txtSenha.Text = "";
            }
        }

        private void XFrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //se eu cliquei em fechar e tem campo vazio vou cancelar o login
            if (IsLogin==false)
                this.IsCancel = true;
        }

        private void btnActionBtn_Click(object sender, EventArgs e)
        {
            if(ActionBtn!=null)
                ActionBtn.DynamicInvoke();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //atualiza o label a cada 1 seg
            this.lblHrs.Text = DateTime.Now.ToLongTimeString();
            this.lblData.Text = DateTime.Now.Date.ToLongDateString();
        }
    }
}
