namespace ITE.Components
{
    partial class LookUpContaContabil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpContaContabil));
            this.txtNomeConta = new DevExpress.XtraEditors.TextEdit();
            this.txtCodConta = new DevExpress.XtraEditors.TextEdit();
            this.btnFindConta = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodConta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeConta
            // 
            this.txtNomeConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeConta.Location = new System.Drawing.Point(133, 6);
            this.txtNomeConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeConta.Name = "txtNomeConta";
            this.txtNomeConta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeConta.Properties.Appearance.Options.UseFont = true;
            this.txtNomeConta.Properties.ReadOnly = true;
            this.txtNomeConta.Size = new System.Drawing.Size(362, 24);
            this.txtNomeConta.TabIndex = 6;
            // 
            // txtCodConta
            // 
            this.txtCodConta.Location = new System.Drawing.Point(6, 6);
            this.txtCodConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodConta.Name = "txtCodConta";
            this.txtCodConta.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodConta.Properties.Appearance.Options.UseFont = true;
            this.txtCodConta.Properties.Mask.EditMask = "9.9.9.99.99999";
            this.txtCodConta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtCodConta.Size = new System.Drawing.Size(120, 24);
            this.txtCodConta.TabIndex = 5;
            this.txtCodConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodConta_KeyDown);
            // 
            // btnFindConta
            // 
            this.btnFindConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindConta.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindConta.Appearance.Options.UseFont = true;
            this.btnFindConta.Image = ((System.Drawing.Image)(resources.GetObject("btnFindConta.Image")));
            this.btnFindConta.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindConta.Location = new System.Drawing.Point(503, 7);
            this.btnFindConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindConta.Name = "btnFindConta";
            this.btnFindConta.Size = new System.Drawing.Size(38, 23);
            this.btnFindConta.TabIndex = 7;
            this.btnFindConta.ToolTip = "Procurar conta contábil";
            this.btnFindConta.Click += new System.EventHandler(this.btnFindConta_Click);
            // 
            // LookUpContaContabil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindConta);
            this.Controls.Add(this.txtNomeConta);
            this.Controls.Add(this.txtCodConta);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LookUpContaContabil";
            this.Size = new System.Drawing.Size(546, 38);
            this.Load += new System.EventHandler(this.LookUpContaContabil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodConta.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNomeConta;
        private DevExpress.XtraEditors.TextEdit txtCodConta;
        private DevExpress.XtraEditors.SimpleButton btnFindConta;
    }
}
