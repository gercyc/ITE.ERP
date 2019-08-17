namespace ITE.Financeiro.Forms.View
{
    partial class XFrmCompensarExtrato
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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCompensarExtrato));
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkDtExtrato = new DevExpress.XtraEditors.CheckEdit();
            this.btnCompensarExtrato = new DevExpress.XtraEditors.SimpleButton();
            this.dtCompensacao = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkDtExtrato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompensacao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompensacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.chkDtExtrato);
            this.groupControl1.Controls.Add(this.btnCompensarExtrato);
            this.groupControl1.Controls.Add(this.dtCompensacao);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(318, 154);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Compensação";
            // 
            // chkDtExtrato
            // 
            this.chkDtExtrato.Location = new System.Drawing.Point(159, 65);
            this.chkDtExtrato.Name = "chkDtExtrato";
            this.chkDtExtrato.Properties.Caption = "Usar data do extrato?";
            this.chkDtExtrato.Size = new System.Drawing.Size(127, 19);
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "Utilizar data do extrato";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Se marcada esta opção a data de compensação dos extratos marcados serão igual a d" +
    "ata de criação.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.chkDtExtrato.SuperTip = superToolTip1;
            this.chkDtExtrato.TabIndex = 3;
            this.chkDtExtrato.CheckedChanged += new System.EventHandler(this.chkDtExtrato_CheckedChanged);
            // 
            // btnCompensarExtrato
            // 
            this.btnCompensarExtrato.Image = ((System.Drawing.Image)(resources.GetObject("btnCompensarExtrato.Image")));
            this.btnCompensarExtrato.Location = new System.Drawing.Point(165, 101);
            this.btnCompensarExtrato.Name = "btnCompensarExtrato";
            this.btnCompensarExtrato.Size = new System.Drawing.Size(120, 28);
            this.btnCompensarExtrato.TabIndex = 2;
            this.btnCompensarExtrato.Text = "Compensar";
            this.btnCompensarExtrato.Click += new System.EventHandler(this.btnCompensarExtrato_Click);
            // 
            // dtCompensacao
            // 
            this.dtCompensacao.EditValue = null;
            this.dtCompensacao.Location = new System.Drawing.Point(15, 64);
            this.dtCompensacao.Name = "dtCompensacao";
            this.dtCompensacao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCompensacao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtCompensacao.Size = new System.Drawing.Size(129, 20);
            this.dtCompensacao.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data da compensação:";
            // 
            // XFrmCompensarExtrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 154);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XFrmCompensarExtrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compensação de Extratos";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkDtExtrato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompensacao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompensacao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCompensarExtrato;
        private DevExpress.XtraEditors.DateEdit dtCompensacao;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkDtExtrato;
    }
}