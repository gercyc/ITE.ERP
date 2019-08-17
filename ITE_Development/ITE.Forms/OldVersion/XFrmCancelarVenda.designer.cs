namespace ITE.Forms.OldVersion
{
    partial class XFrmCancelarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCancelarVenda));
            this.gridControlProposta = new DevExpress.XtraGrid.GridControl();
            this.bsVenda = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProposta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barTxtId = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barBtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProposta
            // 
            this.gridControlProposta.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlProposta.DataSource = this.bsVenda;
            this.gridControlProposta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProposta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Location = new System.Drawing.Point(0, 57);
            this.gridControlProposta.MainView = this.gridViewProposta;
            this.gridControlProposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlProposta.Name = "gridControlProposta";
            this.gridControlProposta.Size = new System.Drawing.Size(883, 534);
            this.gridControlProposta.TabIndex = 0;
            this.gridControlProposta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProposta});
            // 
            // bsVenda
            // 
            this.bsVenda.DataSource = typeof(ITE.Entidades.POCO.Sales.Venda);
            // 
            // gridViewProposta
            // 
            this.gridViewProposta.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewProposta.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewProposta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdVenda,
            this.colStatusVenda,
            this.colDataVenda,
            this.colTotalVenda,
            this.colCliFor,
            this.colUsuario,
            this.colTipo});
            this.gridViewProposta.GridControl = this.gridControlProposta;
            this.gridViewProposta.Name = "gridViewProposta";
            this.gridViewProposta.OptionsBehavior.Editable = false;
            this.gridViewProposta.OptionsView.ColumnAutoWidth = false;
            this.gridViewProposta.OptionsView.ShowGroupPanel = false;
            this.gridViewProposta.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProposta_FocusedRowChanged);
            this.gridViewProposta.DoubleClick += new System.EventHandler(this.gridViewProposta_DoubleClick);
            // 
            // colIdVenda
            // 
            this.colIdVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colIdVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdVenda.Caption = "Nº Venda";
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.OptionsColumn.AllowEdit = false;
            this.colIdVenda.OptionsColumn.AllowShowHide = false;
            this.colIdVenda.Visible = true;
            this.colIdVenda.VisibleIndex = 0;
            this.colIdVenda.Width = 85;
            // 
            // colStatusVenda
            // 
            this.colStatusVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colStatusVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatusVenda.Caption = "Situação";
            this.colStatusVenda.FieldName = "StatusVenda";
            this.colStatusVenda.Name = "colStatusVenda";
            this.colStatusVenda.OptionsColumn.AllowEdit = false;
            this.colStatusVenda.OptionsColumn.AllowShowHide = false;
            this.colStatusVenda.Visible = true;
            this.colStatusVenda.VisibleIndex = 2;
            this.colStatusVenda.Width = 97;
            // 
            // colDataVenda
            // 
            this.colDataVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colDataVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVenda.Caption = "Data Venda";
            this.colDataVenda.FieldName = "DataVenda";
            this.colDataVenda.Name = "colDataVenda";
            this.colDataVenda.OptionsColumn.AllowEdit = false;
            this.colDataVenda.OptionsColumn.AllowShowHide = false;
            this.colDataVenda.Visible = true;
            this.colDataVenda.VisibleIndex = 3;
            this.colDataVenda.Width = 83;
            // 
            // colTotalVenda
            // 
            this.colTotalVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalVenda.Caption = "Total Venda";
            this.colTotalVenda.DisplayFormat.FormatString = "n2";
            this.colTotalVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalVenda.FieldName = "TotalVenda";
            this.colTotalVenda.Name = "colTotalVenda";
            this.colTotalVenda.OptionsColumn.AllowEdit = false;
            this.colTotalVenda.OptionsColumn.AllowShowHide = false;
            this.colTotalVenda.Visible = true;
            this.colTotalVenda.VisibleIndex = 5;
            this.colTotalVenda.Width = 120;
            // 
            // colCliFor
            // 
            this.colCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliFor.Caption = "Cliente";
            this.colCliFor.FieldName = "CliFor.RazaoSocial";
            this.colCliFor.Name = "colCliFor";
            this.colCliFor.OptionsColumn.AllowEdit = false;
            this.colCliFor.OptionsColumn.AllowShowHide = false;
            this.colCliFor.Visible = true;
            this.colCliFor.VisibleIndex = 4;
            this.colCliFor.Width = 350;
            // 
            // colUsuario
            // 
            this.colUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUsuario.Caption = "Vendedor";
            this.colUsuario.FieldName = "Usuario.NomeUsuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.OptionsColumn.AllowEdit = false;
            this.colUsuario.OptionsColumn.AllowShowHide = false;
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 6;
            this.colUsuario.Width = 200;
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "TipoMovimento";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 1;
            this.colTipo.Width = 84;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 5;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1,
            this.repositoryItemTextEdit1});
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 57);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(883, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 591);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(883, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 534);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(883, 57);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 534);
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnCancelar,
            this.barBtnAtualizar,
            this.barStaticItem1,
            this.barTxtId});
            this.barManager2.MaxItemId = 7;
            this.barManager2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barTxtId),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCancelar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.DrawSizeGrip = true;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Nº Venda\\Cotação";
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barTxtId
            // 
            this.barTxtId.Caption = "Venda\\Cotação";
            this.barTxtId.Edit = this.repositoryItemTextEdit2;
            this.barTxtId.EditWidth = 221;
            this.barTxtId.Id = 3;
            this.barTxtId.Name = "barTxtId";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Mask.EditMask = "n0";
            this.repositoryItemTextEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.NullText = "Informe o número da venda ";
            // 
            // barBtnCancelar
            // 
            this.barBtnCancelar.Caption = "Cancelar";
            this.barBtnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.Glyph")));
            this.barBtnCancelar.Id = 0;
            this.barBtnCancelar.Name = "barBtnCancelar";
            this.barBtnCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelar_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 1;
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(883, 57);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 613);
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(883, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 57);
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(0, 556);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(883, 57);
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(0, 556);
            // 
            // XFrmCancelarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 613);
            this.Controls.Add(this.gridControlProposta);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmCancelarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelamento Venda";
            this.Shown += new System.EventHandler(this.XFrmCancelarProposta_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProposta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProposta;
        private System.Windows.Forms.BindingSource bsVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusVenda;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barTxtId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
    }
}