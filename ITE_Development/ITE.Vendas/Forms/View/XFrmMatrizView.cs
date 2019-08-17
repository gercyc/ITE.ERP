using System;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System.Windows.Forms;
using System.IO;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Web.JSON;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmMatrizView : DevExpress.XtraEditors.XtraForm
    {
        private EmpresaMatriz empresaMatAnt;

        public XFrmMatrizView()
        {
            InitializeComponent();

            cepControl1.AddController(txtEndereco, txtBairro, txtComplemento,
                lookUpMunicipio1.ComboEditMunicipio, lookUpMunicipio1.ComboEditUF);
        }

        public XFrmMatrizView(EmpresaMatriz empresaMat)
            : this()
        {
            this.empresaMatAnt = indexarDados(empresaMat);

        }

        public EmpresaMatriz indexarDados()
        {
            var cnpj = StringUtilIts.FixString(txtCnpj.Text);

            var novo = new EmpresaMatriz(txtRazaoSocial.Text, txtNomeFantasia.Text,
                cnpj, dtRegistroJunta.DateTime, DateTime.Now, txtCodMatriz.Text);
            novo.Cep = cepControl1.TextCep.Text;

            novo.Telefone = txtTelefone.Text;
            novo.Fax = txtFax.Text;

            if (dtRegistroJunta.DateTime.ValidateDate() == null)
            {
                novo.DtRegtroJuntaCom = null;
            }

            var endereco = new EnderecoCliFor(txtEndereco.Text, txtNumeroEnd.Text, txtBairro.Text,
                txtComplemento.Text, cepControl1.Cep, lookUpMunicipio1.UF,
                lookUpMunicipio1.Municipio, "Comercial");

            novo.SetEndereco(endereco);

            if (pictureFotoProduto.Image != null)
                novo.Logo = ImageUtilIts.GetBytesFromImage(pictureFotoProduto.Image);

            return novo;
        }

        private EmpresaMatriz indexarDados(EmpresaMatriz emp)
        {
            txtRazaoSocial.Text = emp.RazaoSocial;

            if (emp.DtRegtroJuntaCom.HasValue)
                dtRegistroJunta.DateTime = emp.DtRegtroJuntaCom.Value;

            txtNomeFantasia.Text = emp.NomeFantasia;
            txtCnpj.Text = emp.Cnpj;
            txtEndereco.Text = emp.NomeEndereco;
            txtBairro.Text = emp.Bairro;
            txtNumeroEnd.Text = emp.NumeroEndereco;
            txtComplemento.Text = emp.Complemento;

            txtCodMatriz.Text = emp.CodigoMatriz;
            txtTelefone.Text = emp.Telefone;
            txtFax.Text = emp.Fax;

            cepControl1.TextCep.Text = emp.Cep;

            //tambem equaliza os dados que estao no campo com o objeto carregado
            emp.RazaoSocial = txtRazaoSocial.Text;
            emp.DtRegtroJuntaCom = dtRegistroJunta.DateTime;
            emp.NomeFantasia = txtNomeFantasia.Text;
            emp.Cnpj = txtCnpj.Text;

            //lookupmunicipio
            lookUpMunicipio1.SetMunicipioUF(emp.Cidade, emp.Uf);

            emp.Cidade = lookUpMunicipio1.Municipio;
            emp.Uf = lookUpMunicipio1.UF;

            emp.Cep = cepControl1.Cep;
            emp.NomeEndereco = txtEndereco.Text;
            emp.Bairro = txtBairro.Text;
            emp.NumeroEndereco = txtNumeroEnd.Text;
            emp.Complemento = txtComplemento.Text;
            emp.CodigoMatriz = txtCodMatriz.Text;

            if (emp.Logo != null)
                pictureFotoProduto.Image = ImageUtilIts.GetImageFromBytes(emp.Logo);

            return emp;

        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                var novo = indexarDados();
                //se nenhuma matriz estiver sendo editada, adicione o que foi preenchido no formulario
                if (empresaMatAnt == null)
                {
                    if (ctx.EmpresaMatrizDao.Save(novo))
                    {
                        XMessageIts.Mensagem("Matriz cadastrada com sucesso");

                        this.Dispose();
                    }
                }
                else
                {
                    var current = ctx.EmpresaMatrizDao.Find(empresaMatAnt.IdMatriz);

                    current.Update(novo);

                    if (ctx.EmpresaMatrizDao.Update(current))
                    {
                        empresaMatAnt.Update(current);
                        XMessageIts.Mensagem("Dados atualizados com sucesso!");
                        this.Dispose();
                    }
                }
            }

        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void txtCnpj_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCnpj.Text.Length == 18)
            {
                var r = LayoutReceitaWS.GetDataFromCNPJTyped<EmpresaMatriz>(txtCnpj.Text);

                indexarDados(r);
            }
        }

        private void pictureFotoProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                var op = openFileLogo.ShowDialog();
                if (op == DialogResult.OK)
                {
                    byte[] b = ImageUtilIts.GetBytesFromStream(openFileLogo.OpenFile());
                    pictureFotoProduto.Image = ImageUtilIts.GetImageFromBytes(b);
                }
            }
        }

        private void groupControlLogo_DoubleClick(object sender, EventArgs e)
        {
            if (pictureFotoProduto.Image != null)
            {
                var img = ImageUtilIts.GetBytesFromImage(pictureFotoProduto.Image);
                var path = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + ".jpg");
                FileManagerIts.WriteBytesToFile(path, img);
                FileManagerIts.OpenFromSystem(path);
            }
        }
        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}