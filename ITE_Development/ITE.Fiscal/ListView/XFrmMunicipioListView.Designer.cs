namespace ITE.Fiscal.ListView
{
    partial class XFrmMunicipioListView
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
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem12 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmMunicipioListView));
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            this.gridControlMunicipios = new DevExpress.XtraGrid.GridControl();
            this.bsMunicipios = new System.Windows.Forms.BindingSource();
            this.gridViewMunicipios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNomeMunicipio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoIbge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadeFederacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnAddMunicipio = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnViewMunicipio = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMunicipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMunicipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMunicipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMunicipios
            // 
            this.gridControlMunicipios.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMunicipios.DataSource = this.bsMunicipios;
            this.gridControlMunicipios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMunicipios.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlMunicipios.Location = new System.Drawing.Point(0, 57);
            this.gridControlMunicipios.MainView = this.gridViewMunicipios;
            this.gridControlMunicipios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlMunicipios.Name = "gridControlMunicipios";
            this.gridControlMunicipios.Size = new System.Drawing.Size(951, 422);
            this.gridControlMunicipios.TabIndex = 1;
            this.gridControlMunicipios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMunicipios});
            this.gridControlMunicipios.DoubleClick += new System.EventHandler(this.gridViewLocaisEstoque_DoubleClick);
            // 
            // bsMunicipios
            // 
            this.bsMunicipios.DataSource = typeof(ITE.Entidades.POCO.Fiscal.Municipios);
            // 
            // gridViewMunicipios
            // 
            this.gridViewMunicipios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNomeMunicipio,
            this.colCodigoIbge,
            this.colUnidadeFederacao});
            this.gridViewMunicipios.GridControl = this.gridControlMunicipios;
            this.gridViewMunicipios.Name = "gridViewMunicipios";
            this.gridViewMunicipios.OptionsBehavior.Editable = false;
            this.gridViewMunicipios.OptionsView.RowAutoHeight = true;
            this.gridViewMunicipios.OptionsView.ShowGroupPanel = false;
            // 
            // colNomeMunicipio
            // 
            this.colNomeMunicipio.Caption = "Município";
            this.colNomeMunicipio.FieldName = "NomeMunicipio";
            this.colNomeMunicipio.Name = "colNomeMunicipio";
            this.colNomeMunicipio.Visible = true;
            this.colNomeMunicipio.VisibleIndex = 2;
            this.colNomeMunicipio.Width = 234;
            // 
            // colCodigoIbge
            // 
            this.colCodigoIbge.Caption = "Cód IBGE";
            this.colCodigoIbge.FieldName = "CodigoIbge";
            this.colCodigoIbge.Name = "colCodigoIbge";
            this.colCodigoIbge.Visible = true;
            this.colCodigoIbge.VisibleIndex = 0;
            this.colCodigoIbge.Width = 200;
            // 
            // colUnidadeFederacao
            // 
            this.colUnidadeFederacao.Caption = "UF";
            this.colUnidadeFederacao.FieldName = "UnidadeFederacao.CodigoUF";
            this.colUnidadeFederacao.Name = "colUnidadeFederacao";
            this.colUnidadeFederacao.Visible = true;
            this.colUnidadeFederacao.VisibleIndex = 1;
            this.colUnidadeFederacao.Width = 140;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
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
            this.barBtnAddMunicipio.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAddMunicipio.Glyph")));
            this.barBtnAddMunicipio.Id = 1;
            this.barBtnAddMunicipio.Name = "barBtnAddMunicipio";
            this.barBtnAddMunicipio.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem11.Text = "Adicionar NF";
            toolTipItem11.LeftIndent = 6;
            toolTipItem11.Text = "Permite a inclusão de uma nova nota fiscal no sistema.";
            superToolTip11.Items.Add(toolTipTitleItem11);
            superToolTip11.Items.Add(toolTipItem11);
            this.barBtnAddMunicipio.SuperTip = superToolTip11;
            this.barBtnAddMunicipio.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnAddMunicipio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddMunicipio_ItemClick);
            // 
            // barBtnViewMunicipio
            // 
            this.barBtnViewMunicipio.Caption = "Visualizar/Editar";
            this.barBtnViewMunicipio.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnViewMunicipio.Glyph")));
            this.barBtnViewMunicipio.Id = 3;
            this.barBtnViewMunicipio.Name = "barBtnViewMunicipio";
            this.barBtnViewMunicipio.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem12.Text = "Cancelar";
            toolTipItem12.LeftIndent = 6;
            toolTipItem12.Text = "Permite o cancelamento de uma nota fiscal já registrada no sistema.";
            superToolTip12.Items.Add(toolTipTitleItem12);
            superToolTip12.Items.Add(toolTipItem12);
            this.barBtnViewMunicipio.SuperTip = superToolTip12;
            this.barBtnViewMunicipio.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnViewMunicipio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnViewLocalEstoque_Click);
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
            this.barDockControlTop.Size = new System.Drawing.Size(951, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 479);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(951, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 422);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(951, 57);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 422);
            // 
            // XFrmViewMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 501);
            this.Controls.Add(this.gridControlMunicipios);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmViewMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municípios";
            this.Shown += new System.EventHandler(this.XFrmGerenciarMunicipios_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMunicipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMunicipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMunicipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMunicipios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMunicipios;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnAddMunicipio;
        private DevExpress.XtraBars.BarButtonItem barBtnViewMunicipio;
        private System.Windows.Forms.BindingSource bsMunicipios;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeMunicipio;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoIbge;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadeFederacao;
    }
}