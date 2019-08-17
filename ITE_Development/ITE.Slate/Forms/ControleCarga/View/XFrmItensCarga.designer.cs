
namespace ITE.Slate.Forms.ControleCarga.View
{
    partial class XFrmItensCarga
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
            this.colIdMaterialItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetrosQuadrados = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadePecas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefugo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControlItensVenda.Size = new System.Drawing.Size(784, 462);
            this.gridControlItensVenda.TabIndex = 0;
            this.gridControlItensVenda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItensVenda});
            this.gridControlItensVenda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
            // 
            // bsItensVenda
            // 
            this.bsItensVenda.DataSource = typeof(ITE.Entidades.POCO.Ardosia.Minning.ItemOrdemCarga);
            // 
            // gridViewItensVenda
            // 
            this.gridViewItensVenda.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewItensVenda.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewItensVenda.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewItensVenda.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewItensVenda.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewItensVenda.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewItensVenda.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMaterialItem,
            this.colDescricaoProduto,
            this.colValorUnitario,
            this.colMetrosQuadrados,
            this.colQuantidadePecas,
            this.colTotalItem,
            this.colRefugo});
            this.gridViewItensVenda.GridControl = this.gridControlItensVenda;
            this.gridViewItensVenda.Name = "gridViewItensVenda";
            this.gridViewItensVenda.OptionsView.ShowFooter = true;
            this.gridViewItensVenda.OptionsView.ShowGroupPanel = false;
            this.gridViewItensVenda.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewItensVenda_CellValueChanged);
            // 
            // colIdMaterialItem
            // 
            this.colIdMaterialItem.AppearanceCell.Options.UseTextOptions = true;
            this.colIdMaterialItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMaterialItem.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdMaterialItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMaterialItem.Caption = "Código";
            this.colIdMaterialItem.FieldName = "IdMaterial";
            this.colIdMaterialItem.Name = "colIdMaterialItem";
            this.colIdMaterialItem.OptionsColumn.AllowEdit = false;
            this.colIdMaterialItem.OptionsColumn.AllowShowHide = false;
            this.colIdMaterialItem.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdMaterial", "{0}")});
            this.colIdMaterialItem.Visible = true;
            this.colIdMaterialItem.VisibleIndex = 0;
            this.colIdMaterialItem.Width = 103;
            // 
            // colDescricaoProduto
            // 
            this.colDescricaoProduto.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoProduto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoProduto.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricaoProduto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoProduto.Caption = "Material";
            this.colDescricaoProduto.FieldName = "Material.NomeMaterial";
            this.colDescricaoProduto.Name = "colDescricaoProduto";
            this.colDescricaoProduto.OptionsColumn.AllowEdit = false;
            this.colDescricaoProduto.OptionsColumn.AllowShowHide = false;
            this.colDescricaoProduto.Visible = true;
            this.colDescricaoProduto.VisibleIndex = 1;
            this.colDescricaoProduto.Width = 199;
            // 
            // colValorUnitario
            // 
            this.colValorUnitario.AppearanceCell.Options.UseTextOptions = true;
            this.colValorUnitario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorUnitario.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorUnitario.Caption = "Valor M²";
            this.colValorUnitario.DisplayFormat.FormatString = "N2";
            this.colValorUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorUnitario.FieldName = "ValorUnitario";
            this.colValorUnitario.Name = "colValorUnitario";
            this.colValorUnitario.OptionsColumn.AllowShowHide = false;
            this.colValorUnitario.Visible = true;
            this.colValorUnitario.VisibleIndex = 5;
            this.colValorUnitario.Width = 101;
            // 
            // colMetrosQuadrados
            // 
            this.colMetrosQuadrados.AppearanceCell.Options.UseTextOptions = true;
            this.colMetrosQuadrados.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosQuadrados.AppearanceHeader.Options.UseTextOptions = true;
            this.colMetrosQuadrados.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosQuadrados.Caption = "M²";
            this.colMetrosQuadrados.DisplayFormat.FormatString = "n2";
            this.colMetrosQuadrados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMetrosQuadrados.FieldName = "MetrosQuadrado";
            this.colMetrosQuadrados.Name = "colMetrosQuadrados";
            this.colMetrosQuadrados.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MetrosQuadrado", "M²: {0:n2}")});
            this.colMetrosQuadrados.Visible = true;
            this.colMetrosQuadrados.VisibleIndex = 4;
            this.colMetrosQuadrados.Width = 94;
            // 
            // colQuantidadePecas
            // 
            this.colQuantidadePecas.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidadePecas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadePecas.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidadePecas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadePecas.Caption = "Peças";
            this.colQuantidadePecas.DisplayFormat.FormatString = "N2";
            this.colQuantidadePecas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantidadePecas.FieldName = "QuantidadePeca";
            this.colQuantidadePecas.Name = "colQuantidadePecas";
            this.colQuantidadePecas.OptionsColumn.AllowShowHide = false;
            this.colQuantidadePecas.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantidadePeca", "PÇS: {0:N}")});
            this.colQuantidadePecas.Visible = true;
            this.colQuantidadePecas.VisibleIndex = 2;
            this.colQuantidadePecas.Width = 118;
            // 
            // colTotalItem
            // 
            this.colTotalItem.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalItem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalItem.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalItem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalItem.Caption = "Total";
            this.colTotalItem.DisplayFormat.FormatString = "N2";
            this.colTotalItem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalItem.FieldName = "TotalUnitario";
            this.colTotalItem.Name = "colTotalItem";
            this.colTotalItem.OptionsColumn.AllowEdit = false;
            this.colTotalItem.OptionsColumn.AllowShowHide = false;
            this.colTotalItem.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalUnitario", "R$: {0:N2}")});
            this.colTotalItem.Visible = true;
            this.colTotalItem.VisibleIndex = 6;
            this.colTotalItem.Width = 151;
            // 
            // colRefugo
            // 
            this.colRefugo.AppearanceCell.Options.UseTextOptions = true;
            this.colRefugo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRefugo.AppearanceHeader.Options.UseTextOptions = true;
            this.colRefugo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRefugo.Caption = "Refugo";
            this.colRefugo.FieldName = "QuantidadePecaRefugo";
            this.colRefugo.Name = "colRefugo";
            this.colRefugo.Visible = true;
            this.colRefugo.VisibleIndex = 3;
            // 
            // XFrmItensCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.gridControlItensVenda);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "XFrmItensCarga";
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
        private DevExpress.XtraGrid.Columns.GridColumn colIdMaterialItem;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colValorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadePecas;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMetrosQuadrados;
        private DevExpress.XtraGrid.Columns.GridColumn colRefugo;
    }
}