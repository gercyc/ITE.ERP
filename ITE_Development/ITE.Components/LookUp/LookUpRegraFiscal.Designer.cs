namespace ITE.Components
{
    partial class LookUpRegraFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpRegraFiscal));
            this.txtNomeCfop = new DevExpress.XtraEditors.TextEdit();
            this.txtCodCfop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnFindCfop = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCfop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCfop.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCfop
            // 
            this.txtNomeCfop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCfop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeCfop.Location = new System.Drawing.Point(87, 31);
            this.txtNomeCfop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeCfop.Name = "txtNomeCfop";
            this.txtNomeCfop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeCfop.Properties.Appearance.Options.UseFont = true;
            this.txtNomeCfop.Properties.ReadOnly = true;
            this.txtNomeCfop.Size = new System.Drawing.Size(299, 24);
            this.txtNomeCfop.TabIndex = 6;
            // 
            // txtCodCfop
            // 
            this.txtCodCfop.Location = new System.Drawing.Point(6, 31);
            this.txtCodCfop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodCfop.Name = "txtCodCfop";
            this.txtCodCfop.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodCfop.Properties.Appearance.Options.UseFont = true;
            this.txtCodCfop.Size = new System.Drawing.Size(63, 24);
            this.txtCodCfop.TabIndex = 5;
            this.txtCodCfop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodCentro_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(6, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Regra fiscal:";
            // 
            // btnFindCfop
            // 
            this.btnFindCfop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindCfop.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindCfop.Appearance.Options.UseFont = true;
            this.btnFindCfop.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCfop.Image")));
            this.btnFindCfop.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindCfop.Location = new System.Drawing.Point(394, 32);
            this.btnFindCfop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindCfop.Name = "btnFindCfop";
            this.btnFindCfop.Size = new System.Drawing.Size(38, 23);
            this.btnFindCfop.TabIndex = 7;
            this.btnFindCfop.ToolTip = "Procurar Cfop";
            this.btnFindCfop.Click += new System.EventHandler(this.btnFindFilial_Click);
            // 
            // LookUpRegraFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindCfop);
            this.Controls.Add(this.txtNomeCfop);
            this.Controls.Add(this.txtCodCfop);
            this.Controls.Add(this.labelControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LookUpRegraFiscal";
            this.Size = new System.Drawing.Size(437, 60);
            this.Load += new System.EventHandler(this.LookUpMatrizCentroCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCfop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodCfop.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNomeCfop;
        private DevExpress.XtraEditors.TextEdit txtCodCfop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFindCfop;
    }
}
