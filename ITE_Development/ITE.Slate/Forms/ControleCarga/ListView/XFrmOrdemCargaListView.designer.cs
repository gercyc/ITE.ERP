namespace ITE.Slate.Forms.ControleCarga.ListView
{
    partial class XFrmOrdemCargaListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmOrdemCargaListView));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.gridControlProposta = new DevExpress.XtraGrid.GridControl();
            this.bsOrdemCarga = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewOrdemCargas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOrdemCarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataOrdemCarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalOrdemCarga = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barBtnImprir = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlterar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDetalhes = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barBtnExportar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnOrdemCarga = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnFiltrarOrdens = new DevExpress.XtraEditors.SimpleButton();
            this.cbFiltro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtEditInicio = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtEditFinal = new System.Windows.Forms.DateTimePicker();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdemCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdemCargas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProposta
            // 
            this.gridControlProposta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProposta.DataSource = this.bsOrdemCarga;
            this.gridControlProposta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProposta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Location = new System.Drawing.Point(3, 41);
            this.gridControlProposta.MainView = this.gridViewOrdemCargas;
            this.gridControlProposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Name = "gridControlProposta";
            this.gridControlProposta.Size = new System.Drawing.Size(855, 242);
            this.gridControlProposta.TabIndex = 0;
            this.gridControlProposta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdemCargas});
            // 
            // bsOrdemCarga
            // 
            this.bsOrdemCarga.DataSource = typeof(ITE.Entidades.POCO.Ardosia.Minning.OrdemCarga);
            // 
            // gridViewOrdemCargas
            // 
            this.gridViewOrdemCargas.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewOrdemCargas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewOrdemCargas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOrdemCarga,
            this.colDataOrdemCarga,
            this.colTotalOrdemCarga,
            this.colCliFor,
            this.colUsuario});
            this.gridViewOrdemCargas.GridControl = this.gridControlProposta;
            this.gridViewOrdemCargas.Name = "gridViewOrdemCargas";
            this.gridViewOrdemCargas.OptionsBehavior.Editable = false;
            this.gridViewOrdemCargas.OptionsView.ShowFooter = true;
            this.gridViewOrdemCargas.OptionsView.ShowGroupPanel = false;
            this.gridViewOrdemCargas.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewOrdemCargas_SelectionChanged);
            this.gridViewOrdemCargas.DoubleClick += new System.EventHandler(this.gridViewProposta_DoubleClick);
            // 
            // colIdOrdemCarga
            // 
            this.colIdOrdemCarga.AppearanceCell.Options.UseTextOptions = true;
            this.colIdOrdemCarga.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdOrdemCarga.Caption = "Nº Ordem Carga";
            this.colIdOrdemCarga.FieldName = "IdOrdemCarga";
            this.colIdOrdemCarga.Name = "colIdOrdemCarga";
            this.colIdOrdemCarga.OptionsColumn.AllowEdit = false;
            this.colIdOrdemCarga.OptionsColumn.AllowShowHide = false;
            this.colIdOrdemCarga.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdOrdemCarga", "{0}")});
            this.colIdOrdemCarga.Visible = true;
            this.colIdOrdemCarga.VisibleIndex = 0;
            this.colIdOrdemCarga.Width = 136;
            // 
            // colDataOrdemCarga
            // 
            this.colDataOrdemCarga.AppearanceCell.Options.UseTextOptions = true;
            this.colDataOrdemCarga.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataOrdemCarga.Caption = "Dt. Carregamento";
            this.colDataOrdemCarga.FieldName = "DataCarregamento";
            this.colDataOrdemCarga.Name = "colDataOrdemCarga";
            this.colDataOrdemCarga.OptionsColumn.AllowEdit = false;
            this.colDataOrdemCarga.OptionsColumn.AllowShowHide = false;
            this.colDataOrdemCarga.Visible = true;
            this.colDataOrdemCarga.VisibleIndex = 1;
            this.colDataOrdemCarga.Width = 218;
            // 
            // colTotalOrdemCarga
            // 
            this.colTotalOrdemCarga.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalOrdemCarga.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalOrdemCarga.Caption = "Total Carga";
            this.colTotalOrdemCarga.DisplayFormat.FormatString = "n2";
            this.colTotalOrdemCarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalOrdemCarga.FieldName = "TotalCarga";
            this.colTotalOrdemCarga.Name = "colTotalOrdemCarga";
            this.colTotalOrdemCarga.OptionsColumn.AllowEdit = false;
            this.colTotalOrdemCarga.OptionsColumn.AllowShowHide = false;
            this.colTotalOrdemCarga.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCarga", "{0:n2}")});
            this.colTotalOrdemCarga.Visible = true;
            this.colTotalOrdemCarga.VisibleIndex = 3;
            this.colTotalOrdemCarga.Width = 218;
            // 
            // colCliFor
            // 
            this.colCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliFor.Caption = "Cliente";
            this.colCliFor.FieldName = "Cliente.RazaoSocial";
            this.colCliFor.Name = "colCliFor";
            this.colCliFor.OptionsColumn.AllowEdit = false;
            this.colCliFor.OptionsColumn.AllowShowHide = false;
            this.colCliFor.Visible = true;
            this.colCliFor.VisibleIndex = 2;
            this.colCliFor.Width = 609;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.Caption = "Usuário";
            this.colUsuario.FieldName = "Usuario.NomeUsuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.AllowEdit = false;
            this.colUsuario.OptionsColumn.AllowShowHide = false;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 4;
            this.colUsuario.Width = 171;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barBtnImprir
            // 
            this.barBtnImprir.Caption = "Imprimir Ordem Carga";
            this.barBtnImprir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnImprir.Glyph")));
            this.barBtnImprir.Id = 0;
            this.barBtnImprir.Name = "barBtnImprir";
            this.barBtnImprir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnImprir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnImprir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnImprir_ItemClick);
            // 
            // barBtnAlterar
            // 
            this.barBtnAlterar.Caption = "Alterar Ordem Carga";
            this.barBtnAlterar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterar.Glyph")));
            this.barBtnAlterar.Id = 6;
            this.barBtnAlterar.Name = "barBtnAlterar";
            this.barBtnAlterar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAlterar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAlterar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterar_ItemClick);
            // 
            // barBtnDetalhes
            // 
            this.barBtnDetalhes.Caption = "Detalhar Ordem Carga";
            this.barBtnDetalhes.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnDetalhes.Glyph")));
            this.barBtnDetalhes.Id = 8;
            this.barBtnDetalhes.Name = "barBtnDetalhes";
            this.barBtnDetalhes.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnDetalhes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDetalhes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDetalhes_ItemClick);
            // 
            // barBtnCancelar
            // 
            this.barBtnCancelar.Caption = "Cancelar Ordem Carga";
            this.barBtnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.Glyph")));
            this.barBtnCancelar.Id = 2;
            this.barBtnCancelar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.LargeGlyph")));
            this.barBtnCancelar.Name = "barBtnCancelar";
            this.barBtnCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
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
            toolTipTitleItem2.Text = "Carrega todas as ordens de carga. ";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "As ordem de carga não localizadas a partir do período informado.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barBtnAtualizar.SuperTip = superToolTip2;
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
            this.barSubItem1,
            this.barBtnOrdemCarga,
            this.barBtnExportar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 7;
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
            this.ribbonControl1.Size = new System.Drawing.Size(861, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Opções";
            this.barSubItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.Glyph")));
            this.barSubItem1.Id = 4;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCancelar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnExportar)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnExportar
            // 
            this.barBtnExportar.Caption = "Exportar Dados";
            this.barBtnExportar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExportar.Glyph")));
            this.barBtnExportar.Id = 6;
            this.barBtnExportar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnExportar.LargeGlyph")));
            this.barBtnExportar.Name = "barBtnExportar";
            this.barBtnExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExportar_ItemClick);
            // 
            // barBtnOrdemCarga
            // 
            this.barBtnOrdemCarga.Caption = "Nova Ordem Carga";
            this.barBtnOrdemCarga.Glyph = global::ITE.Slate.Properties.Resources.ordem_carga48x48;
            this.barBtnOrdemCarga.Id = 5;
            this.barBtnOrdemCarga.Name = "barBtnOrdemCarga";
            this.barBtnOrdemCarga.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnOrdemCarga.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnOrdemCarga_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnOrdemCarga);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAlterar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnDetalhes);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnImprir);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAtualizar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barSubItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tarefas";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 429);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(861, 32);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlProposta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 285);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFiltrarOrdens);
            this.panelControl1.Controls.Add(this.cbFiltro);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.dtEditInicio);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dtEditFinal);
            this.panelControl1.Controls.Add(this.searchControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(855, 35);
            this.panelControl1.TabIndex = 1;
            // 
            // btnFiltrarOrdens
            // 
            this.btnFiltrarOrdens.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarOrdens.Image")));
            this.btnFiltrarOrdens.Location = new System.Drawing.Point(783, 5);
            this.btnFiltrarOrdens.Name = "btnFiltrarOrdens";
            this.btnFiltrarOrdens.Size = new System.Drawing.Size(66, 23);
            this.btnFiltrarOrdens.TabIndex = 25;
            this.btnFiltrarOrdens.Text = "Filtrar";
            this.btnFiltrarOrdens.Click += new System.EventHandler(this.btnFiltrarOrdens_Click);
            // 
            // cbFiltro
            // 
            this.cbFiltro.EditValue = "Por Período";
            this.cbFiltro.Location = new System.Drawing.Point(641, 5);
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
            this.cbFiltro.TabIndex = 24;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Location = new System.Drawing.Point(573, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 16);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Filtrar por:";
            // 
            // dtEditInicio
            // 
            this.dtEditInicio.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtEditInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEditInicio.Location = new System.Drawing.Point(318, 5);
            this.dtEditInicio.Name = "dtEditInicio";
            this.dtEditInicio.Size = new System.Drawing.Size(103, 24);
            this.dtEditInicio.TabIndex = 21;
            this.dtEditInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtEditInicio_KeyDown);
            this.dtEditInicio.Leave += new System.EventHandler(this.dtEditInicio_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Location = new System.Drawing.Point(292, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "De:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Location = new System.Drawing.Point(433, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 16);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Ate:";
            // 
            // dtEditFinal
            // 
            this.dtEditFinal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtEditFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEditFinal.Location = new System.Drawing.Point(463, 5);
            this.dtEditFinal.Name = "dtEditFinal";
            this.dtEditFinal.Size = new System.Drawing.Size(103, 24);
            this.dtEditFinal.TabIndex = 22;
            this.dtEditFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtEditInicio_KeyDown);
            this.dtEditFinal.Leave += new System.EventHandler(this.dtEditInicio_Leave);
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControlProposta;
            this.searchControl1.Location = new System.Drawing.Point(9, 6);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchControl1.MenuManager = this.ribbonControl1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlProposta;
            this.searchControl1.Properties.NullValuePrompt = "Digite aqui seu critério de pesquisa...";
            this.searchControl1.Size = new System.Drawing.Size(274, 22);
            this.searchControl1.TabIndex = 0;
            this.searchControl1.EditValueChanged += new System.EventHandler(this.searchControl1_EditValueChanged);
            this.searchControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchControl1_PreviewKeyDown);
            // 
            // XFrmOrdemCargaListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmOrdemCargaListView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Controle de Carga";
            this.Shown += new System.EventHandler(this.XFrmUtilOrdemCarga_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdemCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdemCargas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProposta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdemCargas;
        private System.Windows.Forms.BindingSource bsOrdemCarga;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdemCarga;
        private DevExpress.XtraGrid.Columns.GridColumn colDataOrdemCarga;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalOrdemCarga;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraBars.BarButtonItem barBtnImprir;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarButtonItem barBtnAlterar;
        private DevExpress.XtraBars.BarButtonItem barBtnDetalhes;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnOrdemCarga;
        private DevExpress.XtraBars.BarButtonItem barBtnExportar;
        private DevExpress.XtraEditors.SimpleButton btnFiltrarOrdens;
        private DevExpress.XtraEditors.ComboBoxEdit cbFiltro;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtEditInicio;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtEditFinal;
    }
}