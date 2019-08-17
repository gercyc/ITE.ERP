namespace ITE.Teste._Testador
{
    partial class XFrmTestador
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblMedia = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblContagem = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblSoma = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAttachmentIco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorJuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasPrazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencialParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliForParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNatImg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNotaFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCancelamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoCancelamento = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblMedia);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblContagem);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lblSoma);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 407);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(752, 35);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl1.Location = new System.Drawing.Point(469, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.labelControl1.Size = new System.Drawing.Size(32, 21);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Média:";
            // 
            // lblMedia
            // 
            this.lblMedia.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMedia.Location = new System.Drawing.Point(501, 2);
            this.lblMedia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Padding = new System.Windows.Forms.Padding(4, 8, 34, 0);
            this.lblMedia.Size = new System.Drawing.Size(54, 21);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "0,0";
            // 
            // labelControl2
            // 
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl2.Location = new System.Drawing.Point(555, 2);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(0, 8, 9, 0);
            this.labelControl2.Size = new System.Drawing.Size(62, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Contagem:";
            // 
            // lblContagem
            // 
            this.lblContagem.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblContagem.Location = new System.Drawing.Point(617, 2);
            this.lblContagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblContagem.Name = "lblContagem";
            this.lblContagem.Padding = new System.Windows.Forms.Padding(0, 8, 34, 0);
            this.lblContagem.Size = new System.Drawing.Size(40, 21);
            this.lblContagem.TabIndex = 2;
            this.lblContagem.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl3.Location = new System.Drawing.Point(657, 2);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(0, 8, 4, 0);
            this.labelControl3.Size = new System.Drawing.Size(34, 21);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Soma:";
            // 
            // lblSoma
            // 
            this.lblSoma.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSoma.Location = new System.Drawing.Point(691, 2);
            this.lblSoma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Padding = new System.Windows.Forms.Padding(0, 8, 43, 0);
            this.lblSoma.Size = new System.Drawing.Size(59, 21);
            this.lblSoma.TabIndex = 0;
            this.lblSoma.Text = "0,0";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAttachmentIco,
            this.colIdLancamento,
            this.colValorLancamento,
            this.colValorJuros,
            this.colTotalLancamento,
            this.colDataVencimento,
            this.colDataLancamento,
            this.colDataPagamento,
            this.colDiasPrazo,
            this.colObservacao,
            this.colSequencialParcela,
            this.colStatus,
            this.colIdCliFor,
            this.colCliForParcela,
            this.colCentroCusto,
            this.colIdCentroCusto,
            this.colImageStatus,
            this.colTipoLancamento,
            this.colNatImg,
            this.colRecCreatedBy,
            this.colRecCreatedDate,
            this.colIdNotaFiscal,
            this.colFormaPagamento,
            this.colFilial,
            this.colDataCancelamento,
            this.colMotivoCancelamento});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorLancamento", this.colValorLancamento, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colValorLancamento, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colAttachmentIco
            // 
            this.colAttachmentIco.Caption = " ";
            this.colAttachmentIco.FieldName = "AttachmentIco";
            this.colAttachmentIco.Name = "colAttachmentIco";
            this.colAttachmentIco.Width = 28;
            // 
            // colIdLancamento
            // 
            this.colIdLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colIdLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdLancamento.Caption = "ID Lançto";
            this.colIdLancamento.FieldName = "IdLancamento";
            this.colIdLancamento.Name = "colIdLancamento";
            this.colIdLancamento.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdLancamento", "{0}")});
            this.colIdLancamento.Visible = true;
            this.colIdLancamento.VisibleIndex = 5;
            this.colIdLancamento.Width = 80;
            // 
            // colValorLancamento
            // 
            this.colValorLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colValorLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorLancamento.Caption = "Valor";
            this.colValorLancamento.DisplayFormat.FormatString = "n2";
            this.colValorLancamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorLancamento.FieldName = "ValorLancamento";
            this.colValorLancamento.Name = "colValorLancamento";
            this.colValorLancamento.Visible = true;
            this.colValorLancamento.VisibleIndex = 15;
            this.colValorLancamento.Width = 90;
            // 
            // colValorJuros
            // 
            this.colValorJuros.AppearanceCell.Options.UseTextOptions = true;
            this.colValorJuros.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorJuros.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorJuros.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorJuros.Caption = "Juros";
            this.colValorJuros.DisplayFormat.FormatString = "n2";
            this.colValorJuros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorJuros.FieldName = "ValorJuros";
            this.colValorJuros.Name = "colValorJuros";
            this.colValorJuros.Visible = true;
            this.colValorJuros.VisibleIndex = 16;
            this.colValorJuros.Width = 70;
            // 
            // colTotalLancamento
            // 
            this.colTotalLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalLancamento.Caption = "Total";
            this.colTotalLancamento.DisplayFormat.FormatString = "n2";
            this.colTotalLancamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalLancamento.FieldName = "TotalLancamento";
            this.colTotalLancamento.Name = "colTotalLancamento";
            this.colTotalLancamento.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLancamento", "{0:n2}")});
            this.colTotalLancamento.Visible = true;
            this.colTotalLancamento.VisibleIndex = 13;
            this.colTotalLancamento.Width = 109;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVencimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataVencimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVencimento.Caption = "Vencimento";
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 9;
            // 
            // colDataLancamento
            // 
            this.colDataLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataLancamento.Caption = "Data";
            this.colDataLancamento.FieldName = "DataLancamento";
            this.colDataLancamento.Name = "colDataLancamento";
            this.colDataLancamento.Visible = true;
            this.colDataLancamento.VisibleIndex = 8;
            // 
            // colDataPagamento
            // 
            this.colDataPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataPagamento.Caption = "Data Baixa";
            this.colDataPagamento.FieldName = "DataPagamento";
            this.colDataPagamento.Name = "colDataPagamento";
            this.colDataPagamento.Visible = true;
            this.colDataPagamento.VisibleIndex = 14;
            this.colDataPagamento.Width = 68;
            // 
            // colDiasPrazo
            // 
            this.colDiasPrazo.AppearanceCell.Options.UseTextOptions = true;
            this.colDiasPrazo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDiasPrazo.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiasPrazo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDiasPrazo.Caption = "Prazo";
            this.colDiasPrazo.FieldName = "DiasPrazo";
            this.colDiasPrazo.Name = "colDiasPrazo";
            this.colDiasPrazo.Visible = true;
            this.colDiasPrazo.VisibleIndex = 17;
            this.colDiasPrazo.Width = 60;
            // 
            // colObservacao
            // 
            this.colObservacao.AppearanceCell.Options.UseTextOptions = true;
            this.colObservacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colObservacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.Caption = "Histórico";
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 10;
            this.colObservacao.Width = 275;
            // 
            // colSequencialParcela
            // 
            this.colSequencialParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colSequencialParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSequencialParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.colSequencialParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSequencialParcela.Caption = "Sequencial";
            this.colSequencialParcela.FieldName = "SequencialParcela";
            this.colSequencialParcela.Name = "colSequencialParcela";
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "StatusLancamento";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 73;
            // 
            // colIdCliFor
            // 
            this.colIdCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliFor.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCliFor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliFor.Caption = "Cód. Cliente";
            this.colIdCliFor.FieldName = "IdCliFor";
            this.colIdCliFor.Name = "colIdCliFor";
            // 
            // colCliForParcela
            // 
            this.colCliForParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colCliForParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliForParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.colCliForParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliForParcela.Caption = "Cliente/Fornecedor";
            this.colCliForParcela.FieldName = "CliFor.RazaoSocial";
            this.colCliForParcela.Name = "colCliForParcela";
            this.colCliForParcela.Visible = true;
            this.colCliForParcela.VisibleIndex = 7;
            this.colCliForParcela.Width = 256;
            // 
            // colCentroCusto
            // 
            this.colCentroCusto.AppearanceCell.Options.UseTextOptions = true;
            this.colCentroCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCentroCusto.AppearanceHeader.Options.UseTextOptions = true;
            this.colCentroCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCentroCusto.Caption = "Centro de custo";
            this.colCentroCusto.FieldName = "CentroCusto.NomeCentroCusto";
            this.colCentroCusto.Name = "colCentroCusto";
            this.colCentroCusto.Visible = true;
            this.colCentroCusto.VisibleIndex = 12;
            this.colCentroCusto.Width = 221;
            // 
            // colIdCentroCusto
            // 
            this.colIdCentroCusto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCentroCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCentroCusto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCentroCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCentroCusto.Caption = "Id Centro Custo";
            this.colIdCentroCusto.FieldName = "CodigoCentroCusto";
            this.colIdCentroCusto.Name = "colIdCentroCusto";
            this.colIdCentroCusto.Visible = true;
            this.colIdCentroCusto.VisibleIndex = 11;
            // 
            // colImageStatus
            // 
            this.colImageStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colImageStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImageStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colImageStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImageStatus.Caption = " ";
            this.colImageStatus.FieldName = "Image";
            this.colImageStatus.Name = "colImageStatus";
            this.colImageStatus.OptionsColumn.ReadOnly = true;
            this.colImageStatus.Visible = true;
            this.colImageStatus.VisibleIndex = 1;
            this.colImageStatus.Width = 27;
            // 
            // colTipoLancamento
            // 
            this.colTipoLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoLancamento.Caption = "Natureza";
            this.colTipoLancamento.FieldName = "TipoLancamento";
            this.colTipoLancamento.Name = "colTipoLancamento";
            this.colTipoLancamento.Visible = true;
            this.colTipoLancamento.VisibleIndex = 4;
            // 
            // colNatImg
            // 
            this.colNatImg.AppearanceCell.Options.UseTextOptions = true;
            this.colNatImg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNatImg.AppearanceHeader.Options.UseTextOptions = true;
            this.colNatImg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNatImg.Caption = " ";
            this.colNatImg.FieldName = "ImageNatureza";
            this.colNatImg.Name = "colNatImg";
            this.colNatImg.Visible = true;
            this.colNatImg.VisibleIndex = 3;
            this.colNatImg.Width = 29;
            // 
            // colRecCreatedBy
            // 
            this.colRecCreatedBy.AppearanceCell.Options.UseTextOptions = true;
            this.colRecCreatedBy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRecCreatedBy.AppearanceHeader.Options.UseTextOptions = true;
            this.colRecCreatedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRecCreatedBy.Caption = "Usuário";
            this.colRecCreatedBy.FieldName = "IdUsuario";
            this.colRecCreatedBy.Name = "colRecCreatedBy";
            this.colRecCreatedBy.Visible = true;
            this.colRecCreatedBy.VisibleIndex = 6;
            // 
            // colRecCreatedDate
            // 
            this.colRecCreatedDate.AppearanceCell.Options.UseTextOptions = true;
            this.colRecCreatedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRecCreatedDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRecCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRecCreatedDate.Caption = "Dt. Criação";
            this.colRecCreatedDate.FieldName = "RecCreatedDate";
            this.colRecCreatedDate.Name = "colRecCreatedDate";
            // 
            // colIdNotaFiscal
            // 
            this.colIdNotaFiscal.AppearanceCell.Options.UseTextOptions = true;
            this.colIdNotaFiscal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdNotaFiscal.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdNotaFiscal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdNotaFiscal.Caption = "Núm. NF";
            this.colIdNotaFiscal.FieldName = "NotaFiscal.NumeroNf";
            this.colIdNotaFiscal.Name = "colIdNotaFiscal";
            // 
            // colFormaPagamento
            // 
            this.colFormaPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.colFormaPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFormaPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colFormaPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFormaPagamento.Caption = "Forma de Pagamento";
            this.colFormaPagamento.FieldName = "FormaPagamento.NomeFormaPagamento";
            this.colFormaPagamento.Name = "colFormaPagamento";
            this.colFormaPagamento.Width = 119;
            // 
            // colFilial
            // 
            this.colFilial.AppearanceCell.Options.UseTextOptions = true;
            this.colFilial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFilial.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFilial.Caption = "Cód. Filial";
            this.colFilial.FieldName = "Filial.CodigoFilial";
            this.colFilial.Name = "colFilial";
            // 
            // colDataCancelamento
            // 
            this.colDataCancelamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataCancelamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataCancelamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataCancelamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataCancelamento.Caption = "Dt. Cancelamento";
            this.colDataCancelamento.FieldName = "DataCancelamento";
            this.colDataCancelamento.Name = "colDataCancelamento";
            this.colDataCancelamento.Width = 100;
            // 
            // colMotivoCancelamento
            // 
            this.colMotivoCancelamento.AppearanceCell.Options.UseTextOptions = true;
            this.colMotivoCancelamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMotivoCancelamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colMotivoCancelamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMotivoCancelamento.Caption = "Motivo Cancelamento";
            this.colMotivoCancelamento.FieldName = "MotivoCancelamento";
            this.colMotivoCancelamento.Name = "colMotivoCancelamento";
            this.colMotivoCancelamento.Width = 280;
            // 
            // XFrmTestador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 442);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "XFrmTestador";
            this.Text = "XFrmTestador";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblMedia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblContagem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblSoma;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAttachmentIco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorJuros;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPrazo;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencialParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colCliForParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colImageStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colNatImg;
        private DevExpress.XtraGrid.Columns.GridColumn colRecCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colRecCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNotaFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCancelamento;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoCancelamento;
    }
}