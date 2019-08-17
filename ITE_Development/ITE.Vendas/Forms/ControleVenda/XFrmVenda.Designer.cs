using ITSolution.Framework.Components;

namespace ITE.Vendas.Forms.ControleVenda
{
    partial class XFrmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmVenda));
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator1 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.lblVendedor = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControlProdutos = new DevExpress.XtraEditors.ListBoxControl();
            this.pictureLogo = new DevExpress.XtraEditors.PictureEdit();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.lblTotalVenda = new DevExpress.XtraEditors.LabelControl();
            this.lblItens = new DevExpress.XtraEditors.LabelControl();
            this.lblDescricaoProduto = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl4 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemAlterarCentroCusto = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarDadoCpl = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl2 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupVenda = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemSelecionarCliente = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemCotacao = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemAprazo = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemAvista = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarControl3 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemAjuda = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemObervacao = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemAlterarCarrinho = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemConsultarProduto = new DevExpress.XtraNavBar.NavBarItem();
            this.tbLayoutPanelPai = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtCodigoBarrasProduto = new ITSolution.Framework.Components.TextCodigoBarras();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.picCart = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCliente = new DevExpress.XtraEditors.LabelControl();
            this.openFileLogo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl3)).BeginInit();
            this.tbLayoutPanelPai.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarrasProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVendedor
            // 
            this.lblVendedor.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblVendedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblVendedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVendedor.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblVendedor.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblVendedor.LineVisible = true;
            this.lblVendedor.Location = new System.Drawing.Point(3, 26);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(69, 18);
            this.lblVendedor.TabIndex = 14;
            this.lblVendedor.Text = "%user%";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(40, 25);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(131, 25);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Código Barras:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelControl9.Location = new System.Drawing.Point(17, 34);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(196, 38);
            this.labelControl9.TabIndex = 1;
            this.labelControl9.Text = "Total Venda:";
            // 
            // listBoxControlProdutos
            // 
            this.listBoxControlProdutos.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.listBoxControlProdutos.Appearance.Options.UseFont = true;
            this.listBoxControlProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControlProdutos.Items.AddRange(new object[] {
            "Produtos"});
            this.listBoxControlProdutos.Location = new System.Drawing.Point(3, 2);
            this.listBoxControlProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxControlProdutos.Name = "listBoxControlProdutos";
            this.listBoxControlProdutos.Size = new System.Drawing.Size(396, 412);
            this.listBoxControlProdutos.TabIndex = 0;
            this.listBoxControlProdutos.SelectedIndexChanged += new System.EventHandler(this.listBoxControlProdutos_SelectedIndexChanged);
            // 
            // pictureLogo
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.pictureLogo, 2);
            this.pictureLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.EditValue = ((object)(resources.GetObject("pictureLogo.EditValue")));
            this.pictureLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Properties.Appearance.Options.UseBackColor = true;
            this.pictureLogo.Size = new System.Drawing.Size(586, 164);
            this.pictureLogo.TabIndex = 6;
            this.pictureLogo.DoubleClick += new System.EventHandler(this.pictureLogo_DoubleClick);
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barCodeControl1.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.Location = new System.Drawing.Point(40, 103);
            this.barCodeControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(12, 2, 12, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(474, 42);
            this.barCodeControl1.Symbology = eaN13Generator1;
            this.barCodeControl1.TabIndex = 0;
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVenda.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTotalVenda.Location = new System.Drawing.Point(220, 34);
            this.lblTotalVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(121, 38);
            this.lblTotalVenda.TabIndex = 6;
            this.lblTotalVenda.Text = "R$ 0,00";
            // 
            // lblItens
            // 
            this.lblItens.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblItens.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblItens.Location = new System.Drawing.Point(79, 4);
            this.lblItens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(13, 24);
            this.lblItens.TabIndex = 4;
            this.lblItens.Text = "0";
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Underline);
            this.lblDescricaoProduto.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(20, 2);
            this.lblDescricaoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(177, 40);
            this.lblDescricaoProduto.TabIndex = 5;
            this.lblDescricaoProduto.Text = "%Produto%";
            // 
            // navBarControl4
            // 
            this.navBarControl4.ActiveGroup = this.navBarGroup1;
            this.navBarControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl4.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl4.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemAlterarCentroCusto,
            this.navBarDadoCpl});
            this.navBarControl4.Location = new System.Drawing.Point(3, 2);
            this.navBarControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBarControl4.Name = "navBarControl4";
            this.navBarControl4.OptionsNavPane.ExpandedWidth = 327;
            this.navBarControl4.Size = new System.Drawing.Size(327, 168);
            this.navBarControl4.TabIndex = 0;
            this.navBarControl4.Text = "navBarControl4";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Caption = "Ferramentas";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAlterarCentroCusto),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarDadoCpl)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItemAlterarCentroCusto
            // 
            this.navBarItemAlterarCentroCusto.Caption = "F3: Alterar centro de custo";
            this.navBarItemAlterarCentroCusto.Name = "navBarItemAlterarCentroCusto";
            this.navBarItemAlterarCentroCusto.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemAlterarCentroCusto.SmallImage")));
            this.navBarItemAlterarCentroCusto.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemAlterarCentroCusto_LinkClicked);
            // 
            // navBarDadoCpl
            // 
            this.navBarDadoCpl.Caption = "F4: Dados Complementares";
            this.navBarDadoCpl.Name = "navBarDadoCpl";
            this.navBarDadoCpl.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarDadoCpl.SmallImage")));
            this.navBarDadoCpl.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarDadoCpl_LinkClicked);
            // 
            // navBarControl2
            // 
            this.navBarControl2.ActiveGroup = this.navBarGroupVenda;
            this.navBarControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl2.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupVenda});
            this.navBarControl2.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemCotacao,
            this.navBarItemAprazo,
            this.navBarItemAvista,
            this.navBarItemSelecionarCliente});
            this.navBarControl2.Location = new System.Drawing.Point(336, 2);
            this.navBarControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBarControl2.Name = "navBarControl2";
            this.navBarControl2.OptionsNavPane.ExpandedWidth = 327;
            this.navBarControl2.Size = new System.Drawing.Size(327, 168);
            this.navBarControl2.TabIndex = 38;
            this.navBarControl2.Text = "navBarControl2";
            // 
            // navBarGroupVenda
            // 
            this.navBarGroupVenda.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.navBarGroupVenda.Appearance.Options.UseFont = true;
            this.navBarGroupVenda.Caption = "Venda";
            this.navBarGroupVenda.Expanded = true;
            this.navBarGroupVenda.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSelecionarCliente),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemCotacao),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAprazo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAvista)});
            this.navBarGroupVenda.Name = "navBarGroupVenda";
            // 
            // navBarItemSelecionarCliente
            // 
            this.navBarItemSelecionarCliente.Caption = "F2: Selecionar Cliente";
            this.navBarItemSelecionarCliente.Name = "navBarItemSelecionarCliente";
            this.navBarItemSelecionarCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemSelecionarCliente.SmallImage")));
            this.navBarItemSelecionarCliente.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSelecionarCliente_LinkClicked);
            // 
            // navBarItemCotacao
            // 
            this.navBarItemCotacao.Caption = "F5: Orçamento";
            this.navBarItemCotacao.Name = "navBarItemCotacao";
            this.navBarItemCotacao.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemCotacao.SmallImage")));
            this.navBarItemCotacao.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemCotacao_LinkClicked);
            // 
            // navBarItemAprazo
            // 
            this.navBarItemAprazo.Caption = "F9: Á Prazo";
            this.navBarItemAprazo.Name = "navBarItemAprazo";
            this.navBarItemAprazo.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemAprazo.SmallImage")));
            this.navBarItemAprazo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemAprazo_LinkClicked);
            // 
            // navBarItemAvista
            // 
            this.navBarItemAvista.Caption = "F11: Á Vista";
            this.navBarItemAvista.Name = "navBarItemAvista";
            this.navBarItemAvista.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemAvista.SmallImage")));
            this.navBarItemAvista.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemAvista_LinkClicked);
            // 
            // navBarControl3
            // 
            this.navBarControl3.ActiveGroup = this.navBarGroup2;
            this.navBarControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl3.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup2});
            this.navBarControl3.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemAjuda,
            this.navBarItemObervacao,
            this.navBarItemAlterarCarrinho,
            this.navBarItemConsultarProduto});
            this.navBarControl3.Location = new System.Drawing.Point(669, 2);
            this.navBarControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navBarControl3.Name = "navBarControl3";
            this.navBarControl3.OptionsNavPane.ExpandedWidth = 328;
            this.navBarControl3.Size = new System.Drawing.Size(328, 168);
            this.navBarControl3.TabIndex = 0;
            this.navBarControl3.Text = "navBarControl3";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.navBarGroup2.Appearance.Options.UseFont = true;
            this.navBarGroup2.Caption = "Ajuda";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAjuda),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemObervacao),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemAlterarCarrinho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemConsultarProduto)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItemAjuda
            // 
            this.navBarItemAjuda.Caption = "Ctrl + H: Ajuda";
            this.navBarItemAjuda.Name = "navBarItemAjuda";
            this.navBarItemAjuda.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemAjuda.SmallImage")));
            this.navBarItemAjuda.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemAjuda_LinkClicked);
            // 
            // navBarItemObervacao
            // 
            this.navBarItemObervacao.Caption = "O: Observação para Venda";
            this.navBarItemObervacao.Name = "navBarItemObervacao";
            this.navBarItemObervacao.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemObervacao.SmallImage")));
            this.navBarItemObervacao.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemObervacao_LinkClicked);
            // 
            // navBarItemAlterarCarrinho
            // 
            this.navBarItemAlterarCarrinho.Caption = "V: Ver/Editar Carrinho";
            this.navBarItemAlterarCarrinho.Name = "navBarItemAlterarCarrinho";
            this.navBarItemAlterarCarrinho.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemAlterarCarrinho.SmallImage")));
            this.navBarItemAlterarCarrinho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemAlterarCarrinho_LinkClicked);
            // 
            // navBarItemConsultarProduto
            // 
            this.navBarItemConsultarProduto.Caption = "C: Consultar Produto";
            this.navBarItemConsultarProduto.Name = "navBarItemConsultarProduto";
            this.navBarItemConsultarProduto.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemConsultarProduto.SmallImage")));
            this.navBarItemConsultarProduto.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemConsultarProduto_LinkClicked);
            // 
            // tbLayoutPanelPai
            // 
            this.tbLayoutPanelPai.ColumnCount = 1;
            this.tbLayoutPanelPai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayoutPanelPai.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tbLayoutPanelPai.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tbLayoutPanelPai.Controls.Add(this.lblVendedor, 0, 1);
            this.tbLayoutPanelPai.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tbLayoutPanelPai.Controls.Add(this.lblCliente, 0, 0);
            this.tbLayoutPanelPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLayoutPanelPai.Location = new System.Drawing.Point(0, 0);
            this.tbLayoutPanelPai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLayoutPanelPai.Name = "tbLayoutPanelPai";
            this.tbLayoutPanelPai.RowCount = 5;
            this.tbLayoutPanelPai.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbLayoutPanelPai.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbLayoutPanelPai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.12F));
            this.tbLayoutPanelPai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tbLayoutPanelPai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.04F));
            this.tbLayoutPanelPai.Size = new System.Drawing.Size(1006, 695);
            this.tbLayoutPanelPai.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.29851F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.70149F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxControlProdutos, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 50);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1000, 416);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel3.Controls.Add(this.pictureLogo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelControl2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panelControl3, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.panelControl1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(405, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.71856F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.42515F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.35922F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(592, 412);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panelControl2, 2);
            this.panelControl2.Controls.Add(this.txtCodigoBarrasProduto);
            this.panelControl2.Controls.Add(this.barCodeControl1);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(3, 170);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(586, 150);
            this.panelControl2.TabIndex = 7;
            // 
            // txtCodigoBarrasProduto
            // 
            this.txtCodigoBarrasProduto.CaracteresRestritos = new char[0];
            this.txtCodigoBarrasProduto.EditValue = "0000000000";
            this.txtCodigoBarrasProduto.Location = new System.Drawing.Point(40, 57);
            this.txtCodigoBarrasProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoBarrasProduto.Name = "txtCodigoBarrasProduto";
            this.txtCodigoBarrasProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtCodigoBarrasProduto.Properties.Appearance.Options.UseFont = true;
            this.txtCodigoBarrasProduto.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigoBarrasProduto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCodigoBarrasProduto.Properties.MaxLength = 50;
            this.txtCodigoBarrasProduto.Size = new System.Drawing.Size(474, 40);
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Text = "Código de Barras do Produto";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Utilize o leitor de código de barras ou faça uma pesquisa manual pelos critérios " +
    "das colunas da tabela.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.txtCodigoBarrasProduto.SuperTip = superToolTip1;
            this.txtCodigoBarrasProduto.TabIndex = 0;
            this.txtCodigoBarrasProduto.ToolTip = "Código de Barras do Produto";
            this.txtCodigoBarrasProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarrasProduto_KeyPress);
            this.txtCodigoBarrasProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoBarrasProduto_KeyUp);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.lblItens);
            this.panelControl3.Controls.Add(this.picCart);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(459, 324);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(130, 86);
            this.panelControl3.TabIndex = 8;
            // 
            // picCart
            // 
            this.picCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCart.EditValue = global::ITE.Vendas.Properties.Resources.carrinho64x64;
            this.picCart.Location = new System.Drawing.Point(2, 2);
            this.picCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCart.Name = "picCart";
            this.picCart.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picCart.Properties.Appearance.Options.UseBackColor = true;
            this.picCart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picCart.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.picCart.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picCart.Size = new System.Drawing.Size(126, 82);
            this.picCart.TabIndex = 6;
            this.picCart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCarrinho_MouseClick);
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.lblTotalVenda);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 324);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(450, 86);
            this.panelControl1.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.navBarControl4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.navBarControl2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.navBarControl3, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 521);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1000, 172);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.203182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.79681F));
            this.tableLayoutPanel1.Controls.Add(this.lblDescricaoProduto, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 470);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 47);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // lblCliente
            // 
            this.lblCliente.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(3, 2);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(89, 18);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "%Cliente%";
            // 
            // XFrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 695);
            this.Controls.Add(this.tbLayoutPanelPai);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XFrmVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControlProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl3)).EndInit();
            this.tbLayoutPanelPai.ResumeLayout(false);
            this.tbLayoutPanelPai.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoBarrasProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblVendedor;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl lblItens;
        private DevExpress.XtraEditors.LabelControl lblDescricaoProduto;
        private DevExpress.XtraEditors.PictureEdit pictureLogo;
        private DevExpress.XtraNavBar.NavBarControl navBarControl2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupVenda;
        private DevExpress.XtraNavBar.NavBarItem navBarItemCotacao;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAprazo;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAvista;
        private DevExpress.XtraNavBar.NavBarControl navBarControl3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAjuda;
        private DevExpress.XtraNavBar.NavBarItem navBarItemObervacao;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAlterarCarrinho;
        private DevExpress.XtraNavBar.NavBarItem navBarItemConsultarProduto;
        private DevExpress.XtraNavBar.NavBarControl navBarControl4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraEditors.LabelControl lblTotalVenda;
        private DevExpress.XtraEditors.ListBoxControl listBoxControlProdutos;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private System.Windows.Forms.TableLayoutPanel tbLayoutPanelPai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private TextCodigoBarras txtCodigoBarrasProduto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSelecionarCliente;
        private DevExpress.XtraEditors.PictureEdit picCart;
        private DevExpress.XtraNavBar.NavBarItem navBarItemAlterarCentroCusto;
        private DevExpress.XtraEditors.LabelControl lblCliente;
        private DevExpress.XtraNavBar.NavBarItem navBarDadoCpl;
        private System.Windows.Forms.OpenFileDialog openFileLogo;
    }
}