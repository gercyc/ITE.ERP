namespace ITE.Fiscal.RegrasFiscais
{
    partial class XFrmAddImpostoRegraFiscal
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkImposto = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtAliquota = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkSituacaoTribut = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbOperacaoICMS = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbTributacaoLivro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbTributacaoIpi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTributacaoIcms = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEnquadIPI = new DevExpress.XtraEditors.TextEdit();
            this.lbEnqIPI = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lkImposto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkSituacaoTribut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOperacaoICMS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTributacaoLivro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTributacaoIpi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTributacaoIcms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnquadIPI.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(5, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Imposto:";
            // 
            // lkImposto
            // 
            this.lkImposto.Location = new System.Drawing.Point(5, 54);
            this.lkImposto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkImposto.Name = "lkImposto";
            this.lkImposto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkImposto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoImposto", 60, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescricaoImposto", 180, "Descrição")});
            this.lkImposto.Properties.NullText = "Selecione um imposto...";
            this.lkImposto.Size = new System.Drawing.Size(250, 20);
            this.lkImposto.TabIndex = 0;
            this.lkImposto.EditValueChanged += new System.EventHandler(this.lkImposto_EditValueChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(342, 390);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(242, 390);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Far;
            this.separatorControl1.Location = new System.Drawing.Point(5, 3);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.separatorControl1.Size = new System.Drawing.Size(427, 42);
            this.separatorControl1.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 14);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(275, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Adição de imposto para o tipo de movimento selecionado:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtEnquadIPI);
            this.groupControl1.Controls.Add(this.lbEnqIPI);
            this.groupControl1.Controls.Add(this.txtAliquota);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.lkSituacaoTribut);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lkImposto);
            this.groupControl1.Location = new System.Drawing.Point(5, 48);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(426, 141);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Dados básicos";
            // 
            // txtAliquota
            // 
            this.txtAliquota.Location = new System.Drawing.Point(279, 54);
            this.txtAliquota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.Size = new System.Drawing.Size(113, 20);
            this.txtAliquota.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(279, 28);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Alíquota:";
            // 
            // lkSituacaoTribut
            // 
            this.lkSituacaoTribut.Location = new System.Drawing.Point(5, 111);
            this.lkSituacaoTribut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkSituacaoTribut.Name = "lkSituacaoTribut";
            this.lkSituacaoTribut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkSituacaoTribut.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoCst", 50, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescricaoCst", 180, "Descrição")});
            this.lkSituacaoTribut.Properties.NullText = "Selecione um código CST...";
            this.lkSituacaoTribut.Size = new System.Drawing.Size(250, 20);
            this.lkSituacaoTribut.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(5, 85);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 14);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Situação tributária:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbOperacaoICMS);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.cbTributacaoLivro);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.cbTributacaoIpi);
            this.groupControl2.Controls.Add(this.cbTributacaoIcms);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(5, 195);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(427, 190);
            this.groupControl2.TabIndex = 23;
            this.groupControl2.Text = "Dados de tributação";
            // 
            // cbOperacaoICMS
            // 
            this.cbOperacaoICMS.Location = new System.Drawing.Point(5, 139);
            this.cbOperacaoICMS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbOperacaoICMS.Name = "cbOperacaoICMS";
            this.cbOperacaoICMS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbOperacaoICMS.Size = new System.Drawing.Size(191, 20);
            this.cbOperacaoICMS.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(5, 113);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(101, 14);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "Operação de ICMS";
            // 
            // cbTributacaoLivro
            // 
            this.cbTributacaoLivro.Location = new System.Drawing.Point(279, 139);
            this.cbTributacaoLivro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTributacaoLivro.Name = "cbTributacaoLivro";
            this.cbTributacaoLivro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTributacaoLivro.Size = new System.Drawing.Size(116, 20);
            this.cbTributacaoLivro.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(279, 113);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(116, 14);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Tributação livro fiscal:";
            // 
            // cbTributacaoIpi
            // 
            this.cbTributacaoIpi.Location = new System.Drawing.Point(279, 55);
            this.cbTributacaoIpi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTributacaoIpi.Name = "cbTributacaoIpi";
            this.cbTributacaoIpi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTributacaoIpi.Size = new System.Drawing.Size(113, 20);
            this.cbTributacaoIpi.TabIndex = 23;
            // 
            // cbTributacaoIcms
            // 
            this.cbTributacaoIcms.Location = new System.Drawing.Point(5, 55);
            this.cbTributacaoIcms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTributacaoIcms.Name = "cbTributacaoIcms";
            this.cbTributacaoIcms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTributacaoIcms.Size = new System.Drawing.Size(191, 20);
            this.cbTributacaoIcms.TabIndex = 22;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(279, 29);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 14);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Tributação IPI:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(5, 29);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 14);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Tributação ICMS:";
            // 
            // txtEnquadIPI
            // 
            this.txtEnquadIPI.Location = new System.Drawing.Point(279, 111);
            this.txtEnquadIPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEnquadIPI.Name = "txtEnquadIPI";
            this.txtEnquadIPI.Size = new System.Drawing.Size(113, 20);
            this.txtEnquadIPI.TabIndex = 13;
            this.txtEnquadIPI.Visible = false;
            // 
            // lbEnqIPI
            // 
            this.lbEnqIPI.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnqIPI.Location = new System.Drawing.Point(279, 85);
            this.lbEnqIPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbEnqIPI.Name = "lbEnqIPI";
            this.lbEnqIPI.Size = new System.Drawing.Size(135, 14);
            this.lbEnqIPI.TabIndex = 14;
            this.lbEnqIPI.Text = "Cód. Enquadramento IPI";
            this.lbEnqIPI.Visible = false;
            // 
            // XFrmAddImpostoRegraFiscal
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 428);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "XFrmAddImpostoRegraFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adição de imposto ao tipo de movimento";
            this.Shown += new System.EventHandler(this.XFrmAddImpostoTipoMovimento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.lkImposto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkSituacaoTribut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbOperacaoICMS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTributacaoLivro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTributacaoIpi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTributacaoIcms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnquadIPI.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkImposto;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtAliquota;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lkSituacaoTribut;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbOperacaoICMS;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbTributacaoLivro;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbTributacaoIpi;
        private DevExpress.XtraEditors.ComboBoxEdit cbTributacaoIcms;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEnquadIPI;
        private DevExpress.XtraEditors.LabelControl lbEnqIPI;
    }
}