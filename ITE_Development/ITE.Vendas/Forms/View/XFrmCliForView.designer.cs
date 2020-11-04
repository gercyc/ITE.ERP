using ITSolution.Framework.Components;

namespace ITE.Vendas.Forms.View
{
    partial class XFrmCliForView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCliForView));
            this.bmEndereco = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAddEndereco = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewEditEndereco = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelEndereco = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.gridControlEnderecos = new DevExpress.XtraGrid.GridControl();
            this.bsEndereco = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEnderecos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliForEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComplemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbNome = new DevExpress.XtraEditors.LabelControl();
            this.lbRg = new DevExpress.XtraEditors.LabelControl();
            this.lbTipo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRg = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefone = new DevExpress.XtraEditors.TextEdit();
            this.txtCelular = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtTelComercial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroupTipoCliFor = new DevExpress.XtraEditors.RadioGroup();
            this.txtRazaoSocial = new DevExpress.XtraEditors.TextEdit();
            this.dtDataNasc = new DevExpress.XtraEditors.DateEdit();
            this.cbClassificacaoClifor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cnpjControl1 = new ITSolution.Framework.Components.CpfCnpjControl();
            this.ch0800 = new DevExpress.XtraEditors.CheckEdit();
            this.groupControlDadosEndereco = new DevExpress.XtraEditors.GroupControl();
            this.lookUpMunicipio1 = new ITE.Components.LookUpMunicipio();
            this.cepControl1 = new ITSolution.Framework.Components.CepControl();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtEndereco = new DevExpress.XtraEditors.TextEdit();
            this.txtComplemento = new DevExpress.XtraEditors.TextEdit();
            this.checkSemNumero = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.txtBairro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pnlDadosJuridicos = new DevExpress.XtraEditors.PanelControl();
            this.txtInscMunicipal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.txtInscEstadual = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.txtCapitalSocial = new DevExpress.XtraEditors.TextEdit();
            this.dtPickerAtualizacao = new DevExpress.XtraEditors.DateEdit();
            this.lblCapitalSocial = new DevExpress.XtraEditors.LabelControl();
            this.dtPickerAbertura = new DevExpress.XtraEditors.DateEdit();
            this.txtTipo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataSituacao = new DevExpress.XtraEditors.TextEdit();
            this.txtEFR = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtStatus = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataSituacaoEspecial = new DevExpress.XtraEditors.TextEdit();
            this.txtMotivoSituacaoEspecial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtSituacaoEspecial = new DevExpress.XtraEditors.TextEdit();
            this.txtSituacao = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.txtNaturezaJuridica = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeFantasia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grpControlQsa = new DevExpress.XtraEditors.GroupControl();
            this.gridControlQsa = new DevExpress.XtraGrid.GridControl();
            this.gridViewQsa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpContrlAtvSec = new DevExpress.XtraEditors.GroupControl();
            this.gridControlAtvSecundarias = new DevExpress.XtraGrid.GridControl();
            this.gridViewAtvSecundarias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpControlAtvPrinc = new DevExpress.XtraEditors.GroupControl();
            this.gridControlAtvPrincipal = new DevExpress.XtraGrid.GridControl();
            this.gridViewAtvPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navigationPage5 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlCtbCliFor = new DevExpress.XtraGrid.GridControl();
            this.bsContaBancariaCliFor = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCtbCliFor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdContaCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContaBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bmCliFor = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnVoltar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.bmContaBanc = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnAddContaCliFor = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditContaCliFor = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoveContaCliFor = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.bmEndereco)).BeginInit();
            this.standaloneBarDockControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelComercial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupTipoCliFor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazaoSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNasc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNasc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClassificacaoClifor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch0800.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosEndereco)).BeginInit();
            this.groupControlDadosEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSemNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
            this.navigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDadosJuridicos)).BeginInit();
            this.pnlDadosJuridicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInscMunicipal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInscEstadual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapitalSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPickerAtualizacao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPickerAtualizacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPickerAbertura.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPickerAbertura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEFR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataSituacaoEspecial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoSituacaoEspecial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacaoEspecial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaturezaJuridica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFantasia.Properties)).BeginInit();
            this.navigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlQsa)).BeginInit();
            this.grpControlQsa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpContrlAtvSec)).BeginInit();
            this.grpContrlAtvSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAtvSecundarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAtvSecundarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlAtvPrinc)).BeginInit();
            this.grpControlAtvPrinc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAtvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAtvPrincipal)).BeginInit();
            this.navigationPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCtbCliFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContaBancariaCliFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCtbCliFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmCliFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmContaBanc)).BeginInit();
            this.SuspendLayout();
            // 
            // bmEndereco
            // 
            this.bmEndereco.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.bmEndereco.DockControls.Add(this.standaloneBarDockControl1);
            this.bmEndereco.DockControls.Add(this.barDockControlBottom);
            this.bmEndereco.DockControls.Add(this.barDockControlLeft);
            this.bmEndereco.DockControls.Add(this.barDockControlRight);
            this.bmEndereco.DockControls.Add(this.standaloneBarDockControl2);
            this.bmEndereco.Form = this;
            this.bmEndereco.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddEndereco,
            this.btnViewEditEndereco,
            this.btnDelEndereco});
            this.bmEndereco.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddEndereco),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnViewEditEndereco),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelEndereco)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // btnAddEndereco
            // 
            this.btnAddEndereco.Caption = "Novo endereço";
            this.btnAddEndereco.Id = 0;
            this.btnAddEndereco.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEndereco.ImageOptions.Image")));
            this.btnAddEndereco.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddEndereco.ImageOptions.LargeImage")));
            this.btnAddEndereco.Name = "btnAddEndereco";
            this.btnAddEndereco.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddEndereco.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddEndereco_ItemClick);
            // 
            // btnViewEditEndereco
            // 
            this.btnViewEditEndereco.Caption = "Visualizar/Editar";
            this.btnViewEditEndereco.Id = 1;
            this.btnViewEditEndereco.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewEditEndereco.ImageOptions.Image")));
            this.btnViewEditEndereco.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewEditEndereco.ImageOptions.LargeImage")));
            this.btnViewEditEndereco.Name = "btnViewEditEndereco";
            this.btnViewEditEndereco.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnViewEditEndereco.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewEditEndereco_ItemClick);
            // 
            // btnDelEndereco
            // 
            this.btnDelEndereco.Caption = "Excluir endereço";
            this.btnDelEndereco.Id = 2;
            this.btnDelEndereco.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelEndereco.ImageOptions.Image")));
            this.btnDelEndereco.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelEndereco.ImageOptions.LargeImage")));
            this.btnDelEndereco.Name = "btnDelEndereco";
            this.btnDelEndereco.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelEndereco.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelEndereco_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Manager = this.bmEndereco;
            this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(0, 35);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 584);
            this.barDockControlBottom.Manager = this.bmEndereco;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(897, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.bmEndereco;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 544);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(897, 40);
            this.barDockControlRight.Manager = this.bmEndereco;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 544);
            // 
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(3, 3);
            this.standaloneBarDockControl2.Manager = this.bmEndereco;
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(743, 31);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // gridControlEnderecos
            // 
            this.gridControlEnderecos.DataSource = this.bsEndereco;
            this.gridControlEnderecos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEnderecos.Location = new System.Drawing.Point(0, 35);
            this.gridControlEnderecos.MainView = this.gridViewEnderecos;
            this.gridControlEnderecos.MenuManager = this.bmEndereco;
            this.gridControlEnderecos.Name = "gridControlEnderecos";
            this.gridControlEnderecos.Size = new System.Drawing.Size(0, 0);
            this.gridControlEnderecos.TabIndex = 33;
            this.gridControlEnderecos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEnderecos});
            // 
            // bsEndereco
            // 
            this.bsEndereco.DataSource = typeof(ITE.Entidades.POCO.EnderecoCliFor);
            // 
            // gridViewEnderecos
            // 
            this.gridViewEnderecos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewEnderecos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewEnderecos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewEnderecos.Appearance.Row.Options.UseFont = true;
            this.gridViewEnderecos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEndereco,
            this.colIdCliForEndereco,
            this.colCliFor,
            this.colNomeEndereco,
            this.colNumeroEndereco,
            this.colBairro,
            this.colComplemento,
            this.colCep,
            this.colUf,
            this.colCidade,
            this.colTipoEndereco});
            this.gridViewEnderecos.GridControl = this.gridControlEnderecos;
            this.gridViewEnderecos.Name = "gridViewEnderecos";
            this.gridViewEnderecos.OptionsBehavior.Editable = false;
            this.gridViewEnderecos.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEndereco
            // 
            this.colIdEndereco.FieldName = "IdEndereco";
            this.colIdEndereco.Name = "colIdEndereco";
            this.colIdEndereco.OptionsColumn.FixedWidth = true;
            // 
            // colIdCliForEndereco
            // 
            this.colIdCliForEndereco.FieldName = "IdCliForEndereco";
            this.colIdCliForEndereco.Name = "colIdCliForEndereco";
            this.colIdCliForEndereco.OptionsColumn.FixedWidth = true;
            // 
            // colCliFor
            // 
            this.colCliFor.FieldName = "CliFor";
            this.colCliFor.Name = "colCliFor";
            this.colCliFor.OptionsColumn.FixedWidth = true;
            // 
            // colNomeEndereco
            // 
            this.colNomeEndereco.Caption = "Endereço";
            this.colNomeEndereco.FieldName = "EnderecoParcial";
            this.colNomeEndereco.Name = "colNomeEndereco";
            this.colNomeEndereco.Visible = true;
            this.colNomeEndereco.VisibleIndex = 1;
            this.colNomeEndereco.Width = 380;
            // 
            // colNumeroEndereco
            // 
            this.colNumeroEndereco.Caption = "Número";
            this.colNumeroEndereco.FieldName = "NumeroEndereco";
            this.colNumeroEndereco.Name = "colNumeroEndereco";
            this.colNumeroEndereco.OptionsColumn.FixedWidth = true;
            this.colNumeroEndereco.Width = 95;
            // 
            // colBairro
            // 
            this.colBairro.FieldName = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.OptionsColumn.FixedWidth = true;
            this.colBairro.Width = 145;
            // 
            // colComplemento
            // 
            this.colComplemento.FieldName = "Complemento";
            this.colComplemento.Name = "colComplemento";
            this.colComplemento.OptionsColumn.FixedWidth = true;
            this.colComplemento.Width = 182;
            // 
            // colCep
            // 
            this.colCep.FieldName = "Cep";
            this.colCep.Name = "colCep";
            this.colCep.Visible = true;
            this.colCep.VisibleIndex = 2;
            this.colCep.Width = 80;
            // 
            // colUf
            // 
            this.colUf.Caption = "UF";
            this.colUf.FieldName = "Uf";
            this.colUf.Name = "colUf";
            this.colUf.Visible = true;
            this.colUf.VisibleIndex = 4;
            this.colUf.Width = 50;
            // 
            // colCidade
            // 
            this.colCidade.FieldName = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.Visible = true;
            this.colCidade.VisibleIndex = 3;
            this.colCidade.Width = 104;
            // 
            // colTipoEndereco
            // 
            this.colTipoEndereco.Caption = "Tipo";
            this.colTipoEndereco.FieldName = "TipoEndereco";
            this.colTipoEndereco.Name = "colTipoEndereco";
            this.colTipoEndereco.Visible = true;
            this.colTipoEndereco.VisibleIndex = 0;
            this.colTipoEndereco.Width = 100;
            // 
            // lbNome
            // 
            this.lbNome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Appearance.Options.UseFont = true;
            this.lbNome.Location = new System.Drawing.Point(11, 28);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(37, 15);
            this.lbNome.TabIndex = 11;
            this.lbNome.Text = "Nome:";
            // 
            // lbRg
            // 
            this.lbRg.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRg.Appearance.Options.UseFont = true;
            this.lbRg.Location = new System.Drawing.Point(385, 75);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(21, 15);
            this.lbRg.TabIndex = 14;
            this.lbRg.Text = "RG:";
            // 
            // lbTipo
            // 
            this.lbTipo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Appearance.Options.UseFont = true;
            this.lbTipo.Location = new System.Drawing.Point(11, 72);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(85, 15);
            this.lbTipo.TabIndex = 12;
            this.lbTipo.Text = "Tipo de Cliente:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 131);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 15);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Telefone";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(385, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 15);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Celular";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 176);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 15);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Email:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(385, 94);
            this.txtRg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRg.Name = "txtRg";
            this.txtRg.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Properties.Appearance.Options.UseFont = true;
            this.txtRg.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Size = new System.Drawing.Size(147, 22);
            this.txtRg.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(11, 151);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Properties.Appearance.Options.UseFont = true;
            this.txtTelefone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefone.Size = new System.Drawing.Size(147, 22);
            this.txtTelefone.TabIndex = 5;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(385, 150);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Properties.Appearance.Options.UseFont = true;
            this.txtCelular.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtCelular.Size = new System.Drawing.Size(147, 22);
            this.txtCelular.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 195);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Size = new System.Drawing.Size(717, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTelComercial
            // 
            this.txtTelComercial.Location = new System.Drawing.Point(189, 150);
            this.txtTelComercial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelComercial.Name = "txtTelComercial";
            this.txtTelComercial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelComercial.Properties.Appearance.Options.UseFont = true;
            this.txtTelComercial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelComercial.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelComercial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelComercial.Size = new System.Drawing.Size(147, 22);
            this.txtTelComercial.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(189, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 15);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Comercial";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(575, 77);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(95, 15);
            this.labelControl10.TabIndex = 30;
            this.labelControl10.Text = "Data Nascimento";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(293, 12);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(69, 13);
            this.labelControl13.TabIndex = 3;
            this.labelControl13.Text = "labelControl13";
            // 
            // radioGroupTipoCliFor
            // 
            this.radioGroupTipoCliFor.Location = new System.Drawing.Point(11, 90);
            this.radioGroupTipoCliFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioGroupTipoCliFor.MenuManager = this.bmEndereco;
            this.radioGroupTipoCliFor.Name = "radioGroupTipoCliFor";
            this.radioGroupTipoCliFor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupTipoCliFor.Properties.Appearance.Options.UseFont = true;
            this.radioGroupTipoCliFor.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Física"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Jurídica")});
            this.radioGroupTipoCliFor.Size = new System.Drawing.Size(147, 28);
            this.radioGroupTipoCliFor.TabIndex = 1;
            this.radioGroupTipoCliFor.SelectedIndexChanged += new System.EventHandler(this.cbTipoCliente_SelectedIndexChanged);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(11, 47);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Properties.Appearance.Options.UseFont = true;
            this.txtRazaoSocial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Size = new System.Drawing.Size(716, 22);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.EditValue = null;
            this.dtDataNasc.Location = new System.Drawing.Point(575, 96);
            this.dtDataNasc.MenuManager = this.bmEndereco;
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataNasc.Properties.Appearance.Options.UseFont = true;
            this.dtDataNasc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataNasc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataNasc.Size = new System.Drawing.Size(153, 22);
            this.dtDataNasc.TabIndex = 4;
            // 
            // cbClassificacaoClifor
            // 
            this.cbClassificacaoClifor.EditValue = "";
            this.cbClassificacaoClifor.Location = new System.Drawing.Point(574, 152);
            this.cbClassificacaoClifor.Name = "cbClassificacaoClifor";
            this.cbClassificacaoClifor.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClassificacaoClifor.Properties.Appearance.Options.UseFont = true;
            this.cbClassificacaoClifor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbClassificacaoClifor.Properties.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor",
            "Ambos"});
            this.cbClassificacaoClifor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbClassificacaoClifor.Size = new System.Drawing.Size(153, 22);
            this.cbClassificacaoClifor.TabIndex = 8;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(574, 131);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(75, 15);
            this.labelControl14.TabIndex = 48;
            this.labelControl14.Text = "Classificação:";
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage3);
            this.navigationPane1.Controls.Add(this.navigationPage4);
            this.navigationPane1.Controls.Add(this.navigationPage5);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 40);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowCollapseButton = false;
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4,
            this.navigationPage5});
            this.navigationPane1.RegularSize = new System.Drawing.Size(897, 544);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(897, 544);
            this.navigationPane1.TabIndex = 74;
            this.navigationPane1.Text = "Dados Básicos:";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Endereços:";
            this.navigationPage2.Controls.Add(this.gridControlEnderecos);
            this.navigationPage2.Controls.Add(this.standaloneBarDockControl1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(0, 0);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Dados Básicos:";
            this.navigationPage1.Controls.Add(this.panelControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(728, 480);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.groupControlDadosEndereco);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(728, 480);
            this.panelControl1.TabIndex = 49;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtRazaoSocial);
            this.groupControl1.Controls.Add(this.lbTipo);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl14);
            this.groupControl1.Controls.Add(this.lbNome);
            this.groupControl1.Controls.Add(this.cbClassificacaoClifor);
            this.groupControl1.Controls.Add(this.txtTelefone);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cnpjControl1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txtTelComercial);
            this.groupControl1.Controls.Add(this.dtDataNasc);
            this.groupControl1.Controls.Add(this.radioGroupTipoCliFor);
            this.groupControl1.Controls.Add(this.ch0800);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCelular);
            this.groupControl1.Controls.Add(this.txtRg);
            this.groupControl1.Controls.Add(this.lbRg);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.groupControl1.Size = new System.Drawing.Size(724, 229);
            this.groupControl1.TabIndex = 50;
            this.groupControl1.Text = "Dados Cadastrais:";
            // 
            // cnpjControl1
            // 
            this.cnpjControl1.DelegateValidation = null;
            this.cnpjControl1.IsMaskCNPJ = true;
            this.cnpjControl1.Location = new System.Drawing.Point(173, 63);
            this.cnpjControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cnpjControl1.Name = "cnpjControl1";
            this.cnpjControl1.Size = new System.Drawing.Size(207, 62);
            this.cnpjControl1.TabIndex = 2;
            // 
            // ch0800
            // 
            this.ch0800.Location = new System.Drawing.Point(108, 130);
            this.ch0800.MenuManager = this.bmEndereco;
            this.ch0800.Name = "ch0800";
            this.ch0800.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch0800.Properties.Appearance.Options.UseFont = true;
            this.ch0800.Properties.Caption = "0800";
            this.ch0800.Size = new System.Drawing.Size(50, 20);
            this.ch0800.TabIndex = 24;
            this.ch0800.CheckedChanged += new System.EventHandler(this.ch0800_CheckedChanged);
            // 
            // groupControlDadosEndereco
            // 
            this.groupControlDadosEndereco.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControlDadosEndereco.AppearanceCaption.Options.UseFont = true;
            this.groupControlDadosEndereco.Controls.Add(this.lookUpMunicipio1);
            this.groupControlDadosEndereco.Controls.Add(this.cepControl1);
            this.groupControlDadosEndereco.Controls.Add(this.txtNumero);
            this.groupControlDadosEndereco.Controls.Add(this.txtEndereco);
            this.groupControlDadosEndereco.Controls.Add(this.txtComplemento);
            this.groupControlDadosEndereco.Controls.Add(this.checkSemNumero);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl21);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl22);
            this.groupControlDadosEndereco.Controls.Add(this.txtBairro);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl23);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl24);
            this.groupControlDadosEndereco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlDadosEndereco.Location = new System.Drawing.Point(2, 237);
            this.groupControlDadosEndereco.Name = "groupControlDadosEndereco";
            this.groupControlDadosEndereco.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.groupControlDadosEndereco.Size = new System.Drawing.Size(724, 241);
            this.groupControlDadosEndereco.TabIndex = 49;
            this.groupControlDadosEndereco.Text = "Endereço Principal:";
            // 
            // lookUpMunicipio1
            // 
            this.lookUpMunicipio1.Location = new System.Drawing.Point(359, 145);
            this.lookUpMunicipio1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpMunicipio1.MdiForm = null;
            this.lookUpMunicipio1.Municipio = null;
            this.lookUpMunicipio1.Name = "lookUpMunicipio1";
            this.lookUpMunicipio1.ReadyOnly = false;
            this.lookUpMunicipio1.Size = new System.Drawing.Size(349, 44);
            this.lookUpMunicipio1.TabIndex = 29;
            this.lookUpMunicipio1.UF = null;
            // 
            // cepControl1
            // 
            this.cepControl1.AutoSize = true;
            this.cepControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cepControl1.Location = new System.Drawing.Point(11, 137);
            this.cepControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cepControl1.Name = "cepControl1";
            this.cepControl1.ReadyOnly = false;
            this.cepControl1.Size = new System.Drawing.Size(173, 52);
            this.cepControl1.TabIndex = 28;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(559, 58);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Size = new System.Drawing.Size(169, 20);
            this.txtNumero.TabIndex = 25;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(11, 58);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtEndereco.Properties.Appearance.Options.UseFont = true;
            this.txtEndereco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Size = new System.Drawing.Size(521, 20);
            this.txtEndereco.TabIndex = 24;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(359, 106);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtComplemento.Properties.Appearance.Options.UseFont = true;
            this.txtComplemento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Size = new System.Drawing.Size(267, 20);
            this.txtComplemento.TabIndex = 27;
            // 
            // checkSemNumero
            // 
            this.checkSemNumero.Location = new System.Drawing.Point(677, 36);
            this.checkSemNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSemNumero.Name = "checkSemNumero";
            this.checkSemNumero.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkSemNumero.Properties.Appearance.Options.UseFont = true;
            this.checkSemNumero.Properties.Caption = "S\\N";
            this.checkSemNumero.Size = new System.Drawing.Size(50, 20);
            this.checkSemNumero.TabIndex = 32;
            this.checkSemNumero.CheckedChanged += new System.EventHandler(this.checkSemNumero_CheckedChanged);
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl21.Appearance.Options.UseFont = true;
            this.labelControl21.Location = new System.Drawing.Point(11, 87);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(30, 14);
            this.labelControl21.TabIndex = 60;
            this.labelControl21.Text = "Bairro";
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl22.Appearance.Options.UseFont = true;
            this.labelControl22.Location = new System.Drawing.Point(11, 39);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(52, 14);
            this.labelControl22.TabIndex = 55;
            this.labelControl22.Text = "Endereço";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(11, 106);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBairro.Properties.Appearance.Options.UseFont = true;
            this.txtBairro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Size = new System.Drawing.Size(323, 20);
            this.txtBairro.TabIndex = 26;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl23.Appearance.Options.UseFont = true;
            this.labelControl23.Location = new System.Drawing.Point(559, 39);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(43, 14);
            this.labelControl23.TabIndex = 56;
            this.labelControl23.Text = "Número";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Location = new System.Drawing.Point(359, 87);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(76, 14);
            this.labelControl24.TabIndex = 57;
            this.labelControl24.Text = "Complemento";
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "Dados das Empresa";
            this.navigationPage3.Controls.Add(this.pnlDadosJuridicos);
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(728, 480);
            // 
            // pnlDadosJuridicos
            // 
            this.pnlDadosJuridicos.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlDadosJuridicos.Appearance.Options.UseBackColor = true;
            this.pnlDadosJuridicos.Controls.Add(this.txtInscMunicipal);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl28);
            this.pnlDadosJuridicos.Controls.Add(this.txtInscEstadual);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl27);
            this.pnlDadosJuridicos.Controls.Add(this.txtCapitalSocial);
            this.pnlDadosJuridicos.Controls.Add(this.dtPickerAtualizacao);
            this.pnlDadosJuridicos.Controls.Add(this.lblCapitalSocial);
            this.pnlDadosJuridicos.Controls.Add(this.dtPickerAbertura);
            this.pnlDadosJuridicos.Controls.Add(this.txtTipo);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl19);
            this.pnlDadosJuridicos.Controls.Add(this.txtDataSituacao);
            this.pnlDadosJuridicos.Controls.Add(this.txtEFR);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl18);
            this.pnlDadosJuridicos.Controls.Add(this.txtStatus);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl17);
            this.pnlDadosJuridicos.Controls.Add(this.txtDataSituacaoEspecial);
            this.pnlDadosJuridicos.Controls.Add(this.txtMotivoSituacaoEspecial);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl16);
            this.pnlDadosJuridicos.Controls.Add(this.txtSituacaoEspecial);
            this.pnlDadosJuridicos.Controls.Add(this.txtSituacao);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl15);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl5);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl6);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl12);
            this.pnlDadosJuridicos.Controls.Add(this.txtNaturezaJuridica);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl11);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl7);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl9);
            this.pnlDadosJuridicos.Controls.Add(this.txtNomeFantasia);
            this.pnlDadosJuridicos.Controls.Add(this.labelControl8);
            this.pnlDadosJuridicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDadosJuridicos.Location = new System.Drawing.Point(0, 0);
            this.pnlDadosJuridicos.Name = "pnlDadosJuridicos";
            this.pnlDadosJuridicos.Size = new System.Drawing.Size(728, 480);
            this.pnlDadosJuridicos.TabIndex = 18;
            // 
            // txtInscMunicipal
            // 
            this.txtInscMunicipal.Location = new System.Drawing.Point(396, 198);
            this.txtInscMunicipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInscMunicipal.Name = "txtInscMunicipal";
            this.txtInscMunicipal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtInscMunicipal.Properties.Appearance.Options.UseFont = true;
            this.txtInscMunicipal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscMunicipal.Size = new System.Drawing.Size(146, 20);
            this.txtInscMunicipal.TabIndex = 99;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl28.Appearance.Options.UseFont = true;
            this.labelControl28.Location = new System.Drawing.Point(396, 179);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(100, 14);
            this.labelControl28.TabIndex = 100;
            this.labelControl28.Text = "Inscrição municipal";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Location = new System.Drawing.Point(205, 198);
            this.txtInscEstadual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtInscEstadual.Properties.Appearance.Options.UseFont = true;
            this.txtInscEstadual.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscEstadual.Size = new System.Drawing.Size(146, 20);
            this.txtInscEstadual.TabIndex = 97;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl27.Appearance.Options.UseFont = true;
            this.labelControl27.Location = new System.Drawing.Point(205, 179);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(96, 14);
            this.labelControl27.TabIndex = 98;
            this.labelControl27.Text = "Inscrição estadual";
            // 
            // txtCapitalSocial
            // 
            this.txtCapitalSocial.Location = new System.Drawing.Point(13, 196);
            this.txtCapitalSocial.MenuManager = this.bmEndereco;
            this.txtCapitalSocial.Name = "txtCapitalSocial";
            this.txtCapitalSocial.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapitalSocial.Properties.Appearance.Options.UseFont = true;
            this.txtCapitalSocial.Properties.Mask.EditMask = "n";
            this.txtCapitalSocial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCapitalSocial.Size = new System.Drawing.Size(116, 22);
            this.txtCapitalSocial.TabIndex = 23;
            // 
            // dtPickerAtualizacao
            // 
            this.dtPickerAtualizacao.EditValue = null;
            this.dtPickerAtualizacao.Location = new System.Drawing.Point(587, 155);
            this.dtPickerAtualizacao.MenuManager = this.bmEndereco;
            this.dtPickerAtualizacao.Name = "dtPickerAtualizacao";
            this.dtPickerAtualizacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtPickerAtualizacao.Properties.Appearance.Options.UseFont = true;
            this.dtPickerAtualizacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPickerAtualizacao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPickerAtualizacao.Size = new System.Drawing.Size(124, 20);
            this.dtPickerAtualizacao.TabIndex = 96;
            // 
            // lblCapitalSocial
            // 
            this.lblCapitalSocial.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitalSocial.Appearance.Options.UseFont = true;
            this.lblCapitalSocial.Location = new System.Drawing.Point(13, 176);
            this.lblCapitalSocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCapitalSocial.Name = "lblCapitalSocial";
            this.lblCapitalSocial.Size = new System.Drawing.Size(75, 15);
            this.lblCapitalSocial.TabIndex = 72;
            this.lblCapitalSocial.Text = "Capital Social";
            // 
            // dtPickerAbertura
            // 
            this.dtPickerAbertura.EditValue = null;
            this.dtPickerAbertura.Location = new System.Drawing.Point(586, 24);
            this.dtPickerAbertura.MenuManager = this.bmEndereco;
            this.dtPickerAbertura.Name = "dtPickerAbertura";
            this.dtPickerAbertura.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtPickerAbertura.Properties.Appearance.Options.UseFont = true;
            this.dtPickerAbertura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPickerAbertura.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPickerAbertura.Size = new System.Drawing.Size(124, 20);
            this.dtPickerAbertura.TabIndex = 12;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(586, 68);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTipo.Properties.Appearance.Options.UseFont = true;
            this.txtTipo.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtTipo.Size = new System.Drawing.Size(147, 20);
            this.txtTipo.TabIndex = 14;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(586, 49);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(24, 14);
            this.labelControl19.TabIndex = 94;
            this.labelControl19.Text = "Tipo";
            // 
            // txtDataSituacao
            // 
            this.txtDataSituacao.Location = new System.Drawing.Point(205, 110);
            this.txtDataSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataSituacao.Name = "txtDataSituacao";
            this.txtDataSituacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDataSituacao.Properties.Appearance.Options.UseFont = true;
            this.txtDataSituacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataSituacao.Size = new System.Drawing.Size(146, 20);
            this.txtDataSituacao.TabIndex = 16;
            // 
            // txtEFR
            // 
            this.txtEFR.Location = new System.Drawing.Point(396, 110);
            this.txtEFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEFR.Name = "txtEFR";
            this.txtEFR.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtEFR.Properties.Appearance.Options.UseFont = true;
            this.txtEFR.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtEFR.Size = new System.Drawing.Size(147, 20);
            this.txtEFR.TabIndex = 17;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Location = new System.Drawing.Point(397, 93);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(21, 14);
            this.labelControl18.TabIndex = 92;
            this.labelControl18.Text = "EFR";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(586, 110);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtStatus.Properties.Appearance.Options.UseFont = true;
            this.txtStatus.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtStatus.Size = new System.Drawing.Size(147, 20);
            this.txtStatus.TabIndex = 18;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Location = new System.Drawing.Point(587, 93);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(35, 14);
            this.labelControl17.TabIndex = 90;
            this.labelControl17.Text = "Status";
            // 
            // txtDataSituacaoEspecial
            // 
            this.txtDataSituacaoEspecial.Location = new System.Drawing.Point(397, 154);
            this.txtDataSituacaoEspecial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDataSituacaoEspecial.Name = "txtDataSituacaoEspecial";
            this.txtDataSituacaoEspecial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDataSituacaoEspecial.Properties.Appearance.Options.UseFont = true;
            this.txtDataSituacaoEspecial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDataSituacaoEspecial.Size = new System.Drawing.Size(146, 20);
            this.txtDataSituacaoEspecial.TabIndex = 21;
            // 
            // txtMotivoSituacaoEspecial
            // 
            this.txtMotivoSituacaoEspecial.Location = new System.Drawing.Point(205, 154);
            this.txtMotivoSituacaoEspecial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotivoSituacaoEspecial.Name = "txtMotivoSituacaoEspecial";
            this.txtMotivoSituacaoEspecial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMotivoSituacaoEspecial.Properties.Appearance.Options.UseFont = true;
            this.txtMotivoSituacaoEspecial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivoSituacaoEspecial.Size = new System.Drawing.Size(146, 20);
            this.txtMotivoSituacaoEspecial.TabIndex = 20;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(205, 136);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(132, 14);
            this.labelControl16.TabIndex = 88;
            this.labelControl16.Text = "Motivo Situação Especial";
            // 
            // txtSituacaoEspecial
            // 
            this.txtSituacaoEspecial.Location = new System.Drawing.Point(13, 154);
            this.txtSituacaoEspecial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSituacaoEspecial.Name = "txtSituacaoEspecial";
            this.txtSituacaoEspecial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSituacaoEspecial.Properties.Appearance.Options.UseFont = true;
            this.txtSituacaoEspecial.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSituacaoEspecial.Size = new System.Drawing.Size(146, 20);
            this.txtSituacaoEspecial.TabIndex = 19;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(13, 110);
            this.txtSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSituacao.Properties.Appearance.Options.UseFont = true;
            this.txtSituacao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSituacao.Size = new System.Drawing.Size(146, 20);
            this.txtSituacao.TabIndex = 15;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(586, 3);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(77, 14);
            this.labelControl15.TabIndex = 86;
            this.labelControl15.Text = "Data Abertura";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 14);
            this.labelControl5.TabIndex = 75;
            this.labelControl5.Text = "Situação";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(205, 93);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 14);
            this.labelControl6.TabIndex = 77;
            this.labelControl6.Text = "Data Situação";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(586, 136);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(97, 14);
            this.labelControl12.TabIndex = 84;
            this.labelControl12.Text = "Última Atualização";
            // 
            // txtNaturezaJuridica
            // 
            this.txtNaturezaJuridica.Location = new System.Drawing.Point(13, 24);
            this.txtNaturezaJuridica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaturezaJuridica.Name = "txtNaturezaJuridica";
            this.txtNaturezaJuridica.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNaturezaJuridica.Properties.Appearance.Options.UseFont = true;
            this.txtNaturezaJuridica.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNaturezaJuridica.Size = new System.Drawing.Size(534, 20);
            this.txtNaturezaJuridica.TabIndex = 11;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(396, 136);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(121, 14);
            this.labelControl11.TabIndex = 82;
            this.labelControl11.Text = "Data Situação Especial";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(13, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 14);
            this.labelControl7.TabIndex = 79;
            this.labelControl7.Text = "Natureza Jurídica";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(13, 136);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(92, 14);
            this.labelControl9.TabIndex = 81;
            this.labelControl9.Text = "Situação Especial";
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(13, 68);
            this.txtNomeFantasia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeFantasia.Properties.Appearance.Options.UseFont = true;
            this.txtNomeFantasia.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Size = new System.Drawing.Size(533, 20);
            this.txtNomeFantasia.TabIndex = 13;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(13, 49);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 14);
            this.labelControl8.TabIndex = 80;
            this.labelControl8.Text = "Nome Fantasia";
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "Atividades das Empresa";
            this.navigationPage4.Controls.Add(this.grpControlQsa);
            this.navigationPage4.Controls.Add(this.grpContrlAtvSec);
            this.navigationPage4.Controls.Add(this.grpControlAtvPrinc);
            this.navigationPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(728, 480);
            // 
            // grpControlQsa
            // 
            this.grpControlQsa.Controls.Add(this.gridControlQsa);
            this.grpControlQsa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpControlQsa.Location = new System.Drawing.Point(0, 324);
            this.grpControlQsa.Name = "grpControlQsa";
            this.grpControlQsa.Size = new System.Drawing.Size(728, 156);
            this.grpControlQsa.TabIndex = 26;
            this.grpControlQsa.Text = "Sócios e Diretores (Somente leitura)";
            // 
            // gridControlQsa
            // 
            this.gridControlQsa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlQsa.Location = new System.Drawing.Point(2, 23);
            this.gridControlQsa.MainView = this.gridViewQsa;
            this.gridControlQsa.MenuManager = this.bmEndereco;
            this.gridControlQsa.Name = "gridControlQsa";
            this.gridControlQsa.Size = new System.Drawing.Size(724, 131);
            this.gridControlQsa.TabIndex = 0;
            this.gridControlQsa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQsa});
            // 
            // gridViewQsa
            // 
            this.gridViewQsa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQual,
            this.colNome});
            this.gridViewQsa.GridControl = this.gridControlQsa;
            this.gridViewQsa.Name = "gridViewQsa";
            this.gridViewQsa.OptionsView.ShowGroupPanel = false;
            // 
            // colQual
            // 
            this.colQual.FieldName = "Qual";
            this.colQual.Name = "colQual";
            this.colQual.Visible = true;
            this.colQual.VisibleIndex = 0;
            // 
            // colNome
            // 
            this.colNome.FieldName = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 1;
            // 
            // grpContrlAtvSec
            // 
            this.grpContrlAtvSec.Controls.Add(this.gridControlAtvSecundarias);
            this.grpContrlAtvSec.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContrlAtvSec.Location = new System.Drawing.Point(0, 104);
            this.grpContrlAtvSec.Name = "grpContrlAtvSec";
            this.grpContrlAtvSec.Size = new System.Drawing.Size(728, 235);
            this.grpContrlAtvSec.TabIndex = 25;
            this.grpContrlAtvSec.Text = "Atividades Secundárias";
            // 
            // gridControlAtvSecundarias
            // 
            this.gridControlAtvSecundarias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAtvSecundarias.Location = new System.Drawing.Point(2, 23);
            this.gridControlAtvSecundarias.MainView = this.gridViewAtvSecundarias;
            this.gridControlAtvSecundarias.MenuManager = this.bmEndereco;
            this.gridControlAtvSecundarias.Name = "gridControlAtvSecundarias";
            this.gridControlAtvSecundarias.Size = new System.Drawing.Size(724, 210);
            this.gridControlAtvSecundarias.TabIndex = 0;
            this.gridControlAtvSecundarias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAtvSecundarias});
            // 
            // gridViewAtvSecundarias
            // 
            this.gridViewAtvSecundarias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo1,
            this.colDescricao1});
            this.gridViewAtvSecundarias.GridControl = this.gridControlAtvSecundarias;
            this.gridViewAtvSecundarias.Name = "gridViewAtvSecundarias";
            this.gridViewAtvSecundarias.OptionsBehavior.Editable = false;
            this.gridViewAtvSecundarias.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo1
            // 
            this.colCodigo1.Caption = "Código";
            this.colCodigo1.FieldName = "Codigo";
            this.colCodigo1.Name = "colCodigo1";
            this.colCodigo1.Visible = true;
            this.colCodigo1.VisibleIndex = 0;
            this.colCodigo1.Width = 109;
            // 
            // colDescricao1
            // 
            this.colDescricao1.Caption = "Atividade";
            this.colDescricao1.FieldName = "Descricao";
            this.colDescricao1.Name = "colDescricao1";
            this.colDescricao1.Visible = true;
            this.colDescricao1.VisibleIndex = 1;
            this.colDescricao1.Width = 397;
            // 
            // grpControlAtvPrinc
            // 
            this.grpControlAtvPrinc.Controls.Add(this.gridControlAtvPrincipal);
            this.grpControlAtvPrinc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpControlAtvPrinc.Location = new System.Drawing.Point(0, 0);
            this.grpControlAtvPrinc.Name = "grpControlAtvPrinc";
            this.grpControlAtvPrinc.Size = new System.Drawing.Size(728, 104);
            this.grpControlAtvPrinc.TabIndex = 24;
            this.grpControlAtvPrinc.Text = "Atividade Principal";
            // 
            // gridControlAtvPrincipal
            // 
            this.gridControlAtvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAtvPrincipal.Location = new System.Drawing.Point(2, 23);
            this.gridControlAtvPrincipal.MainView = this.gridViewAtvPrincipal;
            this.gridControlAtvPrincipal.MenuManager = this.bmEndereco;
            this.gridControlAtvPrincipal.Name = "gridControlAtvPrincipal";
            this.gridControlAtvPrincipal.Size = new System.Drawing.Size(724, 79);
            this.gridControlAtvPrincipal.TabIndex = 0;
            this.gridControlAtvPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAtvPrincipal});
            // 
            // gridViewAtvPrincipal
            // 
            this.gridViewAtvPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colDescricao});
            this.gridViewAtvPrincipal.GridControl = this.gridControlAtvPrincipal;
            this.gridViewAtvPrincipal.Name = "gridViewAtvPrincipal";
            this.gridViewAtvPrincipal.OptionsBehavior.Editable = false;
            this.gridViewAtvPrincipal.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "Código";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 112;
            // 
            // colDescricao
            // 
            this.colDescricao.Caption = "Atividade";
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 1;
            this.colDescricao.Width = 394;
            // 
            // navigationPage5
            // 
            this.navigationPage5.Caption = "Dados bancários";
            this.navigationPage5.Controls.Add(this.panelControl2);
            this.navigationPage5.Controls.Add(this.standaloneBarDockControl2);
            this.navigationPage5.Name = "navigationPage5";
            this.navigationPage5.Size = new System.Drawing.Size(0, 0);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControlCtbCliFor);
            this.panelControl2.Location = new System.Drawing.Point(3, 38);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(743, 447);
            this.panelControl2.TabIndex = 2;
            // 
            // gridControlCtbCliFor
            // 
            this.gridControlCtbCliFor.DataSource = this.bsContaBancariaCliFor;
            this.gridControlCtbCliFor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCtbCliFor.Location = new System.Drawing.Point(2, 2);
            this.gridControlCtbCliFor.MainView = this.gridViewCtbCliFor;
            this.gridControlCtbCliFor.MenuManager = this.bmEndereco;
            this.gridControlCtbCliFor.Name = "gridControlCtbCliFor";
            this.gridControlCtbCliFor.Size = new System.Drawing.Size(739, 443);
            this.gridControlCtbCliFor.TabIndex = 1;
            this.gridControlCtbCliFor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCtbCliFor});
            // 
            // bsContaBancariaCliFor
            // 
            this.bsContaBancariaCliFor.DataSource = typeof(ITE.Entidades.POCO.ContaBancariaCliFor);
            // 
            // gridViewCtbCliFor
            // 
            this.gridViewCtbCliFor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdContaCliFor,
            this.colIdCliFor,
            this.colBanco,
            this.colAgencia,
            this.colContaBancaria,
            this.colCliFor1});
            this.gridViewCtbCliFor.GridControl = this.gridControlCtbCliFor;
            this.gridViewCtbCliFor.Name = "gridViewCtbCliFor";
            this.gridViewCtbCliFor.OptionsView.ShowGroupPanel = false;
            // 
            // colIdContaCliFor
            // 
            this.colIdContaCliFor.FieldName = "IdContaCliFor";
            this.colIdContaCliFor.Name = "colIdContaCliFor";
            // 
            // colIdCliFor
            // 
            this.colIdCliFor.FieldName = "IdCliFor";
            this.colIdCliFor.Name = "colIdCliFor";
            // 
            // colBanco
            // 
            this.colBanco.FieldName = "NomeBanco";
            this.colBanco.Name = "colBanco";
            this.colBanco.Visible = true;
            this.colBanco.VisibleIndex = 0;
            this.colBanco.Width = 184;
            // 
            // colAgencia
            // 
            this.colAgencia.FieldName = "Agencia";
            this.colAgencia.Name = "colAgencia";
            this.colAgencia.Visible = true;
            this.colAgencia.VisibleIndex = 1;
            this.colAgencia.Width = 195;
            // 
            // colContaBancaria
            // 
            this.colContaBancaria.FieldName = "ContaBancaria";
            this.colContaBancaria.Name = "colContaBancaria";
            this.colContaBancaria.Visible = true;
            this.colContaBancaria.VisibleIndex = 2;
            this.colContaBancaria.Width = 394;
            // 
            // colCliFor1
            // 
            this.colCliFor1.FieldName = "CliFor";
            this.colCliFor1.Name = "colCliFor1";
            // 
            // bmCliFor
            // 
            this.bmCliFor.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar4});
            this.bmCliFor.DockControls.Add(this.barDockControl1);
            this.bmCliFor.DockControls.Add(this.barDockControl2);
            this.bmCliFor.DockControls.Add(this.barDockControl3);
            this.bmCliFor.DockControls.Add(this.barDockControl4);
            this.bmCliFor.Form = this;
            this.bmCliFor.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnVoltar,
            this.barBtnSalvar});
            this.bmCliFor.MaxItemId = 2;
            this.bmCliFor.StatusBar = this.bar4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnVoltar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSalvar)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableClose = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Tools";
            // 
            // barBtnVoltar
            // 
            this.barBtnVoltar.Caption = "Voltar";
            this.barBtnVoltar.Id = 0;
            this.barBtnVoltar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnVoltar.ImageOptions.Image")));
            this.barBtnVoltar.Name = "barBtnVoltar";
            this.barBtnVoltar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnVoltar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelar_ItemClick);
            // 
            // barBtnSalvar
            // 
            this.barBtnSalvar.Caption = "Salvar";
            this.barBtnSalvar.Id = 1;
            this.barBtnSalvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.ImageOptions.Image")));
            this.barBtnSalvar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.barBtnSalvar.Name = "barBtnSalvar";
            this.barBtnSalvar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSalvar_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.bmCliFor;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(897, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 584);
            this.barDockControl2.Manager = this.bmCliFor;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(897, 20);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Manager = this.bmCliFor;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 544);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(897, 40);
            this.barDockControl4.Manager = this.bmCliFor;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 544);
            // 
            // bmContaBanc
            // 
            this.bmContaBanc.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.bmContaBanc.DockControls.Add(this.barDockControlTop);
            this.bmContaBanc.DockControls.Add(this.barDockControl5);
            this.bmContaBanc.DockControls.Add(this.barDockControl6);
            this.bmContaBanc.DockControls.Add(this.barDockControl7);
            this.bmContaBanc.Form = this.standaloneBarDockControl2;
            this.bmContaBanc.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddContaCliFor,
            this.btnEditContaCliFor,
            this.btnRemoveContaCliFor});
            this.bmContaBanc.MaxItemId = 3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar3.FloatLocation = new System.Drawing.Point(383, 226);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddContaCliFor),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditContaCliFor),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveContaCliFor)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DisableCustomization = true;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.bar3.Text = "Tools";
            // 
            // btnAddContaCliFor
            // 
            this.btnAddContaCliFor.Caption = "Novo";
            this.btnAddContaCliFor.Id = 0;
            this.btnAddContaCliFor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContaCliFor.ImageOptions.Image")));
            this.btnAddContaCliFor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddContaCliFor.ImageOptions.LargeImage")));
            this.btnAddContaCliFor.Name = "btnAddContaCliFor";
            this.btnAddContaCliFor.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAddContaCliFor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddContaCliFor_ItemClick);
            // 
            // btnEditContaCliFor
            // 
            this.btnEditContaCliFor.Caption = "Editar";
            this.btnEditContaCliFor.Id = 1;
            this.btnEditContaCliFor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditContaCliFor.ImageOptions.Image")));
            this.btnEditContaCliFor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditContaCliFor.ImageOptions.LargeImage")));
            this.btnEditContaCliFor.Name = "btnEditContaCliFor";
            this.btnEditContaCliFor.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEditContaCliFor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditContaCliFor_ItemClick);
            // 
            // btnRemoveContaCliFor
            // 
            this.btnRemoveContaCliFor.Caption = "Remover";
            this.btnRemoveContaCliFor.Id = 2;
            this.btnRemoveContaCliFor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveContaCliFor.ImageOptions.Image")));
            this.btnRemoveContaCliFor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveContaCliFor.ImageOptions.LargeImage")));
            this.btnRemoveContaCliFor.Name = "btnRemoveContaCliFor";
            this.btnRemoveContaCliFor.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRemoveContaCliFor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveContaCliFor_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmContaBanc;
            this.barDockControlTop.Size = new System.Drawing.Size(743, 0);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl5.Location = new System.Drawing.Point(0, 31);
            this.barDockControl5.Manager = this.bmContaBanc;
            this.barDockControl5.Size = new System.Drawing.Size(743, 0);
            // 
            // barDockControl6
            // 
            this.barDockControl6.CausesValidation = false;
            this.barDockControl6.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl6.Location = new System.Drawing.Point(0, 0);
            this.barDockControl6.Manager = this.bmContaBanc;
            this.barDockControl6.Size = new System.Drawing.Size(0, 31);
            // 
            // barDockControl7
            // 
            this.barDockControl7.CausesValidation = false;
            this.barDockControl7.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl7.Location = new System.Drawing.Point(743, 0);
            this.barDockControl7.Manager = this.bmContaBanc;
            this.barDockControl7.Size = new System.Drawing.Size(0, 31);
            // 
            // XFrmCliForView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 604);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "XFrmCliForView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente:";
            ((System.ComponentModel.ISupportInitialize)(this.bmEndereco)).EndInit();
            this.standaloneBarDockControl2.ResumeLayout(false);
            this.standaloneBarDockControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelComercial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupTipoCliFor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRazaoSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNasc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNasc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbClassificacaoClifor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch0800.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosEndereco)).EndInit();
            this.groupControlDadosEndereco.ResumeLayout(false);
            this.groupControlDadosEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSemNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
            this.navigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDadosJuridicos)).EndInit();
            this.pnlDadosJuridicos.ResumeLayout(false);
            this.pnlDadosJuridicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInscMunicipal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInscEstadual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapitalSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPickerAtualizacao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPickerAtualizacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPickerAbertura.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPickerAbertura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEFR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataSituacaoEspecial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoSituacaoEspecial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacaoEspecial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaturezaJuridica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFantasia.Properties)).EndInit();
            this.navigationPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpControlQsa)).EndInit();
            this.grpControlQsa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlQsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpContrlAtvSec)).EndInit();
            this.grpContrlAtvSec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAtvSecundarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAtvSecundarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlAtvPrinc)).EndInit();
            this.grpControlAtvPrinc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAtvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAtvPrincipal)).EndInit();
            this.navigationPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCtbCliFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContaBancariaCliFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCtbCliFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmCliFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmContaBanc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbNome;
        private DevExpress.XtraEditors.LabelControl lbRg;
        private DevExpress.XtraEditors.LabelControl lbTipo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTelComercial;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtCelular;
        private DevExpress.XtraEditors.TextEdit txtTelefone;
        private DevExpress.XtraEditors.TextEdit txtRg;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.ComboBoxEdit cbClassificacaoClifor;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAddEndereco;
        private DevExpress.XtraBars.BarButtonItem btnViewEditEndereco;
        private DevExpress.XtraGrid.GridControl gridControlEnderecos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEnderecos;
        private DevExpress.XtraBars.BarButtonItem btnDelEndereco;
        private System.Windows.Forms.BindingSource bsEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliForEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colBairro;
        private DevExpress.XtraGrid.Columns.GridColumn colComplemento;
        private DevExpress.XtraGrid.Columns.GridColumn colCep;
        private DevExpress.XtraGrid.Columns.GridColumn colUf;
        private DevExpress.XtraGrid.Columns.GridColumn colCidade;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoEndereco;
        private DevExpress.XtraBars.BarManager bmCliFor;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnVoltar;
        private DevExpress.XtraBars.BarButtonItem barBtnSalvar;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarManager bmEndereco;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraEditors.TextEdit txtRazaoSocial;
        private DevExpress.XtraEditors.DateEdit dtDataNasc;
        private DevExpress.XtraEditors.RadioGroup radioGroupTipoCliFor;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSituacaoEspecial;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNomeFantasia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtNaturezaJuridica;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSituacao;
        private DevExpress.XtraEditors.GroupControl grpContrlAtvSec;
        private DevExpress.XtraEditors.GroupControl grpControlAtvPrinc;
        private DevExpress.XtraEditors.PanelControl pnlDadosJuridicos;
        private DevExpress.XtraGrid.GridControl gridControlAtvSecundarias;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAtvSecundarias;
        private DevExpress.XtraGrid.GridControl gridControlAtvPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAtvPrincipal;
        private DevExpress.XtraEditors.TextEdit txtMotivoSituacaoEspecial;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtDataSituacaoEspecial;
        private DevExpress.XtraEditors.TextEdit txtEFR;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtStatus;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.TextEdit txtDataSituacao;
        private DevExpress.XtraEditors.GroupControl grpControlQsa;
        private DevExpress.XtraGrid.GridControl gridControlQsa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewQsa;
        private DevExpress.XtraEditors.TextEdit txtTipo;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl lblCapitalSocial;
        private DevExpress.XtraEditors.TextEdit txtCapitalSocial;
        private DevExpress.XtraEditors.DateEdit dtPickerAtualizacao;
        private DevExpress.XtraEditors.DateEdit dtPickerAbertura;
        private DevExpress.XtraGrid.Columns.GridColumn colQual;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private CpfCnpjControl cnpjControl1;
        private DevExpress.XtraEditors.CheckEdit ch0800;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControlDadosEndereco;
        private CepControl cepControl1;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtEndereco;
        private DevExpress.XtraEditors.TextEdit txtComplemento;
        private DevExpress.XtraEditors.CheckEdit checkSemNumero;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.TextEdit txtBairro;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControlCtbCliFor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCtbCliFor;
        private DevExpress.XtraBars.BarManager bmContaBanc;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnAddContaCliFor;
        private DevExpress.XtraBars.BarButtonItem btnEditContaCliFor;
        private DevExpress.XtraBars.BarButtonItem btnRemoveContaCliFor;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private System.Windows.Forms.BindingSource bsContaBancariaCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdContaCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colAgencia;
        private DevExpress.XtraGrid.Columns.GridColumn colContaBancaria;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor1;
        private DevExpress.XtraEditors.TextEdit txtInscMunicipal;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.TextEdit txtInscEstadual;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private Components.LookUpMunicipio lookUpMunicipio1;
    }
}