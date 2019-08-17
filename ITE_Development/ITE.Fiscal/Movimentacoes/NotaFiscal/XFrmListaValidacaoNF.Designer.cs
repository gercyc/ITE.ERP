namespace ITE.Fiscal.Movimentacoes.NotaFiscal
{
    partial class XFrmListaValidacaoNF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XFrmListaValidacaoNF));
            this.groupControlValidList = new DevExpress.XtraEditors.GroupControl();
            this.gridControlValidList = new DevExpress.XtraGrid.GridControl();
            this.gridViewValidList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colErros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlValidList)).BeginInit();
            this.groupControlValidList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlValidList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewValidList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlValidList
            // 
            this.groupControlValidList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlValidList.Controls.Add(this.gridControlValidList);
            this.groupControlValidList.Location = new System.Drawing.Point(14, 13);
            this.groupControlValidList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlValidList.Name = "groupControlValidList";
            this.groupControlValidList.Size = new System.Drawing.Size(675, 311);
            this.groupControlValidList.TabIndex = 2;
            this.groupControlValidList.Text = "Lista de erros da validação";
            // 
            // gridControlValidList
            // 
            this.gridControlValidList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlValidList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlValidList.Location = new System.Drawing.Point(2, 26);
            this.gridControlValidList.MainView = this.gridViewValidList;
            this.gridControlValidList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlValidList.Name = "gridControlValidList";
            this.gridControlValidList.Size = new System.Drawing.Size(671, 283);
            this.gridControlValidList.TabIndex = 0;
            this.gridControlValidList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewValidList});
            // 
            // gridViewValidList
            // 
            this.gridViewValidList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colErros});
            this.gridViewValidList.GridControl = this.gridControlValidList;
            this.gridViewValidList.Name = "gridViewValidList";
            this.gridViewValidList.OptionsView.ColumnAutoWidth = false;
            this.gridViewValidList.OptionsView.ShowGroupPanel = false;
            // 
            // colErros
            // 
            this.colErros.Caption = "Erros de validação";
            this.colErros.FieldName = "Column";
            this.colErros.Name = "colErros";
            this.colErros.Visible = true;
            this.colErros.VisibleIndex = 0;
            this.colErros.Width = 356;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(443, 330);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 30);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Continuar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.Image")));
            this.btnPrintPreview.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnPrintPreview.Location = new System.Drawing.Point(296, 330);
            this.btnPrintPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(100, 30);
            this.btnPrintPreview.TabIndex = 6;
            this.btnPrintPreview.Text = "Relatório";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(139, 330);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 30);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // XFrmListaValidacaoNF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 373);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControlValidList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XFrmListaValidacaoNF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de erros da validação";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlValidList)).EndInit();
            this.groupControlValidList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlValidList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewValidList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControlValidList;
        private DevExpress.XtraGrid.GridControl gridControlValidList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewValidList;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private DevExpress.XtraGrid.Columns.GridColumn colErros;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
    }
}