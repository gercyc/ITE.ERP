using System;
using System.Collections.Generic;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;

namespace ITE.Financeiro.Forms.View
{
    public partial class XFrmCompensarExtrato : DevExpress.XtraEditors.XtraForm
    {
        private List<ExtratoBancario> _extratos;

        public XFrmCompensarExtrato()
        {
            InitializeComponent();
        }

        public XFrmCompensarExtrato(List<ExtratoBancario> extratos) : this()
        {
            this._extratos = extratos;
        }

        private void btnCompensarExtrato_Click(object sender, EventArgs e)
        {
            try
            {
                var ctx = new BalcaoContext();
                foreach (var extr in _extratos)
                {
                    var extUpd = ctx.ExtratoBancarioDao.Find(extr.IdExtrato);

                    if (chkDtExtrato.Checked)
                    {
                        extUpd.CompensarExtrato(extr.DataExtrato);
                        extr.CompensarExtrato(extr.DataExtrato);
                    }
                    else
                    {
                        extUpd.CompensarExtrato(dtCompensacao.DateTime);
                        extr.CompensarExtrato(dtCompensacao.DateTime);
                    }

                    ctx.ExtratoBancarioDao.Update(extUpd);
                }
                XMessageIts.Mensagem("Extratos compensados com sucesso!");
                this.Dispose();
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
        }

        private void chkDtExtrato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDtExtrato.Checked)
            {
                dtCompensacao.Enabled = false;
            }
            else
            {
                dtCompensacao.Enabled = true;
            }
        }
    }
}