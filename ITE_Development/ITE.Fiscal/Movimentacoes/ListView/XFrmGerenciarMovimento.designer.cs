namespace ITE.Fiscal.Movimentacoes.ListView
{
    partial class XFrmGerenciarMovimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmGerenciarMovimento));
            this.gridControlEntradas = new DevExpress.XtraGrid.GridControl();
            this.bsMovimento = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEntradas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCapa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliForEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataEmissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroNf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChaveAcessoNf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalNotaFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProdutos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorFrete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorBaseICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorBaseICMSST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorICMSST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorSeguro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorDespesasAcessorias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoNf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndicadorFrete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeloDocumentoFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacaoDocumentoFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotaFiscalItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacaoDocumentoFiscal1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescTpMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeLocEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsNotaFiscalCapa = new System.Windows.Forms.BindingSource(this.components);
            this.popupMenuIts = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnCancelarNF = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExcluirMov = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSelectColunm = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFilter = new DevExpress.XtraBars.BarButtonItem();
            this.barEditCheckBombo = new DevExpress.XtraBars.BarEditItem();
            this.cbTiposMovimento = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barMenuProcessos = new DevExpress.XtraBars.BarSubItem();
            this.barSubConversores = new DevExpress.XtraBars.BarSubItem();
            this.barConvPedCompraCotacao = new DevExpress.XtraBars.BarButtonItem();
            this.barConvCotacaoFaturamento = new DevExpress.XtraBars.BarButtonItem();
            this.barSubGerarNFe = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMenuNew = new DevExpress.XtraBars.BarSubItem();
            this.barBtnNewMovSimples = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNewMovFiscal = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransEstoque = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFitCol = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalCapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuIts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposMovimento)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlEntradas
            // 
            this.gridControlEntradas.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlEntradas.DataSource = this.bsMovimento;
            this.gridControlEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEntradas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlEntradas.Location = new System.Drawing.Point(0, 143);
            this.gridControlEntradas.MainView = this.gridViewEntradas;
            this.gridControlEntradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlEntradas.Name = "gridControlEntradas";
            this.gridControlEntradas.Size = new System.Drawing.Size(925, 322);
            this.gridControlEntradas.TabIndex = 1;
            this.gridControlEntradas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEntradas});
            this.gridControlEntradas.DoubleClick += new System.EventHandler(this.gridControlEntradas_DoubleClick);
            // 
            // bsMovimento
            // 
            this.bsMovimento.DataSource = typeof(ITE.Entidades.POCO.Fiscal.Movimento);
            // 
            // gridViewEntradas
            // 
            this.gridViewEntradas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCapa,
            this.colIdCliForEntrada,
            this.colCodMatriz,
            this.colCodFilial,
            this.colDataEntrada,
            this.colDataEmissao,
            this.colNumeroNf,
            this.colChaveAcessoNf,
            this.colTotalNotaFiscal,
            this.colTotalProdutos,
            this.colValorFrete,
            this.colValorDesconto,
            this.colValorBaseICMS,
            this.colValorICMS,
            this.colValorBaseICMSST,
            this.colValorICMSST,
            this.colValorSeguro,
            this.colValorDespesasAcessorias,
            this.colIdSituacao,
            this.colIdModelo,
            this.colTipoNf,
            this.colIndicadorFrete,
            this.colCliFor,
            this.colModeloDocumentoFiscal,
            this.colSituacaoDocumentoFiscal,
            this.colNotaFiscalItem,
            this.colSerie,
            this.colSituacaoDocumentoFiscal1,
            this.colSubSerie,
            this.colTipoMovimento,
            this.colIdTipoMovimento,
            this.colDescTpMovimento,
            this.colLocalEstoque,
            this.colNomeLocEstoque});
            this.gridViewEntradas.GridControl = this.gridControlEntradas;
            this.gridViewEntradas.Name = "gridViewEntradas";
            this.gridViewEntradas.OptionsBehavior.Editable = false;
            this.gridViewEntradas.OptionsSelection.MultiSelect = true;
            this.gridViewEntradas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewEntradas.OptionsView.ColumnAutoWidth = false;
            this.gridViewEntradas.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewEntradas.OptionsView.RowAutoHeight = true;
            this.gridViewEntradas.OptionsView.ShowGroupPanel = false;
            this.gridViewEntradas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataEntrada, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewEntradas.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridViewEntradas_MasterRowEmpty);
            this.gridViewEntradas.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridView1_MasterRowGetChildList);
            this.gridViewEntradas.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridViewEntradas_MasterRowGetRelationName);
            this.gridViewEntradas.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridViewEntradas_MasterRowGetRelationCount);
            // 
            // colIdCapa
            // 
            this.colIdCapa.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCapa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCapa.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCapa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCapa.Caption = "Id Movimento";
            this.colIdCapa.FieldName = "IdCapa";
            this.colIdCapa.Name = "colIdCapa";
            this.colIdCapa.Width = 71;
            // 
            // colIdCliForEntrada
            // 
            this.colIdCliForEntrada.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCliForEntrada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliForEntrada.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCliForEntrada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliForEntrada.FieldName = "IdCliForEntrada";
            this.colIdCliForEntrada.Name = "colIdCliForEntrada";
            this.colIdCliForEntrada.Width = 100;
            // 
            // colCodMatriz
            // 
            this.colCodMatriz.AppearanceCell.Options.UseTextOptions = true;
            this.colCodMatriz.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodMatriz.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodMatriz.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodMatriz.Caption = "Cód. Matriz";
            this.colCodMatriz.FieldName = "EmpresaFilial.Matriz.CodigoMatriz";
            this.colCodMatriz.Name = "colCodMatriz";
            this.colCodMatriz.Visible = true;
            this.colCodMatriz.VisibleIndex = 0;
            this.colCodMatriz.Width = 91;
            // 
            // colCodFilial
            // 
            this.colCodFilial.AppearanceCell.Options.UseTextOptions = true;
            this.colCodFilial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodFilial.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodFilial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodFilial.Caption = "Cód. Filial";
            this.colCodFilial.FieldName = "EmpresaFilial.CodigoFilial";
            this.colCodFilial.Name = "colCodFilial";
            this.colCodFilial.Visible = true;
            this.colCodFilial.VisibleIndex = 1;
            this.colCodFilial.Width = 99;
            // 
            // colDataEntrada
            // 
            this.colDataEntrada.AppearanceCell.Options.UseTextOptions = true;
            this.colDataEntrada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataEntrada.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataEntrada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataEntrada.Caption = "Dt. Entrada/Saída";
            this.colDataEntrada.FieldName = "DataEntrada";
            this.colDataEntrada.Name = "colDataEntrada";
            this.colDataEntrada.Visible = true;
            this.colDataEntrada.VisibleIndex = 4;
            this.colDataEntrada.Width = 131;
            // 
            // colDataEmissao
            // 
            this.colDataEmissao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataEmissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataEmissao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataEmissao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataEmissao.Caption = "Data Emissão";
            this.colDataEmissao.FieldName = "DataEmissao";
            this.colDataEmissao.Name = "colDataEmissao";
            this.colDataEmissao.Visible = true;
            this.colDataEmissao.VisibleIndex = 3;
            this.colDataEmissao.Width = 100;
            // 
            // colNumeroNf
            // 
            this.colNumeroNf.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroNf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroNf.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroNf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroNf.Caption = "Nº Movimento";
            this.colNumeroNf.FieldName = "NumeroMovimento";
            this.colNumeroNf.Name = "colNumeroNf";
            this.colNumeroNf.Visible = true;
            this.colNumeroNf.VisibleIndex = 5;
            this.colNumeroNf.Width = 139;
            // 
            // colChaveAcessoNf
            // 
            this.colChaveAcessoNf.AppearanceCell.Options.UseTextOptions = true;
            this.colChaveAcessoNf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colChaveAcessoNf.AppearanceHeader.Options.UseTextOptions = true;
            this.colChaveAcessoNf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colChaveAcessoNf.Caption = "Chave de acesso";
            this.colChaveAcessoNf.FieldName = "ChaveAcessoNf";
            this.colChaveAcessoNf.Name = "colChaveAcessoNf";
            this.colChaveAcessoNf.Width = 197;
            // 
            // colTotalNotaFiscal
            // 
            this.colTotalNotaFiscal.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalNotaFiscal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalNotaFiscal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalNotaFiscal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalNotaFiscal.Caption = "Total Movimento";
            this.colTotalNotaFiscal.DisplayFormat.FormatString = "N2";
            this.colTotalNotaFiscal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalNotaFiscal.FieldName = "TotalMovimento";
            this.colTotalNotaFiscal.GroupFormat.FormatString = "N2";
            this.colTotalNotaFiscal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalNotaFiscal.Name = "colTotalNotaFiscal";
            this.colTotalNotaFiscal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotalNotaFiscal.Visible = true;
            this.colTotalNotaFiscal.VisibleIndex = 6;
            this.colTotalNotaFiscal.Width = 105;
            // 
            // colTotalProdutos
            // 
            this.colTotalProdutos.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalProdutos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalProdutos.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalProdutos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalProdutos.FieldName = "TotalProdutos";
            this.colTotalProdutos.Name = "colTotalProdutos";
            this.colTotalProdutos.Width = 20;
            // 
            // colValorFrete
            // 
            this.colValorFrete.AppearanceCell.Options.UseTextOptions = true;
            this.colValorFrete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorFrete.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorFrete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorFrete.FieldName = "ValorFrete";
            this.colValorFrete.Name = "colValorFrete";
            this.colValorFrete.Width = 98;
            // 
            // colValorDesconto
            // 
            this.colValorDesconto.AppearanceCell.Options.UseTextOptions = true;
            this.colValorDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorDesconto.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorDesconto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorDesconto.FieldName = "ValorDesconto";
            this.colValorDesconto.Name = "colValorDesconto";
            this.colValorDesconto.Width = 20;
            // 
            // colValorBaseICMS
            // 
            this.colValorBaseICMS.AppearanceCell.Options.UseTextOptions = true;
            this.colValorBaseICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorBaseICMS.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorBaseICMS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorBaseICMS.FieldName = "ValorBaseICMS";
            this.colValorBaseICMS.Name = "colValorBaseICMS";
            this.colValorBaseICMS.Width = 20;
            // 
            // colValorICMS
            // 
            this.colValorICMS.AppearanceCell.Options.UseTextOptions = true;
            this.colValorICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorICMS.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorICMS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorICMS.FieldName = "ValorICMS";
            this.colValorICMS.Name = "colValorICMS";
            this.colValorICMS.Width = 67;
            // 
            // colValorBaseICMSST
            // 
            this.colValorBaseICMSST.AppearanceCell.Options.UseTextOptions = true;
            this.colValorBaseICMSST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorBaseICMSST.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorBaseICMSST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorBaseICMSST.FieldName = "ValorBaseICMSST";
            this.colValorBaseICMSST.Name = "colValorBaseICMSST";
            this.colValorBaseICMSST.Width = 20;
            // 
            // colValorICMSST
            // 
            this.colValorICMSST.AppearanceCell.Options.UseTextOptions = true;
            this.colValorICMSST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorICMSST.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorICMSST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorICMSST.FieldName = "ValorICMSST";
            this.colValorICMSST.Name = "colValorICMSST";
            this.colValorICMSST.Width = 26;
            // 
            // colValorSeguro
            // 
            this.colValorSeguro.AppearanceCell.Options.UseTextOptions = true;
            this.colValorSeguro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorSeguro.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorSeguro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorSeguro.FieldName = "ValorSeguro";
            this.colValorSeguro.Name = "colValorSeguro";
            this.colValorSeguro.Width = 20;
            // 
            // colValorDespesasAcessorias
            // 
            this.colValorDespesasAcessorias.AppearanceCell.Options.UseTextOptions = true;
            this.colValorDespesasAcessorias.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorDespesasAcessorias.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorDespesasAcessorias.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorDespesasAcessorias.FieldName = "ValorDespesasAcessorias";
            this.colValorDespesasAcessorias.Name = "colValorDespesasAcessorias";
            this.colValorDespesasAcessorias.Width = 26;
            // 
            // colIdSituacao
            // 
            this.colIdSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdSituacao.FieldName = "IdSituacao";
            this.colIdSituacao.Name = "colIdSituacao";
            this.colIdSituacao.Width = 20;
            // 
            // colIdModelo
            // 
            this.colIdModelo.AppearanceCell.Options.UseTextOptions = true;
            this.colIdModelo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdModelo.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdModelo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdModelo.FieldName = "IdModelo";
            this.colIdModelo.Name = "colIdModelo";
            this.colIdModelo.Width = 42;
            // 
            // colTipoNf
            // 
            this.colTipoNf.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoNf.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoNf.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoNf.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoNf.Caption = "Direção Movimento";
            this.colTipoNf.FieldName = "DirecaoMovimento";
            this.colTipoNf.Name = "colTipoNf";
            this.colTipoNf.Visible = true;
            this.colTipoNf.VisibleIndex = 7;
            this.colTipoNf.Width = 127;
            // 
            // colIndicadorFrete
            // 
            this.colIndicadorFrete.AppearanceCell.Options.UseTextOptions = true;
            this.colIndicadorFrete.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIndicadorFrete.AppearanceHeader.Options.UseTextOptions = true;
            this.colIndicadorFrete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIndicadorFrete.FieldName = "IndicadorFrete";
            this.colIndicadorFrete.Name = "colIndicadorFrete";
            this.colIndicadorFrete.Width = 20;
            // 
            // colCliFor
            // 
            this.colCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliFor.AppearanceHeader.Options.UseTextOptions = true;
            this.colCliFor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliFor.Caption = "Cliente/Fornecedor";
            this.colCliFor.FieldName = "CliFor.RazaoSocial";
            this.colCliFor.Name = "colCliFor";
            this.colCliFor.Visible = true;
            this.colCliFor.VisibleIndex = 2;
            this.colCliFor.Width = 235;
            // 
            // colModeloDocumentoFiscal
            // 
            this.colModeloDocumentoFiscal.AppearanceCell.Options.UseTextOptions = true;
            this.colModeloDocumentoFiscal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colModeloDocumentoFiscal.AppearanceHeader.Options.UseTextOptions = true;
            this.colModeloDocumentoFiscal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colModeloDocumentoFiscal.FieldName = "ModeloDocumentoFiscal";
            this.colModeloDocumentoFiscal.Name = "colModeloDocumentoFiscal";
            this.colModeloDocumentoFiscal.Width = 121;
            // 
            // colSituacaoDocumentoFiscal
            // 
            this.colSituacaoDocumentoFiscal.AppearanceCell.Options.UseTextOptions = true;
            this.colSituacaoDocumentoFiscal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSituacaoDocumentoFiscal.AppearanceHeader.Options.UseTextOptions = true;
            this.colSituacaoDocumentoFiscal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSituacaoDocumentoFiscal.FieldName = "SituacaoDocumentoFiscal.DescricaoSituacao";
            this.colSituacaoDocumentoFiscal.Name = "colSituacaoDocumentoFiscal";
            this.colSituacaoDocumentoFiscal.Width = 96;
            // 
            // colNotaFiscalItem
            // 
            this.colNotaFiscalItem.AppearanceCell.Options.UseTextOptions = true;
            this.colNotaFiscalItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNotaFiscalItem.AppearanceHeader.Options.UseTextOptions = true;
            this.colNotaFiscalItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNotaFiscalItem.FieldName = "NotaFiscalItem";
            this.colNotaFiscalItem.Name = "colNotaFiscalItem";
            this.colNotaFiscalItem.Width = 20;
            // 
            // colSerie
            // 
            this.colSerie.AppearanceCell.Options.UseTextOptions = true;
            this.colSerie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSerie.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            // 
            // colSituacaoDocumentoFiscal1
            // 
            this.colSituacaoDocumentoFiscal1.AppearanceCell.Options.UseTextOptions = true;
            this.colSituacaoDocumentoFiscal1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSituacaoDocumentoFiscal1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSituacaoDocumentoFiscal1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSituacaoDocumentoFiscal1.Caption = "Situação Doc. Fiscal";
            this.colSituacaoDocumentoFiscal1.FieldName = "SituacaoDocumentoFiscal";
            this.colSituacaoDocumentoFiscal1.Name = "colSituacaoDocumentoFiscal1";
            this.colSituacaoDocumentoFiscal1.Width = 141;
            // 
            // colSubSerie
            // 
            this.colSubSerie.AppearanceCell.Options.UseTextOptions = true;
            this.colSubSerie.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSubSerie.AppearanceHeader.Options.UseTextOptions = true;
            this.colSubSerie.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSubSerie.FieldName = "SubSerie";
            this.colSubSerie.Name = "colSubSerie";
            this.colSubSerie.Width = 110;
            // 
            // colTipoMovimento
            // 
            this.colTipoMovimento.Caption = "Cód. Movimento";
            this.colTipoMovimento.FieldName = "TipoMovimento.CodigoTipoMovimento";
            this.colTipoMovimento.Name = "colTipoMovimento";
            this.colTipoMovimento.Visible = true;
            this.colTipoMovimento.VisibleIndex = 8;
            this.colTipoMovimento.Width = 139;
            // 
            // colIdTipoMovimento
            // 
            this.colIdTipoMovimento.FieldName = "IdTipoMovimento";
            this.colIdTipoMovimento.Name = "colIdTipoMovimento";
            // 
            // colDescTpMovimento
            // 
            this.colDescTpMovimento.Caption = "Descrição Movimento";
            this.colDescTpMovimento.FieldName = "TipoMovimento.DescricaoTipoMovimento";
            this.colDescTpMovimento.Name = "colDescTpMovimento";
            this.colDescTpMovimento.Visible = true;
            this.colDescTpMovimento.VisibleIndex = 9;
            this.colDescTpMovimento.Width = 220;
            // 
            // colLocalEstoque
            // 
            this.colLocalEstoque.Caption = "Cód. Local de estoque";
            this.colLocalEstoque.FieldName = "LocalEstoque.CodigoLocalEstoque";
            this.colLocalEstoque.Name = "colLocalEstoque";
            this.colLocalEstoque.Visible = true;
            this.colLocalEstoque.VisibleIndex = 10;
            this.colLocalEstoque.Width = 127;
            // 
            // colNomeLocEstoque
            // 
            this.colNomeLocEstoque.Caption = "Local Estoque";
            this.colNomeLocEstoque.FieldName = "LocalEstoque.NomeLocalEstoque";
            this.colNomeLocEstoque.Name = "colNomeLocEstoque";
            this.colNomeLocEstoque.Visible = true;
            this.colNomeLocEstoque.VisibleIndex = 11;
            this.colNomeLocEstoque.Width = 235;
            // 
            // popupMenuIts
            // 
            this.popupMenuIts.Name = "popupMenuIts";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnCancelarNF,
            this.barBtnExcluirMov,
            this.barBtnSelectColunm,
            this.barBtnFilter,
            this.barEditCheckBombo,
            this.barBtnRefresh,
            this.barMenuProcessos,
            this.barConvPedCompraCotacao,
            this.barConvCotacaoFaturamento,
            this.barSubConversores,
            this.barSubGerarNFe,
            this.barBtnMenuNew,
            this.barBtnNewMovSimples,
            this.barBtnNewMovFiscal,
            this.barBtnFitCol,
            this.barStaticItem1,
            this.btnTransEstoque});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbTiposMovimento});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(925, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnCancelarNF
            // 
            this.barBtnCancelarNF.Caption = "Cancelar Movimento";
            this.barBtnCancelarNF.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelarNF.Glyph")));
            this.barBtnCancelarNF.Id = 2;
            this.barBtnCancelarNF.Name = "barBtnCancelarNF";
            this.barBtnCancelarNF.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCancelarNF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelarNotaFiscal_Click);
            // 
            // barBtnExcluirMov
            // 
            this.barBtnExcluirMov.Caption = "Excluir Registro";
            this.barBtnExcluirMov.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExcluirMov.Glyph")));
            this.barBtnExcluirMov.Id = 3;
            this.barBtnExcluirMov.Name = "barBtnExcluirMov";
            this.barBtnExcluirMov.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnSelectColunm
            // 
            this.barBtnSelectColunm.Caption = "Seletor de colunas";
            this.barBtnSelectColunm.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSelectColunm.Glyph")));
            this.barBtnSelectColunm.Id = 4;
            this.barBtnSelectColunm.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSelectColunm.LargeGlyph")));
            this.barBtnSelectColunm.Name = "barBtnSelectColunm";
            this.barBtnSelectColunm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barBtnSelectColunm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSelectColunm_ItemClick);
            // 
            // barBtnFilter
            // 
            this.barBtnFilter.Caption = "Construtor de filtro";
            this.barBtnFilter.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnFilter.Glyph")));
            this.barBtnFilter.Id = 5;
            this.barBtnFilter.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnFilter.LargeGlyph")));
            this.barBtnFilter.Name = "barBtnFilter";
            this.barBtnFilter.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barBtnFilter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFilter_ItemClick);
            // 
            // barEditCheckBombo
            // 
            this.barEditCheckBombo.Edit = this.cbTiposMovimento;
            this.barEditCheckBombo.EditWidth = 150;
            this.barEditCheckBombo.Glyph = ((System.Drawing.Image)(resources.GetObject("barEditCheckBombo.Glyph")));
            this.barEditCheckBombo.Id = 6;
            this.barEditCheckBombo.Name = "barEditCheckBombo";
            this.barEditCheckBombo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // cbTiposMovimento
            // 
            this.cbTiposMovimento.AllowMultiSelect = true;
            this.cbTiposMovimento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTiposMovimento.Name = "cbTiposMovimento";
            this.cbTiposMovimento.EditValueChanged += new System.EventHandler(this.cbTiposMovimento_EditValueChanged);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Atualizar";
            this.barBtnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.Glyph")));
            this.barBtnRefresh.Id = 7;
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // barMenuProcessos
            // 
            this.barMenuProcessos.Caption = "Processos";
            this.barMenuProcessos.Glyph = ((System.Drawing.Image)(resources.GetObject("barMenuProcessos.Glyph")));
            this.barMenuProcessos.Id = 8;
            this.barMenuProcessos.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barMenuProcessos.LargeGlyph")));
            this.barMenuProcessos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubConversores),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubGerarNFe)});
            this.barMenuProcessos.Name = "barMenuProcessos";
            this.barMenuProcessos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barSubConversores
            // 
            this.barSubConversores.Caption = "Conversão de Movimentos";
            this.barSubConversores.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubConversores.Glyph")));
            this.barSubConversores.Id = 12;
            this.barSubConversores.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSubConversores.LargeGlyph")));
            this.barSubConversores.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barConvPedCompraCotacao),
            new DevExpress.XtraBars.LinkPersistInfo(this.barConvCotacaoFaturamento)});
            this.barSubConversores.Name = "barSubConversores";
            // 
            // barConvPedCompraCotacao
            // 
            this.barConvPedCompraCotacao.Caption = "Pedido de compra -> Cotação";
            this.barConvPedCompraCotacao.Glyph = ((System.Drawing.Image)(resources.GetObject("barConvPedCompraCotacao.Glyph")));
            this.barConvPedCompraCotacao.Id = 10;
            this.barConvPedCompraCotacao.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barConvPedCompraCotacao.LargeGlyph")));
            this.barConvPedCompraCotacao.Name = "barConvPedCompraCotacao";
            // 
            // barConvCotacaoFaturamento
            // 
            this.barConvCotacaoFaturamento.Caption = "Cotação -> Faturamento/Nota Fiscal";
            this.barConvCotacaoFaturamento.Glyph = ((System.Drawing.Image)(resources.GetObject("barConvCotacaoFaturamento.Glyph")));
            this.barConvCotacaoFaturamento.Id = 11;
            this.barConvCotacaoFaturamento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barConvCotacaoFaturamento.LargeGlyph")));
            this.barConvCotacaoFaturamento.Name = "barConvCotacaoFaturamento";
            // 
            // barSubGerarNFe
            // 
            this.barSubGerarNFe.Caption = "Gerar Nota Fiscal Eletrônica (NF-e)";
            this.barSubGerarNFe.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubGerarNFe.Glyph")));
            this.barSubGerarNFe.Id = 13;
            this.barSubGerarNFe.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSubGerarNFe.LargeGlyph")));
            this.barSubGerarNFe.Name = "barSubGerarNFe";
            this.barSubGerarNFe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSubGerarXML_ItemClick);
            // 
            // barBtnMenuNew
            // 
            this.barBtnMenuNew.Caption = "Novo Movimento";
            this.barBtnMenuNew.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnMenuNew.Glyph")));
            this.barBtnMenuNew.Id = 14;
            this.barBtnMenuNew.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnNewMovSimples),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnNewMovFiscal),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTransEstoque)});
            this.barBtnMenuNew.Name = "barBtnMenuNew";
            this.barBtnMenuNew.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnNewMovSimples
            // 
            this.barBtnNewMovSimples.Caption = "Movimento Simples";
            this.barBtnNewMovSimples.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNewMovSimples.Glyph")));
            this.barBtnNewMovSimples.Id = 15;
            this.barBtnNewMovSimples.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnNewMovSimples.LargeGlyph")));
            this.barBtnNewMovSimples.Name = "barBtnNewMovSimples";
            this.barBtnNewMovSimples.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNewMovSimples_ItemClick);
            // 
            // barBtnNewMovFiscal
            // 
            this.barBtnNewMovFiscal.Caption = "Movimento Fiscal";
            this.barBtnNewMovFiscal.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNewMovFiscal.Glyph")));
            this.barBtnNewMovFiscal.Id = 16;
            this.barBtnNewMovFiscal.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnNewMovFiscal.LargeGlyph")));
            this.barBtnNewMovFiscal.Name = "barBtnNewMovFiscal";
            this.barBtnNewMovFiscal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddNf_ItemClick);
            // 
            // btnTransEstoque
            // 
            this.btnTransEstoque.Caption = "Transf. entre Locais de Estoque";
            this.btnTransEstoque.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTransEstoque.Glyph")));
            this.btnTransEstoque.Id = 23;
            this.btnTransEstoque.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTransEstoque.LargeGlyph")));
            this.btnTransEstoque.Name = "btnTransEstoque";
            this.btnTransEstoque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barBtnFitCol
            // 
            this.barBtnFitCol.Caption = "Ajustar colunas";
            this.barBtnFitCol.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnFitCol.Glyph")));
            this.barBtnFitCol.Id = 17;
            this.barBtnFitCol.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnFitCol.LargeGlyph")));
            this.barBtnFitCol.Name = "barBtnFitCol";
            this.barBtnFitCol.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barBtnFitCol.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFitCol_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "      Tipo Movimento";
            this.barStaticItem1.Id = 21;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Movimento";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnMenuNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCancelarNF);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnExcluirMov);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.barMenuProcessos);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Operações";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnSelectColunm);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnFilter);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnFitCol);
            this.ribbonPageGroup2.ItemLinks.Add(this.barStaticItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barEditCheckBombo);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Utilitários/Filtros";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 465);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(925, 31);
            // 
            // XFrmGerenciarMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 496);
            this.Controls.Add(this.gridControlEntradas);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmGerenciarMovimento";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Movimentações:";
            this.Shown += new System.EventHandler(this.XFrmGerenciarEntrada_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalCapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuIts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTiposMovimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEntradas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntradas;
        private System.Windows.Forms.BindingSource bsNotaFiscalCapa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCapa;
        private DevExpress.XtraGrid.Columns.GridColumn colCodMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colDataEmissao;
        private DevExpress.XtraGrid.Columns.GridColumn colChaveAcessoNf;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalNotaFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn colValorFrete;
        private DevExpress.XtraGrid.Columns.GridColumn colValorDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorBaseICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colValorICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colValorBaseICMSST;
        private DevExpress.XtraGrid.Columns.GridColumn colValorICMSST;
        private DevExpress.XtraGrid.Columns.GridColumn colValorSeguro;
        private DevExpress.XtraGrid.Columns.GridColumn colValorDespesasAcessorias;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoNf;
        private DevExpress.XtraGrid.Columns.GridColumn colIndicadorFrete;
        private DevExpress.XtraGrid.Columns.GridColumn colCodFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colModeloDocumentoFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacaoDocumentoFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colNotaFiscalItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroNf;
        private DevExpress.XtraGrid.Columns.GridColumn colDataEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliForEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacaoDocumentoFiscal1;
        private DevExpress.XtraGrid.Columns.GridColumn colSubSerie;
        private DevExpress.XtraBars.PopupMenu popupMenuIts;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelarNF;
        private DevExpress.XtraBars.BarButtonItem barBtnExcluirMov;
        private DevExpress.XtraBars.BarButtonItem barBtnSelectColunm;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtnFilter;
        private DevExpress.XtraBars.BarEditItem barEditCheckBombo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit cbTiposMovimento;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescTpMovimento;
        private DevExpress.XtraBars.BarSubItem barMenuProcessos;
        private DevExpress.XtraBars.BarSubItem barSubConversores;
        private DevExpress.XtraBars.BarButtonItem barConvPedCompraCotacao;
        private DevExpress.XtraBars.BarButtonItem barConvCotacaoFaturamento;
        private DevExpress.XtraBars.BarButtonItem barSubGerarNFe;
        private System.Windows.Forms.BindingSource bsMovimento;
        private DevExpress.XtraBars.BarSubItem barBtnMenuNew;
        private DevExpress.XtraBars.BarButtonItem barBtnNewMovSimples;
        private DevExpress.XtraBars.BarButtonItem barBtnNewMovFiscal;
        private DevExpress.XtraBars.BarButtonItem barBtnFitCol;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeLocEstoque;
        private DevExpress.XtraBars.BarButtonItem btnTransEstoque;
    }
}