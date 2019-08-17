using ITE.Components.LookUp;

namespace ITE.RH.Forms.Folha
{
    partial class XFrmWizardFinancRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmWizardFinancRH));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPageRHFinanc = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.chkGerarFinanceiro = new DevExpress.XtraEditors.CheckEdit();
            this.wizardPageConfiguracoes = new DevExpress.XtraWizard.WizardPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.datePikDtBaixa = new System.Windows.Forms.DateTimePicker();
            this.lookUpFormaPagamento1 = new ITE.Components.LookUpFormaPagamento();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDataBaixa = new DevExpress.XtraEditors.LabelControl();
            this.lookUpContaBancaria1 = new ITE.Components.LookUpContaBancaria();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.chkBaixarLancamentos = new DevExpress.XtraEditors.CheckEdit();
            this.cbTipoGeracao = new DevExpress.XtraEditors.ComboBoxEdit();
            this.datePikVencimento = new System.Windows.Forms.DateTimePicker();
            this.datePikData = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCentroCusto1 = new ITE.Components.LookUpCentroCusto();
            this.lookUpCliFor1 = new LookUpCliFor();
            this.lookUpFilial1 = new ITE.Components.LookUpFilial();
            this.completionWizardPageRHFinanc = new DevExpress.XtraWizard.CompletionWizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPageRHFinanc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkGerarFinanceiro.Properties)).BeginInit();
            this.wizardPageConfiguracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkBaixarLancamentos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoGeracao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPageRHFinanc);
            this.wizardControl1.Controls.Add(this.wizardPageConfiguracoes);
            this.wizardControl1.Controls.Add(this.completionWizardPageRHFinanc);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPageRHFinanc,
            this.wizardPageConfiguracoes,
            this.completionWizardPageRHFinanc});
            this.wizardControl1.Size = new System.Drawing.Size(663, 491);
            // 
            // welcomeWizardPageRHFinanc
            // 
            this.welcomeWizardPageRHFinanc.Controls.Add(this.chkGerarFinanceiro);
            this.welcomeWizardPageRHFinanc.IntroductionText = resources.GetString("welcomeWizardPageRHFinanc.IntroductionText");
            this.welcomeWizardPageRHFinanc.Name = "welcomeWizardPageRHFinanc";
            this.welcomeWizardPageRHFinanc.ProceedText = "Para continuar clique em Next";
            this.welcomeWizardPageRHFinanc.Size = new System.Drawing.Size(446, 358);
            this.welcomeWizardPageRHFinanc.Text = "Encerramento de competência";
            this.welcomeWizardPageRHFinanc.PageCommit += new System.EventHandler(this.welcomeWizardPageRHFinanc_PageCommit);
            // 
            // chkGerarFinanceiro
            // 
            this.chkGerarFinanceiro.Location = new System.Drawing.Point(3, 99);
            this.chkGerarFinanceiro.Name = "chkGerarFinanceiro";
            this.chkGerarFinanceiro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkGerarFinanceiro.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.chkGerarFinanceiro.Properties.Appearance.Options.UseFont = true;
            this.chkGerarFinanceiro.Properties.Appearance.Options.UseForeColor = true;
            this.chkGerarFinanceiro.Properties.Caption = "Gerar financeiro?";
            this.chkGerarFinanceiro.Size = new System.Drawing.Size(134, 19);
            this.chkGerarFinanceiro.TabIndex = 0;
            // 
            // wizardPageConfiguracoes
            // 
            this.wizardPageConfiguracoes.Controls.Add(this.groupControl2);
            this.wizardPageConfiguracoes.Controls.Add(this.groupControl1);
            this.wizardPageConfiguracoes.DescriptionText = "Configure como os lançamentos serão gerados";
            this.wizardPageConfiguracoes.Name = "wizardPageConfiguracoes";
            this.wizardPageConfiguracoes.Size = new System.Drawing.Size(631, 346);
            this.wizardPageConfiguracoes.Text = "Configurações";
            this.wizardPageConfiguracoes.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPageConfiguracoes_PageValidating);
            this.wizardPageConfiguracoes.PageCommit += new System.EventHandler(this.wizardPageConfiguracoes_PageCommit);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.datePikDtBaixa);
            this.groupControl2.Controls.Add(this.lookUpFormaPagamento1);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.lbDataBaixa);
            this.groupControl2.Controls.Add(this.lookUpContaBancaria1);
            this.groupControl2.Location = new System.Drawing.Point(6, 186);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(622, 149);
            this.groupControl2.TabIndex = 16;
            this.groupControl2.Text = "Dados da baixa";
            this.groupControl2.Visible = false;
            // 
            // datePikDtBaixa
            // 
            this.datePikDtBaixa.Checked = false;
            this.datePikDtBaixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePikDtBaixa.Location = new System.Drawing.Point(484, 58);
            this.datePikDtBaixa.Name = "datePikDtBaixa";
            this.datePikDtBaixa.Size = new System.Drawing.Size(108, 21);
            this.datePikDtBaixa.TabIndex = 14;
            // 
            // lookUpFormaPagamento1
            // 
            this.lookUpFormaPagamento1.FormaPagto = null;
            this.lookUpFormaPagamento1.Location = new System.Drawing.Point(11, 85);
            this.lookUpFormaPagamento1.Name = "lookUpFormaPagamento1";
            this.lookUpFormaPagamento1.Size = new System.Drawing.Size(375, 49);
            this.lookUpFormaPagamento1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conta bancária";
            // 
            // lbDataBaixa
            // 
            this.lbDataBaixa.Location = new System.Drawing.Point(484, 39);
            this.lbDataBaixa.Name = "lbDataBaixa";
            this.lbDataBaixa.Size = new System.Drawing.Size(71, 13);
            this.lbDataBaixa.TabIndex = 13;
            this.lbDataBaixa.Text = "Data de baixa:";
            // 
            // lookUpContaBancaria1
            // 
            this.lookUpContaBancaria1.ContaBancaria = null;
            this.lookUpContaBancaria1.Location = new System.Drawing.Point(10, 47);
            this.lookUpContaBancaria1.Name = "lookUpContaBancaria1";
            this.lookUpContaBancaria1.Size = new System.Drawing.Size(376, 32);
            this.lookUpContaBancaria1.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.chkBaixarLancamentos);
            this.groupControl1.Controls.Add(this.cbTipoGeracao);
            this.groupControl1.Controls.Add(this.datePikVencimento);
            this.groupControl1.Controls.Add(this.datePikData);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lookUpCentroCusto1);
            this.groupControl1.Controls.Add(this.lookUpCliFor1);
            this.groupControl1.Controls.Add(this.lookUpFilial1);
            this.groupControl1.Location = new System.Drawing.Point(6, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(622, 179);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Dados principais";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(484, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Tipo de geração:";
            // 
            // chkBaixarLancamentos
            // 
            this.chkBaixarLancamentos.Location = new System.Drawing.Point(484, 155);
            this.chkBaixarLancamentos.Name = "chkBaixarLancamentos";
            this.chkBaixarLancamentos.Properties.Caption = "Baixar lançamentos";
            this.chkBaixarLancamentos.Size = new System.Drawing.Size(114, 19);
            this.chkBaixarLancamentos.TabIndex = 7;
            this.chkBaixarLancamentos.Visible = false;
            this.chkBaixarLancamentos.CheckedChanged += new System.EventHandler(this.chkBaixarLancamentos_CheckedChanged);
            // 
            // cbTipoGeracao
            // 
            this.cbTipoGeracao.EditValue = "Sintetico";
            this.cbTipoGeracao.Location = new System.Drawing.Point(484, 132);
            this.cbTipoGeracao.Name = "cbTipoGeracao";
            this.cbTipoGeracao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoGeracao.Properties.Items.AddRange(new object[] {
            "Sintetico",
            "Analitico"});
            this.cbTipoGeracao.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoGeracao.Size = new System.Drawing.Size(111, 20);
            this.cbTipoGeracao.TabIndex = 20;
            // 
            // datePikVencimento
            // 
            this.datePikVencimento.Checked = false;
            this.datePikVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePikVencimento.Location = new System.Drawing.Point(484, 86);
            this.datePikVencimento.Name = "datePikVencimento";
            this.datePikVencimento.Size = new System.Drawing.Size(108, 21);
            this.datePikVencimento.TabIndex = 19;
            // 
            // datePikData
            // 
            this.datePikData.Checked = false;
            this.datePikData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePikData.Location = new System.Drawing.Point(484, 44);
            this.datePikData.Name = "datePikData";
            this.datePikData.Size = new System.Drawing.Size(108, 21);
            this.datePikData.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(484, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Data vencimento:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(484, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Data:";
            // 
            // lookUpCentroCusto1
            // 
            this.lookUpCentroCusto1.CentroCusto = null;
            this.lookUpCentroCusto1.Enabled = false;
            this.lookUpCentroCusto1.LabelText = "Centro de custo:";
            this.lookUpCentroCusto1.Location = new System.Drawing.Point(5, 121);
            this.lookUpCentroCusto1.Name = "lookUpCentroCusto1";
            this.lookUpCentroCusto1.Size = new System.Drawing.Size(375, 49);
            this.lookUpCentroCusto1.TabIndex = 15;
            // 
            // lookUpCliFor1
            // 
            this.lookUpCliFor1.CliFor = null;
            this.lookUpCliFor1.Enabled = false;
            this.lookUpCliFor1.Filial = null;
            this.lookUpCliFor1.LabelText = "Cliente/Fornecedor:";
            this.lookUpCliFor1.Location = new System.Drawing.Point(5, 71);
            this.lookUpCliFor1.Matriz = null;
            this.lookUpCliFor1.Name = "lookUpCliFor1";
            this.lookUpCliFor1.Size = new System.Drawing.Size(375, 48);
            this.lookUpCliFor1.TabIndex = 14;
            // 
            // lookUpFilial1
            // 
            this.lookUpFilial1.Enabled = false;
            this.lookUpFilial1.Filial = null;
            this.lookUpFilial1.Location = new System.Drawing.Point(5, 25);
            this.lookUpFilial1.Matriz = null;
            this.lookUpFilial1.Name = "lookUpFilial1";
            this.lookUpFilial1.Size = new System.Drawing.Size(375, 50);
            this.lookUpFilial1.TabIndex = 13;
            // 
            // completionWizardPageRHFinanc
            // 
            this.completionWizardPageRHFinanc.FinishText = "A competência foi encerrada com sucesso.";
            this.completionWizardPageRHFinanc.Name = "completionWizardPageRHFinanc";
            this.completionWizardPageRHFinanc.ProceedText = "Para fechar o assistente clique em Finish";
            this.completionWizardPageRHFinanc.Size = new System.Drawing.Size(446, 358);
            this.completionWizardPageRHFinanc.Text = "Concluíndo o assistente";
            // 
            // XFrmWizardFinancRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 491);
            this.Controls.Add(this.wizardControl1);
            this.Name = "XFrmWizardFinancRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistente";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPageRHFinanc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkGerarFinanceiro.Properties)).EndInit();
            this.wizardPageConfiguracoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkBaixarLancamentos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoGeracao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPageRHFinanc;
        private DevExpress.XtraWizard.WizardPage wizardPageConfiguracoes;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPageRHFinanc;
        private System.Windows.Forms.Label label1;
        private Components.LookUpContaBancaria lookUpContaBancaria1;
        private DevExpress.XtraEditors.CheckEdit chkBaixarLancamentos;
        private Components.LookUpFormaPagamento lookUpFormaPagamento1;
        private System.Windows.Forms.DateTimePicker datePikDtBaixa;
        private DevExpress.XtraEditors.LabelControl lbDataBaixa;
        private DevExpress.XtraEditors.CheckEdit chkGerarFinanceiro;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoGeracao;
        private System.Windows.Forms.DateTimePicker datePikVencimento;
        private System.Windows.Forms.DateTimePicker datePikData;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Components.LookUpCentroCusto lookUpCentroCusto1;
        private LookUpCliFor lookUpCliFor1;
        private Components.LookUpFilial lookUpFilial1;
    }
}