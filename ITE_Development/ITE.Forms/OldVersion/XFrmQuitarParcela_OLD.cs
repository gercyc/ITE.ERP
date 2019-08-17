using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Forms.OldVersion
{
    public partial class XFrmQuitarParcela_OLD : DevExpress.XtraEditors.XtraForm
    {
        private List<LancamentoFinanceiro> lista = new List<LancamentoFinanceiro>();
        public bool IsQuitado { get; set; }

        private XFrmQuitarParcela_OLD()
        {
            InitializeComponent();
            this.ActiveControl = this.txtVlrRecebido;
            this.txtVlrRecebido.Focus();
            this.lista = new List<LancamentoFinanceiro>();

        }

        public XFrmQuitarParcela_OLD(List<LancamentoFinanceiro> parcelas)
            : this()
        {
            var totalPagar = 0m;
            foreach (var item in parcelas)
            {
                if (item.StatusLancamento == TypeStatusLancamentoFinanceiro.Aberto)
                {
                    lista.Add(item);
                    totalPagar += item.ValorLancamento + item.ValorJuros;
                }
            }

            this.txtVlrRecebido.Text = totalPagar.ToString("N2");
            this.txtTotalPagar.Text = totalPagar.ToString("N2");

            if (lista.Count > 0)
            {
                gridControlParcelasVenda.DataSource = lista;

                gridViewParcelas.SelectAllRow();

                var cliFor = parcelas.FirstOrDefault().CliFor;

                var credito = cliFor.CreditosCliente.Sum(cd => cd.ValorCredito);

                if (credito > 0)
                {
                    txtCredito.Visible = true;
                    lblCredito.Visible = true;
                    txtCredito.Text = credito.ToString("N2");
                    lblMsg.Visible = true;
                    lblMsg.Text = "Você possui créditos ! O valor do crédito será abatido automaticamente.";
                }

                calcularValores();
            }

        }


        /*public XFrmQuitarParcela(Venda venda)
            : this()
        {
            var parcelas = venda.Parcelas.ToList().FindAll(p => p.DataPagamento == null);
            gridControlParcelasVenda.DataSource = parcelas;
            gridViewParcelas.SelectRange(0, gridViewParcelas.RowCount - 1);
        }*/

        #region Quitacao

        private DialogResult detalharParcelas(List<LancamentoFinanceiro> parcelas)
        {
            String title = "Nº Parcela\t\t\t\t\t\t\tData pagamento\t\t\t\t\t\t\tValor Recebido\n";
            String message = "";
            string hr = "===================================================================\n";
            var total = parcelas.Sum(p => (p.ValorLancamento + p.ValorJuros));

            string footer = "Total das parcelas: " + parcelas.Count
                + "\nTotal á pagar: R$ " + total.ToString("N2");

            foreach (var p in parcelas)
            {
                var data = p.DataPagamento != null ? p.DataPagamento.Value.ToString("dd/MM/yyyy") : null;
                message = message
                    + "\t" + p.SequencialParcela + "\t\t\t\t\t\t\t\t\t\t"
                    + data + "\t\t\t\t\t\t\t\t\t"
                    + "R$ " + p.ValorLancamento + "\n";
            }

            message = title + message + hr + footer;
            return XMessageIts.Confirmacao(message, "Confirma quitação da(s) parcela(s)");
        }

        /// <summary>
        /// Seta a data atual como data da parcela caso a data ainda não foi informada
        /// </summary>
        /// <param name="parcelaSelected"></param>
        private void validarDataPagamento(List<LancamentoFinanceiro> parcelas, Nullable<DateTime> data)
        {
            foreach (var p in parcelas)
            {
                //se a data nao foi informada no grid 
                if (p.DataPagamento == null)
                    //use a data atual
                    p.DataPagamento = data;
            }
        }



        /// <summary>
        /// Validar se existem parcelas selecionadas no grid
        /// </summary>
        /// <param name="parcelas"></param>
        /// <returns></returns>
        private bool isQuitarParcela(List<LancamentoFinanceiro> parcelas)
        {

            if (gridViewParcelas.SelectedRowsCount <= 0 || parcelas.Count <= 0)
                XMessageIts.Mensagem("Selecione uma ou mais parcelas a serem quitadas.",
                    "Atenção");
            else
            {
                try
                {
                    var result = parcelas.Where(p => p.StatusLancamento == TypeStatusLancamentoFinanceiro.Aberto).First();

                    var vlrRecebido = ParseUtil.ToDecimal(txtVlrRecebido.Text);
                    var totalApagar = parcelas.Sum(p => (p.ValorLancamento + p.ValorJuros));
                    var vlrCredito = ParseUtil.ToDecimal(txtCredito.Text);
                    var totalRecebido = vlrCredito + vlrRecebido;


                    //tentando quitar a parcela usando somente credito
                    //se o valor recebido for 0
                    //e o valor do credito for diferente de 0
                    //estou utilizando apenas crédito
                    if (vlrRecebido == 0 && vlrCredito >= totalApagar)
                        return true;

                    //tentando quitar a parcela usando somente credito
                    //se o valor recebido for 0
                    //e o valor do credito for diferente de 0
                    //estou utilizando apenas crédito
                    //então o valor do credito deve ser exatamente igual ao valor a pagar
                    else if (vlrRecebido == 0 && vlrCredito != 0
                        && vlrCredito != totalApagar)
                        XMessageIts.Advertencia("Valor do crédito deve ser igual ao valor da(s) parcela(s) recebida(s).",
                            "Atenção");

                    else if (totalApagar != totalRecebido)
                        XMessageIts.Advertencia("Total á pagar deve ser igual ao valor da(s) parcela(s) recebida(s).",
                            "Atenção");
                    else
                        return true;

                }
                catch
                {
                    XMessageIts.Advertencia("Todas as parcelas já foram quitadas!");
                }
            }
            return false;
        }

        /// <summary>
        /// Permissao para abrir o form e quitar as parcelas
        /// </summary>
        /// <returns></returns>
        public bool IsParcelas()
        {
            var lista = gridViewParcelas.GetSelectedItens<LancamentoFinanceiro>();
            if (lista.Count == 0)
            {
                XMessageIts.Advertencia("Não existem parcelas a serem quitadas");
                this.Dispose();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Quita as numParcelas selecionadas
        /// </summary>
        private void quitarParcelas(List<LancamentoFinanceiro> parcelas)
        {

            var vlrCredito = ParseUtil.ToDecimal(txtCredito.Text);
            var vlrRecebido = ParseUtil.ToDecimal(txtVlrRecebido.Text);

            var totalApagar = parcelas.Sum(p => (p.ValorLancamento + p.ValorJuros));
            var creditoRestante = (vlrRecebido + vlrCredito) - totalApagar;


            //valida as datas das parcelas selecionadas
            validarDataPagamento(parcelas, DateTime.Now);

            //exiba as parcelaSelected a serem quitadas
            var op = detalharParcelas(parcelas);

            if (op == DialogResult.Yes)
            {
                var pManager = new ParcelaDaoManager();

                var transation = pManager.QuitarParcelas(parcelas);

                if (transation == parcelas.Count)
                {
                    if (vlrRecebido > 0)
                    {
                        //parcela de referencia para obter venda e cliente
                        //new CaixaDaoManager().
                        //    AddEntradaCaixaByParcela(parcelas.FirstOrDefault(), vlrRecebido);
                    }

                    validarCredito(parcelas.FirstOrDefault().CliFor, creditoRestante);
                    XMessageIts.Mensagem("Pagamento efetivado!");
                    this.Dispose();
                    gridControlParcelasVenda.Refresh();
                    gridControlParcelasVenda.RefreshDataSource();
                    this.IsQuitado = true;
                }
                else
                    this.IsQuitado = false;
            }
            else
                //volta a data pra null
                validarDataPagamento(parcelas, null);

        }

        /// <summary>
        /// Calcula o valor restante e atualiza o lblVlrRestante
        /// </summary>
        private void calcularValores()
        {
            this.txtVlrRecebido.ReadOnly = false;

            //calcula o valor da parcela abatendo o credito
            var parcelas = this.gridViewParcelas.GetSelectedItens<LancamentoFinanceiro>();
            if (parcelas.Count > 0)
            {
                var totalPagar = parcelas.Sum(p => p.ValorLancamento + p.ValorJuros);
                var credito = ParseUtil.ToDecimal(txtCredito.Text);
                decimal vlrRecebido = 0m;

                if (credito > totalPagar)
                    vlrRecebido = 0;
                else
                    vlrRecebido = totalPagar - credito;

                this.txtVlrRecebido.Text = vlrRecebido.ToString("N2");
            }
            else
            {
                this.txtVlrRecebido.Text = "0,00";
            }

            this.txtVlrRecebido.ReadOnly = true;

        }


        #endregion Quitacao

        private void barBtnQuitarParcela_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var parcelas = gridViewParcelas.GetSelectedItens<LancamentoFinanceiro>();

            if (isQuitarParcela(parcelas))
                quitarParcelas(parcelas);
        }


        private void validarCredito(CliFor cliFor, Decimal creditoRestante)
        {
            var ctx = new BalcaoContext();
            var creditos = ctx.CreditoClienteDao.Where(cd => cd.IdCliFor == cliFor.IdCliFor).ToList();

            //apague todos os creditos existente
            foreach (var c in creditos)
                ctx.CreditoClienteDao.Delete(c);

            if (creditoRestante > 0)
            {
                //gere um novo crédito
                var flag = ctx.CreditoClienteDao.Save(new CreditoCliente(cliFor, creditoRestante,
                                    "Saldo restante de parcela quitada"));
                if (!flag)
                    XMessageIts.Erro("O crédito restante não pode ser gerado\nValor do crédito:" + creditoRestante, "Atenção");
                else
                {
                    XMessageIts.Mensagem("Crédito restante gerado com sucesso");
                    txtCredito.Text = creditoRestante.ToString("N2");
                }
            }
        }

        private void gridViewParcelasVenda_SelectionChanged(object sender,
            DevExpress.Data.SelectionChangedEventArgs e)
        {
            calcularValores();
        }

        private void gridViewParcelas_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            calcularValores();
        }

        private void txtVlrRecebido_EditValueChanged(object sender, EventArgs e)
        {
            calcularValores();
        }

    }
}
