using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.DaoManager.FinanceiroDaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITE.Financeiro.Forms.View;
using ITE.Financeiro.Forms.Filters;
using ITE.Financeiro.Forms.Wizard;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Eventos.GridViewEvents;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Reports.Util;

namespace ITE.Financeiro.Forms.ListView
{
    public partial class XFrmLancamentoFinanceiroListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private XFrmFiltrarLancamentos _xFrmFiltrarLancamentos;
        private readonly Usuario _user;
        ///nome do relatorio
        private string _reportName;
        private bool _cancelTask;
        private readonly LancamentoDaoManager _lanManager;
        private readonly FocusRowChangedEvent _gridFocusUtil;
        private Form _xFrmMenu;

        #region Construtores

        private XFrmLancamentoFinanceiroListView()
        {
            InitializeComponent();

            repComboStatus.Items.AddRange(Enum.GetValues(typeof(TypeStatusLancamentoFinanceiro)));
            repComboNatureza.Items.AddRange(Enum.GetValues(typeof(TypeLancamentoFinanceiro)));

            //bloquea a add de texto
            repComboStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            repComboNatureza.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            this._lanManager = new LancamentoDaoManager();

            this._gridFocusUtil = new FocusRowChangedEvent(gridViewLancamentos);

            //cancela o eventos da barEdit
            //garante somente o evento que estou disparando agora
            this._cancelTask = true;

            //Dispara o evento barEditTipo_EditValueChanged e carrega os lançamentos pelo os status
            //nao vai disparar pq eu cancelei o eventos
            this.barEditTipo.EditValue = TypeLancamentoFinanceiro.Todos;
            //Dispara o evento barEditStatus_EditValueChanged e carrega os lançamentos pelo os status
            //nao vai disparar pq eu cancelei o eventos
            this.barEditStatus.EditValue = TypeStatusLancamentoFinanceiro.Vencido;

            dtEditInicio.Value = DataUtil.GetDataInicialDoMesAtual();
            dtEditFinal.Value = DataUtil.GetDataFinalDoMesAtual();
        }

        public XFrmLancamentoFinanceiroListView(Usuario user, Form menu)
            : this()
        {
            this._user = user;
            this._xFrmMenu = menu;
        }

        #endregion Construtores 

        #region Metodos

        //tirando os anexos a performace aumenta significativamente
        //entao os anexos serao caregados somente quando precisar visualizalos
        private async Task carregarLancamentos()
        {
            var tipo = (TypeLancamentoFinanceiro)barEditTipo.EditValue;
            var status = (TypeStatusLancamentoFinanceiro)barEditStatus.EditValue;

            //padrão de carregamento será aberto
            barEditStatus.EditValue = status;

            //searchControl1.EditValue = "";
            //searchControl1.Text = "";

            barCheckContasPagar.Checked = false;
            barCheckContasReceber.Checked = false;

            //gridViewLancamentos.FindFilterText = "";
            //gridViewLancamentos.FindFilterText = null;

            //carregando lancamentos usando eager
            var lista = await Task.Run(() => _lanManager.FindLancamentos(tipo, status));

            gridControlLancamentos.DataSource = lista;
            if (lista != null)
                this._gridFocusUtil.KeepFocusedRowChanged();


        }

        /// <summary>
        /// O lancamento tera seu status apenas alterado pra cancelado
        /// </summary>
        public void DeleteItemClick()
        {
            if (gridViewLancamentos.IsSelectOneRowWarning())
            {
                var l = gridViewLancamentos.GetFocusedRow() as LancamentoFinanceiro;

                if (l.StatusLancamento != TypeStatusLancamentoFinanceiro.Cancelado)
                    XMessageIts.Advertencia("Status do lançamento é \"cancelado\"", "Operação não permitida");
                else
                {
                    using (var ctx = new BalcaoContext())
                    {
                        ctx.LazyLoading(false);

                        if (l.IdVenda != null)
                            XMessageIts.Advertencia("O lançamento selecionado está vinculado a uma venda.\n\n" +
                                "Para cancelar esse lançamento basta cancelar a venda.", "Atenção");
                        else
                        {
                            ctx.LazyLoading(false);
                            var lan = ctx.LancamentoFinanceiroDao.Find(l.IdLancamento);
                            var msg = "Certeza que deseja excluir o lançamento selecionado?";
                            var op = XMessageIts.Confirmacao(msg);
                            if (op == DialogResult.Yes)
                            {
                                lan.StatusLancamento = TypeStatusLancamentoFinanceiro.Cancelado;
                                lan.DataCancelamento = DateTime.Now;
                                //drop
                                if (ctx.LancamentoFinanceiroDao.Update(lan))
                                {
                                    //XGridViewUtil.DeleteRow(gridViewLancamentosFin);
                                    l.Update(lan);

                                    XMessageIts.Mensagem("Lancamento nº "
                                        + lan.IdLancamento + " cancelado com sucesso");
                                }
                            }
                        }
                    }

                }
            }
        }

        public void RefreshItemClick()
        {
            XFrmWait.StartTask(carregarLancamentos(), "Carregando Lançamentos");

            //permite as tarefas serem executadas
            this._cancelTask = false;

        }

        private void setReportName()
        {
            if (barCheckContasReceber.Checked)
            {
                this._reportName = "ReportContasReceberPeriodo";
            }
            else if (barCheckContasPagar.Checked)
            {
                this._reportName = "ReportContasPagarPeriodo";
            }

            else
            {
                this._reportName = null;
            }
        }

        #endregion

        #region Eventos Gerenciamento/Outros

        private void barBtnNovoLancamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmAddLancamentoFinanceiro(_user).ShowDialog();
        }

        private void barBtnEditViewLancamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LancamentoFinanceiro lan = gridViewLancamentos.GetFocusedRow() as LancamentoFinanceiro;
            if (lan != null)
            {
                //passa o lancamento completo
                var current = LancamentoDaoManager.FindCpl(lan);

                var frm = new XFrmAddLancamentoFinanceiro(current, this._user);

                frm.ShowDialog();

                //atualiza no grid conforme no banco
                lan.Update(LancamentoDaoManager.Find(lan), true);

                //notifica o grid
                //gridViewLancamentos.RefreshData();

            }
        }

        private void barBtnCancelarLancamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);
                try
                {

                    //verifica se existe pelo menos uma conta
                    var conta = ctx.ContaBancariaDao.First();
                    //se chegou aqui a conta existe
                    List<LancamentoFinanceiro> lancamentos =
                        gridViewLancamentos.GetSelectedItens<LancamentoFinanceiro>();

                    if (lancamentos.Exists(l => l.StatusLancamento == TypeStatusLancamentoFinanceiro.Cancelado))
                    {
                        XMessageIts.Advertencia("Existem lançamentos cancelados selecionados", "Atenção - Operação cancelada");
                    }
                    else if (lancamentos.Exists(l => l.IdVenda != null))
                        XMessageIts.Advertencia("O(s) lançamento(s) selecionado(s) estão vinculado(s) a uma venda.\n\n" +
                        "Para cancelar esse lançamento basta cancelar a venda.", "Atenção");

                    else
                    {
                        if (lancamentos.Count > 0)
                        {
                            var wizard = new XFrmWizardCancelamentoLancamento(lancamentos);

                            wizard.ShowDialog();

                            if (wizard.IsBaixa)
                            {
                                gridViewLancamentos.RefreshData();
                            }
                        }
                        else
                        {
                            XMessageIts.Mensagem("Nenhum lançamento(s) a ser baixado!");
                        }
                    }
                }  //nao existe avise
                catch (Exception)
                {
                    XMessageIts.Advertencia("Para a baixa de lançamento(s) é necessário cadastrar "
                        + "uma conta para crédito/débito.", "Aviso");
                }
            }
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshItemClick();
        }

        private void barBtnBaixarLancamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);
                //verifica se existe pelo menos uma conta
                if (ctx.ContaBancariaDao.CheckFirst())
                {
                    List<LancamentoFinanceiro> lanctos =
                        gridViewLancamentos.GetSelectedItens<LancamentoFinanceiro>();

                    if (lanctos.Exists(l => l.StatusLancamento == TypeStatusLancamentoFinanceiro.Cancelado))
                    {
                        XMessageIts.Advertencia("Existem lançamentos cancelados selecionados, e não pode ser baixados!",
                            "Atenção - Operação cancelada");
                    }
                    else if (lanctos.Exists(l => l.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago))
                    {
                        XMessageIts.Advertencia("Existem lançamentos já baixados selecionados, por favor volte a tela do grid e desmarque esses lançamentos!",
                            "Atenção - Operação cancelada");

                    }
                    else
                    {
                        if (lanctos.Count > 0)
                        {
                            XFrmWizardBaixaLancamento wizard = new XFrmWizardBaixaLancamento(lanctos);

                            wizard.ShowDialog();

                            if (wizard.IsBaixa)
                            {
                                //deixe o grid exatamente como no banco
                                foreach (var l in lanctos)
                                    l.Update(LancamentoDaoManager.Find(l));

                                gridViewLancamentos.RefreshData();
                            }
                        }
                        else
                        {
                            XMessageIts.Mensagem("Nenhum lançamento(s) a ser baixado!");
                        }
                    }
                }
                else//nao existe avise
                {
                    XMessageIts.Advertencia("Para a baixa de lançamento(s) é necessário cadastrar "
                        + "uma conta para crédito/débito.", "Aviso");
                }
            }
        }

        //Cancelamento de baixas/pagamentos
        private void barBtnCancelaBaixa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewLancamentos.IsEmptyWarning())
            {
                List<LancamentoFinanceiro> lanctos = gridViewLancamentos.GetSelectedItens<LancamentoFinanceiro>();

                //verifica a lista de lancs selecionados, se houver algum lancamento com status != Pago, entra no if e exibe a mensagem
                var countStatus = lanctos.Count(p => p.StatusLancamento != TypeStatusLancamentoFinanceiro.Pago);

                if (countStatus > 0)
                {
                    XMessageIts.Advertencia("O cancelamento da baixa pode ser executado somente para lançamentos com status \"Pago\"." +
                        "\nPor favor revise os lançamentos que foram selecionados.", "Atenção!");
                }
                else
                {
                    var msg = "Tem certeza que deseja cancelar a baixa dos lançamentos selecionados?";
                    var op = XMessageIts.Confirmacao(msg);
                    if (op == DialogResult.Yes)
                    {
                        //nao gostei disso
                        var result = _lanManager.CancelarBaixa(lanctos, DateTime.Now.Date);
                        if (result)
                        {
                            XMessageIts.Mensagem("Baixa(s) cancelada(s) com sucesso!");
                            //deixe o grid exatamente como no banco
                            foreach (var l in lanctos)
                                l.Update(LancamentoDaoManager.Find(l));

                            gridViewLancamentos.RefreshData();
                        }
                    }
                }
            }
        }

        private void barBtnParcelarLancto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewLancamentos.IsSelectOneRowWarning())
            {
                var row = LancamentoDaoManager.Find(gridViewLancamentos.GetFocusedRow<LancamentoFinanceiro>());
                new XFrmAssitenteLancamentoFinanceiro(row, FormTypeAction.Alterar).ShowDialog();
            }
        }

        private void XFrmLancamentoFinanceiroView_Shown(object sender, EventArgs e)
        {
            barBtnRefresh_ItemClick(null, null);
        }

        private void gridViewLancamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                barBtnEditViewLancamento_ItemClick(null, null);
        }

        #endregion

        #region Eventos Relatórios 

        private void barCheckContasReceber_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            setReportName();
        }

        private void barCheckContasPagar_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            setReportName();
        }


        private async void barEditStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (!this._cancelTask)
            {
                string search = "" + searchControl1.EditValue;
                var tipo = (TypeLancamentoFinanceiro)barEditTipo.EditValue;
                var status = (TypeStatusLancamentoFinanceiro)barEditStatus.EditValue;

                if (string.IsNullOrEmpty(search))
                    gridControlLancamentos.DataSource = await _lanManager.FindLancamentos(tipo, status);
                else
                    gridControlLancamentos.DataSource = await _lanManager.FindLancamentosLikeCliente(search, tipo, status);
                //garante a execução de uma nova task
                this._cancelTask = false;
            }
        }

        private async void barEditTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (!_cancelTask)
            {
                var tipo = (TypeLancamentoFinanceiro)barEditTipo.EditValue;
                var status = (TypeStatusLancamentoFinanceiro)barEditStatus.EditValue;

                gridControlLancamentos.DataSource = await _lanManager.FindLancamentos(tipo, status);
                //garante a execução de uma nova task
                this._cancelTask = false;
            }
        }

        private void barBtnGenerateReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (FormsUtil.isFormDisposedOrNull(_xFrmFiltrarLancamentos))
                this._xFrmFiltrarLancamentos = new XFrmFiltrarLancamentos();

            FormsUtil.Show(this._xFrmFiltrarLancamentos, this._xFrmMenu);

        }

        private void btnPrintReportNow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_reportName != null || barCheckContasPagar.Checked || barCheckContasReceber.Checked)
                ReportUtil.PrintReportByName(_reportName);
            else
            {
                XMessageIts.Mensagem("Selecione o relatório a ser gerado !");
            }
        }

        #endregion

        #region Search Control

        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            //se o evento nao foi cancelado
            if (!this._cancelTask)
            {
                string search = "" + searchControl1.EditValue;

                if (string.IsNullOrEmpty(search))
                {
                    RefreshItemClick();
                }
            }
        }

        private async void searchControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = "" + searchControl1.EditValue;
                var tipo = (TypeLancamentoFinanceiro)barEditTipo.EditValue;
                var status = (TypeStatusLancamentoFinanceiro)barEditStatus.EditValue;

                if (!string.IsNullOrEmpty(search))
                {
                    this.gridViewLancamentos.FindFilterText = search;
                    //this.barEditStatus.EditValue = TypeStatusLancamentoFinanceiro.Todos;
                    //this.barEditTipo.EditValue = TypeLancamentoFinanceiro.Todos;
                    this.gridControlLancamentos.DataSource = await _lanManager.FindLancamentosLikeCliente(search, tipo, status);
                }
            }
        }

        #endregion

        #region Eventos Utilitarios

        private void btnSelectCols_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLancamentos.ColumnsCustomization();
        }

        private void btnFilter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLancamentos.ShowFilterEditor(colTipoLancamento);

        }

        private void btnPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLancamentos.ShowPrintPreview();
        }

        private void btnExpExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var save = new SaveFileDialog();

            if (save.FileName != null)
                gridViewLancamentos.ExportToXlsx(save.FileName);
            else
                XMessageIts.Advertencia("Caminho do arquivo não informado.", "Operação cancelada!");
        }

        private void barBtnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewLancamentos.IsEmpty)
            {
                XMessageIts.Mensagem("Nada a exportar !");
            }
            else
            {
                string excelName = "Lançamentos_export_" + DataUtil.ToDateSql();
                string excel = Path.Combine(FileManagerIts.DeskTopPath, excelName) + ".xlsx";

                if (File.Exists(excel))
                    excel = FileManagerIts.GetTempFileFromDir(excel);

                gridControlLancamentos.ExportToXlsx(excel);
                FileManagerIts.OpenFromSystem(excel);
            }
        }


        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            //nao ta pronto ainda
            string search = "" + searchControl1.EditValue;

            var dtInicio = dtEditInicio.Value.ToDateZerada();
            var dtFim = dtEditFinal.Value.ToDateZerada();

            if (dtInicio <= dtFim)
            {
                this.gridViewLancamentos.FindFilterText = search;
                var list = await _lanManager
                                .FiltrarLancamentos(search, dtInicio, dtFim);
                this.gridControlLancamentos.DataSource = list;
            }
            else
            {
                XMessageIts.Mensagem("Data de início deve ser maior ou igual a data final.");
            }

        }
        #endregion

        #region Eventos do grid
        private void gridViewLancamentosFin_DoubleClick(object sender, EventArgs e)
        {
            barBtnEditViewLancamento_ItemClick(null, null);
        }

        #endregion

    }
}