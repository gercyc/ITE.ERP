namespace ITE.Slate.Forms.ControleCarga.ListView
{
    partial class XFrmMaterialSerraListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITE.Slate.Forms.ControleCarga.ListView.XFrmMaterialSerraListView));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAddMaterialSerra = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditarMaterialSerra = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.gridControlMaterialSerras = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialSerras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMaterialSerra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoMaterialSerra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialSerras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialSerras)).BeginInit();
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
            this.btnAddMaterialSerra,
            this.barBtnEditarMaterialSerra});
            this.barManager1.MaxItemId = 13;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddMaterialSerra),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEditarMaterialSerra),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnAddMaterialSerra
            // 
            this.btnAddMaterialSerra.Caption = "Novo";
            this.btnAddMaterialSerra.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddMaterialSerra.Glyph")));
            this.btnAddMaterialSerra.Id = 8;
            this.btnAddMaterialSerra.Name = "btnAddMaterialSerra";
            this.btnAddMaterialSerra.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddMaterialSerra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddMaterialSerra_ItemClick);
            // 
            // barBtnEditarMaterialSerra
            // 
            this.barBtnEditarMaterialSerra.Caption = "Editar/Visualizar";
            this.barBtnEditarMaterialSerra.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditarMaterialSerra.Glyph")));
            this.barBtnEditarMaterialSerra.Id = 9;
            this.barBtnEditarMaterialSerra.Name = "barBtnEditarMaterialSerra";
            this.barBtnEditarMaterialSerra.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEditarMaterialSerra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditarMaterialSerra_ItemClick);
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
            this.bar3.BarName = "StatusMaterialSerra bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusMaterialSerra bar";
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
            this.repositoryItemSearchControl1.Client = this.gridControlMaterialSerras;
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // gridControlMaterialSerras
            // 
            this.gridControlMaterialSerras.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMaterialSerras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMaterialSerras.Location = new System.Drawing.Point(3, 42);
            this.gridControlMaterialSerras.MainView = this.gridViewMaterialSerras;
            this.gridControlMaterialSerras.MenuManager = this.barManager1;
            this.gridControlMaterialSerras.Name = "gridControlMaterialSerras";
            this.gridControlMaterialSerras.Size = new System.Drawing.Size(764, 334);
            this.gridControlMaterialSerras.TabIndex = 0;
            this.gridControlMaterialSerras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaterialSerras});
            // 
            // gridViewMaterialSerras
            // 
            this.gridViewMaterialSerras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMaterialSerra,
            this.colDescricaoMaterialSerra,
            this.colPrecoVenda});
            this.gridViewMaterialSerras.GridControl = this.gridControlMaterialSerras;
            this.gridViewMaterialSerras.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMaterial", null, "")});
            this.gridViewMaterialSerras.Name = "gridViewMaterialSerras";
            this.gridViewMaterialSerras.OptionsBehavior.Editable = false;
            this.gridViewMaterialSerras.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewMaterialSerras.OptionsSelection.MultiSelect = true;
            this.gridViewMaterialSerras.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewMaterialSerras.OptionsView.ColumnAutoWidth = false;
            this.gridViewMaterialSerras.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMaterialSerras.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMaterialSerras.OptionsView.ShowFooter = true;
            this.gridViewMaterialSerras.OptionsView.ShowGroupPanel = false;
            this.gridViewMaterialSerras.DoubleClick += new System.EventHandler(this.gridViewMaterialSerras_DoubleClick);
            // 
            // colIdMaterialSerra
            // 
            this.colIdMaterialSerra.AppearanceCell.Options.UseTextOptions = true;
            this.colIdMaterialSerra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMaterialSerra.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdMaterialSerra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMaterialSerra.Caption = "Ref. Prod.";
            this.colIdMaterialSerra.FieldName = "IdMaterial";
            this.colIdMaterialSerra.Name = "colIdMaterialSerra";
            this.colIdMaterialSerra.OptionsColumn.AllowEdit = false;
            this.colIdMaterialSerra.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMaterial", "{0}")});
            this.colIdMaterialSerra.Visible = true;
            this.colIdMaterialSerra.VisibleIndex = 1;
            this.colIdMaterialSerra.Width = 90;
            // 
            // colDescricaoMaterialSerra
            // 
            this.colDescricaoMaterialSerra.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoMaterialSerra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoMaterialSerra.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricaoMaterialSerra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoMaterialSerra.Caption = "Material";
            this.colDescricaoMaterialSerra.FieldName = "NomeMaterial";
            this.colDescricaoMaterialSerra.Name = "colDescricaoMaterialSerra";
            this.colDescricaoMaterialSerra.OptionsColumn.AllowEdit = false;
            this.colDescricaoMaterialSerra.Visible = true;
            this.colDescricaoMaterialSerra.VisibleIndex = 2;
            this.colDescricaoMaterialSerra.Width = 410;
            // 
            // colPrecoVenda
            // 
            this.colPrecoVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecoVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoVenda.Caption = "Valor Metro Quadrado";
            this.colPrecoVenda.DisplayFormat.FormatString = "n2";
            this.colPrecoVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoVenda.FieldName = "ValorMetroQuadrado";
            this.colPrecoVenda.Name = "colPrecoVenda";
            this.colPrecoVenda.Visible = true;
            this.colPrecoVenda.VisibleIndex = 3;
            this.colPrecoVenda.Width = 175;
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
            this.tableLayoutPanel1.Controls.Add(this.gridControlMaterialSerras, 0, 1);
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
            this.searchControl1.Client = this.gridControlMaterialSerras;
            this.searchControl1.Location = new System.Drawing.Point(8, 6);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchControl1.MenuManager = this.barManager1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlMaterialSerras;
            this.searchControl1.Properties.FindDelay = 5000;
            this.searchControl1.Properties.NullValuePrompt = "Digite aqui o nome próximo ao material...";
            this.searchControl1.Size = new System.Drawing.Size(410, 22);
            this.searchControl1.TabIndex = 0;
            this.searchControl1.EditValueChanged += new System.EventHandler(this.searchControl1_EditValueChanged);
            this.searchControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchControl1_PreviewKeyDown);
            // 
            // XFrmMaterialSerraListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 449);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "XFrmMaterialSerraListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Materiais:";
            this.Shown += new System.EventHandler(this.XFrmGerenciarMaterialSerraNovo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMaterialSerras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialSerras)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControlMaterialSerras;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialSerras;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMaterialSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoMaterialSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoVenda;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarButtonItem btnAddMaterialSerra;
        private DevExpress.XtraBars.BarButtonItem barBtnEditarMaterialSerra;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}