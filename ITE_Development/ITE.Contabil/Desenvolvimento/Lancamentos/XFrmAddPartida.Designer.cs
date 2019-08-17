using ITE.Components.LookUp;

namespace ITE.Contabil.Desenvolvimento.Lancamentos
{
    partial class XFrmAddPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddPartida));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnSalvarPartida = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lbNumLanc = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lkContaDebito = new ITE.Components.LookUpContaContabil();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkContaCredito = new ITE.Components.LookUpContaContabil();
            this.lookUpCentroCusto1 = new ITE.Components.LookUpCentroCusto();
            this.cbMoedaPrinc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbMoedaEstr = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lookUpCliFor1 = new LookUpCliFor();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrPartida = new DevExpress.XtraEditors.TextEdit();
            this.txtVlrPartidaME = new DevExpress.XtraEditors.TextEdit();
            this.txtHistorico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtLocalDoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoedaPrinc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoedaEstr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrPartida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrPartidaME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalDoc.Properties)).BeginInit();
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
            this.btnSalvarPartida,
            this.barStaticItem1,
            this.lbNumLanc,
            this.btnSaveAndNew});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalvarPartida),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveAndNew)});
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnSalvarPartida
            // 
            this.btnSalvarPartida.Caption = "Salvar";
            this.btnSalvarPartida.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalvarPartida.Glyph")));
            this.btnSalvarPartida.Id = 0;
            this.btnSalvarPartida.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSalvarPartida.LargeGlyph")));
            this.btnSalvarPartida.Name = "btnSalvarPartida";
            this.btnSalvarPartida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalvarPartida_ItemClick);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Caption = "Salvar e adionar nova";
            this.btnSaveAndNew.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaveAndNew.Glyph")));
            this.btnSaveAndNew.Id = 3;
            this.btnSaveAndNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSaveAndNew.LargeGlyph")));
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAndNew_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbNumLanc)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Lançamento:  ";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbNumLanc
            // 
            this.lbNumLanc.Caption = "%lanc%";
            this.lbNumLanc.Id = 2;
            this.lbNumLanc.Name = "lbNumLanc";
            this.lbNumLanc.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(495, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 363);
            this.barDockControlBottom.Size = new System.Drawing.Size(495, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 332);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(495, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 332);
            // 
            // lkContaDebito
            // 
            this.lkContaDebito.ContaContabil = null;
            this.lkContaDebito.Location = new System.Drawing.Point(8, 56);
            this.lkContaDebito.Name = "lkContaDebito";
            this.lkContaDebito.Size = new System.Drawing.Size(468, 31);
            this.lkContaDebito.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(123, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Conta contábil débito:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(12, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Conta contábil crédito:";
            // 
            // lkContaCredito
            // 
            this.lkContaCredito.ContaContabil = null;
            this.lkContaCredito.Location = new System.Drawing.Point(8, 112);
            this.lkContaCredito.Name = "lkContaCredito";
            this.lkContaCredito.Size = new System.Drawing.Size(468, 31);
            this.lkContaCredito.TabIndex = 6;
            // 
            // lookUpCentroCusto1
            // 
            this.lookUpCentroCusto1.CentroCusto = null;
            this.lookUpCentroCusto1.Location = new System.Drawing.Point(11, 142);
            this.lookUpCentroCusto1.Name = "lookUpCentroCusto1";
            this.lookUpCentroCusto1.Size = new System.Drawing.Size(465, 48);
            this.lookUpCentroCusto1.TabIndex = 8;
            // 
            // cbMoedaPrinc
            // 
            this.cbMoedaPrinc.Location = new System.Drawing.Point(14, 223);
            this.cbMoedaPrinc.MenuManager = this.barManager1;
            this.cbMoedaPrinc.Name = "cbMoedaPrinc";
            this.cbMoedaPrinc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMoedaPrinc.Size = new System.Drawing.Size(121, 20);
            this.cbMoedaPrinc.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(14, 204);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Moeda Principal:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(160, 204);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Segunda moeda:";
            // 
            // cbMoedaEstr
            // 
            this.cbMoedaEstr.Location = new System.Drawing.Point(160, 223);
            this.cbMoedaEstr.MenuManager = this.barManager1;
            this.cbMoedaEstr.Name = "cbMoedaEstr";
            this.cbMoedaEstr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbMoedaEstr.Size = new System.Drawing.Size(121, 20);
            this.cbMoedaEstr.TabIndex = 11;
            // 
            // lookUpCliFor1
            // 
            this.lookUpCliFor1.CliFor = null;
            this.lookUpCliFor1.Filial = null;
            this.lookUpCliFor1.LabelText = "Participante:";
            this.lookUpCliFor1.Location = new System.Drawing.Point(287, 195);
            this.lookUpCliFor1.Matriz = null;
            this.lookUpCliFor1.Name = "lookUpCliFor1";
            this.lookUpCliFor1.Size = new System.Drawing.Size(193, 48);
            this.lookUpCliFor1.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(14, 251);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 13);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Valor:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(160, 251);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Valor em 2ª moeda:";
            // 
            // txtVlrPartida
            // 
            this.txtVlrPartida.Location = new System.Drawing.Point(12, 272);
            this.txtVlrPartida.MenuManager = this.barManager1;
            this.txtVlrPartida.Name = "txtVlrPartida";
            this.txtVlrPartida.Size = new System.Drawing.Size(123, 20);
            this.txtVlrPartida.TabIndex = 16;
            // 
            // txtVlrPartidaME
            // 
            this.txtVlrPartidaME.Location = new System.Drawing.Point(160, 272);
            this.txtVlrPartidaME.MenuManager = this.barManager1;
            this.txtVlrPartidaME.Name = "txtVlrPartidaME";
            this.txtVlrPartidaME.Size = new System.Drawing.Size(121, 20);
            this.txtVlrPartidaME.TabIndex = 17;
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(12, 325);
            this.txtHistorico.MenuManager = this.barManager1;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(468, 20);
            this.txtHistorico.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(12, 306);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Histórico:";
            // 
            // txtLocalDoc
            // 
            this.txtLocalDoc.Location = new System.Drawing.Point(287, 272);
            this.txtLocalDoc.MenuManager = this.barManager1;
            this.txtLocalDoc.Name = "txtLocalDoc";
            this.txtLocalDoc.Size = new System.Drawing.Size(121, 20);
            this.txtLocalDoc.TabIndex = 27;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(287, 251);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(78, 13);
            this.labelControl9.TabIndex = 26;
            this.labelControl9.Text = "Localização doc.";
            // 
            // XFrmAddPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 388);
            this.Controls.Add(this.txtLocalDoc);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.txtVlrPartidaME);
            this.Controls.Add(this.txtVlrPartida);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lookUpCliFor1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbMoedaEstr);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbMoedaPrinc);
            this.Controls.Add(this.lookUpCentroCusto1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lkContaCredito);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lkContaDebito);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmAddPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar partida";
            this.Shown += new System.EventHandler(this.XFrmAddPartida_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoedaPrinc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMoedaEstr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrPartida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrPartidaME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHistorico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalDoc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSalvarPartida;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem lbNumLanc;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndNew;
        private Components.LookUpCentroCusto lookUpCentroCusto1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Components.LookUpContaContabil lkContaCredito;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Components.LookUpContaContabil lkContaDebito;
        private DevExpress.XtraEditors.TextEdit txtVlrPartidaME;
        private DevExpress.XtraEditors.TextEdit txtVlrPartida;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private LookUpCliFor lookUpCliFor1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbMoedaEstr;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbMoedaPrinc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtHistorico;
        private DevExpress.XtraEditors.TextEdit txtLocalDoc;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}