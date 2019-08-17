using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Threading.Tasks;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Forms;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Validador;

namespace ITE.DataControl.Company
{
    public class LancamentoFinanceiroImport : XFrmExcelManager
    {

        public LancamentoFinanceiroImport(string file) : base(file)
        {
        }

        public LancamentoFinanceiroImport(string file, int worksheet) : base(file, worksheet)
        {
        }

        public override async void PreVisualizarValidar()
        {
            var r = await XFrmWait.StartTask<bool>(Task.Run(() => validar()), "Validando lançamentos");

            if (r)
            {
                base.PreVisualizarValidar();
                gridViewResult.RestoreViewFromResource(Assembly.GetExecutingAssembly(),
                    "ITE.DataControl.Resources.layout_lancamentos_financeiros.xml");
                ShowResult(this.Result,this.Errors);
            }
        }

        public override async void Salvar()
        {
            var r = await XFrmWait.StartTask<bool>(Task.Run(() => importar()), "Importando lançamentos");

            if (r)
                XMessageIts.Mensagem("Done !!!");
            else
                XMessageIts.Erro("Erro !");

        }

        public override void Novo()
        {
        }

        public override void Alterar()
        {
        }
        public bool validar()
        {

            this.Errors = new HashSet<LancamentoFinanceiro>();
            this.Result = new HashSet<LancamentoFinanceiro>();
            for (int i = 0; i < gridViewBase.DataRowCount; i++)
            {
                DataRow row = gridViewBase.GetDataRow(i);


                var dt = DataUtil.ToDate(row[Data].ToString());
                var vlr = ParseUtil.ToDecimal(row[Valor].ToString().Trim());
                var obs = row[Obs].ToString().Trim();
                var id = ParseUtil.ToInt(row[ID].ToString().Trim());

                var l = new LancamentoFinanceiro();

                l.DataLancamento = dt;
                l.DataVencimento = dt;
                l.ValorLancamento = vlr;
                l.Observacao = obs;
                l.IdCentroCusto = 4;
                l.IdCliFor = id;
                l.RecCreatedBy = 2;
                l.IdFilial = 1;
                l.IdFormaPagamento = (int)TypeFormaPagamento.Cheque;
                try
                {
                    if (ValidadorDTO.Validate(l))
                        this.Result.Add(l);
                    else
                        this.Errors.Add(l);
                }
                catch (Exception ex)
                {
                    this.Errors.Add(l);
                    LoggerUtilIts.ShowExceptionLogs(ex);
                }

            }
            return this.Errors.Count == 0;
        }

        private bool importar()
        {
            using (var ctx = new BalcaoContext())
            {
                var lanctos = gridViewResult.GetItens<LancamentoFinanceiro>();
                int i = 0;
                foreach (var l in lanctos)
                {
                    ctx.LancamentoFinanceiroDao.Save(l);
                    i++;
                }
                return i == lanctos.Count;
            }
        }
        ///Largura Comprimento Espessura1 Espessura2  ValorMetroQuadrado

        private const string Data = "DataLancamento";
        private const string Valor = "ValorLancamento";
        private const string Obs = "Observação";
        private DevExpress.XtraGrid.Columns.GridColumn colAttachmentIco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colValorJuros;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataVencimento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDataPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDiasPrazo;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacao;
        private DevExpress.XtraGrid.Columns.GridColumn colSequencialParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliFor;
        private DevExpress.XtraGrid.Columns.GridColumn colCliForParcela;
        private DevExpress.XtraGrid.Columns.GridColumn colCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCusto;
        private DevExpress.XtraGrid.Columns.GridColumn colImageStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoLancamento;
        private DevExpress.XtraGrid.Columns.GridColumn colNatImg;
        private DevExpress.XtraGrid.Columns.GridColumn colRecCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colRecCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNotaFiscal;
        private const string ID = "IdCliente";

        public HashSet<LancamentoFinanceiro> Result { get; private set; }
        public HashSet<LancamentoFinanceiro> Errors { get; private set; }

        private void InitializeComponent()
        {
            this.colAttachmentIco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorJuros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataVencimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiasPrazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequencialParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliForParcela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCusto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImageStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoLancamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNatImg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNotaFiscal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFormaPagamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFilial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDataCancelamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivoCancelamento = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExcelFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            // 
            // gridControlBase
            // 
            this.gridControlBase.Size = new System.Drawing.Size(770, 256);
            // 
            // gridViewBase
            // 
            this.gridViewBase.OptionsView.ColumnAutoWidth = false;
            this.gridViewBase.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewBase.OptionsView.ShowFooter = true;
            // 
            // txtExcelFile
            // 
            this.txtExcelFile.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtExcelFile.Properties.Appearance.Options.UseBackColor = true;
            // 
            // gridControlResult
            // 
            this.gridControlResult.Size = new System.Drawing.Size(770, 256);
            // 
            // gridViewResult
            // 
            this.gridViewResult.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridViewResult.Appearance.FocusedCell.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.gridViewResult.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAttachmentIco,
            this.colIdLancamento,
            this.colValorLancamento,
            this.colValorJuros,
            this.colTotalLancamento,
            this.colDataVencimento,
            this.colDataLancamento,
            this.colDataPagamento,
            this.colDiasPrazo,
            this.colObservacao,
            this.colSequencialParcela,
            this.colStatus,
            this.colIdCliFor,
            this.colCliForParcela,
            this.colCentroCusto,
            this.colIdCentroCusto,
            this.colImageStatus,
            this.colTipoLancamento,
            this.colNatImg,
            this.colRecCreatedBy,
            this.colRecCreatedDate,
            this.colIdNotaFiscal,
            this.colFormaPagamento,
            this.colFilial,
            this.colDataCancelamento,
            this.colMotivoCancelamento});
            this.gridViewResult.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorLancamento", this.colValorLancamento, "")});
            this.gridViewResult.OptionsBehavior.Editable = false;
            this.gridViewResult.OptionsSelection.MultiSelect = true;
            this.gridViewResult.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewResult.OptionsView.ColumnAutoWidth = false;
            this.gridViewResult.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewResult.OptionsView.ShowFooter = true;
            this.gridViewResult.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colValorLancamento, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colAttachmentIco
            // 
            this.colAttachmentIco.Caption = " ";
            this.colAttachmentIco.FieldName = "AttachmentIco";
            this.colAttachmentIco.Name = "colAttachmentIco";
            this.colAttachmentIco.Width = 28;
            // 
            // colIdLancamento
            // 
            this.colIdLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colIdLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdLancamento.Caption = "ID Lançto";
            this.colIdLancamento.FieldName = "IdLancamento";
            this.colIdLancamento.Name = "colIdLancamento";
            this.colIdLancamento.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdLancamento", "{0}")});
            this.colIdLancamento.Visible = true;
            this.colIdLancamento.VisibleIndex = 5;
            this.colIdLancamento.Width = 80;
            // 
            // colValorLancamento
            // 
            this.colValorLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colValorLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorLancamento.Caption = "Valor";
            this.colValorLancamento.DisplayFormat.FormatString = "n2";
            this.colValorLancamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorLancamento.FieldName = "ValorLancamento";
            this.colValorLancamento.Name = "colValorLancamento";
            this.colValorLancamento.Visible = true;
            this.colValorLancamento.VisibleIndex = 16;
            this.colValorLancamento.Width = 90;
            // 
            // colValorJuros
            // 
            this.colValorJuros.AppearanceCell.Options.UseTextOptions = true;
            this.colValorJuros.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorJuros.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorJuros.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colValorJuros.Caption = "Juros";
            this.colValorJuros.DisplayFormat.FormatString = "n2";
            this.colValorJuros.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colValorJuros.FieldName = "ValorJuros";
            this.colValorJuros.Name = "colValorJuros";
            this.colValorJuros.Visible = true;
            this.colValorJuros.VisibleIndex = 17;
            this.colValorJuros.Width = 70;
            // 
            // colTotalLancamento
            // 
            this.colTotalLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colTotalLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTotalLancamento.Caption = "Total";
            this.colTotalLancamento.DisplayFormat.FormatString = "n2";
            this.colTotalLancamento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalLancamento.FieldName = "TotalLancamento";
            this.colTotalLancamento.Name = "colTotalLancamento";
            this.colTotalLancamento.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalLancamento", "{0:n2}")});
            this.colTotalLancamento.Visible = true;
            this.colTotalLancamento.VisibleIndex = 14;
            this.colTotalLancamento.Width = 109;
            // 
            // colDataVencimento
            // 
            this.colDataVencimento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataVencimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVencimento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataVencimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataVencimento.Caption = "Vencimento";
            this.colDataVencimento.FieldName = "DataVencimento";
            this.colDataVencimento.Name = "colDataVencimento";
            this.colDataVencimento.Visible = true;
            this.colDataVencimento.VisibleIndex = 10;
            // 
            // colDataLancamento
            // 
            this.colDataLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataLancamento.Caption = "Data";
            this.colDataLancamento.FieldName = "DataLancamento";
            this.colDataLancamento.Name = "colDataLancamento";
            this.colDataLancamento.Visible = true;
            this.colDataLancamento.VisibleIndex = 9;
            // 
            // colDataPagamento
            // 
            this.colDataPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataPagamento.Caption = "Data Baixa";
            this.colDataPagamento.FieldName = "DataPagamento";
            this.colDataPagamento.Name = "colDataPagamento";
            this.colDataPagamento.Visible = true;
            this.colDataPagamento.VisibleIndex = 15;
            this.colDataPagamento.Width = 68;
            // 
            // colDiasPrazo
            // 
            this.colDiasPrazo.AppearanceCell.Options.UseTextOptions = true;
            this.colDiasPrazo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDiasPrazo.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiasPrazo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDiasPrazo.Caption = "Prazo";
            this.colDiasPrazo.FieldName = "DiasPrazo";
            this.colDiasPrazo.Name = "colDiasPrazo";
            this.colDiasPrazo.Visible = true;
            this.colDiasPrazo.VisibleIndex = 18;
            this.colDiasPrazo.Width = 60;
            // 
            // colObservacao
            // 
            this.colObservacao.AppearanceCell.Options.UseTextOptions = true;
            this.colObservacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.AppearanceHeader.Options.UseTextOptions = true;
            this.colObservacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colObservacao.Caption = "Histórico";
            this.colObservacao.FieldName = "Observacao";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.Visible = true;
            this.colObservacao.VisibleIndex = 11;
            this.colObservacao.Width = 275;
            // 
            // colSequencialParcela
            // 
            this.colSequencialParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colSequencialParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSequencialParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.colSequencialParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSequencialParcela.Caption = "Sequencial";
            this.colSequencialParcela.FieldName = "SequencialParcela";
            this.colSequencialParcela.Name = "colSequencialParcela";
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "StatusLancamento";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 73;
            // 
            // colIdCliFor
            // 
            this.colIdCliFor.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCliFor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliFor.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCliFor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCliFor.Caption = "Cód. Cliente";
            this.colIdCliFor.FieldName = "IdCliFor";
            this.colIdCliFor.Name = "colIdCliFor";
            this.colIdCliFor.Visible = true;
            this.colIdCliFor.VisibleIndex = 7;
            // 
            // colCliForParcela
            // 
            this.colCliForParcela.AppearanceCell.Options.UseTextOptions = true;
            this.colCliForParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliForParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.colCliForParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCliForParcela.Caption = "Cliente/Fornecedor";
            this.colCliForParcela.FieldName = "CliFor.RazaoSocial";
            this.colCliForParcela.Name = "colCliForParcela";
            this.colCliForParcela.Visible = true;
            this.colCliForParcela.VisibleIndex = 8;
            this.colCliForParcela.Width = 256;
            // 
            // colCentroCusto
            // 
            this.colCentroCusto.AppearanceCell.Options.UseTextOptions = true;
            this.colCentroCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCentroCusto.AppearanceHeader.Options.UseTextOptions = true;
            this.colCentroCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCentroCusto.Caption = "Centro de custo";
            this.colCentroCusto.FieldName = "CentroCusto.NomeCentroCusto";
            this.colCentroCusto.Name = "colCentroCusto";
            this.colCentroCusto.Visible = true;
            this.colCentroCusto.VisibleIndex = 13;
            this.colCentroCusto.Width = 221;
            // 
            // colIdCentroCusto
            // 
            this.colIdCentroCusto.AppearanceCell.Options.UseTextOptions = true;
            this.colIdCentroCusto.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCentroCusto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdCentroCusto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdCentroCusto.Caption = "Id Centro Custo";
            this.colIdCentroCusto.FieldName = "CodigoCentroCusto";
            this.colIdCentroCusto.Name = "colIdCentroCusto";
            this.colIdCentroCusto.Visible = true;
            this.colIdCentroCusto.VisibleIndex = 12;
            // 
            // colImageStatus
            // 
            this.colImageStatus.AppearanceCell.Options.UseTextOptions = true;
            this.colImageStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImageStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colImageStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colImageStatus.Caption = " ";
            this.colImageStatus.FieldName = "Image";
            this.colImageStatus.Name = "colImageStatus";
            this.colImageStatus.OptionsColumn.ReadOnly = true;
            this.colImageStatus.Visible = true;
            this.colImageStatus.VisibleIndex = 1;
            this.colImageStatus.Width = 27;
            // 
            // colTipoLancamento
            // 
            this.colTipoLancamento.AppearanceCell.Options.UseTextOptions = true;
            this.colTipoLancamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoLancamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colTipoLancamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTipoLancamento.Caption = "Natureza";
            this.colTipoLancamento.FieldName = "TipoLancamento";
            this.colTipoLancamento.Name = "colTipoLancamento";
            this.colTipoLancamento.Visible = true;
            this.colTipoLancamento.VisibleIndex = 4;
            // 
            // colNatImg
            // 
            this.colNatImg.AppearanceCell.Options.UseTextOptions = true;
            this.colNatImg.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNatImg.AppearanceHeader.Options.UseTextOptions = true;
            this.colNatImg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNatImg.Caption = " ";
            this.colNatImg.FieldName = "ImageNatureza";
            this.colNatImg.Name = "colNatImg";
            this.colNatImg.Visible = true;
            this.colNatImg.VisibleIndex = 3;
            this.colNatImg.Width = 29;
            // 
            // colRecCreatedBy
            // 
            this.colRecCreatedBy.AppearanceCell.Options.UseTextOptions = true;
            this.colRecCreatedBy.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRecCreatedBy.AppearanceHeader.Options.UseTextOptions = true;
            this.colRecCreatedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRecCreatedBy.Caption = "Usuário";
            this.colRecCreatedBy.FieldName = "IdUsuario";
            this.colRecCreatedBy.Name = "colRecCreatedBy";
            this.colRecCreatedBy.Visible = true;
            this.colRecCreatedBy.VisibleIndex = 6;
            // 
            // colRecCreatedDate
            // 
            this.colRecCreatedDate.AppearanceCell.Options.UseTextOptions = true;
            this.colRecCreatedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRecCreatedDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRecCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colRecCreatedDate.Caption = "Dt. Criação";
            this.colRecCreatedDate.FieldName = "RecCreatedDate";
            this.colRecCreatedDate.Name = "colRecCreatedDate";
            // 
            // colIdNotaFiscal
            // 
            this.colIdNotaFiscal.AppearanceCell.Options.UseTextOptions = true;
            this.colIdNotaFiscal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdNotaFiscal.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdNotaFiscal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colIdNotaFiscal.Caption = "Núm. NF";
            this.colIdNotaFiscal.FieldName = "NotaFiscal.NumeroNf";
            this.colIdNotaFiscal.Name = "colIdNotaFiscal";
            // 
            // colFormaPagamento
            // 
            this.colFormaPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.colFormaPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFormaPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colFormaPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFormaPagamento.Caption = "Forma de Pagamento";
            this.colFormaPagamento.FieldName = "FormaPagamento.NomeFormaPagamento";
            this.colFormaPagamento.Name = "colFormaPagamento";
            this.colFormaPagamento.Width = 119;
            // 
            // colFilial
            // 
            this.colFilial.AppearanceCell.Options.UseTextOptions = true;
            this.colFilial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFilial.AppearanceHeader.Options.UseTextOptions = true;
            this.colFilial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFilial.Caption = "Cód. Filial";
            this.colFilial.FieldName = "Filial.CodigoFilial";
            this.colFilial.Name = "colFilial";
            // 
            // colDataCancelamento
            // 
            this.colDataCancelamento.AppearanceCell.Options.UseTextOptions = true;
            this.colDataCancelamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataCancelamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colDataCancelamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDataCancelamento.Caption = "Dt. Cancelamento";
            this.colDataCancelamento.FieldName = "DataCancelamento";
            this.colDataCancelamento.Name = "colDataCancelamento";
            this.colDataCancelamento.Width = 100;
            // 
            // colMotivoCancelamento
            // 
            this.colMotivoCancelamento.AppearanceCell.Options.UseTextOptions = true;
            this.colMotivoCancelamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMotivoCancelamento.AppearanceHeader.Options.UseTextOptions = true;
            this.colMotivoCancelamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMotivoCancelamento.Caption = "Motivo Cancelamento";
            this.colMotivoCancelamento.FieldName = "MotivoCancelamento";
            this.colMotivoCancelamento.Name = "colMotivoCancelamento";
            this.colMotivoCancelamento.Width = 280;
            // 
            // LancamentoFinanceiroImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(782, 515);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LancamentoFinanceiroImport";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExcelFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraGrid.Columns.GridColumn colFormaPagamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFilial;
        private DevExpress.XtraGrid.Columns.GridColumn colDataCancelamento;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivoCancelamento;
    }
}
