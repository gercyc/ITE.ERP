namespace ITE.RH.Forms.Folha
{
    partial class ucFechFolhaParams
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

        #region Component Designer generated code
        
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucFechFolhaParams));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.cbPeriodo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkConsGrpFunc = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEvtGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImprimirHolerite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTpEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodEvento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbGrupoEvento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbTipoFechamento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConsGrpFunc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoEvento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFechamento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.Location = new System.Drawing.Point(6, 28);
            this.cbPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbPeriodo.Properties.Appearance.Options.UseFont = true;
            this.cbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPeriodo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPeriodo.Size = new System.Drawing.Size(158, 20);
            this.cbPeriodo.TabIndex = 21;
            // 
            // chkConsGrpFunc
            // 
            this.chkConsGrpFunc.Location = new System.Drawing.Point(6, 115);
            this.chkConsGrpFunc.Name = "chkConsGrpFunc";
            this.chkConsGrpFunc.Properties.Caption = "Considerar grupo funcionário";
            this.chkConsGrpFunc.Size = new System.Drawing.Size(168, 19);
            toolTipTitleItem1.Text = "Considerar grupo funcionário";
            toolTipItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem1.Image")));
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Caso esta opção esteja marcada, o grupo escolhido nesta tela será ignorado para f" +
    "uncionários que possuem um grupo padrão para fechamento da folha de pagamento.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.chkConsGrpFunc.SuperTip = superToolTip1;
            this.chkConsGrpFunc.TabIndex = 15;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(189, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(319, 173);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Eventos";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(315, 151);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Grupo de eventos:";
            // 
            // cbGrupoEvento
            // 
            this.cbGrupoEvento.Location = new System.Drawing.Point(6, 89);
            this.cbGrupoEvento.Name = "cbGrupoEvento";
            this.cbGrupoEvento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGrupoEvento.Size = new System.Drawing.Size(156, 20);
            toolTipTitleItem2.Text = "Grupo de eventos";
            toolTipItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipItem2.Appearance.Options.UseImage = true;
            toolTipItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem2.Image")));
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Selecione o grupo de eventos que será utilizado para o fechamento da folha de pag" +
    "amento.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.cbGrupoEvento.SuperTip = superToolTip2;
            this.cbGrupoEvento.TabIndex = 14;
            this.cbGrupoEvento.EditValueChanged += new System.EventHandler(this.cbGrupoEvento_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Periodicidade:";
            // 
            // cbTipoFechamento
            // 
            this.cbTipoFechamento.EditValue = "Mensal";
            this.cbTipoFechamento.Location = new System.Drawing.Point(6, 162);
            this.cbTipoFechamento.Name = "cbTipoFechamento";
            this.cbTipoFechamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTipoFechamento.Properties.Items.AddRange(new object[] {
            "Mensal",
            "Quinzenal",
            "Semanal"});
            this.cbTipoFechamento.Properties.ReadOnly = true;
            this.cbTipoFechamento.Size = new System.Drawing.Size(156, 20);
            this.cbTipoFechamento.TabIndex = 16;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(403, 188);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 25);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Executar";
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Informe o período:";
            // 
            // ucFechFolhaParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.chkConsGrpFunc);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbGrupoEvento);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbTipoFechamento);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Name = "ucFechFolhaParams";
            this.Size = new System.Drawing.Size(518, 224);
            this.Load += new System.EventHandler(this.ucFechFolhaParams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkConsGrpFunc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGrupoEvento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbTipoFechamento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbPeriodo;
        private DevExpress.XtraEditors.CheckEdit chkConsGrpFunc;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEvtGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colImprimirHolerite;
        private DevExpress.XtraGrid.Columns.GridColumn colTpEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colCodEvento;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbGrupoEvento;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbTipoFechamento;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
