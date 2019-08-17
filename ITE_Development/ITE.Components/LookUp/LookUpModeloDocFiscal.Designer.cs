namespace ITE.Components
{
    partial class LookUpModeloDocFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpModeloDocFiscal));
            this.txtDescModelo = new DevExpress.XtraEditors.TextEdit();
            this.txtCodModelo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnFindModelo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodModelo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescModelo
            // 
            this.txtDescModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDescModelo.Location = new System.Drawing.Point(87, 31);
            this.txtDescModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescModelo.Name = "txtDescModelo";
            this.txtDescModelo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDescModelo.Properties.Appearance.Options.UseFont = true;
            this.txtDescModelo.Properties.ReadOnly = true;
            this.txtDescModelo.Size = new System.Drawing.Size(299, 24);
            this.txtDescModelo.TabIndex = 6;
            // 
            // txtCodModelo
            // 
            this.txtCodModelo.Location = new System.Drawing.Point(6, 31);
            this.txtCodModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodModelo.Name = "txtCodModelo";
            this.txtCodModelo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodModelo.Properties.Appearance.Options.UseFont = true;
            this.txtCodModelo.Size = new System.Drawing.Size(63, 24);
            this.txtCodModelo.TabIndex = 5;
            this.txtCodModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodCentro_KeyDown);
            this.txtCodModelo.Leave += new System.EventHandler(this.txtCodModelo_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(6, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(186, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Modelo de documento fiscal:";
            // 
            // btnFindModelo
            // 
            this.btnFindModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindModelo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindModelo.Appearance.Options.UseFont = true;
            this.btnFindModelo.Image = ((System.Drawing.Image)(resources.GetObject("btnFindModelo.Image")));
            this.btnFindModelo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindModelo.Location = new System.Drawing.Point(394, 32);
            this.btnFindModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindModelo.Name = "btnFindModelo";
            this.btnFindModelo.Size = new System.Drawing.Size(38, 23);
            this.btnFindModelo.TabIndex = 7;
            this.btnFindModelo.ToolTip = "Procurar modelo de documento fiscal";
            this.btnFindModelo.Click += new System.EventHandler(this.btnFindModelo_Click);
            // 
            // LookUpModeloDocFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindModelo);
            this.Controls.Add(this.txtDescModelo);
            this.Controls.Add(this.txtCodModelo);
            this.Controls.Add(this.labelControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LookUpModeloDocFiscal";
            this.Size = new System.Drawing.Size(437, 60);
            this.Load += new System.EventHandler(this.LookUpModeloDocFiscal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodModelo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtDescModelo;
        private DevExpress.XtraEditors.TextEdit txtCodModelo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFindModelo;
    }
}
