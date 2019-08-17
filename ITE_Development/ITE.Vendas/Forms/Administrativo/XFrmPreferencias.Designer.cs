using ITE.Components.LookUp;

namespace ITE.Vendas.Forms.Administrativo
{
    partial class XFrmPreferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmPreferencias));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.bsParametro = new System.Windows.Forms.BindingSource();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkLoginVenda = new DevExpress.XtraEditors.CheckEdit();
            this.chkVendaQuitadaVista = new DevExpress.XtraEditors.CheckEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.navigationPanePai = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPageVenda = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lookUpCentroCustoDefault = new ITE.Components.LookUpCentroCusto();
            this.lookUpContaBancariaDefault = new ITE.Components.LookUpContaBancaria();
            this.navigationPageLocal = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnSetDirBackup = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetDirDigitacao = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDirBackup = new DevExpress.XtraEditors.TextEdit();
            this.txtDirDigitalizacao = new DevExpress.XtraEditors.TextEdit();
            this.navigationPageReport = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cbEngReport = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPageRH = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lookUpCliForRH = new LookUpCliFor();
            this.lookUpCentroCustoRH = new ITE.Components.LookUpCentroCusto();
            this.fbDialogDirectory = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bsParametro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoginVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVendaQuitadaVista.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.navigationPanePai.SuspendLayout();
            this.navigationPageVenda.SuspendLayout();
            this.navigationPageLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirBackup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirDigitalizacao.Properties)).BeginInit();
            this.navigationPageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEngReport.Properties)).BeginInit();
            this.navigationPageRH.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsParametro
            // 
            this.bsParametro.DataSource = typeof(ITSolution.Framework.Entities.Parametro);
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
            this.barBtnSalvar,
            this.barBtnRefresh});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSalvar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRefresh)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnSalvar
            // 
            this.barBtnSalvar.Caption = "Salvar";
            this.barBtnSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.Glyph")));
            this.barBtnSalvar.Id = 0;
            this.barBtnSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.LargeGlyph")));
            this.barBtnSalvar.Name = "barBtnSalvar";
            this.barBtnSalvar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSalvar_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Atualizar";
            this.barBtnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.Glyph")));
            this.barBtnRefresh.Id = 1;
            this.barBtnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.LargeGlyph")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtRefresh_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusProduto bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusProduto bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(729, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 456);
            this.barDockControlBottom.Size = new System.Drawing.Size(729, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 425);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(729, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 425);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(16, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Centro de custo da Venda";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(18, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(276, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Conta bancária para baixa de lançamentos";
            // 
            // chkLoginVenda
            // 
            this.chkLoginVenda.Location = new System.Drawing.Point(18, 188);
            this.chkLoginVenda.MenuManager = this.barManager1;
            this.chkLoginVenda.Name = "chkLoginVenda";
            this.chkLoginVenda.Properties.Caption = "Exigir login ao iniciar uma Venda";
            this.chkLoginVenda.Size = new System.Drawing.Size(218, 19);
            toolTipItem2.Text = "Define se será exigido o login sempre que iniciar uma venda ";
            superToolTip2.Items.Add(toolTipItem2);
            this.chkLoginVenda.SuperTip = superToolTip2;
            this.chkLoginVenda.TabIndex = 11;
            // 
            // chkVendaQuitadaVista
            // 
            this.chkVendaQuitadaVista.Location = new System.Drawing.Point(305, 188);
            this.chkVendaQuitadaVista.MenuManager = this.barManager1;
            this.chkVendaQuitadaVista.Name = "chkVendaQuitadaVista";
            this.chkVendaQuitadaVista.Properties.Caption = "Quitar Venda á Vista";
            this.chkVendaQuitadaVista.Size = new System.Drawing.Size(136, 19);
            toolTipItem1.Text = "Define se ao gravar uma venda a vista seu status já será definido como \"Quitada\"";
            superToolTip1.Items.Add(toolTipItem1);
            this.chkVendaQuitadaVista.SuperTip = superToolTip1;
            this.chkVendaQuitadaVista.TabIndex = 12;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(11, 161);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(618, 19);
            this.separatorControl1.TabIndex = 24;
            // 
            // navigationPanePai
            // 
            this.navigationPanePai.Controls.Add(this.navigationPageVenda);
            this.navigationPanePai.Controls.Add(this.navigationPageLocal);
            this.navigationPanePai.Controls.Add(this.navigationPageReport);
            this.navigationPanePai.Controls.Add(this.navigationPageRH);
            this.navigationPanePai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePai.Location = new System.Drawing.Point(0, 31);
            this.navigationPanePai.Name = "navigationPanePai";
            this.navigationPanePai.PageProperties.ShowCollapseButton = false;
            this.navigationPanePai.PageProperties.ShowExpandButton = false;
            this.navigationPanePai.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPageVenda,
            this.navigationPageLocal,
            this.navigationPageReport,
            this.navigationPageRH});
            this.navigationPanePai.RegularSize = new System.Drawing.Size(729, 425);
            this.navigationPanePai.SelectedPage = this.navigationPageVenda;
            this.navigationPanePai.SelectedPageIndex = 0;
            this.navigationPanePai.Size = new System.Drawing.Size(729, 425);
            this.navigationPanePai.TabIndex = 29;
            this.navigationPanePai.Text = "Opções";
            // 
            // navigationPageVenda
            // 
            this.navigationPageVenda.Caption = "Venda";
            this.navigationPageVenda.Controls.Add(this.labelControl1);
            this.navigationPageVenda.Controls.Add(this.separatorControl1);
            this.navigationPageVenda.Controls.Add(this.lookUpCentroCustoDefault);
            this.navigationPageVenda.Controls.Add(this.lookUpContaBancariaDefault);
            this.navigationPageVenda.Controls.Add(this.labelControl2);
            this.navigationPageVenda.Controls.Add(this.chkVendaQuitadaVista);
            this.navigationPageVenda.Controls.Add(this.chkLoginVenda);
            this.navigationPageVenda.Name = "navigationPageVenda";
            this.navigationPageVenda.Size = new System.Drawing.Size(604, 379);
            // 
            // lookUpCentroCustoDefault
            // 
            this.lookUpCentroCustoDefault.CentroCusto = null;
            this.lookUpCentroCustoDefault.LabelText = "";
            this.lookUpCentroCustoDefault.Location = new System.Drawing.Point(11, 15);
            this.lookUpCentroCustoDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpCentroCustoDefault.Name = "lookUpCentroCustoDefault";
            this.lookUpCentroCustoDefault.Size = new System.Drawing.Size(544, 49);
            this.lookUpCentroCustoDefault.TabIndex = 7;
            // 
            // lookUpContaBancariaDefault
            // 
            this.lookUpContaBancariaDefault.ContaBancaria = null;
            this.lookUpContaBancariaDefault.Location = new System.Drawing.Point(11, 116);
            this.lookUpContaBancariaDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpContaBancariaDefault.Name = "lookUpContaBancariaDefault";
            this.lookUpContaBancariaDefault.Size = new System.Drawing.Size(544, 36);
            this.lookUpContaBancariaDefault.TabIndex = 19;
            // 
            // navigationPageLocal
            // 
            this.navigationPageLocal.Caption = "Diretórios";
            this.navigationPageLocal.Controls.Add(this.btnSetDirBackup);
            this.navigationPageLocal.Controls.Add(this.btnSetDirDigitacao);
            this.navigationPageLocal.Controls.Add(this.labelControl5);
            this.navigationPageLocal.Controls.Add(this.labelControl4);
            this.navigationPageLocal.Controls.Add(this.txtDirBackup);
            this.navigationPageLocal.Controls.Add(this.txtDirDigitalizacao);
            this.navigationPageLocal.Name = "navigationPageLocal";
            this.navigationPageLocal.Size = new System.Drawing.Size(604, 379);
            // 
            // btnSetDirBackup
            // 
            this.btnSetDirBackup.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSetDirBackup.Appearance.Options.UseFont = true;
            this.btnSetDirBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnSetDirBackup.Image")));
            this.btnSetDirBackup.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSetDirBackup.Location = new System.Drawing.Point(556, 36);
            this.btnSetDirBackup.Name = "btnSetDirBackup";
            this.btnSetDirBackup.Size = new System.Drawing.Size(33, 19);
            this.btnSetDirBackup.TabIndex = 9;
            this.btnSetDirBackup.ToolTip = "Procurar Centro Custo";
            this.btnSetDirBackup.Click += new System.EventHandler(this.btnSetDirBackup_Click);
            // 
            // btnSetDirDigitacao
            // 
            this.btnSetDirDigitacao.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSetDirDigitacao.Appearance.Options.UseFont = true;
            this.btnSetDirDigitacao.Image = ((System.Drawing.Image)(resources.GetObject("btnSetDirDigitacao.Image")));
            this.btnSetDirDigitacao.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSetDirDigitacao.Location = new System.Drawing.Point(556, 98);
            this.btnSetDirDigitacao.Name = "btnSetDirDigitacao";
            this.btnSetDirDigitacao.Size = new System.Drawing.Size(33, 19);
            this.btnSetDirDigitacao.TabIndex = 8;
            this.btnSetDirDigitacao.ToolTip = "Procurar Centro Custo";
            this.btnSetDirDigitacao.Click += new System.EventHandler(this.btnSetDirDigitacao_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(20, 17);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(130, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Local de backup do sistema";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(265, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Local onde serão armazenadas as imagens digitalizadas";
            // 
            // txtDirBackup
            // 
            this.txtDirBackup.Location = new System.Drawing.Point(20, 37);
            this.txtDirBackup.MenuManager = this.barManager1;
            this.txtDirBackup.Name = "txtDirBackup";
            this.txtDirBackup.Properties.ReadOnly = true;
            this.txtDirBackup.Size = new System.Drawing.Size(530, 20);
            this.txtDirBackup.TabIndex = 1;
            // 
            // txtDirDigitalizacao
            // 
            this.txtDirDigitalizacao.Location = new System.Drawing.Point(20, 98);
            this.txtDirDigitalizacao.MenuManager = this.barManager1;
            this.txtDirDigitalizacao.Name = "txtDirDigitalizacao";
            this.txtDirDigitalizacao.Properties.ReadOnly = true;
            this.txtDirDigitalizacao.Size = new System.Drawing.Size(530, 20);
            this.txtDirDigitalizacao.TabIndex = 0;
            // 
            // navigationPageReport
            // 
            this.navigationPageReport.Caption = "Relatórios";
            this.navigationPageReport.Controls.Add(this.cbEngReport);
            this.navigationPageReport.Controls.Add(this.labelControl3);
            this.navigationPageReport.Name = "navigationPageReport";
            this.navigationPageReport.Size = new System.Drawing.Size(604, 379);
            // 
            // cbEngReport
            // 
            this.cbEngReport.Location = new System.Drawing.Point(18, 34);
            this.cbEngReport.MenuManager = this.barManager1;
            this.cbEngReport.Name = "cbEngReport";
            this.cbEngReport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEngReport.Properties.Items.AddRange(new object[] {
            "1 = Gerar e visualizar sem gravar no spool.",
            "2 = Gerar e visualizar gravando no spool.",
            "3 = Gerar somente no spool."});
            this.cbEngReport.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbEngReport.Size = new System.Drawing.Size(270, 20);
            this.cbEngReport.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Motor de Relatório";
            // 
            // navigationPageRH
            // 
            this.navigationPageRH.Caption = "Recursos Humanos";
            this.navigationPageRH.Controls.Add(this.lookUpCliForRH);
            this.navigationPageRH.Controls.Add(this.lookUpCentroCustoRH);
            this.navigationPageRH.Name = "navigationPageRH";
            this.navigationPageRH.Size = new System.Drawing.Size(604, 379);
            // 
            // lookUpCliForRH
            // 
            this.lookUpCliForRH.CliFor = null;
            this.lookUpCliForRH.Filial = null;
            this.lookUpCliForRH.LabelText = "CliFor padrão para financeiro";
            this.lookUpCliForRH.Location = new System.Drawing.Point(13, 85);
            this.lookUpCliForRH.Matriz = null;
            this.lookUpCliForRH.Name = "lookUpCliForRH";
            this.lookUpCliForRH.Size = new System.Drawing.Size(375, 48);
            this.lookUpCliForRH.TabIndex = 1;
            // 
            // lookUpCentroCustoRH
            // 
            this.lookUpCentroCustoRH.CentroCusto = null;
            this.lookUpCentroCustoRH.LabelText = "Centro de custo padrão para financeiro";
            this.lookUpCentroCustoRH.Location = new System.Drawing.Point(13, 16);
            this.lookUpCentroCustoRH.Name = "lookUpCentroCustoRH";
            this.lookUpCentroCustoRH.Size = new System.Drawing.Size(375, 49);
            this.lookUpCentroCustoRH.TabIndex = 0;
            // 
            // XFrmPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 479);
            this.Controls.Add(this.navigationPanePai);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XFrmPreferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prefências do Sistema";
            this.Shown += new System.EventHandler(this.XFrmConfigParam_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bsParametro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoginVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVendaQuitadaVista.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.navigationPanePai.ResumeLayout(false);
            this.navigationPageVenda.ResumeLayout(false);
            this.navigationPageVenda.PerformLayout();
            this.navigationPageLocal.ResumeLayout(false);
            this.navigationPageLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirBackup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirDigitalizacao.Properties)).EndInit();
            this.navigationPageReport.ResumeLayout(false);
            this.navigationPageReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEngReport.Properties)).EndInit();
            this.navigationPageRH.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsParametro;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnSalvar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraEditors.CheckEdit chkVendaQuitadaVista;
        private DevExpress.XtraEditors.CheckEdit chkLoginVenda;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPanePai;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageVenda;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageLocal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDirBackup;
        private DevExpress.XtraEditors.TextEdit txtDirDigitalizacao;
        private DevExpress.XtraEditors.SimpleButton btnSetDirBackup;
        private DevExpress.XtraEditors.SimpleButton btnSetDirDigitacao;
        private System.Windows.Forms.FolderBrowserDialog fbDialogDirectory;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageReport;
        private DevExpress.XtraEditors.ComboBoxEdit cbEngReport;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private Components.LookUpCentroCusto lookUpCentroCustoDefault;
        private Components.LookUpContaBancaria lookUpContaBancariaDefault;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageRH;
        private LookUpCliFor lookUpCliForRH;
        private Components.LookUpCentroCusto lookUpCentroCustoRH;
    }
}