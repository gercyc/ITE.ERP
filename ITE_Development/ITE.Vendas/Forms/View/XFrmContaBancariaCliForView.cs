using ITE.Entidades.POCO;
using ITSolution.Framework.Validador;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmContaBancariaCliForView : DevExpress.XtraEditors.XtraForm
    {

        public ContaBancariaCliFor ContaBancariaCliForAnt;
        public ContaBancariaCliFor ContaBancariaCliForAdd { get; private set; }

        public XFrmContaBancariaCliForView()
        {
            InitializeComponent();            
        }


        public XFrmContaBancariaCliForView(ContaBancariaCliFor c, bool edit):this()
        {
            this.ContaBancariaCliForAnt = indexarConta(c);

        }

        /// <summary>
        /// Visualizacao/Edicao do endereco selecionado
        /// </summary>
        /// <param name="xFrmAddCliFor_DEV"></param>
        /// <param name="contaAnt"></param>
        /// <param name="formTypeAction"></param>
        public XFrmContaBancariaCliForView(ContaBancariaCliFor contaAnt) : this()
        {
            this.ContaBancariaCliForAnt = indexarConta(contaAnt);
        }

        /// <summary>
        ///Obtem os dados do endereco dos campos
        /// </summary>
        /// <param name="index"></param> Indice da aba selecionada
        /// <returns></returns>o endereco com os dados do campos
        private ContaBancariaCliFor indexarConta()
        {
            var banco = txtNomeBanco.Text;
            var agencia = txtAgencia.Text;
            var conta = txtContaBancaria.Text;

            return new ContaBancariaCliFor(banco, agencia, conta);

        }

        /// <summary>
        /// Seta os dados do endereço nos campos
        /// </summary>
        /// <param name="c"></param>
        private ContaBancariaCliFor indexarConta(ContaBancariaCliFor c)
        {
            //cria uma instancia somente para apagar os dados existentes
            if (c == null) c = new ContaBancariaCliFor();
            txtNomeBanco.Text = c.NomeBanco;
            txtAgencia.Text = c.Agencia;
            txtContaBancaria.Text = c.ContaBancaria;
           

            return c;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {

            var conta = indexarConta();

            if (ValidadorDTO.ValidateWarningAll(conta))
            {
                if (ContaBancariaCliForAnt == null)
                    this.ContaBancariaCliForAdd = conta;

                //alteracao
                else
                {
                    this.ContaBancariaCliForAnt.Update(conta);
                    this.ContaBancariaCliForAdd = ContaBancariaCliForAnt;
                }

                //terminar o form
                this.Dispose();
            }

        }

    }
}