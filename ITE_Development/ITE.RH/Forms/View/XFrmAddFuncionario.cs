using System;
using ITSolution.Framework.Validador;
using ITSolution.Framework.Mensagem;
using ITE.Entidades.POCO.RH;
using ITSolution.Framework.Util;
using ITE.Entidades.Repositorio;
using ITE.RH.Enumeradores;
using System.Windows.Forms;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Enumeradores;
using System.ComponentModel;
using ITSolution.Framework.Entities;
using ITE.Entidades.UnitControl;
using ITE.Entidades.DaoManager.RHDaoManager;
using ITE.Entidades.POCO.RH.Folha;
using ITSolution.Framework.Beans.Forms;
using System.Linq;
using System.Collections.Generic;
using ITSolution.Framework.Forms;

//Unlock o Panel dos Historicos para manipular o form
//Form com muitos campos
namespace ITE.RH.Forms.View
{
    public partial class XFrmAddFuncionario : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variaveis

        private Funcionario funcAnt;
        private List<EventoFuncionario> eventosFuncionario;

        #endregion Variaveis

        #region Construtores

        public XFrmAddFuncionario()
        {
            InitializeComponent();
            this.ActiveControl = this.txtNome;
            this.txtNome.Focus();
            initi();
            this.cbSituacao.SelectedIndex = 0;
            this.cbSituacao.ReadOnly = true;
            new TextEditUtil(this.txtSalario).CustomizeNumberField();
            lookUpMatrizFilial1.FindSetMatrizFilial(UnitWork.Filial.Matriz, UnitWork.Filial);
            this.eventosFuncionario = new List<EventoFuncionario>();
            FormsUtil.AddShortcutEscapeOnDispose(this);

        }

        public XFrmAddFuncionario(Funcionario funcionario, FormTypeAction action = FormTypeAction.Nenhum) : this()
        {
            this.funcAnt = this.indexarFuncionario(funcionario);
            this.cbSituacao.ReadOnly = false;
            this.dtDataAdmissao.Enabled = false;
            this.cbDepartamento.Enabled = false;
            this.cbFuncao.Enabled = false;
            this.cbSituacao.Enabled = false;
            this.txtSalario.Enabled = false;

            var q = from p in funcionario.Eventos.Where(e => e.Removed == false)
                    select new EventoFuncionario() { Evento = p.Evento, IdEvento = p.IdEvento, Valor = p.Valor, IdFuncionario = p.IdFuncionario, IdRegistro = p.IdRegistro, Removed = p.Removed };

            this.eventosFuncionario = q.ToList();

            gridControlEvtFunc.DataSource = this.eventosFuncionario;

            if (action == FormTypeAction.Visualizar)
                ComponenteUtil.DesabilitarComponentes(new Component[] { this.ribbon,
                    this.navPaneHistoricoPai,
                    this.navPaneHistDepartamento, this.navPaneHistFuncao, this.navPaneHistSalarial,
                    this.navPaneInfoPessoais,this.navPaneEndereco , this.navPaneCTPS, navPaneDadosAdmissionais, navPaneDocumentos });

        }

        #endregion Construtores 

        #region Metodos internos

        private void initi()
        {
            this.cepControl1.AddController(lookUpMunicipio1.ComboEditMunicipio, lookUpMunicipio1.ComboEditUF);
            //unificado
            using (var ctx = new BalcaoContext())
            {

                var deptos = ctx.DepartamentoDao.FindAll();
                var funcoes = ctx.FuncaoDao.FindAll();
                var undfed = ctx.UnidadeFederacaoDao.FindAll();
                var tiposLograd = ctx.TipoLogradouroDao.FindAll();
                var gruposEvento = ctx.GrupoEventoDao.FindAll();

                //limpa
                cbTipoRecebimento.Properties.Items.Clear();
                cbDepartamento.Properties.Items.Clear();
                cbFuncao.Properties.Items.Clear();
                cbSituacao.Properties.Items.Clear();
                cbGrpEventoFunc.Properties.Items.Clear();

                cbTipoRecebimento.Properties.Items.AddRange(Enum.GetValues(typeof(TypeRecebimento)));
                cbDepartamento.Properties.Items.AddRange(deptos);
                cbFuncao.Properties.Items.AddRange(funcoes);
                cbSituacao.Properties.Items.AddRange(Enum.GetValues(typeof(TypeSituacaoFuncionario)));
                cbGrpEventoFunc.Properties.Items.AddRange(gruposEvento);
                //sempre sera carregado
                cbTipoLogradouros.Properties.Items.AddRange(tiposLograd);
                cbEstadoEmissaoCTPS.Properties.Items.AddRange(undfed);
                cbEstadoCivil.Properties.Items.AddRange(Enum.GetValues(typeof(TypeEstadoCivil)));

            }
        }
        private void setDataGridEventos()
        {
            try
            {
                gridControlEvtFunc.DataSource = null;

                var q = from p in this.eventosFuncionario.Where(e => e.Removed == false)
                        select new EventoFuncionario() { Evento = p.Evento, IdEvento = p.IdEvento, Valor = p.Valor };

                gridControlEvtFunc.DataSource = q.ToList();
                gridControlEvtFunc.RefreshDataSource();
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Erro ao atualizar grid", "Erro fatal!");
            }

        }
        #endregion Metodos internos

        #region Area de coleta de dados

        private Funcionario indexarFuncionario()
        {
            Funcionario novo;
            var filial = lookUpMatrizFilial1.Filial;
            var nomeFuncionario = txtNome.Text;
            var dataAdmissao = dtDataAdmissao.DateTime;
            var dataNasc = dtDataNasc.DateTime;
            var codigo = txtCodigoFunc.Text;
            var cpf = txtCpf.Text;

            var telefoneFixo = txtTelFixo.Text;
            var celular = txtCelular.Text;
            var email = txtEmail.Text;

            var salario = ParseUtil.ToDecimal(txtSalario.Text);
            var foto = ImageUtilIts.GetBytesFromImage(this.pictureEditFoto.Image);

            var departamento = cbDepartamento.SelectedItem as Departamento;
            var funcao = cbFuncao.SelectedItem as Funcao;

            var grpEventos = cbGrpEventoFunc.SelectedItem as GrupoEvento;

            string msg = "";
            if (dataNasc.ValidateDate() == null)
            {
                msg += "Informe a data de nascimento";
            }

            if (dataAdmissao.ValidateDate() == null)
            {
                msg = msg + "\nInforme a data de admissão";
            }


            if (!String.IsNullOrWhiteSpace(msg))
            {
                XMessageIts.Advertencia(msg);
                return null;
            }

            novo = new Funcionario(codigo, nomeFuncionario, cpf, dataNasc, telefoneFixo, celular,
                                        email, dataAdmissao, departamento, funcao, salario, foto);

            novo.IdFilial = filial != null ? filial.IdFilial : 0;
            novo.DefaultGroupEvt = grpEventos != null ? grpEventos.IdGrupoEvento : 0;

            novo.GrupoDefault = grpEventos != null ? grpEventos : null;


            setEnums(novo);

            setEndereco(novo);

            setDocumentos(novo);

            novo.Idade = ParseUtil.ToInt(txtIdade.Text);

            if (funcAnt != null)
            {
                //passa a PK para o funcionario
                novo.IdFuncionario = funcAnt.IdFuncionario;
            }
            //adicionando os eventos..
            foreach (var evt in eventosFuncionario)
            {
                novo.Eventos.Add(evt);
            }

            return novo;
        }
        private void setEnums(Funcionario f)
        {
            var ist = cbSituacao.SelectedIndex;
            var itr = cbTipoRecebimento.SelectedIndex;
            var ies = cbEstadoCivil.SelectedIndex;

            if (ist >= 0)
                f.Situacao = cbSituacao.GetSelectedItem<TypeSituacaoFuncionario>();

            if (itr >= 0)
                f.TipoRecebimento = cbTipoRecebimento.GetSelectedItem<TypeRecebimento>();

            if (itr >= 0)
                f.EstadoCivil = cbEstadoCivil.GetSelectedItem<TypeEstadoCivil>();

        }

        /// <summary>
        ///Obtem os dados do endereco dos campos
        /// </summary>
        private void setEndereco(Funcionario f)
        {
            var end = f.Endereco;
            var endereco = txtEndereco.Text;
            var numEnd = txtNumeroEnd.Text;
            var bairro = txtBairro.Text;
            var complemento = txtComplemento.Text;
            var cep = cepControl1.TextCep.Text;
            var cidade = lookUpMunicipio1.Municipio;
            var uf = lookUpMunicipio1.UF;
            var tipoEndereco = cbTipoLogradouros.SelectedItem != null ? cbTipoLogradouros.SelectedItem.ToString() : null;

            end.NomeEndereco = endereco;
            end.NumeroEndereco = numEnd;
            end.Bairro = bairro;
            end.Complemento = complemento;
            end.Uf = uf;
            end.Cep = cep;
            end.Cidade = cidade;
            end.TipoEndereco = tipoEndereco;
            end.Uf = uf;
        }


        /// <summary>
        /// Documentos
        /// </summary>
        /// <param name="cnh"></param>
        private void setDocumentos(Funcionario f)
        {
            var rg = f.RegistroGeral;
            var ctps = f.CTPS;
            var cnh = f.CNH;
            var titEl = f.TituloEleitor;
            var cert = f.CertificadoReservista;
            var dtInvalida = new DateTime(1, 1, 1);


            //Registro Geral
            rg.NumeroRG = txtRg.Text;
            rg.OrgaoEmissorRG = txtOrgaoEmissorRG.Text;
            rg.DataExpedicao = dtDataExpRG.DateTime;
            //valida
            rg.DataExpedicao = rg.DataExpedicao.ValidateDate();

            rg.NomeMae = txtNomeMae.Text;
            rg.NomePai = txtNomePai.Text;


            // Dados da CTPS

            ctps.NumeroCTPS = txtNumCTPS.Text;
            ctps.SerieCTPS = txtSerieCTPS.Text;
            ctps.DataEmissaoCTPS = dtEmissaoCTPS.DateTime;
            ctps.DataEmissaoCTPS = ctps.DataEmissaoCTPS.ValidateDate();

            ctps.EstadoEmissaoCTPS = cbEstadoEmissaoCTPS.SelectedItem != null
                                ? cbEstadoEmissaoCTPS.SelectedItem.ToString()
                                : "";

            ctps.NumeroPis = txtNumPis.Text;

            //CNH
            cnh.NumeroRegistroCNH = txtNumCNH.Text;
            cnh.CategoriaCNH = txtCatCNH.Text;
            cnh.ValidadeCNH = dtValidadeCNH.DateTime;
            cnh.ValidadeCNH = cnh.ValidadeCNH.ValidateDate();
            cnh.DataPrimeiraHabCNH = cnh.DataPrimeiraHabCNH.ValidateDate();


            //Titulo Eleitor
            titEl.NumeroTituloEleitor = txtTituloEleitor.Text;
            titEl.ZonaEleitoral = txtZonaEleitoral.Text;
            titEl.SecaoEleitoral = txtSecaoEleitoral.Text;
            titEl.UfEmissaoTituloEleitor = txtUfTituloEleitoral.Text;
            titEl.DataEmissaoTituloEleitor = dtTituloEleitor.DateTime;
            titEl.DataEmissaoTituloEleitor = titEl.DataEmissaoTituloEleitor.ValidateDate();

            //Cert. Reservista
            cert.NumeroCertReservista = txtNumCertReservista.Text;
            cert.CategoriaMilitar = txtCatMilitar.Text;
            cert.CircunscricaoMilitar = txtCircunscricaoMilitar.Text;
            cert.RegiaoMilitar = txtRegiaoMilitar.Text;
            cert.OrgaoEmissorCert = txtOrgaoEmissaoCert.Text;

            cert.DataEmissaoCertificado = dtEmissaoCert.DateTime;
            cert.DataEmissaoCertificado = cert.DataEmissaoCertificado.ValidateDate();

            cert.SituacaoMilitar = txtSituacaoMilitar.Text;

        }


        #endregion Area de coleta de dados

        #region Area de transferencia de dados
        /// <summary>
        /// Seta os dados do endereço nos campos
        /// </summary>
        /// <param name="f"></param>
        private Funcionario indexarFuncionario(Funcionario f)
        {
            infoPessoais(f);

            documentos(f);

            dadosAdminissionais(f);

            dadosFolha(f);

            this.lookUpMatrizFilial1.FindSetMatriz(f.Filial.Matriz.CodigoMatriz);
            this.lookUpMatrizFilial1.FindSetFilial(f.Filial.CodigoFilial);

            this.gridControlSalarial.DataSource = f.HistoricoSalarial;
            this.gridControlDepto.DataSource = f.HistoricoDepartamento;
            this.gridControlFuncao.DataSource = f.HistoricoFuncao;
            this.gridControlSituacao.DataSource = f.HistoricoSituacao;

            return f;
        }


        private void infoPessoais(Funcionario f)
        {

            txtCodigoFunc.Text = f.CodigoFuncionario;
            txtNome.Text = f.NomeFuncionario;
            txtCpf.Text = f.CPF;
            dtDataNasc.DateTime = f.DataNascimento;

            //registro geral
            txtRg.Text = f.RegistroGeral.NumeroRG;
            txtOrgaoEmissorRG.Text = f.RegistroGeral.OrgaoEmissorRG;

            if (f.RegistroGeral.DataExpedicao != null)
                dtDataExpRG.DateTime = f.RegistroGeral.DataExpedicao.Value;
            txtNomePai.Text = f.RegistroGeral.NomePai;
            txtNomeMae.Text = f.RegistroGeral.NomeMae;

            //endereco
            txtEndereco.Text = f.Endereco.NomeEndereco;
            txtNumeroEnd.Text = f.Endereco.NumeroEndereco;
            txtBairro.Text = f.Endereco.Bairro;
            txtComplemento.Text = f.Endereco.Complemento;
            cepControl1.TextCep.Text = f.Endereco.Cep;
            lookUpMunicipio1.SetMunicipioUF(f.Endereco.Cidade, f.Endereco.Uf);

            if (f.Endereco.TipoEndereco != null)
            {

                var logradouros = cbTipoLogradouros.GetItens<TipoLogradouro>();

                foreach (var item in logradouros)
                {
                    var tipo = f.Endereco.TipoEndereco;

                    if (item.Nome.Equals(tipo))
                    {

                        cbTipoLogradouros.SelectedItem = item;

                    }
                }
            }


            if (!String.IsNullOrWhiteSpace(f.Endereco.NumeroEndereco) && f.Endereco.NumeroEndereco.Equals("S/N"))
                checkSemNumero.Checked = true;
            else
                checkSemNumero.Checked = false;

        }

        private void documentos(Funcionario f)
        {
            //RG esta nos documentos pessoais

            //CNH
            {
                txtNumCNH.Text = f.CNH.NumeroRegistroCNH;
                txtCatCNH.Text = f.CNH.CategoriaCNH;

                if (f.CNH.ValidadeCNH != null)
                    dtValidadeCNH.DateTime = f.CNH.ValidadeCNH.Value;

                if (f.CNH.DataPrimeiraHabCNH != null)
                    dtPrimeiraHab.DateTime = f.CNH.DataPrimeiraHabCNH.Value;

            }
            //CTPS
            {
                txtNumCTPS.Text = f.CTPS.NumeroCTPS;
                txtSerieCTPS.Text = f.CTPS.SerieCTPS;

                if (f.CTPS.DataEmissaoCTPS != null)
                    dtEmissaoCTPS.DateTime = f.CTPS.DataEmissaoCTPS.Value;
                if (f.CTPS.EstadoEmissaoCTPS != null)
                    cbEstadoEmissaoCTPS.Properties.Items.Add(f.CTPS.EstadoEmissaoCTPS);
                cbEstadoEmissaoCTPS.SelectedIndex = 0;
                txtNumPis.Text = f.CTPS.NumeroPis;
            }//Titulo Eleitor
            {
                txtTituloEleitor.Text = f.TituloEleitor.NumeroTituloEleitor;
                txtZonaEleitoral.Text = f.TituloEleitor.ZonaEleitoral;
                txtSecaoEleitoral.Text = f.TituloEleitor.SecaoEleitoral;
                txtUfTituloEleitoral.Text = f.TituloEleitor.UfEmissaoTituloEleitor;

                if (f.TituloEleitor.DataEmissaoTituloEleitor != null)
                    dtTituloEleitor.DateTime = f.TituloEleitor.DataEmissaoTituloEleitor.Value;
            }

            //Cert. Reservista
            {
                txtNumCertReservista.Text = f.CertificadoReservista.NumeroCertReservista;
                txtCatMilitar.Text = f.CertificadoReservista.CategoriaMilitar;
                txtCircunscricaoMilitar.Text = f.CertificadoReservista.CircunscricaoMilitar;
                txtRegiaoMilitar.Text = f.CertificadoReservista.RegiaoMilitar;
                txtOrgaoEmissaoCert.Text = f.CertificadoReservista.OrgaoEmissorCert;

                if (f.CertificadoReservista.DataEmissaoCertificado != null)
                    dtEmissaoCert.DateTime = f.CertificadoReservista.DataEmissaoCertificado.Value;

                txtSituacaoMilitar.Text = f.CertificadoReservista.SituacaoMilitar;
            }

        }

        private void dadosAdminissionais(Funcionario f)
        {

            //Nao sera editaveis a partir daqui
            dtDataAdmissao.DateTime = f.DataAdmissao;
            cbTipoRecebimento.SelectedIndex = (int)f.TipoRecebimento;
            cbDepartamento.SetSelectItem<Departamento>(f.Departamento);
            cbFuncao.SetSelectItem<Funcao>(f.Funcao);
            cbSituacao.SetSelectItem<TypeSituacaoFuncionario>(f.Situacao);
            cbEstadoCivil.SetSelectItem<TypeEstadoCivil>(f.EstadoCivil);

            txtSalario.Text = f.Salario.ToString();
            pictureEditFoto.Image = ImageUtilIts.GetImageFromBytes(f.Foto);
            txtEmail.Text = f.Email;
            txtCelular.Text = f.Celular;
            txtTelFixo.Text = f.TelefoneFixo;

        }
        private void dadosFolha(Funcionario f)
        {
            if (f.GrupoDefault != null)
                cbGrpEventoFunc.SetSelectItem<GrupoEvento>(f.GrupoDefault);

            setDataGridEventos();
        }

        #endregion Area de transferencia de dados

        #region Eventos

        private void barBtnSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //cancelada o evento
            if (!this.barBtnSalvar.Enabled) return;

            var novo = indexarFuncionario();

            if (ValidadorDTO.ValidateWarningAll(novo))
            {
                var manager = new FuncionarioDaoManager();

                //verifica se o CPF existe
                if (manager.FindByCpf(novo))
                {
                    XMessageIts.Mensagem("CPF " + novo.CPF + " já existe !");
                }
                else
                {
                    if (funcAnt == null)
                    {
                        if (manager.SaveFuncionario(novo))
                        {
                            XMessageIts.Mensagem("Funcionário salvo com sucesso!");
                            this.funcAnt = novo;
                            this.Dispose();
                        }
                    }
                    else
                    {
                        if (manager.UpdateFuncionario(novo))
                        {
                            this.funcAnt.Update(novo);//manda a atualizacao pro objeto do grid
                            XMessageIts.Mensagem("Funcionário atualizado com sucesso!");
                        }
                    }
                }

            }
        }

        private void barBtnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void checkSemNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNumeroEnd.Text))
                txtNumeroEnd.Text = "S/N";
            else
                txtNumeroEnd.Text = "";
            //sete o estado contrario
            checkSemNumero.Checked = !checkSemNumero.Checked;
        }

        private void pictureEditFoto_DoubleClick(object sender, EventArgs e)
        {
            btnSelecionarFoto_Click(null, null);
        }

        private void btnSelecionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = ImageUtilIts.ImageFilter;
            if (open.ShowDialog() == DialogResult.OK)
            {
                var file = open.FileName;

                this.pictureEditFoto.Image = ImageUtilIts.GetImageFromFile(file);

                this.lblFoto.Text = "Resolução: " + this.pictureEditFoto.Image.Width + " x "
                                    + this.pictureEditFoto.Image.Height;
            }
        }

        private void XFrmAddFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (string.IsNullOrEmpty(this.txtNome.Text))
                    this.Dispose();
                else
                {
                    var op = XMessageIts.Confirmacao("Abandonar admissão de funcionário ?");

                    if (op == DialogResult.Yes)
                        this.Dispose();
                }
            }
        }

        private void btnAddEvento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var paramsFind = new ParamsFindEntity()
                {
                    Context = ctx,
                    Title = "Localizar evento:",
                    Columns = new string[] { "CodigoEvento", "DescricaoEvento", "TipoEvento", "CodigoCalculo" },
                    Order = "CodigoEvento",
                    DynamicObject = null
                };

                var selected = XFrmFindEntity.ShowDialogFindEntity<Evento>(paramsFind);

                if (selected != null)
                {
                    //recuperando os valores do objeto dinamico
                    //pego o tipo, dps a propriedade que quero, em seguida o valor
                    var codEvento = selected.GetType().GetProperty("CodigoEvento").GetValue(selected, null);
                    var nome = selected.GetType().GetProperty("DescricaoEvento").GetValue(selected, null);

                    selected = ctx.EventoDao.Where(ev => ev.CodigoEvento == codEvento).FirstOrDefault() as Evento;

                    if (selected != null)
                    {
                        //procura o evento selecionado na lista dos eventos do funcionario, se nao encontrar nada, adicione
                        if (this.eventosFuncionario.Where(fe => fe.IdEvento == selected.IdEvento).Count() == 0)
                        {
                            //se esta editando ja existe o funcionario
                            if (funcAnt != null)
                                this.eventosFuncionario.Add(new EventoFuncionario(funcAnt, selected));
                            else //senao so add o evento no func. que esta sendo criado
                                this.eventosFuncionario.Add(new EventoFuncionario(selected));
                        }
                        else
                            //senao o evento ja existe para o funcionario, então ignore.
                            XMessageIts.Advertencia("Evento já existente para o funcionário.");
                    }
                    //atualize o grid.
                    setDataGridEventos();
                }
            }
        }

        private void btnRemoveEvento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = gridViewEvtFunc.GetFocusedRow<EventoFuncionario>();
            try
            {
                //procura o evento removido na lista do funcionario e marca como removido
                var evtF = funcAnt.Eventos.Where(ev => ev.IdEvento == selected.IdEvento).First();
                //marca como removido.
                evtF.Removed = true;

                //remova da lista;
                eventosFuncionario.Where(ev => ev.IdEvento == selected.IdEvento).First().Removed = true;
            }
            catch (Exception)
            {
                //fodase
            }
            finally
            {
                setDataGridEventos();
            }
        }
        #endregion Eventos



    }
}
