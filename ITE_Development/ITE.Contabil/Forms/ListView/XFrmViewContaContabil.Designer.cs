namespace ITE.Contabil.Forms.ListView
{
    partial class XFrmViewContaContabil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewContaContabil));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnNovaConta = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnViewConta = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRemoveConta = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barExpandCollapse = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barCbMatriz = new DevExpress.XtraBars.BarEditItem();
            this.cbMatrizFilter = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.treeListContas = new DevExpress.XtraTreeList.TreeList();
            this.colMatriz = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCodigoConta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescricaoConta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCodigoReduzido = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdConta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMatrizFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListContas)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnNovaConta,
            this.barBtnViewConta,
            this.barBtnRemoveConta,
            this.barBtnRefresh,
            this.barExpandCollapse,
            this.barStaticItem1,
            this.barCbMatriz});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbMatrizFilter});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnNovaConta),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnViewConta),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRemoveConta),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExpandCollapse)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnNovaConta
            // 
            this.barBtnNovaConta.Caption = "Nova";
            this.barBtnNovaConta.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovaConta.Glyph")));
            this.barBtnNovaConta.Id = 0;
            this.barBtnNovaConta.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovaConta.LargeGlyph")));
            this.barBtnNovaConta.Name = "barBtnNovaConta";
            this.barBtnNovaConta.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnNovaConta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovaConta_ItemClick);
            // 
            // barBtnViewConta
            // 
            this.barBtnViewConta.Caption = "Detalhes";
            this.barBtnViewConta.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnViewConta.Glyph")));
            this.barBtnViewConta.Id = 1;
            this.barBtnViewConta.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnViewConta.LargeGlyph")));
            this.barBtnViewConta.Name = "barBtnViewConta";
            this.barBtnViewConta.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnViewConta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewConta_ItemClick);
            // 
            // barBtnRemoveConta
            // 
            this.barBtnRemoveConta.Caption = "Excluir";
            this.barBtnRemoveConta.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRemoveConta.Glyph")));
            this.barBtnRemoveConta.Id = 2;
            this.barBtnRemoveConta.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnRemoveConta.LargeGlyph")));
            this.barBtnRemoveConta.Name = "barBtnRemoveConta";
            this.barBtnRemoveConta.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnRemoveConta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRemoveConta_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Atualizar";
            this.barBtnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.Glyph")));
            this.barBtnRefresh.Id = 3;
            this.barBtnRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.LargeGlyph")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // barExpandCollapse
            // 
            this.barExpandCollapse.Caption = "Expandir/Recolher";
            this.barExpandCollapse.Glyph = ((System.Drawing.Image)(resources.GetObject("barExpandCollapse.Glyph")));
            this.barExpandCollapse.Id = 4;
            this.barExpandCollapse.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barExpandCollapse.LargeGlyph")));
            this.barExpandCollapse.Name = "barExpandCollapse";
            this.barExpandCollapse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barExpandCollapse_ItemClick);
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
            // bar2
            // 
            this.bar2.BarName = "Custom 4";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCbMatriz)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 4";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "    Filtrar matriz:";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barCbMatriz
            // 
            this.barCbMatriz.Caption = "Selecionar matriz";
            this.barCbMatriz.Edit = this.cbMatrizFilter;
            this.barCbMatriz.Id = 6;
            this.barCbMatriz.Name = "barCbMatriz";
            this.barCbMatriz.Size = new System.Drawing.Size(200, 0);
            // 
            // cbMatrizFilter
            // 
            this.cbMatrizFilter.AutoHeight = false;
            this.cbMatrizFilter.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMatrizFilter.Name = "cbMatrizFilter";
            this.cbMatrizFilter.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbMatrizFilter.SelectedIndexChanged += new System.EventHandler(this.cbMatrizFilter_SelectedIndexChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(935, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 457);
            this.barDockControlBottom.Size = new System.Drawing.Size(935, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(935, 51);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
            // 
            // treeListContas
            // 
            this.treeListContas.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colMatriz,
            this.colCodigoConta,
            this.colDescricaoConta,
            this.colCodigoReduzido,
            this.colIdConta});
            this.treeListContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListContas.Location = new System.Drawing.Point(0, 51);
            this.treeListContas.Name = "treeListContas";
            this.treeListContas.OptionsBehavior.Editable = false;
            this.treeListContas.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListContas.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListContas.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeListContas.OptionsView.AutoWidth = false;
            this.treeListContas.Size = new System.Drawing.Size(935, 406);
            this.treeListContas.TabIndex = 4;
            this.treeListContas.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListContas_FocusedNodeChanged);
            this.treeListContas.DoubleClick += new System.EventHandler(this.treeListContas_DoubleClick);
            // 
            // colMatriz
            // 
            this.colMatriz.Caption = "Matriz";
            this.colMatriz.FieldName = "CodigoMatriz";
            this.colMatriz.Name = "colMatriz";
            this.colMatriz.Visible = true;
            this.colMatriz.VisibleIndex = 0;
            this.colMatriz.Width = 123;
            // 
            // colCodigoConta
            // 
            this.colCodigoConta.Caption = "Código";
            this.colCodigoConta.FieldName = "CodigoContaContabil";
            this.colCodigoConta.Name = "colCodigoConta";
            this.colCodigoConta.Visible = true;
            this.colCodigoConta.VisibleIndex = 1;
            this.colCodigoConta.Width = 203;
            // 
            // colDescricaoConta
            // 
            this.colDescricaoConta.Caption = "Descrição";
            this.colDescricaoConta.FieldName = "DescricaoContaContabil";
            this.colDescricaoConta.Name = "colDescricaoConta";
            this.colDescricaoConta.Visible = true;
            this.colDescricaoConta.VisibleIndex = 2;
            this.colDescricaoConta.Width = 332;
            // 
            // colCodigoReduzido
            // 
            this.colCodigoReduzido.Caption = "Reduzido";
            this.colCodigoReduzido.FieldName = "CodigoReduzido";
            this.colCodigoReduzido.Name = "colCodigoReduzido";
            this.colCodigoReduzido.Visible = true;
            this.colCodigoReduzido.VisibleIndex = 3;
            this.colCodigoReduzido.Width = 144;
            // 
            // colIdConta
            // 
            this.colIdConta.Caption = "ID";
            this.colIdConta.FieldName = "IdContaContabil";
            this.colIdConta.Name = "colIdConta";
            this.colIdConta.Visible = true;
            this.colIdConta.VisibleIndex = 4;
            // 
            // XFrmViewContaContabil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 480);
            this.Controls.Add(this.treeListContas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmViewContaContabil";
            this.Text = "Contas contábeis";
            this.Shown += new System.EventHandler(this.XFrmViewContaContabil_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMatrizFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListContas)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem barBtnNovaConta;
        private DevExpress.XtraBars.BarButtonItem barBtnViewConta;
        private DevExpress.XtraBars.BarButtonItem barBtnRemoveConta;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraTreeList.TreeList treeListContas;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCodigoConta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescricaoConta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCodigoReduzido;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdConta;
        private DevExpress.XtraBars.BarButtonItem barExpandCollapse;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barCbMatriz;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbMatrizFilter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMatriz;
    }
}