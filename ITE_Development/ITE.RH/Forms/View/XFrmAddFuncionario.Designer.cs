using ITSolution.Framework.Components;

namespace ITE.RH.Forms.View
{
    partial class XFrmAddFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddFuncionario));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.navPanelPai = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navPaneInfoPessoais = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl46 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdade = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigoFunc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl45 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNomeMae = new DevExpress.XtraEditors.TextEdit();
            this.labelControl41 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl43 = new DevExpress.XtraEditors.LabelControl();
            this.dtDataExpRG = new DevExpress.XtraEditors.DateEdit();
            this.labelControl42 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl40 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomePai = new DevExpress.XtraEditors.TextEdit();
            this.txtOrgaoEmissorRG = new DevExpress.XtraEditors.TextEdit();
            this.txtRg = new DevExpress.XtraEditors.TextEdit();
            this.lbRg = new DevExpress.XtraEditors.LabelControl();
            this.btnSelecionarFoto = new DevExpress.XtraEditors.SimpleButton();
            this.lblFoto = new DevExpress.XtraEditors.LabelControl();
            this.pictureEditFoto = new DevExpress.XtraEditors.PictureEdit();
            this.txtCpf = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.cbEstadoCivil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.dtDataNasc = new DevExpress.XtraEditors.DateEdit();
            this.lbCpfCnpj = new DevExpress.XtraEditors.LabelControl();
            this.lbNome = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtCelular = new DevExpress.XtraEditors.TextEdit();
            this.txtTelFixo = new DevExpress.XtraEditors.TextEdit();
            this.navPaneDadosAdmissionais = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbTipoRecebimento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl44 = new DevExpress.XtraEditors.LabelControl();
            this.dtDataAdmissao = new DevExpress.XtraEditors.DateEdit();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.panelCtrlDepto = new DevExpress.XtraEditors.PanelControl();
            this.cbDepartamento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl37 = new DevExpress.XtraEditors.LabelControl();
            this.panelCtrlSituacao = new DevExpress.XtraEditors.PanelControl();
            this.cbSituacao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl39 = new DevExpress.XtraEditors.LabelControl();
            this.panelCtrlFuncao = new DevExpress.XtraEditors.PanelControl();
            this.cbFuncao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl38 = new DevExpress.XtraEditors.LabelControl();
            this.panelCtrlSalario = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.txtSalario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl36 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpMatrizFilial1 = new ITE.Components.LookUpMatrizFilial();
            this.navPaneHistoricoPai = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navPaneHistoricos = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navPaneHistSalarial = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlSalarial = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFuncionario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoSalario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHistoricoSalario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltbFuncionario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navPaneHistFuncao = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlFuncao = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHistoricoFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFuncionario2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltbFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFuncionarioFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navPaneHistDepartamento = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlDepto = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdHistoricoDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFuncionario3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltbFuncionario3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistoricoDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoDepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navPaneHistSituacao = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlSituacao = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFuncionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAdmissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataDemissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataHistorico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistorico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltbFuncionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdHistoricoSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navPaneEndereco = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.lookUpMunicipio1 = new ITE.Components.LookUpMunicipio();
            this.cepControl1 = new ITSolution.Framework.Components.CepControl();
            this.cbTipoLogradouros = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNumeroEnd = new DevExpress.XtraEditors.TextEdit();
            this.checkSemNumero = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.txtComplemento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.txtBairro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUf = new DevExpress.XtraEditors.TextEdit();
            this.txtCidade = new DevExpress.XtraEditors.TextEdit();
            this.txtEndereco = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.navPaneCTPS = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cbEstadoEmissaoCTPS = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtEmissaoCTPS = new DevExpress.XtraEditors.DateEdit();
            this.txtNumPis = new DevExpress.XtraEditors.TextEdit();
            this.txtSerieCTPS = new DevExpress.XtraEditors.TextEdit();
            this.txtNumCTPS = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.navPaneDocumentos = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtSituacaoMilitar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrgaoEmissaoCert = new DevExpress.XtraEditors.TextEdit();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.dtEmissaoCert = new DevExpress.XtraEditors.DateEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.txtRegiaoMilitar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.txtCircunscricaoMilitar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.txtCatMilitar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumCertReservista = new DevExpress.XtraEditors.TextEdit();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.dtTituloEleitor = new DevExpress.XtraEditors.DateEdit();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.txtUfTituloEleitoral = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.txtSecaoEleitoral = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtZonaEleitoral = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtTituloEleitor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.dtPrimeiraHab = new DevExpress.XtraEditors.DateEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.dtValidadeCNH = new DevExpress.XtraEditors.DateEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtCatCNH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumCNH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.navPageFechFolha = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grpEventos = new DevExpress.XtraEditors.GroupControl();
            this.gridControlEvtFunc = new DevExpress.XtraGrid.GridControl();
            this.eventoFuncionarioBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewEvtFunc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDscEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTpEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodCalculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColVlrEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.cbGrpEventoFunc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAddEvento = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoveEvento = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.navPanelPai.SuspendLayout();
            this.navPaneInfoPessoais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoFunc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeMae.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataExpRG.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataExpRG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomePai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgaoEmissorRG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditFoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstadoCivil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNasc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNasc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelFixo.Properties)).BeginInit();
            this.navPaneDadosAdmissionais.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoRecebimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataAdmissao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataAdmissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlDepto)).BeginInit();
            this.panelCtrlDepto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlSituacao)).BeginInit();
            this.panelCtrlSituacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlFuncao)).BeginInit();
            this.panelCtrlFuncao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFuncao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlSalario)).BeginInit();
            this.panelCtrlSalario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario.Properties)).BeginInit();
            this.navPaneHistoricoPai.SuspendLayout();
            this.navPaneHistoricos.SuspendLayout();
            this.navPaneHistSalarial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalarial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.navPaneHistFuncao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuncao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.navPaneHistDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.navPaneHistSituacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.navPaneEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoLogradouros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSemNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
            this.navPaneCTPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstadoEmissaoCTPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmissaoCTPS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmissaoCTPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieCTPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCTPS.Properties)).BeginInit();
            this.navPaneDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacaoMilitar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgaoEmissaoCert.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmissaoCert.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmissaoCert.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegiaoMilitar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCircunscricaoMilitar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatMilitar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCertReservista.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTituloEleitor.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTituloEleitor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUfTituloEleitoral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecaoEleitoral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZonaEleitoral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTituloEleitor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrimeiraHab.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrimeiraHab.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtValidadeCNH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtValidadeCNH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatCNH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCNH.Properties)).BeginInit();
            this.navPageFechFolha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpEventos)).BeginInit();
            this.grpEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvtFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvtFunc)).BeginInit();
            this.standaloneBarDockControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrpEventoFunc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnSalvar,
            this.barBtnCancelar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1011, 183);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnSalvar
            // 
            this.barBtnSalvar.Caption = "Salvar";
            this.barBtnSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.Glyph")));
            this.barBtnSalvar.Id = 1;
            this.barBtnSalvar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.barBtnSalvar.Name = "barBtnSalvar";
            this.barBtnSalvar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSalvar_ItemClick);
            // 
            // barBtnCancelar
            // 
            this.barBtnCancelar.Caption = "Voltar";
            this.barBtnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.Glyph")));
            this.barBtnCancelar.Id = 2;
            this.barBtnCancelar.Name = "barBtnCancelar";
            this.barBtnCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Admissão";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCancelar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSalvar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tarefas";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 726);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1011, 41);
            // 
            // navPanelPai
            // 
            this.navPanelPai.Controls.Add(this.navPaneInfoPessoais);
            this.navPanelPai.Controls.Add(this.navPaneDadosAdmissionais);
            this.navPanelPai.Controls.Add(this.navPaneHistoricoPai);
            this.navPanelPai.Controls.Add(this.navPaneEndereco);
            this.navPanelPai.Controls.Add(this.navPaneCTPS);
            this.navPanelPai.Controls.Add(this.navPaneDocumentos);
            this.navPanelPai.Controls.Add(this.navPageFechFolha);
            this.navPanelPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelPai.Location = new System.Drawing.Point(0, 183);
            this.navPanelPai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPanelPai.Name = "navPanelPai";
            this.navPanelPai.PageProperties.ShowCollapseButton = false;
            this.navPanelPai.PageProperties.ShowExpandButton = false;
            this.navPanelPai.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPaneInfoPessoais,
            this.navPaneEndereco,
            this.navPaneCTPS,
            this.navPaneDocumentos,
            this.navPaneDadosAdmissionais,
            this.navPaneHistoricoPai,
            this.navPageFechFolha});
            this.navPanelPai.RegularSize = new System.Drawing.Size(1011, 543);
            this.navPanelPai.SelectedPage = this.navPaneInfoPessoais;
            this.navPanelPai.SelectedPageIndex = 0;
            this.navPanelPai.Size = new System.Drawing.Size(1011, 543);
            this.navPanelPai.TabIndex = 0;
            this.navPanelPai.TransitionType = DevExpress.Utils.Animation.Transitions.Push;
            // 
            // navPaneInfoPessoais
            // 
            this.navPaneInfoPessoais.Caption = "Informações Pessoais";
            this.navPaneInfoPessoais.Controls.Add(this.labelControl46);
            this.navPaneInfoPessoais.Controls.Add(this.txtIdade);
            this.navPaneInfoPessoais.Controls.Add(this.txtCodigoFunc);
            this.navPaneInfoPessoais.Controls.Add(this.labelControl45);
            this.navPaneInfoPessoais.Controls.Add(this.groupControl1);
            this.navPaneInfoPessoais.Controls.Add(this.btnSelecionarFoto);
            this.navPaneInfoPessoais.Controls.Add(this.lblFoto);
            this.navPaneInfoPessoais.Controls.Add(this.pictureEditFoto);
            this.navPaneInfoPessoais.Controls.Add(this.txtCpf);
            this.navPaneInfoPessoais.Controls.Add(this.labelControl17);
            this.navPaneInfoPessoais.Controls.Add(this.cbEstadoCivil);
            this.navPaneInfoPessoais.Controls.Add(this.txtNome);
            this.navPaneInfoPessoais.Controls.Add(this.dtDataNasc);
            this.navPaneInfoPessoais.Controls.Add(this.lbCpfCnpj);
            this.navPaneInfoPessoais.Controls.Add(this.lbNome);
            this.navPaneInfoPessoais.Controls.Add(this.labelControl10);
            this.navPaneInfoPessoais.Controls.Add(this.labelControl2);
            this.navPaneInfoPessoais.Controls.Add(this.labelControl3);
            this.navPaneInfoPessoais.Controls.Add(this.labelControl1);
            this.navPaneInfoPessoais.Controls.Add(this.txtEmail);
            this.navPaneInfoPessoais.Controls.Add(this.txtCelular);
            this.navPaneInfoPessoais.Controls.Add(this.txtTelFixo);
            this.navPaneInfoPessoais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneInfoPessoais.Name = "navPaneInfoPessoais";
            this.navPaneInfoPessoais.Size = new System.Drawing.Size(839, 487);
            // 
            // labelControl46
            // 
            this.labelControl46.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl46.Location = new System.Drawing.Point(435, 158);
            this.labelControl46.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl46.Name = "labelControl46";
            this.labelControl46.Size = new System.Drawing.Size(38, 18);
            this.labelControl46.TabIndex = 62;
            this.labelControl46.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.EditValue = "";
            this.txtIdade.Location = new System.Drawing.Point(435, 181);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtIdade.Properties.Appearance.Options.UseFont = true;
            this.txtIdade.Properties.Mask.EditMask = "d";
            this.txtIdade.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIdade.Size = new System.Drawing.Size(145, 24);
            this.txtIdade.TabIndex = 7;
            // 
            // txtCodigoFunc
            // 
            this.txtCodigoFunc.Location = new System.Drawing.Point(678, 9);
            this.txtCodigoFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoFunc.MenuManager = this.ribbon;
            this.txtCodigoFunc.Name = "txtCodigoFunc";
            this.txtCodigoFunc.Size = new System.Drawing.Size(142, 22);
            this.txtCodigoFunc.TabIndex = 15;
            // 
            // labelControl45
            // 
            this.labelControl45.Location = new System.Drawing.Point(628, 12);
            this.labelControl45.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl45.Name = "labelControl45";
            this.labelControl45.Size = new System.Drawing.Size(44, 16);
            this.labelControl45.TabIndex = 59;
            this.labelControl45.Text = "Código:";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtNomeMae);
            this.groupControl1.Controls.Add(this.labelControl41);
            this.groupControl1.Controls.Add(this.labelControl43);
            this.groupControl1.Controls.Add(this.dtDataExpRG);
            this.groupControl1.Controls.Add(this.labelControl42);
            this.groupControl1.Controls.Add(this.labelControl40);
            this.groupControl1.Controls.Add(this.txtNomePai);
            this.groupControl1.Controls.Add(this.txtOrgaoEmissorRG);
            this.groupControl1.Controls.Add(this.txtRg);
            this.groupControl1.Controls.Add(this.lbRg);
            this.groupControl1.Location = new System.Drawing.Point(3, 287);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(840, 188);
            this.groupControl1.TabIndex = 58;
            this.groupControl1.Text = "Registro Geral";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(21, 142);
            this.txtNomeMae.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeMae.Properties.Appearance.Options.UseFont = true;
            this.txtNomeMae.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMae.Size = new System.Drawing.Size(353, 24);
            this.txtNomeMae.TabIndex = 12;
            // 
            // labelControl41
            // 
            this.labelControl41.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl41.Location = new System.Drawing.Point(226, 43);
            this.labelControl41.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl41.Name = "labelControl41";
            this.labelControl41.Size = new System.Drawing.Size(95, 18);
            this.labelControl41.TabIndex = 53;
            this.labelControl41.Text = "Orgão Emissor";
            // 
            // labelControl43
            // 
            this.labelControl43.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl43.Location = new System.Drawing.Point(432, 118);
            this.labelControl43.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl43.Name = "labelControl43";
            this.labelControl43.Size = new System.Drawing.Size(67, 18);
            this.labelControl43.TabIndex = 57;
            this.labelControl43.Text = "Nome Pai ";
            // 
            // dtDataExpRG
            // 
            this.dtDataExpRG.EditValue = null;
            this.dtDataExpRG.Location = new System.Drawing.Point(432, 66);
            this.dtDataExpRG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDataExpRG.Name = "dtDataExpRG";
            this.dtDataExpRG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtDataExpRG.Properties.Appearance.Options.UseFont = true;
            this.dtDataExpRG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataExpRG.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataExpRG.Size = new System.Drawing.Size(145, 24);
            this.dtDataExpRG.TabIndex = 11;
            // 
            // labelControl42
            // 
            this.labelControl42.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl42.Location = new System.Drawing.Point(21, 118);
            this.labelControl42.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl42.Name = "labelControl42";
            this.labelControl42.Size = new System.Drawing.Size(72, 18);
            this.labelControl42.TabIndex = 55;
            this.labelControl42.Text = "Nome Mãe";
            // 
            // labelControl40
            // 
            this.labelControl40.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl40.Location = new System.Drawing.Point(432, 43);
            this.labelControl40.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl40.Name = "labelControl40";
            this.labelControl40.Size = new System.Drawing.Size(101, 18);
            this.labelControl40.TabIndex = 51;
            this.labelControl40.Text = "Data Expedição";
            // 
            // txtNomePai
            // 
            this.txtNomePai.Location = new System.Drawing.Point(432, 142);
            this.txtNomePai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomePai.Properties.Appearance.Options.UseFont = true;
            this.txtNomePai.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomePai.Size = new System.Drawing.Size(384, 24);
            this.txtNomePai.TabIndex = 13;
            // 
            // txtOrgaoEmissorRG
            // 
            this.txtOrgaoEmissorRG.Location = new System.Drawing.Point(226, 66);
            this.txtOrgaoEmissorRG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrgaoEmissorRG.Name = "txtOrgaoEmissorRG";
            this.txtOrgaoEmissorRG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtOrgaoEmissorRG.Properties.Appearance.Options.UseFont = true;
            this.txtOrgaoEmissorRG.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrgaoEmissorRG.Size = new System.Drawing.Size(140, 24);
            this.txtOrgaoEmissorRG.TabIndex = 10;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(21, 66);
            this.txtRg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRg.Name = "txtRg";
            this.txtRg.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtRg.Properties.Appearance.Options.UseFont = true;
            this.txtRg.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRg.Size = new System.Drawing.Size(140, 24);
            this.txtRg.TabIndex = 9;
            // 
            // lbRg
            // 
            this.lbRg.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbRg.Location = new System.Drawing.Point(21, 43);
            this.lbRg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(19, 18);
            this.lbRg.TabIndex = 40;
            this.lbRg.Text = "RG";
            // 
            // btnSelecionarFoto
            // 
            this.btnSelecionarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarFoto.Image")));
            this.btnSelecionarFoto.Location = new System.Drawing.Point(773, 256);
            this.btnSelecionarFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionarFoto.Name = "btnSelecionarFoto";
            this.btnSelecionarFoto.Size = new System.Drawing.Size(55, 23);
            this.btnSelecionarFoto.TabIndex = 16;
            this.btnSelecionarFoto.Text = "...";
            this.btnSelecionarFoto.Click += new System.EventHandler(this.btnSelecionarFoto_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.Location = new System.Drawing.Point(615, 256);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(25, 16);
            this.lblFoto.TabIndex = 48;
            this.lblFoto.Text = "Foto";
            // 
            // pictureEditFoto
            // 
            this.pictureEditFoto.Location = new System.Drawing.Point(615, 37);
            this.pictureEditFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEditFoto.Name = "pictureEditFoto";
            this.pictureEditFoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEditFoto.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEditFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEditFoto.Size = new System.Drawing.Size(213, 213);
            this.pictureEditFoto.TabIndex = 47;
            this.pictureEditFoto.DoubleClick += new System.EventHandler(this.pictureEditFoto_DoubleClick);
            // 
            // txtCpf
            // 
            this.txtCpf.EditValue = "";
            this.txtCpf.Location = new System.Drawing.Point(24, 107);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCpf.Properties.Appearance.Options.UseFont = true;
            this.txtCpf.Properties.Mask.EditMask = "\\d\\d\\d\\.\\d\\d\\d\\.\\d\\d\\d-\\d\\d";
            this.txtCpf.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtCpf.Size = new System.Drawing.Size(145, 24);
            this.txtCpf.TabIndex = 1;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl17.Location = new System.Drawing.Point(435, 82);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(72, 18);
            this.labelControl17.TabIndex = 46;
            this.labelControl17.Text = "Estado Civil";
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Location = new System.Drawing.Point(435, 107);
            this.cbEstadoCivil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbEstadoCivil.Properties.Appearance.Options.UseFont = true;
            this.cbEstadoCivil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstadoCivil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbEstadoCivil.Size = new System.Drawing.Size(145, 24);
            this.cbEstadoCivil.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.EditValue = "";
            this.txtNome.Location = new System.Drawing.Point(24, 42);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNome.Properties.Appearance.Options.UseFont = true;
            this.txtNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Properties.NullText = "Nome do Funcionário";
            this.txtNome.Size = new System.Drawing.Size(556, 24);
            this.txtNome.TabIndex = 0;
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.EditValue = null;
            this.dtDataNasc.Location = new System.Drawing.Point(229, 107);
            this.dtDataNasc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtDataNasc.Properties.Appearance.Options.UseFont = true;
            this.dtDataNasc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataNasc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataNasc.Size = new System.Drawing.Size(145, 24);
            this.dtDataNasc.TabIndex = 3;
            // 
            // lbCpfCnpj
            // 
            this.lbCpfCnpj.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbCpfCnpj.Location = new System.Drawing.Point(24, 82);
            this.lbCpfCnpj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbCpfCnpj.Name = "lbCpfCnpj";
            this.lbCpfCnpj.Size = new System.Drawing.Size(25, 18);
            this.lbCpfCnpj.TabIndex = 39;
            this.lbCpfCnpj.Text = "CPF";
            // 
            // lbNome
            // 
            this.lbNome.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbNome.Location = new System.Drawing.Point(24, 18);
            this.lbNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(39, 18);
            this.lbNome.TabIndex = 38;
            this.lbNome.Text = "Nome";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl10.Location = new System.Drawing.Point(229, 82);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(112, 18);
            this.labelControl10.TabIndex = 44;
            this.labelControl10.Text = "Data Nascimento";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(229, 158);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 18);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "Celular";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(24, 224);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 18);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "Email";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(24, 158);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 18);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Telefone Fixo";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 249);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(556, 24);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCelular
            // 
            this.txtCelular.EditValue = "";
            this.txtCelular.Location = new System.Drawing.Point(229, 181);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCelular.Properties.Appearance.Options.UseFont = true;
            this.txtCelular.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\-\\d\\d\\d-\\d\\d\\d";
            this.txtCelular.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtCelular.Size = new System.Drawing.Size(145, 24);
            this.txtCelular.TabIndex = 6;
            // 
            // txtTelFixo
            // 
            this.txtTelFixo.Location = new System.Drawing.Point(24, 181);
            this.txtTelFixo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelFixo.Name = "txtTelFixo";
            this.txtTelFixo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTelFixo.Properties.Appearance.Options.UseFont = true;
            this.txtTelFixo.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelFixo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelFixo.Size = new System.Drawing.Size(145, 24);
            this.txtTelFixo.TabIndex = 5;
            // 
            // navPaneDadosAdmissionais
            // 
            this.navPaneDadosAdmissionais.Caption = "Dados Admissionais";
            this.navPaneDadosAdmissionais.Controls.Add(this.tableLayoutPanel1);
            this.navPaneDadosAdmissionais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneDadosAdmissionais.Name = "navPaneDadosAdmissionais";
            this.navPaneDadosAdmissionais.Size = new System.Drawing.Size(839, 487);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.260752F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.56637F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.50827F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.728132F));
            this.tableLayoutPanel1.Controls.Add(this.cbTipoRecebimento, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl44, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtDataAdmissao, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl35, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelCtrlDepto, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panelCtrlSituacao, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.panelCtrlFuncao, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panelCtrlSalario, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lookUpMatrizFilial1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.79105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.835821F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.68657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.43284F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(839, 487);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // cbTipoRecebimento
            // 
            this.cbTipoRecebimento.Location = new System.Drawing.Point(420, 24);
            this.cbTipoRecebimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoRecebimento.Name = "cbTipoRecebimento";
            this.cbTipoRecebimento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRecebimento.Properties.Appearance.Options.UseFont = true;
            this.cbTipoRecebimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoRecebimento.Properties.Items.AddRange(new object[] {
            "No Endereço",
            "Ponto de Atendimento"});
            this.cbTipoRecebimento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoRecebimento.Size = new System.Drawing.Size(231, 24);
            this.cbTipoRecebimento.TabIndex = 114;
            // 
            // labelControl44
            // 
            this.labelControl44.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl44.Location = new System.Drawing.Point(38, 2);
            this.labelControl44.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl44.Name = "labelControl44";
            this.labelControl44.Size = new System.Drawing.Size(98, 18);
            this.labelControl44.TabIndex = 17;
            this.labelControl44.Text = "Data Admissão";
            // 
            // dtDataAdmissao
            // 
            this.dtDataAdmissao.EditValue = null;
            this.dtDataAdmissao.Location = new System.Drawing.Point(38, 24);
            this.dtDataAdmissao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDataAdmissao.MenuManager = this.ribbon;
            this.dtDataAdmissao.Name = "dtDataAdmissao";
            this.dtDataAdmissao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtDataAdmissao.Properties.Appearance.Options.UseFont = true;
            this.dtDataAdmissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataAdmissao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataAdmissao.Size = new System.Drawing.Size(191, 24);
            this.dtDataAdmissao.TabIndex = 100;
            // 
            // labelControl35
            // 
            this.labelControl35.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl35.Location = new System.Drawing.Point(420, 2);
            this.labelControl35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(117, 18);
            this.labelControl35.TabIndex = 109;
            this.labelControl35.Text = "Tipo Recebimento";
            // 
            // panelCtrlDepto
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelCtrlDepto, 2);
            this.panelCtrlDepto.Controls.Add(this.cbDepartamento);
            this.panelCtrlDepto.Controls.Add(this.pictureEdit1);
            this.panelCtrlDepto.Controls.Add(this.labelControl37);
            this.panelCtrlDepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrlDepto.Location = new System.Drawing.Point(3, 194);
            this.panelCtrlDepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCtrlDepto.Name = "panelCtrlDepto";
            this.panelCtrlDepto.Size = new System.Drawing.Size(411, 118);
            this.panelCtrlDepto.TabIndex = 11;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.Location = new System.Drawing.Point(103, 47);
            this.cbDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.Properties.Appearance.Options.UseFont = true;
            this.cbDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDepartamento.Properties.Items.AddRange(new object[] {
            "No Endereço",
            "Ponto de Atendimento"});
            this.cbDepartamento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbDepartamento.Size = new System.Drawing.Size(300, 24);
            this.cbDepartamento.TabIndex = 103;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 5);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.MenuManager = this.ribbon;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 78);
            this.pictureEdit1.TabIndex = 111;
            // 
            // labelControl37
            // 
            this.labelControl37.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl37.Location = new System.Drawing.Point(103, 25);
            this.labelControl37.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl37.Name = "labelControl37";
            this.labelControl37.Size = new System.Drawing.Size(94, 18);
            this.labelControl37.TabIndex = 3;
            this.labelControl37.Text = "Departamento";
            // 
            // panelCtrlSituacao
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelCtrlSituacao, 2);
            this.panelCtrlSituacao.Controls.Add(this.cbSituacao);
            this.panelCtrlSituacao.Controls.Add(this.pictureEdit3);
            this.panelCtrlSituacao.Controls.Add(this.labelControl39);
            this.panelCtrlSituacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrlSituacao.Location = new System.Drawing.Point(420, 194);
            this.panelCtrlSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCtrlSituacao.Name = "panelCtrlSituacao";
            this.panelCtrlSituacao.Size = new System.Drawing.Size(416, 118);
            this.panelCtrlSituacao.TabIndex = 11;
            // 
            // cbSituacao
            // 
            this.cbSituacao.Location = new System.Drawing.Point(103, 47);
            this.cbSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacao.Properties.Appearance.Options.UseFont = true;
            this.cbSituacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSituacao.Properties.Items.AddRange(new object[] {
            "No Endereço",
            "Ponto de Atendimento"});
            this.cbSituacao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSituacao.Size = new System.Drawing.Size(300, 24);
            this.cbSituacao.TabIndex = 113;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(-3, 5);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit3.MenuManager = this.ribbon;
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(100, 78);
            this.pictureEdit3.TabIndex = 112;
            // 
            // labelControl39
            // 
            this.labelControl39.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl39.Location = new System.Drawing.Point(103, 20);
            this.labelControl39.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl39.Name = "labelControl39";
            this.labelControl39.Size = new System.Drawing.Size(54, 18);
            this.labelControl39.TabIndex = 7;
            this.labelControl39.Text = "Situação";
            // 
            // panelCtrlFuncao
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelCtrlFuncao, 2);
            this.panelCtrlFuncao.Controls.Add(this.cbFuncao);
            this.panelCtrlFuncao.Controls.Add(this.pictureEdit2);
            this.panelCtrlFuncao.Controls.Add(this.labelControl38);
            this.panelCtrlFuncao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrlFuncao.Location = new System.Drawing.Point(3, 338);
            this.panelCtrlFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCtrlFuncao.Name = "panelCtrlFuncao";
            this.panelCtrlFuncao.Size = new System.Drawing.Size(411, 106);
            this.panelCtrlFuncao.TabIndex = 10;
            // 
            // cbFuncao
            // 
            this.cbFuncao.Location = new System.Drawing.Point(103, 43);
            this.cbFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncao.Properties.Appearance.Options.UseFont = true;
            this.cbFuncao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFuncao.Properties.Items.AddRange(new object[] {
            "No Endereço",
            "Ponto de Atendimento"});
            this.cbFuncao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFuncao.Size = new System.Drawing.Size(300, 24);
            this.cbFuncao.TabIndex = 105;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(-3, 5);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit2.MenuManager = this.ribbon;
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(100, 78);
            this.pictureEdit2.TabIndex = 111;
            // 
            // labelControl38
            // 
            this.labelControl38.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl38.Location = new System.Drawing.Point(103, 20);
            this.labelControl38.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl38.Name = "labelControl38";
            this.labelControl38.Size = new System.Drawing.Size(47, 18);
            this.labelControl38.TabIndex = 5;
            this.labelControl38.Text = "Função";
            // 
            // panelCtrlSalario
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelCtrlSalario, 2);
            this.panelCtrlSalario.Controls.Add(this.pictureEdit4);
            this.panelCtrlSalario.Controls.Add(this.txtSalario);
            this.panelCtrlSalario.Controls.Add(this.labelControl36);
            this.panelCtrlSalario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrlSalario.Location = new System.Drawing.Point(420, 338);
            this.panelCtrlSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCtrlSalario.Name = "panelCtrlSalario";
            this.panelCtrlSalario.Size = new System.Drawing.Size(416, 106);
            this.panelCtrlSalario.TabIndex = 13;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(0, 5);
            this.pictureEdit4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit4.MenuManager = this.ribbon;
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(100, 78);
            this.pictureEdit4.TabIndex = 113;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(103, 43);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalario.MenuManager = this.ribbon;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSalario.Properties.Appearance.Options.UseFont = true;
            this.txtSalario.Properties.Mask.EditMask = "n";
            this.txtSalario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSalario.Size = new System.Drawing.Size(191, 24);
            this.txtSalario.TabIndex = 106;
            // 
            // labelControl36
            // 
            this.labelControl36.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl36.Location = new System.Drawing.Point(103, 18);
            this.labelControl36.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl36.Name = "labelControl36";
            this.labelControl36.Size = new System.Drawing.Size(41, 18);
            this.labelControl36.TabIndex = 1;
            this.labelControl36.Text = "Salário";
            // 
            // lookUpMatrizFilial1
            // 
            this.lookUpMatrizFilial1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lookUpMatrizFilial1, 2);
            this.lookUpMatrizFilial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lookUpMatrizFilial1.Filial = null;
            this.lookUpMatrizFilial1.Location = new System.Drawing.Point(38, 55);
            this.lookUpMatrizFilial1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lookUpMatrizFilial1.Matriz = null;
            this.lookUpMatrizFilial1.Name = "lookUpMatrizFilial1";
            this.lookUpMatrizFilial1.Size = new System.Drawing.Size(757, 111);
            this.lookUpMatrizFilial1.TabIndex = 102;
            // 
            // navPaneHistoricoPai
            // 
            this.navPaneHistoricoPai.Caption = "Históricos";
            this.navPaneHistoricoPai.Controls.Add(this.navPaneHistoricos);
            this.navPaneHistoricoPai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneHistoricoPai.Name = "navPaneHistoricoPai";
            this.navPaneHistoricoPai.Size = new System.Drawing.Size(839, 487);
            // 
            // navPaneHistoricos
            // 
            this.navPaneHistoricos.Controls.Add(this.navPaneHistSalarial);
            this.navPaneHistoricos.Controls.Add(this.navPaneHistFuncao);
            this.navPaneHistoricos.Controls.Add(this.navPaneHistDepartamento);
            this.navPaneHistoricos.Controls.Add(this.navPaneHistSituacao);
            this.navPaneHistoricos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPaneHistoricos.Location = new System.Drawing.Point(0, 0);
            this.navPaneHistoricos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneHistoricos.Name = "navPaneHistoricos";
            this.navPaneHistoricos.PageProperties.ShowCollapseButton = false;
            this.navPaneHistoricos.PageProperties.ShowExpandButton = false;
            this.navPaneHistoricos.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPaneHistSalarial,
            this.navPaneHistFuncao,
            this.navPaneHistDepartamento,
            this.navPaneHistSituacao});
            this.navPaneHistoricos.RegularSize = new System.Drawing.Size(839, 487);
            this.navPaneHistoricos.SelectedPage = this.navPaneHistSalarial;
            this.navPaneHistoricos.SelectedPageIndex = 0;
            this.navPaneHistoricos.Size = new System.Drawing.Size(839, 487);
            this.navPaneHistoricos.TabIndex = 0;
            // 
            // navPaneHistSalarial
            // 
            this.navPaneHistSalarial.Caption = "Histórico Salárial";
            this.navPaneHistSalarial.Controls.Add(this.gridControlSalarial);
            this.navPaneHistSalarial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneHistSalarial.Name = "navPaneHistSalarial";
            this.navPaneHistSalarial.Size = new System.Drawing.Size(657, 431);
            // 
            // gridControlSalarial
            // 
            this.gridControlSalarial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSalarial.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlSalarial.Location = new System.Drawing.Point(0, 0);
            this.gridControlSalarial.MainView = this.gridView1;
            this.gridControlSalarial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlSalarial.Name = "gridControlSalarial";
            this.gridControlSalarial.Size = new System.Drawing.Size(657, 431);
            this.gridControlSalarial.TabIndex = 0;
            this.gridControlSalarial.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFuncionario1,
            this.colDataRef,
            this.colSalario,
            this.colMotivoSalario,
            this.colIdHistoricoSalario,
            this.coltbFuncionario1});
            this.gridView1.GridControl = this.gridControlSalarial;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFuncionario1
            // 
            this.colIdFuncionario1.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFuncionario1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario1.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFuncionario1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario1.FieldName = "IdFuncionario";
            this.colIdFuncionario1.Name = "colIdFuncionario1";
            // 
            // colDataRef
            // 
            this.colDataRef.AppearanceCell.Options.UseTextOptions = true;
            this.colDataRef.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataRef.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataRef.Caption = "Data Ref.";
            this.colDataRef.FieldName = "Data";
            this.colDataRef.Name = "colDataRef";
            this.colDataRef.Visible = true;
            this.colDataRef.VisibleIndex = 3;
            this.colDataRef.Width = 100;
            // 
            // colSalario
            // 
            this.colSalario.AppearanceCell.Options.UseTextOptions = true;
            this.colSalario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSalario.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSalario.Caption = "Salário";
            this.colSalario.DisplayFormat.FormatString = "n2";
            this.colSalario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSalario.FieldName = "Salario";
            this.colSalario.Name = "colSalario";
            this.colSalario.Visible = true;
            this.colSalario.VisibleIndex = 1;
            this.colSalario.Width = 151;
            // 
            // colMotivoSalario
            // 
            this.colMotivoSalario.AppearanceCell.Options.UseTextOptions = true;
            this.colMotivoSalario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMotivoSalario.AppearanceHeader.Options.UseTextOptions = true;
            this.colMotivoSalario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMotivoSalario.FieldName = "Motivo";
            this.colMotivoSalario.Name = "colMotivoSalario";
            this.colMotivoSalario.Visible = true;
            this.colMotivoSalario.VisibleIndex = 2;
            this.colMotivoSalario.Width = 299;
            // 
            // colIdHistoricoSalario
            // 
            this.colIdHistoricoSalario.AppearanceCell.Options.UseTextOptions = true;
            this.colIdHistoricoSalario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdHistoricoSalario.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdHistoricoSalario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdHistoricoSalario.Caption = "ID";
            this.colIdHistoricoSalario.FieldName = "IdHistoricoSalario";
            this.colIdHistoricoSalario.Name = "colIdHistoricoSalario";
            this.colIdHistoricoSalario.Visible = true;
            this.colIdHistoricoSalario.VisibleIndex = 0;
            this.colIdHistoricoSalario.Width = 100;
            // 
            // coltbFuncionario1
            // 
            this.coltbFuncionario1.AppearanceCell.Options.UseTextOptions = true;
            this.coltbFuncionario1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coltbFuncionario1.AppearanceHeader.Options.UseTextOptions = true;
            this.coltbFuncionario1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coltbFuncionario1.FieldName = "tbFuncionario";
            this.coltbFuncionario1.Name = "coltbFuncionario1";
            // 
            // navPaneHistFuncao
            // 
            this.navPaneHistFuncao.Caption = "Histórico Funções";
            this.navPaneHistFuncao.Controls.Add(this.gridControlFuncao);
            this.navPaneHistFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneHistFuncao.Name = "navPaneHistFuncao";
            this.navPaneHistFuncao.Size = new System.Drawing.Size(657, 431);
            // 
            // gridControlFuncao
            // 
            this.gridControlFuncao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFuncao.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlFuncao.Location = new System.Drawing.Point(0, 0);
            this.gridControlFuncao.MainView = this.gridView2;
            this.gridControlFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlFuncao.Name = "gridControlFuncao";
            this.gridControlFuncao.Size = new System.Drawing.Size(657, 431);
            this.gridControlFuncao.TabIndex = 0;
            this.gridControlFuncao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHistoricoFuncao,
            this.colIdFuncionario2,
            this.colIdFuncao,
            this.colData,
            this.coltbFuncao,
            this.colFuncionarioFuncao,
            this.colMotivoFuncao});
            this.gridView2.GridControl = this.gridControlFuncao;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdHistoricoFuncao
            // 
            this.colIdHistoricoFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdHistoricoFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdHistoricoFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdHistoricoFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdHistoricoFuncao.Caption = "ID";
            this.colIdHistoricoFuncao.FieldName = "IdHistoricoFuncao";
            this.colIdHistoricoFuncao.Name = "colIdHistoricoFuncao";
            this.colIdHistoricoFuncao.Visible = true;
            this.colIdHistoricoFuncao.VisibleIndex = 0;
            this.colIdHistoricoFuncao.Width = 100;
            // 
            // colIdFuncionario2
            // 
            this.colIdFuncionario2.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFuncionario2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario2.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFuncionario2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario2.FieldName = "IdFuncionario";
            this.colIdFuncionario2.Name = "colIdFuncionario2";
            // 
            // colIdFuncao
            // 
            this.colIdFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncao.FieldName = "IdFuncao";
            this.colIdFuncao.Name = "colIdFuncao";
            // 
            // colData
            // 
            this.colData.AppearanceCell.Options.UseTextOptions = true;
            this.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colData.AppearanceHeader.Options.UseTextOptions = true;
            this.colData.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colData.Caption = "Data Ref.";
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 3;
            this.colData.Width = 100;
            // 
            // coltbFuncao
            // 
            this.coltbFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.coltbFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coltbFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.coltbFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coltbFuncao.Caption = "Função";
            this.coltbFuncao.FieldName = "Funcao.NomeFuncao";
            this.coltbFuncao.Name = "coltbFuncao";
            this.coltbFuncao.Visible = true;
            this.coltbFuncao.VisibleIndex = 1;
            this.coltbFuncao.Width = 250;
            // 
            // colFuncionarioFuncao
            // 
            this.colFuncionarioFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colFuncionarioFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFuncionarioFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colFuncionarioFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFuncionarioFuncao.FieldName = "Funcionario";
            this.colFuncionarioFuncao.Name = "colFuncionarioFuncao";
            // 
            // colMotivoFuncao
            // 
            this.colMotivoFuncao.FieldName = "Motivo";
            this.colMotivoFuncao.Name = "colMotivoFuncao";
            this.colMotivoFuncao.Visible = true;
            this.colMotivoFuncao.VisibleIndex = 2;
            this.colMotivoFuncao.Width = 200;
            // 
            // navPaneHistDepartamento
            // 
            this.navPaneHistDepartamento.Caption = "Histórico Departamento";
            this.navPaneHistDepartamento.Controls.Add(this.gridControlDepto);
            this.navPaneHistDepartamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneHistDepartamento.Name = "navPaneHistDepartamento";
            this.navPaneHistDepartamento.Size = new System.Drawing.Size(657, 431);
            // 
            // gridControlDepto
            // 
            this.gridControlDepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDepto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlDepto.Location = new System.Drawing.Point(0, 0);
            this.gridControlDepto.MainView = this.gridView3;
            this.gridControlDepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlDepto.Name = "gridControlDepto";
            this.gridControlDepto.Size = new System.Drawing.Size(657, 431);
            this.gridControlDepto.TabIndex = 0;
            this.gridControlDepto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdHistoricoDepartamento,
            this.colIdFuncionario3,
            this.colIdDepartamento,
            this.colData1,
            this.coltbFuncionario3,
            this.colHistoricoDepartamento,
            this.colMotivoDepto});
            this.gridView3.GridControl = this.gridControlDepto;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colIdHistoricoDepartamento
            // 
            this.colIdHistoricoDepartamento.AppearanceCell.Options.UseTextOptions = true;
            this.colIdHistoricoDepartamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdHistoricoDepartamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdHistoricoDepartamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdHistoricoDepartamento.Caption = "ID";
            this.colIdHistoricoDepartamento.FieldName = "IdHistoricoDepartamento";
            this.colIdHistoricoDepartamento.Name = "colIdHistoricoDepartamento";
            this.colIdHistoricoDepartamento.Visible = true;
            this.colIdHistoricoDepartamento.VisibleIndex = 0;
            this.colIdHistoricoDepartamento.Width = 100;
            // 
            // colIdFuncionario3
            // 
            this.colIdFuncionario3.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFuncionario3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario3.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFuncionario3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario3.FieldName = "IdFuncionario";
            this.colIdFuncionario3.Name = "colIdFuncionario3";
            // 
            // colIdDepartamento
            // 
            this.colIdDepartamento.AppearanceCell.Options.UseTextOptions = true;
            this.colIdDepartamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdDepartamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdDepartamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdDepartamento.FieldName = "IdDepartamento";
            this.colIdDepartamento.Name = "colIdDepartamento";
            // 
            // colData1
            // 
            this.colData1.AppearanceCell.Options.UseTextOptions = true;
            this.colData1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colData1.AppearanceHeader.Options.UseTextOptions = true;
            this.colData1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colData1.Caption = "Data Ref.";
            this.colData1.FieldName = "Data";
            this.colData1.Name = "colData1";
            this.colData1.Visible = true;
            this.colData1.VisibleIndex = 3;
            this.colData1.Width = 100;
            // 
            // coltbFuncionario3
            // 
            this.coltbFuncionario3.AppearanceCell.Options.UseTextOptions = true;
            this.coltbFuncionario3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coltbFuncionario3.AppearanceHeader.Options.UseTextOptions = true;
            this.coltbFuncionario3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coltbFuncionario3.Caption = "Funcionário";
            this.coltbFuncionario3.FieldName = "tbFuncionario";
            this.coltbFuncionario3.Name = "coltbFuncionario3";
            // 
            // colHistoricoDepartamento
            // 
            this.colHistoricoDepartamento.AppearanceCell.Options.UseTextOptions = true;
            this.colHistoricoDepartamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoDepartamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistoricoDepartamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoDepartamento.Caption = "Departamento";
            this.colHistoricoDepartamento.FieldName = "Departamento.NomeDepartamento";
            this.colHistoricoDepartamento.Name = "colHistoricoDepartamento";
            this.colHistoricoDepartamento.Visible = true;
            this.colHistoricoDepartamento.VisibleIndex = 1;
            this.colHistoricoDepartamento.Width = 250;
            // 
            // colMotivoDepto
            // 
            this.colMotivoDepto.FieldName = "Motivo";
            this.colMotivoDepto.Name = "colMotivoDepto";
            this.colMotivoDepto.Visible = true;
            this.colMotivoDepto.VisibleIndex = 2;
            this.colMotivoDepto.Width = 200;
            // 
            // navPaneHistSituacao
            // 
            this.navPaneHistSituacao.Caption = "Histórico Situação";
            this.navPaneHistSituacao.Controls.Add(this.gridControlSituacao);
            this.navPaneHistSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneHistSituacao.Name = "navPaneHistSituacao";
            this.navPaneHistSituacao.Size = new System.Drawing.Size(657, 431);
            // 
            // gridControlSituacao
            // 
            this.gridControlSituacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSituacao.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlSituacao.Location = new System.Drawing.Point(0, 0);
            this.gridControlSituacao.MainView = this.gridView4;
            this.gridControlSituacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlSituacao.Name = "gridControlSituacao";
            this.gridControlSituacao.Size = new System.Drawing.Size(657, 431);
            this.gridControlSituacao.TabIndex = 0;
            this.gridControlSituacao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFuncionario,
            this.colDataAdmissao,
            this.colDataDemissao,
            this.colSituacao,
            this.colDataHistorico,
            this.colHistorico,
            this.coltbFuncionario,
            this.colIdHistoricoSituacao});
            this.gridView4.GridControl = this.gridControlSituacao;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIdFuncionario
            // 
            this.colIdFuncionario.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFuncionario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFuncionario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario.FieldName = "IdFuncionario";
            this.colIdFuncionario.Name = "colIdFuncionario";
            // 
            // colDataAdmissao
            // 
            this.colDataAdmissao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataAdmissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataAdmissao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataAdmissao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataAdmissao.Caption = "Dt. Admissão";
            this.colDataAdmissao.FieldName = "DataAdmissao";
            this.colDataAdmissao.Name = "colDataAdmissao";
            this.colDataAdmissao.Visible = true;
            this.colDataAdmissao.VisibleIndex = 2;
            this.colDataAdmissao.Width = 91;
            // 
            // colDataDemissao
            // 
            this.colDataDemissao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataDemissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataDemissao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataDemissao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataDemissao.Caption = "Dt. Demissão";
            this.colDataDemissao.FieldName = "DataDemissao";
            this.colDataDemissao.Name = "colDataDemissao";
            this.colDataDemissao.Visible = true;
            this.colDataDemissao.VisibleIndex = 3;
            this.colDataDemissao.Width = 91;
            // 
            // colSituacao
            // 
            this.colSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.colSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSituacao.Caption = "Situação";
            this.colSituacao.FieldName = "Situacao";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.Visible = true;
            this.colSituacao.VisibleIndex = 1;
            this.colSituacao.Width = 114;
            // 
            // colDataHistorico
            // 
            this.colDataHistorico.AppearanceCell.Options.UseTextOptions = true;
            this.colDataHistorico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataHistorico.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataHistorico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataHistorico.Caption = "Data Ref.";
            this.colDataHistorico.FieldName = "Data";
            this.colDataHistorico.Name = "colDataHistorico";
            this.colDataHistorico.Visible = true;
            this.colDataHistorico.VisibleIndex = 5;
            this.colDataHistorico.Width = 91;
            // 
            // colHistorico
            // 
            this.colHistorico.AppearanceCell.Options.UseTextOptions = true;
            this.colHistorico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistorico.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistorico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistorico.Caption = "Histórico";
            this.colHistorico.FieldName = "Historico";
            this.colHistorico.Name = "colHistorico";
            this.colHistorico.Visible = true;
            this.colHistorico.VisibleIndex = 4;
            this.colHistorico.Width = 163;
            // 
            // coltbFuncionario
            // 
            this.coltbFuncionario.AppearanceCell.Options.UseTextOptions = true;
            this.coltbFuncionario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coltbFuncionario.AppearanceHeader.Options.UseTextOptions = true;
            this.coltbFuncionario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.coltbFuncionario.FieldName = "tbFuncionario";
            this.coltbFuncionario.Name = "coltbFuncionario";
            // 
            // colIdHistoricoSituacao
            // 
            this.colIdHistoricoSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdHistoricoSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdHistoricoSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdHistoricoSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdHistoricoSituacao.Caption = "ID";
            this.colIdHistoricoSituacao.FieldName = "IdHistoricoSituacao";
            this.colIdHistoricoSituacao.Name = "colIdHistoricoSituacao";
            this.colIdHistoricoSituacao.Visible = true;
            this.colIdHistoricoSituacao.VisibleIndex = 0;
            this.colIdHistoricoSituacao.Width = 100;
            // 
            // navPaneEndereco
            // 
            this.navPaneEndereco.Caption = "Endereço";
            this.navPaneEndereco.Controls.Add(this.lookUpMunicipio1);
            this.navPaneEndereco.Controls.Add(this.cepControl1);
            this.navPaneEndereco.Controls.Add(this.cbTipoLogradouros);
            this.navPaneEndereco.Controls.Add(this.txtNumeroEnd);
            this.navPaneEndereco.Controls.Add(this.checkSemNumero);
            this.navPaneEndereco.Controls.Add(this.labelControl34);
            this.navPaneEndereco.Controls.Add(this.txtComplemento);
            this.navPaneEndereco.Controls.Add(this.labelControl33);
            this.navPaneEndereco.Controls.Add(this.txtBairro);
            this.navPaneEndereco.Controls.Add(this.labelControl6);
            this.navPaneEndereco.Controls.Add(this.labelControl5);
            this.navPaneEndereco.Controls.Add(this.txtUf);
            this.navPaneEndereco.Controls.Add(this.txtCidade);
            this.navPaneEndereco.Controls.Add(this.txtEndereco);
            this.navPaneEndereco.Controls.Add(this.labelControl7);
            this.navPaneEndereco.Controls.Add(this.labelControl8);
            this.navPaneEndereco.Controls.Add(this.labelControl9);
            this.navPaneEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneEndereco.Name = "navPaneEndereco";
            this.navPaneEndereco.Size = new System.Drawing.Size(839, 487);
            // 
            // lookUpMunicipio1
            // 
            this.lookUpMunicipio1.AutoSize = true;
            this.lookUpMunicipio1.Location = new System.Drawing.Point(23, 223);
            this.lookUpMunicipio1.Margin = new System.Windows.Forms.Padding(5);
            this.lookUpMunicipio1.MdiForm = null;
            this.lookUpMunicipio1.Municipio = null;
            this.lookUpMunicipio1.Name = "lookUpMunicipio1";
            this.lookUpMunicipio1.ReadyOnly = false;
            this.lookUpMunicipio1.Size = new System.Drawing.Size(293, 66);
            this.lookUpMunicipio1.TabIndex = 66;
            this.lookUpMunicipio1.UF = null;
            // 
            // cepControl1
            // 
            this.cepControl1.AutoSize = true;
            this.cepControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cepControl1.Location = new System.Drawing.Point(406, 139);
            this.cepControl1.Margin = new System.Windows.Forms.Padding(2);
            this.cepControl1.Name = "cepControl1";
            this.cepControl1.ReadyOnly = false;
            this.cepControl1.Size = new System.Drawing.Size(201, 64);
            this.cepControl1.TabIndex = 65;
            // 
            // cbTipoLogradouros
            // 
            this.cbTipoLogradouros.Location = new System.Drawing.Point(23, 43);
            this.cbTipoLogradouros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoLogradouros.MenuManager = this.ribbon;
            this.cbTipoLogradouros.Name = "cbTipoLogradouros";
            this.cbTipoLogradouros.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbTipoLogradouros.Properties.Appearance.Options.UseFont = true;
            this.cbTipoLogradouros.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbTipoLogradouros.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbTipoLogradouros.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoLogradouros.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoLogradouros.Size = new System.Drawing.Size(154, 24);
            this.cbTipoLogradouros.TabIndex = 30;
            // 
            // txtNumeroEnd
            // 
            this.txtNumeroEnd.Location = new System.Drawing.Point(23, 108);
            this.txtNumeroEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroEnd.Name = "txtNumeroEnd";
            this.txtNumeroEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumeroEnd.Properties.Appearance.Options.UseFont = true;
            this.txtNumeroEnd.Properties.MaxLength = 10;
            this.txtNumeroEnd.Size = new System.Drawing.Size(198, 24);
            this.txtNumeroEnd.TabIndex = 32;
            // 
            // checkSemNumero
            // 
            this.checkSemNumero.Location = new System.Drawing.Point(163, 80);
            this.checkSemNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSemNumero.Name = "checkSemNumero";
            this.checkSemNumero.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkSemNumero.Properties.Appearance.Options.UseFont = true;
            this.checkSemNumero.Properties.Caption = "S\\N";
            this.checkSemNumero.Size = new System.Drawing.Size(58, 22);
            this.checkSemNumero.TabIndex = 64;
            // 
            // labelControl34
            // 
            this.labelControl34.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl34.Location = new System.Drawing.Point(23, 84);
            this.labelControl34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(52, 18);
            this.labelControl34.TabIndex = 63;
            this.labelControl34.Text = "Número";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(23, 175);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtComplemento.Properties.Appearance.Options.UseFont = true;
            this.txtComplemento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Size = new System.Drawing.Size(331, 24);
            this.txtComplemento.TabIndex = 34;
            // 
            // labelControl33
            // 
            this.labelControl33.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl33.Location = new System.Drawing.Point(23, 151);
            this.labelControl33.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(90, 18);
            this.labelControl33.TabIndex = 59;
            this.labelControl33.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(406, 108);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Properties.Appearance.Options.UseFont = true;
            this.txtBairro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Size = new System.Drawing.Size(331, 24);
            this.txtBairro.TabIndex = 33;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(411, 336);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 18);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Estado";
            this.labelControl6.Visible = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(23, 336);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 18);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Cidade";
            this.labelControl5.Visible = false;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(411, 362);
            this.txtUf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUf.Name = "txtUf";
            this.txtUf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.Properties.Appearance.Options.UseFont = true;
            this.txtUf.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Size = new System.Drawing.Size(195, 24);
            this.txtUf.TabIndex = 37;
            this.txtUf.Visible = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(23, 362);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Properties.Appearance.Options.UseFont = true;
            this.txtCidade.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Size = new System.Drawing.Size(331, 24);
            this.txtCidade.TabIndex = 36;
            this.txtCidade.Visible = false;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(198, 44);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Properties.Appearance.Options.UseFont = true;
            this.txtEndereco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Size = new System.Drawing.Size(539, 24);
            this.txtEndereco.TabIndex = 31;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(23, 18);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(106, 18);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Tipo Logradouro";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(198, 18);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 18);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Endereço";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(406, 85);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 18);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Bairro";
            // 
            // navPaneCTPS
            // 
            this.navPaneCTPS.Caption = "CTPS";
            this.navPaneCTPS.Controls.Add(this.cbEstadoEmissaoCTPS);
            this.navPaneCTPS.Controls.Add(this.dtEmissaoCTPS);
            this.navPaneCTPS.Controls.Add(this.txtNumPis);
            this.navPaneCTPS.Controls.Add(this.txtSerieCTPS);
            this.navPaneCTPS.Controls.Add(this.txtNumCTPS);
            this.navPaneCTPS.Controls.Add(this.labelControl15);
            this.navPaneCTPS.Controls.Add(this.labelControl14);
            this.navPaneCTPS.Controls.Add(this.labelControl13);
            this.navPaneCTPS.Controls.Add(this.labelControl12);
            this.navPaneCTPS.Controls.Add(this.labelControl11);
            this.navPaneCTPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneCTPS.Name = "navPaneCTPS";
            this.navPaneCTPS.Size = new System.Drawing.Size(839, 487);
            // 
            // cbEstadoEmissaoCTPS
            // 
            this.cbEstadoEmissaoCTPS.Location = new System.Drawing.Point(23, 123);
            this.cbEstadoEmissaoCTPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstadoEmissaoCTPS.Name = "cbEstadoEmissaoCTPS";
            this.cbEstadoEmissaoCTPS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbEstadoEmissaoCTPS.Properties.Appearance.Options.UseFont = true;
            this.cbEstadoEmissaoCTPS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEstadoEmissaoCTPS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbEstadoEmissaoCTPS.Size = new System.Drawing.Size(199, 24);
            this.cbEstadoEmissaoCTPS.TabIndex = 53;
            // 
            // dtEmissaoCTPS
            // 
            this.dtEmissaoCTPS.EditValue = null;
            this.dtEmissaoCTPS.Location = new System.Drawing.Point(576, 50);
            this.dtEmissaoCTPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEmissaoCTPS.Name = "dtEmissaoCTPS";
            this.dtEmissaoCTPS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtEmissaoCTPS.Properties.Appearance.Options.UseFont = true;
            this.dtEmissaoCTPS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmissaoCTPS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmissaoCTPS.Size = new System.Drawing.Size(147, 24);
            this.dtEmissaoCTPS.TabIndex = 52;
            // 
            // txtNumPis
            // 
            this.txtNumPis.Location = new System.Drawing.Point(306, 121);
            this.txtNumPis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumPis.Name = "txtNumPis";
            this.txtNumPis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumPis.Properties.Appearance.Options.UseFont = true;
            this.txtNumPis.Size = new System.Drawing.Size(199, 24);
            this.txtNumPis.TabIndex = 54;
            // 
            // txtSerieCTPS
            // 
            this.txtSerieCTPS.Location = new System.Drawing.Point(306, 50);
            this.txtSerieCTPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSerieCTPS.Name = "txtSerieCTPS";
            this.txtSerieCTPS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSerieCTPS.Properties.Appearance.Options.UseFont = true;
            this.txtSerieCTPS.Size = new System.Drawing.Size(199, 24);
            this.txtSerieCTPS.TabIndex = 51;
            // 
            // txtNumCTPS
            // 
            this.txtNumCTPS.Location = new System.Drawing.Point(23, 50);
            this.txtNumCTPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCTPS.Name = "txtNumCTPS";
            this.txtNumCTPS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumCTPS.Properties.Appearance.Options.UseFont = true;
            this.txtNumCTPS.Size = new System.Drawing.Size(199, 24);
            this.txtNumCTPS.TabIndex = 50;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl15.Location = new System.Drawing.Point(306, 94);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(79, 18);
            this.labelControl15.TabIndex = 4;
            this.labelControl15.Text = "Número PIS";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl14.Location = new System.Drawing.Point(23, 94);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(142, 18);
            this.labelControl14.TabIndex = 3;
            this.labelControl14.Text = "Estado Emissão CTPS";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl13.Location = new System.Drawing.Point(576, 25);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(129, 18);
            this.labelControl13.TabIndex = 2;
            this.labelControl13.Text = "Data Emissão CTPS";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl12.Location = new System.Drawing.Point(306, 25);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(71, 18);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "Série CTPS";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl11.Location = new System.Drawing.Point(23, 25);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(92, 18);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Número CTPS";
            // 
            // navPaneDocumentos
            // 
            this.navPaneDocumentos.Caption = "Documentos";
            this.navPaneDocumentos.Controls.Add(this.separatorControl2);
            this.navPaneDocumentos.Controls.Add(this.separatorControl1);
            this.navPaneDocumentos.Controls.Add(this.txtSituacaoMilitar);
            this.navPaneDocumentos.Controls.Add(this.labelControl32);
            this.navPaneDocumentos.Controls.Add(this.txtOrgaoEmissaoCert);
            this.navPaneDocumentos.Controls.Add(this.labelControl31);
            this.navPaneDocumentos.Controls.Add(this.dtEmissaoCert);
            this.navPaneDocumentos.Controls.Add(this.labelControl30);
            this.navPaneDocumentos.Controls.Add(this.txtRegiaoMilitar);
            this.navPaneDocumentos.Controls.Add(this.labelControl26);
            this.navPaneDocumentos.Controls.Add(this.txtCircunscricaoMilitar);
            this.navPaneDocumentos.Controls.Add(this.labelControl27);
            this.navPaneDocumentos.Controls.Add(this.txtCatMilitar);
            this.navPaneDocumentos.Controls.Add(this.labelControl28);
            this.navPaneDocumentos.Controls.Add(this.txtNumCertReservista);
            this.navPaneDocumentos.Controls.Add(this.labelControl29);
            this.navPaneDocumentos.Controls.Add(this.dtTituloEleitor);
            this.navPaneDocumentos.Controls.Add(this.labelControl25);
            this.navPaneDocumentos.Controls.Add(this.txtUfTituloEleitoral);
            this.navPaneDocumentos.Controls.Add(this.labelControl24);
            this.navPaneDocumentos.Controls.Add(this.txtSecaoEleitoral);
            this.navPaneDocumentos.Controls.Add(this.labelControl23);
            this.navPaneDocumentos.Controls.Add(this.txtZonaEleitoral);
            this.navPaneDocumentos.Controls.Add(this.labelControl21);
            this.navPaneDocumentos.Controls.Add(this.txtTituloEleitor);
            this.navPaneDocumentos.Controls.Add(this.labelControl22);
            this.navPaneDocumentos.Controls.Add(this.dtPrimeiraHab);
            this.navPaneDocumentos.Controls.Add(this.labelControl20);
            this.navPaneDocumentos.Controls.Add(this.dtValidadeCNH);
            this.navPaneDocumentos.Controls.Add(this.labelControl19);
            this.navPaneDocumentos.Controls.Add(this.txtCatCNH);
            this.navPaneDocumentos.Controls.Add(this.labelControl18);
            this.navPaneDocumentos.Controls.Add(this.txtNumCNH);
            this.navPaneDocumentos.Controls.Add(this.labelControl16);
            this.navPaneDocumentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPaneDocumentos.Name = "navPaneDocumentos";
            this.navPaneDocumentos.Size = new System.Drawing.Size(839, 487);
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(3, 235);
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(840, 23);
            this.separatorControl2.TabIndex = 103;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(3, 79);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(840, 23);
            this.separatorControl1.TabIndex = 102;
            // 
            // txtSituacaoMilitar
            // 
            this.txtSituacaoMilitar.EditValue = "";
            this.txtSituacaoMilitar.Location = new System.Drawing.Point(28, 423);
            this.txtSituacaoMilitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSituacaoMilitar.Name = "txtSituacaoMilitar";
            this.txtSituacaoMilitar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSituacaoMilitar.Properties.Appearance.Options.UseFont = true;
            this.txtSituacaoMilitar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSituacaoMilitar.Size = new System.Drawing.Size(211, 24);
            this.txtSituacaoMilitar.TabIndex = 85;
            // 
            // labelControl32
            // 
            this.labelControl32.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl32.Location = new System.Drawing.Point(28, 399);
            this.labelControl32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(95, 18);
            this.labelControl32.TabIndex = 100;
            this.labelControl32.Text = "Situação Militar";
            // 
            // txtOrgaoEmissaoCert
            // 
            this.txtOrgaoEmissaoCert.EditValue = "";
            this.txtOrgaoEmissaoCert.Location = new System.Drawing.Point(292, 358);
            this.txtOrgaoEmissaoCert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrgaoEmissaoCert.Name = "txtOrgaoEmissaoCert";
            this.txtOrgaoEmissaoCert.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtOrgaoEmissaoCert.Properties.Appearance.Options.UseFont = true;
            this.txtOrgaoEmissaoCert.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrgaoEmissaoCert.Size = new System.Drawing.Size(211, 24);
            this.txtOrgaoEmissaoCert.TabIndex = 83;
            // 
            // labelControl31
            // 
            this.labelControl31.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl31.Location = new System.Drawing.Point(292, 334);
            this.labelControl31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(167, 18);
            this.labelControl31.TabIndex = 98;
            this.labelControl31.Text = "Orgão Emissor Certificado";
            // 
            // dtEmissaoCert
            // 
            this.dtEmissaoCert.EditValue = null;
            this.dtEmissaoCert.Location = new System.Drawing.Point(540, 358);
            this.dtEmissaoCert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEmissaoCert.Name = "dtEmissaoCert";
            this.dtEmissaoCert.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtEmissaoCert.Properties.Appearance.Options.UseFont = true;
            this.dtEmissaoCert.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmissaoCert.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEmissaoCert.Size = new System.Drawing.Size(120, 24);
            this.dtEmissaoCert.TabIndex = 84;
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl30.Location = new System.Drawing.Point(540, 334);
            this.labelControl30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(126, 18);
            this.labelControl30.TabIndex = 96;
            this.labelControl30.Text = "Data Emissão Cert.";
            // 
            // txtRegiaoMilitar
            // 
            this.txtRegiaoMilitar.EditValue = "";
            this.txtRegiaoMilitar.Location = new System.Drawing.Point(26, 358);
            this.txtRegiaoMilitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRegiaoMilitar.Name = "txtRegiaoMilitar";
            this.txtRegiaoMilitar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtRegiaoMilitar.Properties.Appearance.Options.UseFont = true;
            this.txtRegiaoMilitar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegiaoMilitar.Size = new System.Drawing.Size(211, 24);
            this.txtRegiaoMilitar.TabIndex = 82;
            // 
            // labelControl26
            // 
            this.labelControl26.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl26.Location = new System.Drawing.Point(28, 334);
            this.labelControl26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(84, 18);
            this.labelControl26.TabIndex = 94;
            this.labelControl26.Text = "Região Militar";
            // 
            // txtCircunscricaoMilitar
            // 
            this.txtCircunscricaoMilitar.EditValue = "";
            this.txtCircunscricaoMilitar.Location = new System.Drawing.Point(540, 295);
            this.txtCircunscricaoMilitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCircunscricaoMilitar.Name = "txtCircunscricaoMilitar";
            this.txtCircunscricaoMilitar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCircunscricaoMilitar.Properties.Appearance.Options.UseFont = true;
            this.txtCircunscricaoMilitar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCircunscricaoMilitar.Size = new System.Drawing.Size(206, 24);
            this.txtCircunscricaoMilitar.TabIndex = 81;
            // 
            // labelControl27
            // 
            this.labelControl27.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl27.Location = new System.Drawing.Point(540, 271);
            this.labelControl27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(124, 18);
            this.labelControl27.TabIndex = 92;
            this.labelControl27.Text = "Circunscrição Militar";
            // 
            // txtCatMilitar
            // 
            this.txtCatMilitar.EditValue = "";
            this.txtCatMilitar.Location = new System.Drawing.Point(289, 295);
            this.txtCatMilitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCatMilitar.Name = "txtCatMilitar";
            this.txtCatMilitar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCatMilitar.Properties.Appearance.Options.UseFont = true;
            this.txtCatMilitar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCatMilitar.Size = new System.Drawing.Size(211, 24);
            this.txtCatMilitar.TabIndex = 80;
            // 
            // labelControl28
            // 
            this.labelControl28.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl28.Location = new System.Drawing.Point(289, 271);
            this.labelControl28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(102, 18);
            this.labelControl28.TabIndex = 90;
            this.labelControl28.Text = "Categoria Militar";
            // 
            // txtNumCertReservista
            // 
            this.txtNumCertReservista.EditValue = "";
            this.txtNumCertReservista.Location = new System.Drawing.Point(26, 295);
            this.txtNumCertReservista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCertReservista.Name = "txtNumCertReservista";
            this.txtNumCertReservista.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumCertReservista.Properties.Appearance.Options.UseFont = true;
            this.txtNumCertReservista.Size = new System.Drawing.Size(211, 24);
            this.txtNumCertReservista.TabIndex = 79;
            // 
            // labelControl29
            // 
            this.labelControl29.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl29.Location = new System.Drawing.Point(26, 271);
            this.labelControl29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(196, 18);
            this.labelControl29.TabIndex = 88;
            this.labelControl29.Text = "Número Certificado Reservista";
            // 
            // dtTituloEleitor
            // 
            this.dtTituloEleitor.EditValue = null;
            this.dtTituloEleitor.Location = new System.Drawing.Point(289, 202);
            this.dtTituloEleitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTituloEleitor.Name = "dtTituloEleitor";
            this.dtTituloEleitor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtTituloEleitor.Properties.Appearance.Options.UseFont = true;
            this.dtTituloEleitor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTituloEleitor.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTituloEleitor.Size = new System.Drawing.Size(120, 24);
            this.dtTituloEleitor.TabIndex = 78;
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl25.Location = new System.Drawing.Point(289, 178);
            this.labelControl25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(114, 18);
            this.labelControl25.TabIndex = 86;
            this.labelControl25.Text = "Data Título Eleitor";
            // 
            // txtUfTituloEleitoral
            // 
            this.txtUfTituloEleitoral.EditValue = "";
            this.txtUfTituloEleitoral.Location = new System.Drawing.Point(26, 202);
            this.txtUfTituloEleitoral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUfTituloEleitoral.Name = "txtUfTituloEleitoral";
            this.txtUfTituloEleitoral.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUfTituloEleitoral.Properties.Appearance.Options.UseFont = true;
            this.txtUfTituloEleitoral.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUfTituloEleitoral.Size = new System.Drawing.Size(211, 24);
            this.txtUfTituloEleitoral.TabIndex = 77;
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl24.Location = new System.Drawing.Point(26, 178);
            this.labelControl24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(101, 18);
            this.labelControl24.TabIndex = 84;
            this.labelControl24.Text = "UF Título Eleitor";
            // 
            // txtSecaoEleitoral
            // 
            this.txtSecaoEleitoral.EditValue = "";
            this.txtSecaoEleitoral.Location = new System.Drawing.Point(540, 138);
            this.txtSecaoEleitoral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSecaoEleitoral.Name = "txtSecaoEleitoral";
            this.txtSecaoEleitoral.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSecaoEleitoral.Properties.Appearance.Options.UseFont = true;
            this.txtSecaoEleitoral.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSecaoEleitoral.Size = new System.Drawing.Size(211, 24);
            this.txtSecaoEleitoral.TabIndex = 76;
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl23.Location = new System.Drawing.Point(540, 114);
            this.labelControl23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(92, 18);
            this.labelControl23.TabIndex = 82;
            this.labelControl23.Text = "Seção Eleitoral";
            // 
            // txtZonaEleitoral
            // 
            this.txtZonaEleitoral.EditValue = "";
            this.txtZonaEleitoral.Location = new System.Drawing.Point(289, 138);
            this.txtZonaEleitoral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZonaEleitoral.Name = "txtZonaEleitoral";
            this.txtZonaEleitoral.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtZonaEleitoral.Properties.Appearance.Options.UseFont = true;
            this.txtZonaEleitoral.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtZonaEleitoral.Size = new System.Drawing.Size(211, 24);
            this.txtZonaEleitoral.TabIndex = 75;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl21.Location = new System.Drawing.Point(289, 114);
            this.labelControl21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(85, 18);
            this.labelControl21.TabIndex = 80;
            this.labelControl21.Text = "Zona Eleitoral";
            // 
            // txtTituloEleitor
            // 
            this.txtTituloEleitor.EditValue = "";
            this.txtTituloEleitor.Location = new System.Drawing.Point(26, 138);
            this.txtTituloEleitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTituloEleitor.Name = "txtTituloEleitor";
            this.txtTituloEleitor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTituloEleitor.Properties.Appearance.Options.UseFont = true;
            this.txtTituloEleitor.Size = new System.Drawing.Size(211, 24);
            this.txtTituloEleitor.TabIndex = 74;
            // 
            // labelControl22
            // 
            this.labelControl22.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl22.Location = new System.Drawing.Point(26, 114);
            this.labelControl22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(78, 18);
            this.labelControl22.TabIndex = 78;
            this.labelControl22.Text = "Título Eleitor";
            // 
            // dtPrimeiraHab
            // 
            this.dtPrimeiraHab.EditValue = null;
            this.dtPrimeiraHab.Location = new System.Drawing.Point(695, 47);
            this.dtPrimeiraHab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPrimeiraHab.Name = "dtPrimeiraHab";
            this.dtPrimeiraHab.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtPrimeiraHab.Properties.Appearance.Options.UseFont = true;
            this.dtPrimeiraHab.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPrimeiraHab.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPrimeiraHab.Size = new System.Drawing.Size(120, 24);
            this.dtPrimeiraHab.TabIndex = 73;
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl20.Location = new System.Drawing.Point(695, 23);
            this.labelControl20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(123, 18);
            this.labelControl20.TabIndex = 76;
            this.labelControl20.Text = "Data Primeira Hab.";
            // 
            // dtValidadeCNH
            // 
            this.dtValidadeCNH.EditValue = null;
            this.dtValidadeCNH.Location = new System.Drawing.Point(540, 47);
            this.dtValidadeCNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtValidadeCNH.Name = "dtValidadeCNH";
            this.dtValidadeCNH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtValidadeCNH.Properties.Appearance.Options.UseFont = true;
            this.dtValidadeCNH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtValidadeCNH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtValidadeCNH.Size = new System.Drawing.Size(120, 24);
            this.dtValidadeCNH.TabIndex = 72;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl19.Location = new System.Drawing.Point(540, 23);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(53, 18);
            this.labelControl19.TabIndex = 74;
            this.labelControl19.Text = "Validade";
            // 
            // txtCatCNH
            // 
            this.txtCatCNH.EditValue = "";
            this.txtCatCNH.Location = new System.Drawing.Point(289, 49);
            this.txtCatCNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCatCNH.Name = "txtCatCNH";
            this.txtCatCNH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCatCNH.Properties.Appearance.Options.UseFont = true;
            this.txtCatCNH.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCatCNH.Properties.MaxLength = 3;
            this.txtCatCNH.Size = new System.Drawing.Size(211, 24);
            this.txtCatCNH.TabIndex = 71;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl18.Location = new System.Drawing.Point(289, 25);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(95, 18);
            this.labelControl18.TabIndex = 71;
            this.labelControl18.Text = "Categoria CNH";
            // 
            // txtNumCNH
            // 
            this.txtNumCNH.EditValue = "";
            this.txtNumCNH.Location = new System.Drawing.Point(26, 47);
            this.txtNumCNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumCNH.Name = "txtNumCNH";
            this.txtNumCNH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumCNH.Properties.Appearance.Options.UseFont = true;
            this.txtNumCNH.Size = new System.Drawing.Size(211, 24);
            this.txtNumCNH.TabIndex = 70;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl16.Location = new System.Drawing.Point(26, 23);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(86, 18);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "Número CNH";
            // 
            // navPageFechFolha
            // 
            this.navPageFechFolha.Caption = "Fechamento da Folha";
            this.navPageFechFolha.Controls.Add(this.grpEventos);
            this.navPageFechFolha.Controls.Add(this.cbGrpEventoFunc);
            this.navPageFechFolha.Controls.Add(this.labelControl4);
            this.navPageFechFolha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navPageFechFolha.Name = "navPageFechFolha";
            this.navPageFechFolha.Size = new System.Drawing.Size(839, 487);
            // 
            // grpEventos
            // 
            this.grpEventos.Controls.Add(this.gridControlEvtFunc);
            this.grpEventos.Controls.Add(this.standaloneBarDockControl1);
            this.grpEventos.Location = new System.Drawing.Point(19, 108);
            this.grpEventos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpEventos.Name = "grpEventos";
            this.grpEventos.Size = new System.Drawing.Size(814, 306);
            this.grpEventos.TabIndex = 2;
            this.grpEventos.Text = "Eventos da Folha:";
            // 
            // gridControlEvtFunc
            // 
            this.gridControlEvtFunc.DataSource = this.eventoFuncionarioBindingSource;
            this.gridControlEvtFunc.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlEvtFunc.Location = new System.Drawing.Point(6, 66);
            this.gridControlEvtFunc.MainView = this.gridViewEvtFunc;
            this.gridControlEvtFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlEvtFunc.MenuManager = this.ribbon;
            this.gridControlEvtFunc.Name = "gridControlEvtFunc";
            this.gridControlEvtFunc.Size = new System.Drawing.Size(803, 234);
            this.gridControlEvtFunc.TabIndex = 1;
            this.gridControlEvtFunc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEvtFunc});
            // 
            // eventoFuncionarioBindingSource
            // 
            this.eventoFuncionarioBindingSource.DataSource = typeof(ITE.Entidades.POCO.RH.EventoFuncionario);
            // 
            // gridViewEvtFunc
            // 
            this.gridViewEvtFunc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEvento,
            this.colDscEvento,
            this.colTpEvento,
            this.colCodCalculo,
            this.ColVlrEvento});
            this.gridViewEvtFunc.GridControl = this.gridControlEvtFunc;
            this.gridViewEvtFunc.Name = "gridViewEvtFunc";
            this.gridViewEvtFunc.OptionsView.ShowGroupPanel = false;
            this.gridViewEvtFunc.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEvento, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colEvento
            // 
            this.colEvento.Caption = "Cód. Evento";
            this.colEvento.FieldName = "Evento.CodigoEvento";
            this.colEvento.Name = "colEvento";
            this.colEvento.OptionsColumn.AllowEdit = false;
            this.colEvento.Visible = true;
            this.colEvento.VisibleIndex = 0;
            this.colEvento.Width = 94;
            // 
            // colDscEvento
            // 
            this.colDscEvento.FieldName = "Evento.DescricaoEvento";
            this.colDscEvento.Name = "colDscEvento";
            this.colDscEvento.OptionsColumn.AllowEdit = false;
            this.colDscEvento.Visible = true;
            this.colDscEvento.VisibleIndex = 1;
            this.colDscEvento.Width = 222;
            // 
            // colTpEvento
            // 
            this.colTpEvento.Caption = "Tipo";
            this.colTpEvento.FieldName = "Evento.TipoEvento";
            this.colTpEvento.Name = "colTpEvento";
            this.colTpEvento.OptionsColumn.AllowEdit = false;
            this.colTpEvento.Visible = true;
            this.colTpEvento.VisibleIndex = 2;
            this.colTpEvento.Width = 123;
            // 
            // colCodCalculo
            // 
            this.colCodCalculo.Caption = "Cód. Cálculo";
            this.colCodCalculo.FieldName = "Evento.CodigoCalculo";
            this.colCodCalculo.Name = "colCodCalculo";
            this.colCodCalculo.OptionsColumn.AllowEdit = false;
            this.colCodCalculo.Visible = true;
            this.colCodCalculo.VisibleIndex = 3;
            this.colCodCalculo.Width = 135;
            // 
            // ColVlrEvento
            // 
            this.ColVlrEvento.Caption = "Valor";
            this.ColVlrEvento.DisplayFormat.FormatString = "N2";
            this.ColVlrEvento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColVlrEvento.FieldName = "Valor";
            this.ColVlrEvento.Name = "ColVlrEvento";
            this.ColVlrEvento.Visible = true;
            this.ColVlrEvento.VisibleIndex = 4;
            this.ColVlrEvento.Width = 122;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(6, 28);
            this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(803, 42);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // cbGrpEventoFunc
            // 
            this.cbGrpEventoFunc.Location = new System.Drawing.Point(19, 52);
            this.cbGrpEventoFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGrpEventoFunc.MenuManager = this.ribbon;
            this.cbGrpEventoFunc.Name = "cbGrpEventoFunc";
            this.cbGrpEventoFunc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrpEventoFunc.Size = new System.Drawing.Size(428, 22);
            this.cbGrpEventoFunc.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 28);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(267, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Grupo padrões de evento da folha pagamento:";
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
            this.barManager1.Form = this.standaloneBarDockControl1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddEvento,
            this.btnRemoveEvento});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddEvento),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveEvento)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // btnAddEvento
            // 
            this.btnAddEvento.Caption = "Adicionar";
            this.btnAddEvento.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAddEvento.Glyph")));
            this.btnAddEvento.Id = 0;
            this.btnAddEvento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAddEvento.LargeGlyph")));
            this.btnAddEvento.Name = "btnAddEvento";
            this.btnAddEvento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddEvento_ItemClick);
            // 
            // btnRemoveEvento
            // 
            this.btnRemoveEvento.Caption = "Remover";
            this.btnRemoveEvento.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRemoveEvento.Glyph")));
            this.btnRemoveEvento.Id = 1;
            this.btnRemoveEvento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRemoveEvento.LargeGlyph")));
            this.btnRemoveEvento.Name = "btnRemoveEvento";
            this.btnRemoveEvento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveEvento_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(803, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 42);
            this.barDockControlBottom.Size = new System.Drawing.Size(803, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 42);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(803, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 42);
            // 
            // XFrmAddFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 767);
            this.Controls.Add(this.navPanelPai);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmAddFuncionario";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Admissão Funcionário:";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmAddFuncionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.navPanelPai.ResumeLayout(false);
            this.navPaneInfoPessoais.ResumeLayout(false);
            this.navPaneInfoPessoais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoFunc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeMae.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataExpRG.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataExpRG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomePai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgaoEmissorRG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditFoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCpf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstadoCivil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNasc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataNasc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelFixo.Properties)).EndInit();
            this.navPaneDadosAdmissionais.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoRecebimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataAdmissao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataAdmissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlDepto)).EndInit();
            this.panelCtrlDepto.ResumeLayout(false);
            this.panelCtrlDepto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlSituacao)).EndInit();
            this.panelCtrlSituacao.ResumeLayout(false);
            this.panelCtrlSituacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlFuncao)).EndInit();
            this.panelCtrlFuncao.ResumeLayout(false);
            this.panelCtrlFuncao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbFuncao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCtrlSalario)).EndInit();
            this.panelCtrlSalario.ResumeLayout(false);
            this.panelCtrlSalario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalario.Properties)).EndInit();
            this.navPaneHistoricoPai.ResumeLayout(false);
            this.navPaneHistoricos.ResumeLayout(false);
            this.navPaneHistSalarial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSalarial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.navPaneHistFuncao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuncao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.navPaneHistDepartamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.navPaneHistSituacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.navPaneEndereco.ResumeLayout(false);
            this.navPaneEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoLogradouros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSemNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
            this.navPaneCTPS.ResumeLayout(false);
            this.navPaneCTPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbEstadoEmissaoCTPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmissaoCTPS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmissaoCTPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieCTPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCTPS.Properties)).EndInit();
            this.navPaneDocumentos.ResumeLayout(false);
            this.navPaneDocumentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSituacaoMilitar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrgaoEmissaoCert.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmissaoCert.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmissaoCert.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegiaoMilitar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCircunscricaoMilitar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatMilitar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCertReservista.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTituloEleitor.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTituloEleitor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUfTituloEleitoral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecaoEleitoral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZonaEleitoral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTituloEleitor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrimeiraHab.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrimeiraHab.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtValidadeCNH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtValidadeCNH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCatCNH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCNH.Properties)).EndInit();
            this.navPageFechFolha.ResumeLayout(false);
            this.navPageFechFolha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpEventos)).EndInit();
            this.grpEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEvtFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEvtFunc)).EndInit();
            this.standaloneBarDockControl1.ResumeLayout(false);
            this.standaloneBarDockControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrpEventoFunc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnSalvar;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelar;
        private DevExpress.XtraBars.Navigation.NavigationPane navPanelPai;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneInfoPessoais;
        private DevExpress.XtraEditors.PictureEdit pictureEditFoto;
        private DevExpress.XtraEditors.TextEdit txtCpf;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.ComboBoxEdit cbEstadoCivil;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.DateEdit dtDataNasc;
        private DevExpress.XtraEditors.LabelControl lbCpfCnpj;
        private DevExpress.XtraEditors.LabelControl lbNome;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbRg;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtRg;
        private DevExpress.XtraEditors.TextEdit txtTelFixo;
        private DevExpress.XtraBars.Navigation.NavigationPane navPaneHistoricos;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneHistSalarial;
        private DevExpress.XtraGrid.GridControl gridControlSalarial;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFuncionario1;
        private DevExpress.XtraGrid.Columns.GridColumn colDataRef;
        private DevExpress.XtraGrid.Columns.GridColumn colSalario;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoSalario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHistoricoSalario;
        private DevExpress.XtraGrid.Columns.GridColumn coltbFuncionario1;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneHistFuncao;
        private DevExpress.XtraGrid.GridControl gridControlFuncao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHistoricoFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFuncionario2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn coltbFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colFuncionarioFuncao;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneHistDepartamento;
        private DevExpress.XtraGrid.GridControl gridControlDepto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHistoricoDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFuncionario3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colData1;
        private DevExpress.XtraGrid.Columns.GridColumn coltbFuncionario3;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricoDepartamento;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneHistSituacao;
        private DevExpress.XtraGrid.GridControl gridControlSituacao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAdmissao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataDemissao;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataHistorico;
        private DevExpress.XtraGrid.Columns.GridColumn colHistorico;
        private DevExpress.XtraGrid.Columns.GridColumn coltbFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdHistoricoSituacao;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneEndereco;
        private DevExpress.XtraEditors.TextEdit txtNumeroEnd;
        private DevExpress.XtraEditors.CheckEdit checkSemNumero;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.TextEdit txtComplemento;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.TextEdit txtBairro;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtUf;
        private DevExpress.XtraEditors.TextEdit txtCidade;
        private DevExpress.XtraEditors.TextEdit txtEndereco;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneCTPS;
        private DevExpress.XtraEditors.ComboBoxEdit cbEstadoEmissaoCTPS;
        private DevExpress.XtraEditors.DateEdit dtEmissaoCTPS;
        private DevExpress.XtraEditors.TextEdit txtNumPis;
        private DevExpress.XtraEditors.TextEdit txtSerieCTPS;
        private DevExpress.XtraEditors.TextEdit txtNumCTPS;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneDocumentos;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TextEdit txtSituacaoMilitar;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.TextEdit txtOrgaoEmissaoCert;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.DateEdit dtEmissaoCert;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.TextEdit txtRegiaoMilitar;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.TextEdit txtCircunscricaoMilitar;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.TextEdit txtCatMilitar;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.TextEdit txtNumCertReservista;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.DateEdit dtTituloEleitor;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.TextEdit txtUfTituloEleitoral;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.TextEdit txtSecaoEleitoral;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.TextEdit txtZonaEleitoral;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.TextEdit txtTituloEleitor;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.DateEdit dtPrimeiraHab;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.DateEdit dtValidadeCNH;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtCatCNH;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtNumCNH;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneDadosAdmissionais;
        private DevExpress.XtraEditors.LabelControl labelControl36;
        private DevExpress.XtraEditors.LabelControl labelControl39;
        private DevExpress.XtraEditors.LabelControl labelControl38;
        private DevExpress.XtraEditors.LabelControl labelControl37;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelCtrlSalario;
        private DevExpress.XtraEditors.PanelControl panelCtrlSituacao;
        private DevExpress.XtraEditors.PanelControl panelCtrlDepto;
        private DevExpress.XtraEditors.PanelControl panelCtrlFuncao;
        private DevExpress.XtraBars.Navigation.NavigationPage navPaneHistoricoPai;
        private DevExpress.XtraEditors.TextEdit txtSalario;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoDepto;
        private DevExpress.XtraEditors.SimpleButton btnSelecionarFoto;
        private DevExpress.XtraEditors.LabelControl lblFoto;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeMae;
        private DevExpress.XtraEditors.LabelControl labelControl41;
        private DevExpress.XtraEditors.LabelControl labelControl43;
        private DevExpress.XtraEditors.DateEdit dtDataExpRG;
        private DevExpress.XtraEditors.LabelControl labelControl40;
        private DevExpress.XtraEditors.TextEdit txtNomePai;
        private DevExpress.XtraEditors.TextEdit txtOrgaoEmissorRG;
        private DevExpress.XtraEditors.LabelControl labelControl42;
        private DevExpress.XtraEditors.TextEdit txtCelular;
        private DevExpress.XtraEditors.LabelControl labelControl44;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoLogradouros;
        private DevExpress.XtraEditors.TextEdit txtCodigoFunc;
        private DevExpress.XtraEditors.LabelControl labelControl45;
        private DevExpress.XtraEditors.LabelControl labelControl46;
        private DevExpress.XtraEditors.TextEdit txtIdade;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.DateEdit dtDataAdmissao;
        private Components.LookUpMatrizFilial lookUpMatrizFilial1;
        private Components.LookUpMunicipio lookUpMunicipio1;
        private CepControl cepControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbDepartamento;
        private DevExpress.XtraEditors.ComboBoxEdit cbSituacao;
        private DevExpress.XtraEditors.ComboBoxEdit cbFuncao;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoRecebimento;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageFechFolha;
        private DevExpress.XtraEditors.GroupControl grpEventos;
        private DevExpress.XtraEditors.ComboBoxEdit cbGrpEventoFunc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAddEvento;
        private DevExpress.XtraBars.BarButtonItem btnRemoveEvento;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlEvtFunc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEvtFunc;
        private System.Windows.Forms.BindingSource eventoFuncionarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colDscEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colTpEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCalculo;
        private DevExpress.XtraGrid.Columns.GridColumn ColVlrEvento;
    }
}