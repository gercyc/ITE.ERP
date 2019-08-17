namespace ITE.Financeiro.Forms.Caixa
{
    partial class XFrmAddMovimentoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddMovimentoCaixa));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorMovimento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHistorico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barChAbertura = new DevExpress.XtraBars.BarCheckItem();
            this.barChFechamento = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.dtEditMovimento = new DevExpress.XtraEditors.DateEdit();
            this.lblSaldo = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorMovimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditMovimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditMovimento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(21, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Valor:";
            // 
            // txtValorMovimento
            // 
            this.txtValorMovimento.EditValue = "0,00";
            this.txtValorMovimento.EnterMoveNextControl = true;
            this.txtValorMovimento.Location = new System.Drawing.Point(21, 145);
            this.txtValorMovimento.Name = "txtValorMovimento";
            this.txtValorMovimento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMovimento.Properties.Appearance.Options.UseFont = true;
            this.txtValorMovimento.Properties.Mask.EditMask = "n";
            this.txtValorMovimento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorMovimento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValorMovimento.Size = new System.Drawing.Size(196, 26);
            this.txtValorMovimento.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(241, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Destinação:";
            // 
            // txtHistorico
            // 
            this.txtHistorico.EnterMoveNextControl = true;
            this.txtHistorico.Location = new System.Drawing.Point(241, 55);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Properties.Appearance.Options.UseFont = true;
            this.txtHistorico.Properties.NullText = "Motivo do retirada";
            this.txtHistorico.Properties.NullValuePrompt = "Motivo do retirada";
            this.txtHistorico.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtHistorico.Size = new System.Drawing.Size(405, 26);
            this.txtHistorico.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barChAbertura,
            this.barChFechamento});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusProduto bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barChAbertura),
            new DevExpress.XtraBars.LinkPersistInfo(this.barChFechamento)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusProduto bar";
            // 
            // barChAbertura
            // 
            this.barChAbertura.Caption = "Abertura de Caixa";
            this.barChAbertura.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barChAbertura.Glyph = global::ITE.Financeiro.Properties.Resources.caixa_Credito;
            this.barChAbertura.Id = 2;
            this.barChAbertura.Name = "barChAbertura";
            this.barChAbertura.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barChAbertura.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barChAbertura.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barChAbertura_CheckedChanged);
            // 
            // barChFechamento
            // 
            this.barChFechamento.Caption = "Fechamento Caixa";
            this.barChFechamento.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barChFechamento.Glyph = global::ITE.Financeiro.Properties.Resources.caixa_Debito;
            this.barChFechamento.Id = 3;
            this.barChFechamento.Name = "barChFechamento";
            this.barChFechamento.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barChFechamento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barChFechamento.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barChFechamento_CheckedChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(664, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 254);
            this.barDockControlBottom.Size = new System.Drawing.Size(664, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 254);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(664, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 254);
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(560, 209);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 28);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dtEditMovimento
            // 
            this.dtEditMovimento.EditValue = null;
            this.dtEditMovimento.Location = new System.Drawing.Point(23, 55);
            this.dtEditMovimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEditMovimento.MenuManager = this.barManager1;
            this.dtEditMovimento.Name = "dtEditMovimento";
            this.dtEditMovimento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtEditMovimento.Properties.Appearance.Options.UseFont = true;
            this.dtEditMovimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditMovimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditMovimento.Size = new System.Drawing.Size(194, 26);
            this.dtEditMovimento.TabIndex = 11;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(23, 218);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(123, 19);
            this.lblSaldo.TabIndex = 16;
            this.lblSaldo.Text = "Saldo Disponível:";
            // 
            // XFrmAddMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 281);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.dtEditMovimento);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtValorMovimento);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XFrmAddMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ação";
            ((System.ComponentModel.ISupportInitialize)(this.txtValorMovimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditMovimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditMovimento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtValorMovimento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHistorico;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.DateEdit dtEditMovimento;
        private DevExpress.XtraBars.BarCheckItem barChAbertura;
        private DevExpress.XtraBars.BarCheckItem barChFechamento;
        private DevExpress.XtraEditors.LabelControl lblSaldo;
    }
}