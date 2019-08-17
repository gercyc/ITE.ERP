namespace ITE.Fiscal.TpMovimento
{
    partial class XFrmParametrizarMovimentoView
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
            this.xtraTabControlParams = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPagePrincipal = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpLocalEstoque1 = new ITE.Components.LookUpLocalEstoque();
            this.chkGeraDadosFiscais = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rdNumeracao = new DevExpress.XtraEditors.RadioGroup();
            this.chkMovimentaEstoque = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rdDirecao = new DevExpress.XtraEditors.RadioGroup();
            this.txtDescTpMov = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbCategoriaTpMov = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtCodTpMovimento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPageFinanceiro = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.chkGerarFaturamento = new DevExpress.XtraEditors.CheckEdit();
            this.lookUpFormaPagamento1 = new ITE.Components.LookUpFormaPagamento();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpCentroCusto1 = new ITE.Components.LookUpCentroCusto();
            this.chkInfoCentroCusto = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkEmiteNFe = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlParams)).BeginInit();
            this.xtraTabControlParams.SuspendLayout();
            this.xtraTabPagePrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkGeraDadosFiscais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdNumeracao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMovimentaEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdDirecao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescTpMov.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoriaTpMov.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodTpMovimento.Properties)).BeginInit();
            this.xtraTabPageFinanceiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkGerarFaturamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkInfoCentroCusto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEmiteNFe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlParams
            // 
            this.xtraTabControlParams.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 9F);
            this.xtraTabControlParams.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControlParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControlParams.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlParams.Name = "xtraTabControlParams";
            this.xtraTabControlParams.SelectedTabPage = this.xtraTabPagePrincipal;
            this.xtraTabControlParams.Size = new System.Drawing.Size(519, 306);
            this.xtraTabControlParams.TabIndex = 0;
            this.xtraTabControlParams.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPagePrincipal,
            this.xtraTabPageFinanceiro});
            // 
            // xtraTabPagePrincipal
            // 
            this.xtraTabPagePrincipal.Controls.Add(this.groupControl1);
            this.xtraTabPagePrincipal.Name = "xtraTabPagePrincipal";
            this.xtraTabPagePrincipal.Size = new System.Drawing.Size(513, 277);
            this.xtraTabPagePrincipal.Text = "Principal";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.chkEmiteNFe);
            this.groupControl1.Controls.Add(this.lookUpLocalEstoque1);
            this.groupControl1.Controls.Add(this.chkGeraDadosFiscais);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.chkMovimentaEstoque);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.txtDescTpMov);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.cbCategoriaTpMov);
            this.groupControl1.Controls.Add(this.txtCodTpMovimento);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(513, 277);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Propriedades básicas";
            // 
            // lookUpLocalEstoque1
            // 
            this.lookUpLocalEstoque1.LabelText = "Local de estoque";
            this.lookUpLocalEstoque1.LocalEstoque = null;
            this.lookUpLocalEstoque1.Location = new System.Drawing.Point(13, 211);
            this.lookUpLocalEstoque1.Name = "lookUpLocalEstoque1";
            this.lookUpLocalEstoque1.Size = new System.Drawing.Size(346, 50);
            this.lookUpLocalEstoque1.TabIndex = 13;
            // 
            // chkGeraDadosFiscais
            // 
            this.chkGeraDadosFiscais.Location = new System.Drawing.Point(171, 122);
            this.chkGeraDadosFiscais.Name = "chkGeraDadosFiscais";
            this.chkGeraDadosFiscais.Properties.Appearance.Options.UseFont = true;
            this.chkGeraDadosFiscais.Properties.Caption = "Gerar dados fiscais?";
            this.chkGeraDadosFiscais.Size = new System.Drawing.Size(127, 19);
            this.chkGeraDadosFiscais.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 192);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(98, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Local de estoque:";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.rdNumeracao);
            this.groupControl3.Location = new System.Drawing.Point(367, 177);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(125, 84);
            this.groupControl3.TabIndex = 9;
            this.groupControl3.Text = "Numeração";
            // 
            // rdNumeracao
            // 
            this.rdNumeracao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdNumeracao.Location = new System.Drawing.Point(2, 20);
            this.rdNumeracao.Name = "rdNumeracao";
            this.rdNumeracao.Properties.Appearance.Options.UseFont = true;
            this.rdNumeracao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Manual"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Automática")});
            this.rdNumeracao.Size = new System.Drawing.Size(121, 62);
            this.rdNumeracao.TabIndex = 3;
            // 
            // chkMovimentaEstoque
            // 
            this.chkMovimentaEstoque.Location = new System.Drawing.Point(13, 122);
            this.chkMovimentaEstoque.Name = "chkMovimentaEstoque";
            this.chkMovimentaEstoque.Properties.Appearance.Options.UseFont = true;
            this.chkMovimentaEstoque.Properties.Caption = "Movimenta estoque?";
            this.chkMovimentaEstoque.Size = new System.Drawing.Size(127, 19);
            this.chkMovimentaEstoque.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(188, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Categoria:";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.rdDirecao);
            this.groupControl2.Location = new System.Drawing.Point(367, 29);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(123, 87);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Direção";
            // 
            // rdDirecao
            // 
            this.rdDirecao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdDirecao.Location = new System.Drawing.Point(2, 20);
            this.rdDirecao.Name = "rdDirecao";
            this.rdDirecao.Properties.Appearance.Options.UseFont = true;
            this.rdDirecao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Entrada"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Saída")});
            this.rdDirecao.Size = new System.Drawing.Size(119, 65);
            this.rdDirecao.TabIndex = 3;
            // 
            // txtDescTpMov
            // 
            this.txtDescTpMov.Location = new System.Drawing.Point(13, 96);
            this.txtDescTpMov.Name = "txtDescTpMov";
            this.txtDescTpMov.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDescTpMov.Properties.Appearance.Options.UseFont = true;
            this.txtDescTpMov.Size = new System.Drawing.Size(333, 20);
            this.txtDescTpMov.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Descrição:";
            // 
            // cbCategoriaTpMov
            // 
            this.cbCategoriaTpMov.Location = new System.Drawing.Point(188, 47);
            this.cbCategoriaTpMov.Name = "cbCategoriaTpMov";
            this.cbCategoriaTpMov.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbCategoriaTpMov.Properties.Appearance.Options.UseFont = true;
            this.cbCategoriaTpMov.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCategoriaTpMov.Properties.Items.AddRange(new object[] {
            "Cotação",
            "Pedido de compra",
            "Pedido de venda",
            "Nota fiscal de mercadorias",
            "Nota fiscal de serviço",
            "Nota fiscal conjugada",
            "Nota fiscal de exportação",
            "Nota fiscal de importação",
            "Movimentação de estoque",
            "Outras saídas não fiscal",
            "Outras entradas não fiscal",
            "Transferência entre locais de estoque"});
            this.cbCategoriaTpMov.Size = new System.Drawing.Size(159, 20);
            this.cbCategoriaTpMov.TabIndex = 2;
            this.cbCategoriaTpMov.EditValueChanged += new System.EventHandler(this.cbCategoriaTpMov_EditValueChanged);
            // 
            // txtCodTpMovimento
            // 
            this.txtCodTpMovimento.Location = new System.Drawing.Point(13, 48);
            this.txtCodTpMovimento.Name = "txtCodTpMovimento";
            this.txtCodTpMovimento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtCodTpMovimento.Properties.Appearance.Options.UseFont = true;
            this.txtCodTpMovimento.Properties.Mask.EditMask = "9.9.99";
            this.txtCodTpMovimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtCodTpMovimento.Size = new System.Drawing.Size(100, 20);
            this.txtCodTpMovimento.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código:";
            // 
            // xtraTabPageFinanceiro
            // 
            this.xtraTabPageFinanceiro.Controls.Add(this.groupControl4);
            this.xtraTabPageFinanceiro.Name = "xtraTabPageFinanceiro";
            this.xtraTabPageFinanceiro.Size = new System.Drawing.Size(513, 277);
            this.xtraTabPageFinanceiro.Text = "Financeiro/Contábil";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.lookUpCentroCusto1);
            this.groupControl4.Controls.Add(this.chkInfoCentroCusto);
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.chkGerarFaturamento);
            this.groupControl4.Controls.Add(this.lookUpFormaPagamento1);
            this.groupControl4.Controls.Add(this.labelControl6);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(513, 277);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Configuração da financeiro/contábil";
            // 
            // chkGerarFaturamento
            // 
            this.chkGerarFaturamento.Location = new System.Drawing.Point(9, 24);
            this.chkGerarFaturamento.Name = "chkGerarFaturamento";
            this.chkGerarFaturamento.Properties.Appearance.Options.UseFont = true;
            this.chkGerarFaturamento.Properties.Caption = "Gerar faturamento?";
            this.chkGerarFaturamento.Size = new System.Drawing.Size(127, 19);
            this.chkGerarFaturamento.TabIndex = 11;
            // 
            // lookUpFormaPagamento1
            // 
            this.lookUpFormaPagamento1.FormaPagto = null;
            this.lookUpFormaPagamento1.Location = new System.Drawing.Point(4, 69);
            this.lookUpFormaPagamento1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpFormaPagamento1.Name = "lookUpFormaPagamento1";
            this.lookUpFormaPagamento1.Size = new System.Drawing.Size(498, 49);
            this.lookUpFormaPagamento1.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(9, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(167, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Forma de pagamento padrão:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(431, 8);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(335, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Controls.Add(this.btnSalvar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 304);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(519, 41);
            this.panelControl1.TabIndex = 3;
            // 
            // lookUpCentroCusto1
            // 
            this.lookUpCentroCusto1.CentroCusto = null;
            this.lookUpCentroCusto1.LabelText = "Centro de custo:";
            this.lookUpCentroCusto1.Location = new System.Drawing.Point(9, 167);
            this.lookUpCentroCusto1.Name = "lookUpCentroCusto1";
            this.lookUpCentroCusto1.Size = new System.Drawing.Size(497, 49);
            this.lookUpCentroCusto1.TabIndex = 16;
            // 
            // chkInfoCentroCusto
            // 
            this.chkInfoCentroCusto.Location = new System.Drawing.Point(9, 124);
            this.chkInfoCentroCusto.Name = "chkInfoCentroCusto";
            this.chkInfoCentroCusto.Properties.Appearance.Options.UseFont = true;
            this.chkInfoCentroCusto.Properties.Caption = "Informar centro de custo?";
            this.chkInfoCentroCusto.Size = new System.Drawing.Size(167, 19);
            this.chkInfoCentroCusto.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(9, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(135, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Centro de custo padrão:";
            // 
            // chkEmiteNFe
            // 
            this.chkEmiteNFe.Location = new System.Drawing.Point(171, 147);
            this.chkEmiteNFe.Name = "chkEmiteNFe";
            this.chkEmiteNFe.Properties.Appearance.Options.UseFont = true;
            this.chkEmiteNFe.Properties.Caption = "Emite NF-e?";
            this.chkEmiteNFe.Size = new System.Drawing.Size(99, 19);
            this.chkEmiteNFe.TabIndex = 14;
            // 
            // XFrmParametrizarMovimentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 345);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.xtraTabControlParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XFrmParametrizarMovimentoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrização de movimento: novo*";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlParams)).EndInit();
            this.xtraTabControlParams.ResumeLayout(false);
            this.xtraTabPagePrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkGeraDadosFiscais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdNumeracao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMovimentaEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdDirecao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescTpMov.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoriaTpMov.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodTpMovimento.Properties)).EndInit();
            this.xtraTabPageFinanceiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkGerarFaturamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkInfoCentroCusto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEmiteNFe.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlParams;
        private DevExpress.XtraTab.XtraTabPage xtraTabPagePrincipal;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.RadioGroup rdNumeracao;
        private DevExpress.XtraEditors.CheckEdit chkMovimentaEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.RadioGroup rdDirecao;
        private DevExpress.XtraEditors.TextEdit txtDescTpMov;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbCategoriaTpMov;
        private DevExpress.XtraEditors.TextEdit txtCodTpMovimento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageFinanceiro;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.CheckEdit chkGerarFaturamento;
        private Components.LookUpFormaPagamento lookUpFormaPagamento1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit chkGeraDadosFiscais;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Components.LookUpLocalEstoque lookUpLocalEstoque1;
        private Components.LookUpCentroCusto lookUpCentroCusto1;
        private DevExpress.XtraEditors.CheckEdit chkInfoCentroCusto;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chkEmiteNFe;
    }
}