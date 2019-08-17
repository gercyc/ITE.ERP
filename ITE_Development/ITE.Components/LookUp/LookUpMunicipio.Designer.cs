namespace ITE.Components
{
    partial class LookUpMunicipio
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
            this.cbCidade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbUf = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUf.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCidade
            // 
            this.cbCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCidade.Location = new System.Drawing.Point(1, 21);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbCidade.Properties.Appearance.Options.UseFont = true;
            this.cbCidade.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbCidade.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbCidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCidade.Size = new System.Drawing.Size(209, 20);
            this.cbCidade.TabIndex = 0;
            this.cbCidade.ToolTip = "Duplo clique para atualizar";
            this.cbCidade.SelectedIndexChanged += new System.EventHandler(this.cbCidade_SelectedIndexChanged);
            this.cbCidade.EditValueChanged += new System.EventHandler(this.cbCidade_EditValueChanged);
            this.cbCidade.Click += new System.EventHandler(this.cbCidade_Click);
            this.cbCidade.DoubleClick += new System.EventHandler(this.cbCidade_DoubleClick);
            // 
            // cbUf
            // 
            this.cbUf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUf.Location = new System.Drawing.Point(218, 21);
            this.cbUf.Name = "cbUf";
            this.cbUf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbUf.Properties.Appearance.Options.UseFont = true;
            this.cbUf.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbUf.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbUf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUf.Size = new System.Drawing.Size(55, 20);
            this.cbUf.TabIndex = 1;
            this.cbUf.EditValueChanged += new System.EventHandler(this.cbUf_EditValueChanged);
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl13.Location = new System.Drawing.Point(218, 2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(14, 14);
            this.labelControl13.TabIndex = 11;
            this.labelControl13.Text = "UF";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl12.Location = new System.Drawing.Point(1, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(36, 14);
            this.labelControl12.TabIndex = 10;
            this.labelControl12.Text = "Cidade";
            // 
            // LookUpMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.cbUf);
            this.Controls.Add(this.cbCidade);
            this.Name = "LookUpMunicipio";
            this.Size = new System.Drawing.Size(276, 44);
            ((System.ComponentModel.ISupportInitialize)(this.cbCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUf.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbCidade;
        private DevExpress.XtraEditors.ComboBoxEdit cbUf;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}
