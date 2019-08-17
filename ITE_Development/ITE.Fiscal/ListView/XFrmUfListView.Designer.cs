namespace ITE.Fiscal.ListView
{
    partial class XFrmUfListView
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
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem12 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmUfListView));
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            this.gridControlLocaisEstoque = new DevExpress.XtraGrid.GridControl();
            this.localEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.notaFiscalCapaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bsEntrada = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnAddLocalEstoque = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnViewLocalEstoque = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLocaisEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocaisEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalCapaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLocaisEstoque
            // 
            this.gridControlLocaisEstoque.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlLocaisEstoque.DataSource = this.localEstoqueBindingSource;
            this.gridControlLocaisEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLocaisEstoque.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlLocaisEstoque.Location = new System.Drawing.Point(0, 59);
            this.gridControlLocaisEstoque.MainView = this.gridViewLocaisEstoque;
            this.gridControlLocaisEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlLocaisEstoque.Name = "gridControlLocaisEstoque";
            this.gridControlLocaisEstoque.Size = new System.Drawing.Size(951, 417);
            this.gridControlLocaisEstoque.TabIndex = 1;
            this.gridControlLocaisEstoque.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLocaisEstoque});
            this.gridControlLocaisEstoque.DoubleClick += new System.EventHandler(this.gridViewLocaisEstoque_DoubleClick);
            // 
            // localEstoqueBindingSource
            // 
            this.localEstoqueBindingSource.DataSource = typeof(ITE.Entidades.POCO.Fiscal.LocalEstoque);
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
            this.colCodigoLocalEstoque.Caption = "Código do Local";
            this.colCodigoLocalEstoque.FieldName = "CodigoLocalEstoque";
            this.colCodigoLocalEstoque.Name = "colCodigoLocalEstoque";
            this.colCodigoLocalEstoque.Visible = true;
            this.colCodigoLocalEstoque.VisibleIndex = 2;
            this.colCodigoLocalEstoque.Width = 159;
            // 
            // colNomeLocalEstoque
            // 
            this.colNomeLocalEstoque.Caption = "Local do Estoque";
            this.colNomeLocalEstoque.FieldName = "NomeLocalEstoque";
            this.colNomeLocalEstoque.Name = "colNomeLocalEstoque";
            this.colNomeLocalEstoque.Visible = true;
            this.colNomeLocalEstoque.VisibleIndex = 3;
            this.colNomeLocalEstoque.Width = 387;
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
            this.colCodFilial.Width = 81;
            // 
            // colCodMatriz
            // 
            this.colCodMatriz.Caption = "Matriz";
            this.colCodMatriz.FieldName = "Filial.Matriz.CodigoMatriz";
            this.colCodMatriz.Name = "colCodMatriz";
            this.colCodMatriz.Visible = true;
            this.colCodMatriz.VisibleIndex = 0;
            this.colCodMatriz.Width = 88;
            // 
            // notaFiscalCapaBindingSource
            // 
            this.notaFiscalCapaBindingSource.DataSource = typeof(ITE.Entidades.POCO.Fiscal.Movimento);
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
            this.btnRefresh,
            this.barBtnAddLocalEstoque,
            this.barBtnViewLocalEstoque});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAddLocalEstoque),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnViewLocalEstoque),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnAddLocalEstoque
            // 
            this.barBtnAddLocalEstoque.Caption = "Novo";
            this.barBtnAddLocalEstoque.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAddLocalEstoque.Glyph")));
            this.barBtnAddLocalEstoque.Id = 1;
            this.barBtnAddLocalEstoque.Name = "barBtnAddLocalEstoque";
            this.barBtnAddLocalEstoque.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem11.Text = "Adicionar NF";
            toolTipItem11.LeftIndent = 6;
            toolTipItem11.Text = "Permite a inclusão de uma nova nota fiscal no sistema.";
            superToolTip11.Items.Add(toolTipTitleItem11);
            superToolTip11.Items.Add(toolTipItem11);
            this.barBtnAddLocalEstoque.SuperTip = superToolTip11;
            this.barBtnAddLocalEstoque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddLocalEstoque_ItemClick);
            // 
            // barBtnViewLocalEstoque
            // 
            this.barBtnViewLocalEstoque.Caption = "Visualizar/Editar";
            this.barBtnViewLocalEstoque.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnViewLocalEstoque.Glyph")));
            this.barBtnViewLocalEstoque.Id = 3;
            this.barBtnViewLocalEstoque.Name = "barBtnViewLocalEstoque";
            this.barBtnViewLocalEstoque.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem12.Text = "Cancelar";
            toolTipItem12.LeftIndent = 6;
            toolTipItem12.Text = "Permite o cancelamento de uma nota fiscal já registrada no sistema.";
            superToolTip12.Items.Add(toolTipTitleItem12);
            superToolTip12.Items.Add(toolTipItem12);
            this.barBtnViewLocalEstoque.SuperTip = superToolTip12;
            this.barBtnViewLocalEstoque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnViewLocalEstoque_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Atualizar";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 0;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem10.Text = "Atualizar";
            toolTipItem10.LeftIndent = 6;
            toolTipItem10.Text = "Atualiza a visão de notas fiscais cadastradas.";
            superToolTip10.Items.Add(toolTipTitleItem10);
            superToolTip10.Items.Add(toolTipItem10);
            this.btnRefresh.SuperTip = superToolTip10;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(951, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 476);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(951, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 417);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(951, 59);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 417);
            // 
            // XFrmViewUf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 501);
            this.Controls.Add(this.gridControlLocaisEstoque);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmViewUf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Locais de Estoque";
            this.Shown += new System.EventHandler(this.XFrmGerenciarLocalEstoque_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLocaisEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocaisEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalCapaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlLocaisEstoque;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLocaisEstoque;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bsEntrada;
        private DevExpress.XtraBars.BarButtonItem barBtnAddLocalEstoque;
        private DevExpress.XtraBars.BarButtonItem barBtnViewLocalEstoque;
        private System.Windows.Forms.BindingSource notaFiscalCapaBindingSource;
        private System.Windows.Forms.BindingSource localEstoqueBindingSource;
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
    }
}