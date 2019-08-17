namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmCliForListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCliForListView));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlterar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCreditos = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlCliente = new DevExpress.XtraGrid.GridControl();
            this.bsCliFor = new System.Windows.Forms.BindingSource();
            this.gridViewCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassificacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCpfCnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefoneComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCliente)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnNovo,
            this.barBtnAlterar,
            this.barBtnAtualizar,
            this.barBtnCreditos});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(819, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.Caption = "Novo";
            this.barBtnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Glyph")));
            this.barBtnNovo.Id = 1;
            this.barBtnNovo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnNovo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovo_ItemClick);
            // 
            // barBtnAlterar
            // 
            this.barBtnAlterar.Caption = "Alterar";
            this.barBtnAlterar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterar.Glyph")));
            this.barBtnAlterar.Id = 2;
            this.barBtnAlterar.Name = "barBtnAlterar";
            this.barBtnAlterar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAlterar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAlterar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterar_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 3;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // barBtnCreditos
            // 
            this.barBtnCreditos.Caption = "Gerenciar Créditos";
            this.barBtnCreditos.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCreditos.Glyph")));
            this.barBtnCreditos.Id = 4;
            this.barBtnCreditos.Name = "barBtnCreditos";
            this.barBtnCreditos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCreditos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCreditos_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Início";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAlterar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCreditos);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAtualizar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Opções";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 504);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar.Size = new System.Drawing.Size(819, 32);
            // 
            // gridControlCliente
            // 
            this.gridControlCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlCliente.DataSource = this.bsCliFor;
            this.gridControlCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCliente.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCliente.Location = new System.Drawing.Point(3, 41);
            this.gridControlCliente.MainView = this.gridViewCliente;
            this.gridControlCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlCliente.Name = "gridControlCliente";
            this.gridControlCliente.Size = new System.Drawing.Size(813, 317);
            this.gridControlCliente.TabIndex = 3;
            this.gridControlCliente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCliente});
            // 
            // bsCliFor
            // 
            this.bsCliFor.DataSource = typeof(ITE.Entidades.POCO.CliFor);
            // 
            // gridViewCliente
            // 
            this.gridViewCliente.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewCliente.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewCliente.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCliFor,
            this.colNomeCliFor,
            this.colTipoCliFor,
            this.colClassificacao,
            this.colCpfCnpj,
            this.colTelefone,
            this.colCelular,
            this.colTelefoneComercial,
            this.colEmail});
            this.gridViewCliente.GridControl = this.gridControlCliente;
            this.gridViewCliente.Name = "gridViewCliente";
            this.gridViewCliente.OptionsBehavior.Editable = false;
            this.gridViewCliente.OptionsView.ShowGroupPanel = false;
            this.gridViewCliente.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewCliente_CustomColumnDisplayText);
            this.gridViewCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewCliente_KeyDown);
            this.gridViewCliente.DoubleClick += new System.EventHandler(this.gridViewCliente_DoubleClick);
            // 
            // colIdCliFor
            // 
            this.colIdCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliFor.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCliFor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliFor.Caption = "ID";
            this.colIdCliFor.FieldName = "IdCliFor";
            this.colIdCliFor.Name = "colIdCliFor";
            this.colIdCliFor.Visible = true;
            this.colIdCliFor.VisibleIndex = 0;
            this.colIdCliFor.Width = 74;
            // 
            // colNomeCliFor
            // 
            this.colNomeCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colNomeCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeCliFor.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeCliFor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeCliFor.Caption = "Nome";
            this.colNomeCliFor.FieldName = "RazaoSocial";
            this.colNomeCliFor.Name = "colNomeCliFor";
            this.colNomeCliFor.OptionsColumn.AllowEdit = false;
            this.colNomeCliFor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNomeCliFor.Visible = true;
            this.colNomeCliFor.VisibleIndex = 1;
            this.colNomeCliFor.Width = 529;
            // 
            // colTipoCliFor
            // 
            this.colTipoCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoCliFor.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoCliFor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoCliFor.Caption = "Tipo";
            this.colTipoCliFor.FieldName = "TipoCliente";
            this.colTipoCliFor.Name = "colTipoCliFor";
            this.colTipoCliFor.OptionsColumn.AllowEdit = false;
            this.colTipoCliFor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTipoCliFor.Visible = true;
            this.colTipoCliFor.VisibleIndex = 2;
            this.colTipoCliFor.Width = 115;
            // 
            // colClassificacao
            // 
            this.colClassificacao.AppearanceCell.Options.UseTextOptions = true;
            this.colClassificacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colClassificacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colClassificacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colClassificacao.Caption = "Classificação";
            this.colClassificacao.FieldName = "Classificacao";
            this.colClassificacao.Name = "colClassificacao";
            this.colClassificacao.OptionsColumn.AllowEdit = false;
            this.colClassificacao.Visible = true;
            this.colClassificacao.VisibleIndex = 3;
            this.colClassificacao.Width = 100;
            // 
            // colCpfCnpj
            // 
            this.colCpfCnpj.AppearanceCell.Options.UseTextOptions = true;
            this.colCpfCnpj.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCpfCnpj.AppearanceHeader.Options.UseTextOptions = true;
            this.colCpfCnpj.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCpfCnpj.Caption = "CPF/CNPJ";
            this.colCpfCnpj.FieldName = "CpfCnpj";
            this.colCpfCnpj.Name = "colCpfCnpj";
            this.colCpfCnpj.OptionsColumn.AllowEdit = false;
            this.colCpfCnpj.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCpfCnpj.Visible = true;
            this.colCpfCnpj.VisibleIndex = 4;
            this.colCpfCnpj.Width = 151;
            // 
            // colTelefone
            // 
            this.colTelefone.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTelefone.AppearanceHeader.Options.UseTextOptions = true;
            this.colTelefone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTelefone.Caption = "Telefone";
            this.colTelefone.FieldName = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.OptionsColumn.AllowEdit = false;
            this.colTelefone.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTelefone.Visible = true;
            this.colTelefone.VisibleIndex = 5;
            this.colTelefone.Width = 151;
            // 
            // colCelular
            // 
            this.colCelular.AppearanceCell.Options.UseTextOptions = true;
            this.colCelular.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCelular.AppearanceHeader.Options.UseTextOptions = true;
            this.colCelular.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCelular.Caption = "Celular";
            this.colCelular.FieldName = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.OptionsColumn.AllowEdit = false;
            this.colCelular.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCelular.Visible = true;
            this.colCelular.VisibleIndex = 7;
            this.colCelular.Width = 133;
            // 
            // colTelefoneComercial
            // 
            this.colTelefoneComercial.AppearanceCell.Options.UseTextOptions = true;
            this.colTelefoneComercial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTelefoneComercial.AppearanceHeader.Options.UseTextOptions = true;
            this.colTelefoneComercial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTelefoneComercial.Caption = "Tel. Comercial";
            this.colTelefoneComercial.FieldName = "TelefoneComercial";
            this.colTelefoneComercial.Name = "colTelefoneComercial";
            this.colTelefoneComercial.OptionsColumn.AllowEdit = false;
            this.colTelefoneComercial.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTelefoneComercial.Visible = true;
            this.colTelefoneComercial.VisibleIndex = 6;
            this.colTelefoneComercial.Width = 151;
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Options.UseTextOptions = true;
            this.colEmail.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEmail.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmail.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEmail.OptionsColumn.AllowMove = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 8;
            this.colEmail.Width = 226;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControlCliente, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 360);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.searchControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(813, 33);
            this.panelControl1.TabIndex = 4;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControlCliente;
            this.searchControl1.Location = new System.Drawing.Point(8, 6);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton("", -1, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, false, new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Enter)), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Repository.MRUButton()});
            this.searchControl1.Properties.Client = this.gridControlCliente;
            this.searchControl1.Properties.FindDelay = 5000;
            this.searchControl1.Properties.NullValuePrompt = "Digite aqui o nome mais próximo do cliente...";
            this.searchControl1.Properties.ShowMRUButton = true;
            this.searchControl1.Size = new System.Drawing.Size(410, 22);
            this.searchControl1.TabIndex = 0;
            this.searchControl1.ToolTip = "Digite aqui se critério de pesquisa(colunas do grid)";
            this.searchControl1.EditValueChanged += new System.EventHandler(this.searchControl1_EditValueChanged);
            this.searchControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.searchControl1_PreviewKeyDown);
            // 
            // XFrmCliForListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 536);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmCliForListView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Clientes/Fornecedor";
            this.Shown += new System.EventHandler(this.XFrmGerenciarCliFor_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCliente)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnNovo;
        private DevExpress.XtraBars.BarButtonItem barBtnAlterar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraGrid.GridControl gridControlCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colClassificacao;
        private DevExpress.XtraGrid.Columns.GridColumn colCpfCnpj;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefone;
        private DevExpress.XtraGrid.Columns.GridColumn colCelular;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefoneComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private System.Windows.Forms.BindingSource bsCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliFor;
        private DevExpress.XtraBars.BarButtonItem barBtnCreditos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
    }
}