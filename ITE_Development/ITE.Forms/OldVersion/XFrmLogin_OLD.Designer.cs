
using DevExpress.XtraEditors;

namespace ITSolution.Framework.Beans.Forms
{
    partial class XFrmLoginOld
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmLoginOld));
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogar = new DevExpress.XtraEditors.SimpleButton();
            this.lblLogin = new DevExpress.XtraEditors.LabelControl();
            this.lblSenha = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnActionBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblData = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblHrs = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(197, 140);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(358, 22);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(345, 187);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnLogar.Appearance.Options.UseFont = true;
            this.btnLogar.Image = ((System.Drawing.Image)(resources.GetObject("btnLogar.Image")));
            this.btnLogar.Location = new System.Drawing.Point(456, 187);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(98, 30);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "Logar";
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblLogin.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(199, 53);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(34, 16);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Logon";
            // 
            // lblSenha
            // 
            this.lblSenha.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblSenha.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(197, 116);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(36, 16);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtNome.Location = new System.Drawing.Point(197, 75);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(357, 24);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // btnActionBtn
            // 
            this.btnActionBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnActionBtn.Appearance.Options.UseFont = true;
            this.btnActionBtn.Image = ((System.Drawing.Image)(resources.GetObject("btnActionBtn.Image")));
            this.btnActionBtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnActionBtn.Location = new System.Drawing.Point(456, 34);
            this.btnActionBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActionBtn.Name = "btnActionBtn";
            this.btnActionBtn.Size = new System.Drawing.Size(99, 31);
            this.btnActionBtn.TabIndex = 4;
            this.btnActionBtn.Text = "Cadastrar";
            this.btnActionBtn.Visible = false;
            this.btnActionBtn.Click += new System.EventHandler(this.btnActionBtn_Click);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(741, 62);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 534);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(741, 40);
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.lblData);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lblHrs);
            this.panelControl1.Controls.Add(this.btnActionBtn);
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Controls.Add(this.txtNome);
            this.panelControl1.Controls.Add(this.txtSenha);
            this.panelControl1.Controls.Add(this.lblSenha);
            this.panelControl1.Controls.Add(this.btnLogar);
            this.panelControl1.Controls.Add(this.lblLogin);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 62);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(741, 472);
            this.panelControl1.TabIndex = 8;
            // 
            // lblData
            // 
            this.lblData.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Appearance.Font = new System.Drawing.Font("Tahoma", 22F);
            this.lblData.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(12, 361);
            this.lblData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(410, 45);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Nome do Dia, dia do Mes";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(554, 450);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(179, 16);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Sistema de Gestão Empresarial";
            // 
            // lblHrs
            // 
            this.lblHrs.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblHrs.Appearance.Font = new System.Drawing.Font("Tahoma", 40F);
            this.lblHrs.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblHrs.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblHrs.Location = new System.Drawing.Point(12, 277);
            this.lblHrs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblHrs.Name = "lblHrs";
            this.lblHrs.Size = new System.Drawing.Size(170, 81);
            this.lblHrs.TabIndex = 6;
            this.lblHrs.Text = "Horas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 398);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 59000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // XFrmLoginOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 574);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "XFrmLoginOld";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Login:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XFrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.XFrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnLogar;
        private DevExpress.XtraEditors.LabelControl lblLogin;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private SimpleButton btnActionBtn;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private PanelControl panelControl1;
        private LabelControl lblData;
        private LabelControl lblHrs;
        private LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}