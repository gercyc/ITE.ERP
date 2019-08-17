namespace ITE.Fiscal.RegrasFiscais
{
    partial class XFrmAddRegraFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddRegraFiscal));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdImpostoTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdImposto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCst = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoTributacaoICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoTributacaoIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoLancImposto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoImposto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacaoTributaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditarRegistro = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewImposto = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoverImposto = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigoTpMov = new DevExpress.XtraEditors.TextEdit();
            this.cbTipoNatureza = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricaoMov = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoDevolucao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.chkMovEstoque = new DevExpress.XtraEditors.CheckEdit();
            this.memDispLegal = new DevExpress.XtraEditors.MemoExEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTpMov.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoNatureza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoMov.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDevolucao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMovEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDispLegal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(661, 369);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 24);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Salvar";
            this.simpleButton1.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(574, 369);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(77, 24);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(14, 171);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(724, 190);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Impostos";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(720, 165);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdImpostoTipoMovimento,
            this.colIdTipoMovimento,
            this.colIdImposto,
            this.colIdCst,
            this.colAliquota,
            this.colTipoTributacaoICMS,
            this.colTipoTributacaoIPI,
            this.colTipoLancImposto,
            this.colTipoMovimento,
            this.colTipoImposto,
            this.colSituacaoTributaria});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdImpostoTipoMovimento
            // 
            this.colIdImpostoTipoMovimento.FieldName = "IdImpostoTipoMovimento";
            this.colIdImpostoTipoMovimento.Name = "colIdImpostoTipoMovimento";
            // 
            // colIdTipoMovimento
            // 
            this.colIdTipoMovimento.FieldName = "IdTipoMovimento";
            this.colIdTipoMovimento.Name = "colIdTipoMovimento";
            // 
            // colIdImposto
            // 
            this.colIdImposto.Caption = "ID Imposto";
            this.colIdImposto.FieldName = "IdImposto";
            this.colIdImposto.Name = "colIdImposto";
            this.colIdImposto.Width = 84;
            // 
            // colIdCst
            // 
            this.colIdCst.Caption = "ID CST";
            this.colIdCst.FieldName = "IdCst";
            this.colIdCst.Name = "colIdCst";
            this.colIdCst.Width = 92;
            // 
            // colAliquota
            // 
            this.colAliquota.Caption = "Alíquota";
            this.colAliquota.FieldName = "Aliquota";
            this.colAliquota.Name = "colAliquota";
            this.colAliquota.Visible = true;
            this.colAliquota.VisibleIndex = 5;
            this.colAliquota.Width = 93;
            // 
            // colTipoTributacaoICMS
            // 
            this.colTipoTributacaoICMS.Caption = "Tribut ICMS";
            this.colTipoTributacaoICMS.FieldName = "TipoTributacaoICMS";
            this.colTipoTributacaoICMS.Name = "colTipoTributacaoICMS";
            this.colTipoTributacaoICMS.Visible = true;
            this.colTipoTributacaoICMS.VisibleIndex = 2;
            this.colTipoTributacaoICMS.Width = 137;
            // 
            // colTipoTributacaoIPI
            // 
            this.colTipoTributacaoIPI.Caption = "Tribut. IPI";
            this.colTipoTributacaoIPI.FieldName = "TipoTributacaoIPI";
            this.colTipoTributacaoIPI.Name = "colTipoTributacaoIPI";
            this.colTipoTributacaoIPI.Visible = true;
            this.colTipoTributacaoIPI.VisibleIndex = 3;
            this.colTipoTributacaoIPI.Width = 145;
            // 
            // colTipoLancImposto
            // 
            this.colTipoLancImposto.Caption = "Tribut. Livro";
            this.colTipoLancImposto.FieldName = "TipoLancImposto";
            this.colTipoLancImposto.Name = "colTipoLancImposto";
            this.colTipoLancImposto.Visible = true;
            this.colTipoLancImposto.VisibleIndex = 4;
            this.colTipoLancImposto.Width = 147;
            // 
            // colTipoMovimento
            // 
            this.colTipoMovimento.FieldName = "TipoMovimento";
            this.colTipoMovimento.Name = "colTipoMovimento";
            // 
            // colTipoImposto
            // 
            this.colTipoImposto.FieldName = "TipoImposto";
            this.colTipoImposto.Name = "colTipoImposto";
            this.colTipoImposto.Visible = true;
            this.colTipoImposto.VisibleIndex = 0;
            this.colTipoImposto.Width = 90;
            // 
            // colSituacaoTributaria
            // 
            this.colSituacaoTributaria.FieldName = "SituacaoTributaria";
            this.colSituacaoTributaria.Name = "colSituacaoTributaria";
            this.colSituacaoTributaria.Visible = true;
            this.colSituacaoTributaria.VisibleIndex = 1;
            this.colSituacaoTributaria.Width = 116;
            // 
            // btnEditarRegistro
            // 
            this.btnEditarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarRegistro.Image")));
            this.btnEditarRegistro.Location = new System.Drawing.Point(14, 135);
            this.btnEditarRegistro.Name = "btnEditarRegistro";
            this.btnEditarRegistro.Size = new System.Drawing.Size(121, 23);
            this.btnEditarRegistro.TabIndex = 9;
            this.btnEditarRegistro.Text = "Editar registro";
            this.btnEditarRegistro.Click += new System.EventHandler(this.btnEditarRegistro_Click);
            // 
            // btnNewImposto
            // 
            this.btnNewImposto.Image = ((System.Drawing.Image)(resources.GetObject("btnNewImposto.Image")));
            this.btnNewImposto.Location = new System.Drawing.Point(140, 135);
            this.btnNewImposto.Name = "btnNewImposto";
            this.btnNewImposto.Size = new System.Drawing.Size(107, 23);
            this.btnNewImposto.TabIndex = 6;
            this.btnNewImposto.Text = "Novo imposto";
            this.btnNewImposto.Click += new System.EventHandler(this.btnNewImposto_Click);
            // 
            // btnRemoverImposto
            // 
            this.btnRemoverImposto.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverImposto.Image")));
            this.btnRemoverImposto.Location = new System.Drawing.Point(252, 135);
            this.btnRemoverImposto.Name = "btnRemoverImposto";
            this.btnRemoverImposto.Size = new System.Drawing.Size(121, 23);
            this.btnRemoverImposto.TabIndex = 10;
            this.btnRemoverImposto.Text = "Remover imposto";
            this.btnRemoverImposto.Click += new System.EventHandler(this.btnRemoverImposto_Click);
            // 
            // txtCodigoTpMov
            // 
            this.txtCodigoTpMov.Location = new System.Drawing.Point(14, 32);
            this.txtCodigoTpMov.Name = "txtCodigoTpMov";
            this.txtCodigoTpMov.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoTpMov.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoTpMov.Size = new System.Drawing.Size(143, 20);
            this.txtCodigoTpMov.TabIndex = 0;
            // 
            // cbTipoNatureza
            // 
            this.cbTipoNatureza.Location = new System.Drawing.Point(14, 82);
            this.cbTipoNatureza.Name = "cbTipoNatureza";
            this.cbTipoNatureza.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoNatureza.Properties.Appearance.Options.UseFont = true;
            this.cbTipoNatureza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoNatureza.Size = new System.Drawing.Size(143, 20);
            this.cbTipoNatureza.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(14, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 14);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Código:";
            // 
            // txtDescricaoMov
            // 
            this.txtDescricaoMov.Location = new System.Drawing.Point(197, 31);
            this.txtDescricaoMov.Name = "txtDescricaoMov";
            this.txtDescricaoMov.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoMov.Properties.Appearance.Options.UseFont = true;
            this.txtDescricaoMov.Size = new System.Drawing.Size(507, 20);
            this.txtDescricaoMov.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(197, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 14);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Descrição:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(14, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 14);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Tipo Natureza:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(197, 60);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 14);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Tipo devolução:";
            // 
            // cbTipoDevolucao
            // 
            this.cbTipoDevolucao.Location = new System.Drawing.Point(197, 82);
            this.cbTipoDevolucao.Name = "cbTipoDevolucao";
            this.cbTipoDevolucao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDevolucao.Properties.Appearance.Options.UseFont = true;
            this.cbTipoDevolucao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoDevolucao.Size = new System.Drawing.Size(143, 20);
            this.cbTipoDevolucao.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(381, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(114, 14);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Movimenta estoque?";
            // 
            // chkMovEstoque
            // 
            this.chkMovEstoque.Location = new System.Drawing.Point(381, 83);
            this.chkMovEstoque.Name = "chkMovEstoque";
            this.chkMovEstoque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMovEstoque.Properties.Appearance.Options.UseFont = true;
            this.chkMovEstoque.Properties.Caption = "Sim";
            this.chkMovEstoque.Size = new System.Drawing.Size(71, 19);
            this.chkMovEstoque.TabIndex = 4;
            // 
            // memDispLegal
            // 
            this.memDispLegal.Location = new System.Drawing.Point(561, 79);
            this.memDispLegal.Name = "memDispLegal";
            this.memDispLegal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memDispLegal.Properties.Appearance.Options.UseFont = true;
            this.memDispLegal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.memDispLegal.Size = new System.Drawing.Size(142, 20);
            this.memDispLegal.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(561, 57);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(88, 14);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Dispositivo legal:";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl1.Location = new System.Drawing.Point(0, 104);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(748, 24);
            this.separatorControl1.TabIndex = 27;
            // 
            // XFrmAddRegraFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 404);
            this.Controls.Add(this.btnEditarRegistro);
            this.Controls.Add(this.btnRemoverImposto);
            this.Controls.Add(this.btnNewImposto);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.memDispLegal);
            this.Controls.Add(this.chkMovEstoque);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbTipoDevolucao);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDescricaoMov);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCodigoTpMov);
            this.Controls.Add(this.cbTipoNatureza);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XFrmAddRegraFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adição/Edição de Tipo de Movimento";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoTpMov.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoNatureza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoMov.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoDevolucao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMovEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memDispLegal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnRemoverImposto;
        private DevExpress.XtraEditors.SimpleButton btnNewImposto;
        private DevExpress.XtraEditors.TextEdit txtCodigoTpMov;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoNatureza;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDescricaoMov;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoDevolucao;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit chkMovEstoque;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdImpostoTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdImposto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCst;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquota;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoTributacaoICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoTributacaoIPI;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLancImposto;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoImposto;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacaoTributaria;
        private DevExpress.XtraEditors.MemoExEdit memDispLegal;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnEditarRegistro;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
    }
}