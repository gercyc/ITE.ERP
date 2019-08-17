namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmProdutoSemEstoque
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
            this.gridControlProduto = new DevExpress.XtraGrid.GridControl();
            this.bsProduto = new System.Windows.Forms.BindingSource();
            this.gridViewProduto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadeMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMargemLucro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFotoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategoriaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadeMedidaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItensEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItensVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistoricoPrecoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlteracoesProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProduto
            // 
            this.gridControlProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProduto.DataSource = this.bsProduto;
            this.gridControlProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProduto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlProduto.Location = new System.Drawing.Point(0, 0);
            this.gridControlProduto.MainView = this.gridViewProduto;
            this.gridControlProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlProduto.Name = "gridControlProduto";
            this.gridControlProduto.Size = new System.Drawing.Size(1037, 609);
            this.gridControlProduto.TabIndex = 0;
            this.gridControlProduto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProduto});
            // 
            // bsProduto
            // 
            this.bsProduto.DataSource = typeof(ITE.Entidades.POCO.Sales.Produto);
            // 
            // gridViewProduto
            // 
            this.gridViewProduto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProduto,
            this.colCodigoBarra,
            this.colDescricaoProduto,
            this.colPrecoCompra,
            this.colPrecoVenda,
            this.colQuantidadeProduto,
            this.colCategoriaProduto,
            this.colUnidadeMedida,
            this.colMargemLucro,
            this.colStatusProduto,
            this.colFotoProduto,
            this.colObservacao,
            this.colIdCategoriaProduto,
            this.colIdUnidadeMedidaProduto,
            this.colItensEntrada,
            this.colItensVenda,
            this.colHistoricoPrecoProduto,
            this.colAlteracoesProduto});
            this.gridViewProduto.GridControl = this.gridControlProduto;
            this.gridViewProduto.Name = "gridViewProduto";
            this.gridViewProduto.OptionsView.ShowFooter = true;
            this.gridViewProduto.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProduto
            // 
            this.colIdProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdProduto.FieldName = "IdProduto";
            this.colIdProduto.Name = "colIdProduto";
            // 
            // colCodigoBarra
            // 
            this.colCodigoBarra.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoBarra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoBarra.FieldName = "CodigoBarras";
            this.colCodigoBarra.Name = "colCodigoBarra";
            // 
            // colDescricaoProduto
            // 
            this.colDescricaoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoProduto.Caption = "Descrição";
            this.colDescricaoProduto.FieldName = "DescricaoProduto";
            this.colDescricaoProduto.Name = "colDescricaoProduto";
            this.colDescricaoProduto.Visible = true;
            this.colDescricaoProduto.VisibleIndex = 0;
            this.colDescricaoProduto.Width = 547;
            // 
            // colPrecoCompra
            // 
            this.colPrecoCompra.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoCompra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoCompra.Caption = "Preço Compra";
            this.colPrecoCompra.DisplayFormat.FormatString = "c2";
            this.colPrecoCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoCompra.FieldName = "PrecoCompra";
            this.colPrecoCompra.Name = "colPrecoCompra";
            this.colPrecoCompra.Width = 149;
            // 
            // colPrecoVenda
            // 
            this.colPrecoVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colPrecoVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colPrecoVenda.Caption = "Preço Venda";
            this.colPrecoVenda.DisplayFormat.FormatString = "c2";
            this.colPrecoVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrecoVenda.FieldName = "PrecoVenda";
            this.colPrecoVenda.Name = "colPrecoVenda";
            this.colPrecoVenda.Visible = true;
            this.colPrecoVenda.VisibleIndex = 4;
            this.colPrecoVenda.Width = 182;
            // 
            // colQuantidadeProduto
            // 
            this.colQuantidadeProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidadeProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadeProduto.Caption = "Quantidade";
            this.colQuantidadeProduto.FieldName = "QuantidadeProduto";
            this.colQuantidadeProduto.Name = "colQuantidadeProduto";
            this.colQuantidadeProduto.Visible = true;
            this.colQuantidadeProduto.VisibleIndex = 2;
            this.colQuantidadeProduto.Width = 76;
            // 
            // colCategoriaProduto
            // 
            this.colCategoriaProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colCategoriaProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCategoriaProduto.Caption = "Categoria";
            this.colCategoriaProduto.FieldName = "CategoriaProduto.NomeCategoriaProduto";
            this.colCategoriaProduto.Name = "colCategoriaProduto";
            this.colCategoriaProduto.Visible = true;
            this.colCategoriaProduto.VisibleIndex = 3;
            this.colCategoriaProduto.Width = 131;
            // 
            // colUnidadeMedida
            // 
            this.colUnidadeMedida.AppearanceCell.Options.UseTextOptions = true;
            this.colUnidadeMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidadeMedida.Caption = "UN. Medida";
            this.colUnidadeMedida.FieldName = "UnidadeMedida.NomeUnidadeMedida";
            this.colUnidadeMedida.Name = "colUnidadeMedida";
            this.colUnidadeMedida.Visible = true;
            this.colUnidadeMedida.VisibleIndex = 1;
            this.colUnidadeMedida.Width = 81;
            // 
            // colMargemLucro
            // 
            this.colMargemLucro.AppearanceCell.Options.UseTextOptions = true;
            this.colMargemLucro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMargemLucro.FieldName = "MargemLucro";
            this.colMargemLucro.Name = "colMargemLucro";
            // 
            // colStatusProduto
            // 
            this.colStatusProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colStatusProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusProduto.FieldName = "StatusProduto";
            this.colStatusProduto.Name = "colStatusProduto";
            // 
            // colFotoProduto
            // 
            this.colFotoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colFotoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFotoProduto.FieldName = "FotoProduto";
            this.colFotoProduto.Name = "colFotoProduto";
            // 
            // colObservacao
            // 
            this.colObservacao.AppearanceCell.Options.UseTextOptions = true;
            this.colObservacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            // 
            // colIdCategoriaProduto
            // 
            this.colIdCategoriaProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCategoriaProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCategoriaProduto.FieldName = "IdCategoriaProduto";
            this.colIdCategoriaProduto.Name = "colIdCategoriaProduto";
            // 
            // colIdUnidadeMedidaProduto
            // 
            this.colIdUnidadeMedidaProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdUnidadeMedidaProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUnidadeMedidaProduto.FieldName = "IdUnidadeMedidaProduto";
            this.colIdUnidadeMedidaProduto.Name = "colIdUnidadeMedidaProduto";
            // 
            // colItensEntrada
            // 
            this.colItensEntrada.AppearanceCell.Options.UseTextOptions = true;
            this.colItensEntrada.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItensEntrada.FieldName = "ItensEntrada";
            this.colItensEntrada.Name = "colItensEntrada";
            // 
            // colItensVenda
            // 
            this.colItensVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colItensVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItensVenda.FieldName = "ItensVenda";
            this.colItensVenda.Name = "colItensVenda";
            // 
            // colHistoricoPrecoProduto
            // 
            this.colHistoricoPrecoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colHistoricoPrecoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistoricoPrecoProduto.FieldName = "HistoricoPrecoProduto";
            this.colHistoricoPrecoProduto.Name = "colHistoricoPrecoProduto";
            // 
            // colAlteracoesProduto
            // 
            this.colAlteracoesProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colAlteracoesProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAlteracoesProduto.FieldName = "AlteracoesProduto";
            this.colAlteracoesProduto.Name = "colAlteracoesProduto";
            // 
            // XFrmProdutoSemEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 609);
            this.Controls.Add(this.gridControlProduto);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmProdutoSemEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos sem estoque:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.XFrmInfoProdutoDefasado_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmInfoProdutoSemEstoque_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProduto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProduto;
        private System.Windows.Forms.BindingSource bsProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarra;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colMargemLucro;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colFotoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoriaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadeMedidaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadeMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colItensEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colItensVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colHistoricoPrecoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colAlteracoesProduto;
    }
}