namespace ITE.CE.Forms
{
    partial class XFrmCusteioListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCusteioListView));
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
            this.custeioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCusteio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCalculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroProcesso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorFobTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCapatazia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFabricante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExportador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncoterms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPortoOrigem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPortoDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaisOrigem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaisDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMoedaReais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMoedaEstrangeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantideContainer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContainer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPISTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCofinsTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colICMSTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIITotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIPITotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colICMSSTTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCusteio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapataziaEstrangeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIITotalEstrangeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIPITotalEstrangeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPISTotalEstrangeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCofinsTotalEstrangeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colICMSMoedaEstrangeira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItensCusteio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDespesas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnAddCusteio = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnViewCusteio = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custeioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.custeioBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 48);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(759, 335);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // custeioBindingSource
            // 
            this.custeioBindingSource.DataSource = typeof(ITE.Entidades.POCO.CE.Custeio);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCusteio,
            this.colIdCliente,
            this.colCliente,
            this.colDataCalculo,
            this.colNumeroProcesso,
            this.colValorFobTotal,
            this.colValorCapatazia,
            this.colValorCif,
            this.colFabricante,
            this.colExportador,
            this.colIncoterms,
            this.colPortoOrigem,
            this.colPortoDestino,
            this.colPaisOrigem,
            this.colPaisDestino,
            this.colObservacao,
            this.colIdUsuario,
            this.colUsuario,
            this.colValorMoedaReais,
            this.colValorMoedaEstrangeira,
            this.colQuantideContainer,
            this.colContainer,
            this.colPISTotal,
            this.colCofinsTotal,
            this.colICMSTotal,
            this.colIITotal,
            this.colIPITotal,
            this.colICMSSTTotal,
            this.colTotalCusteio,
            this.colCapataziaEstrangeira,
            this.colIITotalEstrangeira,
            this.colIPITotalEstrangeira,
            this.colPISTotalEstrangeira,
            this.colCofinsTotalEstrangeira,
            this.colICMSMoedaEstrangeira,
            this.colItensCusteio,
            this.colDespesas});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCusteio
            // 
            this.colIdCusteio.FieldName = "IdCusteio";
            this.colIdCusteio.Name = "colIdCusteio";
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 0;
            this.colCliente.Width = 76;
            // 
            // colDataCalculo
            // 
            this.colDataCalculo.FieldName = "DataCalculo";
            this.colDataCalculo.Name = "colDataCalculo";
            this.colDataCalculo.Visible = true;
            this.colDataCalculo.VisibleIndex = 1;
            this.colDataCalculo.Width = 81;
            // 
            // colNumeroProcesso
            // 
            this.colNumeroProcesso.FieldName = "NumeroProcesso";
            this.colNumeroProcesso.Name = "colNumeroProcesso";
            this.colNumeroProcesso.Visible = true;
            this.colNumeroProcesso.VisibleIndex = 2;
            this.colNumeroProcesso.Width = 104;
            // 
            // colValorFobTotal
            // 
            this.colValorFobTotal.FieldName = "ValorFobTotal";
            this.colValorFobTotal.Name = "colValorFobTotal";
            this.colValorFobTotal.Visible = true;
            this.colValorFobTotal.VisibleIndex = 3;
            this.colValorFobTotal.Width = 93;
            // 
            // colValorCapatazia
            // 
            this.colValorCapatazia.FieldName = "ValorCapatazia";
            this.colValorCapatazia.Name = "colValorCapatazia";
            this.colValorCapatazia.Visible = true;
            this.colValorCapatazia.VisibleIndex = 4;
            this.colValorCapatazia.Width = 96;
            // 
            // colValorCif
            // 
            this.colValorCif.FieldName = "ValorCif";
            this.colValorCif.Name = "colValorCif";
            this.colValorCif.Visible = true;
            this.colValorCif.VisibleIndex = 5;
            this.colValorCif.Width = 76;
            // 
            // colFabricante
            // 
            this.colFabricante.FieldName = "Fabricante";
            this.colFabricante.Name = "colFabricante";
            this.colFabricante.Visible = true;
            this.colFabricante.VisibleIndex = 6;
            this.colFabricante.Width = 76;
            // 
            // colExportador
            // 
            this.colExportador.FieldName = "Exportador";
            this.colExportador.Name = "colExportador";
            this.colExportador.Visible = true;
            this.colExportador.VisibleIndex = 7;
            this.colExportador.Width = 76;
            // 
            // colIncoterms
            // 
            this.colIncoterms.FieldName = "Incoterms";
            this.colIncoterms.Name = "colIncoterms";
            this.colIncoterms.Visible = true;
            this.colIncoterms.VisibleIndex = 8;
            this.colIncoterms.Width = 76;
            // 
            // colPortoOrigem
            // 
            this.colPortoOrigem.FieldName = "PortoOrigem";
            this.colPortoOrigem.Name = "colPortoOrigem";
            this.colPortoOrigem.Visible = true;
            this.colPortoOrigem.VisibleIndex = 9;
            this.colPortoOrigem.Width = 84;
            // 
            // colPortoDestino
            // 
            this.colPortoDestino.FieldName = "PortoDestino";
            this.colPortoDestino.Name = "colPortoDestino";
            this.colPortoDestino.Visible = true;
            this.colPortoDestino.VisibleIndex = 10;
            this.colPortoDestino.Width = 86;
            // 
            // colPaisOrigem
            // 
            this.colPaisOrigem.FieldName = "PaisOrigem";
            this.colPaisOrigem.Name = "colPaisOrigem";
            this.colPaisOrigem.Visible = true;
            this.colPaisOrigem.VisibleIndex = 11;
            this.colPaisOrigem.Width = 77;
            // 
            // colPaisDestino
            // 
            this.colPaisDestino.FieldName = "PaisDestino";
            this.colPaisDestino.Name = "colPaisDestino";
            this.colPaisDestino.Visible = true;
            this.colPaisDestino.VisibleIndex = 12;
            this.colPaisDestino.Width = 79;
            // 
            // colObservacao
            // 
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 13;
            this.colObservacao.Width = 79;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Width = 76;
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 14;
            this.colUsuario.Width = 76;
            // 
            // colValorMoedaReais
            // 
            this.colValorMoedaReais.FieldName = "ValorMoedaReais";
            this.colValorMoedaReais.Name = "colValorMoedaReais";
            this.colValorMoedaReais.Visible = true;
            this.colValorMoedaReais.VisibleIndex = 15;
            this.colValorMoedaReais.Width = 109;
            // 
            // colValorMoedaEstrangeira
            // 
            this.colValorMoedaEstrangeira.FieldName = "ValorMoedaEstrangeira";
            this.colValorMoedaEstrangeira.Name = "colValorMoedaEstrangeira";
            this.colValorMoedaEstrangeira.Visible = true;
            this.colValorMoedaEstrangeira.VisibleIndex = 16;
            this.colValorMoedaEstrangeira.Width = 138;
            // 
            // colQuantideContainer
            // 
            this.colQuantideContainer.FieldName = "QuantideContainer";
            this.colQuantideContainer.Name = "colQuantideContainer";
            this.colQuantideContainer.Visible = true;
            this.colQuantideContainer.VisibleIndex = 17;
            this.colQuantideContainer.Width = 115;
            // 
            // colContainer
            // 
            this.colContainer.FieldName = "Container";
            this.colContainer.Name = "colContainer";
            this.colContainer.Visible = true;
            this.colContainer.VisibleIndex = 18;
            this.colContainer.Width = 76;
            // 
            // colPISTotal
            // 
            this.colPISTotal.FieldName = "PISTotal";
            this.colPISTotal.Name = "colPISTotal";
            this.colPISTotal.Visible = true;
            this.colPISTotal.VisibleIndex = 19;
            this.colPISTotal.Width = 76;
            // 
            // colCofinsTotal
            // 
            this.colCofinsTotal.FieldName = "CofinsTotal";
            this.colCofinsTotal.Name = "colCofinsTotal";
            this.colCofinsTotal.Visible = true;
            this.colCofinsTotal.VisibleIndex = 20;
            this.colCofinsTotal.Width = 78;
            // 
            // colICMSTotal
            // 
            this.colICMSTotal.FieldName = "ICMSTotal";
            this.colICMSTotal.Name = "colICMSTotal";
            this.colICMSTotal.Visible = true;
            this.colICMSTotal.VisibleIndex = 21;
            this.colICMSTotal.Width = 76;
            // 
            // colIITotal
            // 
            this.colIITotal.FieldName = "IITotal";
            this.colIITotal.Name = "colIITotal";
            this.colIITotal.Visible = true;
            this.colIITotal.VisibleIndex = 22;
            this.colIITotal.Width = 76;
            // 
            // colIPITotal
            // 
            this.colIPITotal.FieldName = "IPITotal";
            this.colIPITotal.Name = "colIPITotal";
            this.colIPITotal.Visible = true;
            this.colIPITotal.VisibleIndex = 23;
            this.colIPITotal.Width = 76;
            // 
            // colICMSSTTotal
            // 
            this.colICMSSTTotal.FieldName = "ICMSSTTotal";
            this.colICMSSTTotal.Name = "colICMSSTTotal";
            this.colICMSSTTotal.Visible = true;
            this.colICMSSTTotal.VisibleIndex = 24;
            this.colICMSSTTotal.Width = 85;
            // 
            // colTotalCusteio
            // 
            this.colTotalCusteio.FieldName = "TotalCusteio";
            this.colTotalCusteio.Name = "colTotalCusteio";
            this.colTotalCusteio.Visible = true;
            this.colTotalCusteio.VisibleIndex = 25;
            this.colTotalCusteio.Width = 84;
            // 
            // colCapataziaEstrangeira
            // 
            this.colCapataziaEstrangeira.FieldName = "CapataziaEstrangeira";
            this.colCapataziaEstrangeira.Name = "colCapataziaEstrangeira";
            this.colCapataziaEstrangeira.OptionsColumn.ReadOnly = true;
            this.colCapataziaEstrangeira.Visible = true;
            this.colCapataziaEstrangeira.VisibleIndex = 26;
            this.colCapataziaEstrangeira.Width = 127;
            // 
            // colIITotalEstrangeira
            // 
            this.colIITotalEstrangeira.FieldName = "IITotalEstrangeira";
            this.colIITotalEstrangeira.Name = "colIITotalEstrangeira";
            this.colIITotalEstrangeira.OptionsColumn.ReadOnly = true;
            this.colIITotalEstrangeira.Visible = true;
            this.colIITotalEstrangeira.VisibleIndex = 27;
            this.colIITotalEstrangeira.Width = 114;
            // 
            // colIPITotalEstrangeira
            // 
            this.colIPITotalEstrangeira.FieldName = "IPITotalEstrangeira";
            this.colIPITotalEstrangeira.Name = "colIPITotalEstrangeira";
            this.colIPITotalEstrangeira.OptionsColumn.ReadOnly = true;
            this.colIPITotalEstrangeira.Visible = true;
            this.colIPITotalEstrangeira.VisibleIndex = 28;
            this.colIPITotalEstrangeira.Width = 120;
            // 
            // colPISTotalEstrangeira
            // 
            this.colPISTotalEstrangeira.FieldName = "PISTotalEstrangeira";
            this.colPISTotalEstrangeira.Name = "colPISTotalEstrangeira";
            this.colPISTotalEstrangeira.OptionsColumn.ReadOnly = true;
            this.colPISTotalEstrangeira.Visible = true;
            this.colPISTotalEstrangeira.VisibleIndex = 29;
            this.colPISTotalEstrangeira.Width = 122;
            // 
            // colCofinsTotalEstrangeira
            // 
            this.colCofinsTotalEstrangeira.FieldName = "CofinsTotalEstrangeira";
            this.colCofinsTotalEstrangeira.Name = "colCofinsTotalEstrangeira";
            this.colCofinsTotalEstrangeira.OptionsColumn.ReadOnly = true;
            this.colCofinsTotalEstrangeira.Visible = true;
            this.colCofinsTotalEstrangeira.VisibleIndex = 30;
            this.colCofinsTotalEstrangeira.Width = 136;
            // 
            // colICMSMoedaEstrangeira
            // 
            this.colICMSMoedaEstrangeira.FieldName = "ICMSMoedaEstrangeira";
            this.colICMSMoedaEstrangeira.Name = "colICMSMoedaEstrangeira";
            this.colICMSMoedaEstrangeira.OptionsColumn.ReadOnly = true;
            this.colICMSMoedaEstrangeira.Visible = true;
            this.colICMSMoedaEstrangeira.VisibleIndex = 31;
            this.colICMSMoedaEstrangeira.Width = 139;
            // 
            // colItensCusteio
            // 
            this.colItensCusteio.FieldName = "ItensCusteio";
            this.colItensCusteio.Name = "colItensCusteio";
            this.colItensCusteio.Width = 85;
            // 
            // colDespesas
            // 
            this.colDespesas.FieldName = "Despesas";
            this.colDespesas.Name = "colDespesas";
            this.colDespesas.Width = 76;
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
            this.barBtnAddCusteio,
            this.barBtnViewCusteio});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAddCusteio),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnViewCusteio),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRefresh)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnAddCusteio
            // 
            this.barBtnAddCusteio.Caption = "Novo";
            this.barBtnAddCusteio.Id = 1;
            this.barBtnAddCusteio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddCusteio.ImageOptions.Image")));
            this.barBtnAddCusteio.Name = "barBtnAddCusteio";
            this.barBtnAddCusteio.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem1.Text = "Adicionar NF";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Permite a inclusão de uma nova nota fiscal no sistema.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barBtnAddCusteio.SuperTip = superToolTip1;
            this.barBtnAddCusteio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddCusteio_ItemClick);
            // 
            // barBtnViewCusteio
            // 
            this.barBtnViewCusteio.Caption = "Visualizar/Editar";
            this.barBtnViewCusteio.Id = 3;
            this.barBtnViewCusteio.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnViewCusteio.ImageOptions.Image")));
            this.barBtnViewCusteio.Name = "barBtnViewCusteio";
            this.barBtnViewCusteio.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Cancelar";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Permite o cancelamento de uma nota fiscal já registrada no sistema.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barBtnViewCusteio.SuperTip = superToolTip2;
            this.barBtnViewCusteio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnViewCusteio_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(759, 48);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 383);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(759, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 335);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(759, 48);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 335);
            // 
            // XFrmCusteioListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 404);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmCusteioListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custeios de importação";
            this.Shown += new System.EventHandler(this.XFrmCusteioListView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custeioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnAddCusteio;
        private DevExpress.XtraBars.BarButtonItem barBtnViewCusteio;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource custeioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCusteio;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCalculo;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroProcesso;
        private DevExpress.XtraGrid.Columns.GridColumn colValorFobTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCapatazia;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCif;
        private DevExpress.XtraGrid.Columns.GridColumn colFabricante;
        private DevExpress.XtraGrid.Columns.GridColumn colExportador;
        private DevExpress.XtraGrid.Columns.GridColumn colIncoterms;
        private DevExpress.XtraGrid.Columns.GridColumn colPortoOrigem;
        private DevExpress.XtraGrid.Columns.GridColumn colPortoDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colPaisOrigem;
        private DevExpress.XtraGrid.Columns.GridColumn colPaisDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMoedaReais;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMoedaEstrangeira;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantideContainer;
        private DevExpress.XtraGrid.Columns.GridColumn colContainer;
        private DevExpress.XtraGrid.Columns.GridColumn colPISTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colCofinsTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colICMSTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIITotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIPITotal;
        private DevExpress.XtraGrid.Columns.GridColumn colICMSSTTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCusteio;
        private DevExpress.XtraGrid.Columns.GridColumn colCapataziaEstrangeira;
        private DevExpress.XtraGrid.Columns.GridColumn colIITotalEstrangeira;
        private DevExpress.XtraGrid.Columns.GridColumn colIPITotalEstrangeira;
        private DevExpress.XtraGrid.Columns.GridColumn colPISTotalEstrangeira;
        private DevExpress.XtraGrid.Columns.GridColumn colCofinsTotalEstrangeira;
        private DevExpress.XtraGrid.Columns.GridColumn colICMSMoedaEstrangeira;
        private DevExpress.XtraGrid.Columns.GridColumn colItensCusteio;
        private DevExpress.XtraGrid.Columns.GridColumn colDespesas;
    }
}