namespace ITE.RH.Forms.Folha
{
    partial class XFrmMovimentoCompetencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmMovimentoCompetencia));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnLancarEvento = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRemoveEvento = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRecalculoFolha = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControlComp = new DevExpress.XtraEditors.GroupControl();
            this.lblTotalFolha = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbCompSelect = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlFuncs = new DevExpress.XtraEditors.GroupControl();
            this.lstFuncionarios = new DevExpress.XtraEditors.ListBoxControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbTotalLiquido = new DevExpress.XtraEditors.LabelControl();
            this.lbTotalDescontos = new DevExpress.XtraEditors.LabelControl();
            this.lbTotalBruto = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlFicFin = new DevExpress.XtraEditors.GroupControl();
            this.gridControlFichaFinanceira = new DevExpress.XtraGrid.GridControl();
            this.gridViewFichaFinanceira = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorMovimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsFichaFinaceiraFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.bsFuncionarioCompetencia = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlComp)).BeginInit();
            this.groupControlComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFuncs)).BeginInit();
            this.groupControlFuncs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstFuncionarios)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFicFin)).BeginInit();
            this.groupControlFicFin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFichaFinanceira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFichaFinanceira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFichaFinaceiraFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioCompetencia)).BeginInit();
            this.SuspendLayout();
            // 
            // colTipo
            // 
            this.colTipo.Caption = "Tipo";
            this.colTipo.FieldName = "Evento.TipoEvento";
            this.colTipo.Name = "colTipo";
            this.colTipo.OptionsColumn.AllowEdit = false;
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 4;
            this.colTipo.Width = 115;
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
            this.barBtnLancarEvento,
            this.barBtnRemoveEvento,
            this.barBtnRecalculoFolha,
            this.btnSalvar,
            this.barBtnCancelar});
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnLancarEvento),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRemoveEvento),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalvar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnRecalculoFolha),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnCancelar)});
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.Text = "Tools";
            // 
            // barBtnLancarEvento
            // 
            this.barBtnLancarEvento.Caption = "Lançar evento";
            this.barBtnLancarEvento.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnLancarEvento.Glyph")));
            this.barBtnLancarEvento.Id = 0;
            this.barBtnLancarEvento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnLancarEvento.LargeGlyph")));
            this.barBtnLancarEvento.Name = "barBtnLancarEvento";
            this.barBtnLancarEvento.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnLancarEvento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLancarEvento_ItemClick);
            // 
            // barBtnRemoveEvento
            // 
            this.barBtnRemoveEvento.Caption = "Remover Evento";
            this.barBtnRemoveEvento.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRemoveEvento.Glyph")));
            this.barBtnRemoveEvento.Id = 1;
            this.barBtnRemoveEvento.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnRemoveEvento.LargeGlyph")));
            this.barBtnRemoveEvento.Name = "barBtnRemoveEvento";
            this.barBtnRemoveEvento.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnRemoveEvento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRemoveEvento_ItemClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Caption = "Salvar alterações";
            this.btnSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Glyph")));
            this.btnSalvar.Id = 5;
            this.btnSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSalvar.LargeGlyph")));
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalvar_ItemClick);
            // 
            // barBtnRecalculoFolha
            // 
            this.barBtnRecalculoFolha.Caption = "Recálculo da folha";
            this.barBtnRecalculoFolha.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnRecalculoFolha.Glyph")));
            this.barBtnRecalculoFolha.Id = 4;
            this.barBtnRecalculoFolha.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnRecalculoFolha.LargeGlyph")));
            this.barBtnRecalculoFolha.Name = "barBtnRecalculoFolha";
            this.barBtnRecalculoFolha.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnRecalculoFolha.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barBtnCancelar
            // 
            this.barBtnCancelar.Caption = "Cancelar";
            this.barBtnCancelar.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.Glyph")));
            this.barBtnCancelar.Id = 7;
            this.barBtnCancelar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnCancelar.LargeGlyph")));
            this.barBtnCancelar.Name = "barBtnCancelar";
            this.barBtnCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barBtnCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCancelar_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(994, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Size = new System.Drawing.Size(994, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 407);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(994, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 407);
            // 
            // groupControlComp
            // 
            this.groupControlComp.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupControlComp.AppearanceCaption.Options.UseFont = true;
            this.groupControlComp.Controls.Add(this.lblTotalFolha);
            this.groupControlComp.Controls.Add(this.labelControl5);
            this.groupControlComp.Controls.Add(this.lbCompSelect);
            this.groupControlComp.Controls.Add(this.labelControl1);
            this.groupControlComp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlComp.Location = new System.Drawing.Point(0, 0);
            this.groupControlComp.Name = "groupControlComp";
            this.groupControlComp.Size = new System.Drawing.Size(994, 59);
            this.groupControlComp.TabIndex = 5;
            this.groupControlComp.Text = "Competência:";
            // 
            // lblTotalFolha
            // 
            this.lblTotalFolha.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalFolha.Location = new System.Drawing.Point(633, 32);
            this.lblTotalFolha.Name = "lblTotalFolha";
            this.lblTotalFolha.Size = new System.Drawing.Size(20, 14);
            this.lblTotalFolha.TabIndex = 3;
            this.lblTotalFolha.Text = "0,0";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(509, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(118, 14);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Total Salarial Folha:";
            // 
            // lbCompSelect
            // 
            this.lbCompSelect.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompSelect.Location = new System.Drawing.Point(183, 32);
            this.lbCompSelect.Name = "lbCompSelect";
            this.lbCompSelect.Size = new System.Drawing.Size(14, 14);
            this.lbCompSelect.TabIndex = 1;
            this.lbCompSelect.Text = "%";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(11, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(159, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Competência Selecionada:";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControlComp);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(994, 407);
            this.splitContainerControl2.SplitterPosition = 59;
            this.splitContainerControl2.TabIndex = 7;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControlFuncs);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(994, 343);
            this.splitContainerControl1.SplitterPosition = 415;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControlFuncs
            // 
            this.groupControlFuncs.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupControlFuncs.AppearanceCaption.Options.UseFont = true;
            this.groupControlFuncs.Controls.Add(this.lstFuncionarios);
            this.groupControlFuncs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlFuncs.Location = new System.Drawing.Point(0, 0);
            this.groupControlFuncs.Name = "groupControlFuncs";
            this.groupControlFuncs.Size = new System.Drawing.Size(415, 343);
            this.groupControlFuncs.TabIndex = 0;
            this.groupControlFuncs.Text = "Funcionários";
            // 
            // lstFuncionarios
            // 
            this.lstFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFuncionarios.Location = new System.Drawing.Point(2, 21);
            this.lstFuncionarios.Name = "lstFuncionarios";
            this.lstFuncionarios.Size = new System.Drawing.Size(411, 320);
            this.lstFuncionarios.TabIndex = 0;
            this.lstFuncionarios.SelectedIndexChanged += new System.EventHandler(this.lstFuncionarios_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupControlFicFin, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.69617F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.30383F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 343);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lbTotalLiquido);
            this.groupControl1.Controls.Add(this.lbTotalDescontos);
            this.groupControl1.Controls.Add(this.lbTotalBruto);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(3, 266);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(568, 74);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Totailizadores:";
            // 
            // lbTotalLiquido
            // 
            this.lbTotalLiquido.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbTotalLiquido.Location = new System.Drawing.Point(494, 37);
            this.lbTotalLiquido.Name = "lbTotalLiquido";
            this.lbTotalLiquido.Size = new System.Drawing.Size(70, 14);
            this.lbTotalLiquido.TabIndex = 5;
            this.lbTotalLiquido.Text = "%tot_liquido";
            // 
            // lbTotalDescontos
            // 
            this.lbTotalDescontos.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbTotalDescontos.Location = new System.Drawing.Point(286, 37);
            this.lbTotalDescontos.Name = "lbTotalDescontos";
            this.lbTotalDescontos.Size = new System.Drawing.Size(92, 14);
            this.lbTotalDescontos.TabIndex = 4;
            this.lbTotalDescontos.Text = "%tot_descontos";
            // 
            // lbTotalBruto
            // 
            this.lbTotalBruto.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbTotalBruto.Location = new System.Drawing.Point(87, 37);
            this.lbTotalBruto.Name = "lbTotalBruto";
            this.lbTotalBruto.Size = new System.Drawing.Size(66, 14);
            this.lbTotalBruto.TabIndex = 3;
            this.lbTotalBruto.Text = "%tot_bruto";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(402, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 14);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Total Líquido:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(175, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 14);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Total Descontos:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(6, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Total Bruto:";
            // 
            // groupControlFicFin
            // 
            this.groupControlFicFin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlFicFin.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupControlFicFin.AppearanceCaption.Options.UseFont = true;
            this.groupControlFicFin.Controls.Add(this.gridControlFichaFinanceira);
            this.groupControlFicFin.Location = new System.Drawing.Point(3, 3);
            this.groupControlFicFin.Name = "groupControlFicFin";
            this.groupControlFicFin.Size = new System.Drawing.Size(568, 257);
            this.groupControlFicFin.TabIndex = 1;
            this.groupControlFicFin.Text = "Ficha financeira";
            // 
            // gridControlFichaFinanceira
            // 
            this.gridControlFichaFinanceira.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFichaFinanceira.Location = new System.Drawing.Point(2, 21);
            this.gridControlFichaFinanceira.MainView = this.gridViewFichaFinanceira;
            this.gridControlFichaFinanceira.MenuManager = this.barManager1;
            this.gridControlFichaFinanceira.Name = "gridControlFichaFinanceira";
            this.gridControlFichaFinanceira.Size = new System.Drawing.Size(564, 234);
            this.gridControlFichaFinanceira.TabIndex = 1;
            this.gridControlFichaFinanceira.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFichaFinanceira});
            // 
            // gridViewFichaFinanceira
            // 
            this.gridViewFichaFinanceira.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEvento,
            this.colEvento,
            this.colQuantidade,
            this.colValorMovimento,
            this.colTipo});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colTipo;
            gridFormatRule1.Name = "Proventos";
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Blue;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[Evento.TipoEvento] = \'Provento\'";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Descontos";
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "[Evento.TipoEvento] = \'Desconto\'";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "BaseCalculo";
            formatConditionRuleExpression3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            formatConditionRuleExpression3.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression3.Expression = "[Evento.TipoEvento] = \'BaseCalculo\'";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            this.gridViewFichaFinanceira.FormatRules.Add(gridFormatRule1);
            this.gridViewFichaFinanceira.FormatRules.Add(gridFormatRule2);
            this.gridViewFichaFinanceira.FormatRules.Add(gridFormatRule3);
            this.gridViewFichaFinanceira.GridControl = this.gridControlFichaFinanceira;
            this.gridViewFichaFinanceira.Name = "gridViewFichaFinanceira";
            this.gridViewFichaFinanceira.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewFichaFinanceira.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewFichaFinanceira.OptionsView.ShowGroupPanel = false;
            this.gridViewFichaFinanceira.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewFichaFinanceira_KeyDown);
            // 
            // colIdEvento
            // 
            this.colIdEvento.Caption = "Código Evento";
            this.colIdEvento.FieldName = "Evento.CodigoEvento";
            this.colIdEvento.Name = "colIdEvento";
            this.colIdEvento.OptionsColumn.AllowEdit = false;
            this.colIdEvento.Visible = true;
            this.colIdEvento.VisibleIndex = 0;
            this.colIdEvento.Width = 86;
            // 
            // colEvento
            // 
            this.colEvento.Caption = "Descrição Evento";
            this.colEvento.FieldName = "Evento.DescricaoEvento";
            this.colEvento.Name = "colEvento";
            this.colEvento.OptionsColumn.AllowEdit = false;
            this.colEvento.Visible = true;
            this.colEvento.VisibleIndex = 1;
            this.colEvento.Width = 200;
            // 
            // colQuantidade
            // 
            this.colQuantidade.Caption = "Quantidade";
            this.colQuantidade.FieldName = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.OptionsColumn.AllowEdit = false;
            this.colQuantidade.Visible = true;
            this.colQuantidade.VisibleIndex = 2;
            this.colQuantidade.Width = 85;
            // 
            // colValorMovimento
            // 
            this.colValorMovimento.DisplayFormat.FormatString = "N2";
            this.colValorMovimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorMovimento.FieldName = "ValorMovimento";
            this.colValorMovimento.Name = "colValorMovimento";
            this.colValorMovimento.Visible = true;
            this.colValorMovimento.VisibleIndex = 3;
            this.colValorMovimento.Width = 98;
            // 
            // bsFichaFinaceiraFuncionario
            // 
            this.bsFichaFinaceiraFuncionario.DataSource = typeof(ITE.Entidades.POCO.RH.Folha.FichaFinanceiraFuncionario);
            // 
            // bsFuncionarioCompetencia
            // 
            this.bsFuncionarioCompetencia.DataSource = typeof(ITE.Entidades.POCO.RH.Folha.FuncionarioCompetencia);
            // 
            // XFrmMovimentoCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 461);
            this.Controls.Add(this.splitContainerControl2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "XFrmMovimentoCompetencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competências";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlComp)).EndInit();
            this.groupControlComp.ResumeLayout(false);
            this.groupControlComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFuncs)).EndInit();
            this.groupControlFuncs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstFuncionarios)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlFicFin)).EndInit();
            this.groupControlFicFin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFichaFinanceira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFichaFinanceira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFichaFinaceiraFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarioCompetencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnLancarEvento;
        private DevExpress.XtraBars.BarButtonItem barBtnRemoveEvento;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControlComp;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControlFuncs;
        private DevExpress.XtraEditors.ListBoxControl lstFuncionarios;
        private DevExpress.XtraEditors.GroupControl groupControlFicFin;
        private DevExpress.XtraGrid.GridControl gridControlFichaFinanceira;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFichaFinanceira;
        private System.Windows.Forms.BindingSource bsFuncionarioCompetencia;
        private System.Windows.Forms.BindingSource bsFichaFinaceiraFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorMovimento;
        private DevExpress.XtraGrid.Columns.GridColumn colEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private DevExpress.XtraEditors.LabelControl lbCompSelect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantidade;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbTotalLiquido;
        private DevExpress.XtraEditors.LabelControl lbTotalDescontos;
        private DevExpress.XtraEditors.LabelControl lbTotalBruto;
        private DevExpress.XtraBars.BarButtonItem barBtnRecalculoFolha;
        private DevExpress.XtraBars.BarButtonItem btnSalvar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.BarButtonItem barBtnCancelar;
        private DevExpress.XtraEditors.LabelControl lblTotalFolha;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}