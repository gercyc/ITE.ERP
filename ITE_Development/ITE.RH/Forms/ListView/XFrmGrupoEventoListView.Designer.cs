namespace ITE.RH.Forms.ListView
{
    partial class XFrmGrupoEventoListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmGrupoEventoListView));
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
            this.grupoEventoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewEventos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGrupoEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacoes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEventosGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsEventos = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoEventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEventos)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(806, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 324);
            this.barDockControlBottom.Size = new System.Drawing.Size(806, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 279);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(806, 45);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 279);
            // 
            // gridControlEventos
            // 
            this.gridControlEventos.DataSource = this.grupoEventoBindingSource;
            this.gridControlEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEventos.Location = new System.Drawing.Point(0, 45);
            this.gridControlEventos.MainView = this.gridViewEventos;
            this.gridControlEventos.MenuManager = this.barManager1;
            this.gridControlEventos.Name = "gridControlEventos";
            this.gridControlEventos.Size = new System.Drawing.Size(806, 279);
            this.gridControlEventos.TabIndex = 4;
            this.gridControlEventos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEventos});
            // 
            // grupoEventoBindingSource
            // 
            this.grupoEventoBindingSource.DataSource = typeof(ITE.Entidades.POCO.RH.Folha.GrupoEvento);
            // 
            // gridViewEventos
            // 
            this.gridViewEventos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGrupoEvento,
            this.colCodigoGrupo,
            this.colDescricaoGrupo,
            this.colObservacoes,
            this.colEventosGrupo});
            this.gridViewEventos.GridControl = this.gridControlEventos;
            this.gridViewEventos.Name = "gridViewEventos";
            this.gridViewEventos.OptionsBehavior.Editable = false;
            this.gridViewEventos.OptionsView.ShowGroupPanel = false;
            this.gridViewEventos.DoubleClick += new System.EventHandler(this.gridViewEventos_DoubleClick);
            // 
            // colIdGrupoEvento
            // 
            this.colIdGrupoEvento.FieldName = "IdGrupoEvento";
            this.colIdGrupoEvento.Name = "colIdGrupoEvento";
            // 
            // colCodigoGrupo
            // 
            this.colCodigoGrupo.FieldName = "CodigoGrupo";
            this.colCodigoGrupo.Name = "colCodigoGrupo";
            this.colCodigoGrupo.Visible = true;
            this.colCodigoGrupo.VisibleIndex = 0;
            this.colCodigoGrupo.Width = 153;
            // 
            // colDescricaoGrupo
            // 
            this.colDescricaoGrupo.FieldName = "DescricaoGrupo";
            this.colDescricaoGrupo.Name = "colDescricaoGrupo";
            this.colDescricaoGrupo.Visible = true;
            this.colDescricaoGrupo.VisibleIndex = 1;
            this.colDescricaoGrupo.Width = 316;
            // 
            // colObservacoes
            // 
            this.colObservacoes.FieldName = "Observacoes";
            this.colObservacoes.Name = "colObservacoes";
            this.colObservacoes.Visible = true;
            this.colObservacoes.VisibleIndex = 2;
            this.colObservacoes.Width = 319;
            // 
            // colEventosGrupo
            // 
            this.colEventosGrupo.FieldName = "EventosGrupo";
            this.colEventosGrupo.Name = "colEventosGrupo";
            // 
            // bsEventos
            // 
            this.bsEventos.DataSource = typeof(ITE.Entidades.POCO.RH.Evento);
            // 
            // XFrmGrupoEventoListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 345);
            this.Controls.Add(this.gridControlEventos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmGrupoEventoListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Shown += new System.EventHandler(this.XFrmGerenciarEvento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoEventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEventos)).EndInit();
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
        private System.Windows.Forms.BindingSource grupoEventoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacoes;
        private DevExpress.XtraGrid.Columns.GridColumn colEventosGrupo;
    }
}