namespace ITE.Fiscal.ListView
{
    partial class XFrmPaisListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmPaisListView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.gridControlPaises = new DevExpress.XtraGrid.GridControl();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPaises = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoSiscomex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomePais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnAddPais = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnViewPais = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlPaises
            // 
            this.gridControlPaises.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlPaises.DataSource = this.paisBindingSource;
            this.gridControlPaises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPaises.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlPaises.Location = new System.Drawing.Point(0, 47);
            this.gridControlPaises.MainView = this.gridViewPaises;
            this.gridControlPaises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlPaises.Name = "gridControlPaises";
            this.gridControlPaises.Size = new System.Drawing.Size(815, 337);
            this.gridControlPaises.TabIndex = 1;
            this.gridControlPaises.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPaises});
            this.gridControlPaises.DoubleClick += new System.EventHandler(this.gridViewLocaisEstoque_DoubleClick);
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataSource = typeof(ITE.Entidades.POCO.Fiscal.Pais);
            // 
            // gridViewPaises
            // 
            this.gridViewPaises.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPais,
            this.colCodigoSiscomex,
            this.colNomePais});
            this.gridViewPaises.GridControl = this.gridControlPaises;
            this.gridViewPaises.Name = "gridViewPaises";
            this.gridViewPaises.OptionsBehavior.Editable = false;
            this.gridViewPaises.OptionsView.ColumnAutoWidth = false;
            this.gridViewPaises.OptionsView.RowAutoHeight = true;
            // 
            // colIdPais
            // 
            this.colIdPais.FieldName = "IdPais";
            this.colIdPais.Name = "colIdPais";
            // 
            // colCodigoSiscomex
            // 
            this.colCodigoSiscomex.FieldName = "CodigoSiscomex";
            this.colCodigoSiscomex.Name = "colCodigoSiscomex";
            this.colCodigoSiscomex.Visible = true;
            this.colCodigoSiscomex.VisibleIndex = 0;
            this.colCodigoSiscomex.Width = 124;
            // 
            // colNomePais
            // 
            this.colNomePais.FieldName = "NomePais";
            this.colNomePais.Name = "colNomePais";
            this.colNomePais.Visible = true;
            this.colNomePais.VisibleIndex = 1;
            this.colNomePais.Width = 400;
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
            this.barBtnAddPais,
            this.barBtnViewPais});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAddPais),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnViewPais),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnAddPais
            // 
            this.barBtnAddPais.Caption = "Novo";
            this.barBtnAddPais.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAddPais.Glyph")));
            this.barBtnAddPais.Id = 1;
            this.barBtnAddPais.Name = "barBtnAddPais";
            this.barBtnAddPais.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem1.Text = "Adicionar NF";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Permite a inclusão de uma nova nota fiscal no sistema.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barBtnAddPais.SuperTip = superToolTip1;
            this.barBtnAddPais.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddPais_ItemClick);
            // 
            // barBtnViewPais
            // 
            this.barBtnViewPais.Caption = "Visualizar/Editar";
            this.barBtnViewPais.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnViewPais.Glyph")));
            this.barBtnViewPais.Id = 3;
            this.barBtnViewPais.Name = "barBtnViewPais";
            this.barBtnViewPais.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Cancelar";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Permite o cancelamento de uma nota fiscal já registrada no sistema.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barBtnViewPais.SuperTip = superToolTip2;
            this.barBtnViewPais.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnViewPais_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Atualizar";
            this.btnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Glyph")));
            this.btnRefresh.Id = 0;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem3.Text = "Atualizar";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Atualiza a visão de notas fiscais cadastradas.";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnRefresh.SuperTip = superToolTip3;
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
            this.barDockControlTop.Size = new System.Drawing.Size(815, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 384);
            this.barDockControlBottom.Size = new System.Drawing.Size(815, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(815, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // XFrmPaisListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 407);
            this.Controls.Add(this.gridControlPaises);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmPaisListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar países";
            this.Shown += new System.EventHandler(this.XFrmPaisListView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPaises;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPaises;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnAddPais;
        private DevExpress.XtraBars.BarButtonItem barBtnViewPais;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPais;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoSiscomex;
        private DevExpress.XtraGrid.Columns.GridColumn colNomePais;
    }
}