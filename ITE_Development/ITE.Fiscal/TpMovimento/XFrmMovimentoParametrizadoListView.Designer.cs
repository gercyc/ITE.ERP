namespace ITE.Fiscal.TpMovimento
{
    partial class XFrmMovimentoParametrizadoListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmMovimentoParametrizadoListView));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tipoMovimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoriaTipoMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirecao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovimentarEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGerarFaturamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPagamentoDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInformarCentro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCustoDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeraMovimentoFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmiteNfe = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimentoBindingSource)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(828, 143);
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
            this.ribbonPage1.Text = "Operações";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operações";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 441);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(828, 31);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tipoMovimentoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(828, 298);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tipoMovimentoBindingSource
            // 
            this.tipoMovimentoBindingSource.DataSource = typeof(ITE.Entidades.POCO.Contabil.TipoMovimento);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoMovimento,
            this.colCodigoTipoMovimento,
            this.colDescricaoTipoMovimento,
            this.colCategoriaTipoMovimento,
            this.colDirecao,
            this.colNumeracao,
            this.colMovimentarEstoque,
            this.colIdLocalEstoque,
            this.colLocalEstoque,
            this.colGerarFaturamento,
            this.colFormaPagamento,
            this.colIdFormaPagamentoDefault,
            this.colInformarCentro,
            this.colCentroCusto,
            this.colIdCentroCustoDefault,
            this.colGeraMovimentoFiscal,
            this.colEmiteNfe});
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
            // colCodigoTipoMovimento
            // 
            this.colCodigoTipoMovimento.FieldName = "CodigoTipoMovimento";
            this.colCodigoTipoMovimento.Name = "colCodigoTipoMovimento";
            this.colCodigoTipoMovimento.Visible = true;
            this.colCodigoTipoMovimento.VisibleIndex = 0;
            // 
            // colDescricaoTipoMovimento
            // 
            this.colDescricaoTipoMovimento.FieldName = "DescricaoTipoMovimento";
            this.colDescricaoTipoMovimento.Name = "colDescricaoTipoMovimento";
            this.colDescricaoTipoMovimento.Visible = true;
            this.colDescricaoTipoMovimento.VisibleIndex = 1;
            this.colDescricaoTipoMovimento.Width = 196;
            // 
            // colCategoriaTipoMovimento
            // 
            this.colCategoriaTipoMovimento.FieldName = "CategoriaTipoMovimento";
            this.colCategoriaTipoMovimento.Name = "colCategoriaTipoMovimento";
            this.colCategoriaTipoMovimento.Visible = true;
            this.colCategoriaTipoMovimento.VisibleIndex = 2;
            this.colCategoriaTipoMovimento.Width = 141;
            // 
            // colDirecao
            // 
            this.colDirecao.FieldName = "Direcao";
            this.colDirecao.Name = "colDirecao";
            this.colDirecao.Visible = true;
            this.colDirecao.VisibleIndex = 3;
            // 
            // colNumeracao
            // 
            this.colNumeracao.FieldName = "Numeracao";
            this.colNumeracao.Name = "colNumeracao";
            this.colNumeracao.Visible = true;
            this.colNumeracao.VisibleIndex = 4;
            // 
            // colMovimentarEstoque
            // 
            this.colMovimentarEstoque.FieldName = "MovimentarEstoque";
            this.colMovimentarEstoque.Name = "colMovimentarEstoque";
            this.colMovimentarEstoque.Visible = true;
            this.colMovimentarEstoque.VisibleIndex = 9;
            // 
            // colIdLocalEstoque
            // 
            this.colIdLocalEstoque.FieldName = "IdLocalEstoque";
            this.colIdLocalEstoque.Name = "colIdLocalEstoque";
            // 
            // colLocalEstoque
            // 
            this.colLocalEstoque.FieldName = "LocalEstoque";
            this.colLocalEstoque.Name = "colLocalEstoque";
            this.colLocalEstoque.Visible = true;
            this.colLocalEstoque.VisibleIndex = 5;
            this.colLocalEstoque.Width = 160;
            // 
            // colGerarFaturamento
            // 
            this.colGerarFaturamento.FieldName = "GerarFaturamento";
            this.colGerarFaturamento.Name = "colGerarFaturamento";
            this.colGerarFaturamento.Visible = true;
            this.colGerarFaturamento.VisibleIndex = 10;
            // 
            // colFormaPagamento
            // 
            this.colFormaPagamento.FieldName = "FormaPagamento";
            this.colFormaPagamento.Name = "colFormaPagamento";
            this.colFormaPagamento.Visible = true;
            this.colFormaPagamento.VisibleIndex = 6;
            this.colFormaPagamento.Width = 141;
            // 
            // colIdFormaPagamentoDefault
            // 
            this.colIdFormaPagamentoDefault.FieldName = "IdFormaPagamentoDefault";
            this.colIdFormaPagamentoDefault.Name = "colIdFormaPagamentoDefault";
            // 
            // colInformarCentro
            // 
            this.colInformarCentro.FieldName = "InformarCentro";
            this.colInformarCentro.Name = "colInformarCentro";
            this.colInformarCentro.Visible = true;
            this.colInformarCentro.VisibleIndex = 8;
            // 
            // colCentroCusto
            // 
            this.colCentroCusto.FieldName = "CentroCusto";
            this.colCentroCusto.Name = "colCentroCusto";
            this.colCentroCusto.Visible = true;
            this.colCentroCusto.VisibleIndex = 7;
            // 
            // colIdCentroCustoDefault
            // 
            this.colIdCentroCustoDefault.FieldName = "IdCentroCustoDefault";
            this.colIdCentroCustoDefault.Name = "colIdCentroCustoDefault";
            // 
            // colGeraMovimentoFiscal
            // 
            this.colGeraMovimentoFiscal.FieldName = "GeraMovimentoFiscal";
            this.colGeraMovimentoFiscal.Name = "colGeraMovimentoFiscal";
            this.colGeraMovimentoFiscal.Visible = true;
            this.colGeraMovimentoFiscal.VisibleIndex = 11;
            // 
            // colEmiteNfe
            // 
            this.colEmiteNfe.Caption = "Emite NFe";
            this.colEmiteNfe.FieldName = "EmiteNFe";
            this.colEmiteNfe.Name = "colEmiteNfe";
            this.colEmiteNfe.Visible = true;
            this.colEmiteNfe.VisibleIndex = 12;
            // 
            // XFrmMovimentoParametrizadoListView
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 472);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "XFrmMovimentoParametrizadoListView";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Parametrização de tipos de movimento:";
            this.Shown += new System.EventHandler(this.XFrmViewTiposMovimento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoMovimentoBindingSource)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnNovo;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private System.Windows.Forms.BindingSource tipoMovimentoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaTipoMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDirecao;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeracao;
        private DevExpress.XtraGrid.Columns.GridColumn colMovimentarEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colGerarFaturamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPagamentoDefault;
        private DevExpress.XtraGrid.Columns.GridColumn colInformarCentro;
        private DevExpress.XtraGrid.Columns.GridColumn colCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCustoDefault;
        private DevExpress.XtraGrid.Columns.GridColumn colGeraMovimentoFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colEmiteNfe;
    }
}