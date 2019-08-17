using ITSolution.Framework.Components;

namespace ITE.Financeiro.Forms.Caixa
{
    partial class XFrmCaixaVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCaixaVendas));
            this.barBtnSaqueCaixa = new DevExpress.XtraBars.BarButtonItem();
            this.btnFluxoCaixa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnDeposito = new DevExpress.XtraBars.BarButtonItem();
            this.barEditUsers = new DevExpress.XtraBars.BarEditItem();
            this.repSearchLookUpEditUser = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridSearchLookUpEditViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barToggleSwitchUser = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repToggleSwitchSelectUser = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsMovimentoCaixa = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistoricoMov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pnlPeriodo = new DevExpress.XtraEditors.PanelControl();
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtFinal = new DevExpress.XtraEditors.DateEdit();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.cbFiltro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panelSum1 = new PanelSum();
            this.lblSaldoDinheiro = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpEditUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchLookUpEditViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repToggleSwitchSelectUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPeriodo)).BeginInit();
            this.pnlPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSum1)).BeginInit();
            this.panelSum1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barBtnSaqueCaixa
            // 
            this.barBtnSaqueCaixa.Caption = "Saque";
            this.barBtnSaqueCaixa.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSaqueCaixa.Glyph")));
            this.barBtnSaqueCaixa.Id = 2;
            this.barBtnSaqueCaixa.Name = "barBtnSaqueCaixa";
            this.barBtnSaqueCaixa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSaqueCaixa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnSaqueCaixa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSaqueCaixa_ItemClick);
            // 
            // btnFluxoCaixa
            // 
            this.btnFluxoCaixa.Caption = "Fluxo de Caixa";
            this.btnFluxoCaixa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnFluxoCaixa.Glyph")));
            this.btnFluxoCaixa.Id = 1;
            this.btnFluxoCaixa.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.btnFluxoCaixa.Name = "btnFluxoCaixa";
            this.btnFluxoCaixa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnFluxoCaixa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnFluxoCaixa.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnFluxoCaixa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFluxoCaixa_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 0;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAtualizar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnAtualizar,
            this.btnFluxoCaixa,
            this.barBtnSaqueCaixa,
            this.barBtnDeposito,
            this.barEditUsers,
            this.barToggleSwitchUser});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repToggleSwitchSelectUser,
            this.repSearchLookUpEditUser});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(853, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnDeposito
            // 
            this.barBtnDeposito.Caption = "Depósito";
            this.barBtnDeposito.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnDeposito.Glyph")));
            this.barBtnDeposito.Id = 1;
            this.barBtnDeposito.Name = "barBtnDeposito";
            this.barBtnDeposito.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDeposito.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDeposito_ItemClick);
            // 
            // barEditUsers
            // 
            this.barEditUsers.Caption = "Usuários:";
            this.barEditUsers.Edit = this.repSearchLookUpEditUser;
            this.barEditUsers.EditWidth = 250;
            this.barEditUsers.Id = 3;
            this.barEditUsers.Name = "barEditUsers";
            this.barEditUsers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // repSearchLookUpEditUser
            // 
            this.repSearchLookUpEditUser.AutoHeight = false;
            this.repSearchLookUpEditUser.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSearchLookUpEditUser.DisplayMember = "NomeUsuario";
            this.repSearchLookUpEditUser.Name = "repSearchLookUpEditUser";
            this.repSearchLookUpEditUser.NullText = "";
            this.repSearchLookUpEditUser.NullValuePrompt = "Selecione o usuário a ser filtrado";
            this.repSearchLookUpEditUser.ReadOnly = true;
            this.repSearchLookUpEditUser.View = this.gridSearchLookUpEditViewUser;
            // 
            // gridSearchLookUpEditViewUser
            // 
            this.gridSearchLookUpEditViewUser.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridSearchLookUpEditViewUser.Name = "gridSearchLookUpEditViewUser";
            this.gridSearchLookUpEditViewUser.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridSearchLookUpEditViewUser.OptionsView.ShowGroupPanel = false;
            // 
            // barToggleSwitchUser
            // 
            this.barToggleSwitchUser.Caption = "Filtra Usuário";
            this.barToggleSwitchUser.Id = 4;
            this.barToggleSwitchUser.Name = "barToggleSwitchUser";
            this.barToggleSwitchUser.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barToggleSwitchUser_CheckedChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Controle do Caixa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnDeposito);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSaqueCaixa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFluxoCaixa);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAtualizar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barToggleSwitchUser);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditUsers);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Opções";
            // 
            // repToggleSwitchSelectUser
            // 
            this.repToggleSwitchSelectUser.AutoHeight = false;
            this.repToggleSwitchSelectUser.Name = "repToggleSwitchSelectUser";
            this.repToggleSwitchSelectUser.OffText = "Off";
            this.repToggleSwitchSelectUser.OnText = "On";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 471);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(853, 32);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bsMovimentoCaixa;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(3, 85);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(847, 206);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsMovimentoCaixa
            // 
            this.bsMovimentoCaixa.DataSource = typeof(ITE.Entidades.POCO.Financeiro.MovimentoCaixa);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMovimento,
            this.colImage,
            this.colIdVenda,
            this.colVenda,
            this.colIdUsuario,
            this.colUsuario,
            this.colValorMovimento,
            this.colTipoMov,
            this.colDataMovimento,
            this.colHistoricoMov,
            this.colSaldo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colIdMovimento
            // 
            this.colIdMovimento.AppearanceCell.Options.UseTextOptions = true;
            this.colIdMovimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMovimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdMovimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMovimento.Caption = "ID";
            this.colIdMovimento.FieldName = "IdMovimento";
            this.colIdMovimento.Name = "colIdMovimento";
            this.colIdMovimento.Width = 71;
            // 
            // colImage
            // 
            this.colImage.AppearanceCell.Options.UseTextOptions = true;
            this.colImage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImage.AppearanceHeader.Options.UseTextOptions = true;
            this.colImage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImage.Caption = " ";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.ReadOnly = true;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 41;
            // 
            // colIdVenda
            // 
            this.colIdVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colIdVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.Visible = true;
            this.colIdVenda.VisibleIndex = 2;
            this.colIdVenda.Width = 93;
            // 
            // colVenda
            // 
            this.colVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colVenda.FieldName = "Venda";
            this.colVenda.Name = "colVenda";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colIdUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.Caption = "Usuário";
            this.colUsuario.FieldName = "Usuario.NomeUsuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 3;
            this.colUsuario.Width = 120;
            // 
            // colValorMovimento
            // 
            this.colValorMovimento.AppearanceCell.Options.UseTextOptions = true;
            this.colValorMovimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorMovimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorMovimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorMovimento.Caption = "Valor Movimento";
            this.colValorMovimento.DisplayFormat.FormatString = "n2";
            this.colValorMovimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorMovimento.FieldName = "ValorMovimento";
            this.colValorMovimento.Name = "colValorMovimento";
            this.colValorMovimento.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorMovimento", "Total: {0:c2}")});
            this.colValorMovimento.Visible = true;
            this.colValorMovimento.VisibleIndex = 4;
            this.colValorMovimento.Width = 92;
            // 
            // colTipoMov
            // 
            this.colTipoMov.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoMov.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoMov.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoMov.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoMov.Caption = "Espécie";
            this.colTipoMov.FieldName = "TipoMov";
            this.colTipoMov.Name = "colTipoMov";
            this.colTipoMov.Visible = true;
            this.colTipoMov.VisibleIndex = 1;
            this.colTipoMov.Width = 69;
            // 
            // colDataMovimento
            // 
            this.colDataMovimento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataMovimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataMovimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataMovimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataMovimento.Caption = "Dt. Movimento";
            this.colDataMovimento.FieldName = "DataMovimento";
            this.colDataMovimento.Name = "colDataMovimento";
            this.colDataMovimento.Visible = true;
            this.colDataMovimento.VisibleIndex = 5;
            this.colDataMovimento.Width = 87;
            // 
            // colHistoricoMov
            // 
            this.colHistoricoMov.AppearanceCell.Options.UseTextOptions = true;
            this.colHistoricoMov.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoMov.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistoricoMov.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoMov.FieldName = "HistoricoMov";
            this.colHistoricoMov.Name = "colHistoricoMov";
            this.colHistoricoMov.Visible = true;
            this.colHistoricoMov.VisibleIndex = 6;
            this.colHistoricoMov.Width = 740;
            // 
            // colSaldo
            // 
            this.colSaldo.AppearanceCell.Options.UseTextOptions = true;
            this.colSaldo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSaldo.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.Width = 90;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSum1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 327);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.pnlPeriodo);
            this.groupControl2.Controls.Add(this.btnFiltrar);
            this.groupControl2.Controls.Add(this.cbFiltro);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 2);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(847, 79);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "Filtros de Controles para Indicadores";
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlPeriodo.Appearance.Options.UseBackColor = true;
            this.pnlPeriodo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlPeriodo.Controls.Add(this.dtInicio);
            this.pnlPeriodo.Controls.Add(this.labelControl4);
            this.pnlPeriodo.Controls.Add(this.labelControl6);
            this.pnlPeriodo.Controls.Add(this.dtFinal);
            this.pnlPeriodo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPeriodo.Location = new System.Drawing.Point(2, 21);
            this.pnlPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(278, 56);
            this.pnlPeriodo.TabIndex = 13;
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = new System.DateTime(2016, 12, 17, 11, 58, 57, 791);
            this.dtInicio.Location = new System.Drawing.Point(9, 25);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Properties.Appearance.Options.UseFont = true;
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Size = new System.Drawing.Size(103, 20);
            this.dtInicio.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(9, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(19, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "De:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(133, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(8, 14);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Á";
            // 
            // dtFinal
            // 
            this.dtFinal.EditValue = new System.DateTime(2016, 12, 17, 11, 59, 5, 279);
            this.dtFinal.Location = new System.Drawing.Point(133, 25);
            this.dtFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Properties.Appearance.Options.UseFont = true;
            this.dtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinal.Size = new System.Drawing.Size(103, 20);
            this.dtFinal.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFiltrar.Appearance.Options.UseFont = true;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnFiltrar.Location = new System.Drawing.Point(463, 46);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(64, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbFiltro
            // 
            this.cbFiltro.EditValue = "Por Dia";
            this.cbFiltro.Location = new System.Drawing.Point(313, 47);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.Properties.Appearance.Options.UseFont = true;
            this.cbFiltro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFiltro.Properties.Items.AddRange(new object[] {
            "Por Período",
            "Mês Atual",
            "Mês Anterior",
            "Por Dia",
            "Por Ano"});
            this.cbFiltro.Size = new System.Drawing.Size(136, 20);
            this.cbFiltro.TabIndex = 2;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(313, 27);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 14);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Filtrar por:";
            // 
            // panelSum1
            // 
            this.panelSum1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSum1.Controls.Add(this.lblSaldoDinheiro);
            this.panelSum1.Location = new System.Drawing.Point(3, 295);
            this.panelSum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSum1.Name = "panelSum1";
            this.panelSum1.Size = new System.Drawing.Size(847, 30);
            this.panelSum1.TabIndex = 1;
            // 
            // lblSaldoDinheiro
            // 
            this.lblSaldoDinheiro.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSaldoDinheiro.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSaldoDinheiro.Location = new System.Drawing.Point(2, 2);
            this.lblSaldoDinheiro.Name = "lblSaldoDinheiro";
            this.lblSaldoDinheiro.Size = new System.Drawing.Size(119, 16);
            this.lblSaldoDinheiro.TabIndex = 6;
            this.lblSaldoDinheiro.Text = "Saldo em dinheiro:";
            this.lblSaldoDinheiro.ToolTip = "Saldo atual do caixa";
            // 
            // XFrmCaixaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "XFrmCaixaVendas";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Caixa de Vendas";
            this.Shown += new System.EventHandler(this.XFrmCaixaVendas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSearchLookUpEditUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchLookUpEditViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repToggleSwitchSelectUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentoCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPeriodo)).EndInit();
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSum1)).EndInit();
            this.panelSum1.ResumeLayout(false);
            this.panelSum1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarButtonItem btnFluxoCaixa;
        private DevExpress.XtraBars.BarButtonItem barBtnSaqueCaixa;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barBtnDeposito;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repToggleSwitchSelectUser;
        private DevExpress.XtraBars.BarEditItem barEditUsers;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repSearchLookUpEditUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSearchLookUpEditViewUser;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl pnlPeriodo;
        private DevExpress.XtraEditors.DateEdit dtInicio;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtFinal;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraEditors.ComboBoxEdit cbFiltro;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private PanelSum panelSum1;
        private System.Windows.Forms.BindingSource bsMovimentoCaixa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMov;
        private DevExpress.XtraGrid.Columns.GridColumn colDataMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricoMov;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchUser;
        private DevExpress.XtraEditors.LabelControl lblSaldoDinheiro;
    }
}