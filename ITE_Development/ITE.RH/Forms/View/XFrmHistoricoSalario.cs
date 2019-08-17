using System;
using System.Text;
using System.Linq;
using ITE.Entidades.POCO.RH;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Validador;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITSolution.Framework.GuiUtil;

namespace ITE.RH.Forms.View
{
    public partial class XFrmHistoricoSalario : DevExpress.XtraEditors.XtraForm
    {
        private Funcionario func;
        public XFrmHistoricoSalario(Funcionario func)
        {
            InitializeComponent();
            this.ActiveControl = this.txtSalario;

            this.txtSalario.Focus();
            this.init(func);
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        private void init(Funcionario func)
        {
            this.func = func;
            this.hyperlinkLblFunc.Text = func.NomeFuncionario;
            this.txtSalarioAnt.Text = func.Salario.ToString();
            

            if (this.func.HistoricoSalarial.Count > 0)
            {
                var historico = this.func.HistoricoSalarial.LastOrDefault();
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Última alteração:");
                sb.AppendLine(historico.Data.ToShortDateString());
                sb.AppendLine("");

                sb.AppendLine ("Motivo da alteração:");
                sb.AppendFormat(historico.Motivo);

                this.memoEditInfo.Text = sb.ToString();
            }

            else
                this.memoEditHistorico.Text = "Não há registro de salários anteriores deste funcionário.";
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            new XFrmAddFuncionario(func).Show();
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var salario = ParseUtil.ToDecimal(txtSalario.Text);
            HistoricoSalarial historico = new HistoricoSalarial(salario, memoEditHistorico.Text);


            if (ValidadorDTO.ValidateWarning(func) && ValidadorDTO.ValidateWarning(historico))
            {
                if (salario == this.func.Salario)
                    XMessageIts.Advertencia("O salário informado deve ser diferente do salário atual");
                else
                {
                    if (new HistoricoFuncionarioManager().UpdateSalario(func, historico))
                    {
                        XMessageIts.Mensagem("Ajuste salárial realizado com sucesso");
                        this.Dispose();
                    }
                }
            }
        }
    }
}