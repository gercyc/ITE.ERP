namespace ITE.Financeiro.Forms.ListView
{
    partial class XFrmViewExtratoBancario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewExtratoBancario));
            this.gridControlExtrato = new DevExpress.XtraGrid.GridControl();
            this.bsExtratoBancario = new System.Windows.Forms.BindingSource();
            this.gridViewExtrato = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImagemTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdExtrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoExtrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataExtrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCompensacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorExtrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataChequePreDatado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgenciaCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroContaEmissorCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmissorCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompensado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodContaBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeConta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistorico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataEstorno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrintReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.dtFinalEdit = new DevExpress.XtraEditors.DateEdit();
            this.dtInicialEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbConta = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.brBtnAddExtrato = new DevExpress.XtraBars.BarButtonItem();
            this.brBtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.brBtnCompensar = new DevExpress.XtraBars.BarButtonItem();
            this.brBtnCancCompensacao = new DevExpress.XtraBars.BarButtonItem();
            this.btBtnRemove = new DevExpress.XtraBars.BarButtonItem();
            this.brBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnCalcLiquido = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lbLiquido = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExtrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExtratoBancario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExtrato)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinalEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinalEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicialEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicialEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlExtrato
            // 
            this.gridControlExtrato.DataSource = this.bsExtratoBancario;
            this.gridControlExtrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlExtrato.Location = new System.Drawing.Point(3, 42);
            this.gridControlExtrato.MainView = this.gridViewExtrato;
            this.gridControlExtrato.Name = "gridControlExtrato";
            this.gridControlExtrato.Size = new System.Drawing.Size(874, 392);
            this.gridControlExtrato.TabIndex = 2;
            this.gridControlExtrato.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewExtrato});
            // 
            // bsExtratoBancario
            // 
            this.bsExtratoBancario.DataSource = typeof(ITE.Entidades.POCO.Financeiro.ExtratoBancario);
            // 
            // gridViewExtrato
            // 
            this.gridViewExtrato.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImagemTipo,
            this.colIdExtrato,
            this.colTipoExtrato,
            this.colDataExtrato,
            this.colDataCompensacao,
            this.colValorExtrato,
            this.colNumeroCheque,
            this.colDataChequePreDatado,
            this.colBancoCheque,
            this.colAgenciaCheque,
            this.colNumeroContaEmissorCheque,
            this.colEmissorCheque,
            this.colCompensado,
            this.colIdLancamento,
            this.colCodContaBancaria,
            this.colNomeConta,
            this.colHistorico,
            this.colCentroCusto,
            this.colCodCentro,
            this.colDataEstorno});
            this.gridViewExtrato.GridControl = this.gridControlExtrato;
            this.gridViewExtrato.Name = "gridViewExtrato";
            this.gridViewExtrato.OptionsBehavior.Editable = false;
            this.gridViewExtrato.OptionsSelection.MultiSelect = true;
            this.gridViewExtrato.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewExtrato.OptionsView.ColumnAutoWidth = false;
            this.gridViewExtrato.OptionsView.ShowGroupPanel = false;
            this.gridViewExtrato.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataExtrato, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewExtrato.DoubleClick += new System.EventHandler(this.gridViewExtrato_DoubleClick);
            // 
            // colImagemTipo
            // 
            this.colImagemTipo.Caption = " ";
            this.colImagemTipo.FieldName = "ImageTipoExtrato";
            this.colImagemTipo.Name = "colImagemTipo";
            this.colImagemTipo.Visible = true;
            this.colImagemTipo.VisibleIndex = 1;
            this.colImagemTipo.Width = 32;
            // 
            // colIdExtrato
            // 
            this.colIdExtrato.Caption = "Ref. Extrato";
            this.colIdExtrato.FieldName = "IdExtrato";
            this.colIdExtrato.Name = "colIdExtrato";
            this.colIdExtrato.Visible = true;
            this.colIdExtrato.VisibleIndex = 2;
            this.colIdExtrato.Width = 130;
            // 
            // colTipoExtrato
            // 
            this.colTipoExtrato.Caption = "Tipo";
            this.colTipoExtrato.FieldName = "TipoExtrato";
            this.colTipoExtrato.Name = "colTipoExtrato";
            this.colTipoExtrato.Visible = true;
            this.colTipoExtrato.VisibleIndex = 4;
            // 
            // colDataExtrato
            // 
            this.colDataExtrato.Caption = "Data";
            this.colDataExtrato.FieldName = "DataExtrato";
            this.colDataExtrato.Name = "colDataExtrato";
            this.colDataExtrato.Visible = true;
            this.colDataExtrato.VisibleIndex = 6;
            // 
            // colDataCompensacao
            // 
            this.colDataCompensacao.Caption = "Compensação";
            this.colDataCompensacao.FieldName = "DataCompensacao";
            this.colDataCompensacao.Name = "colDataCompensacao";
            this.colDataCompensacao.Visible = true;
            this.colDataCompensacao.VisibleIndex = 7;
            this.colDataCompensacao.Width = 105;
            // 
            // colValorExtrato
            // 
            this.colValorExtrato.Caption = "Valor";
            this.colValorExtrato.DisplayFormat.FormatString = "N2";
            this.colValorExtrato.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorExtrato.FieldName = "ValorExtrato";
            this.colValorExtrato.Name = "colValorExtrato";
            this.colValorExtrato.Visible = true;
            this.colValorExtrato.VisibleIndex = 8;
            // 
            // colNumeroCheque
            // 
            this.colNumeroCheque.FieldName = "NumeroCheque";
            this.colNumeroCheque.Name = "colNumeroCheque";
            // 
            // colDataChequePreDatado
            // 
            this.colDataChequePreDatado.FieldName = "DataChequePreDatado";
            this.colDataChequePreDatado.Name = "colDataChequePreDatado";
            // 
            // colBancoCheque
            // 
            this.colBancoCheque.FieldName = "BancoCheque";
            this.colBancoCheque.Name = "colBancoCheque";
            // 
            // colAgenciaCheque
            // 
            this.colAgenciaCheque.FieldName = "AgenciaCheque";
            this.colAgenciaCheque.Name = "colAgenciaCheque";
            // 
            // colNumeroContaEmissorCheque
            // 
            this.colNumeroContaEmissorCheque.FieldName = "NumeroContaEmissorCheque";
            this.colNumeroContaEmissorCheque.Name = "colNumeroContaEmissorCheque";
            // 
            // colEmissorCheque
            // 
            this.colEmissorCheque.FieldName = "EmissorCheque";
            this.colEmissorCheque.Name = "colEmissorCheque";
            // 
            // colCompensado
            // 
            this.colCompensado.Caption = "Compensado?";
            this.colCompensado.FieldName = "Compensado";
            this.colCompensado.Name = "colCompensado";
            this.colCompensado.Visible = true;
            this.colCompensado.VisibleIndex = 9;
            this.colCompensado.Width = 105;
            // 
            // colIdLancamento
            // 
            this.colIdLancamento.Caption = "Ref. Lanç.";
            this.colIdLancamento.FieldName = "IdLancamento";
            this.colIdLancamento.Name = "colIdLancamento";
            this.colIdLancamento.Visible = true;
            this.colIdLancamento.VisibleIndex = 3;
            this.colIdLancamento.Width = 82;
            // 
            // colCodContaBancaria
            // 
            this.colCodContaBancaria.Caption = "Código Conta";
            this.colCodContaBancaria.FieldName = "ContaBancaria.CodigoContaBancaria";
            this.colCodContaBancaria.Name = "colCodContaBancaria";
            this.colCodContaBancaria.Visible = true;
            this.colCodContaBancaria.VisibleIndex = 10;
            this.colCodContaBancaria.Width = 101;
            // 
            // colNomeConta
            // 
            this.colNomeConta.Caption = "Descrição conta";
            this.colNomeConta.FieldName = "ContaBancaria.DescricaoContaBancaria";
            this.colNomeConta.Name = "colNomeConta";
            // 
            // colHistorico
            // 
            this.colHistorico.Caption = "Histórico";
            this.colHistorico.FieldName = "Historico";
            this.colHistorico.Name = "colHistorico";
            this.colHistorico.Visible = true;
            this.colHistorico.VisibleIndex = 5;
            this.colHistorico.Width = 257;
            // 
            // colCentroCusto
            // 
            this.colCentroCusto.Caption = "Centro de Custo";
            this.colCentroCusto.FieldName = "CentroCusto.NomeCentroCusto";
            this.colCentroCusto.Name = "colCentroCusto";
            this.colCentroCusto.Visible = true;
            this.colCentroCusto.VisibleIndex = 12;
            this.colCentroCusto.Width = 198;
            // 
            // colCodCentro
            // 
            this.colCodCentro.Caption = "Cód. Centro de custo";
            this.colCodCentro.FieldName = "CentroCusto.CodigoCentroCusto";
            this.colCodCentro.Name = "colCodCentro";
            this.colCodCentro.Visible = true;
            this.colCodCentro.VisibleIndex = 11;
            this.colCodCentro.Width = 145;
            // 
            // colDataEstorno
            // 
            this.colDataEstorno.Caption = "Data estorno";
            this.colDataEstorno.FieldName = "DataEstorno";
            this.colDataEstorno.Name = "colDataEstorno";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlExtrato, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.070294F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.9297F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 437);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnPrintReport);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.dtFinalEdit);
            this.panel1.Controls.Add(this.dtInicialEdit);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.cbConta);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 33);
            this.panel1.TabIndex = 3;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintReport.Image")));
            this.btnPrintReport.Location = new System.Drawing.Point(709, 5);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(75, 23);
            this.btnPrintReport.TabIndex = 7;
            this.btnPrintReport.Text = "Relatório";
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(628, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtFinalEdit
            // 
            this.dtFinalEdit.EditValue = null;
            this.dtFinalEdit.Location = new System.Drawing.Point(514, 7);
            this.dtFinalEdit.Name = "dtFinalEdit";
            this.dtFinalEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinalEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinalEdit.Size = new System.Drawing.Size(108, 20);
            this.dtFinalEdit.TabIndex = 5;
            // 
            // dtInicialEdit
            // 
            this.dtInicialEdit.EditValue = null;
            this.dtInicialEdit.Location = new System.Drawing.Point(328, 7);
            this.dtInicialEdit.Name = "dtInicialEdit";
            this.dtInicialEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicialEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicialEdit.Size = new System.Drawing.Size(108, 20);
            this.dtInicialEdit.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(458, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Data final:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(267, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data inicial:";
            // 
            // cbConta
            // 
            this.cbConta.Location = new System.Drawing.Point(86, 8);
            this.cbConta.Name = "cbConta";
            this.cbConta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbConta.Size = new System.Drawing.Size(163, 20);
            this.cbConta.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Conta bancária:";
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
            this.brBtnAddExtrato,
            this.brBtnEdit,
            this.brBtnCompensar,
            this.brBtnCancCompensacao,
            this.btBtnRemove,
            this.brBtnRefresh,
            this.barStaticItem1,
            this.btnCalcLiquido,
            this.lbLiquido});
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.brBtnAddExtrato),
            new DevExpress.XtraBars.LinkPersistInfo(this.brBtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.brBtnCompensar),
            new DevExpress.XtraBars.LinkPersistInfo(this.brBtnCancCompensacao),
            new DevExpress.XtraBars.LinkPersistInfo(this.btBtnRemove),
            new DevExpress.XtraBars.LinkPersistInfo(this.brBtnRefresh)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // brBtnAddExtrato
            // 
            this.brBtnAddExtrato.Caption = "Novo";
            this.brBtnAddExtrato.Glyph = ((System.Drawing.Image)(resources.GetObject("brBtnAddExtrato.Glyph")));
            this.brBtnAddExtrato.Id = 0;
            this.brBtnAddExtrato.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("brBtnAddExtrato.LargeGlyph")));
            this.brBtnAddExtrato.Name = "brBtnAddExtrato";
            this.brBtnAddExtrato.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddExtrato_ItemClick);
            // 
            // brBtnEdit
            // 
            this.brBtnEdit.Caption = "Editar/Visualizar";
            this.brBtnEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("brBtnEdit.Glyph")));
            this.brBtnEdit.Id = 1;
            this.brBtnEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("brBtnEdit.LargeGlyph")));
            this.brBtnEdit.Name = "brBtnEdit";
            this.brBtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditExtrato_ItemClick);
            // 
            // brBtnCompensar
            // 
            this.brBtnCompensar.Caption = "Compensar";
            this.brBtnCompensar.Glyph = ((System.Drawing.Image)(resources.GetObject("brBtnCompensar.Glyph")));
            this.brBtnCompensar.Id = 2;
            this.brBtnCompensar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("brBtnCompensar.LargeGlyph")));
            this.brBtnCompensar.Name = "brBtnCompensar";
            this.brBtnCompensar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCompensarExtratos_ItemClick);
            // 
            // brBtnCancCompensacao
            // 
            this.brBtnCancCompensacao.Caption = "Cancelar compensação";
            this.brBtnCancCompensacao.Glyph = ((System.Drawing.Image)(resources.GetObject("brBtnCancCompensacao.Glyph")));
            this.brBtnCancCompensacao.Id = 3;
            this.brBtnCancCompensacao.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("brBtnCancCompensacao.LargeGlyph")));
            this.brBtnCancCompensacao.Name = "brBtnCancCompensacao";
            this.brBtnCancCompensacao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelarComp_ItemClick);
            // 
            // btBtnRemove
            // 
            this.btBtnRemove.Caption = "Excluir";
            this.btBtnRemove.Glyph = ((System.Drawing.Image)(resources.GetObject("btBtnRemove.Glyph")));
            this.btBtnRemove.Id = 4;
            this.btBtnRemove.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btBtnRemove.LargeGlyph")));
            this.btBtnRemove.Name = "btBtnRemove";
            this.btBtnRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcluirExtrato_ItemClick);
            // 
            // brBtnRefresh
            // 
            this.brBtnRefresh.Caption = "Atualizar";
            this.brBtnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("brBtnRefresh.Glyph")));
            this.brBtnRefresh.Id = 5;
            this.brBtnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("brBtnRefresh.LargeGlyph")));
            this.brBtnRefresh.Name = "brBtnRefresh";
            this.brBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCalcLiquido),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbLiquido)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnCalcLiquido
            // 
            this.btnCalcLiquido.Caption = "Valor líquido";
            this.btnCalcLiquido.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCalcLiquido.Glyph")));
            this.btnCalcLiquido.Id = 7;
            this.btnCalcLiquido.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCalcLiquido.LargeGlyph")));
            this.btnCalcLiquido.Name = "btnCalcLiquido";
            this.btnCalcLiquido.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalcLiquido_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Líquido:";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbLiquido
            // 
            this.lbLiquido.Caption = "0,00";
            this.lbLiquido.Id = 8;
            this.lbLiquido.Name = "lbLiquido";
            this.lbLiquido.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(880, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 468);
            this.barDockControlBottom.Size = new System.Drawing.Size(880, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 437);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(880, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 437);
            // 
            // XFrmViewExtratoBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "XFrmViewExtratoBancario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extrato bancário";
            this.Shown += new System.EventHandler(this.XFrmViewExtratoBancario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlExtrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExtratoBancario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExtrato)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinalEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinalEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicialEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicialEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlExtrato;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExtrato;
        private System.Windows.Forms.BindingSource bsExtratoBancario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdExtrato;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoExtrato;
        private DevExpress.XtraGrid.Columns.GridColumn colDataExtrato;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCompensacao;
        private DevExpress.XtraGrid.Columns.GridColumn colValorExtrato;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colDataChequePreDatado;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colAgenciaCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroContaEmissorCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colEmissorCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colCompensado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colCodContaBancaria;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeConta;
        private DevExpress.XtraGrid.Columns.GridColumn colHistorico;
        private DevExpress.XtraGrid.Columns.GridColumn colCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCentro;
        private DevExpress.XtraGrid.Columns.GridColumn colImagemTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colDataEstorno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnPrintReport;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraEditors.DateEdit dtFinalEdit;
        private DevExpress.XtraEditors.DateEdit dtInicialEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbConta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem brBtnAddExtrato;
        private DevExpress.XtraBars.BarButtonItem brBtnEdit;
        private DevExpress.XtraBars.BarButtonItem brBtnCompensar;
        private DevExpress.XtraBars.BarButtonItem brBtnCancCompensacao;
        private DevExpress.XtraBars.BarButtonItem btBtnRemove;
        private DevExpress.XtraBars.BarButtonItem brBtnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCalcLiquido;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem lbLiquido;
    }
}