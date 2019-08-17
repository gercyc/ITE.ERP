namespace ITE.Financeiro.Forms.Wizard
{
    partial class XFrmWizardBaixaLancamento
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
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chDtVencimento = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpContaBancaria1 = new ITE.Components.LookUpContaBancaria();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalLancamentos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbFormaPagto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtEditDataBaixa = new DevExpress.XtraEditors.DateEdit();
            this.chDataAtual = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlLancBaixa = new DevExpress.XtraGrid.GridControl();
            this.bsLancoFinanceiro = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewLanctosBaixa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colImageStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorJuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorRecebido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliForParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageNatureza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chDtVencimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalLancamentos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormaPagto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataBaixa.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataBaixa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDataAtual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLancBaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLancoFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLanctosBaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(779, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 499);
            this.barDockControlBottom.Size = new System.Drawing.Size(779, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 499);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(779, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 499);
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
            this.wizardControl1.NextText = "&Avançar>";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.PreviousText = "< &Voltar";
            this.wizardControl1.Size = new System.Drawing.Size(779, 499);
            this.wizardControl1.Text = "Informe os dados";
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.IntroductionText = "Este assistente irá guia-lo no processo de baixa de lançamentos financeiros.";
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.ProceedText = "Clique em \"Avançar\" para continuar com o processo";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(562, 366);
            this.welcomeWizardPage1.Text = "Bem vindo ao assistente para baixa de lançamentos";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.tableLayoutPanel1);
            this.wizardPage1.DescriptionText = "Data da baixa, forma de pagamento e a conta para débito";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(747, 354);
            this.wizardPage1.Text = "Informe os dados abaixo para continuar o processo da baixa de lançamentos:";
            this.wizardPage1.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage1_PageValidating);
            this.wizardPage1.PageCommit += new System.EventHandler(this.wizardPage1_PageCommit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControlLancBaixa, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.8983F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.10169F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 354);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chDtVencimento);
            this.panelControl1.Controls.Add(this.lookUpContaBancaria1);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtTotalLancamentos);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cbFormaPagto);
            this.panelControl1.Controls.Add(this.dtEditDataBaixa);
            this.panelControl1.Controls.Add(this.chDataAtual);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(741, 113);
            this.panelControl1.TabIndex = 6;
            // 
            // chDtVencimento
            // 
            this.chDtVencimento.Location = new System.Drawing.Point(132, 31);
            this.chDtVencimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chDtVencimento.MenuManager = this.tabFormDefaultManager1;
            this.chDtVencimento.Name = "chDtVencimento";
            this.chDtVencimento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chDtVencimento.Properties.Appearance.Options.UseFont = true;
            this.chDtVencimento.Properties.Caption = "Data Vencimento";
            this.chDtVencimento.Size = new System.Drawing.Size(118, 19);
            this.chDtVencimento.TabIndex = 118;
            this.chDtVencimento.CheckedChanged += new System.EventHandler(this.chDtVencimento_CheckedChanged);
            // 
            // lookUpContaBancaria1
            // 
            this.lookUpContaBancaria1.ContaBancaria = null;
            this.lookUpContaBancaria1.Location = new System.Drawing.Point(5, 70);
            this.lookUpContaBancaria1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpContaBancaria1.Name = "lookUpContaBancaria1";
            this.lookUpContaBancaria1.Size = new System.Drawing.Size(704, 36);
            this.lookUpContaBancaria1.TabIndex = 117;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(560, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 14);
            this.labelControl3.TabIndex = 116;
            this.labelControl3.Text = "Total";
            // 
            // txtTotalLancamentos
            // 
            this.txtTotalLancamentos.EditValue = "0,00";
            this.txtTotalLancamentos.Location = new System.Drawing.Point(560, 31);
            this.txtTotalLancamentos.MenuManager = this.tabFormDefaultManager1;
            this.txtTotalLancamentos.Name = "txtTotalLancamentos";
            this.txtTotalLancamentos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTotalLancamentos.Properties.Appearance.Options.UseFont = true;
            this.txtTotalLancamentos.Properties.Mask.EditMask = "n";
            this.txtTotalLancamentos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalLancamentos.Properties.ReadOnly = true;
            this.txtTotalLancamentos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalLancamentos.Size = new System.Drawing.Size(149, 20);
            this.txtTotalLancamentos.TabIndex = 115;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(260, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 14);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Forma Pagamento:";
            // 
            // cbFormaPagto
            // 
            this.cbFormaPagto.Location = new System.Drawing.Point(260, 31);
            this.cbFormaPagto.MenuManager = this.tabFormDefaultManager1;
            this.cbFormaPagto.Name = "cbFormaPagto";
            this.cbFormaPagto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbFormaPagto.Properties.Appearance.Options.UseFont = true;
            this.cbFormaPagto.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbFormaPagto.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbFormaPagto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFormaPagto.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbFormaPagto.Size = new System.Drawing.Size(280, 20);
            this.cbFormaPagto.TabIndex = 1;
            // 
            // dtEditDataBaixa
            // 
            this.dtEditDataBaixa.EditValue = new System.DateTime(2016, 12, 18, 13, 47, 33, 594);
            this.dtEditDataBaixa.Location = new System.Drawing.Point(6, 31);
            this.dtEditDataBaixa.MenuManager = this.tabFormDefaultManager1;
            this.dtEditDataBaixa.Name = "dtEditDataBaixa";
            this.dtEditDataBaixa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtEditDataBaixa.Properties.Appearance.Options.UseFont = true;
            this.dtEditDataBaixa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDataBaixa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDataBaixa.Size = new System.Drawing.Size(120, 20);
            this.dtEditDataBaixa.TabIndex = 0;
            // 
            // chDataAtual
            // 
            this.chDataAtual.EditValue = true;
            this.chDataAtual.Location = new System.Drawing.Point(132, 9);
            this.chDataAtual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chDataAtual.MenuManager = this.tabFormDefaultManager1;
            this.chDataAtual.Name = "chDataAtual";
            this.chDataAtual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chDataAtual.Properties.Appearance.Options.UseFont = true;
            this.chDataAtual.Properties.Caption = "Data atual";
            this.chDataAtual.Size = new System.Drawing.Size(90, 19);
            this.chDataAtual.TabIndex = 1;
            this.chDataAtual.CheckedChanged += new System.EventHandler(this.chDataAtual_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(6, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data da baixa:";
            // 
            // gridControlLancBaixa
            // 
            this.gridControlLancBaixa.DataSource = this.bsLancoFinanceiro;
            this.gridControlLancBaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLancBaixa.Location = new System.Drawing.Point(3, 122);
            this.gridControlLancBaixa.MainView = this.gridViewLanctosBaixa;
            this.gridControlLancBaixa.MenuManager = this.tabFormDefaultManager1;
            this.gridControlLancBaixa.Name = "gridControlLancBaixa";
            this.gridControlLancBaixa.Size = new System.Drawing.Size(741, 229);
            this.gridControlLancBaixa.TabIndex = 5;
            this.gridControlLancBaixa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLanctosBaixa});
            // 
            // bsLancoFinanceiro
            // 
            this.bsLancoFinanceiro.DataSource = typeof(ITE.Entidades.POCO.Financeiro.LancamentoFinanceiro);
            // 
            // gridViewLanctosBaixa
            // 
            this.gridViewLanctosBaixa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImageStatus,
            this.colStatus,
            this.colValorLancamento,
            this.colValorJuros,
            this.colValorRecebido,
            this.colCliForParcela,
            this.colImageNatureza,
            this.colIdLancamento,
            this.colDataVencimento});
            this.gridViewLanctosBaixa.GridControl = this.gridControlLancBaixa;
            this.gridViewLanctosBaixa.Name = "gridViewLanctosBaixa";
            this.gridViewLanctosBaixa.OptionsSelection.MultiSelect = true;
            this.gridViewLanctosBaixa.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewLanctosBaixa.OptionsView.ShowGroupPanel = false;
            this.gridViewLanctosBaixa.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCliForParcela, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewLanctosBaixa.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewLancsBaixa_SelectionChanged);
            this.gridViewLanctosBaixa.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewLancsBaixa_CellValueChanged);
            // 
            // colImageStatus
            // 
            this.colImageStatus.Caption = " ";
            this.colImageStatus.FieldName = "Image";
            this.colImageStatus.Name = "colImageStatus";
            this.colImageStatus.Visible = true;
            this.colImageStatus.VisibleIndex = 2;
            this.colImageStatus.Width = 20;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "StatusLancamento";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 65;
            // 
            // colValorLancamento
            // 
            this.colValorLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colValorLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorLancamento.Caption = "Valor";
            this.colValorLancamento.DisplayFormat.FormatString = "N2";
            this.colValorLancamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorLancamento.FieldName = "ValorLancamento";
            this.colValorLancamento.Name = "colValorLancamento";
            this.colValorLancamento.OptionsColumn.AllowEdit = false;
            this.colValorLancamento.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colValorLancamento.Visible = true;
            this.colValorLancamento.VisibleIndex = 7;
            this.colValorLancamento.Width = 71;
            // 
            // colValorJuros
            // 
            this.colValorJuros.AppearanceCell.Options.UseTextOptions = true;
            this.colValorJuros.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorJuros.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorJuros.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorJuros.Caption = "Juros";
            this.colValorJuros.DisplayFormat.FormatString = "N2";
            this.colValorJuros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorJuros.FieldName = "ValorJuros";
            this.colValorJuros.Name = "colValorJuros";
            this.colValorJuros.Visible = true;
            this.colValorJuros.VisibleIndex = 8;
            this.colValorJuros.Width = 48;
            // 
            // colValorRecebido
            // 
            this.colValorRecebido.AppearanceCell.Options.UseTextOptions = true;
            this.colValorRecebido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorRecebido.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorRecebido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorRecebido.Caption = "Total";
            this.colValorRecebido.DisplayFormat.FormatString = "N2";
            this.colValorRecebido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorRecebido.FieldName = "TotalLancamento";
            this.colValorRecebido.Name = "colValorRecebido";
            this.colValorRecebido.OptionsColumn.AllowEdit = false;
            this.colValorRecebido.UnboundExpression = "0";
            this.colValorRecebido.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colValorRecebido.Visible = true;
            this.colValorRecebido.VisibleIndex = 9;
            this.colValorRecebido.Width = 74;
            // 
            // colCliForParcela
            // 
            this.colCliForParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colCliForParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliForParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.colCliForParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliForParcela.Caption = "Cliente";
            this.colCliForParcela.FieldName = "CliFor.RazaoSocial";
            this.colCliForParcela.Name = "colCliForParcela";
            this.colCliForParcela.OptionsColumn.AllowEdit = false;
            this.colCliForParcela.Visible = true;
            this.colCliForParcela.VisibleIndex = 5;
            this.colCliForParcela.Width = 220;
            // 
            // colImageNatureza
            // 
            this.colImageNatureza.AppearanceCell.Options.UseTextOptions = true;
            this.colImageNatureza.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImageNatureza.AppearanceHeader.Options.UseTextOptions = true;
            this.colImageNatureza.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImageNatureza.Caption = " ";
            this.colImageNatureza.FieldName = "ImageNatureza";
            this.colImageNatureza.Name = "colImageNatureza";
            this.colImageNatureza.OptionsColumn.AllowEdit = false;
            this.colImageNatureza.OptionsColumn.ReadOnly = true;
            this.colImageNatureza.Visible = true;
            this.colImageNatureza.VisibleIndex = 4;
            this.colImageNatureza.Width = 20;
            // 
            // colIdLancamento
            // 
            this.colIdLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colIdLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdLancamento.Caption = "Ref.";
            this.colIdLancamento.FieldName = "IdLancamento";
            this.colIdLancamento.Name = "colIdLancamento";
            this.colIdLancamento.OptionsColumn.AllowEdit = false;
            this.colIdLancamento.Visible = true;
            this.colIdLancamento.VisibleIndex = 1;
            this.colIdLancamento.Width = 51;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.Caption = "Vencimento";
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.OptionsColumn.AllowEdit = false;
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 6;
            this.colDataVencimento.Width = 79;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.AllowBack = false;
            this.completionWizardPage1.AllowCancel = false;
            this.completionWizardPage1.FinishText = "Lançamento(s) baixado(s) com sucesso.";
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.ProceedText = "Para fechar, clique em \"Terminar\"";
            this.completionWizardPage1.Size = new System.Drawing.Size(562, 366);
            this.completionWizardPage1.Text = "Finalizando o assistente de baixa de lançamentos";
            this.completionWizardPage1.PageCommit += new System.EventHandler(this.completionWizardPage1_PageCommit);
            // 
            // XFrmWizardBaixaLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 499);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XFrmWizardBaixaLancamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistente para baixa de lançamentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XFrmWizardBaixaLancamento_FormClosing);
            this.Shown += new System.EventHandler(this.XFrmWizardBaixaLancamento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chDtVencimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalLancamentos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFormaPagto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataBaixa.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataBaixa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDataAtual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLancBaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLancoFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLanctosBaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.DateEdit dtEditDataBaixa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlLancBaixa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLanctosBaixa;
        private System.Windows.Forms.BindingSource bsLancoFinanceiro;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorJuros;
        private DevExpress.XtraGrid.Columns.GridColumn colValorRecebido;
        private DevExpress.XtraGrid.Columns.GridColumn colCliForParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colImageNatureza;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLancamento;
        private DevExpress.XtraEditors.CheckEdit chDataAtual;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbFormaPagto;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTotalLancamentos;
        private DevExpress.XtraGrid.Columns.GridColumn colImageStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private Components.LookUpContaBancaria lookUpContaBancaria1;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraEditors.CheckEdit chDtVencimento;
    }
}