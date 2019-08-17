namespace ITE.Financeiro.Forms.Wizard
{
    partial class XFrmWizardCancelamentoVenda
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
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.lblNumVenda = new DevExpress.XtraEditors.LabelControl();
            this.lblCliFor = new DevExpress.XtraEditors.LabelControl();
            this.lblVlrVenda = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrVenda = new DevExpress.XtraEditors.TextEdit();
            this.lblMsg = new DevExpress.XtraEditors.LabelControl();
            this.chEstorno = new DevExpress.XtraEditors.CheckEdit();
            this.chDataAtual = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMotivoCancelamento = new DevExpress.XtraEditors.TextEdit();
            this.dtEditDataCancelamento = new DevExpress.XtraEditors.DateEdit();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstorno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDataAtual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoCancelamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataCancelamento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataCancelamento.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.wizardControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "&Avançar >";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.PreviousText = "< &Voltar";
            this.wizardControl1.Size = new System.Drawing.Size(713, 522);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.IntroductionText = "Este assistente irá guia-lo para cancelar um venda";
            this.welcomeWizardPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.ProceedText = "Para continuar, clique em Avançar";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(496, 344);
            this.welcomeWizardPage1.Text = "Bem-vindo ao assistente de cancelamento de venda";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.lblNumVenda);
            this.wizardPage1.Controls.Add(this.lblCliFor);
            this.wizardPage1.Controls.Add(this.lblVlrVenda);
            this.wizardPage1.Controls.Add(this.txtVlrVenda);
            this.wizardPage1.Controls.Add(this.lblMsg);
            this.wizardPage1.Controls.Add(this.chEstorno);
            this.wizardPage1.Controls.Add(this.chDataAtual);
            this.wizardPage1.Controls.Add(this.labelControl2);
            this.wizardPage1.Controls.Add(this.labelControl1);
            this.wizardPage1.Controls.Add(this.txtMotivoCancelamento);
            this.wizardPage1.Controls.Add(this.dtEditDataCancelamento);
            this.wizardPage1.DescriptionText = "Atenção: Para baixa do valor pago da venda no caixa, autorize o estorno da venda";
            this.wizardPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(681, 348);
            this.wizardPage1.Text = "Informe a data e o motivo do cancelamento";
            this.wizardPage1.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage1_PageValidating);
            this.wizardPage1.PageCommit += new System.EventHandler(this.wizardPage1_PageCommit);
            this.wizardPage1.PageInit += new System.EventHandler(this.wizardPage1_PageInit);
            // 
            // lblNumVenda
            // 
            this.lblNumVenda.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblNumVenda.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNumVenda.Location = new System.Drawing.Point(595, 0);
            this.lblNumVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblNumVenda.Name = "lblNumVenda";
            this.lblNumVenda.Size = new System.Drawing.Size(86, 21);
            this.lblNumVenda.TabIndex = 10;
            this.lblNumVenda.Text = "Nº Venda:";
            // 
            // lblCliFor
            // 
            this.lblCliFor.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCliFor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCliFor.Location = new System.Drawing.Point(0, 0);
            this.lblCliFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCliFor.Name = "lblCliFor";
            this.lblCliFor.Size = new System.Drawing.Size(99, 21);
            this.lblCliFor.TabIndex = 9;
            this.lblCliFor.Text = "%Cliente%";
            // 
            // lblVlrVenda
            // 
            this.lblVlrVenda.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblVlrVenda.Location = new System.Drawing.Point(510, 246);
            this.lblVlrVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblVlrVenda.Name = "lblVlrVenda";
            this.lblVlrVenda.Size = new System.Drawing.Size(102, 18);
            this.lblVlrVenda.TabIndex = 8;
            this.lblVlrVenda.Text = "Valor Estornado";
            this.lblVlrVenda.Visible = false;
            // 
            // txtVlrVenda
            // 
            this.txtVlrVenda.EditValue = "0,00";
            this.txtVlrVenda.Location = new System.Drawing.Point(510, 270);
            this.txtVlrVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVlrVenda.Name = "txtVlrVenda";
            this.txtVlrVenda.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrVenda.Properties.Appearance.Options.UseFont = true;
            this.txtVlrVenda.Properties.Mask.EditMask = "n";
            this.txtVlrVenda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtVlrVenda.Properties.ReadOnly = true;
            this.txtVlrVenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVlrVenda.Size = new System.Drawing.Size(138, 24);
            this.txtVlrVenda.TabIndex = 7;
            this.txtVlrVenda.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblMsg.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMsg.Location = new System.Drawing.Point(0, 330);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(602, 18);
            this.lblMsg.TabIndex = 6;
            this.lblMsg.Text = "Aviso: O valor da venda não poderá ser estornado pois a mesma não está totalmente" +
    " paga";
            this.lblMsg.Visible = false;
            // 
            // chEstorno
            // 
            this.chEstorno.Location = new System.Drawing.Point(27, 271);
            this.chEstorno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chEstorno.Name = "chEstorno";
            this.chEstorno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chEstorno.Properties.Appearance.Options.UseFont = true;
            this.chEstorno.Properties.Caption = "Estornar valor da venda";
            this.chEstorno.Size = new System.Drawing.Size(208, 22);
            this.chEstorno.TabIndex = 5;
            this.chEstorno.CheckedChanged += new System.EventHandler(this.chEstorno_CheckedChanged);
            // 
            // chDataAtual
            // 
            this.chDataAtual.EditValue = true;
            this.chDataAtual.Location = new System.Drawing.Point(178, 91);
            this.chDataAtual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chDataAtual.Name = "chDataAtual";
            this.chDataAtual.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chDataAtual.Properties.Appearance.Options.UseFont = true;
            this.chDataAtual.Properties.Caption = "Data Atual";
            this.chDataAtual.Size = new System.Drawing.Size(92, 22);
            this.chDataAtual.TabIndex = 4;
            this.chDataAtual.CheckedChanged += new System.EventHandler(this.chDataAtual_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(27, 154);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(159, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Motivo do cancelamento";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(27, 65);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Data Cancelamento";
            // 
            // txtMotivoCancelamento
            // 
            this.txtMotivoCancelamento.Location = new System.Drawing.Point(27, 178);
            this.txtMotivoCancelamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMotivoCancelamento.Name = "txtMotivoCancelamento";
            this.txtMotivoCancelamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMotivoCancelamento.Properties.Appearance.Options.UseFont = true;
            this.txtMotivoCancelamento.Properties.NullText = "Informe o motivo do cancelamento";
            this.txtMotivoCancelamento.Properties.NullValuePrompt = "Informe o motivo do cancelamento";
            this.txtMotivoCancelamento.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtMotivoCancelamento.Size = new System.Drawing.Size(621, 24);
            this.txtMotivoCancelamento.TabIndex = 1;
            // 
            // dtEditDataCancelamento
            // 
            this.dtEditDataCancelamento.EditValue = new System.DateTime(2016, 12, 18, 13, 46, 58, 805);
            this.dtEditDataCancelamento.Location = new System.Drawing.Point(27, 89);
            this.dtEditDataCancelamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEditDataCancelamento.Name = "dtEditDataCancelamento";
            this.dtEditDataCancelamento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtEditDataCancelamento.Properties.Appearance.Options.UseFont = true;
            this.dtEditDataCancelamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDataCancelamento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditDataCancelamento.Size = new System.Drawing.Size(146, 24);
            this.dtEditDataCancelamento.TabIndex = 0;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.FinishText = "Venda cancelada com sucesso !";
            this.completionWizardPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.ProceedText = "Para fechar, clique em \"Terminar\"";
            this.completionWizardPage1.Size = new System.Drawing.Size(496, 344);
            this.completionWizardPage1.Text = "Finalizando o assistente de cancelamento de venda";
            // 
            // XFrmWizardCancelamentoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 522);
            this.Controls.Add(this.wizardControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmWizardCancelamentoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelamento de Venda";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstorno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chDataAtual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivoCancelamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataCancelamento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditDataCancelamento.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMotivoCancelamento;
        private DevExpress.XtraEditors.DateEdit dtEditDataCancelamento;
        private DevExpress.XtraEditors.CheckEdit chDataAtual;
        private DevExpress.XtraEditors.LabelControl lblMsg;
        private DevExpress.XtraEditors.CheckEdit chEstorno;
        private DevExpress.XtraEditors.TextEdit txtVlrVenda;
        private DevExpress.XtraEditors.LabelControl lblVlrVenda;
        private DevExpress.XtraEditors.LabelControl lblNumVenda;
        private DevExpress.XtraEditors.LabelControl lblCliFor;
    }
}