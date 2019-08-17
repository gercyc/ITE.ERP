namespace ITE.Contabil.Forms.ListView
{
    partial class XFrmViewCentroCustoTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewCentroCustoTree));
            this.barAction = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExpCollapse = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bsCentroCusto = new System.Windows.Forms.BindingSource(this.components);
            this.treeListCentros = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCentroCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCentros)).BeginInit();
            this.SuspendLayout();
            // 
            // barAction
            // 
            this.barAction.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barAction.DockControls.Add(this.barDockControlTop);
            this.barAction.DockControls.Add(this.barDockControlBottom);
            this.barAction.DockControls.Add(this.barDockControlLeft);
            this.barAction.DockControls.Add(this.barDockControlRight);
            this.barAction.Form = this;
            this.barAction.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnEditar,
            this.barBtnAtualizar,
            this.barBtnNovo,
            this.barBtnExpCollapse});
            this.barAction.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnNovo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnExpCollapse),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.Caption = "Novo Centro";
            this.barBtnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Glyph")));
            this.barBtnNovo.Id = 4;
            this.barBtnNovo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.LargeGlyph")));
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovo_ItemClick);
            // 
            // barBtnEditar
            // 
            this.barBtnEditar.Caption = "Editar/Visualizar";
            this.barBtnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditar.Glyph")));
            this.barBtnEditar.Id = 1;
            this.barBtnEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditar.LargeGlyph")));
            this.barBtnEditar.Name = "barBtnEditar";
            this.barBtnEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditarCc_ItemClick);
            // 
            // barBtnExpCollapse
            // 
            this.barBtnExpCollapse.Caption = "Expandir/Recolher";
            this.barBtnExpCollapse.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExpCollapse.Glyph")));
            this.barBtnExpCollapse.Id = 5;
            this.barBtnExpCollapse.Name = "barBtnExpCollapse";
            this.barBtnExpCollapse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExpCollapse_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 2;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizar.ShortcutKeyDisplayString = "Atualizar";
            this.barBtnAtualizar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(776, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 449);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(776, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 404);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(776, 45);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 404);
            // 
            // bsCentroCusto
            // 
            this.bsCentroCusto.DataSource = typeof(ITE.Entidades.POCO.Contabil.CentroCusto);
            // 
            // treeListCentros
            // 
            this.treeListCentros.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeListCentros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListCentros.Location = new System.Drawing.Point(0, 45);
            this.treeListCentros.Name = "treeListCentros";
            this.treeListCentros.OptionsBehavior.Editable = false;
            this.treeListCentros.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListCentros.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListCentros.Size = new System.Drawing.Size(776, 404);
            this.treeListCentros.TabIndex = 88;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Código";
            this.treeListColumn1.FieldName = "CodigoCentroCusto";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 168;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Centro de Custo";
            this.treeListColumn2.FieldName = "NomeCentroCusto";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 590;
            // 
            // XFrmViewCentroCustoTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 449);
            this.Controls.Add(this.treeListCentros);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmViewCentroCustoTree";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centros de Custo";
            this.Shown += new System.EventHandler(this.XFrmViewCentroCustoTree_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCentroCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCentros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barAction;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnEditar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarButtonItem barBtnNovo;
        private System.Windows.Forms.BindingSource bsCentroCusto;
        private DevExpress.XtraTreeList.TreeList treeListCentros;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraBars.BarButtonItem barBtnExpCollapse;
    }
}