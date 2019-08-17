namespace ITE.DataControl.Forms
{
    partial class XFrmMapping
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
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPageOrigem = new DevExpress.XtraWizard.WizardPage();
            this.gridControlColsOrigem = new DevExpress.XtraGrid.GridControl();
            this.gridViewColsOrigem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNomeColuna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoInform = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repComboTipo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTamanho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecisao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPageTabDestino = new DevExpress.XtraWizard.WizardPage();
            this.gridControlTabDestino = new DevExpress.XtraGrid.GridControl();
            this.gridViewTabDestino = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTabela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSchema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wizardPageMapeamento = new DevExpress.XtraWizard.WizardPage();
            this.gridControlMapeamento = new DevExpress.XtraGrid.GridControl();
            this.gridViewMapeamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repComboDestino = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTpDadoDestino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrigem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repComboOrigem = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTpDadoOrigem = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPageOrigem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlColsOrigem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewColsOrigem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboTipo)).BeginInit();
            this.wizardPageTabDestino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTabDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTabDestino)).BeginInit();
            this.wizardPageMapeamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMapeamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMapeamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboOrigem)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPageOrigem);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPageTabDestino);
            this.wizardControl1.Controls.Add(this.wizardPageMapeamento);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPageOrigem,
            this.wizardPageTabDestino,
            this.wizardPageMapeamento,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(822, 498);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.IntroductionText = "Este assistente irá guia-lo durante o processo de criação de XML para mapeamento " +
    "das tabelas do banco de dados, para que seja possível importar arquivos de texto" +
    ".";
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.ProceedText = "Clique em Avançar para ir ao próximo passo";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(605, 365);
            this.welcomeWizardPage1.Text = "Bem vindo ao assistente de mapeamento";
            // 
            // wizardPageOrigem
            // 
            this.wizardPageOrigem.Controls.Add(this.gridControlColsOrigem);
            this.wizardPageOrigem.DescriptionText = "Informe quais colunas existem no seu arquivo de texto";
            this.wizardPageOrigem.Name = "wizardPageOrigem";
            this.wizardPageOrigem.Size = new System.Drawing.Size(790, 353);
            this.wizardPageOrigem.Text = "Informe as colunas da origem";
            this.wizardPageOrigem.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPageOrigem_PageValidating);
            this.wizardPageOrigem.PageCommit += new System.EventHandler(this.wizardPageOrigem_PageCommit);
            // 
            // gridControlColsOrigem
            // 
            this.gridControlColsOrigem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlColsOrigem.EmbeddedNavigator.TextStringFormat = "Coluna {0} de {1}";
            this.gridControlColsOrigem.Location = new System.Drawing.Point(0, 0);
            this.gridControlColsOrigem.MainView = this.gridViewColsOrigem;
            this.gridControlColsOrigem.Name = "gridControlColsOrigem";
            this.gridControlColsOrigem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repComboTipo});
            this.gridControlColsOrigem.Size = new System.Drawing.Size(790, 353);
            this.gridControlColsOrigem.TabIndex = 0;
            this.gridControlColsOrigem.UseEmbeddedNavigator = true;
            this.gridControlColsOrigem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewColsOrigem});
            this.gridControlColsOrigem.Load += new System.EventHandler(this.gridControlColsOrigem_Load);
            // 
            // gridViewColsOrigem
            // 
            this.gridViewColsOrigem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNomeColuna,
            this.colTipoInform,
            this.colTamanho,
            this.colPrecisao});
            this.gridViewColsOrigem.GridControl = this.gridControlColsOrigem;
            this.gridViewColsOrigem.Name = "gridViewColsOrigem";
            this.gridViewColsOrigem.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewColsOrigem.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewColsOrigem.OptionsView.ColumnAutoWidth = false;
            this.gridViewColsOrigem.OptionsView.ShowGroupPanel = false;
            // 
            // colNomeColuna
            // 
            this.colNomeColuna.Caption = "Coluna origem";
            this.colNomeColuna.FieldName = "NomeColOrigem";
            this.colNomeColuna.Name = "colNomeColuna";
            this.colNomeColuna.Visible = true;
            this.colNomeColuna.VisibleIndex = 0;
            this.colNomeColuna.Width = 188;
            // 
            // colTipoInform
            // 
            this.colTipoInform.Caption = "Tipo";
            this.colTipoInform.ColumnEdit = this.repComboTipo;
            this.colTipoInform.FieldName = "TipoColOrigem";
            this.colTipoInform.Name = "colTipoInform";
            this.colTipoInform.Visible = true;
            this.colTipoInform.VisibleIndex = 1;
            this.colTipoInform.Width = 171;
            // 
            // repComboTipo
            // 
            this.repComboTipo.AutoHeight = false;
            this.repComboTipo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repComboTipo.Items.AddRange(new object[] {
            "Texto",
            "Data",
            "Decimal"});
            this.repComboTipo.Name = "repComboTipo";
            // 
            // colTamanho
            // 
            this.colTamanho.Caption = "Tamanho";
            this.colTamanho.FieldName = "Tamanho";
            this.colTamanho.Name = "colTamanho";
            this.colTamanho.Visible = true;
            this.colTamanho.VisibleIndex = 2;
            this.colTamanho.Width = 111;
            // 
            // colPrecisao
            // 
            this.colPrecisao.Caption = "Precisão decimal";
            this.colPrecisao.FieldName = "Precisao";
            this.colPrecisao.Name = "colPrecisao";
            this.colPrecisao.Visible = true;
            this.colPrecisao.VisibleIndex = 3;
            this.colPrecisao.Width = 101;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(605, 365);
            // 
            // wizardPageTabDestino
            // 
            this.wizardPageTabDestino.Controls.Add(this.gridControlTabDestino);
            this.wizardPageTabDestino.DescriptionText = "Escolha neste passo qual será a tabela de destino das informações";
            this.wizardPageTabDestino.Name = "wizardPageTabDestino";
            this.wizardPageTabDestino.Size = new System.Drawing.Size(790, 353);
            this.wizardPageTabDestino.Text = "Selecione a tabela de destino";
            this.wizardPageTabDestino.PageCommit += new System.EventHandler(this.wizardPageTabDestino_PageCommit);
            // 
            // gridControlTabDestino
            // 
            this.gridControlTabDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTabDestino.Location = new System.Drawing.Point(0, 0);
            this.gridControlTabDestino.MainView = this.gridViewTabDestino;
            this.gridControlTabDestino.Name = "gridControlTabDestino";
            this.gridControlTabDestino.Size = new System.Drawing.Size(790, 353);
            this.gridControlTabDestino.TabIndex = 0;
            this.gridControlTabDestino.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTabDestino});
            // 
            // gridViewTabDestino
            // 
            this.gridViewTabDestino.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTabela,
            this.colSchema});
            this.gridViewTabDestino.GridControl = this.gridControlTabDestino;
            this.gridViewTabDestino.Name = "gridViewTabDestino";
            this.gridViewTabDestino.OptionsBehavior.Editable = false;
            this.gridViewTabDestino.OptionsView.ShowGroupPanel = false;
            // 
            // colTabela
            // 
            this.colTabela.Caption = "Tabela";
            this.colTabela.FieldName = "TABLE_NAME";
            this.colTabela.Name = "colTabela";
            this.colTabela.Visible = true;
            this.colTabela.VisibleIndex = 1;
            this.colTabela.Width = 653;
            // 
            // colSchema
            // 
            this.colSchema.Caption = "Schema";
            this.colSchema.FieldName = "TABLE_SCHEMA";
            this.colSchema.Name = "colSchema";
            this.colSchema.Visible = true;
            this.colSchema.VisibleIndex = 0;
            this.colSchema.Width = 120;
            // 
            // wizardPageMapeamento
            // 
            this.wizardPageMapeamento.Controls.Add(this.gridControlMapeamento);
            this.wizardPageMapeamento.DescriptionText = "Informe aqui a origem e o destino dos dados que serão importados";
            this.wizardPageMapeamento.Name = "wizardPageMapeamento";
            this.wizardPageMapeamento.Size = new System.Drawing.Size(790, 353);
            this.wizardPageMapeamento.Text = "Criando o mapeamento..";
            this.wizardPageMapeamento.PageCommit += new System.EventHandler(this.wizardPageMapeamento_PageCommit);
            // 
            // gridControlMapeamento
            // 
            this.gridControlMapeamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMapeamento.EmbeddedNavigator.TextStringFormat = "Mapeamento {0} de {1}";
            this.gridControlMapeamento.Location = new System.Drawing.Point(0, 0);
            this.gridControlMapeamento.MainView = this.gridViewMapeamento;
            this.gridControlMapeamento.Name = "gridControlMapeamento";
            this.gridControlMapeamento.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repComboDestino,
            this.repComboOrigem});
            this.gridControlMapeamento.Size = new System.Drawing.Size(790, 353);
            this.gridControlMapeamento.TabIndex = 0;
            this.gridControlMapeamento.UseEmbeddedNavigator = true;
            this.gridControlMapeamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMapeamento});
            // 
            // gridViewMapeamento
            // 
            this.gridViewMapeamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDestino,
            this.colTpDadoDestino,
            this.colOrigem,
            this.colTpDadoOrigem});
            this.gridViewMapeamento.GridControl = this.gridControlMapeamento;
            this.gridViewMapeamento.Name = "gridViewMapeamento";
            this.gridViewMapeamento.OptionsView.ShowGroupPanel = false;
            // 
            // colDestino
            // 
            this.colDestino.Caption = "Destino";
            this.colDestino.ColumnEdit = this.repComboDestino;
            this.colDestino.FieldName = "Destino";
            this.colDestino.Name = "colDestino";
            this.colDestino.Visible = true;
            this.colDestino.VisibleIndex = 0;
            // 
            // repComboDestino
            // 
            this.repComboDestino.AutoHeight = false;
            this.repComboDestino.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repComboDestino.Name = "repComboDestino";
            this.repComboDestino.SelectedValueChanged += new System.EventHandler(this.repComboDestino_SelectedValueChanged);
            // 
            // colTpDadoDestino
            // 
            this.colTpDadoDestino.Caption = "Tipo destino";
            this.colTpDadoDestino.FieldName = "TipoDestino";
            this.colTpDadoDestino.Name = "colTpDadoDestino";
            this.colTpDadoDestino.OptionsColumn.AllowEdit = false;
            this.colTpDadoDestino.Visible = true;
            this.colTpDadoDestino.VisibleIndex = 1;
            // 
            // colOrigem
            // 
            this.colOrigem.Caption = "Origem";
            this.colOrigem.ColumnEdit = this.repComboOrigem;
            this.colOrigem.FieldName = "Origem";
            this.colOrigem.Name = "colOrigem";
            this.colOrigem.Visible = true;
            this.colOrigem.VisibleIndex = 2;
            // 
            // repComboOrigem
            // 
            this.repComboOrigem.AutoHeight = false;
            this.repComboOrigem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repComboOrigem.Name = "repComboOrigem";
            this.repComboOrigem.SelectedValueChanged += new System.EventHandler(this.repComboOrigem_SelectedValueChanged);
            // 
            // colTpDadoOrigem
            // 
            this.colTpDadoOrigem.Caption = "Tipo origem";
            this.colTpDadoOrigem.FieldName = "TipoOrigem";
            this.colTpDadoOrigem.Name = "colTpDadoOrigem";
            this.colTpDadoOrigem.OptionsColumn.AllowEdit = false;
            this.colTpDadoOrigem.Visible = true;
            this.colTpDadoOrigem.VisibleIndex = 3;
            // 
            // XFrmMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 498);
            this.Controls.Add(this.wizardControl1);
            this.Name = "XFrmMapping";
            this.Text = "XFrmMapping";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPageOrigem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlColsOrigem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewColsOrigem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboTipo)).EndInit();
            this.wizardPageTabDestino.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTabDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTabDestino)).EndInit();
            this.wizardPageMapeamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMapeamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMapeamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repComboOrigem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPageOrigem;
        private DevExpress.XtraGrid.GridControl gridControlColsOrigem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewColsOrigem;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPageTabDestino;
        private DevExpress.XtraGrid.GridControl gridControlTabDestino;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTabDestino;
        private DevExpress.XtraWizard.WizardPage wizardPageMapeamento;
        private DevExpress.XtraGrid.GridControl gridControlMapeamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMapeamento;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeColuna;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoInform;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repComboTipo;
        private DevExpress.XtraGrid.Columns.GridColumn colTamanho;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecisao;
        private DevExpress.XtraGrid.Columns.GridColumn colTabela;
        private DevExpress.XtraGrid.Columns.GridColumn colSchema;
        private DevExpress.XtraGrid.Columns.GridColumn colDestino;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repComboDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colTpDadoDestino;
        private DevExpress.XtraGrid.Columns.GridColumn colOrigem;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repComboOrigem;
        private DevExpress.XtraGrid.Columns.GridColumn colTpDadoOrigem;
    }
}