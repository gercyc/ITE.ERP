using ITSolution.Framework.Components;

namespace ITE.Vendas.Forms.View
{
    partial class XFrmEnderecoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmEnderecoView));
            this.groupControlDadosEndereco = new DevExpress.XtraEditors.GroupControl();
            this.cepControl1 = new CepControl();
            this.radioGroupEndereco = new DevExpress.XtraEditors.RadioGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalvarEndereco = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtEndereco = new DevExpress.XtraEditors.TextEdit();
            this.txtComplemento = new DevExpress.XtraEditors.TextEdit();
            this.checkSemNumero = new DevExpress.XtraEditors.CheckEdit();
            this.txtCidade = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBairro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtUf = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosEndereco)).BeginInit();
            this.groupControlDadosEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSemNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUf.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlDadosEndereco
            // 
            this.groupControlDadosEndereco.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControlDadosEndereco.AppearanceCaption.Options.UseFont = true;
            this.groupControlDadosEndereco.Controls.Add(this.cepControl1);
            this.groupControlDadosEndereco.Controls.Add(this.radioGroupEndereco);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl1);
            this.groupControlDadosEndereco.Controls.Add(this.txtNumero);
            this.groupControlDadosEndereco.Controls.Add(this.txtEndereco);
            this.groupControlDadosEndereco.Controls.Add(this.txtComplemento);
            this.groupControlDadosEndereco.Controls.Add(this.checkSemNumero);
            this.groupControlDadosEndereco.Controls.Add(this.txtCidade);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl11);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl5);
            this.groupControlDadosEndereco.Controls.Add(this.txtBairro);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl6);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl7);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl8);
            this.groupControlDadosEndereco.Controls.Add(this.labelControl9);
            this.groupControlDadosEndereco.Controls.Add(this.txtUf);
            this.groupControlDadosEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDadosEndereco.Location = new System.Drawing.Point(0, 59);
            this.groupControlDadosEndereco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlDadosEndereco.Name = "groupControlDadosEndereco";
            this.groupControlDadosEndereco.Size = new System.Drawing.Size(705, 402);
            this.groupControlDadosEndereco.TabIndex = 0;
            this.groupControlDadosEndereco.Text = "Dados do Endereço:";
            // 
            // cepControl1
            // 
            this.cepControl1.AutoSize = true;
            this.cepControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cepControl1.Location = new System.Drawing.Point(471, 252);
            this.cepControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cepControl1.Name = "cepControl1";
            this.cepControl1.ReadyOnly = false;
            this.cepControl1.Size = new System.Drawing.Size(201, 64);
            this.cepControl1.TabIndex = 5;
            // 
            // radioGroupEndereco
            // 
            this.radioGroupEndereco.Location = new System.Drawing.Point(28, 59);
            this.radioGroupEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioGroupEndereco.MenuManager = this.barManager1;
            this.radioGroupEndereco.Name = "radioGroupEndereco";
            this.radioGroupEndereco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioGroupEndereco.Properties.Appearance.Options.UseFont = true;
            this.radioGroupEndereco.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Residencial"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Comercial"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Correspondência")});
            this.radioGroupEndereco.Size = new System.Drawing.Size(510, 49);
            this.radioGroupEndereco.TabIndex = 68;
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
            this.btnSalvarEndereco,
            this.barBtnCancelar});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCancelar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalvarEndereco)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.Hidden = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnCancelar
            // 
            this.barBtnCancelar.Caption = "Cancelar";
            this.barBtnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.Glyph")));
            this.barBtnCancelar.Id = 2;
            this.barBtnCancelar.Name = "barBtnCancelar";
            this.barBtnCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelar_ItemClick);
            // 
            // btnSalvarEndereco
            // 
            this.btnSalvarEndereco.Caption = "Salvar";
            this.btnSalvarEndereco.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalvarEndereco.Glyph")));
            this.btnSalvarEndereco.Id = 0;
            this.btnSalvarEndereco.Name = "btnSalvarEndereco";
            this.btnSalvarEndereco.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalvarEndereco.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalvarEndereco_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(705, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(705, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 402);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(705, 59);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 402);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(28, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 18);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "Tipo Endereço:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(29, 212);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNumero.Properties.Appearance.Options.UseFont = true;
            this.txtNumero.Size = new System.Drawing.Size(198, 24);
            this.txtNumero.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(28, 138);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtEndereco.Properties.Appearance.Options.UseFont = true;
            this.txtEndereco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Size = new System.Drawing.Size(650, 24);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(28, 282);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtComplemento.Properties.Appearance.Options.UseFont = true;
            this.txtComplemento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Size = new System.Drawing.Size(311, 24);
            this.txtComplemento.TabIndex = 4;
            // 
            // checkSemNumero
            // 
            this.checkSemNumero.Location = new System.Drawing.Point(168, 186);
            this.checkSemNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkSemNumero.Name = "checkSemNumero";
            this.checkSemNumero.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkSemNumero.Properties.Appearance.Options.UseFont = true;
            this.checkSemNumero.Properties.Caption = "S\\N";
            this.checkSemNumero.Size = new System.Drawing.Size(58, 22);
            this.checkSemNumero.TabIndex = 61;
            this.checkSemNumero.CheckedChanged += new System.EventHandler(this.checkSemNumero_CheckedChanged);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(28, 352);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCidade.Properties.Appearance.Options.UseFont = true;
            this.txtCidade.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Size = new System.Drawing.Size(311, 24);
            this.txtCidade.TabIndex = 6;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl11.Location = new System.Drawing.Point(259, 188);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(37, 18);
            this.labelControl11.TabIndex = 60;
            this.labelControl11.Text = "Bairro";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Location = new System.Drawing.Point(28, 114);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 18);
            this.labelControl5.TabIndex = 55;
            this.labelControl5.Text = "Endereço";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(259, 212);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBairro.Properties.Appearance.Options.UseFont = true;
            this.txtBairro.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Size = new System.Drawing.Size(419, 24);
            this.txtBairro.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Location = new System.Drawing.Point(29, 188);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 18);
            this.labelControl6.TabIndex = 56;
            this.labelControl6.Text = "Número";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl7.Location = new System.Drawing.Point(29, 258);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 18);
            this.labelControl7.TabIndex = 57;
            this.labelControl7.Text = "Complemento";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl8.Location = new System.Drawing.Point(28, 327);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 18);
            this.labelControl8.TabIndex = 58;
            this.labelControl8.Text = "Cidade";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl9.Location = new System.Drawing.Point(471, 327);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(18, 18);
            this.labelControl9.TabIndex = 59;
            this.labelControl9.Text = "UF";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(471, 352);
            this.txtUf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUf.Name = "txtUf";
            this.txtUf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUf.Properties.Appearance.Options.UseFont = true;
            this.txtUf.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Size = new System.Drawing.Size(198, 24);
            this.txtUf.TabIndex = 7;
            // 
            // XFrmAddEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 486);
            this.Controls.Add(this.groupControlDadosEndereco);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "XFrmAddEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão Endereço:";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDadosEndereco)).EndInit();
            this.groupControlDadosEndereco.ResumeLayout(false);
            this.groupControlDadosEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndereco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComplemento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSemNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBairro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUf.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlDadosEndereco;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtEndereco;
        private DevExpress.XtraEditors.TextEdit txtComplemento;
        private DevExpress.XtraEditors.CheckEdit checkSemNumero;
        private DevExpress.XtraEditors.TextEdit txtCidade;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBairro;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtUf;
        private DevExpress.XtraBars.BarButtonItem btnSalvarEndereco;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.RadioGroup radioGroupEndereco;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelar;
        private CepControl cepControl1;
    }
}