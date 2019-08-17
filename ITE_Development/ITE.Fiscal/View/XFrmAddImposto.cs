using System;
using System.Windows.Forms;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Fiscal.View
{
    public partial class XFrmAddImposto : DevExpress.XtraEditors.XtraForm
    {
        private TipoImposto impostoAnt;
        private FormTypeAction formTypeAction;

        public XFrmAddImposto()
        {
            InitializeComponent();
        }

        public XFrmAddImposto(TipoImposto impostoAnt, FormTypeAction formTypeAction) : this()
        {
            this.impostoAnt = impostoAnt;
            this.formTypeAction = formTypeAction;
            indexarCampos();
        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctx = new BalcaoContext();
            if (formTypeAction == FormTypeAction.Alterar)
            {
                var fUpdate = ctx.TipoImpostoDao.Find(impostoAnt.IdImposto);
                fUpdate.Update(indexarImposto());

                if (ctx.TipoImpostoDao.Update(fUpdate))
                {
                    XMessageIts.Mensagem("Imposto atualizado com sucesso!", "SUCESSO!", MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (ctx.TipoImpostoDao.Save(indexarImposto()))
                {
                    XMessageIts.Mensagem("Imposto cadastrado com sucesso!", "SUCESSO!", MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
                this.Dispose();
            }
        }

        private TipoImposto indexarImposto()
        {
            String codigo = txtCodImposto.Text;
            String descImposto = txtDescImposto.Text;
            TypeAliquotaImposto tipoAliquota = cbTpAliquota.SelectedIndex == 0 ? TypeAliquotaImposto.Fixa : TypeAliquotaImposto.Variavel;
            var aliquota = ParseUtil.ToDecimal(txtAliquota.Text);
            var impostoAdd = new TipoImposto(codigo, descImposto, tipoAliquota, aliquota);
            return impostoAdd;
        }
        private void indexarCampos()
        {
            if (impostoAnt != null)
            {
                txtCodImposto.Text = impostoAnt.CodigoImposto;
                txtDescImposto.Text = impostoAnt.DescricaoImposto;
                cbTpAliquota.SelectedIndex = impostoAnt.TipoAliquota == TypeAliquotaImposto.Fixa ? 0 : 1;
                txtAliquota.Text = ParseUtil.ToDecimal(impostoAnt.Aliquota).ToString("N2");
            }
        }
    }
}