namespace ITE.Vendas.Forms.Util
{
    partial class XFrmCotacaoListView
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
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCotacaoListView));
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            this.gridControlProposta = new DevExpress.XtraGrid.GridControl();
            this.bsVenda = new System.Windows.Forms.BindingSource();
            this.gridViewProposta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCotacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusCotacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataProposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCotacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager2 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditNumVenda = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlterar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProposta
            // 
            this.gridControlProposta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProposta.DataSource = this.bsVenda;
            this.gridControlProposta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProposta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Location = new System.Drawing.Point(0, 59);
            this.gridControlProposta.MainView = this.gridViewProposta;
            this.gridControlProposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Name = "gridControlProposta";
            this.gridControlProposta.Size = new System.Drawing.Size(969, 510);
            this.gridControlProposta.TabIndex = 0;
            this.gridControlProposta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProposta});
            // 
            // bsVenda
            // 
            this.bsVenda.DataSource = typeof(ITE.Entidades.POCO.Sales.Venda);
            // 
            // gridViewProposta
            // 
            this.gridViewProposta.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewProposta.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewProposta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCotacao,
            this.colStatusCotacao,
            this.colDataProposta,
            this.colTotalCotacao,
            this.colCliFor,
            this.colUsuario,
            this.colDataVencimento});
            this.gridViewProposta.GridControl = this.gridControlProposta;
            this.gridViewProposta.Name = "gridViewProposta";
            this.gridViewProposta.OptionsBehavior.Editable = false;
            this.gridViewProposta.OptionsView.ShowGroupPanel = false;
            this.gridViewProposta.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdCotacao, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewProposta.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProposta_FocusedRowChanged);
            this.gridViewProposta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewVendas_KeyDown);
            this.gridViewProposta.Click += new System.EventHandler(this.gridViewProposta_Click);
            this.gridViewProposta.DoubleClick += new System.EventHandler(this.gridViewProposta_DoubleClick);
            // 
            // colIdCotacao
            // 
            this.colIdCotacao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCotacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCotacao.Caption = "Nº Cotação";
            this.colIdCotacao.FieldName = "IdVenda";
            this.colIdCotacao.Name = "colIdCotacao";
            this.colIdCotacao.OptionsColumn.AllowEdit = false;
            this.colIdCotacao.OptionsColumn.AllowShowHide = false;
            this.colIdCotacao.Visible = true;
            this.colIdCotacao.VisibleIndex = 0;
            this.colIdCotacao.Width = 109;
            // 
            // colStatusCotacao
            // 
            this.colStatusCotacao.AppearanceCell.Options.UseTextOptions = true;
            this.colStatusCotacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusCotacao.Caption = "Nº Itens";
            this.colStatusCotacao.FieldName = "NumeroItens";
            this.colStatusCotacao.Name = "colStatusCotacao";
            this.colStatusCotacao.OptionsColumn.AllowEdit = false;
            this.colStatusCotacao.OptionsColumn.AllowShowHide = false;
            this.colStatusCotacao.Visible = true;
            this.colStatusCotacao.VisibleIndex = 5;
            this.colStatusCotacao.Width = 90;
            // 
            // colDataProposta
            // 
            this.colDataProposta.AppearanceCell.Options.UseTextOptions = true;
            this.colDataProposta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataProposta.Caption = "Data";
            this.colDataProposta.FieldName = "DataVenda";
            this.colDataProposta.Name = "colDataProposta";
            this.colDataProposta.OptionsColumn.AllowEdit = false;
            this.colDataProposta.OptionsColumn.AllowShowHide = false;
            this.colDataProposta.Visible = true;
            this.colDataProposta.VisibleIndex = 1;
            this.colDataProposta.Width = 90;
            // 
            // colTotalCotacao
            // 
            this.colTotalCotacao.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalCotacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalCotacao.Caption = "Total";
            this.colTotalCotacao.DisplayFormat.FormatString = "n2";
            this.colTotalCotacao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalCotacao.FieldName = "TotalVenda";
            this.colTotalCotacao.Name = "colTotalCotacao";
            this.colTotalCotacao.OptionsColumn.AllowEdit = false;
            this.colTotalCotacao.OptionsColumn.AllowShowHide = false;
            this.colTotalCotacao.Visible = true;
            this.colTotalCotacao.VisibleIndex = 4;
            this.colTotalCotacao.Width = 81;
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
            this.colCliFor.VisibleIndex = 3;
            this.colCliFor.Width = 222;
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
            this.colUsuario.VisibleIndex = 6;
            this.colUsuario.Width = 117;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.Caption = "Data Vencimento";
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 2;
            this.colDataVencimento.Width = 112;
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnAlterar,
            this.barBtnAtualizar,
            this.barEditNumVenda,
            this.barStaticItem4,
            this.barBtnPrint});
            this.barManager2.MaxItemId = 7;
            this.barManager2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditNumVenda),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAlterar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Número Cotação";
            this.barStaticItem4.Id = 5;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barEditNumVenda
            // 
            this.barEditNumVenda.Caption = "Número Cotação";
            this.barEditNumVenda.Edit = this.repositoryItemTextEdit2;
            this.barEditNumVenda.EditWidth = 220;
            this.barEditNumVenda.Id = 4;
            this.barEditNumVenda.Name = "barEditNumVenda";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.NullText = "Informe o número da cotação";
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "Imprimir";
            this.barBtnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPrint.Glyph")));
            this.barBtnPrint.Id = 6;
            this.barBtnPrint.Name = "barBtnPrint";
            toolTipTitleItem4.Text = "Imprimir Cotação";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Imprime a cotação selecionada";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.barBtnPrint.SuperTip = superToolTip4;
            this.barBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrint_ItemClick);
            // 
            // barBtnAlterar
            // 
            this.barBtnAlterar.Caption = "Alterar Cotação";
            this.barBtnAlterar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterar.Glyph")));
            this.barBtnAlterar.Id = 0;
            this.barBtnAlterar.Name = "barBtnAlterar";
            this.barBtnAlterar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem3.Text = "Editar Cotação";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Permite editar a cotação atráves da tela de venda.";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.barBtnAlterar.SuperTip = superToolTip3;
            this.barBtnAlterar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterar_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 1;
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            toolTipTitleItem5.Text = "Atualizar Cotações";
            toolTipItem5.LeftIndent = 6;
            toolTipItem5.Text = "Atualiza a tabela de cotações existentes.";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            this.barBtnAtualizar.SuperTip = superToolTip5;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(969, 59);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 569);
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(969, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 59);
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 510);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(969, 59);
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 510);
            // 
            // XFrmCotacaoListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 569);
            this.Controls.Add(this.gridControlProposta);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmCotacaoListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotações";
            this.Shown += new System.EventHandler(this.XFrmAlterarCotacao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProposta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProposta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCotacao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataProposta;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCotacao;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusCotacao;
        private System.Windows.Forms.BindingSource bsVenda;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarEditItem barEditNumVenda;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem barBtnAlterar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraBars.BarButtonItem barBtnPrint;
    }
}