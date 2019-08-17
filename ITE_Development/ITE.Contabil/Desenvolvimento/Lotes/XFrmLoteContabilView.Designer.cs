namespace ITE.Contabil.Desenvolvimento.Lotes
{
    partial class XFrmLoteContabilView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmLoteContabilView));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNovoLote = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelLote = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlLoteCont = new DevExpress.XtraGrid.GridControl();
            this.loteContabilBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewLoteCont = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorDebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrigemLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCriacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLancamentosLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partidaContabilBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoteCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteContabilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoteCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaContabilBindingSource)).BeginInit();
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
            this.btnNovoLote,
            this.btnDelLote,
            this.btnRefresh,
            this.btnEditar});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovoLote),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelLote),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnNovoLote
            // 
            this.btnNovoLote.Caption = "Novo";
            this.btnNovoLote.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovoLote.Glyph")));
            this.btnNovoLote.Id = 0;
            this.btnNovoLote.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNovoLote.LargeGlyph")));
            this.btnNovoLote.Name = "btnNovoLote";
            this.btnNovoLote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovoLote_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
            this.btnEditar.Id = 3;
            this.btnEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.LargeGlyph")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnDelLote
            // 
            this.btnDelLote.Caption = "Excluir";
            this.btnDelLote.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelLote.Glyph")));
            this.btnDelLote.Id = 1;
            this.btnDelLote.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelLote.LargeGlyph")));
            this.btnDelLote.Name = "btnDelLote";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Atualizar";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 2;
            this.btnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.LargeGlyph")));
            this.btnRefresh.Name = "btnRefresh";
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
            this.barDockControlTop.Size = new System.Drawing.Size(715, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 354);
            this.barDockControlBottom.Size = new System.Drawing.Size(715, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 325);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(715, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 325);
            // 
            // gridControlLoteCont
            // 
            this.gridControlLoteCont.DataSource = this.loteContabilBindingSource;
            this.gridControlLoteCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLoteCont.Location = new System.Drawing.Point(0, 29);
            this.gridControlLoteCont.MainView = this.gridViewLoteCont;
            this.gridControlLoteCont.MenuManager = this.barManager1;
            this.gridControlLoteCont.Name = "gridControlLoteCont";
            this.gridControlLoteCont.Size = new System.Drawing.Size(715, 325);
            this.gridControlLoteCont.TabIndex = 4;
            this.gridControlLoteCont.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLoteCont});
            // 
            // loteContabilBindingSource
            // 
            this.loteContabilBindingSource.DataSource = typeof(ITE.Entidades.POCO.Contabil.LoteContabil);
            // 
            // gridViewLoteCont
            // 
            this.gridViewLoteCont.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLote,
            this.colIdMatriz,
            this.colNumeroLote,
            this.colDescricaoLote,
            this.colDataInicial,
            this.colDataFinal,
            this.colValorDebito,
            this.colValorCredito,
            this.colValor,
            this.colOrigemLote,
            this.colStatusLote,
            this.colIdUsuario,
            this.colDataCriacao,
            this.colLancamentosLote,
            this.colUsuario,
            this.colMatriz});
            this.gridViewLoteCont.GridControl = this.gridControlLoteCont;
            this.gridViewLoteCont.Name = "gridViewLoteCont";
            this.gridViewLoteCont.OptionsBehavior.Editable = false;
            this.gridViewLoteCont.OptionsView.ColumnAutoWidth = false;
            this.gridViewLoteCont.OptionsView.ShowGroupPanel = false;
            this.gridViewLoteCont.DoubleClick += new System.EventHandler(this.gridViewLoteCont_DoubleClick);
            // 
            // colIdLote
            // 
            this.colIdLote.FieldName = "IdLote";
            this.colIdLote.Name = "colIdLote";
            // 
            // colIdMatriz
            // 
            this.colIdMatriz.FieldName = "IdMatriz";
            this.colIdMatriz.Name = "colIdMatriz";
            // 
            // colNumeroLote
            // 
            this.colNumeroLote.Caption = "Numero";
            this.colNumeroLote.FieldName = "NumeroLote";
            this.colNumeroLote.Name = "colNumeroLote";
            this.colNumeroLote.Visible = true;
            this.colNumeroLote.VisibleIndex = 1;
            this.colNumeroLote.Width = 98;
            // 
            // colDescricaoLote
            // 
            this.colDescricaoLote.Caption = "Descrição";
            this.colDescricaoLote.FieldName = "DescricaoLote";
            this.colDescricaoLote.Name = "colDescricaoLote";
            this.colDescricaoLote.Visible = true;
            this.colDescricaoLote.VisibleIndex = 2;
            this.colDescricaoLote.Width = 202;
            // 
            // colDataInicial
            // 
            this.colDataInicial.FieldName = "DataInicial";
            this.colDataInicial.Name = "colDataInicial";
            this.colDataInicial.Visible = true;
            this.colDataInicial.VisibleIndex = 3;
            this.colDataInicial.Width = 85;
            // 
            // colDataFinal
            // 
            this.colDataFinal.FieldName = "DataFinal";
            this.colDataFinal.Name = "colDataFinal";
            this.colDataFinal.Visible = true;
            this.colDataFinal.VisibleIndex = 4;
            this.colDataFinal.Width = 83;
            // 
            // colValorDebito
            // 
            this.colValorDebito.FieldName = "ValorDebito";
            this.colValorDebito.Name = "colValorDebito";
            this.colValorDebito.Visible = true;
            this.colValorDebito.VisibleIndex = 5;
            this.colValorDebito.Width = 104;
            // 
            // colValorCredito
            // 
            this.colValorCredito.FieldName = "ValorCredito";
            this.colValorCredito.Name = "colValorCredito";
            this.colValorCredito.Visible = true;
            this.colValorCredito.VisibleIndex = 6;
            this.colValorCredito.Width = 101;
            // 
            // colValor
            // 
            this.colValor.Caption = "Valor total";
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 7;
            this.colValor.Width = 111;
            // 
            // colOrigemLote
            // 
            this.colOrigemLote.Caption = "Origem";
            this.colOrigemLote.FieldName = "OrigemLote";
            this.colOrigemLote.Name = "colOrigemLote";
            this.colOrigemLote.Visible = true;
            this.colOrigemLote.VisibleIndex = 8;
            this.colOrigemLote.Width = 101;
            // 
            // colStatusLote
            // 
            this.colStatusLote.Caption = "Status";
            this.colStatusLote.FieldName = "StatusLote";
            this.colStatusLote.Name = "colStatusLote";
            this.colStatusLote.Visible = true;
            this.colStatusLote.VisibleIndex = 9;
            this.colStatusLote.Width = 104;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colDataCriacao
            // 
            this.colDataCriacao.FieldName = "DataCriacao";
            this.colDataCriacao.Name = "colDataCriacao";
            // 
            // colLancamentosLote
            // 
            this.colLancamentosLote.FieldName = "LancamentosLote";
            this.colLancamentosLote.Name = "colLancamentosLote";
            // 
            // colUsuario
            // 
            this.colUsuario.Caption = "Usuário";
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 10;
            this.colUsuario.Width = 105;
            // 
            // colMatriz
            // 
            this.colMatriz.Caption = "Matriz";
            this.colMatriz.FieldName = "Matriz";
            this.colMatriz.Name = "colMatriz";
            this.colMatriz.Visible = true;
            this.colMatriz.VisibleIndex = 0;
            this.colMatriz.Width = 251;
            // 
            // partidaContabilBindingSource
            // 
            this.partidaContabilBindingSource.DataSource = typeof(ITE.Entidades.POCO.Contabil.PartidaContabil);
            // 
            // XFrmLoteContabilView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 375);
            this.Controls.Add(this.gridControlLoteCont);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmLoteContabilView";
            this.Text = "Lotes contábeis";
            this.Shown += new System.EventHandler(this.XFrmLoteContabilView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoteCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loteContabilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoteCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaContabilBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControlLoteCont;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLoteCont;
        private DevExpress.XtraBars.BarButtonItem btnNovoLote;
        private DevExpress.XtraBars.BarButtonItem btnDelLote;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private System.Windows.Forms.BindingSource loteContabilBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLote;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroLote;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoLote;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colDataFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colValorDebito;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colOrigemLote;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusLote;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCriacao;
        private DevExpress.XtraGrid.Columns.GridColumn colLancamentosLote;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colMatriz;
        private System.Windows.Forms.BindingSource partidaContabilBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
    }
}