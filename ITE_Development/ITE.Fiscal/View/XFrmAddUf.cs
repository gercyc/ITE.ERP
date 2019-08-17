using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Mensagem;

namespace ITE.Fiscal.View
{
    public partial class XFrmAddUf : DevExpress.XtraEditors.XtraForm
    {
        private LocalEstoque _localEstAnt;
        private readonly FormTypeAction _formTypeAction;

        public XFrmAddUf()
        {
            InitializeComponent();
        }

        public XFrmAddUf(LocalEstoque localEstAnt, FormTypeAction formTypeAction) : this()
        {
            this._localEstAnt = localEstAnt;
            this._formTypeAction = formTypeAction;
            indexarCampos();
        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var ctx = new BalcaoContext();
            if (_formTypeAction == FormTypeAction.Alterar)
            {
                var fUpdate = ctx.LocalEstoqueDao.Find(_localEstAnt.IdLocalEstoque);
                fUpdate.Update(indexarLocalEstoque());

                if (ctx.LocalEstoqueDao.Update(fUpdate))
                {
                    XMessageIts.Mensagem("Local de estoque atualizado com sucesso!");
                }
            }
            else
            {
                if (ctx.LocalEstoqueDao.Save(indexarLocalEstoque()))
                {
                    XMessageIts.Mensagem("Local de estoque cadastrado com sucesso!");
                }
             
                this.Dispose();
            }
        }

        private LocalEstoque indexarLocalEstoque()
        {
            string codigo = txtCodLocal.Text;
            string nomeLocal = txtNomeLocal.Text;
            int idFilial = lookUpMatrizFilial1.Filial.IdFilial;
            string uf = lookUpMunicio1.UF;
            string municipio = lookUpMunicio1.Municipio;

            var lce = new LocalEstoque(codigo, nomeLocal, idFilial, uf, municipio);
            return lce;
        }
        private void indexarCampos()
        {
            if(_localEstAnt != null)
            {
                txtCodLocal.Text = _localEstAnt.CodigoLocalEstoque;
                txtNomeLocal.Text = _localEstAnt.NomeLocalEstoque;
                lookUpMatrizFilial1.Matriz = _localEstAnt.Filial.Matriz;
                lookUpMatrizFilial1.Filial = _localEstAnt.Filial;
                lookUpMunicio1.Municipio = _localEstAnt.Municipio;
                lookUpMunicio1.UF = _localEstAnt.Uf;

            }
        }
    }
}