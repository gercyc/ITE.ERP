
namespace ITE.Vendas.Forms.ControleVenda
{
    partial class XFrmItensProposta
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
            this.gridControlItensVenda = new DevExpress.XtraGrid.GridControl();
            this.bsItensVenda = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewItensVenda = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProdutoVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalItem = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlItensVenda
            // 
            this.gridControlItensVenda.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlItensVenda.DataSource = this.bsItensVenda;
            this.gridControlItensVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlItensVenda.Location = new System.Drawing.Point(0, 0);
            this.gridControlItensVenda.MainView = this.gridViewItensVenda;
            this.gridControlItensVenda.Name = "gridControlItensVenda";
            this.gridControlItensVenda.Size = new System.Drawing.Size(718, 370);
            this.gridControlItensVenda.TabIndex = 0;
            this.gridControlItensVenda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItensVenda});
            this.gridControlItensVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // bsItensVenda
            // 
            this.bsItensVenda.DataSource = typeof(ITE.Entidades.POCO.Sales.ItemVenda);
            // 
            // gridViewItensVenda
            // 
            this.gridViewItensVenda.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewItensVenda.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewItensVenda.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewItensVenda.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewItensVenda.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewItensVenda.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewItensVenda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProdutoVenda,
            this.colDescricaoProduto,
            this.colValorUnitario,
            this.colQuantidade,
            this.colTotalItem});
            this.gridViewItensVenda.GridControl = this.gridControlItensVenda;
            this.gridViewItensVenda.Name = "gridViewItensVenda";
            this.gridViewItensVenda.OptionsView.ShowFooter = true;
            this.gridViewItensVenda.OptionsView.ShowGroupPanel = false;
            this.gridViewItensVenda.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewItensVenda_CellValueChanged);
            // 
            // colIdProdutoVenda
            // 
            this.colIdProdutoVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colIdProdutoVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdProdutoVenda.Caption = "Código";
            this.colIdProdutoVenda.FieldName = "IdProduto";
            this.colIdProdutoVenda.Name = "colIdProdutoVenda";
            this.colIdProdutoVenda.OptionsColumn.AllowEdit = false;
            this.colIdProdutoVenda.OptionsColumn.AllowShowHide = false;
            this.colIdProdutoVenda.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdProduto", "{0}")});
            this.colIdProdutoVenda.Visible = true;
            this.colIdProdutoVenda.VisibleIndex = 0;
            this.colIdProdutoVenda.Width = 120;
            // 
            // colDescricaoProduto
            // 
            this.colDescricaoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoProduto.Caption = "Descrição";
            this.colDescricaoProduto.FieldName = "Produto.DescricaoProduto";
            this.colDescricaoProduto.Name = "colDescricaoProduto";
            this.colDescricaoProduto.OptionsColumn.AllowEdit = false;
            this.colDescricaoProduto.OptionsColumn.AllowShowHide = false;
            this.colDescricaoProduto.Visible = true;
            this.colDescricaoProduto.VisibleIndex = 1;
            this.colDescricaoProduto.Width = 321;
            // 
            // colValorUnitario
            // 
            this.colValorUnitario.AppearanceCell.Options.UseTextOptions = true;
            this.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorUnitario.Caption = "Valor Unitário";
            this.colValorUnitario.DisplayFormat.FormatString = "N2";
            this.colValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorUnitario.FieldName = "ValorUnitario";
            this.colValorUnitario.Name = "colValorUnitario";
            this.colValorUnitario.OptionsColumn.AllowShowHide = false;
            this.colValorUnitario.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorUnitario", "Total: {0:N2}")});
            this.colValorUnitario.Visible = true;
            this.colValorUnitario.VisibleIndex = 3;
            this.colValorUnitario.Width = 120;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidade.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidade.DisplayFormat.FormatString = "N3";
            this.colQuantidade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.OptionsColumn.AllowShowHide = false;
            this.colQuantidade.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantidade", "Total: {0:N3}")});
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 2;
            this.colQuantidade.Width = 120;
            // 
            // colTotalItem
            // 
            this.colTotalItem.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalItem.Caption = "Total";
            this.colTotalItem.DisplayFormat.FormatString = "N2";
            this.colTotalItem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalItem.FieldName = "TotalItem";
            this.colTotalItem.Name = "colTotalItem";
            this.colTotalItem.OptionsColumn.AllowEdit = false;
            this.colTotalItem.OptionsColumn.AllowShowHide = false;
            this.colTotalItem.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalItem", "Total: {0:N2}")});
            this.colTotalItem.Visible = true;
            this.colTotalItem.VisibleIndex = 4;
            this.colTotalItem.Width = 120;
            // 
            // XFrmItensProposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 370);
            this.Controls.Add(this.gridControlItensVenda);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "XFrmItensProposta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XFrmItensProposta_FormClosing);
            this.Shown += new System.EventHandler(this.XFrmItensVenda_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmItensVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItensVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlItensVenda;
        private System.Windows.Forms.BindingSource bsItensVenda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItensVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProdutoVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalItem;
    }
}