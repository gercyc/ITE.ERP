using ITE.Components.LookUp;

namespace ITE.Fiscal.Movimentacoes.OutrasMovimentacoes
{
    partial class XFrmPedidoCompraCotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmPedidoCompraCotacao));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tbLayoutPanelPai = new System.Windows.Forms.TableLayoutPanel();
            this.btnValoresView = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navCabecalho = new DevExpress.XtraNavBar.NavBarItem();
            this.navItensNf = new DevExpress.XtraNavBar.NavBarItem();
            this.navValores = new DevExpress.XtraNavBar.NavBarItem();
            this.navInfoFrete = new DevExpress.XtraNavBar.NavBarItem();
            this.navInfoObservacoes = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItgFinanceira = new DevExpress.XtraNavBar.NavBarItem();
            this.navItgContabFiscal = new DevExpress.XtraNavBar.NavBarItem();
            this.xTraTabNF = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabCabecalho = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubSerie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.rdTipoNf = new DevExpress.XtraEditors.RadioGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtNumNf = new DevExpress.XtraEditors.TextEdit();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.lookUpMatrizFilial1 = new ITE.Components.LookUpMatrizFilial();
            this.lookUpTipoMovimento1 = new ITE.Components.LookUpTipoMovimento();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpCliFor1 = new LookUpCliFor();
            this.xtraTabItensNF = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlItensNF = new DevExpress.XtraGrid.GridControl();
            this.bsNotaFiscalItem = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewItensNF = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSequencialItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCfop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegraFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabValores = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrDespesas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrSeguro = new DevExpress.XtraEditors.TextEdit();
            this.btnCalcNf = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrTotalNf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrDesconto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrFrete = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabItgFinanceira = new DevExpress.XtraTab.XtraTabPage();
            this.chkGerarFat = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpFormaPagamento1 = new ITE.Components.LookUpFormaPagamento();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlParcelas = new DevExpress.XtraGrid.GridControl();
            this.lancamentoFinanceiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewParcelas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorJuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoCancelamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCancelamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasPrazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencialParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnexos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaixas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtratos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNotaFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotaFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioRecCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecModifyBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioRecModifyBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageNatureza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabFrete = new DevExpress.XtraTab.XtraTabPage();
            this.rdTipoFrete = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabObserv = new DevExpress.XtraTab.XtraTabPage();
            this.memoEditObservacoes = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabIntContabFiscal = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpLocalEstoque1 = new ITE.Components.LookUpLocalEstoque();
            this.lookUpCentroCusto1 = new ITE.Components.LookUpCentroCusto();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnEditNF = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.bsFormaPagamento = new System.Windows.Forms.BindingSource(this.components);
            this.bsEmpresaFilial = new System.Windows.Forms.BindingSource(this.components);
            this.bsEmpresaMatriz = new System.Windows.Forms.BindingSource(this.components);
            this.bsItemEntrada = new System.Windows.Forms.BindingSource(this.components);
            this.bsCliFor = new System.Windows.Forms.BindingSource(this.components);
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnAddItem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditarItem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRemoveItem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizarDados = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.lbMensagem = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tbLayoutPanelPai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnValoresView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTraTabNF)).BeginInit();
            this.xTraTabNF.SuspendLayout();
            this.xtraTabCabecalho.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoNf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.xtraTabItensNF.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItensNF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensNF)).BeginInit();
            this.xtraTabValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrDespesas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrSeguro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotalNf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrFrete.Properties)).BeginInit();
            this.xtraTabItgFinanceira.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkGerarFat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoFinanceiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParcelas)).BeginInit();
            this.xtraTabFrete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoFrete.Properties)).BeginInit();
            this.xtraTabObserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditObservacoes.Properties)).BeginInit();
            this.xtraTabIntContabFiscal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaFilial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tbLayoutPanelPai);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(919, 513);
            this.panelControl1.TabIndex = 0;
            // 
            // tbLayoutPanelPai
            // 
            this.tbLayoutPanelPai.ColumnCount = 2;
            this.tbLayoutPanelPai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.17666F));
            this.tbLayoutPanelPai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.82333F));
            this.tbLayoutPanelPai.Controls.Add(this.btnValoresView, 0, 0);
            this.tbLayoutPanelPai.Controls.Add(this.xTraTabNF, 1, 0);
            this.tbLayoutPanelPai.Controls.Add(this.panelControl4, 1, 1);
            this.tbLayoutPanelPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutPanelPai.Location = new System.Drawing.Point(2, 2);
            this.tbLayoutPanelPai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLayoutPanelPai.Name = "tbLayoutPanelPai";
            this.tbLayoutPanelPai.RowCount = 2;
            this.tbLayoutPanelPai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPanelPai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tbLayoutPanelPai.Size = new System.Drawing.Size(915, 509);
            this.tbLayoutPanelPai.TabIndex = 6;
            // 
            // btnValoresView
            // 
            this.btnValoresView.ActiveGroup = this.navBarGroup1;
            this.btnValoresView.Appearance.GroupHeader.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnValoresView.Appearance.GroupHeader.Options.UseFont = true;
            this.btnValoresView.Appearance.Item.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnValoresView.Appearance.Item.Options.UseFont = true;
            this.btnValoresView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValoresView.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.btnValoresView.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navCabecalho,
            this.navItensNf,
            this.navValores,
            this.navInfoFrete,
            this.navItgFinanceira,
            this.navInfoObservacoes,
            this.navItgContabFiscal});
            this.btnValoresView.Location = new System.Drawing.Point(3, 3);
            this.btnValoresView.Name = "btnValoresView";
            this.btnValoresView.OptionsNavPane.ExpandedWidth = 123;
            this.btnValoresView.Size = new System.Drawing.Size(123, 464);
            this.btnValoresView.TabIndex = 0;
            this.btnValoresView.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Caption = "Sessões";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCabecalho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItensNf),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navValores),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navInfoFrete),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navInfoObservacoes)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navCabecalho
            // 
            this.navCabecalho.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.navCabecalho.Appearance.Options.UseFont = true;
            this.navCabecalho.Caption = "Cabeçalho";
            this.navCabecalho.Name = "navCabecalho";
            this.navCabecalho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnCabecalhoView_LinkClicked);
            // 
            // navItensNf
            // 
            this.navItensNf.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.navItensNf.Appearance.Options.UseFont = true;
            this.navItensNf.Caption = "Itens";
            this.navItensNf.Name = "navItensNf";
            this.navItensNf.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnItensView_LinkClicked);
            // 
            // navValores
            // 
            this.navValores.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.navValores.Appearance.Options.UseFont = true;
            this.navValores.Caption = "Valores";
            this.navValores.Name = "navValores";
            this.navValores.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem3_LinkClicked);
            // 
            // navInfoFrete
            // 
            this.navInfoFrete.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.navInfoFrete.Appearance.Options.UseFont = true;
            this.navInfoFrete.Caption = "Frete";
            this.navInfoFrete.Name = "navInfoFrete";
            this.navInfoFrete.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navInfoFrete_LinkClicked);
            // 
            // navInfoObservacoes
            // 
            this.navInfoObservacoes.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.navInfoObservacoes.Appearance.Options.UseFont = true;
            this.navInfoObservacoes.Caption = "Observações";
            this.navInfoObservacoes.Name = "navInfoObservacoes";
            this.navInfoObservacoes.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navInfoObservacoes_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.Caption = "Integrações";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItgFinanceira),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItgContabFiscal)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navItgFinanceira
            // 
            this.navItgFinanceira.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.navItgFinanceira.Appearance.Options.UseFont = true;
            this.navItgFinanceira.Caption = "Financeira";
            this.navItgFinanceira.Name = "navItgFinanceira";
            this.navItgFinanceira.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItgFinanceira_LinkClicked);
            // 
            // navItgContabFiscal
            // 
            this.navItgContabFiscal.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.navItgContabFiscal.Appearance.Options.UseFont = true;
            this.navItgContabFiscal.Caption = "Contábil/Fiscal";
            this.navItgContabFiscal.Name = "navItgContabFiscal";
            this.navItgContabFiscal.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navItgContabFiscal_LinkClicked);
            // 
            // xTraTabNF
            // 
            this.xTraTabNF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xTraTabNF.Location = new System.Drawing.Point(132, 3);
            this.xTraTabNF.Name = "xTraTabNF";
            this.xTraTabNF.SelectedTabPage = this.xtraTabCabecalho;
            this.xTraTabNF.Size = new System.Drawing.Size(780, 464);
            this.xTraTabNF.TabIndex = 3;
            this.xTraTabNF.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabCabecalho,
            this.xtraTabItensNF,
            this.xtraTabValores,
            this.xtraTabItgFinanceira,
            this.xtraTabFrete,
            this.xtraTabObserv,
            this.xtraTabIntContabFiscal,
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabCabecalho
            // 
            this.xtraTabCabecalho.Controls.Add(this.tableLayoutPanel1);
            this.xtraTabCabecalho.Name = "xtraTabCabecalho";
            this.xtraTabCabecalho.Size = new System.Drawing.Size(774, 436);
            this.xtraTabCabecalho.Text = "Cabeçalho";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6055F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3945F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 436);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.tableLayoutPanel3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(768, 218);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Informações Básicas";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.panelControl2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lookUpMatrizFilial1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lookUpTipoMovimento1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 23);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.64249F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.35751F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(764, 193);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.txtSubSerie);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txtSerie);
            this.panelControl2.Controls.Add(this.rdTipoNf);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.dtEntrada);
            this.panelControl2.Controls.Add(this.txtNumNf);
            this.panelControl2.Controls.Add(this.dtEmissao);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(384, 65);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(381, 126);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(186, 58);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Sub Serie";
            // 
            // txtSubSerie
            // 
            this.txtSubSerie.Location = new System.Drawing.Point(186, 79);
            this.txtSubSerie.Name = "txtSubSerie";
            this.txtSubSerie.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSubSerie.Properties.Appearance.Options.UseFont = true;
            this.txtSubSerie.Size = new System.Drawing.Size(73, 20);
            this.txtSubSerie.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(120, 58);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(120, 79);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSerie.Properties.Appearance.Options.UseFont = true;
            this.txtSerie.Size = new System.Drawing.Size(60, 20);
            this.txtSerie.TabIndex = 6;
            // 
            // rdTipoNf
            // 
            this.rdTipoNf.Enabled = false;
            this.rdTipoNf.Location = new System.Drawing.Point(265, 14);
            this.rdTipoNf.MenuManager = this.barManager1;
            this.rdTipoNf.Name = "rdTipoNf";
            this.rdTipoNf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rdTipoNf.Properties.Appearance.Options.UseFont = true;
            this.rdTipoNf.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("E", "Entrada"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Saída")});
            this.rdTipoNf.Properties.ReadOnly = true;
            this.rdTipoNf.Size = new System.Drawing.Size(98, 85);
            this.rdTipoNf.TabIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(919, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 513);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(919, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 513);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(919, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 513);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(3, 2);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(768, 32);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data Emissão";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(124, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data Entrada";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Número:";
            // 
            // dtEntrada
            // 
            this.dtEntrada.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntrada.Location = new System.Drawing.Point(124, 25);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(98, 22);
            this.dtEntrada.TabIndex = 3;
            // 
            // txtNumNf
            // 
            this.txtNumNf.Location = new System.Drawing.Point(5, 79);
            this.txtNumNf.Name = "txtNumNf";
            this.txtNumNf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumNf.Properties.Appearance.Options.UseFont = true;
            this.txtNumNf.Size = new System.Drawing.Size(102, 20);
            this.txtNumNf.TabIndex = 4;
            // 
            // dtEmissao
            // 
            this.dtEmissao.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmissao.Location = new System.Drawing.Point(5, 24);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(98, 22);
            this.dtEmissao.TabIndex = 2;
            // 
            // lookUpMatrizFilial1
            // 
            this.lookUpMatrizFilial1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lookUpMatrizFilial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpMatrizFilial1.Filial = null;
            this.lookUpMatrizFilial1.Location = new System.Drawing.Point(3, 66);
            this.lookUpMatrizFilial1.Matriz = null;
            this.lookUpMatrizFilial1.Name = "lookUpMatrizFilial1";
            this.lookUpMatrizFilial1.Size = new System.Drawing.Size(375, 124);
            this.lookUpMatrizFilial1.TabIndex = 2;
            // 
            // lookUpTipoMovimento1
            // 
            this.lookUpTipoMovimento1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lookUpTipoMovimento1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpTipoMovimento1.Location = new System.Drawing.Point(3, 3);
            this.lookUpTipoMovimento1.Name = "lookUpTipoMovimento1";
            this.lookUpTipoMovimento1.Size = new System.Drawing.Size(375, 57);
            this.lookUpTipoMovimento1.TabIndex = 3;
            this.lookUpTipoMovimento1.TipoMovimento = null;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.lbMensagem);
            this.groupControl2.Controls.Add(this.lookUpCliFor1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 227);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(768, 206);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Informaçõe Fornecedor";
            // 
            // lookUpCliFor1
            // 
            this.lookUpCliFor1.CliFor = null;
            this.lookUpCliFor1.Filial = null;
            this.lookUpCliFor1.LabelText = "Cliente/Fornecedor:";
            this.lookUpCliFor1.Location = new System.Drawing.Point(5, 26);
            this.lookUpCliFor1.Matriz = null;
            this.lookUpCliFor1.Name = "lookUpCliFor1";
            this.lookUpCliFor1.Size = new System.Drawing.Size(576, 48);
            this.lookUpCliFor1.TabIndex = 0;
            // 
            // xtraTabItensNF
            // 
            this.xtraTabItensNF.Controls.Add(this.tableLayoutPanel2);
            this.xtraTabItensNF.Name = "xtraTabItensNF";
            this.xtraTabItensNF.Size = new System.Drawing.Size(774, 436);
            this.xtraTabItensNF.Text = "Itens";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.standaloneBarDockControl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 436);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.gridControlItensNF);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 40);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(768, 393);
            this.groupControl3.TabIndex = 10;
            this.groupControl3.Text = "NF: Itens";
            // 
            // gridControlItensNF
            // 
            this.gridControlItensNF.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlItensNF.DataSource = this.bsNotaFiscalItem;
            this.gridControlItensNF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlItensNF.Location = new System.Drawing.Point(2, 23);
            this.gridControlItensNF.MainView = this.gridViewItensNF;
            this.gridControlItensNF.Name = "gridControlItensNF";
            this.gridControlItensNF.Size = new System.Drawing.Size(764, 368);
            this.gridControlItensNF.TabIndex = 1;
            this.gridControlItensNF.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItensNF});
            // 
            // bsNotaFiscalItem
            // 
            this.bsNotaFiscalItem.DataSource = typeof(ITE.Entidades.POCO.Fiscal.ItemMovimento);
            // 
            // gridViewItensNF
            // 
            this.gridViewItensNF.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSequencialItem,
            this.colProduto,
            this.colCfop,
            this.colQuantidade,
            this.colValorUnitario,
            this.colValorDesconto,
            this.colTotalItem,
            this.colRegraFiscal,
            this.colIdProduto});
            this.gridViewItensNF.GridControl = this.gridControlItensNF;
            this.gridViewItensNF.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalItem", this.colTotalItem, "(Total produtos: {0:0.##})")});
            this.gridViewItensNF.Name = "gridViewItensNF";
            this.gridViewItensNF.OptionsBehavior.Editable = false;
            this.gridViewItensNF.OptionsView.ColumnAutoWidth = false;
            this.gridViewItensNF.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewItensNF.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewItensNF.OptionsView.ShowFooter = true;
            this.gridViewItensNF.OptionsView.ShowGroupPanel = false;
            // 
            // colSequencialItem
            // 
            this.colSequencialItem.AppearanceCell.Options.UseTextOptions = true;
            this.colSequencialItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSequencialItem.Caption = "Seq. Item";
            this.colSequencialItem.FieldName = "SequencialItem";
            this.colSequencialItem.Name = "colSequencialItem";
            this.colSequencialItem.Visible = true;
            this.colSequencialItem.VisibleIndex = 0;
            this.colSequencialItem.Width = 81;
            // 
            // colProduto
            // 
            this.colProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProduto.Caption = "Desc. Produto";
            this.colProduto.FieldName = "Produto.DescricaoProduto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Visible = true;
            this.colProduto.VisibleIndex = 2;
            this.colProduto.Width = 155;
            // 
            // colCfop
            // 
            this.colCfop.AppearanceCell.Options.UseTextOptions = true;
            this.colCfop.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCfop.FieldName = "Cfop";
            this.colCfop.Name = "colCfop";
            // 
            // colQuantidade
            // 
            this.colQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 3;
            this.colQuantidade.Width = 90;
            // 
            // colValorUnitario
            // 
            this.colValorUnitario.AppearanceCell.Options.UseTextOptions = true;
            this.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorUnitario.FieldName = "ValorUnitario";
            this.colValorUnitario.Name = "colValorUnitario";
            this.colValorUnitario.Visible = true;
            this.colValorUnitario.VisibleIndex = 4;
            this.colValorUnitario.Width = 103;
            // 
            // colValorDesconto
            // 
            this.colValorDesconto.AppearanceCell.Options.UseTextOptions = true;
            this.colValorDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorDesconto.FieldName = "ValorDesconto";
            this.colValorDesconto.Name = "colValorDesconto";
            this.colValorDesconto.Visible = true;
            this.colValorDesconto.VisibleIndex = 5;
            this.colValorDesconto.Width = 111;
            // 
            // colTotalItem
            // 
            this.colTotalItem.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalItem.FieldName = "TotalItem";
            this.colTotalItem.Name = "colTotalItem";
            this.colTotalItem.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalItem", "{0:0.##.00}")});
            this.colTotalItem.Visible = true;
            this.colTotalItem.VisibleIndex = 6;
            this.colTotalItem.Width = 84;
            // 
            // colRegraFiscal
            // 
            this.colRegraFiscal.Caption = "Regra fiscal";
            this.colRegraFiscal.FieldName = "RegraFiscal";
            this.colRegraFiscal.Name = "colRegraFiscal";
            this.colRegraFiscal.Width = 92;
            // 
            // colIdProduto
            // 
            this.colIdProduto.FieldName = "IdProduto";
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.Visible = true;
            this.colIdProduto.VisibleIndex = 1;
            // 
            // xtraTabValores
            // 
            this.xtraTabValores.Controls.Add(this.groupControl4);
            this.xtraTabValores.Name = "xtraTabValores";
            this.xtraTabValores.Size = new System.Drawing.Size(774, 436);
            this.xtraTabValores.Text = "Valores";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.labelControl20);
            this.groupControl4.Controls.Add(this.txtVlrDespesas);
            this.groupControl4.Controls.Add(this.labelControl19);
            this.groupControl4.Controls.Add(this.txtVlrSeguro);
            this.groupControl4.Controls.Add(this.btnCalcNf);
            this.groupControl4.Controls.Add(this.labelControl12);
            this.groupControl4.Controls.Add(this.txtVlrTotalNf);
            this.groupControl4.Controls.Add(this.labelControl11);
            this.groupControl4.Controls.Add(this.txtVlrDesconto);
            this.groupControl4.Controls.Add(this.labelControl10);
            this.groupControl4.Controls.Add(this.txtVlrFrete);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(774, 436);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Valores";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl20.Appearance.Options.UseFont = true;
            this.labelControl20.Location = new System.Drawing.Point(334, 96);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(113, 14);
            this.labelControl20.TabIndex = 10;
            this.labelControl20.Text = "Despesas Acessórias:";
            // 
            // txtVlrDespesas
            // 
            this.txtVlrDespesas.Location = new System.Drawing.Point(334, 119);
            this.txtVlrDespesas.Name = "txtVlrDespesas";
            this.txtVlrDespesas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrDespesas.Properties.Appearance.Options.UseFont = true;
            this.txtVlrDespesas.Size = new System.Drawing.Size(147, 20);
            this.txtVlrDespesas.TabIndex = 9;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(334, 35);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(90, 14);
            this.labelControl19.TabIndex = 8;
            this.labelControl19.Text = "Valor do seguro:";
            // 
            // txtVlrSeguro
            // 
            this.txtVlrSeguro.Location = new System.Drawing.Point(334, 58);
            this.txtVlrSeguro.Name = "txtVlrSeguro";
            this.txtVlrSeguro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrSeguro.Properties.Appearance.Options.UseFont = true;
            this.txtVlrSeguro.Size = new System.Drawing.Size(147, 20);
            this.txtVlrSeguro.TabIndex = 7;
            // 
            // btnCalcNf
            // 
            this.btnCalcNf.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnCalcNf.Appearance.Options.UseFont = true;
            this.btnCalcNf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcNf.ImageOptions.Image")));
            this.btnCalcNf.Location = new System.Drawing.Point(532, 379);
            this.btnCalcNf.Name = "btnCalcNf";
            this.btnCalcNf.Size = new System.Drawing.Size(142, 34);
            this.btnCalcNf.TabIndex = 6;
            this.btnCalcNf.Text = "Calcular Totais";
            this.btnCalcNf.Click += new System.EventHandler(this.btnCalcNf_Click);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(28, 288);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(95, 14);
            this.labelControl12.TabIndex = 5;
            this.labelControl12.Text = "Valor Movimento:";
            // 
            // txtVlrTotalNf
            // 
            this.txtVlrTotalNf.Location = new System.Drawing.Point(28, 311);
            this.txtVlrTotalNf.Name = "txtVlrTotalNf";
            this.txtVlrTotalNf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrTotalNf.Properties.Appearance.Options.UseFont = true;
            this.txtVlrTotalNf.Size = new System.Drawing.Size(199, 20);
            this.txtVlrTotalNf.TabIndex = 4;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(28, 96);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(104, 14);
            this.labelControl11.TabIndex = 3;
            this.labelControl11.Text = "Valor do desconto:";
            // 
            // txtVlrDesconto
            // 
            this.txtVlrDesconto.Location = new System.Drawing.Point(28, 119);
            this.txtVlrDesconto.Name = "txtVlrDesconto";
            this.txtVlrDesconto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtVlrDesconto.Size = new System.Drawing.Size(147, 20);
            this.txtVlrDesconto.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(28, 35);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(82, 14);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "Valor do Frete:";
            // 
            // txtVlrFrete
            // 
            this.txtVlrFrete.Location = new System.Drawing.Point(28, 58);
            this.txtVlrFrete.Name = "txtVlrFrete";
            this.txtVlrFrete.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrFrete.Properties.Appearance.Options.UseFont = true;
            this.txtVlrFrete.Size = new System.Drawing.Size(147, 20);
            this.txtVlrFrete.TabIndex = 0;
            // 
            // xtraTabItgFinanceira
            // 
            this.xtraTabItgFinanceira.Controls.Add(this.chkGerarFat);
            this.xtraTabItgFinanceira.Controls.Add(this.lookUpFormaPagamento1);
            this.xtraTabItgFinanceira.Controls.Add(this.groupControl7);
            this.xtraTabItgFinanceira.Name = "xtraTabItgFinanceira";
            this.xtraTabItgFinanceira.Size = new System.Drawing.Size(774, 436);
            this.xtraTabItgFinanceira.Text = "Intg. Financeira";
            // 
            // chkGerarFat
            // 
            this.chkGerarFat.Location = new System.Drawing.Point(16, 33);
            this.chkGerarFat.MenuManager = this.barManager1;
            this.chkGerarFat.Name = "chkGerarFat";
            this.chkGerarFat.Properties.Caption = "Gerar faturamento?";
            this.chkGerarFat.Properties.ReadOnly = true;
            this.chkGerarFat.Size = new System.Drawing.Size(133, 19);
            this.chkGerarFat.TabIndex = 6;
            // 
            // lookUpFormaPagamento1
            // 
            this.lookUpFormaPagamento1.FormaPagto = null;
            this.lookUpFormaPagamento1.Location = new System.Drawing.Point(443, 16);
            this.lookUpFormaPagamento1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpFormaPagamento1.Name = "lookUpFormaPagamento1";
            this.lookUpFormaPagamento1.Size = new System.Drawing.Size(328, 49);
            this.lookUpFormaPagamento1.TabIndex = 5;
            // 
            // groupControl7
            // 
            this.groupControl7.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupControl7.AppearanceCaption.Options.UseFont = true;
            this.groupControl7.Controls.Add(this.gridControlParcelas);
            this.groupControl7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl7.Location = new System.Drawing.Point(0, 81);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(774, 355);
            this.groupControl7.TabIndex = 3;
            this.groupControl7.Text = "Parcelas";
            // 
            // gridControlParcelas
            // 
            this.gridControlParcelas.DataSource = this.lancamentoFinanceiroBindingSource;
            this.gridControlParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlParcelas.Location = new System.Drawing.Point(2, 20);
            this.gridControlParcelas.MainView = this.gridViewParcelas;
            this.gridControlParcelas.MenuManager = this.barManager1;
            this.gridControlParcelas.Name = "gridControlParcelas";
            this.gridControlParcelas.Size = new System.Drawing.Size(770, 333);
            this.gridControlParcelas.TabIndex = 3;
            this.gridControlParcelas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewParcelas});
            // 
            // lancamentoFinanceiroBindingSource
            // 
            this.lancamentoFinanceiroBindingSource.DataSource = typeof(ITE.Entidades.POCO.Financeiro.LancamentoFinanceiro);
            // 
            // gridViewParcelas
            // 
            this.gridViewParcelas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLancamento,
            this.colDataLancamento,
            this.colValorLancamento,
            this.colValorJuros,
            this.colDataVencimento,
            this.colDataPagamento,
            this.colMotivoCancelamento,
            this.colDataCancelamento,
            this.colDiasPrazo,
            this.colObservacao,
            this.colSequencialParcela,
            this.colStatusLancamento,
            this.colTipoLancamento,
            this.colAnexos,
            this.colBaixas,
            this.colExtratos,
            this.colIdVenda,
            this.colVenda,
            this.colIdCliFor,
            this.colCliFor,
            this.colCentroCusto,
            this.colIdCentroCusto,
            this.colIdFilial,
            this.colFilial,
            this.colIdFormaPagamento,
            this.colFormaPagamento,
            this.colIdNotaFiscal,
            this.colNotaFiscal,
            this.colRecCreatedBy,
            this.colUsuarioRecCreatedBy,
            this.colRecModifyBy,
            this.colUsuarioRecModifyBy,
            this.colRecCreatedDate,
            this.colRecModifyDate,
            this.colImage,
            this.colImageNatureza,
            this.colTotalLancamento});
            this.gridViewParcelas.GridControl = this.gridControlParcelas;
            this.gridViewParcelas.Name = "gridViewParcelas";
            this.gridViewParcelas.OptionsBehavior.Editable = false;
            this.gridViewParcelas.OptionsView.ColumnAutoWidth = false;
            this.gridViewParcelas.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewParcelas.OptionsView.ShowGroupPanel = false;
            // 
            // colIdLancamento
            // 
            this.colIdLancamento.FieldName = "IdLancamento";
            this.colIdLancamento.Name = "colIdLancamento";
            // 
            // colDataLancamento
            // 
            this.colDataLancamento.FieldName = "DataLancamento";
            this.colDataLancamento.Name = "colDataLancamento";
            this.colDataLancamento.Width = 108;
            // 
            // colValorLancamento
            // 
            this.colValorLancamento.FieldName = "ValorLancamento";
            this.colValorLancamento.Name = "colValorLancamento";
            this.colValorLancamento.Width = 122;
            // 
            // colValorJuros
            // 
            this.colValorJuros.FieldName = "ValorJuros";
            this.colValorJuros.Name = "colValorJuros";
            this.colValorJuros.Width = 107;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 4;
            this.colDataVencimento.Width = 118;
            // 
            // colDataPagamento
            // 
            this.colDataPagamento.FieldName = "DataPagamento";
            this.colDataPagamento.Name = "colDataPagamento";
            // 
            // colMotivoCancelamento
            // 
            this.colMotivoCancelamento.FieldName = "MotivoCancelamento";
            this.colMotivoCancelamento.Name = "colMotivoCancelamento";
            // 
            // colDataCancelamento
            // 
            this.colDataCancelamento.FieldName = "DataCancelamento";
            this.colDataCancelamento.Name = "colDataCancelamento";
            // 
            // colDiasPrazo
            // 
            this.colDiasPrazo.FieldName = "DiasPrazo";
            this.colDiasPrazo.Name = "colDiasPrazo";
            // 
            // colObservacao
            // 
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 3;
            this.colObservacao.Width = 398;
            // 
            // colSequencialParcela
            // 
            this.colSequencialParcela.Caption = "Sequencial";
            this.colSequencialParcela.FieldName = "SequencialParcela";
            this.colSequencialParcela.Name = "colSequencialParcela";
            this.colSequencialParcela.Visible = true;
            this.colSequencialParcela.VisibleIndex = 2;
            // 
            // colStatusLancamento
            // 
            this.colStatusLancamento.FieldName = "StatusLancamento";
            this.colStatusLancamento.Name = "colStatusLancamento";
            // 
            // colTipoLancamento
            // 
            this.colTipoLancamento.FieldName = "TipoLancamento";
            this.colTipoLancamento.Name = "colTipoLancamento";
            // 
            // colAnexos
            // 
            this.colAnexos.FieldName = "Anexos";
            this.colAnexos.Name = "colAnexos";
            // 
            // colBaixas
            // 
            this.colBaixas.FieldName = "Baixas";
            this.colBaixas.Name = "colBaixas";
            // 
            // colExtratos
            // 
            this.colExtratos.FieldName = "Extratos";
            this.colExtratos.Name = "colExtratos";
            // 
            // colIdVenda
            // 
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            // 
            // colVenda
            // 
            this.colVenda.FieldName = "Venda";
            this.colVenda.Name = "colVenda";
            // 
            // colIdCliFor
            // 
            this.colIdCliFor.FieldName = "IdCliFor";
            this.colIdCliFor.Name = "colIdCliFor";
            // 
            // colCliFor
            // 
            this.colCliFor.FieldName = "CliFor";
            this.colCliFor.Name = "colCliFor";
            // 
            // colCentroCusto
            // 
            this.colCentroCusto.FieldName = "CentroCusto";
            this.colCentroCusto.Name = "colCentroCusto";
            // 
            // colIdCentroCusto
            // 
            this.colIdCentroCusto.FieldName = "IdCentroCusto";
            this.colIdCentroCusto.Name = "colIdCentroCusto";
            // 
            // colIdFilial
            // 
            this.colIdFilial.FieldName = "IdFilial";
            this.colIdFilial.Name = "colIdFilial";
            // 
            // colFilial
            // 
            this.colFilial.FieldName = "Filial";
            this.colFilial.Name = "colFilial";
            // 
            // colIdFormaPagamento
            // 
            this.colIdFormaPagamento.FieldName = "IdFormaPagamento";
            this.colIdFormaPagamento.Name = "colIdFormaPagamento";
            // 
            // colFormaPagamento
            // 
            this.colFormaPagamento.FieldName = "FormaPagamento";
            this.colFormaPagamento.Name = "colFormaPagamento";
            // 
            // colIdNotaFiscal
            // 
            this.colIdNotaFiscal.FieldName = "IdNotaFiscal";
            this.colIdNotaFiscal.Name = "colIdNotaFiscal";
            // 
            // colNotaFiscal
            // 
            this.colNotaFiscal.FieldName = "NotaFiscal";
            this.colNotaFiscal.Name = "colNotaFiscal";
            // 
            // colRecCreatedBy
            // 
            this.colRecCreatedBy.FieldName = "RecCreatedBy";
            this.colRecCreatedBy.Name = "colRecCreatedBy";
            // 
            // colUsuarioRecCreatedBy
            // 
            this.colUsuarioRecCreatedBy.FieldName = "UsuarioRecCreatedBy";
            this.colUsuarioRecCreatedBy.Name = "colUsuarioRecCreatedBy";
            // 
            // colRecModifyBy
            // 
            this.colRecModifyBy.FieldName = "RecModifyBy";
            this.colRecModifyBy.Name = "colRecModifyBy";
            // 
            // colUsuarioRecModifyBy
            // 
            this.colUsuarioRecModifyBy.FieldName = "UsuarioRecModifyBy";
            this.colUsuarioRecModifyBy.Name = "colUsuarioRecModifyBy";
            // 
            // colRecCreatedDate
            // 
            this.colRecCreatedDate.FieldName = "RecCreatedDate";
            this.colRecCreatedDate.Name = "colRecCreatedDate";
            // 
            // colRecModifyDate
            // 
            this.colRecModifyDate.FieldName = "RecModifyDate";
            this.colRecModifyDate.Name = "colRecModifyDate";
            // 
            // colImage
            // 
            this.colImage.Caption = "Situação";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.ReadOnly = true;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 60;
            // 
            // colImageNatureza
            // 
            this.colImageNatureza.Caption = "Natureza";
            this.colImageNatureza.FieldName = "ImageNatureza";
            this.colImageNatureza.Name = "colImageNatureza";
            this.colImageNatureza.OptionsColumn.ReadOnly = true;
            this.colImageNatureza.Visible = true;
            this.colImageNatureza.VisibleIndex = 1;
            this.colImageNatureza.Width = 57;
            // 
            // colTotalLancamento
            // 
            this.colTotalLancamento.FieldName = "TotalLancamento";
            this.colTotalLancamento.Name = "colTotalLancamento";
            this.colTotalLancamento.OptionsColumn.ReadOnly = true;
            this.colTotalLancamento.Visible = true;
            this.colTotalLancamento.VisibleIndex = 5;
            this.colTotalLancamento.Width = 113;
            // 
            // xtraTabFrete
            // 
            this.xtraTabFrete.Controls.Add(this.rdTipoFrete);
            this.xtraTabFrete.Controls.Add(this.labelControl18);
            this.xtraTabFrete.Name = "xtraTabFrete";
            this.xtraTabFrete.Size = new System.Drawing.Size(774, 436);
            this.xtraTabFrete.Text = "Frete";
            // 
            // rdTipoFrete
            // 
            this.rdTipoFrete.EditValue = 0;
            this.rdTipoFrete.Location = new System.Drawing.Point(21, 33);
            this.rdTipoFrete.MenuManager = this.barManager1;
            this.rdTipoFrete.Name = "rdTipoFrete";
            this.rdTipoFrete.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rdTipoFrete.Properties.Appearance.Options.UseFont = true;
            this.rdTipoFrete.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Por conta do emitente"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por conta do destinatário/remetente"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Por conta de terceiros"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(9, "Sem cobrança de frete")});
            this.rdTipoFrete.Size = new System.Drawing.Size(260, 128);
            this.rdTipoFrete.TabIndex = 2;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(21, 10);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(150, 16);
            this.labelControl18.TabIndex = 1;
            this.labelControl18.Text = "Indicador do tipo de frete:";
            // 
            // xtraTabObserv
            // 
            this.xtraTabObserv.Controls.Add(this.memoEditObservacoes);
            this.xtraTabObserv.Name = "xtraTabObserv";
            this.xtraTabObserv.Size = new System.Drawing.Size(774, 436);
            this.xtraTabObserv.Text = "Observações";
            // 
            // memoEditObservacoes
            // 
            this.memoEditObservacoes.Location = new System.Drawing.Point(13, 24);
            this.memoEditObservacoes.MenuManager = this.barManager1;
            this.memoEditObservacoes.Name = "memoEditObservacoes";
            this.memoEditObservacoes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.memoEditObservacoes.Properties.Appearance.Options.UseFont = true;
            this.memoEditObservacoes.Size = new System.Drawing.Size(688, 167);
            this.memoEditObservacoes.TabIndex = 1;
            // 
            // xtraTabIntContabFiscal
            // 
            this.xtraTabIntContabFiscal.Controls.Add(this.labelControl6);
            this.xtraTabIntContabFiscal.Controls.Add(this.lookUpLocalEstoque1);
            this.xtraTabIntContabFiscal.Controls.Add(this.lookUpCentroCusto1);
            this.xtraTabIntContabFiscal.Name = "xtraTabIntContabFiscal";
            this.xtraTabIntContabFiscal.Size = new System.Drawing.Size(774, 436);
            this.xtraTabIntContabFiscal.Text = "Intg. Contábil/Fiscal";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 77);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(85, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Local de estoque:";
            // 
            // lookUpLocalEstoque1
            // 
            this.lookUpLocalEstoque1.LabelText = "Local de estoque";
            this.lookUpLocalEstoque1.LocalEstoque = null;
            this.lookUpLocalEstoque1.Location = new System.Drawing.Point(13, 93);
            this.lookUpLocalEstoque1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpLocalEstoque1.Name = "lookUpLocalEstoque1";
            this.lookUpLocalEstoque1.Size = new System.Drawing.Size(375, 48);
            this.lookUpLocalEstoque1.TabIndex = 6;
            // 
            // lookUpCentroCusto1
            // 
            this.lookUpCentroCusto1.CentroCusto = null;
            this.lookUpCentroCusto1.LabelText = "Centro de custo:";
            this.lookUpCentroCusto1.Location = new System.Drawing.Point(13, 18);
            this.lookUpCentroCusto1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpCentroCusto1.Name = "lookUpCentroCusto1";
            this.lookUpCentroCusto1.Size = new System.Drawing.Size(375, 49);
            this.lookUpCentroCusto1.TabIndex = 5;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(774, 436);
            this.xtraTabPage1.Text = "Importação";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(774, 436);
            this.xtraTabPage2.Text = "Exportação";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnEditNF);
            this.panelControl4.Controls.Add(this.btnVoltar);
            this.panelControl4.Controls.Add(this.btnSalvar);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(132, 472);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(780, 35);
            this.panelControl4.TabIndex = 4;
            // 
            // btnEditNF
            // 
            this.btnEditNF.Location = new System.Drawing.Point(560, 7);
            this.btnEditNF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditNF.Name = "btnEditNF";
            this.btnEditNF.Size = new System.Drawing.Size(77, 23);
            this.btnEditNF.TabIndex = 2;
            this.btnEditNF.Text = "Editar";
            this.btnEditNF.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(477, 7);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(77, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(643, 7);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // bsFormaPagamento
            // 
            this.bsFormaPagamento.DataSource = typeof(ITE.Entidades.POCO.Sales.FormaPagamento);
            // 
            // bsEmpresaFilial
            // 
            this.bsEmpresaFilial.DataSource = typeof(ITE.Entidades.POCO.EmpresaFilial);
            // 
            // bsEmpresaMatriz
            // 
            this.bsEmpresaMatriz.DataSource = typeof(ITE.Entidades.POCO.EmpresaMatriz);
            // 
            // bsCliFor
            // 
            this.bsCliFor.DataSource = typeof(ITE.Entidades.POCO.CliFor);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnAddItem,
            this.barBtnEditarItem,
            this.barBtnRemoveItem,
            this.barBtnAtualizarDados});
            this.barManager2.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Standalone;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.FloatLocation = new System.Drawing.Point(410, 209);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAddItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEditarItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRemoveItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizarDados)});
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar2.Text = "Tools";
            // 
            // barBtnAddItem
            // 
            this.barBtnAddItem.Caption = "Add Item";
            this.barBtnAddItem.Id = 0;
            this.barBtnAddItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddItem.ImageOptions.Image")));
            this.barBtnAddItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnAddItem.ImageOptions.LargeImage")));
            this.barBtnAddItem.Name = "barBtnAddItem";
            this.barBtnAddItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAddItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddItem_ItemClick);
            // 
            // barBtnEditarItem
            // 
            this.barBtnEditarItem.Caption = "Editar Item";
            this.barBtnEditarItem.Id = 1;
            this.barBtnEditarItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEditarItem.ImageOptions.Image")));
            this.barBtnEditarItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnEditarItem.ImageOptions.LargeImage")));
            this.barBtnEditarItem.Name = "barBtnEditarItem";
            this.barBtnEditarItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEditarItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditarItem_ItemClick);
            // 
            // barBtnRemoveItem
            // 
            this.barBtnRemoveItem.Caption = "Remove Item";
            this.barBtnRemoveItem.Id = 2;
            this.barBtnRemoveItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRemoveItem.ImageOptions.Image")));
            this.barBtnRemoveItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnRemoveItem.ImageOptions.LargeImage")));
            this.barBtnRemoveItem.Name = "barBtnRemoveItem";
            this.barBtnRemoveItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnRemoveItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRemoveItem_ItemClick);
            // 
            // barBtnAtualizarDados
            // 
            this.barBtnAtualizarDados.Caption = "Atualizar";
            this.barBtnAtualizarDados.Id = 3;
            this.barBtnAtualizarDados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizarDados.ImageOptions.Image")));
            this.barBtnAtualizarDados.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizarDados.ImageOptions.LargeImage")));
            this.barBtnAtualizarDados.Name = "barBtnAtualizarDados";
            this.barBtnAtualizarDados.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizarDados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizarDados_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(919, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 513);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(919, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 513);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(919, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 513);
            // 
            // lbMensagem
            // 
            this.lbMensagem.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbMensagem.Appearance.Options.UseForeColor = true;
            this.lbMensagem.Location = new System.Drawing.Point(473, 172);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(257, 13);
            this.lbMensagem.TabIndex = 2;
            this.lbMensagem.Text = "Transferência entre estoques não permitida a edição.";
            this.lbMensagem.Visible = false;
            // 
            // XFrmPedidoCompraCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 513);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "XFrmPedidoCompraCotacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão Movimento Simples";
            this.Shown += new System.EventHandler(this.XFrmEntradaNew_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tbLayoutPanelPai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnValoresView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTraTabNF)).EndInit();
            this.xTraTabNF.ResumeLayout(false);
            this.xtraTabCabecalho.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoNf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.xtraTabItensNF.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItensNF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensNF)).EndInit();
            this.xtraTabValores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrDespesas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrSeguro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotalNf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrFrete.Properties)).EndInit();
            this.xtraTabItgFinanceira.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkGerarFat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoFinanceiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParcelas)).EndInit();
            this.xtraTabFrete.ResumeLayout(false);
            this.xtraTabFrete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoFrete.Properties)).EndInit();
            this.xtraTabObserv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditObservacoes.Properties)).EndInit();
            this.xtraTabIntContabFiscal.ResumeLayout(false);
            this.xtraTabIntContabFiscal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaFilial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlItensNF;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItensNF;
        private System.Windows.Forms.BindingSource bsCliFor;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNumNf;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraNavBar.NavBarControl btnValoresView;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navCabecalho;
        private DevExpress.XtraNavBar.NavBarItem navItensNf;
        private DevExpress.XtraNavBar.NavBarItem navValores;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraTab.XtraTabControl xTraTabNF;
        private DevExpress.XtraTab.XtraTabPage xtraTabCabecalho;
        private DevExpress.XtraTab.XtraTabPage xtraTabItensNF;
        private DevExpress.XtraTab.XtraTabPage xtraTabValores;
        private System.Windows.Forms.BindingSource bsItemEntrada;
        private System.Windows.Forms.DateTimePicker dtEmissao;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtVlrTotalNf;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtVlrDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtVlrFrete;
        private DevExpress.XtraEditors.SimpleButton btnCalcNf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbLayoutPanelPai;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnAddItem;
        private DevExpress.XtraBars.BarButtonItem barBtnEditarItem;
        private DevExpress.XtraBars.BarButtonItem barBtnRemoveItem;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizarDados;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraNavBar.NavBarItem navInfoFrete;
        private DevExpress.XtraNavBar.NavBarItem navItgFinanceira;
        private DevExpress.XtraEditors.RadioGroup rdTipoNf;
        private DevExpress.XtraTab.XtraTabPage xtraTabItgFinanceira;
        private DevExpress.XtraTab.XtraTabPage xtraTabFrete;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtVlrDespesas;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtVlrSeguro;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private System.Windows.Forms.BindingSource bsEmpresaFilial;
        private System.Windows.Forms.BindingSource bsEmpresaMatriz;
        private System.Windows.Forms.BindingSource bsNotaFiscalItem;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencialItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCfop;
        private DevExpress.XtraGrid.Columns.GridColumn colValorDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalItem;
        private DevExpress.XtraGrid.Columns.GridColumn colValorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private System.Windows.Forms.BindingSource bsFormaPagamento;
        private DevExpress.XtraEditors.RadioGroup rdTipoFrete;
        private DevExpress.XtraGrid.Columns.GridColumn colRegraFiscal;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraGrid.GridControl gridControlParcelas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewParcelas;
        private DevExpress.XtraNavBar.NavBarItem navInfoObservacoes;
        private DevExpress.XtraTab.XtraTabPage xtraTabObserv;
        private DevExpress.XtraEditors.MemoEdit memoEditObservacoes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private System.Windows.Forms.BindingSource lancamentoFinanceiroBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorJuros;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoCancelamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCancelamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPrazo;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencialParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colAnexos;
        private DevExpress.XtraGrid.Columns.GridColumn colBaixas;
        private DevExpress.XtraGrid.Columns.GridColumn colExtratos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNotaFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colNotaFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colRecCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioRecCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colRecModifyBy;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioRecModifyBy;
        private DevExpress.XtraGrid.Columns.GridColumn colRecCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRecModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colImageNatureza;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalLancamento;
        private DevExpress.XtraEditors.SimpleButton btnEditNF;
        private Components.LookUpFormaPagamento lookUpFormaPagamento1;
        private System.Windows.Forms.DateTimePicker dtEntrada;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSubSerie;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSerie;
        private DevExpress.XtraNavBar.NavBarItem navItgContabFiscal;
        private DevExpress.XtraTab.XtraTabPage xtraTabIntContabFiscal;
        private Components.LookUpCentroCusto lookUpCentroCusto1;
        private DevExpress.XtraEditors.CheckEdit chkGerarFat;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private Components.LookUpLocalEstoque lookUpLocalEstoque1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private Components.LookUpMatrizFilial lookUpMatrizFilial1;
        private Components.LookUpTipoMovimento lookUpTipoMovimento1;
        private LookUpCliFor lookUpCliFor1;
        private DevExpress.XtraEditors.LabelControl lbMensagem;
    }
}