namespace ITE.Vendas.Forms.View
{
    partial class XFrmUsuarioView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmUsuarioView));
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenhaConfirmacao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupoUsuario = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeUtilizador = new DevExpress.XtraEditors.TextEdit();
            this.btnAddGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaConfirmacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeUtilizador.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 108);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(358, 22);
            this.txtNome.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(26, 233);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(358, 22);
            this.txtSenha.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(229, 345);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 28);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(314, 345);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 28);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 85);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Nome";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 209);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Senha";
            // 
            // txtSenhaConfirmacao
            // 
            this.txtSenhaConfirmacao.Location = new System.Drawing.Point(26, 300);
            this.txtSenhaConfirmacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenhaConfirmacao.Name = "txtSenhaConfirmacao";
            this.txtSenhaConfirmacao.Properties.PasswordChar = '•';
            this.txtSenhaConfirmacao.Size = new System.Drawing.Size(358, 22);
            this.txtSenhaConfirmacao.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 277);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Confirme a senha";
            // 
            // cbGrupoUsuario
            // 
            this.cbGrupoUsuario.Location = new System.Drawing.Point(26, 46);
            this.cbGrupoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGrupoUsuario.Name = "cbGrupoUsuario";
            this.cbGrupoUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupoUsuario.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbGrupoUsuario.Size = new System.Drawing.Size(358, 22);
            this.cbGrupoUsuario.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 22);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Grupo";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 144);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 16);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Nome de acesso";
            // 
            // txtNomeUtilizador
            // 
            this.txtNomeUtilizador.Location = new System.Drawing.Point(27, 167);
            this.txtNomeUtilizador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeUtilizador.Name = "txtNomeUtilizador";
            this.txtNomeUtilizador.Size = new System.Drawing.Size(358, 22);
            this.txtNomeUtilizador.TabIndex = 2;
            // 
            // btnAddGrupo
            // 
            this.btnAddGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGrupo.Image")));
            this.btnAddGrupo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAddGrupo.Location = new System.Drawing.Point(357, 14);
            this.btnAddGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddGrupo.Name = "btnAddGrupo";
            this.btnAddGrupo.Size = new System.Drawing.Size(28, 25);
            this.btnAddGrupo.TabIndex = 12;
            this.btnAddGrupo.Text = "Add Grupo";
            this.btnAddGrupo.Click += new System.EventHandler(this.btnAddGrupo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRefresh.Location = new System.Drawing.Point(323, 14);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(28, 25);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // XFrmAddUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 394);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddGrupo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtNomeUtilizador);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbGrupoUsuario);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSenhaConfirmacao);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "XFrmAddUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário:";
            this.Shown += new System.EventHandler(this.XFrmAddUsuario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaConfirmacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeUtilizador.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSenhaConfirmacao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbGrupoUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtNomeUtilizador;
        private DevExpress.XtraEditors.SimpleButton btnAddGrupo;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
    }
}