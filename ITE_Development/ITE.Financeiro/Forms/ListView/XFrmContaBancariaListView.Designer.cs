namespace ITE.Financeiro.Forms.ListView
{
    partial class XFrmContaBancariaListView
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
            this.gridControlContaBancaria = new DevExpress.XtraGrid.GridControl();
            this.bsContaBancaria = new System.Windows.Forms.BindingSource();
            this.gridViewContaBancaria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdContaBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoContaBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoContaBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAbertura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroConta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoConta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtratosBancario = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContaBancaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContaBancaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContaBancaria)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Margin = new System.Windows.Forms.Padding(3);
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(877, 144);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 524);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3);
            this.ribbonStatusBar.Size = new System.Drawing.Size(877, 32);
            // 
            // gridControlContaBancaria
            // 
            this.gridControlContaBancaria.DataSource = this.bsContaBancaria;
            this.gridControlContaBancaria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlContaBancaria.Location = new System.Drawing.Point(0, 144);
            this.gridControlContaBancaria.MainView = this.gridViewContaBancaria;
            this.gridControlContaBancaria.MenuManager = this.ribbon;
            this.gridControlContaBancaria.Name = "gridControlContaBancaria";
            this.gridControlContaBancaria.Size = new System.Drawing.Size(877, 380);
            this.gridControlContaBancaria.TabIndex = 2;
            this.gridControlContaBancaria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewContaBancaria});
            // 
            // bsContaBancaria
            // 
            this.bsContaBancaria.DataSource = typeof(ITE.Entidades.POCO.Financeiro.ContaBancaria);
            // 
            // gridViewContaBancaria
            // 
            this.gridViewContaBancaria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdContaBancaria,
            this.colIdFilial,
            this.colCodigoContaBancaria,
            this.colDescricaoContaBancaria,
            this.colDataAbertura,
            this.colSaldoInicial,
            this.colAgencia,
            this.colNumeroConta,
            this.colNomeBanco,
            this.colTipoConta,
            this.colFilial,
            this.colExtratosBancario});
            this.gridViewContaBancaria.GridControl = this.gridControlContaBancaria;
            this.gridViewContaBancaria.Name = "gridViewContaBancaria";
            this.gridViewContaBancaria.OptionsBehavior.Editable = false;
            this.gridViewContaBancaria.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCodigoContaBancaria, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewContaBancaria.DoubleClick += new System.EventHandler(this.gridViewContaBancaria_DoubleClick);
            // 
            // colIdContaBancaria
            // 
            this.colIdContaBancaria.AppearanceCell.Options.UseTextOptions = true;
            this.colIdContaBancaria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdContaBancaria.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdContaBancaria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdContaBancaria.FieldName = "IdContaBancaria";
            this.colIdContaBancaria.Name = "colIdContaBancaria";
            // 
            // colIdFilial
            // 
            this.colIdFilial.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFilial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFilial.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFilial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFilial.FieldName = "IdFilial";
            this.colIdFilial.Name = "colIdFilial";
            // 
            // colCodigoContaBancaria
            // 
            this.colCodigoContaBancaria.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoContaBancaria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoContaBancaria.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoContaBancaria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoContaBancaria.Caption = "Código";
            this.colCodigoContaBancaria.FieldName = "CodigoContaBancaria";
            this.colCodigoContaBancaria.Name = "colCodigoContaBancaria";
            this.colCodigoContaBancaria.Visible = true;
            this.colCodigoContaBancaria.VisibleIndex = 0;
            this.colCodigoContaBancaria.Width = 79;
            // 
            // colDescricaoContaBancaria
            // 
            this.colDescricaoContaBancaria.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoContaBancaria.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoContaBancaria.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricaoContaBancaria.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoContaBancaria.Caption = "Finalidade";
            this.colDescricaoContaBancaria.FieldName = "DescricaoContaBancaria";
            this.colDescricaoContaBancaria.Name = "colDescricaoContaBancaria";
            this.colDescricaoContaBancaria.Visible = true;
            this.colDescricaoContaBancaria.VisibleIndex = 6;
            this.colDescricaoContaBancaria.Width = 122;
            // 
            // colDataAbertura
            // 
            this.colDataAbertura.AppearanceCell.Options.UseTextOptions = true;
            this.colDataAbertura.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataAbertura.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataAbertura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataAbertura.FieldName = "DataAbertura";
            this.colDataAbertura.Name = "colDataAbertura";
            this.colDataAbertura.Visible = true;
            this.colDataAbertura.VisibleIndex = 1;
            this.colDataAbertura.Width = 83;
            // 
            // colSaldoInicial
            // 
            this.colSaldoInicial.AppearanceCell.Options.UseTextOptions = true;
            this.colSaldoInicial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSaldoInicial.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldoInicial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSaldoInicial.FieldName = "SaldoInicial";
            this.colSaldoInicial.Name = "colSaldoInicial";
            this.colSaldoInicial.Visible = true;
            this.colSaldoInicial.VisibleIndex = 4;
            this.colSaldoInicial.Width = 90;
            // 
            // colAgencia
            // 
            this.colAgencia.AppearanceCell.Options.UseTextOptions = true;
            this.colAgencia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAgencia.AppearanceHeader.Options.UseTextOptions = true;
            this.colAgencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAgencia.FieldName = "Agencia";
            this.colAgencia.Name = "colAgencia";
            this.colAgencia.Visible = true;
            this.colAgencia.VisibleIndex = 2;
            this.colAgencia.Width = 79;
            // 
            // colNumeroConta
            // 
            this.colNumeroConta.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroConta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroConta.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroConta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroConta.FieldName = "NumeroConta";
            this.colNumeroConta.Name = "colNumeroConta";
            this.colNumeroConta.Visible = true;
            this.colNumeroConta.VisibleIndex = 3;
            this.colNumeroConta.Width = 116;
            // 
            // colNomeBanco
            // 
            this.colNomeBanco.AppearanceCell.Options.UseTextOptions = true;
            this.colNomeBanco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeBanco.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeBanco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeBanco.FieldName = "NomeBanco";
            this.colNomeBanco.Name = "colNomeBanco";
            this.colNomeBanco.Visible = true;
            this.colNomeBanco.VisibleIndex = 7;
            this.colNomeBanco.Width = 203;
            // 
            // colTipoConta
            // 
            this.colTipoConta.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoConta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoConta.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoConta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoConta.FieldName = "TipoConta";
            this.colTipoConta.Name = "colTipoConta";
            this.colTipoConta.Visible = true;
            this.colTipoConta.VisibleIndex = 5;
            this.colTipoConta.Width = 87;
            // 
            // colFilial
            // 
            this.colFilial.AppearanceCell.Options.UseTextOptions = true;
            this.colFilial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFilial.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFilial.FieldName = "Filial";
            this.colFilial.Name = "colFilial";
            // 
            // colExtratosBancario
            // 
            this.colExtratosBancario.AppearanceCell.Options.UseTextOptions = true;
            this.colExtratosBancario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colExtratosBancario.AppearanceHeader.Options.UseTextOptions = true;
            this.colExtratosBancario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colExtratosBancario.FieldName = "ExtratosBancario";
            this.colExtratosBancario.Name = "colExtratosBancario";
            // 
            // XFrmContaBancariaView
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 556);
            this.Controls.Add(this.gridControlContaBancaria);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "XFrmContaBancariaView";
            this.Text = "Contas Bancária";
            this.Shown += new System.EventHandler(this.XFrmViewContaBancaria_Shown);
            this.Controls.SetChildIndex(this.ribbon, 0);
            this.Controls.SetChildIndex(this.ribbonStatusBar, 0);
            this.Controls.SetChildIndex(this.gridControlContaBancaria, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlContaBancaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContaBancaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContaBancaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlContaBancaria;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewContaBancaria;
        private System.Windows.Forms.BindingSource bsContaBancaria;
        private DevExpress.XtraGrid.Columns.GridColumn colIdContaBancaria;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoContaBancaria;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoContaBancaria;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAbertura;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colAgencia;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroConta;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoConta;
        private DevExpress.XtraGrid.Columns.GridColumn colFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colExtratosBancario;
    }
}