namespace ITE.Fiscal.View
{
    partial class XFrmAddImposto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddImposto));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
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
            this.txtAliquota = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbTpAliquota = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescImposto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodImposto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraPageEnderecos = new DevExpress.XtraTab.XtraTabPage();
            this.lookUpMunicio1 = new ITE.Components.LookUpMunicipio();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCep = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtBairro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtComplEndereco = new DevExpress.XtraEditors.TextEdit();
            this.txtNumeroEndereco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeEndereco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraPageDados)).BeginInit();
            this.xtraPageDados.SuspendLayout();
            this.xtraPagePrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTpAliquota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescImposto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodImposto.Properties)).BeginInit();
            this.xtraPageEnderecos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeEndereco.Properties)).BeginInit();
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
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
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
            this.barDockControlTop.Size = new System.Drawing.Size(640, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 295);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(640, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 256);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(640, 39);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 256);
            // 
            // xtraPageDados
            // 
            this.xtraPageDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraPageDados.Location = new System.Drawing.Point(0, 39);
            this.xtraPageDados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraPageDados.Name = "xtraPageDados";
            this.xtraPageDados.SelectedTabPage = this.xtraPagePrincipal;
            this.xtraPageDados.Size = new System.Drawing.Size(640, 256);
            this.xtraPageDados.TabIndex = 4;
            this.xtraPageDados.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraPagePrincipal,
            this.xtraPageEnderecos});
            // 
            // xtraPagePrincipal
            // 
            this.xtraPagePrincipal.Controls.Add(this.txtAliquota);
            this.xtraPagePrincipal.Controls.Add(this.labelControl9);
            this.xtraPagePrincipal.Controls.Add(this.cbTpAliquota);
            this.xtraPagePrincipal.Controls.Add(this.labelControl8);
            this.xtraPagePrincipal.Controls.Add(this.txtDescImposto);
            this.xtraPagePrincipal.Controls.Add(this.labelControl2);
            this.xtraPagePrincipal.Controls.Add(this.txtCodImposto);
            this.xtraPagePrincipal.Controls.Add(this.labelControl1);
            this.xtraPagePrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraPagePrincipal.Name = "xtraPagePrincipal";
            this.xtraPagePrincipal.Size = new System.Drawing.Size(633, 222);
            this.xtraPagePrincipal.Text = "Dados principais";
            // 
            // txtAliquota
            // 
            this.txtAliquota.Location = new System.Drawing.Point(185, 137);
            this.txtAliquota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAliquota.MenuManager = this.barManager1;
            this.txtAliquota.Name = "txtAliquota";
            this.txtAliquota.Size = new System.Drawing.Size(117, 22);
            this.txtAliquota.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl9.Location = new System.Drawing.Point(185, 113);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(51, 16);
            this.labelControl9.TabIndex = 7;
            this.labelControl9.Text = "Alíquota:";
            // 
            // cbTpAliquota
            // 
            this.cbTpAliquota.Location = new System.Drawing.Point(14, 137);
            this.cbTpAliquota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTpAliquota.MenuManager = this.barManager1;
            this.cbTpAliquota.Name = "cbTpAliquota";
            this.cbTpAliquota.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTpAliquota.Properties.Items.AddRange(new object[] {
            "Fixa",
            "Variável"});
            this.cbTpAliquota.Size = new System.Drawing.Size(143, 22);
            this.cbTpAliquota.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl8.Location = new System.Drawing.Point(14, 113);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(97, 16);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "Tipo de alíquota:";
            // 
            // txtDescImposto
            // 
            this.txtDescImposto.Location = new System.Drawing.Point(185, 46);
            this.txtDescImposto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescImposto.MenuManager = this.barManager1;
            this.txtDescImposto.Name = "txtDescImposto";
            this.txtDescImposto.Size = new System.Drawing.Size(374, 22);
            this.txtDescImposto.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o código do local de estoque.";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txtDescImposto, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl2.Location = new System.Drawing.Point(185, 22);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(178, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Descrição completa do imposto";
            // 
            // txtCodImposto
            // 
            this.txtCodImposto.Location = new System.Drawing.Point(14, 46);
            this.txtCodImposto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodImposto.MenuManager = this.barManager1;
            this.txtCodImposto.Name = "txtCodImposto";
            this.txtCodImposto.Size = new System.Drawing.Size(143, 22);
            this.txtCodImposto.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe o código do local de estoque";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.txtCodImposto, conditionValidationRule2);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl1.Location = new System.Drawing.Point(14, 23);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Código do imposto";
            // 
            // xtraPageEnderecos
            // 
            this.xtraPageEnderecos.Controls.Add(this.lookUpMunicio1);
            this.xtraPageEnderecos.Controls.Add(this.labelControl7);
            this.xtraPageEnderecos.Controls.Add(this.txtCep);
            this.xtraPageEnderecos.Controls.Add(this.labelControl6);
            this.xtraPageEnderecos.Controls.Add(this.txtBairro);
            this.xtraPageEnderecos.Controls.Add(this.labelControl5);
            this.xtraPageEnderecos.Controls.Add(this.txtComplEndereco);
            this.xtraPageEnderecos.Controls.Add(this.txtNumeroEndereco);
            this.xtraPageEnderecos.Controls.Add(this.labelControl4);
            this.xtraPageEnderecos.Controls.Add(this.txtNomeEndereco);
            this.xtraPageEnderecos.Controls.Add(this.labelControl3);
            this.xtraPageEnderecos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraPageEnderecos.Name = "xtraPageEnderecos";
            this.xtraPageEnderecos.PageVisible = false;
            this.xtraPageEnderecos.Size = new System.Drawing.Size(633, 222);
            this.xtraPageEnderecos.Text = "Endereço - oculta";
            // 
            // lookUpMunicio1
            // 
            this.lookUpMunicio1.AutoSize = true;
            this.lookUpMunicio1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lookUpMunicio1.Location = new System.Drawing.Point(314, 121);
            this.lookUpMunicio1.Margin = new System.Windows.Forms.Padding(5);
            this.lookUpMunicio1.MdiForm = null;
            this.lookUpMunicio1.Municipio = null;
            this.lookUpMunicio1.Name = "lookUpMunicio1";
            this.lookUpMunicio1.ReadyOnly = false;
            this.lookUpMunicio1.Size = new System.Drawing.Size(257, 54);
            this.lookUpMunicio1.TabIndex = 15;
            this.lookUpMunicio1.UF = null;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl7.Location = new System.Drawing.Point(157, 124);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 16);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Cep:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(157, 148);
            this.txtCep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCep.MenuManager = this.barManager1;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(124, 22);
            this.txtCep.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl6.Location = new System.Drawing.Point(16, 124);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 16);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(16, 148);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.MenuManager = this.barManager1;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(124, 22);
            this.txtBairro.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl5.Location = new System.Drawing.Point(447, 27);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(84, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Complemento:";
            // 
            // txtComplEndereco
            // 
            this.txtComplEndereco.Location = new System.Drawing.Point(447, 50);
            this.txtComplEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComplEndereco.MenuManager = this.barManager1;
            this.txtComplEndereco.Name = "txtComplEndereco";
            this.txtComplEndereco.Size = new System.Drawing.Size(124, 22);
            this.txtComplEndereco.TabIndex = 9;
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.Location = new System.Drawing.Point(297, 50);
            this.txtNumeroEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeroEndereco.MenuManager = this.barManager1;
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(124, 22);
            this.txtNumeroEndereco.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl4.Location = new System.Drawing.Point(297, 27);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Número:";
            // 
            // txtNomeEndereco
            // 
            this.txtNomeEndereco.Location = new System.Drawing.Point(16, 50);
            this.txtNomeEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeEndereco.MenuManager = this.barManager1;
            this.txtNomeEndereco.Name = "txtNomeEndereco";
            this.txtNomeEndereco.Size = new System.Drawing.Size(265, 22);
            this.txtNomeEndereco.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl3.Location = new System.Drawing.Point(16, 27);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Endereço:";
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // XFrmAddImposto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.Controls.Add(this.xtraPageDados);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmAddImposto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adição de imposto";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraPageDados)).EndInit();
            this.xtraPageDados.ResumeLayout(false);
            this.xtraPagePrincipal.ResumeLayout(false);
            this.xtraPagePrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAliquota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTpAliquota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescImposto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodImposto.Properties)).EndInit();
            this.xtraPageEnderecos.ResumeLayout(false);
            this.xtraPageEnderecos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeEndereco.Properties)).EndInit();
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
        private DevExpress.XtraTab.XtraTabPage xtraPageEnderecos;
        private DevExpress.XtraEditors.TextEdit txtDescImposto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCodImposto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNumeroEndereco;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNomeEndereco;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtBairro;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtComplEndereco;
        private ITE.Components.LookUpMunicipio lookUpMunicio1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtCep;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTpAliquota;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtAliquota;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}