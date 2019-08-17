using System;
using System.Windows.Forms;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;

namespace ITE.Fiscal.View
{
    public partial class XFrmAddCfop : DevExpress.XtraEditors.XtraForm
    {
        private Cfops cfopAnt;
        private FormTypeAction formTypeAction;

        public XFrmAddCfop()
        {
            InitializeComponent();
            FormsUtil.AddShortcutEscapeOnDispose(this);
        }

        public XFrmAddCfop(Cfops cfopAnt, FormTypeAction formTypeAction) : this()
        {
            this.cfopAnt = cfopAnt;
            this.formTypeAction = formTypeAction;
            if (cfopAnt != null)
            {
                this.Text = cfopAnt.CodigoCfop;
                indexarCampos();
            }

        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctx = new BalcaoContext();
            if (formTypeAction == FormTypeAction.Alterar)
            {
                var fUpdate = ctx.CfopsDao.Find(cfopAnt.IdCfop);
                fUpdate.Update(indexarCfop());

                if (ctx.CfopsDao.Update(fUpdate))
                {
                    XMessageIts.Mensagem("CFOP atualizado com sucesso!", "SUCESSO!", MessageBoxIcon.Information);
                    //this.Dispose();
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (ctx.CfopsDao.Save(indexarCfop()))
                {
                    XMessageIts.Mensagem("CFOP cadastrado com sucesso!", "SUCESSO!", MessageBoxIcon.Information);
                    //this.Dispose();
                }
                else
                {
                    return;
                }
                this.Dispose();
            }
        }

        private Cfops indexarCfop()
        {
            String codigo = txtCodCfop.Text;
            String descrCfop = descCfop.Text;
            
            var cfop = new Cfops(codigo, descrCfop);
            return cfop;
        }
        private void indexarCampos()
        {
            if (cfopAnt != null)
            {
                txtCodCfop.Text = cfopAnt.CodigoCfop;
                descCfop.Text = cfopAnt.DescricaoCfop;
                
            }
        }
    }
}