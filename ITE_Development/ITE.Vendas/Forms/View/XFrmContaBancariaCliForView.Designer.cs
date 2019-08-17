namespace ITE.Vendas.Forms.View
{
    partial class XFrmContaBancariaCliForView
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
            this.groupControlDadosEndereco = new DevExpress.XtraEditors.GroupControl();
            this.txtAgencia = new DevExpress.XtraEditors.TextEdit();
            this.txtNomeBanco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtContaBancaria = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosEndereco)).BeginInit();
            this.groupControlDadosEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContaBancaria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlDadosEndereco
            // 
            this.groupControlDadosEndereco.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControlDadosEndereco.AppearanceCaption.Options.UseFont = true;
            this.groupControlDadosEndereco.Controls.Add(this.btnSalvar);
            this.groupControlDadosEndereco.Controls.Add(this.groupBox1);
            this.groupControlDadosEndereco.Controls.Add(this.txtAgencia);
            this.groupControlDadosEndereco.Controls.Add(this.txtNomeBanco);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl11);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl5);
            this.groupControlDadosEndereco.Controls.Add(this.txtContaBancaria);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl6);
            this.groupControlDadosEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDadosEndereco.Location = new System.Drawing.Point(0, 0);
            this.groupControlDadosEndereco.Name = "groupControlDadosEndereco";
            this.groupControlDadosEndereco.Size = new System.Drawing.Size(363, 261);
            this.groupControlDadosEndereco.TabIndex = 0;
            this.groupControlDadosEndereco.Text = "Dados Bancários";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(13, 180);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtAgencia.Properties.Appearance.Options.UseFont = true;
            this.txtAgencia.Size = new System.Drawing.Size(108, 20);
            this.txtAgencia.TabIndex = 2;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(12, 55);
            this.txtNomeBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeBanco.Properties.Appearance.Options.UseFont = true;
            this.txtNomeBanco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeBanco.Size = new System.Drawing.Size(327, 20);
            this.txtNomeBanco.TabIndex = 1;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl11.Location = new System.Drawing.Point(141, 161);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(32, 14);
            this.labelControl11.TabIndex = 60;
            this.labelControl11.Text = "Conta";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Location = new System.Drawing.Point(12, 36);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(109, 14);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "Nome da Instituição";
            // 
            // txtContaBancaria
            // 
            this.txtContaBancaria.Location = new System.Drawing.Point(141, 180);
            this.txtContaBancaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContaBancaria.Name = "txtContaBancaria";
            this.txtContaBancaria.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtContaBancaria.Properties.Appearance.Options.UseFont = true;
            this.txtContaBancaria.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContaBancaria.Size = new System.Drawing.Size(198, 20);
            this.txtContaBancaria.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Location = new System.Drawing.Point(13, 161);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 14);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "Agência";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(363, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 261);
            this.barDockControlBottom.Size = new System.Drawing.Size(363, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 261);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(363, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 261);
            // 
            // radioGroup1
            // 
            this.radioGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioGroup1.Location = new System.Drawing.Point(3, 17);
            this.radioGroup1.MenuManager = this.barManager1;
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Corrente"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Poupança"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Conjunta")});
            this.radioGroup1.Size = new System.Drawing.Size(320, 37);
            this.radioGroup1.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGroup1);
            this.groupBox1.Location = new System.Drawing.Point(13, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 57);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Conta";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(259, 221);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 28);
            this.btnSalvar.TabIndex = 64;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // XFrmAddCtbCliFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.groupControlDadosEndereco);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.Name = "XFrmAddCtbCliFor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão dados bancários:";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosEndereco)).EndInit();
            this.groupControlDadosEndereco.ResumeLayout(false);
            this.groupControlDadosEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContaBancaria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDadosEndereco;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit txtAgencia;
        private DevExpress.XtraEditors.TextEdit txtNomeBanco;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtContaBancaria;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
    }
}