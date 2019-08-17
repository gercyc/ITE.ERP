namespace ITE.RH.Forms.ListView
{
    partial class XFrmFuncionarioListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmFuncionarioListView));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlterarSalario = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlterarSituacao = new DevExpress.XtraBars.BarButtonItem();
            this.batBtnAlterarDepto = new DevExpress.XtraBars.BarButtonItem();
            this.batBtnAlterarFuncao = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControlFuncionario = new DevExpress.XtraGrid.GridControl();
            this.bsFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewFuncionario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFuncionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeFuncionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataNascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAdmissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoCivil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefoneFixo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoRecebimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegistroGeral = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCTPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTituloEleitor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCertificadoReservista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFichaFinaceiraFuncionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistoricoSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistoricoDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistoricoFuncao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistoricoSalarial = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnNovo,
            this.barBtnEditar,
            this.barBtnAtualizar,
            this.barBtnAlterarSalario,
            this.barBtnAlterarSituacao,
            this.batBtnAlterarDepto,
            this.batBtnAlterarFuncao});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(965, 183);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.Caption = "Novo";
            this.barBtnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Glyph")));
            this.barBtnNovo.Id = 1;
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovo_ItemClick);
            // 
            // barBtnEditar
            // 
            this.barBtnEditar.Caption = "Editar/Visualizar";
            this.barBtnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditar.Glyph")));
            this.barBtnEditar.Id = 2;
            this.barBtnEditar.Name = "barBtnEditar";
            this.barBtnEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEditar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditar_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 4;
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // barBtnAlterarSalario
            // 
            this.barBtnAlterarSalario.Caption = "Alteração Salárial";
            this.barBtnAlterarSalario.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterarSalario.Glyph")));
            this.barBtnAlterarSalario.Id = 5;
            this.barBtnAlterarSalario.Name = "barBtnAlterarSalario";
            this.barBtnAlterarSalario.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barBtnAlterarSalario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterarSalario_ItemClick);
            // 
            // barBtnAlterarSituacao
            // 
            this.barBtnAlterarSituacao.Caption = "Alteração Situação";
            this.barBtnAlterarSituacao.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterarSituacao.Glyph")));
            this.barBtnAlterarSituacao.Id = 6;
            this.barBtnAlterarSituacao.Name = "barBtnAlterarSituacao";
            this.barBtnAlterarSituacao.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAlterarSituacao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAlterarSituacao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterarSituacao_ItemClick);
            // 
            // batBtnAlterarDepto
            // 
            this.batBtnAlterarDepto.Caption = "Alteração Departamento";
            this.batBtnAlterarDepto.Glyph = ((System.Drawing.Image)(resources.GetObject("batBtnAlterarDepto.Glyph")));
            this.batBtnAlterarDepto.Id = 7;
            this.batBtnAlterarDepto.Name = "batBtnAlterarDepto";
            this.batBtnAlterarDepto.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.batBtnAlterarDepto.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.batBtnAlterarDepto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.batBtnAlterarDepto_ItemClick);
            // 
            // batBtnAlterarFuncao
            // 
            this.batBtnAlterarFuncao.Caption = "Alteração de Função";
            this.batBtnAlterarFuncao.Glyph = ((System.Drawing.Image)(resources.GetObject("batBtnAlterarFuncao.Glyph")));
            this.batBtnAlterarFuncao.Id = 8;
            this.batBtnAlterarFuncao.Name = "batBtnAlterarFuncao";
            this.batBtnAlterarFuncao.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.batBtnAlterarFuncao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.batBtnAlterarFuncao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.batBtnAlterarFuncao_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Início";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAtualizar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Controle de Informações";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnAlterarSalario);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnAlterarSituacao);
            this.ribbonPageGroup2.ItemLinks.Add(this.batBtnAlterarDepto);
            this.ribbonPageGroup2.ItemLinks.Add(this.batBtnAlterarFuncao);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Controle Administrativo";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 578);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(965, 41);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControlFuncionario, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 183);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 395);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gridControlFuncionario
            // 
            this.gridControlFuncionario.DataSource = this.bsFuncionario;
            this.gridControlFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFuncionario.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlFuncionario.Location = new System.Drawing.Point(3, 2);
            this.gridControlFuncionario.MainView = this.gridViewFuncionario;
            this.gridControlFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlFuncionario.MenuManager = this.ribbon;
            this.gridControlFuncionario.Name = "gridControlFuncionario";
            this.gridControlFuncionario.Size = new System.Drawing.Size(959, 391);
            this.gridControlFuncionario.TabIndex = 0;
            this.gridControlFuncionario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFuncionario});
            // 
            // bsFuncionario
            // 
            this.bsFuncionario.DataSource = typeof(ITE.Entidades.POCO.RH.Funcionario);
            // 
            // gridViewFuncionario
            // 
            this.gridViewFuncionario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFuncionario,
            this.colNomeFuncionario,
            this.colSituacao,
            this.colCPF,
            this.colDataNascimento,
            this.colDataAdmissao,
            this.colSalario,
            this.colEstadoCivil,
            this.colIdDepartamento,
            this.colIdFuncao,
            this.colTelefoneFixo,
            this.colCelular,
            this.colEmail,
            this.colTipoRecebimento,
            this.colFoto,
            this.colDepartamento,
            this.colFuncao,
            this.colRegistroGeral,
            this.colEndereco,
            this.colCTPS,
            this.colCNH,
            this.colTituloEleitor,
            this.colCertificadoReservista,
            this.colFichaFinaceiraFuncionario,
            this.colHistoricoSituacao,
            this.colHistoricoDepartamento,
            this.colHistoricoFuncao,
            this.colHistoricoSalarial});
            this.gridViewFuncionario.GridControl = this.gridControlFuncionario;
            this.gridViewFuncionario.Name = "gridViewFuncionario";
            this.gridViewFuncionario.OptionsBehavior.Editable = false;
            this.gridViewFuncionario.OptionsBehavior.ReadOnly = true;
            this.gridViewFuncionario.OptionsView.ColumnAutoWidth = false;
            this.gridViewFuncionario.DoubleClick += new System.EventHandler(this.gridViewFuncionario_DoubleClick);
            // 
            // colIdFuncionario
            // 
            this.colIdFuncionario.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFuncionario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFuncionario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncionario.FieldName = "ID";
            this.colIdFuncionario.Name = "colIdFuncionario";
            // 
            // colNomeFuncionario
            // 
            this.colNomeFuncionario.AppearanceCell.Options.UseTextOptions = true;
            this.colNomeFuncionario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeFuncionario.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeFuncionario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeFuncionario.Caption = "Nome Funcionário";
            this.colNomeFuncionario.FieldName = "NomeFuncionario";
            this.colNomeFuncionario.Name = "colNomeFuncionario";
            this.colNomeFuncionario.Visible = true;
            this.colNomeFuncionario.VisibleIndex = 0;
            this.colNomeFuncionario.Width = 274;
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
            this.colSituacao.VisibleIndex = 2;
            this.colSituacao.Width = 93;
            // 
            // colCPF
            // 
            this.colCPF.AppearanceCell.Options.UseTextOptions = true;
            this.colCPF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCPF.AppearanceHeader.Options.UseTextOptions = true;
            this.colCPF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCPF.FieldName = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.Visible = true;
            this.colCPF.VisibleIndex = 5;
            this.colCPF.Width = 125;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataNascimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataNascimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataNascimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataNascimento.FieldName = "DataNascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.Visible = true;
            this.colDataNascimento.VisibleIndex = 6;
            this.colDataNascimento.Width = 118;
            // 
            // colDataAdmissao
            // 
            this.colDataAdmissao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataAdmissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataAdmissao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataAdmissao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataAdmissao.Caption = "Admissão";
            this.colDataAdmissao.FieldName = "DataAdmissao";
            this.colDataAdmissao.Name = "colDataAdmissao";
            this.colDataAdmissao.Visible = true;
            this.colDataAdmissao.VisibleIndex = 7;
            this.colDataAdmissao.Width = 100;
            // 
            // colSalario
            // 
            this.colSalario.AppearanceCell.Options.UseTextOptions = true;
            this.colSalario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSalario.AppearanceHeader.Options.UseTextOptions = true;
            this.colSalario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSalario.FieldName = "Salario";
            this.colSalario.Name = "colSalario";
            // 
            // colEstadoCivil
            // 
            this.colEstadoCivil.AppearanceCell.Options.UseTextOptions = true;
            this.colEstadoCivil.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEstadoCivil.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstadoCivil.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEstadoCivil.FieldName = "EstadoCivil";
            this.colEstadoCivil.Name = "colEstadoCivil";
            this.colEstadoCivil.Visible = true;
            this.colEstadoCivil.VisibleIndex = 8;
            this.colEstadoCivil.Width = 90;
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
            // colIdFuncao
            // 
            this.colIdFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFuncao.FieldName = "IdFuncao";
            this.colIdFuncao.Name = "colIdFuncao";
            // 
            // colTelefoneFixo
            // 
            this.colTelefoneFixo.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefoneFixo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTelefoneFixo.AppearanceHeader.Options.UseTextOptions = true;
            this.colTelefoneFixo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTelefoneFixo.FieldName = "TelefoneFixo";
            this.colTelefoneFixo.Name = "colTelefoneFixo";
            // 
            // colCelular
            // 
            this.colCelular.AppearanceCell.Options.UseTextOptions = true;
            this.colCelular.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCelular.AppearanceHeader.Options.UseTextOptions = true;
            this.colCelular.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCelular.FieldName = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.Visible = true;
            this.colCelular.VisibleIndex = 10;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Options.UseTextOptions = true;
            this.colEmail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            this.colEmail.Width = 241;
            // 
            // colTipoRecebimento
            // 
            this.colTipoRecebimento.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoRecebimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoRecebimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoRecebimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoRecebimento.Caption = "Recebimento";
            this.colTipoRecebimento.FieldName = "TipoRecebimento";
            this.colTipoRecebimento.Name = "colTipoRecebimento";
            this.colTipoRecebimento.Visible = true;
            this.colTipoRecebimento.VisibleIndex = 1;
            this.colTipoRecebimento.Width = 116;
            // 
            // colFoto
            // 
            this.colFoto.AppearanceCell.Options.UseTextOptions = true;
            this.colFoto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFoto.AppearanceHeader.Options.UseTextOptions = true;
            this.colFoto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFoto.FieldName = "Foto";
            this.colFoto.Name = "colFoto";
            // 
            // colDepartamento
            // 
            this.colDepartamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDepartamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDepartamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepartamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDepartamento.FieldName = "Departamento";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.Visible = true;
            this.colDepartamento.VisibleIndex = 3;
            this.colDepartamento.Width = 189;
            // 
            // colFuncao
            // 
            this.colFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFuncao.Caption = "Função";
            this.colFuncao.FieldName = "Funcao";
            this.colFuncao.Name = "colFuncao";
            this.colFuncao.Visible = true;
            this.colFuncao.VisibleIndex = 4;
            this.colFuncao.Width = 195;
            // 
            // colRegistroGeral
            // 
            this.colRegistroGeral.AppearanceCell.Options.UseTextOptions = true;
            this.colRegistroGeral.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRegistroGeral.AppearanceHeader.Options.UseTextOptions = true;
            this.colRegistroGeral.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRegistroGeral.FieldName = "RegistroGeral";
            this.colRegistroGeral.Name = "colRegistroGeral";
            this.colRegistroGeral.Visible = true;
            this.colRegistroGeral.VisibleIndex = 11;
            this.colRegistroGeral.Width = 138;
            // 
            // colEndereco
            // 
            this.colEndereco.AppearanceCell.Options.UseTextOptions = true;
            this.colEndereco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEndereco.AppearanceHeader.Options.UseTextOptions = true;
            this.colEndereco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEndereco.FieldName = "Endereco";
            this.colEndereco.Name = "colEndereco";
            // 
            // colCTPS
            // 
            this.colCTPS.AppearanceCell.Options.UseTextOptions = true;
            this.colCTPS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCTPS.AppearanceHeader.Options.UseTextOptions = true;
            this.colCTPS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCTPS.FieldName = "CTPS";
            this.colCTPS.Name = "colCTPS";
            this.colCTPS.Visible = true;
            this.colCTPS.VisibleIndex = 12;
            this.colCTPS.Width = 120;
            // 
            // colCNH
            // 
            this.colCNH.AppearanceCell.Options.UseTextOptions = true;
            this.colCNH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCNH.AppearanceHeader.Options.UseTextOptions = true;
            this.colCNH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCNH.FieldName = "CNH";
            this.colCNH.Name = "colCNH";
            this.colCNH.Visible = true;
            this.colCNH.VisibleIndex = 13;
            this.colCNH.Width = 120;
            // 
            // colTituloEleitor
            // 
            this.colTituloEleitor.AppearanceCell.Options.UseTextOptions = true;
            this.colTituloEleitor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTituloEleitor.AppearanceHeader.Options.UseTextOptions = true;
            this.colTituloEleitor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTituloEleitor.FieldName = "TituloEleitor";
            this.colTituloEleitor.Name = "colTituloEleitor";
            this.colTituloEleitor.Visible = true;
            this.colTituloEleitor.VisibleIndex = 14;
            this.colTituloEleitor.Width = 120;
            // 
            // colCertificadoReservista
            // 
            this.colCertificadoReservista.AppearanceCell.Options.UseTextOptions = true;
            this.colCertificadoReservista.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCertificadoReservista.AppearanceHeader.Options.UseTextOptions = true;
            this.colCertificadoReservista.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCertificadoReservista.FieldName = "CertificadoReservista";
            this.colCertificadoReservista.Name = "colCertificadoReservista";
            this.colCertificadoReservista.Visible = true;
            this.colCertificadoReservista.VisibleIndex = 15;
            this.colCertificadoReservista.Width = 160;
            // 
            // colFichaFinaceiraFuncionario
            // 
            this.colFichaFinaceiraFuncionario.AppearanceCell.Options.UseTextOptions = true;
            this.colFichaFinaceiraFuncionario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFichaFinaceiraFuncionario.AppearanceHeader.Options.UseTextOptions = true;
            this.colFichaFinaceiraFuncionario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFichaFinaceiraFuncionario.FieldName = "FichaFinaceiraFuncionario";
            this.colFichaFinaceiraFuncionario.Name = "colFichaFinaceiraFuncionario";
            // 
            // colHistoricoSituacao
            // 
            this.colHistoricoSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.colHistoricoSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistoricoSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoSituacao.FieldName = "HistoricoSituacao";
            this.colHistoricoSituacao.Name = "colHistoricoSituacao";
            // 
            // colHistoricoDepartamento
            // 
            this.colHistoricoDepartamento.AppearanceCell.Options.UseTextOptions = true;
            this.colHistoricoDepartamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoDepartamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistoricoDepartamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoDepartamento.FieldName = "HistoricoDepartamento";
            this.colHistoricoDepartamento.Name = "colHistoricoDepartamento";
            // 
            // colHistoricoFuncao
            // 
            this.colHistoricoFuncao.AppearanceCell.Options.UseTextOptions = true;
            this.colHistoricoFuncao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoFuncao.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistoricoFuncao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoFuncao.FieldName = "HistoricoFuncao";
            this.colHistoricoFuncao.Name = "colHistoricoFuncao";
            // 
            // colHistoricoSalarial
            // 
            this.colHistoricoSalarial.AppearanceCell.Options.UseTextOptions = true;
            this.colHistoricoSalarial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoSalarial.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistoricoSalarial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoSalarial.FieldName = "HistoricoSalarial";
            this.colHistoricoSalarial.Name = "colHistoricoSalarial";
            // 
            // XFrmFuncionarioListView
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmFuncionarioListView";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Gerenciador de Funcionário";
            this.Shown += new System.EventHandler(this.XFrmGerenciarFuncionario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnNovo;
        private DevExpress.XtraBars.BarButtonItem barBtnEditar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarButtonItem barBtnAlterarSalario;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControlFuncionario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFuncionario;
        private System.Windows.Forms.BindingSource bsFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn colCPF;
        private DevExpress.XtraGrid.Columns.GridColumn colDataNascimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAdmissao;
        private DevExpress.XtraGrid.Columns.GridColumn colSalario;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoCivil;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefoneFixo;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoRecebimento;
        private DevExpress.XtraGrid.Columns.GridColumn colFoto;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colRegistroGeral;
        private DevExpress.XtraGrid.Columns.GridColumn colEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colCTPS;
        private DevExpress.XtraGrid.Columns.GridColumn colCNH;
        private DevExpress.XtraGrid.Columns.GridColumn colTituloEleitor;
        private DevExpress.XtraGrid.Columns.GridColumn colCertificadoReservista;
        private DevExpress.XtraGrid.Columns.GridColumn colFichaFinaceiraFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricoSituacao;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricoDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricoFuncao;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricoSalarial;
        private DevExpress.XtraBars.BarButtonItem barBtnAlterarSituacao;
        private DevExpress.XtraBars.BarButtonItem batBtnAlterarDepto;
        private DevExpress.XtraBars.BarButtonItem batBtnAlterarFuncao;
    }
}