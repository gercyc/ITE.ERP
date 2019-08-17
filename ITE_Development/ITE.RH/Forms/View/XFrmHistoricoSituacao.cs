using System;
using System.Text;
using System.Linq;
using ITE.Entidades.POCO.RH;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Mensagem;
using ITE.RH.Enumeradores;
using ITSolution.Framework.Util;
using System.Windows.Forms;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.DaoManager.RHDaoManager;

namespace ITE.RH.Forms.View
{
    public partial class XFrmHistoricoSituacao : DevExpress.XtraEditors.XtraForm
    {
        private Funcionario func;

        public XFrmHistoricoSituacao(Funcionario func)
        {
            InitializeComponent();
            this.ActiveControl = this.cbSituacao;
            this.cbSituacao.Focus();
            this.init(func);

            this.cbSituacao.SetSelectItem<TypeSituacaoFuncionario>(func.Situacao);

            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        private void init(Funcionario func)
        {
            this.func = func;

            cbSituacao.AddEnumValues(typeof(TypeSituacaoFuncionario));
            this.hyperlinkLblFunc.Text = func.NomeFuncionario;


            this.cbSituacao.SelectedIndex = (int)func.Situacao;
            this.txtSituacaoAnt.Text = func.Situacao.ToString();

            this.lookUpMatrizFilial1.FindSetMatriz(func.Filial.Matriz.CodigoMatriz);
            this.lookUpMatrizFilial1.FindSetFilial(func.Filial.CodigoFilial);

            if (this.func.HistoricoSalarial.Count > 0)
            {
                var historico = this.func.HistoricoSituacao.LastOrDefault();
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Última alteração:");
                sb.AppendLine(historico.Data.ToShortDateString());
                sb.AppendLine("");
                sb.AppendLine("Motivo da alteração:");
                sb.AppendLine(historico.Motivo);

                this.memoEditInfo.Text = sb.ToString();
            }

            else
                this.memoEditInfo.Text = "Não há registro de situações anteriores deste funcionário.";
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            new XFrmAddFuncionario(func).Show();
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lookUpMatrizFilial1.IsMatrizFilial)
            {
                var filial = lookUpMatrizFilial1.Filial;

                var situacao = cbSituacao.GetSelectedItem<TypeSituacaoFuncionario>();
                var dtDemissao = dtEditDtDemissao.DateTime.Date.ValidateDate();

                if (situacao == this.func.Situacao && filial.IdFilial == this.func.IdFilial)
                {
                    XMessageIts.Advertencia("A situação e filial são iguais.\n"
                        + "Para que haja um alteração \"Situação e Filial\" devem ser diferentes.");
                }
                else
                {
                    //atualiza filial
                    this.func.IdFilial = filial.IdFilial;
                    this.func.Situacao = situacao;

                    if (dtEditDtDemissao.Visible && dtDemissao == null)
                    {
                        XMessageIts.Advertencia("Informe a data da demissão");
                    }
                    else
                    {
                        HistoricoSituacao historico = new HistoricoSituacao(func.IdFilial, func.DataAdmissao,
                            situacao, memoEditHistorico.Text);

                        historico.IdFilial = filial.IdFilial;

                        //se existe a data de demissao
                        if (dtDemissao != null)
                        {
                            historico = new HistoricoSituacao(func.IdFilial, func.DataAdmissao, dtEditDtDemissao.DateTime,
                                situacao, memoEditHistorico.Text);
                        }

                        var validador = new ValidadorDTO();

                        if (ValidadorDTO.ValidateWarning(func) && ValidadorDTO.ValidateWarning(historico))
                        {
                            if (dtDemissao != null)
                            {
                                var op = XMessageIts.Confirmacao("Confirma demissão do funcionário: " + func.NomeFuncionario);

                                if (op == DialogResult.Yes)
                                {
                                    var flag = new HistoricoFuncionarioManager().
                                        DemitirFuncionario(func, this.memoEditHistorico.Text, dtDemissao);

                                    if (flag)
                                    {
                                        XMessageIts.Mensagem("Funcionário demitido!");

                                        //atualiza o objeto de onde foi chamado
                                        this.Dispose();
                                    }
                                }
                            }
                            else if (new HistoricoFuncionarioManager().UpdateSituacao(func, historico))
                            {
                                XMessageIts.Mensagem("Situação alterada com sucesso!");
                                this.Dispose();
                            }
                        }
                    }
                }
            }
            else
            {
                XMessageIts.Mensagem("Matriz e Filial não informadas", "Atenção");
            }
        }

        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

            //exibe o campo para data da demissao e troca de lugar com o campo situacao
            if (cbSituacao.SelectedIndex == (int)TypeSituacaoFuncionario.Demitido)
            {
                this.memoEditHistorico.Text = "Demissão sem justa causa";

                lblDemissao.Visible = true;
                dtEditDtDemissao.Visible = true;

                this.lblSituacaoAnt.Location = new System.Drawing.Point(512, 129);
                this.txtSituacaoAnt.Location = new System.Drawing.Point(512, 153);

                this.lblDemissao.Location = new System.Drawing.Point(360, 129);
                this.dtEditDtDemissao.Location = new System.Drawing.Point(360, 153);


            }
            else
            {

                if (cbSituacao.SelectedIndex == (int)TypeSituacaoFuncionario.Ferias)
                    this.memoEditHistorico.Text = "Férias anual";
                else
                    this.memoEditHistorico.Text = "";

                this.lblSituacaoAnt.Location = new System.Drawing.Point(360, 129);
                this.txtSituacaoAnt.Location = new System.Drawing.Point(360, 153);

                this.lblDemissao.Location = new System.Drawing.Point(612, 129);
                this.dtEditDtDemissao.Location = new System.Drawing.Point(612, 153);

                lblDemissao.Visible = false;
                dtEditDtDemissao.Visible = false;

            }
            this.memoEditHistorico.Focus();
        }

        private void XFrmHistoricoSituacao_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
        }
    }
}