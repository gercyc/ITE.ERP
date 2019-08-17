namespace ITE.Components.LookUp
{
    partial class LookUpProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpProduto));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodProduto = new DevExpress.XtraEditors.TextEdit();
            this.txtNomeProduto = new DevExpress.XtraEditors.TextEdit();
            this.btnFindProduto = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(3, 7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Produto:";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(3, 31);
            this.txtCodProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodProduto.Properties.Appearance.Options.UseFont = true;
            this.txtCodProduto.Size = new System.Drawing.Size(115, 24);
            this.txtCodProduto.TabIndex = 1;
            this.txtCodProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProduto_KeyDown);
            this.txtCodProduto.Leave += new System.EventHandler(this.txtCodProduto_Leave);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeProduto.Location = new System.Drawing.Point(132, 31);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeProduto.Properties.Appearance.Options.UseFont = true;
            this.txtNomeProduto.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNomeProduto.Properties.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(289, 24);
            this.txtNomeProduto.TabIndex = 2;
            // 
            // btnFindProduto
            // 
            this.btnFindProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindProduto.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFindProduto.Appearance.Options.UseFont = true;
            this.btnFindProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnFindProduto.Image")));
            this.btnFindProduto.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindProduto.Location = new System.Drawing.Point(429, 31);
            this.btnFindProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindProduto.Name = "btnFindProduto";
            this.btnFindProduto.Size = new System.Drawing.Size(38, 23);
            this.btnFindProduto.TabIndex = 3;
            this.btnFindProduto.ToolTip = "Procurar Produto";
            this.btnFindProduto.Click += new System.EventHandler(this.btnFindProduto_Click);
            // 
            // LookUpProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtCodProduto);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LookUpProduto";
            this.Size = new System.Drawing.Size(474, 61);
            this.Load += new System.EventHandler(this.LookUpProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodProduto;
        private DevExpress.XtraEditors.TextEdit txtNomeProduto;
        private DevExpress.XtraEditors.SimpleButton btnFindProduto;
    }
}
