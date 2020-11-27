/**
 * Copyright (produto) 2013, IT Solution Business Intelligence. Todos os direitos reservados. ITE
 * SOFTWARE/CONFIDENCIAL. O Uso está sujeito aos termos.
 * 
 * 
 * 
 * 
 */
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.DaoManager;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITE.Vendas.Forms.Administrativo;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Arquivos;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using System;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.POCO.Fiscal;

namespace ITE.Vendas.Forms.ControleVenda
{
    public partial class XFrmVenda : DevExpress.XtraEditors.XtraForm
    {
        private XFrmFindProduto _xFrmFindProduto;
        private XFrmItensProposta xFrmItensVenda;
        private Usuario user;
        private string Observacao;
        //Objeto utilizado em caso de alteração=> cotação
        private Venda propostaAnt;
        private string codBarraProdutoAnt;
        private CentroCusto centro;
        private LocalEstoque localEstoque;
        private CliFor cliFor;
        private Venda vendaComplementar;

        private static string PATH_LOGO_VENDA = Path.Combine(Application.StartupPath, "logo_venda");

        #region Construtores

        private XFrmVenda()
        {
            InitializeComponent();
            this.xFrmItensVenda = new XFrmItensProposta(this);
            this._xFrmFindProduto = new XFrmFindProduto(this);
            this.ActiveControl = this.txtCodigoBarrasProduto;
            this.txtCodigoBarrasProduto.Focus();
            this.lblDescricaoProduto.Text = " - ";
            this.codBarraProdutoAnt = this.txtCodigoBarrasProduto.Text;
            this.listBoxControlProdutos.Items.Clear();
            //teclas especiais nessa tela que nao deve sem inseridas
            this.txtCodigoBarrasProduto.CaracteresRestritos = new char[] { 'c', 'C', 'o', 'O', 'v', 'V' };
            this.lblCliente.Text = "CONSUMIDOR";
            this.centro = ParametroDaoManager.GetCentroCustoVenda();
            //local de estoque
            this.localEstoque = new BalcaoContext().LocalEstoqueDao.Where(l => l.IdFilial == UnitWork.Filial.IdFilial).FirstOrDefault();
            this.vendaComplementar = new Venda();

            if (File.Exists(PATH_LOGO_VENDA))
            {
                if (File.Exists(PATH_LOGO_VENDA + ".new"))
                    //cancela o evento
                    this.pictureLogo.Image = Image.FromFile(PATH_LOGO_VENDA + ".new");
                else
                    this.pictureLogo.Image = Image.FromFile(PATH_LOGO_VENDA);

            }
            this.openFileLogo.Filter = ImageUtilIts.ImageFilter;
        }

        public XFrmVenda(Usuario user)
            : this()
        {
            if (user == null)
            {
                XMessageIts.Erro("Vendedor não informado.");
                this.Dispose();
            }
            else
            {
                this.user = user;
                this.lblVendedor.Text = "Operador : " + user.NomeUsuario;

            }
        }

        public XFrmVenda(Venda cotacao, Usuario user)
            : this(user)
        {
            this.propostaAnt = indexarCotacao(cotacao);
        }

        #endregion Construtores

        #region Controle Venda

        internal bool AddProduto(Produto p, decimal qtde)
        {

            if (p.TipoItemProduto == TypeItemProduto.Servico)
            {
                p.QuantidadeProduto = 1;
                qtde = 1;
            }

            //se quantidade disponivel em estoque
            if (IsQuantidade(p, qtde))
            {
                lblDescricaoProduto.ForeColor = Color.SteelBlue;

                //atualiza a quantidade com o valor informado
                p.QuantidadeProduto = qtde;

                //verifica se o produto e avisa se produto ficara defasado apos a proposta
                //vou tirar esse aviso
                //preciso de um rotina para gerar o produto defasado apos a proposta o mesmo
                checkProdutoSemEstoque(p);

                //add o produto na pilha
                //insere sempre no topo

                var ok = xFrmItensVenda.AddItem(p);
                //se foi add na lista
                if (ok)
                {

                    lblDescricaoProduto.Text = p.DescricaoProduto + "\t" +
                         qtde + " x " + p.PrecoVenda + " = " + p.CalculaTotalProduto(p.PrecoVenda, qtde).ToString("N2");

                    //atualiza o label com o total da proposta
                    atualizarTotalVenda();

                    //add os itens na lista visivel da tela de proposta
                    this.listBoxControlProdutos.Items.Add(p);

                }
                return ok;
            }
            return false;
        }

        private void findAddProduto(string txtCodBar)
        {
            var ctx = new BalcaoContext().ProdutoDao;
            var split = txtCodBar.Split('*');
            Decimal qtde = 0;
            Produto p = null;

            if (txtCodBar.Contains("*") && split.Length > 1)
            {
                p = new ProdutoDaoManager().GetProdutoByCodigoBarras(split[1]);
                qtde = ParseUtil.ToDecimal(split[0]);
            }
            else if (split.Length > 0)
            {
                p = new ProdutoDaoManager().GetProdutoByCodigoBarras(split[0]);
                //minimo
                qtde = 1;
            }

            if (p == null)
            {
                lblDescricaoProduto.ForeColor = Color.Red;
                lblDescricaoProduto.Text = "Nenhum produto encontrado";
            }
            else
            {
                AddProduto(p, qtde);
            }

            //deixe o foco no codigo de barras
            this.txtCodigoBarrasProduto.Focus();
            //selecione todo o codigo ja presente no componente
            this.txtCodigoBarrasProduto.SelectAll();
            //foco no top
            this.listBoxControlProdutos.SelectedIndex = 0;

        }

        /// <summary>
        /// Cria a proposta
        /// </summary>
        /// <returns></returns>
        private Venda indexarVenda(TypeVenda tipo, CliFor cliFor)
        {
            var itens = xFrmItensVenda.GetItensProposta();
            Venda venda = new Venda(user, cliFor, itens);
            venda.TipoMovimento = tipo;
            venda.Observacao = this.Observacao;
            venda.StatusVenda = TypeStatusVenda.Aberto;
            //centro de custo existente ou setado
            venda.IdCentroCusto = centro.IdCentroCusto;

            //local de estoque, se setou..s
            venda.LocalEstoque = localEstoque;

            //se existe um proposta anterior
            if (propostaAnt != null)
            {
                venda.Desconto = propostaAnt.Desconto;
                venda.FormaPagamentoVenda = propostaAnt.FormaPagamentoVenda;
                //passe a Pk para proposta 
                venda.IdVenda = propostaAnt.IdVenda;
                this.cliFor = propostaAnt.CliFor;
            }

            if (tipo == TypeVenda.VendaPrazo)
                venda.TipoMovimento = TypeVenda.Venda;

            venda.IdFilial = UnitWork.Filial.IdFilial;

            //forma de pagamento default é => á vista
            venda.IdFormaPagamentoVenda = 1;

            //ver demais campos dps
            venda.DataVenda = vendaComplementar.DataVenda;

            return venda;
        }

        /// <summary>
        /// Altera a cotação
        /// O usuário que fez a venda pela primeira vez nao será alterado
        /// O mérito é de quem registrou a venda
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private Venda indexarCotacao(Venda v)
        {
            if (v != null)
            {
                this.cliFor = v.CliFor;
                lblCliente.Text = v.CliFor.RazaoSocial;

                foreach (var item in v.ItensVendas)
                    item.Produto.QuantidadeProduto = item.Quantidade;

                xFrmItensVenda.AddListaItem(v.ItensVendas);

                this.listBoxControlProdutos.DataSource = v.ItensVendas;
                this.listBoxControlProdutos.Refresh();

                lblItens.Text = v.NumeroItens.ToString();
                lblItens.Refresh();

                lblTotalVenda.Text = v.TotalVenda.ToString("N2");
                lblTotalVenda.Refresh();

                this.vendaComplementar.DataVenda = v.DataVenda;
            }

            return v;
        }

        /// <summary>
        /// Valida o cliente e os itens = Pre requisitos do fechamento da proposta
        /// </summary>
        /// <returns></returns>true ok caso contrário false
        private bool isProposta()
        {
            var itens = xFrmItensVenda.GetItensProposta();

            if (itens.Count <= 0)
            {
                XMessageIts.Advertencia("Nenhum item foi adicionado.");
                txtCodigoBarrasProduto.Focus();
            }
            else
                return true;
            return false;
        }

        private void fecharProposta(TypeVenda tipo)
        {
            //Venda/Cotacao a prazo ou se ta setado a vista
            if (this.cliFor == null || this.cliFor.RazaoSocial == "CONSUMIDOR")
                navBarItemSelecionarCliente_LinkClicked(null, null);

            if (cliFor == null)
            {
                XMessageIts.Mensagem("Cliente não foi informado");
            }
            else if (this.cliFor.RazaoSocial == "CONSUMIDOR" && tipo == TypeVenda.VendaPrazo
                || this.cliFor.RazaoSocial == "CONSUMIDOR" && tipo == TypeVenda.Cotacao)
            {
                XMessageIts.Mensagem("Cliente \"CONSUMIDOR\" nao permitido para cotação ou venda á prazo !");
                this.cliFor = null;
            }
            else
            {
                //fechamento da proposta a prazo                
                if (isProposta())
                {
                    Venda venda = indexarVenda(tipo, cliFor);

                    if (venda != null)
                    {
                        //oculta o form da venda
                        this.Hide();

                        //chame o forma para seleciona a forma de pagamento
                        //a forma de pagamento ira chamar o fechamento
                        new XFrmFormaPagto(this, venda).ShowDialog();
                    }
                }
            }
        }

        internal void atualizarTotalVenda()
        {
            var itens = this.xFrmItensVenda.GetItensProposta();
            this.lblItens.Text = itens.Count.ToString();
            this.lblItens.Refresh();

            this.lblTotalVenda.Text = "R$ " + xFrmItensVenda.CalculaTotalProposta().ToString("N2");
            this.lblTotalVenda.Refresh();

            var item = listBoxControlProdutos.SelectedItem;
            if (item != null)
                this.lblDescricaoProduto.Text = item.ToString();

            if (itens.Count == 0)
                this.lblDescricaoProduto.Text = "";
            
            //copia a lista pra pilha
            //inverte a lista copiada
            //insere no listbox
            this.listBoxControlProdutos.DataSource = itens.Reverse<ItemVenda>();

            this.listBoxControlProdutos.Refresh();

            listBoxControlProdutos.SelectedIndex = 0;

        }

        /// <summary>
        /// Gera um alerta quando o usuário esta vendendo o produto e o estoque está menor ou a 1 após a proposta realizada
        /// </summary>
        internal void checkProdutoSemEstoque(Produto pro)
        {
            var ctx = new BalcaoContext().ProdutoDao;
            var proAtual = ctx.Find(pro.IdProduto);
            var qtdeRestante = proAtual.QuantidadeProduto - pro.QuantidadeProduto;

            if (qtdeRestante <= 1M && pro.TipoItemProduto != TypeItemProduto.Servico)
            {
                lblDescricaoProduto.ForeColor = Color.Red;
                lblDescricaoProduto.Text = proAtual.DescricaoProduto + " - Sem Estoque";

            }
            else
            {
                //pinta o label de verde //significa produto add com sucesso
                lblDescricaoProduto.ForeColor = Color.Green;
            }
        }

        /// <summary>
        /// Verifica se quantidade do produto informada é válida
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        internal bool IsQuantidade(Produto pro, decimal quantidade)
        {
            if (pro == null) return false;

            using (var ctx = new BalcaoContext().ProdutoDao)
            {
                var proAtual = ctx.Find(pro.IdProduto);
                var qtdeRestante = proAtual.QuantidadeProduto - quantidade;

                if (proAtual.TipoItemProduto == TypeItemProduto.Servico)
                    return true;

                ///produto informado
                if (pro.QuantidadeProduto <= 0)
                {
                    var msg = "Produto : " + pro.DescricaoProduto + " com quantidade 0";

                    XMessageIts.Advertencia(msg, "Quantidade inválida");

                }//se a quantidade vendida for maior que a quantidade em estoque, somente produto, servico nao faz essa validacao
                else if (qtdeRestante < 0 && pro.TipoItemProduto == TypeItemProduto.Produto)
                    XMessageIts.Advertencia("Quantidade: \"" + quantidade + "\" não disponível em estoque.\n\n"
                              + "Estoque disponivél: " + proAtual.QuantidadeProduto, "Atenção ao estoque!!!");
                else
                    return true;
                //padrao eh false
                return false;
            }
        }

        private MethodInvoker addCliFor()
        {
            //executa essa acao la no metodo 
            var actionAddCli = new MethodInvoker(delegate
            {
                var frm = new XFrmCliForView(TypeClassificaoCliente.Cliente);

                frm.ShowDialog();

                this.cliFor = frm.ClienteAdd;

            });
            return actionAddCli;
        }


        #endregion Controle Venda

        #region Eventos

        private void listBoxControlProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBoxControlProdutos.SelectedItem;
            if (item != null)
                this.lblDescricaoProduto.Text = item.ToString();
        }

        /// <summary>
        /// Controle de atalhos das teclas pressionadas na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XFrmVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                navBarItemConsultarProduto_LinkClicked(null, null);
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
                navBarItemAlterarCarrinho_LinkClicked(null, null);
            }
            else if (e.KeyCode == Keys.F2)
            {
                navBarItemSelecionarCliente_LinkClicked(null, null);
            }
            else if (e.KeyCode == Keys.F3)
            {
                navBarItemAlterarCentroCusto_LinkClicked(null, null);
            }

            else if (e.KeyCode == Keys.F4)
            {
                navBarDadoCpl_LinkClicked(null, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                navBarItemCotacao_LinkClicked(null, null);
            }

            else if (e.KeyCode == Keys.F9)
            {
                navBarItemAprazo_LinkClicked(null, null);
            }

            else if (e.KeyCode == Keys.F11)
            {
                navBarItemAvista_LinkClicked(null, null);
            }

            else if (e.KeyCode == Keys.W && e.Modifiers == Keys.Control)
            {
                var op = XMessageIts.Confirmacao("Deseja realmente abandonar a venda/cotação ?", "Atenção - Todas as informações não salvas serão perdida !");

                if (op == DialogResult.Yes)
                    this.Dispose();
            }
        }

        private void panelCarrinho_MouseClick(object sender, MouseEventArgs e)
        {
            navBarItemAlterarCarrinho_LinkClicked(null, null);
        }

        internal void txtCodigoBarrasProduto_KeyUp(object sender, KeyEventArgs e)
        {
            //ação de ver o produto através do código de barras
            //feito de cabeça nao confie nisso
            //testar usando um leitor real
            var txtCodBar = this.txtCodigoBarrasProduto.Text;

            if (e.KeyCode == Keys.Enter && !txtCodBar.Equals(codBarraProdutoAnt))
            {
                this.codBarraProdutoAnt = txtCodigoBarrasProduto.Text;
                findAddProduto(txtCodBar);
            }
            else
                this.codBarraProdutoAnt = "";

        }

        private void txtCodigoBarrasProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nao remova esse evento
            //Precisa desse evento mesmo estando comentado
            //Nao me pergunte pq mas assim esta funcionando entao eu vou deixar => azar
        }

        private void navBarItemAvista_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (isProposta())
            {
                //se nao vai usar o cliente atual
                if (this.cliFor == null)
                {
                    //cliente default
                    this.cliFor = new ClienteDaoManager().GetClienteByNome("CONSUMIDOR");
                }

                if (this.cliFor != null)
                {
                    //cria uma venda                    
                    var venda = indexarVenda(TypeVenda.Venda, cliFor);

                    //venda a vista a data de vencimento eh a data da venda
                    venda.DataVencimento = vendaComplementar.DataVenda;

                    //cria a parcela da venda a vista
                    venda.Parcelas.Add(new LancamentoFinanceiro(venda));

                    this.Hide();

                    new XFrmFechamento(venda, this).ShowDialog();

                }
                else
                {
                    XMessageIts.Advertencia("Cliente \"Consumidor\" não existe!");
                }

            }
        }

        private void navBarItemAprazo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fecharProposta(TypeVenda.VendaPrazo);
        }

        private void navBarItemCotacao_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fecharProposta(TypeVenda.Cotacao);
        }

        private void navBarItemConsultarProduto_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this._xFrmFindProduto.Run();
        }

        private void navBarItemSelecionarCliente_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                using (var ctx = new BalcaoContext(false))
                {
                    //carrega o layout dentro do projeto
                    var layoutStream = GridViewUtil.GetLayoutStreamFromResource(Assembly.GetExecutingAssembly(),
                    "ITE.Vendas.GridLayout.cliente_basico.xml");



                    var x = XFrmFindEntity.ShowDiaglogFindEntity<CliFor>(ctx,
                        new string[] { "IdCliFor", "RazaoSocial", "TipoCliente", "CpfCnpj" }, cliFor, layoutStream,
                        "Selecionar Cliente", addCliFor());

                    if (x != null)
                    {
                        //recupera o cliente
                        this.cliFor = ctx.CliForDao.Find(x.IdCliFor);

                        this.lblCliente.Text = this.cliFor.RazaoSocial.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
        }

        private void navBarItemAlterarCarrinho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.xFrmItensVenda.Run();
        }

        private void navBarItemAjuda_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var OBS = "O: Adiciona Observação.\n\n";
            var V = "V: Ver itens da proposta.\n\n";
            var F3 = "Alterar o Centro de custo da Venda.\n\n";
            var F4 = "Dados Complementares da Proposta.\n\n";
            var F5 = "F5: Fechar a cotação - A cotação pode ser alterada sempre que preciso.\n\n";
            var F9 = "F9: Fechar a proposta - Após fechada a proposta, a mesma não poderá ser alterada.\n\n";
            var F11 = "F11: Fechar a proposta á vista.\n\n";
            var Sair = "Ctrl + W: Abandonar proposta.\n\n";

            //criando mensagem de alerta
            var sb = new StringBuilder();

            sb.Append(OBS);
            sb.Append(V);
            sb.Append(F3);
            sb.Append(F4);
            sb.Append(F5);
            sb.Append(F9);
            sb.Append(F11);
            sb.Append(Sair);

            XMessageIts.Mensagem(sb);
        }

        private void navBarItemObervacao_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Observacao = XFrmOptionPane.ShowInputDialog("Observação:", 
                "Observação", this.Observacao, 300);
        }

        private void XFrmVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void navBarItemAlterarCentroCusto_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //esta selecionando o centro de custo para venda especifica
            var frm = new XFrmSetCentroVenda(centro, localEstoque);

            frm.ShowDialog();

            this.centro = frm.Centro;
            this.localEstoque = frm.LocalEstoque;

            frm.Dispose();
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

        private void navBarDadoCpl_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            new XFrmDadosComplementaresVenda(this.vendaComplementar).ShowDialog();
        }
        #endregion Eventos

    }
}