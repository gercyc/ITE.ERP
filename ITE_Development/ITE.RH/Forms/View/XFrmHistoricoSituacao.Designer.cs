namespace ITE.RH.Forms.View
{
    partial class XFrmHistoricoSituacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmHistoricoSituacao));
            this.hyperlinkLblFunc = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.memoEditInfo = new DevExpress.XtraEditors.MemoEdit();
            this.lblSituacaoAnt = new DevExpress.XtraEditors.LabelControl();
            this.txtSituacaoAnt = new DevExpress.XtraEditors.TextEdit();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panelCtrlSituacao = new DevExpress.XtraEditors.PanelControl();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.cbSituacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.memoEditHistorico = new DevExpress.XtraEditors.MemoEdit();
            this.dtEditDtDemissao = new DevExpress.XtraEditors.DateEdit();
            this.lblDemissao = new DevExpress.XtraEditors.LabelControl();
            this.lookUpMatrizFilial1 = new ITE.Components.LookUpMatrizFilial();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacaoAnt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditHistorico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDtDemissao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDtDemissao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hyperlinkLblFunc
            // 
            this.hyperlinkLblFunc.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.hyperlinkLblFunc.Cursor = System.Windows.Forms.Cursors.Default;
            this.hyperlinkLblFunc.Location = new System.Drawing.Point(10, 53);
            this.hyperlinkLblFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hyperlinkLblFunc.Name = "hyperlinkLblFunc";
            this.hyperlinkLblFunc.Size = new System.Drawing.Size(135, 23);
            this.hyperlinkLblFunc.TabIndex = 0;
            this.hyperlinkLblFunc.Text = "%Funcionario%";
            this.hyperlinkLblFunc.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // memoEditInfo
            // 
            this.memoEditInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEditInfo.Location = new System.Drawing.Point(0, 0);
            this.memoEditInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoEditInfo.Name = "memoEditInfo";
            this.memoEditInfo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.memoEditInfo.Properties.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.memoEditInfo.Properties.Appearance.Options.UseFont = true;
            this.memoEditInfo.Properties.Appearance.Options.UseForeColor = true;
            this.memoEditInfo.Properties.ReadOnly = true;
            this.memoEditInfo.Size = new System.Drawing.Size(662, 101);
            this.memoEditInfo.TabIndex = 3;
            // 
            // lblSituacaoAnt
            // 
            this.lblSituacaoAnt.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblSituacaoAnt.Location = new System.Drawing.Point(309, 105);
            this.lblSituacaoAnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSituacaoAnt.Name = "lblSituacaoAnt";
            this.lblSituacaoAnt.Size = new System.Drawing.Size(94, 14);
            this.lblSituacaoAnt.TabIndex = 7;
            this.lblSituacaoAnt.Text = "Situação Anterior";
            // 
            // txtSituacaoAnt
            // 
            this.txtSituacaoAnt.Location = new System.Drawing.Point(309, 124);
            this.txtSituacaoAnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSituacaoAnt.Name = "txtSituacaoAnt";
            this.txtSituacaoAnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSituacaoAnt.Properties.Appearance.Options.UseFont = true;
            this.txtSituacaoAnt.Properties.Mask.EditMask = "n";
            this.txtSituacaoAnt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSituacaoAnt.Properties.ReadOnly = true;
            this.txtSituacaoAnt.Size = new System.Drawing.Size(197, 20);
            this.txtSituacaoAnt.TabIndex = 2;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
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
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnSalvar});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSalvar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnSalvar
            // 
            this.barBtnSalvar.Caption = "Salvar";
            this.barBtnSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.Glyph")));
            this.barBtnSalvar.Id = 0;
            this.barBtnSalvar.Name = "barBtnSalvar";
            this.barBtnSalvar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSalvar_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(670, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 553);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(670, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 508);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(670, 45);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 508);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel1.ID = new System.Guid("866110cc-4c74-48af-bcf8-2b309544cdd7");
            this.dockPanel1.Location = new System.Drawing.Point(0, 423);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 130);
            this.dockPanel1.Size = new System.Drawing.Size(670, 130);
            this.dockPanel1.Text = "Painel de Avisos";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.memoEditInfo);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(662, 101);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // panelCtrlSituacao
            // 
            this.panelCtrlSituacao.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelCtrlSituacao.ContentImage")));
            this.panelCtrlSituacao.Location = new System.Drawing.Point(10, 85);
            this.panelCtrlSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCtrlSituacao.Name = "panelCtrlSituacao";
            this.panelCtrlSituacao.Size = new System.Drawing.Size(69, 72);
            this.panelCtrlSituacao.TabIndex = 107;
            // 
            // labelControl39
            // 
            this.labelControl39.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl39.Location = new System.Drawing.Point(93, 105);
            this.labelControl39.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(46, 14);
            this.labelControl39.TabIndex = 106;
            this.labelControl39.Text = "Situação";
            // 
            // cbSituacao
            // 
            this.cbSituacao.Location = new System.Drawing.Point(93, 124);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbSituacao.Properties.Appearance.Options.UseFont = true;
            this.cbSituacao.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbSituacao.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSituacao.Size = new System.Drawing.Size(197, 20);
            this.cbSituacao.TabIndex = 108;
            this.cbSituacao.SelectedIndexChanged += new System.EventHandler(this.cbSituacao_SelectedIndexChanged);
            // 
            // memoEditHistorico
            // 
            this.memoEditHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEditHistorico.Location = new System.Drawing.Point(10, 301);
            this.memoEditHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoEditHistorico.Name = "memoEditHistorico";
            this.memoEditHistorico.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.memoEditHistorico.Properties.Appearance.Options.UseFont = true;
            this.memoEditHistorico.Size = new System.Drawing.Size(650, 106);
            this.memoEditHistorico.TabIndex = 116;
            // 
            // dtEditDtDemissao
            // 
            this.dtEditDtDemissao.EditValue = null;
            this.dtEditDtDemissao.Location = new System.Drawing.Point(525, 124);
            this.dtEditDtDemissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEditDtDemissao.MenuManager = this.barManager1;
            this.dtEditDtDemissao.Name = "dtEditDtDemissao";
            this.dtEditDtDemissao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtEditDtDemissao.Properties.Appearance.Options.UseFont = true;
            this.dtEditDtDemissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDtDemissao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDtDemissao.Size = new System.Drawing.Size(114, 20);
            this.dtEditDtDemissao.TabIndex = 117;
            this.dtEditDtDemissao.Visible = false;
            // 
            // lblDemissao
            // 
            this.lblDemissao.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblDemissao.Location = new System.Drawing.Point(525, 105);
            this.lblDemissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDemissao.Name = "lblDemissao";
            this.lblDemissao.Size = new System.Drawing.Size(79, 14);
            this.lblDemissao.TabIndex = 118;
            this.lblDemissao.Text = "Data Demissão";
            this.lblDemissao.Visible = false;
            // 
            // lookUpMatrizFilial1
            // 
            this.lookUpMatrizFilial1.Filial = null;
            this.lookUpMatrizFilial1.Location = new System.Drawing.Point(10, 163);
            this.lookUpMatrizFilial1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpMatrizFilial1.Matriz = null;
            this.lookUpMatrizFilial1.Name = "lookUpMatrizFilial1";
            this.lookUpMatrizFilial1.Size = new System.Drawing.Size(648, 100);
            this.lookUpMatrizFilial1.TabIndex = 154;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(10, 281);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 14);
            this.labelControl3.TabIndex = 160;
            this.labelControl3.Text = "Histórico alteração:";
            // 
            // XFrmHistoricoSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 574);
            this.Controls.Add(this.memoEditHistorico);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lookUpMatrizFilial1);
            this.Controls.Add(this.lblDemissao);
            this.Controls.Add(this.dtEditDtDemissao);
            this.Controls.Add(this.panelCtrlSituacao);
            this.Controls.Add(this.labelControl39);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.lblSituacaoAnt);
            this.Controls.Add(this.txtSituacaoAnt);
            this.Controls.Add(this.hyperlinkLblFunc);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "XFrmHistoricoSituacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração de Situação";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmHistoricoSituacao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacaoAnt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditHistorico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDtDemissao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDtDemissao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLblFunc;
        private DevExpress.XtraEditors.MemoEdit memoEditInfo;
        private DevExpress.XtraEditors.LabelControl lblSituacaoAnt;
        private DevExpress.XtraEditors.TextEdit txtSituacaoAnt;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panelCtrlSituacao;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.ComboBoxEdit cbSituacao;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnSalvar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraEditors.MemoEdit memoEditHistorico;
        private DevExpress.XtraEditors.DateEdit dtEditDtDemissao;
        private DevExpress.XtraEditors.LabelControl lblDemissao;
        private Components.LookUpMatrizFilial lookUpMatrizFilial1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}