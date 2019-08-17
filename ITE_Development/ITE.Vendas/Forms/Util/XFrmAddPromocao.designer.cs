namespace ITE.Vendas.Forms.Util
{
    partial class XFrmAddPromocao
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPorcetagemPromocao = new DevExpress.XtraEditors.TextEdit();
            this.btnAplicaPromoção = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcetagemPromocao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 27);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(144, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Percentual da promoção:";
            // 
            // textEdit1
            // 
            this.txtPorcetagemPromocao.Location = new System.Drawing.Point(164, 23);
            this.txtPorcetagemPromocao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPorcetagemPromocao.Name = "textEdit1";
            this.txtPorcetagemPromocao.Properties.Mask.EditMask = "P";
            this.txtPorcetagemPromocao.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcetagemPromocao.Size = new System.Drawing.Size(117, 22);
            this.txtPorcetagemPromocao.TabIndex = 1;
            // 
            // btnAplicaPromoção
            // 
            this.btnAplicaPromoção.Location = new System.Drawing.Point(305, 21);
            this.btnAplicaPromoção.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAplicaPromoção.Name = "btnAplicaPromoção";
            this.btnAplicaPromoção.Size = new System.Drawing.Size(99, 28);
            this.btnAplicaPromoção.TabIndex = 2;
            this.btnAplicaPromoção.Text = "Aplicar";
            this.btnAplicaPromoção.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XFrmAddPromocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 74);
            this.Controls.Add(this.btnAplicaPromoção);
            this.Controls.Add(this.txtPorcetagemPromocao);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "XFrmAddPromocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicar Promoção";
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcetagemPromocao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPorcetagemPromocao;
        private DevExpress.XtraEditors.SimpleButton btnAplicaPromoção;
    }
}