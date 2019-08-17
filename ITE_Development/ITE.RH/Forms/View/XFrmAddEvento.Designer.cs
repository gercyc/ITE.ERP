namespace ITE.RH.Forms.View
{
    partial class XFrmAddEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddEvento));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodEvento = new DevExpress.XtraEditors.TextEdit();
            this.txtDescricaoEvento = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.checkedListBoxSomaBase = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoEvento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbTipoRef = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbCodCalculo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnVoltar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodEvento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoEvento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxSomaBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoEvento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoRef.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCodCalculo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(9, 63);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Código Evento";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(177, 63);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Descrição Evento";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(10, 128);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tipo Ref.";
            // 
            // txtCodEvento
            // 
            this.txtCodEvento.Location = new System.Drawing.Point(10, 83);
            this.txtCodEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodEvento.Name = "txtCodEvento";
            this.txtCodEvento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCodEvento.Properties.Appearance.Options.UseFont = true;
            this.txtCodEvento.Size = new System.Drawing.Size(137, 20);
            this.txtCodEvento.TabIndex = 6;
            // 
            // txtDescricaoEvento
            // 
            this.txtDescricaoEvento.Location = new System.Drawing.Point(177, 83);
            this.txtDescricaoEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoEvento.Name = "txtDescricaoEvento";
            this.txtDescricaoEvento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDescricaoEvento.Properties.Appearance.Options.UseFont = true;
            this.txtDescricaoEvento.Size = new System.Drawing.Size(393, 20);
            this.txtDescricaoEvento.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl7.Location = new System.Drawing.Point(177, 128);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(67, 14);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Tipo Evento";
            // 
            // checkedListBoxSomaBase
            // 
            this.checkedListBoxSomaBase.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkedListBoxSomaBase.Appearance.Options.UseFont = true;
            this.checkedListBoxSomaBase.HorizontalScrollbar = true;
            this.checkedListBoxSomaBase.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Soma Base IRRF"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Soma Base FGTS"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Soma Base INSS")});
            this.checkedListBoxSomaBase.Location = new System.Drawing.Point(10, 207);
            this.checkedListBoxSomaBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxSomaBase.Name = "checkedListBoxSomaBase";
            this.checkedListBoxSomaBase.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBoxSomaBase.Size = new System.Drawing.Size(219, 73);
            this.checkedListBoxSomaBase.TabIndex = 19;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl8.Location = new System.Drawing.Point(10, 185);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 14);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "Soma Base";
            this.labelControl8.Visible = false;
            // 
            // cbTipoEvento
            // 
            this.cbTipoEvento.Location = new System.Drawing.Point(177, 146);
            this.cbTipoEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoEvento.Name = "cbTipoEvento";
            this.cbTipoEvento.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoEvento.Properties.Appearance.Options.UseFont = true;
            this.cbTipoEvento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoEvento.Properties.Items.AddRange(new object[] {
            "No Endereço",
            "Ponto de Atendimento"});
            this.cbTipoEvento.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoEvento.Size = new System.Drawing.Size(184, 20);
            this.cbTipoEvento.TabIndex = 25;
            // 
            // cbTipoRef
            // 
            this.cbTipoRef.Location = new System.Drawing.Point(10, 146);
            this.cbTipoRef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoRef.Name = "cbTipoRef";
            this.cbTipoRef.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRef.Properties.Appearance.Options.UseFont = true;
            this.cbTipoRef.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoRef.Properties.Items.AddRange(new object[] {
            "No Endereço",
            "Ponto de Atendimento"});
            this.cbTipoRef.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbTipoRef.Size = new System.Drawing.Size(137, 20);
            this.cbTipoRef.TabIndex = 26;
            // 
            // cbCodCalculo
            // 
            this.cbCodCalculo.Location = new System.Drawing.Point(386, 146);
            this.cbCodCalculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCodCalculo.Name = "cbCodCalculo";
            this.cbCodCalculo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodCalculo.Properties.Appearance.Options.UseFont = true;
            this.cbCodCalculo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCodCalculo.Properties.Items.AddRange(new object[] {
            "No Endereço",
            "Ponto de Atendimento"});
            this.cbCodCalculo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbCodCalculo.Size = new System.Drawing.Size(184, 20);
            this.cbCodCalculo.TabIndex = 30;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Location = new System.Drawing.Point(386, 128);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 14);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "Código de cálculo";
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
            this.barBtnVoltar,
            this.btnSalvar});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnVoltar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalvar)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // barBtnVoltar
            // 
            this.barBtnVoltar.Caption = "Voltar";
            this.barBtnVoltar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnVoltar.Glyph")));
            this.barBtnVoltar.Id = 0;
            this.barBtnVoltar.Name = "barBtnVoltar";
            this.barBtnVoltar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnVoltar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnVoltar_ItemClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Caption = "Salvar";
            this.btnSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Glyph")));
            this.btnSalvar.Id = 1;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSalvar_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(591, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 287);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(591, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 240);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(591, 47);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 240);
            // 
            // XFrmAddEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 310);
            this.Controls.Add(this.cbCodCalculo);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbTipoRef);
            this.Controls.Add(this.cbTipoEvento);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.checkedListBoxSomaBase);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtDescricaoEvento);
            this.Controls.Add(this.txtCodEvento);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "XFrmAddEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão de Evento";
            ((System.ComponentModel.ISupportInitialize)(this.txtCodEvento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricaoEvento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxSomaBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoEvento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoRef.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCodCalculo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCodEvento;
        private DevExpress.XtraEditors.TextEdit txtDescricaoEvento;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListBoxSomaBase;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoEvento;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoRef;
        private DevExpress.XtraEditors.ComboBoxEdit cbCodCalculo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnVoltar;
        private DevExpress.XtraBars.BarButtonItem btnSalvar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}