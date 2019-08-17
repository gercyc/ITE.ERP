namespace ITE.Teste
{
    partial class XtraFormXmlEditor
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ncmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigoNcm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescricaoNcm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidadeMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaII = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaPIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaCOFINS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaICMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAliquotaICMSST = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ncmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(10, 280);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(65, 24);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Carregar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ncmsBindingSource
            // 
            this.ncmsBindingSource.DataSource = typeof(ITE.Entidades.POCO.Fiscal.Ncms);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ncmsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(718, 470);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigoNcm,
            this.colDescricaoNcm,
            this.colUnidadeMedida,
            this.colAliquotaII,
            this.colAliquotaIPI,
            this.colAliquotaPIS,
            this.colAliquotaCOFINS,
            this.colAliquotaICMS,
            this.colAliquotaICMSST});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCodigoNcm
            // 
            this.colCodigoNcm.AppearanceCell.Options.UseTextOptions = true;
            this.colCodigoNcm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoNcm.AppearanceHeader.Options.UseTextOptions = true;
            this.colCodigoNcm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCodigoNcm.Caption = "Cód. NCM";
            this.colCodigoNcm.FieldName = "CodigoNcm";
            this.colCodigoNcm.Name = "colCodigoNcm";
            this.colCodigoNcm.Visible = true;
            this.colCodigoNcm.VisibleIndex = 0;
            this.colCodigoNcm.Width = 85;
            // 
            // colDescricaoNcm
            // 
            this.colDescricaoNcm.AppearanceCell.Options.UseTextOptions = true;
            this.colDescricaoNcm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoNcm.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescricaoNcm.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDescricaoNcm.Caption = "Descrição NCM";
            this.colDescricaoNcm.FieldName = "DescricaoNcm";
            this.colDescricaoNcm.Name = "colDescricaoNcm";
            this.colDescricaoNcm.Visible = true;
            this.colDescricaoNcm.VisibleIndex = 1;
            this.colDescricaoNcm.Width = 414;
            // 
            // colUnidadeMedida
            // 
            this.colUnidadeMedida.AppearanceCell.Options.UseTextOptions = true;
            this.colUnidadeMedida.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidadeMedida.AppearanceHeader.Options.UseTextOptions = true;
            this.colUnidadeMedida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colUnidadeMedida.FieldName = "UnidadeMedida";
            this.colUnidadeMedida.Name = "colUnidadeMedida";
            // 
            // colAliquotaII
            // 
            this.colAliquotaII.AppearanceCell.Options.UseTextOptions = true;
            this.colAliquotaII.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaII.AppearanceHeader.Options.UseTextOptions = true;
            this.colAliquotaII.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaII.Caption = "II";
            this.colAliquotaII.FieldName = "AliquotaII";
            this.colAliquotaII.Name = "colAliquotaII";
            this.colAliquotaII.Visible = true;
            this.colAliquotaII.VisibleIndex = 2;
            this.colAliquotaII.Width = 85;
            // 
            // colAliquotaIPI
            // 
            this.colAliquotaIPI.AppearanceCell.Options.UseTextOptions = true;
            this.colAliquotaIPI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaIPI.AppearanceHeader.Options.UseTextOptions = true;
            this.colAliquotaIPI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaIPI.Caption = "IPI";
            this.colAliquotaIPI.FieldName = "AliquotaIPI";
            this.colAliquotaIPI.Name = "colAliquotaIPI";
            this.colAliquotaIPI.Visible = true;
            this.colAliquotaIPI.VisibleIndex = 3;
            this.colAliquotaIPI.Width = 85;
            // 
            // colAliquotaPIS
            // 
            this.colAliquotaPIS.AppearanceCell.Options.UseTextOptions = true;
            this.colAliquotaPIS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaPIS.AppearanceHeader.Options.UseTextOptions = true;
            this.colAliquotaPIS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaPIS.Caption = "PIS";
            this.colAliquotaPIS.FieldName = "AliquotaPIS";
            this.colAliquotaPIS.Name = "colAliquotaPIS";
            this.colAliquotaPIS.Visible = true;
            this.colAliquotaPIS.VisibleIndex = 4;
            this.colAliquotaPIS.Width = 85;
            // 
            // colAliquotaCOFINS
            // 
            this.colAliquotaCOFINS.AppearanceCell.Options.UseTextOptions = true;
            this.colAliquotaCOFINS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaCOFINS.AppearanceHeader.Options.UseTextOptions = true;
            this.colAliquotaCOFINS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaCOFINS.Caption = "COFINS";
            this.colAliquotaCOFINS.FieldName = "AliquotaCOFINS";
            this.colAliquotaCOFINS.Name = "colAliquotaCOFINS";
            this.colAliquotaCOFINS.Visible = true;
            this.colAliquotaCOFINS.VisibleIndex = 5;
            this.colAliquotaCOFINS.Width = 85;
            // 
            // colAliquotaICMS
            // 
            this.colAliquotaICMS.AppearanceCell.Options.UseTextOptions = true;
            this.colAliquotaICMS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaICMS.AppearanceHeader.Options.UseTextOptions = true;
            this.colAliquotaICMS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaICMS.Caption = "ICMS";
            this.colAliquotaICMS.FieldName = "AliquotaICMS";
            this.colAliquotaICMS.Name = "colAliquotaICMS";
            this.colAliquotaICMS.Visible = true;
            this.colAliquotaICMS.VisibleIndex = 6;
            this.colAliquotaICMS.Width = 85;
            // 
            // colAliquotaICMSST
            // 
            this.colAliquotaICMSST.AppearanceCell.Options.UseTextOptions = true;
            this.colAliquotaICMSST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaICMSST.AppearanceHeader.Options.UseTextOptions = true;
            this.colAliquotaICMSST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAliquotaICMSST.Caption = "ICMSST";
            this.colAliquotaICMSST.FieldName = "AliquotaICMSST";
            this.colAliquotaICMSST.Name = "colAliquotaICMSST";
            this.colAliquotaICMSST.Visible = true;
            this.colAliquotaICMSST.VisibleIndex = 7;
            this.colAliquotaICMSST.Width = 109;
            // 
            // XtraFormXmlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 470);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XtraFormXmlEditor";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.ncmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource ncmsBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoNcm;
        private DevExpress.XtraGrid.Columns.GridColumn colDescricaoNcm;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadeMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaII;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaIPI;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaPIS;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaCOFINS;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaICMS;
        private DevExpress.XtraGrid.Columns.GridColumn colAliquotaICMSST;
    }
}