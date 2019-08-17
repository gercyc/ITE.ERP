namespace ITE.Forms.OldVersion
{
    partial class XFrmConfigParam_OLD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmConfigParam_OLD));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlParam = new DevExpress.XtraGrid.GridControl();
            this.parametroBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewParam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoParametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoParametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusParametro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlParam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 37);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(717, 372);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Parametros";
            // 
            // gridControlParam
            // 
            this.gridControlParam.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlParam.DataSource = this.parametroBindingSource;
            this.gridControlParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlParam.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlParam.Location = new System.Drawing.Point(2, 26);
            this.gridControlParam.MainView = this.gridViewParam;
            this.gridControlParam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlParam.Name = "gridControlParam";
            this.gridControlParam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridControlParam.Size = new System.Drawing.Size(713, 344);
            this.gridControlParam.TabIndex = 1;
            this.gridControlParam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParam});
            // 
            // parametroBindingSource
            // 
            this.parametroBindingSource.DataSource = typeof(ITSolution.Framework.Entities.Parametro);
            // 
            // gridViewParam
            // 
            this.gridViewParam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoParametro,
            this.colDescricaoParametro,
            this.colStatusParametro});
            this.gridViewParam.GridControl = this.gridControlParam;
            this.gridViewParam.Name = "gridViewParam";
            this.gridViewParam.OptionsView.ColumnAutoWidth = false;
            this.gridViewParam.OptionsView.ShowGroupPanel = false;
            this.gridViewParam.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewParam_CellValueChanged);
            this.gridViewParam.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewParam_CellValueChanging);
            this.gridViewParam.DoubleClick += new System.EventHandler(this.gridViewParam_DoubleClick);
            // 
            // colCodigoParametro
            // 
            this.colCodigoParametro.Caption = "Código";
            this.colCodigoParametro.FieldName = "CodigoParametro";
            this.colCodigoParametro.Name = "colCodigoParametro";
            this.colCodigoParametro.OptionsColumn.AllowEdit = false;
            this.colCodigoParametro.Width = 182;
            // 
            // colDescricaoParametro
            // 
            this.colDescricaoParametro.Caption = "Parâmetro";
            this.colDescricaoParametro.FieldName = "DescricaoParametro";
            this.colDescricaoParametro.Name = "colDescricaoParametro";
            this.colDescricaoParametro.OptionsColumn.AllowEdit = false;
            this.colDescricaoParametro.Visible = true;
            this.colDescricaoParametro.VisibleIndex = 0;
            this.colDescricaoParametro.Width = 426;
            // 
            // colStatusParametro
            // 
            this.colStatusParametro.Caption = "Valor";
            this.colStatusParametro.FieldName = "StatusParametro";
            this.colStatusParametro.Name = "colStatusParametro";
            this.colStatusParametro.Width = 78;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "0",
            "1"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
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
            this.barBtnSalvar.Caption = "Salvar Alterações";
            this.barBtnSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.Glyph")));
            this.barBtnSalvar.Id = 0;
            this.barBtnSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.LargeGlyph")));
            this.barBtnSalvar.Name = "barBtnSalvar";
            this.barBtnSalvar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSalvar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(717, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(717, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 372);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(717, 37);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 372);
            // 
            // XFrmConfigParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 431);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmConfigParam";
            this.Text = "Configurar parâmetros:";
            this.Shown += new System.EventHandler(this.XFrmConfigParam_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlParam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParam;
        private System.Windows.Forms.BindingSource parametroBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoParametro;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusParametro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoParametro;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnSalvar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;

    }
}