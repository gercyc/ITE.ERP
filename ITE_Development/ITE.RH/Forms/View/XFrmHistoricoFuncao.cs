using System;
using System.Text;
using System.Linq;
using ITE.Entidades.POCO.RH;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITSolution.Framework.GuiUtil;

namespace ITE.RH.Forms.View
{
    public partial class XFrmHistoricoFuncao : DevExpress.XtraEditors.XtraForm
    {
        private Funcionario func;
        public XFrmHistoricoFuncao(Funcionario func)
        {
            InitializeComponent();
            this.ActiveControl = this.cbFuncao;
            this.cbFuncao.Focus();
            this.init(func);
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        private void init(Funcionario func)
        {
            this.func = func;
            this.hyperlinkLblFunc.Text = func.NomeFuncionario;
            this.txtSituacaoAnt.Text = func.Funcao.NomeFuncao;

            cbFuncao.Properties.Items.AddRange(new BalcaoContext().FuncaoDao.FindAll());

            if (this.func.HistoricoFuncao.Count > 0)
            {
                var historico = this.func.HistoricoFuncao.LastOrDefault();
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
            var funcao = cbFuncao.SelectedItem as Funcao;
            var idFuncao = funcao != null ? funcao.IdFuncao : 0;
            var historico = new HistoricoFuncao(funcao, memoEditHistorico.Text);


            //se existe a data de demissao

            if (ValidadorDTO.ValidateWarning(func) && ValidadorDTO.ValidateWarning(historico))
            {
                if (idFuncao == this.func.IdFuncao)
                    XMessageIts.Advertencia("A função selecionada deve ser diferente da função atual");
                else
                {

                    if (new HistoricoFuncionarioManager().UpdateFuncao(func, historico))
                    {
                        XMessageIts.Mensagem("Função alterada com sucesso");
                        //atualiza o objeto de onde foi chamado
                        this.func.Funcao = funcao;
                        this.Dispose();
                    }
                }
            }
        }
    }
}
