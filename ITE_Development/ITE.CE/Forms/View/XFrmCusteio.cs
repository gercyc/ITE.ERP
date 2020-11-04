using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.CE;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Web.Bacen;
using ITE.Entidades.Enumeradores.CEEnums;
using System.Linq;
using DevExpress.Data.Extensions;

namespace ITE.CE.Forms.View
{
    public partial class XFrmCusteio : DevExpress.XtraEditors.XtraForm
    {
        private Custeio _custeio;
        private List<ItemCusteio> _mercadorias;
        private List<DespesaCusteio> _despesas;
        private List<CotacaoCusteio> _cotacoes;
        private Usuario _user;
        private CotacaoMonetaria cotacaoMonetaria;

        public XFrmCusteio(Usuario user)
        {
            InitializeComponent();
            this._user = user;
            this._mercadorias = new List<ItemCusteio>();
            this._despesas = new List<DespesaCusteio>();
            this._cotacoes = new List<CotacaoCusteio>();

            //ReflectionIts.ShowComponentsFromForm(this);

        }


        public XFrmCusteio(Custeio custeio):this(custeio.Usuario)
        {
            this._custeio = indexarDados(custeio);
        }

        private Custeio indexarDados()
        {
            string container = textEditContainer.Text;
            var qtdeContainer = ParseUtil.ToInt(textEditQtdeContainer.Text);
            var capatazia = ParseUtil.ToDecimal(textEditCapatazia.Text);
            CliFor cliFor = lookUpCliFor1.CliFor;
            string exportador = textEditExportador.Text;
            string fabricante = textEditFabricante.Text;
            string cotacao = radioGroupCotacao.Text;
            string unidadeMed = cbUnidadeMed.Text;
            string transporte = cbTransporte.Text;
            var cotacaoMoeda = _cotacoes.IsValidIndex(0) ? _cotacoes.First().ValorMoeda : 0M;
            string moedas = cbMoedas.Text;
            string paisDestino = cbPaisDestino.Text;
            string paisOrigem = cbPaisOrigem.Text;
            string moEditObs = memoEditObs.Text;
            string destino = textEditDestino.Text;
            string origem = textEditOrigem.Text;

            Custeio c = new Custeio()
            {
                ValorMoedaEstrangeira = cotacaoMoeda,
                
                Container = container,
                QuantideContainer = qtdeContainer,
                ValorCapatazia = capatazia,
                Cliente = cliFor,
                IdCliente = cliFor.IdCliFor,
                Exportador = exportador,
                Fabricante = fabricante,
                PaisDestino = paisDestino,
                PaisOrigem = paisOrigem,
                Observacao = moEditObs,
                PortoOrigem = origem,
                PortoDestino = destino,
                DataCalculo = dtPickerData.Value,
                DespesasCusteio = _despesas,
                ItensCusteio = _mercadorias
                //Moedas = _cotacoes
            };

            c.ICMSTotal = c.CalcICMSTotalBrl();
            c.ICMSSTTotal = c.CalcICMSSTTotalBrl();
            c.IPITotal = c.CalcIPITotalBrl();
            c.IITotal = c.CalcIITotalBrl();
            c.PISTotal = c.CalcPISTotalBrl();
            c.CofinsTotal = c.CalcCofinsTotalBrl();
            c.ValorFobTotal = c.CalcFobTotal();
            
            c.TotalCusteio = c.CalcTotalCusteioReais();
            c.ValorMoedaEstrangeira = c.CalcTotalCusteioME();

            return c;
        }

        private Custeio indexarDados(Custeio custeio)
        {
            //indexar 


            return custeio;
        }

        #region  Metodos

        private void loadCurrencyExchange()
        {
            string currencyName = "";
            string currencyValue = "";
            var o = cbMoedas.SelectedItem as Moeda;
            var sb = new StringBuilder();
            pictureBoxProgress.BeginInvoke(new Action(() =>
            {
                pictureBoxProgress.Visible = true;
            }));

            if (o != null && o.CodigoWSVenda != 0)
            {
                sb.Append("COTAÇÃO MOEDA: ");
                sb.Append(o.NomeMoeda);
                sb.Append(" | ");
                sb.Append(DateTime.Now.ToShortDateString());

                if (_custeio == null)
                {
                    try
                    {
                        using (var ws = new WSBacenCambio())
                        {
                            var cot = ws.GetCotacaoByCodigo((TypeCodigoBacen)o.CodigoWSVenda);
                            cot.Moeda = o;
                            //pode lançar exceção
                            if (cot == null)
                            {
                                cot = new CambioContext().CotacaoMonetariaDao.Last();
                            }
                            this.cotacaoMonetaria = cot;
                            sb.Append(" | ");
                            sb.Append(cot.Fonte);

                            if (radioGroupCotacao.SelectedIndex == 1)
                            {
                                currencyValue = cot.ValorVenda.ToString("N4");
                                sb.Append(" | VENDA");
                                sb.Append(" : ");

                            }

                            else
                            {
                                currencyValue = cot.ValorCompra.ToString("N4");
                                sb.Append(" | COMPRA");
                                sb.Append(" : ");

                            }
                            sb.Append(currencyValue);

                            //termina a string
                            currencyName = sb.ToString();

                        }

                    }
                    catch (Exception exception)
                    {
                        XMessageIts.ExceptionMessageDetails(exception, "Falha na moeda");
                        currencyName = "COTAÇÃO NÃO DISPONIVÉL";
                        currencyValue = "0,00";
                    }
                } //se os valores da ci
                else
                {
                    currencyValue = _custeio.ValorMoedaReais.ToString("n2");

                    sb.Append(" : ");
                    sb.Append(currencyValue);
                    //termina a string
                    currencyName = sb.ToString();
                }

                this.Invoke(new MethodInvoker(delegate
                {
                    lblMoedaName.Text = currencyName;
                    textEditCotacaoMoeda.Text = currencyValue;
                    pictureBoxProgress.Visible = false;
                }));
                //lblMoedaName.BeginInvoke(new Action(() =>
                //{
                //    lblMoedaName.Text = currencyName;
                //}));

                //textEditCotacaoMoeda.BeginInvoke(new Action(() =>
                //{
                //    textEditCotacaoMoeda.Text = currencyValue;
                //}));

                //pictureBoxProgress.BeginInvoke(new Action(() =>
                //{
                //    pictureBoxProgress.Visible = true;
                //}));
            }
        }


        private async void load()
        {

            using (var ctx = new BalcaoContext(false))
            {
                var moedas = await ctx.MoedaDao.FindAllAsync();
                var paises = await ctx.PaisDao.FindAllAsync();
                var unids = await ctx.UnidadeMedidaDao.FindAllAsync();
                this.Invoke(new MethodInvoker(delegate
                {
                    cbMoedas.AddList(moedas, false);

                    repComboMoedas.Items.Clear();
                    foreach (var m in moedas)
                    {
                        repComboMoedas.Items.Add(m);
                    }
                    cbPaisOrigem.AddList(paises, false);
                    cbPaisDestino.AddList(paises, false);
                    cbUnidadeMed.AddList(unids, false);

                        //add o evento
                        this.cbMoedas.SelectedIndexChanged += new System.EventHandler(this.cbMoeda_SelectedIndexChanged);
                    pictureBoxProgress.Visible = false;
                    ComboBoxUtil.AddEnumValues<TypeTipoCotacao>(cbTipoCotacao);
                }));

            }
        }

        #endregion

        #region  Mercadoria

        private void barBtnItemAddMercadoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cotacoes != null)
            {
                var firstCotacao = _cotacoes.First();

                if (firstCotacao != null)
                {
                    var frm = new XFrmAddMercadoria(firstCotacao);
                    frm.ShowDialog();
                    if (frm.Mercadoria != null)
                    {
                        frm.Mercadoria.Sequencial = _mercadorias.Count + 1;
                        this._mercadorias.Add(frm.Mercadoria);
                        gridControlMercadoria.DataSource = this._mercadorias;
                    }
                }
            }
            else
                XMessageIts.Advertencia("Selecione ao menos a moeda para seguir com a simulação do item!");
        }

        private void barBtnItemEditarMercadoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var mercadoria = this.gridViewDespesa.GetFocusedRow<ItemCusteio>();
            if (mercadoria != null)
                new XFrmAddMercadoria(mercadoria).ShowDialog();
        }

        private void barBtnItemRemoveMercadoria_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var mercadoria = this.gridViewMercadoria.GetFocusedRow<ItemCusteio>();

            if (mercadoria != null)
            {
                var op =
                    XMessageIts.Confirmacao(
                        "Deseja remover o item selecionado ?\n\nMercadoria:" + mercadoria.Mercadoria,
                        "Remoção de mercadoria");

                if (op == DialogResult.Yes)
                {
                    this._mercadorias.Remove(mercadoria);
                    gridViewMercadoria.DeleteSelectedRows();
                    gridViewMercadoria.RefreshData();
                }
            }
        }

        #endregion

        #region Despesas 
        private void barBtnItemAddDespesa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new XFrmAddDespesa();
            frm.ShowDialog();

            if (frm.Despesa != null)
            {
                frm.Despesa.Sequencial = _despesas.Count + 1;
                this._despesas.Add(frm.Despesa);

                gridControlDespesa.DataSource = this._despesas;
            }
        }

        private void barBtnItemEditarDespesa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var despesa = this.gridViewDespesa.GetFocusedRow<DespesaCusteio>();
            if (despesa != null)
                new XFrmAddDespesa(despesa).ShowDialog();

        }

        private void barBtnItemRemoveDespesa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var despesa = this.gridViewDespesa.GetFocusedRow<DespesaCusteio>();

            if (despesa != null)
            {
                var op =
                    XMessageIts.Confirmacao(
                        "Deseja remover o item selecionado ?\n\nValor:" + despesa.ValorDespesa,
                        "Remoção de mercadoria");

                if (op == DialogResult.Yes)
                {
                    this._despesas.Remove(despesa);
                    gridViewDespesa.DeleteSelectedRows();
                    gridViewDespesa.RefreshData();
                }
            }
        }

        #endregion

        #region  Eventos

        private void cbMoeda_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Task.Run(() => loadCurrencyExchange());
        }

        private void XFrmCusteio_Shown(object sender, System.EventArgs e)
        {
            Task.Run(() => load());
        }

        private void radioGroupCotacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCurrencyExchange();
        }

        private void simpleButtonSalvar_Click(object sender, EventArgs e)
        {
            var c = indexarDados();
        }

        private void btnViewCotacoes_Click(object sender, EventArgs e)
        {
            var stFlyout = flyoutPanel1.IsPopupOpen;
            if (stFlyout)
                flyoutPanel1.HidePopup();
            else
                flyoutPanel1.ShowPopup();
        }

        private void btnAddCotacao_Click(object sender, EventArgs e)
        {
            var moeda = cbMoedas.SelectedItem as Moeda;
            var dtCotacao = dtPickerData.Value;
            var tipoCotacao = (int)cbTipoCotacao.SelectedIndex;
            var vlrCotacao = ParseUtil.ToDecimal(textEditCotacaoMoeda.Text);

            var cotacao = new CotacaoCusteio()
            {
                DataCotacao = dtCotacao,
                Moeda = moeda,
                IdMoeda = moeda.IdMoeda,
                TipoCotacao = (TypeTipoCotacao)tipoCotacao,
                ValorMoeda = vlrCotacao
            };

            if (cotacao != null)
            {
                this._cotacoes.Add(cotacao);
                gridControlCotacoes.DataSource = this._cotacoes;
            }
        }

        private void gridViewCotacoes_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {

        }

        #endregion


        //private void rounded_Paint(object sender, PaintEventArgs e)
        //{
        //    /* Cria um objeto do tipo GraphicsPath que modifica a forma
        //   do botão em questão*/
        //    GraphicsPath forma = new GraphicsPath();
        //    /* Define como uma elipse o formato do objeto criado
        //     atribuindo valores para os parâmetros de posição e tamanho*/
        //    forma.AddEllipse(0, 0, simpleButton5.Width, simpleButton5.Height);
        //    /* Define a região do botão a ser arredondado, ou seja,
        //    o botão em si*/
        //    simpleButton5.Region = new Region(forma);
        //}

    }
}
