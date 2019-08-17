using System;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmLocalEstoqueView : DevExpress.XtraEditors.XtraForm
    {


        private LocalEstoque localEstAnt;


        public XFrmLocalEstoqueView()
        {
            InitializeComponent();
            cepControl1.AddController(lookUpMunicipio1.ComboEditMunicipio, lookUpMunicipio1.ComboEditUF);
        }


        public XFrmLocalEstoqueView(LocalEstoque le) : this()
        {
            this.localEstAnt = indexarCampos(le);


        }


        private LocalEstoque indexarLocalEstoque()
        {
            string codigo = txtCodLocal.Text;
            string nomeLocal = txtNomeLocal.Text;
            int idFilial = lookUpFilial1.Filial.IdFilial;
            string uf = lookUpMunicipio1.UF;
            string municipio = lookUpMunicipio1.Municipio;

            var lce = new LocalEstoque(codigo, nomeLocal, idFilial, uf, municipio);

            lce.Bairro = txtBairro.Text;
            lce.NomeEndereco = txtNomeEndereco.Text;
            lce.NumeroEndereco = txtNumeroEndereco.Text;
            lce.ComplementoEndereco = txtComplEndereco.Text;
            lce.Cep = cepControl1.TextCep.Text;

            if (localEstAnt != null)
                lce.IdLocalEstoque = localEstAnt.IdLocalEstoque;

            return lce;

        }
        private LocalEstoque indexarCampos(LocalEstoque l)
        {
            if (l != null)
            {
                txtCodLocal.Text = l.CodigoLocalEstoque;
                txtNomeLocal.Text = l.NomeLocalEstoque;
                lookUpFilial1.FindSetFilial(l.Filial);
                lookUpMunicipio1.Municipio = l.Municipio;
                lookUpMunicipio1.UF = l.Uf;
                txtNomeEndereco.Text = l.NomeEndereco;
                txtNumeroEndereco.Text = l.NumeroEndereco;
                txtBairro.Text = l.Bairro;
                txtComplEndereco.Text = l.ComplementoEndereco;
                cepControl1.TextCep.Text = l.Cep;

            }
            return l;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var ctx = new BalcaoContext();

            var novo = indexarLocalEstoque();

            if (localEstAnt == null)
            {
                if (ctx.LocalEstoqueDao.Save(novo))
                {
                    XMessageIts.Mensagem("Local de estoque cadastrado com sucesso!");

                    this.Dispose();
                }

            }
            else
            {
                var current = ctx.LocalEstoqueDao.Find(localEstAnt.IdLocalEstoque);

                current.Update(novo);

                if (ctx.LocalEstoqueDao.Update(current))
                {
                    XMessageIts.Mensagem("Local de estoque atualizado com sucesso!");
                    localEstAnt.Update(current);
                    this.Dispose();
                }
            }
        }
    }

}