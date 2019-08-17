using ITSolution.Framework.Components;

namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmProducaoVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmProducaoVendas));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsVenda = new System.Windows.Forms.BindingSource();
            this.gridViewVendas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParcelasVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataProposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroParcelas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroItens = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusProposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPagamentoVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotalDesconto = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalVendas = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalVendasPrazo = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalVendasAvista = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.lblTotalLiquido = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.panelSomatorio1 = new ITSolution.Framework.Components.PanelSum();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSomatorio1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.bsVenda;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(3, 100);
            this.gridControl1.MainView = this.gridViewVendas;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(855, 443);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVendas});
            this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // bsVenda
            // 
            this.bsVenda.DataSource = typeof(ITE.Entidades.POCO.Sales.Venda);
            // 
            // gridViewVendas
            // 
            this.gridViewVendas.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewVendas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewVendas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdVenda,
            this.colParcelasVenda,
            this.colDataProposta,
            this.colTotalProposta,
            this.colValorDesconto,
            this.colNumeroParcelas,
            this.colObservacao,
            this.colNumeroItens,
            this.colStatusProposta,
            this.colDesconto,
            this.colNomeCliFor,
            this.colUsuario,
            this.colIdFormaPagamentoVenda,
            this.colDataPagamento});
            this.gridViewVendas.GridControl = this.gridControl1;
            this.gridViewVendas.Name = "gridViewVendas";
            this.gridViewVendas.OptionsView.ShowFooter = true;
            this.gridViewVendas.OptionsView.ShowGroupPanel = false;
            this.gridViewVendas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDataProposta, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewVendas.DoubleClick += new System.EventHandler(this.gridViewVendas_DoubleClick);
            // 
            // colIdVenda
            // 
            this.colIdVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colIdVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVenda.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colIdVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVenda.Caption = "Ref. Venda";
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.OptionsColumn.AllowEdit = false;
            this.colIdVenda.Visible = true;
            this.colIdVenda.VisibleIndex = 0;
            this.colIdVenda.Width = 95;
            // 
            // colParcelasVenda
            // 
            this.colParcelasVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colParcelasVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colParcelasVenda.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colParcelasVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colParcelasVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colParcelasVenda.FieldName = "ValorDesconto";
            this.colParcelasVenda.Name = "colParcelasVenda";
            this.colParcelasVenda.OptionsColumn.AllowEdit = false;
            this.colParcelasVenda.Width = 101;
            // 
            // colDataProposta
            // 
            this.colDataProposta.AppearanceCell.Options.UseTextOptions = true;
            this.colDataProposta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataProposta.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colDataProposta.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataProposta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataProposta.Caption = "Data Venda";
            this.colDataProposta.FieldName = "DataVenda";
            this.colDataProposta.Name = "colDataProposta";
            this.colDataProposta.OptionsColumn.AllowEdit = false;
            this.colDataProposta.Visible = true;
            this.colDataProposta.VisibleIndex = 2;
            this.colDataProposta.Width = 112;
            // 
            // colTotalProposta
            // 
            this.colTotalProposta.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalProposta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalProposta.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colTotalProposta.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalProposta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalProposta.Caption = "Total";
            this.colTotalProposta.DisplayFormat.FormatString = "c2";
            this.colTotalProposta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalProposta.FieldName = "TotalVenda";
            this.colTotalProposta.Name = "colTotalProposta";
            this.colTotalProposta.OptionsColumn.AllowEdit = false;
            this.colTotalProposta.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalVenda", "SUM={0:c2}")});
            this.colTotalProposta.Visible = true;
            this.colTotalProposta.VisibleIndex = 6;
            this.colTotalProposta.Width = 166;
            // 
            // colValorDesconto
            // 
            this.colValorDesconto.AppearanceCell.Options.UseTextOptions = true;
            this.colValorDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorDesconto.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colValorDesconto.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorDesconto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorDesconto.FieldName = "ValorDesconto";
            this.colValorDesconto.Name = "colValorDesconto";
            this.colValorDesconto.OptionsColumn.AllowEdit = false;
            this.colValorDesconto.Width = 73;
            // 
            // colNumeroParcelas
            // 
            this.colNumeroParcelas.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroParcelas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroParcelas.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colNumeroParcelas.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroParcelas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroParcelas.FieldName = "NumeroParcelas";
            this.colNumeroParcelas.Name = "colNumeroParcelas";
            this.colNumeroParcelas.OptionsColumn.AllowEdit = false;
            this.colNumeroParcelas.Width = 113;
            // 
            // colObservacao
            // 
            this.colObservacao.AppearanceCell.Options.UseTextOptions = true;
            this.colObservacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colObservacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colObservacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.OptionsColumn.AllowEdit = false;
            this.colObservacao.Width = 33;
            // 
            // colNumeroItens
            // 
            this.colNumeroItens.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroItens.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroItens.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colNumeroItens.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroItens.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroItens.FieldName = "NumeroItens";
            this.colNumeroItens.Name = "colNumeroItens";
            this.colNumeroItens.OptionsColumn.AllowEdit = false;
            this.colNumeroItens.Width = 122;
            // 
            // colStatusProposta
            // 
            this.colStatusProposta.AppearanceCell.Options.UseTextOptions = true;
            this.colStatusProposta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusProposta.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colStatusProposta.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatusProposta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusProposta.Caption = "Status";
            this.colStatusProposta.FieldName = "StatusVenda";
            this.colStatusProposta.Name = "colStatusProposta";
            this.colStatusProposta.OptionsColumn.AllowEdit = false;
            this.colStatusProposta.Visible = true;
            this.colStatusProposta.VisibleIndex = 5;
            this.colStatusProposta.Width = 127;
            // 
            // colDesconto
            // 
            this.colDesconto.AppearanceCell.Options.UseTextOptions = true;
            this.colDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDesconto.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colDesconto.AppearanceHeader.Options.UseTextOptions = true;
            this.colDesconto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDesconto.FieldName = "Desconto";
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.OptionsColumn.AllowEdit = false;
            this.colDesconto.Width = 40;
            // 
            // colNomeCliFor
            // 
            this.colNomeCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colNomeCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeCliFor.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colNomeCliFor.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeCliFor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeCliFor.Caption = "Nome do Cliente";
            this.colNomeCliFor.FieldName = "CliFor.RazaoSocial";
            this.colNomeCliFor.Name = "colNomeCliFor";
            this.colNomeCliFor.OptionsColumn.AllowEdit = false;
            this.colNomeCliFor.Visible = true;
            this.colNomeCliFor.VisibleIndex = 1;
            this.colNomeCliFor.Width = 232;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.AllowEdit = false;
            this.colUsuario.Width = 40;
            // 
            // colIdFormaPagamentoVenda
            // 
            this.colIdFormaPagamentoVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFormaPagamentoVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFormaPagamentoVenda.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colIdFormaPagamentoVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFormaPagamentoVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFormaPagamentoVenda.Caption = "Forma Pagamento";
            this.colIdFormaPagamentoVenda.FieldName = "FormaPagamentoVenda.NomeFormaPagamento";
            this.colIdFormaPagamentoVenda.Name = "colIdFormaPagamentoVenda";
            this.colIdFormaPagamentoVenda.OptionsColumn.AllowEdit = false;
            this.colIdFormaPagamentoVenda.Visible = true;
            this.colIdFormaPagamentoVenda.VisibleIndex = 4;
            this.colIdFormaPagamentoVenda.Width = 133;
            // 
            // colDataPagamento
            // 
            this.colDataPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataPagamento.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.colDataPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataPagamento.Caption = "Dt. Vencimento";
            this.colDataPagamento.FieldName = "DataVencimento";
            this.colDataPagamento.Name = "colDataPagamento";
            this.colDataPagamento.Visible = true;
            this.colDataPagamento.VisibleIndex = 3;
            this.colDataPagamento.Width = 113;
            // 
            // lblTotalDesconto
            // 
            this.lblTotalDesconto.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalDesconto.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDesconto.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalDesconto.Location = new System.Drawing.Point(83, 37);
            this.lblTotalDesconto.Name = "lblTotalDesconto";
            this.lblTotalDesconto.Size = new System.Drawing.Size(80, 25);
            this.lblTotalDesconto.TabIndex = 7;
            this.lblTotalDesconto.Text = "R$ 0,00";
            this.lblTotalDesconto.ToolTip = "Total de desconto aplicado";
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalVendas.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalVendas.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalVendas.Location = new System.Drawing.Point(83, 37);
            this.lblTotalVendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(80, 25);
            this.lblTotalVendas.TabIndex = 5;
            this.lblTotalVendas.Text = "R$ 0,00";
            this.lblTotalVendas.ToolTip = "Faturamento Total";
            // 
            // lblTotalVendasPrazo
            // 
            this.lblTotalVendasPrazo.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalVendasPrazo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotalVendasPrazo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalVendasPrazo.Location = new System.Drawing.Point(83, 37);
            this.lblTotalVendasPrazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalVendasPrazo.Name = "lblTotalVendasPrazo";
            this.lblTotalVendasPrazo.Size = new System.Drawing.Size(80, 25);
            this.lblTotalVendasPrazo.TabIndex = 3;
            this.lblTotalVendasPrazo.Text = "R$ 0,00";
            this.lblTotalVendasPrazo.ToolTip = "Total de vendas á prazo";
            // 
            // lblTotalVendasAvista
            // 
            this.lblTotalVendasAvista.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalVendasAvista.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalVendasAvista.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalVendasAvista.Location = new System.Drawing.Point(83, 37);
            this.lblTotalVendasAvista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalVendasAvista.Name = "lblTotalVendasAvista";
            this.lblTotalVendasAvista.Size = new System.Drawing.Size(80, 25);
            this.lblTotalVendasAvista.TabIndex = 2;
            this.lblTotalVendasAvista.Text = "R$ 0,00";
            this.lblTotalVendasAvista.ToolTip = "Total de vendas em dinheiro";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(861, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 574);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(861, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 574);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(861, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 574);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImage = global::ITE.Vendas.Properties.Resources.simbol_money32x32;
            this.groupControl1.Controls.Add(this.lblTotalVendasAvista);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(165, 90);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Á Vista";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSomatorio1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(861, 574);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl4, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(855, 94);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImage")));
            this.groupControl3.Controls.Add(this.lblTotalDesconto);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(345, 2);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(165, 90);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Desconto";
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl5.CaptionImage")));
            this.groupControl5.Controls.Add(this.lblTotalLiquido);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(516, 2);
            this.groupControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(165, 90);
            this.groupControl5.TabIndex = 6;
            this.groupControl5.Text = "Liquído";
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalLiquido.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTotalLiquido.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalLiquido.Location = new System.Drawing.Point(83, 37);
            this.lblTotalLiquido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(80, 25);
            superToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem1.Text = "Faturamento real sobre vendas";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "( + ) Soma: Preço de Venda\r\n( - ) Soma: Preço de Compra\r\n( - ) <u>Soma: Desconto " +
    "sobre vendas</u>\r\n\r\n<b>( = ) Total Líquido</b>\r\n\r\n";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.lblTotalLiquido.SuperTip = superToolTip1;
            this.lblTotalLiquido.TabIndex = 6;
            this.lblTotalLiquido.Text = "R$ 0,00";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.lblTotalVendasPrazo);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(174, 2);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(165, 90);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Á Prazo";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImage")));
            this.groupControl4.Controls.Add(this.lblTotalVendas);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(687, 2);
            this.groupControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(165, 90);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Total";
            // 
            // panelSomatorio1
            // 
            this.panelSomatorio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSomatorio1.Location = new System.Drawing.Point(3, 547);
            this.panelSomatorio1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSomatorio1.Name = "panelSomatorio1";
            this.panelSomatorio1.Size = new System.Drawing.Size(855, 25);
            this.panelSomatorio1.TabIndex = 1;
            // 
            // XFrmProducaoVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmProducaoVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produção de Vendas:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.XFrmProducao_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmProducao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSomatorio1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource bsVenda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVendas;
        private DevExpress.XtraEditors.LabelControl lblTotalVendas;
        private DevExpress.XtraEditors.LabelControl lblTotalVendasPrazo;
        private DevExpress.XtraEditors.LabelControl lblTotalVendasAvista;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colParcelasVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colDataProposta;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProposta;
        private DevExpress.XtraGrid.Columns.GridColumn colValorDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroParcelas;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroItens;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusProposta;
        private DevExpress.XtraGrid.Columns.GridColumn colDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPagamentoVenda;
        private DevExpress.XtraEditors.LabelControl lblTotalDesconto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colDataPagamento;
        private PanelSum panelSomatorio1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl lblTotalLiquido;
    }
}