namespace ITEDesktop
{
    partial class GrcTeste
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.entityDataSource1 = new ITSolution.Framework.BaseClasses.ThirdyPartyComponents.EntityDataSource(this.components);
            this.colIdProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecoVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadeProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMargemLucro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCadastro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoItemProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFotoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategoriaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadeMedidaProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadeMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificacaoProduto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoNCM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtributos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Size = new System.Drawing.Size(800, 450);
            this.panelControl1.Controls.SetChildIndex(this.gridControl1, 0);
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Produtos";
            this.gridControl1.DataSource = this.entityDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(796, 424);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProduto,
            this.colCodigoBarras,
            this.colDescricaoProduto,
            this.colPrecoCompra,
            this.colPrecoVenda,
            this.colQuantidadeProduto,
            this.colMargemLucro,
            this.colDataCadastro,
            this.colStatusProduto,
            this.colTipoItemProduto,
            this.colFotoProduto,
            this.colObservacao,
            this.colIdCategoriaProduto,
            this.colCategoriaProduto,
            this.colIdUnidadeMedidaProduto,
            this.colUnidadeMedida,
            this.colIdentificacaoProduto,
            this.colCodigoNCM,
            this.colAtributos,
            this.colImage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // entityDataSource1
            // 
            this.entityDataSource1.DbContextType = typeof(ITE.Entidades.Repositorio.BalcaoContext);
            // 
            // colIdProduto
            // 
            this.colIdProduto.FieldName = "IdProduto";
            this.colIdProduto.Name = "colIdProduto";
            this.colIdProduto.Visible = true;
            this.colIdProduto.VisibleIndex = 0;
            // 
            // colCodigoBarras
            // 
            this.colCodigoBarras.FieldName = "CodigoBarras";
            this.colCodigoBarras.Name = "colCodigoBarras";
            this.colCodigoBarras.Visible = true;
            this.colCodigoBarras.VisibleIndex = 1;
            // 
            // colDescricaoProduto
            // 
            this.colDescricaoProduto.FieldName = "DescricaoProduto";
            this.colDescricaoProduto.Name = "colDescricaoProduto";
            this.colDescricaoProduto.Visible = true;
            this.colDescricaoProduto.VisibleIndex = 2;
            // 
            // colPrecoCompra
            // 
            this.colPrecoCompra.FieldName = "PrecoCompra";
            this.colPrecoCompra.Name = "colPrecoCompra";
            this.colPrecoCompra.Visible = true;
            this.colPrecoCompra.VisibleIndex = 3;
            // 
            // colPrecoVenda
            // 
            this.colPrecoVenda.FieldName = "PrecoVenda";
            this.colPrecoVenda.Name = "colPrecoVenda";
            this.colPrecoVenda.Visible = true;
            this.colPrecoVenda.VisibleIndex = 4;
            // 
            // colQuantidadeProduto
            // 
            this.colQuantidadeProduto.FieldName = "QuantidadeProduto";
            this.colQuantidadeProduto.Name = "colQuantidadeProduto";
            this.colQuantidadeProduto.Visible = true;
            this.colQuantidadeProduto.VisibleIndex = 5;
            // 
            // colMargemLucro
            // 
            this.colMargemLucro.FieldName = "MargemLucro";
            this.colMargemLucro.Name = "colMargemLucro";
            this.colMargemLucro.Visible = true;
            this.colMargemLucro.VisibleIndex = 6;
            // 
            // colDataCadastro
            // 
            this.colDataCadastro.FieldName = "DataCadastro";
            this.colDataCadastro.Name = "colDataCadastro";
            this.colDataCadastro.Visible = true;
            this.colDataCadastro.VisibleIndex = 7;
            // 
            // colStatusProduto
            // 
            this.colStatusProduto.FieldName = "StatusProduto";
            this.colStatusProduto.Name = "colStatusProduto";
            this.colStatusProduto.Visible = true;
            this.colStatusProduto.VisibleIndex = 8;
            // 
            // colTipoItemProduto
            // 
            this.colTipoItemProduto.FieldName = "TipoItemProduto";
            this.colTipoItemProduto.Name = "colTipoItemProduto";
            this.colTipoItemProduto.Visible = true;
            this.colTipoItemProduto.VisibleIndex = 9;
            // 
            // colFotoProduto
            // 
            this.colFotoProduto.FieldName = "FotoProduto";
            this.colFotoProduto.Name = "colFotoProduto";
            this.colFotoProduto.Visible = true;
            this.colFotoProduto.VisibleIndex = 10;
            // 
            // colObservacao
            // 
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 11;
            // 
            // colIdCategoriaProduto
            // 
            this.colIdCategoriaProduto.FieldName = "IdCategoriaProduto";
            this.colIdCategoriaProduto.Name = "colIdCategoriaProduto";
            this.colIdCategoriaProduto.Visible = true;
            this.colIdCategoriaProduto.VisibleIndex = 12;
            // 
            // colCategoriaProduto
            // 
            this.colCategoriaProduto.FieldName = "CategoriaProduto";
            this.colCategoriaProduto.Name = "colCategoriaProduto";
            this.colCategoriaProduto.Visible = true;
            this.colCategoriaProduto.VisibleIndex = 13;
            // 
            // colIdUnidadeMedidaProduto
            // 
            this.colIdUnidadeMedidaProduto.FieldName = "IdUnidadeMedidaProduto";
            this.colIdUnidadeMedidaProduto.Name = "colIdUnidadeMedidaProduto";
            this.colIdUnidadeMedidaProduto.Visible = true;
            this.colIdUnidadeMedidaProduto.VisibleIndex = 14;
            // 
            // colUnidadeMedida
            // 
            this.colUnidadeMedida.FieldName = "UnidadeMedida";
            this.colUnidadeMedida.Name = "colUnidadeMedida";
            this.colUnidadeMedida.Visible = true;
            this.colUnidadeMedida.VisibleIndex = 15;
            // 
            // colIdentificacaoProduto
            // 
            this.colIdentificacaoProduto.FieldName = "IdentificacaoProduto";
            this.colIdentificacaoProduto.Name = "colIdentificacaoProduto";
            this.colIdentificacaoProduto.Visible = true;
            this.colIdentificacaoProduto.VisibleIndex = 16;
            // 
            // colCodigoNCM
            // 
            this.colCodigoNCM.FieldName = "CodigoNCM";
            this.colCodigoNCM.Name = "colCodigoNCM";
            this.colCodigoNCM.Visible = true;
            this.colCodigoNCM.VisibleIndex = 17;
            // 
            // colAtributos
            // 
            this.colAtributos.FieldName = "Atributos";
            this.colAtributos.Name = "colAtributos";
            this.colAtributos.Visible = true;
            this.colAtributos.VisibleIndex = 18;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.ReadOnly = true;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 19;
            // 
            // GrcTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "GrcTeste";
            this.Text = "GrcTeste";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ITSolution.Framework.BaseClasses.ThirdyPartyComponents.EntityDataSource entityDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarras;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecoVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadeProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colMargemLucro;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCadastro;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoItemProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colFotoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoriaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadeMedidaProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadeMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificacaoProduto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoNCM;
        private DevExpress.XtraGrid.Columns.GridColumn colAtributos;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
    }
}