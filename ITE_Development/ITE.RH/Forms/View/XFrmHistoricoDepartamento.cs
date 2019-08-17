using System;
using System.Text;
using System.Linq;
using ITE.Entidades.POCO.RH;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITSolution.Framework.GuiUtil;

namespace ITE.RH.Forms.View
{
    public partial class XFrmHistoricoDepartamento : DevExpress.XtraEditors.XtraForm
    {
        private Funcionario func;
        public XFrmHistoricoDepartamento(Funcionario func)
        {
            InitializeComponent();
            this.ActiveControl = this.cbDepartamento;
            this.cbDepartamento.Focus();
            this.init(func);
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        private void init(Funcionario func)
        {
            this.func = func;
            this.hyperlinkLblFunc.Text = func.NomeFuncionario;
            this.txtSituacaoAnt.Text = func.Departamento.NomeDepartamento;
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);//nao preciso nada a nao ser depto
                cbDepartamento.Properties.Items.AddRange(ctx.DepartamentoDao.FindAll());

                if (this.func.HistoricoDepartamento.Count > 0)
                {
                    var historico = this.func.HistoricoDepartamento.LastOrDefault();
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
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            new XFrmAddFuncionario(func, FormTypeAction.Visualizar).Show();
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var depto = cbDepartamento.SelectedItem as Departamento;
            var idDepto = depto != null ? depto.IdDepartamento : 0;

            HistoricoDepartamento historico = new HistoricoDepartamento(depto, memoEditHistorico.Text);

            //se existe a data de demissao

            if (ValidadorDTO.ValidateWarning(func) && ValidadorDTO.ValidateWarning(historico))
            {
                if (idDepto == this.func.IdDepartamento)
                    XMessageIts.Advertencia("O departamento selecionado deve ser diferente da departamento atual");
                else
                {
                    if (new HistoricoFuncionarioManager().UpdateDepartamento(func, historico))
                    {
                        XMessageIts.Mensagem("Departamento alterado com sucesso");
                        //atualiza o objeto de onde foi chamado
                        this.func.Departamento = depto;
                        this.Dispose();
                    }
                }
            }
        }
    }
}
