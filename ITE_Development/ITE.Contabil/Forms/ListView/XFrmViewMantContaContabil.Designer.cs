namespace ITE.Contabil.Forms.ListView
{
    partial class XFrmViewMantContaContabil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewMantContaContabil));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnNovaConta = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnViewConta = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRemoveConta = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barCbMatriz = new DevExpress.XtraBars.BarEditItem();
            this.cbMatrizFilter = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contaContabilBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdContaContabil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoContaContabil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoReduzido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoContaContabil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndAnaliticaSintetica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoContaSped = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNatureza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInclusao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataAlteracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMatrizFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaContabilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRefresh)});
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 459);
            this.barDockControlBottom.Size = new System.Drawing.Size(935, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 408);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(935, 51);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.contaContabilBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 51);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(935, 408);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // contaContabilBindingSource
            // 
            this.contaContabilBindingSource.DataSource = typeof(ITE.Entidades.POCO.Contabil.ContaContabil);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdContaContabil,
            this.colIdMatriz,
            this.colCodigoContaContabil,
            this.colCodigoReduzido,
            this.colDescricaoContaContabil,
            this.colIndAnaliticaSintetica,
            this.colTipoContaSped,
            this.colNatureza,
            this.colNivel,
            this.colDataInclusao,
            this.colDataAlteracao,
            this.colMatriz});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colIndAnaliticaSintetica;
            gridFormatRule1.Name = "Sintetica";
            formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleExpression1.Appearance.Options.UseFont = true;
            formatConditionRuleExpression1.Expression = "[IndAnaliticaSintetica] = \'Sintetica\'";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colIdContaContabil
            // 
            this.colIdContaContabil.FieldName = "IdContaContabil";
            this.colIdContaContabil.Name = "colIdContaContabil";
            // 
            // colIdMatriz
            // 
            this.colIdMatriz.FieldName = "IdMatriz";
            this.colIdMatriz.Name = "colIdMatriz";
            // 
            // colCodigoContaContabil
            // 
            this.colCodigoContaContabil.FieldName = "CodigoContaContabil";
            this.colCodigoContaContabil.Name = "colCodigoContaContabil";
            this.colCodigoContaContabil.Visible = true;
            this.colCodigoContaContabil.VisibleIndex = 1;
            this.colCodigoContaContabil.Width = 125;
            // 
            // colCodigoReduzido
            // 
            this.colCodigoReduzido.FieldName = "CodigoReduzido";
            this.colCodigoReduzido.Name = "colCodigoReduzido";
            this.colCodigoReduzido.Visible = true;
            this.colCodigoReduzido.VisibleIndex = 3;
            this.colCodigoReduzido.Width = 95;
            // 
            // colDescricaoContaContabil
            // 
            this.colDescricaoContaContabil.FieldName = "DescricaoContaContabil";
            this.colDescricaoContaContabil.Name = "colDescricaoContaContabil";
            this.colDescricaoContaContabil.Visible = true;
            this.colDescricaoContaContabil.VisibleIndex = 2;
            this.colDescricaoContaContabil.Width = 270;
            // 
            // colIndAnaliticaSintetica
            // 
            this.colIndAnaliticaSintetica.FieldName = "IndAnaliticaSintetica";
            this.colIndAnaliticaSintetica.Name = "colIndAnaliticaSintetica";
            this.colIndAnaliticaSintetica.Visible = true;
            this.colIndAnaliticaSintetica.VisibleIndex = 4;
            this.colIndAnaliticaSintetica.Width = 130;
            // 
            // colTipoContaSped
            // 
            this.colTipoContaSped.FieldName = "TipoContaSped";
            this.colTipoContaSped.Name = "colTipoContaSped";
            this.colTipoContaSped.Visible = true;
            this.colTipoContaSped.VisibleIndex = 5;
            this.colTipoContaSped.Width = 139;
            // 
            // colNatureza
            // 
            this.colNatureza.FieldName = "Natureza";
            this.colNatureza.Name = "colNatureza";
            this.colNatureza.Visible = true;
            this.colNatureza.VisibleIndex = 6;
            this.colNatureza.Width = 73;
            // 
            // colNivel
            // 
            this.colNivel.FieldName = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.Visible = true;
            this.colNivel.VisibleIndex = 7;
            this.colNivel.Width = 56;
            // 
            // colDataInclusao
            // 
            this.colDataInclusao.FieldName = "DataInclusao";
            this.colDataInclusao.Name = "colDataInclusao";
            this.colDataInclusao.Width = 56;
            // 
            // colDataAlteracao
            // 
            this.colDataAlteracao.FieldName = "DataAlteracao";
            this.colDataAlteracao.Name = "colDataAlteracao";
            this.colDataAlteracao.Width = 56;
            // 
            // colMatriz
            // 
            this.colMatriz.Caption = "Matriz";
            this.colMatriz.FieldName = "Matriz.CodigoMatriz";
            this.colMatriz.Name = "colMatriz";
            this.colMatriz.Visible = true;
            this.colMatriz.VisibleIndex = 0;
            this.colMatriz.Width = 67;
            // 
            // XFrmViewMantContaContabil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 480);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmViewMantContaContabil";
            this.Text = "Contas contábeis";
            this.Shown += new System.EventHandler(this.XFrmViewContaContabil_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMatrizFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaContabilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barCbMatriz;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbMatrizFilter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource contaContabilBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdContaContabil;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoContaContabil;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoReduzido;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoContaContabil;
        private DevExpress.XtraGrid.Columns.GridColumn colIndAnaliticaSintetica;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoContaSped;
        private DevExpress.XtraGrid.Columns.GridColumn colNatureza;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInclusao;
        private DevExpress.XtraGrid.Columns.GridColumn colDataAlteracao;
        private DevExpress.XtraGrid.Columns.GridColumn colMatriz;
    }
}