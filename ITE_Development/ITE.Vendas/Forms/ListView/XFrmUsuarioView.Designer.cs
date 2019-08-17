namespace ITE.Vendas.Forms.ListView
{
    partial class XFrmUsuarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmUsuarioView));
            this.gridControlUsuario = new DevExpress.XtraGrid.GridControl();
            this.bsUsuario = new System.Windows.Forms.BindingSource();
            this.gridViewUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompetencias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLancamentosCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLancamentosRecModifyBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsGerente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomeUtilizador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSenha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConfirmarSenha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataInclusao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSkin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barBtnNovo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAlterar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnGrupo = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAtualizar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlUsuario
            // 
            this.gridControlUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlUsuario.DataSource = this.bsUsuario;
            this.gridControlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUsuario.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlUsuario.Location = new System.Drawing.Point(0, 144);
            this.gridControlUsuario.MainView = this.gridViewUsuarios;
            this.gridControlUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControlUsuario.Name = "gridControlUsuario";
            this.gridControlUsuario.Size = new System.Drawing.Size(800, 248);
            this.gridControlUsuario.TabIndex = 1;
            this.gridControlUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsuarios});
            // 
            // bsUsuario
            // 
            this.bsUsuario.DataSource = typeof(ITE.Entidades.POCO.Usuario);
            // 
            // gridViewUsuarios
            // 
            this.gridViewUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUsuario,
            this.colIdGrupoUsuario,
            this.colGrupoUsuario,
            this.colVenda,
            this.colCompetencias,
            this.colLancamentosCreatedBy,
            this.colLancamentosRecModifyBy,
            this.colIsGerente,
            this.colIsAdmin,
            this.colIsVendedor,
            this.colNomeUsuario,
            this.colNomeUtilizador,
            this.colSenha,
            this.colConfirmarSenha,
            this.colDataInclusao,
            this.colSkin});
            this.gridViewUsuarios.GridControl = this.gridControlUsuario;
            this.gridViewUsuarios.Name = "gridViewUsuarios";
            this.gridViewUsuarios.OptionsBehavior.Editable = false;
            this.gridViewUsuarios.OptionsView.ShowGroupPanel = false;
            this.gridViewUsuarios.DoubleClick += new System.EventHandler(this.gridViewUsuarios_DoubleClick);
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colIdUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdUsuario.Caption = "ID";
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 0;
            this.colIdUsuario.Width = 48;
            // 
            // colIdGrupoUsuario
            // 
            this.colIdGrupoUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colIdGrupoUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdGrupoUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdGrupoUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdGrupoUsuario.FieldName = "IdGrupoUsuario";
            this.colIdGrupoUsuario.Name = "colIdGrupoUsuario";
            // 
            // colGrupoUsuario
            // 
            this.colGrupoUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colGrupoUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colGrupoUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colGrupoUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colGrupoUsuario.FieldName = "GrupoUsuario";
            this.colGrupoUsuario.Name = "colGrupoUsuario";
            this.colGrupoUsuario.Visible = true;
            this.colGrupoUsuario.VisibleIndex = 4;
            this.colGrupoUsuario.Width = 115;
            // 
            // colVenda
            // 
            this.colVenda.AppearanceCell.Options.UseTextOptions = true;
            this.colVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.colVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colVenda.FieldName = "Venda";
            this.colVenda.Name = "colVenda";
            // 
            // colCompetencias
            // 
            this.colCompetencias.AppearanceCell.Options.UseTextOptions = true;
            this.colCompetencias.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCompetencias.AppearanceHeader.Options.UseTextOptions = true;
            this.colCompetencias.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCompetencias.FieldName = "Competencias";
            this.colCompetencias.Name = "colCompetencias";
            // 
            // colLancamentosCreatedBy
            // 
            this.colLancamentosCreatedBy.AppearanceCell.Options.UseTextOptions = true;
            this.colLancamentosCreatedBy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colLancamentosCreatedBy.AppearanceHeader.Options.UseTextOptions = true;
            this.colLancamentosCreatedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colLancamentosCreatedBy.FieldName = "LancamentosCreatedBy";
            this.colLancamentosCreatedBy.Name = "colLancamentosCreatedBy";
            // 
            // colLancamentosRecModifyBy
            // 
            this.colLancamentosRecModifyBy.AppearanceCell.Options.UseTextOptions = true;
            this.colLancamentosRecModifyBy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colLancamentosRecModifyBy.AppearanceHeader.Options.UseTextOptions = true;
            this.colLancamentosRecModifyBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colLancamentosRecModifyBy.FieldName = "LancamentosRecModifyBy";
            this.colLancamentosRecModifyBy.Name = "colLancamentosRecModifyBy";
            // 
            // colIsGerente
            // 
            this.colIsGerente.AppearanceCell.Options.UseTextOptions = true;
            this.colIsGerente.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIsGerente.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsGerente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIsGerente.Caption = "Gerente";
            this.colIsGerente.FieldName = "IsGerente";
            this.colIsGerente.Name = "colIsGerente";
            this.colIsGerente.OptionsColumn.ReadOnly = true;
            this.colIsGerente.Width = 52;
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.AppearanceCell.Options.UseTextOptions = true;
            this.colIsAdmin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIsAdmin.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsAdmin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIsAdmin.Caption = "Privilégio Adm";
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.OptionsColumn.ReadOnly = true;
            this.colIsAdmin.Visible = true;
            this.colIsAdmin.VisibleIndex = 6;
            this.colIsAdmin.Width = 95;
            // 
            // colIsVendedor
            // 
            this.colIsVendedor.AppearanceCell.Options.UseTextOptions = true;
            this.colIsVendedor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIsVendedor.AppearanceHeader.Options.UseTextOptions = true;
            this.colIsVendedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIsVendedor.Caption = "Vendedor";
            this.colIsVendedor.FieldName = "IsVendedor";
            this.colIsVendedor.Name = "colIsVendedor";
            this.colIsVendedor.OptionsColumn.ReadOnly = true;
            this.colIsVendedor.Width = 44;
            // 
            // colNomeUsuario
            // 
            this.colNomeUsuario.AppearanceCell.Options.UseTextOptions = true;
            this.colNomeUsuario.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeUsuario.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeUsuario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeUsuario.Caption = "Nome do Usuário";
            this.colNomeUsuario.FieldName = "NomeUsuario";
            this.colNomeUsuario.Name = "colNomeUsuario";
            this.colNomeUsuario.Visible = true;
            this.colNomeUsuario.VisibleIndex = 1;
            this.colNomeUsuario.Width = 166;
            // 
            // colNomeUtilizador
            // 
            this.colNomeUtilizador.AppearanceCell.Options.UseTextOptions = true;
            this.colNomeUtilizador.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeUtilizador.AppearanceHeader.Options.UseTextOptions = true;
            this.colNomeUtilizador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNomeUtilizador.Caption = "Nome Acesso";
            this.colNomeUtilizador.FieldName = "NomeUtilizador";
            this.colNomeUtilizador.Name = "colNomeUtilizador";
            this.colNomeUtilizador.Visible = true;
            this.colNomeUtilizador.VisibleIndex = 2;
            this.colNomeUtilizador.Width = 112;
            // 
            // colSenha
            // 
            this.colSenha.AppearanceCell.Options.UseTextOptions = true;
            this.colSenha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSenha.AppearanceHeader.Options.UseTextOptions = true;
            this.colSenha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSenha.FieldName = "Senha";
            this.colSenha.Name = "colSenha";
            // 
            // colConfirmarSenha
            // 
            this.colConfirmarSenha.AppearanceCell.Options.UseTextOptions = true;
            this.colConfirmarSenha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colConfirmarSenha.AppearanceHeader.Options.UseTextOptions = true;
            this.colConfirmarSenha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colConfirmarSenha.FieldName = "ConfirmarSenha";
            this.colConfirmarSenha.Name = "colConfirmarSenha";
            // 
            // colDataInclusao
            // 
            this.colDataInclusao.AppearanceCell.Options.UseTextOptions = true;
            this.colDataInclusao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataInclusao.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataInclusao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataInclusao.Caption = "Data Inclusão";
            this.colDataInclusao.FieldName = "DataInclusao";
            this.colDataInclusao.Name = "colDataInclusao";
            this.colDataInclusao.Visible = true;
            this.colDataInclusao.VisibleIndex = 3;
            this.colDataInclusao.Width = 112;
            // 
            // colSkin
            // 
            this.colSkin.AppearanceCell.Options.UseTextOptions = true;
            this.colSkin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSkin.AppearanceHeader.Options.UseTextOptions = true;
            this.colSkin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSkin.Caption = "Software Skin";
            this.colSkin.FieldName = "Skin";
            this.colSkin.Name = "colSkin";
            this.colSkin.Visible = true;
            this.colSkin.VisibleIndex = 5;
            this.colSkin.Width = 265;
            // 
            // barBtnNovo
            // 
            this.barBtnNovo.Caption = "Novo";
            this.barBtnNovo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnNovo.Glyph")));
            this.barBtnNovo.Id = 0;
            this.barBtnNovo.Name = "barBtnNovo";
            this.barBtnNovo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnNovo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnNovo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNovo_ItemClick);
            // 
            // barBtnAlterar
            // 
            this.barBtnAlterar.Caption = "Alterar";
            this.barBtnAlterar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterar.Glyph")));
            this.barBtnAlterar.Id = 1;
            this.barBtnAlterar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnAlterar.LargeGlyph")));
            this.barBtnAlterar.Name = "barBtnAlterar";
            this.barBtnAlterar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAlterar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAlterar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlterar_ItemClick);
            // 
            // barBtnGrupo
            // 
            this.barBtnGrupo.Caption = "Grupos";
            this.barBtnGrupo.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnGrupo.Glyph")));
            this.barBtnGrupo.Id = 3;
            this.barBtnGrupo.Name = "barBtnGrupo";
            this.barBtnGrupo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnGrupo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnGrupo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnGrupo_ItemClick);
            // 
            // barBtnAtualizar
            // 
            this.barBtnAtualizar.Caption = "Atualizar";
            this.barBtnAtualizar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.Glyph")));
            this.barBtnAtualizar.Id = 2;
            this.barBtnAtualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barBtnAtualizar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnAtualizar.LargeGlyph")));
            this.barBtnAtualizar.Name = "barBtnAtualizar";
            this.barBtnAtualizar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnAtualizar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAtualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAtualizar_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnNovo,
            this.barBtnAlterar,
            this.barBtnAtualizar,
            this.barBtnGrupo});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menu";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnNovo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAlterar);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnGrupo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAtualizar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Opções";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 392);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(800, 32);
            // 
            // XFrmUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.gridControlUsuario);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XFrmUsuarioView";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Usuários do Sistema:";
            this.Shown += new System.EventHandler(this.XFrmGerenciarUsuario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsuarios;
        private System.Windows.Forms.BindingSource bsUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNomeUtilizador;
        private DevExpress.XtraGrid.Columns.GridColumn colSenha;
        private DevExpress.XtraGrid.Columns.GridColumn colDataInclusao;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoUsuario;
        private DevExpress.XtraBars.BarButtonItem barBtnNovo;
        private DevExpress.XtraBars.BarButtonItem barBtnAlterar;
        private DevExpress.XtraBars.BarButtonItem barBtnAtualizar;
        private DevExpress.XtraBars.BarButtonItem barBtnGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colCompetencias;
        private DevExpress.XtraGrid.Columns.GridColumn colLancamentosCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colLancamentosRecModifyBy;
        private DevExpress.XtraGrid.Columns.GridColumn colIsGerente;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colIsVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colConfirmarSenha;
        private DevExpress.XtraGrid.Columns.GridColumn colSkin;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    }
}