namespace ITE.CE.Forms.View
{
    partial class XFrmAddDespesa
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEditDiscriminacaoDespesa = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditValorDespesa = new DevExpress.XtraEditors.TextEdit();
            this.checkEditAliquota = new DevExpress.XtraEditors.CheckEdit();
            this.textEditAliquota = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroupTipoDespesa = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditDiscriminacaoDespesa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditValorDespesa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAliquota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAliquota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupTipoDespesa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(123, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Discriminação da Despesa";
            // 
            // buttonEditDiscriminacaoDespesa
            // 
            this.buttonEditDiscriminacaoDespesa.Location = new System.Drawing.Point(12, 31);
            this.buttonEditDiscriminacaoDespesa.Name = "buttonEditDiscriminacaoDespesa";
            this.buttonEditDiscriminacaoDespesa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditDiscriminacaoDespesa.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditDespesa_Properties_ButtonClick);
            this.buttonEditDiscriminacaoDespesa.Size = new System.Drawing.Size(405, 20);
            this.buttonEditDiscriminacaoDespesa.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Valor da Despesa";
            // 
            // textEditValorDespesa
            // 
            this.textEditValorDespesa.EditValue = "0,00";
            this.textEditValorDespesa.Location = new System.Drawing.Point(12, 85);
            this.textEditValorDespesa.Name = "textEditValorDespesa";
            this.textEditValorDespesa.Properties.Mask.EditMask = "n2";
            this.textEditValorDespesa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditValorDespesa.Size = new System.Drawing.Size(150, 20);
            this.textEditValorDespesa.TabIndex = 3;
            // 
            // checkEditAliquota
            // 
            this.checkEditAliquota.Location = new System.Drawing.Point(168, 85);
            this.checkEditAliquota.Name = "checkEditAliquota";
            this.checkEditAliquota.Properties.Caption = "Alíquota ?";
            this.checkEditAliquota.Size = new System.Drawing.Size(75, 19);
            this.checkEditAliquota.TabIndex = 4;
            this.checkEditAliquota.CheckedChanged += new System.EventHandler(this.checkEditAliquota_CheckedChanged);
            // 
            // textEditAliquota
            // 
            this.textEditAliquota.EditValue = "0,00";
            this.textEditAliquota.Location = new System.Drawing.Point(285, 85);
            this.textEditAliquota.Name = "textEditAliquota";
            this.textEditAliquota.Properties.Mask.EditMask = "n2";
            this.textEditAliquota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditAliquota.Size = new System.Drawing.Size(75, 20);
            this.textEditAliquota.TabIndex = 5;
            this.textEditAliquota.Visible = false;
            // 
            // simpleButtonSalvar
            // 
            this.simpleButtonSalvar.Location = new System.Drawing.Point(343, 209);
            this.simpleButtonSalvar.Name = "simpleButtonSalvar";
            this.simpleButtonSalvar.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonSalvar.TabIndex = 6;
            this.simpleButtonSalvar.Text = "Salvar";
            this.simpleButtonSalvar.Click += new System.EventHandler(this.simpleButtonSalvar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Tipo";
            // 
            // radioGroupTipoDespesa
            // 
            this.radioGroupTipoDespesa.Location = new System.Drawing.Point(12, 147);
            this.radioGroupTipoDespesa.Name = "radioGroupTipoDespesa";
            this.radioGroupTipoDespesa.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Aduaneira"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Não Aduaneira"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Outras")});
            this.radioGroupTipoDespesa.Size = new System.Drawing.Size(405, 33);
            this.radioGroupTipoDespesa.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(285, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Alíquota";
            this.labelControl4.Visible = false;
            // 
            // XFrmAddDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 255);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.radioGroupTipoDespesa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButtonSalvar);
            this.Controls.Add(this.textEditAliquota);
            this.Controls.Add(this.checkEditAliquota);
            this.Controls.Add(this.textEditValorDespesa);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.buttonEditDiscriminacaoDespesa);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "XFrmAddDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Despesa:";
            this.Shown += new System.EventHandler(this.XFrmAddDespesa_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditDiscriminacaoDespesa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditValorDespesa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditAliquota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAliquota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupTipoDespesa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit buttonEditDiscriminacaoDespesa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditValorDespesa;
        private DevExpress.XtraEditors.CheckEdit checkEditAliquota;
        private DevExpress.XtraEditors.TextEdit textEditAliquota;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSalvar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.RadioGroup radioGroupTipoDespesa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}