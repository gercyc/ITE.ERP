namespace ITE.Fiscal.CentralFiscal
{
    partial class XFrmPainelNFe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmPainelNFe));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSalvarXml = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewXml = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnAssinarDocumento = new DevExpress.XtraBars.BarButtonItem();
            this.btnEnviaNFe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.nFeEstadualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNfe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChaveAcesso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXmlNfe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusXml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumNf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImgStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoteEnvio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnValidarXml = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFeEstadualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnSalvarXml,
            this.btnViewXml,
            this.btnRefresh,
            this.barButtonItem1,
            this.btnAssinarDocumento,
            this.btnEnviaNFe,
            this.btnValidarXml});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(854, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSalvarXml
            // 
            this.btnSalvarXml.Caption = "Salvar XML";
            this.btnSalvarXml.Id = 1;
            this.btnSalvarXml.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarXml.ImageOptions.Image")));
            this.btnSalvarXml.Name = "btnSalvarXml";
            this.btnSalvarXml.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSalvarXml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalvarXML_ItemClick);
            // 
            // btnViewXml
            // 
            this.btnViewXml.Caption = "Visualizar XML";
            this.btnViewXml.Id = 2;
            this.btnViewXml.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewXml.ImageOptions.Image")));
            this.btnViewXml.Name = "btnViewXml";
            this.btnViewXml.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnViewXml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewXml_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Atualizar";
            this.btnRefresh.Id = 3;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Excluir (temporário)";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnAssinarDocumento
            // 
            this.btnAssinarDocumento.Caption = "Assinar documento";
            this.btnAssinarDocumento.Id = 5;
            this.btnAssinarDocumento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAssinarDocumento.ImageOptions.Image")));
            this.btnAssinarDocumento.Name = "btnAssinarDocumento";
            this.btnAssinarDocumento.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAssinarDocumento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAssinarDocumento_ItemClick);
            // 
            // btnEnviaNFe
            // 
            this.btnEnviaNFe.Caption = "Enviar NFe";
            this.btnEnviaNFe.Id = 6;
            this.btnEnviaNFe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviaNFe.ImageOptions.Image")));
            this.btnEnviaNFe.Name = "btnEnviaNFe";
            this.btnEnviaNFe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipTitleItem2.Text = "Enviar Nota Fiscal Eletrônica";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Envia as notas selecionadas para validação na SEFAZ e recebe o status se o lote f" +
    "oi enviado com sucesso.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnEnviaNFe.SuperTip = superToolTip2;
            this.btnEnviaNFe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEnviaNFe_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operações";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSalvarXml);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnViewXml);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnValidarXml);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAssinarDocumento);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEnviaNFe);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operações";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(854, 31);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nFeEstadualBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(854, 275);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nFeEstadualBindingSource
            // 
            this.nFeEstadualBindingSource.DataSource = typeof(ITE.Entidades.POCO.Fiscal.NFe.NFeEstadual);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNfe,
            this.colIdMovimento,
            this.colChaveAcesso,
            this.colXmlNfe,
            this.colStatusXml,
            this.colMatriz,
            this.colFilial,
            this.colNumNf,
            this.colCliFor,
            this.colTipoMov,
            this.colImgStatus,
            this.colLoteEnvio});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdNfe
            // 
            this.colIdNfe.FieldName = "IdNfe";
            this.colIdNfe.Name = "colIdNfe";
            // 
            // colIdMovimento
            // 
            this.colIdMovimento.FieldName = "IdMovimento";
            this.colIdMovimento.Name = "colIdMovimento";
            // 
            // colChaveAcesso
            // 
            this.colChaveAcesso.Caption = "Chave de Acesso";
            this.colChaveAcesso.FieldName = "ChaveAcesso";
            this.colChaveAcesso.Name = "colChaveAcesso";
            this.colChaveAcesso.Visible = true;
            this.colChaveAcesso.VisibleIndex = 7;
            this.colChaveAcesso.Width = 347;
            // 
            // colXmlNfe
            // 
            this.colXmlNfe.FieldName = "XmlNfe";
            this.colXmlNfe.Name = "colXmlNfe";
            // 
            // colStatusXml
            // 
            this.colStatusXml.Caption = "Status";
            this.colStatusXml.FieldName = "StatusXml";
            this.colStatusXml.Name = "colStatusXml";
            this.colStatusXml.Visible = true;
            this.colStatusXml.VisibleIndex = 2;
            // 
            // colMatriz
            // 
            this.colMatriz.Caption = "Matriz";
            this.colMatriz.FieldName = "Movimento.EmpresaFilial.Matriz.CodigoMatriz";
            this.colMatriz.Name = "colMatriz";
            this.colMatriz.Visible = true;
            this.colMatriz.VisibleIndex = 3;
            // 
            // colFilial
            // 
            this.colFilial.Caption = "Filial";
            this.colFilial.FieldName = "Movimento.EmpresaFilial.CodigoFilial";
            this.colFilial.Name = "colFilial";
            this.colFilial.Visible = true;
            this.colFilial.VisibleIndex = 4;
            // 
            // colNumNf
            // 
            this.colNumNf.Caption = "Número NF";
            this.colNumNf.FieldName = "Movimento.NumeroMovimento";
            this.colNumNf.Name = "colNumNf";
            this.colNumNf.Visible = true;
            this.colNumNf.VisibleIndex = 5;
            // 
            // colCliFor
            // 
            this.colCliFor.Caption = "Destinatário";
            this.colCliFor.FieldName = "Movimento.CliFor.RazaoSocial";
            this.colCliFor.Name = "colCliFor";
            this.colCliFor.Visible = true;
            this.colCliFor.VisibleIndex = 6;
            this.colCliFor.Width = 235;
            // 
            // colTipoMov
            // 
            this.colTipoMov.Caption = "Tipo Mov.";
            this.colTipoMov.FieldName = "Movimento.TipoMovimento.CodigoTipoMovimento";
            this.colTipoMov.Name = "colTipoMov";
            this.colTipoMov.Visible = true;
            this.colTipoMov.VisibleIndex = 8;
            // 
            // colImgStatus
            // 
            this.colImgStatus.Caption = " ";
            this.colImgStatus.FieldName = "ImageStatusNfe";
            this.colImgStatus.Name = "colImgStatus";
            this.colImgStatus.Visible = true;
            this.colImgStatus.VisibleIndex = 1;
            this.colImgStatus.Width = 41;
            // 
            // colLoteEnvio
            // 
            this.colLoteEnvio.Caption = "Lote de Envio";
            this.colLoteEnvio.FieldName = "IdLoteEnvio";
            this.colLoteEnvio.Name = "colLoteEnvio";
            this.colLoteEnvio.Visible = true;
            this.colLoteEnvio.VisibleIndex = 9;
            // 
            // btnValidarXml
            // 
            this.btnValidarXml.Caption = "Validar XML";
            this.btnValidarXml.Id = 7;
            this.btnValidarXml.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnValidarXml.Name = "btnValidarXml";
            this.btnValidarXml.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnValidarXml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnValidarXml_ItemClick);
            // 
            // XFrmPainelNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 449);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "XFrmPainelNFe";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Painel de notas fiscais eletrônicas";
            this.Shown += new System.EventHandler(this.XFrmPainelNFe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFeEstadualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSalvarXml;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nFeEstadualBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNfe;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colChaveAcesso;
        private DevExpress.XtraGrid.Columns.GridColumn colXmlNfe;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusXml;
        private DevExpress.XtraGrid.Columns.GridColumn colMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colNumNf;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMov;
        private DevExpress.XtraBars.BarButtonItem btnViewXml;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnAssinarDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colImgStatus;
        private DevExpress.XtraBars.BarButtonItem btnEnviaNFe;
        private DevExpress.XtraGrid.Columns.GridColumn colLoteEnvio;
        private DevExpress.XtraBars.BarButtonItem btnValidarXml;
    }
}