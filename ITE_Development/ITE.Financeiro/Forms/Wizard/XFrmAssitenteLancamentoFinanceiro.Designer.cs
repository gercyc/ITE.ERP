namespace ITE.Financeiro.Forms.Wizard
{
    partial class XFrmAssitenteLancamentoFinanceiro
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
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSequencialParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repStatus = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colImageStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repNatureza = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colNatImg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorJuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.lblDesId = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalLancamento = new DevExpress.XtraEditors.LabelControl();
            this.lblDescValor = new DevExpress.XtraEditors.LabelControl();
            this.lblDataVencimento = new DevExpress.XtraEditors.LabelControl();
            this.lblDescVencimento = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaxaJuros = new DevExpress.XtraEditors.TextEdit();
            this.spinIntervalDias = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvarParcelas = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalLancamento = new DevExpress.XtraEditors.TextEdit();
            this.lblParcelas = new DevExpress.XtraEditors.LabelControl();
            this.spinNumLancamentos = new DevExpress.XtraEditors.SpinEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.wizardPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNatureza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxaJuros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinIntervalDias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalLancamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumLancamentos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.FinishText = "Lançamento(s) gerados com sucesso.";
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.ProceedText = "Para fechar, clique em \"Terminar\"";
            this.completionWizardPage1.Size = new System.Drawing.Size(626, 405);
            this.completionWizardPage1.Text = "Assistente de lançamentos concluído com sucesso.";
            this.completionWizardPage1.PageCommit += new System.EventHandler(this.completionWizardPage1_PageCommit);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.tableLayoutPanel1);
            this.wizardPage1.DescriptionText = "Informe o número de lançamentos e edite os dados da tabela";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(811, 393);
            this.wizardPage1.Text = "Preparando lançamentos";
            this.wizardPage1.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage1_PageValidating);
            this.wizardPage1.PageCommit += new System.EventHandler(this.wizardPage1_PageCommit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.64754F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.35246F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 393);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repStatus,
            this.repNatureza,
            this.repositoryItemMemoExEdit1});
            this.gridControl1.Size = new System.Drawing.Size(805, 314);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSequencialParcela,
            this.colStatus,
            this.colImageStatus,
            this.colTipoLancamento,
            this.colNatImg,
            this.colDataLancamento,
            this.colDataVencimento,
            this.colDataPagamento,
            this.colValorLancamento,
            this.colValorJuros,
            this.colTotalLancamento,
            this.colObservacao,
            this.colFormaPagamento});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorLancamento", this.colValorLancamento, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colSequencialParcela
            // 
            this.colSequencialParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colSequencialParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSequencialParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.colSequencialParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSequencialParcela.Caption = "Nº";
            this.colSequencialParcela.FieldName = "SequencialParcela";
            this.colSequencialParcela.Name = "colSequencialParcela";
            this.colSequencialParcela.OptionsColumn.AllowEdit = false;
            this.colSequencialParcela.Visible = true;
            this.colSequencialParcela.VisibleIndex = 0;
            this.colSequencialParcela.Width = 33;
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.Caption = "Status";
            this.colStatus.ColumnEdit = this.repStatus;
            this.colStatus.FieldName = "StatusLancamento";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 1;
            this.colStatus.Width = 68;
            // 
            // repStatus
            // 
            this.repStatus.AutoHeight = false;
            this.repStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStatus.Name = "repStatus";
            this.repStatus.PopupSizeable = true;
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
            this.colImageStatus.OptionsColumn.AllowEdit = false;
            this.colImageStatus.OptionsColumn.ReadOnly = true;
            this.colImageStatus.Visible = true;
            this.colImageStatus.VisibleIndex = 2;
            this.colImageStatus.Width = 20;
            // 
            // colTipoLancamento
            // 
            this.colTipoLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoLancamento.Caption = "Natureza";
            this.colTipoLancamento.ColumnEdit = this.repNatureza;
            this.colTipoLancamento.FieldName = "TipoLancamento";
            this.colTipoLancamento.Name = "colTipoLancamento";
            this.colTipoLancamento.Visible = true;
            this.colTipoLancamento.VisibleIndex = 3;
            this.colTipoLancamento.Width = 67;
            // 
            // repNatureza
            // 
            this.repNatureza.AutoHeight = false;
            this.repNatureza.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repNatureza.Name = "repNatureza";
            this.repNatureza.PopupSizeable = true;
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
            this.colNatImg.OptionsColumn.AllowEdit = false;
            this.colNatImg.Visible = true;
            this.colNatImg.VisibleIndex = 4;
            this.colNatImg.Width = 20;
            // 
            // colDataLancamento
            // 
            this.colDataLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataLancamento.Caption = "Data";
            this.colDataLancamento.DisplayFormat.FormatString = "d";
            this.colDataLancamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataLancamento.FieldName = "DataLancamento";
            this.colDataLancamento.Name = "colDataLancamento";
            this.colDataLancamento.Visible = true;
            this.colDataLancamento.VisibleIndex = 5;
            this.colDataLancamento.Width = 72;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVencimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataVencimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVencimento.Caption = "Vencimento";
            this.colDataVencimento.DisplayFormat.FormatString = "d";
            this.colDataVencimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 6;
            // 
            // colDataPagamento
            // 
            this.colDataPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataPagamento.Caption = "Data Baixa";
            this.colDataPagamento.DisplayFormat.FormatString = "d";
            this.colDataPagamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDataPagamento.FieldName = "DataPagamento";
            this.colDataPagamento.Name = "colDataPagamento";
            this.colDataPagamento.Width = 90;
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
            this.colValorLancamento.VisibleIndex = 8;
            this.colValorLancamento.Width = 88;
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
            this.colValorJuros.VisibleIndex = 9;
            this.colValorJuros.Width = 57;
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
            this.colTotalLancamento.OptionsColumn.AllowEdit = false;
            this.colTotalLancamento.Visible = true;
            this.colTotalLancamento.VisibleIndex = 10;
            this.colTotalLancamento.Width = 125;
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
            this.colObservacao.VisibleIndex = 7;
            this.colObservacao.Width = 162;
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
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblId);
            this.panelControl1.Controls.Add(this.lblDesId);
            this.panelControl1.Controls.Add(this.lblTotalLancamento);
            this.panelControl1.Controls.Add(this.lblDescValor);
            this.panelControl1.Controls.Add(this.lblDataVencimento);
            this.panelControl1.Controls.Add(this.lblDescVencimento);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtTaxaJuros);
            this.panelControl1.Controls.Add(this.spinIntervalDias);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.btnSalvarParcelas);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtTotalLancamento);
            this.panelControl1.Controls.Add(this.lblParcelas);
            this.panelControl1.Controls.Add(this.spinNumLancamentos);
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(805, 67);
            this.panelControl1.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(27, 4);
            this.lblId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(6, 13);
            this.lblId.TabIndex = 77;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // lblDesId
            // 
            this.lblDesId.Location = new System.Drawing.Point(8, 4);
            this.lblDesId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDesId.Name = "lblDesId";
            this.lblDesId.Size = new System.Drawing.Size(15, 13);
            this.lblDesId.TabIndex = 76;
            this.lblDesId.Text = "ID:";
            this.lblDesId.Visible = false;
            // 
            // lblTotalLancamento
            // 
            this.lblTotalLancamento.Location = new System.Drawing.Point(420, 4);
            this.lblTotalLancamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTotalLancamento.Name = "lblTotalLancamento";
            this.lblTotalLancamento.Size = new System.Drawing.Size(22, 13);
            this.lblTotalLancamento.TabIndex = 75;
            this.lblTotalLancamento.Text = "0,00";
            this.lblTotalLancamento.Visible = false;
            // 
            // lblDescValor
            // 
            this.lblDescValor.Location = new System.Drawing.Point(385, 4);
            this.lblDescValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDescValor.Name = "lblDescValor";
            this.lblDescValor.Size = new System.Drawing.Size(28, 13);
            this.lblDescValor.TabIndex = 74;
            this.lblDescValor.Text = "Valor:";
            this.lblDescValor.Visible = false;
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.Location = new System.Drawing.Point(188, 4);
            this.lblDataVencimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(77, 13);
            this.lblDataVencimento.TabIndex = 73;
            this.lblDataVencimento.Text = "%vencimento%";
            this.lblDataVencimento.Visible = false;
            // 
            // lblDescVencimento
            // 
            this.lblDescVencimento.Location = new System.Drawing.Point(124, 4);
            this.lblDescVencimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDescVencimento.Name = "lblDescVencimento";
            this.lblDescVencimento.Size = new System.Drawing.Size(59, 13);
            this.lblDescVencimento.TabIndex = 72;
            this.lblDescVencimento.Text = "Vencimento:";
            this.lblDescVencimento.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl4.Location = new System.Drawing.Point(329, 37);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 13);
            this.labelControl4.TabIndex = 71;
            this.labelControl4.Text = "Taxa de juros a.m.";
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.EditValue = "0,00";
            this.txtTaxaJuros.Location = new System.Drawing.Point(428, 33);
            this.txtTaxaJuros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtTaxaJuros.Properties.Appearance.Options.UseFont = true;
            this.txtTaxaJuros.Properties.Mask.EditMask = "n2";
            this.txtTaxaJuros.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxaJuros.Size = new System.Drawing.Size(79, 20);
            this.txtTaxaJuros.TabIndex = 70;
            // 
            // spinIntervalDias
            // 
            this.spinIntervalDias.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinIntervalDias.Location = new System.Drawing.Point(240, 34);
            this.spinIntervalDias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spinIntervalDias.Name = "spinIntervalDias";
            this.spinIntervalDias.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.spinIntervalDias.Properties.Appearance.Options.UseFont = true;
            this.spinIntervalDias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinIntervalDias.Properties.EditFormat.FormatString = "n0";
            this.spinIntervalDias.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinIntervalDias.Properties.IsFloatValue = false;
            this.spinIntervalDias.Properties.Mask.EditMask = "N00";
            this.spinIntervalDias.Size = new System.Drawing.Size(48, 20);
            this.spinIntervalDias.TabIndex = 64;
            this.spinIntervalDias.ToolTip = "Número de Lançamentos";
            this.spinIntervalDias.EditValueChanged += new System.EventHandler(this.spinIntervalDias_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl3.Location = new System.Drawing.Point(161, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 63;
            this.labelControl3.Text = "Intervalo Dias:";
            // 
            // btnSalvarParcelas
            // 
            this.btnSalvarParcelas.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnSalvarParcelas.Appearance.Options.UseFont = true;
            this.btnSalvarParcelas.Location = new System.Drawing.Point(715, 30);
            this.btnSalvarParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarParcelas.Name = "btnSalvarParcelas";
            this.btnSalvarParcelas.Size = new System.Drawing.Size(64, 23);
            this.btnSalvarParcelas.TabIndex = 60;
            this.btnSalvarParcelas.Text = "Gerar";
            this.btnSalvarParcelas.Click += new System.EventHandler(this.btnGerarParcelas_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl1.Location = new System.Drawing.Point(532, 35);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 59;
            this.labelControl1.Text = "Total:";
            // 
            // txtTotalLancamento
            // 
            this.txtTotalLancamento.EditValue = "0,00";
            this.txtTotalLancamento.Location = new System.Drawing.Point(567, 33);
            this.txtTotalLancamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalLancamento.Name = "txtTotalLancamento";
            this.txtTotalLancamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtTotalLancamento.Properties.Appearance.Options.UseFont = true;
            this.txtTotalLancamento.Properties.Mask.EditMask = "n2";
            this.txtTotalLancamento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalLancamento.Size = new System.Drawing.Size(129, 20);
            this.txtTotalLancamento.TabIndex = 58;
            this.txtTotalLancamento.Leave += new System.EventHandler(this.txtTotalLancamento_Leave);
            // 
            // lblParcelas
            // 
            this.lblParcelas.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblParcelas.Location = new System.Drawing.Point(8, 37);
            this.lblParcelas.Name = "lblParcelas";
            this.lblParcelas.Size = new System.Drawing.Size(59, 13);
            this.lblParcelas.TabIndex = 57;
            this.lblParcelas.Text = "Nº Parcelas:";
            // 
            // spinNumLancamentos
            // 
            this.spinNumLancamentos.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinNumLancamentos.Location = new System.Drawing.Point(74, 34);
            this.spinNumLancamentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spinNumLancamentos.Name = "spinNumLancamentos";
            this.spinNumLancamentos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.spinNumLancamentos.Properties.Appearance.Options.UseFont = true;
            this.spinNumLancamentos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNumLancamentos.Properties.EditFormat.FormatString = "n0";
            this.spinNumLancamentos.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNumLancamentos.Properties.IsFloatValue = false;
            this.spinNumLancamentos.Properties.Mask.EditMask = "N00";
            this.spinNumLancamentos.Size = new System.Drawing.Size(48, 20);
            this.spinNumLancamentos.TabIndex = 56;
            this.spinNumLancamentos.ToolTip = "Número de Lançamentos";
            this.spinNumLancamentos.EditValueChanged += new System.EventHandler(this.spinNumLancamentos_EditValueChanged);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(3, 11);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.separatorControl1.Size = new System.Drawing.Size(797, 26);
            this.separatorControl1.TabIndex = 78;
            this.separatorControl1.Visible = false;
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.IntroductionText = "Este assistente irá auxilia-lo no processo de criação dos lançamentos financeiros" +
    ".";
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.ProceedText = "Clique em \"Avançar\" para continuar";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(626, 405);
            this.welcomeWizardPage1.Text = "Bem vindo ao assistente de criação de lançamentos";
            // 
            // wizardControl1
            // 
            this.wizardControl1.CancelText = "Cancelar";
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.FinishText = "&Terminar";
            this.wizardControl1.HelpText = "&Ajuda";
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "&Avançar >";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.PreviousText = "< &Voltar";
            this.wizardControl1.Size = new System.Drawing.Size(843, 538);
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            // 
            // XFrmAssitenteLancamentoFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 538);
            this.Controls.Add(this.wizardControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XFrmAssitenteLancamentoFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assitente de Lançamentos";
            this.wizardPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNatureza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxaJuros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinIntervalDias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalLancamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumLancamentos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblParcelas;
        private DevExpress.XtraEditors.SpinEdit spinNumLancamentos;
        private DevExpress.XtraGrid.Columns.GridColumn colDataLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorJuros;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencialParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colImageStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colNatImg;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagamento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTotalLancamento;
        private DevExpress.XtraEditors.SimpleButton btnSalvarParcelas;
        private DevExpress.XtraEditors.SpinEdit spinIntervalDias;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTaxaJuros;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repNatureza;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.LabelControl lblId;
        private DevExpress.XtraEditors.LabelControl lblDesId;
        private DevExpress.XtraEditors.LabelControl lblTotalLancamento;
        private DevExpress.XtraEditors.LabelControl lblDescValor;
        private DevExpress.XtraEditors.LabelControl lblDataVencimento;
        private DevExpress.XtraEditors.LabelControl lblDescVencimento;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}