namespace ITE.Financeiro.Forms.ListView
{
    partial class XFrmVendaListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmVendaListView));
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            this.gridControlProposta = new DevExpress.XtraGrid.GridControl();
            this.bsVenda = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barBtnImprir = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlterar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDetalhes = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnDuplicar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBaixarVenda = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExportXlsx = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItemUtil = new DevExpress.XtraBars.BarSubItem();
            this.barBtnExpandirMasterRow = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProposta
            // 
            this.gridControlProposta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProposta.DataSource = this.bsVenda;
            this.gridControlProposta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProposta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Location = new System.Drawing.Point(3, 50);
            this.gridControlProposta.MainView = this.gridView1;
            this.gridControlProposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Name = "gridControlProposta";
            this.gridControlProposta.Size = new System.Drawing.Size(947, 291);
            this.gridControlProposta.TabIndex = 0;
            this.gridControlProposta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsVenda
            // 
            this.bsVenda.DataSource = typeof(ITE.Entidades.POCO.Sales.Venda);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdVenda,
            this.colStatusVenda,
            this.colDataVenda,
            this.colTotalVenda,
            this.colCliFor,
            this.colUsuario,
            this.colFormaPagto,
            this.colTipo});
            this.gridView1.GridControl = this.gridControlProposta;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewVendas_SelectionChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridViewProposta_DoubleClick);
            // 
            // colIdVenda
            // 
            this.colIdVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colIdVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVenda.Caption = "Nº Venda";
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.OptionsColumn.AllowEdit = false;
            this.colIdVenda.OptionsColumn.AllowShowHide = false;
            this.colIdVenda.Visible = true;
            this.colIdVenda.VisibleIndex = 0;
            this.colIdVenda.Width = 70;
            // 
            // colStatusVenda
            // 
            this.colStatusVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colStatusVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusVenda.Caption = "Situação";
            this.colStatusVenda.FieldName = "StatusVenda";
            this.colStatusVenda.Name = "colStatusVenda";
            this.colStatusVenda.OptionsColumn.AllowEdit = false;
            this.colStatusVenda.OptionsColumn.AllowShowHide = false;
            this.colStatusVenda.Visible = true;
            this.colStatusVenda.VisibleIndex = 7;
            // 
            // colDataVenda
            // 
            this.colDataVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colDataVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVenda.Caption = "Data Venda";
            this.colDataVenda.FieldName = "DataVenda";
            this.colDataVenda.Name = "colDataVenda";
            this.colDataVenda.OptionsColumn.AllowEdit = false;
            this.colDataVenda.OptionsColumn.AllowShowHide = false;
            this.colDataVenda.Visible = true;
            this.colDataVenda.VisibleIndex = 2;
            this.colDataVenda.Width = 96;
            // 
            // colTotalVenda
            // 
            this.colTotalVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalVenda.Caption = "Total Venda";
            this.colTotalVenda.DisplayFormat.FormatString = "n2";
            this.colTotalVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalVenda.FieldName = "TotalVenda";
            this.colTotalVenda.Name = "colTotalVenda";
            this.colTotalVenda.OptionsColumn.AllowEdit = false;
            this.colTotalVenda.OptionsColumn.AllowShowHide = false;
            this.colTotalVenda.Visible = true;
            this.colTotalVenda.VisibleIndex = 5;
            this.colTotalVenda.Width = 96;
            // 
            // colCliFor
            // 
            this.colCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliFor.Caption = "Cliente";
            this.colCliFor.FieldName = "CliFor.RazaoSocial";
            this.colCliFor.Name = "colCliFor";
            this.colCliFor.OptionsColumn.AllowEdit = false;
            this.colCliFor.OptionsColumn.AllowShowHide = false;
            this.colCliFor.Visible = true;
            this.colCliFor.VisibleIndex = 3;
            this.colCliFor.Width = 267;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.Caption = "Vendedor";
            this.colUsuario.FieldName = "Usuario.NomeUsuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.AllowEdit = false;
            this.colUsuario.OptionsColumn.AllowShowHide = false;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 6;
            this.colUsuario.Width = 72;
            // 
            // colFormaPagto
            // 
            this.colFormaPagto.Caption = "Forma de Pagamento";
            this.colFormaPagto.FieldName = "FormaPagamentoVenda.NomeFormaPagamento";
            this.colFormaPagto.Name = "colFormaPagto";
            this.colFormaPagto.Visible = true;
            this.colFormaPagto.VisibleIndex = 4;
            this.colFormaPagto.Width = 134;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "TipoMovimento";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 66;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barBtnImprir
            // 
            this.barBtnImprir.Caption = "Imprimir";
            this.barBtnImprir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnImprir.Glyph")));
            this.barBtnImprir.Id = 0;
            this.barBtnImprir.Name = "barBtnImprir";
            this.barBtnImprir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnImprir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnImprir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnImprir_ItemClick);
            // 
            // barBtnAlterar
            // 
            this.barBtnAlterar.Caption = "Alterar Cotação";
            this.barBtnAlterar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterar.Glyph")));
            this.barBtnAlterar.Id = 6;
            this.barBtnAlterar.Name = "barBtnAlterar";
            this.barBtnAlterar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAlterar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAlterar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterar_ItemClick);
            // 
            // barBtnDetalhes
            // 
            this.barBtnDetalhes.Caption = "Visualizar Detalhes";
            this.barBtnDetalhes.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnDetalhes.Glyph")));
            this.barBtnDetalhes.Id = 8;
            this.barBtnDetalhes.Name = "barBtnDetalhes";
            this.barBtnDetalhes.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnDetalhes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem3.Text = "Detalhar dados de uma Venda/Cotação";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Exibe os detalhes da venda/cotação";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem2);
            this.barBtnDetalhes.SuperTip = superToolTip3;
            this.barBtnDetalhes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDetalhes_ItemClick);
            // 
            // barBtnCancelar
            // 
            this.barBtnCancelar.Caption = "Cancelar Venda";
            this.barBtnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.Glyph")));
            this.barBtnCancelar.Id = 2;
            this.barBtnCancelar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.LargeGlyph")));
            this.barBtnCancelar.Name = "barBtnCancelar";
            this.barBtnCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExcluir_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 3;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem4.Text = "Carrega todas as vendas. ";
            superToolTip4.Items.Add(toolTipTitleItem4);
            this.barBtnAtualizar.SuperTip = superToolTip4;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnImprir,
            this.barBtnCancelar,
            this.barBtnAtualizar,
            this.barBtnAlterar,
            this.barBtnDetalhes,
            this.barBtnDuplicar,
            this.barBtnBaixarVenda,
            this.barBtnExportXlsx,
            this.barSubItemUtil,
            this.barBtnExpandirMasterRow});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(953, 183);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnDuplicar
            // 
            this.barBtnDuplicar.Caption = "Duplicar Venda/Cotação";
            this.barBtnDuplicar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnDuplicar.Glyph")));
            this.barBtnDuplicar.Id = 1;
            this.barBtnDuplicar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnDuplicar.LargeGlyph")));
            this.barBtnDuplicar.Name = "barBtnDuplicar";
            this.barBtnDuplicar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDuplicar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDuplicar_ItemClick);
            // 
            // barBtnBaixarVenda
            // 
            this.barBtnBaixarVenda.Caption = "Baixar Venda";
            this.barBtnBaixarVenda.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnBaixarVenda.Glyph")));
            this.barBtnBaixarVenda.Id = 2;
            this.barBtnBaixarVenda.Name = "barBtnBaixarVenda";
            this.barBtnBaixarVenda.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnBaixarVenda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBaixarVenda_ItemClick);
            // 
            // barBtnExportXlsx
            // 
            this.barBtnExportXlsx.Caption = "Exportar";
            this.barBtnExportXlsx.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExportXlsx.Glyph")));
            this.barBtnExportXlsx.Id = 3;
            this.barBtnExportXlsx.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnExportXlsx.LargeGlyph")));
            this.barBtnExportXlsx.Name = "barBtnExportXlsx";
            this.barBtnExportXlsx.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnExportXlsx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExportXlsx_ItemClick);
            // 
            // barSubItemUtil
            // 
            this.barSubItemUtil.Caption = "Utilitários";
            this.barSubItemUtil.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItemUtil.Glyph")));
            this.barSubItemUtil.Id = 4;
            this.barSubItemUtil.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDuplicar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCancelar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnExportXlsx),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnExpandirMasterRow)});
            this.barSubItemUtil.Name = "barSubItemUtil";
            this.barSubItemUtil.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnExpandirMasterRow
            // 
            this.barBtnExpandirMasterRow.Caption = "Expandir/Recolher";
            this.barBtnExpandirMasterRow.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExpandirMasterRow.Glyph")));
            this.barBtnExpandirMasterRow.Id = 5;
            this.barBtnExpandirMasterRow.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnExpandirMasterRow.LargeGlyph")));
            this.barBtnExpandirMasterRow.Name = "barBtnExpandirMasterRow";
            this.barBtnExpandirMasterRow.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barBtnExpandirMasterRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExpandirMasterRow_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Início";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAlterar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnDetalhes);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnImprir);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnBaixarVenda);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAtualizar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barSubItemUtil);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Menu";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 526);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(953, 41);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlProposta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 183);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 343);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.searchControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(947, 44);
            this.panelControl1.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControlProposta;
            this.searchControl1.Location = new System.Drawing.Point(9, 7);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchControl1.MenuManager = this.ribbonControl1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlProposta;
            this.searchControl1.Properties.NullValuePrompt = "Digite aqui o número da venda ou o nome do cliente";
            this.searchControl1.Size = new System.Drawing.Size(478, 28);
            this.searchControl1.TabIndex = 0;
            this.searchControl1.EditValueChanged += new System.EventHandler(this.searchControl1_EditValueChanged);
            this.searchControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchControl1_PreviewKeyDown);
            // 
            // XFrmVendaListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmVendaListView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Utilitários Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.XFrmUtilVenda_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProposta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusVenda;
        private DevExpress.XtraBars.BarButtonItem barBtnImprir;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarButtonItem barBtnAlterar;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagto;
        private DevExpress.XtraBars.BarButtonItem barBtnDetalhes;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnDuplicar;
        private DevExpress.XtraBars.BarButtonItem barBtnBaixarVenda;
        private DevExpress.XtraBars.BarButtonItem barBtnExportXlsx;
        private DevExpress.XtraBars.BarSubItem barSubItemUtil;
        private DevExpress.XtraBars.BarButtonItem barBtnExpandirMasterRow;
    }
}