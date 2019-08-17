namespace ITE.Components
{
    partial class LookUpMatrizFilial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpMatrizFilial));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodMatriz = new DevExpress.XtraEditors.TextEdit();
            this.txtNomeMatriz = new DevExpress.XtraEditors.TextEdit();
            this.btnFindMatriz = new DevExpress.XtraEditors.SimpleButton();
            this.txtNomeFilial = new DevExpress.XtraEditors.TextEdit();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.txtCodFilial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnFindFilial = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodMatriz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeMatriz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodFilial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelControl1.Location = new System.Drawing.Point(3, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Matriz:";
            // 
            // txtCodMatriz
            // 
            this.txtCodMatriz.Location = new System.Drawing.Point(3, 28);
            this.txtCodMatriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodMatriz.Name = "txtCodMatriz";
            this.txtCodMatriz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodMatriz.Properties.Appearance.Options.UseFont = true;
            this.txtCodMatriz.Properties.Mask.EditMask = "\\p{Ll}+\\d+";
            this.txtCodMatriz.Size = new System.Drawing.Size(63, 24);
            this.txtCodMatriz.TabIndex = 0;
            this.txtCodMatriz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodMatriz_KeyDown);
            // 
            // txtNomeMatriz
            // 
            this.txtNomeMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeMatriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeMatriz.Location = new System.Drawing.Point(82, 28);
            this.txtNomeMatriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeMatriz.Name = "txtNomeMatriz";
            this.txtNomeMatriz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeMatriz.Properties.Appearance.Options.UseFont = true;
            this.txtNomeMatriz.Properties.ReadOnly = true;
            this.txtNomeMatriz.Size = new System.Drawing.Size(289, 24);
            this.txtNomeMatriz.TabIndex = 1;
            // 
            // btnFindMatriz
            // 
            this.btnFindMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindMatriz.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindMatriz.Appearance.Options.UseFont = true;
            this.btnFindMatriz.Image = ((System.Drawing.Image)(resources.GetObject("btnFindMatriz.Image")));
            this.btnFindMatriz.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindMatriz.Location = new System.Drawing.Point(385, 28);
            this.btnFindMatriz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindMatriz.Name = "btnFindMatriz";
            this.btnFindMatriz.Size = new System.Drawing.Size(38, 23);
            this.btnFindMatriz.TabIndex = 2;
            this.btnFindMatriz.ToolTip = "Procurar Matriz";
            this.btnFindMatriz.Click += new System.EventHandler(this.btnFindMatriz_Click);
            // 
            // txtNomeFilial
            // 
            this.txtNomeFilial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFilial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeFilial.Location = new System.Drawing.Point(82, 83);
            this.txtNomeFilial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeFilial.Name = "txtNomeFilial";
            this.txtNomeFilial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeFilial.Properties.Appearance.Options.UseFont = true;
            this.txtNomeFilial.Properties.ReadOnly = true;
            this.txtNomeFilial.Size = new System.Drawing.Size(289, 24);
            this.txtNomeFilial.TabIndex = 4;
            // 
            // txtCodFilial
            // 
            this.txtCodFilial.Location = new System.Drawing.Point(3, 83);
            this.txtCodFilial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodFilial.Name = "txtCodFilial";
            this.txtCodFilial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodFilial.Properties.Appearance.Options.UseFont = true;
            this.txtCodFilial.Properties.Mask.EditMask = "\\p{Ll}+\\d+";
            this.txtCodFilial.Size = new System.Drawing.Size(63, 24);
            this.txtCodFilial.TabIndex = 3;
            this.txtCodFilial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodFilial_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelControl2.Location = new System.Drawing.Point(3, 61);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Filial:";
            // 
            // btnFindFilial
            // 
            this.btnFindFilial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindFilial.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindFilial.Appearance.Options.UseFont = true;
            this.btnFindFilial.Image = ((System.Drawing.Image)(resources.GetObject("btnFindFilial.Image")));
            this.btnFindFilial.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindFilial.Location = new System.Drawing.Point(385, 83);
            this.btnFindFilial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindFilial.Name = "btnFindFilial";
            this.btnFindFilial.Size = new System.Drawing.Size(38, 23);
            this.btnFindFilial.TabIndex = 5;
            this.btnFindFilial.ToolTip = "Procurar Filial";
            this.btnFindFilial.Click += new System.EventHandler(this.btnFindFilial_Click);
            // 
            // LookUpMatrizFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindFilial);
            this.Controls.Add(this.txtNomeFilial);
            this.Controls.Add(this.txtCodFilial);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnFindMatriz);
            this.Controls.Add(this.txtNomeMatriz);
            this.Controls.Add(this.txtCodMatriz);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LookUpMatrizFilial";
            this.Size = new System.Drawing.Size(429, 117);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodMatriz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeMatriz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodFilial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodMatriz;
        private DevExpress.XtraEditors.TextEdit txtNomeMatriz;
        private DevExpress.XtraEditors.SimpleButton btnFindMatriz;
        private DevExpress.XtraEditors.TextEdit txtNomeFilial;
        private DevExpress.XtraEditors.TextEdit txtCodFilial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFindFilial;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}
