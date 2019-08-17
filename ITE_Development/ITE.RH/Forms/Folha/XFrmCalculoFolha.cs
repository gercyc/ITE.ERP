using DevExpress.XtraEditors.DXErrorProvider;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.RH.Folha;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITSolution.Framework.Entities.Embedded;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITE.RH.Forms.Folha
{
    public partial class XFrmCalculoFolha : DevExpress.XtraEditors.XtraForm
    {
        private Usuario userLogado;

        public XFrmCalculoFolha()
        {
            InitializeComponent();
            FillCbGrupoEventos();
            this.userLogado = UnitWork.Usuario;
            cbPeriodo.Properties.Items.AddRange(CalendarMonth.Calendar.CalendarMonths);
            cbPeriodo.SelectedIndex = DateTime.Now.Month-1;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var grupoSelect = cbGrupoEvento.SelectedItem as GrupoEvento;
            if (grupoSelect != null)
            {
                var dtPeriodo = (cbPeriodo.SelectedItem as CalendarMonth).DateTime;
                dtPeriodo =  DataUtil.GetDataFinalDoMes(dtPeriodo);

                Task<bool> myTask = new Task<bool>(
                    () => new FolhaDaoManager()
                    .ExecutaCalculoFolha(dtPeriodo, userLogado, IndexTipoFechamento(),
                    grupoSelect, chkConsGrpFunc.Checked, new System.Threading.CancellationTokenSource()));


                var tempo = TaskWatch.StartTaskWatch(myTask);

                var message = "Geração da folha de pagamento. -> " + DateTime.Now +
                    "\n Tempo gasto: 0" + tempo.Hours + ":0" + tempo.Minutes + ":" + tempo.Seconds + ":" + tempo.Milliseconds;

                LoggerUtilIts.WriteOnEventViewer(message);

                if (myTask.Result)
                {
                    XMessageIts.Mensagem("Competencia criada com sucesso");
                    this.Dispose();
                }
            }
            else
            {
                XMessageIts.Advertencia("Selecione um grupo de eventos para efetuar o cálculo da folha.");
            }
        }
        private TypeTipoFechamentoFolha IndexTipoFechamento()
        {
            var tipo = TypeTipoFechamentoFolha.Mensal; //padrão

            if (cbTipoFechamento.SelectedIndex == 0 || cbTipoFechamento.SelectedIndex == -1)
                return tipo;
            else if (cbTipoFechamento.SelectedIndex == 1)
                tipo = TypeTipoFechamentoFolha.Quinzenal;
            else if (cbTipoFechamento.SelectedIndex == 2)
                tipo = TypeTipoFechamentoFolha.Semanal;

            return tipo;
        }
        private void FillCbGrupoEventos()
        {
            var ctx = new BalcaoContext();
            var grupos = ctx.GrupoEventoDao.FindAll();
            cbGrupoEvento.Properties.Items.AddRange(grupos);
            cbGrupoEvento.SelectedIndex = 0;
        }

        private void cbGrupoEvento_EditValueChanged(object sender, EventArgs e)
        {
            var grpSel = cbGrupoEvento.SelectedItem as GrupoEvento;

            if (grpSel != null)
                gridControl1.DataSource = grpSel.EventosGrupo.ToList();
        }

         /*private void txtPeriodo_Leave(object sender, EventArgs e)
        {
            var per = txtPeriodo.Text;
            var rule = new validatePeriodo();
            rule.ErrorText = "Período digitado inválido. Por favor informe no formado MÊS/ANO (MM/AAAA).";
            rule.ErrorType = ErrorType.Critical;

            dxValidatePeriodo.SetValidationRule(txtPeriodo, rule);
        } */
        
        private class validatePeriodo : ValidationRule
        {
            //public new string ErrorText { get; set; }
            public override bool Validate(Control control, object value)
            {
                if (value != null)
                {
                    if (!value.ToString().IsNullOrEmpty())
                    {
                        var values = value.ToString().Split('/');
                        var mes = ParseUtil.ToInt(values[0]);
                        var ano = values[1].ToString().Replace("_", "");
                        //this.ErrorText = "Período digitado inválido. Por favor informe no formado MÊS/ANO (MM/AAAA).";

                        if (mes > 12 || (ano.Length > 4 || ano.Length < 4))
                        {
                            return false;
                        }
                        else
                            return true;
                    }
                }
                return false;
            }
        } 

    }
}