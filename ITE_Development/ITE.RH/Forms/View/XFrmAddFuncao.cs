using System;
using ITE.Entidades.POCO.RH;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;

namespace ITE.RH.Forms.View
{
    public partial class XFrmAddFuncao : DevExpress.XtraEditors.XtraForm
    {
        private Funcao funcaoAnt;

        public XFrmAddFuncao()
        {
            InitializeComponent();
        }

        public XFrmAddFuncao(Funcao funcao) : this()
        {
            this.funcaoAnt = indexaFuncao(funcao);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novo = indexarFuncao();
            using (var ctx = new BalcaoContext())
            {
                if (funcaoAnt == null)
                {
                    if (ctx.FuncaoDao.Save(novo))
                    {
                        XMessageIts.Mensagem("Função incluída com sucesso!", "Sucesso");
                        this.Dispose();
                    }
                }
                else
                {
                    var funcaoBd = ctx.FuncaoDao.Find(funcaoAnt.IdFuncao);
                    //atualiza com os dados dos campos
                    funcaoBd.Update(novo);
                    //atualiza no banco
                    if (ctx.FuncaoDao.Update(funcaoBd))
                    {
                        this.funcaoAnt.Update(funcaoBd);//manda a atualizacao pro objeto do grid
                        XMessageIts.Mensagem("Função atualizada com sucesso!", "Sucesso");
                        this.Dispose();
                    }
                }
            }
        }

        private Funcao indexarFuncao()
        {
            return new Funcao(txtNomeFuncao.Text,
                              txtCodFuncao.Text,
                              ParseUtil.ToInt(txtCbo.Text));
        }

        private Funcao indexaFuncao(Funcao f)
        {
            if (f != null)
            {
                txtIdFuncao.Text = f.IdFuncao.ToString();
                txtCodFuncao.Text = f.CodigoFuncao;
                txtNomeFuncao.Text = f.NomeFuncao;
                txtCbo.Text = f.CBO.ToString();
            }
            return f;
        }


    }
}