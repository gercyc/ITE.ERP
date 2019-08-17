namespace ITE.Slate.Forms.ControleCarga.View
{
    partial class XFrmComplementoOrdemCarga
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
            this.deDataVenda = new DevExpress.XtraEditors.DateEdit();
            this.deDataColeta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.deDataEntrega = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.deDataVenda.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataColeta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataColeta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataEntrega.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataEntrega.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Data da Venda";
            // 
            // deDataVenda
            // 
            this.deDataVenda.EditValue = null;
            this.deDataVenda.Location = new System.Drawing.Point(21, 37);
            this.deDataVenda.Name = "deDataVenda";
            this.deDataVenda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDataVenda.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDataVenda.Properties.Mask.EditMask = "G";
            this.deDataVenda.Size = new System.Drawing.Size(112, 20);
            this.deDataVenda.TabIndex = 0;
            // 
            // deDataColeta
            // 
            this.deDataColeta.EditValue = null;
            this.deDataColeta.Location = new System.Drawing.Point(177, 37);
            this.deDataColeta.Name = "deDataColeta";
            this.deDataColeta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDataColeta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDataColeta.Size = new System.Drawing.Size(112, 20);
            this.deDataColeta.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(177, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Data da Coleta";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(214, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // deDataEntrega
            // 
            this.deDataEntrega.EditValue = null;
            this.deDataEntrega.Location = new System.Drawing.Point(21, 102);
            this.deDataEntrega.Name = "deDataEntrega";
            this.deDataEntrega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDataEntrega.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDataEntrega.Size = new System.Drawing.Size(112, 20);
            this.deDataEntrega.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Data da Entrega";
            // 
            // XFrmComplementoOrdemCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 198);
            this.Controls.Add(this.deDataEntrega);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.deDataColeta);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.deDataVenda);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XFrmComplementoOrdemCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados Complementares";
            this.Shown += new System.EventHandler(this.XFrmComplementoOrdemCarga_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmComplementoOrdemCarga_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.deDataVenda.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataColeta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataColeta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataEntrega.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDataEntrega.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deDataVenda;
        private DevExpress.XtraEditors.DateEdit deDataColeta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.DateEdit deDataEntrega;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}