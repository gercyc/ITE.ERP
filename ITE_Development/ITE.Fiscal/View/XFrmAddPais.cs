using System;
using System.Windows.Forms;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Mensagem;

namespace ITE.Fiscal.View
{
    public partial class XFrmAddPais : DevExpress.XtraEditors.XtraForm
    {
        private LocalEstoque localEstAnt;
        private FormTypeAction formTypeAction;

        public XFrmAddPais()
        {
            InitializeComponent();
        }

        public XFrmAddPais(LocalEstoque localEstAnt, FormTypeAction formTypeAction) : this()
        {
            this.localEstAnt = localEstAnt;
            this.formTypeAction = formTypeAction;
            indexarCampos();
        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctx = new BalcaoContext();
            if (formTypeAction == FormTypeAction.Alterar)
            {
                var fUpdate = ctx.LocalEstoqueDao.Find(localEstAnt.IdLocalEstoque);
                fUpdate.Update(indexarLocalEstoque());

                if (ctx.LocalEstoqueDao.Update(fUpdate))
                {
                    XMessageIts.Mensagem("Local de estoque atualizado com sucesso!", "SUCESSO!", MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            else
            {
                if (ctx.LocalEstoqueDao.Save(indexarLocalEstoque()))
                {
                    XMessageIts.Mensagem("Local de estoque cadastrado com sucesso!", "SUCESSO!", MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
                this.Dispose();
            }
        }

        private LocalEstoque indexarLocalEstoque()
        {
            String codigo = txtCodLocal.Text;
            String nomeLocal = txtNomeLocal.Text;
            int idFilial = lookUpMatrizFilial1.Filial.IdFilial;
            string uf = lookUpMunicio1.UF;
            string municipio = lookUpMunicio1.Municipio;

            var lce = new LocalEstoque(codigo, nomeLocal, idFilial, uf, municipio);
            return lce;
        }
        private void indexarCampos()
        {
            if(localEstAnt != null)
            {
                txtCodLocal.Text = localEstAnt.CodigoLocalEstoque;
                txtNomeLocal.Text = localEstAnt.NomeLocalEstoque;
                lookUpMatrizFilial1.Matriz = localEstAnt.Filial.Matriz;
                lookUpMatrizFilial1.Filial = localEstAnt.Filial;
                lookUpMunicio1.Municipio = localEstAnt.Municipio;
                lookUpMunicio1.UF = localEstAnt.Uf;

            }
        }
    }
}