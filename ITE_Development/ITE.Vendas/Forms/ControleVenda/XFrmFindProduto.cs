/**
 * Copyright (produto) 2013, ITSolution Business Intelligence. Todos os direitos reservados. ITE
 * SOFTWARE/CONFIDENCIAL. O Uso está sujeito aos termos.
 * 
 * 
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using ITE.Entidades.Repositorio;
using ITE.Entidades.POCO.Sales;
using ITSolution.Framework.Util;
using System.Threading.Tasks;
using ITSolution.Framework.Beans.ProgressBar;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.DaoManager;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.GuiUtil;
using System.Text;
using ITSolution.Framework.Mensagem;

namespace ITE.Vendas.Forms.ControleVenda
{
    public partial class XFrmFindProduto : DevExpress.XtraEditors.XtraForm
    {
        private XFrmVenda _xFrmProposta;
        private string _codBarraProdutoAnt;

        public XFrmFindProduto()
        {
            InitializeComponent();
            this.ActiveControl = this.txtCodigoBarrasProduto;
            this.lblDescricaoProduto.Text = " - ";
            this.gridViewProdutos.SelectRows(0, 0);

        }

        public XFrmFindProduto(XFrmVenda xFrmProposta)
            : this()
        {
            this._xFrmProposta = xFrmProposta;
        }

        public void Run()
        {
            this.ShowDialog();
        }

        #region Metodos internos
        private async Task carregarProdutos()
        {
            using (var ctx = new BalcaoContext())
            {
                ctx.LazyLoading(false);

                var produtos = await new ProdutoDaoManager().GetProdutosAVenda();
                this.gridViewProdutos.FindFilterText = "";
                this.gridControlProdutos.DataSource = produtos;
            }

        }

        private async Task carregarProdutosSemEstoque()
        {
            using (var ctx = new BalcaoContext())
            {

                //if (this.gridControlProdutos.InvokeRequired)
                var produtos = await ctx.ProdutoDao.WhereAsync(p => p.StatusProduto == TypeStatusProduto.SemEstoque);

                this.Invoke(new MethodInvoker(delegate
                {
                    gridControlProdutos.DataSource = produtos;
                    this.gridViewProdutos.SelectRows(0, 0);
                    this.gridViewProdutos.Focus();
                }));
            }
        }

        private void verProdutoGridNosCampos()
        {
            var p = gridViewProdutos.GetFocusedRow() as Produto;

            if (p != null)
            {
                txtCodigoBarrasProduto.Text = p.CodigoBarras;

                if (p.QuantidadeProduto <= 0)
                    lblDescricaoProduto.ForeColor = Color.Red;
                else
                    lblDescricaoProduto.ForeColor = Color.SteelBlue;

                lblDescricaoProduto.Text = p.DescricaoProduto + "\t" +
                                 p.QuantidadeProduto + " x " + p.PrecoVenda + " = "
                                 + p.CalculaTotalProduto(p.PrecoVenda, p.QuantidadeProduto).ToString("N2");

                //this.txtCodigoBarrasProduto.Focus();
                //this.txtCodigoBarrasProduto.SelectAll();
            }
        }

        private void help()
        {
            var sb = new StringBuilder();
            sb.Append("Enter - Adicionar o produto e retorna a tela da venda\n\n");
            sb.Append("CTRL + 0 - Retornar para tabela\n\n");
            sb.Append("CTRL + 1 - Ajustar quantidade\n\n");
            sb.Append("CTRL + Enter - Adicionar o produto e permanece na tela de consulta\n\n");
            sb.Append("CTRL + F - Localizar produto pelo nome\n\n");

            XMessageIts.Mensagem(sb);
        }

        private void selecionar(FormTypeAction action)
        {
            var txtCodBar = txtCodigoBarrasProduto.Text;

            if (String.IsNullOrWhiteSpace(txtCodBar))
                return;

            var split = txtCodBar.Split('*');

            Decimal qtde = 0;
            Produto p = this.gridViewProdutos.GetFocusedRow() as Produto;
            bool flag = false;
            if (txtCodBar.Contains("*") && split.Length > 1)
            {
                qtde = ParseUtil.ToDecimal(split[0]);
            }
            else
                //minimo
                qtde = 1;

            if (p == null)
            {
                lblDescricaoProduto.ForeColor = Color.Red;
                lblDescricaoProduto.Text = "Nenhum produto encontrado";
            }
            else
            {
                p.QuantidadeProduto = qtde;
                flag = this._xFrmProposta.AddProduto(p, qtde);
                //this.Hide();
            }

            if (action == FormTypeAction.Selecionar &&flag  )
            {
                this.Hide();
            }
        }

        #endregion

        #region Eventos do Form
        private void XFrmVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers== Keys.Control && e.KeyCode == Keys.H)
                help();

            else if (e.KeyCode == Keys.F1)
                navBarViewEstoqueZerado_LinkClicked(null, null);

            else if (e.KeyCode == Keys.F5)
               refreshProduto();

            else if (e.KeyCode == Keys.Escape)
                navBarEscape_LinkClicked(null, null);

            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.L)
            {
                searchControl1.Focus();
            }
        }

        private void XFrmFindProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            searchControl1.EditValue = "";
            gridViewProdutos.FindFilterText = "";
        }

        private void XFrmFindProduto_Shown(object sender, EventArgs e)
        {
           refreshProduto();
        }

        private void btnSelecionarNow_Click(object sender, EventArgs e)
        {
            //fique nessa tela
            selecionar(FormTypeAction.Nenhum);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //seleciona e volta a volta
            selecionar(FormTypeAction.Selecionar);
        }

        /// <summary>
        /// Evento disparado quando terminada a leitura do codigo de barras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodigoBarrras_KeyUp(object sender, KeyEventArgs e)
        {
            var txtCodBar = this.txtCodigoBarrasProduto.Text;

            //ação de ver o produto através do código de barras
            //testar usando um leitor real
            if (e.KeyCode == Keys.Enter && !txtCodBar.Equals(_codBarraProdutoAnt))
            {

                Produto find = new ProdutoDaoManager()
                    .GetProdutoByCodigoBarras(this.txtCodigoBarrasProduto.CodigoBarras);

                if (find != null)
                {
                    //cria uma copia para nao altera os dados do grid
                    Produto p = find.Clone();

                    Decimal qtde = txtCodigoBarrasProduto.Quantidade;
                    this._codBarraProdutoAnt = txtCodigoBarrasProduto.Text;

                    if (p == null)
                    {
                        lblDescricaoProduto.ForeColor = Color.Red;
                        lblDescricaoProduto.Text = "Nenhum produto encontrado";
                        //alerta sonoro
                        SoundUtil.Exclamation();
                    }
                    else
                    {
                        btnSelecionarNow_Click(null, null);
                        lblDescricaoProduto.Text = p.DescricaoProduto + "\t" +
                      qtde + "x " + p.PrecoVenda + " = " + p.CalculaTotalProduto(p.PrecoVenda, qtde).ToString("N2");

                    }

                    //deixe o foco no codigo de barras
                    this.txtCodigoBarrasProduto.Focus();

                    //selecione todo o codigo ja presente no componente
                    this.txtCodigoBarrasProduto.SelectAll();
                }
            }
            else
                if (e.KeyCode != Keys.Back)
                this._codBarraProdutoAnt = "";


        }

        private void txtCodigoBarrasProduto_KeyDown(object sender, KeyEventArgs e)
        {
            //se apertar ctrl + 0 volta pro grid
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.NumPad0
                || e.Modifiers == Keys.Control && e.KeyCode == Keys.D0)
                this.gridViewProdutos.FocusTop();

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
                this.searchControl1.Focus();
        }

        #endregion

        #region Eventos NavBar 
        private void refreshProduto()
        {
            //condicoes para nao carregar a tabela toda vez
            if (this.gridViewProdutos.IsEmpty )
            {
                XFrmWait.StartTask(carregarProdutos(), "Carregando produtos");
                this.txtCodigoBarrasProduto.Focus();
                this.txtCodigoBarrasProduto.SelectAll();
            }
        }


        private void navBarViewEstoqueZerado_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            XFrmWait.StartTask(carregarProdutosSemEstoque(), "Procurando por produtos defasados");

        }

        private void navBarEscape_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (this._xFrmProposta != null)
                this.Hide();
            else
                this.Dispose();
        }

        #endregion

        #region Eventos GridView
        private void gridViewProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.NumPad1
                 || e.Modifiers == Keys.Control && e.KeyCode == Keys.D1)
            {
                if (!txtCodigoBarrasProduto.Text.Contains("*"))
                    txtCodigoBarrasProduto.Text = "1*" + txtCodigoBarrasProduto.Text;

                txtCodigoBarrasProduto.Focus();
                txtCodigoBarrasProduto.SelectionLength = 1;
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Enter)
            {
                btnSelecionarNow_Click(null, null);
            }

            else if (gridViewProdutos.GetFocusedRow() != null && e.KeyCode == Keys.Enter)
            {
                btnSelecionar_Click(null, null);
            }
        }

        private void gridViewProdutos_DoubleClick(object sender, EventArgs e)
        {
            btnSelecionar_Click(null, null);
        }

        //Ver produto no campos pela mudanca de linha
        private void gridViewProdutosVenda_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            verProdutoGridNosCampos();

        }

        #endregion

        #region Eventos SearchControl
        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            string search = "" + searchControl1.EditValue;

            if (string.IsNullOrEmpty(search))
            {
                this.gridViewProdutos.FindFilterText = "";
               refreshProduto();
            }
        }

        private async void searchControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string pesquisa = "" + searchControl1.EditValue;
                if (!string.IsNullOrEmpty(pesquisa))
                {

                    var ctx = new BalcaoContext();
                    ctx.LazyLoading(false);

                    this.gridControlProdutos.DataSource = await new ProdutoDaoManager().GetProdutosAVenda();
                    this.gridViewProdutos.FindFilterText = pesquisa;
                }

            }
        }

        #endregion

        //Movido para componente customizado
        /*  private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
          {         
              //O Evento KeyDown possui um atraso 
              //A cada tecla pressionada ele reconhece o novo caracter na proximo ocorrencia
              //Ex: Texto Atual = 1
              //Apos digitado um digito qualquer por ex *
              //O conteudo do texto para o evento ainda é igual = 1
              //Na proxima ocorrencia de um digito qualquer a string sera = 1*
              //Considerando que tenha outro digito

              if (e.KeyCode == Keys.Multiply && txtCodigoBarrasProduto.Text.Contains("*"))
              {
                  e.SuppressKeyPress = true;
                  return;
              }
            
              //Allow navigation keyboard arrows
              switch (e.KeyCode)
              {
                      //todos os case sao permitidos
                  case Keys.Up:
                  case Keys.Down:
                  case Keys.Left:
                  case Keys.Right:
                  case Keys.PageUp:
                  case Keys.PageDown:
                  case Keys.Delete:
                  case Keys.NumPad0:
                  case Keys.NumPad1:
                  case Keys.NumPad2:
                  case Keys.NumPad3:
                  case Keys.NumPad4:
                  case Keys.NumPad5:
                  case Keys.NumPad6:
                  case Keys.NumPad7:
                  case Keys.NumPad8:
                  case Keys.NumPad9:
                      //atencao ao asterico "*"
                  case Keys.Multiply:
                      e.SuppressKeyPress = false;
                      return;
                  default:
                      break;
              }

              //Block non-number characters
              char currentKey = (char)e.KeyCode;
              bool modifier = e.Control || e.Alt || e.Shift;
              bool nonNumber = char.IsLetter(currentKey) ||
                               char.IsSymbol(currentKey) ||
                               char.IsWhiteSpace(currentKey) ||
                               char.IsPunctuation(currentKey);

    
              if (!modifier && nonNumber )
                  e.SuppressKeyPress = true;

              //Handle pasted Text
              if (e.Control && e.KeyCode == Keys.V)
              {
                  //Preview paste data (removing non-number characters)
                  string pasteText = Clipboard.GetText();
                  string strippedText = "";
                  for (int i = 0; i < pasteText.Length; i++)
                  {
                      if (char.IsDigit(pasteText[i]))
                          strippedText += pasteText[i].ToString();
                  }

                  if (strippedText != pasteText)
                  {
                      //There were non-numbers in the pasted text
                      e.SuppressKeyPress = true;

                      //OPTIONAL: Manually insert text stripped of non-numbers
                      TextBox me = (TextBox)sender;
                      int start = me.SelectionStart;
                      string newTxt = me.Text;
                      newTxt = newTxt.Remove(me.SelectionStart, me.SelectionLength); //remove highlighted text
                      newTxt = newTxt.Insert(me.SelectionStart, strippedText); //paste
                      me.Text = newTxt;
                      me.SelectionStart = start + strippedText.Length;
                  }
                  else
                      e.SuppressKeyPress = false;
              }*/
    }
}