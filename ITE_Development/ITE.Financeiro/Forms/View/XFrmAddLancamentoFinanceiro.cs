using System;
using ITE.Entidades.POCO;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Arquivos;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ITE.Entidades.POCO.Financeiro;
using System.Collections.Generic;
using ITE.Entidades.DaoManager.FinanceiroDaoManager;
using ITSolution.Framework.Beans.Forms;
using ITE.Financeiro.Forms.Wizard;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.Validador;
using ITE.Entidades.POCO.Sales;

namespace ITE.Financeiro.Forms.View
{
    public partial class XFrmAddLancamentoFinanceiro : DevExpress.XtraEditors.XtraForm
    {
        private readonly Usuario _currentUser;
        private LancamentoFinanceiro _lancAnt;

        /// <summary>
        /// Path dos arquivos digitalizados ou carregados
        /// <br>
        /// Os arquivos digitalizados são todos temporários
        /// </summary>
        private List<AnexoLancamento> _anexos = new List<AnexoLancamento>();

        private readonly List<string> _temps = new List<string>();

        #region Construtores

        private XFrmAddLancamentoFinanceiro()
        {
            InitializeComponent();
            this.dtEditEmissao.DateTime = DateTime.Now;
            //foco inicial no camp codigo
            this.ActiveControl = this.lookUpCentroCusto1.TextCodigoCentroCusto;
            this.lookUpCentroCusto1.TextCodigoCentroCusto.Focus();
            //cbStatusLancamento.Properties.Items.AddRange(Enum.GetValues(typeof(TypeStatusLancamentoFinanceiro)));
            lookUpFilial1.FindSetFilial(UnitWork.Filial);

            opFileComprovantePagto.Filter = FileManagerIts.AttachmentFilter;
            //"Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF,*.PDF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF;*.PDF|" + "All files (*.*)|*.*"; ;

            new TextEditUtil(this.txtValorJuros, 2).CustomizeNumberField();
            new TextEditUtil(this.txtValorLancamento, 2).CustomizeNumberField();

        }

        public XFrmAddLancamentoFinanceiro(LancamentoFinanceiro l, Usuario user) : this()
        {
            this._currentUser = user;
            this._lancAnt = this.indexarDados(l);
            FormsUtil.AddShortcutEscapeOnDispose(this);
            this.btnAssistente.Visible = false;
        }

        public XFrmAddLancamentoFinanceiro(Usuario user) : this()
        {
            this._currentUser = user;

        }

        #endregion

        #region Metodos

        private LancamentoFinanceiro indexarDados()
        {
            var dtEmissao = dtEditEmissao.DateTime;

            DateTime? dtVencimento = dtEditVencimento.DateTime;
            var vlrJuros = ParseUtil.ToDecimal(txtValorJuros.Text);
            var vlrLancamento = ParseUtil.ToDecimal(txtValorLancamento.Text);

            if (rdTipoLanc.SelectedIndex < 0)
            {
                XMessageIts.Advertencia("Informe o tipo/natureza do lançamento!");
                return null;
            }
            if (dtVencimento.ValidateDate() == null)
            {
                XMessageIts.Advertencia("Informe a data de vencimento!");
                return null;
            }

            if (string.IsNullOrEmpty(richObs.Text))
            {
                XMessageIts.Advertencia("Informe o histórico do lançamento!");
                return null;
            }
            if (dtEditEmissao.DateTime.ToDateZerada() > dtEditVencimento.DateTime.ToDateZerada())
            {
                XMessageIts.Advertencia("Data de emissão não pode ser maior que a data de vencimento!");
                return null;
            }
            LancamentoFinanceiro novo = new LancamentoFinanceiro
            {
                RecCreatedBy = _currentUser.IdUsuario,
                DataLancamento = dtEmissao,
                DataPagamento = null,
                DataVencimento = dtVencimento.Value,
                DiasPrazo = dtEmissao.CompareTo(dtVencimento),
                CentroCusto = lookUpCentroCusto1.CentroCusto,
                CliFor = lookUpCliFor1.CliFor,
                Filial = lookUpFilial1.Filial,
                Observacao = richObs.Text,
                SequencialParcela = 0,
                QuantidadeAnexos = this._anexos.Count

            };

            if (dtEditPagamento.DateTime.ValidateDate() != null)
            {
                novo.DataPagamento = dtEditPagamento.DateTime.Date;
            }
            if (cbFormaPagto.SelectedItem != null)
            {
                novo.IdFormaPagamento = cbFormaPagto.GetSelectedItem<FormaPagamento>().IdFormaPagamento;
            }

            if (novo.CentroCusto != null)
                novo.IdCentroCusto = novo.CentroCusto.IdCentroCusto;

            novo.IdCliFor = (novo.CliFor != null)
                ? lookUpCliFor1.CliFor.IdCliFor
                : 0;

            if (novo.Filial != null)
                novo.IdFilial = lookUpFilial1.Filial.IdFilial;


            foreach (AnexoLancamento a in _anexos)
            {
                novo.Anexos.Add(a);

            }
            //se selecionou algum...
            //que nao seja o status pago
            //o status pago so pode ser setado pelo wizard
            //aqui ele eh usado somente como referencia para a chamada do wizard
            if (cbStatusLancamento.SelectedIndex != -1 && cbStatusLancamento.SelectedIndex != 2)
                novo.StatusLancamento = (TypeStatusLancamentoFinanceiro)cbStatusLancamento.SelectedIndex;
            else //senao defina como Aberto (Padrão)
                novo.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;

            novo.TipoLancamento = (TypeLancamentoFinanceiro)rdTipoLanc.SelectedIndex;

            novo.ValorJuros = vlrJuros;
            novo.ValorLancamento = vlrLancamento;

            //rastreamento
            if (_lancAnt != null)
            {
                //garanto os dados
                novo.RecModifyDate = DateTime.Now.ValidateDate();
                novo.RecModifyBy = _currentUser.IdUsuario;
                novo.IdLancamento = _lancAnt.IdLancamento;
                novo.IdVenda = _lancAnt.IdVenda;
            }

            novo.ValidarLancamento();

            return novo;
        }

        private LancamentoFinanceiro indexarDados(LancamentoFinanceiro lancto)
        {
            if (lancto.CentroCusto != null)
                lookUpCentroCusto1.FindSetCentroCusto(lancto.CentroCusto.CodigoCentroCusto);

            if (lancto.CliFor != null)
                lookUpCliFor1.FindSetCliFor(lancto.CliFor.IdCliFor.ToString());

            lookUpFilial1.FindSetFilial(lancto.Filial.CodigoFilial);

            rdTipoLanc.SelectedIndex = (int)lancto.TipoLancamento;

            this.dtEditEmissao.DateTime = lancto.DataLancamento;
            this.dtEditVencimento.DateTime = lancto.DataVencimento;
            this.txtValorLancamento.Text = lancto.ValorLancamento.ToString("N2");
            this.txtValorJuros.Text = lancto.ValorJuros.ToString("N2");
            this.richObs.Text = lancto.Observacao;

            //indexado a partir 0
            this.cbStatusLancamento.SelectedIndex = (int)lancto.StatusLancamento;

            this._anexos = lancto.Anexos.ToList();
            this.gridControl1.DataSource = this._anexos;
            this.gridView1.RefreshData();

            statusView(lancto);

            //deixe colocar se ainda nao foi pago ou se nao tem anexos
            if (lancto.Anexos.Count == 0 ||
                lancto.StatusLancamento == TypeStatusLancamentoFinanceiro.Aberto
                || lancto.StatusLancamento == TypeStatusLancamentoFinanceiro.Vencido)
            {
                this.barBtnDigitalizar.Enabled = true;
                this.barBtnAnexar.Enabled = true;
                this.btnSalvarAnexos.Visible = true;
                this.btnRemoveAnexo.Visible = true;

                this.gridView1.OptionsBehavior.Editable = true;
                this.btnCancelar.Visible = false;

            }

            //se a venda eh nula entao eh um lançamento avulso
            if (lancto.IdVenda == null && lancto.StatusLancamento != TypeStatusLancamentoFinanceiro.Pago)
            {
                //flexibilidade
                dtEditEmissao.ReadOnly = false;
                dtEditVencimento.ReadOnly = false;
            }

            if (_currentUser.IsAdmin)
            {
                btnSalvarAnexos.Visible = true;
                btnRemoveAnexo.Visible = true;
            }
            return lancto;
        }

        private void ReadyOnlyMode()
        {
            //esse atalho so eh permitido na atualização
            FormsUtil.AddShortcutEscapeOnDispose(this);

            lookUpCentroCusto1.ReadOnlyMode();
            lookUpCliFor1.ReadOnlyMode();
            lookUpFilial1.ReadOnlyMode();
            ComponenteUtil.ReadyOnly(true,
                rdTipoLanc,
                cbStatusLancamento,
                cbFormaPagto,
                dtEditEmissao,
                dtEditPagamento,
                dtEditVencimento,
                txtValorLancamento,
                txtValorJuros,
                richObs);
            this.gridView1.OptionsBehavior.Editable = false;

            if (this._currentUser.IsAdmin == false)
            {
                this.barBtnAnexar.Enabled = false;
                this.barBtnDigitalizar.Enabled = false;
                this.btnRemoveAnexo.Visible = false;

            }
            this.btnSalvar.Text = "OK";

        }

        private void statusView(LancamentoFinanceiro l)
        {

            if (l.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago)
            {
                this.dtEditPagamento.Visible = true;
                this.lblDataPagto.Visible = true;

                //pago entao tem uma forma de pagamento
                this.cbFormaPagto.AddItem(l.FormaPagamento);
                this.cbFormaPagto.Visible = true;
                this.lblFrmPagamento.Visible = true;
                this.dtEditPagamento.DateTime = l.DataPagamento.Value;
            }

            if (l.StatusLancamento == TypeStatusLancamentoFinanceiro.Cancelado)
            {
                richObs.ForeColor = System.Drawing.Color.Red;

                this.richObs.AppendText(this.richObs.Text + "\n\r\n\r");

                if (!string.IsNullOrEmpty(l.MotivoCancelamento))
                    this.richObs.AppendText(l.MotivoCancelamento);

                this.lblCancelamento.Visible = true;
                this.dtEditCancelamento.DateTime = l.DataCancelamento.Value;
                this.dtEditCancelamento.Visible = true;
            }


            if (l.StatusLancamento == TypeStatusLancamentoFinanceiro.Cancelado
                || l.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago
                || l.IdVenda != null)
            {
                ReadyOnlyMode();
                gridView1.OptionsBehavior.Editable = false;


            }

            else
            {
                this.btnSalvar.Enabled = true;
                this.btnSalvar.Visible = true;

            }

            if (l.StatusLancamento == TypeStatusLancamentoFinanceiro.Aberto
                || l.StatusLancamento == TypeStatusLancamentoFinanceiro.Vencido)
                this.richObs.ReadOnly = false;
        }

        private void removeAnexo()
        {
            var anexo = gridView1.GetFocusedRow<AnexoLancamento>();
            gridView1.DeleteSelectedRows();
            this._anexos = this.gridView1.GetItens<AnexoLancamento>();
            gridView1.RefreshData();
        }



        #endregion

        #region Eventos Tab Principal

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text.Equals("OK") && _lancAnt != null &&
                _lancAnt.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago)
            {
                this.Dispose();
            }
            else
            {
                LancamentoFinanceiro novo = indexarDados();
                var status = (TypeStatusLancamentoFinanceiro)cbStatusLancamento.SelectedIndex;

                if (novo != null)
                {
                    try
                    {

                        var manager = new LancamentoDaoManager();
                        bool flag = false;
                        if (_lancAnt == null)
                        {
                            flag = manager.SaveLancamento(novo);
                            if (flag)
                            {
                                XMessageIts.Mensagem("Lancamento incluso com sucesso!\n\n"
                                                     + "Nº Lançamento: " + novo.IdLancamento);
                            }
                        }
                        else
                        {
                            flag = manager.UpdateLancamento(novo);
                            if (flag)
                            {
                                XMessageIts.Mensagem("Lancamento atualizado com sucesso!");

                                //atualiza no grid
                                this._lancAnt = novo;

                            }
                        }
                        if (flag)
                        {
                            //se setei como pago
                            if (status == TypeStatusLancamentoFinanceiro.Pago)
                            {
                                var lista = new List<LancamentoFinanceiro>();
                                
                                //use esse status pq ainda nao foi pago se nao ira confundir o usuario
                                //verificar se eh null, pq na criacao do lancamento ele eh null, somenta na edicao ele é 'fill'
                                if(this._lancAnt !=null)
                                novo.StatusLancamento = _lancAnt.StatusLancamento;

                                //recupera o lancto
                                var r = LancamentoDaoManager.FindCpl(novo);

                                lista.Add(r);
                                //chama o wizard para realizar a baixa
                                var wizard = new XFrmWizardBaixaLancamento(lista);
                                wizard.ShowDialog();

                                //se foi cancelada a baixa
                                if (wizard.IsBaixa == false)
                                {
                                    //consistencia o status do lançamento
                                    novo.StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto;
                                    //invoca o validar lançamento
                                    manager.UpdateLancamento(novo);
                                }
                                novo.Update(r);

                            }
                            //always
                            this.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        XMessageIts.ExceptionJustMessage(ex, "Falha durante a persistência do lançamento!");
                        this.Dispose();
                    }
                }
            }
        }

        private void gridControl1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnRemoveAnexo_Click(null, null);

                //menos 1 pois eh indexado partir do 0
                //-1 pq eu removi uma linha
                gridView1.FocusedRowHandle = this.gridView1.RowCount - 1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            barBtnVisualizarAnexo_ItemClick(null, null);

        }

        private void txtValorJuros_EditValueChanged(object sender, EventArgs e)
        {
            var juros = ParseUtil.ToDecimal(txtValorJuros.Text);
            this.lblTotal.Text = (ParseUtil.ToDecimal(txtValorLancamento.Text) + juros).ToString();

            if (juros != 0)
                this.lblTotal.Visible = true;
            else
                this.lblTotal.Visible = false;

        }

        private void btnAssistente_Click(object sender, EventArgs e)
        {
            var novo = indexarDados();

            if (ValidadorDTO.ValidateWarningAll(novo))
            {
                var asst = new XFrmAssitenteLancamentoFinanceiro(novo);

                asst.ShowDialog();

                if (!asst.IsCancel)
                    this.Dispose();
            }
        }

        private void XFrmAddLancamentoFinanceiro_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.T)
            {
                if (this.rdTipoLanc.SelectedIndex == 0)
                    this.rdTipoLanc.SelectedIndex = 1;
                else
                    this.rdTipoLanc.SelectedIndex = 0;
                this.rdTipoLanc.Focus();

            }
            //ctrl + shift + A
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.H)
                btnAssistente_Click(null, null);

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.L)
            {
                if (lookUpCentroCusto1.CentroCusto == null)
                    lookUpCentroCusto1.ShowSelectCentroCusto();

                else if (lookUpCliFor1.CliFor == null)
                    lookUpCliFor1.ShowSelectCliFor();

            }

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                if(xtraTabControl1.SelectedTabPageIndex == 0)
                    btnSalvar_Click(null, null);
                else
                    btnSalvarAnexos_Click(null, null);

            }
        }

        #endregion

        #region Eventos Tab Anexos

        private void btnSalvarAnexos_Click(object sender, EventArgs e)
        {
            if (gridView1.IsEmptyWarning())
            {
                LancamentoFinanceiro novo = indexarDados();
                if (novo != null)
                {
                    if (new LancamentoDaoManager().SalvarAnexos(novo))
                    {
                        if (_lancAnt == null)
                            XMessageIts.Mensagem("Anexos salvos com sucesso!");
                        else
                            XMessageIts.Mensagem("Anexos atualizados com sucesso!");

                        if (_lancAnt != null && _lancAnt.StatusLancamento == TypeStatusLancamentoFinanceiro.Pago)
                            this.Dispose();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void barBtnVisualizarAnexo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                var row = gridView1.GetFocusedRow<AnexoLancamento>();

                if (row != null)
                {
                    //evita um nome duplicado
                    string file = FileManagerIts.GetTempFile(row.PathFile);
                    FileManagerIts.DeleteFile(file);
                    FileManagerIts.WriteBytesToFile(file, row.DataFile);
                    FileManagerIts.OpenFromSystem(file);

                    this._temps.Add(file);

                }
            }
        }

        private void barBtnExportarAnexo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "All Files | *.*";

                var anexo = gridView1.GetFocusedRow<AnexoLancamento>();

                sfd.FileName = anexo.IdentificacaoAnexo + anexo.Extensao;
                var op = sfd.ShowDialog();

                if (op == DialogResult.OK)
                {

                    if (FileManagerIts.WriteBytesToFile(sfd.FileName, anexo.DataFile))
                    {
                        XMessageIts.Mensagem("Anexo salvo com sucesso!");
                    }
                    else
                    {
                        XMessageIts.Erro("Falha ao salvar anexo!");
                    }
                }
            }
        }

        private void barBtnExportarTodos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.IsSelectOneRowWarning())
            {
                var anexos = gridView1.GetItens<AnexoLancamento>();

                var destiny = Path.Combine(FileManagerIts.DeskTopPath,
                    "Anexos" + DateTime.Now.ToString("dd-MM-yyyy"));

                FileManagerIts.CreateDirectory(destiny);
                foreach (var anexo in anexos)
                {
                    string name = anexo.IdentificacaoAnexo.Replace("/", "-")
                                  + anexo.Extensao;
                    string fileName = Path.Combine(destiny, name);

                    if (FileManagerIts.WriteBytesToFile(fileName, anexo.DataFile))
                    {
                        XMessageIts.Mensagem("Anexo salvo com sucesso!");
                    }
                    else
                    {
                        XMessageIts.Erro("Falha ao salvar anexo!\n" + anexo.PathFile);
                    }
                }

            }
        }

        private void barBtnDigitalizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dig = new XFrmScanning();
            dig.ShowDialog();

            //pega os arquivos digitalizado/carregados
            foreach (string file in dig.DigitalizacoesPath)
            {
                this._anexos.Add(new AnexoLancamento(file));
            }
            gridControl1.DataSource = this._anexos;
            gridView1.FocusCurrentRow();
            gridView1.RefreshData();

        }

        private void barBtnAnexar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Implementaro carrossel de anexos aqui depois

            if (opFileComprovantePagto.ShowDialog() == DialogResult.OK)
            {
                var files = opFileComprovantePagto.FileNames;

                foreach (var path in files)
                {
                    this._anexos.Add(new AnexoLancamento(path));
                }

                this.gridControl1.DataSource = this._anexos;
                gridView1.RefreshData();
            }
        }

        private void btnRemoveAnexo_Click(object sender, EventArgs e)
        {
            if (_lancAnt != null)
            {

                if (gridView1.IsSelectOneRowWarning())
                {
                    if (_lancAnt.StatusLancamento != TypeStatusLancamentoFinanceiro.Cancelado
                        && _lancAnt.StatusLancamento != TypeStatusLancamentoFinanceiro.Pago)
                    {
                        removeAnexo();
                    }
                    else
                        XMessageIts.Erro("Anexo não pode ser removido !", "Acesso negado");
                }
            }
            else
            {
                removeAnexo();
            }
        }

        #endregion

        private void XFrmAddLancamentoFinanceiro_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //apague os temporario q foram criados
                this._temps.ForEach(File.Delete);
            }
            catch
            {
                this._temps.Clear();
                //FODASE//FODASE//FODASE FODASE FODASE
            }

        }

        private void XFrmAddLancamentoFinanceiro_Shown(object sender, EventArgs e)
        {
            //se esse lancto eh null entao nao faz sentido eu deixar criar um lancto com status cancelado.
            //o vencido fica no validador
            if (this._lancAnt == null)
            {
                //remova o cancelar/vencido
                this.cbStatusLancamento.Properties.Items.RemoveAt(2);
                //remove o 3 que passou a 2
                this.cbStatusLancamento.Properties.Items.RemoveAt(2);
            }
        }
    }
}