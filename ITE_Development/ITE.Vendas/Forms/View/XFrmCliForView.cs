using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.POCO;
using ITSolution.Framework.GuiUtil;
using System;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Enumeradores;
using ITE.Entidades.DaoManager;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITSolution.Framework.Web.JSON;

namespace ITE.Vendas.Forms.View
{
    public partial class XFrmCliForView : DevExpress.XtraEditors.XtraForm
    {
        #region Declaracao de variaveis
        private const string Correspondencia = "Correspondência";
        private const string Comercial = "Comercial";
        private List<EnderecoCliFor> _enderecos = new List<EnderecoCliFor>();
        private List<AtividadePrincipalCliFor> _atividadesPrincipais = new List<AtividadePrincipalCliFor>();
        private List<AtividadeSecundariaCliFor> atividadesSecundarias = new List<AtividadeSecundariaCliFor>();
        private List<ContaBancariaCliFor> _contasBancarias = new List<ContaBancariaCliFor>();
        private CliFor _cliForAnt;
        /// <summary>
        /// Cliente salvo setado no dispose do botao salvar
        /// </summary>
        public CliFor ClienteAdd { get; private set; }
        public bool IsSave { get; internal set; }
        #endregion Declaracao de variaveis

        #region Construtores

        public XFrmCliForView()
            : this(TypeClassificaoCliente.Cliente)
        {

        }

        public XFrmCliForView(TypeClassificaoCliente type)
        {
            init();
            radioGroupTipoCliFor.SelectedIndex = (int)type;
            cbClassificacaoClifor.SelectedIndex = (int)type;
        }

        public XFrmCliForView(CliFor cliFor)
                : this(cliFor.Classificacao)
        {
            this._cliForAnt = indexarCliFor(cliFor);

            FormsUtil.AddShortcutEscapeOnDispose(this);
        }


        #endregion Construtores

        #region Metodos

        private void init()
        {
            InitializeComponent();
            this.ActiveControl = this.txtRazaoSocial;
            txtRazaoSocial.Focus();
            new TextEditUtil(this.txtCapitalSocial).CustomizeNumberField();

            this.cepControl1.AddController(lookUpMunicipio1.ComboEditMunicipio, lookUpMunicipio1.ComboEditUF);

            cnpjControl1.AddController(txtRazaoSocial,
                txtNaturezaJuridica, txtNomeFantasia, dtPickerAbertura,
                txtSituacao, txtDataSituacao, txtSituacaoEspecial,
                txtDataSituacaoEspecial, txtMotivoSituacaoEspecial,
                 dtPickerAtualizacao, txtStatus, txtEFR, txtEmail,
                txtTelefone, txtTelComercial, txtTipo,
                txtCapitalSocial);

            //ação disparada apos a validação do CNPJ
            this.cnpjControl1.DelegateValidation = DelegatePosValidation();
        }

        private MethodInvoker DelegatePosValidation()
        {

            var method = new MethodInvoker(delegate
            {
                var result = this.cnpjControl1.ResultValidation;

                this._enderecos.Clear();
                this._atividadesPrincipais.Clear();
                this.atividadesSecundarias.Clear();

                result.AtividadesPrincipais.ForEach(AddAtvPrincipal);
                result.AtividadesSecundarias.ForEach(AddAtvSecundarias);

                EnderecoCliFor end = new EnderecoCliFor();
                end.TipoEndereco = Comercial;
                end.Update(this.cnpjControl1.Endereco);

                //evitar o acesso de outra thread
                txtEndereco.Text = end.NomeEndereco;
                txtNumero.Text = end.NumeroEndereco;
                txtBairro.Text = end.Bairro;
                txtComplemento.Text = end.Complemento;
                cepControl1.TextCep.Text = end.Cep;

                lookUpMunicipio1.SetMunicipioUF(end.Cidade, end.Uf);

                if (!string.IsNullOrWhiteSpace(end.NumeroEndereco) && end.NumeroEndereco.Equals("S/N"))
                    checkSemNumero.Checked = true;
                else
                    checkSemNumero.Checked = false;

                if (_cliForAnt != null)
                    this._enderecos.AddRange(_cliForAnt.Enderecos);

                //this._enderecos.Add(end);

                this.gridControlEnderecos.DataSource = this._enderecos;
                this.gridViewEnderecos.RefreshData();

                this.gridControlAtvPrincipal.DataSource = this._atividadesPrincipais;
                this.gridControlAtvSecundarias.DataSource = this.atividadesSecundarias;
                //nao foi implementado
                this.gridControlQsa.DataSource = result.Qsa;
            });

            return method;
        }

        private void AddAtvSecundarias(ModelLayout a)
        {
            var atv = new AtividadeSecundariaCliFor(a.Descricao, a.Codigo);
            //atv.Update(a);
            this.atividadesSecundarias.Add(atv);
        }

        private void AddAtvPrincipal(ModelLayout a)
        {
            var atv = new AtividadePrincipalCliFor(a.Descricao, a.Codigo);

            //atv.Update(a);

            this._atividadesPrincipais.Add(atv);
        }

        //Indexar os dados empresariais
        private CliFor indexarCliFor()
        {
            CliFor novo = new CliFor();
            if (cnpjControl1.ResultValidation != null)
                //alterando o objeto por referencia
                this.cnpjControl1.ResultValidation.ToClient(novo);

            var nomeCliFor = txtRazaoSocial.Text;
            var rg = txtRg.Text;
            var cpfCnpj = cnpjControl1.MaskedTxtCpfCnpj.Text;
            var dtNasc = dtDataNasc.DateTime.ValidateDate();
            var tipoCliente = (TypeCliente)radioGroupTipoCliFor.SelectedIndex;
            var classificacao = (TypeClassificaoCliente)cbClassificacaoClifor.SelectedIndex;

            var telefone = txtTelefone.Text;
            var celular = txtCelular.Text;
            var telComercial = txtTelComercial.Text;

            novo.RazaoSocial = nomeCliFor;
            novo.RG = rg;
            novo.CpfCnpj = cpfCnpj;
            novo.DataNascimento = dtNasc;

            novo.TipoCliente = tipoCliente;

            novo.Telefone = telefone;
            novo.Celular = celular;
            novo.TelefoneComercial = telComercial;

            novo.Classificacao = classificacao;


            //add os endereco do grid no objeto cliente
            this._enderecos.ForEach(novo.Enderecos.Add);

            //add as contas do grid no objeto cliente
            this._contasBancarias.ForEach(novo.ContasBancariasCliFor.Add);

            novo.Classificacao = classificacao;

            novo.Email = txtEmail.Text;


            //add a lista de atv
            this._atividadesPrincipais.ForEach(novo.AtividadesPrincipais.Add);

            //add a lista de atv
            this.atividadesSecundarias.ForEach(novo.AtividadesSecundarias.Add);


            //se o cliForAnt existe entao estou atualizado
            //entao eu quero somente os dados do cliente
            //pois o endereco ja existe e vou obter os dados do endereço
            //individualmente para cada endereço do cliente
            if (_cliForAnt != null)
            {
                //caracter hifen "-" "/"
                //garante que seja salvo somente numeros
                //cpfCnpj = cpfCnpj.Replace(".", "").Replace("-", "").Replace("/", "");
                novo.IdCliFor = _cliForAnt.IdCliFor;
            }

            //dados juridicos
            novo.NaturezaJuridica = this.txtNaturezaJuridica.Text;

            if (DataUtil.IsValidDate(this.dtPickerAbertura.DateTime))
                novo.Abertura = this.dtPickerAbertura.DateTime.ToShortDateString();

            novo.NomeFantasia = this.txtNomeFantasia.Text;
            novo.Tipo = this.txtTipo.Text;
            novo.SituacaoJuridica = this.txtSituacao.Text;
            novo.DataSituacao = this.txtDataSituacao.Text;
            novo.Efr = this.txtEFR.Text;
            novo.StatusCliente = this.txtStatus.Text;
            novo.SituacaoEspecial = this.txtSituacaoEspecial.Text;
            novo.MotivoSituacao = this.txtMotivoSituacaoEspecial.Text;
            novo.DataSituacaoEspecial = this.txtDataSituacaoEspecial.Text;
            novo.InscricaoEstadual = this.txtInscEstadual.Text;
            novo.InscricaoMunicipal = this.txtInscMunicipal.Text; if (this.dtPickerAtualizacao.DateTime.ValidateDate() != null)
                novo.UltimaAtualizacao = this.dtPickerAtualizacao.DateTime;

            novo.CapitalSocial = ParseUtil.ToDecimal(this.txtCapitalSocial.Text);

            setEnderecoCliFor(novo);
            return novo;

        }

        private CliFor indexarCliFor(CliFor c)
        {
            if (c != null)
            {

                txtRazaoSocial.Text = c.RazaoSocial;
                txtRg.Text = c.RG;
                cbClassificacaoClifor.SelectedIndex = (int)c.Classificacao;

                radioGroupTipoCliFor.SelectedIndex = (int)c.TipoCliente;
                cnpjControl1.MaskedTxtCpfCnpj.Text = c.CpfCnpj;

                if (c.DataNascimento == null)
                    dtDataNasc.Enabled = false;
                else
                {
                    dtDataNasc.DateTime = c.DataNascimento.Value;
                    dtDataNasc.Enabled = true;
                }
                if (c.Telefone != null && c.Telefone.StartsWith("0800"))
                {
                    ch0800.Checked = true;
                    ch0800_CheckedChanged(null, null);
                }
                this.txtTelefone.Text = c.Telefone;
                this.txtTelComercial.Text = c.TelefoneComercial;
                this.txtCelular.Text = c.Celular;
                this.txtEmail.Text = c.Email;


                this.txtNaturezaJuridica.Text = c.NaturezaJuridica;
                if (DataUtil.IsValidDate(DataUtil.ToDate(c.Abertura)))
                    this.dtPickerAbertura.DateTime = DataUtil.ToDate(c.Abertura);

                this.txtNomeFantasia.Text = c.NomeFantasia;
                this.txtTipo.Text = c.Tipo;
                this.txtSituacao.Text = c.SituacaoJuridica;
                this.txtDataSituacao.Text = c.DataSituacao;
                this.txtEFR.Text = c.Efr;
                this.txtStatus.Text = c.StatusCliente;
                this.txtSituacaoEspecial.Text = c.SituacaoEspecial;
                this.txtMotivoSituacaoEspecial.Text = c.MotivoSituacao;
                this.txtDataSituacaoEspecial.Text = c.DataSituacaoEspecial;
                this.txtInscEstadual.Text = c.InscricaoEstadual;
                this.txtInscMunicipal.Text = c.InscricaoMunicipal;

                if (c.UltimaAtualizacao.HasValue)
                    this.dtPickerAtualizacao.DateTime = c.UltimaAtualizacao.Value.Date;


                this.txtCapitalSocial.Text = "" + c.CapitalSocial;


                this._atividadesPrincipais = c.AtividadesPrincipais.ToList();
                this.atividadesSecundarias = c.AtividadesSecundarias.ToList();

                this._enderecos = c.Enderecos.ToList();
                this._contasBancarias = c.ContasBancariasCliFor.ToList();

                this.gridControlEnderecos.DataSource = this._enderecos;
                this.gridViewEnderecos.RefreshData();

                this.gridControlAtvPrincipal.DataSource = this._atividadesPrincipais; ;
                this.gridViewAtvPrincipal.RefreshData();

                this.gridControlAtvSecundarias.DataSource = this.atividadesSecundarias;
                this.gridViewAtvSecundarias.RefreshData();

                this.gridControlCtbCliFor.DataSource = this._contasBancarias;
                this.gridViewEnderecos.RefreshData();

                this.grpControlQsa.Visible = false;

                //traz o endereco primario do cliente
                indexarEndereco(c);

            }

            return c;
        }

        #region Endereco Principal

        /// <summary>
        ///Obtem os dados do endereco dos campos
        /// </summary>
        /// <param name="index"></param> Indice da aba selecionada
        /// <returns></returns>o endereco com os dados do campos
        private void setEnderecoCliFor(CliFor c)
        {
            var endereco = txtEndereco.Text;
            var numEnd = txtNumero.Text;
            var bairro = txtBairro.Text;
            var complemento = txtComplemento.Text;
            var uf = lookUpMunicipio1.UF;
            var cidade = lookUpMunicipio1.Municipio;
            var cep = cepControl1.TextCep.Text;

            c.NomeEndereco = endereco;
            c.NumeroEndereco = numEnd;
            c.Bairro = bairro;
            c.Complemento = complemento;
            c.Cep = cep;
            c.Uf = uf;
            c.Cidade = cidade;
            c.TipoEndereco = Correspondencia;

        }

        /// <summary>
        /// Seta os dados do endereço nos campos
        /// </summary>
        /// <param name="e"></param>
        private void indexarEndereco(CliFor c)
        {
            //cria uma instancia somente para apagar os dados existentes

            txtEndereco.Text = c.NomeEndereco;
            txtNumero.Text = c.NumeroEndereco;
            txtBairro.Text = c.Bairro;
            txtComplemento.Text = c.Complemento;
            cepControl1.TextCep.Text = c.Cep;

            lookUpMunicipio1.SetMunicipioUF(c.Cidade, c.Uf);

            if (!string.IsNullOrWhiteSpace(c.NumeroEndereco) && c.NumeroEndereco.Equals("S/N"))
                checkSemNumero.Checked = true;
            else
                checkSemNumero.Checked = false;

        }

        private void checkSemNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSemNumero.Checked)
                txtNumero.Text = "S/N";

        }

        #endregion

        #endregion Metodos interno

        #region Eventos 

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupTipoCliFor.SelectedIndex == (int)TypeClassificaoCliente.Cliente)
            {
                cnpjControl1.SetMaskCPF();
                this.txtRg.Enabled = true;
                this.dtDataNasc.Enabled = true;
                this.lblCapitalSocial.Visible = false;
                this.txtCapitalSocial.Visible = false;
                //this.pnlDadosJuridicos.Visible = false;
                //this.Location = new Point(this.Location.X, this.Location.Y + 125);
                //this.Height = 410;

            }
            else
            {
                //this.Height = 630;
                //move o form pra cima
                //this.Location = new Point(this.Location.X, this.Location.Y - 100);
                //this.pnlDadosJuridicos.Visible = true;
                cnpjControl1.SetMaskCNPJ();
                this.txtRg.Enabled = false;
                this.dtDataNasc.Enabled = false;
                this.lblCapitalSocial.Visible = true;
                this.txtCapitalSocial.Visible = true;
            }

        }

        private void btnAddEndereco_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmEnderecoView addEnd = new XFrmEnderecoView();

            addEnd.ShowDialog();

            if (addEnd.EnderecoAdd != null)
            {
                this._enderecos.Add(addEnd.EnderecoAdd);

                this.gridControlEnderecos.DataSource = this._enderecos;
                this.gridViewEnderecos.RefreshData();

                //PRECISO DEIXAR O ENDERECO VISIVEL
            }
        }

        private void btnViewEditEndereco_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var enderecoSelect = gridViewEnderecos.GetFocusedRow<EnderecoCliFor>();
            if (enderecoSelect != null)
            {
                var addEnd = new XFrmEnderecoView(enderecoSelect);

                addEnd.ShowDialog();

                if (addEnd.EnderecoAdd != null)
                {
                    this._enderecos.Remove(enderecoSelect);
                    this._enderecos.Add(addEnd.EnderecoAdd);
                    this.gridViewEnderecos.RefreshData();
                }
            }
        }

        private void btnDelEndereco_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var end = gridViewEnderecos.GetFocusedRow<EnderecoCliFor>();
            if (end != null)
            {
                //Adiciona a lista de enderecos removidos
                this._enderecos.Remove(end);
                this.gridViewEnderecos.RefreshData();
            }
        }

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CliFor novo = indexarCliFor();

            //validando o cliente
            if (ValidadorDTO.ValidateWarningAll(novo))
            {
                var manager = new ClienteDaoManager();
                if (_cliForAnt == null)
                {
                    IsSave = manager.Save(novo);

                    if (IsSave)
                    {
                        XMessageIts.Mensagem("Cliente cadastrado com sucesso.");
                        this.ClienteAdd = novo;
                        this.Dispose();
                    }
                }
                else
                {
                    //ação de atualizar
                    if (manager.Update(novo))
                    {
                        //atualiza no grid
                        _cliForAnt.Update(novo);
                        //atualiza os endereços tbm
                        _cliForAnt.Enderecos = novo.Enderecos;
                        //atualizando as contas
                        _cliForAnt.ContasBancariasCliFor = novo.ContasBancariasCliFor;
                        XMessageIts.Mensagem("Os dados do cliente foram atualizados.");
                        this.Dispose();
                    }
                }
            }
        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void ch0800_CheckedChanged(object sender, EventArgs e)
        {
            if (ch0800.Checked)
                this.txtTelefone.Properties.Mask.EditMask = "\\d\\d\\d\\d-\\d\\d\\d-\\d\\d\\d\\d";
            else
                this.txtTelefone.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d-\\d\\d\\d\\d";
        }
        private void btnAddContaCliFor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmContaBancariaCliForView addCtb = new XFrmContaBancariaCliForView();

            addCtb.ShowDialog();

            if (addCtb.ContaBancariaCliForAdd != null)
            {
                this._contasBancarias.Add(addCtb.ContaBancariaCliForAdd);
                this.gridControlCtbCliFor.DataSource = this._contasBancarias;
                this.gridViewCtbCliFor.RefreshData();
            }
        }
        private void btnEditContaCliFor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var contaSelect = gridViewCtbCliFor.GetFocusedRow<ContaBancariaCliFor>();
            if (contaSelect != null)
            {
                var addConta = new XFrmContaBancariaCliForView(contaSelect);

                addConta.ShowDialog();

                if (addConta.ContaBancariaCliForAdd != null)
                {
                    this._contasBancarias.Remove(contaSelect);
                    this._contasBancarias.Add(addConta.ContaBancariaCliForAdd);
                    this.gridViewCtbCliFor.RefreshData();
                }
            }
        }

        private void btnRemoveContaCliFor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var conta = gridViewCtbCliFor.GetFocusedRow<ContaBancariaCliFor>();
            if (conta != null)
            {
                //Adiciona a lista de enderecos removidos
                this._contasBancarias.Remove(conta);
                this.gridViewCtbCliFor.RefreshData();
            }
        }

        #endregion Fim dos eventos
    }
}