namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmFormaPagamentoListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmFormaPagamentoListView));
            this.gridControlFormasPagto = new DevExpress.XtraGrid.GridControl();
            this.gridViewFormasPagto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroParcelas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlterar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFormasPagto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormasPagto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlFormasPagto
            // 
            this.gridControlFormasPagto.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlFormasPagto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFormasPagto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlFormasPagto.Location = new System.Drawing.Point(0, 143);
            this.gridControlFormasPagto.MainView = this.gridViewFormasPagto;
            this.gridControlFormasPagto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlFormasPagto.Name = "gridControlFormasPagto";
            this.gridControlFormasPagto.Size = new System.Drawing.Size(739, 250);
            this.gridControlFormasPagto.TabIndex = 2;
            this.gridControlFormasPagto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFormasPagto});
            // 
            // gridViewFormasPagto
            // 
            this.gridViewFormasPagto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFormaPagamento,
            this.colDescricaoFormaPagamento,
            this.colTipoFormaPagamento,
            this.colNumeroParcelas});
            this.gridViewFormasPagto.GridControl = this.gridControlFormasPagto;
            this.gridViewFormasPagto.Name = "gridViewFormasPagto";
            this.gridViewFormasPagto.OptionsBehavior.Editable = false;
            this.gridViewFormasPagto.OptionsView.ColumnAutoWidth = false;
            this.gridViewFormasPagto.OptionsView.ShowGroupPanel = false;
            this.gridViewFormasPagto.DoubleClick += new System.EventHandler(this.gridViewFormasPagto_DoubleClick);
            // 
            // colIdFormaPagamento
            // 
            this.colIdFormaPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.colIdFormaPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFormaPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdFormaPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdFormaPagamento.Caption = "Ref.";
            this.colIdFormaPagamento.FieldName = "IdFormaPagamento";
            this.colIdFormaPagamento.Name = "colIdFormaPagamento";
            this.colIdFormaPagamento.Visible = true;
            this.colIdFormaPagamento.VisibleIndex = 0;
            this.colIdFormaPagamento.Width = 119;
            // 
            // colDescricaoFormaPagamento
            // 
            this.colDescricaoFormaPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoFormaPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoFormaPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricaoFormaPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoFormaPagamento.Caption = "Descrição";
            this.colDescricaoFormaPagamento.FieldName = "NomeFormaPagamento";
            this.colDescricaoFormaPagamento.Name = "colDescricaoFormaPagamento";
            this.colDescricaoFormaPagamento.Visible = true;
            this.colDescricaoFormaPagamento.VisibleIndex = 1;
            this.colDescricaoFormaPagamento.Width = 311;
            // 
            // colTipoFormaPagamento
            // 
            this.colTipoFormaPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoFormaPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoFormaPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoFormaPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoFormaPagamento.Caption = "Tipo";
            this.colTipoFormaPagamento.FieldName = "TipoFormaPagamento";
            this.colTipoFormaPagamento.Name = "colTipoFormaPagamento";
            this.colTipoFormaPagamento.Visible = true;
            this.colTipoFormaPagamento.VisibleIndex = 2;
            this.colTipoFormaPagamento.Width = 178;
            // 
            // colNumeroParcelas
            // 
            this.colNumeroParcelas.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroParcelas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroParcelas.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroParcelas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroParcelas.Caption = "Nº Parcelas";
            this.colNumeroParcelas.FieldName = "NumeroParcelas";
            this.colNumeroParcelas.Name = "colNumeroParcelas";
            this.colNumeroParcelas.Visible = true;
            this.colNumeroParcelas.VisibleIndex = 3;
            this.colNumeroParcelas.Width = 79;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnNovo,
            this.barBtnAlterar,
            this.barBtnAtualizar,
            this.barBtnExcluir});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(739, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.Caption = "Novo";
            this.barBtnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Glyph")));
            this.barBtnNovo.Id = 1;
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnNovo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovo_ItemClick);
            // 
            // barBtnAlterar
            // 
            this.barBtnAlterar.Caption = "Alterar";
            this.barBtnAlterar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterar.Glyph")));
            this.barBtnAlterar.Id = 2;
            this.barBtnAlterar.Name = "barBtnAlterar";
            this.barBtnAlterar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAlterar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAlterar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterar_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 3;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // barBtnExcluir
            // 
            this.barBtnExcluir.Caption = "Excluir";
            this.barBtnExcluir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExcluir.Glyph")));
            this.barBtnExcluir.Id = 4;
            this.barBtnExcluir.Name = "barBtnExcluir";
            this.barBtnExcluir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnExcluir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExcluir_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Início";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAlterar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAtualizar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnExcluir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Controle";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 393);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(739, 31);
            // 
            // XFrmGerenciarFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 424);
            this.Controls.Add(this.gridControlFormasPagto);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmGerenciarFormaPagamento";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Formas de Pagamento:";
            this.Shown += new System.EventHandler(this.XFrmGerenciarFormasPagto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFormasPagto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormasPagto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnNovo;
        private DevExpress.XtraBars.BarButtonItem barBtnAlterar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraGrid.GridControl gridControlFormasPagto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFormasPagto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroParcelas;
        private DevExpress.XtraBars.BarButtonItem barBtnExcluir;
    }
}