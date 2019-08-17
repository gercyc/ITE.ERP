using ITE.Components.LookUp;

namespace ITE.Fiscal.Movimentacoes.NotaFiscal
{
    partial class XFrmAddItemNF_NEW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddItemNF_NEW));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvarN = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlImpostos = new DevExpress.XtraGrid.GridControl();
            this.bsNotaFiscalItemImposto = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewImpostos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBaseCalculo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorImposto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTpSitImposto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoImposto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSituacaoTributaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTotItem = new DevExpress.XtraEditors.SimpleButton();
            this.txtVlrTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtQtde = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrUnitario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bsCfops = new System.Windows.Forms.BindingSource(this.components);
            this.bsTipoImposto = new System.Windows.Forms.BindingSource(this.components);
            this.bsSituacaoTributaria = new System.Windows.Forms.BindingSource(this.components);
            this.bsProduto = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpProduto1 = new LookUpProduto();
            this.lookUpRegraFiscal1 = new ITE.Components.LookUpRegraFiscal();
            this.lookUpCfop1 = new ITE.Components.LookUpCfop();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlImpostos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalItemImposto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewImpostos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCfops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoImposto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSituacaoTributaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSalvarN);
            this.panel1.Controls.Add(this.groupControl3);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 405);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(409, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 24);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSalvarN
            // 
            this.btnSalvarN.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarN.Image")));
            this.btnSalvarN.Location = new System.Drawing.Point(517, 372);
            this.btnSalvarN.Name = "btnSalvarN";
            this.btnSalvarN.Size = new System.Drawing.Size(86, 24);
            this.btnSalvarN.TabIndex = 7;
            this.btnSalvarN.Text = "Salvar";
            this.btnSalvarN.Click += new System.EventHandler(this.btnSalvarN_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.gridControlImpostos);
            this.groupControl3.Location = new System.Drawing.Point(3, 221);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(605, 145);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Impostos";
            // 
            // gridControlImpostos
            // 
            this.gridControlImpostos.DataSource = this.bsNotaFiscalItemImposto;
            this.gridControlImpostos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlImpostos.Location = new System.Drawing.Point(2, 23);
            this.gridControlImpostos.MainView = this.gridViewImpostos;
            this.gridControlImpostos.Name = "gridControlImpostos";
            this.gridControlImpostos.Size = new System.Drawing.Size(601, 120);
            this.gridControlImpostos.TabIndex = 2;
            this.gridControlImpostos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewImpostos});
            // 
            // bsNotaFiscalItemImposto
            // 
            this.bsNotaFiscalItemImposto.DataSource = typeof(ITE.Entidades.POCO.Fiscal.ImpostoItemMovimento);
            // 
            // gridViewImpostos
            // 
            this.gridViewImpostos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBaseCalculo,
            this.colAliquota,
            this.colValorImposto,
            this.colTpSitImposto,
            this.colTipoImposto,
            this.colSituacaoTributaria});
            this.gridViewImpostos.GridControl = this.gridControlImpostos;
            this.gridViewImpostos.Name = "gridViewImpostos";
            this.gridViewImpostos.OptionsBehavior.Editable = false;
            this.gridViewImpostos.OptionsView.ShowGroupPanel = false;
            // 
            // colBaseCalculo
            // 
            this.colBaseCalculo.Caption = "Base de cálculo";
            this.colBaseCalculo.FieldName = "BaseCalculo";
            this.colBaseCalculo.Name = "colBaseCalculo";
            this.colBaseCalculo.Visible = true;
            this.colBaseCalculo.VisibleIndex = 3;
            // 
            // colAliquota
            // 
            this.colAliquota.Caption = "Alíquota";
            this.colAliquota.FieldName = "Aliquota";
            this.colAliquota.Name = "colAliquota";
            this.colAliquota.Visible = true;
            this.colAliquota.VisibleIndex = 4;
            // 
            // colValorImposto
            // 
            this.colValorImposto.Caption = "Valor imposto";
            this.colValorImposto.FieldName = "ValorImposto";
            this.colValorImposto.Name = "colValorImposto";
            this.colValorImposto.Visible = true;
            this.colValorImposto.VisibleIndex = 5;
            // 
            // colTpSitImposto
            // 
            this.colTpSitImposto.Caption = "Tributação";
            this.colTpSitImposto.FieldName = "TpSitImposto";
            this.colTpSitImposto.Name = "colTpSitImposto";
            this.colTpSitImposto.Visible = true;
            this.colTpSitImposto.VisibleIndex = 2;
            // 
            // colTipoImposto
            // 
            this.colTipoImposto.Caption = "Cód. Imposto";
            this.colTipoImposto.FieldName = "TipoImposto";
            this.colTipoImposto.Name = "colTipoImposto";
            this.colTipoImposto.Visible = true;
            this.colTipoImposto.VisibleIndex = 0;
            // 
            // colSituacaoTributaria
            // 
            this.colSituacaoTributaria.Caption = "CST";
            this.colSituacaoTributaria.FieldName = "SituacaoTributaria";
            this.colSituacaoTributaria.Name = "colSituacaoTributaria";
            this.colSituacaoTributaria.Visible = true;
            this.colSituacaoTributaria.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lookUpCfop1);
            this.groupControl1.Controls.Add(this.lookUpRegraFiscal1);
            this.groupControl1.Controls.Add(this.lookUpProduto1);
            this.groupControl1.Controls.Add(this.btnTotItem);
            this.groupControl1.Controls.Add(this.txtVlrTotal);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtQtde);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtVlrUnitario);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(5, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(603, 209);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Informações do item";
            // 
            // btnTotItem
            // 
            this.btnTotItem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnTotItem.Appearance.Options.UseFont = true;
            this.btnTotItem.Image = ((System.Drawing.Image)(resources.GetObject("btnTotItem.Image")));
            this.btnTotItem.Location = new System.Drawing.Point(565, 175);
            this.btnTotItem.Name = "btnTotItem";
            this.btnTotItem.Size = new System.Drawing.Size(28, 23);
            this.btnTotItem.TabIndex = 6;
            this.btnTotItem.Click += new System.EventHandler(this.btnTotItem_Click);
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(443, 177);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrTotal.Properties.Appearance.Options.UseFont = true;
            this.txtVlrTotal.Size = new System.Drawing.Size(116, 20);
            this.txtVlrTotal.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Location = new System.Drawing.Point(443, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Valor Total:";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(11, 178);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtQtde.Properties.Appearance.Options.UseFont = true;
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 3;
            this.txtQtde.EditValueChanged += new System.EventHandler(this.txtQtde_EditValueChanged);
            this.txtQtde.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtQtde_EditValueChanging);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(11, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Quantidade:";
            // 
            // txtVlrUnitario
            // 
            this.txtVlrUnitario.Location = new System.Drawing.Point(117, 178);
            this.txtVlrUnitario.Name = "txtVlrUnitario";
            this.txtVlrUnitario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrUnitario.Properties.Appearance.Options.UseFont = true;
            this.txtVlrUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtVlrUnitario.TabIndex = 4;
            this.txtVlrUnitario.Leave += new System.EventHandler(this.txtVlrUnitario_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(117, 158);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Valor Unitário:";
            // 
            // bsCfops
            // 
            this.bsCfops.DataSource = typeof(ITE.Entidades.POCO.Fiscal.Cfops);
            // 
            // bsTipoImposto
            // 
            this.bsTipoImposto.DataSource = typeof(ITE.Entidades.POCO.Fiscal.TipoImposto);
            // 
            // bsSituacaoTributaria
            // 
            this.bsSituacaoTributaria.DataSource = typeof(ITE.Entidades.POCO.Fiscal.SituacaoTributaria);
            // 
            // bsProduto
            // 
            this.bsProduto.DataSource = typeof(ITE.Entidades.POCO.Sales.Produto);
            // 
            // lookUpProduto1
            // 
            this.lookUpProduto1.LabelText = "Produto:";
            this.lookUpProduto1.Location = new System.Drawing.Point(11, 32);
            this.lookUpProduto1.Name = "lookUpProduto1";
            this.lookUpProduto1.Produto = null;
            this.lookUpProduto1.ReadOnly = false;
            this.lookUpProduto1.Size = new System.Drawing.Size(582, 50);
            this.lookUpProduto1.TabIndex = 0;
            // 
            // lookUpRegraFiscal1
            // 
            this.lookUpRegraFiscal1.Location = new System.Drawing.Point(359, 88);
            this.lookUpRegraFiscal1.Name = "lookUpRegraFiscal1";
            this.lookUpRegraFiscal1.RegraFiscal = null;
            this.lookUpRegraFiscal1.Size = new System.Drawing.Size(234, 49);
            this.lookUpRegraFiscal1.TabIndex = 2;
            // 
            // lookUpCfop1
            // 
            this.lookUpCfop1.CFOP = null;
            this.lookUpCfop1.Location = new System.Drawing.Point(11, 88);
            this.lookUpCfop1.Name = "lookUpCfop1";
            this.lookUpCfop1.Size = new System.Drawing.Size(327, 49);
            this.lookUpCfop1.TabIndex = 1;
            // 
            // XFrmAddItemNF_NEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 405);
            this.Controls.Add(this.panel1);
            this.Name = "XFrmAddItemNF_NEW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota Fiscal: Inclusão de Item";
            this.Shown += new System.EventHandler(this.XFrmAddItemNF_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlImpostos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalItemImposto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewImpostos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCfops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoImposto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSituacaoTributaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnTotItem;
        private DevExpress.XtraEditors.TextEdit txtVlrTotal;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtQtde;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtVlrUnitario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsProduto;
        private System.Windows.Forms.BindingSource bsNotaFiscalItemImposto;
        private System.Windows.Forms.BindingSource bsTipoImposto;
        private System.Windows.Forms.BindingSource bsSituacaoTributaria;
        private System.Windows.Forms.BindingSource bsCfops;
        private DevExpress.XtraEditors.SimpleButton btnSalvarN;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlImpostos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewImpostos;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseCalculo;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquota;
        private DevExpress.XtraGrid.Columns.GridColumn colValorImposto;
        private DevExpress.XtraGrid.Columns.GridColumn colTpSitImposto;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoImposto;
        private DevExpress.XtraGrid.Columns.GridColumn colSituacaoTributaria;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private Components.LookUpCfop lookUpCfop1;
        private Components.LookUpRegraFiscal lookUpRegraFiscal1;
        private LookUpProduto lookUpProduto1;
    }
}