﻿namespace ITE.RH.Forms.View
{
    partial class XFrmHistoricoSalario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmHistoricoSalario));
            this.hyperlinkLblFunc = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSalarioAnt = new DevExpress.XtraEditors.TextEdit();
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
            this.memoEditInfo = new DevExpress.XtraEditors.MemoEdit();
            this.panelCtrlSalario = new DevExpress.XtraEditors.PanelControl();
            this.txtSalario = new DevExpress.XtraEditors.TextEdit();
            this.memoEditHistorico = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalarioAnt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditHistorico.Properties)).BeginInit();
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(93, 105);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Salário";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(309, 105);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Salário Anterior";
            // 
            // txtSalarioAnt
            // 
            this.txtSalarioAnt.Location = new System.Drawing.Point(309, 124);
            this.txtSalarioAnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalarioAnt.Name = "txtSalarioAnt";
            this.txtSalarioAnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSalarioAnt.Properties.Appearance.Options.UseFont = true;
            this.txtSalarioAnt.Properties.Mask.EditMask = "n";
            this.txtSalarioAnt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSalarioAnt.Properties.ReadOnly = true;
            this.txtSalarioAnt.Size = new System.Drawing.Size(197, 20);
            this.txtSalarioAnt.TabIndex = 2;
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
            this.barManager1.MaxItemId = 1;
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
            this.bar1.OptionsBar.AllowDelete = true;
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
            this.barBtnSalvar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
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
            this.barDockControlTop.Size = new System.Drawing.Size(517, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 428);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(517, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 383);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(517, 45);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 383);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dockPanel1.ID = new System.Guid("866110cc-4c74-48af-bcf8-2b309544cdd7");
            this.dockPanel1.Location = new System.Drawing.Point(0, 302);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 126);
            this.dockPanel1.Size = new System.Drawing.Size(517, 126);
            this.dockPanel1.Text = "Painel de Avisos";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.memoEditInfo);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(509, 97);
            this.dockPanel1_Container.TabIndex = 0;
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
            this.memoEditInfo.Size = new System.Drawing.Size(509, 97);
            this.memoEditInfo.TabIndex = 116;
            // 
            // panelCtrlSalario
            // 
            this.panelCtrlSalario.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelCtrlSalario.ContentImage")));
            this.panelCtrlSalario.Location = new System.Drawing.Point(10, 85);
            this.panelCtrlSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCtrlSalario.Name = "panelCtrlSalario";
            this.panelCtrlSalario.Size = new System.Drawing.Size(69, 72);
            this.panelCtrlSalario.TabIndex = 108;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(93, 124);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSalario.Properties.Appearance.Options.UseFont = true;
            this.txtSalario.Properties.Mask.EditMask = "n";
            this.txtSalario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSalario.Size = new System.Drawing.Size(197, 20);
            this.txtSalario.TabIndex = 0;
            // 
            // memoEditHistorico
            // 
            this.memoEditHistorico.Location = new System.Drawing.Point(10, 181);
            this.memoEditHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoEditHistorico.Name = "memoEditHistorico";
            this.memoEditHistorico.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.memoEditHistorico.Properties.Appearance.Options.UseFont = true;
            this.memoEditHistorico.Size = new System.Drawing.Size(495, 106);
            this.memoEditHistorico.TabIndex = 115;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(10, 162);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 14);
            this.labelControl3.TabIndex = 123;
            this.labelControl3.Text = "Histórico alteração:";
            // 
            // XFrmHistoricoSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 449);
            this.Controls.Add(this.memoEditHistorico);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelCtrlSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtSalarioAnt);
            this.Controls.Add(this.labelControl1);
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
            this.Name = "XFrmHistoricoSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração Salarial";
            ((System.ComponentModel.ISupportInitialize)(this.txtSalarioAnt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditHistorico.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLblFunc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSalarioAnt;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panelCtrlSalario;
        private DevExpress.XtraEditors.TextEdit txtSalario;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnSalvar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraEditors.MemoEdit memoEditHistorico;
        private DevExpress.XtraEditors.MemoEdit memoEditInfo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}