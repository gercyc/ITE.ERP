/**
 * Copyright (MaterialSerra) 2013, IT Solution Business Intelligence. Todos os direitos reservados. ITE
 * SOFTWARE/CONFIDENCIAL. O Uso está sujeito aos termos.
 * 
 * 
 * 
 * 
 */

using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ITE.Entidades.DaoManager.SlateManager;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Ardosia.Minning;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITSolution.Framework.Forms;

namespace ITE.Slate.Forms.ControleCarga.View
{
    public partial class XFrmOrdemCarga : DevExpress.XtraEditors.XtraForm
    {
        private readonly XFrmItensCarga _xFrmItensCarga;
        private Usuario _user;
        private string _observacao;
        private CliFor _cliFor;
        private Motorista _motorista;
        //Objeto utilizado em caso de alteração da ordem de carga
        private OrdemCarga _ordemAnt;

        private static string PATH_LOGO_VENDA = Path.Combine(Application.StartupPath, "logo_venda");
        public bool isUpdateOrdemCarga;

        #region Construtores

        private XFrmOrdemCarga()
        {
            InitializeComponent();
            this._xFrmItensCarga = new XFrmItensCarga(this);
            //this.ActiveControl = this.txtCodigoBarrasMaterialSerra;
            this.lblMotorista.Text = " - ";
            this.listBoxControl1.Items.Clear();
            new TextEditUtil(txtDesconto).CustomizeNumberField();
            //teclas especiais nessa tela que nao deve sem inseridas

            if (File.Exists(PATH_LOGO_VENDA))
            {
                if (File.Exists(PATH_LOGO_VENDA + ".new"))
                    //cancela o evento
                    this.pictureLogo.Image = Image.FromFile(PATH_LOGO_VENDA + ".new");
                else
                    this.pictureLogo.Image = Image.FromFile(PATH_LOGO_VENDA);

            }
            this.openFileLogo.Filter = ImageUtilIts.ImageFilter;
            lookUpMaterialSerra1.RedirectFocusTo(txtQuantidadePeca);
            this.dtDataCarregamento.DateTime = DateTime.Now;
        }

        public XFrmOrdemCarga(Usuario user)
            : this()
        {
            if (user == null)
            {
                XMessageIts.Erro("Vendedor não informado.");
                this.Dispose();
            }
            else
            {
                this._user = user;
                this.lblVendedor.Text = "Operador : " + user.NomeUsuario;

            }
        }

        public XFrmOrdemCarga(OrdemCarga cotacao, Usuario user)
            : this(user)
        {
            this._ordemAnt = indexarOrdem(cotacao);
        }

        #endregion Construtores

        #region Controle Ordem Carga

        private void btnAddMaterial()
        {
            int qtde = ParseUtil.ToInt(txtQuantidadePeca.Text);
            var material = lookUpMaterialSerra1.Produto;
            if (qtde > 0)
            {
                if (material == null)
                {
                    XMessageIts.Mensagem("Informe o material !");
                }
                else
                {
                    var item = this._xFrmItensCarga.AddItem(material, qtde);
                    if (item != null)
                    {
                        //add os itens na lista visivel da tela de proposta
                        this.listBoxControl1.Items.Add(item);

                        //atualiza o label com o total da proposta
                        atualizarTotalVenda();

                        lookUpMaterialSerra1.Focus();
                        lookUpMaterialSerra1.RequestFocus();
                    }
                }
            }
            else
                XMessageIts.Advertencia("Quantidade de peças deve ser maior que 0.");
        }

        /// <summary>
        /// Cria a proposta
        /// </summary>
        /// <returns></returns>
        private OrdemCarga indexarOrdem()
        {
            var itens = _xFrmItensCarga.GetItensCarga();
            OrdemCarga ordem = new OrdemCarga(_user, _cliFor, _motorista, itens)
            {
                Observacao = this._observacao,
                DataCarregamento = dtDataCarregamento.DateTime,
                Desconto = ParseUtil.ToDecimal(txtDesconto.Text),
            };

            ordem.CalculaDesconto(ordem.Desconto);


            //se existe um proposta anterior
            if (_ordemAnt != null)
            {

                //passe a Pk para proposta 
                ordem.IdOrdemCarga = _ordemAnt.IdOrdemCarga;

            }

            return ordem;
        }

        /// <summary>
        /// Altera a cotação
        /// O usuário que fez a ordem pela primeira vez nao será alterado
        /// O mérito é de quem registrou a ordem
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private OrdemCarga indexarOrdem(OrdemCarga v)
        {
            if (v != null)
            {
                this._cliFor = v.Cliente;
                this._motorista = v.Motorista;
                this.dtDataCarregamento.DateTime = v.DataCarregamento;
                this._user = v.Usuario;
                lblCliente.Text = v.Cliente.RazaoSocial;

                var itens = v.ItensOrdemCarga;
                //passa os itens para tela de itens
                _xFrmItensCarga.AddListaItem(itens);

                //coloque no painel lateral tbm
                if (itens != null)
                {
                    this.listBoxControl1.Items.AddRange(itens.ToArray());
                    this.listBoxControl1.Refresh();

                    this.lblMetrosQuadrados.Text = itens.Sum(m => m.MetrosQuadrado).ToString("N2");
                }


                lblItens.Text = v.NumeroItens.ToString();
                lblItens.Refresh();

                lblTotalCarga.Text = v.TotalCarga.ToString("N2");
                lblTotalCarga.Refresh();


            }

            return v;
        }

        /// <summary>
        /// Valida o cliente e os itens = Pre requisitos do fechamento da proposta
        /// </summary>
        /// <returns></returns>true ok caso contrário false
        private bool isProposta()
        {

            if (dtDataCarregamento.DateTime.ValidateDate() == null)
            {
                XMessageIts.Advertencia("Informe a data do carregamento.");
            }
            else
            {
                var itens = _xFrmItensCarga.GetItensCarga();

                if (itens.Count <= 0)
                {
                    XMessageIts.Advertencia("Nenhum item foi adicionado.");
                    lookUpMaterialSerra1.RequestFocus();
                }
                else
                    return true;
            }
            return false;
        }

        private void fecharProposta()
        {
            var carga = indexarOrdem();

            string msg = "Deseja continuar e gerar a ordem de carga ?";
            if (_ordemAnt != null)
                msg = "Confirmar a alteração da ordem de carga ?";

            DialogResult op = XMessageIts.Confirmacao(msg);

            if (op == DialogResult.Yes)
            {
                if (new OrdemCargaDaoManager().EncerrarCarregamento(carga))
                {
                    if (_ordemAnt == null)
                    {
                        op = XMessageIts.Confirmacao("Ordem de carga gerado com sucesso !\n\n" +
                                                     "Nº Ordem Carga: " + carga.IdOrdemCarga + "\n\n" +
                                                     "Continuar lançamentos ?");
                        this.Dispose();

                        if (op == DialogResult.Yes)
                        {
                            new XFrmOrdemCarga(_user).ShowDialog();
                        }
                    }
                    else
                    {
                        XMessageIts.Mensagem("Ordem de carga Nº Ordem Carga: \"" + carga.IdOrdemCarga + "\"" +
                                                     " foi alterada ");
                        this.isUpdateOrdemCarga = true;
                        this.Dispose();
                    }

                }
            }
        }

        internal void atualizarTotalVenda(bool updateItens = false)
        {
            var itens = this._xFrmItensCarga.GetItensCarga();
            this.lblItens.Text = itens.Count.ToString();
            this.lblItens.Refresh();

            this.lblTotalCarga.Text = "R$ " + _xFrmItensCarga.CalculaTotalProposta().ToString("N2");
            this.lblMetrosQuadrados.Text = _xFrmItensCarga.MetrosQuadrados.ToString("N2");
            this.lblTotalCarga.Refresh();

            //atualize o listbox
            //insere no listbox
            if (updateItens)
            {
                this.listBoxControl1.Items.Clear();
                foreach (var item in itens)
                {
                    this.listBoxControl1.Items.Add(item);
                }

            }

            this.listBoxControl1.Refresh();
            //listBoxControl1.SelectedIndex = 0;

        }


        /// <summary>
        /// Verifica se quantidade do MaterialSerra informada é válida
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        internal bool IsQuantidade(ItemOrdemCarga item)
        {
            if (item.QuantidadePeca <= 0 && item.IdMaterial != 999)//999 => LAJINHA
            {
                XMessageIts.Advertencia("Quantidade de peças informada é inválida", "Atenção");

                return false;
            }
            return true;
        }

 
        #endregion Controle OrdemCarga

        #region Eventos


        /// <summary>
        /// Controle de atalhos das teclas pressionadas na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XFrmVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
                lookUpMaterialSerra1.RequestFocus();

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.L)
                lookUpMaterialSerra1.ShowFindMaterial();

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Delete)
            {
                this.listBoxControl1.Items.Clear();
                this.listBoxControl1.Refresh();
                this.lookUpMaterialSerra1.Clear();
                this._xFrmItensCarga.GetItensCarga().Clear();
                atualizarTotalVenda();
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.H)
            {
                navBarItemAjuda_LinkClicked(null, null);
            }
            else if (e.KeyCode == Keys.O)
            {
                navBarItemObervacao_LinkClicked(null, null);
            }

            else if (e.KeyCode == Keys.V)
            {
                navBarItemAlterarCarga_LinkClicked(null, null);
            }
            else if (e.KeyCode == Keys.F2)
            {
                navBarItemSelecionarCliente_LinkClicked(null, null);
            }
            else if (e.KeyCode == Keys.F3)
            {
                navBarItemSelectMotorista_LinkClicked(null, null);
            }
            else if (e.KeyCode == Keys.F4)
            {
                dtDataCarregamento.ShowPopup();
                dtDataCarregamento.Focus();
            }
            else if (e.KeyCode == Keys.F11)
            {
                navBarItemEncerrarCarregamento_LinkClicked(null, null);
            }

            else if (e.KeyCode == Keys.W && e.Modifiers == Keys.Control)
            {
                var op = XMessageIts.Confirmacao("Abandonar ordem de carga ?", "Atenção");

                if (op == DialogResult.Yes)
                    this.Dispose();
            }
        }

        private void panelCarga_MouseClick(object sender, MouseEventArgs e)
        {
            navBarItemAlterarCarga_LinkClicked(null, null);
        }

        private void navBarItemEncerrarCarregamento_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (isProposta())
            {
                //se nao vai usar o cliente atual
                if (this._cliFor == null)
                {
                    XMessageIts.Advertencia("Informe o cliente !");
                }
                else if (this._motorista == null)
                {
                    XMessageIts.Advertencia("Informe o motorista !");
                }
                else
                {
                    fecharProposta();
                }
            }
        }

        private void navBarItemSelectMotorista_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                using (var ctx = new SlateContext())
                {
                    ctx.LazyLoading(false);

                    var x = XFrmFindEntity.ShowDialogFindEntity<Motorista>(new ParamsFindEntity()
                    {
                        Context = ctx,
                        Columns = new string[] { "IdMotorista", "NomeMotorista" },
                        DynamicObject = _motorista,
                        Title = "Localizar Motorista"
                    });

                    //var x = XFrmFindEntity.ShowDiaglogFindEntity<Motorista>(ctx,
                    //    new string[] { "IdMotorista", "NomeMotorista" }, _motorista,
                    //    "Selecionar Motorista");

                    if (x != null)
                    {
                        //recupera o cliente
                        this._motorista = ctx.MotoristaDao.Find(x.IdMotorista);

                        this.lblMotorista.Text = this._motorista.NomeMotorista;
                    }
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
        }

        private void navBarItemSelecionarCliente_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                using (var ctx = new SlateContext())
                {
                    ctx.LazyLoading(false);
                    //carrega o layout dentro do projeto
                    var layoutStream = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
                        "ITE.Slate.GridLayout.cliente_basico.xml");

                    var x = XFrmFindEntity.ShowDialogFindEntity<CliFor>(new ParamsFindEntity()
                    {
                        Context = ctx,
                        Columns = new string[] { "IdCliFor", "RazaoSocial", "TipoCliente", "CpfCnpj" },
                        DynamicObject = _cliFor,
                        Title = "Selecionar Comprador",
                        Layout = layoutStream
                    });

                    //var x = XFrmFindEntity.ShowDiaglogFindEntity<CliFor>(ctx,
                    //         new string[] { "IdCliFor", "RazaoSocial", "TipoCliente", "CpfCnpj" }, _cliFor, layoutStream,
                    //         "Selecionar Comprador");

                    if (x != null)
                    {
                        //recupera o cliente
                        this._cliFor = ctx.ClienteDao.Find(x.IdCliFor);
                        this.lblCliente.Text = this._cliFor.RazaoSocial;
                    }
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
        }

        private void navBarItemAlterarCarga_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this._xFrmItensCarga.Run();
        }

        private void navBarItemAjuda_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var OBS = "O: Adiciona Observação.\n\n";
            var V = "V: Ver itens da carga.\n\n";
            var F4 = "F4: Alterar Data Carregamento.\n\n";
            var F11 = "F11: Encerrar Carregamento.\n\n";
            var Sair = "Ctrl + W: Abandonar ordem.\n\n";

            //criando mensagem de alerta
            var sb = new StringBuilder();

            sb.Append(OBS);
            sb.Append(V);
            sb.Append(F4);
            sb.Append(F11);
            sb.Append(Sair);

            XMessageIts.Mensagem(sb);
        }

        private void navBarItemObervacao_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this._observacao = XFrmOptionPane.ShowInputDialog("Observação:", "Observação", this._observacao);
        }

        private void pictureLogo_DoubleClick(object sender, EventArgs e)
        {
            var op = openFileLogo.ShowDialog();
            if (op == DialogResult.OK)
            {
                pictureLogo.Image = Image.FromFile(openFileLogo.FileName);

                //var dir = Path.Combine(Path.GetDirectoryName(PATH_LOGO_VENDA), "logo_venda"));
                if (File.Exists(PATH_LOGO_VENDA))
                    //salva
                    FileManagerIts.CopyFile(openFileLogo.FileName, PATH_LOGO_VENDA + ".new");
                else
                    pictureLogo.Image.Save(PATH_LOGO_VENDA);

            }

        }

        private void txtQuantidadePeca_KeyDown(object sender, KeyEventArgs e)
        {
            string qtde = txtQuantidadePeca.Text;
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(qtde))
            {
                this.btnAddMaterial();
            }
        }

        private void XFrmOrdemCarga_Shown(object sender, EventArgs e)
        {
            this.lookUpMaterialSerra1.RequestFocus();
        }

        private void txtQuantidadePeca_Enter(object sender, EventArgs e)
        {
            txtQuantidadePeca.SelectAll();
        }
        #endregion Eventos

        private void txtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
                txtDesconto.Focus();
        }

        private void navBarItemDesconto_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            txtDesconto.Focus();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            var os = indexarOrdem();

            lblTotalCarga.Text = os.TotalLiquidoCarga.ToString("N2");
        }
    }
}