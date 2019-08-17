namespace ITE.RH.Forms.ListView
{
    partial class XFrmFuncaoListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmFuncaoListView));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNovaFuncao = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlFuncao = new DevExpress.XtraGrid.GridControl();
            this.funcaoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewFuncao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuncao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuncao)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowCustomization = false;
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNovaFuncao,
            this.btnEditar,
            this.btnDelete,
            this.btnRefresh});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovaFuncao),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnNovaFuncao
            // 
            this.btnNovaFuncao.Caption = "Novo";
            this.btnNovaFuncao.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovaFuncao.Glyph")));
            this.btnNovaFuncao.Id = 0;
            this.btnNovaFuncao.Name = "btnNovaFuncao";
            this.btnNovaFuncao.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNovaFuncao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovaFuncao_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
            this.btnEditar.Id = 1;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Excluir";
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 2;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Atualizar";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 3;
            this.btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(743, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 288);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(743, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 229);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(743, 59);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 229);
            // 
            // gridControlFuncao
            // 
            this.gridControlFuncao.DataSource = this.funcaoBindingSource;
            this.gridControlFuncao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFuncao.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlFuncao.Location = new System.Drawing.Point(0, 59);
            this.gridControlFuncao.MainView = this.gridViewFuncao;
            this.gridControlFuncao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlFuncao.MenuManager = this.barManager1;
            this.gridControlFuncao.Name = "gridControlFuncao";
            this.gridControlFuncao.Size = new System.Drawing.Size(743, 229);
            this.gridControlFuncao.TabIndex = 5;
            this.gridControlFuncao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFuncao});
            // 
            // funcaoBindingSource
            // 
            this.funcaoBindingSource.DataSource = typeof(ITE.Entidades.POCO.RH.Funcao);
            // 
            // gridViewFuncao
            // 
            this.gridViewFuncao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFuncao,
            this.colNomeFuncao,
            this.colCodigoFuncao,
            this.colCBO});
            this.gridViewFuncao.GridControl = this.gridControlFuncao;
            this.gridViewFuncao.Name = "gridViewFuncao";
            this.gridViewFuncao.OptionsBehavior.Editable = false;
            this.gridViewFuncao.OptionsView.ShowGroupPanel = false;
            this.gridViewFuncao.DoubleClick += new System.EventHandler(this.gridViewFuncao_DoubleClick);
            // 
            // colIdFuncao
            // 
            this.colIdFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncao.Caption = "ID";
            this.colIdFuncao.FieldName = "IdFuncao";
            this.colIdFuncao.Name = "colIdFuncao";
            this.colIdFuncao.Visible = true;
            this.colIdFuncao.VisibleIndex = 0;
            this.colIdFuncao.Width = 78;
            // 
            // colNomeFuncao
            // 
            this.colNomeFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colNomeFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeFuncao.Caption = "Nome Função";
            this.colNomeFuncao.FieldName = "NomeFuncao";
            this.colNomeFuncao.Name = "colNomeFuncao";
            this.colNomeFuncao.Visible = true;
            this.colNomeFuncao.VisibleIndex = 2;
            this.colNomeFuncao.Width = 345;
            // 
            // colCodigoFuncao
            // 
            this.colCodigoFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoFuncao.Caption = "Código";
            this.colCodigoFuncao.FieldName = "CodigoFuncao";
            this.colCodigoFuncao.Name = "colCodigoFuncao";
            this.colCodigoFuncao.Visible = true;
            this.colCodigoFuncao.VisibleIndex = 1;
            this.colCodigoFuncao.Width = 114;
            // 
            // colCBO
            // 
            this.colCBO.AppearanceCell.Options.UseTextOptions = true;
            this.colCBO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCBO.AppearanceHeader.Options.UseTextOptions = true;
            this.colCBO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCBO.FieldName = "CBO";
            this.colCBO.Name = "colCBO";
            this.colCBO.Visible = true;
            this.colCBO.VisibleIndex = 3;
            this.colCBO.Width = 112;
            // 
            // XFrmViewFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 313);
            this.Controls.Add(this.gridControlFuncao);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmViewFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funções";
            this.Shown += new System.EventHandler(this.XFrmGerenciarFuncao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuncao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuncao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNovaFuncao;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlFuncao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFuncao;
        private System.Windows.Forms.BindingSource funcaoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colCBO;
    }
}