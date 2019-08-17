namespace ITE.Contabil.Forms.View
{
    partial class XFrmAddContaContabil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddContaContabil));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lookUpMatriz1 = new ITE.Components.LookUpMatriz();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodConta = new DevExpress.XtraEditors.TextEdit();
            this.txtCodReduzido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescConta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rdSintAnalitica = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rdNatureza = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.rdTipoSped = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodReduzido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescConta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSintAnalitica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdNatureza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoSped.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSalvar,
            this.btnEditar});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalvar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Tools";
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
            this.btnEditar.Id = 1;
            this.btnEditar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.LargeGlyph")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Caption = "Salvar";
            this.btnSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Glyph")));
            this.btnSalvar.Id = 0;
            this.btnSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSalvar.LargeGlyph")));
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalvar_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(517, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 298);
            this.barDockControlBottom.Size = new System.Drawing.Size(517, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 267);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(517, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 267);
            // 
            // lookUpMatriz1
            // 
            this.lookUpMatriz1.Filial = null;
            this.lookUpMatriz1.Location = new System.Drawing.Point(0, 37);
            this.lookUpMatriz1.Matriz = null;
            this.lookUpMatriz1.Name = "lookUpMatriz1";
            this.lookUpMatriz1.Size = new System.Drawing.Size(375, 51);
            this.lookUpMatriz1.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Código da conta:";
            // 
            // txtCodConta
            // 
            this.txtCodConta.Location = new System.Drawing.Point(7, 122);
            this.txtCodConta.MenuManager = this.barManager1;
            this.txtCodConta.Name = "txtCodConta";
            this.txtCodConta.Properties.Mask.EditMask = "9.9.9.99.99999";
            this.txtCodConta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtCodConta.Size = new System.Drawing.Size(147, 20);
            this.txtCodConta.TabIndex = 6;
            this.txtCodConta.Leave += new System.EventHandler(this.txtCodConta_Leave);
            // 
            // txtCodReduzido
            // 
            this.txtCodReduzido.Location = new System.Drawing.Point(228, 122);
            this.txtCodReduzido.MenuManager = this.barManager1;
            this.txtCodReduzido.Name = "txtCodReduzido";
            this.txtCodReduzido.Size = new System.Drawing.Size(147, 20);
            this.txtCodReduzido.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(228, 103);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Código reduzido:";
            // 
            // txtDescConta
            // 
            this.txtDescConta.Location = new System.Drawing.Point(7, 168);
            this.txtDescConta.MenuManager = this.barManager1;
            this.txtDescConta.Name = "txtDescConta";
            this.txtDescConta.Size = new System.Drawing.Size(368, 20);
            this.txtDescConta.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Descrição:";
            // 
            // rdSintAnalitica
            // 
            this.rdSintAnalitica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdSintAnalitica.Location = new System.Drawing.Point(2, 20);
            this.rdSintAnalitica.MenuManager = this.barManager1;
            this.rdSintAnalitica.Name = "rdSintAnalitica";
            this.rdSintAnalitica.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Sintética"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Analítica")});
            this.rdSintAnalitica.Size = new System.Drawing.Size(110, 58);
            this.rdSintAnalitica.TabIndex = 11;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdSintAnalitica);
            this.groupControl1.Location = new System.Drawing.Point(395, 128);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(114, 80);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Sintética/Analítica";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rdNatureza);
            this.groupControl2.Location = new System.Drawing.Point(393, 37);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(114, 80);
            this.groupControl2.TabIndex = 13;
            this.groupControl2.Text = "Natureza";
            // 
            // rdNatureza
            // 
            this.rdNatureza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdNatureza.Location = new System.Drawing.Point(2, 20);
            this.rdNatureza.MenuManager = this.barManager1;
            this.rdNatureza.Name = "rdNatureza";
            this.rdNatureza.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Devedora"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Credora")});
            this.rdNatureza.Size = new System.Drawing.Size(110, 58);
            this.rdNatureza.TabIndex = 11;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.rdTipoSped);
            this.groupControl3.Location = new System.Drawing.Point(7, 212);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(500, 80);
            this.groupControl3.TabIndex = 14;
            this.groupControl3.Text = "Natureza";
            // 
            // rdTipoSped
            // 
            this.rdTipoSped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdTipoSped.Location = new System.Drawing.Point(2, 20);
            this.rdTipoSped.MenuManager = this.barManager1;
            this.rdTipoSped.Name = "rdTipoSped";
            this.rdTipoSped.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("01", "Contas de ativo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("02", "Contas de passivo"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("03", "Patrimônio líquido"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("04", "Contas de resultado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("05", "Contas de compensação"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("09", "Outras")});
            this.rdTipoSped.Size = new System.Drawing.Size(496, 58);
            this.rdTipoSped.TabIndex = 11;
            // 
            // XFrmAddContaContabil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 321);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtDescConta);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCodReduzido);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCodConta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lookUpMatriz1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmAddContaContabil";
            this.Text = "Adição de conta contábil";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodReduzido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescConta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdSintAnalitica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdNatureza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdTipoSped.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnSalvar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.RadioGroup rdNatureza;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.RadioGroup rdSintAnalitica;
        private DevExpress.XtraEditors.TextEdit txtDescConta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodReduzido;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCodConta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Components.LookUpMatriz lookUpMatriz1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.RadioGroup rdTipoSped;
    }
}