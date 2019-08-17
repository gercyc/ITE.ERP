using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ITSolution.Framework.Util;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Web.JSON;
using ITSolution.Framework.Entities;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmFilialView : DevExpress.XtraEditors.XtraForm
    {
        private EmpresaFilial _filialAnt;
        public XFrmFilialView()
        {
            InitializeComponent();
            cepControl1.AddController(txtEndereco,  txtBairro, txtComplemento,
                lookUpMunicipio1.ComboEditMunicipio, lookUpMunicipio1.ComboEditUF);

        }
        public XFrmFilialView(EmpresaFilial filial) : this()
        {
            this._filialAnt = indexarFormulario(filial);
        }

        /// <summary>
        /// Indexar a filial para adicionar.
        /// </summary>
        /// <returns></returns>
        public EmpresaFilial indexarDados()
        {
            EmpresaFilial novo = new EmpresaFilial();
            if (lkpMatriz.EditValue != null)
            {
                var matriz = lkpMatriz.GetSelectedDataRow() as EmpresaMatriz;

                var cnpj = txtCnpj.Text;
                cnpj = cnpj.Replace(".", "");
                cnpj = cnpj.Replace("-", "");
                cnpj = cnpj.Replace("/", "");

                novo = new EmpresaFilial(txtRazSocial.Text, txtNomeFantasia.Text, cnpj, txtInsEst.Text,
                    dtRegistroJunta.DateTime, DateTime.Now, txtTelefone.Text, txtFax.Text, txtEmail.Text, txtCodFilial.Text);

                novo.Telefone = txtTelefone.Text;
                novo.Fax = txtFax.Text;
                novo.IdMatriz = matriz.IdMatriz;

                if (dtRegistroJunta.DateTime.ValidateDate() == null)
                {
                    novo.DtRegtroJuntaCom = null;
                }

                var endereco = new Endereco(txtEndereco.Text, txtNumEndereco.Text, txtBairro.Text,
                    txtComplemento.Text, cepControl1.TextCep.Text, lookUpMunicipio1.UF, lookUpMunicipio1.Municipio, "Comercial");

                novo.SetEndereco(endereco);

            }

            return novo;
        }

        private EmpresaFilial indexarFormulario(EmpresaFilial f)
        {
            //this.btnCopyData.Visibility = BarItemVisibility.Never;
            if (f != null)
            {
                lkpMatriz.EditValue = f.Matriz;
                if (f.Matriz != null)
                {
                    lkpMatriz.Text = f.Matriz.ToString();
                }
                txtCodFilial.Text = f.CodigoFilial;
                txtRazSocial.Text = f.RazaoSocial;
                txtNomeFantasia.Text = f.NomeFantasia;
                txtCnpj.Text = StringUtilIts.ToCpfCnpj(f.Cnpj);
                if (f.DtRegtroJuntaCom.HasValue)
                    dtRegistroJunta.DateTime = f.DtRegtroJuntaCom.Value.Date;

                cepControl1.TextCep.Text = f.Cep;

                lookUpMunicipio1.SetMunicipioUF(f.Cidade, f.Uf);

                lookUpMunicipio1.Refresh();
                lookUpMunicipio1.Update();


                txtEndereco.Text = f.NomeEndereco;
                txtNumEndereco.Text = f.NumeroEndereco;
                txtComplemento.Text = f.Complemento;
                txtBairro.Text = f.Bairro;
                cepControl1.TextCep.Text = f.Cep;

                if (!string.IsNullOrEmpty(f.Telefone))
                {
                    var tel = f.Telefone.Split('/');
                    if (tel.Length > 0)
                    {
                        this.txtTelefone.Text = tel[0];

                        if (tel.Length > 1)
                            this.txtTelefone.Text = tel[1];

                    }
                }


                txtFax.Text = f.Fax;
                txtInsEst.Text = f.InscricaoEstadual;
                txtSuframa.Text = f.InscricaoSuframa;
                txtEmail.Text = f.Email;

            }
            return f;
        }

        private async Task<bool> carregarMatriz()
        {
            var ctx = new BalcaoContext();

            var matrizList = await ctx.EmpresaMatrizDao.FindAllAsync();

            this.Invoke(new MethodInvoker(delegate
            {
     
                lkpMatriz.Properties.DataSource = matrizList;
            }));
            return true;
        }

        private async void XFrmAddFilial_Shown(object sender, EventArgs e)
        {
            bool result = await XFrmWait.StartTask<bool>(carregarMatriz(), "Carregando Matrizes", this);

            if (result)
            {
                indexarFormulario(_filialAnt);
            }
        }

        private void btnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EmpresaFilial novo = indexarDados();

            if (ValidadorDTO.ValidateWarningAll(novo))
            {
                using (var ctx = new BalcaoContext())
                {

                    if (_filialAnt == null)
                    {
                        if (ctx.EmpresaFilialDao.Save(novo))

                        {
                            XMessageIts.Mensagem("Filial cadastrada com sucesso!");
                            this.Dispose();
                        }
                    }
                    else
                    {
                        var fUpdate = ctx.EmpresaFilialDao.Find(_filialAnt.IdFilial);
                        fUpdate.Update(novo);
                        if (ctx.EmpresaFilialDao.Update(fUpdate))
                        {
                            this._filialAnt.Update(fUpdate);
                            XMessageIts.Mensagem("Filial atualizada com sucesso!");
                            this.Dispose();
                        }
                    }
                }
            }
        }

        private void btnCopyData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var matriz = lkpMatriz.GetSelectedDataRow() as EmpresaMatriz;
            if (matriz != null)
            {
                txtRazSocial.Text = matriz.RazaoSocial;
                txtNomeFantasia.Text = matriz.NomeFantasia;
                txtCnpj.Text = matriz.Cnpj;
                if (matriz.DtRegtroJuntaCom.HasValue)
                    dtRegistroJunta.DateTime = matriz.DtRegtroJuntaCom.Value.Date;

                lookUpMunicipio1.SetMunicipioUF(matriz.Cidade, matriz.Uf);
                cepControl1.TextCep.Text = matriz.Cep;

                txtEndereco.Text = matriz.NomeEndereco;
                txtNumEndereco.Text = matriz.NumeroEndereco;
                txtComplemento.Text = matriz.Complemento;
                txtBairro.Text = matriz.Bairro;
                cepControl1.TextCep.Text = matriz.Cep;
            }
            else
            {
                MessageBoxBlack.Show("Selecione a matriz a ser copiada");
            }

        }

        private void txtCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCnpj.Text.Length == 18)
            {
                var r = LayoutReceitaWS.GetDataFromCNPJTyped<EmpresaFilial>(txtCnpj.Text);

                indexarFormulario(r);
            }
        }
    }
}