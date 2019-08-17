using ITSolution.Framework.Components;

namespace ITE.Bordero.Forms.Calculator
{
    partial class XFrmChequeCalculadoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmChequeCalculadoView));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsCheque = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCompensacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompensacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrazoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLiquido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorJuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTotalLiquido = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalJuros = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnVoltar = new DevExpress.XtraBars.BarButtonItem();
            this.bartBtnRemoveCh = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelSum1 = new PanelSum();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSum1)).BeginInit();
            this.panelSum1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.bsCheque;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 57);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(968, 496);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsCheque
            // 
            this.bsCheque.DataSource = typeof(ITE.Entidades.POCO.Bordero.Cheque);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCheque,
            this.colNumeroCheque,
            this.colDataLancamento,
            this.colDataVencimento,
            this.colDataCompensacao,
            this.colIdCliente,
            this.colCliente,
            this.colPrazo,
            this.colCompensacao,
            this.colPrazoTotal,
            this.colValorLiquido,
            this.colValorJuros,
            this.colValorCheque,
            this.colTipoLancamento,
            this.colObservacao,
            this.colSituacao});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCheque
            // 
            this.colIdCheque.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCheque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdCheque.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCheque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdCheque.Caption = "Item";
            this.colIdCheque.FieldName = "Sequencial";
            this.colIdCheque.Name = "colIdCheque";
            this.colIdCheque.Visible = true;
            this.colIdCheque.VisibleIndex = 0;
            // 
            // colNumeroCheque
            // 
            this.colNumeroCheque.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroCheque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroCheque.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroCheque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroCheque.Caption = "Número Cheque";
            this.colNumeroCheque.FieldName = "NumeroCheque";
            this.colNumeroCheque.Name = "colNumeroCheque";
            this.colNumeroCheque.Visible = true;
            this.colNumeroCheque.VisibleIndex = 1;
            // 
            // colDataLancamento
            // 
            this.colDataLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataLancamento.FieldName = "DataLancamento";
            this.colDataLancamento.Name = "colDataLancamento";
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataVencimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataVencimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataVencimento.Caption = "Dt. Vencimento";
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 2;
            // 
            // colDataCompensacao
            // 
            this.colDataCompensacao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataCompensacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataCompensacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataCompensacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDataCompensacao.FieldName = "DataCompensacao";
            this.colDataCompensacao.Name = "colDataCompensacao";
            // 
            // colIdCliente
            // 
            this.colIdCliente.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdCliente.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colCliente
            // 
            this.colCliente.AppearanceCell.Options.UseTextOptions = true;
            this.colCliente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCliente.AppearanceHeader.Options.UseTextOptions = true;
            this.colCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            // 
            // colPrazo
            // 
            this.colPrazo.AppearanceCell.Options.UseTextOptions = true;
            this.colPrazo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrazo.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrazo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrazo.FieldName = "Prazo";
            this.colPrazo.Name = "colPrazo";
            this.colPrazo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prazo", "SUM={0:0.##}")});
            this.colPrazo.Visible = true;
            this.colPrazo.VisibleIndex = 3;
            // 
            // colCompensacao
            // 
            this.colCompensacao.AppearanceCell.Options.UseTextOptions = true;
            this.colCompensacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompensacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompensacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCompensacao.FieldName = "Compensacao";
            this.colCompensacao.Name = "colCompensacao";
            // 
            // colPrazoTotal
            // 
            this.colPrazoTotal.AppearanceCell.Options.UseTextOptions = true;
            this.colPrazoTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrazoTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrazoTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrazoTotal.FieldName = "PrazoTotal";
            this.colPrazoTotal.Name = "colPrazoTotal";
            // 
            // colValorLiquido
            // 
            this.colValorLiquido.AppearanceCell.Options.UseTextOptions = true;
            this.colValorLiquido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorLiquido.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorLiquido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorLiquido.Caption = "Valor Líquido";
            this.colValorLiquido.DisplayFormat.FormatString = "n2";
            this.colValorLiquido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorLiquido.FieldName = "ValorLiquido";
            this.colValorLiquido.Name = "colValorLiquido";
            this.colValorLiquido.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorLiquido", "SUM={0:0.##}")});
            this.colValorLiquido.Visible = true;
            this.colValorLiquido.VisibleIndex = 6;
            // 
            // colValorJuros
            // 
            this.colValorJuros.AppearanceCell.Options.UseTextOptions = true;
            this.colValorJuros.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorJuros.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorJuros.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorJuros.Caption = "Valor Juros";
            this.colValorJuros.DisplayFormat.FormatString = "n2";
            this.colValorJuros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorJuros.FieldName = "ValorJuros";
            this.colValorJuros.Name = "colValorJuros";
            this.colValorJuros.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorJuros", "SUM={0:0.##}")});
            this.colValorJuros.Visible = true;
            this.colValorJuros.VisibleIndex = 5;
            // 
            // colValorCheque
            // 
            this.colValorCheque.AppearanceCell.Options.UseTextOptions = true;
            this.colValorCheque.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorCheque.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorCheque.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorCheque.Caption = "Valor Cheque";
            this.colValorCheque.DisplayFormat.FormatString = "n2";
            this.colValorCheque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorCheque.FieldName = "ValorCheque";
            this.colValorCheque.Name = "colValorCheque";
            this.colValorCheque.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorCheque", "SUM={0:0.##}")});
            this.colValorCheque.Visible = true;
            this.colValorCheque.VisibleIndex = 4;
            // 
            // colTipoLancamento
            // 
            this.colTipoLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTipoLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTipoLancamento.FieldName = "TipoLancamento";
            this.colTipoLancamento.Name = "colTipoLancamento";
            // 
            // colObservacao
            // 
            this.colObservacao.AppearanceCell.Options.UseTextOptions = true;
            this.colObservacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colObservacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colObservacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            // 
            // colSituacao
            // 
            this.colSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.colSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSituacao.FieldName = "Situacao";
            this.colSituacao.Name = "colSituacao";
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalLiquido.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalLiquido.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalLiquido.Location = new System.Drawing.Point(452, 8);
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(68, 22);
            this.lblTotalLiquido.TabIndex = 22;
            this.lblTotalLiquido.Text = "R$ 0,00";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelControl3.Location = new System.Drawing.Point(324, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(122, 22);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Total Líquido:";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 22);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Total Juros:";
            // 
            // lblTotalJuros
            // 
            this.lblTotalJuros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalJuros.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalJuros.Location = new System.Drawing.Point(124, 8);
            this.lblTotalJuros.Name = "lblTotalJuros";
            this.lblTotalJuros.Size = new System.Drawing.Size(68, 22);
            this.lblTotalJuros.TabIndex = 21;
            this.lblTotalJuros.Text = "R$ 0,00";
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
            this.barBtnAtualizar,
            this.barBtnVoltar,
            this.bartBtnRemoveCh});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnVoltar),
            new DevExpress.XtraBars.LinkPersistInfo(this.bartBtnRemoveCh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAtualizar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnVoltar
            // 
            this.barBtnVoltar.Caption = "Voltar";
            this.barBtnVoltar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnVoltar.Glyph")));
            this.barBtnVoltar.Id = 1;
            this.barBtnVoltar.Name = "barBtnVoltar";
            this.barBtnVoltar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnVoltar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnVoltar_ItemClick);
            // 
            // bartBtnRemoveCh
            // 
            this.bartBtnRemoveCh.Caption = "Remover Cheque";
            this.bartBtnRemoveCh.Id = 2;
            this.bartBtnRemoveCh.Name = "bartBtnRemoveCh";
            this.bartBtnRemoveCh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bartBtnRemoveCh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bartBtnRemoveCh_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 0;
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
            this.barDockControlTop.Size = new System.Drawing.Size(968, 57);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 596);
            this.barDockControlBottom.Size = new System.Drawing.Size(968, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 57);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 539);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(968, 57);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 539);
            // 
            // panelSum1
            // 
            this.panelSum1.Controls.Add(this.labelControl1);
            this.panelSum1.Controls.Add(this.labelControl3);
            this.panelSum1.Controls.Add(this.lblTotalLiquido);
            this.panelSum1.Controls.Add(this.lblTotalJuros);
            this.panelSum1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSum1.Location = new System.Drawing.Point(0, 559);
            this.panelSum1.Name = "panelSum1";
            this.panelSum1.Size = new System.Drawing.Size(968, 37);
            this.panelSum1.TabIndex = 1;
            // 
            // XFrmChequeCalculadoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 618);
            this.Controls.Add(this.panelSum1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmChequeCalculadoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheques";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCheque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSum1)).EndInit();
            this.panelSum1.ResumeLayout(false);
            this.panelSum1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bsCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colDataLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCompensacao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colPrazo;
        private DevExpress.XtraGrid.Columns.GridColumn colCompensacao;
        private DevExpress.XtraGrid.Columns.GridColumn colPrazoTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLiquido;
        private DevExpress.XtraGrid.Columns.GridColumn colValorJuros;
        private DevExpress.XtraGrid.Columns.GridColumn colValorCheque;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacao;
        private DevExpress.XtraEditors.LabelControl lblTotalLiquido;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblTotalJuros;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnVoltar;
        private DevExpress.XtraBars.BarButtonItem bartBtnRemoveCh;
        private PanelSum panelSum1;
    }
}