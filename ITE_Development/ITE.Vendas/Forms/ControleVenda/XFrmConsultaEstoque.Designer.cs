using ITE.Components.LookUp;

namespace ITE.Vendas.Forms.ControleVenda
{
    partial class XFrmConsultaEstoque
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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSaldoLoc = new DevExpress.XtraGrid.GridControl();
            this.gridViewSaldoLoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sldColLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sldColQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sldColValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSaldoFisico2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecoMedioVendas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustoMedio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldoEstoque = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rdTipoProduto = new DevExpress.XtraEditors.RadioGroup();
            this.txtCategoria = new DevExpress.XtraEditors.TextEdit();
            this.lookUpProduto1 = new LookUpProduto();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlEntradas = new DevExpress.XtraGrid.GridControl();
            this.bsTransacoesProduto = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEntradas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDataTransacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlSaidas = new DevExpress.XtraGrid.GridControl();
            this.gridViewSaidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navigationPane1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsTransacoesProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSaidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowCollapseButton = false;
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(704, 484);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.SelectedPageIndex = 0;
            this.navigationPane1.Size = new System.Drawing.Size(704, 484);
            this.navigationPane1.TabIndex = 4;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Saldos e custos";
            this.navigationPage1.Controls.Add(this.groupControl3);
            this.navigationPage1.Controls.Add(this.txtSaldoFisico2);
            this.navigationPage1.Controls.Add(this.labelControl9);
            this.navigationPage1.Controls.Add(this.txtPrecoMedioVendas);
            this.navigationPage1.Controls.Add(this.labelControl5);
            this.navigationPage1.Controls.Add(this.txtCustoMedio);
            this.navigationPage1.Controls.Add(this.labelControl4);
            this.navigationPage1.Controls.Add(this.txtSaldoEstoque);
            this.navigationPage1.Controls.Add(this.labelControl1);
            this.navigationPage1.Controls.Add(this.rdTipoProduto);
            this.navigationPage1.Controls.Add(this.txtCategoria);
            this.navigationPage1.Controls.Add(this.lookUpProduto1);
            this.navigationPage1.Controls.Add(this.labelControl3);
            this.navigationPage1.Controls.Add(this.labelControl2);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(596, 438);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControlSaldoLoc);
            this.groupControl3.Location = new System.Drawing.Point(248, 175);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(333, 122);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "Saldo por local de estoque";
            // 
            // gridControlSaldoLoc
            // 
            this.gridControlSaldoLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSaldoLoc.Location = new System.Drawing.Point(2, 20);
            this.gridControlSaldoLoc.MainView = this.gridViewSaldoLoc;
            this.gridControlSaldoLoc.Name = "gridControlSaldoLoc";
            this.gridControlSaldoLoc.Size = new System.Drawing.Size(329, 100);
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
            this.txtSaldoFisico2.Location = new System.Drawing.Point(389, 140);
            this.txtSaldoFisico2.Name = "txtSaldoFisico2";
            this.txtSaldoFisico2.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoFisico2.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(389, 121);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Saldo físico geral:";
            // 
            // txtPrecoMedioVendas
            // 
            this.txtPrecoMedioVendas.Location = new System.Drawing.Point(389, 95);
            this.txtPrecoMedioVendas.Name = "txtPrecoMedioVendas";
            this.txtPrecoMedioVendas.Size = new System.Drawing.Size(145, 20);
            this.txtPrecoMedioVendas.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(389, 76);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Preço médio de vendas:";
            // 
            // txtCustoMedio
            // 
            this.txtCustoMedio.Location = new System.Drawing.Point(13, 95);
            this.txtCustoMedio.Name = "txtCustoMedio";
            this.txtCustoMedio.Size = new System.Drawing.Size(145, 20);
            this.txtCustoMedio.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 76);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Custo médio aquisição:";
            // 
            // txtSaldoEstoque
            // 
            this.txtSaldoEstoque.Location = new System.Drawing.Point(13, 277);
            this.txtSaldoEstoque.Name = "txtSaldoEstoque";
            this.txtSaldoEstoque.Size = new System.Drawing.Size(203, 20);
            this.txtSaldoEstoque.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 258);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Saldo em estoque:";
            // 
            // rdTipoProduto
            // 
            this.rdTipoProduto.Location = new System.Drawing.Point(13, 194);
            this.rdTipoProduto.Name = "rdTipoProduto";
            this.rdTipoProduto.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Produto"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Serviço")});
            this.rdTipoProduto.Size = new System.Drawing.Size(203, 27);
            this.rdTipoProduto.TabIndex = 5;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(13, 140);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(145, 20);
            this.txtCategoria.TabIndex = 2;
            // 
            // lookUpProduto1
            // 
            this.lookUpProduto1.Enabled = false;
            this.lookUpProduto1.LabelText = "Produto:";
            this.lookUpProduto1.LabelTextFont = null;
            this.lookUpProduto1.Location = new System.Drawing.Point(13, 9);
            this.lookUpProduto1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpProduto1.Name = "lookUpProduto1";
            this.lookUpProduto1.Produto = null;
            this.lookUpProduto1.ReadOnly = false;
            this.lookUpProduto1.Size = new System.Drawing.Size(521, 53);
            this.lookUpProduto1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 175);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tipo produto:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Categoria:";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Movimentações";
            this.navigationPage2.Controls.Add(this.splitContainerControl1);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(596, 438);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(596, 438);
            this.splitContainerControl1.SplitterPosition = 205;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlEntradas);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(596, 205);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Entradas";
            // 
            // gridControlEntradas
            // 
            this.gridControlEntradas.DataSource = this.bsTransacoesProduto;
            this.gridControlEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEntradas.Location = new System.Drawing.Point(2, 20);
            this.gridControlEntradas.MainView = this.gridViewEntradas;
            this.gridControlEntradas.Name = "gridControlEntradas";
            this.gridControlEntradas.Size = new System.Drawing.Size(592, 183);
            this.gridControlEntradas.TabIndex = 0;
            this.gridControlEntradas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEntradas});
            // 
            // bsTransacoesProduto
            // 
            this.bsTransacoesProduto.DataSource = typeof(ITE.Entidades.POCO.Sales.TransacoesProduto);
            // 
            // gridViewEntradas
            // 
            this.gridViewEntradas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDataTransacao,
            this.colValorTotal,
            this.colQuantidade,
            this.colObservacao,
            this.colIdVenda,
            this.colLocalEstoque,
            this.colMovimento});
            this.gridViewEntradas.GridControl = this.gridControlEntradas;
            this.gridViewEntradas.Name = "gridViewEntradas";
            this.gridViewEntradas.OptionsBehavior.Editable = false;
            this.gridViewEntradas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewEntradas.OptionsView.ColumnAutoWidth = false;
            this.gridViewEntradas.OptionsView.ShowFooter = true;
            this.gridViewEntradas.OptionsView.ShowGroupPanel = false;
            // 
            // colDataTransacao
            // 
            this.colDataTransacao.Caption = "Data";
            this.colDataTransacao.FieldName = "DataTransacao";
            this.colDataTransacao.Name = "colDataTransacao";
            this.colDataTransacao.Visible = true;
            this.colDataTransacao.VisibleIndex = 0;
            // 
            // colValorTotal
            // 
            this.colValorTotal.Caption = "Valor";
            this.colValorTotal.FieldName = "ValorTotal";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.Visible = true;
            this.colValorTotal.VisibleIndex = 2;
            this.colValorTotal.Width = 92;
            // 
            // colQuantidade
            // 
            this.colQuantidade.Caption = "Quantidade";
            this.colQuantidade.DisplayFormat.FormatString = "N2";
            this.colQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantidade", "Entradas: {0:0.##}")});
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 3;
            this.colQuantidade.Width = 135;
            // 
            // colObservacao
            // 
            this.colObservacao.Caption = "Observação";
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 4;
            this.colObservacao.Width = 128;
            // 
            // colIdVenda
            // 
            this.colIdVenda.Caption = "Nº Venda";
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.Visible = true;
            this.colIdVenda.VisibleIndex = 5;
            // 
            // colLocalEstoque
            // 
            this.colLocalEstoque.Caption = "Local de Estoque";
            this.colLocalEstoque.FieldName = "LocalEstoque.CodigoLocalEstoque";
            this.colLocalEstoque.Name = "colLocalEstoque";
            this.colLocalEstoque.Visible = true;
            this.colLocalEstoque.VisibleIndex = 1;
            this.colLocalEstoque.Width = 101;
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
            this.groupControl2.Size = new System.Drawing.Size(596, 228);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Saídas";
            // 
            // gridControlSaidas
            // 
            this.gridControlSaidas.DataSource = this.bsTransacoesProduto;
            this.gridControlSaidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSaidas.Location = new System.Drawing.Point(2, 20);
            this.gridControlSaidas.MainView = this.gridViewSaidas;
            this.gridControlSaidas.Name = "gridControlSaidas";
            this.gridControlSaidas.Size = new System.Drawing.Size(592, 206);
            this.gridControlSaidas.TabIndex = 0;
            this.gridControlSaidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSaidas});
            // 
            // gridViewSaidas
            // 
            this.gridViewSaidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridViewSaidas.GridControl = this.gridControlSaidas;
            this.gridViewSaidas.Name = "gridViewSaidas";
            this.gridViewSaidas.OptionsBehavior.Editable = false;
            this.gridViewSaidas.OptionsView.ColumnAutoWidth = false;
            this.gridViewSaidas.OptionsView.ShowFooter = true;
            this.gridViewSaidas.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn3.FieldName = "Quantidade";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantidade", "Saídas: {0:0.##}")});
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
            this.gridColumn4.Width = 129;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nº Venda";
            this.gridColumn5.FieldName = "IdVenda";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Local de Estoque";
            this.gridColumn6.FieldName = "LocalEstoque.CodigoLocalEstoque";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 101;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Nº Mov.";
            this.gridColumn7.FieldName = "Movimento.NumeroMovimento";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 133;
            // 
            // XFrmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 484);
            this.Controls.Add(this.navigationPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "XFrmConsultaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de saldos e custos: ";
            this.navigationPane1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.bsTransacoesProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSaidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSaidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlEntradas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntradas;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlSaidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSaidas;
        private DevExpress.XtraEditors.TextEdit txtPrecoMedioVendas;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCustoMedio;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSaldoEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup rdTipoProduto;
        private DevExpress.XtraEditors.TextEdit txtCategoria;
        private LookUpProduto lookUpProduto1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource bsTransacoesProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colDataTransacao;
        private DevExpress.XtraGrid.Columns.GridColumn colValorTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.TextEdit txtSaldoFisico2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.GridControl gridControlSaldoLoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSaldoLoc;
        private DevExpress.XtraGrid.Columns.GridColumn sldColLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn sldColQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn sldColValor;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}