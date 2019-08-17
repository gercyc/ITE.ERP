using ITE.Entidades.Enumeradores;
using System;
namespace ITE.Vendas.Forms.View
{
    partial class XFrmFormaPagamentoView
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
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescFormaPagamento = new DevExpress.XtraEditors.TextEdit();
            this.cbTipoFormaPagto = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumParcelas = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescFormaPagamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFormaPagto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumParcelas.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(519, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 232);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(519, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 232);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(519, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 232);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelControl2.Location = new System.Drawing.Point(18, 15);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Descrição";
            // 
            // txtDescFormaPagamento
            // 
            this.txtDescFormaPagamento.Location = new System.Drawing.Point(18, 41);
            this.txtDescFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescFormaPagamento.MenuManager = this.barManager1;
            this.txtDescFormaPagamento.Name = "txtDescFormaPagamento";
            this.txtDescFormaPagamento.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDescFormaPagamento.Properties.Appearance.Options.UseFont = true;
            this.txtDescFormaPagamento.Size = new System.Drawing.Size(482, 24);
            this.txtDescFormaPagamento.TabIndex = 0;
            // 
            // cbTipoFormaPagto
            // 
            this.cbTipoFormaPagto.Location = new System.Drawing.Point(18, 112);
            this.cbTipoFormaPagto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoFormaPagto.MenuManager = this.barManager1;
            this.cbTipoFormaPagto.Name = "cbTipoFormaPagto";
            this.cbTipoFormaPagto.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbTipoFormaPagto.Properties.Appearance.Options.UseFont = true;
            this.cbTipoFormaPagto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoFormaPagto.Properties.Items.AddRange(new object[] {
            ITE.Entidades.Enumeradores.TypeFormaPagamento.Dinheiro,
            ITE.Entidades.Enumeradores.TypeFormaPagamento.Cartao,
            ITE.Entidades.Enumeradores.TypeFormaPagamento.Boleto,
            ITE.Entidades.Enumeradores.TypeFormaPagamento.Cheque,
            ITE.Entidades.Enumeradores.TypeFormaPagamento.Parcelado});
            this.cbTipoFormaPagto.Size = new System.Drawing.Size(213, 24);
            this.cbTipoFormaPagto.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelControl3.Location = new System.Drawing.Point(18, 84);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 18);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Classificação";
            // 
            // txtNumParcelas
            // 
            this.txtNumParcelas.Location = new System.Drawing.Point(269, 112);
            this.txtNumParcelas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumParcelas.MenuManager = this.barManager1;
            this.txtNumParcelas.Name = "txtNumParcelas";
            this.txtNumParcelas.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNumParcelas.Properties.Appearance.Options.UseFont = true;
            this.txtNumParcelas.Size = new System.Drawing.Size(128, 24);
            this.txtNumParcelas.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelControl4.Location = new System.Drawing.Point(269, 88);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 18);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Nº Parcelas";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(410, 187);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 28);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(298, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // XFrmAddFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 232);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNumParcelas);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbTipoFormaPagto);
            this.Controls.Add(this.txtDescFormaPagamento);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "XFrmAddFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão Forma Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescFormaPagamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFormaPagto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumParcelas.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit txtNumParcelas;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoFormaPagto;
        private DevExpress.XtraEditors.TextEdit txtDescFormaPagamento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
    }
}