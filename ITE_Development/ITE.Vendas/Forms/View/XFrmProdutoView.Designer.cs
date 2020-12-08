namespace ITE.Vendas.Forms.Informativo
{
    partial class XFrmDetalhesProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmDetalhesProduto));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnTransacoes = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCarregarTransacoes = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRecEstoque = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navDadosFiscais = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navPagDadosProdutos = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.chEditar = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoBarras = new DevExpress.XtraEditors.TextEdit();
            this.btnQtdPrd = new DevExpress.XtraEditors.ButtonEdit();
            this.radioTipoProduto = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtMargemLucro = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecoVenda = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecoCompra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.pictureFotoProduto = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtCadastro = new DevExpress.XtraEditors.DateEdit();
            this.cbUnidadeMed = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbCategoriaProduto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbStatusProduto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbStatus = new DevExpress.XtraEditors.LabelControl();
            this.lbCategoria = new DevExpress.XtraEditors.LabelControl();
            this.lbDescricao = new DevExpress.XtraEditors.LabelControl();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.navigationPageDadosComplementares = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeso = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtAcabamento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtCor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtEspessura2 = new DevExpress.XtraEditors.TextEdit();
            this.txtEspessura1 = new DevExpress.XtraEditors.TextEdit();
            this.txtLargura = new DevExpress.XtraEditors.TextEdit();
            this.txtComprimento = new DevExpress.XtraEditors.TextEdit();
            this.navPageTransactions = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlTransacoes = new DevExpress.XtraGrid.GridControl();
            this.bsTransacoesProduto = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTra = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDataTransacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoTransacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.naPagAlteracoes = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlAlteracoes = new DevExpress.XtraGrid.GridControl();
            this.bsAlteracaoProduto = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewAlteracoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDataAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentualDescontoPromocao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoCompraAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoVendaAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQtdAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navigationPageDadosFiscais = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnNcm = new DevExpress.XtraEditors.ButtonEdit();
            this.cbTipoItem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSaldoLoc = new DevExpress.XtraGrid.GridControl();
            this.gridViewSaldoLoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sldColLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sldColQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sldColValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSaldoFisico2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecoMedioVendas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustoMedio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldoEstoque = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.rdTipoProduto = new DevExpress.XtraEditors.RadioGroup();
            this.txtCategoria = new DevExpress.XtraEditors.TextEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlEntradas = new DevExpress.XtraGrid.GridControl();
            this.gridViewEntradas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSaidas = new DevExpress.XtraGrid.GridControl();
            this.gridViewSaidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navDadosFiscais)).BeginInit();
            this.navDadosFiscais.SuspendLayout();
            this.navPagDadosProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chEditar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQtdPrd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioTipoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargemLucro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCadastro.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCadastro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadeMed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoriaProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            this.navigationPageDadosComplementares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcabamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEspessura2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEspessura1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLargura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprimento.Properties)).BeginInit();
            this.navPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransacoesProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTra)).BeginInit();
            this.naPagAlteracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlteracoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlteracaoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAlteracoes)).BeginInit();
            this.navigationPageDadosFiscais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNcm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoItem.Properties)).BeginInit();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSaldoLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaldoLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoFisico2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoMedioVendas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoMedio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSaidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnSalvar,
            this.barBtnTransacoes,
            this.barBtnCarregarTransacoes,
            this.barBtnCancelar,
            this.barBtnRecEstoque,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(812, 166);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnSalvar
            // 
            this.barBtnSalvar.Caption = "Salvar";
            this.barBtnSalvar.Id = 1;
            this.barBtnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.ImageOptions.Image")));
            this.barBtnSalvar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.barBtnSalvar.Name = "barBtnSalvar";
            this.barBtnSalvar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalvar_ItemClick);
            // 
            // barBtnTransacoes
            // 
            this.barBtnTransacoes.Caption = "Nova Transação";
            this.barBtnTransacoes.Id = 2;
            this.barBtnTransacoes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnTransacoes.ImageOptions.Image")));
            this.barBtnTransacoes.Name = "barBtnTransacoes";
            this.barBtnTransacoes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnTransacoes.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barBtnCarregarTransacoes
            // 
            this.barBtnCarregarTransacoes.Caption = "Carregar Transações";
            this.barBtnCarregarTransacoes.Id = 3;
            this.barBtnCarregarTransacoes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCarregarTransacoes.ImageOptions.Image")));
            this.barBtnCarregarTransacoes.Name = "barBtnCarregarTransacoes";
            this.barBtnCarregarTransacoes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCarregarTransacoes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCarregarTransacoes_ItemClick);
            // 
            // barBtnCancelar
            // 
            this.barBtnCancelar.Caption = "Cancelar";
            this.barBtnCancelar.Id = 4;
            this.barBtnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.ImageOptions.Image")));
            this.barBtnCancelar.Name = "barBtnCancelar";
            this.barBtnCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelar_ItemClick);
            // 
            // barBtnRecEstoque
            // 
            this.barBtnRecEstoque.Caption = "Recalcula Estoque geral";
            this.barBtnRecEstoque.Id = 5;
            this.barBtnRecEstoque.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRecEstoque.ImageOptions.Image")));
            this.barBtnRecEstoque.Name = "barBtnRecEstoque";
            this.barBtnRecEstoque.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnRecEstoque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnRecEstoque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRecEstoque_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Transações";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSalvar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnTransacoes);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRecEstoque);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCarregarTransacoes);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Transações";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 503);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(812, 25);
            // 
            // navDadosFiscais
            // 
            this.navDadosFiscais.Controls.Add(this.navPagDadosProdutos);
            this.navDadosFiscais.Controls.Add(this.navigationPageDadosComplementares);
            this.navDadosFiscais.Controls.Add(this.navPageTransactions);
            this.navDadosFiscais.Controls.Add(this.naPagAlteracoes);
            this.navDadosFiscais.Controls.Add(this.navigationPageDadosFiscais);
            this.navDadosFiscais.Controls.Add(this.navigationPage1);
            this.navDadosFiscais.Controls.Add(this.navigationPage2);
            this.navDadosFiscais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navDadosFiscais.Location = new System.Drawing.Point(0, 166);
            this.navDadosFiscais.Name = "navDadosFiscais";
            this.navDadosFiscais.PageProperties.ShowCollapseButton = false;
            this.navDadosFiscais.PageProperties.ShowExpandButton = false;
            this.navDadosFiscais.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPagDadosProdutos,
            this.navigationPageDadosComplementares,
            this.navigationPageDadosFiscais,
            this.navPageTransactions,
            this.naPagAlteracoes,
            this.navigationPage1,
            this.navigationPage2});
            this.navDadosFiscais.RegularSize = new System.Drawing.Size(812, 337);
            this.navDadosFiscais.SelectedPage = this.navPagDadosProdutos;
            this.navDadosFiscais.Size = new System.Drawing.Size(812, 337);
            this.navDadosFiscais.TabIndex = 30;
            this.navDadosFiscais.Text = "Dados do Produto";
            // 
            // navPagDadosProdutos
            // 
            this.navPagDadosProdutos.Caption = "Dados Básicos";
            this.navPagDadosProdutos.Controls.Add(this.chEditar);
            this.navPagDadosProdutos.Controls.Add(this.labelControl10);
            this.navPagDadosProdutos.Controls.Add(this.txtCodigoBarras);
            this.navPagDadosProdutos.Controls.Add(this.btnQtdPrd);
            this.navPagDadosProdutos.Controls.Add(this.radioTipoProduto);
            this.navPagDadosProdutos.Controls.Add(this.labelControl7);
            this.navPagDadosProdutos.Controls.Add(this.txtMargemLucro);
            this.navPagDadosProdutos.Controls.Add(this.txtPrecoVenda);
            this.navPagDadosProdutos.Controls.Add(this.txtPrecoCompra);
            this.navPagDadosProdutos.Controls.Add(this.labelControl5);
            this.navPagDadosProdutos.Controls.Add(this.labelControl4);
            this.navPagDadosProdutos.Controls.Add(this.labelControl3);
            this.navPagDadosProdutos.Controls.Add(this.labelControl1);
            this.navPagDadosProdutos.Controls.Add(this.groupControl5);
            this.navPagDadosProdutos.Controls.Add(this.labelControl6);
            this.navPagDadosProdutos.Controls.Add(this.dtCadastro);
            this.navPagDadosProdutos.Controls.Add(this.cbUnidadeMed);
            this.navPagDadosProdutos.Controls.Add(this.labelControl2);
            this.navPagDadosProdutos.Controls.Add(this.cbCategoriaProduto);
            this.navPagDadosProdutos.Controls.Add(this.cbStatusProduto);
            this.navPagDadosProdutos.Controls.Add(this.lbStatus);
            this.navPagDadosProdutos.Controls.Add(this.lbCategoria);
            this.navPagDadosProdutos.Controls.Add(this.lbDescricao);
            this.navPagDadosProdutos.Controls.Add(this.txtDescricao);
            this.navPagDadosProdutos.Name = "navPagDadosProdutos";
            this.navPagDadosProdutos.Size = new System.Drawing.Size(638, 265);
            // 
            // chEditar
            // 
            this.chEditar.Location = new System.Drawing.Point(350, 121);
            this.chEditar.MenuManager = this.ribbon;
            this.chEditar.Name = "chEditar";
            this.chEditar.Properties.Caption = "Editar";
            this.chEditar.Size = new System.Drawing.Size(56, 21);
            this.chEditar.TabIndex = 78;
            this.chEditar.CheckedChanged += new System.EventHandler(this.chEditar_CheckedChanged);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(280, 68);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(67, 13);
            this.labelControl10.TabIndex = 77;
            this.labelControl10.Text = "Código Barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(280, 86);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoBarras.MenuManager = this.ribbon;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(125, 20);
            this.txtCodigoBarras.TabIndex = 2;
            // 
            // btnQtdPrd
            // 
            this.btnQtdPrd.EditValue = "";
            this.btnQtdPrd.Location = new System.Drawing.Point(263, 260);
            this.btnQtdPrd.MenuManager = this.ribbon;
            this.btnQtdPrd.Name = "btnQtdPrd";
            this.btnQtdPrd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnQtdPrd.Properties.Mask.EditMask = "n";
            this.btnQtdPrd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.btnQtdPrd.Properties.ReadOnly = true;
            this.btnQtdPrd.Size = new System.Drawing.Size(103, 20);
            this.btnQtdPrd.TabIndex = 9;
            this.btnQtdPrd.Click += new System.EventHandler(this.btnQtdPrd_Click);
            // 
            // radioTipoProduto
            // 
            this.radioTipoProduto.EditValue = 0;
            this.radioTipoProduto.Location = new System.Drawing.Point(13, 83);
            this.radioTipoProduto.MenuManager = this.ribbon;
            this.radioTipoProduto.Name = "radioTipoProduto";
            this.radioTipoProduto.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Produto"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Serviço")});
            this.radioTipoProduto.Size = new System.Drawing.Size(237, 25);
            this.radioTipoProduto.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 64);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(80, 13);
            this.labelControl7.TabIndex = 74;
            this.labelControl7.Text = "Tipo de produto:";
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.Location = new System.Drawing.Point(394, 260);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Properties.Mask.EditMask = "n";
            this.txtMargemLucro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMargemLucro.Size = new System.Drawing.Size(103, 20);
            this.txtMargemLucro.TabIndex = 10;
            this.txtMargemLucro.Leave += new System.EventHandler(this.txtMargemLucro_Leave);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Location = new System.Drawing.Point(137, 260);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Properties.Mask.EditMask = "n";
            this.txtPrecoVenda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecoVenda.Size = new System.Drawing.Size(103, 20);
            this.txtPrecoVenda.TabIndex = 8;
            this.txtPrecoVenda.Leave += new System.EventHandler(this.txtPrecoVenda_Leave);
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.Location = new System.Drawing.Point(13, 260);
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Properties.Mask.EditMask = "n";
            this.txtPrecoCompra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecoCompra.Size = new System.Drawing.Size(103, 20);
            this.txtPrecoCompra.TabIndex = 7;
            this.txtPrecoCompra.Leave += new System.EventHandler(this.txtPrecoCompra_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(263, 240);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 69;
            this.labelControl5.Text = "Estoque";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(394, 240);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 13);
            this.labelControl4.TabIndex = 68;
            this.labelControl4.Text = "Margem de lucro";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(137, 240);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 67;
            this.labelControl3.Text = "Preço de Venda";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 240);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "Preço de Compra";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.pictureFotoProduto);
            this.groupControl5.Location = new System.Drawing.Point(421, 12);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(219, 207);
            this.groupControl5.TabIndex = 65;
            this.groupControl5.Text = "Foto (opcional)";
            this.groupControl5.DoubleClick += new System.EventHandler(this.groupControl5_DoubleClick);
            // 
            // pictureFotoProduto
            // 
            this.pictureFotoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureFotoProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureFotoProduto.Location = new System.Drawing.Point(2, 25);
            this.pictureFotoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureFotoProduto.Name = "pictureFotoProduto";
            this.pictureFotoProduto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureFotoProduto.Properties.Appearance.Options.UseBackColor = true;
            this.pictureFotoProduto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureFotoProduto.Size = new System.Drawing.Size(215, 180);
            this.pictureFotoProduto.TabIndex = 11;
            this.pictureFotoProduto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureFotoProduto_MouseClick);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(263, 181);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 13);
            this.labelControl6.TabIndex = 64;
            this.labelControl6.Text = "Data de cadastro";
            // 
            // dtCadastro
            // 
            this.dtCadastro.EditValue = null;
            this.dtCadastro.Location = new System.Drawing.Point(263, 199);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCadastro.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCadastro.Properties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.dtCadastro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtCadastro.Properties.ReadOnly = true;
            this.dtCadastro.Size = new System.Drawing.Size(142, 20);
            this.dtCadastro.TabIndex = 6;
            // 
            // cbUnidadeMed
            // 
            this.cbUnidadeMed.Location = new System.Drawing.Point(13, 199);
            this.cbUnidadeMed.Name = "cbUnidadeMed";
            this.cbUnidadeMed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidadeMed.Size = new System.Drawing.Size(109, 20);
            this.cbUnidadeMed.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 13);
            this.labelControl2.TabIndex = 62;
            this.labelControl2.Text = "Unidade de medida";
            // 
            // cbCategoriaProduto
            // 
            this.cbCategoriaProduto.Location = new System.Drawing.Point(13, 30);
            this.cbCategoriaProduto.Name = "cbCategoriaProduto";
            this.cbCategoriaProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCategoriaProduto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbCategoriaProduto.Size = new System.Drawing.Size(394, 20);
            this.cbCategoriaProduto.TabIndex = 0;
            // 
            // cbStatusProduto
            // 
            this.cbStatusProduto.Location = new System.Drawing.Point(137, 199);
            this.cbStatusProduto.Name = "cbStatusProduto";
            this.cbStatusProduto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatusProduto.Properties.Items.AddRange(new object[] {
            "Ativo",
            "Inativo",
            "Sem estoque"});
            this.cbStatusProduto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbStatusProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbStatusProduto.Size = new System.Drawing.Size(104, 20);
            this.cbStatusProduto.TabIndex = 5;
            // 
            // lbStatus
            // 
            this.lbStatus.Location = new System.Drawing.Point(137, 181);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(31, 13);
            this.lbStatus.TabIndex = 61;
            this.lbStatus.Text = "Status";
            // 
            // lbCategoria
            // 
            this.lbCategoria.Location = new System.Drawing.Point(13, 12);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(47, 13);
            this.lbCategoria.TabIndex = 60;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbDescricao
            // 
            this.lbDescricao.Location = new System.Drawing.Point(13, 127);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(46, 13);
            this.lbDescricao.TabIndex = 59;
            this.lbDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(13, 145);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(393, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // navigationPageDadosComplementares
            // 
            this.navigationPageDadosComplementares.Caption = "Dados Complementares";
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl11);
            this.navigationPageDadosComplementares.Controls.Add(this.txtPeso);
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl20);
            this.navigationPageDadosComplementares.Controls.Add(this.txtAcabamento);
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl19);
            this.navigationPageDadosComplementares.Controls.Add(this.txtCor);
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl12);
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl13);
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl14);
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl15);
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl16);
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl17);
            this.navigationPageDadosComplementares.Controls.Add(this.labelControl18);
            this.navigationPageDadosComplementares.Controls.Add(this.txtEspessura2);
            this.navigationPageDadosComplementares.Controls.Add(this.txtEspessura1);
            this.navigationPageDadosComplementares.Controls.Add(this.txtLargura);
            this.navigationPageDadosComplementares.Controls.Add(this.txtComprimento);
            this.navigationPageDadosComplementares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationPageDadosComplementares.Name = "navigationPageDadosComplementares";
            this.navigationPageDadosComplementares.Size = new System.Drawing.Size(665, 308);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(331, 123);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(23, 13);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(331, 141);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtPeso.Properties.Appearance.Options.UseFont = true;
            this.txtPeso.Properties.Mask.EditMask = "n2";
            this.txtPeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPeso.Size = new System.Drawing.Size(69, 20);
            this.txtPeso.TabIndex = 19;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(13, 123);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(60, 13);
            this.labelControl20.TabIndex = 29;
            this.labelControl20.Text = "Acabamento";
            // 
            // txtAcabamento
            // 
            this.txtAcabamento.Location = new System.Drawing.Point(13, 141);
            this.txtAcabamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAcabamento.Name = "txtAcabamento";
            this.txtAcabamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtAcabamento.Properties.Appearance.Options.UseFont = true;
            this.txtAcabamento.Properties.Mask.EditMask = "n2";
            this.txtAcabamento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAcabamento.Size = new System.Drawing.Size(273, 20);
            this.txtAcabamento.TabIndex = 18;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(13, 66);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(17, 13);
            this.labelControl19.TabIndex = 27;
            this.labelControl19.Text = "Cor";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(13, 84);
            this.txtCor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCor.Name = "txtCor";
            this.txtCor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtCor.Properties.Appearance.Options.UseFont = true;
            this.txtCor.Properties.Mask.EditMask = "n2";
            this.txtCor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCor.Size = new System.Drawing.Size(273, 20);
            this.txtCor.TabIndex = 17;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(307, 32);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(13, 14);
            this.labelControl12.TabIndex = 24;
            this.labelControl12.Text = " ~";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(201, 32);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(14, 14);
            this.labelControl13.TabIndex = 23;
            this.labelControl13.Text = " x ";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(95, 32);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(14, 14);
            this.labelControl14.TabIndex = 22;
            this.labelControl14.Text = " x ";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(331, 12);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(64, 14);
            this.labelControl15.TabIndex = 21;
            this.labelControl15.Text = "Espessura 1";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(226, 12);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(64, 14);
            this.labelControl16.TabIndex = 20;
            this.labelControl16.Text = "Espessura 1";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(121, 12);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(40, 14);
            this.labelControl17.TabIndex = 19;
            this.labelControl17.Text = "Largura";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(13, 12);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(73, 14);
            this.labelControl18.TabIndex = 18;
            this.labelControl18.Text = "Comprimento";
            // 
            // txtEspessura2
            // 
            this.txtEspessura2.Location = new System.Drawing.Point(331, 30);
            this.txtEspessura2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEspessura2.Name = "txtEspessura2";
            this.txtEspessura2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtEspessura2.Properties.Appearance.Options.UseFont = true;
            this.txtEspessura2.Size = new System.Drawing.Size(69, 20);
            this.txtEspessura2.TabIndex = 16;
            // 
            // txtEspessura1
            // 
            this.txtEspessura1.Location = new System.Drawing.Point(226, 30);
            this.txtEspessura1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEspessura1.Name = "txtEspessura1";
            this.txtEspessura1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtEspessura1.Properties.Appearance.Options.UseFont = true;
            this.txtEspessura1.Size = new System.Drawing.Size(69, 20);
            this.txtEspessura1.TabIndex = 15;
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(121, 30);
            this.txtLargura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtLargura.Properties.Appearance.Options.UseFont = true;
            this.txtLargura.Size = new System.Drawing.Size(69, 20);
            this.txtLargura.TabIndex = 14;
            // 
            // txtComprimento
            // 
            this.txtComprimento.Location = new System.Drawing.Point(13, 30);
            this.txtComprimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtComprimento.Properties.Appearance.Options.UseFont = true;
            this.txtComprimento.Size = new System.Drawing.Size(69, 20);
            this.txtComprimento.TabIndex = 13;
            // 
            // navPageTransactions
            // 
            this.navPageTransactions.Caption = "Transações";
            this.navPageTransactions.Controls.Add(this.gridControlTransacoes);
            this.navPageTransactions.Name = "navPageTransactions";
            this.navPageTransactions.Size = new System.Drawing.Size(665, 308);
            // 
            // gridControlTransacoes
            // 
            this.gridControlTransacoes.DataSource = this.bsTransacoesProduto;
            this.gridControlTransacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTransacoes.Location = new System.Drawing.Point(0, 0);
            this.gridControlTransacoes.MainView = this.gridViewTra;
            this.gridControlTransacoes.MenuManager = this.ribbon;
            this.gridControlTransacoes.Name = "gridControlTransacoes";
            this.gridControlTransacoes.Size = new System.Drawing.Size(665, 308);
            this.gridControlTransacoes.TabIndex = 0;
            this.gridControlTransacoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTra});
            // 
            // gridViewTra
            // 
            this.gridViewTra.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDataTransacao,
            this.colTipoTransacao,
            this.colValorUnitario,
            this.colValorTotal,
            this.colQuantidade,
            this.colObservacao,
            this.colProduto,
            this.colLocalEstoque});
            this.gridViewTra.GridControl = this.gridControlTransacoes;
            this.gridViewTra.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorUnitario", this.colValorUnitario, "{0:0.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorTotal", this.colValorTotal, "{0:0.00}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantidade", this.colQuantidade, "{0:0.00}")});
            this.gridViewTra.Name = "gridViewTra";
            this.gridViewTra.OptionsBehavior.Editable = false;
            this.gridViewTra.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewTra.OptionsView.ShowFooter = true;
            this.gridViewTra.OptionsView.ShowGroupPanel = false;
            // 
            // colDataTransacao
            // 
            this.colDataTransacao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataTransacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataTransacao.Caption = "Data";
            this.colDataTransacao.FieldName = "DataTransacao";
            this.colDataTransacao.Name = "colDataTransacao";
            this.colDataTransacao.Visible = true;
            this.colDataTransacao.VisibleIndex = 0;
            this.colDataTransacao.Width = 84;
            // 
            // colTipoTransacao
            // 
            this.colTipoTransacao.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoTransacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoTransacao.Caption = "Tipo";
            this.colTipoTransacao.FieldName = "TipoTransacao";
            this.colTipoTransacao.Name = "colTipoTransacao";
            this.colTipoTransacao.Visible = true;
            this.colTipoTransacao.VisibleIndex = 1;
            this.colTipoTransacao.Width = 98;
            // 
            // colValorUnitario
            // 
            this.colValorUnitario.AppearanceCell.Options.UseTextOptions = true;
            this.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorUnitario.Caption = "Valor Unit.";
            this.colValorUnitario.FieldName = "ValorUnitario";
            this.colValorUnitario.Name = "colValorUnitario";
            this.colValorUnitario.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorUnitario", "{0:0.00}")});
            this.colValorUnitario.Visible = true;
            this.colValorUnitario.VisibleIndex = 3;
            this.colValorUnitario.Width = 87;
            // 
            // colValorTotal
            // 
            this.colValorTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colValorTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorTotal.FieldName = "ValorTotal";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorTotal", "{0:0.00}")});
            this.colValorTotal.Visible = true;
            this.colValorTotal.VisibleIndex = 4;
            this.colValorTotal.Width = 74;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantidade", "{0:0.00}")});
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 2;
            this.colQuantidade.Width = 76;
            // 
            // colObservacao
            // 
            this.colObservacao.AppearanceCell.Options.UseTextOptions = true;
            this.colObservacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.Caption = "Observação";
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 5;
            this.colObservacao.Width = 218;
            // 
            // colProduto
            // 
            this.colProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colProduto.FieldName = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.Width = 64;
            // 
            // colLocalEstoque
            // 
            this.colLocalEstoque.AppearanceCell.Options.UseTextOptions = true;
            this.colLocalEstoque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colLocalEstoque.FieldName = "LocalEstoque";
            this.colLocalEstoque.Name = "colLocalEstoque";
            this.colLocalEstoque.Visible = true;
            this.colLocalEstoque.VisibleIndex = 6;
            this.colLocalEstoque.Width = 96;
            // 
            // naPagAlteracoes
            // 
            this.naPagAlteracoes.Caption = "Alterações";
            this.naPagAlteracoes.Controls.Add(this.gridControlAlteracoes);
            this.naPagAlteracoes.Name = "naPagAlteracoes";
            this.naPagAlteracoes.Size = new System.Drawing.Size(665, 308);
            // 
            // gridControlAlteracoes
            // 
            this.gridControlAlteracoes.DataSource = this.bsAlteracaoProduto;
            this.gridControlAlteracoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAlteracoes.Location = new System.Drawing.Point(0, 0);
            this.gridControlAlteracoes.MainView = this.gridViewAlteracoes;
            this.gridControlAlteracoes.MenuManager = this.ribbon;
            this.gridControlAlteracoes.Name = "gridControlAlteracoes";
            this.gridControlAlteracoes.Size = new System.Drawing.Size(665, 308);
            this.gridControlAlteracoes.TabIndex = 0;
            this.gridControlAlteracoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAlteracoes});
            // 
            // gridViewAlteracoes
            // 
            this.gridViewAlteracoes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDataAlteracao,
            this.colTipoAlteracao,
            this.colPercentualDescontoPromocao,
            this.colPrecoCompraAnterior,
            this.colPrecoVendaAnterior,
            this.colQtdAnterior});
            this.gridViewAlteracoes.GridControl = this.gridControlAlteracoes;
            this.gridViewAlteracoes.Name = "gridViewAlteracoes";
            this.gridViewAlteracoes.OptionsBehavior.Editable = false;
            this.gridViewAlteracoes.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewAlteracoes.OptionsView.ShowGroupPanel = false;
            // 
            // colDataAlteracao
            // 
            this.colDataAlteracao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataAlteracao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataAlteracao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataAlteracao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataAlteracao.Caption = "Data Alteração";
            this.colDataAlteracao.FieldName = "DataAlteracao";
            this.colDataAlteracao.Name = "colDataAlteracao";
            this.colDataAlteracao.Visible = true;
            this.colDataAlteracao.VisibleIndex = 0;
            this.colDataAlteracao.Width = 111;
            // 
            // colTipoAlteracao
            // 
            this.colTipoAlteracao.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoAlteracao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoAlteracao.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoAlteracao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoAlteracao.Caption = "Tipo Alteração";
            this.colTipoAlteracao.FieldName = "TipoAlteracao";
            this.colTipoAlteracao.Name = "colTipoAlteracao";
            this.colTipoAlteracao.Visible = true;
            this.colTipoAlteracao.VisibleIndex = 1;
            this.colTipoAlteracao.Width = 116;
            // 
            // colPercentualDescontoPromocao
            // 
            this.colPercentualDescontoPromocao.AppearanceCell.Options.UseTextOptions = true;
            this.colPercentualDescontoPromocao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPercentualDescontoPromocao.AppearanceHeader.Options.UseTextOptions = true;
            this.colPercentualDescontoPromocao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPercentualDescontoPromocao.Caption = "% Desconto Promoção";
            this.colPercentualDescontoPromocao.FieldName = "PercentualDescontoPromocao";
            this.colPercentualDescontoPromocao.Name = "colPercentualDescontoPromocao";
            this.colPercentualDescontoPromocao.Visible = true;
            this.colPercentualDescontoPromocao.VisibleIndex = 5;
            this.colPercentualDescontoPromocao.Width = 166;
            // 
            // colPrecoCompraAnterior
            // 
            this.colPrecoCompraAnterior.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoCompraAnterior.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoCompraAnterior.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecoCompraAnterior.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoCompraAnterior.Caption = "Preço Compra";
            this.colPrecoCompraAnterior.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoCompraAnterior.FieldName = "PrecoCompraAnterior";
            this.colPrecoCompraAnterior.Name = "colPrecoCompraAnterior";
            this.colPrecoCompraAnterior.Visible = true;
            this.colPrecoCompraAnterior.VisibleIndex = 2;
            this.colPrecoCompraAnterior.Width = 129;
            // 
            // colPrecoVendaAnterior
            // 
            this.colPrecoVendaAnterior.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoVendaAnterior.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoVendaAnterior.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecoVendaAnterior.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoVendaAnterior.Caption = "Preço Venda";
            this.colPrecoVendaAnterior.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoVendaAnterior.FieldName = "PrecoVendaAnterior";
            this.colPrecoVendaAnterior.Name = "colPrecoVendaAnterior";
            this.colPrecoVendaAnterior.Visible = true;
            this.colPrecoVendaAnterior.VisibleIndex = 3;
            this.colPrecoVendaAnterior.Width = 129;
            // 
            // colQtdAnterior
            // 
            this.colQtdAnterior.AppearanceCell.Options.UseTextOptions = true;
            this.colQtdAnterior.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQtdAnterior.AppearanceHeader.Options.UseTextOptions = true;
            this.colQtdAnterior.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQtdAnterior.Caption = "Quantidade ";
            this.colQtdAnterior.FieldName = "QtdAnterior";
            this.colQtdAnterior.Name = "colQtdAnterior";
            this.colQtdAnterior.Visible = true;
            this.colQtdAnterior.VisibleIndex = 4;
            this.colQtdAnterior.Width = 97;
            // 
            // navigationPageDadosFiscais
            // 
            this.navigationPageDadosFiscais.Caption = "Dados Fiscais";
            this.navigationPageDadosFiscais.Controls.Add(this.btnNcm);
            this.navigationPageDadosFiscais.Controls.Add(this.cbTipoItem);
            this.navigationPageDadosFiscais.Controls.Add(this.labelControl9);
            this.navigationPageDadosFiscais.Controls.Add(this.labelControl8);
            this.navigationPageDadosFiscais.Name = "navigationPageDadosFiscais";
            this.navigationPageDadosFiscais.Properties.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPageDadosFiscais.Properties.ShowExpandButton = DevExpress.Utils.DefaultBoolean.False;
            this.navigationPageDadosFiscais.Size = new System.Drawing.Size(661, 307);
            // 
            // btnNcm
            // 
            this.btnNcm.Location = new System.Drawing.Point(20, 92);
            this.btnNcm.MenuManager = this.ribbon;
            this.btnNcm.Name = "btnNcm";
            this.btnNcm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnNcm.Size = new System.Drawing.Size(158, 20);
            this.btnNcm.TabIndex = 23;
            this.btnNcm.Click += new System.EventHandler(this.btnNcm_Click);
            // 
            // cbTipoItem
            // 
            this.cbTipoItem.Location = new System.Drawing.Point(20, 37);
            this.cbTipoItem.MenuManager = this.ribbon;
            this.cbTipoItem.Name = "cbTipoItem";
            this.cbTipoItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoItem.Properties.NullText = "Selecione o tipo de item";
            this.cbTipoItem.Size = new System.Drawing.Size(158, 20);
            this.cbTipoItem.TabIndex = 20;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(20, 73);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(26, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "NCM:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(20, 18);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(95, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Tipo de item (EFD): ";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Saldos e Custos";
            this.navigationPage1.Controls.Add(this.groupControl3);
            this.navigationPage1.Controls.Add(this.txtSaldoFisico2);
            this.navigationPage1.Controls.Add(this.labelControl21);
            this.navigationPage1.Controls.Add(this.txtPrecoMedioVendas);
            this.navigationPage1.Controls.Add(this.labelControl22);
            this.navigationPage1.Controls.Add(this.txtCustoMedio);
            this.navigationPage1.Controls.Add(this.labelControl23);
            this.navigationPage1.Controls.Add(this.txtSaldoEstoque);
            this.navigationPage1.Controls.Add(this.labelControl24);
            this.navigationPage1.Controls.Add(this.rdTipoProduto);
            this.navigationPage1.Controls.Add(this.txtCategoria);
            this.navigationPage1.Controls.Add(this.labelControl25);
            this.navigationPage1.Controls.Add(this.labelControl26);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(665, 308);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControlSaldoLoc);
            this.groupControl3.Location = new System.Drawing.Point(320, 117);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(333, 122);
            this.groupControl3.TabIndex = 22;
            this.groupControl3.Text = "Saldo por local de estoque";
            // 
            // gridControlSaldoLoc
            // 
            this.gridControlSaldoLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSaldoLoc.Location = new System.Drawing.Point(2, 25);
            this.gridControlSaldoLoc.MainView = this.gridViewSaldoLoc;
            this.gridControlSaldoLoc.Name = "gridControlSaldoLoc";
            this.gridControlSaldoLoc.Size = new System.Drawing.Size(329, 95);
            this.gridControlSaldoLoc.TabIndex = 8;
            this.gridControlSaldoLoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSaldoLoc});
            // 
            // gridViewSaldoLoc
            // 
            this.gridViewSaldoLoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.sldColLocalEstoque,
            this.sldColQuantidade,
            this.sldColValor});
            this.gridViewSaldoLoc.GridControl = this.gridControlSaldoLoc;
            this.gridViewSaldoLoc.Name = "gridViewSaldoLoc";
            this.gridViewSaldoLoc.OptionsBehavior.Editable = false;
            this.gridViewSaldoLoc.OptionsView.ShowGroupPanel = false;
            // 
            // sldColLocalEstoque
            // 
            this.sldColLocalEstoque.Caption = "Local Estoque";
            this.sldColLocalEstoque.FieldName = "CodigoLocal";
            this.sldColLocalEstoque.Name = "sldColLocalEstoque";
            this.sldColLocalEstoque.Visible = true;
            this.sldColLocalEstoque.VisibleIndex = 0;
            this.sldColLocalEstoque.Width = 77;
            // 
            // sldColQuantidade
            // 
            this.sldColQuantidade.Caption = "Quantidade";
            this.sldColQuantidade.DisplayFormat.FormatString = "N3";
            this.sldColQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sldColQuantidade.FieldName = "Quantidade";
            this.sldColQuantidade.Name = "sldColQuantidade";
            this.sldColQuantidade.Visible = true;
            this.sldColQuantidade.VisibleIndex = 1;
            this.sldColQuantidade.Width = 97;
            // 
            // sldColValor
            // 
            this.sldColValor.Caption = "Valor";
            this.sldColValor.DisplayFormat.FormatString = "N3";
            this.sldColValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sldColValor.FieldName = "Valor";
            this.sldColValor.Name = "sldColValor";
            this.sldColValor.Visible = true;
            this.sldColValor.VisibleIndex = 2;
            this.sldColValor.Width = 120;
            // 
            // txtSaldoFisico2
            // 
            this.txtSaldoFisico2.Location = new System.Drawing.Point(322, 82);
            this.txtSaldoFisico2.Name = "txtSaldoFisico2";
            this.txtSaldoFisico2.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoFisico2.TabIndex = 18;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(322, 63);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(84, 13);
            this.labelControl21.TabIndex = 25;
            this.labelControl21.Text = "Saldo físico geral:";
            // 
            // txtPrecoMedioVendas
            // 
            this.txtPrecoMedioVendas.Location = new System.Drawing.Point(322, 37);
            this.txtPrecoMedioVendas.Name = "txtPrecoMedioVendas";
            this.txtPrecoMedioVendas.Size = new System.Drawing.Size(145, 20);
            this.txtPrecoMedioVendas.TabIndex = 17;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(322, 18);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(115, 13);
            this.labelControl22.TabIndex = 24;
            this.labelControl22.Text = "Preço médio de vendas:";
            // 
            // txtCustoMedio
            // 
            this.txtCustoMedio.Location = new System.Drawing.Point(15, 37);
            this.txtCustoMedio.Name = "txtCustoMedio";
            this.txtCustoMedio.Size = new System.Drawing.Size(145, 20);
            this.txtCustoMedio.TabIndex = 13;
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(15, 18);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(110, 13);
            this.labelControl23.TabIndex = 23;
            this.labelControl23.Text = "Custo médio aquisição:";
            // 
            // txtSaldoEstoque
            // 
            this.txtSaldoEstoque.Location = new System.Drawing.Point(15, 219);
            this.txtSaldoEstoque.Name = "txtSaldoEstoque";
            this.txtSaldoEstoque.Size = new System.Drawing.Size(203, 20);
            this.txtSaldoEstoque.TabIndex = 20;
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(15, 200);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(89, 13);
            this.labelControl24.TabIndex = 21;
            this.labelControl24.Text = "Saldo em estoque:";
            // 
            // rdTipoProduto
            // 
            this.rdTipoProduto.Location = new System.Drawing.Point(15, 136);
            this.rdTipoProduto.Name = "rdTipoProduto";
            this.rdTipoProduto.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Produto"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Serviço")});
            this.rdTipoProduto.Size = new System.Drawing.Size(203, 27);
            this.rdTipoProduto.TabIndex = 19;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(15, 82);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(145, 20);
            this.txtCategoria.TabIndex = 15;
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(15, 117);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(65, 13);
            this.labelControl25.TabIndex = 16;
            this.labelControl25.Text = "Tipo produto:";
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(15, 63);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(51, 13);
            this.labelControl26.TabIndex = 14;
            this.labelControl26.Text = "Categoria:";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Movimentações";
            this.navigationPage2.Controls.Add(this.splitContainerControl1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(665, 308);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(665, 308);
            this.splitContainerControl1.SplitterPosition = 126;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlEntradas);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(665, 126);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Entradas";
            // 
            // gridControlEntradas
            // 
            this.gridControlEntradas.DataSource = this.bsTransacoesProduto;
            this.gridControlEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEntradas.Location = new System.Drawing.Point(2, 25);
            this.gridControlEntradas.MainView = this.gridViewEntradas;
            this.gridControlEntradas.Name = "gridControlEntradas";
            this.gridControlEntradas.Size = new System.Drawing.Size(661, 99);
            this.gridControlEntradas.TabIndex = 0;
            this.gridControlEntradas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEntradas});
            // 
            // gridViewEntradas
            // 
            this.gridViewEntradas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colIdVenda,
            this.gridColumn5,
            this.colMovimento});
            this.gridViewEntradas.GridControl = this.gridControlEntradas;
            this.gridViewEntradas.Name = "gridViewEntradas";
            this.gridViewEntradas.OptionsBehavior.Editable = false;
            this.gridViewEntradas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewEntradas.OptionsView.ColumnAutoWidth = false;
            this.gridViewEntradas.OptionsView.ShowFooter = true;
            this.gridViewEntradas.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Data";
            this.gridColumn1.FieldName = "DataTransacao";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Valor";
            this.gridColumn2.FieldName = "ValorTotal";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 92;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Quantidade";
            this.gridColumn3.DisplayFormat.FormatString = "N2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "Quantidade";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantidade", "Entradas: {0:0.##}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 135;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Observação";
            this.gridColumn4.FieldName = "Observacao";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 128;
            // 
            // colIdVenda
            // 
            this.colIdVenda.Caption = "Nº Venda";
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.Visible = true;
            this.colIdVenda.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Local de Estoque";
            this.gridColumn5.FieldName = "LocalEstoque.CodigoLocalEstoque";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 101;
            // 
            // colMovimento
            // 
            this.colMovimento.Caption = "Nº Mov.";
            this.colMovimento.FieldName = "Movimento.NumeroMovimento";
            this.colMovimento.Name = "colMovimento";
            this.colMovimento.Visible = true;
            this.colMovimento.VisibleIndex = 6;
            this.colMovimento.Width = 133;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlSaidas);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(665, 171);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Saídas";
            // 
            // gridControlSaidas
            // 
            this.gridControlSaidas.DataSource = this.bsTransacoesProduto;
            this.gridControlSaidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSaidas.Location = new System.Drawing.Point(2, 25);
            this.gridControlSaidas.MainView = this.gridViewSaidas;
            this.gridControlSaidas.Name = "gridControlSaidas";
            this.gridControlSaidas.Size = new System.Drawing.Size(661, 144);
            this.gridControlSaidas.TabIndex = 0;
            this.gridControlSaidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSaidas});
            // 
            // gridViewSaidas
            // 
            this.gridViewSaidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridViewSaidas.GridControl = this.gridControlSaidas;
            this.gridViewSaidas.Name = "gridViewSaidas";
            this.gridViewSaidas.OptionsBehavior.Editable = false;
            this.gridViewSaidas.OptionsView.ColumnAutoWidth = false;
            this.gridViewSaidas.OptionsView.ShowFooter = true;
            this.gridViewSaidas.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Data";
            this.gridColumn6.FieldName = "DataTransacao";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Valor";
            this.gridColumn7.FieldName = "ValorTotal";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 92;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Quantidade";
            this.gridColumn8.FieldName = "Quantidade";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantidade", "Saídas: {0:0.##}")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 135;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Observação";
            this.gridColumn9.FieldName = "Observacao";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 129;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Nº Venda";
            this.gridColumn10.FieldName = "IdVenda";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Local de Estoque";
            this.gridColumn11.FieldName = "LocalEstoque.CodigoLocalEstoque";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 101;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Nº Mov.";
            this.gridColumn12.FieldName = "Movimento.NumeroMovimento";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            this.gridColumn12.Width = 133;
            // 
            // XFrmDetalhesProduto
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 528);
            this.Controls.Add(this.navDadosFiscais);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.Name = "XFrmDetalhesProduto";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Detalhes Produto";
            this.Shown += new System.EventHandler(this.XFrmDetalhesProduto_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmDetalhesProduto_DEV_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navDadosFiscais)).EndInit();
            this.navDadosFiscais.ResumeLayout(false);
            this.navPagDadosProdutos.ResumeLayout(false);
            this.navPagDadosProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chEditar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQtdPrd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioTipoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargemLucro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCadastro.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCadastro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadeMed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoriaProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            this.navigationPageDadosComplementares.ResumeLayout(false);
            this.navigationPageDadosComplementares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAcabamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEspessura2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEspessura1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLargura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComprimento.Properties)).EndInit();
            this.navPageTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTransacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransacoesProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTra)).EndInit();
            this.naPagAlteracoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlteracoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlteracaoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAlteracoes)).EndInit();
            this.navigationPageDadosFiscais.ResumeLayout(false);
            this.navigationPageDadosFiscais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNcm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoItem.Properties)).EndInit();
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSaldoLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaldoLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoFisico2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoMedioVendas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustoMedio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldoEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoria.Properties)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSaidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Navigation.NavigationPane navDadosFiscais;
        private DevExpress.XtraBars.Navigation.NavigationPage navPagDadosProdutos;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageTransactions;
        private DevExpress.XtraBars.BarButtonItem barBtnSalvar;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtCadastro;
        private DevExpress.XtraEditors.ComboBoxEdit cbUnidadeMed;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbCategoriaProduto;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatusProduto;
        private DevExpress.XtraEditors.LabelControl lbStatus;
        private DevExpress.XtraEditors.LabelControl lbCategoria;
        private DevExpress.XtraEditors.LabelControl lbDescricao;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.PictureEdit pictureFotoProduto;
        private DevExpress.XtraBars.BarButtonItem barBtnTransacoes;
        private DevExpress.XtraBars.BarButtonItem barBtnCarregarTransacoes;
        private DevExpress.XtraGrid.GridControl gridControlTransacoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTra;
        private DevExpress.XtraEditors.TextEdit txtMargemLucro;
        private DevExpress.XtraEditors.TextEdit txtPrecoVenda;
        private DevExpress.XtraEditors.TextEdit txtPrecoCompra;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelar;
        private DevExpress.XtraBars.BarButtonItem barBtnRecEstoque;
        private System.Windows.Forms.BindingSource bsTransacoesProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDataTransacao;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoTransacao;
        private DevExpress.XtraGrid.Columns.GridColumn colValorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colValorTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalEstoque;
        private DevExpress.XtraBars.Navigation.NavigationPage naPagAlteracoes;
        private DevExpress.XtraGrid.GridControl gridControlAlteracoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAlteracoes;
        private System.Windows.Forms.BindingSource bsAlteracaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn colPercentualDescontoPromocao;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoCompraAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoVendaAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn colQtdAnterior;
        private DevExpress.XtraEditors.RadioGroup radioTipoProduto;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageDadosFiscais;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoItem;
        private DevExpress.XtraEditors.ButtonEdit btnQtdPrd;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtCodigoBarras;
        private System.Windows.Forms.OpenFileDialog openFileFoto;
        private DevExpress.XtraEditors.CheckEdit chEditar;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtEspessura2;
        private DevExpress.XtraEditors.TextEdit txtEspessura1;
        private DevExpress.XtraEditors.TextEdit txtLargura;
        private DevExpress.XtraEditors.TextEdit txtComprimento;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtAcabamento;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtCor;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPageDadosComplementares;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtPeso;
        private DevExpress.XtraEditors.ButtonEdit btnNcm;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlSaldoLoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSaldoLoc;
        private DevExpress.XtraGrid.Columns.GridColumn sldColLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn sldColQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn sldColValor;
        private DevExpress.XtraEditors.TextEdit txtSaldoFisico2;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.TextEdit txtPrecoMedioVendas;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.TextEdit txtCustoMedio;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.TextEdit txtSaldoEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.RadioGroup rdTipoProduto;
        private DevExpress.XtraEditors.TextEdit txtCategoria;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlEntradas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntradas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colMovimento;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlSaidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSaidas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}