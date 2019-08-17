namespace ITE.DataControl.Forms 
{
    partial class XFrmViewDbf
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewDbf));
            this.txtFileDbf = new DevExpress.XtraEditors.TextEdit();
            this.gridControlimport = new DevExpress.XtraGrid.GridControl();
            this.gridViewImport = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnImportar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnIndexar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExportarExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoadLayout = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.openFileDbf = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectFileDbf = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileDbf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlimport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileDbf
            // 
            this.txtFileDbf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileDbf.Location = new System.Drawing.Point(3, 2);
            this.txtFileDbf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFileDbf.Name = "txtFileDbf";
            this.txtFileDbf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFileDbf.Properties.Appearance.Options.UseFont = true;
            this.txtFileDbf.Properties.ReadOnly = true;
            this.txtFileDbf.Size = new System.Drawing.Size(926, 28);
            this.txtFileDbf.TabIndex = 0;
            // 
            // gridControlimport
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gridControlimport, 2);
            this.gridControlimport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlimport.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlimport.Location = new System.Drawing.Point(3, 34);
            this.gridControlimport.MainView = this.gridViewImport;
            this.gridControlimport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlimport.MenuManager = this.barManager1;
            this.gridControlimport.Name = "gridControlimport";
            this.gridControlimport.Size = new System.Drawing.Size(1000, 606);
            this.gridControlimport.TabIndex = 5;
            this.gridControlimport.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewImport});
            // 
            // gridViewImport
            // 
            this.gridViewImport.GridControl = this.gridControlimport;
            this.gridViewImport.Name = "gridViewImport";
            this.gridViewImport.OptionsView.ColumnAutoWidth = false;
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
            this.barBtnImportar,
            this.barBtnAtualizar,
            this.barBtnIndexar,
            this.barBtnExportarExcel,
            this.btnLoadLayout});
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnImportar, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnIndexar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnExportarExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoadLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnImportar
            // 
            this.barBtnImportar.Caption = "ImportarProducao";
            this.barBtnImportar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnImportar.Glyph")));
            this.barBtnImportar.Id = 0;
            this.barBtnImportar.Name = "barBtnImportar";
            this.barBtnImportar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnImportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnImportar_ItemClick);
            // 
            // barBtnIndexar
            // 
            this.barBtnIndexar.Caption = "Indexar";
            this.barBtnIndexar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnIndexar.Glyph")));
            this.barBtnIndexar.Id = 2;
            this.barBtnIndexar.Name = "barBtnIndexar";
            this.barBtnIndexar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnIndexar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnIndexar_ItemClick);
            // 
            // barBtnExportarExcel
            // 
            this.barBtnExportarExcel.Caption = "Exportar Excel";
            this.barBtnExportarExcel.Enabled = false;
            this.barBtnExportarExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExportarExcel.Glyph")));
            this.barBtnExportarExcel.Id = 3;
            this.barBtnExportarExcel.Name = "barBtnExportarExcel";
            this.barBtnExportarExcel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnExportarExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExportarExcel_ItemClick);
            // 
            // btnLoadLayout
            // 
            this.btnLoadLayout.Caption = "ImportarProducao usando XML";
            this.btnLoadLayout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLoadLayout.Glyph")));
            this.btnLoadLayout.Id = 4;
            this.btnLoadLayout.Name = "btnLoadLayout";
            this.btnLoadLayout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem1.Text = "Importação via mapeamento XML";
            toolTipItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem1.Image")));
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Selecionar um arquivo XML com a definição do layout para importação para o banco " +
    "de dados.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnLoadLayout.SuperTip = superToolTip1;
            this.btnLoadLayout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoadLayout_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 1;
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1006, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 699);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1006, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 642);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1006, 57);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 642);
            // 
            // openFileDbf
            // 
            this.openFileDbf.Filter = "Files DBF |*.DBF; *.dbf";
            this.openFileDbf.Title = "Selecionar arquivo DBF";
            // 
            // btnSelectFileDbf
            // 
            this.btnSelectFileDbf.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSelectFileDbf.Appearance.Options.UseFont = true;
            this.btnSelectFileDbf.Appearance.Options.UseTextOptions = true;
            this.btnSelectFileDbf.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnSelectFileDbf.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnSelectFileDbf.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFileDbf.Image")));
            this.btnSelectFileDbf.Location = new System.Drawing.Point(935, 2);
            this.btnSelectFileDbf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectFileDbf.Name = "btnSelectFileDbf";
            this.btnSelectFileDbf.Size = new System.Drawing.Size(60, 25);
            this.btnSelectFileDbf.TabIndex = 1;
            this.btnSelectFileDbf.Text = "...";
            this.btnSelectFileDbf.Click += new System.EventHandler(this.btnSelectFileDbf_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Controls.Add(this.txtFileDbf, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControlimport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectFileDbf, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.140187F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.85981F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1006, 642);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // XFrmViewDbf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmViewDbf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportarProducao dados LSC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.txtFileDbf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlimport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtFileDbf;
        private System.Windows.Forms.OpenFileDialog openFileDbf;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlimport;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewImport;
        private DevExpress.XtraBars.BarButtonItem barBtnImportar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarButtonItem barBtnIndexar;
        private DevExpress.XtraBars.BarButtonItem barBtnExportarExcel;
        private DevExpress.XtraBars.BarButtonItem btnLoadLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnSelectFileDbf;
    }
}