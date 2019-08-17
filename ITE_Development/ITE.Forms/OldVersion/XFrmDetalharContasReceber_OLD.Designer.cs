namespace ITE.Vendas.Forms.Administrativo
{
    partial class XFrmDetalharContasReceber_OLD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmDetalharContasReceber_OLD));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnBaixarTitulo = new DevExpress.XtraBars.BarButtonItem();
            this.btnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlReceber = new DevExpress.XtraGrid.GridControl();
            this.bsVenda = new System.Windows.Forms.BindingSource();
            this.gridViewReceber = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVendaParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorJurosParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.btnAtualizar,
            this.btnBaixarTitulo});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBaixarTitulo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAtualizar)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnBaixarTitulo
            // 
            this.btnBaixarTitulo.Caption = "Baixar Parcela(s)";
            this.btnBaixarTitulo.Id = 1;
            this.btnBaixarTitulo.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F10);
            this.btnBaixarTitulo.Name = "btnBaixarTitulo";
            this.btnBaixarTitulo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnBaixarTitulo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaixarTitulo_ItemClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Caption = "Atualizar";
            this.btnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Glyph")));
            this.btnAtualizar.Id = 0;
            this.btnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Atualizar a lista de clientes";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnAtualizar.SuperTip = superToolTip2;
            this.btnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAtualizar_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusProduto bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusProduto bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(996, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 616);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(996, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 557);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(996, 59);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 557);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gridControlReceber);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 59);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(996, 557);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Resultados";
            // 
            // gridControlReceber
            // 
            this.gridControlReceber.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlReceber.DataSource = this.bsVenda;
            this.gridControlReceber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlReceber.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlReceber.Location = new System.Drawing.Point(2, 30);
            this.gridControlReceber.MainView = this.gridViewReceber;
            this.gridControlReceber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlReceber.MenuManager = this.barManager1;
            this.gridControlReceber.Name = "gridControlReceber";
            this.gridControlReceber.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlReceber.Size = new System.Drawing.Size(992, 525);
            this.gridControlReceber.TabIndex = 0;
            this.gridControlReceber.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReceber});
            // 
            // bsVenda
            // 
            this.bsVenda.DataSource = typeof(ITE.Entidades.POCO.Sales.Venda);
            // 
            // gridViewReceber
            // 
            this.gridViewReceber.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewReceber.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewReceber.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewReceber.Appearance.Row.Options.UseFont = true;
            this.gridViewReceber.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdParcela,
            this.colIdVendaParcela,
            this.colIdCliFor,
            this.colTotalVenda,
            this.colValorJurosParcela,
            this.colDataParcela,
            this.colNumeroParcela,
            this.colImageStatus,
            this.colStatus});
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "[DataVencimento] < Today()  And IsNull([DataPagamento])";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gridViewReceber.FormatRules.Add(gridFormatRule2);
            this.gridViewReceber.GridControl = this.gridControlReceber;
            this.gridViewReceber.Name = "gridViewReceber";
            this.gridViewReceber.OptionsBehavior.Editable = false;
            this.gridViewReceber.OptionsSelection.MultiSelect = true;
            this.gridViewReceber.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewReceber.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewReceber.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colValorJurosParcela, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewReceber.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            this.gridViewReceber.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridView1_MasterRowGetChildList);
            this.gridViewReceber.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView1_MasterRowGetRelationName);
            this.gridViewReceber.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridView1_MasterRowGetRelationCount);
            // 
            // colIdParcela
            // 
            this.colIdParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colIdParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdParcela.Caption = "Ref.";
            this.colIdParcela.FieldName = "IdParcela";
            this.colIdParcela.Name = "colIdParcela";
            // 
            // colIdVendaParcela
            // 
            this.colIdVendaParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colIdVendaParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVendaParcela.Caption = "Nº Venda";
            this.colIdVendaParcela.FieldName = "IdVenda";
            this.colIdVendaParcela.Name = "colIdVendaParcela";
            this.colIdVendaParcela.Visible = true;
            this.colIdVendaParcela.VisibleIndex = 3;
            this.colIdVendaParcela.Width = 135;
            // 
            // colIdCliFor
            // 
            this.colIdCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliFor.Caption = "Cliente";
            this.colIdCliFor.FieldName = "CliFor";
            this.colIdCliFor.Name = "colIdCliFor";
            this.colIdCliFor.Visible = true;
            this.colIdCliFor.VisibleIndex = 4;
            this.colIdCliFor.Width = 241;
            // 
            // colTotalVenda
            // 
            this.colTotalVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalVenda.Caption = "Total";
            this.colTotalVenda.FieldName = "TotalVenda";
            this.colTotalVenda.Name = "colTotalVenda";
            this.colTotalVenda.Visible = true;
            this.colTotalVenda.VisibleIndex = 7;
            this.colTotalVenda.Width = 101;
            // 
            // colValorJurosParcela
            // 
            this.colValorJurosParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colValorJurosParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorJurosParcela.Caption = "Juros";
            this.colValorJurosParcela.FieldName = "ValorJurosParcela";
            this.colValorJurosParcela.Name = "colValorJurosParcela";
            // 
            // colDataParcela
            // 
            this.colDataParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colDataParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataParcela.Caption = "Vencimento";
            this.colDataParcela.FieldName = "DataVencimento";
            this.colDataParcela.Name = "colDataParcela";
            this.colDataParcela.Visible = true;
            this.colDataParcela.VisibleIndex = 6;
            this.colDataParcela.Width = 140;
            // 
            // colNumeroParcela
            // 
            this.colNumeroParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroParcela.Caption = "Nº Parcela";
            this.colNumeroParcela.FieldName = "NumeroParcelas";
            this.colNumeroParcela.Name = "colNumeroParcela";
            this.colNumeroParcela.Visible = true;
            this.colNumeroParcela.VisibleIndex = 5;
            this.colNumeroParcela.Width = 127;
            // 
            // colImageStatus
            // 
            this.colImageStatus.Caption = " ";
            this.colImageStatus.FieldName = "Image";
            this.colImageStatus.Name = "colImageStatus";
            this.colImageStatus.Visible = true;
            this.colImageStatus.VisibleIndex = 1;
            this.colImageStatus.Width = 43;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "StatusVenda";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 112;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // XFrmDetalharContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 641);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmDetalharContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas á Receber";
            this.Shown += new System.EventHandler(this.XFrmContasReceber_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnBaixarTitulo;
        private DevExpress.XtraBars.BarButtonItem btnAtualizar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlReceber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReceber;
        private DevExpress.XtraGrid.Columns.GridColumn colIdParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colValorJurosParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colDataParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVendaParcela;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colImageStatus;
        private System.Windows.Forms.BindingSource bsVenda;
    }
}