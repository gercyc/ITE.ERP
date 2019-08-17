namespace ITE.Contabil.Forms.View
{
    partial class XFrmAddCentroCusto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param colName="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.txtNomeCentroCusto = new DevExpress.XtraEditors.TextEdit();
            this.lbNome = new DevExpress.XtraEditors.LabelControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkpMatriz = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCodigoCentro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkCentroPai = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDestinacao = new DevExpress.XtraEditors.RadioGroup();
            this.lblFlag = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCentroCusto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMatriz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCentro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCentroPai.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdDestinacao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnVoltar.Appearance.Options.UseFont = true;
            this.btnVoltar.Location = new System.Drawing.Point(973, 204);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(77, 24);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSalvar.Appearance.Options.UseFont = true;
            this.btnSalvar.Location = new System.Drawing.Point(379, 197);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 24);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeCentroCusto
            // 
            this.txtNomeCentroCusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCentroCusto.Location = new System.Drawing.Point(10, 89);
            this.txtNomeCentroCusto.Name = "txtNomeCentroCusto";
            this.txtNomeCentroCusto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNomeCentroCusto.Properties.Appearance.Options.UseFont = true;
            this.txtNomeCentroCusto.Size = new System.Drawing.Size(446, 20);
            this.txtNomeCentroCusto.TabIndex = 3;
            this.txtNomeCentroCusto.ToolTip = "Refêrencia as contas cadastradas futuramente";
            // 
            // lbNome
            // 
            this.lbNome.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbNome.Location = new System.Drawing.Point(10, 68);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(125, 14);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome Centro de custo";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(12, 129);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 14);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Centro Custo Primário";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(12, 11);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 14);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Matriz:";
            // 
            // lkpMatriz
            // 
            this.lkpMatriz.Location = new System.Drawing.Point(10, 31);
            this.lkpMatriz.Name = "lkpMatriz";
            this.lkpMatriz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lkpMatriz.Properties.Appearance.Options.UseFont = true;
            this.lkpMatriz.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpMatriz.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoMatriz", 50, "Código"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomeFantasia", 180, "Nome Fantasia")});
            this.lkpMatriz.Properties.NullText = "Selecione a Matriz";
            this.lkpMatriz.Size = new System.Drawing.Size(446, 20);
            this.lkpMatriz.TabIndex = 0;
            // 
            // txtCodigoCentro
            // 
            this.txtCodigoCentro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoCentro.Location = new System.Drawing.Point(321, 148);
            this.txtCodigoCentro.Name = "txtCodigoCentro";
            this.txtCodigoCentro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodigoCentro.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoCentro.Size = new System.Drawing.Size(135, 20);
            this.txtCodigoCentro.TabIndex = 2;
            this.txtCodigoCentro.ToolTip = "Refêrencia as contas cadastradas futuramente";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(323, 128);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 14);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Código/Nível";
            // 
            // lkCentroPai
            // 
            this.lkCentroPai.Location = new System.Drawing.Point(10, 148);
            this.lkCentroPai.Name = "lkCentroPai";
            this.lkCentroPai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCentroPai.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoCentroCusto", 80, "Código Centro"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NomeCentroCusto", 150, "Nome Centro")});
            this.lkCentroPai.Properties.NullText = " ";
            this.lkCentroPai.Size = new System.Drawing.Size(286, 20);
            this.lkCentroPai.TabIndex = 1;
            this.lkCentroPai.EditValueChanged += new System.EventHandler(this.lkCentroPai_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDestinacao);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(353, 47);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinação";
            this.groupBox1.Visible = false;
            // 
            // rdDestinacao
            // 
            this.rdDestinacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdDestinacao.Location = new System.Drawing.Point(3, 16);
            this.rdDestinacao.Name = "rdDestinacao";
            this.rdDestinacao.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDestinacao.Properties.Appearance.Options.UseFont = true;
            this.rdDestinacao.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rdDestinacao.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Entrada"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Saída"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Pai")});
            this.rdDestinacao.Size = new System.Drawing.Size(347, 29);
            this.rdDestinacao.TabIndex = 4;
            this.rdDestinacao.SelectedIndexChanged += new System.EventHandler(this.rdDestinacao_SelectedIndexChanged);
            // 
            // lblFlag
            // 
            this.lblFlag.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblFlag.Location = new System.Drawing.Point(379, 226);
            this.lblFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(0, 14);
            this.lblFlag.TabIndex = 15;
            this.lblFlag.Visible = false;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.EditValue = true;
            this.toggleSwitch1.Location = new System.Drawing.Point(194, 122);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 24);
            this.toggleSwitch1.TabIndex = 0;
            this.toggleSwitch1.EditValueChanged += new System.EventHandler(this.toggleSwitch1_EditValueChanged);
            // 
            // XFrmAddCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 241);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lkCentroPai);
            this.Controls.Add(this.txtCodigoCentro);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lkpMatriz);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNomeCentroCusto);
            this.Controls.Add(this.lbNome);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "XFrmAddCentroCusto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão Centro Custo";
            this.Shown += new System.EventHandler(this.XFrmAddCentroCusto_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmAddCentroCusto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeCentroCusto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMatriz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoCentro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkCentroPai.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdDestinacao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private DevExpress.XtraEditors.ComboBoxEdit cbCategoria;
        private DevExpress.XtraEditors.TextEdit txtNomeCentroCusto;
        private DevExpress.XtraEditors.LabelControl lbNome;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lkpMatriz;
        private DevExpress.XtraEditors.TextEdit txtCodigoCentro;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lkCentroPai;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.RadioGroup rdDestinacao;
        private DevExpress.XtraEditors.LabelControl lblFlag;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}