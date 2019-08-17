namespace ITE.RH.Forms.Folha
{
    partial class XFrmCalculoFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmCalculoFolha));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbTipoFechamento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupoEvento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.eventosGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEvtGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImprimirHolerite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTpEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkConsGrpFunc = new DevExpress.XtraEditors.CheckEdit();
            this.dxValidatePeriodo = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.cbPeriodo = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFechamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoEvento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConsGrpFunc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidatePeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 27);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Informe o período:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(477, 247);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 31);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Executar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbTipoFechamento
            // 
            this.cbTipoFechamento.EditValue = "Mensal";
            this.cbTipoFechamento.Location = new System.Drawing.Point(14, 215);
            this.cbTipoFechamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoFechamento.Name = "cbTipoFechamento";
            this.cbTipoFechamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoFechamento.Properties.Items.AddRange(new object[] {
            "Mensal",
            "Quinzenal",
            "Semanal"});
            this.cbTipoFechamento.Properties.ReadOnly = true;
            this.cbTipoFechamento.Size = new System.Drawing.Size(182, 22);
            this.cbTipoFechamento.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 192);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Periodicidade:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 102);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(105, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Grupo de eventos:";
            // 
            // cbGrupoEvento
            // 
            this.cbGrupoEvento.Location = new System.Drawing.Point(14, 126);
            this.cbGrupoEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGrupoEvento.Name = "cbGrupoEvento";
            this.cbGrupoEvento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupoEvento.Size = new System.Drawing.Size(182, 22);
            toolTipTitleItem1.Text = "Grupo de eventos";
            toolTipItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem1.Image")));
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Selecione o grupo de eventos que será utilizado para o fechamento da folha de pag" +
    "amento.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.cbGrupoEvento.SuperTip = superToolTip1;
            this.cbGrupoEvento.TabIndex = 1;
            this.cbGrupoEvento.EditValueChanged += new System.EventHandler(this.cbGrupoEvento_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(227, 27);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(372, 213);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Eventos";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.eventosGrupoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(2, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(368, 185);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // eventosGrupoBindingSource
            // 
            this.eventosGrupoBindingSource.DataSource = typeof(ITE.Entidades.POCO.RH.Folha.EventosGrupo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEvtGrupo,
            this.colIdGrupoEvento,
            this.colIdEvento,
            this.colImprimirHolerite,
            this.colTpEvento,
            this.colCodEvento,
            this.colGrupo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEvtGrupo
            // 
            this.colIdEvtGrupo.FieldName = "IdEvtGrupo";
            this.colIdEvtGrupo.Name = "colIdEvtGrupo";
            // 
            // colIdGrupoEvento
            // 
            this.colIdGrupoEvento.FieldName = "IdGrupoEvento";
            this.colIdGrupoEvento.Name = "colIdGrupoEvento";
            // 
            // colIdEvento
            // 
            this.colIdEvento.FieldName = "IdEvento";
            this.colIdEvento.Name = "colIdEvento";
            // 
            // colImprimirHolerite
            // 
            this.colImprimirHolerite.FieldName = "ImprimirHolerite";
            this.colImprimirHolerite.Name = "colImprimirHolerite";
            // 
            // colTpEvento
            // 
            this.colTpEvento.Caption = "Tipo";
            this.colTpEvento.FieldName = "Evento.TipoEvento";
            this.colTpEvento.Name = "colTpEvento";
            this.colTpEvento.Visible = true;
            this.colTpEvento.VisibleIndex = 2;
            this.colTpEvento.Width = 106;
            // 
            // colCodEvento
            // 
            this.colCodEvento.Caption = "Cód. Evento";
            this.colCodEvento.FieldName = "Evento.CodigoEvento";
            this.colCodEvento.Name = "colCodEvento";
            this.colCodEvento.Visible = true;
            this.colCodEvento.VisibleIndex = 0;
            this.colCodEvento.Width = 79;
            // 
            // colGrupo
            // 
            this.colGrupo.FieldName = "Evento.DescricaoEvento";
            this.colGrupo.Name = "colGrupo";
            this.colGrupo.Visible = true;
            this.colGrupo.VisibleIndex = 1;
            this.colGrupo.Width = 112;
            // 
            // chkConsGrpFunc
            // 
            this.chkConsGrpFunc.Location = new System.Drawing.Point(14, 158);
            this.chkConsGrpFunc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkConsGrpFunc.Name = "chkConsGrpFunc";
            this.chkConsGrpFunc.Properties.Caption = "Considerar grupo funcionário";
            this.chkConsGrpFunc.Size = new System.Drawing.Size(196, 20);
            toolTipTitleItem2.Text = "Considerar grupo funcionário";
            toolTipItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipItem2.Appearance.Options.UseImage = true;
            toolTipItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem2.Image")));
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Caso esta opção esteja marcada, o grupo escolhido nesta tela será ignorado para f" +
    "uncionários que possuem um grupo padrão para fechamento da folha de pagamento.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.chkConsGrpFunc.SuperTip = superToolTip2;
            this.chkConsGrpFunc.TabIndex = 2;
            // 
            // dxValidatePeriodo
            // 
            this.dxValidatePeriodo.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.Location = new System.Drawing.Point(14, 50);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbPeriodo.Properties.Appearance.Options.UseFont = true;
            this.cbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPeriodo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPeriodo.Size = new System.Drawing.Size(184, 24);
            this.cbPeriodo.TabIndex = 12;
            // 
            // XFrmCalculoFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 286);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.chkConsGrpFunc);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbGrupoEvento);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbTipoFechamento);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "XFrmCalculoFolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo Folha de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFechamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoEvento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConsGrpFunc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidatePeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoFechamento;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbGrupoEvento;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.CheckEdit chkConsGrpFunc;
        private System.Windows.Forms.BindingSource eventosGrupoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEvtGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colImprimirHolerite;
        private DevExpress.XtraGrid.Columns.GridColumn colTpEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colCodEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidatePeriodo;
        private DevExpress.XtraEditors.ComboBoxEdit cbPeriodo;
    }
}