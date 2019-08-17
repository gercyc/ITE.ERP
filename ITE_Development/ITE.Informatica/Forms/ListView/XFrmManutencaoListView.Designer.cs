namespace ITE.Informatica.Forms.View
{
    partial class XFrmViewManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmViewManutencao));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnExcluir = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnVisualizar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnVoltar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNewManutencao = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.bsManutencao = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdManutencao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdComputador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAtendimentoManutencao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdClienteManutencao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRelatorioManutencao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataTermino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuracao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesconto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAtendimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComputador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItensManutencao = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManutencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnExcluir,
            this.barBtnVisualizar,
            this.barBtnRefresh,
            this.barBtnVoltar,
            this.barBtnImprimir,
            this.barBtnNewManutencao});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 9;
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
            // barBtnExcluir
            // 
            this.barBtnExcluir.Caption = "Excluir";
            this.barBtnExcluir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExcluir.Glyph")));
            this.barBtnExcluir.Id = 2;
            this.barBtnExcluir.Name = "barBtnExcluir";
            this.barBtnExcluir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnExcluir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExcluir_ItemClick);
            // 
            // barBtnVisualizar
            // 
            this.barBtnVisualizar.Caption = "Editar/Visualizar Manutenção";
            this.barBtnVisualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnVisualizar.Glyph")));
            this.barBtnVisualizar.Id = 3;
            this.barBtnVisualizar.Name = "barBtnVisualizar";
            this.barBtnVisualizar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnVisualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnVisualizar_ItemClick);
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
            // barBtnVoltar
            // 
            this.barBtnVoltar.Caption = "Cancelar";
            this.barBtnVoltar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnVoltar.Glyph")));
            this.barBtnVoltar.Id = 6;
            this.barBtnVoltar.Name = "barBtnVoltar";
            this.barBtnVoltar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnVoltar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelar_ItemClick);
            // 
            // barBtnImprimir
            // 
            this.barBtnImprimir.Caption = "Imprimir";
            this.barBtnImprimir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnImprimir.Glyph")));
            this.barBtnImprimir.Id = 7;
            this.barBtnImprimir.Name = "barBtnImprimir";
            this.barBtnImprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnImprimir_ItemClick);
            // 
            // barBtnNewManutencao
            // 
            this.barBtnNewManutencao.Caption = "Incluir Manutenção";
            this.barBtnNewManutencao.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNewManutencao.Glyph")));
            this.barBtnNewManutencao.Id = 8;
            this.barBtnNewManutencao.Name = "barBtnNewManutencao";
            this.barBtnNewManutencao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnNewManutencao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNewManutencao_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnVoltar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnNewManutencao);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnVisualizar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnExcluir);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnImprimir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Central de Serviços";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 572);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1025, 40);
            // 
            // bsManutencao
            // 
            this.bsManutencao.DataSource = typeof(ITE.Entidades.POCO.TI.Manutencao);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bsManutencao;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 179);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1025, 393);
            this.gridControl1.TabIndex = 100;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdManutencao,
            this.colStatus,
            this.colImage,
            this.colIdComputador,
            this.colIdAtendimentoManutencao,
            this.colIdClienteManutencao,
            this.colRelatorioManutencao,
            this.colData,
            this.colDataInicial,
            this.colDataTermino,
            this.colDataEntrega,
            this.colDuracao,
            this.colValor,
            this.colDesconto,
            this.colAtendimento,
            this.colComputador,
            this.colCliente,
            this.colItensManutencao});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView1_MasterRowEmpty);
            this.gridView1.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridView1_MasterRowGetChildList);
            this.gridView1.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView1_MasterRowGetRelationName);
            this.gridView1.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridView1_MasterRowGetRelationCount);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colIdManutencao
            // 
            this.colIdManutencao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdManutencao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdManutencao.Caption = "ID";
            this.colIdManutencao.FieldName = "IdManutencao";
            this.colIdManutencao.Name = "colIdManutencao";
            this.colIdManutencao.OptionsColumn.AllowEdit = false;
            this.colIdManutencao.Visible = true;
            this.colIdManutencao.VisibleIndex = 0;
            this.colIdManutencao.Width = 60;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "StatusManutencao";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 84;
            // 
            // colImage
            // 
            this.colImage.Caption = " ";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.AllowEdit = false;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 1;
            this.colImage.Width = 41;
            // 
            // colIdComputador
            // 
            this.colIdComputador.AppearanceCell.Options.UseTextOptions = true;
            this.colIdComputador.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdComputador.FieldName = "IdComputador";
            this.colIdComputador.Name = "colIdComputador";
            this.colIdComputador.OptionsColumn.AllowEdit = false;
            // 
            // colIdAtendimentoManutencao
            // 
            this.colIdAtendimentoManutencao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdAtendimentoManutencao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdAtendimentoManutencao.Caption = "Nº Atendimento";
            this.colIdAtendimentoManutencao.FieldName = "IdAtendimento";
            this.colIdAtendimentoManutencao.Name = "colIdAtendimentoManutencao";
            this.colIdAtendimentoManutencao.OptionsColumn.AllowEdit = false;
            this.colIdAtendimentoManutencao.Visible = true;
            this.colIdAtendimentoManutencao.VisibleIndex = 4;
            this.colIdAtendimentoManutencao.Width = 71;
            // 
            // colIdClienteManutencao
            // 
            this.colIdClienteManutencao.AppearanceCell.Options.UseTextOptions = true;
            this.colIdClienteManutencao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdClienteManutencao.FieldName = "IdClienteManutencao";
            this.colIdClienteManutencao.Name = "colIdClienteManutencao";
            this.colIdClienteManutencao.OptionsColumn.AllowEdit = false;
            this.colIdClienteManutencao.Width = 135;
            // 
            // colRelatorioManutencao
            // 
            this.colRelatorioManutencao.AppearanceCell.Options.UseTextOptions = true;
            this.colRelatorioManutencao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRelatorioManutencao.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colRelatorioManutencao.FieldName = "RelatorioManutencao";
            this.colRelatorioManutencao.Name = "colRelatorioManutencao";
            this.colRelatorioManutencao.OptionsColumn.ReadOnly = true;
            this.colRelatorioManutencao.Visible = true;
            this.colRelatorioManutencao.VisibleIndex = 5;
            this.colRelatorioManutencao.Width = 170;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colData
            // 
            this.colData.AppearanceCell.Options.UseTextOptions = true;
            this.colData.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.OptionsColumn.AllowEdit = false;
            this.colData.Visible = true;
            this.colData.VisibleIndex = 6;
            this.colData.Width = 51;
            // 
            // colDataInicial
            // 
            this.colDataInicial.AppearanceCell.Options.UseTextOptions = true;
            this.colDataInicial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataInicial.FieldName = "DataInicial";
            this.colDataInicial.Name = "colDataInicial";
            this.colDataInicial.OptionsColumn.AllowEdit = false;
            this.colDataInicial.Visible = true;
            this.colDataInicial.VisibleIndex = 7;
            this.colDataInicial.Width = 63;
            // 
            // colDataTermino
            // 
            this.colDataTermino.AppearanceCell.Options.UseTextOptions = true;
            this.colDataTermino.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataTermino.FieldName = "DataTermino";
            this.colDataTermino.Name = "colDataTermino";
            this.colDataTermino.OptionsColumn.AllowEdit = false;
            this.colDataTermino.Visible = true;
            this.colDataTermino.VisibleIndex = 8;
            this.colDataTermino.Width = 64;
            // 
            // colDataEntrega
            // 
            this.colDataEntrega.AppearanceCell.Options.UseTextOptions = true;
            this.colDataEntrega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataEntrega.FieldName = "DataEntrega";
            this.colDataEntrega.Name = "colDataEntrega";
            this.colDataEntrega.OptionsColumn.AllowEdit = false;
            this.colDataEntrega.Visible = true;
            this.colDataEntrega.VisibleIndex = 9;
            this.colDataEntrega.Width = 71;
            // 
            // colDuracao
            // 
            this.colDuracao.AppearanceCell.Options.UseTextOptions = true;
            this.colDuracao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDuracao.Caption = "Duração";
            this.colDuracao.FieldName = "Duracao";
            this.colDuracao.Name = "colDuracao";
            this.colDuracao.OptionsColumn.AllowEdit = false;
            this.colDuracao.Visible = true;
            this.colDuracao.VisibleIndex = 10;
            this.colDuracao.Width = 46;
            // 
            // colValor
            // 
            this.colValor.AppearanceCell.Options.UseTextOptions = true;
            this.colValor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValor.FieldName = "ValorManutencao";
            this.colValor.Name = "colValor";
            this.colValor.OptionsColumn.AllowEdit = false;
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 11;
            this.colValor.Width = 70;
            // 
            // colDesconto
            // 
            this.colDesconto.AppearanceCell.Options.UseTextOptions = true;
            this.colDesconto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDesconto.FieldName = "Desconto";
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.OptionsColumn.AllowEdit = false;
            this.colDesconto.Visible = true;
            this.colDesconto.VisibleIndex = 12;
            this.colDesconto.Width = 100;
            // 
            // colAtendimento
            // 
            this.colAtendimento.AppearanceCell.Options.UseTextOptions = true;
            this.colAtendimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAtendimento.FieldName = "Atendimento";
            this.colAtendimento.Name = "colAtendimento";
            this.colAtendimento.OptionsColumn.AllowEdit = false;
            // 
            // colComputador
            // 
            this.colComputador.AppearanceCell.Options.UseTextOptions = true;
            this.colComputador.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colComputador.FieldName = "Computador";
            this.colComputador.Name = "colComputador";
            this.colComputador.OptionsColumn.AllowEdit = false;
            // 
            // colCliente
            // 
            this.colCliente.AppearanceCell.Options.UseTextOptions = true;
            this.colCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente.RazaoSocial";
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.AllowEdit = false;
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 3;
            this.colCliente.Width = 127;
            // 
            // colItensManutencao
            // 
            this.colItensManutencao.AppearanceCell.Options.UseTextOptions = true;
            this.colItensManutencao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItensManutencao.FieldName = "ItensManutencao";
            this.colItensManutencao.Name = "colItensManutencao";
            this.colItensManutencao.OptionsColumn.AllowEdit = false;
            // 
            // XFrmViewManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmViewManutencao";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Gerenciador Manutenções";
            this.Shown += new System.EventHandler(this.XFrmInfoManutencao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsManutencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barBtnExcluir;
        private DevExpress.XtraBars.BarButtonItem barBtnVisualizar;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private System.Windows.Forms.BindingSource bsManutencao;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdManutencao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdComputador;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAtendimentoManutencao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClienteManutencao;
        private DevExpress.XtraGrid.Columns.GridColumn colRelatorioManutencao;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInicial;
        private DevExpress.XtraGrid.Columns.GridColumn colDataTermino;
        private DevExpress.XtraGrid.Columns.GridColumn colDataEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colDuracao;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colDesconto;
        private DevExpress.XtraGrid.Columns.GridColumn colAtendimento;
        private DevExpress.XtraGrid.Columns.GridColumn colComputador;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colItensManutencao;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraBars.BarButtonItem barBtnVoltar;
        private DevExpress.XtraBars.BarButtonItem barBtnImprimir;
        private DevExpress.XtraBars.BarButtonItem barBtnNewManutencao;
    }
}