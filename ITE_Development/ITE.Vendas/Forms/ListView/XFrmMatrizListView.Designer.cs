namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmMatrizListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmMatrizListView));
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnNovaMatriz = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetalhes = new DevExpress.XtraBars.BarButtonItem();
            this.btnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlMatriz = new DevExpress.XtraGrid.GridControl();
            this.bsMatriz = new System.Windows.Forms.BindingSource();
            this.gridViewMatriz = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoMatriz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaFilial = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMatriz)).BeginInit();
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
            this.btnNovaMatriz,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovaMatriz),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDetalhes),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAtualizar)});
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // btnNovaMatriz
            // 
            this.btnNovaMatriz.Caption = "Nova";
            this.btnNovaMatriz.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNovaMatriz.Glyph")));
            this.btnNovaMatriz.Id = 1;
            this.btnNovaMatriz.Name = "btnNovaMatriz";
            this.btnNovaMatriz.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNovaMatriz.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovaMatriz_ItemClick);
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
            this.btnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAtualizar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(771, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 332);
            this.barDockControlBottom.Size = new System.Drawing.Size(771, 21);
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
            this.barDockControlRight.Location = new System.Drawing.Point(771, 45);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 287);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlMatriz);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(771, 287);
            this.panelControl1.TabIndex = 4;
            // 
            // gridControlMatriz
            // 
            this.gridControlMatriz.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlMatriz.DataSource = this.bsMatriz;
            this.gridControlMatriz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMatriz.Location = new System.Drawing.Point(2, 2);
            this.gridControlMatriz.MainView = this.gridViewMatriz;
            this.gridControlMatriz.MenuManager = this.barManager1;
            this.gridControlMatriz.Name = "gridControlMatriz";
            this.gridControlMatriz.Size = new System.Drawing.Size(767, 283);
            this.gridControlMatriz.TabIndex = 0;
            this.gridControlMatriz.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMatriz});
            // 
            // bsMatriz
            // 
            this.bsMatriz.DataSource = typeof(ITE.Entidades.POCO.EmpresaMatriz);
            // 
            // gridViewMatriz
            // 
            this.gridViewMatriz.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMatriz,
            this.colCodigoMatriz,
            this.colEmpresaFilial,
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
            this.gridViewMatriz.GridControl = this.gridControlMatriz;
            this.gridViewMatriz.Name = "gridViewMatriz";
            this.gridViewMatriz.OptionsBehavior.Editable = false;
            this.gridViewMatriz.OptionsView.ShowGroupPanel = false;
            this.gridViewMatriz.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewMatriz_CustomColumnDisplayText);
            this.gridViewMatriz.DoubleClick += new System.EventHandler(this.gridViewMatriz_DoubleClick);
            // 
            // colIdMatriz
            // 
            this.colIdMatriz.FieldName = "IdMatriz";
            this.colIdMatriz.Name = "colIdMatriz";
            this.colIdMatriz.Width = 86;
            // 
            // colCodigoMatriz
            // 
            this.colCodigoMatriz.FieldName = "CodigoMatriz";
            this.colCodigoMatriz.Name = "colCodigoMatriz";
            this.colCodigoMatriz.Visible = true;
            this.colCodigoMatriz.VisibleIndex = 0;
            this.colCodigoMatriz.Width = 99;
            // 
            // colEmpresaFilial
            // 
            this.colEmpresaFilial.FieldName = "EmpresaFilial";
            this.colEmpresaFilial.Name = "colEmpresaFilial";
            this.colEmpresaFilial.Width = 37;
            // 
            // colRazaoSocial
            // 
            this.colRazaoSocial.FieldName = "RazaoSocial";
            this.colRazaoSocial.Name = "colRazaoSocial";
            this.colRazaoSocial.Visible = true;
            this.colRazaoSocial.VisibleIndex = 1;
            this.colRazaoSocial.Width = 294;
            // 
            // colNomeFantasia
            // 
            this.colNomeFantasia.FieldName = "NomeFantasia";
            this.colNomeFantasia.Name = "colNomeFantasia";
            this.colNomeFantasia.Width = 37;
            // 
            // colCnpj
            // 
            this.colCnpj.FieldName = "Cnpj";
            this.colCnpj.Name = "colCnpj";
            this.colCnpj.Visible = true;
            this.colCnpj.VisibleIndex = 2;
            this.colCnpj.Width = 99;
            // 
            // colDtRegtroJuntaCom
            // 
            this.colDtRegtroJuntaCom.FieldName = "DtRegtroJuntaCom";
            this.colDtRegtroJuntaCom.Name = "colDtRegtroJuntaCom";
            this.colDtRegtroJuntaCom.Width = 37;
            // 
            // colDtCadastro
            // 
            this.colDtCadastro.FieldName = "DtCadastro";
            this.colDtCadastro.Name = "colDtCadastro";
            this.colDtCadastro.Width = 37;
            // 
            // colEmailMatriz
            // 
            this.colEmailMatriz.FieldName = "EmailMatriz";
            this.colEmailMatriz.Name = "colEmailMatriz";
            this.colEmailMatriz.Width = 37;
            // 
            // colNomeEndereco
            // 
            this.colNomeEndereco.FieldName = "NomeEndereco";
            this.colNomeEndereco.Name = "colNomeEndereco";
            this.colNomeEndereco.Width = 37;
            // 
            // colNumeroEndereco
            // 
            this.colNumeroEndereco.FieldName = "NumeroEndereco";
            this.colNumeroEndereco.Name = "colNumeroEndereco";
            this.colNumeroEndereco.Width = 37;
            // 
            // colBairro
            // 
            this.colBairro.FieldName = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.Width = 37;
            // 
            // colComplemento
            // 
            this.colComplemento.FieldName = "Complemento";
            this.colComplemento.Name = "colComplemento";
            this.colComplemento.Width = 37;
            // 
            // colCep
            // 
            this.colCep.FieldName = "Cep";
            this.colCep.Name = "colCep";
            this.colCep.Width = 37;
            // 
            // colUf
            // 
            this.colUf.FieldName = "Uf";
            this.colUf.Name = "colUf";
            this.colUf.Visible = true;
            this.colUf.VisibleIndex = 3;
            this.colUf.Width = 99;
            // 
            // colCidade
            // 
            this.colCidade.FieldName = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.Visible = true;
            this.colCidade.VisibleIndex = 4;
            this.colCidade.Width = 105;
            // 
            // colTipoEndereco
            // 
            this.colTipoEndereco.FieldName = "TipoEndereco";
            this.colTipoEndereco.Name = "colTipoEndereco";
            this.colTipoEndereco.Width = 55;
            // 
            // XFrmMatrizListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 353);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XFrmMatrizListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrizes:";
            this.Shown += new System.EventHandler(this.XFrmGerenciarMatriz_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMatriz)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnNovaMatriz;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlMatriz;
        private System.Windows.Forms.BindingSource bsMatriz;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMatriz;
        private DevExpress.XtraBars.BarButtonItem btnDetalhes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoMatriz;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaFilial;
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