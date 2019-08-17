namespace ITE.Contabil.Forms.ListView
{
    partial class XFrmViewCentroCusto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewCentroCusto));
            this.btnVisualizarCentroCusto = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.barAction = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlCentroCusto = new DevExpress.XtraGrid.GridControl();
            this.centroCustoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCentroCusto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAbertura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsCentroCusto = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCentroCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroCustoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCentroCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCentroCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizarCentroCusto
            // 
            this.btnVisualizarCentroCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarCentroCusto.Location = new System.Drawing.Point(705, 420);
            this.btnVisualizarCentroCusto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisualizarCentroCusto.Name = "btnVisualizarCentroCusto";
            this.btnVisualizarCentroCusto.Size = new System.Drawing.Size(60, 20);
            this.btnVisualizarCentroCusto.TabIndex = 79;
            this.btnVisualizarCentroCusto.Text = "Visualizar";
            this.btnVisualizarCentroCusto.Click += new System.EventHandler(this.btnVisualizarCentroCusto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(640, 420);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 20);
            this.btnCancelar.TabIndex = 78;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // barAction
            // 
            this.barAction.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barAction.DockControls.Add(this.barDockControlTop);
            this.barAction.DockControls.Add(this.barDockControlBottom);
            this.barAction.DockControls.Add(this.barDockControlLeft);
            this.barAction.DockControls.Add(this.barDockControlRight);
            this.barAction.Form = this;
            this.barAction.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnExcluir,
            this.barBtnEditar,
            this.barBtnAtualizar,
            this.barBtnNovo});
            this.barAction.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnNovo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.barBtnExcluir, false),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.Caption = "Novo Centro";
            this.barBtnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Glyph")));
            this.barBtnNovo.Id = 4;
            this.barBtnNovo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.LargeGlyph")));
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovo_ItemClick);
            // 
            // barBtnEditar
            // 
            this.barBtnEditar.Caption = "Editar/Visualizar";
            this.barBtnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditar.Glyph")));
            this.barBtnEditar.Id = 1;
            this.barBtnEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditar.LargeGlyph")));
            this.barBtnEditar.Name = "barBtnEditar";
            this.barBtnEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditarCc_ItemClick);
            // 
            // barBtnExcluir
            // 
            this.barBtnExcluir.Caption = "Excluir Centro Custo";
            this.barBtnExcluir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExcluir.Glyph")));
            this.barBtnExcluir.Id = 0;
            this.barBtnExcluir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnExcluir.LargeGlyph")));
            this.barBtnExcluir.Name = "barBtnExcluir";
            this.barBtnExcluir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnExcluir.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnExcluir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExcluir_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 2;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(776, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 449);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(776, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 404);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(776, 45);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 404);
            // 
            // gridControlCentroCusto
            // 
            this.gridControlCentroCusto.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlCentroCusto.DataSource = this.centroCustoBindingSource;
            this.gridControlCentroCusto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCentroCusto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCentroCusto.Location = new System.Drawing.Point(0, 45);
            this.gridControlCentroCusto.MainView = this.gridViewCentroCusto;
            this.gridControlCentroCusto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCentroCusto.Name = "gridControlCentroCusto";
            this.gridControlCentroCusto.Size = new System.Drawing.Size(776, 404);
            this.gridControlCentroCusto.TabIndex = 83;
            this.gridControlCentroCusto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCentroCusto});
            // 
            // centroCustoBindingSource
            // 
            this.centroCustoBindingSource.DataSource = typeof(ITE.Entidades.POCO.Contabil.CentroCusto);
            // 
            // gridViewCentroCusto
            // 
            this.gridViewCentroCusto.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewCentroCusto.Appearance.FocusedCell.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.gridViewCentroCusto.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewCentroCusto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCentroCusto,
            this.colCodMatriz,
            this.colCodigoCentroCusto,
            this.colNomeCentroCusto,
            this.colDataAbertura});
            this.gridViewCentroCusto.GridControl = this.gridControlCentroCusto;
            this.gridViewCentroCusto.Name = "gridViewCentroCusto";
            this.gridViewCentroCusto.OptionsBehavior.Editable = false;
            this.gridViewCentroCusto.OptionsFind.FindNullPrompt = "Digite aqui sua pesquisa";
            this.gridViewCentroCusto.OptionsView.ColumnAutoWidth = false;
            this.gridViewCentroCusto.OptionsView.ShowGroupPanel = false;
            this.gridViewCentroCusto.DoubleClick += new System.EventHandler(this.gridViewCentroCusto_DoubleClick);
            // 
            // colIdCentroCusto
            // 
            this.colIdCentroCusto.FieldName = "IdCentroCusto";
            this.colIdCentroCusto.Name = "colIdCentroCusto";
            // 
            // colCodMatriz
            // 
            this.colCodMatriz.Caption = "Matriz";
            this.colCodMatriz.FieldName = "Matriz.CodigoMatriz";
            this.colCodMatriz.Name = "colCodMatriz";
            this.colCodMatriz.Visible = true;
            this.colCodMatriz.VisibleIndex = 0;
            this.colCodMatriz.Width = 126;
            // 
            // colCodigoCentroCusto
            // 
            this.colCodigoCentroCusto.Caption = "Código";
            this.colCodigoCentroCusto.FieldName = "CodigoCentroCusto";
            this.colCodigoCentroCusto.Name = "colCodigoCentroCusto";
            this.colCodigoCentroCusto.Visible = true;
            this.colCodigoCentroCusto.VisibleIndex = 1;
            this.colCodigoCentroCusto.Width = 174;
            // 
            // colNomeCentroCusto
            // 
            this.colNomeCentroCusto.Caption = "Descrição centro de custo";
            this.colNomeCentroCusto.FieldName = "NomeCentroCusto";
            this.colNomeCentroCusto.Name = "colNomeCentroCusto";
            this.colNomeCentroCusto.Visible = true;
            this.colNomeCentroCusto.VisibleIndex = 2;
            this.colNomeCentroCusto.Width = 576;
            // 
            // colDataAbertura
            // 
            this.colDataAbertura.FieldName = "DataAbertura";
            this.colDataAbertura.Name = "colDataAbertura";
            // 
            // XFrmViewCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 449);
            this.Controls.Add(this.gridControlCentroCusto);
            this.Controls.Add(this.btnVisualizarCentroCusto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmViewCentroCusto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centros de Custo";
            this.Load += new System.EventHandler(this.XFrmInfoCentroCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCentroCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroCustoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCentroCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCentroCusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnVisualizarCentroCusto;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraBars.BarManager barAction;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnExcluir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnEditar;
        private DevExpress.XtraGrid.GridControl gridControlCentroCusto;
        private System.Windows.Forms.BindingSource bsCentroCusto;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCentroCusto;
        private DevExpress.XtraBars.BarButtonItem barBtnNovo;
        private System.Windows.Forms.BindingSource centroCustoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAbertura;
    }
}