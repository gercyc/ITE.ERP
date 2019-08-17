namespace ITE.Components
{
    partial class LookUpLocalEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpLocalEstoque));
            this.txtNomeLocalEstoque = new DevExpress.XtraEditors.TextEdit();
            this.txtCodLocalEstoque = new DevExpress.XtraEditors.TextEdit();
            this.btnFindLocalEstoque = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeLocalEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodLocalEstoque.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeLocalEstoque
            // 
            this.txtNomeLocalEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeLocalEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeLocalEstoque.Location = new System.Drawing.Point(75, 20);
            this.txtNomeLocalEstoque.Name = "txtNomeLocalEstoque";
            this.txtNomeLocalEstoque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeLocalEstoque.Properties.Appearance.Options.UseFont = true;
            this.txtNomeLocalEstoque.Properties.ReadOnly = true;
            this.txtNomeLocalEstoque.Size = new System.Drawing.Size(256, 20);
            this.txtNomeLocalEstoque.TabIndex = 6;
            // 
            // txtCodLocalEstoque
            // 
            this.txtCodLocalEstoque.Location = new System.Drawing.Point(5, 20);
            this.txtCodLocalEstoque.Name = "txtCodLocalEstoque";
            this.txtCodLocalEstoque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodLocalEstoque.Properties.Appearance.Options.UseFont = true;
            this.txtCodLocalEstoque.Size = new System.Drawing.Size(54, 20);
            this.txtCodLocalEstoque.TabIndex = 5;
            this.txtCodLocalEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodCentro_KeyDown);
            // 
            // btnFindLocalEstoque
            // 
            this.btnFindLocalEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindLocalEstoque.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindLocalEstoque.Appearance.Options.UseFont = true;
            this.btnFindLocalEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnFindLocalEstoque.Image")));
            this.btnFindLocalEstoque.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindLocalEstoque.Location = new System.Drawing.Point(338, 21);
            this.btnFindLocalEstoque.Name = "btnFindLocalEstoque";
            this.btnFindLocalEstoque.Size = new System.Drawing.Size(33, 19);
            this.btnFindLocalEstoque.TabIndex = 7;
            this.btnFindLocalEstoque.ToolTip = "Procurar local de estoque";
            this.btnFindLocalEstoque.Click += new System.EventHandler(this.btnFindFilial_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Local de estoque";
            // 
            // LookUpLocalEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnFindLocalEstoque);
            this.Controls.Add(this.txtNomeLocalEstoque);
            this.Controls.Add(this.txtCodLocalEstoque);
            this.Name = "LookUpLocalEstoque";
            this.Size = new System.Drawing.Size(375, 47);
            this.Load += new System.EventHandler(this.LookUpMatrizCentroCusto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeLocalEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodLocalEstoque.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNomeLocalEstoque;
        private DevExpress.XtraEditors.TextEdit txtCodLocalEstoque;
        private DevExpress.XtraEditors.SimpleButton btnFindLocalEstoque;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
