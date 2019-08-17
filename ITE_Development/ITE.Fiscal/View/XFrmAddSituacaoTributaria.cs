using System;
using System.Windows.Forms;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Mensagem;

namespace ITE.Fiscal.View
{
    public partial class XFrmAddSituacaoTributaria : DevExpress.XtraEditors.XtraForm
    {
        private SituacaoTributaria cstAnt;
        private FormTypeAction formTypeAction;

        public XFrmAddSituacaoTributaria()
        {
            InitializeComponent();
        }

        public XFrmAddSituacaoTributaria(SituacaoTributaria cstAnt, FormTypeAction formTypeAction) : this()
        {
            this.cstAnt = cstAnt;
            this.formTypeAction = formTypeAction;
            //indexarCampos();
        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctx = new BalcaoContext();
            if (formTypeAction == FormTypeAction.Alterar)
            {
                var fUpdate = ctx.SituacaoTributariaDao.Find(cstAnt.IdCst);
                fUpdate.Update(indexarCst());

                if (ctx.SituacaoTributariaDao.Update(fUpdate))
                {
                    XMessageIts.Mensagem("Situação tributária atualizada com sucesso!", "SUCESSO!", MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (ctx.SituacaoTributariaDao.Save(indexarCst()))
                {
                    XMessageIts.Mensagem("Situação tributária cadastrado com sucesso!", "SUCESSO!", MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
                this.Dispose();
            }
        }

        private SituacaoTributaria indexarCst()
        {
            String codigo = txtCodCst.Text;
            String descricao = memoEdit1.Text;
            var imposto = lkImposto.EditValue as TipoImposto;

            var lce = new SituacaoTributaria(codigo, descricao, imposto);
            return lce;
        }
        private void indexarCampos()
        {
            if (cstAnt != null)
            {
                lkImposto.EditValue = cstAnt.TipoImposto;
                lkImposto.Text = cstAnt.TipoImposto.ToString();
                lkImposto.ResetText();
                txtCodCst.Text = cstAnt.CodigoCst;
                memoEdit1.Text = cstAnt.DescricaoCst;

            }
        }

        private void XFrmAddSituacaoTributaria_Shown(object sender, EventArgs e)
        {
            //XFrmWait.StartTask(carregarDados(), "Carregando informações", this);
            carregarDados();
            if(cstAnt != null) indexarCampos();
        }

        private void carregarDados()
        {
            var ctx = new BalcaoContext();
            var impostos = ctx.TipoImpostoDao.FindAll();
            lkImposto.Properties.DataSource = impostos;
        }
    }
}