
namespace ITE.Vendas.Forms.View
{
    partial class XFrmCategoriaProdutoView
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
            this.lbNome = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeCategoria = new DevExpress.XtraEditors.TextEdit();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCategoria.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbNome.Location = new System.Drawing.Point(21, 22);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(90, 14);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome categoria:";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(21, 43);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeCategoria.Properties.Appearance.Options.UseFont = true;
            this.txtNomeCategoria.Size = new System.Drawing.Size(252, 20);
            this.txtNomeCategoria.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(293, 41);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // XFrmAddCategoriaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 84);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.lbNome);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "XFrmAddCategoriaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categoria de Produto:";
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCategoria.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbNome;
        private DevExpress.XtraEditors.TextEdit txtNomeCategoria;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
    }
}