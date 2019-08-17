namespace ITE.Contabil.Desenvolvimento.Lancamentos
{
    partial class XFrmAddLancamentoContabil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddLancamentoContabil));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtEditLancamento = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlPartidas = new DevExpress.XtraGrid.GridControl();
            this.partidaContabilBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewPartidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPartida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLancamentoContabil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencialPartida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContaContabilDeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContaContabilCred = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoeda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorPartida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoeda2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorPartida2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHistoricoPadrao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistorico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalizacaoFisDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLancamentoContabil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContaContabilDebito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContaContabilCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoedaPrincipal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoedaEstrangeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParticipante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNovoLancamento = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveLancamento = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelLancamento = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lbDebitos = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.lbCreditos = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.lbTotalLanc = new DevExpress.XtraBars.BarStaticItem();
            this.barPartidas = new DevExpress.XtraBars.Bar();
            this.btnAddPartida = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditarPartida = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelPartida = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lookUpMatriz1 = new ITE.Components.LookUpMatriz();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditLancamento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditLancamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaContabilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(8, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(8, 115);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(425, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(586, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data";
            // 
            // dtEditLancamento
            // 
            this.dtEditLancamento.EditValue = null;
            this.dtEditLancamento.Location = new System.Drawing.Point(586, 115);
            this.dtEditLancamento.Name = "dtEditLancamento";
            this.dtEditLancamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditLancamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditLancamento.Size = new System.Drawing.Size(116, 20);
            this.dtEditLancamento.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gridControlPartidas);
            this.groupControl1.Controls.Add(this.standaloneBarDockControl1);
            this.groupControl1.Location = new System.Drawing.Point(8, 152);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(694, 384);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Partidas";
            // 
            // gridControlPartidas
            // 
            this.gridControlPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPartidas.DataSource = this.partidaContabilBindingSource;
            this.gridControlPartidas.Location = new System.Drawing.Point(5, 53);
            this.gridControlPartidas.MainView = this.gridViewPartidas;
            this.gridControlPartidas.MenuManager = this.barManager1;
            this.gridControlPartidas.Name = "gridControlPartidas";
            this.gridControlPartidas.Size = new System.Drawing.Size(684, 326);
            this.gridControlPartidas.TabIndex = 3;
            this.gridControlPartidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPartidas});
            // 
            // partidaContabilBindingSource
            // 
            this.partidaContabilBindingSource.DataSource = typeof(ITE.Entidades.POCO.Contabil.PartidaContabil);
            // 
            // gridViewPartidas
            // 
            this.gridViewPartidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPartida,
            this.colIdLancamentoContabil,
            this.colSequencialPartida,
            this.colIdCentroCusto,
            this.colContaContabilDeb,
            this.colContaContabilCred,
            this.colIdMoeda,
            this.colValorPartida,
            this.colIdMoeda2,
            this.colValorPartida2,
            this.colIdHistoricoPadrao,
            this.colHistorico,
            this.colIdCliFor,
            this.colLocalizacaoFisDoc,
            this.colLancamentoContabil,
            this.colCentroCusto,
            this.colContaContabilDebito,
            this.colContaContabilCredito,
            this.colMoedaPrincipal,
            this.colMoedaEstrangeira,
            this.colParticipante});
            this.gridViewPartidas.GridControl = this.gridControlPartidas;
            this.gridViewPartidas.Name = "gridViewPartidas";
            this.gridViewPartidas.OptionsBehavior.Editable = false;
            this.gridViewPartidas.OptionsView.ColumnAutoWidth = false;
            this.gridViewPartidas.OptionsView.ShowGroupPanel = false;
            this.gridViewPartidas.DoubleClick += new System.EventHandler(this.gridViewPartidas_DoubleClick);
            // 
            // colIdPartida
            // 
            this.colIdPartida.FieldName = "IdPartida";
            this.colIdPartida.Name = "colIdPartida";
            // 
            // colIdLancamentoContabil
            // 
            this.colIdLancamentoContabil.FieldName = "IdLancamentoContabil";
            this.colIdLancamentoContabil.Name = "colIdLancamentoContabil";
            // 
            // colSequencialPartida
            // 
            this.colSequencialPartida.Caption = "Item";
            this.colSequencialPartida.FieldName = "SequencialPartida";
            this.colSequencialPartida.Name = "colSequencialPartida";
            this.colSequencialPartida.Visible = true;
            this.colSequencialPartida.VisibleIndex = 0;
            this.colSequencialPartida.Width = 70;
            // 
            // colIdCentroCusto
            // 
            this.colIdCentroCusto.FieldName = "IdCentroCusto";
            this.colIdCentroCusto.Name = "colIdCentroCusto";
            // 
            // colContaContabilDeb
            // 
            this.colContaContabilDeb.Caption = "Desc. Débito";
            this.colContaContabilDeb.FieldName = "ContaContabilDebito.DescricaoContaContabil";
            this.colContaContabilDeb.Name = "colContaContabilDeb";
            this.colContaContabilDeb.Visible = true;
            this.colContaContabilDeb.VisibleIndex = 3;
            this.colContaContabilDeb.Width = 239;
            // 
            // colContaContabilCred
            // 
            this.colContaContabilCred.Caption = "Desc. Crédito";
            this.colContaContabilCred.FieldName = "ContaContabilCredito.DescricaoContaContabil";
            this.colContaContabilCred.Name = "colContaContabilCred";
            this.colContaContabilCred.Visible = true;
            this.colContaContabilCred.VisibleIndex = 5;
            this.colContaContabilCred.Width = 280;
            // 
            // colIdMoeda
            // 
            this.colIdMoeda.FieldName = "IdMoeda";
            this.colIdMoeda.Name = "colIdMoeda";
            // 
            // colValorPartida
            // 
            this.colValorPartida.Caption = "Valor";
            this.colValorPartida.DisplayFormat.FormatString = "N2";
            this.colValorPartida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorPartida.FieldName = "ValorPartida";
            this.colValorPartida.Name = "colValorPartida";
            this.colValorPartida.Visible = true;
            this.colValorPartida.VisibleIndex = 1;
            this.colValorPartida.Width = 129;
            // 
            // colIdMoeda2
            // 
            this.colIdMoeda2.FieldName = "IdMoeda2";
            this.colIdMoeda2.Name = "colIdMoeda2";
            // 
            // colValorPartida2
            // 
            this.colValorPartida2.FieldName = "ValorPartida2";
            this.colValorPartida2.Name = "colValorPartida2";
            // 
            // colIdHistoricoPadrao
            // 
            this.colIdHistoricoPadrao.FieldName = "IdHistoricoPadrao";
            this.colIdHistoricoPadrao.Name = "colIdHistoricoPadrao";
            // 
            // colHistorico
            // 
            this.colHistorico.Caption = "Histórico";
            this.colHistorico.FieldName = "Historico";
            this.colHistorico.Name = "colHistorico";
            this.colHistorico.Visible = true;
            this.colHistorico.VisibleIndex = 6;
            this.colHistorico.Width = 183;
            // 
            // colIdCliFor
            // 
            this.colIdCliFor.FieldName = "IdCliFor";
            this.colIdCliFor.Name = "colIdCliFor";
            // 
            // colLocalizacaoFisDoc
            // 
            this.colLocalizacaoFisDoc.Caption = "Local Documento";
            this.colLocalizacaoFisDoc.FieldName = "LocalizacaoFisDoc";
            this.colLocalizacaoFisDoc.Name = "colLocalizacaoFisDoc";
            this.colLocalizacaoFisDoc.Visible = true;
            this.colLocalizacaoFisDoc.VisibleIndex = 8;
            this.colLocalizacaoFisDoc.Width = 120;
            // 
            // colLancamentoContabil
            // 
            this.colLancamentoContabil.FieldName = "LancamentoContabil";
            this.colLancamentoContabil.Name = "colLancamentoContabil";
            // 
            // colCentroCusto
            // 
            this.colCentroCusto.Caption = "Centro de Custo";
            this.colCentroCusto.FieldName = "CentroCusto";
            this.colCentroCusto.Name = "colCentroCusto";
            this.colCentroCusto.Visible = true;
            this.colCentroCusto.VisibleIndex = 7;
            this.colCentroCusto.Width = 142;
            // 
            // colContaContabilDebito
            // 
            this.colContaContabilDebito.Caption = "Conta débito";
            this.colContaContabilDebito.FieldName = "ContaContabilDebito";
            this.colContaContabilDebito.Name = "colContaContabilDebito";
            this.colContaContabilDebito.Visible = true;
            this.colContaContabilDebito.VisibleIndex = 2;
            this.colContaContabilDebito.Width = 125;
            // 
            // colContaContabilCredito
            // 
            this.colContaContabilCredito.Caption = "Conta crédito";
            this.colContaContabilCredito.FieldName = "ContaContabilCredito";
            this.colContaContabilCredito.Name = "colContaContabilCredito";
            this.colContaContabilCredito.Visible = true;
            this.colContaContabilCredito.VisibleIndex = 4;
            this.colContaContabilCredito.Width = 129;
            // 
            // colMoedaPrincipal
            // 
            this.colMoedaPrincipal.FieldName = "MoedaPrincipal";
            this.colMoedaPrincipal.Name = "colMoedaPrincipal";
            this.colMoedaPrincipal.Width = 94;
            // 
            // colMoedaEstrangeira
            // 
            this.colMoedaEstrangeira.FieldName = "MoedaEstrangeira";
            this.colMoedaEstrangeira.Name = "colMoedaEstrangeira";
            this.colMoedaEstrangeira.Width = 110;
            // 
            // colParticipante
            // 
            this.colParticipante.Caption = "Participante";
            this.colParticipante.FieldName = "Participante";
            this.colParticipante.Name = "colParticipante";
            this.colParticipante.Visible = true;
            this.colParticipante.VisibleIndex = 9;
            this.colParticipante.Width = 138;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3,
            this.barPartidas});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNovoLancamento,
            this.btnSaveLancamento,
            this.btnDelLancamento,
            this.btnAddPartida,
            this.btnDelPartida,
            this.btnEditarPartida,
            this.barStaticItem1,
            this.lbDebitos,
            this.barStaticItem3,
            this.lbCreditos,
            this.barStaticItem2,
            this.lbTotalLanc,
            this.btnExportExcel});
            this.barManager1.MaxItemId = 13;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveLancamento),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelLancamento)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnNovoLancamento
            // 
            this.btnNovoLancamento.Caption = "Novo";
            this.btnNovoLancamento.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovoLancamento.Glyph")));
            this.btnNovoLancamento.Id = 0;
            this.btnNovoLancamento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNovoLancamento.LargeGlyph")));
            this.btnNovoLancamento.Name = "btnNovoLancamento";
            // 
            // btnSaveLancamento
            // 
            this.btnSaveLancamento.Caption = "Salvar";
            this.btnSaveLancamento.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaveLancamento.Glyph")));
            this.btnSaveLancamento.Id = 1;
            this.btnSaveLancamento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSaveLancamento.LargeGlyph")));
            this.btnSaveLancamento.Name = "btnSaveLancamento";
            this.btnSaveLancamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveLancamento_ItemClick);
            // 
            // btnDelLancamento
            // 
            this.btnDelLancamento.Caption = "Excluir";
            this.btnDelLancamento.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelLancamento.Glyph")));
            this.btnDelLancamento.Id = 2;
            this.btnDelLancamento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelLancamento.LargeGlyph")));
            this.btnDelLancamento.Name = "btnDelLancamento";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbDebitos),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbCreditos),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbTotalLanc)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Débitos:";
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbDebitos
            // 
            this.lbDebitos.Caption = "0,00";
            this.lbDebitos.Id = 7;
            this.lbDebitos.Name = "lbDebitos";
            this.lbDebitos.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Créditos:";
            this.barStaticItem3.Id = 8;
            this.barStaticItem3.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barStaticItem3.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbCreditos
            // 
            this.lbCreditos.Caption = "0,00";
            this.lbCreditos.Id = 9;
            this.lbCreditos.Name = "lbCreditos";
            this.lbCreditos.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Total lançamento:";
            this.barStaticItem2.Id = 10;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbTotalLanc
            // 
            this.lbTotalLanc.Caption = "0,00";
            this.lbTotalLanc.Id = 11;
            this.lbTotalLanc.Name = "lbTotalLanc";
            this.lbTotalLanc.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barPartidas
            // 
            this.barPartidas.BarName = "Custom 4";
            this.barPartidas.DockCol = 0;
            this.barPartidas.DockRow = 0;
            this.barPartidas.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barPartidas.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddPartida),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditarPartida),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelPartida),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportExcel)});
            this.barPartidas.OptionsBar.AllowQuickCustomization = false;
            this.barPartidas.OptionsBar.DisableClose = true;
            this.barPartidas.OptionsBar.DisableCustomization = true;
            this.barPartidas.OptionsBar.DrawDragBorder = false;
            this.barPartidas.OptionsBar.UseWholeRow = true;
            this.barPartidas.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.barPartidas.Text = "Custom 4";
            // 
            // btnAddPartida
            // 
            this.btnAddPartida.Caption = "Nova";
            this.btnAddPartida.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddPartida.Glyph")));
            this.btnAddPartida.Id = 3;
            this.btnAddPartida.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddPartida.LargeGlyph")));
            this.btnAddPartida.Name = "btnAddPartida";
            this.btnAddPartida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddPartida_ItemClick);
            // 
            // btnEditarPartida
            // 
            this.btnEditarPartida.Caption = "Editar partida";
            this.btnEditarPartida.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditarPartida.Glyph")));
            this.btnEditarPartida.Id = 5;
            this.btnEditarPartida.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditarPartida.LargeGlyph")));
            this.btnEditarPartida.Name = "btnEditarPartida";
            this.btnEditarPartida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditarPartida_ItemClick);
            // 
            // btnDelPartida
            // 
            this.btnDelPartida.Caption = "Excluir";
            this.btnDelPartida.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelPartida.Glyph")));
            this.btnDelPartida.Id = 4;
            this.btnDelPartida.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDelPartida.LargeGlyph")));
            this.btnDelPartida.Name = "btnDelPartida";
            this.btnDelPartida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelPartida_ItemClick);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Caption = "Exportar para excel";
            this.btnExportExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Glyph")));
            this.btnExportExcel.Id = 12;
            this.btnExportExcel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.LargeGlyph")));
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportExcel_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(4, 18);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(685, 31);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(711, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            this.barDockControlBottom.Size = new System.Drawing.Size(711, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 507);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(711, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 507);
            // 
            // lookUpMatriz1
            // 
            this.lookUpMatriz1.Filial = null;
            this.lookUpMatriz1.Location = new System.Drawing.Point(5, 39);
            this.lookUpMatriz1.Matriz = null;
            this.lookUpMatriz1.Name = "lookUpMatriz1";
            this.lookUpMatriz1.Size = new System.Drawing.Size(425, 51);
            this.lookUpMatriz1.TabIndex = 0;
            // 
            // XFrmAddLancamentoContabil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 563);
            this.Controls.Add(this.lookUpMatriz1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dtEditLancamento);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmAddLancamentoContabil";
            this.Text = "Novo lançamento:";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditLancamento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditLancamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaContabilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtEditLancamento;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlPartidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPartidas;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnNovoLancamento;
        private DevExpress.XtraBars.BarButtonItem btnSaveLancamento;
        private DevExpress.XtraBars.BarButtonItem btnDelLancamento;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar barPartidas;
        private DevExpress.XtraBars.BarButtonItem btnAddPartida;
        private DevExpress.XtraBars.BarButtonItem btnDelPartida;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnEditarPartida;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem lbDebitos;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem lbCreditos;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem lbTotalLanc;
        private DevExpress.XtraBars.BarButtonItem btnExportExcel;
        private System.Windows.Forms.BindingSource partidaContabilBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPartida;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLancamentoContabil;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencialPartida;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colContaContabilDeb;
        private DevExpress.XtraGrid.Columns.GridColumn colContaContabilCred;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoeda;
        private DevExpress.XtraGrid.Columns.GridColumn colValorPartida;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoeda2;
        private DevExpress.XtraGrid.Columns.GridColumn colValorPartida2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHistoricoPadrao;
        private DevExpress.XtraGrid.Columns.GridColumn colHistorico;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalizacaoFisDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colLancamentoContabil;
        private DevExpress.XtraGrid.Columns.GridColumn colCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colContaContabilDebito;
        private DevExpress.XtraGrid.Columns.GridColumn colContaContabilCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colMoedaPrincipal;
        private DevExpress.XtraGrid.Columns.GridColumn colMoedaEstrangeira;
        private DevExpress.XtraGrid.Columns.GridColumn colParticipante;
        private Components.LookUpMatriz lookUpMatriz1;
    }
}