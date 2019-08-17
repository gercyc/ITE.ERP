using System;
using ITE.Entidades.POCO;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Entities;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmEnderecoView : DevExpress.XtraEditors.XtraForm
    {
        const string Residencial = "Residencial";
        const string Correspondencia = "Correspondência";
        const string Comercial = "Comercial";

        private EnderecoCliFor _enderecoAnt;
        public EnderecoCliFor EnderecoAdd { get; private set; }

        public XFrmEnderecoView()
        {
            InitializeComponent();

            //cbClassificacaoClifor.Properties.Items.AddRange(Enum.GetValues(typeof(TypeClassificaoCliente)));
            cepControl1.AddController(txtEndereco,  txtBairro, txtComplemento, txtCidade, txtUf);
        }


        public XFrmEnderecoView(Endereco e):this()
        {
            this._enderecoAnt = indexarEndereco(new EnderecoCliFor(e.NomeEndereco, e.NumeroEndereco, e.Bairro,
                                            e.Complemento, e.Cep, e.Uf, e.Cidade, e.TipoEndereco));

        }


        /// <summary>
        /// Visualizacao/Edicao do endereco selecionado
        /// </summary>
        /// <param name="enderecoAnt"></param>
        public XFrmEnderecoView(EnderecoCliFor enderecoAnt) : this()
        {
            this._enderecoAnt = indexarEndereco(enderecoAnt);
        }

        /// <summary>
        ///Obtem os dados do endereco dos campos
        /// </summary>
        /// <param name="index"></param> Indice da aba selecionada
        /// <returns></returns>o endereco com os dados do campos
        private EnderecoCliFor indexarEndereco()
        {
            var endereco = txtEndereco.Text;
            var numEnd = txtNumero.Text;
            var bairro = txtBairro.Text;
            var complemento = txtComplemento.Text;
            var uf = txtUf.Text;
            var cep = cepControl1.TextCep.Text;
            var cidade = txtCidade.Text;
            string tipoEndereco = getSelectAdress();

            return new EnderecoCliFor(endereco, numEnd, bairro, complemento, cep, uf, cidade, tipoEndereco);

        }

        /// <summary>
        /// Seta os dados do endereço nos campos
        /// </summary>
        /// <param name="e"></param>
        private EnderecoCliFor indexarEndereco(EnderecoCliFor e)
        {
            //cria uma instancia somente para apagar os dados existentes
            if (e == null) e = new EnderecoCliFor();
            txtEndereco.Text = e.NomeEndereco;
            txtNumero.Text = e.NumeroEndereco;
            txtBairro.Text = e.Bairro;
            txtComplemento.Text = e.Complemento;
            cepControl1.TextCep.Text = e.Cep;
            txtCidade.Text = e.Cidade;
            txtUf.Text = e.Uf;

            //indexa p radiogroup
            setAdress(e);

            if (!String.IsNullOrWhiteSpace(e.NumeroEndereco) && e.NumeroEndereco.Equals("S/N"))
                checkSemNumero.Checked = true;
            else
                checkSemNumero.Checked = false;

            return e;
        }

        private string getSelectAdress()
        {
            int index = radioGroupEndereco.SelectedIndex;

            if (index == 1)
                return Comercial;

            else if (index == 2)
                return Correspondencia;

            //default
            return Residencial;

        }

        private void setAdress(EnderecoCliFor e)
        {
            //default residencial
            int index = 0;

            if (e.TipoEndereco.Equals(Comercial))
                index = 1;
            else if (e.TipoEndereco.Equals(Correspondencia))
                index = 2;


            radioGroupEndereco.SelectedIndex = index;
        }

        private void btnSalvarEndereco_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var endereco = indexarEndereco();

            if (ValidadorDTO.ValidateWarningAll(endereco))
            {
                if (_enderecoAnt == null)
                    this.EnderecoAdd = endereco;

                //alteracao
                else
                {
                    this._enderecoAnt.Update(endereco);
                    this.EnderecoAdd = _enderecoAnt;
                }

                //terminar o form
                this.Dispose();
            }

        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.EnderecoAdd = null;
            this.Dispose();
        }

        private void checkSemNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSemNumero.Checked)
                txtNumero.Text = "S/N";

        }
    }
}