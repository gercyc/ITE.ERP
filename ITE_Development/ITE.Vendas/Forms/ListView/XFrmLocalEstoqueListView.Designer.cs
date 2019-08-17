namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmLocalEstoqueListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmLocalEstoqueListView));
            this.gridControlLocaisEstoque = new DevExpress.XtraGrid.GridControl();
            this.bsLocalEstoque = new System.Windows.Forms.BindingSource();
            this.gridViewLocaisEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeLocalEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComplementoEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsNotaFiscalCapa = new System.Windows.Forms.BindingSource();
            this.bsEntrada = new System.Windows.Forms.BindingSource();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLocaisEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocaisEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalCapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLocaisEstoque
            // 
            this.gridControlLocaisEstoque.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlLocaisEstoque.DataSource = this.bsLocalEstoque;
            this.gridControlLocaisEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLocaisEstoque.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlLocaisEstoque.Location = new System.Drawing.Point(0, 144);
            this.gridControlLocaisEstoque.MainView = this.gridViewLocaisEstoque;
            this.gridControlLocaisEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlLocaisEstoque.Name = "gridControlLocaisEstoque";
            this.gridControlLocaisEstoque.Size = new System.Drawing.Size(815, 210);
            this.gridControlLocaisEstoque.TabIndex = 1;
            this.gridControlLocaisEstoque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLocaisEstoque});
            this.gridControlLocaisEstoque.DoubleClick += new System.EventHandler(this.gridViewLocaisEstoque_DoubleClick);
            // 
            // bsLocalEstoque
            // 
            this.bsLocalEstoque.DataSource = typeof(ITE.Entidades.POCO.Fiscal.LocalEstoque);
            // 
            // gridViewLocaisEstoque
            // 
            this.gridViewLocaisEstoque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLocalEstoque,
            this.colCodigoLocalEstoque,
            this.colNomeLocalEstoque,
            this.colIdFilial,
            this.colNomeEndereco,
            this.colNumeroEndereco,
            this.colComplementoEndereco,
            this.colBairro,
            this.colCep,
            this.colUf,
            this.colMunicipio,
            this.colCodFilial,
            this.colCodMatriz});
            this.gridViewLocaisEstoque.GridControl = this.gridControlLocaisEstoque;
            this.gridViewLocaisEstoque.Name = "gridViewLocaisEstoque";
            this.gridViewLocaisEstoque.OptionsBehavior.Editable = false;
            this.gridViewLocaisEstoque.OptionsView.ColumnAutoWidth = false;
            this.gridViewLocaisEstoque.OptionsView.RowAutoHeight = true;
            this.gridViewLocaisEstoque.OptionsView.ShowGroupPanel = false;
            // 
            // colIdLocalEstoque
            // 
            this.colIdLocalEstoque.FieldName = "IdLocalEstoque";
            this.colIdLocalEstoque.Name = "colIdLocalEstoque";
            // 
            // colCodigoLocalEstoque
            // 
            this.colCodigoLocalEstoque.FieldName = "CodigoLocalEstoque";
            this.colCodigoLocalEstoque.Name = "colCodigoLocalEstoque";
            this.colCodigoLocalEstoque.Visible = true;
            this.colCodigoLocalEstoque.VisibleIndex = 2;
            this.colCodigoLocalEstoque.Width = 146;
            // 
            // colNomeLocalEstoque
            // 
            this.colNomeLocalEstoque.FieldName = "NomeLocalEstoque";
            this.colNomeLocalEstoque.Name = "colNomeLocalEstoque";
            this.colNomeLocalEstoque.Visible = true;
            this.colNomeLocalEstoque.VisibleIndex = 3;
            this.colNomeLocalEstoque.Width = 192;
            // 
            // colIdFilial
            // 
            this.colIdFilial.FieldName = "IdFilial";
            this.colIdFilial.Name = "colIdFilial";
            // 
            // colNomeEndereco
            // 
            this.colNomeEndereco.FieldName = "NomeEndereco";
            this.colNomeEndereco.Name = "colNomeEndereco";
            // 
            // colNumeroEndereco
            // 
            this.colNumeroEndereco.FieldName = "NumeroEndereco";
            this.colNumeroEndereco.Name = "colNumeroEndereco";
            // 
            // colComplementoEndereco
            // 
            this.colComplementoEndereco.FieldName = "ComplementoEndereco";
            this.colComplementoEndereco.Name = "colComplementoEndereco";
            // 
            // colBairro
            // 
            this.colBairro.FieldName = "Bairro";
            this.colBairro.Name = "colBairro";
            // 
            // colCep
            // 
            this.colCep.FieldName = "Cep";
            this.colCep.Name = "colCep";
            // 
            // colUf
            // 
            this.colUf.FieldName = "Uf";
            this.colUf.Name = "colUf";
            // 
            // colMunicipio
            // 
            this.colMunicipio.FieldName = "Municipio";
            this.colMunicipio.Name = "colMunicipio";
            // 
            // colCodFilial
            // 
            this.colCodFilial.Caption = "Filial";
            this.colCodFilial.FieldName = "Filial.CodigoFilial";
            this.colCodFilial.Name = "colCodFilial";
            this.colCodFilial.Visible = true;
            this.colCodFilial.VisibleIndex = 1;
            // 
            // colCodMatriz
            // 
            this.colCodMatriz.Caption = "Matriz";
            this.colCodMatriz.FieldName = "Filial.Matriz.CodigoMatriz";
            this.colCodMatriz.Name = "colCodMatriz";
            this.colCodMatriz.Visible = true;
            this.colCodMatriz.VisibleIndex = 0;
            // 
            // bsNotaFiscalCapa
            // 
            this.bsNotaFiscalCapa.DataSource = typeof(ITE.Entidades.POCO.Fiscal.Movimento);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(815, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 386);
            this.barDockControlBottom.Size = new System.Drawing.Size(815, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 386);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(815, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 386);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnNovo,
            this.barBtnEditar,
            this.barBtnAtualizar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(815, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.Caption = "Novo";
            this.barBtnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Glyph")));
            this.barBtnNovo.Id = 1;
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovo_ItemClick);
            // 
            // barBtnEditar
            // 
            this.barBtnEditar.Caption = "Editar";
            this.barBtnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditar.Glyph")));
            this.barBtnEditar.Id = 2;
            this.barBtnEditar.Name = "barBtnEditar";
            this.barBtnEditar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditar_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 3;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAtualizar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Gerenciador";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 354);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(815, 32);
            // 
            // XFrmLocalEstoqueListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 407);
            this.Controls.Add(this.gridControlLocaisEstoque);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmLocalEstoqueListView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Locais de Estoque";
            this.Shown += new System.EventHandler(this.XFrmGerenciarLocalEstoque_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLocaisEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocaisEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalCapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLocaisEstoque;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLocaisEstoque;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bsEntrada;
        private System.Windows.Forms.BindingSource bsNotaFiscalCapa;
        private System.Windows.Forms.BindingSource bsLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colComplementoEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colBairro;
        private DevExpress.XtraGrid.Columns.GridColumn colCep;
        private DevExpress.XtraGrid.Columns.GridColumn colUf;
        private DevExpress.XtraGrid.Columns.GridColumn colMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colCodMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colCodFilial;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barBtnNovo;
        private DevExpress.XtraBars.BarButtonItem barBtnEditar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
    }
}