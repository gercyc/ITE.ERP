namespace ITE.Contabil.Desenvolvimento.Lancamentos
{
    partial class XFrmLancamentosContabeisView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmLancamentosContabeisView));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNovoLancamento = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditarLancamento = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelLancamento = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControlLancamentos = new DevExpress.XtraGrid.GridControl();
            this.lancamentoContabilBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewLancamentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroLanc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorDebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioAlter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCriacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLancamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoContabilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLancamentos)).BeginInit();
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
            this.btnNovoLancamento,
            this.btnEditarLancamento,
            this.btnDelLancamento,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovoLancamento),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditarLancamento),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelLancamento),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Caption = "Novo lançamento";
            this.btnNovoLancamento.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovoLancamento.Glyph")));
            this.btnNovoLancamento.Id = 0;
            this.btnNovoLancamento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNovoLancamento.LargeGlyph")));
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            this.btnNovoLancamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovoLancamento_ItemClick);
            // 
            // btnEditarLancamento
            // 
            this.btnEditarLancamento.Caption = "Editar lançamento";
            this.btnEditarLancamento.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditarLancamento.Glyph")));
            this.btnEditarLancamento.Id = 1;
            this.btnEditarLancamento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditarLancamento.LargeGlyph")));
            this.btnEditarLancamento.Name = "btnEditarLancamento";
            this.btnEditarLancamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarLancamento_ItemClick);
            // 
            // btnDelLancamento
            // 
            this.btnDelLancamento.Caption = "Excluir lançamento";
            this.btnDelLancamento.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelLancamento.Glyph")));
            this.btnDelLancamento.Id = 2;
            this.btnDelLancamento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelLancamento.LargeGlyph")));
            this.btnDelLancamento.Name = "btnDelLancamento";
            this.btnDelLancamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelLancamento_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Atualizar";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(710, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 336);
            this.barDockControlBottom.Size = new System.Drawing.Size(710, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 307);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(710, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 307);
            // 
            // gridControlLancamentos
            // 
            this.gridControlLancamentos.DataSource = this.lancamentoContabilBindingSource;
            this.gridControlLancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLancamentos.Location = new System.Drawing.Point(0, 29);
            this.gridControlLancamentos.MainView = this.gridViewLancamentos;
            this.gridControlLancamentos.MenuManager = this.barManager1;
            this.gridControlLancamentos.Name = "gridControlLancamentos";
            this.gridControlLancamentos.Size = new System.Drawing.Size(710, 307);
            this.gridControlLancamentos.TabIndex = 4;
            this.gridControlLancamentos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLancamentos});
            // 
            // lancamentoContabilBindingSource
            // 
            this.lancamentoContabilBindingSource.DataSource = typeof(ITE.Entidades.POCO.Contabil.LancamentoContabil);
            // 
            // gridViewLancamentos
            // 
            this.gridViewLancamentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroLanc,
            this.colDescricao,
            this.colDataLancamento,
            this.colValorDebito,
            this.colValorCredito,
            this.colValor,
            this.colIdUsuario,
            this.colIdUsuarioAlter,
            this.colDataCriacao,
            this.colDataAlteracao,
            this.colPartidas,
            this.colUsuario,
            this.colUsuarioAlteracao,
            this.colMatriz});
            this.gridViewLancamentos.GridControl = this.gridControlLancamentos;
            this.gridViewLancamentos.Name = "gridViewLancamentos";
            this.gridViewLancamentos.OptionsBehavior.Editable = false;
            this.gridViewLancamentos.OptionsView.ColumnAutoWidth = false;
            this.gridViewLancamentos.OptionsView.ShowGroupPanel = false;
            this.gridViewLancamentos.DoubleClick += new System.EventHandler(this.gridViewLancamentos_DoubleClick);
            // 
            // colNumeroLanc
            // 
            this.colNumeroLanc.Caption = "Número";
            this.colNumeroLanc.FieldName = "NumeroLancamento";
            this.colNumeroLanc.Name = "colNumeroLanc";
            this.colNumeroLanc.Visible = true;
            this.colNumeroLanc.VisibleIndex = 1;
            this.colNumeroLanc.Width = 111;
            // 
            // colDescricao
            // 
            this.colDescricao.Caption = "Descrição";
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 2;
            this.colDescricao.Width = 196;
            // 
            // colDataLancamento
            // 
            this.colDataLancamento.FieldName = "DataLancamento";
            this.colDataLancamento.Name = "colDataLancamento";
            this.colDataLancamento.Visible = true;
            this.colDataLancamento.VisibleIndex = 3;
            this.colDataLancamento.Width = 126;
            // 
            // colValorDebito
            // 
            this.colValorDebito.DisplayFormat.FormatString = "N2";
            this.colValorDebito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorDebito.FieldName = "ValorDebito";
            this.colValorDebito.Name = "colValorDebito";
            this.colValorDebito.Visible = true;
            this.colValorDebito.VisibleIndex = 4;
            this.colValorDebito.Width = 111;
            // 
            // colValorCredito
            // 
            this.colValorCredito.DisplayFormat.FormatString = "N2";
            this.colValorCredito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorCredito.FieldName = "ValorCredito";
            this.colValorCredito.Name = "colValorCredito";
            this.colValorCredito.Visible = true;
            this.colValorCredito.VisibleIndex = 5;
            this.colValorCredito.Width = 126;
            // 
            // colValor
            // 
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 39;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Width = 39;
            // 
            // colIdUsuarioAlter
            // 
            this.colIdUsuarioAlter.FieldName = "IdUsuarioAlter";
            this.colIdUsuarioAlter.Name = "colIdUsuarioAlter";
            this.colIdUsuarioAlter.Width = 39;
            // 
            // colDataCriacao
            // 
            this.colDataCriacao.FieldName = "DataCriacao";
            this.colDataCriacao.Name = "colDataCriacao";
            this.colDataCriacao.Width = 39;
            // 
            // colDataAlteracao
            // 
            this.colDataAlteracao.FieldName = "DataAlteracao";
            this.colDataAlteracao.Name = "colDataAlteracao";
            this.colDataAlteracao.Width = 120;
            // 
            // colPartidas
            // 
            this.colPartidas.FieldName = "Partidas";
            this.colPartidas.Name = "colPartidas";
            this.colPartidas.Width = 39;
            // 
            // colUsuario
            // 
            this.colUsuario.Caption = "Usuario criação";
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Width = 99;
            // 
            // colUsuarioAlteracao
            // 
            this.colUsuarioAlteracao.Caption = "Usuario alteração";
            this.colUsuarioAlteracao.FieldName = "UsuarioAlteracao";
            this.colUsuarioAlteracao.Name = "colUsuarioAlteracao";
            this.colUsuarioAlteracao.Width = 97;
            // 
            // colMatriz
            // 
            this.colMatriz.FieldName = "Matriz.CodigoMatriz";
            this.colMatriz.Name = "colMatriz";
            this.colMatriz.Visible = true;
            this.colMatriz.VisibleIndex = 0;
            this.colMatriz.Width = 108;
            // 
            // XFrmLancamentosContabeisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 357);
            this.Controls.Add(this.gridControlLancamentos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmLancamentosContabeisView";
            this.Text = "Lançamentos contábeis";
            this.Shown += new System.EventHandler(this.XFrmLancamentosContabeisView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLancamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoContabilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLancamentos)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControlLancamentos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLancamentos;
        private DevExpress.XtraBars.BarButtonItem btnNovoLancamento;
        private DevExpress.XtraBars.BarButtonItem btnEditarLancamento;
        private DevExpress.XtraBars.BarButtonItem btnDelLancamento;
        private System.Windows.Forms.BindingSource lancamentoContabilBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroLanc;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorDebito;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioAlter;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCriacao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn colPartidas;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn colMatriz;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
    }
}