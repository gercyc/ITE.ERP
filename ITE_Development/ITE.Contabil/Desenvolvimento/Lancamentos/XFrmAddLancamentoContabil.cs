using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Contabil;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.DaoManager.ContabilDaoManager;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.UnitControl;

namespace ITE.Contabil.Desenvolvimento.Lancamentos
{
    public partial class XFrmAddLancamentoContabil : DevExpress.XtraEditors.XtraForm
    {
        #region Variaveis
        private Usuario _currentUser;
        private LancamentoContabil _lancamentoCurrent;
        private LoteContabil _lote;
        private List<PartidaContabil> partidas;
        #endregion

        #region Construtures
        public XFrmAddLancamentoContabil()
        {
            InitializeComponent();
            dtEditLancamento.DateTime = DateTime.Now.Date;
            FormsUtil.AddShortcutEscapeOnDispose(this);
            lookUpMatriz1.FindSetMatriz(UnitWork.Filial.Matriz);
        }
        //adição
        public XFrmAddLancamentoContabil(Usuario _currentUser, LoteContabil _lote = null) : this()
        {
            this._currentUser = _currentUser;
            this._lote = _lote;
            this.partidas = new List<PartidaContabil>();

            if (_lote != null)
                lookUpMatriz1.FindSetMatriz(_lote.Matriz);

            refreshGrid();
        }

        //edição
        public XFrmAddLancamentoContabil(Usuario _currentUser, LancamentoContabil currentLancamento) : this()
        {
            this._currentUser = _currentUser;
            lookUpMatriz1.FindSetMatriz(currentLancamento.Matriz);
            this._lancamentoCurrent = currentLancamento;
            this.partidas = currentLancamento.Partidas.ToList();
            gridControlPartidas.DataSource = this.partidas;
            this.Text = "Lançamento: " + currentLancamento.NumeroLancamento;
            indexarFormulario();
        }
        #endregion

        #region Eventos

        private void btnAddPartida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //lancamento em edicao
            if (_lancamentoCurrent != null)
            {
                var addPartida = new XFrmAddPartida(_lancamentoCurrent);
                addPartida.ShowDialog();

                if (addPartida.Partida != null)
                {
                    partidas.Add(addPartida.Partida);
                }

                addPartida.Dispose();
                //atualize os valores de debito e credito
                lbDebitos.Caption = getValoresDebito();
                lbCreditos.Caption = getValoresCredito();
            }
            //lancamento em criacao
            else
            {
                var addPartida = new XFrmAddPartida(getLastIndexPartida());
                addPartida.ShowDialog();

                if (addPartida.Partida != null)
                {
                    partidas.Add(addPartida.Partida);
                }

                addPartida.Dispose();
                //atualize os valores de debito e credito
                lbDebitos.Caption = getValoresDebito();
                lbCreditos.Caption = getValoresCredito();
            }

            updateGrid();
        }

        //Edicao da partida selecionada
        private void btnEditarPartida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var partida = gridViewPartidas.GetFocusedRow<PartidaContabil>();
            if (partida != null)
            {
                var frmEdit = new XFrmAddPartida(partida);
                frmEdit.ShowDialog();

                if (frmEdit.Partida != null)
                {
                    partida.Update(frmEdit.Partida);
                    refreshGrid();
                }
            }
        }

        private void btnDelPartida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSaveLancamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var manager = new LancamentoContabilDaoManager();
            try
            {
                //adicao
                if (_lancamentoCurrent == null)
                {
                    var newLancto = indexarLancamento();
                    if (manager.SaveLancamento(newLancto))
                    {
                        XMessageIts.Mensagem("Lançamento criado com sucesso.");
                        this.Dispose();
                    }
                }
                else
                {
                    var lancEdit = indexarLancamento();

                    if (manager.Update(lancEdit))
                    {
                        XMessageIts.Mensagem("Lançamento atualizado com sucesso.");
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Erro ao salvar lançamento.");
                return;
            }

        }
        private void gridViewPartidas_DoubleClick(object sender, EventArgs e)
        {
            btnEditarPartida_ItemClick(null, null);
        }

        #endregion

        #region Metodos

        private void refreshGrid()
        {
            gridControlPartidas.DataSource = this.partidas.OrderBy(p => p.SequencialPartida);
            gridControlPartidas.RefreshDataSource();
        }
        private void indexarFormulario()
        {
            txtDescricao.Text = _lancamentoCurrent.Descricao;
            dtEditLancamento.DateTime = _lancamentoCurrent.DataLancamento;
            this.partidas = _lancamentoCurrent.Partidas.ToList();
            lbDebitos.Caption = _lancamentoCurrent.ValorDebito.ToString("N2");
            lbCreditos.Caption = _lancamentoCurrent.ValorCredito.ToString("N2");
            lbTotalLanc.Caption = _lancamentoCurrent.Valor.ToString("N2");
            refreshGrid();
        }

        private LancamentoContabil indexarLancamento()
        {
            var matriz = lookUpMatriz1.Matriz;

            LancamentoContabil l;

            if (_lancamentoCurrent != null)
                l = new LancamentoContabil(_lancamentoCurrent.Matriz, dtEditLancamento.DateTime, _currentUser);
            else
                l = new LancamentoContabil(matriz, dtEditLancamento.DateTime, _currentUser);

            //se estiver editando passa a PK 
            if (_lancamentoCurrent != null)
            {
                l.IdLancamentoContabil = _lancamentoCurrent.IdLancamentoContabil;
                //se alterou, atualize o user de alteracao tbm...
                l.IdUsuarioAlter = _currentUser.IdUsuario;
            }

            if (_lote != null)
                l.IdLoteOrigem = _lote.IdLote;

            l.DataLancamento = dtEditLancamento.DateTime;
            l.Descricao = txtDescricao.Text;

            int i = 1;
            foreach (var p in this.partidas)
            {
                var partida = new PartidaContabil();

                if (p.IdPartida != 0)
                    partida.IdPartida = p.IdPartida;

                partida.Update(p);
                partida.SequencialPartida = i++;
                l.Partidas.Add(partida);
            }
            l.ValorDebito = l.GetValoresDebito();
            l.ValorCredito = l.GetValoresCredito();
            l.Valor = l.GetValor();

            return l;
        }

        private int getLastIndexPartida()
        {
            return this.partidas.Count;
        }
        private string getValoresDebito()
        {
            return this.partidas.Where(p => p.IdContaContabilDeb != 0).Sum(p => p.ValorPartida).ToString("N2");
        }
        private string getValoresCredito()
        {
            return this.partidas.Where(p => p.IdContaContabilCred != 0).Sum(p => p.ValorPartida).ToString("N2");
        }
        private void updateGrid()
        {
            gridControlPartidas.DataSource = this.partidas;
            gridControlPartidas.RefreshDataSource();
        }
        #endregion


    }
}