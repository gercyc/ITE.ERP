using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.DaoManager.BorderoManager;
using ITE.Entidades.Enumeradores.BorderoEnum;
using ITE.Entidades.POCO.Bordero;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Financeiro.Forms.Bordero
{
    //Em modelagem
    public partial class XFrmChequeListView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TypeSituacaoCheque _situacaoCheque;

        public XFrmChequeListView()
        {
            InitializeComponent();
            this.panelSomatorio1.AddSomatorio(gridControlCheques, gridViewCheque);
        }

        private void XFrmInfoCheque_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarCheques());
        }

        private async Task carregarCheques()
        {
            using (var ctx = new BalcaoContext())
            {
                var source = await ctx.ChequeDao.WhereAsync(ch =>
                                            ch.Situacao != TypeSituacaoCheque.Cancelado);
                gridControlCheques.DataSource = source.OrderBy(ch => ch.DataVencimento);
                setDemonstrativo(Cheque.CreditoSum(source), Cheque.DebitoSum(source));

                //if (this.gridControlCheques.InvokeRequired)
                //{
                //    this.gridControlCheques.Invoke(new MethodInvoker(delegate
                //    {
                //}));
            }

        }

        private void barBtnNovoCheque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new XFrmCheque().ShowDialog();
        }


        private void barBtnCancelarCheque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var ch = gridViewCheque.GetFocusedRow() as Cheque;

            if (ch != null)
            {

                if (ch.Situacao == TypeSituacaoCheque.Cancelado)
                {
                    XMessageIts.Advertencia("Cheque já cancelado !");
                }
                else
                {
                    var op = XMessageIts.Confirmacao("Confirmar cancelamento do cheque: "
                        + ch.IdCheque + " será cancelado", "Atenção");

                    if (op == DialogResult.Yes)
                    {
                        using (var ctx = new BalcaoContext())
                        {

                            //pk do cheque selecionado
                            var cheque = ctx.ChequeDao.Find(ch.IdCheque);

                            //atualiza o cheque
                            ch.Situacao = cheque.Situacao = TypeSituacaoCheque.Cancelado;

                            if (ctx.ChequeDao.Update(cheque))
                                XMessageIts.Mensagem("Cheque cancelado com sucesso.");
                        }
                    }
                }
            }
        }

        private void barBtnConsultarCheque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }


        private void setDemonstrativo(Decimal credito, Decimal debito)
        {
            var liquido = credito - debito;
            var total = credito + debito;

            lblCredito.Text = "R$ " + credito.ToString("n2");
            lblDebito.Text = "R$ " + debito.ToString("n2");
            lblLiquido.Text = "R$ " + liquido.ToString("n2");
            lblTotal.Text = "R$ " + total.ToString("n2");

        }

        private void barBtnAlterarCheque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (GridViewUtil.IsSelectOneRowWarning(gridViewCheque))
            {
                var ch = gridViewCheque.GetFocusedRow() as Cheque;

                new XFrmCheque(ch).ShowDialog();
            }
        }

        private void barBtnFiltrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void btnConsultarCheques_Click(object sender, EventArgs e)
        {
            var manager = new ChequeDaoManager();
            var dtInicio = ParseUtil.ToDate(dtEditDataInicial.DateTime);
            var dtFinal = ParseUtil.ToDate(dtEditDataFinal.DateTime);

            List<Cheque> cheques;

            if (cbStatusCheques.SelectedIndex > 0)
            {
                if (_situacaoCheque == TypeSituacaoCheque.VencendoHoje)
                    cheques = manager.FindChequesVencidoNoDia();
                else
                    //no periodo com situação
                    cheques = manager.FindChequesByPeriodo(_situacaoCheque, dtInicio, dtFinal);
            }
            else
            {
                cheques = manager.FindChequesByPeriodo(dtInicio, dtFinal);
            }

            //seta no label
            var credito = Cheque.CreditoSum(cheques);
            var debito = Cheque.DebitoSum(cheques);

            //carrega no grid
            gridControlCheques.DataSource = cheques;

            //atualiza os label
            setDemonstrativo(credito, debito);


        }

        private void cbStatusCheques_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbStatusCheques.SelectedIndex; //repComboBoxSituacao.Items.IndexOf(barEditSituacao.EditValue);

            switch (index)
            {
                //Aberto
                case 1:
                    this._situacaoCheque = TypeSituacaoCheque.Aberto; break;
                //Vencido
                case 2: this._situacaoCheque = TypeSituacaoCheque.Vencido; break;
                //Compensado
                case 3: this._situacaoCheque = TypeSituacaoCheque.Compensado; break;
                //Cancelado
                case 4: this._situacaoCheque = TypeSituacaoCheque.Cancelado; break;
                //Devolvido
                case 5: this._situacaoCheque = TypeSituacaoCheque.Devolvido; break;

                //Vencendo hoje
                case 6: this._situacaoCheque = TypeSituacaoCheque.VencendoHoje; break;
                default:
                    this._situacaoCheque = TypeSituacaoCheque.Todos;
                    break;
            }
        }
    }
}