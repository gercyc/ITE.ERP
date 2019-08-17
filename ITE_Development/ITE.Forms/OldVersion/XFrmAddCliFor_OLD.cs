using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using ITE.Entidades.POCO;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Web.Correios;

namespace ITE.Forms.OldVersion
{

    public partial class XFrmAddCliForOld : DevExpress.XtraEditors.XtraForm
    {
        const string Residencial = "Residencial";
        const string Correspondencia = "Correspondência";
        const string Comercial = "Comercial";

        private EnderecoCliFor endResd;
        private EnderecoCliFor endCorresp;
        private EnderecoCliFor endComercial;
        private CliFor cliForAnt;
        private object TypeClassificaoCliFor;
        public XFrmAddCliForOld()
        {
            InitializeComponent();
            //recupere os valores do enum dos tipos
            cbTipoCliente.Properties.Items.AddRange(Enum.GetValues(typeof(TypeCliente)));
            cbClassificacaoClifor.Properties.Items.AddRange(Enum.GetValues(typeof(TypeClassificaoCliente)));
        }

        public XFrmAddCliForOld(CliFor cliFor)
            : this()
        {
            this.cliForAnt = indexarCliFor(cliFor);
        }
        public XFrmAddCliForOld(TypeClassificaoCliente type):this()
        {
            this.TypeClassificaoCliFor = type;
        }

        //Indexa o CliFor
        private CliFor indexarCliFor()
        {
            var nomeCliFor = txtNomeCliFor.Text;
            var rg = txtRg.Text;
            var cpfCnpj = maskedTxtCpfCnpj.Text;
            var dtNasc = dtDataNasc.Value;
            var tipoCliente = cbTipoCliente.SelectedIndex == 0 ? TypeCliente.Fisica : TypeCliente.Juridica;
            var telefone = txtTelFixo.Text;
            var celular = txtCelular.Text;
            var telComercial = txtTelComercial.Text;
            TypeClassificaoCliente classificacao;

            if (TypeClassificaoCliFor != null)
                classificacao = (TypeClassificaoCliente) TypeClassificaoCliFor ;

            else if (cbClassificacaoClifor.SelectedIndex == (int)TypeClassificaoCliente.Cliente)
                classificacao = TypeClassificaoCliente.Cliente;

            else if (cbClassificacaoClifor.SelectedIndex == (int)TypeClassificaoCliente.Fornecedor)
                classificacao = TypeClassificaoCliente.Fornecedor;

            else if (cbClassificacaoClifor.SelectedIndex == (int)TypeClassificaoCliente.Ambos)
                classificacao = TypeClassificaoCliente.Ambos;
            else
                classificacao = TypeClassificaoCliente.Cliente;

            //se o cliForAnt existe entao estou atualizado
            //entao eu quero somente os dados do cliente
            //pois o endereco ja existe e vou obter os dados do endereço
            //individualmente para cada endereço do cliente
            if (cliForAnt != null)
            {
                //corrigindo a mascara
                //retira as virgulas
                //caracter hifen "-"
                //caracter hifen "/"
                cpfCnpj = cpfCnpj.Replace(",", "");
                cpfCnpj = cpfCnpj.Replace("-", "");
                cpfCnpj = cpfCnpj.Replace("/", "");

                //garante que seja salvo somente numeros
                return new CliFor(nomeCliFor, rg, cpfCnpj, dtNasc, tipoCliente,
                                    telefone, celular, telComercial, classificacao);
            }

            var enderecos = new List<EnderecoCliFor>();

            if (endResd != null)
                enderecos.Add(endResd);

            if (endCorresp != null)
                enderecos.Add(endCorresp);

            if (endComercial != null)
                enderecos.Add(endComercial);

            return new CliFor(nomeCliFor, rg, cpfCnpj, dtNasc, tipoCliente,
                telefone, celular, telComercial, enderecos, classificacao);
        }

        //Indexa os campos do CliFor
        private CliFor indexarCliFor(CliFor cliFor)
        {
            if (cliFor != null)
            {
                //mude o flag do botao para atualizar
                //this.btnAddEndereco.Image = ((System.Drawing.Image)(Properties.Resources.refresh_16x16));

                this.btnAddEndereco.Text = "Atualizar Endereço";

                txtNomeCliFor.Text = cliFor.RazaoSocial;
                txtRg.Text = cliFor.RG;
                maskedTxtCpfCnpj.Text = cliFor.CpfCnpj;

                dtDataNasc.Value = cliFor.DataNascimento.Value;

                if (TypeClassificaoCliFor != null)
                    cbTipoCliente.SelectedIndex = (int)TypeClassificaoCliFor;
                else
                {

                    cbTipoCliente.SelectedIndex = (int)cliFor.TipoCliente;
                    cbClassificacaoClifor.SelectedIndex = (int)cliFor.Classificacao;
                }


                txtTelFixo.Text = cliFor.Telefone;
                txtTelComercial.Text = cliFor.TelefoneComercial;
                txtCelular.Text = cliFor.Celular;
                txtEmail.Text = cliFor.Email;

                var enderecos = cliFor.Enderecos != null ? cliFor.Enderecos.ToList() : new List<EnderecoCliFor>();

                for (int i = 0; i < enderecos.Count; i++)
                {
                    try
                    {
                        var end = enderecos[i];
                        int index = 0;
                        if (end != null)
                            switch (end.TipoEndereco)
                            {
                                // o metodo SelectedTab dispara um metodo
                                //indexarEndereco que seta so dados nos campos
                                case Residencial:
                                    index = 0;
                                    endResd = end;
                                    tabEnderecos.SelectedTabPageIndex = index;
                                    break;
                                case Correspondencia:
                                    index = 1;
                                    endCorresp = end;
                                    tabEnderecos.SelectedTabPageIndex = index;
                                    break;

                                case Comercial:
                                    index = 2;
                                    endComercial = end;
                                    tabEnderecos.SelectedTabPageIndex = index;
                                    break;
                            }
                        flagEndereco(index, "OK", Color.Green, end);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                    }
                }
            }
            return cliFor;
        }

        /// <summary>
        ///Obtem os dados do endereco dos campos
        /// </summary>
        /// <param name="index"></param> Indice da aba selecionada
        /// <returns></returns>o endereco com os dados do campos
        private EnderecoCliFor indexarEndereco(int index)
        {
            var endereco = txtLogradouro.Text;
            var numEnd = txtNumeroEnd.Text;
            var bairro = txtBairro.Text;
            var complemento = txtComplemento.Text;
            var uf = txtUf.Text;
            var cep = txtCep.Text;
            var cidade = txtCidade.Text;
            string tipoEndereco;

            switch (index)
            {
                case 1:
                    tipoEndereco = Residencial;
                    break;
                case 2:
                    tipoEndereco = Correspondencia;
                    break;

                case 3: tipoEndereco = Comercial;
                    break;

                default:
                    tipoEndereco = Residencial;
                    break;
            }
            return new EnderecoCliFor(endereco, numEnd, bairro, complemento, cep, uf, cidade, tipoEndereco);
            /*  return new Endereco(txtLogradouro.Text, txtNumeroEnd.Text, txtBairro.Text, 
                 txtComplemento.Text, txtCep.Text, txtCidade.Text, txtUf.Text);*/

        }

        /// <summary>
        /// Seta os dados do endereço nos campos
        /// </summary>
        /// <param name="e"></param>
        private void indexarEndereco(EnderecoCliFor e)
        {
            //cria uma instancia somente para apagar os dados existentes
            if (e == null) e = new EnderecoCliFor();
            txtLogradouro.Text = e.NomeEndereco;
            txtNumeroEnd.Text = e.NumeroEndereco;
            txtBairro.Text = e.Bairro;
            txtComplemento.Text = e.Complemento;
            txtCep.Text = e.Cep;
            txtCidade.Text = e.Cidade;
            txtUf.Text = e.Uf;

            if (!String.IsNullOrWhiteSpace(e.NumeroEndereco) && e.NumeroEndereco.Equals("S/N"))
                checkSemNumero.Checked = true;
            else
                checkSemNumero.Checked = false;
        }

        private void updateCliFor(CliFor novo, BalcaoContext ctx)
        {
            var cliFor = ctx.CliFors.Find(cliForAnt.IdCliFor);

            //atualizando o cliente com os dado dos campos
            cliFor.Update(novo);

            //atualize ou save o endereco 
            updateOrSaveEnderecos(ctx, cliFor);

            if (ctx.CliForDao.Update(cliFor))
            {
                XMessageIts.Mensagem("Os dados do cliente foram atualizados.");
            }
        }
        private void updateOrSaveEnderecos(BalcaoContext ctx, CliFor cliFor)
        {
            var resd = cliFor.Enderecos.ToList().Find(e => e.TipoEndereco.Equals(Residencial));
            var corresp = cliFor.Enderecos.ToList().Find(e => e.TipoEndereco.Equals(Correspondencia));
            var comercial = cliFor.Enderecos.ToList().Find(e => e.TipoEndereco.Equals(Comercial));

            //atualizando endereço
            if (resd != null && endResd != null)
            {
                resd.Update(endResd);
                ctx.EnderecoCliForDao.Update(resd);
            }
            //add endereco para ser salvo
            else if (resd == null && endResd != null)
            {
                cliFor.Enderecos.Add(endResd);
            }

            //atualizando endereço
            if (corresp != null && endCorresp != null)
            {
                corresp.Update(endCorresp);
                ctx.EnderecoCliForDao.Update(corresp);
            }
            //add endereco para ser salvo
            else if (corresp == null && endCorresp != null)
            {
                cliFor.Enderecos.Add(corresp);
            }

            //atualizando endereço
            if (comercial != null && endComercial != null)
            {
                comercial.Update(endComercial);
                ctx.EnderecoCliForDao.Update(comercial);
            }
            //add endereco para ser salvo
            else if (comercial == null && endComercial != null)
            {
                cliFor.Enderecos.Add(comercial);
            }
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            CliFor c = indexarCliFor();

            //validando o cliente
            if (ValidadorDTO.ValidateWarningAll(c) && validarCpfCnpj())
            {

                /* if (endResd == null && endComercial == null && endCorresp == null)
                 {
                     XMessageIts.Advertencia("Informe pelo menos um endereço", "Atenção");
                     return;
                 }*/
                var ctx = new BalcaoContext();

                if (cliForAnt == null)
                {
                    if (ctx.CliForDao.Save(c))
                    {
                        XMessageIts.Mensagem("Cliente cadastrado com sucesso");
                        this.Dispose();
                    }
                }
                else
                {
                    //ação de atualizar
                    updateCliFor(c, ctx);
                }
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void checkSemNumero_CheckedChanged(object sender, System.EventArgs e)
        {
            txtNumeroEnd.Enabled = !checkSemNumero.Checked;

            if (checkSemNumero.Checked)
            {
                txtNumeroEnd.Text = "S/N";
            }
            else
            {
                txtNumeroEnd.Text = "";
                txtNumeroEnd.Focus();
            }
        }

        private void tabEnderecos_SelectedPageChanged(object sender,
            DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            //guarde o indice da tab selecionad do endereço a ser salvo 
            //indexado a partir do 1
            int index = tabEnderecos.SelectedTabPageIndex;
            //ver o endereco add caso ele exista
            switch (index)
            {
                case 0: indexarEndereco(endResd); break;

                case 1: indexarEndereco(endCorresp); break;

                case 2: indexarEndereco(endComercial); break;
                //Whatever -> Fodase
                default: break;
            }
        }

        private void btnAddEndereco_Click(object sender, EventArgs e)
        {
            int index = tabEnderecos.SelectedTabPageIndex;
            if (index >= 0)
            {
                //cria um endereço com os dados dos campos
                var end = indexarEndereco(index);
                if (ValidadorDTO.ValidateWarningAll(end))
                {
                    flagEndereco(index, "OK", Color.Blue, end);
                }
            }
        }

        private void btnExcluirEndereco_Click(object sender, EventArgs e)
        {
            int index = tabEnderecos.SelectedTabPageIndex;

            flagEndereco(index, " - ", Color.Black, null);

            indexarEndereco(new EnderecoCliFor());
        }

        private void flagEndereco(int index, string flag, Color color, EnderecoCliFor end)
        {
            switch (index)
            {
                case 0:
                    endResd = end;
                    lblFlagResid.Text = flag;
                    lblFlagResid.ForeColor = color;
                    break;

                case 1:
                    endCorresp = end;
                    lblFlagCorresp.Text = flag;
                    lblFlagCorresp.ForeColor = color;
                    break;

                case 2:
                    endComercial = end;
                    lblFlagComercial.Text = flag;
                    lblFlagComercial.ForeColor = color;
                    break;
            }
        }


        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            int lenght = txtCep.Text.Length;

            if (lenght == 5)
            {
                txtCep.Text = txtCep.Text + "-";
                txtCep.SelectionStart = lenght + 1;
            }


        }

        private void txtCep_EditValueChanged(object sender, EventArgs e)
        {
            int lenght = txtCep.Text.Length;

            if (lenght == 9)
                validaCep();

            lblFlagCep.Visible = false;
        }

        private async void validaCep()
        {
            SplashScreenManager.ShowForm(typeof(XFrmWait));

            XFrmWait.ShowSplashScreen ("Procurando CEP");

            string cep = txtCep.Text;

            FindCepIts find = new FindCepIts();

            var result = await find.FindAdress(txtCep.Text);

            if (result)
            {
                txtCidade.Enabled = false;
                txtUf.Enabled = false;
                lblFlagCep.Visible = true;
            }
            else
            {
                txtCidade.Enabled = true;
                txtUf.Enabled = true;
                lblFlagCep.Visible = false;
            }

            txtCep.Text = find.Cep;
            txtCidade.Text = find.Cidade;
            txtUf.Text = find.UF;
            txtBairro.Text = find.Bairro;
            txtLogradouro.Text = find.Endereco;

            SplashScreenManager.CloseForm();

        }
        
        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoCliente.SelectedIndex == (int)TypeClassificaoCliente.Cliente)
                maskedTxtCpfCnpj.Mask = "000\\.000\\.000\\-00";
            else
                maskedTxtCpfCnpj.Mask = "00\\.000\\.000\\/0000\\-00";
        }

        private void maskedTxtCpfCnpj_Enter(object sender, EventArgs e)
        {
            maskedTxtCpfCnpj.SelectionStart = 1;
            maskedTxtCpfCnpj.SelectAll();
        }

        private bool validarCpfCnpj()
        {
            var cpfCnpj = maskedTxtCpfCnpj.Text;
            var valido = false;

            //ignore se nao informar
            if (cpfCnpj.Equals("  ,   ,   /    -")) return true;

            if (cbTipoCliente.SelectedIndex == (int)TypeClassificaoCliente.Cliente)
            {
                valido = StringUtilIts.IsCpf(cpfCnpj);
                if (!valido)
                    XMessageIts.Advertencia("CPF: " + cpfCnpj + " inválido");

            }
            else
            {
                valido = StringUtilIts.IsCnpj(cpfCnpj);
                if (!valido)
                    XMessageIts.Advertencia("CNPJ: " + cpfCnpj + " inválido");
            }
            return valido;
        }

        private void maskedTxtCpfCnpj_Leave(object sender, EventArgs e)
        {
            validarCpfCnpj();
        }
    }
}