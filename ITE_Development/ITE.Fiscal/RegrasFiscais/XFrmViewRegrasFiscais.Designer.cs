namespace ITE.Fiscal.RegrasFiscais
{
    partial class XFrmViewRegrasFiscais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewRegrasFiscais));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoRegraFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoRegraFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoNatureza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDevolucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImpostosTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovimentaEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseLegal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnRefresh,
            this.btnNovo,
            this.btnEditar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(966, 179);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Atualizar";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 1;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Caption = "Novo";
            this.btnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovo.Glyph")));
            this.btnNovo.Id = 2;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovo_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Visualizar/Editar";
            this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
            this.btnEditar.Id = 3;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Opções";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 541);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(966, 40);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 179);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(966, 362);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoMovimento,
            this.colCodigoRegraFiscal,
            this.colDescricaoRegraFiscal,
            this.colTipoNatureza,
            this.colTipoDevolucao,
            this.colImpostosTipoMovimento,
            this.colMovimentaEstoque,
            this.colBaseLegal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colIdTipoMovimento
            // 
            this.colIdTipoMovimento.FieldName = "IdTipoMovimento";
            this.colIdTipoMovimento.Name = "colIdTipoMovimento";
            // 
            // colCodigoRegraFiscal
            // 
            this.colCodigoRegraFiscal.Caption = "Código";
            this.colCodigoRegraFiscal.FieldName = "CodigoRegraFiscal";
            this.colCodigoRegraFiscal.Name = "colCodigoRegraFiscal";
            this.colCodigoRegraFiscal.Visible = true;
            this.colCodigoRegraFiscal.VisibleIndex = 0;
            // 
            // colDescricaoRegraFiscal
            // 
            this.colDescricaoRegraFiscal.Caption = "Descrição";
            this.colDescricaoRegraFiscal.FieldName = "DescricaoRegraFiscal";
            this.colDescricaoRegraFiscal.Name = "colDescricaoRegraFiscal";
            this.colDescricaoRegraFiscal.Visible = true;
            this.colDescricaoRegraFiscal.VisibleIndex = 1;
            this.colDescricaoRegraFiscal.Width = 411;
            // 
            // colTipoNatureza
            // 
            this.colTipoNatureza.FieldName = "TipoNatureza";
            this.colTipoNatureza.Name = "colTipoNatureza";
            this.colTipoNatureza.Visible = true;
            this.colTipoNatureza.VisibleIndex = 2;
            this.colTipoNatureza.Width = 123;
            // 
            // colTipoDevolucao
            // 
            this.colTipoDevolucao.FieldName = "TipoDevolucao";
            this.colTipoDevolucao.Name = "colTipoDevolucao";
            this.colTipoDevolucao.Visible = true;
            this.colTipoDevolucao.VisibleIndex = 3;
            this.colTipoDevolucao.Width = 123;
            // 
            // colImpostosTipoMovimento
            // 
            this.colImpostosTipoMovimento.FieldName = "ImpostosTipoMovimento";
            this.colImpostosTipoMovimento.Name = "colImpostosTipoMovimento";
            // 
            // colMovimentaEstoque
            // 
            this.colMovimentaEstoque.FieldName = "MovimentaEstoque";
            this.colMovimentaEstoque.Name = "colMovimentaEstoque";
            this.colMovimentaEstoque.Visible = true;
            this.colMovimentaEstoque.VisibleIndex = 4;
            this.colMovimentaEstoque.Width = 123;
            // 
            // colBaseLegal
            // 
            this.colBaseLegal.FieldName = "BaseLegal";
            this.colBaseLegal.Name = "colBaseLegal";
            this.colBaseLegal.Visible = true;
            this.colBaseLegal.VisibleIndex = 5;
            this.colBaseLegal.Width = 92;
            // 
            // XFrmViewRegrasFiscais
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 581);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmViewRegrasFiscais";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Regras Fiscais";
            this.Shown += new System.EventHandler(this.XFrmViewTiposMovimento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoRegraFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoRegraFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoNatureza;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDevolucao;
        private DevExpress.XtraGrid.Columns.GridColumn colImpostosTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colMovimentaEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseLegal;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnNovo;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
    }
}