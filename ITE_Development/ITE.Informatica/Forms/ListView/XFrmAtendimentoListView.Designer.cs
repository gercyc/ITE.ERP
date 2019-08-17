namespace ITE.Informatica.Forms.View
{
    partial class XFrmViewAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewAtendimento));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsAtendimento = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAtendimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRelatorioAtendimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colTipoColeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataColeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComplementoEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManutencao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnIniciar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAtendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.bsAtendimento;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 179);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1025, 393);
            this.gridControl1.TabIndex = 97;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsAtendimento
            // 
            this.bsAtendimento.DataSource = typeof(ITE.Entidades.POCO.TI.Atendimento);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImage,
            this.colIdAtendimento,
            this.colStatus,
            this.colRelatorioAtendimento,
            this.colTipoColeta,
            this.colDataColeta,
            this.colEndereco,
            this.colNumeroEndereco,
            this.colComplementoEndereco,
            this.colCliente,
            this.colIdCliente,
            this.colManutencao});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.FindNullPrompt = " Digite aqui sua pesquisa...";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridViewAt_DoubleClick);
            // 
            // colImage
            // 
            this.colImage.Caption = " ";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.AllowEdit = false;
            this.colImage.OptionsColumn.ReadOnly = true;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 31;
            // 
            // colIdAtendimento
            // 
            this.colIdAtendimento.AppearanceCell.Options.UseTextOptions = true;
            this.colIdAtendimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdAtendimento.Caption = "Nº Atendimento";
            this.colIdAtendimento.FieldName = "IdAtendimento";
            this.colIdAtendimento.Name = "colIdAtendimento";
            this.colIdAtendimento.OptionsColumn.AllowEdit = false;
            this.colIdAtendimento.OptionsColumn.ReadOnly = true;
            this.colIdAtendimento.Visible = true;
            this.colIdAtendimento.VisibleIndex = 1;
            this.colIdAtendimento.Width = 103;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "StatusAtendimento";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.OptionsColumn.ReadOnly = true;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 99;
            // 
            // colRelatorioAtendimento
            // 
            this.colRelatorioAtendimento.AppearanceCell.Options.UseTextOptions = true;
            this.colRelatorioAtendimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRelatorioAtendimento.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colRelatorioAtendimento.FieldName = "RelatorioAtendimento";
            this.colRelatorioAtendimento.Name = "colRelatorioAtendimento";
            this.colRelatorioAtendimento.OptionsColumn.ReadOnly = true;
            this.colRelatorioAtendimento.Visible = true;
            this.colRelatorioAtendimento.VisibleIndex = 6;
            this.colRelatorioAtendimento.Width = 139;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemMemoExEdit1.PopupFormSize = new System.Drawing.Size(500, 250);
            // 
            // colTipoColeta
            // 
            this.colTipoColeta.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoColeta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoColeta.Caption = "Tipo Coleta";
            this.colTipoColeta.FieldName = "TipoColeta";
            this.colTipoColeta.Name = "colTipoColeta";
            this.colTipoColeta.OptionsColumn.AllowEdit = false;
            this.colTipoColeta.OptionsColumn.ReadOnly = true;
            this.colTipoColeta.Visible = true;
            this.colTipoColeta.VisibleIndex = 5;
            this.colTipoColeta.Width = 98;
            // 
            // colDataColeta
            // 
            this.colDataColeta.AppearanceCell.Options.UseTextOptions = true;
            this.colDataColeta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataColeta.Caption = "Data Coleta";
            this.colDataColeta.FieldName = "DataColeta";
            this.colDataColeta.Name = "colDataColeta";
            this.colDataColeta.OptionsColumn.AllowEdit = false;
            this.colDataColeta.OptionsColumn.ReadOnly = true;
            this.colDataColeta.Visible = true;
            this.colDataColeta.VisibleIndex = 4;
            this.colDataColeta.Width = 77;
            // 
            // colEndereco
            // 
            this.colEndereco.AppearanceCell.Options.UseTextOptions = true;
            this.colEndereco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colEndereco.FieldName = "Endereco";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.OptionsColumn.AllowEdit = false;
            this.colEndereco.OptionsColumn.ReadOnly = true;
            this.colEndereco.Visible = true;
            this.colEndereco.VisibleIndex = 7;
            this.colEndereco.Width = 229;
            // 
            // colNumeroEndereco
            // 
            this.colNumeroEndereco.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroEndereco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroEndereco.Caption = "Nº";
            this.colNumeroEndereco.FieldName = "NumeroEndereco";
            this.colNumeroEndereco.Name = "colNumeroEndereco";
            this.colNumeroEndereco.OptionsColumn.AllowEdit = false;
            this.colNumeroEndereco.OptionsColumn.ReadOnly = true;
            this.colNumeroEndereco.Width = 57;
            // 
            // colComplementoEndereco
            // 
            this.colComplementoEndereco.AppearanceCell.Options.UseTextOptions = true;
            this.colComplementoEndereco.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colComplementoEndereco.Caption = "Complemento";
            this.colComplementoEndereco.FieldName = "ComplementoEndereco";
            this.colComplementoEndereco.Name = "colComplementoEndereco";
            this.colComplementoEndereco.OptionsColumn.AllowEdit = false;
            this.colComplementoEndereco.OptionsColumn.ReadOnly = true;
            this.colComplementoEndereco.Width = 84;
            // 
            // colCliente
            // 
            this.colCliente.AppearanceCell.Options.UseTextOptions = true;
            this.colCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente.RazaoSocial";
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.AllowEdit = false;
            this.colCliente.OptionsColumn.ReadOnly = true;
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 230;
            // 
            // colIdCliente
            // 
            this.colIdCliente.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.OptionsColumn.AllowEdit = false;
            this.colIdCliente.OptionsColumn.ReadOnly = true;
            this.colIdCliente.Width = 119;
            // 
            // colManutencao
            // 
            this.colManutencao.AppearanceCell.Options.UseTextOptions = true;
            this.colManutencao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colManutencao.FieldName = "Manutencao";
            this.colManutencao.Name = "colManutencao";
            this.colManutencao.OptionsColumn.AllowEdit = false;
            this.colManutencao.OptionsColumn.ReadOnly = true;
            this.colManutencao.Width = 119;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnIniciar,
            this.barBtnCancelar,
            this.barBtnEditar,
            this.barBtnRefresh,
            this.barBtnNovo,
            this.barBtnImprimir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1025, 179);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnIniciar
            // 
            this.barBtnIniciar.Caption = "Iniciar Atendimento";
            this.barBtnIniciar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnIniciar.Glyph")));
            this.barBtnIniciar.Id = 1;
            this.barBtnIniciar.Name = "barBtnIniciar";
            this.barBtnIniciar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnIniciar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnIniciar_ItemClick);
            // 
            // barBtnCancelar
            // 
            this.barBtnCancelar.Caption = "Cancelar";
            this.barBtnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.Glyph")));
            this.barBtnCancelar.Id = 2;
            this.barBtnCancelar.Name = "barBtnCancelar";
            this.barBtnCancelar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelar_ItemClick);
            // 
            // barBtnEditar
            // 
            this.barBtnEditar.Caption = "Visualizar/Editar";
            this.barBtnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnEditar.Glyph")));
            this.barBtnEditar.Id = 3;
            this.barBtnEditar.Name = "barBtnEditar";
            this.barBtnEditar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditar_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Atualizar";
            this.barBtnRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.Glyph")));
            this.barBtnRefresh.Id = 4;
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.Caption = "Abertura Novo Atendimento";
            this.barBtnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Glyph")));
            this.barBtnNovo.Id = 5;
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovo_ItemClick);
            // 
            // barBtnImprimir
            // 
            this.barBtnImprimir.Caption = "Imprimir";
            this.barBtnImprimir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnImprimir.Glyph")));
            this.barBtnImprimir.Id = 6;
            this.barBtnImprimir.Name = "barBtnImprimir";
            this.barBtnImprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ferramentas";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnEditar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnIniciar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCancelar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnImprimir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Central de Atendimento";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 572);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1025, 40);
            // 
            // XFrmGerenciarAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmGerenciarAtendimento";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Informação Atendimento";
            this.Shown += new System.EventHandler(this.XFrmGerenciarAtendimento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAtendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsAtendimento;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barBtnIniciar;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelar;
        private DevExpress.XtraBars.BarButtonItem barBtnEditar;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAtendimento;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colRelatorioAtendimento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoColeta;
        private DevExpress.XtraGrid.Columns.GridColumn colDataColeta;
        private DevExpress.XtraGrid.Columns.GridColumn colEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colComplementoEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colManutencao;
        private DevExpress.XtraBars.BarButtonItem barBtnNovo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraBars.BarButtonItem barBtnImprimir;
    }
}