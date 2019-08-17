namespace ITE.RH.Forms.ListView
{
    partial class XFrmEventoListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmEventoListView));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlEventos = new DevExpress.XtraGrid.GridControl();
            this.bsEventos = new System.Windows.Forms.BindingSource();
            this.gridViewEventos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEventoFolha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSomaBaseIRRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSomaBaseFGTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSomaBaseINSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCalculo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEventos)).BeginInit();
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
            this.btnNovo,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.bar1.OptionsBar.AllowDelete = true;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnNovo
            // 
            this.btnNovo.Caption = "Novo";
            this.btnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovo.Glyph")));
            this.btnNovo.Id = 0;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovo_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(806, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 323);
            this.barDockControlBottom.Size = new System.Drawing.Size(806, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 281);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(806, 42);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 281);
            // 
            // gridControlEventos
            // 
            this.gridControlEventos.DataSource = this.bsEventos;
            this.gridControlEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEventos.Location = new System.Drawing.Point(0, 42);
            this.gridControlEventos.MainView = this.gridViewEventos;
            this.gridControlEventos.MenuManager = this.barManager1;
            this.gridControlEventos.Name = "gridControlEventos";
            this.gridControlEventos.Size = new System.Drawing.Size(806, 281);
            this.gridControlEventos.TabIndex = 4;
            this.gridControlEventos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEventos});
            // 
            // bsEventos
            // 
            this.bsEventos.DataSource = typeof(ITE.Entidades.POCO.RH.Evento);
            // 
            // gridViewEventos
            // 
            this.gridViewEventos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEventoFolha,
            this.colCodigoEvento,
            this.colDescricaoEvento,
            this.colTipoEvento,
            this.colTipoReferencia,
            this.colCodCalculo,
            this.colSomaBaseIRRF,
            this.colSomaBaseFGTS,
            this.colSomaBaseINSS});
            this.gridViewEventos.GridControl = this.gridControlEventos;
            this.gridViewEventos.Name = "gridViewEventos";
            this.gridViewEventos.OptionsBehavior.Editable = false;
            this.gridViewEventos.OptionsView.ShowGroupPanel = false;
            this.gridViewEventos.DoubleClick += new System.EventHandler(this.gridViewEventos_DoubleClick);
            // 
            // colIdEventoFolha
            // 
            this.colIdEventoFolha.AppearanceCell.Options.UseTextOptions = true;
            this.colIdEventoFolha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdEventoFolha.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdEventoFolha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdEventoFolha.Caption = "ID";
            this.colIdEventoFolha.FieldName = "IdEvento";
            this.colIdEventoFolha.Name = "colIdEventoFolha";
            // 
            // colCodigoEvento
            // 
            this.colCodigoEvento.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoEvento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoEvento.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoEvento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoEvento.Caption = "Código";
            this.colCodigoEvento.FieldName = "CodigoEvento";
            this.colCodigoEvento.Name = "colCodigoEvento";
            this.colCodigoEvento.Visible = true;
            this.colCodigoEvento.VisibleIndex = 0;
            this.colCodigoEvento.Width = 62;
            // 
            // colDescricaoEvento
            // 
            this.colDescricaoEvento.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoEvento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoEvento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricaoEvento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoEvento.Caption = "Descrição";
            this.colDescricaoEvento.FieldName = "DescricaoEvento";
            this.colDescricaoEvento.Name = "colDescricaoEvento";
            this.colDescricaoEvento.Visible = true;
            this.colDescricaoEvento.VisibleIndex = 1;
            this.colDescricaoEvento.Width = 211;
            // 
            // colTipoEvento
            // 
            this.colTipoEvento.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoEvento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoEvento.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoEvento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoEvento.FieldName = "TipoEvento";
            this.colTipoEvento.Name = "colTipoEvento";
            this.colTipoEvento.Visible = true;
            this.colTipoEvento.VisibleIndex = 2;
            this.colTipoEvento.Width = 94;
            // 
            // colTipoReferencia
            // 
            this.colTipoReferencia.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoReferencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoReferencia.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoReferencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoReferencia.FieldName = "TipoReferencia";
            this.colTipoReferencia.Name = "colTipoReferencia";
            this.colTipoReferencia.Visible = true;
            this.colTipoReferencia.VisibleIndex = 3;
            this.colTipoReferencia.Width = 93;
            // 
            // colSomaBaseIRRF
            // 
            this.colSomaBaseIRRF.AppearanceCell.Options.UseTextOptions = true;
            this.colSomaBaseIRRF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSomaBaseIRRF.AppearanceHeader.Options.UseTextOptions = true;
            this.colSomaBaseIRRF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSomaBaseIRRF.Caption = "Base IRRF";
            this.colSomaBaseIRRF.FieldName = "SomaBaseIRRF";
            this.colSomaBaseIRRF.Name = "colSomaBaseIRRF";
            this.colSomaBaseIRRF.Visible = true;
            this.colSomaBaseIRRF.VisibleIndex = 5;
            this.colSomaBaseIRRF.Width = 79;
            // 
            // colSomaBaseFGTS
            // 
            this.colSomaBaseFGTS.AppearanceCell.Options.UseTextOptions = true;
            this.colSomaBaseFGTS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSomaBaseFGTS.AppearanceHeader.Options.UseTextOptions = true;
            this.colSomaBaseFGTS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSomaBaseFGTS.Caption = "Base FGTS";
            this.colSomaBaseFGTS.FieldName = "SomaBaseFGTS";
            this.colSomaBaseFGTS.Name = "colSomaBaseFGTS";
            this.colSomaBaseFGTS.Visible = true;
            this.colSomaBaseFGTS.VisibleIndex = 6;
            this.colSomaBaseFGTS.Width = 61;
            // 
            // colSomaBaseINSS
            // 
            this.colSomaBaseINSS.AppearanceCell.Options.UseTextOptions = true;
            this.colSomaBaseINSS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSomaBaseINSS.AppearanceHeader.Options.UseTextOptions = true;
            this.colSomaBaseINSS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSomaBaseINSS.Caption = "Base INSS";
            this.colSomaBaseINSS.FieldName = "SomaBaseINSS";
            this.colSomaBaseINSS.Name = "colSomaBaseINSS";
            this.colSomaBaseINSS.Visible = true;
            this.colSomaBaseINSS.VisibleIndex = 7;
            this.colSomaBaseINSS.Width = 70;
            // 
            // colCodCalculo
            // 
            this.colCodCalculo.Caption = "Código de cálculo";
            this.colCodCalculo.FieldName = "CodigoCalculo";
            this.colCodCalculo.Name = "colCodCalculo";
            this.colCodCalculo.Visible = true;
            this.colCodCalculo.VisibleIndex = 4;
            this.colCodCalculo.Width = 102;
            // 
            // XFrmEventoListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 345);
            this.Controls.Add(this.gridControlEventos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmEventoListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Shown += new System.EventHandler(this.XFrmGerenciarEvento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNovo;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlEventos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEventos;
        private System.Windows.Forms.BindingSource bsEventos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEventoFolha;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colSomaBaseIRRF;
        private DevExpress.XtraGrid.Columns.GridColumn colSomaBaseFGTS;
        private DevExpress.XtraGrid.Columns.GridColumn colSomaBaseINSS;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCalculo;
    }
}