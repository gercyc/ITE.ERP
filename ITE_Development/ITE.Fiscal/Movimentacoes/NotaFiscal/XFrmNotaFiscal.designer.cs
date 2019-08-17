using ITE.Components.LookUp;

namespace ITE.Fiscal.Movimentacoes.NotaFiscal
{
    partial class XFrmNotaFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmNotaFiscal));
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
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnEditNF = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.xTraTabNF = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabCabecalho = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtSubSerie = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.rdTipoNf = new DevExpress.XtraEditors.RadioGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.txtSerieNf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtNumNf = new DevExpress.XtraEditors.TextEdit();
            this.dtEmissao = new System.Windows.Forms.DateTimePicker();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpModeloDocFiscal1 = new ITE.Components.LookUpModeloDocFiscal();
            this.lookUpTipoMovimento1 = new ITE.Components.LookUpTipoMovimento();
            this.txtChaveAcessoNf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpMatrizFilial1 = new ITE.Components.LookUpMatrizFilial();
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
            this.xtraTabValores = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrICMSST = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrBaseICMSST = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrICMS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrBaseICMS = new DevExpress.XtraEditors.TextEdit();
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
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtIETransp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtUfTranspo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtMunicipioTranporta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompEndTransp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumEndTransp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtEndTransp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbTpDocTransportador = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCnpjTransport = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtRazSocTransportador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpTransportador = new LookUpCliFor();
            this.rdTipoFrete = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabObserv = new DevExpress.XtraTab.XtraTabPage();
            this.memoEditObservacoes = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabItgContabFiscal = new DevExpress.XtraTab.XtraTabPage();
            this.lookUpLocalEstoque1 = new ITE.Components.LookUpLocalEstoque();
            this.lookUpCentroCusto1 = new ITE.Components.LookUpCentroCusto();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
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
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtMuncTransporta = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.dxValidadorNF = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lbMensagem = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tbLayoutPanelPai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnValoresView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoNf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieNf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChaveAcessoNf.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrICMSST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseICMSST.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrICMS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseICMS.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIETransp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUfTranspo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipioTranporta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompEndTransp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumEndTransp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTransp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTpDocTransportador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnpjTransport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazSocTransportador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoFrete.Properties)).BeginInit();
            this.xtraTabObserv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditObservacoes.Properties)).BeginInit();
            this.xtraTabItgContabFiscal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaFilial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMuncTransporta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidadorNF)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tbLayoutPanelPai);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(862, 446);
            this.panelControl1.TabIndex = 0;
            // 
            // tbLayoutPanelPai
            // 
            this.tbLayoutPanelPai.ColumnCount = 2;
            this.tbLayoutPanelPai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.17666F));
            this.tbLayoutPanelPai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.82333F));
            this.tbLayoutPanelPai.Controls.Add(this.btnValoresView, 0, 0);
            this.tbLayoutPanelPai.Controls.Add(this.panelControl4, 1, 1);
            this.tbLayoutPanelPai.Controls.Add(this.xTraTabNF, 1, 0);
            this.tbLayoutPanelPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutPanelPai.Location = new System.Drawing.Point(2, 2);
            this.tbLayoutPanelPai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLayoutPanelPai.Name = "tbLayoutPanelPai";
            this.tbLayoutPanelPai.RowCount = 2;
            this.tbLayoutPanelPai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLayoutPanelPai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tbLayoutPanelPai.Size = new System.Drawing.Size(858, 442);
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
            this.btnValoresView.OptionsNavPane.ExpandedWidth = 115;
            this.btnValoresView.Size = new System.Drawing.Size(115, 397);
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
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnEditNF);
            this.panelControl4.Controls.Add(this.btnVoltar);
            this.panelControl4.Controls.Add(this.btnSalvar);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(124, 405);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(731, 35);
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
            // xTraTabNF
            // 
            this.xTraTabNF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xTraTabNF.Location = new System.Drawing.Point(124, 3);
            this.xTraTabNF.Name = "xTraTabNF";
            this.xTraTabNF.SelectedTabPage = this.xtraTabCabecalho;
            this.xTraTabNF.Size = new System.Drawing.Size(731, 397);
            this.xTraTabNF.TabIndex = 3;
            this.xTraTabNF.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabCabecalho,
            this.xtraTabItensNF,
            this.xtraTabValores,
            this.xtraTabItgFinanceira,
            this.xtraTabFrete,
            this.xtraTabObserv,
            this.xtraTabItgContabFiscal,
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabCabecalho
            // 
            this.xtraTabCabecalho.Controls.Add(this.tableLayoutPanel1);
            this.xtraTabCabecalho.Name = "xtraTabCabecalho";
            this.xtraTabCabecalho.Size = new System.Drawing.Size(725, 369);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.29269F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.70732F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 369);
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
            this.groupControl1.Size = new System.Drawing.Size(719, 245);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Informações Básicas";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.12546F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.87454F));
            this.tableLayoutPanel3.Controls.Add(this.panelControl2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelControl3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lookUpMatrizFilial1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 23);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.92704F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.07296F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(715, 220);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.txtSubSerie);
            this.panelControl2.Controls.Add(this.labelControl27);
            this.panelControl2.Controls.Add(this.rdTipoNf);
            this.panelControl2.Controls.Add(this.txtSerieNf);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl17);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.dtEntrada);
            this.panelControl2.Controls.Add(this.txtNumNf);
            this.panelControl2.Controls.Add(this.dtEmissao);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(332, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(380, 103);
            this.panelControl2.TabIndex = 1;
            // 
            // txtSubSerie
            // 
            this.txtSubSerie.Location = new System.Drawing.Point(79, 78);
            this.txtSubSerie.Name = "txtSubSerie";
            this.txtSubSerie.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSubSerie.Properties.Appearance.Options.UseFont = true;
            this.txtSubSerie.Size = new System.Drawing.Size(70, 20);
            this.txtSubSerie.TabIndex = 5;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Location = new System.Drawing.Point(79, 57);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(56, 14);
            this.labelControl27.TabIndex = 27;
            this.labelControl27.Text = "Sub Série:";
            // 
            // rdTipoNf
            // 
            this.rdTipoNf.EditValue = "E";
            this.rdTipoNf.Location = new System.Drawing.Point(273, 14);
            this.rdTipoNf.MenuManager = this.barManager1;
            this.rdTipoNf.Name = "rdTipoNf";
            this.rdTipoNf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rdTipoNf.Properties.Appearance.Options.UseFont = true;
            this.rdTipoNf.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("E", "Entrada"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Saída")});
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
            this.barDockControlTop.Size = new System.Drawing.Size(862, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 446);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(862, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 446);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(862, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 446);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(3, 2);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(719, 32);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // txtSerieNf
            // 
            this.txtSerieNf.Location = new System.Drawing.Point(5, 78);
            this.txtSerieNf.Name = "txtSerieNf";
            this.txtSerieNf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSerieNf.Properties.Appearance.Options.UseFont = true;
            this.txtSerieNf.Size = new System.Drawing.Size(61, 20);
            this.txtSerieNf.TabIndex = 4;
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
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(5, 57);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(33, 13);
            this.labelControl17.TabIndex = 21;
            this.labelControl17.Text = "Série:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(141, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Data Entrada";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(159, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Número:";
            // 
            // dtEntrada
            // 
            this.dtEntrada.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEntrada.Location = new System.Drawing.Point(141, 25);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(98, 22);
            this.dtEntrada.TabIndex = 2;
            // 
            // txtNumNf
            // 
            this.txtNumNf.Location = new System.Drawing.Point(159, 78);
            this.txtNumNf.Name = "txtNumNf";
            this.txtNumNf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumNf.Properties.Appearance.Options.UseFont = true;
            this.txtNumNf.Size = new System.Drawing.Size(102, 20);
            this.txtNumNf.TabIndex = 6;
            // 
            // dtEmissao
            // 
            this.dtEmissao.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEmissao.Location = new System.Drawing.Point(5, 24);
            this.dtEmissao.Name = "dtEmissao";
            this.dtEmissao.Size = new System.Drawing.Size(98, 22);
            this.dtEmissao.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tableLayoutPanel3.SetColumnSpan(this.panelControl3, 2);
            this.panelControl3.Controls.Add(this.lookUpModeloDocFiscal1);
            this.panelControl3.Controls.Add(this.lookUpTipoMovimento1);
            this.panelControl3.Controls.Add(this.txtChaveAcessoNf);
            this.panelControl3.Controls.Add(this.labelControl26);
            this.panelControl3.Location = new System.Drawing.Point(3, 109);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(709, 109);
            this.panelControl3.TabIndex = 2;
            // 
            // lookUpModeloDocFiscal1
            // 
            this.lookUpModeloDocFiscal1.Location = new System.Drawing.Point(7, 9);
            this.lookUpModeloDocFiscal1.ModeloDocumentoFiscal = null;
            this.lookUpModeloDocFiscal1.Name = "lookUpModeloDocFiscal1";
            this.lookUpModeloDocFiscal1.Size = new System.Drawing.Size(323, 49);
            this.lookUpModeloDocFiscal1.TabIndex = 25;
            // 
            // lookUpTipoMovimento1
            // 
            this.lookUpTipoMovimento1.Location = new System.Drawing.Point(7, 56);
            this.lookUpTipoMovimento1.Name = "lookUpTipoMovimento1";
            this.lookUpTipoMovimento1.Size = new System.Drawing.Size(695, 49);
            this.lookUpTipoMovimento1.TabIndex = 24;
            this.lookUpTipoMovimento1.TipoMovimento = null;
            this.lookUpTipoMovimento1.Leave += new System.EventHandler(this.lookUpTipoMovimento1_Leave);
            // 
            // txtChaveAcessoNf
            // 
            this.txtChaveAcessoNf.Location = new System.Drawing.Point(336, 34);
            this.txtChaveAcessoNf.Name = "txtChaveAcessoNf";
            this.txtChaveAcessoNf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtChaveAcessoNf.Properties.Appearance.Options.UseFont = true;
            this.txtChaveAcessoNf.Size = new System.Drawing.Size(366, 20);
            this.txtChaveAcessoNf.TabIndex = 8;
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl26.Appearance.Options.UseFont = true;
            this.labelControl26.Location = new System.Drawing.Point(336, 13);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(95, 14);
            this.labelControl26.TabIndex = 23;
            this.labelControl26.Text = "Chave de acesso:";
            // 
            // lookUpMatrizFilial1
            // 
            this.lookUpMatrizFilial1.AutoSize = true;
            this.lookUpMatrizFilial1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lookUpMatrizFilial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpMatrizFilial1.Filial = null;
            this.lookUpMatrizFilial1.Location = new System.Drawing.Point(3, 3);
            this.lookUpMatrizFilial1.Matriz = null;
            this.lookUpMatrizFilial1.Name = "lookUpMatrizFilial1";
            this.lookUpMatrizFilial1.Size = new System.Drawing.Size(323, 101);
            this.lookUpMatrizFilial1.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.lbMensagem);
            this.groupControl2.Controls.Add(this.lookUpCliFor1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 254);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(719, 112);
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
            this.lookUpCliFor1.Size = new System.Drawing.Size(709, 55);
            this.lookUpCliFor1.TabIndex = 0;
            // 
            // xtraTabItensNF
            // 
            this.xtraTabItensNF.Controls.Add(this.tableLayoutPanel2);
            this.xtraTabItensNF.Name = "xtraTabItensNF";
            this.xtraTabItensNF.Size = new System.Drawing.Size(725, 369);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(725, 369);
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
            this.groupControl3.Size = new System.Drawing.Size(719, 326);
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
            this.gridControlItensNF.Size = new System.Drawing.Size(715, 301);
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
            this.colRegraFiscal});
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
            this.colProduto.VisibleIndex = 1;
            this.colProduto.Width = 104;
            // 
            // colCfop
            // 
            this.colCfop.AppearanceCell.Options.UseTextOptions = true;
            this.colCfop.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCfop.FieldName = "Cfop";
            this.colCfop.Name = "colCfop";
            this.colCfop.Visible = true;
            this.colCfop.VisibleIndex = 2;
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
            this.colRegraFiscal.Visible = true;
            this.colRegraFiscal.VisibleIndex = 7;
            this.colRegraFiscal.Width = 92;
            // 
            // xtraTabValores
            // 
            this.xtraTabValores.Controls.Add(this.groupControl4);
            this.xtraTabValores.Name = "xtraTabValores";
            this.xtraTabValores.Size = new System.Drawing.Size(725, 369);
            this.xtraTabValores.Text = "Valores";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.labelControl23);
            this.groupControl4.Controls.Add(this.txtVlrICMSST);
            this.groupControl4.Controls.Add(this.labelControl24);
            this.groupControl4.Controls.Add(this.txtVlrBaseICMSST);
            this.groupControl4.Controls.Add(this.labelControl21);
            this.groupControl4.Controls.Add(this.txtVlrICMS);
            this.groupControl4.Controls.Add(this.labelControl22);
            this.groupControl4.Controls.Add(this.txtVlrBaseICMS);
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
            this.groupControl4.Size = new System.Drawing.Size(725, 369);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Valores";
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(335, 222);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(81, 14);
            this.labelControl23.TabIndex = 18;
            this.labelControl23.Text = "Valor ICMS ST:";
            // 
            // txtVlrICMSST
            // 
            this.txtVlrICMSST.Location = new System.Drawing.Point(334, 245);
            this.txtVlrICMSST.Name = "txtVlrICMSST";
            this.txtVlrICMSST.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrICMSST.Properties.Appearance.Options.UseFont = true;
            this.txtVlrICMSST.Size = new System.Drawing.Size(147, 20);
            this.txtVlrICMSST.TabIndex = 17;
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Location = new System.Drawing.Point(28, 222);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(137, 14);
            this.labelControl24.TabIndex = 16;
            this.labelControl24.Text = "Base de cálculo ICMS ST:";
            // 
            // txtVlrBaseICMSST
            // 
            this.txtVlrBaseICMSST.Location = new System.Drawing.Point(28, 245);
            this.txtVlrBaseICMSST.Name = "txtVlrBaseICMSST";
            this.txtVlrBaseICMSST.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrBaseICMSST.Properties.Appearance.Options.UseFont = true;
            this.txtVlrBaseICMSST.Size = new System.Drawing.Size(147, 20);
            this.txtVlrBaseICMSST.TabIndex = 15;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(335, 153);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(80, 14);
            this.labelControl21.TabIndex = 14;
            this.labelControl21.Text = "Valor do ICMS:";
            // 
            // txtVlrICMS
            // 
            this.txtVlrICMS.Location = new System.Drawing.Point(334, 176);
            this.txtVlrICMS.Name = "txtVlrICMS";
            this.txtVlrICMS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrICMS.Properties.Appearance.Options.UseFont = true;
            this.txtVlrICMS.Size = new System.Drawing.Size(147, 20);
            this.txtVlrICMS.TabIndex = 13;
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(28, 153);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(118, 14);
            this.labelControl22.TabIndex = 12;
            this.labelControl22.Text = "Base de cálculo ICMS:";
            // 
            // txtVlrBaseICMS
            // 
            this.txtVlrBaseICMS.Location = new System.Drawing.Point(28, 176);
            this.txtVlrBaseICMS.Name = "txtVlrBaseICMS";
            this.txtVlrBaseICMS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrBaseICMS.Properties.Appearance.Options.UseFont = true;
            this.txtVlrBaseICMS.Size = new System.Drawing.Size(147, 20);
            this.txtVlrBaseICMS.TabIndex = 11;
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
            this.btnCalcNf.Location = new System.Drawing.Point(577, 314);
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
            this.labelControl12.Size = new System.Drawing.Size(93, 14);
            this.labelControl12.TabIndex = 5;
            this.labelControl12.Text = "Valor Total Nota:";
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
            this.xtraTabItgFinanceira.Size = new System.Drawing.Size(725, 369);
            this.xtraTabItgFinanceira.Text = "Intg. Financeira";
            // 
            // chkGerarFat
            // 
            this.chkGerarFat.Location = new System.Drawing.Point(16, 36);
            this.chkGerarFat.MenuManager = this.barManager1;
            this.chkGerarFat.Name = "chkGerarFat";
            this.chkGerarFat.Properties.Caption = "Gerar faturamento?";
            this.chkGerarFat.Properties.ReadOnly = true;
            this.chkGerarFat.Size = new System.Drawing.Size(133, 19);
            this.chkGerarFat.TabIndex = 7;
            // 
            // lookUpFormaPagamento1
            // 
            this.lookUpFormaPagamento1.FormaPagto = null;
            this.lookUpFormaPagamento1.Location = new System.Drawing.Point(387, 16);
            this.lookUpFormaPagamento1.Name = "lookUpFormaPagamento1";
            this.lookUpFormaPagamento1.Size = new System.Drawing.Size(332, 49);
            this.lookUpFormaPagamento1.TabIndex = 5;
            // 
            // groupControl7
            // 
            this.groupControl7.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupControl7.AppearanceCaption.Options.UseFont = true;
            this.groupControl7.Controls.Add(this.gridControlParcelas);
            this.groupControl7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl7.Location = new System.Drawing.Point(0, 71);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(725, 298);
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
            this.gridControlParcelas.Size = new System.Drawing.Size(721, 276);
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
            this.xtraTabFrete.Controls.Add(this.groupControl5);
            this.xtraTabFrete.Controls.Add(this.lookUpTransportador);
            this.xtraTabFrete.Controls.Add(this.rdTipoFrete);
            this.xtraTabFrete.Controls.Add(this.labelControl18);
            this.xtraTabFrete.Name = "xtraTabFrete";
            this.xtraTabFrete.Size = new System.Drawing.Size(725, 369);
            this.xtraTabFrete.Text = "Frete";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.txtIETransp);
            this.groupControl5.Controls.Add(this.labelControl15);
            this.groupControl5.Controls.Add(this.txtUfTranspo);
            this.groupControl5.Controls.Add(this.labelControl14);
            this.groupControl5.Controls.Add(this.txtMunicipioTranporta);
            this.groupControl5.Controls.Add(this.labelControl13);
            this.groupControl5.Controls.Add(this.txtCompEndTransp);
            this.groupControl5.Controls.Add(this.labelControl9);
            this.groupControl5.Controls.Add(this.txtNumEndTransp);
            this.groupControl5.Controls.Add(this.labelControl8);
            this.groupControl5.Controls.Add(this.txtEndTransp);
            this.groupControl5.Controls.Add(this.labelControl7);
            this.groupControl5.Controls.Add(this.cbTpDocTransportador);
            this.groupControl5.Controls.Add(this.labelControl6);
            this.groupControl5.Controls.Add(this.txtCnpjTransport);
            this.groupControl5.Controls.Add(this.labelControl5);
            this.groupControl5.Controls.Add(this.txtRazSocTransportador);
            this.groupControl5.Controls.Add(this.labelControl4);
            this.groupControl5.Location = new System.Drawing.Point(7, 195);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(712, 159);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "Dados do transportador:";
            // 
            // txtIETransp
            // 
            this.txtIETransp.Location = new System.Drawing.Point(5, 132);
            this.txtIETransp.MenuManager = this.barManager1;
            this.txtIETransp.Name = "txtIETransp";
            this.txtIETransp.Size = new System.Drawing.Size(161, 20);
            this.txtIETransp.TabIndex = 5;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(5, 113);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(87, 13);
            this.labelControl15.TabIndex = 16;
            this.labelControl15.Text = "Inscrição Estadual";
            // 
            // txtUfTranspo
            // 
            this.txtUfTranspo.Location = new System.Drawing.Point(378, 87);
            this.txtUfTranspo.MenuManager = this.barManager1;
            this.txtUfTranspo.Name = "txtUfTranspo";
            this.txtUfTranspo.Size = new System.Drawing.Size(38, 20);
            this.txtUfTranspo.TabIndex = 10;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(378, 68);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(13, 13);
            this.labelControl14.TabIndex = 14;
            this.labelControl14.Text = "UF";
            // 
            // txtMunicipioTranporta
            // 
            this.txtMunicipioTranporta.Location = new System.Drawing.Point(289, 87);
            this.txtMunicipioTranporta.MenuManager = this.barManager1;
            this.txtMunicipioTranporta.Name = "txtMunicipioTranporta";
            this.txtMunicipioTranporta.Size = new System.Drawing.Size(83, 20);
            this.txtMunicipioTranporta.TabIndex = 9;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(289, 68);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(43, 13);
            this.labelControl13.TabIndex = 12;
            this.labelControl13.Text = "Município";
            // 
            // txtCompEndTransp
            // 
            this.txtCompEndTransp.Location = new System.Drawing.Point(568, 42);
            this.txtCompEndTransp.MenuManager = this.barManager1;
            this.txtCompEndTransp.Name = "txtCompEndTransp";
            this.txtCompEndTransp.Size = new System.Drawing.Size(105, 20);
            this.txtCompEndTransp.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(568, 23);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 13);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "Complemento";
            // 
            // txtNumEndTransp
            // 
            this.txtNumEndTransp.Location = new System.Drawing.Point(489, 42);
            this.txtNumEndTransp.MenuManager = this.barManager1;
            this.txtNumEndTransp.Name = "txtNumEndTransp";
            this.txtNumEndTransp.Size = new System.Drawing.Size(73, 20);
            this.txtNumEndTransp.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(489, 23);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Número";
            // 
            // txtEndTransp
            // 
            this.txtEndTransp.Location = new System.Drawing.Point(289, 42);
            this.txtEndTransp.MenuManager = this.barManager1;
            this.txtEndTransp.Name = "txtEndTransp";
            this.txtEndTransp.Size = new System.Drawing.Size(194, 20);
            this.txtEndTransp.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(289, 23);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(45, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Endereço";
            // 
            // cbTpDocTransportador
            // 
            this.cbTpDocTransportador.Location = new System.Drawing.Point(5, 87);
            this.cbTpDocTransportador.MenuManager = this.barManager1;
            this.cbTpDocTransportador.Name = "cbTpDocTransportador";
            this.cbTpDocTransportador.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTpDocTransportador.Properties.Items.AddRange(new object[] {
            "CNPJ",
            "CPF"});
            this.cbTpDocTransportador.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTpDocTransportador.Size = new System.Drawing.Size(111, 20);
            this.cbTpDocTransportador.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 68);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Tipo de documento";
            // 
            // txtCnpjTransport
            // 
            this.txtCnpjTransport.Location = new System.Drawing.Point(122, 87);
            this.txtCnpjTransport.MenuManager = this.barManager1;
            this.txtCnpjTransport.Name = "txtCnpjTransport";
            this.txtCnpjTransport.Size = new System.Drawing.Size(161, 20);
            this.txtCnpjTransport.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(122, 68);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "CNPJ/CPF";
            // 
            // txtRazSocTransportador
            // 
            this.txtRazSocTransportador.Location = new System.Drawing.Point(5, 42);
            this.txtRazSocTransportador.MenuManager = this.barManager1;
            this.txtRazSocTransportador.Name = "txtRazSocTransportador";
            this.txtRazSocTransportador.Size = new System.Drawing.Size(278, 20);
            this.txtRazSocTransportador.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Razão Social";
            // 
            // lookUpTransportador
            // 
            this.lookUpTransportador.CliFor = null;
            this.lookUpTransportador.Filial = null;
            this.lookUpTransportador.LabelText = "Transportador:";
            this.lookUpTransportador.Location = new System.Drawing.Point(6, 141);
            this.lookUpTransportador.Matriz = null;
            this.lookUpTransportador.Name = "lookUpTransportador";
            this.lookUpTransportador.Size = new System.Drawing.Size(375, 48);
            this.lookUpTransportador.TabIndex = 1;
            this.lookUpTransportador.Leave += new System.EventHandler(this.lookUpTransportador_Leave);
            // 
            // rdTipoFrete
            // 
            this.rdTipoFrete.EditValue = 0;
            this.rdTipoFrete.Location = new System.Drawing.Point(7, 32);
            this.rdTipoFrete.MenuManager = this.barManager1;
            this.rdTipoFrete.Name = "rdTipoFrete";
            this.rdTipoFrete.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.rdTipoFrete.Properties.Appearance.Options.UseFont = true;
            this.rdTipoFrete.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Por conta do emitente"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por conta do destinatário/remetente"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Por conta de terceiros"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(9, "Sem cobrança de frete")});
            this.rdTipoFrete.Size = new System.Drawing.Size(243, 103);
            this.rdTipoFrete.TabIndex = 0;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(7, 10);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(150, 16);
            this.labelControl18.TabIndex = 1;
            this.labelControl18.Text = "Indicador do tipo de frete:";
            // 
            // xtraTabObserv
            // 
            this.xtraTabObserv.Controls.Add(this.memoEditObservacoes);
            this.xtraTabObserv.Name = "xtraTabObserv";
            this.xtraTabObserv.Size = new System.Drawing.Size(725, 369);
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
            // xtraTabItgContabFiscal
            // 
            this.xtraTabItgContabFiscal.Controls.Add(this.lookUpLocalEstoque1);
            this.xtraTabItgContabFiscal.Controls.Add(this.lookUpCentroCusto1);
            this.xtraTabItgContabFiscal.Name = "xtraTabItgContabFiscal";
            this.xtraTabItgContabFiscal.Size = new System.Drawing.Size(725, 369);
            this.xtraTabItgContabFiscal.Text = "Intg. Contábil/Fiscal";
            // 
            // lookUpLocalEstoque1
            // 
            this.lookUpLocalEstoque1.LabelText = "Local de estoque";
            this.lookUpLocalEstoque1.LocalEstoque = null;
            this.lookUpLocalEstoque1.Location = new System.Drawing.Point(13, 83);
            this.lookUpLocalEstoque1.Name = "lookUpLocalEstoque1";
            this.lookUpLocalEstoque1.Size = new System.Drawing.Size(375, 47);
            this.lookUpLocalEstoque1.TabIndex = 6;
            // 
            // lookUpCentroCusto1
            // 
            this.lookUpCentroCusto1.CentroCusto = null;
            this.lookUpCentroCusto1.LabelText = "Centro de custo:";
            this.lookUpCentroCusto1.Location = new System.Drawing.Point(12, 28);
            this.lookUpCentroCusto1.Name = "lookUpCentroCusto1";
            this.lookUpCentroCusto1.Size = new System.Drawing.Size(375, 49);
            this.lookUpCentroCusto1.TabIndex = 5;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(725, 369);
            this.xtraTabPage1.Text = "Importação";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(725, 369);
            this.xtraTabPage2.Text = "Exportação";
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
            this.barDockControl1.Size = new System.Drawing.Size(862, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 446);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(862, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 446);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(862, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 446);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(5, 87);
            this.comboBoxEdit1.MenuManager = this.barManager1;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "CNPJ",
            "CPF"});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(111, 20);
            this.comboBoxEdit1.TabIndex = 3;
            // 
            // txtMuncTransporta
            // 
            this.txtMuncTransporta.Location = new System.Drawing.Point(289, 87);
            this.txtMuncTransporta.MenuManager = this.barManager1;
            this.txtMuncTransporta.Name = "txtMuncTransporta";
            this.txtMuncTransporta.Size = new System.Drawing.Size(83, 20);
            this.txtMuncTransporta.TabIndex = 9;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(378, 87);
            this.textEdit7.MenuManager = this.barManager1;
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(38, 20);
            this.textEdit7.TabIndex = 10;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(489, 42);
            this.textEdit4.MenuManager = this.barManager1;
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(73, 20);
            this.textEdit4.TabIndex = 7;
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(5, 132);
            this.textEdit8.MenuManager = this.barManager1;
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(161, 20);
            this.textEdit8.TabIndex = 5;
            // 
            // dxValidadorNF
            // 
            this.dxValidadorNF.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            this.dxValidadorNF.ValidationFailed += new DevExpress.XtraEditors.DXErrorProvider.ValidationFailedEventHandler(this.dxValidadorNF_ValidationFailed);
            this.dxValidadorNF.ValidationSucceeded += new DevExpress.XtraEditors.DXErrorProvider.ValidationSucceededEventHandler(this.dxValidadorNF_ValidationSucceeded);
            // 
            // lbMensagem
            // 
            this.lbMensagem.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbMensagem.Appearance.Options.UseForeColor = true;
            this.lbMensagem.Location = new System.Drawing.Point(448, 44);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(257, 13);
            this.lbMensagem.TabIndex = 1;
            this.lbMensagem.Text = "Transferência entre estoques não permitida a edição.";
            this.lbMensagem.Visible = false;
            // 
            // XFrmNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 446);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "XFrmNotaFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão Nota Fiscal";
            this.Shown += new System.EventHandler(this.XFrmEntradaNew_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tbLayoutPanelPai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnValoresView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xTraTabNF)).EndInit();
            this.xTraTabNF.ResumeLayout(false);
            this.xtraTabCabecalho.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoNf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieNf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumNf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChaveAcessoNf.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrICMSST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseICMSST.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrICMS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrBaseICMS.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIETransp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUfTranspo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMunicipioTranporta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompEndTransp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumEndTransp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndTransp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTpDocTransportador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnpjTransport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazSocTransportador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoFrete.Properties)).EndInit();
            this.xtraTabObserv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditObservacoes.Properties)).EndInit();
            this.xtraTabItgContabFiscal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaFilial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmpresaMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMuncTransporta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidadorNF)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtEntrada;
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
        private DevExpress.XtraEditors.TextEdit txtSerieNf;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.RadioGroup rdTipoNf;
        private DevExpress.XtraTab.XtraTabPage xtraTabItgFinanceira;
        private DevExpress.XtraTab.XtraTabPage xtraTabFrete;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.TextEdit txtVlrICMSST;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.TextEdit txtVlrBaseICMSST;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.TextEdit txtVlrICMS;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.TextEdit txtVlrBaseICMS;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtVlrDespesas;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtVlrSeguro;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtChaveAcessoNf;
        private DevExpress.XtraEditors.LabelControl labelControl26;
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
        private DevExpress.XtraEditors.TextEdit txtSubSerie;
        private DevExpress.XtraEditors.LabelControl labelControl27;
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
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private Components.LookUpMatrizFilial lookUpMatrizFilial1;
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
        private DevExpress.XtraNavBar.NavBarItem navItgContabFiscal;
        private DevExpress.XtraTab.XtraTabPage xtraTabItgContabFiscal;
        private Components.LookUpCentroCusto lookUpCentroCusto1;
        private DevExpress.XtraEditors.CheckEdit chkGerarFat;
        private Components.LookUpTipoMovimento lookUpTipoMovimento1;
        private LookUpCliFor lookUpCliFor1;
        private Components.LookUpModeloDocFiscal lookUpModeloDocFiscal1;
        private Components.LookUpLocalEstoque lookUpLocalEstoque1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private LookUpCliFor lookUpTransportador;
        private DevExpress.XtraEditors.TextEdit txtRazSocTransportador;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbTpDocTransportador;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCnpjTransport;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtUfTranspo;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtMunicipioTranporta;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtCompEndTransp;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtNumEndTransp;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtEndTransp;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtIETransp;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.TextEdit txtMuncTransporta;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidadorNF;
        private DevExpress.XtraEditors.LabelControl lbMensagem;
    }
}