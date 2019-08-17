namespace ITE.Vendas.Forms.Administrativo
{
    partial class XFrmSetMatrizFilial
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
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmSetMatrizFilial));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.chBoxMemorizarFilial = new DevExpress.XtraEditors.CheckEdit();
            this.chBoxLoginAuto = new DevExpress.XtraEditors.CheckEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lookUpMatrizFilial1 = new ITE.Components.LookUpMatrizFilial();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBoxMemorizarFilial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBoxLoginAuto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(424, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 241);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(424, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 241);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(424, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 241);
            // 
            // chBoxMemorizarFilial
            // 
            this.chBoxMemorizarFilial.Location = new System.Drawing.Point(8, 15);
            this.chBoxMemorizarFilial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chBoxMemorizarFilial.MenuManager = this.barManager1;
            this.chBoxMemorizarFilial.Name = "chBoxMemorizarFilial";
            this.chBoxMemorizarFilial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chBoxMemorizarFilial.Properties.Appearance.Options.UseFont = true;
            this.chBoxMemorizarFilial.Properties.Caption = "Memorizar Filial";
            this.chBoxMemorizarFilial.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chBoxMemorizarFilial.Size = new System.Drawing.Size(113, 19);
            this.chBoxMemorizarFilial.TabIndex = 45;
            this.chBoxMemorizarFilial.CheckedChanged += new System.EventHandler(this.chBoxMemorizarFilial_CheckedChanged);
            // 
            // chBoxLoginAuto
            // 
            this.chBoxLoginAuto.Location = new System.Drawing.Point(8, 36);
            this.chBoxLoginAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chBoxLoginAuto.MenuManager = this.barManager1;
            this.chBoxLoginAuto.Name = "chBoxLoginAuto";
            this.chBoxLoginAuto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chBoxLoginAuto.Properties.Appearance.Options.UseFont = true;
            this.chBoxLoginAuto.Properties.Caption = "Entrar automaticamente";
            this.chBoxLoginAuto.Size = new System.Drawing.Size(181, 19);
            toolTipTitleItem1.Text = "Para desfazer essa opção:";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Acesse a barra inferior do menu principal e clique em \"Alterar Contexto\"";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.chBoxLoginAuto.SuperTip = superToolTip1;
            this.chBoxLoginAuto.TabIndex = 46;
            this.chBoxLoginAuto.CheckedChanged += new System.EventHandler(this.chBoxAuto_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(200, 39);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 24);
            this.btnCancelar.TabIndex = 73;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_ItemClick);
            // 
            // btnOk
            // 
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(294, 39);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 24);
            this.btnOk.TabIndex = 74;
            this.btnOk.Text = "Selecionar";
            this.btnOk.Click += new System.EventHandler(this.btnOk_ItemClick);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.chBoxLoginAuto);
            this.panelControl2.Controls.Add(this.btnOk);
            this.panelControl2.Controls.Add(this.btnCancelar);
            this.panelControl2.Controls.Add(this.chBoxMemorizarFilial);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(18, 148);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(388, 91);
            this.panelControl2.TabIndex = 82;
            // 
            // separatorControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.separatorControl1, 3);
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.separatorControl1.Location = new System.Drawing.Point(3, 129);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.separatorControl1.Size = new System.Drawing.Size(418, 15);
            this.separatorControl1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.separatorControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lookUpMatrizFilial1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 241);
            this.tableLayoutPanel1.TabIndex = 92;
            // 
            // lookUpMatrizFilial1
            // 
            this.lookUpMatrizFilial1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lookUpMatrizFilial1.Filial = null;
            this.lookUpMatrizFilial1.Location = new System.Drawing.Point(18, 18);
            this.lookUpMatrizFilial1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpMatrizFilial1.Matriz = null;
            this.lookUpMatrizFilial1.Name = "lookUpMatrizFilial1";
            this.lookUpMatrizFilial1.Size = new System.Drawing.Size(388, 105);
            this.lookUpMatrizFilial1.TabIndex = 83;
            // 
            // XFrmSetMatrizFilial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 241);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XFrmSetMatrizFilial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Filial:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XFrmSetMatrizFilial_FormClosing);
            this.Shown += new System.EventHandler(this.XFrmSetMatrizFilial_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmSetMatrizFilial_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBoxMemorizarFilial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBoxLoginAuto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.CheckEdit chBoxLoginAuto;
        private DevExpress.XtraEditors.CheckEdit chBoxMemorizarFilial;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.LookUpMatrizFilial lookUpMatrizFilial1;
    }
}