namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmUnidMedidaListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmUnidMedidaListView));
            this.gridControlUnidMedidas = new DevExpress.XtraGrid.GridControl();
            this.bsUnidadeMedida = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewUnidMedidas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadeMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeUnidadeMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUnidMedidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnidadeMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnidMedidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUnidMedidas
            // 
            this.gridControlUnidMedidas.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlUnidMedidas.DataSource = this.bsUnidadeMedida;
            this.gridControlUnidMedidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUnidMedidas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlUnidMedidas.Location = new System.Drawing.Point(0, 59);
            this.gridControlUnidMedidas.MainView = this.gridViewUnidMedidas;
            this.gridControlUnidMedidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlUnidMedidas.Name = "gridControlUnidMedidas";
            this.gridControlUnidMedidas.Size = new System.Drawing.Size(890, 438);
            this.gridControlUnidMedidas.TabIndex = 1;
            this.gridControlUnidMedidas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUnidMedidas});
            this.gridControlUnidMedidas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridControlUnidMedidas_MouseDoubleClick);
            // 
            // bsUnidadeMedida
            // 
            this.bsUnidadeMedida.DataSource = typeof(ITE.Entidades.POCO.Sales.UnidadeMedida);
            // 
            // gridViewUnidMedidas
            // 
            this.gridViewUnidMedidas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUnidadeMedida,
            this.colNomeUnidadeMedida,
            this.colDescricao});
            this.gridViewUnidMedidas.GridControl = this.gridControlUnidMedidas;
            this.gridViewUnidMedidas.Name = "gridViewUnidMedidas";
            this.gridViewUnidMedidas.OptionsBehavior.Editable = false;
            this.gridViewUnidMedidas.OptionsView.ColumnAutoWidth = false;
            this.gridViewUnidMedidas.OptionsView.ShowGroupPanel = false;
            this.gridViewUnidMedidas.DoubleClick += new System.EventHandler(this.gridViewUnidMedidas_DoubleClick);
            // 
            // colIdUnidadeMedida
            // 
            this.colIdUnidadeMedida.AppearanceCell.Options.UseTextOptions = true;
            this.colIdUnidadeMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUnidadeMedida.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdUnidadeMedida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUnidadeMedida.Caption = "ID";
            this.colIdUnidadeMedida.FieldName = "IdUnidadeMedida";
            this.colIdUnidadeMedida.Name = "colIdUnidadeMedida";
            this.colIdUnidadeMedida.Visible = true;
            this.colIdUnidadeMedida.VisibleIndex = 0;
            // 
            // colNomeUnidadeMedida
            // 
            this.colNomeUnidadeMedida.AppearanceCell.Options.UseTextOptions = true;
            this.colNomeUnidadeMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeUnidadeMedida.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeUnidadeMedida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeUnidadeMedida.Caption = "Código Unidade Medida";
            this.colNomeUnidadeMedida.FieldName = "NomeUnidadeMedida";
            this.colNomeUnidadeMedida.Name = "colNomeUnidadeMedida";
            this.colNomeUnidadeMedida.Visible = true;
            this.colNomeUnidadeMedida.VisibleIndex = 1;
            this.colNomeUnidadeMedida.Width = 187;
            // 
            // colDescricao
            // 
            this.colDescricao.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricao.Caption = "Descrição da Unidade de Medida";
            this.colDescricao.FieldName = "Descricao";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Visible = true;
            this.colDescricao.VisibleIndex = 2;
            this.colDescricao.Width = 557;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnNovo,
            this.barBtnEditar,
            this.barBtnAtualizar});
            this.barManager1.MaxItemId = 7;
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
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnNovo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 4";
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.Caption = "Novo";
            this.barBtnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Glyph")));
            this.barBtnNovo.Id = 4;
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovo_ItemClick);
            // 
            // barBtnEditar
            // 
            this.barBtnEditar.Caption = "Editar";
            this.barBtnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditar.Glyph")));
            this.barBtnEditar.Id = 5;
            this.barBtnEditar.Name = "barBtnEditar";
            this.barBtnEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterar_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 6;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizar.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(890, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 497);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(890, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 438);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(890, 59);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 438);
            // 
            // XFrmViewUnidMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 522);
            this.Controls.Add(this.gridControlUnidMedidas);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmViewUnidMedidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades Medida";
            this.Shown += new System.EventHandler(this.XFrmGerenciarUnidMedidas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUnidMedidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnidadeMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnidMedidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUnidMedidas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUnidMedidas;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bsUnidadeMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeUnidadeMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricao;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnNovo;
        private DevExpress.XtraBars.BarButtonItem barBtnEditar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadeMedida;
    }
}