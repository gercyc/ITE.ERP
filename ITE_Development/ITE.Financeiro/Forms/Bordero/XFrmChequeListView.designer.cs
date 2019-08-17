using ITSolution.Framework.Components;

namespace ITE.Financeiro.Forms.Bordero
{
    partial class XFrmChequeListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmChequeListView));
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.gridControlCheques = new DevExpress.XtraGrid.GridControl();
            this.bsCheque = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCheque = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageNatureza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barBtnAlterarCheque = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnNovoCheque = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCancelarCheque = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCompensar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExcluirCheque = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repComboBoxSituacao = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lblCredito = new DevExpress.XtraEditors.LabelControl();
            this.panelSomatorio1 = new ITSolution.Framework.Components.PanelSum();
            this.lblLiquido = new DevExpress.XtraEditors.LabelControl();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblDebito = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnConsultarCheques = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbStatusCheques = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtEditDataFinal = new DevExpress.XtraEditors.DateEdit();
            this.dtEditDataInicial = new DevExpress.XtraEditors.DateEdit();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.barBtnConsultarCheque = new DevExpress.XtraBars.BarButtonItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSomatorio1)).BeginInit();
            this.panelSomatorio1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusCheques.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataInicial.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlCheques
            // 
            this.gridControlCheques.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlCheques.DataSource = this.bsCheque;
            this.gridControlCheques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCheques.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlCheques.Location = new System.Drawing.Point(3, 57);
            this.gridControlCheques.MainView = this.gridViewCheque;
            this.gridControlCheques.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlCheques.Name = "gridControlCheques";
            this.gridControlCheques.Size = new System.Drawing.Size(1065, 394);
            this.gridControlCheques.TabIndex = 1;
            this.gridControlCheques.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCheque});
            // 
            // gridViewCheque
            // 
            this.gridViewCheque.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewCheque.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewCheque.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSituacao,
            this.colImage,
            this.colTipoLancamento,
            this.colImageNatureza,
            this.colIdCheque,
            this.colNumeroCheque,
            this.colDataLancamento,
            this.colDataVencimento,
            this.colIdCliente,
            this.colCliente,
            this.colObservacao,
            this.colValorCheque});
            this.gridViewCheque.GridControl = this.gridControlCheques;
            this.gridViewCheque.Name = "gridViewCheque";
            this.gridViewCheque.OptionsSelection.MultiSelect = true;
            this.gridViewCheque.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            // 
            // colSituacao
            // 
            this.colSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.colSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSituacao.Caption = "Stituação";
            this.colSituacao.FieldName = "Situacao";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.OptionsColumn.AllowEdit = false;
            this.colSituacao.Visible = true;
            this.colSituacao.VisibleIndex = 1;
            this.colSituacao.Width = 76;
            // 
            // colImage
            // 
            this.colImage.Caption = " ";
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 30;
            // 
            // colTipoLancamento
            // 
            this.colTipoLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoLancamento.Caption = "Tipo";
            this.colTipoLancamento.FieldName = "TipoLancamento";
            this.colTipoLancamento.Name = "colTipoLancamento";
            this.colTipoLancamento.OptionsColumn.AllowEdit = false;
            this.colTipoLancamento.Visible = true;
            this.colTipoLancamento.VisibleIndex = 3;
            this.colTipoLancamento.Width = 101;
            // 
            // colImageNatureza
            // 
            this.colImageNatureza.Caption = " ";
            this.colImageNatureza.FieldName = "ImageNatureza";
            this.colImageNatureza.Name = "colImageNatureza";
            this.colImageNatureza.Visible = true;
            this.colImageNatureza.VisibleIndex = 2;
            this.colImageNatureza.Width = 23;
            // 
            // colIdCheque
            // 
            this.colIdCheque.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCheque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCheque.Caption = "ID";
            this.colIdCheque.FieldName = "IdCheque";
            this.colIdCheque.Name = "colIdCheque";
            this.colIdCheque.OptionsColumn.AllowEdit = false;
            // 
            // colNumeroCheque
            // 
            this.colNumeroCheque.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroCheque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumeroCheque.Caption = "Nº Cheque";
            this.colNumeroCheque.FieldName = "NumeroCheque";
            this.colNumeroCheque.Name = "colNumeroCheque";
            this.colNumeroCheque.OptionsColumn.AllowEdit = false;
            this.colNumeroCheque.Visible = true;
            this.colNumeroCheque.VisibleIndex = 4;
            this.colNumeroCheque.Width = 101;
            // 
            // colDataLancamento
            // 
            this.colDataLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataLancamento.Caption = "Dt. Lançamento";
            this.colDataLancamento.FieldName = "DataLancamento";
            this.colDataLancamento.Name = "colDataLancamento";
            this.colDataLancamento.OptionsColumn.AllowEdit = false;
            this.colDataLancamento.Visible = true;
            this.colDataLancamento.VisibleIndex = 6;
            this.colDataLancamento.Width = 102;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVencimento.Caption = "Dt. Vencimento";
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.OptionsColumn.AllowEdit = false;
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 7;
            this.colDataVencimento.Width = 102;
            // 
            // colIdCliente
            // 
            this.colIdCliente.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.OptionsColumn.AllowEdit = false;
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
            this.colCliente.VisibleIndex = 5;
            this.colCliente.Width = 248;
            // 
            // colObservacao
            // 
            this.colObservacao.AppearanceCell.Options.UseTextOptions = true;
            this.colObservacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.OptionsColumn.AllowEdit = false;
            // 
            // colValorCheque
            // 
            this.colValorCheque.AppearanceCell.Options.UseTextOptions = true;
            this.colValorCheque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorCheque.Caption = "Valor Cheque";
            this.colValorCheque.FieldName = "ValorCheque";
            this.colValorCheque.Name = "colValorCheque";
            this.colValorCheque.OptionsColumn.AllowEdit = false;
            this.colValorCheque.Visible = true;
            this.colValorCheque.VisibleIndex = 8;
            this.colValorCheque.Width = 114;
            // 
            // barBtnAlterarCheque
            // 
            this.barBtnAlterarCheque.Caption = "Alterar";
            this.barBtnAlterarCheque.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterarCheque.Glyph")));
            this.barBtnAlterarCheque.Id = 12;
            this.barBtnAlterarCheque.Name = "barBtnAlterarCheque";
            this.barBtnAlterarCheque.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAlterarCheque.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAlterarCheque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterarCheque_ItemClick);
            // 
            // barBtnNovoCheque
            // 
            this.barBtnNovoCheque.Caption = "Lançar/Calcular Cheque";
            this.barBtnNovoCheque.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovoCheque.Glyph")));
            this.barBtnNovoCheque.Id = 0;
            this.barBtnNovoCheque.Name = "barBtnNovoCheque";
            this.barBtnNovoCheque.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnNovoCheque.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnNovoCheque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovoCheque_ItemClick);
            // 
            // barBtnCancelarCheque
            // 
            this.barBtnCancelarCheque.Caption = "Cancelar";
            this.barBtnCancelarCheque.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelarCheque.Glyph")));
            this.barBtnCancelarCheque.Id = 1;
            this.barBtnCancelarCheque.Name = "barBtnCancelarCheque";
            this.barBtnCancelarCheque.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnCancelarCheque.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnCancelarCheque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelarCheque_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 11;
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem3.Text = "Carregador todos os cheques.";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Sem exceção";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.barBtnAtualizar.SuperTip = superToolTip3;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Situação";
            this.barStaticItem3.Id = 9;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnNovoCheque,
            this.barBtnCancelarCheque,
            this.barStaticItem3,
            this.barBtnAtualizar,
            this.barBtnAlterarCheque,
            this.barBtnImprimir,
            this.barBtnCompensar,
            this.barBtnExcluirCheque});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repComboBoxSituacao});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1071, 183);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barBtnImprimir
            // 
            this.barBtnImprimir.Caption = "Imprimir";
            this.barBtnImprimir.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnImprimir.Glyph")));
            this.barBtnImprimir.Id = 4;
            this.barBtnImprimir.Name = "barBtnImprimir";
            this.barBtnImprimir.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnCompensar
            // 
            this.barBtnCompensar.Caption = "Compensar Cheque";
            this.barBtnCompensar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCompensar.Glyph")));
            this.barBtnCompensar.Id = 7;
            this.barBtnCompensar.Name = "barBtnCompensar";
            this.barBtnCompensar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnExcluirCheque
            // 
            this.barBtnExcluirCheque.Caption = "Excluir Cheque";
            this.barBtnExcluirCheque.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExcluirCheque.Glyph")));
            this.barBtnExcluirCheque.Id = 8;
            this.barBtnExcluirCheque.Name = "barBtnExcluirCheque";
            this.barBtnExcluirCheque.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tarefas";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnNovoCheque);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAlterarCheque);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCompensar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnImprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAtualizar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Gerenciador Cheques";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnCancelarCheque);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnExcluirCheque);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Util";
            // 
            // repComboBoxSituacao
            // 
            this.repComboBoxSituacao.AutoHeight = false;
            this.repComboBoxSituacao.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repComboBoxSituacao.Items.AddRange(new object[] {
            "",
            "Aberto",
            "Vencido",
            "Compensado",
            "Cancelado",
            "Vencendo Hoje"});
            this.repComboBoxSituacao.Name = "repComboBoxSituacao";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 681);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1071, 41);
            // 
            // lblCredito
            // 
            this.lblCredito.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.Location = new System.Drawing.Point(65, 11);
            this.lblCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(58, 18);
            this.lblCredito.TabIndex = 9;
            this.lblCredito.Text = "R$ 0,00";
            // 
            // panelSomatorio1
            // 
            this.panelSomatorio1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSomatorio1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelSomatorio1.Controls.Add(this.lblCredito);
            this.panelSomatorio1.Controls.Add(this.lblLiquido);
            this.panelSomatorio1.Controls.Add(this.lblTotal);
            this.panelSomatorio1.Controls.Add(this.labelControl1);
            this.panelSomatorio1.Controls.Add(this.lblDebito);
            this.panelSomatorio1.Controls.Add(this.labelControl2);
            this.panelSomatorio1.Controls.Add(this.labelControl5);
            this.panelSomatorio1.Controls.Add(this.labelControl3);
            this.panelSomatorio1.Location = new System.Drawing.Point(3, 457);
            this.panelSomatorio1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSomatorio1.Name = "panelSomatorio1";
            this.panelSomatorio1.Size = new System.Drawing.Size(1065, 39);
            this.panelSomatorio1.TabIndex = 3;
            // 
            // lblLiquido
            // 
            this.lblLiquido.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiquido.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLiquido.Location = new System.Drawing.Point(503, 11);
            this.lblLiquido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLiquido.Name = "lblLiquido";
            this.lblLiquido.Size = new System.Drawing.Size(58, 18);
            this.lblLiquido.TabIndex = 11;
            this.lblLiquido.Text = "R$ 0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(714, 11);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 18);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(3, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 18);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Crédito";
            // 
            // lblDebito
            // 
            this.lblDebito.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebito.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblDebito.Location = new System.Drawing.Point(302, 11);
            this.lblDebito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(58, 18);
            this.lblDebito.TabIndex = 10;
            this.lblDebito.Text = "R$ 0,00";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(247, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Débito";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl5.Location = new System.Drawing.Point(670, 11);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 18);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Total";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl3.Location = new System.Drawing.Point(444, 11);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 18);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Liquído";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnConsultarCheques);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Controls.Add(this.cbStatusCheques);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.dtEditDataFinal);
            this.panelControl2.Controls.Add(this.dtEditDataInicial);
            this.panelControl2.Controls.Add(this.searchControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(3, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1065, 49);
            this.panelControl2.TabIndex = 1;
            // 
            // btnConsultarCheques
            // 
            this.btnConsultarCheques.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarCheques.Image")));
            this.btnConsultarCheques.Location = new System.Drawing.Point(910, 11);
            this.btnConsultarCheques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarCheques.Name = "btnConsultarCheques";
            this.btnConsultarCheques.Size = new System.Drawing.Size(92, 28);
            this.btnConsultarCheques.TabIndex = 7;
            this.btnConsultarCheques.Text = "Consultar";
            this.btnConsultarCheques.Click += new System.EventHandler(this.btnConsultarCheques_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(698, 16);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 16);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Situação:";
            // 
            // cbStatusCheques
            // 
            this.cbStatusCheques.Location = new System.Drawing.Point(761, 14);
            this.cbStatusCheques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatusCheques.MenuManager = this.ribbonControl1;
            this.cbStatusCheques.Name = "cbStatusCheques";
            this.cbStatusCheques.Properties.Appearance.Options.UseFont = true;
            this.cbStatusCheques.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbStatusCheques.Properties.Items.AddRange(new object[] {
            "",
            "Aberto",
            "Vencido",
            "Compensado",
            "Cancelado",
            "Devolvido",
            "Vencendo Hoje"});
            this.cbStatusCheques.Size = new System.Drawing.Size(143, 22);
            this.cbStatusCheques.TabIndex = 5;
            this.cbStatusCheques.SelectedIndexChanged += new System.EventHandler(this.cbStatusCheques_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(567, 16);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(19, 16);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Até";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(435, 16);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(20, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "De:";
            // 
            // dtEditDataFinal
            // 
            this.dtEditDataFinal.EditValue = null;
            this.dtEditDataFinal.Location = new System.Drawing.Point(591, 14);
            this.dtEditDataFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEditDataFinal.MenuManager = this.ribbonControl1;
            this.dtEditDataFinal.Name = "dtEditDataFinal";
            this.dtEditDataFinal.Properties.Appearance.Options.UseFont = true;
            this.dtEditDataFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDataFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDataFinal.Size = new System.Drawing.Size(100, 22);
            this.dtEditDataFinal.TabIndex = 2;
            // 
            // dtEditDataInicial
            // 
            this.dtEditDataInicial.EditValue = null;
            this.dtEditDataInicial.Location = new System.Drawing.Point(461, 14);
            this.dtEditDataInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEditDataInicial.MenuManager = this.ribbonControl1;
            this.dtEditDataInicial.Name = "dtEditDataInicial";
            this.dtEditDataInicial.Properties.Appearance.Options.UseFont = true;
            this.dtEditDataInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDataInicial.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDataInicial.Size = new System.Drawing.Size(100, 22);
            this.dtEditDataInicial.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControlCheques;
            this.searchControl1.Location = new System.Drawing.Point(12, 10);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchControl1.MenuManager = this.ribbonControl1;
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControlCheques;
            this.searchControl1.Properties.NullValuePrompt = "Digite aqui sua pesquisa...";
            this.searchControl1.Size = new System.Drawing.Size(415, 28);
            this.searchControl1.TabIndex = 0;
            // 
            // barBtnConsultarCheque
            // 
            this.barBtnConsultarCheque.Caption = "Consultar";
            this.barBtnConsultarCheque.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnConsultarCheque.Glyph")));
            this.barBtnConsultarCheque.Id = 8;
            this.barBtnConsultarCheque.Name = "barBtnConsultarCheque";
            this.barBtnConsultarCheque.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnConsultarCheque.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem4.Text = "Carrega todos os cheques no período específico.";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Utilize o filtro abaixo para complementar o critério de consulta";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.barBtnConsultarCheque.SuperTip = superToolTip4;
            this.barBtnConsultarCheque.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnConsultarCheque_ItemClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSomatorio1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridControlCheques, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 183);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1071, 498);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // XFrmChequeListView
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 722);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmChequeListView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Gerenciador de Cheques";
            this.Shown += new System.EventHandler(this.XFrmInfoCheque_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboBoxSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSomatorio1)).EndInit();
            this.panelSomatorio1.ResumeLayout(false);
            this.panelSomatorio1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbStatusCheques.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataInicial.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCheques;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCheque;
        private System.Windows.Forms.BindingSource bsCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colDataLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacao;
        private DevExpress.XtraBars.BarButtonItem barBtnNovoCheque;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelarCheque;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarButtonItem barBtnAlterarCheque;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repComboBoxSituacao;
        private DevExpress.XtraEditors.LabelControl lblCredito;
        private PanelSum panelSomatorio1;
        private DevExpress.XtraEditors.LabelControl lblLiquido;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblDebito;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.BarButtonItem barBtnImprimir;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton btnConsultarCheques;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cbStatusCheques;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dtEditDataFinal;
        private DevExpress.XtraEditors.DateEdit dtEditDataInicial;
        private DevExpress.XtraBars.BarButtonItem barBtnConsultarCheque;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.BarButtonItem barBtnCompensar;
        private DevExpress.XtraBars.BarButtonItem barBtnExcluirCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colImageNatureza;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}