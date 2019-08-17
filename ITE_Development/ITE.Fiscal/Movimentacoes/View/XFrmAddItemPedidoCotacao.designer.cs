using ITE.Components.LookUp;

namespace ITE.Fiscal.Movimentacoes.OutrasMovimentacoes
{
    partial class XFrmAddItemPedidoCotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmAddItemPedidoCotacao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSalvarN = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTotItem = new DevExpress.XtraEditors.SimpleButton();
            this.txtVlrTotal = new DevExpress.XtraEditors.TextEdit();
            this.lbVlrTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtQtde = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtVlrUnitario = new DevExpress.XtraEditors.TextEdit();
            this.lbVlrUnitario = new DevExpress.XtraEditors.LabelControl();
            this.bsNotaFiscalItemImposto = new System.Windows.Forms.BindingSource();
            this.bsCfops = new System.Windows.Forms.BindingSource();
            this.bsTipoImposto = new System.Windows.Forms.BindingSource();
            this.bsSituacaoTributaria = new System.Windows.Forms.BindingSource();
            this.bsProduto = new System.Windows.Forms.BindingSource();
            this.lookUpProduto1 = new LookUpProduto();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalItemImposto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCfops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoImposto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSituacaoTributaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 170);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnSalvarN);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.lookUpProduto1);
            this.groupControl1.Controls.Add(this.btnTotItem);
            this.groupControl1.Controls.Add(this.txtVlrTotal);
            this.groupControl1.Controls.Add(this.lbVlrTotal);
            this.groupControl1.Controls.Add(this.txtQtde);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtVlrUnitario);
            this.groupControl1.Controls.Add(this.lbVlrUnitario);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(416, 170);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Informações do item";
            // 
            // btnSalvarN
            // 
            this.btnSalvarN.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarN.Image")));
            this.btnSalvarN.Location = new System.Drawing.Point(326, 133);
            this.btnSalvarN.Name = "btnSalvarN";
            this.btnSalvarN.Size = new System.Drawing.Size(77, 24);
            this.btnSalvarN.TabIndex = 5;
            this.btnSalvarN.Text = "Salvar";
            this.btnSalvarN.Click += new System.EventHandler(this.btnSalvarN_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(226, 133);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTotItem
            // 
            this.btnTotItem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnTotItem.Appearance.Options.UseFont = true;
            this.btnTotItem.Image = ((System.Drawing.Image)(resources.GetObject("btnTotItem.Image")));
            this.btnTotItem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTotItem.Location = new System.Drawing.Point(374, 106);
            this.btnTotItem.Name = "btnTotItem";
            this.btnTotItem.Size = new System.Drawing.Size(28, 20);
            this.btnTotItem.TabIndex = 4;
            this.btnTotItem.Click += new System.EventHandler(this.btnTotItem_Click);
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(253, 107);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrTotal.Properties.Appearance.Options.UseFont = true;
            this.txtVlrTotal.Size = new System.Drawing.Size(116, 20);
            this.txtVlrTotal.TabIndex = 3;
            // 
            // lbVlrTotal
            // 
            this.lbVlrTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbVlrTotal.Location = new System.Drawing.Point(253, 87);
            this.lbVlrTotal.Name = "lbVlrTotal";
            this.lbVlrTotal.Size = new System.Drawing.Size(63, 14);
            this.lbVlrTotal.TabIndex = 6;
            this.lbVlrTotal.Text = "Valor Total:";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(128, 107);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtQtde.Properties.Appearance.Options.UseFont = true;
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 2;
            this.txtQtde.EditValueChanged += new System.EventHandler(this.txtQtde_EditValueChanged);
            this.txtQtde.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtQtde_EditValueChanging);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(128, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Quantidade:";
            // 
            // txtVlrUnitario
            // 
            this.txtVlrUnitario.Location = new System.Drawing.Point(11, 107);
            this.txtVlrUnitario.Name = "txtVlrUnitario";
            this.txtVlrUnitario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtVlrUnitario.Properties.Appearance.Options.UseFont = true;
            this.txtVlrUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtVlrUnitario.TabIndex = 1;
            // 
            // lbVlrUnitario
            // 
            this.lbVlrUnitario.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbVlrUnitario.Location = new System.Drawing.Point(11, 87);
            this.lbVlrUnitario.Name = "lbVlrUnitario";
            this.lbVlrUnitario.Size = new System.Drawing.Size(76, 14);
            this.lbVlrUnitario.TabIndex = 1;
            this.lbVlrUnitario.Text = "Valor Unitário:";
            // 
            // bsNotaFiscalItemImposto
            // 
            this.bsNotaFiscalItemImposto.DataSource = typeof(ITE.Entidades.POCO.Fiscal.ImpostoItemMovimento);
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
            this.lookUpProduto1.LabelTextFont = null;
            this.lookUpProduto1.Location = new System.Drawing.Point(11, 26);
            this.lookUpProduto1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lookUpProduto1.Name = "lookUpProduto1";
            this.lookUpProduto1.Produto = null;
            this.lookUpProduto1.ReadOnly = false;
            this.lookUpProduto1.Size = new System.Drawing.Size(391, 53);
            this.lookUpProduto1.TabIndex = 0;
            // 
            // XFrmAddItemPedidoCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 170);
            this.Controls.Add(this.panel1);
            this.Name = "XFrmAddItemPedidoCotacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota Fiscal: Inclusão de Item";
            this.Shown += new System.EventHandler(this.XFrmAddItemNF_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVlrUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotaFiscalItemImposto)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl lbVlrTotal;
        private DevExpress.XtraEditors.TextEdit txtQtde;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtVlrUnitario;
        private DevExpress.XtraEditors.LabelControl lbVlrUnitario;
        private System.Windows.Forms.BindingSource bsProduto;
        private System.Windows.Forms.BindingSource bsNotaFiscalItemImposto;
        private System.Windows.Forms.BindingSource bsTipoImposto;
        private System.Windows.Forms.BindingSource bsSituacaoTributaria;
        private System.Windows.Forms.BindingSource bsCfops;
        private DevExpress.XtraEditors.SimpleButton btnSalvarN;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private LookUpProduto lookUpProduto1;
    }
}