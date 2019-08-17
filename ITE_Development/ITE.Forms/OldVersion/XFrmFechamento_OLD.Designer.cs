namespace ITE.Vendas.Forms.ControleVenda
{
    partial class XFrmFechamento_OLD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmFechamento_OLD));
            this.txtDesconto = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnVoltar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtbFinalizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lblInfoImprimir = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbDescontoOp = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblTotalVenda = new DevExpress.XtraEditors.LabelControl();
            this.lblValorDesconto = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblVlrTroco = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalComDesconto = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrRecebido = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl5 = new DevExpress.XtraEditors.SeparatorControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDescontoOp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrRecebido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesconto
            // 
            this.txtDesconto.EditValue = "0,00";
            this.txtDesconto.EnterMoveNextControl = true;
            this.txtDesconto.Location = new System.Drawing.Point(473, 83);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDesconto.Properties.Appearance.Options.UseFont = true;
            this.txtDesconto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDesconto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtDesconto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDesconto.Size = new System.Drawing.Size(260, 44);
            this.txtDesconto.TabIndex = 1;
            this.txtDesconto.EditValueChanged += new System.EventHandler(this.txtDesconto_EditValueChanged);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
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
            this.barBtbFinalizar,
            this.barBtnVoltar});
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtbFinalizar)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnVoltar
            // 
            this.barBtnVoltar.Caption = "Voltar";
            this.barBtnVoltar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnVoltar.Glyph")));
            this.barBtnVoltar.Id = 3;
            this.barBtnVoltar.Name = "barBtnVoltar";
            this.barBtnVoltar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnVoltar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnVoltar_ItemClick);
            // 
            // barBtbFinalizar
            // 
            this.barBtbFinalizar.Caption = "F10: Finalizar";
            this.barBtbFinalizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtbFinalizar.Glyph")));
            this.barBtbFinalizar.Id = 2;
            this.barBtbFinalizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F10);
            this.barBtbFinalizar.Name = "barBtbFinalizar";
            this.barBtbFinalizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtbFinalizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtbFinalizar_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusProduto bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusProduto bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(776, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 603);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(776, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 544);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(776, 59);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 544);
            // 
            // lblInfoImprimir
            // 
            this.lblInfoImprimir.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoImprimir.Location = new System.Drawing.Point(12, 553);
            this.lblInfoImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblInfoImprimir.Name = "lblInfoImprimir";
            this.lblInfoImprimir.Size = new System.Drawing.Size(154, 28);
            this.lblInfoImprimir.TabIndex = 31;
            this.lblInfoImprimir.Text = "Flag Impressão";
            this.lblInfoImprimir.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelControl3.Location = new System.Drawing.Point(21, 181);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(331, 38);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Valor Recebido:...........";
            // 
            // cbDescontoOp
            // 
            this.cbDescontoOp.EditValue = "Aplicar Desconto %";
            this.cbDescontoOp.Location = new System.Drawing.Point(21, 83);
            this.cbDescontoOp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDescontoOp.MenuManager = this.barManager1;
            this.cbDescontoOp.Name = "cbDescontoOp";
            this.cbDescontoOp.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cbDescontoOp.Properties.Appearance.Options.UseFont = true;
            this.cbDescontoOp.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbDescontoOp.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cbDescontoOp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbDescontoOp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbDescontoOp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDescontoOp.Properties.Items.AddRange(new object[] {
            "Aplicar Desconto %",
            "Aplicar Desconto R$"});
            this.cbDescontoOp.Size = new System.Drawing.Size(346, 44);
            this.cbDescontoOp.TabIndex = 0;
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTotalVenda.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalVenda.Location = new System.Drawing.Point(91, 61);
            this.lblTotalVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(63, 38);
            this.lblTotalVenda.TabIndex = 44;
            this.lblTotalVenda.Text = "0,00";
            // 
            // lblValorDesconto
            // 
            this.lblValorDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorDesconto.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblValorDesconto.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblValorDesconto.Location = new System.Drawing.Point(483, 341);
            this.lblValorDesconto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblValorDesconto.Name = "lblValorDesconto";
            this.lblValorDesconto.Size = new System.Drawing.Size(63, 38);
            this.lblValorDesconto.TabIndex = 46;
            this.lblValorDesconto.Text = "0,00";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(21, 341);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(328, 38);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "Desconto:....................";
            // 
            // lblVlrTroco
            // 
            this.lblVlrTroco.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblVlrTroco.Appearance.ForeColor = System.Drawing.Color.Orange;
            this.lblVlrTroco.Location = new System.Drawing.Point(79, 61);
            this.lblVlrTroco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblVlrTroco.Name = "lblVlrTroco";
            this.lblVlrTroco.Size = new System.Drawing.Size(63, 38);
            this.lblVlrTroco.TabIndex = 47;
            this.lblVlrTroco.Text = "0,00";
            // 
            // lblTotalComDesconto
            // 
            this.lblTotalComDesconto.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTotalComDesconto.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTotalComDesconto.Location = new System.Drawing.Point(483, 266);
            this.lblTotalComDesconto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalComDesconto.Name = "lblTotalComDesconto";
            this.lblTotalComDesconto.Size = new System.Drawing.Size(63, 38);
            this.lblTotalComDesconto.TabIndex = 53;
            this.lblTotalComDesconto.Text = "0,00";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Location = new System.Drawing.Point(24, 266);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(326, 38);
            this.labelControl6.TabIndex = 52;
            this.labelControl6.Text = "Subtotal:......................";
            // 
            // txtVlrRecebido
            // 
            this.txtVlrRecebido.EditValue = "0,00";
            this.txtVlrRecebido.EnterMoveNextControl = true;
            this.txtVlrRecebido.Location = new System.Drawing.Point(473, 175);
            this.txtVlrRecebido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVlrRecebido.Name = "txtVlrRecebido";
            this.txtVlrRecebido.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtVlrRecebido.Properties.Appearance.Options.UseFont = true;
            this.txtVlrRecebido.Properties.Appearance.Options.UseTextOptions = true;
            this.txtVlrRecebido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.txtVlrRecebido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtVlrRecebido.Size = new System.Drawing.Size(260, 44);
            this.txtVlrRecebido.TabIndex = 58;
            this.txtVlrRecebido.EditValueChanged += new System.EventHandler(this.txtVlrRecebido_EditValueChanged);
            this.txtVlrRecebido.Leave += new System.EventHandler(this.txtVlrRecebido_Leave);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(0, 145);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(776, 23);
            this.separatorControl1.TabIndex = 63;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(12, 226);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(776, 23);
            this.separatorControl2.TabIndex = 64;
            // 
            // separatorControl4
            // 
            this.separatorControl4.Location = new System.Drawing.Point(0, 311);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(776, 23);
            this.separatorControl4.TabIndex = 66;
            // 
            // separatorControl5
            // 
            this.separatorControl5.Location = new System.Drawing.Point(0, 386);
            this.separatorControl5.Name = "separatorControl5";
            this.separatorControl5.Size = new System.Drawing.Size(776, 23);
            this.separatorControl5.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalVenda);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.groupBox1.Location = new System.Drawing.Point(12, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 117);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVlrTroco);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.groupBox2.Location = new System.Drawing.Point(394, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 117);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Troco";
            // 
            // XFrmFechamento_OLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.separatorControl5);
            this.Controls.Add(this.separatorControl4);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.txtVlrRecebido);
            this.Controls.Add(this.lblTotalComDesconto);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lblValorDesconto);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cbDescontoOp);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblInfoImprimir);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "XFrmFechamento_OLD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento :";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XFrmFechamento_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmDesconto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDescontoOp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrRecebido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDesconto;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtbFinalizar;
        private DevExpress.XtraEditors.LabelControl lblInfoImprimir;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbDescontoOp;
        private DevExpress.XtraEditors.LabelControl lblTotalVenda;
        private DevExpress.XtraEditors.LabelControl lblVlrTroco;
        private DevExpress.XtraEditors.LabelControl lblValorDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblTotalComDesconto;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraBars.BarButtonItem barBtnVoltar;
        private DevExpress.XtraEditors.TextEdit txtVlrRecebido;
        private DevExpress.XtraEditors.SeparatorControl separatorControl5;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}