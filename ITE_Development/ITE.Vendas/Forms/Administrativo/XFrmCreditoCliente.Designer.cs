namespace ITE.Vendas.Forms.Administrativo
{
    partial class XFrmCreditoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCreditoCliente));
            this.groupControlCredito = new DevExpress.XtraEditors.GroupControl();
            this.txtHistorico = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnLancarCredito = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRemoverCredito = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtCredito = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewCredito = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHistorico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCredito)).BeginInit();
            this.groupControlCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlCredito
            // 
            this.groupControlCredito.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControlCredito.AppearanceCaption.Options.UseFont = true;
            this.groupControlCredito.Controls.Add(this.txtHistorico);
            this.groupControlCredito.Controls.Add(this.txtCredito);
            this.groupControlCredito.Controls.Add(this.labelControl2);
            this.groupControlCredito.Controls.Add(this.labelControl1);
            this.groupControlCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlCredito.Location = new System.Drawing.Point(0, 0);
            this.groupControlCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControlCredito.Name = "groupControlCredito";
            this.groupControlCredito.Size = new System.Drawing.Size(513, 127);
            this.groupControlCredito.TabIndex = 0;
            this.groupControlCredito.Text = "Gerenciador de Crédito";
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(17, 99);
            this.txtHistorico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHistorico.MenuManager = this.barManager1;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Properties.Appearance.Options.UseFont = true;
            this.txtHistorico.Properties.MaxLength = 100;
            this.txtHistorico.Size = new System.Drawing.Size(453, 20);
            this.txtHistorico.TabIndex = 3;
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
            this.barBtnLancarCredito,
            this.barBtnRemoverCredito,
            this.barBtnSalvar});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnLancarCredito),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRemoverCredito),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnSalvar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnLancarCredito
            // 
            this.barBtnLancarCredito.Caption = "Lançar Crédito";
            this.barBtnLancarCredito.Glyph = global::ITE.Vendas.Properties.Resources.add_money32x32;
            this.barBtnLancarCredito.Id = 0;
            this.barBtnLancarCredito.Name = "barBtnLancarCredito";
            this.barBtnLancarCredito.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnLancarCredito.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLancarCredito_ItemClick);
            // 
            // barBtnRemoverCredito
            // 
            this.barBtnRemoverCredito.Caption = "Remover Crédito";
            this.barBtnRemoverCredito.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRemoverCredito.Glyph")));
            this.barBtnRemoverCredito.Id = 1;
            this.barBtnRemoverCredito.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnRemoverCredito.LargeGlyph")));
            this.barBtnRemoverCredito.Name = "barBtnRemoverCredito";
            this.barBtnRemoverCredito.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnRemoverCredito.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRemoverCredito_ItemClick);
            // 
            // barBtnSalvar
            // 
            this.barBtnSalvar.Caption = "Salvar";
            this.barBtnSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.Glyph")));
            this.barBtnSalvar.Id = 2;
            this.barBtnSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSalvar.LargeGlyph")));
            this.barBtnSalvar.Name = "barBtnSalvar";
            this.barBtnSalvar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSalvar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(513, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 427);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(513, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 382);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(513, 45);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 382);
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(17, 54);
            this.txtCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCredito.MenuManager = this.barManager1;
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtCredito.Properties.Appearance.Options.UseFont = true;
            this.txtCredito.Properties.Appearance.Options.UseForeColor = true;
            this.txtCredito.Size = new System.Drawing.Size(158, 20);
            this.txtCredito.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(17, 79);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Histórico:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(17, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Valor Crédito:";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridViewCredito;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(513, 252);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCredito});
            // 
            // gridViewCredito
            // 
            this.gridViewCredito.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCredito.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewCredito.Appearance.Row.Options.UseFont = true;
            this.gridViewCredito.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCredito,
            this.colIdCliFor,
            this.colCliFor,
            this.colDataCredito,
            this.colValorCredito,
            this.colHistorico});
            this.gridViewCredito.GridControl = this.gridControl1;
            this.gridViewCredito.Name = "gridViewCredito";
            this.gridViewCredito.OptionsSelection.MultiSelect = true;
            this.gridViewCredito.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewCredito.OptionsView.ShowFooter = true;
            this.gridViewCredito.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCredito
            // 
            this.colIdCredito.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCredito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCredito.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCredito.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCredito.Caption = "Ref.";
            this.colIdCredito.FieldName = "IdCredito";
            this.colIdCredito.Name = "colIdCredito";
            this.colIdCredito.OptionsColumn.AllowEdit = false;
            this.colIdCredito.OptionsColumn.AllowMove = false;
            this.colIdCredito.Width = 259;
            // 
            // colIdCliFor
            // 
            this.colIdCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliFor.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCliFor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliFor.FieldName = "IdCliFor";
            this.colIdCliFor.Name = "colIdCliFor";
            this.colIdCliFor.OptionsColumn.AllowEdit = false;
            this.colIdCliFor.OptionsColumn.AllowMove = false;
            this.colIdCliFor.OptionsColumn.AllowShowHide = false;
            // 
            // colCliFor
            // 
            this.colCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliFor.AppearanceHeader.Options.UseTextOptions = true;
            this.colCliFor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliFor.Caption = "Cliente";
            this.colCliFor.FieldName = "CliFor";
            this.colCliFor.Name = "colCliFor";
            this.colCliFor.OptionsColumn.AllowEdit = false;
            this.colCliFor.OptionsColumn.AllowMove = false;
            this.colCliFor.OptionsColumn.AllowShowHide = false;
            // 
            // colDataCredito
            // 
            this.colDataCredito.AppearanceCell.Options.UseTextOptions = true;
            this.colDataCredito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataCredito.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataCredito.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataCredito.Caption = "Data Crédito";
            this.colDataCredito.FieldName = "DataCredito";
            this.colDataCredito.Name = "colDataCredito";
            this.colDataCredito.OptionsColumn.AllowEdit = false;
            this.colDataCredito.OptionsColumn.AllowMove = false;
            this.colDataCredito.OptionsColumn.AllowShowHide = false;
            this.colDataCredito.Visible = true;
            this.colDataCredito.VisibleIndex = 1;
            this.colDataCredito.Width = 251;
            // 
            // colValorCredito
            // 
            this.colValorCredito.AppearanceCell.Options.UseTextOptions = true;
            this.colValorCredito.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorCredito.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorCredito.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorCredito.Caption = "Valor Crédito";
            this.colValorCredito.FieldName = "ValorCredito";
            this.colValorCredito.Name = "colValorCredito";
            this.colValorCredito.OptionsColumn.AllowEdit = false;
            this.colValorCredito.OptionsColumn.AllowMove = false;
            this.colValorCredito.OptionsColumn.AllowShowHide = false;
            this.colValorCredito.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorCredito", "TOTAL: {0:N2}")});
            this.colValorCredito.Visible = true;
            this.colValorCredito.VisibleIndex = 2;
            this.colValorCredito.Width = 242;
            // 
            // colHistorico
            // 
            this.colHistorico.AppearanceCell.Options.UseTextOptions = true;
            this.colHistorico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistorico.AppearanceHeader.Options.UseTextOptions = true;
            this.colHistorico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colHistorico.Caption = "Histórico";
            this.colHistorico.FieldName = "Historico";
            this.colHistorico.Name = "colHistorico";
            this.colHistorico.OptionsColumn.AllowEdit = false;
            this.colHistorico.OptionsColumn.AllowMove = false;
            this.colHistorico.OptionsColumn.AllowShowHide = false;
            this.colHistorico.Visible = true;
            this.colHistorico.VisibleIndex = 3;
            this.colHistorico.Width = 803;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 45);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControlCredito);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(513, 382);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // XFrmCreditoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 448);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XFrmCreditoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlCredito)).EndInit();
            this.groupControlCredito.ResumeLayout(false);
            this.groupControlCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCredito)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlCredito;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCredito;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colHistorico;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnLancarCredito;
        private DevExpress.XtraBars.BarButtonItem barBtnRemoverCredito;
        private DevExpress.XtraBars.BarButtonItem barBtnSalvar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit txtHistorico;
        private DevExpress.XtraEditors.TextEdit txtCredito;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}