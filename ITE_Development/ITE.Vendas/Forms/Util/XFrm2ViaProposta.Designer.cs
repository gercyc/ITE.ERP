namespace ITE.Vendas.Forms.Util
{
    partial class XFrm2ViaProposta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrm2ViaProposta));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditNumVenda = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barBtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDetail = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.bsVenda = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlProposta = new DevExpress.XtraGrid.GridControl();
            this.gridViewProposta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagto = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProposta)).BeginInit();
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
            this.barBtnImprimir,
            this.barBtnDetail,
            this.barBtnAtualizar,
            this.barStaticItem1,
            this.barEditNumVenda});
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1,
            this.repositoryItemTextEdit1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditNumVenda),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnDetail),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Número Venda";
            this.barStaticItem1.Id = 4;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditNumVenda
            // 
            this.barEditNumVenda.Caption = "barEditItem1";
            this.barEditNumVenda.Edit = this.repositoryItemTextEdit1;
            this.barEditNumVenda.EditWidth = 170;
            this.barEditNumVenda.Id = 5;
            this.barEditNumVenda.Name = "barEditNumVenda";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.NullText = "Informe o número da venda";
            // 
            // barBtnImprimir
            // 
            this.barBtnImprimir.Caption = "Imprimir";
            this.barBtnImprimir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnImprimir.Glyph")));
            this.barBtnImprimir.Id = 0;
            this.barBtnImprimir.Name = "barBtnImprimir";
            toolTipTitleItem1.Text = "Imprime a nota de venda";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.barBtnImprimir.SuperTip = superToolTip1;
            this.barBtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnImprimir_ItemClick);
            // 
            // barBtnDetail
            // 
            this.barBtnDetail.Caption = "Detalhes da venda";
            this.barBtnDetail.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnDetail.Glyph")));
            this.barBtnDetail.Id = 1;
            this.barBtnDetail.Name = "barBtnDetail";
            toolTipTitleItem2.Text = "Visualiza detalhes sobre a venda";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.barBtnDetail.SuperTip = superToolTip2;
            this.barBtnDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDetail_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 2;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            toolTipTitleItem3.Text = "Carrega todas as vendas/cotações";
            superToolTip3.Items.Add(toolTipTitleItem3);
            this.barBtnAtualizar.SuperTip = superToolTip3;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(770, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 466);
            this.barDockControlBottom.Size = new System.Drawing.Size(770, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 419);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(770, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 419);
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            this.repositoryItemSearchControl1.NullValuePrompt = "Número da venda";
            // 
            // bsVenda
            // 
            this.bsVenda.DataSource = typeof(ITE.Entidades.POCO.Sales.Venda);
            // 
            // gridControlProposta
            // 
            this.gridControlProposta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProposta.DataSource = this.bsVenda;
            this.gridControlProposta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProposta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Location = new System.Drawing.Point(0, 47);
            this.gridControlProposta.MainView = this.gridViewProposta;
            this.gridControlProposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Name = "gridControlProposta";
            this.gridControlProposta.Size = new System.Drawing.Size(770, 419);
            this.gridControlProposta.TabIndex = 4;
            this.gridControlProposta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProposta});
            // 
            // gridViewProposta
            // 
            this.gridViewProposta.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewProposta.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewProposta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdVenda,
            this.colStatusVenda,
            this.colDataVenda,
            this.colDataVencimento,
            this.colTotalVenda,
            this.colCliFor,
            this.colUsuario,
            this.colTipoMov,
            this.colFormaPagto});
            this.gridViewProposta.GridControl = this.gridControlProposta;
            this.gridViewProposta.Name = "gridViewProposta";
            this.gridViewProposta.OptionsBehavior.Editable = false;
            this.gridViewProposta.OptionsView.ShowGroupPanel = false;
            this.gridViewProposta.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewVendas_FocusedRowChanged);
            this.gridViewProposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewVendas_KeyDown);
            this.gridViewProposta.DoubleClick += new System.EventHandler(this.gridViewProposta_DoubleClick);
            // 
            // colIdVenda
            // 
            this.colIdVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colIdVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVenda.Caption = "Nº Venda";
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.OptionsColumn.AllowEdit = false;
            this.colIdVenda.OptionsColumn.AllowShowHide = false;
            this.colIdVenda.Visible = true;
            this.colIdVenda.VisibleIndex = 0;
            this.colIdVenda.Width = 100;
            // 
            // colStatusVenda
            // 
            this.colStatusVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colStatusVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusVenda.Caption = "Situação";
            this.colStatusVenda.FieldName = "StatusVenda";
            this.colStatusVenda.Name = "colStatusVenda";
            this.colStatusVenda.OptionsColumn.AllowEdit = false;
            this.colStatusVenda.OptionsColumn.AllowShowHide = false;
            this.colStatusVenda.Visible = true;
            this.colStatusVenda.VisibleIndex = 1;
            this.colStatusVenda.Width = 104;
            // 
            // colDataVenda
            // 
            this.colDataVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colDataVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVenda.Caption = "Data Venda";
            this.colDataVenda.FieldName = "DataVenda";
            this.colDataVenda.Name = "colDataVenda";
            this.colDataVenda.OptionsColumn.AllowEdit = false;
            this.colDataVenda.OptionsColumn.AllowShowHide = false;
            this.colDataVenda.Visible = true;
            this.colDataVenda.VisibleIndex = 2;
            this.colDataVenda.Width = 81;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.Caption = "Dt. Vencimento";
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 3;
            this.colDataVencimento.Width = 102;
            // 
            // colTotalVenda
            // 
            this.colTotalVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalVenda.Caption = "Total Venda";
            this.colTotalVenda.DisplayFormat.FormatString = "n2";
            this.colTotalVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalVenda.FieldName = "TotalVenda";
            this.colTotalVenda.Name = "colTotalVenda";
            this.colTotalVenda.OptionsColumn.AllowEdit = false;
            this.colTotalVenda.OptionsColumn.AllowShowHide = false;
            this.colTotalVenda.Visible = true;
            this.colTotalVenda.VisibleIndex = 6;
            this.colTotalVenda.Width = 82;
            // 
            // colCliFor
            // 
            this.colCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliFor.Caption = "Cliente";
            this.colCliFor.FieldName = "CliFor.RazaoSocial";
            this.colCliFor.Name = "colCliFor";
            this.colCliFor.OptionsColumn.AllowEdit = false;
            this.colCliFor.OptionsColumn.AllowShowHide = false;
            this.colCliFor.Visible = true;
            this.colCliFor.VisibleIndex = 4;
            this.colCliFor.Width = 287;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.Caption = "Vendedor";
            this.colUsuario.FieldName = "Usuario.NomeUsuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.AllowEdit = false;
            this.colUsuario.OptionsColumn.AllowShowHide = false;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 7;
            this.colUsuario.Width = 69;
            // 
            // colTipoMov
            // 
            this.colTipoMov.Caption = "Tipo";
            this.colTipoMov.FieldName = "TipoMovimento";
            this.colTipoMov.Name = "colTipoMov";
            this.colTipoMov.Visible = true;
            this.colTipoMov.VisibleIndex = 8;
            this.colTipoMov.Width = 54;
            // 
            // colFormaPagto
            // 
            this.colFormaPagto.Caption = "Forma Pagamento";
            this.colFormaPagto.FieldName = "FormaPagamentoVenda.NomeFormaPagamento";
            this.colFormaPagto.Name = "colFormaPagto";
            this.colFormaPagto.Visible = true;
            this.colFormaPagto.VisibleIndex = 5;
            this.colFormaPagto.Width = 130;
            // 
            // XFrm2ViaProposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.gridControlProposta);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "XFrm2ViaProposta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Proposta";
            this.Shown += new System.EventHandler(this.XFrm2ViaProposta_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrm2ViaProposta_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProposta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlProposta;
        private System.Windows.Forms.BindingSource bsVenda;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProposta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMov;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagto;
        private DevExpress.XtraBars.BarButtonItem barBtnImprimir;
        private DevExpress.XtraBars.BarButtonItem barBtnDetail;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barEditNumVenda;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}