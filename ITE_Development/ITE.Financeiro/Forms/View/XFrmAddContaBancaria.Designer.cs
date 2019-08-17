namespace ITE.Financeiro.Forms.View
{
    partial class XFrmAddContaBancaria
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoConta = new DevExpress.XtraEditors.TextEdit();
            this.txtDescConta = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.rdTipoConta = new DevExpress.XtraEditors.RadioGroup();
            this.txtNomeBanco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroConta = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.txtNumAgencia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtEditInicial = new DevExpress.XtraEditors.DateEdit();
            this.txtSaldoInicial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpFilial1 = new ITE.Components.LookUpFilial();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAgencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoInicial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Código:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 259);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Descrição da Conta:";
            // 
            // txtCodigoConta
            // 
            this.txtCodigoConta.Location = new System.Drawing.Point(18, 49);
            this.txtCodigoConta.Name = "txtCodigoConta";
            this.txtCodigoConta.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoConta.TabIndex = 1;
            // 
            // txtDescConta
            // 
            this.txtDescConta.Location = new System.Drawing.Point(18, 278);
            this.txtDescConta.Name = "txtDescConta";
            this.txtDescConta.Size = new System.Drawing.Size(472, 20);
            this.txtDescConta.TabIndex = 8;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.rdTipoConta);
            this.groupControl1.Controls.Add(this.txtNomeBanco);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtNumeroConta);
            this.groupControl1.Controls.Add(this.btnCancelar);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btnSalvar);
            this.groupControl1.Controls.Add(this.txtNumAgencia);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.dtEditInicial);
            this.groupControl1.Controls.Add(this.txtSaldoInicial);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtDescConta);
            this.groupControl1.Controls.Add(this.txtCodigoConta);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 64);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(508, 360);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Conta Bancária:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(18, 79);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Tipo de Conta:";
            // 
            // rdTipoConta
            // 
            this.rdTipoConta.Location = new System.Drawing.Point(19, 98);
            this.rdTipoConta.Name = "rdTipoConta";
            this.rdTipoConta.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Corrente"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Poupança"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Conjunta")});
            this.rdTipoConta.Size = new System.Drawing.Size(471, 29);
            this.rdTipoConta.TabIndex = 4;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(18, 163);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(212, 20);
            this.txtNomeBanco.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(18, 144);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(95, 13);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "Nome da Instituição";
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(157, 219);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Properties.Mask.EditMask = "\\d+-\\d";
            this.txtNumeroConta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumeroConta.Size = new System.Drawing.Size(239, 20);
            this.txtNumeroConta.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(321, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(157, 200);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Número Conta:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(410, 314);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 28);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNumAgencia
            // 
            this.txtNumAgencia.Location = new System.Drawing.Point(18, 219);
            this.txtNumAgencia.Name = "txtNumAgencia";
            this.txtNumAgencia.Properties.Mask.EditMask = "\\d+-\\d";
            this.txtNumAgencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumAgencia.Size = new System.Drawing.Size(100, 20);
            this.txtNumAgencia.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 200);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 13);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "Agência";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(352, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Abertura:";
            // 
            // dtEditInicial
            // 
            this.dtEditInicial.EditValue = null;
            this.dtEditInicial.Location = new System.Drawing.Point(352, 49);
            this.dtEditInicial.Name = "dtEditInicial";
            this.dtEditInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditInicial.Size = new System.Drawing.Size(138, 20);
            this.dtEditInicial.TabIndex = 3;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.EditValue = "0,00";
            this.txtSaldoInicial.Location = new System.Drawing.Point(157, 49);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Properties.Mask.EditMask = "n";
            this.txtSaldoInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSaldoInicial.Size = new System.Drawing.Size(143, 20);
            this.txtSaldoInicial.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(157, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Saldo inicial:";
            // 
            // lookUpFilial1
            // 
            this.lookUpFilial1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpFilial1.Filial = null;
            this.lookUpFilial1.Location = new System.Drawing.Point(0, 0);
            this.lookUpFilial1.Matriz = null;
            this.lookUpFilial1.Name = "lookUpFilial1";
            this.lookUpFilial1.Size = new System.Drawing.Size(508, 58);
            this.lookUpFilial1.TabIndex = 0;
            // 
            // XFrmAddContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 424);
            this.Controls.Add(this.lookUpFilial1);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.Name = "XFrmAddContaBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura Conta Bancária:";
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumAgencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoInicial.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCodigoConta;
        private DevExpress.XtraEditors.TextEdit txtDescConta;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtEditInicial;
        private DevExpress.XtraEditors.TextEdit txtSaldoInicial;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private Components.LookUpFilial lookUpFilial1;
        private DevExpress.XtraEditors.TextEdit txtNumeroConta;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtNumAgencia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtNomeBanco;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.RadioGroup rdTipoConta;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}