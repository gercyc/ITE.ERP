namespace ITE.CE.Forms.View
{
    partial class XFrmCusteio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCusteio));
            this.textEditCotacaoMoeda = new DevExpress.XtraEditors.TextEdit();
            this.cbMoedas = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtPickerData = new System.Windows.Forms.DateTimePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbTransporte = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbUnidadeMed = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlCotacoes = new DevExpress.XtraGrid.GridControl();
            this.cotacaoCusteioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCotacoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCotacaoCusteio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCusteio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCotacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCotacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMoeda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMoeda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoeda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repComboMoedas = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colCusteio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnItemAddMercadoria = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItemEditarMercadoria = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItemRemoveMercadoria = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnAddCotacao = new DevExpress.XtraEditors.SimpleButton();
            this.cbTipoCotacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.btnViewCotacoes = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroupCotacao = new DevExpress.XtraEditors.RadioGroup();
            this.pictureBoxProgress = new System.Windows.Forms.PictureBox();
            this.textEditContainer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.textEditQtdeContainer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditCapatazia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCliFor1 = new ITE.Components.LookUp.LookUpCliFor();
            this.textEditExportador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.textEditFabricante = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControlMercadoria = new DevExpress.XtraGrid.GridControl();
            this.bsItemCusteio = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMercadoria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCusteio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNcm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMercadoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalUnitarioFob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorReais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMoedaEstrangeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colII = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCofins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colICMSST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencial1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCusteio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControlDespesa = new DevExpress.XtraGrid.GridControl();
            this.bsDespesaCusteio = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDespesa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescriminacaoDespesa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorDespesa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorAliquota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.cbPaisDestino = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.cbPaisOrigem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.memoEditObs = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.textEditDestino = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEditOrigem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblMoedaName = new DevExpress.XtraEditors.LabelControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnItemAddDespesa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItemEditarDespesa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItemRemoveDespesa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCotacaoMoeda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoedas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransporte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadeMed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCotacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotacaoCusteioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCotacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboMoedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoCotacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupCotacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditContainer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQtdeContainer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCapatazia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExportador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFabricante.Properties)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMercadoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemCusteio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMercadoria)).BeginInit();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDespesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDespesaCusteio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDespesa)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaisDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaisOrigem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditObs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDestino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOrigem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditCotacaoMoeda
            // 
            this.textEditCotacaoMoeda.Location = new System.Drawing.Point(284, 40);
            this.textEditCotacaoMoeda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditCotacaoMoeda.Name = "textEditCotacaoMoeda";
            this.textEditCotacaoMoeda.Properties.Mask.EditMask = "n4";
            this.textEditCotacaoMoeda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditCotacaoMoeda.Size = new System.Drawing.Size(99, 20);
            this.textEditCotacaoMoeda.TabIndex = 7;
            // 
            // cbMoedas
            // 
            this.cbMoedas.Location = new System.Drawing.Point(5, 42);
            this.cbMoedas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMoedas.Name = "cbMoedas";
            this.cbMoedas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMoedas.Size = new System.Drawing.Size(135, 20);
            this.cbMoedas.TabIndex = 6;
            // 
            // dtPickerData
            // 
            this.dtPickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerData.Location = new System.Drawing.Point(15, 145);
            this.dtPickerData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerData.Name = "dtPickerData";
            this.dtPickerData.Size = new System.Drawing.Size(100, 21);
            this.dtPickerData.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(284, 23);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(99, 14);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Cotação Moeda:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 25);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Moeda";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 130);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Data";
            // 
            // cbTransporte
            // 
            this.cbTransporte.Location = new System.Drawing.Point(331, 142);
            this.cbTransporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTransporte.Name = "cbTransporte";
            this.cbTransporte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTransporte.Properties.Items.AddRange(new object[] {
            "Marítimo",
            "Aéreo",
            "Rodoviário",
            "Ferroviário",
            "Coletivo",
            "Carga",
            "Espacial",
            "Alternativo"});
            this.cbTransporte.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTransporte.Size = new System.Drawing.Size(283, 20);
            this.cbTransporte.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(331, 124);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Via de Transporte";
            // 
            // cbUnidadeMed
            // 
            this.cbUnidadeMed.Location = new System.Drawing.Point(130, 146);
            this.cbUnidadeMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUnidadeMed.Name = "cbUnidadeMed";
            this.cbUnidadeMed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnidadeMed.Size = new System.Drawing.Size(168, 20);
            this.cbUnidadeMed.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(130, 128);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Unidade Med.";
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4});
            this.tabPane1.RegularSize = new System.Drawing.Size(690, 390);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(690, 390);
            this.tabPane1.TabIndex = 6;
            this.tabPane1.Text = "Despesas";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Carga";
            this.tabNavigationPage1.Controls.Add(this.groupControl2);
            this.tabNavigationPage1.Controls.Add(this.pictureBoxProgress);
            this.tabNavigationPage1.Controls.Add(this.textEditContainer);
            this.tabNavigationPage1.Controls.Add(this.labelControl15);
            this.tabNavigationPage1.Controls.Add(this.textEditQtdeContainer);
            this.tabNavigationPage1.Controls.Add(this.labelControl3);
            this.tabNavigationPage1.Controls.Add(this.textEditCapatazia);
            this.tabNavigationPage1.Controls.Add(this.labelControl4);
            this.tabNavigationPage1.Controls.Add(this.lookUpCliFor1);
            this.tabNavigationPage1.Controls.Add(this.textEditExportador);
            this.tabNavigationPage1.Controls.Add(this.labelControl14);
            this.tabNavigationPage1.Controls.Add(this.textEditFabricante);
            this.tabNavigationPage1.Controls.Add(this.labelControl13);
            this.tabNavigationPage1.Controls.Add(this.cbUnidadeMed);
            this.tabNavigationPage1.Controls.Add(this.labelControl1);
            this.tabNavigationPage1.Controls.Add(this.labelControl2);
            this.tabNavigationPage1.Controls.Add(this.cbTransporte);
            this.tabNavigationPage1.Controls.Add(this.dtPickerData);
            this.tabNavigationPage1.Controls.Add(this.labelControl5);
            this.tabNavigationPage1.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.Image")));
            this.tabNavigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.PageText = "";
            this.tabNavigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Size = new System.Drawing.Size(670, 338);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(156, 15);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.OwnerControl = this.tabNavigationPage1;
            this.flyoutPanel1.Size = new System.Drawing.Size(375, 206);
            this.flyoutPanel1.TabIndex = 51;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.groupControl1);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(375, 206);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlCotacoes);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(371, 202);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Taxas de conversão de moedas";
            // 
            // gridControlCotacoes
            // 
            this.gridControlCotacoes.DataSource = this.cotacaoCusteioBindingSource;
            this.gridControlCotacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCotacoes.Location = new System.Drawing.Point(2, 23);
            this.gridControlCotacoes.MainView = this.gridViewCotacoes;
            this.gridControlCotacoes.MenuManager = this.barManager1;
            this.gridControlCotacoes.Name = "gridControlCotacoes";
            this.gridControlCotacoes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repComboMoedas});
            this.gridControlCotacoes.Size = new System.Drawing.Size(367, 177);
            this.gridControlCotacoes.TabIndex = 0;
            this.gridControlCotacoes.UseEmbeddedNavigator = true;
            this.gridControlCotacoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCotacoes});
            // 
            // cotacaoCusteioBindingSource
            // 
            this.cotacaoCusteioBindingSource.DataSource = typeof(ITE.Entidades.POCO.CE.CotacaoCusteio);
            // 
            // gridViewCotacoes
            // 
            this.gridViewCotacoes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCotacaoCusteio,
            this.colIdCusteio1,
            this.colDataCotacao,
            this.colTipoCotacao,
            this.colIdMoeda,
            this.colValorMoeda,
            this.colMoeda,
            this.colCusteio1});
            this.gridViewCotacoes.GridControl = this.gridControlCotacoes;
            this.gridViewCotacoes.Name = "gridViewCotacoes";
            this.gridViewCotacoes.OptionsView.ShowGroupPanel = false;
            this.gridViewCotacoes.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridViewCotacoes_RowDeleting);
            // 
            // colIdCotacaoCusteio
            // 
            this.colIdCotacaoCusteio.FieldName = "IdCotacaoCusteio";
            this.colIdCotacaoCusteio.Name = "colIdCotacaoCusteio";
            // 
            // colIdCusteio1
            // 
            this.colIdCusteio1.FieldName = "IdCusteio";
            this.colIdCusteio1.Name = "colIdCusteio1";
            // 
            // colDataCotacao
            // 
            this.colDataCotacao.FieldName = "DataCotacao";
            this.colDataCotacao.Name = "colDataCotacao";
            this.colDataCotacao.Visible = true;
            this.colDataCotacao.VisibleIndex = 0;
            // 
            // colTipoCotacao
            // 
            this.colTipoCotacao.FieldName = "TipoCotacao";
            this.colTipoCotacao.Name = "colTipoCotacao";
            this.colTipoCotacao.Visible = true;
            this.colTipoCotacao.VisibleIndex = 1;
            // 
            // colIdMoeda
            // 
            this.colIdMoeda.FieldName = "IdMoeda";
            this.colIdMoeda.Name = "colIdMoeda";
            // 
            // colValorMoeda
            // 
            this.colValorMoeda.Caption = "Valor";
            this.colValorMoeda.FieldName = "ValorMoeda";
            this.colValorMoeda.Name = "colValorMoeda";
            this.colValorMoeda.Visible = true;
            this.colValorMoeda.VisibleIndex = 3;
            // 
            // colMoeda
            // 
            this.colMoeda.ColumnEdit = this.repComboMoedas;
            this.colMoeda.FieldName = "Moeda";
            this.colMoeda.Name = "colMoeda";
            this.colMoeda.Visible = true;
            this.colMoeda.VisibleIndex = 2;
            // 
            // repComboMoedas
            // 
            this.repComboMoedas.AutoHeight = false;
            this.repComboMoedas.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repComboMoedas.Name = "repComboMoedas";
            // 
            // colCusteio1
            // 
            this.colCusteio1.FieldName = "Custeio";
            this.colCusteio1.Name = "colCusteio1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl2);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnItemAddMercadoria,
            this.barBtnItemEditarMercadoria,
            this.barBtnItemRemoveMercadoria});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(358, 222);
            this.bar1.FloatSize = new System.Drawing.Size(46, 28);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnItemAddMercadoria),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnItemEditarMercadoria),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnItemRemoveMercadoria)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // barBtnItemAddMercadoria
            // 
            this.barBtnItemAddMercadoria.Caption = "Novo";
            this.barBtnItemAddMercadoria.Id = 0;
            this.barBtnItemAddMercadoria.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItemAddMercadoria.ImageOptions.Image")));
            this.barBtnItemAddMercadoria.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItemAddMercadoria.ImageOptions.LargeImage")));
            this.barBtnItemAddMercadoria.Name = "barBtnItemAddMercadoria";
            this.barBtnItemAddMercadoria.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnItemAddMercadoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItemAddMercadoria_ItemClick);
            // 
            // barBtnItemEditarMercadoria
            // 
            this.barBtnItemEditarMercadoria.Caption = "Editar";
            this.barBtnItemEditarMercadoria.Id = 1;
            this.barBtnItemEditarMercadoria.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItemEditarMercadoria.ImageOptions.Image")));
            this.barBtnItemEditarMercadoria.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItemEditarMercadoria.ImageOptions.LargeImage")));
            this.barBtnItemEditarMercadoria.Name = "barBtnItemEditarMercadoria";
            this.barBtnItemEditarMercadoria.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnItemEditarMercadoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItemEditarMercadoria_ItemClick);
            // 
            // barBtnItemRemoveMercadoria
            // 
            this.barBtnItemRemoveMercadoria.Caption = "Excluir";
            this.barBtnItemRemoveMercadoria.Id = 2;
            this.barBtnItemRemoveMercadoria.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItemRemoveMercadoria.ImageOptions.Image")));
            this.barBtnItemRemoveMercadoria.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItemRemoveMercadoria.ImageOptions.LargeImage")));
            this.barBtnItemRemoveMercadoria.Name = "barBtnItemRemoveMercadoria";
            this.barBtnItemRemoveMercadoria.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnItemRemoveMercadoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItemRemoveMercadoria_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(670, 30);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(690, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 434);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(690, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 434);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(690, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 434);
            // 
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.AutoSize = true;
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl2.Manager = this.barManager1;
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(670, 30);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnAddCotacao);
            this.groupControl2.Controls.Add(this.cbTipoCotacao);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Controls.Add(this.cbMoedas);
            this.groupControl2.Controls.Add(this.btnViewCotacoes);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.textEditCotacaoMoeda);
            this.groupControl2.Controls.Add(this.radioGroupCotacao);
            this.groupControl2.Location = new System.Drawing.Point(3, 191);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(659, 75);
            this.groupControl2.TabIndex = 53;
            this.groupControl2.Text = "Moeda Estrangeira";
            // 
            // btnAddCotacao
            // 
            this.btnAddCotacao.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.btnAddCotacao.Appearance.Options.UseFont = true;
            this.btnAddCotacao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCotacao.ImageOptions.Image")));
            this.btnAddCotacao.Location = new System.Drawing.Point(524, 37);
            this.btnAddCotacao.Name = "btnAddCotacao";
            this.btnAddCotacao.Size = new System.Drawing.Size(70, 23);
            this.btnAddCotacao.TabIndex = 55;
            this.btnAddCotacao.Text = "Adicionar";
            this.btnAddCotacao.Click += new System.EventHandler(this.btnAddCotacao_Click);
            // 
            // cbTipoCotacao
            // 
            this.cbTipoCotacao.Location = new System.Drawing.Point(151, 42);
            this.cbTipoCotacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoCotacao.Name = "cbTipoCotacao";
            this.cbTipoCotacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoCotacao.Size = new System.Drawing.Size(127, 20);
            this.cbTipoCotacao.TabIndex = 53;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(151, 25);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(63, 13);
            this.labelControl16.TabIndex = 54;
            this.labelControl16.Text = "Tipo Cotação";
            // 
            // btnViewCotacoes
            // 
            this.btnViewCotacoes.Appearance.Font = new System.Drawing.Font("Tahoma", 6F);
            this.btnViewCotacoes.Appearance.Options.UseFont = true;
            this.btnViewCotacoes.Location = new System.Drawing.Point(600, 37);
            this.btnViewCotacoes.Name = "btnViewCotacoes";
            this.btnViewCotacoes.Size = new System.Drawing.Size(54, 23);
            this.btnViewCotacoes.TabIndex = 52;
            this.btnViewCotacoes.Text = "Cotações";
            this.btnViewCotacoes.Click += new System.EventHandler(this.btnViewCotacoes_Click);
            // 
            // radioGroupCotacao
            // 
            this.radioGroupCotacao.EditValue = 1;
            this.radioGroupCotacao.Location = new System.Drawing.Point(389, 38);
            this.radioGroupCotacao.MenuManager = this.barManager1;
            this.radioGroupCotacao.Name = "radioGroupCotacao";
            this.radioGroupCotacao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Compra"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Venda")});
            this.radioGroupCotacao.Size = new System.Drawing.Size(129, 23);
            this.radioGroupCotacao.TabIndex = 8;
            this.radioGroupCotacao.SelectedIndexChanged += new System.EventHandler(this.radioGroupCotacao_SelectedIndexChanged);
            // 
            // pictureBoxProgress
            // 
            this.pictureBoxProgress.Image = global::ITE.CE.Properties.Resources.progress;
            this.pictureBoxProgress.Location = new System.Drawing.Point(573, 0);
            this.pictureBoxProgress.Name = "pictureBoxProgress";
            this.pictureBoxProgress.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProgress.TabIndex = 50;
            this.pictureBoxProgress.TabStop = false;
            // 
            // textEditContainer
            // 
            this.textEditContainer.Location = new System.Drawing.Point(331, 301);
            this.textEditContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditContainer.Name = "textEditContainer";
            this.textEditContainer.Size = new System.Drawing.Size(283, 20);
            this.textEditContainer.TabIndex = 11;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(331, 283);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(47, 13);
            this.labelControl15.TabIndex = 49;
            this.labelControl15.Text = "Container";
            // 
            // textEditQtdeContainer
            // 
            this.textEditQtdeContainer.Location = new System.Drawing.Point(170, 301);
            this.textEditQtdeContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditQtdeContainer.Name = "textEditQtdeContainer";
            this.textEditQtdeContainer.Properties.Mask.EditMask = "d";
            this.textEditQtdeContainer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditQtdeContainer.Size = new System.Drawing.Size(128, 20);
            this.textEditQtdeContainer.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(170, 283);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Quantidade Containers";
            // 
            // textEditCapatazia
            // 
            this.textEditCapatazia.Location = new System.Drawing.Point(15, 301);
            this.textEditCapatazia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditCapatazia.Name = "textEditCapatazia";
            this.textEditCapatazia.Properties.Mask.EditMask = "n2";
            this.textEditCapatazia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditCapatazia.Size = new System.Drawing.Size(128, 20);
            this.textEditCapatazia.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 283);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 13);
            this.labelControl4.TabIndex = 45;
            this.labelControl4.Text = "Valor Capatazia";
            // 
            // lookUpCliFor1
            // 
            this.lookUpCliFor1.CliFor = null;
            this.lookUpCliFor1.Filial = null;
            this.lookUpCliFor1.LabelText = "Cliente/Fornecedor:";
            this.lookUpCliFor1.Location = new System.Drawing.Point(10, 14);
            this.lookUpCliFor1.Matriz = null;
            this.lookUpCliFor1.Name = "lookUpCliFor1";
            this.lookUpCliFor1.Size = new System.Drawing.Size(604, 48);
            this.lookUpCliFor1.TabIndex = 0;
            // 
            // textEditExportador
            // 
            this.textEditExportador.Location = new System.Drawing.Point(331, 90);
            this.textEditExportador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditExportador.Name = "textEditExportador";
            this.textEditExportador.Size = new System.Drawing.Size(283, 20);
            this.textEditExportador.TabIndex = 2;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(331, 72);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(54, 13);
            this.labelControl14.TabIndex = 42;
            this.labelControl14.Text = "Exportador";
            // 
            // textEditFabricante
            // 
            this.textEditFabricante.Location = new System.Drawing.Point(15, 90);
            this.textEditFabricante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditFabricante.Name = "textEditFabricante";
            this.textEditFabricante.Size = new System.Drawing.Size(283, 20);
            this.textEditFabricante.TabIndex = 1;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(15, 72);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(51, 13);
            this.labelControl13.TabIndex = 40;
            this.labelControl13.Text = "Fabricante";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Mercadorias";
            this.tabNavigationPage3.Controls.Add(this.gridControlMercadoria);
            this.tabNavigationPage3.Controls.Add(this.standaloneBarDockControl1);
            this.tabNavigationPage3.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage3.Image")));
            this.tabNavigationPage3.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage3.Size = new System.Drawing.Size(670, 338);
            // 
            // gridControlMercadoria
            // 
            this.gridControlMercadoria.DataSource = this.bsItemCusteio;
            this.gridControlMercadoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMercadoria.Location = new System.Drawing.Point(0, 30);
            this.gridControlMercadoria.MainView = this.gridViewMercadoria;
            this.gridControlMercadoria.Name = "gridControlMercadoria";
            this.gridControlMercadoria.Size = new System.Drawing.Size(670, 308);
            this.gridControlMercadoria.TabIndex = 2;
            this.gridControlMercadoria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMercadoria});
            // 
            // bsItemCusteio
            // 
            this.bsItemCusteio.DataSource = typeof(ITE.Entidades.POCO.CE.ItemCusteio);
            // 
            // gridViewMercadoria
            // 
            this.gridViewMercadoria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCusteio,
            this.colNcm,
            this.colMercadoria,
            this.colTotalUnitarioFob,
            this.colTotalFob,
            this.colQuantidade,
            this.colPeso,
            this.colValorReais,
            this.colValorMoedaEstrangeira,
            this.colII,
            this.colIPI,
            this.colPIS,
            this.colCofins,
            this.colICMS,
            this.colICMSST,
            this.colSequencial1,
            this.colCusteio});
            this.gridViewMercadoria.GridControl = this.gridControlMercadoria;
            this.gridViewMercadoria.Name = "gridViewMercadoria";
            this.gridViewMercadoria.OptionsBehavior.Editable = false;
            this.gridViewMercadoria.OptionsView.ColumnAutoWidth = false;
            this.gridViewMercadoria.OptionsView.ShowGroupPanel = false;
            this.gridViewMercadoria.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSequencial1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdCusteio
            // 
            this.colIdCusteio.FieldName = "IdCusteio";
            this.colIdCusteio.Name = "colIdCusteio";
            this.colIdCusteio.Width = 107;
            // 
            // colNcm
            // 
            this.colNcm.FieldName = "Ncm";
            this.colNcm.Name = "colNcm";
            this.colNcm.Visible = true;
            this.colNcm.VisibleIndex = 1;
            this.colNcm.Width = 104;
            // 
            // colMercadoria
            // 
            this.colMercadoria.FieldName = "Mercadoria";
            this.colMercadoria.Name = "colMercadoria";
            this.colMercadoria.Visible = true;
            this.colMercadoria.VisibleIndex = 2;
            this.colMercadoria.Width = 104;
            // 
            // colTotalUnitarioFob
            // 
            this.colTotalUnitarioFob.FieldName = "TotalUnitarioFob";
            this.colTotalUnitarioFob.Name = "colTotalUnitarioFob";
            this.colTotalUnitarioFob.Width = 106;
            // 
            // colTotalFob
            // 
            this.colTotalFob.FieldName = "TotalFob";
            this.colTotalFob.Name = "colTotalFob";
            this.colTotalFob.Visible = true;
            this.colTotalFob.VisibleIndex = 5;
            this.colTotalFob.Width = 92;
            // 
            // colQuantidade
            // 
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Width = 77;
            // 
            // colPeso
            // 
            this.colPeso.FieldName = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.Width = 35;
            // 
            // colValorReais
            // 
            this.colValorReais.FieldName = "ValorReais";
            this.colValorReais.Name = "colValorReais";
            this.colValorReais.Visible = true;
            this.colValorReais.VisibleIndex = 4;
            this.colValorReais.Width = 101;
            // 
            // colValorMoedaEstrangeira
            // 
            this.colValorMoedaEstrangeira.FieldName = "ValorMoedaEstrangeira";
            this.colValorMoedaEstrangeira.Name = "colValorMoedaEstrangeira";
            this.colValorMoedaEstrangeira.Visible = true;
            this.colValorMoedaEstrangeira.VisibleIndex = 3;
            this.colValorMoedaEstrangeira.Width = 138;
            // 
            // colII
            // 
            this.colII.FieldName = "II";
            this.colII.Name = "colII";
            this.colII.Visible = true;
            this.colII.VisibleIndex = 6;
            this.colII.Width = 88;
            // 
            // colIPI
            // 
            this.colIPI.FieldName = "IPI";
            this.colIPI.Name = "colIPI";
            this.colIPI.Visible = true;
            this.colIPI.VisibleIndex = 7;
            this.colIPI.Width = 79;
            // 
            // colPIS
            // 
            this.colPIS.FieldName = "PIS";
            this.colPIS.Name = "colPIS";
            this.colPIS.Visible = true;
            this.colPIS.VisibleIndex = 8;
            this.colPIS.Width = 80;
            // 
            // colCofins
            // 
            this.colCofins.FieldName = "Cofins";
            this.colCofins.Name = "colCofins";
            this.colCofins.Visible = true;
            this.colCofins.VisibleIndex = 9;
            this.colCofins.Width = 83;
            // 
            // colICMS
            // 
            this.colICMS.FieldName = "ICMS";
            this.colICMS.Name = "colICMS";
            this.colICMS.Visible = true;
            this.colICMS.VisibleIndex = 10;
            this.colICMS.Width = 94;
            // 
            // colICMSST
            // 
            this.colICMSST.FieldName = "ICMSST";
            this.colICMSST.Name = "colICMSST";
            this.colICMSST.Visible = true;
            this.colICMSST.VisibleIndex = 11;
            this.colICMSST.Width = 89;
            // 
            // colSequencial1
            // 
            this.colSequencial1.Caption = "Nº";
            this.colSequencial1.FieldName = "Sequencial";
            this.colSequencial1.Name = "colSequencial1";
            this.colSequencial1.Visible = true;
            this.colSequencial1.VisibleIndex = 0;
            this.colSequencial1.Width = 35;
            // 
            // colCusteio
            // 
            this.colCusteio.FieldName = "Custeio";
            this.colCusteio.Name = "colCusteio";
            this.colCusteio.Width = 58;
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Despesas";
            this.tabNavigationPage4.Controls.Add(this.gridControlDespesa);
            this.tabNavigationPage4.Controls.Add(this.standaloneBarDockControl2);
            this.tabNavigationPage4.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage4.Image")));
            this.tabNavigationPage4.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage4.Size = new System.Drawing.Size(670, 338);
            // 
            // gridControlDespesa
            // 
            this.gridControlDespesa.DataSource = this.bsDespesaCusteio;
            this.gridControlDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDespesa.Location = new System.Drawing.Point(0, 30);
            this.gridControlDespesa.MainView = this.gridViewDespesa;
            this.gridControlDespesa.MenuManager = this.barManager1;
            this.gridControlDespesa.Name = "gridControlDespesa";
            this.gridControlDespesa.Size = new System.Drawing.Size(670, 308);
            this.gridControlDespesa.TabIndex = 1;
            this.gridControlDespesa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDespesa});
            // 
            // bsDespesaCusteio
            // 
            this.bsDespesaCusteio.DataSource = typeof(ITE.Entidades.POCO.CE.DespesaCusteio);
            // 
            // gridViewDespesa
            // 
            this.gridViewDespesa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescriminacaoDespesa,
            this.colValorDespesa,
            this.colValorAliquota,
            this.colTipo,
            this.colSequencial});
            this.gridViewDespesa.GridControl = this.gridControlDespesa;
            this.gridViewDespesa.Name = "gridViewDespesa";
            this.gridViewDespesa.OptionsBehavior.Editable = false;
            this.gridViewDespesa.OptionsView.ShowGroupPanel = false;
            // 
            // colDescriminacaoDespesa
            // 
            this.colDescriminacaoDespesa.AppearanceCell.Options.UseTextOptions = true;
            this.colDescriminacaoDespesa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescriminacaoDespesa.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescriminacaoDespesa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescriminacaoDespesa.Caption = "Discriminação";
            this.colDescriminacaoDespesa.FieldName = "DiscriminacaoDespesa";
            this.colDescriminacaoDespesa.Name = "colDescriminacaoDespesa";
            this.colDescriminacaoDespesa.Visible = true;
            this.colDescriminacaoDespesa.VisibleIndex = 1;
            this.colDescriminacaoDespesa.Width = 192;
            // 
            // colValorDespesa
            // 
            this.colValorDespesa.AppearanceCell.Options.UseTextOptions = true;
            this.colValorDespesa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorDespesa.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorDespesa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorDespesa.FieldName = "ValorDespesa";
            this.colValorDespesa.Name = "colValorDespesa";
            this.colValorDespesa.Visible = true;
            this.colValorDespesa.VisibleIndex = 2;
            this.colValorDespesa.Width = 141;
            // 
            // colValorAliquota
            // 
            this.colValorAliquota.AppearanceCell.Options.UseTextOptions = true;
            this.colValorAliquota.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorAliquota.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorAliquota.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorAliquota.FieldName = "ValorAliquota";
            this.colValorAliquota.Name = "colValorAliquota";
            this.colValorAliquota.Visible = true;
            this.colValorAliquota.VisibleIndex = 3;
            this.colValorAliquota.Width = 100;
            // 
            // colTipo
            // 
            this.colTipo.AppearanceCell.Options.UseTextOptions = true;
            this.colTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 4;
            this.colTipo.Width = 164;
            // 
            // colSequencial
            // 
            this.colSequencial.AppearanceCell.Options.UseTextOptions = true;
            this.colSequencial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSequencial.AppearanceHeader.Options.UseTextOptions = true;
            this.colSequencial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSequencial.Caption = "Nº";
            this.colSequencial.FieldName = "Sequencial";
            this.colSequencial.Name = "colSequencial";
            this.colSequencial.Visible = true;
            this.colSequencial.VisibleIndex = 0;
            this.colSequencial.Width = 29;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Despacho";
            this.tabNavigationPage2.Controls.Add(this.cbPaisDestino);
            this.tabNavigationPage2.Controls.Add(this.labelControl12);
            this.tabNavigationPage2.Controls.Add(this.cbPaisOrigem);
            this.tabNavigationPage2.Controls.Add(this.labelControl11);
            this.tabNavigationPage2.Controls.Add(this.memoEditObs);
            this.tabNavigationPage2.Controls.Add(this.labelControl10);
            this.tabNavigationPage2.Controls.Add(this.textEditDestino);
            this.tabNavigationPage2.Controls.Add(this.labelControl9);
            this.tabNavigationPage2.Controls.Add(this.textEditOrigem);
            this.tabNavigationPage2.Controls.Add(this.labelControl8);
            this.tabNavigationPage2.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.Image")));
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Size = new System.Drawing.Size(670, 338);
            // 
            // cbPaisDestino
            // 
            this.cbPaisDestino.Location = new System.Drawing.Point(332, 96);
            this.cbPaisDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPaisDestino.Name = "cbPaisDestino";
            this.cbPaisDestino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaisDestino.Size = new System.Drawing.Size(283, 20);
            this.cbPaisDestino.TabIndex = 42;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(332, 79);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(58, 13);
            this.labelControl12.TabIndex = 47;
            this.labelControl12.Text = "Pais Destino";
            // 
            // cbPaisOrigem
            // 
            this.cbPaisOrigem.Location = new System.Drawing.Point(16, 96);
            this.cbPaisOrigem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPaisOrigem.Name = "cbPaisOrigem";
            this.cbPaisOrigem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPaisOrigem.Size = new System.Drawing.Size(283, 20);
            this.cbPaisOrigem.TabIndex = 41;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(16, 79);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(56, 13);
            this.labelControl11.TabIndex = 46;
            this.labelControl11.Text = "Pais Origem";
            // 
            // memoEditObs
            // 
            this.memoEditObs.Location = new System.Drawing.Point(16, 157);
            this.memoEditObs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoEditObs.Name = "memoEditObs";
            this.memoEditObs.Size = new System.Drawing.Size(604, 78);
            this.memoEditObs.TabIndex = 43;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(16, 139);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(63, 13);
            this.labelControl10.TabIndex = 45;
            this.labelControl10.Text = "Observações";
            // 
            // textEditDestino
            // 
            this.textEditDestino.Location = new System.Drawing.Point(332, 36);
            this.textEditDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditDestino.Name = "textEditDestino";
            this.textEditDestino.Size = new System.Drawing.Size(283, 20);
            this.textEditDestino.TabIndex = 40;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(332, 18);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 13);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "Porto de Destino";
            // 
            // textEditOrigem
            // 
            this.textEditOrigem.Location = new System.Drawing.Point(16, 36);
            this.textEditOrigem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEditOrigem.Name = "textEditOrigem";
            this.textEditOrigem.Size = new System.Drawing.Size(283, 20);
            this.textEditOrigem.TabIndex = 39;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 18);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 13);
            this.labelControl8.TabIndex = 38;
            this.labelControl8.Text = "Porto de Origem";
            // 
            // lblMoedaName
            // 
            this.lblMoedaName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMoedaName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMoedaName.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMoedaName.Appearance.Options.UseFont = true;
            this.lblMoedaName.Appearance.Options.UseForeColor = true;
            this.lblMoedaName.Location = new System.Drawing.Point(9, 15);
            this.lblMoedaName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMoedaName.Name = "lblMoedaName";
            this.lblMoedaName.Size = new System.Drawing.Size(112, 16);
            this.lblMoedaName.TabIndex = 33;
            this.lblMoedaName.Text = "COTAÇÃO MOEDA";
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
            this.barBtnItemAddDespesa,
            this.barBtnItemEditarDespesa,
            this.barBtnItemRemoveDespesa});
            this.barManager2.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.FloatLocation = new System.Drawing.Point(356, 146);
            this.bar2.FloatSize = new System.Drawing.Size(304, 30);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnItemAddDespesa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnItemEditarDespesa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnItemRemoveDespesa)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.bar2.Text = "Tools";
            // 
            // barBtnItemAddDespesa
            // 
            this.barBtnItemAddDespesa.Caption = "Novo";
            this.barBtnItemAddDespesa.Id = 0;
            this.barBtnItemAddDespesa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItemAddDespesa.ImageOptions.Image")));
            this.barBtnItemAddDespesa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItemAddDespesa.ImageOptions.LargeImage")));
            this.barBtnItemAddDespesa.Name = "barBtnItemAddDespesa";
            this.barBtnItemAddDespesa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnItemAddDespesa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItemAddDespesa_ItemClick);
            // 
            // barBtnItemEditarDespesa
            // 
            this.barBtnItemEditarDespesa.Caption = "Editar";
            this.barBtnItemEditarDespesa.Id = 1;
            this.barBtnItemEditarDespesa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItemEditarDespesa.ImageOptions.Image")));
            this.barBtnItemEditarDespesa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItemEditarDespesa.ImageOptions.LargeImage")));
            this.barBtnItemEditarDespesa.Name = "barBtnItemEditarDespesa";
            this.barBtnItemEditarDespesa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnItemEditarDespesa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItemEditarDespesa_ItemClick);
            // 
            // barBtnItemRemoveDespesa
            // 
            this.barBtnItemRemoveDespesa.Caption = "Excluir";
            this.barBtnItemRemoveDespesa.Id = 2;
            this.barBtnItemRemoveDespesa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnItemRemoveDespesa.ImageOptions.Image")));
            this.barBtnItemRemoveDespesa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnItemRemoveDespesa.ImageOptions.LargeImage")));
            this.barBtnItemRemoveDespesa.Name = "barBtnItemRemoveDespesa";
            this.barBtnItemRemoveDespesa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnItemRemoveDespesa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnItemRemoveDespesa_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(690, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 434);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(690, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 434);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(690, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 434);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.flyoutPanel1);
            this.panelControl1.Controls.Add(this.simpleButtonSalvar);
            this.panelControl1.Controls.Add(this.lblMoedaName);
            this.panelControl1.Location = new System.Drawing.Point(0, 390);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(690, 44);
            this.panelControl1.TabIndex = 15;
            // 
            // simpleButtonSalvar
            // 
            this.simpleButtonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonSalvar.Location = new System.Drawing.Point(582, 7);
            this.simpleButtonSalvar.Name = "simpleButtonSalvar";
            this.simpleButtonSalvar.Size = new System.Drawing.Size(90, 30);
            this.simpleButtonSalvar.TabIndex = 0;
            this.simpleButtonSalvar.Text = "Salvar";
            this.simpleButtonSalvar.Click += new System.EventHandler(this.simpleButtonSalvar_Click);
            // 
            // XFrmCusteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 434);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "XFrmCusteio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo Importação";
            this.Shown += new System.EventHandler(this.XFrmCusteio_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.textEditCotacaoMoeda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoedas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransporte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnidadeMed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCotacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotacaoCusteioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCotacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboMoedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoCotacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupCotacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditContainer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQtdeContainer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCapatazia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditExportador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFabricante.Properties)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMercadoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemCusteio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMercadoria)).EndInit();
            this.tabNavigationPage4.ResumeLayout(false);
            this.tabNavigationPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDespesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDespesaCusteio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDespesa)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaisDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPaisOrigem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditObs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDestino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditOrigem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit textEditCotacaoMoeda;
        private DevExpress.XtraEditors.ComboBoxEdit cbMoedas;
        private System.Windows.Forms.DateTimePicker dtPickerData;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cbTransporte;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbUnidadeMed;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraGrid.GridControl gridControlMercadoria;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMercadoria;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnItemAddMercadoria;
        private DevExpress.XtraBars.BarButtonItem barBtnItemEditarMercadoria;
        private DevExpress.XtraBars.BarButtonItem barBtnItemRemoveMercadoria;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnItemAddDespesa;
        private DevExpress.XtraBars.BarButtonItem barBtnItemEditarDespesa;
        private DevExpress.XtraBars.BarButtonItem barBtnItemRemoveDespesa;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraGrid.GridControl gridControlDespesa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDespesa;
        private DevExpress.XtraEditors.LabelControl lblMoedaName;
        private DevExpress.XtraEditors.RadioGroup radioGroupCotacao;
        private System.Windows.Forms.BindingSource bsItemCusteio;
        private DevExpress.XtraEditors.TextEdit textEditExportador;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit textEditFabricante;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private Components.LookUp.LookUpCliFor lookUpCliFor1;
        private DevExpress.XtraEditors.TextEdit textEditCapatazia;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditContainer;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit textEditQtdeContainer;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource bsDespesaCusteio;
        private DevExpress.XtraGrid.Columns.GridColumn colDescriminacaoDespesa;
        private DevExpress.XtraGrid.Columns.GridColumn colValorDespesa;
        private DevExpress.XtraGrid.Columns.GridColumn colValorAliquota;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencial;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSalvar;
        private DevExpress.XtraEditors.ComboBoxEdit cbPaisDestino;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ComboBoxEdit cbPaisOrigem;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.MemoEdit memoEditObs;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit textEditDestino;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEditOrigem;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.PictureBox pictureBoxProgress;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCusteio;
        private DevExpress.XtraGrid.Columns.GridColumn colNcm;
        private DevExpress.XtraGrid.Columns.GridColumn colMercadoria;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalUnitarioFob;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFob;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colValorReais;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMoedaEstrangeira;
        private DevExpress.XtraGrid.Columns.GridColumn colII;
        private DevExpress.XtraGrid.Columns.GridColumn colIPI;
        private DevExpress.XtraGrid.Columns.GridColumn colPIS;
        private DevExpress.XtraGrid.Columns.GridColumn colCofins;
        private DevExpress.XtraGrid.Columns.GridColumn colICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colICMSST;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencial1;
        private DevExpress.XtraGrid.Columns.GridColumn colCusteio;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlCotacoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCotacoes;
        private System.Windows.Forms.BindingSource cotacaoCusteioBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnViewCotacoes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCotacaoCusteio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCusteio1;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCotacao;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCotacao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMoeda;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMoeda;
        private DevExpress.XtraGrid.Columns.GridColumn colMoeda;
        private DevExpress.XtraGrid.Columns.GridColumn colCusteio1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddCotacao;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoCotacao;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repComboMoedas;
    }
}

