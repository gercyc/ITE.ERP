using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Util;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.DaoManager;
using ITSolution.Framework.Beans.ProgressBar;
using ITE.Vendas.Forms.View;
using ITE.Entidades.Enumeradores;
using DevExpress.XtraSplashScreen;
using ITE.Entidades.POCO.Sales;

/**
 * Copyright (produto) 2013, ITSolution Business Intelligence. Todos os direitos reservados. ITE
 * SOFTWARE/CONFIDENCIAL. O Uso está sujeito aos termos.
 * Ajustar o estoque do produto ou dos produtos selecionados no grid
 * se o parametro "grv_alter_produto_ajuste_estoque" estiver como true o objeto Produto é serializado e armazenado
 * no banco de dados em formato binario. Nota-se uma pequena perda de performance 
 * 
 */

namespace ITE.Vendas.Forms.Informativo
{//
    public partial class XFrmDetalhesProduto_OLD : DevExpress.XtraEditors.XtraForm
    {
        private Produto produto;
        private List<AlteracaoProduto> listaAlteracoes = new List<AlteracaoProduto>();
        private List<Produto> produtosAlter = new List<Produto>();

        public XFrmDetalhesProduto_OLD()
        {
            InitializeComponent();
            new TextEditUtil(txtQtdEstoque).CustomizeNumberField();
        }

        public XFrmDetalhesProduto_OLD(Produto p)
            : this()
        {
            this.produto = p;
        }

        public void FillStatus()
        {
            if (produto != null)
            {
                using (var ctx = new BalcaoContext())
                {

                    var pNew = ctx.ProdutoDao.Find(produto.IdProduto);
                    produto = pNew;
                    if (produto.StatusProduto.Equals(TypeStatusProduto.Ativo))
                    {
                        cbStatusProduto.SelectedIndex = 0;
                        cbStatusProduto.Text = produto.StatusProduto.ToString();
                    }
                    else if (produto.StatusProduto.Equals(TypeStatusProduto.Invativo))
                    {
                        cbStatusProduto.SelectedIndex = 1;
                        cbStatusProduto.Text = produto.StatusProduto.ToString();
                    }
                    else if (produto.StatusProduto.Equals(TypeStatusProduto.SemEstoque))
                    {
                        cbStatusProduto.SelectedIndex = 2;
                        cbStatusProduto.Text = produto.StatusProduto.ToString();
                    }
                }

            }
        }

        /// <summary>
        /// Popula os campos do formulario com os dados do produto selecionado
        /// A lógica deve ser revisada para ganhar performance
        /// </summary>
        private void popularCampos()
        {

            if (produto != null)
            {
                var ctx = new BalcaoContext();

                txtDescricao.Text = produto.DescricaoProduto;
                txtMargemLucro.Text = produto.MargemLucro.ToString("N2");
                txtPrecoCompra.Text = produto.PrecoCompra.ToString("N2");
                txtPrecoVenda.Text = produto.PrecoVenda.ToString("N2");
                txtQtdEstoque.Text = produto.QuantidadeProduto.ToString("n3");
                cbUnidadeMed.Text = produto.UnidadeMedida.NomeUnidadeMedida;
                cbStatusProduto.Text = produto.StatusProduto.ToString();
                FillStatus();
                cbStatusProduto.Refresh();
                cbCategoriaProduto.Text = produto.CategoriaProduto.NomeCategoriaProduto;
                cbCategoriaProduto.Refresh();
                pictureFotoProduto.Image = ImageUtilIts.GetImageFromBytes(produto.FotoProduto);
                //atualiza o grid com as alteracoes
                //pego somente os campos do novo tipo anonimo retornado pela query LINQ
                var alts = from a in produto.AlteracoesProduto
                           where a.IdProduto == produto.IdProduto
                           select new AlteracaoProduto
                           {
                               DataAlteracao = a.DataAlteracao,
                               IdAlteracao = a.IdAlteracao,
                               IdProduto = a.IdProduto,
                               PercentualDescontoPromocao = a.PercentualDescontoPromocao,
                               TipoAlteracao = a.TipoAlteracao,
                               PrecoCompraAnterior = a.PrecoCompraAnterior,
                               PrecoVendaAnterior = a.PrecoVendaAnterior,
                               QtdAnterior = a.QtdAnterior
                           };

                gridControlAlteracoes.DataSource = alts;

                //movimentacoes

                //Listas vazias
                List<Venda> vendasPrd = new List<Venda>();
                /*List<Entrada> entradasPrd = new List<Entrada>();

                //busca as entradas e saidas que contenham o produto selecionado
                //query a ser revisada para obter performance, nas duas abaixo
                //os objetos são convertidos para ToList() ocorrendo um GAP de CPU/Memória
                var IentradasT = produto.ItensEntrada;
                if (IentradasT != null)
                {
                    foreach (var e in IentradasT)
                    {
                        entradasPrd.Add(new Entrada(e.IdEntradaNf, e.Entrada.NumeroNf, e.Entrada.CliFor, e.Entrada.DataEntrada, e.TotalItem, e.Entrada.StatusNota));
                    }
                }*/

                var Isaidas = produto.ItensVenda;
                if (Isaidas != null)
                {
                    foreach (var s in Isaidas)
                    {
                        vendasPrd.Add(new Venda(s.Venda.IdVenda, s.Venda.CliFor, s.TotalItem, s.Venda.StatusVenda, s.Venda.DataVenda));
                    }
                }


                //var entradas = from ent in ctx.ItemEntradaDao.FindAll()
                //               join prd in ctx.ProdutoDao.FindAll() on ent.IdProdutoEntrada 
                //                 equals prd.IdProduto where prd.IdProduto == produto.IdProduto
                //                 select ent;

                //var saidas = from itmSai in ctx.ItensVendaDao.FindAll()
                //             join prd in ctx.ProdutoDao.FindAll() on itmSai.IdProduto 
                //               equals prd.IdProduto where prd.IdProduto == produto.IdProduto
                //               select itmSai;

                //  //check
                //  if (entradas != null)
                //  {
                //      foreach (var e in entradas)
                //      {
                //          entradasPrd.Add(e.Entrada);
                //      }
                //  }

                //  //check
                //  if (saidas != null)
                //  {
                //      foreach (var v in saidas.ToList())
                //      {
                //          vendasPrd.Add(v.Venda);
                //      }
                //  }

                gridControlMovSaidas.DataSource = vendasPrd;
                //gridControlMovEntradas.DataSource = entradasPrd;
            }
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            new XFrmCategoriaProdutoView().ShowDialog();
            btnAtualizarCategorias_Click(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                var op = XMessageIts.Confirmacao("Deseja cancelar cadastro de produto ?");

                if (op == DialogResult.No)
                    return;
            }
            this.Dispose();
        }

        //private void btnSalvar_Click(object sender, EventArgs e)
        //{
        //    Produto produto = indexarDados();

        //    if (new ValidadorDTO().ValidateWarningAll(produto))
        //    {
        //        var ctx = new BalcaoContext();

        //        if (ctx.ProdutoDao.Save(produto))
        //        {
        //            XMessageIts.Mensagem("Produto salvo com sucesso.");
        //            this.Dispose();
        //        }
        //    }
        //}

        //private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        //{
        //    var op = openFileFoto.ShowDialog();
        //    if (op == DialogResult.OK)
        //    {
        //        txtPathFoto.Text = openFileFoto.FileName;
        //        byte[] b = ImageUtilIts.GetBytesFromStream(openFileFoto.OpenFile());
        //        pictureFotoProduto.Image = ImageUtilIts.GetImageFromBytes(b);
        //    }
        //}

        private void btnAtualizarCategorias_Click(object sender, EventArgs e)
        {
            var cats = new BalcaoContext().CategoriaProdutoDao.FindAll();
            var unm = new BalcaoContext().UnidadeMedidaDao.FindAll().OrderByDescending(u => u.NomeUnidadeMedida).ToList();
            ComboBoxUtil.AddList<CategoriaProduto>(cbCategoriaProduto, cats);
            ComboBoxUtil.AddList<UnidadeMedida>(cbUnidadeMed, unm);
        }

        private async void btnSalvarProduto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await updateProdutoAsync();
            cbStatusProduto.Refresh();
        }

        private async Task updateProdutoAsync()
        {
            var prdMng = new ProdutoDaoManager();
            var categoria = cbCategoriaProduto.GetSelectedItem<CategoriaProduto>();
            var unidMedida = cbUnidadeMed.GetSelectedItem<UnidadeMedida>();

            if (categoria != null && unidMedida != null)
            {
                var ctx = new BalcaoContext();

                var pUpdate = await ctx.ProdutoDao.FindAsync(produto.IdProduto);
                pUpdate.DescricaoProduto = txtDescricao.Text;
                pUpdate.IdCategoriaProduto = categoria.IdCategoriaProduto;
                pUpdate.IdUnidadeMedidaProduto = unidMedida.IdUnidadeMedida;
                pUpdate.MargemLucro = ParseUtil.ToDecimal(txtMargemLucro.Text);
                pUpdate.PrecoCompra = ParseUtil.ToDecimal(txtPrecoCompra.Text);
                pUpdate.PrecoVenda = ParseUtil.ToDecimal(txtPrecoVenda.Text);
                pUpdate.QuantidadeProduto = ParseUtil.ToDecimal(txtQtdEstoque.Text, 3);
                //pUpdate.StatusProduto = (StatusProduto)cbStatusProduto.SelectedItem;

                //adicione a alteracao ao produto
                pUpdate.AlteracoesProduto.Add(new AlteracaoProduto(pUpdate.IdProduto,
                    "A", 0.0m, DateTime.Now, produto.PrecoVenda, produto.PrecoCompra, produto.QuantidadeProduto));

                SplashScreenManager.ShowForm(typeof(XFrmWait));

                var result = await ctx.ProdutoDao.UpdateAsync(pUpdate);

                if (result)
                {
                    cbStatusProduto.Text = pUpdate.StatusProduto.ToString();
                    FillStatus();
                    XMessageIts.Mensagem("Produto atualizado com sucesso!",
                        "SUCESSSO", MessageBoxIcon.Information);
                    this.produto = await ctx.ProdutoDao.FindAsync(produto.IdProduto);
                    popularCampos();


                    this.ProdutoUpdate = pUpdate;
                }
                SplashScreenManager.CloseForm();

            }
        }
        private void gridViewAlteracoes_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }


        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            //calcule a margem de lucro se o textbox for modificado
            if (txtPrecoVenda.IsModified)
            {
                var pVenda = ParseUtil.ToDecimal(txtPrecoVenda.Text);
                var vCompra = ParseUtil.ToDecimal(txtPrecoCompra.Text);
                var margemLucro = produto.CalcularMargemLucro(pVenda, vCompra);
                produto.MargemLucro = margemLucro;
                txtMargemLucro.Text = margemLucro.ToString("N2");
            }
        }

        private void txtPrecoCompra_Leave(object sender, EventArgs e)
        {
            //calcule a margem de lucro se o textbox for modificado
            if (txtPrecoCompra.IsModified)
            {
                var pVenda = ParseUtil.ToDecimal(txtPrecoVenda.Text);
                var vCompra = ParseUtil.ToDecimal(txtPrecoCompra.Text);
                var margemLucro = produto.CalcularMargemLucro(pVenda, vCompra);
                produto.MargemLucro = margemLucro;
                txtMargemLucro.Text = margemLucro.ToString("N2");
            }
        }

        private void XFrmDetalhesProduto_Shown(object sender, EventArgs e)
        {
            popularCampos();
        }

        private void XFrmDetalhesProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        public Produto ProdutoUpdate { get; set; }
    }
}