namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmFilialListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmFilialListView));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNovaFilial = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetalhes = new DevExpress.XtraBars.BarButtonItem();
            this.btnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlFiliais = new DevExpress.XtraGrid.GridControl();
            this.bsFilial = new System.Windows.Forms.BindingSource();
            this.gridViewFiliais = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresaMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInscricaoSuframa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInscricaoEstadual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefoneComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazaoSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeFantasia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCnpj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtRegtroJuntaCom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDtCadastro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmailMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBairro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComplemento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoEndereco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsMatriz = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiliais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFilial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiliais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatriz)).BeginInit();
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
            this.btnAtualizar,
            this.btnNovaFilial,
            this.btnDetalhes});
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovaFilial),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetalhes),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAtualizar)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnNovaFilial
            // 
            this.btnNovaFilial.Caption = "Nova";
            this.btnNovaFilial.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovaFilial.Glyph")));
            this.btnNovaFilial.Id = 1;
            this.btnNovaFilial.Name = "btnNovaFilial";
            this.btnNovaFilial.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNovaFilial.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovaFilial_ItemClick);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Caption = "Detalhes";
            this.btnDetalhes.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDetalhes.Glyph")));
            this.btnDetalhes.Id = 2;
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDetalhes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetalhes_ItemClick);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Caption = "Atualizar";
            this.btnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Glyph")));
            this.btnAtualizar.Id = 0;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusProduto bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusProduto bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(759, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 332);
            this.barDockControlBottom.Size = new System.Drawing.Size(759, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 287);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(759, 45);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 287);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlFiliais);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(759, 287);
            this.panelControl1.TabIndex = 4;
            // 
            // gridControlFiliais
            // 
            this.gridControlFiliais.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlFiliais.DataSource = this.bsFilial;
            this.gridControlFiliais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFiliais.Location = new System.Drawing.Point(2, 2);
            this.gridControlFiliais.MainView = this.gridViewFiliais;
            this.gridControlFiliais.MenuManager = this.barManager1;
            this.gridControlFiliais.Name = "gridControlFiliais";
            this.gridControlFiliais.Size = new System.Drawing.Size(755, 283);
            this.gridControlFiliais.TabIndex = 0;
            this.gridControlFiliais.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFiliais});
            // 
            // bsFilial
            // 
            this.bsFilial.DataSource = typeof(ITE.Entidades.POCO.EmpresaFilial);
            // 
            // gridViewFiliais
            // 
            this.gridViewFiliais.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFilial,
            this.colIdEmpresaMatriz,
            this.colCodigoFilial,
            this.colInscricaoSuframa,
            this.colInscricaoEstadual,
            this.colTelefoneComercial,
            this.colFax,
            this.colMatriz,
            this.colRazaoSocial,
            this.colNomeFantasia,
            this.colCnpj,
            this.colDtRegtroJuntaCom,
            this.colDtCadastro,
            this.colEmailMatriz,
            this.colNomeEndereco,
            this.colNumeroEndereco,
            this.colBairro,
            this.colComplemento,
            this.colCep,
            this.colUf,
            this.colCidade,
            this.colTipoEndereco});
            this.gridViewFiliais.GridControl = this.gridControlFiliais;
            this.gridViewFiliais.Name = "gridViewFiliais";
            this.gridViewFiliais.OptionsBehavior.Editable = false;
            this.gridViewFiliais.OptionsView.ShowGroupPanel = false;
            this.gridViewFiliais.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewFiliais_CustomColumnDisplayText);
            // 
            // colIdFilial
            // 
            this.colIdFilial.FieldName = "IdFilial";
            this.colIdFilial.Name = "colIdFilial";
            // 
            // colIdEmpresaMatriz
            // 
            this.colIdEmpresaMatriz.FieldName = "Matriz.CodigoMatriz";
            this.colIdEmpresaMatriz.Name = "colIdEmpresaMatriz";
            this.colIdEmpresaMatriz.Visible = true;
            this.colIdEmpresaMatriz.VisibleIndex = 0;
            this.colIdEmpresaMatriz.Width = 129;
            // 
            // colCodigoFilial
            // 
            this.colCodigoFilial.FieldName = "CodigoFilial";
            this.colCodigoFilial.Name = "colCodigoFilial";
            this.colCodigoFilial.Visible = true;
            this.colCodigoFilial.VisibleIndex = 1;
            this.colCodigoFilial.Width = 110;
            // 
            // colInscricaoSuframa
            // 
            this.colInscricaoSuframa.FieldName = "InscricaoSuframa";
            this.colInscricaoSuframa.Name = "colInscricaoSuframa";
            // 
            // colInscricaoEstadual
            // 
            this.colInscricaoEstadual.FieldName = "InscricaoEstadual";
            this.colInscricaoEstadual.Name = "colInscricaoEstadual";
            // 
            // colTelefoneComercial
            // 
            this.colTelefoneComercial.FieldName = "TelefoneComercial";
            this.colTelefoneComercial.Name = "colTelefoneComercial";
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            // 
            // colMatriz
            // 
            this.colMatriz.FieldName = "Matriz";
            this.colMatriz.Name = "colMatriz";
            // 
            // colRazaoSocial
            // 
            this.colRazaoSocial.FieldName = "RazaoSocial";
            this.colRazaoSocial.Name = "colRazaoSocial";
            this.colRazaoSocial.Visible = true;
            this.colRazaoSocial.VisibleIndex = 2;
            this.colRazaoSocial.Width = 252;
            // 
            // colNomeFantasia
            // 
            this.colNomeFantasia.FieldName = "NomeFantasia";
            this.colNomeFantasia.Name = "colNomeFantasia";
            // 
            // colCnpj
            // 
            this.colCnpj.Caption = "CNPJ";
            this.colCnpj.FieldName = "Cnpj";
            this.colCnpj.Name = "colCnpj";
            this.colCnpj.Visible = true;
            this.colCnpj.VisibleIndex = 3;
            this.colCnpj.Width = 160;
            // 
            // colDtRegtroJuntaCom
            // 
            this.colDtRegtroJuntaCom.FieldName = "DtRegtroJuntaCom";
            this.colDtRegtroJuntaCom.Name = "colDtRegtroJuntaCom";
            // 
            // colDtCadastro
            // 
            this.colDtCadastro.FieldName = "DtCadastro";
            this.colDtCadastro.Name = "colDtCadastro";
            // 
            // colEmailMatriz
            // 
            this.colEmailMatriz.FieldName = "EmailMatriz";
            this.colEmailMatriz.Name = "colEmailMatriz";
            // 
            // colNomeEndereco
            // 
            this.colNomeEndereco.FieldName = "NomeEndereco";
            this.colNomeEndereco.Name = "colNomeEndereco";
            // 
            // colNumeroEndereco
            // 
            this.colNumeroEndereco.FieldName = "NumeroEndereco";
            this.colNumeroEndereco.Name = "colNumeroEndereco";
            // 
            // colBairro
            // 
            this.colBairro.FieldName = "Bairro";
            this.colBairro.Name = "colBairro";
            // 
            // colComplemento
            // 
            this.colComplemento.FieldName = "Complemento";
            this.colComplemento.Name = "colComplemento";
            // 
            // colCep
            // 
            this.colCep.FieldName = "Cep";
            this.colCep.Name = "colCep";
            // 
            // colUf
            // 
            this.colUf.Caption = "UF";
            this.colUf.FieldName = "Uf";
            this.colUf.Name = "colUf";
            this.colUf.Visible = true;
            this.colUf.VisibleIndex = 5;
            this.colUf.Width = 74;
            // 
            // colCidade
            // 
            this.colCidade.FieldName = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.Visible = true;
            this.colCidade.VisibleIndex = 4;
            this.colCidade.Width = 136;
            // 
            // colTipoEndereco
            // 
            this.colTipoEndereco.FieldName = "TipoEndereco";
            this.colTipoEndereco.Name = "colTipoEndereco";
            // 
            // bsMatriz
            // 
            this.bsMatriz.DataSource = typeof(ITE.Entidades.POCO.EmpresaMatriz);
            // 
            // XFrmFilialListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 353);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmFilialListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filiais:";
            this.Shown += new System.EventHandler(this.XGrmGerenciarFilial_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFiliais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFilial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFiliais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatriz)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnAtualizar;
        private DevExpress.XtraBars.BarButtonItem btnNovaFilial;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlFiliais;
        private System.Windows.Forms.BindingSource bsMatriz;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFiliais;
        private System.Windows.Forms.BindingSource bsFilial;
        private DevExpress.XtraBars.BarButtonItem btnDetalhes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresaMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colInscricaoSuframa;
        private DevExpress.XtraGrid.Columns.GridColumn colInscricaoEstadual;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefoneComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colRazaoSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeFantasia;
        private DevExpress.XtraGrid.Columns.GridColumn colCnpj;
        private DevExpress.XtraGrid.Columns.GridColumn colDtRegtroJuntaCom;
        private DevExpress.XtraGrid.Columns.GridColumn colDtCadastro;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEndereco;
        private DevExpress.XtraGrid.Columns.GridColumn colBairro;
        private DevExpress.XtraGrid.Columns.GridColumn colComplemento;
        private DevExpress.XtraGrid.Columns.GridColumn colCep;
        private DevExpress.XtraGrid.Columns.GridColumn colUf;
        private DevExpress.XtraGrid.Columns.GridColumn colCidade;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoEndereco;
    }
}