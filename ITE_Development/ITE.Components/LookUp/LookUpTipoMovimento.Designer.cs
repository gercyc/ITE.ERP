namespace ITE.Components
{
    partial class LookUpTipoMovimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpTipoMovimento));
            this.txtDescTpMov = new DevExpress.XtraEditors.TextEdit();
            this.txtCodTpMov = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnFindTpMov = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescTpMov.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodTpMov.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescTpMov
            // 
            this.txtDescTpMov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescTpMov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescTpMov.Location = new System.Drawing.Point(87, 31);
            this.txtDescTpMov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescTpMov.Name = "txtDescTpMov";
            this.txtDescTpMov.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDescTpMov.Properties.Appearance.Options.UseFont = true;
            this.txtDescTpMov.Properties.ReadOnly = true;
            this.txtDescTpMov.Size = new System.Drawing.Size(299, 24);
            this.txtDescTpMov.TabIndex = 6;
            // 
            // txtCodTpMov
            // 
            this.txtCodTpMov.Location = new System.Drawing.Point(6, 31);
            this.txtCodTpMov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodTpMov.Name = "txtCodTpMov";
            this.txtCodTpMov.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTpMov.Properties.Appearance.Options.UseFont = true;
            this.txtCodTpMov.Size = new System.Drawing.Size(63, 24);
            this.txtCodTpMov.TabIndex = 5;
            this.txtCodTpMov.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodTpMov_KeyDown);
            this.txtCodTpMov.Leave += new System.EventHandler(this.txtCodTpMov_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(6, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(131, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tipo de Movimento:";
            // 
            // btnFindTpMov
            // 
            this.btnFindTpMov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindTpMov.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindTpMov.Appearance.Options.UseFont = true;
            this.btnFindTpMov.Image = ((System.Drawing.Image)(resources.GetObject("btnFindTpMov.Image")));
            this.btnFindTpMov.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindTpMov.Location = new System.Drawing.Point(394, 32);
            this.btnFindTpMov.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindTpMov.Name = "btnFindTpMov";
            this.btnFindTpMov.Size = new System.Drawing.Size(38, 23);
            this.btnFindTpMov.TabIndex = 7;
            this.btnFindTpMov.ToolTip = "Procurar Centro Custo";
            this.btnFindTpMov.Click += new System.EventHandler(this.btnFindTpMov_Click);
            // 
            // LookUpTipoMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindTpMov);
            this.Controls.Add(this.txtDescTpMov);
            this.Controls.Add(this.txtCodTpMov);
            this.Controls.Add(this.labelControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LookUpTipoMovimento";
            this.Size = new System.Drawing.Size(437, 60);
            this.Load += new System.EventHandler(this.LookUpDescricaoTipoMovimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescTpMov.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodTpMov.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtDescTpMov;
        private DevExpress.XtraEditors.TextEdit txtCodTpMov;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFindTpMov;
    }
}
