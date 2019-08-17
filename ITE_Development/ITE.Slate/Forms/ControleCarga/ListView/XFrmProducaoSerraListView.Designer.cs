namespace ITE.Slate.Forms.ControleCarga.ListView
{
    partial class XFrmProducaoSerraListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITE.Slate.Forms.ControleCarga.ListView.XFrmProducaoSerraListView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnAddSerra = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddProducaoSerra = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnImportar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControlProducaoSerra = new DevExpress.XtraGrid.GridControl();
            this.bsProducaoSerra = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProducaoSerra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSerra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataProducao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadePeca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetrosQuadrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetrosCubico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMaterialSerra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnFiltrarProducao = new DevExpress.XtraEditors.SimpleButton();
            this.cbFiltro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtEditInicio = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtEditFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducaoSerra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducaoSerra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducaoSerra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnAddSerra,
            this.barBtnRefresh,
            this.barBtnExportar,
            this.barBtnPrintPreview,
            this.barBtnAddProducaoSerra,
            this.barBtnImportar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(896, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnAddSerra
            // 
            this.barBtnAddSerra.Caption = "Cadastrar Serra";
            this.barBtnAddSerra.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAddSerra.Glyph")));
            this.barBtnAddSerra.Id = 1;
            this.barBtnAddSerra.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnAddSerra.LargeGlyph")));
            this.barBtnAddSerra.Name = "barBtnAddSerra";
            this.barBtnAddSerra.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddSerra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddSerra_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Atualizar";
            this.barBtnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.Glyph")));
            this.barBtnRefresh.Id = 2;
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem1.Text = "Produção do ano e mês atual";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Carrega a produção das serras na tabela.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barBtnRefresh.SuperTip = superToolTip1;
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // barBtnExportar
            // 
            this.barBtnExportar.Caption = "Exportar";
            this.barBtnExportar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExportar.Glyph")));
            this.barBtnExportar.Id = 3;
            this.barBtnExportar.Name = "barBtnExportar";
            this.barBtnExportar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExpExcel_ItemClick);
            // 
            // barBtnPrintPreview
            // 
            this.barBtnPrintPreview.Caption = "Visualizar";
            this.barBtnPrintPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPrintPreview.Glyph")));
            this.barBtnPrintPreview.Id = 4;
            this.barBtnPrintPreview.Name = "barBtnPrintPreview";
            this.barBtnPrintPreview.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintPreview_ItemClick);
            // 
            // barBtnAddProducaoSerra
            // 
            this.barBtnAddProducaoSerra.Caption = "Lançar Produção";
            this.barBtnAddProducaoSerra.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAddProducaoSerra.Glyph")));
            this.barBtnAddProducaoSerra.Id = 5;
            this.barBtnAddProducaoSerra.Name = "barBtnAddProducaoSerra";
            this.barBtnAddProducaoSerra.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddProducaoSerra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddProducaoSerra_ItemClick);
            // 
            // barBtnImportar
            // 
            this.barBtnImportar.Caption = "Importar Produção";
            this.barBtnImportar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnImportar.Glyph")));
            this.barBtnImportar.Id = 6;
            this.barBtnImportar.Name = "barBtnImportar";
            this.barBtnImportar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnImportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnImportar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAddSerra);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAddProducaoSerra);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnExportar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnImportar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnPrintPreview);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Controle de Produção";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 521);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(896, 32);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlProducaoSerra, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 377);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // gridControlProducaoSerra
            // 
            this.gridControlProducaoSerra.DataSource = this.bsProducaoSerra;
            this.gridControlProducaoSerra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProducaoSerra.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProducaoSerra.Location = new System.Drawing.Point(3, 48);
            this.gridControlProducaoSerra.MainView = this.gridViewProducaoSerra;
            this.gridControlProducaoSerra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProducaoSerra.MenuManager = this.ribbon;
            this.gridControlProducaoSerra.Name = "gridControlProducaoSerra";
            this.gridControlProducaoSerra.Size = new System.Drawing.Size(890, 327);
            this.gridControlProducaoSerra.TabIndex = 2;
            this.gridControlProducaoSerra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducaoSerra});
            // 
            // bsProducaoSerra
            // 
            this.bsProducaoSerra.DataSource = typeof(global::ITE.Entidades.POCO.Ardosia.ProductionSlate.ProducaoSerra);
            // 
            // gridViewProducaoSerra
            // 
            this.gridViewProducaoSerra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSerra,
            this.colSerra,
            this.colDataProducao,
            this.colQuantidadePeca,
            this.colMetrosQuadrado,
            this.colMetrosCubico,
            this.colTotalUnitario,
            this.colIdMaterialSerra,
            this.colMaterial});
            this.gridViewProducaoSerra.GridControl = this.gridControlProducaoSerra;
            this.gridViewProducaoSerra.Name = "gridViewProducaoSerra";
            this.gridViewProducaoSerra.OptionsBehavior.Editable = false;
            this.gridViewProducaoSerra.OptionsView.ShowFooter = true;
            // 
            // colIdSerra
            // 
            this.colIdSerra.AppearanceCell.Options.UseTextOptions = true;
            this.colIdSerra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdSerra.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdSerra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdSerra.Caption = "Serra";
            this.colIdSerra.FieldName = "IdSerra";
            this.colIdSerra.Name = "colIdSerra";
            this.colIdSerra.OptionsColumn.AllowEdit = false;
            this.colIdSerra.OptionsColumn.ReadOnly = true;
            this.colIdSerra.Visible = true;
            this.colIdSerra.VisibleIndex = 0;
            // 
            // colSerra
            // 
            this.colSerra.AppearanceCell.Options.UseTextOptions = true;
            this.colSerra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSerra.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSerra.Caption = "Serra";
            this.colSerra.FieldName = "Serra.NomeSerra";
            this.colSerra.Name = "colSerra";
            this.colSerra.Width = 145;
            // 
            // colDataProducao
            // 
            this.colDataProducao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataProducao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataProducao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataProducao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataProducao.FieldName = "DataProducao";
            this.colDataProducao.Name = "colDataProducao";
            this.colDataProducao.OptionsColumn.AllowEdit = false;
            this.colDataProducao.OptionsColumn.ReadOnly = true;
            this.colDataProducao.Visible = true;
            this.colDataProducao.VisibleIndex = 1;
            this.colDataProducao.Width = 99;
            // 
            // colQuantidadePeca
            // 
            this.colQuantidadePeca.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidadePeca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadePeca.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidadePeca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadePeca.Caption = "Quantidade Peças";
            this.colQuantidadePeca.FieldName = "QuantidadePeca";
            this.colQuantidadePeca.Name = "colQuantidadePeca";
            this.colQuantidadePeca.OptionsColumn.AllowEdit = false;
            this.colQuantidadePeca.OptionsColumn.ReadOnly = true;
            this.colQuantidadePeca.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantidadePeca", "TOTAL PÇS: {0:0.##}")});
            this.colQuantidadePeca.Visible = true;
            this.colQuantidadePeca.VisibleIndex = 4;
            this.colQuantidadePeca.Width = 107;
            // 
            // colMetrosQuadrado
            // 
            this.colMetrosQuadrado.AppearanceCell.Options.UseTextOptions = true;
            this.colMetrosQuadrado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosQuadrado.AppearanceHeader.Options.UseTextOptions = true;
            this.colMetrosQuadrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosQuadrado.DisplayFormat.FormatString = "n2";
            this.colMetrosQuadrado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMetrosQuadrado.FieldName = "MetrosQuadrado";
            this.colMetrosQuadrado.Name = "colMetrosQuadrado";
            this.colMetrosQuadrado.OptionsColumn.AllowEdit = false;
            this.colMetrosQuadrado.OptionsColumn.ReadOnly = true;
            this.colMetrosQuadrado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MetrosQuadrado", "TOTAL M²: {0:n2}")});
            this.colMetrosQuadrado.Visible = true;
            this.colMetrosQuadrado.VisibleIndex = 5;
            this.colMetrosQuadrado.Width = 122;
            // 
            // colMetrosCubico
            // 
            this.colMetrosCubico.AppearanceCell.Options.UseTextOptions = true;
            this.colMetrosCubico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosCubico.AppearanceHeader.Options.UseTextOptions = true;
            this.colMetrosCubico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosCubico.DisplayFormat.FormatString = "n2";
            this.colMetrosCubico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMetrosCubico.FieldName = "MetrosCubico";
            this.colMetrosCubico.Name = "colMetrosCubico";
            this.colMetrosCubico.OptionsColumn.AllowEdit = false;
            this.colMetrosCubico.OptionsColumn.ReadOnly = true;
            this.colMetrosCubico.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MetrosCubico", "TOTAL M³: {0:n2}")});
            this.colMetrosCubico.Visible = true;
            this.colMetrosCubico.VisibleIndex = 6;
            this.colMetrosCubico.Width = 96;
            // 
            // colTotalUnitario
            // 
            this.colTotalUnitario.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalUnitario.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalUnitario.Caption = "Total R$";
            this.colTotalUnitario.FieldName = "TotalUnitario";
            this.colTotalUnitario.Name = "colTotalUnitario";
            this.colTotalUnitario.OptionsColumn.AllowEdit = false;
            this.colTotalUnitario.OptionsColumn.ReadOnly = true;
            this.colTotalUnitario.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalUnitario", "TOTAL R$: {0:N2}")});
            this.colTotalUnitario.Visible = true;
            this.colTotalUnitario.VisibleIndex = 7;
            this.colTotalUnitario.Width = 119;
            // 
            // colIdMaterialSerra
            // 
            this.colIdMaterialSerra.AppearanceCell.Options.UseTextOptions = true;
            this.colIdMaterialSerra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMaterialSerra.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdMaterialSerra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMaterialSerra.Caption = "ID Material";
            this.colIdMaterialSerra.FieldName = "IdMaterial";
            this.colIdMaterialSerra.Name = "colIdMaterialSerra";
            this.colIdMaterialSerra.OptionsColumn.AllowEdit = false;
            this.colIdMaterialSerra.OptionsColumn.ReadOnly = true;
            this.colIdMaterialSerra.Visible = true;
            this.colIdMaterialSerra.VisibleIndex = 2;
            // 
            // colMaterial
            // 
            this.colMaterial.AppearanceCell.Options.UseTextOptions = true;
            this.colMaterial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaterial.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaterial.FieldName = "Material.NomeMaterial";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.OptionsColumn.AllowEdit = false;
            this.colMaterial.OptionsColumn.ReadOnly = true;
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 3;
            this.colMaterial.Width = 226;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFiltrarProducao);
            this.panelControl1.Controls.Add(this.cbFiltro);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.dtEditInicio);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dtEditFinal);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(890, 40);
            this.panelControl1.TabIndex = 3;
            // 
            // btnFiltrarProducao
            // 
            this.btnFiltrarProducao.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarProducao.Image")));
            this.btnFiltrarProducao.Location = new System.Drawing.Point(540, 9);
            this.btnFiltrarProducao.Name = "btnFiltrarProducao";
            this.btnFiltrarProducao.Size = new System.Drawing.Size(66, 23);
            this.btnFiltrarProducao.TabIndex = 18;
            this.btnFiltrarProducao.Text = "Filtrar";
            this.btnFiltrarProducao.Click += new System.EventHandler(this.btnFiltrarProducao_Click);
            // 
            // cbFiltro
            // 
            this.cbFiltro.EditValue = "Por Período";
            this.cbFiltro.Location = new System.Drawing.Point(377, 10);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbFiltro.Properties.Appearance.Options.UseFont = true;
            this.cbFiltro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFiltro.Properties.Items.AddRange(new object[] {
            "Por Período",
            "Mês Atual",
            "Mês Anterior",
            "Por Dia",
            "Por Ano"});
            this.cbFiltro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFiltro.Size = new System.Drawing.Size(136, 22);
            this.cbFiltro.TabIndex = 17;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(309, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 16);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Filtrar por:";
            // 
            // dtEditInicio
            // 
            this.dtEditInicio.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtEditInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEditInicio.Location = new System.Drawing.Point(35, 7);
            this.dtEditInicio.Name = "dtEditInicio";
            this.dtEditInicio.Size = new System.Drawing.Size(103, 24);
            this.dtEditInicio.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(9, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "De:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(153, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 16);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Ate:";
            // 
            // dtEditFinal
            // 
            this.dtEditFinal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtEditFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEditFinal.Location = new System.Drawing.Point(183, 7);
            this.dtEditFinal.Name = "dtEditFinal";
            this.dtEditFinal.Size = new System.Drawing.Size(103, 24);
            this.dtEditFinal.TabIndex = 15;
            // 
            // XFrmProducaoSerraListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmProducaoSerraListView";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Produção Árdosia";
            this.Shown += new System.EventHandler(this.XFrmProducaoSerraListView_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmProducaoSerraListView_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducaoSerra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducaoSerra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducaoSerra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnAddSerra;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControlProducaoSerra;
        private System.Windows.Forms.BindingSource bsProducaoSerra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducaoSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colDataProducao;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadePeca;
        private DevExpress.XtraGrid.Columns.GridColumn colMetrosQuadrado;
        private DevExpress.XtraGrid.Columns.GridColumn colMetrosCubico;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMaterialSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarButtonItem barBtnExportar;
        private DevExpress.XtraBars.BarButtonItem barBtnPrintPreview;
        private DevExpress.XtraBars.BarButtonItem barBtnAddProducaoSerra;
        private DevExpress.XtraBars.BarButtonItem barBtnImportar;
        private DevExpress.XtraEditors.ComboBoxEdit cbFiltro;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtEditInicio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtEditFinal;
        private DevExpress.XtraEditors.SimpleButton btnFiltrarProducao;
    }
}