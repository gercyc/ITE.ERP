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
using ITE.Entidades.POCO.Contabil;
using ITSolution.Framework.Web.Bacen;
using ITSolution.Framework.Util;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.GuiUtil;

namespace ITE.Contabil.Desenvolvimento.Lancamentos
{
    public partial class XFrmAddPartida : DevExpress.XtraEditors.XtraForm
    {
        private LancamentoContabil _lancamentoCurrent;
        private int quantidadePartidas;

        /// <summary>
        /// Partida que será retornada ao salvar.
        /// </summary>
        public PartidaContabil Partida { get; set; }

        #region Construtores
        public XFrmAddPartida()
        {
            InitializeComponent();
            lbNumLanc.Caption = "<Em edição>";
            FormsUtil.AddShortcutEscapeOnDispose(this);
            new TextEditUtil(txtVlrPartida).CustomizeNumberField();
            new TextEditUtil(txtVlrPartidaME).CustomizeNumberField();
        }
        public XFrmAddPartida(int qtdPartidas) : this()
        {
            lbNumLanc.Caption = "<Em edição>";
            this.quantidadePartidas = qtdPartidas;
        }
        public XFrmAddPartida(LancamentoContabil _lancamentoCurrent) : this()
        {
            this._lancamentoCurrent = _lancamentoCurrent;
            this.quantidadePartidas = _lancamentoCurrent.Partidas.Count;
            lbNumLanc.Caption = _lancamentoCurrent.NumeroLancamento;
        }
        //edicao da partida
        public XFrmAddPartida(PartidaContabil _partida) : this()
        {
            if (_partida.LancamentoContabil != null)
                lbNumLanc.Caption = _partida.LancamentoContabil.NumeroLancamento;

            this.Partida = _partida;

            //indexarFormulario();
        }

        #endregion

        #region Metodos
        private PartidaContabil indexarPartida()
        {
            var contaDebito = lkContaDebito.ContaContabil;
            var contaCredito = lkContaCredito.ContaContabil;
            var centro = lookUpCentroCusto1.CentroCusto;
            var participante = lookUpCliFor1.CliFor;
            var moeda = cbMoedaPrinc.SelectedItem as Moeda;
            var moedaEstr = cbMoedaEstr.SelectedItem as Moeda;

            if (contaDebito == null && contaCredito == null)
            {
                XMessageIts.Advertencia("Informe pelo menos uma conta contábil");
                return null;
            }


            var p = new PartidaContabil()
            {
                Historico = txtHistorico.Text,
                ValorPartida = ParseUtil.ToDecimal(txtVlrPartida.Text),
                ValorPartida2 = ParseUtil.ToDecimal(txtVlrPartidaME.Text),
                LocalizacaoFisDoc = txtLocalDoc.Text,
                SequencialPartida = this.quantidadePartidas + 1
            };

            if (participante != null)
            {
                p.Participante = participante;
                p.IdCliFor = participante.IdCliFor;
            }
            if (centro != null)
            {
                p.CentroCusto = centro;
                p.IdCentroCusto = centro.IdCentroCusto;
            }
            if (contaDebito != null)
            {
                p.ContaContabilDebito = contaDebito;
                p.IdContaContabilDeb = contaDebito.IdContaContabil;
            }
            if (contaCredito != null)
            {
                p.ContaContabilCredito = contaCredito;
                p.IdContaContabilCred = contaCredito.IdContaContabil;
            }
            if (moeda != null)
            {
                p.MoedaPrincipal = moeda;
                p.IdMoeda = moeda.IdMoeda;
            }
            else
            {
                XMessageIts.Advertencia("Selecione a moeda do lançamento");
            }

            if (moedaEstr != null)
            {
                p.MoedaEstrangeira = moedaEstr;
                p.IdMoeda2 = moedaEstr.IdMoeda;
            }

            return p;
        }

        private void indexarMoedas()
        {
            using (var ctx = new BalcaoContext())
            {
                var moedas = ctx.MoedaDao.FindAll();
                cbMoedaPrinc.Properties.Items.AddRange(moedas);
                cbMoedaEstr.Properties.Items.AddRange(moedas);

                //indexar o cb com o real
                var real = moedas.Find(r => r.IdMoeda == 10);
                cbMoedaPrinc.SelectedItem = real;
            }
        }

        private void indexarFormulario()
        {
            if (this.Partida != null)
            {
                var contaDebito = Partida.ContaContabilDebito.CodigoContaContabil;
                var contaCredito = Partida.ContaContabilCredito.CodigoContaContabil;
                var centro = Partida.CentroCusto;
                var participante = Partida.Participante;
                var moeda1 = Partida.MoedaPrincipal;
                var moeda2 = Partida.MoedaEstrangeira;

                var valor1 = Partida.ValorPartida;
                var valor2 = Partida.ValorPartida2;
                var locDoc = Partida.LocalizacaoFisDoc;
                var historico = Partida.Historico;

                txtHistorico.Text = historico;
                txtLocalDoc.Text = locDoc;
                txtVlrPartida.Text = valor1.ToString("N2");
                txtVlrPartidaME.Text = valor2.ToString("N2");

                if (contaDebito != null)
                    lkContaDebito.FindSetContaContabil(contaDebito);

                if (contaCredito != null)
                    lkContaCredito.FindSetContaContabil(contaCredito);

                if (centro != null)
                    lookUpCentroCusto1.FindSetCentroCusto(centro.CodigoCentroCusto);

                if (participante != null)
                    lookUpCliFor1.FindSetCliFor(participante.IdCliFor.ToString());

                if (moeda1 != null)
                    cbMoedaPrinc.SetSelectItem<Moeda>(moeda1);


                if (moeda2 != null)
                    cbMoedaEstr.SetSelectItem<Moeda>(moeda2);
            }
        }

        #endregion

        #region Eventos

        private void btnSalvarPartida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var partida = indexarPartida();
            if (partida != null)
            {
                this.Partida = partida;
                this.Close();
            }
        }

        private void btnSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void XFrmAddPartida_Shown(object sender, EventArgs e)
        {
            indexarMoedas();

            if (Partida != null)
            {
                indexarFormulario();
            }
        }

        #endregion


    }
}