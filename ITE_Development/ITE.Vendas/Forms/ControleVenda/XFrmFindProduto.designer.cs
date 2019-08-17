using ITSolution.Framework.Components;

namespace ITE.Vendas.Forms.ControleVenda
{
    partial class XFrmFindProduto
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmFindProduto));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator1 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.bsProduto = new System.Windows.Forms.BindingSource();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControlProdutos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProdutos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadeMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMargemLucro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFotoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategoriaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadeMedidaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItensEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItensVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistoricoPrecoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlteracoesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblDescricaoProduto = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSelecionarNow = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigoBarrasProduto = new ITSolution.Framework.Components.TextCodigoBarras();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.btnSelecionar = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarrasProduto.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsProduto
            // 
            this.bsProduto.DataSource = typeof(ITE.Entidades.POCO.Sales.Produto);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.searchControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 161);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1033, 44);
            this.panelControl1.TabIndex = 9;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControlProdutos;
            this.searchControl1.Location = new System.Drawing.Point(9, 5);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.searchControl1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton("", -1, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, false, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Repository.MRUButton()});
            this.searchControl1.Properties.Client = this.gridControlProdutos;
            this.searchControl1.Properties.FindDelay = 5000;
            this.searchControl1.Properties.NullValuePrompt = "Digite aqui o nome mais próximo do produto...";
            this.searchControl1.Properties.ShowMRUButton = true;
            this.searchControl1.Size = new System.Drawing.Size(478, 30);
            this.searchControl1.TabIndex = 1;
            this.searchControl1.ToolTip = "Digite aqui o nome do produto";
            this.searchControl1.EditValueChanged += new System.EventHandler(this.searchControl1_EditValueChanged);
            this.searchControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchControl1_PreviewKeyDown);
            // 
            // gridControlProdutos
            // 
            this.gridControlProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProdutos.DataSource = this.bsProduto;
            this.gridControlProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProdutos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlProdutos.Location = new System.Drawing.Point(3, 211);
            this.gridControlProdutos.MainView = this.gridViewProdutos;
            this.gridControlProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlProdutos.Name = "gridControlProdutos";
            this.gridControlProdutos.Size = new System.Drawing.Size(1033, 402);
            this.gridControlProdutos.TabIndex = 2;
            this.gridControlProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProdutos,
            this.gridView1});
            // 
            // gridViewProdutos
            // 
            this.gridViewProdutos.Appearance.FixedLine.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridViewProdutos.Appearance.FixedLine.Options.UseFont = true;
            this.gridViewProdutos.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewProdutos.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewProdutos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F);
            this.gridViewProdutos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewProdutos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProduto,
            this.colQuantidadeProduto,
            this.colDescricaoProduto,
            this.colPrecoVenda,
            this.colUnidadeMedida,
            this.colCategoriaProduto,
            this.colCodigoBarra,
            this.colMargemLucro,
            this.colStatusProduto,
            this.colFotoProduto,
            this.colPrecoCompra,
            this.colObservacao,
            this.colIdCategoriaProduto,
            this.colIdUnidadeMedidaProduto,
            this.colItensEntrada,
            this.colItensVenda,
            this.colHistoricoPrecoProduto,
            this.colAlteracoesProduto});
            this.gridViewProdutos.GridControl = this.gridControlProdutos;
            this.gridViewProdutos.Name = "gridViewProdutos";
            this.gridViewProdutos.OptionsView.ShowGroupPanel = false;
            this.gridViewProdutos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDescricaoProduto, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewProdutos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProdutosVenda_FocusedRowChanged);
            this.gridViewProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProdutos_KeyDown);
            this.gridViewProdutos.DoubleClick += new System.EventHandler(this.gridViewProdutos_DoubleClick);
            // 
            // colIdProduto
            // 
            this.colIdProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdProduto.Caption = "Código Barras";
            this.colIdProduto.FieldName = "CodigoBarras";
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.OptionsColumn.AllowEdit = false;
            this.colIdProduto.OptionsColumn.AllowShowHide = false;
            this.colIdProduto.Visible = true;
            this.colIdProduto.VisibleIndex = 0;
            this.colIdProduto.Width = 150;
            // 
            // colQuantidadeProduto
            // 
            this.colQuantidadeProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidadeProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadeProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidadeProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadeProduto.Caption = "Quantidade";
            this.colQuantidadeProduto.DisplayFormat.FormatString = "N3";
            this.colQuantidadeProduto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantidadeProduto.FieldName = "QuantidadeProduto";
            this.colQuantidadeProduto.Name = "colQuantidadeProduto";
            this.colQuantidadeProduto.OptionsColumn.AllowEdit = false;
            this.colQuantidadeProduto.OptionsColumn.AllowShowHide = false;
            this.colQuantidadeProduto.Visible = true;
            this.colQuantidadeProduto.VisibleIndex = 3;
            this.colQuantidadeProduto.Width = 117;
            // 
            // colDescricaoProduto
            // 
            this.colDescricaoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricaoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoProduto.Caption = "Descrição";
            this.colDescricaoProduto.FieldName = "DescricaoProduto";
            this.colDescricaoProduto.Name = "colDescricaoProduto";
            this.colDescricaoProduto.OptionsColumn.AllowEdit = false;
            this.colDescricaoProduto.OptionsColumn.AllowShowHide = false;
            this.colDescricaoProduto.Visible = true;
            this.colDescricaoProduto.VisibleIndex = 1;
            this.colDescricaoProduto.Width = 514;
            // 
            // colPrecoVenda
            // 
            this.colPrecoVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecoVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoVenda.Caption = "Preço";
            this.colPrecoVenda.DisplayFormat.FormatString = "n2";
            this.colPrecoVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoVenda.FieldName = "PrecoVenda";
            this.colPrecoVenda.Name = "colPrecoVenda";
            this.colPrecoVenda.OptionsColumn.AllowEdit = false;
            this.colPrecoVenda.OptionsColumn.AllowShowHide = false;
            this.colPrecoVenda.Visible = true;
            this.colPrecoVenda.VisibleIndex = 4;
            this.colPrecoVenda.Width = 139;
            // 
            // colUnidadeMedida
            // 
            this.colUnidadeMedida.AppearanceCell.Options.UseTextOptions = true;
            this.colUnidadeMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidadeMedida.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidadeMedida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidadeMedida.Caption = "UN. Med";
            this.colUnidadeMedida.FieldName = "UnidadeMedida.NomeUnidadeMedida";
            this.colUnidadeMedida.Name = "colUnidadeMedida";
            this.colUnidadeMedida.OptionsColumn.AllowEdit = false;
            this.colUnidadeMedida.OptionsColumn.AllowShowHide = false;
            this.colUnidadeMedida.Visible = true;
            this.colUnidadeMedida.VisibleIndex = 2;
            this.colUnidadeMedida.Width = 93;
            // 
            // colCategoriaProduto
            // 
            this.colCategoriaProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colCategoriaProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCategoriaProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colCategoriaProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCategoriaProduto.Caption = "Categoria";
            this.colCategoriaProduto.FieldName = "CategoriaProduto.NomeCategoriaProduto";
            this.colCategoriaProduto.Name = "colCategoriaProduto";
            this.colCategoriaProduto.OptionsColumn.AllowEdit = false;
            this.colCategoriaProduto.OptionsColumn.AllowShowHide = false;
            // 
            // colCodigoBarra
            // 
            this.colCodigoBarra.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoBarra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoBarra.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoBarra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoBarra.FieldName = "CodigoBarras";
            this.colCodigoBarra.Name = "colCodigoBarra";
            this.colCodigoBarra.OptionsColumn.AllowEdit = false;
            this.colCodigoBarra.OptionsColumn.AllowShowHide = false;
            // 
            // colMargemLucro
            // 
            this.colMargemLucro.AppearanceCell.Options.UseTextOptions = true;
            this.colMargemLucro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMargemLucro.AppearanceHeader.Options.UseTextOptions = true;
            this.colMargemLucro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMargemLucro.FieldName = "MargemLucro";
            this.colMargemLucro.Name = "colMargemLucro";
            this.colMargemLucro.OptionsColumn.AllowEdit = false;
            this.colMargemLucro.OptionsColumn.AllowShowHide = false;
            // 
            // colStatusProduto
            // 
            this.colStatusProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colStatusProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatusProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusProduto.FieldName = "StatusProduto";
            this.colStatusProduto.Name = "colStatusProduto";
            this.colStatusProduto.OptionsColumn.AllowEdit = false;
            this.colStatusProduto.OptionsColumn.AllowShowHide = false;
            // 
            // colFotoProduto
            // 
            this.colFotoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colFotoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFotoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colFotoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFotoProduto.FieldName = "FotoProduto";
            this.colFotoProduto.Name = "colFotoProduto";
            this.colFotoProduto.OptionsColumn.AllowEdit = false;
            this.colFotoProduto.OptionsColumn.AllowShowHide = false;
            // 
            // colPrecoCompra
            // 
            this.colPrecoCompra.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoCompra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoCompra.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecoCompra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoCompra.FieldName = "PrecoCompra";
            this.colPrecoCompra.Name = "colPrecoCompra";
            this.colPrecoCompra.OptionsColumn.AllowEdit = false;
            this.colPrecoCompra.OptionsColumn.AllowShowHide = false;
            // 
            // colObservacao
            // 
            this.colObservacao.AppearanceCell.Options.UseTextOptions = true;
            this.colObservacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colObservacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.OptionsColumn.AllowEdit = false;
            this.colObservacao.OptionsColumn.AllowShowHide = false;
            // 
            // colIdCategoriaProduto
            // 
            this.colIdCategoriaProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCategoriaProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCategoriaProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCategoriaProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCategoriaProduto.FieldName = "IdCategoriaProduto";
            this.colIdCategoriaProduto.Name = "colIdCategoriaProduto";
            this.colIdCategoriaProduto.OptionsColumn.AllowEdit = false;
            this.colIdCategoriaProduto.OptionsColumn.AllowShowHide = false;
            // 
            // colIdUnidadeMedidaProduto
            // 
            this.colIdUnidadeMedidaProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdUnidadeMedidaProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUnidadeMedidaProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdUnidadeMedidaProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUnidadeMedidaProduto.FieldName = "IdUnidadeMedidaProduto";
            this.colIdUnidadeMedidaProduto.Name = "colIdUnidadeMedidaProduto";
            this.colIdUnidadeMedidaProduto.OptionsColumn.AllowEdit = false;
            this.colIdUnidadeMedidaProduto.OptionsColumn.AllowShowHide = false;
            // 
            // colItensEntrada
            // 
            this.colItensEntrada.AppearanceCell.Options.UseTextOptions = true;
            this.colItensEntrada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItensEntrada.AppearanceHeader.Options.UseTextOptions = true;
            this.colItensEntrada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItensEntrada.FieldName = "ItensEntrada";
            this.colItensEntrada.Name = "colItensEntrada";
            this.colItensEntrada.OptionsColumn.AllowEdit = false;
            this.colItensEntrada.OptionsColumn.AllowShowHide = false;
            // 
            // colItensVenda
            // 
            this.colItensVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colItensVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItensVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colItensVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItensVenda.FieldName = "ItensVenda";
            this.colItensVenda.Name = "colItensVenda";
            this.colItensVenda.OptionsColumn.AllowEdit = false;
            this.colItensVenda.OptionsColumn.AllowShowHide = false;
            // 
            // colHistoricoPrecoProduto
            // 
            this.colHistoricoPrecoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colHistoricoPrecoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoPrecoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistoricoPrecoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoPrecoProduto.FieldName = "HistoricoPrecoProduto";
            this.colHistoricoPrecoProduto.Name = "colHistoricoPrecoProduto";
            this.colHistoricoPrecoProduto.OptionsColumn.AllowEdit = false;
            this.colHistoricoPrecoProduto.OptionsColumn.AllowShowHide = false;
            // 
            // colAlteracoesProduto
            // 
            this.colAlteracoesProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colAlteracoesProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAlteracoesProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colAlteracoesProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAlteracoesProduto.FieldName = "AlteracoesProduto";
            this.colAlteracoesProduto.Name = "colAlteracoesProduto";
            this.colAlteracoesProduto.OptionsColumn.AllowEdit = false;
            this.colAlteracoesProduto.OptionsColumn.AllowShowHide = false;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Underline);
            this.lblDescricaoProduto.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDescricaoProduto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDescricaoProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(3, 619);
            this.lblDescricaoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(162, 36);
            this.lblDescricaoProduto.TabIndex = 5;
            this.lblDescricaoProduto.Text = "%Produto%";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlProdutos;
            this.gridView1.Name = "gridView1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnSelecionarNow);
            this.panel1.Controls.Add(this.txtCodigoBarrasProduto);
            this.panel1.Controls.Add(this.barCodeControl1);
            this.panel1.Controls.Add(this.btnSelecionar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 155);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Location = new System.Drawing.Point(380, 6);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(241, 33);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Consulta de Produto";
            // 
            // btnSelecionarNow
            // 
            this.btnSelecionarNow.AutoSize = true;
            this.btnSelecionarNow.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSelecionarNow.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarNow.Image")));
            this.btnSelecionarNow.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSelecionarNow.Location = new System.Drawing.Point(761, 44);
            this.btnSelecionarNow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionarNow.Name = "btnSelecionarNow";
            this.btnSelecionarNow.Size = new System.Drawing.Size(49, 47);
            toolTipTitleItem1.Text = "Inclui o item selecionado na venda.";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Utilize o \"*\" para alterar a quantidade\r\nEx: 2*123456789\r\n\r\nSeleciona o item e pe" +
    "rmace na tela de consulta";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnSelecionarNow.SuperTip = superToolTip1;
            this.btnSelecionarNow.TabIndex = 5;
            this.btnSelecionarNow.Click += new System.EventHandler(this.btnSelecionarNow_Click);
            // 
            // txtCodigoBarrasProduto
            // 
            this.txtCodigoBarrasProduto.CaracteresRestritos = new char[0];
            this.txtCodigoBarrasProduto.EditValue = "0000000000";
            this.txtCodigoBarrasProduto.Location = new System.Drawing.Point(273, 46);
            this.txtCodigoBarrasProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoBarrasProduto.Name = "txtCodigoBarrasProduto";
            this.txtCodigoBarrasProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtCodigoBarrasProduto.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoBarrasProduto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigoBarrasProduto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCodigoBarrasProduto.Properties.MaxLength = 50;
            this.txtCodigoBarrasProduto.Size = new System.Drawing.Size(421, 42);
            toolTipTitleItem2.Appearance.Options.UseImage = true;
            toolTipTitleItem2.Text = "Código de Barras do Produto";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Utilize o leitor de código de barras ou faça uma pesquisa manual pelos critérios " +
    "das colunas da tabela.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.txtCodigoBarrasProduto.SuperTip = superToolTip2;
            this.txtCodigoBarrasProduto.TabIndex = 0;
            this.txtCodigoBarrasProduto.ToolTip = "Código de Barras do Produto";
            this.txtCodigoBarrasProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarrasProduto_KeyDown);
            this.txtCodigoBarrasProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarrras_KeyUp);
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barCodeControl1.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.Location = new System.Drawing.Point(273, 94);
            this.barCodeControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(12, 2, 12, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(421, 42);
            this.barCodeControl1.Symbology = eaN13Generator1;
            this.barCodeControl1.TabIndex = 35;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.AutoSize = true;
            this.btnSelecionar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionar.Image")));
            this.btnSelecionar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSelecionar.Location = new System.Drawing.Point(705, 44);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(49, 47);
            toolTipTitleItem3.Text = "Inclui o item selecionado na venda.";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Utilize o \"*\" para alterar a quantidade\r\nEx: 2*123456789\r\n\r\nSeleciona o item e re" +
    "torna a venda";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnSelecionar.SuperTip = superToolTip3;
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControlProdutos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDescricaoProduto, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1039, 622);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // XFrmFindProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 622);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "XFrmFindProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XFrmFindProduto_FormClosing);
            this.Shown += new System.EventHandler(this.XFrmFindProduto_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarrasProduto.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsProduto;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl gridControlProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdutos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadeMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colMargemLucro;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colFotoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoriaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadeMedidaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colItensEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colItensVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricoPrecoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colAlteracoesProduto;
        private DevExpress.XtraEditors.LabelControl lblDescricaoProduto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelecionarNow;
        private TextCodigoBarras txtCodigoBarrasProduto;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelecionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}