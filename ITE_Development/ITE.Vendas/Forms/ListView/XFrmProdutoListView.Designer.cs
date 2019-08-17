namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmProdutoListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmProdutoListView));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAddProduto = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditarProduto = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnAjustaEstoque = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditarGrid = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddPromocao = new DevExpress.XtraBars.BarButtonItem();
            this.btnAlterGlobal = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSaldoCusto = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.gridControlProdutos = new DevExpress.XtraGrid.GridControl();
            this.ctxMenuProduto = new System.Windows.Forms.ContextMenuStrip();
            this.propriedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldosECustosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsProduto = new System.Windows.Forms.BindingSource();
            this.gridViewProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMargemLucro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFotoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategoriaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchLookUpCat = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridViewCat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadeMedidaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadeMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSearchLookUpUnd = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridViewUnd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHistoricoPrecoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlagProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).BeginInit();
            this.ctxMenuProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpUnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
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
            this.barBtnAtualizar,
            this.barSubItem1,
            this.btnAddPromocao,
            this.btnAjustaEstoque,
            this.btnAlterGlobal,
            this.btnAddProduto,
            this.barBtnEditarProduto,
            this.barBtnEditarGrid,
            this.barBtnSaldoCusto});
            this.barManager1.MaxItemId = 14;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddProduto),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEditarProduto),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Caption = "Novo Produto";
            this.btnAddProduto.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddProduto.Glyph")));
            this.btnAddProduto.Id = 8;
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddProduto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddProduto_ItemClick);
            // 
            // barBtnEditarProduto
            // 
            this.barBtnEditarProduto.Caption = "Editar/Visualizar";
            this.barBtnEditarProduto.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditarProduto.Glyph")));
            this.barBtnEditarProduto.Id = 9;
            this.barBtnEditarProduto.Name = "barBtnEditarProduto";
            this.barBtnEditarProduto.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEditarProduto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditarProduto_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Utilitários";
            this.barSubItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.Glyph")));
            this.barSubItem1.Id = 2;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAjustaEstoque),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEditarGrid),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddPromocao),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAlterGlobal),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSaldoCusto)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnAjustaEstoque
            // 
            this.btnAjustaEstoque.Caption = "Ajustar estoque";
            this.btnAjustaEstoque.Glyph = global::ITE.Vendas.Properties.Resources.hammer57;
            this.btnAjustaEstoque.Id = 4;
            this.btnAjustaEstoque.Name = "btnAjustaEstoque";
            this.btnAjustaEstoque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAjustaEstoque_ItemClick);
            // 
            // barBtnEditarGrid
            // 
            this.barBtnEditarGrid.Caption = "Edição na tabela";
            this.barBtnEditarGrid.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditarGrid.Glyph")));
            this.barBtnEditarGrid.Id = 11;
            this.barBtnEditarGrid.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditarGrid.LargeGlyph")));
            this.barBtnEditarGrid.Name = "barBtnEditarGrid";
            this.barBtnEditarGrid.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEditarGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditarGrid_ItemClick);
            // 
            // btnAddPromocao
            // 
            this.btnAddPromocao.Caption = "Aplicar promoção";
            this.btnAddPromocao.Enabled = false;
            this.btnAddPromocao.Glyph = global::ITE.Vendas.Properties.Resources.credit_card23;
            this.btnAddPromocao.Id = 3;
            this.btnAddPromocao.Name = "btnAddPromocao";
            this.btnAddPromocao.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddPromocao.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnAddPromocao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAplicarPromocao_ItemClick);
            // 
            // btnAlterGlobal
            // 
            this.btnAlterGlobal.Caption = "Alteração Global";
            this.btnAlterGlobal.Enabled = false;
            this.btnAlterGlobal.Glyph = global::ITE.Vendas.Properties.Resources.finance_and_business3;
            this.btnAlterGlobal.Id = 6;
            this.btnAlterGlobal.Name = "btnAlterGlobal";
            // 
            // barBtnSaldoCusto
            // 
            this.barBtnSaldoCusto.Caption = "Saldos e custos";
            this.barBtnSaldoCusto.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSaldoCusto.Glyph")));
            this.barBtnSaldoCusto.Id = 13;
            this.barBtnSaldoCusto.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSaldoCusto.LargeGlyph")));
            this.barBtnSaldoCusto.Name = "barBtnSaldoCusto";
            this.barBtnSaldoCusto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSaldoCusto_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 0;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(774, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 428);
            this.barDockControlBottom.Size = new System.Drawing.Size(774, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 383);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(774, 45);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 383);
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Client = this.gridControlProdutos;
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // gridControlProdutos
            // 
            this.gridControlProdutos.ContextMenuStrip = this.ctxMenuProduto;
            this.gridControlProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProdutos.DataSource = this.bsProduto;
            this.gridControlProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProdutos.Location = new System.Drawing.Point(3, 42);
            this.gridControlProdutos.MainView = this.gridViewProdutos;
            this.gridControlProdutos.MenuManager = this.barManager1;
            this.gridControlProdutos.Name = "gridControlProdutos";
            this.gridControlProdutos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repSearchLookUpCat,
            this.repSearchLookUpUnd});
            this.gridControlProdutos.Size = new System.Drawing.Size(764, 334);
            this.gridControlProdutos.TabIndex = 0;
            this.gridControlProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProdutos});
            // 
            // ctxMenuProduto
            // 
            this.ctxMenuProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propriedadesToolStripMenuItem,
            this.saldosECustosToolStripMenuItem});
            this.ctxMenuProduto.Name = "ctxMenuProduto";
            this.ctxMenuProduto.Size = new System.Drawing.Size(155, 48);
            // 
            // propriedadesToolStripMenuItem
            // 
            this.propriedadesToolStripMenuItem.Name = "propriedadesToolStripMenuItem";
            this.propriedadesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.propriedadesToolStripMenuItem.Text = "Propriedades";
            this.propriedadesToolStripMenuItem.Click += new System.EventHandler(this.propriedadesToolStripMenuItem_Click);
            // 
            // saldosECustosToolStripMenuItem
            // 
            this.saldosECustosToolStripMenuItem.Name = "saldosECustosToolStripMenuItem";
            this.saldosECustosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saldosECustosToolStripMenuItem.Text = "Saldos e custos";
            this.saldosECustosToolStripMenuItem.Click += new System.EventHandler(this.saldosECustosToolStripMenuItem_Click);
            // 
            // bsProduto
            // 
            this.bsProduto.DataSource = typeof(ITE.Entidades.POCO.Sales.Produto);
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProduto,
            this.colDescricaoProduto,
            this.colPrecoCompra,
            this.colPrecoVenda,
            this.colQuantidadeProduto,
            this.colMargemLucro,
            this.colFotoProduto,
            this.colIdCategoriaProduto,
            this.colCategoriaProduto,
            this.colIdUnidadeMedidaProduto,
            this.colUnidadeMedida,
            this.colHistoricoPrecoProduto,
            this.colStatusProduto,
            this.colFlagProduto,
            this.colCodigoBarras,
            this.colTipoItem});
            this.gridViewProdutos.GridControl = this.gridControlProdutos;
            this.gridViewProdutos.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProduto", null, "")});
            this.gridViewProdutos.Name = "gridViewProdutos";
            this.gridViewProdutos.OptionsBehavior.Editable = false;
            this.gridViewProdutos.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewProdutos.OptionsSelection.MultiSelect = true;
            this.gridViewProdutos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewProdutos.OptionsView.ColumnAutoWidth = false;
            this.gridViewProdutos.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewProdutos.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewProdutos.OptionsView.ShowFooter = true;
            this.gridViewProdutos.OptionsView.ShowGroupPanel = false;
            this.gridViewProdutos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProdutos_CellValueChanged);
            this.gridViewProdutos.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewProdutos_CustomColumnDisplayText);
            this.gridViewProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProdutos_KeyDown);
            this.gridViewProdutos.DoubleClick += new System.EventHandler(this.gridViewProdutos_DoubleClick);
            // 
            // colIdProduto
            // 
            this.colIdProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdProduto.Caption = "Ref. Prod.";
            this.colIdProduto.FieldName = "IdProduto";
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.OptionsColumn.AllowEdit = false;
            this.colIdProduto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProduto", "{0}")});
            this.colIdProduto.Visible = true;
            this.colIdProduto.VisibleIndex = 1;
            this.colIdProduto.Width = 68;
            // 
            // colDescricaoProduto
            // 
            this.colDescricaoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricaoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoProduto.Caption = "Descrição";
            this.colDescricaoProduto.FieldName = "DescricaoProduto";
            this.colDescricaoProduto.Name = "colDescricaoProduto";
            this.colDescricaoProduto.OptionsColumn.AllowEdit = false;
            this.colDescricaoProduto.Visible = true;
            this.colDescricaoProduto.VisibleIndex = 2;
            this.colDescricaoProduto.Width = 410;
            // 
            // colPrecoCompra
            // 
            this.colPrecoCompra.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoCompra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoCompra.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecoCompra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoCompra.Caption = "Preço Compra";
            this.colPrecoCompra.DisplayFormat.FormatString = "n2";
            this.colPrecoCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoCompra.FieldName = "PrecoCompra";
            this.colPrecoCompra.Name = "colPrecoCompra";
            this.colPrecoCompra.Width = 110;
            // 
            // colPrecoVenda
            // 
            this.colPrecoVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecoVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoVenda.Caption = "Preço Venda";
            this.colPrecoVenda.DisplayFormat.FormatString = "n2";
            this.colPrecoVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoVenda.FieldName = "PrecoVenda";
            this.colPrecoVenda.Name = "colPrecoVenda";
            this.colPrecoVenda.Visible = true;
            this.colPrecoVenda.VisibleIndex = 4;
            this.colPrecoVenda.Width = 110;
            // 
            // colQuantidadeProduto
            // 
            this.colQuantidadeProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidadeProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadeProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidadeProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadeProduto.Caption = "Quantidade";
            this.colQuantidadeProduto.DisplayFormat.FormatString = "n3";
            this.colQuantidadeProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantidadeProduto.FieldName = "QuantidadeProduto";
            this.colQuantidadeProduto.Name = "colQuantidadeProduto";
            this.colQuantidadeProduto.Visible = true;
            this.colQuantidadeProduto.VisibleIndex = 3;
            this.colQuantidadeProduto.Width = 106;
            // 
            // colMargemLucro
            // 
            this.colMargemLucro.AppearanceCell.Options.UseTextOptions = true;
            this.colMargemLucro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMargemLucro.AppearanceHeader.Options.UseTextOptions = true;
            this.colMargemLucro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMargemLucro.Caption = "Margem";
            this.colMargemLucro.FieldName = "MargemLucro";
            this.colMargemLucro.Name = "colMargemLucro";
            this.colMargemLucro.OptionsColumn.AllowEdit = false;
            this.colMargemLucro.Width = 73;
            // 
            // colFotoProduto
            // 
            this.colFotoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colFotoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFotoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colFotoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFotoProduto.FieldName = "FotoProduto";
            this.colFotoProduto.Name = "colFotoProduto";
            this.colFotoProduto.OptionsColumn.AllowEdit = false;
            this.colFotoProduto.Width = 39;
            // 
            // colIdCategoriaProduto
            // 
            this.colIdCategoriaProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCategoriaProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCategoriaProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCategoriaProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCategoriaProduto.FieldName = "IdCategoriaProduto";
            this.colIdCategoriaProduto.Name = "colIdCategoriaProduto";
            this.colIdCategoriaProduto.OptionsColumn.AllowEdit = false;
            this.colIdCategoriaProduto.Width = 39;
            // 
            // colCategoriaProduto
            // 
            this.colCategoriaProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colCategoriaProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCategoriaProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoriaProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCategoriaProduto.Caption = "Categoria";
            this.colCategoriaProduto.ColumnEdit = this.repSearchLookUpCat;
            this.colCategoriaProduto.FieldName = "CategoriaProduto";
            this.colCategoriaProduto.Name = "colCategoriaProduto";
            this.colCategoriaProduto.Visible = true;
            this.colCategoriaProduto.VisibleIndex = 5;
            this.colCategoriaProduto.Width = 132;
            // 
            // repSearchLookUpCat
            // 
            this.repSearchLookUpCat.AutoHeight = false;
            this.repSearchLookUpCat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchLookUpCat.Name = "repSearchLookUpCat";
            this.repSearchLookUpCat.View = this.gridViewCat;
            // 
            // gridViewCat
            // 
            this.gridViewCat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewCat.Name = "gridViewCat";
            this.gridViewCat.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCat.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUnidadeMedidaProduto
            // 
            this.colIdUnidadeMedidaProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdUnidadeMedidaProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUnidadeMedidaProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdUnidadeMedidaProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUnidadeMedidaProduto.FieldName = "IdUnidadeMedidaProduto";
            this.colIdUnidadeMedidaProduto.Name = "colIdUnidadeMedidaProduto";
            this.colIdUnidadeMedidaProduto.OptionsColumn.AllowEdit = false;
            this.colIdUnidadeMedidaProduto.Width = 39;
            // 
            // colUnidadeMedida
            // 
            this.colUnidadeMedida.AppearanceCell.Options.UseTextOptions = true;
            this.colUnidadeMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidadeMedida.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidadeMedida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidadeMedida.Caption = "Un. Medida";
            this.colUnidadeMedida.ColumnEdit = this.repSearchLookUpUnd;
            this.colUnidadeMedida.FieldName = "UnidadeMedida";
            this.colUnidadeMedida.Name = "colUnidadeMedida";
            this.colUnidadeMedida.Visible = true;
            this.colUnidadeMedida.VisibleIndex = 6;
            this.colUnidadeMedida.Width = 80;
            // 
            // repSearchLookUpUnd
            // 
            this.repSearchLookUpUnd.AutoHeight = false;
            this.repSearchLookUpUnd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchLookUpUnd.Name = "repSearchLookUpUnd";
            this.repSearchLookUpUnd.View = this.gridViewUnd;
            // 
            // gridViewUnd
            // 
            this.gridViewUnd.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewUnd.Name = "gridViewUnd";
            this.gridViewUnd.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewUnd.OptionsView.ShowGroupPanel = false;
            // 
            // colHistoricoPrecoProduto
            // 
            this.colHistoricoPrecoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colHistoricoPrecoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoPrecoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistoricoPrecoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoPrecoProduto.FieldName = "HistoricoPrecoProduto";
            this.colHistoricoPrecoProduto.Name = "colHistoricoPrecoProduto";
            this.colHistoricoPrecoProduto.OptionsColumn.AllowEdit = false;
            this.colHistoricoPrecoProduto.Width = 79;
            // 
            // colStatusProduto
            // 
            this.colStatusProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colStatusProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatusProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusProduto.Caption = "Status";
            this.colStatusProduto.FieldName = "StatusProduto";
            this.colStatusProduto.Name = "colStatusProduto";
            this.colStatusProduto.Visible = true;
            this.colStatusProduto.VisibleIndex = 9;
            this.colStatusProduto.Width = 100;
            // 
            // colFlagProduto
            // 
            this.colFlagProduto.Caption = "  ";
            this.colFlagProduto.FieldName = "Image";
            this.colFlagProduto.Name = "colFlagProduto";
            this.colFlagProduto.OptionsColumn.AllowEdit = false;
            this.colFlagProduto.Visible = true;
            this.colFlagProduto.VisibleIndex = 10;
            this.colFlagProduto.Width = 27;
            // 
            // colCodigoBarras
            // 
            this.colCodigoBarras.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoBarras.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoBarras.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoBarras.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoBarras.Caption = "Código Barras";
            this.colCodigoBarras.FieldName = "CodigoBarras";
            this.colCodigoBarras.Name = "colCodigoBarras";
            this.colCodigoBarras.Visible = true;
            this.colCodigoBarras.VisibleIndex = 7;
            this.colCodigoBarras.Width = 119;
            // 
            // colTipoItem
            // 
            this.colTipoItem.Caption = "Tipo Item";
            this.colTipoItem.FieldName = "TipoItemProduto";
            this.colTipoItem.Name = "colTipoItem";
            this.colTipoItem.Visible = true;
            this.colTipoItem.VisibleIndex = 8;
            this.colTipoItem.Width = 86;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tableLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(774, 383);
            this.panelControl1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControlProdutos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 379);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.searchControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(3, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(764, 35);
            this.panelControl2.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControlProdutos;
            this.searchControl1.Location = new System.Drawing.Point(8, 6);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchControl1.MenuManager = this.barManager1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlProdutos;
            this.searchControl1.Properties.FindDelay = 5000;
            this.searchControl1.Properties.NullValuePrompt = "Digite aqui o nome mais próximo do produto...";
            this.searchControl1.Size = new System.Drawing.Size(410, 22);
            this.searchControl1.TabIndex = 0;
            this.searchControl1.EditValueChanged += new System.EventHandler(this.searchControl1_EditValueChanged);
            this.searchControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchControl1_PreviewKeyDown);
            // 
            // XFrmProdutoListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 449);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmProdutoListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.XFrmGerenciarProdutoNovo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).EndInit();
            this.ctxMenuProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpUnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlProdutos;
        private System.Windows.Forms.BindingSource bsProduto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colMargemLucro;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colFotoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoriaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadeMedidaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadeMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricoPrecoProduto;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnAddPromocao;
        private DevExpress.XtraBars.BarButtonItem btnAjustaEstoque;
        private DevExpress.XtraBars.BarButtonItem btnAlterGlobal;
        private DevExpress.XtraBars.BarButtonItem btnAddProduto;
        private DevExpress.XtraBars.BarButtonItem barBtnEditarProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colFlagProduto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUnd;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchLookUpCat;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchLookUpUnd;
        private DevExpress.XtraBars.BarButtonItem barBtnEditarGrid;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarras;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.BarButtonItem barBtnSaldoCusto;
        private System.Windows.Forms.ContextMenuStrip ctxMenuProduto;
        private System.Windows.Forms.ToolStripMenuItem propriedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldosECustosToolStripMenuItem;
    }
}