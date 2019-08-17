namespace ITE.Components.LookUp
{
    partial class LookUpNCM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEditNcm = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEditNcm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditNcm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNcm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditNcm
            // 
            this.buttonEditNcm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditNcm.Location = new System.Drawing.Point(111, 23);
            this.buttonEditNcm.Name = "buttonEditNcm";
            this.buttonEditNcm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.buttonEditNcm.Properties.Appearance.Options.UseFont = true;
            this.buttonEditNcm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEditNcm.Properties.NullText = "Selecione o NCM";
            this.buttonEditNcm.Properties.NullValuePrompt = "Selecione o NCM";
            this.buttonEditNcm.Properties.NullValuePromptShowForEmptyValue = true;
            this.buttonEditNcm.Properties.ReadOnly = true;
            this.buttonEditNcm.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEditoNcm_Properties_ButtonClick);
            this.buttonEditNcm.Size = new System.Drawing.Size(305, 22);
            this.buttonEditNcm.TabIndex = 25;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(111, 5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(85, 16);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Descrição NCM";
            // 
            // textEditNcm
            // 
            this.textEditNcm.EditValue = "";
            this.textEditNcm.Location = new System.Drawing.Point(3, 23);
            this.textEditNcm.Name = "textEditNcm";
            this.textEditNcm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.textEditNcm.Properties.Appearance.Options.UseFont = true;
            this.textEditNcm.Properties.Mask.EditMask = "\\d\\d\\d\\d\\.\\d\\d\\.\\d\\d";
            this.textEditNcm.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textEditNcm.Properties.NullText = "Código NCM";
            this.textEditNcm.Properties.NullValuePrompt = "Código NCM";
            this.textEditNcm.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditNcm.Properties.ShowNullValuePromptWhenFocused = true;
            this.textEditNcm.Size = new System.Drawing.Size(102, 22);
            this.textEditNcm.TabIndex = 27;
            this.textEditNcm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNcm_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 16);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "NCM";
            // 
            // LookUpNCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEditNcm);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.buttonEditNcm);
            this.Controls.Add(this.labelControl9);
            this.Name = "LookUpNCM";
            this.Size = new System.Drawing.Size(419, 47);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEditNcm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNcm.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit buttonEditNcm;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEditNcm;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
