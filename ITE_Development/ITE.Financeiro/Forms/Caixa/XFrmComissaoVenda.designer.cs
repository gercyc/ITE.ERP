using ITE.Financeiro.Listeners;

namespace ITE.Financeiro.Forms.Caixa
{
    partial class XFrmComissaoVenda
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmComissaoVenda));
            this.gridViewDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdComissaoVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorFaturado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorComissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusComissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLancamentos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsVenda = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewComissoes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbSituacaoComissao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.searchLkpUser = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLkpViewUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentagemComissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompetencias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLancamentosCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLancamentosRecModifyBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsGerente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducaoSerra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeUtilizador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSenha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConfirmarSenha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInclusao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSkin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnToggleSwitchUser = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnFiltrar = new DevExpress.XtraEditors.SimpleButton();
            this.dtInicio = new DevExpress.XtraEditors.DateEdit();
            this.cbFiltro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtFinal = new DevExpress.XtraEditors.DateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barBtnFaturarComissaoIntegral = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFaturarComissaoParcial = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrintReport = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExpandCollapse = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComissoes)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacaoComissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLkpUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLkpViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleSwitchUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewDetails
            // 
            this.gridViewDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdComissaoVenda,
            this.gridColumn2,
            this.colValorFaturado,
            this.colValorComissao,
            this.gridColumn3,
            this.colStatusComissao,
            this.gridColumn4,
            this.colImage,
            this.colLancamentos});
            this.gridViewDetails.GridControl = this.gridControl1;
            this.gridViewDetails.Name = "gridViewDetails";
            this.gridViewDetails.OptionsBehavior.Editable = false;
            this.gridViewDetails.OptionsView.ColumnAutoWidth = false;
            // 
            // colIdComissaoVenda
            // 
            this.colIdComissaoVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colIdComissaoVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdComissaoVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdComissaoVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdComissaoVenda.FieldName = "IdComissaoVenda";
            this.colIdComissaoVenda.Name = "colIdComissaoVenda";
            this.colIdComissaoVenda.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn2.FieldName = "IdVenda";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 176;
            // 
            // colValorFaturado
            // 
            this.colValorFaturado.AppearanceCell.Options.UseTextOptions = true;
            this.colValorFaturado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorFaturado.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorFaturado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorFaturado.DisplayFormat.FormatString = "n2";
            this.colValorFaturado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorFaturado.FieldName = "ValorFaturado";
            this.colValorFaturado.Name = "colValorFaturado";
            this.colValorFaturado.Visible = true;
            this.colValorFaturado.VisibleIndex = 2;
            this.colValorFaturado.Width = 158;
            // 
            // colValorComissao
            // 
            this.colValorComissao.AppearanceCell.Options.UseTextOptions = true;
            this.colValorComissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorComissao.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorComissao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorComissao.Caption = "Comissão R$";
            this.colValorComissao.DisplayFormat.FormatString = "n2";
            this.colValorComissao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorComissao.FieldName = "ValorComissao";
            this.colValorComissao.Name = "colValorComissao";
            this.colValorComissao.Visible = true;
            this.colValorComissao.VisibleIndex = 4;
            this.colValorComissao.Width = 153;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn3.Caption = "Comissão %";
            this.gridColumn3.DisplayFormat.FormatString = "n2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn3.FieldName = "PorcentagemComissao";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 138;
            // 
            // colStatusComissao
            // 
            this.colStatusComissao.AppearanceCell.Options.UseTextOptions = true;
            this.colStatusComissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusComissao.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatusComissao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusComissao.Caption = "Status Comissão";
            this.colStatusComissao.DisplayFormat.FormatString = "n2";
            this.colStatusComissao.FieldName = "StatusComissao";
            this.colStatusComissao.Name = "colStatusComissao";
            this.colStatusComissao.Visible = true;
            this.colStatusComissao.VisibleIndex = 1;
            this.colStatusComissao.Width = 135;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn4.FieldName = "Venda";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 152;
            // 
            // colImage
            // 
            this.colImage.AppearanceCell.Options.UseTextOptions = true;
            this.colImage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImage.AppearanceHeader.Options.UseTextOptions = true;
            this.colImage.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImage.Caption = "  ";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.ReadOnly = true;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 32;
            // 
            // colLancamentos
            // 
            this.colLancamentos.AppearanceCell.Options.UseTextOptions = true;
            this.colLancamentos.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colLancamentos.AppearanceHeader.Options.UseTextOptions = true;
            this.colLancamentos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colLancamentos.FieldName = "Lancamentos";
            this.colLancamentos.Name = "colLancamentos";
            this.colLancamentos.Width = 98;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bsVenda;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            gridLevelNode1.LevelTemplate = this.gridViewDetails;
            gridLevelNode1.RelationName = "Comissoes";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 94);
            this.gridControl1.MainView = this.gridViewComissoes;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1005, 468);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewComissoes,
            this.gridViewDetails});
            // 
            // bsVenda
            // 
            this.bsVenda.DataSource = typeof(ITE.Entidades.POCO.Sales.Venda);
            // 
            // gridViewComissoes
            // 
            this.gridViewComissoes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdVenda,
            this.colUsuario,
            this.colVenda,
            this.colTotalVenda,
            this.colVencimento});
            this.gridViewComissoes.GridControl = this.gridControl1;
            this.gridViewComissoes.Name = "gridViewComissoes";
            this.gridViewComissoes.OptionsBehavior.Editable = false;
            this.gridViewComissoes.OptionsCustomization.AllowRowSizing = true;
            this.gridViewComissoes.OptionsSelection.MultiSelect = true;
            this.gridViewComissoes.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewComissoes.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewComissoes.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewComissoes.OptionsView.ShowFooter = true;
            this.gridViewComissoes.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colIdVenda
            // 
            this.colIdVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colIdVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVenda.Caption = "N°. Venda";
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdVenda", "{0}")});
            this.colIdVenda.Visible = true;
            this.colIdVenda.VisibleIndex = 1;
            this.colIdVenda.Width = 142;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.Caption = "Vendedor";
            this.colUsuario.FieldName = "Usuario.NomeUsuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 2;
            this.colUsuario.Width = 370;
            // 
            // colVenda
            // 
            this.colVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colVenda.Caption = "Data Venda";
            this.colVenda.FieldName = "DataVenda";
            this.colVenda.Name = "colVenda";
            this.colVenda.Visible = true;
            this.colVenda.VisibleIndex = 3;
            this.colVenda.Width = 87;
            // 
            // colTotalVenda
            // 
            this.colTotalVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalVenda.Caption = "Comissao R$";
            this.colTotalVenda.DisplayFormat.FormatString = "N2";
            this.colTotalVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalVenda.FieldName = "TotalComissao";
            this.colTotalVenda.Name = "colTotalVenda";
            this.colTotalVenda.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Venda.TotalVenda", "{0:n2}")});
            this.colTotalVenda.Visible = true;
            this.colTotalVenda.VisibleIndex = 5;
            this.colTotalVenda.Width = 208;
            // 
            // colVencimento
            // 
            this.colVencimento.Caption = "Vencimento";
            this.colVencimento.FieldName = "DataVencimento";
            this.colVencimento.Name = "colVencimento";
            this.colVencimento.Visible = true;
            this.colVencimento.VisibleIndex = 4;
            this.colVencimento.Width = 103;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 564);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbSituacaoComissao);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.searchLkpUser);
            this.panelControl1.Controls.Add(this.btnToggleSwitchUser);
            this.panelControl1.Controls.Add(this.btnFiltrar);
            this.panelControl1.Controls.Add(this.dtInicio);
            this.panelControl1.Controls.Add(this.cbFiltro);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.dtFinal);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 4);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1005, 84);
            this.panelControl1.TabIndex = 24;
            // 
            // cbSituacaoComissao
            // 
            this.cbSituacaoComissao.EditValue = "Pendente";
            this.cbSituacaoComissao.Location = new System.Drawing.Point(759, 34);
            this.cbSituacaoComissao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSituacaoComissao.Name = "cbSituacaoComissao";
            this.cbSituacaoComissao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSituacaoComissao.Properties.Appearance.Options.UseFont = true;
            this.cbSituacaoComissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSituacaoComissao.Properties.Items.AddRange(new object[] {
            "Pendente",
            "Vencida",
            "Faturado"});
            this.cbSituacaoComissao.Size = new System.Drawing.Size(146, 24);
            this.cbSituacaoComissao.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(759, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 18);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Situação";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 18);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Vendedor";
            // 
            // searchLkpUser
            // 
            this.searchLkpUser.EditValue = "";
            this.searchLkpUser.Location = new System.Drawing.Point(16, 34);
            this.searchLkpUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchLkpUser.Name = "searchLkpUser";
            this.searchLkpUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.searchLkpUser.Properties.Appearance.Options.UseFont = true;
            this.searchLkpUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLkpUser.Properties.DisplayMember = "NomeUsuario";
            this.searchLkpUser.Properties.NullText = "Selecione o Vendedor";
            this.searchLkpUser.Properties.ValueMember = "NomeUsuario";
            this.searchLkpUser.Properties.View = this.searchLkpViewUser;
            this.searchLkpUser.Size = new System.Drawing.Size(191, 24);
            this.searchLkpUser.TabIndex = 0;
            this.searchLkpUser.EditValueChanged += new System.EventHandler(this.searchLkpUser_EditValueChanged);
            // 
            // searchLkpViewUser
            // 
            this.searchLkpViewUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUsuario,
            this.colIdGrupoUsuario,
            this.colGrupoUsuario,
            this.colPorcentagemComissao,
            this.gridColumn1,
            this.colCompetencias,
            this.colLancamentosCreatedBy,
            this.colLancamentosRecModifyBy,
            this.colInvoices,
            this.colIsGerente,
            this.colIsAdmin,
            this.colIsVendedor,
            this.colProducaoSerra,
            this.colNomeUsuario,
            this.colNomeUtilizador,
            this.colSenha,
            this.colConfirmarSenha,
            this.colDataInclusao,
            this.colSkin});
            this.searchLkpViewUser.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLkpViewUser.Name = "searchLkpViewUser";
            this.searchLkpViewUser.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLkpViewUser.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colIdGrupoUsuario
            // 
            this.colIdGrupoUsuario.FieldName = "IdGrupoUsuario";
            this.colIdGrupoUsuario.Name = "colIdGrupoUsuario";
            // 
            // colGrupoUsuario
            // 
            this.colGrupoUsuario.FieldName = "GrupoUsuario";
            this.colGrupoUsuario.Name = "colGrupoUsuario";
            // 
            // colPorcentagemComissao
            // 
            this.colPorcentagemComissao.FieldName = "PorcentagemComissao";
            this.colPorcentagemComissao.Name = "colPorcentagemComissao";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Venda";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colCompetencias
            // 
            this.colCompetencias.FieldName = "Competencias";
            this.colCompetencias.Name = "colCompetencias";
            // 
            // colLancamentosCreatedBy
            // 
            this.colLancamentosCreatedBy.FieldName = "LancamentosCreatedBy";
            this.colLancamentosCreatedBy.Name = "colLancamentosCreatedBy";
            // 
            // colLancamentosRecModifyBy
            // 
            this.colLancamentosRecModifyBy.FieldName = "LancamentosRecModifyBy";
            this.colLancamentosRecModifyBy.Name = "colLancamentosRecModifyBy";
            // 
            // colInvoices
            // 
            this.colInvoices.FieldName = "Custeios";
            this.colInvoices.Name = "colInvoices";
            // 
            // colIsGerente
            // 
            this.colIsGerente.FieldName = "IsGerente";
            this.colIsGerente.Name = "colIsGerente";
            this.colIsGerente.OptionsColumn.ReadOnly = true;
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.OptionsColumn.ReadOnly = true;
            // 
            // colIsVendedor
            // 
            this.colIsVendedor.FieldName = "IsVendedor";
            this.colIsVendedor.Name = "colIsVendedor";
            this.colIsVendedor.OptionsColumn.ReadOnly = true;
            // 
            // colProducaoSerra
            // 
            this.colProducaoSerra.FieldName = "ProducaoSerra";
            this.colProducaoSerra.Name = "colProducaoSerra";
            // 
            // colNomeUsuario
            // 
            this.colNomeUsuario.FieldName = "NomeUsuario";
            this.colNomeUsuario.Name = "colNomeUsuario";
            this.colNomeUsuario.Visible = true;
            this.colNomeUsuario.VisibleIndex = 0;
            // 
            // colNomeUtilizador
            // 
            this.colNomeUtilizador.FieldName = "NomeUtilizador";
            this.colNomeUtilizador.Name = "colNomeUtilizador";
            // 
            // colSenha
            // 
            this.colSenha.FieldName = "Senha";
            this.colSenha.Name = "colSenha";
            // 
            // colConfirmarSenha
            // 
            this.colConfirmarSenha.FieldName = "ConfirmarSenha";
            this.colConfirmarSenha.Name = "colConfirmarSenha";
            // 
            // colDataInclusao
            // 
            this.colDataInclusao.FieldName = "DataInclusao";
            this.colDataInclusao.Name = "colDataInclusao";
            // 
            // colSkin
            // 
            this.colSkin.FieldName = "Skin";
            this.colSkin.Name = "colSkin";
            // 
            // btnToggleSwitchUser
            // 
            this.btnToggleSwitchUser.EditValue = true;
            this.btnToggleSwitchUser.Location = new System.Drawing.Point(219, 31);
            this.btnToggleSwitchUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToggleSwitchUser.Name = "btnToggleSwitchUser";
            this.btnToggleSwitchUser.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnToggleSwitchUser.Properties.Appearance.Options.UseFont = true;
            this.btnToggleSwitchUser.Properties.OffText = "Off";
            this.btnToggleSwitchUser.Properties.OnText = "On";
            this.btnToggleSwitchUser.Properties.ShowText = false;
            this.btnToggleSwitchUser.Size = new System.Drawing.Size(91, 29);
            superToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem1.Text = "Opção Filtragem";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Filtras as comissões por vendedor\r\n\r\nDesative essa opção para filtrar a comissão " +
    "de venda de todos os vendedor.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnToggleSwitchUser.SuperTip = superToolTip1;
            this.btnToggleSwitchUser.TabIndex = 1;
            this.btnToggleSwitchUser.Toggled += new System.EventHandler(this.btnToggleSwitchUser_Toggled);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFiltrar.Appearance.Options.UseFont = true;
            this.btnFiltrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.ImageOptions.Image")));
            this.btnFiltrar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnFiltrar.Location = new System.Drawing.Point(911, 32);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 28);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.EditValue = new System.DateTime(2017, 8, 5, 19, 32, 2, 0);
            this.dtInicio.Location = new System.Drawing.Point(320, 34);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Properties.Appearance.Options.UseFont = true;
            this.dtInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicio.Size = new System.Drawing.Size(120, 24);
            this.dtInicio.TabIndex = 2;
            this.dtInicio.Leave += new System.EventHandler(this.dtInicio_Leave);
            // 
            // cbFiltro
            // 
            this.cbFiltro.Location = new System.Drawing.Point(585, 34);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.cbFiltro.Size = new System.Drawing.Size(159, 24);
            this.cbFiltro.TabIndex = 4;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(320, 12);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 18);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "De:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(585, 11);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Pré Filtro:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(451, 11);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(14, 18);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Á:";
            // 
            // dtFinal
            // 
            this.dtFinal.EditValue = new System.DateTime(2017, 8, 5, 19, 31, 55, 0);
            this.dtFinal.Location = new System.Drawing.Point(451, 34);
            this.dtFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFinal.Properties.Appearance.Options.UseFont = true;
            this.dtFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFinal.Size = new System.Drawing.Size(120, 24);
            this.dtFinal.TabIndex = 3;
            this.dtFinal.Leave += new System.EventHandler(this.dtInicio_Leave);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnFaturarComissaoIntegral,
            this.barBtnPrintReport,
            this.barSubItem1,
            this.barBtnFaturarComissaoParcial,
            this.barBtnExpandCollapse,
            this.barBtnRefresh});
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrintReport),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnExpandCollapse),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRefresh)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Faturar Comissão";
            this.barSubItem1.Id = 3;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnFaturarComissaoIntegral),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnFaturarComissaoParcial)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barBtnFaturarComissaoIntegral
            // 
            this.barBtnFaturarComissaoIntegral.Caption = "Comissão Integral";
            this.barBtnFaturarComissaoIntegral.Id = 0;
            this.barBtnFaturarComissaoIntegral.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnFaturarComissaoIntegral.ImageOptions.Image")));
            this.barBtnFaturarComissaoIntegral.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnFaturarComissaoIntegral.ImageOptions.LargeImage")));
            this.barBtnFaturarComissaoIntegral.Name = "barBtnFaturarComissaoIntegral";
            this.barBtnFaturarComissaoIntegral.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnFaturarComissaoIntegral.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFaturarComissaoIntegral_ItemClick);
            // 
            // barBtnFaturarComissaoParcial
            // 
            this.barBtnFaturarComissaoParcial.Caption = "Comissão Parcial";
            this.barBtnFaturarComissaoParcial.Id = 4;
            this.barBtnFaturarComissaoParcial.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnFaturarComissaoParcial.ImageOptions.Image")));
            this.barBtnFaturarComissaoParcial.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnFaturarComissaoParcial.ImageOptions.LargeImage")));
            this.barBtnFaturarComissaoParcial.Name = "barBtnFaturarComissaoParcial";
            this.barBtnFaturarComissaoParcial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnFaturarComissaoParcial_ItemClick);
            // 
            // barBtnPrintReport
            // 
            this.barBtnPrintReport.Caption = "Imprimir Relatório";
            this.barBtnPrintReport.Id = 1;
            this.barBtnPrintReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPrintReport.ImageOptions.Image")));
            this.barBtnPrintReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnPrintReport.ImageOptions.LargeImage")));
            this.barBtnPrintReport.Name = "barBtnPrintReport";
            this.barBtnPrintReport.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnPrintReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrintReport_ItemClick);
            // 
            // barBtnExpandCollapse
            // 
            this.barBtnExpandCollapse.Caption = "Expand/Collapse";
            this.barBtnExpandCollapse.Id = 5;
            this.barBtnExpandCollapse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnExpandCollapse.ImageOptions.Image")));
            this.barBtnExpandCollapse.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnExpandCollapse.ImageOptions.LargeImage")));
            this.barBtnExpandCollapse.Name = "barBtnExpandCollapse";
            this.barBtnExpandCollapse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExpandCollapse_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Atualizar";
            this.barBtnRefresh.Id = 6;
            this.barBtnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.ImageOptions.Image")));
            this.barBtnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.ImageOptions.LargeImage")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1011, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 601);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1011, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 564);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1011, 37);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 564);
            // 
            // XFrmComissaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmComissaoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comissão de Vendas";
            this.Shown += new System.EventHandler(this.XFrmCaixaVendas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComissoes)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSituacaoComissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLkpUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLkpViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggleSwitchUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFiltro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //this.masterRowComissao = new MasterRowComissaoVenda(this.gridViewComissoes);
        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.DateEdit dtInicio;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit dtFinal;
        private DevExpress.XtraEditors.SimpleButton btnFiltrar;
        private DevExpress.XtraEditors.ComboBoxEdit cbFiltro;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLkpUser;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLkpViewUser;
        private DevExpress.XtraEditors.ToggleSwitch btnToggleSwitchUser;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnFaturarComissaoIntegral;
        private DevExpress.XtraBars.BarButtonItem barBtnPrintReport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewComissoes;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colVenda;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbSituacaoComissao;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentagemComissao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompetencias;
        private DevExpress.XtraGrid.Columns.GridColumn colLancamentosCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLancamentosRecModifyBy;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoices;
        private DevExpress.XtraGrid.Columns.GridColumn colIsGerente;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colIsVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colProducaoSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeUtilizador;
        private DevExpress.XtraGrid.Columns.GridColumn colSenha;
        private DevExpress.XtraGrid.Columns.GridColumn colConfirmarSenha;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInclusao;
        private DevExpress.XtraGrid.Columns.GridColumn colSkin;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnFaturarComissaoParcial;
        private DevExpress.XtraBars.BarButtonItem barBtnExpandCollapse;
        private DevExpress.XtraGrid.Columns.GridColumn colVencimento;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private System.Windows.Forms.BindingSource bsVenda;
        private ITE.Financeiro.Listeners.MasterRowComissaoVenda masterRowComissao;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetails;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComissaoVenda;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colValorFaturado;
        private DevExpress.XtraGrid.Columns.GridColumn colValorComissao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusComissao;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colLancamentos;
    }
}