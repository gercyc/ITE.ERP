namespace ITE.Fiscal.View
{
    partial class XFrmAddMunicipio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddMunicipio));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.xtraPageDados = new DevExpress.XtraTab.XtraTabControl();
            this.xtraPagePrincipal = new DevExpress.XtraTab.XtraTabPage();
            this.lkUnidFederacao = new DevExpress.XtraEditors.LookUpEdit();
            this.unidadeFederacaoBindingSource = new System.Windows.Forms.BindingSource();
            this.txtCodigoIbge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeLocal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraPageDados)).BeginInit();
            this.xtraPageDados.SuspendLayout();
            this.xtraPagePrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnidFederacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeFederacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoIbge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeLocal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalvar,
            this.btnExcluir});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalvar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcluir)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Caption = "Salvar";
            this.btnSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Glyph")));
            this.btnSalvar.Id = 0;
            this.btnSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSalvar.LargeGlyph")));
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalvar_ItemClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Caption = "Excluir";
            this.btnExcluir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Glyph")));
            this.btnExcluir.Id = 1;
            this.btnExcluir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExcluir.LargeGlyph")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(548, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 263);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(548, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 224);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(548, 39);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 224);
            // 
            // xtraPageDados
            // 
            this.xtraPageDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraPageDados.Location = new System.Drawing.Point(0, 39);
            this.xtraPageDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraPageDados.Name = "xtraPageDados";
            this.xtraPageDados.SelectedTabPage = this.xtraPagePrincipal;
            this.xtraPageDados.Size = new System.Drawing.Size(548, 224);
            this.xtraPageDados.TabIndex = 4;
            this.xtraPageDados.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraPagePrincipal});
            // 
            // xtraPagePrincipal
            // 
            this.xtraPagePrincipal.Controls.Add(this.lkUnidFederacao);
            this.xtraPagePrincipal.Controls.Add(this.txtCodigoIbge);
            this.xtraPagePrincipal.Controls.Add(this.labelControl3);
            this.xtraPagePrincipal.Controls.Add(this.txtNomeLocal);
            this.xtraPagePrincipal.Controls.Add(this.labelControl2);
            this.xtraPagePrincipal.Controls.Add(this.labelControl1);
            this.xtraPagePrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraPagePrincipal.Name = "xtraPagePrincipal";
            this.xtraPagePrincipal.Size = new System.Drawing.Size(541, 190);
            this.xtraPagePrincipal.Text = "Dados principais";
            // 
            // lkUnidFederacao
            // 
            this.lkUnidFederacao.Location = new System.Drawing.Point(26, 39);
            this.lkUnidFederacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkUnidFederacao.MenuManager = this.barManager1;
            this.lkUnidFederacao.Name = "lkUnidFederacao";
            this.lkUnidFederacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUnidFederacao.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoUF", "Codigo UF", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkUnidFederacao.Properties.DataSource = this.unidadeFederacaoBindingSource;
            this.lkUnidFederacao.Properties.NullText = "";
            this.lkUnidFederacao.Size = new System.Drawing.Size(121, 22);
            this.lkUnidFederacao.TabIndex = 7;
            // 
            // unidadeFederacaoBindingSource
            // 
            this.unidadeFederacaoBindingSource.DataSource = typeof(ITE.Entidades.POCO.Fiscal.UnidadeFederacao);
            // 
            // txtCodigoIbge
            // 
            this.txtCodigoIbge.Location = new System.Drawing.Point(204, 39);
            this.txtCodigoIbge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoIbge.MenuManager = this.barManager1;
            this.txtCodigoIbge.Name = "txtCodigoIbge";
            this.txtCodigoIbge.Size = new System.Drawing.Size(117, 22);
            this.txtCodigoIbge.TabIndex = 6;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe o código do local de estoque";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txtCodigoIbge, conditionValidationRule3);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl3.Location = new System.Drawing.Point(204, 16);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Código IBGE:";
            // 
            // txtNomeLocal
            // 
            this.txtNomeLocal.Location = new System.Drawing.Point(26, 137);
            this.txtNomeLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeLocal.MenuManager = this.barManager1;
            this.txtNomeLocal.Name = "txtNomeLocal";
            this.txtNomeLocal.Size = new System.Drawing.Size(294, 22);
            this.txtNomeLocal.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o código do local de estoque.";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txtNomeLocal, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl2.Location = new System.Drawing.Point(26, 113);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nome município:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl1.Location = new System.Drawing.Point(26, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Código UF:";
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // XFrmAddMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 288);
            this.Controls.Add(this.xtraPageDados);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmAddMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adição de município";
            this.Shown += new System.EventHandler(this.XFrmAddMunicipio_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraPageDados)).EndInit();
            this.xtraPageDados.ResumeLayout(false);
            this.xtraPagePrincipal.ResumeLayout(false);
            this.xtraPagePrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnidFederacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeFederacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoIbge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeLocal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSalvar;
        private DevExpress.XtraBars.BarButtonItem btnExcluir;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTab.XtraTabControl xtraPageDados;
        private DevExpress.XtraTab.XtraTabPage xtraPagePrincipal;
        private DevExpress.XtraEditors.TextEdit txtNomeLocal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.TextEdit txtCodigoIbge;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lkUnidFederacao;
        private System.Windows.Forms.BindingSource unidadeFederacaoBindingSource;
    }
}