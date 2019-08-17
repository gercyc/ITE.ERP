namespace ITE.Fiscal.Movimentacoes
{
    partial class XFrmTransferenciaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmTransferenciaEstoque));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPageOrgDest = new DevExpress.XtraWizard.WizardPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtObsEntrada = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemove = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtObsSaida = new DevExpress.XtraEditors.TextEdit();
            this.lookUpTipoMovimento1 = new ITE.Components.LookUpTipoMovimento();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpMovimento = new System.Windows.Forms.DateTimePicker();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.lookUpLocalEstoqueDestino = new ITE.Components.LookUpLocalEstoque();
            this.lookUpLocalEstoqueOrigem = new ITE.Components.LookUpLocalEstoque();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPageProdutos = new DevExpress.XtraWizard.WizardPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridControlItens = new DevExpress.XtraGrid.GridControl();
            this.gridViewItens = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPageOrgDest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObsEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObsSaida.Properties)).BeginInit();
            this.wizardPageProdutos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItens)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage);
            this.wizardControl1.Controls.Add(this.wizardPageOrgDest);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPageProdutos);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage,
            this.wizardPageOrgDest,
            this.wizardPageProdutos,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(657, 421);
            // 
            // welcomeWizardPage
            // 
            this.welcomeWizardPage.IntroductionText = "Para continuar clique em Next.";
            this.welcomeWizardPage.Name = "welcomeWizardPage";
            this.welcomeWizardPage.ProceedText = "";
            this.welcomeWizardPage.Size = new System.Drawing.Size(440, 288);
            this.welcomeWizardPage.Text = "Transferência entre estoques";
            // 
            // wizardPageOrgDest
            // 
            this.wizardPageOrgDest.Controls.Add(this.labelControl4);
            this.wizardPageOrgDest.Controls.Add(this.labelControl3);
            this.wizardPageOrgDest.Controls.Add(this.txtObsEntrada);
            this.wizardPageOrgDest.Controls.Add(this.txtObsSaida);
            this.wizardPageOrgDest.Controls.Add(this.lookUpTipoMovimento1);
            this.wizardPageOrgDest.Controls.Add(this.labelControl2);
            this.wizardPageOrgDest.Controls.Add(this.labelControl1);
            this.wizardPageOrgDest.Controls.Add(this.dtpMovimento);
            this.wizardPageOrgDest.Controls.Add(this.dtpEmissao);
            this.wizardPageOrgDest.Controls.Add(this.lookUpLocalEstoqueDestino);
            this.wizardPageOrgDest.Controls.Add(this.lookUpLocalEstoqueOrigem);
            this.wizardPageOrgDest.DescriptionText = "Informe os dados dos locais de estoque que serão movimentados";
            this.wizardPageOrgDest.Name = "wizardPageOrgDest";
            this.wizardPageOrgDest.Size = new System.Drawing.Size(625, 276);
            this.wizardPageOrgDest.Text = "Informações Origem X Destino";
            this.wizardPageOrgDest.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPageOrgDest_PageValidating);
            this.wizardPageOrgDest.PageCommit += new System.EventHandler(this.wizardPageOrgDest_PageCommit);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 230);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(194, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Observação para movimento de entrada";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 185);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(181, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Observação para movimento de saída";
            // 
            // txtObsEntrada
            // 
            this.txtObsEntrada.EditValue = "Transferencia entre locais de estoque ENTRADA";
            this.txtObsEntrada.Location = new System.Drawing.Point(13, 249);
            this.txtObsEntrada.MenuManager = this.barManager1;
            this.txtObsEntrada.Name = "txtObsEntrada";
            this.txtObsEntrada.Size = new System.Drawing.Size(398, 20);
            this.txtObsEntrada.TabIndex = 8;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnRemove,
            this.btnAdd});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemove)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Adicionar";
            this.btnAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAdd.Glyph")));
            this.btnAdd.Id = 2;
            this.btnAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnAdd.LargeGlyph")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Caption = "Remover";
            this.btnRemove.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRemove.Glyph")));
            this.btnRemove.Id = 1;
            this.btnRemove.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnRemove.LargeGlyph")));
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemove_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(3, 3);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(619, 29);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(657, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 421);
            this.barDockControlBottom.Size = new System.Drawing.Size(657, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(657, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
            // 
            // txtObsSaida
            // 
            this.txtObsSaida.EditValue = "Transferencia entre locais de estoque SAIDA";
            this.txtObsSaida.Location = new System.Drawing.Point(13, 204);
            this.txtObsSaida.MenuManager = this.barManager1;
            this.txtObsSaida.Name = "txtObsSaida";
            this.txtObsSaida.Size = new System.Drawing.Size(398, 20);
            this.txtObsSaida.TabIndex = 7;
            // 
            // lookUpTipoMovimento1
            // 
            this.lookUpTipoMovimento1.Location = new System.Drawing.Point(13, 15);
            this.lookUpTipoMovimento1.Name = "lookUpTipoMovimento1";
            this.lookUpTipoMovimento1.Size = new System.Drawing.Size(398, 49);
            this.lookUpTipoMovimento1.TabIndex = 6;
            this.lookUpTipoMovimento1.TipoMovimento = null;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(503, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Data movimentação";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(503, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Data emissão";
            // 
            // dtpMovimento
            // 
            this.dtpMovimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMovimento.Location = new System.Drawing.Point(503, 111);
            this.dtpMovimento.Name = "dtpMovimento";
            this.dtpMovimento.Size = new System.Drawing.Size(110, 21);
            this.dtpMovimento.TabIndex = 3;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(503, 55);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(110, 21);
            this.dtpEmissao.TabIndex = 2;
            // 
            // lookUpLocalEstoqueDestino
            // 
            this.lookUpLocalEstoqueDestino.LabelText = "Local de estoque destino";
            this.lookUpLocalEstoqueDestino.LocalEstoque = null;
            this.lookUpLocalEstoqueDestino.Location = new System.Drawing.Point(13, 138);
            this.lookUpLocalEstoqueDestino.Name = "lookUpLocalEstoqueDestino";
            this.lookUpLocalEstoqueDestino.Size = new System.Drawing.Size(398, 47);
            this.lookUpLocalEstoqueDestino.TabIndex = 1;
            // 
            // lookUpLocalEstoqueOrigem
            // 
            this.lookUpLocalEstoqueOrigem.LabelText = "Local de estoque origem";
            this.lookUpLocalEstoqueOrigem.LocalEstoque = null;
            this.lookUpLocalEstoqueOrigem.Location = new System.Drawing.Point(13, 80);
            this.lookUpLocalEstoqueOrigem.Name = "lookUpLocalEstoqueOrigem";
            this.lookUpLocalEstoqueOrigem.Size = new System.Drawing.Size(398, 52);
            this.lookUpLocalEstoqueOrigem.TabIndex = 0;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.FinishText = "Os produtos selecionados foram transferidos";
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.ProceedText = "Para fechar clique em finish";
            this.completionWizardPage1.Size = new System.Drawing.Size(440, 288);
            this.completionWizardPage1.Text = "Sucesso";
            // 
            // wizardPageProdutos
            // 
            this.wizardPageProdutos.Controls.Add(this.tableLayoutPanel1);
            this.wizardPageProdutos.DescriptionText = "Selecione os produtos que deseja transferir";
            this.wizardPageProdutos.Name = "wizardPageProdutos";
            this.wizardPageProdutos.Size = new System.Drawing.Size(625, 276);
            this.wizardPageProdutos.Text = "Seleção de produtos";
            this.wizardPageProdutos.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPageProdutos_PageValidating);
            this.wizardPageProdutos.PageCommit += new System.EventHandler(this.wizardPageProdutos_PageCommit);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.standaloneBarDockControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControlItens, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.68116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.31884F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 276);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControlItens
            // 
            this.gridControlItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlItens.Location = new System.Drawing.Point(3, 38);
            this.gridControlItens.MainView = this.gridViewItens;
            this.gridControlItens.MenuManager = this.barManager1;
            this.gridControlItens.Name = "gridControlItens";
            this.gridControlItens.Size = new System.Drawing.Size(619, 235);
            this.gridControlItens.TabIndex = 1;
            this.gridControlItens.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItens});
            // 
            // gridViewItens
            // 
            this.gridViewItens.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDesc,
            this.colQuantidade});
            this.gridViewItens.GridControl = this.gridControlItens;
            this.gridViewItens.Name = "gridViewItens";
            this.gridViewItens.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "ID Produto";
            this.colId.FieldName = "IdProduto";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 124;
            // 
            // colDesc
            // 
            this.colDesc.Caption = "Descrição";
            this.colDesc.FieldName = "DescricaoProduto";
            this.colDesc.Name = "colDesc";
            this.colDesc.OptionsColumn.AllowEdit = false;
            this.colDesc.Visible = true;
            this.colDesc.VisibleIndex = 1;
            this.colDesc.Width = 340;
            // 
            // colQuantidade
            // 
            this.colQuantidade.Caption = "Quantidade";
            this.colQuantidade.FieldName = "QuantidadeProduto";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 2;
            this.colQuantidade.Width = 137;
            // 
            // XFrmTransferenciaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 421);
            this.Controls.Add(this.wizardControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmTransferenciaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XFrmTransferenciaEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPageOrgDest.ResumeLayout(false);
            this.wizardPageOrgDest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtObsEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObsSaida.Properties)).EndInit();
            this.wizardPageProdutos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage;
        private DevExpress.XtraWizard.WizardPage wizardPageOrgDest;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPageProdutos;
        private Components.LookUpLocalEstoque lookUpLocalEstoqueDestino;
        private Components.LookUpLocalEstoque lookUpLocalEstoqueOrigem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraGrid.GridControl gridControlItens;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItens;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnRemove;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtpMovimento;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private Components.LookUpTipoMovimento lookUpTipoMovimento1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtObsEntrada;
        private DevExpress.XtraEditors.TextEdit txtObsSaida;
    }
}