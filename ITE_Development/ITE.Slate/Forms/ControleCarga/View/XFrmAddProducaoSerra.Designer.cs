namespace ITE.Slate.Forms.ControleCarga.View
{
    partial class XFrmAddProducaoSerra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddProducaoSerra));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.lookUpMaterialSerra1 = new ITE.Components.LookUpMaterialSerra();
            this.cbSerras = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditDtProducao = new DevExpress.XtraEditors.DateEdit();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdSerra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataProducao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidadePeca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetrosQuadrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMetrosCubico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMetroQuadrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduzido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMaterialSerra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnRemoveMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.chAtualizar = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantidadePeca = new DevExpress.XtraEditors.TextEdit();
            this.btnAddProduto = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSerras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDtProducao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDtProducao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chAtualizar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadePeca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(987, 540);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.panelControl2);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(980, 506);
            this.xtraTabPage1.Text = "Serra:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.flyoutPanel1);
            this.panelControl2.Controls.Add(this.cbSerras);
            this.panelControl2.Controls.Add(this.btnAlterar);
            this.panelControl2.Controls.Add(this.dateEditDtProducao);
            this.panelControl2.Controls.Add(this.btnConfirmar);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.separatorControl1);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(980, 506);
            this.panelControl2.TabIndex = 0;
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(166, 263);
            this.flyoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OwnerControl = this.lookUpMaterialSerra1;
            this.flyoutPanel1.Size = new System.Drawing.Size(572, 95);
            this.flyoutPanel1.TabIndex = 16;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.lblMessage);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(572, 95);
            this.flyoutPanelControl1.TabIndex = 0;
            this.flyoutPanelControl1.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblMessage.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblMessage.Location = new System.Drawing.Point(16, 33);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(79, 24);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Material:";
            // 
            // lookUpMaterialSerra1
            // 
            this.lookUpMaterialSerra1.Location = new System.Drawing.Point(8, 17);
            this.lookUpMaterialSerra1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lookUpMaterialSerra1.Produto = null;
            this.lookUpMaterialSerra1.Name = "lookUpMaterialSerra1";
            this.lookUpMaterialSerra1.Size = new System.Drawing.Size(575, 65);
            this.lookUpMaterialSerra1.TabIndex = 5;
            // 
            // cbSerras
            // 
            this.cbSerras.Location = new System.Drawing.Point(31, 53);
            this.cbSerras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSerras.Name = "cbSerras";
            this.cbSerras.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbSerras.Properties.Appearance.Options.UseFont = true;
            this.cbSerras.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbSerras.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbSerras.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSerras.Size = new System.Drawing.Size(276, 24);
            this.cbSerras.TabIndex = 0;
            this.cbSerras.SelectedIndexChanged += new System.EventHandler(this.cbSerras_SelectedIndexChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(647, 49);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 30);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dateEditDtProducao
            // 
            this.dateEditDtProducao.EditValue = null;
            this.dateEditDtProducao.Location = new System.Drawing.Point(432, 53);
            this.dateEditDtProducao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateEditDtProducao.Name = "dateEditDtProducao";
            this.dateEditDtProducao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateEditDtProducao.Properties.Appearance.Options.UseFont = true;
            this.dateEditDtProducao.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dateEditDtProducao.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateEditDtProducao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDtProducao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDtProducao.Size = new System.Drawing.Size(157, 24);
            this.dateEditDtProducao.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(745, 49);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 30);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(31, 30);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 18);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Serra";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(17, 96);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(859, 23);
            this.separatorControl1.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(432, 30);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 18);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Data Produção";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.tableLayoutPanel1);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabPage2.Size = new System.Drawing.Size(980, 506);
            this.xtraTabPage2.Text = "Produção:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(980, 506);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(3, 105);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(974, 349);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdSerra,
            this.colSerra,
            this.colDataProducao,
            this.colCodigoMaterial,
            this.colQuantidadePeca,
            this.colMetrosQuadrado,
            this.colMetrosCubico,
            this.colValorMetroQuadrado,
            this.colTotalProduzido,
            this.colIdMaterialSerra,
            this.colMaterial});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colIdSerra
            // 
            this.colIdSerra.AppearanceCell.Options.UseTextOptions = true;
            this.colIdSerra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdSerra.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdSerra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdSerra.FieldName = "IdSerra";
            this.colIdSerra.Name = "colIdSerra";
            // 
            // colSerra
            // 
            this.colSerra.AppearanceCell.Options.UseTextOptions = true;
            this.colSerra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSerra.AppearanceHeader.Options.UseTextOptions = true;
            this.colSerra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSerra.FieldName = "Serra";
            this.colSerra.Name = "colSerra";
            // 
            // colDataProducao
            // 
            this.colDataProducao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataProducao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataProducao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataProducao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataProducao.FieldName = "DataProducao";
            this.colDataProducao.Name = "colDataProducao";
            // 
            // colCodigoMaterial
            // 
            this.colCodigoMaterial.Caption = "Código";
            this.colCodigoMaterial.FieldName = "Material.CodigoMaterial";
            this.colCodigoMaterial.Name = "colCodigoMaterial";
            this.colCodigoMaterial.OptionsColumn.AllowEdit = false;
            this.colCodigoMaterial.OptionsColumn.AllowMove = false;
            this.colCodigoMaterial.OptionsColumn.AllowShowHide = false;
            this.colCodigoMaterial.Visible = true;
            this.colCodigoMaterial.VisibleIndex = 0;
            this.colCodigoMaterial.Width = 80;
            // 
            // colQuantidadePeca
            // 
            this.colQuantidadePeca.AppearanceCell.Options.UseTextOptions = true;
            this.colQuantidadePeca.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadePeca.AppearanceHeader.Options.UseTextOptions = true;
            this.colQuantidadePeca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colQuantidadePeca.Caption = "Quantidade Peças";
            this.colQuantidadePeca.FieldName = "QuantidadePeca";
            this.colQuantidadePeca.Name = "colQuantidadePeca";
            this.colQuantidadePeca.OptionsColumn.AllowMove = false;
            this.colQuantidadePeca.OptionsColumn.AllowShowHide = false;
            this.colQuantidadePeca.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantidadePeca", "TOTAL PÇ: {0:N}")});
            this.colQuantidadePeca.Visible = true;
            this.colQuantidadePeca.VisibleIndex = 2;
            this.colQuantidadePeca.Width = 98;
            // 
            // colMetrosQuadrado
            // 
            this.colMetrosQuadrado.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMetrosQuadrado.AppearanceCell.ForeColor = System.Drawing.SystemColors.Highlight;
            this.colMetrosQuadrado.AppearanceCell.Options.UseFont = true;
            this.colMetrosQuadrado.AppearanceCell.Options.UseForeColor = true;
            this.colMetrosQuadrado.AppearanceCell.Options.UseTextOptions = true;
            this.colMetrosQuadrado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosQuadrado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMetrosQuadrado.AppearanceHeader.ForeColor = System.Drawing.SystemColors.Highlight;
            this.colMetrosQuadrado.AppearanceHeader.Options.UseFont = true;
            this.colMetrosQuadrado.AppearanceHeader.Options.UseForeColor = true;
            this.colMetrosQuadrado.AppearanceHeader.Options.UseTextOptions = true;
            this.colMetrosQuadrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosQuadrado.Caption = "M²";
            this.colMetrosQuadrado.DisplayFormat.FormatString = "n2";
            this.colMetrosQuadrado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMetrosQuadrado.FieldName = "MetrosQuadrado";
            this.colMetrosQuadrado.Name = "colMetrosQuadrado";
            this.colMetrosQuadrado.OptionsColumn.AllowEdit = false;
            this.colMetrosQuadrado.OptionsColumn.AllowMove = false;
            this.colMetrosQuadrado.OptionsColumn.AllowShowHide = false;
            this.colMetrosQuadrado.OptionsColumn.ReadOnly = true;
            this.colMetrosQuadrado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MetrosQuadrado", "TOTAL M²: {0:n2}")});
            this.colMetrosQuadrado.Visible = true;
            this.colMetrosQuadrado.VisibleIndex = 3;
            this.colMetrosQuadrado.Width = 88;
            // 
            // colMetrosCubico
            // 
            this.colMetrosCubico.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMetrosCubico.AppearanceCell.ForeColor = System.Drawing.Color.Brown;
            this.colMetrosCubico.AppearanceCell.Options.UseFont = true;
            this.colMetrosCubico.AppearanceCell.Options.UseForeColor = true;
            this.colMetrosCubico.AppearanceCell.Options.UseTextOptions = true;
            this.colMetrosCubico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosCubico.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMetrosCubico.AppearanceHeader.ForeColor = System.Drawing.Color.Brown;
            this.colMetrosCubico.AppearanceHeader.Options.UseFont = true;
            this.colMetrosCubico.AppearanceHeader.Options.UseForeColor = true;
            this.colMetrosCubico.AppearanceHeader.Options.UseTextOptions = true;
            this.colMetrosCubico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMetrosCubico.Caption = "M³";
            this.colMetrosCubico.DisplayFormat.FormatString = "n2";
            this.colMetrosCubico.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMetrosCubico.FieldName = "MetrosCubico";
            this.colMetrosCubico.Name = "colMetrosCubico";
            this.colMetrosCubico.OptionsColumn.AllowEdit = false;
            this.colMetrosCubico.OptionsColumn.AllowMove = false;
            this.colMetrosCubico.OptionsColumn.AllowShowHide = false;
            this.colMetrosCubico.OptionsColumn.ReadOnly = true;
            this.colMetrosCubico.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MetrosCubico", "TOTAL M³: {0:n2}")});
            this.colMetrosCubico.Visible = true;
            this.colMetrosCubico.VisibleIndex = 4;
            this.colMetrosCubico.Width = 88;
            // 
            // colValorMetroQuadrado
            // 
            this.colValorMetroQuadrado.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colValorMetroQuadrado.AppearanceCell.ForeColor = System.Drawing.Color.Teal;
            this.colValorMetroQuadrado.AppearanceCell.Options.UseFont = true;
            this.colValorMetroQuadrado.AppearanceCell.Options.UseForeColor = true;
            this.colValorMetroQuadrado.AppearanceCell.Options.UseTextOptions = true;
            this.colValorMetroQuadrado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorMetroQuadrado.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colValorMetroQuadrado.AppearanceHeader.ForeColor = System.Drawing.Color.Teal;
            this.colValorMetroQuadrado.AppearanceHeader.Options.UseFont = true;
            this.colValorMetroQuadrado.AppearanceHeader.Options.UseForeColor = true;
            this.colValorMetroQuadrado.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorMetroQuadrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorMetroQuadrado.Caption = "Valor M²";
            this.colValorMetroQuadrado.FieldName = "Material.ValorMetroQuadrado";
            this.colValorMetroQuadrado.Name = "colValorMetroQuadrado";
            this.colValorMetroQuadrado.OptionsColumn.AllowEdit = false;
            this.colValorMetroQuadrado.OptionsColumn.AllowMove = false;
            this.colValorMetroQuadrado.OptionsColumn.AllowShowHide = false;
            this.colValorMetroQuadrado.Visible = true;
            this.colValorMetroQuadrado.VisibleIndex = 5;
            this.colValorMetroQuadrado.Width = 63;
            // 
            // colTotalProduzido
            // 
            this.colTotalProduzido.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTotalProduzido.AppearanceCell.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.colTotalProduzido.AppearanceCell.Options.UseFont = true;
            this.colTotalProduzido.AppearanceCell.Options.UseForeColor = true;
            this.colTotalProduzido.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalProduzido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalProduzido.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTotalProduzido.AppearanceHeader.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.colTotalProduzido.AppearanceHeader.Options.UseFont = true;
            this.colTotalProduzido.AppearanceHeader.Options.UseForeColor = true;
            this.colTotalProduzido.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalProduzido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalProduzido.Caption = "Total Unitário";
            this.colTotalProduzido.DisplayFormat.FormatString = "n2";
            this.colTotalProduzido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalProduzido.FieldName = "TotalUnitario";
            this.colTotalProduzido.Name = "colTotalProduzido";
            this.colTotalProduzido.OptionsColumn.AllowEdit = false;
            this.colTotalProduzido.OptionsColumn.AllowMove = false;
            this.colTotalProduzido.OptionsColumn.AllowShowHide = false;
            this.colTotalProduzido.OptionsColumn.ReadOnly = true;
            this.colTotalProduzido.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalUnitario", "TOTAL R$: {0:n2}")});
            this.colTotalProduzido.Visible = true;
            this.colTotalProduzido.VisibleIndex = 6;
            this.colTotalProduzido.Width = 149;
            // 
            // colIdMaterialSerra
            // 
            this.colIdMaterialSerra.AppearanceCell.Options.UseTextOptions = true;
            this.colIdMaterialSerra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMaterialSerra.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdMaterialSerra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdMaterialSerra.FieldName = "IdMaterial";
            this.colIdMaterialSerra.Name = "colIdMaterialSerra";
            // 
            // colMaterial
            // 
            this.colMaterial.AppearanceCell.Options.UseTextOptions = true;
            this.colMaterial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaterial.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaterial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaterial.FieldName = "Material";
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.OptionsColumn.AllowEdit = false;
            this.colMaterial.OptionsColumn.AllowMove = false;
            this.colMaterial.OptionsColumn.AllowShowHide = false;
            this.colMaterial.OptionsColumn.ReadOnly = true;
            this.colMaterial.Visible = true;
            this.colMaterial.VisibleIndex = 1;
            this.colMaterial.Width = 250;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnRemoveMaterial);
            this.panelControl1.Controls.Add(this.chAtualizar);
            this.panelControl1.Controls.Add(this.lookUpMaterialSerra1);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtQuantidadePeca);
            this.panelControl1.Controls.Add(this.btnAddProduto);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(974, 99);
            this.panelControl1.TabIndex = 5;
            // 
            // btnRemoveMaterial
            // 
            this.btnRemoveMaterial.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMaterial.Appearance.Options.UseFont = true;
            this.btnRemoveMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveMaterial.Image")));
            this.btnRemoveMaterial.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRemoveMaterial.Location = new System.Drawing.Point(881, 44);
            this.btnRemoveMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveMaterial.Name = "btnRemoveMaterial";
            this.btnRemoveMaterial.Size = new System.Drawing.Size(76, 34);
            this.btnRemoveMaterial.TabIndex = 9;
            this.btnRemoveMaterial.Text = "Del";
            this.btnRemoveMaterial.ToolTip = "Remove o material produzido da tabela";
            this.btnRemoveMaterial.Click += new System.EventHandler(this.btnRemoveMaterial_Click);
            // 
            // chAtualizar
            // 
            this.chAtualizar.EditValue = true;
            this.chAtualizar.Location = new System.Drawing.Point(790, 14);
            this.chAtualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chAtualizar.Name = "chAtualizar";
            this.chAtualizar.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chAtualizar.Properties.Appearance.Options.UseFont = true;
            this.chAtualizar.Properties.Caption = "Atualizar";
            this.chAtualizar.Size = new System.Drawing.Size(105, 29);
            this.chAtualizar.TabIndex = 8;
            this.chAtualizar.ToolTip = "Atualiza quantidade de um material já incluso automaticamente";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(619, 14);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(108, 25);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Qtde. Peças";
            // 
            // txtQuantidadePeca
            // 
            this.txtQuantidadePeca.Location = new System.Drawing.Point(619, 47);
            this.txtQuantidadePeca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidadePeca.Name = "txtQuantidadePeca";
            this.txtQuantidadePeca.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadePeca.Properties.Appearance.Options.UseFont = true;
            this.txtQuantidadePeca.Properties.Mask.EditMask = "d";
            this.txtQuantidadePeca.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQuantidadePeca.Size = new System.Drawing.Size(138, 32);
            this.txtQuantidadePeca.TabIndex = 6;
            this.txtQuantidadePeca.Enter += new System.EventHandler(this.txtQuantidadePeca_Enter);
            this.txtQuantidadePeca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantidadePeca_KeyDown);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.Appearance.Options.UseFont = true;
            this.btnAddProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduto.Image")));
            this.btnAddProduto.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAddProduto.Location = new System.Drawing.Point(790, 45);
            this.btnAddProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(76, 34);
            this.btnAddProduto.TabIndex = 6;
            this.btnAddProduto.Text = "Add";
            this.btnAddProduto.ToolTip = "Adiciona o material produzido na tabela";
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnSalvar);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(3, 458);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(974, 46);
            this.panelControl3.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(877, 7);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 30);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // XFrmAddProducaoSerra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 540);
            this.Controls.Add(this.xtraTabControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmAddProducaoSerra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Produção:";
            this.Load += new System.EventHandler(this.XFrmAddProducaoSerra_Load);
            this.Shown += new System.EventHandler(this.XFrmProducaoArdosia_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmAddItemSerra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.flyoutPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbSerras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDtProducao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDtProducao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chAtualizar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidadePeca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colDataProducao;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidadePeca;
        private DevExpress.XtraGrid.Columns.GridColumn colMetrosQuadrado;
        private DevExpress.XtraGrid.Columns.GridColumn colMetrosCubico;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMetroQuadrado;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduzido;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMaterialSerra;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterial;
        private DevExpress.XtraEditors.TextEdit txtQuantidadePeca;
        private DevExpress.XtraEditors.SimpleButton btnAddProduto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbSerras;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.DateEdit dateEditDtProducao;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private ITE.Components.LookUpMaterialSerra lookUpMaterialSerra1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.CheckEdit chAtualizar;
        private DevExpress.XtraEditors.SimpleButton btnRemoveMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoMaterial;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraEditors.LabelControl lblMessage;
    }
}