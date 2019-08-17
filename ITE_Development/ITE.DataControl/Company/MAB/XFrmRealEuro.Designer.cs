namespace ITE.DataControl.Company.MAB
{
    partial class XFrmRealEuro
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.modelControlLancamentoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoeda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErrors = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorJuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoCancelamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCancelamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasPrazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencialParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnexos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaixas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtratos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVenda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNotaFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotaFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioRecCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecModifyBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioRecModifyBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageNatureza = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelControlLancamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.modelControlLancamentoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(883, 442);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // modelControlLancamentoBindingSource
            // 
            this.modelControlLancamentoBindingSource.DataSource = typeof(ITE.DataControl.Company.MAB.ModelControlLancamento);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDataVencimento,
            this.colValorLancamento,
            this.colTotalLancamento,
            this.colMoeda,
            this.colObservacao,
            this.colResult,
            this.colErrors,
            this.colIdLancamento,
            this.colDataLancamento,
            this.colValorJuros,
            this.colDataPagamento,
            this.colMotivoCancelamento,
            this.colDataCancelamento,
            this.colDiasPrazo,
            this.colSequencialParcela,
            this.colStatusLancamento,
            this.colTipoLancamento,
            this.colAnexos,
            this.colBaixas,
            this.colExtratos,
            this.colIdVenda,
            this.colVenda,
            this.colIdCliFor,
            this.colCliFor,
            this.colCentroCusto,
            this.colIdCentroCusto,
            this.colIdFilial,
            this.colFilial,
            this.colIdFormaPagamento,
            this.colFormaPagamento,
            this.colIdNotaFiscal,
            this.colNotaFiscal,
            this.colRecCreatedBy,
            this.colUsuarioRecCreatedBy,
            this.colRecModifyBy,
            this.colUsuarioRecModifyBy,
            this.colRecCreatedDate,
            this.colRecModifyDate,
            this.colImage,
            this.colImageNatureza});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 1;
            this.colDataVencimento.Width = 136;
            // 
            // colValorLancamento
            // 
            this.colValorLancamento.DisplayFormat.FormatString = "n2";
            this.colValorLancamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorLancamento.FieldName = "ValorLancamento";
            this.colValorLancamento.Name = "colValorLancamento";
            this.colValorLancamento.Visible = true;
            this.colValorLancamento.VisibleIndex = 2;
            this.colValorLancamento.Width = 179;
            // 
            // colTotalLancamento
            // 
            this.colTotalLancamento.DisplayFormat.FormatString = "n2";
            this.colTotalLancamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalLancamento.FieldName = "TotalLancamento";
            this.colTotalLancamento.Name = "colTotalLancamento";
            this.colTotalLancamento.OptionsColumn.ReadOnly = true;
            this.colTotalLancamento.Width = 150;
            // 
            // colMoeda
            // 
            this.colMoeda.FieldName = "Moeda";
            this.colMoeda.Name = "colMoeda";
            this.colMoeda.Visible = true;
            this.colMoeda.VisibleIndex = 3;
            this.colMoeda.Width = 123;
            // 
            // colObservacao
            // 
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 4;
            this.colObservacao.Width = 596;
            // 
            // colResult
            // 
            this.colResult.FieldName = "Result";
            this.colResult.Name = "colResult";
            this.colResult.OptionsColumn.ReadOnly = true;
            this.colResult.Width = 61;
            // 
            // colErrors
            // 
            this.colErrors.FieldName = "Errors";
            this.colErrors.Name = "colErrors";
            this.colErrors.OptionsColumn.ReadOnly = true;
            this.colErrors.Width = 92;
            // 
            // colIdLancamento
            // 
            this.colIdLancamento.FieldName = "IdLancamento";
            this.colIdLancamento.Name = "colIdLancamento";
            this.colIdLancamento.Width = 111;
            // 
            // colDataLancamento
            // 
            this.colDataLancamento.FieldName = "DataLancamento";
            this.colDataLancamento.Name = "colDataLancamento";
            this.colDataLancamento.Visible = true;
            this.colDataLancamento.VisibleIndex = 0;
            this.colDataLancamento.Width = 128;
            // 
            // colValorJuros
            // 
            this.colValorJuros.FieldName = "ValorJuros";
            this.colValorJuros.Name = "colValorJuros";
            this.colValorJuros.Width = 64;
            // 
            // colDataPagamento
            // 
            this.colDataPagamento.FieldName = "DataPagamento";
            this.colDataPagamento.Name = "colDataPagamento";
            this.colDataPagamento.Width = 158;
            // 
            // colMotivoCancelamento
            // 
            this.colMotivoCancelamento.FieldName = "MotivoCancelamento";
            this.colMotivoCancelamento.Name = "colMotivoCancelamento";
            this.colMotivoCancelamento.Width = 29;
            // 
            // colDataCancelamento
            // 
            this.colDataCancelamento.FieldName = "DataCancelamento";
            this.colDataCancelamento.Name = "colDataCancelamento";
            this.colDataCancelamento.Width = 27;
            // 
            // colDiasPrazo
            // 
            this.colDiasPrazo.FieldName = "DiasPrazo";
            this.colDiasPrazo.Name = "colDiasPrazo";
            this.colDiasPrazo.Width = 35;
            // 
            // colSequencialParcela
            // 
            this.colSequencialParcela.FieldName = "SequencialParcela";
            this.colSequencialParcela.Name = "colSequencialParcela";
            this.colSequencialParcela.Width = 27;
            // 
            // colStatusLancamento
            // 
            this.colStatusLancamento.FieldName = "StatusLancamento";
            this.colStatusLancamento.Name = "colStatusLancamento";
            this.colStatusLancamento.Width = 47;
            // 
            // colTipoLancamento
            // 
            this.colTipoLancamento.FieldName = "TipoLancamento";
            this.colTipoLancamento.Name = "colTipoLancamento";
            this.colTipoLancamento.Width = 45;
            // 
            // colAnexos
            // 
            this.colAnexos.FieldName = "Anexos";
            this.colAnexos.Name = "colAnexos";
            this.colAnexos.Width = 62;
            // 
            // colBaixas
            // 
            this.colBaixas.FieldName = "Baixas";
            this.colBaixas.Name = "colBaixas";
            this.colBaixas.Width = 20;
            // 
            // colExtratos
            // 
            this.colExtratos.FieldName = "Extratos";
            this.colExtratos.Name = "colExtratos";
            this.colExtratos.Width = 20;
            // 
            // colIdVenda
            // 
            this.colIdVenda.FieldName = "IdVenda";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.Width = 20;
            // 
            // colVenda
            // 
            this.colVenda.FieldName = "Venda";
            this.colVenda.Name = "colVenda";
            this.colVenda.Width = 20;
            // 
            // colIdCliFor
            // 
            this.colIdCliFor.FieldName = "IdCliFor";
            this.colIdCliFor.Name = "colIdCliFor";
            this.colIdCliFor.Width = 20;
            // 
            // colCliFor
            // 
            this.colCliFor.FieldName = "CliFor";
            this.colCliFor.Name = "colCliFor";
            this.colCliFor.Width = 20;
            // 
            // colCentroCusto
            // 
            this.colCentroCusto.FieldName = "CentroCusto";
            this.colCentroCusto.Name = "colCentroCusto";
            this.colCentroCusto.Width = 25;
            // 
            // colIdCentroCusto
            // 
            this.colIdCentroCusto.FieldName = "IdCentroCusto";
            this.colIdCentroCusto.Name = "colIdCentroCusto";
            this.colIdCentroCusto.Width = 25;
            // 
            // colIdFilial
            // 
            this.colIdFilial.FieldName = "IdFilial";
            this.colIdFilial.Name = "colIdFilial";
            this.colIdFilial.Width = 20;
            // 
            // colFilial
            // 
            this.colFilial.FieldName = "Filial";
            this.colFilial.Name = "colFilial";
            this.colFilial.Width = 20;
            // 
            // colIdFormaPagamento
            // 
            this.colIdFormaPagamento.FieldName = "IdFormaPagamento";
            this.colIdFormaPagamento.Name = "colIdFormaPagamento";
            this.colIdFormaPagamento.Width = 28;
            // 
            // colFormaPagamento
            // 
            this.colFormaPagamento.FieldName = "FormaPagamento";
            this.colFormaPagamento.Name = "colFormaPagamento";
            this.colFormaPagamento.Width = 26;
            // 
            // colIdNotaFiscal
            // 
            this.colIdNotaFiscal.FieldName = "IdNotaFiscal";
            this.colIdNotaFiscal.Name = "colIdNotaFiscal";
            this.colIdNotaFiscal.Width = 22;
            // 
            // colNotaFiscal
            // 
            this.colNotaFiscal.FieldName = "NotaFiscal";
            this.colNotaFiscal.Name = "colNotaFiscal";
            this.colNotaFiscal.Width = 20;
            // 
            // colRecCreatedBy
            // 
            this.colRecCreatedBy.FieldName = "RecCreatedBy";
            this.colRecCreatedBy.Name = "colRecCreatedBy";
            this.colRecCreatedBy.Width = 20;
            // 
            // colUsuarioRecCreatedBy
            // 
            this.colUsuarioRecCreatedBy.FieldName = "UsuarioRecCreatedBy";
            this.colUsuarioRecCreatedBy.Name = "colUsuarioRecCreatedBy";
            this.colUsuarioRecCreatedBy.Width = 20;
            // 
            // colRecModifyBy
            // 
            this.colRecModifyBy.FieldName = "RecModifyBy";
            this.colRecModifyBy.Name = "colRecModifyBy";
            this.colRecModifyBy.Width = 22;
            // 
            // colUsuarioRecModifyBy
            // 
            this.colUsuarioRecModifyBy.FieldName = "UsuarioRecModifyBy";
            this.colUsuarioRecModifyBy.Name = "colUsuarioRecModifyBy";
            this.colUsuarioRecModifyBy.Width = 20;
            // 
            // colRecCreatedDate
            // 
            this.colRecCreatedDate.FieldName = "RecCreatedDate";
            this.colRecCreatedDate.Name = "colRecCreatedDate";
            this.colRecCreatedDate.Width = 26;
            // 
            // colRecModifyDate
            // 
            this.colRecModifyDate.FieldName = "RecModifyDate";
            this.colRecModifyDate.Name = "colRecModifyDate";
            this.colRecModifyDate.Width = 25;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.OptionsColumn.ReadOnly = true;
            this.colImage.Width = 20;
            // 
            // colImageNatureza
            // 
            this.colImageNatureza.FieldName = "ImageNatureza";
            this.colImageNatureza.Name = "colImageNatureza";
            this.colImageNatureza.OptionsColumn.ReadOnly = true;
            this.colImageNatureza.Width = 25;
            // 
            // XFrmRealEuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 442);
            this.Controls.Add(this.gridControl1);
            this.Name = "XFrmRealEuro";
            this.Text = "XFrmRealEuro";
            this.Shown += new System.EventHandler(this.XFrmRealEuro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelControlLancamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource modelControlLancamentoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colMoeda;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraGrid.Columns.GridColumn colErrors;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorJuros;
        private DevExpress.XtraGrid.Columns.GridColumn colDataPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoCancelamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCancelamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPrazo;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencialParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colAnexos;
        private DevExpress.XtraGrid.Columns.GridColumn colBaixas;
        private DevExpress.XtraGrid.Columns.GridColumn colExtratos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colVenda;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNotaFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colNotaFiscal;
        private DevExpress.XtraGrid.Columns.GridColumn colRecCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioRecCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colRecModifyBy;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioRecModifyBy;
        private DevExpress.XtraGrid.Columns.GridColumn colRecCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRecModifyDate;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colImageNatureza;
    }
}