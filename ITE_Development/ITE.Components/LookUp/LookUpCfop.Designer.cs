namespace ITE.Components
{
    partial class LookUpCfop
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
            this.txtCodCfop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCfop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodCfop
            // 
            this.txtCodCfop.Location = new System.Drawing.Point(5, 23);
            this.txtCodCfop.Name = "txtCodCfop";
            this.txtCodCfop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodCfop.Properties.Appearance.Options.UseFont = true;
            this.txtCodCfop.Size = new System.Drawing.Size(75, 20);
            this.txtCodCfop.TabIndex = 5;
            this.txtCodCfop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodCentro_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "CFOP:";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(86, 23);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Properties.ReadOnly = true;
            this.buttonEdit1.Properties.Click += new System.EventHandler(this.btnFindFilial_Click);
            this.buttonEdit1.Size = new System.Drawing.Size(290, 20);
            this.buttonEdit1.TabIndex = 8;
            // 
            // LookUpCfop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.txtCodCfop);
            this.Controls.Add(this.labelControl2);
            this.Name = "LookUpCfop";
            this.Size = new System.Drawing.Size(380, 48);
            this.Load += new System.EventHandler(this.LookUpMatrizCentroCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCfop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtCodCfop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
    }
}
