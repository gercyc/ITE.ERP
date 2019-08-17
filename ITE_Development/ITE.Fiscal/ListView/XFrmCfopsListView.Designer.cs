namespace ITE.Fiscal.ListView
{
    partial class XFrmViewCfop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewCfop));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.gridControlLocaisEstoque = new DevExpress.XtraGrid.GridControl();
            this.gridViewLocaisEstoque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoCfop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoCfop = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocaisEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlLocaisEstoque
            // 
            this.gridControlLocaisEstoque.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.gridControlLocaisEstoque.DoubleClick += new System.EventHandler(this.gridViewCfops_DoubleClick);
            // 
            // gridViewLocaisEstoque
            // 
            this.gridViewLocaisEstoque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoCfop,
            this.colDescricaoCfop});
            this.gridViewLocaisEstoque.GridControl = this.gridControlLocaisEstoque;
            this.gridViewLocaisEstoque.Name = "gridViewLocaisEstoque";
            this.gridViewLocaisEstoque.OptionsBehavior.Editable = false;
            this.gridViewLocaisEstoque.OptionsView.ColumnAutoWidth = false;
            this.gridViewLocaisEstoque.OptionsView.RowAutoHeight = true;
            this.gridViewLocaisEstoque.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigoCfop
            // 
            this.colCodigoCfop.Caption = "Código CFOP";
            this.colCodigoCfop.FieldName = "CodigoCfop";
            this.colCodigoCfop.Name = "colCodigoCfop";
            this.colCodigoCfop.Visible = true;
            this.colCodigoCfop.VisibleIndex = 0;
            this.colCodigoCfop.Width = 121;
            // 
            // colDescricaoCfop
            // 
            this.colDescricaoCfop.Caption = "Descrição CFOP";
            this.colDescricaoCfop.FieldName = "DescricaoCfop";
            this.colDescricaoCfop.Name = "colDescricaoCfop";
            this.colDescricaoCfop.Visible = true;
            this.colDescricaoCfop.VisibleIndex = 1;
            this.colDescricaoCfop.Width = 480;
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
            toolTipTitleItem1.Text = "Adicionar NF";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Permite a inclusão de uma nova nota fiscal no sistema.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barBtnAddLocalEstoque.SuperTip = superToolTip1;
            this.barBtnAddLocalEstoque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddCfop_ItemClick);
            // 
            // barBtnViewLocalEstoque
            // 
            this.barBtnViewLocalEstoque.Caption = "Visualizar/Editar";
            this.barBtnViewLocalEstoque.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnViewLocalEstoque.Glyph")));
            this.barBtnViewLocalEstoque.Id = 3;
            this.barBtnViewLocalEstoque.Name = "barBtnViewLocalEstoque";
            this.barBtnViewLocalEstoque.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Cancelar";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Permite o cancelamento de uma nota fiscal já registrada no sistema.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barBtnViewLocalEstoque.SuperTip = superToolTip2;
            this.barBtnViewLocalEstoque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnViewLocalEstoque_Click);
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
            // XFrmViewCfop
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
            this.Name = "XFrmViewCfop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar códigos CFOP";
            this.Shown += new System.EventHandler(this.XFrmViewCfops_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLocaisEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLocaisEstoque)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barBtnAddLocalEstoque;
        private DevExpress.XtraBars.BarButtonItem barBtnViewLocalEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoCfop;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoCfop;
    }
}