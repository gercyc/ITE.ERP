namespace ITE.Fiscal.ListView
{
    partial class XFrmNcmListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmNcmListView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsNcms = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnAddMunicipio = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnViewMunicipio = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.colIdNcm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoNcm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoNcm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadeMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaII = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaPIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaCOFINS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaICMSST = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNcms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.bsNcms;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(759, 334);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsNcms
            // 
            this.bsNcms.DataSource = typeof(ITE.Entidades.POCO.Fiscal.Ncms);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNcm,
            this.colCodigoNcm,
            this.colDescricaoNcm,
            this.colUnidadeMedida,
            this.colAliquotaII,
            this.colAliquotaIPI,
            this.colAliquotaPIS,
            this.colAliquotaCOFINS,
            this.colAliquotaICMS,
            this.colAliquotaICMSST});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.barBtnRefresh,
            this.barBtnAddMunicipio,
            this.barBtnViewMunicipio});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAddMunicipio),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnViewMunicipio),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRefresh)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnAddMunicipio
            // 
            this.barBtnAddMunicipio.Caption = "Novo";
            this.barBtnAddMunicipio.Id = 1;
            this.barBtnAddMunicipio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddMunicipio.ImageOptions.Image")));
            this.barBtnAddMunicipio.Name = "barBtnAddMunicipio";
            this.barBtnAddMunicipio.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem1.Text = "Adicionar NF";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Permite a inclusão de uma nova nota fiscal no sistema.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barBtnAddMunicipio.SuperTip = superToolTip1;
            this.barBtnAddMunicipio.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barBtnViewMunicipio
            // 
            this.barBtnViewMunicipio.Caption = "Visualizar/Editar";
            this.barBtnViewMunicipio.Id = 3;
            this.barBtnViewMunicipio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnViewMunicipio.ImageOptions.Image")));
            this.barBtnViewMunicipio.Name = "barBtnViewMunicipio";
            this.barBtnViewMunicipio.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Cancelar";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Permite o cancelamento de uma nota fiscal já registrada no sistema.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barBtnViewMunicipio.SuperTip = superToolTip2;
            this.barBtnViewMunicipio.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnViewMunicipio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnViewMunicipio_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Atualizar";
            this.barBtnRefresh.Id = 0;
            this.barBtnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.ImageOptions.Image")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem3.Text = "Atualizar";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Atualiza a visão de notas fiscais cadastradas.";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.barBtnRefresh.SuperTip = superToolTip3;
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(759, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 381);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(759, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 334);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(759, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 334);
            // 
            // colIdNcm
            // 
            this.colIdNcm.FieldName = "IdNcm";
            this.colIdNcm.Name = "colIdNcm";
            this.colIdNcm.Visible = true;
            this.colIdNcm.VisibleIndex = 0;
            // 
            // colCodigoNcm
            // 
            this.colCodigoNcm.FieldName = "CodigoNcm";
            this.colCodigoNcm.Name = "colCodigoNcm";
            this.colCodigoNcm.Visible = true;
            this.colCodigoNcm.VisibleIndex = 1;
            // 
            // colDescricaoNcm
            // 
            this.colDescricaoNcm.FieldName = "DescricaoNcm";
            this.colDescricaoNcm.Name = "colDescricaoNcm";
            this.colDescricaoNcm.Visible = true;
            this.colDescricaoNcm.VisibleIndex = 2;
            // 
            // colUnidadeMedida
            // 
            this.colUnidadeMedida.FieldName = "UnidadeMedida";
            this.colUnidadeMedida.Name = "colUnidadeMedida";
            this.colUnidadeMedida.Visible = true;
            this.colUnidadeMedida.VisibleIndex = 3;
            // 
            // colAliquotaII
            // 
            this.colAliquotaII.FieldName = "AliquotaII";
            this.colAliquotaII.Name = "colAliquotaII";
            this.colAliquotaII.Visible = true;
            this.colAliquotaII.VisibleIndex = 4;
            // 
            // colAliquotaIPI
            // 
            this.colAliquotaIPI.FieldName = "AliquotaIPI";
            this.colAliquotaIPI.Name = "colAliquotaIPI";
            this.colAliquotaIPI.Visible = true;
            this.colAliquotaIPI.VisibleIndex = 5;
            // 
            // colAliquotaPIS
            // 
            this.colAliquotaPIS.FieldName = "AliquotaPIS";
            this.colAliquotaPIS.Name = "colAliquotaPIS";
            this.colAliquotaPIS.Visible = true;
            this.colAliquotaPIS.VisibleIndex = 6;
            // 
            // colAliquotaCOFINS
            // 
            this.colAliquotaCOFINS.FieldName = "AliquotaCOFINS";
            this.colAliquotaCOFINS.Name = "colAliquotaCOFINS";
            this.colAliquotaCOFINS.Visible = true;
            this.colAliquotaCOFINS.VisibleIndex = 7;
            // 
            // colAliquotaICMS
            // 
            this.colAliquotaICMS.FieldName = "AliquotaICMS";
            this.colAliquotaICMS.Name = "colAliquotaICMS";
            this.colAliquotaICMS.Visible = true;
            this.colAliquotaICMS.VisibleIndex = 8;
            // 
            // colAliquotaICMSST
            // 
            this.colAliquotaICMSST.FieldName = "AliquotaICMSST";
            this.colAliquotaICMSST.Name = "colAliquotaICMSST";
            this.colAliquotaICMSST.Visible = true;
            this.colAliquotaICMSST.VisibleIndex = 9;
            // 
            // XFrmNcmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 404);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmNcmListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de NCMs";
            this.Shown += new System.EventHandler(this.XFrmViewNcm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNcms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnAddMunicipio;
        private DevExpress.XtraBars.BarButtonItem barBtnViewMunicipio;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bsNcms;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNcm;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoNcm;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoNcm;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadeMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaII;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaIPI;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaPIS;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaCOFINS;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaICMSST;
    }
}