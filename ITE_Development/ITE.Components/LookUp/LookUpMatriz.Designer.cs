﻿namespace ITE.Components
{
    partial class LookUpMatriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookUpMatriz));
            this.txtNomeFilial = new DevExpress.XtraEditors.TextEdit();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.txtCodFilial = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnFindFilial = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodFilial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeFilial
            // 
            this.txtNomeFilial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFilial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNomeFilial.Location = new System.Drawing.Point(87, 31);
            this.txtNomeFilial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeFilial.Name = "txtNomeFilial";
            this.txtNomeFilial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeFilial.Properties.Appearance.Options.UseFont = true;
            this.txtNomeFilial.Properties.ReadOnly = true;
            this.txtNomeFilial.Size = new System.Drawing.Size(299, 24);
            this.txtNomeFilial.TabIndex = 6;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // txtCodFilial
            // 
            this.txtCodFilial.Location = new System.Drawing.Point(6, 31);
            this.txtCodFilial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodFilial.Name = "txtCodFilial";
            this.txtCodFilial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodFilial.Properties.Appearance.Options.UseFont = true;
            this.txtCodFilial.Size = new System.Drawing.Size(63, 24);
            this.txtCodFilial.TabIndex = 5;
            this.txtCodFilial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodFilial_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(6, 5);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Matriz:";
            // 
            // btnFindFilial
            // 
            this.btnFindFilial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindFilial.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFindFilial.Appearance.Options.UseFont = true;
            this.btnFindFilial.Image = ((System.Drawing.Image)(resources.GetObject("btnFindFilial.Image")));
            this.btnFindFilial.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFindFilial.Location = new System.Drawing.Point(394, 31);
            this.btnFindFilial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFindFilial.Name = "btnFindFilial";
            this.btnFindFilial.Size = new System.Drawing.Size(38, 23);
            this.btnFindFilial.TabIndex = 7;
            this.btnFindFilial.ToolTip = "Procurar Matriz";
            this.btnFindFilial.Click += new System.EventHandler(this.btnFindFilial_Click);
            // 
            // LookUpMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindFilial);
            this.Controls.Add(this.txtNomeFilial);
            this.Controls.Add(this.txtCodFilial);
            this.Controls.Add(this.labelControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LookUpMatriz";
            this.Size = new System.Drawing.Size(437, 63);
            this.Load += new System.EventHandler(this.LookUpMatrizFilial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodFilial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtNomeFilial;
        private DevExpress.XtraEditors.TextEdit txtCodFilial;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFindFilial;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}
