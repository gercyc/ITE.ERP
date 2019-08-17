namespace ITE.RH.Forms.Folha
{
    partial class XFrmViewCompetencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewCompetencias));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnShowMov = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRelatFolha = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnImpRecibos = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFecharCompetencia = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnProxComp = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRptLiqFolha = new DevExpress.XtraBars.BarButtonItem();
            this.barBtneExcluirMov = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReabrir = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGeraFinanceiro = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnProcessos = new DevExpress.XtraBars.BarSubItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlCompetencias = new DevExpress.XtraGrid.GridControl();
            this.gridViewCompetencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCompetencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInicialCompetencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFinalCompetencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLiquidoFechamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFechamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoFechamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsFuncCompetencia = new System.Windows.Forms.BindingSource(this.components);
            this.bsCompetenciaFolha = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompetencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompetencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncCompetencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompetenciaFolha)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnShowMov,
            this.barBtnRelatFolha,
            this.barBtnImpRecibos,
            this.barBtnFecharCompetencia,
            this.barBtnRefresh,
            this.barBtnProxComp,
            this.barBtnRptLiqFolha,
            this.barBtneExcluirMov,
            this.barBtnReabrir,
            this.barBtnGeraFinanceiro,
            this.barBtnProcessos});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(871, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnShowMov
            // 
            this.barBtnShowMov.Caption = "Exibir Movimentação";
            this.barBtnShowMov.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnShowMov.Glyph")));
            this.barBtnShowMov.Id = 1;
            this.barBtnShowMov.Name = "barBtnShowMov";
            this.barBtnShowMov.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnShowMov.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnShowMov_ItemClick);
            // 
            // barBtnRelatFolha
            // 
            this.barBtnRelatFolha.Caption = "Relatório Analítico";
            this.barBtnRelatFolha.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRelatFolha.Glyph")));
            this.barBtnRelatFolha.Id = 2;
            this.barBtnRelatFolha.Name = "barBtnRelatFolha";
            this.barBtnRelatFolha.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnRelatFolha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRelatFolha_ItemClick);
            // 
            // barBtnImpRecibos
            // 
            this.barBtnImpRecibos.Caption = "Imprimir Recibos";
            this.barBtnImpRecibos.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnImpRecibos.Glyph")));
            this.barBtnImpRecibos.Id = 3;
            this.barBtnImpRecibos.Name = "barBtnImpRecibos";
            this.barBtnImpRecibos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnImpRecibos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnImpRecibos_ItemClick);
            // 
            // barBtnFecharCompetencia
            // 
            this.barBtnFecharCompetencia.Caption = "Encerrar Competência";
            this.barBtnFecharCompetencia.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnFecharCompetencia.Glyph")));
            this.barBtnFecharCompetencia.Id = 4;
            this.barBtnFecharCompetencia.Name = "barBtnFecharCompetencia";
            this.barBtnFecharCompetencia.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnFecharCompetencia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFecharCompetencia_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Atualizar";
            this.barBtnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.Glyph")));
            this.barBtnRefresh.Id = 5;
            this.barBtnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // barBtnProxComp
            // 
            this.barBtnProxComp.Caption = "Gerar Próxima Competência";
            this.barBtnProxComp.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnProxComp.Glyph")));
            this.barBtnProxComp.Id = 6;
            this.barBtnProxComp.Name = "barBtnProxComp";
            this.barBtnProxComp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnProxComp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnProxComp_ItemClick);
            // 
            // barBtnRptLiqFolha
            // 
            this.barBtnRptLiqFolha.Caption = "Líquido de folha";
            this.barBtnRptLiqFolha.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRptLiqFolha.Glyph")));
            this.barBtnRptLiqFolha.Id = 7;
            this.barBtnRptLiqFolha.Name = "barBtnRptLiqFolha";
            this.barBtnRptLiqFolha.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnRptLiqFolha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRptLiqFolha_ItemClick);
            // 
            // barBtneExcluirMov
            // 
            this.barBtneExcluirMov.Caption = "Excluir";
            this.barBtneExcluirMov.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtneExcluirMov.Glyph")));
            this.barBtneExcluirMov.Id = 8;
            this.barBtneExcluirMov.Name = "barBtneExcluirMov";
            this.barBtneExcluirMov.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtneExcluirMov.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelarMov_ItemClick);
            // 
            // barBtnReabrir
            // 
            this.barBtnReabrir.Caption = "Reabrir";
            this.barBtnReabrir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnReabrir.Glyph")));
            this.barBtnReabrir.Id = 9;
            this.barBtnReabrir.Name = "barBtnReabrir";
            this.barBtnReabrir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnReabrir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnReabrir_ItemClick);
            // 
            // barBtnGeraFinanceiro
            // 
            this.barBtnGeraFinanceiro.Caption = "Gerar mov. financeiro";
            this.barBtnGeraFinanceiro.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnGeraFinanceiro.Glyph")));
            this.barBtnGeraFinanceiro.Id = 10;
            this.barBtnGeraFinanceiro.Name = "barBtnGeraFinanceiro";
            this.barBtnGeraFinanceiro.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnGeraFinanceiro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGeraFinanceiro_ItemClick);
            // 
            // barBtnProcessos
            // 
            this.barBtnProcessos.Caption = "Processos";
            this.barBtnProcessos.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnProcessos.Glyph")));
            this.barBtnProcessos.Id = 11;
            this.barBtnProcessos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnGeraFinanceiro),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnReabrir),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtneExcluirMov)});
            this.barBtnProcessos.Name = "barBtnProcessos";
            this.barBtnProcessos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operações";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnShowMov);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnProxComp);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRelatFolha);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRptLiqFolha);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnImpRecibos);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnFecharCompetencia);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnProcessos);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Operações";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 462);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(871, 31);
            // 
            // gridControlCompetencias
            // 
            this.gridControlCompetencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCompetencias.Location = new System.Drawing.Point(0, 143);
            this.gridControlCompetencias.MainView = this.gridViewCompetencias;
            this.gridControlCompetencias.MenuManager = this.ribbon;
            this.gridControlCompetencias.Name = "gridControlCompetencias";
            this.gridControlCompetencias.Size = new System.Drawing.Size(871, 319);
            this.gridControlCompetencias.TabIndex = 2;
            this.gridControlCompetencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCompetencias});
            // 
            // gridViewCompetencias
            // 
            this.gridViewCompetencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCompetencia,
            this.colDataInicialCompetencia,
            this.colDataFinalCompetencia,
            this.colPeriodo,
            this.colValorLiquidoFechamento,
            this.colDataFechamento,
            this.colStatus,
            this.colIdUsuario,
            this.colUsuario,
            this.colTipoFechamento});
            this.gridViewCompetencias.GridControl = this.gridControlCompetencias;
            this.gridViewCompetencias.Name = "gridViewCompetencias";
            this.gridViewCompetencias.OptionsBehavior.Editable = false;
            this.gridViewCompetencias.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataFinalCompetencia, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewCompetencias.DoubleClick += new System.EventHandler(this.gridViewCompetencias_DoubleClick);
            // 
            // colIdCompetencia
            // 
            this.colIdCompetencia.FieldName = "IdCompetencia";
            this.colIdCompetencia.Name = "colIdCompetencia";
            // 
            // colDataInicialCompetencia
            // 
            this.colDataInicialCompetencia.FieldName = "DataInicialCompetencia";
            this.colDataInicialCompetencia.Name = "colDataInicialCompetencia";
            // 
            // colDataFinalCompetencia
            // 
            this.colDataFinalCompetencia.FieldName = "DataFinalCompetencia";
            this.colDataFinalCompetencia.Name = "colDataFinalCompetencia";
            this.colDataFinalCompetencia.Visible = true;
            this.colDataFinalCompetencia.VisibleIndex = 3;
            this.colDataFinalCompetencia.Width = 134;
            // 
            // colPeriodo
            // 
            this.colPeriodo.FieldName = "Periodo";
            this.colPeriodo.Name = "colPeriodo";
            this.colPeriodo.Visible = true;
            this.colPeriodo.VisibleIndex = 0;
            this.colPeriodo.Width = 79;
            // 
            // colValorLiquidoFechamento
            // 
            this.colValorLiquidoFechamento.DisplayFormat.FormatString = "N2";
            this.colValorLiquidoFechamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorLiquidoFechamento.FieldName = "ValorLiquidoFechamento";
            this.colValorLiquidoFechamento.Name = "colValorLiquidoFechamento";
            this.colValorLiquidoFechamento.Visible = true;
            this.colValorLiquidoFechamento.VisibleIndex = 4;
            this.colValorLiquidoFechamento.Width = 137;
            // 
            // colDataFechamento
            // 
            this.colDataFechamento.FieldName = "DataFechamento";
            this.colDataFechamento.Name = "colDataFechamento";
            this.colDataFechamento.Width = 146;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 1;
            this.colStatus.Width = 113;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colUsuario
            // 
            this.colUsuario.Caption = "Usuário";
            this.colUsuario.FieldName = "Usuario.NomeUsuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 5;
            this.colUsuario.Width = 101;
            // 
            // colTipoFechamento
            // 
            this.colTipoFechamento.Caption = "Tipo de Fechamento";
            this.colTipoFechamento.FieldName = "TipoFechamento";
            this.colTipoFechamento.Name = "colTipoFechamento";
            this.colTipoFechamento.Visible = true;
            this.colTipoFechamento.VisibleIndex = 2;
            this.colTipoFechamento.Width = 132;
            // 
            // bsFuncCompetencia
            // 
            this.bsFuncCompetencia.DataSource = typeof(ITE.Entidades.POCO.RH.Folha.FuncionarioCompetencia);
            // 
            // bsCompetenciaFolha
            // 
            this.bsCompetenciaFolha.DataSource = typeof(ITE.Entidades.POCO.RH.Folha.CompetenciaFolha);
            // 
            // XFrmViewCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 493);
            this.Controls.Add(this.gridControlCompetencias);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "XFrmViewCompetencias";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Gerenciador Competências";
            this.Shown += new System.EventHandler(this.XFrmViewCompetencias_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCompetencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompetencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncCompetencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompetenciaFolha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControlCompetencias;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCompetencias;
        private DevExpress.XtraBars.BarButtonItem barBtnShowMov;
        private DevExpress.XtraBars.BarButtonItem barBtnRelatFolha;
        private DevExpress.XtraBars.BarButtonItem barBtnImpRecibos;
        private DevExpress.XtraBars.BarButtonItem barBtnFecharCompetencia;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarButtonItem barBtnProxComp;
        private System.Windows.Forms.BindingSource bsCompetenciaFolha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCompetencia;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicialCompetencia;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFinalCompetencia;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLiquidoFechamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFechamento;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private System.Windows.Forms.BindingSource bsFuncCompetencia;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoFechamento;
        private DevExpress.XtraBars.BarButtonItem barBtnRptLiqFolha;
        private DevExpress.XtraBars.BarButtonItem barBtneExcluirMov;
        private DevExpress.XtraBars.BarButtonItem barBtnReabrir;
        private DevExpress.XtraBars.BarButtonItem barBtnGeraFinanceiro;
        private DevExpress.XtraBars.BarSubItem barBtnProcessos;
    }
}