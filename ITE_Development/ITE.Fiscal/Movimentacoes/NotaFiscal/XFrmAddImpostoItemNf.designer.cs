namespace ITE.Fiscal.Movimentacoes.NotaFiscal
{
    partial class XFrmAddImpostoItemNf
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbImposto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBaseCalculo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbSitTribut = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTributacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAliquota = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrImposto = new DevExpress.XtraEditors.TextEdit();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lkImposto = new DevExpress.XtraEditors.LookUpEdit();
            this.lkSitTribut = new DevExpress.XtraEditors.LookUpEdit();
            this.situacaoTributariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoImpostoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cbImposto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseCalculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSitTribut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTributacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrImposto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkImposto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkSitTribut.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoTributariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoImpostoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Situação tributária:";
            // 
            // cbImposto
            // 
            this.cbImposto.Location = new System.Drawing.Point(24, 67);
            this.cbImposto.Name = "cbImposto";
            this.cbImposto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbImposto.Size = new System.Drawing.Size(100, 20);
            this.cbImposto.TabIndex = 0;
            this.cbImposto.Visible = false;
            this.cbImposto.SelectedValueChanged += new System.EventHandler(this.cbImposto_SelectedValueChanged);
            // 
            // txtBaseCalculo
            // 
            this.txtBaseCalculo.Location = new System.Drawing.Point(343, 45);
            this.txtBaseCalculo.Name = "txtBaseCalculo";
            this.txtBaseCalculo.Size = new System.Drawing.Size(100, 20);
            this.txtBaseCalculo.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Imposto:";
            // 
            // cbSitTribut
            // 
            this.cbSitTribut.Location = new System.Drawing.Point(24, 93);
            this.cbSitTribut.Name = "cbSitTribut";
            this.cbSitTribut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSitTribut.Size = new System.Drawing.Size(100, 20);
            this.cbSitTribut.TabIndex = 1;
            this.cbSitTribut.Visible = false;
            // 
            // cbTributacao
            // 
            this.cbTributacao.Location = new System.Drawing.Point(343, 9);
            this.cbTributacao.Name = "cbTributacao";
            this.cbTributacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTributacao.Properties.Items.AddRange(new object[] {
            "1 - Tributada",
            "2 - Isenta",
            "3 - Outras"});
            this.cbTributacao.Size = new System.Drawing.Size(100, 20);
            this.cbTributacao.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(244, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tributação:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(244, 48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Base de cálculo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(459, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Alíquota:";
            // 
            // txtAliquota
            // 
            this.txtAliquota.Location = new System.Drawing.Point(563, 9);
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.Size = new System.Drawing.Size(100, 20);
            this.txtAliquota.TabIndex = 4;
            this.txtAliquota.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtAliquota_EditValueChanging);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(455, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(98, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Valor do imposto:";
            // 
            // txtVlrImposto
            // 
            this.txtVlrImposto.Location = new System.Drawing.Point(563, 45);
            this.txtVlrImposto.Name = "txtVlrImposto";
            this.txtVlrImposto.Size = new System.Drawing.Size(100, 20);
            this.txtVlrImposto.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(498, 80);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(586, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lkImposto
            // 
            this.lkImposto.Location = new System.Drawing.Point(128, 9);
            this.lkImposto.Name = "lkImposto";
            this.lkImposto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkImposto.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoImposto", "Codigo Imposto", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescricaoImposto", "Descricao Imposto", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkImposto.Properties.DataSource = this.tipoImpostoBindingSource;
            this.lkImposto.Properties.NullText = " ";
            this.lkImposto.Size = new System.Drawing.Size(110, 20);
            this.lkImposto.TabIndex = 14;
            this.lkImposto.EditValueChanged += new System.EventHandler(this.lkImposto_EditValueChanged);
            // 
            // lkSitTribut
            // 
            this.lkSitTribut.Location = new System.Drawing.Point(128, 45);
            this.lkSitTribut.Name = "lkSitTribut";
            this.lkSitTribut.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkSitTribut.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoCst", "Codigo Cst", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DescricaoCst", "Descricao Cst", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkSitTribut.Properties.DataSource = this.situacaoTributariaBindingSource;
            this.lkSitTribut.Properties.NullText = " ";
            this.lkSitTribut.Size = new System.Drawing.Size(110, 20);
            this.lkSitTribut.TabIndex = 15;
            // 
            // situacaoTributariaBindingSource
            // 
            this.situacaoTributariaBindingSource.DataSource = typeof(ITE.Entidades.POCO.Fiscal.SituacaoTributaria);
            // 
            // tipoImpostoBindingSource
            // 
            this.tipoImpostoBindingSource.DataSource = typeof(ITE.Entidades.POCO.Fiscal.TipoImposto);
            // 
            // XFrmAddImpostoItemNf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 118);
            this.Controls.Add(this.lkSitTribut);
            this.Controls.Add(this.lkImposto);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtVlrImposto);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtAliquota);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbTributacao);
            this.Controls.Add(this.cbSitTribut);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtBaseCalculo);
            this.Controls.Add(this.cbImposto);
            this.Controls.Add(this.labelControl1);
            this.Name = "XFrmAddImpostoItemNf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do imposto";
            this.Shown += new System.EventHandler(this.XFrmAddImpostoItemNf_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cbImposto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseCalculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSitTribut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTributacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrImposto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkImposto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkSitTribut.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.situacaoTributariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoImpostoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbImposto;
        private DevExpress.XtraEditors.TextEdit txtBaseCalculo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbSitTribut;
        private DevExpress.XtraEditors.ComboBoxEdit cbTributacao;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtAliquota;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtVlrImposto;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LookUpEdit lkImposto;
        private System.Windows.Forms.BindingSource tipoImpostoBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lkSitTribut;
        private System.Windows.Forms.BindingSource situacaoTributariaBindingSource;
    }
}