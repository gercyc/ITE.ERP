using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using ITE.Entidades.DaoManager;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITE.Entidades.UnitControl;
using ITE.Vendas.Forms.Informativo;
using ITE.Vendas.Forms.Util;
using ITE.Vendas.Forms.View;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Eventos.GridViewEvents;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITE.Vendas.Forms.ControleVenda;
using ITSolution.Framework.BaseInterfaces;
using ITSolution.Framework.Common.BaseClasses;

/**
 * Copyright (produto) 2013, ITSolution Business Intelligence. Todos os direitos reservados. ITE
 * SOFTWARE/CONFIDENCIAL. O Uso está sujeito aos termos.
 * 
 * 
 * GridControl EnableAppearenceEvenRow e OddRow
 * 
 */
namespace ITE.Vendas.Forms.ListView
{
    public partial class XFrmProdutoListView : DevExpress.XtraEditors.XtraForm, IITSTransaction
    {
        private readonly UnitWork _lc;
        private readonly Usuario _user;
        private readonly FocusRowChangedEvent _gridFocusUtil;


        public XFrmProdutoListView(Usuario user)
        {
            InitializeComponent();
            this._user = user;
            _lc = new UnitWork();
            gridViewCat.RestoreViewFromResource(Assembly.GetExecutingAssembly(), "ITE.Vendas.GridLayout.categoria.xml");
            gridViewUnd.RestoreViewFromResource(Assembly.GetExecutingAssembly(), "ITE.Vendas.GridLayout.unidade_medida.xml");
            this._gridFocusUtil = new FocusRowChangedEvent(gridViewProdutos);
        }

        private void barBtnAtualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XFrmWait.StartTask(carregarProdutos(), "Carregando Produtos");
        }

        private async Task carregarProdutos()
        {
            try
            {
                //cortou pra mais da metade os selects
                using (var ctx = new BalcaoContext())
                {
                    ctx.LazyLoading(false);

                    var produtos = await ctx.Produtos
                        .Include(p => p.CategoriaProduto)
                        .Include(p => p.UnidadeMedida)
                        .ToListAsync();

                    var cats = await ctx.CategoriaProdutoDao.FindAllAsync();
                    var unds = await ctx.UnidadeMedidaDao.FindAllAsync();

                    this.Invoke(new MethodInvoker(delegate
                    {
                        this.gridControlProdutos.DataSource = produtos;
                        this.gridViewProdutos.FindFilterText = "";
                        this.gridViewProdutos.Focus();

                        if (produtos != null)
                            this._gridFocusUtil.KeepFocusedRowChanged();

                        repSearchLookUpCat.DataSource = cats;
                        repSearchLookUpUnd.DataSource = unds;

                    }));
                }
            }
            catch (Exception ex)
            {
                Console.Write("Erro no view dos produtos" + ex.Message);
            }

        }


        public List<Produto> getSelectedRows()
        {
            List<Produto> produtosAlterar = new List<Produto>();
            int[] rowIndex = gridViewProdutos.GetSelectedRows();
            int rowCount = gridViewProdutos.SelectedRowsCount;
            for (int i = 0; i < rowCount; i++)
            {
                var p = gridViewProdutos.GetRow(rowIndex[i]) as Produto;
                produtosAlterar.Add(p);
            }

            return produtosAlterar;
        }

        private void btnAplicarPromocao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_lc.AcessOrLogin(_user))
                new XFrmAddPromocao(gridViewProdutos.GetSelectedItens<Produto>()).ShowDialog();
        }


        private void barBtnEditarProduto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_lc.AcessOrLogin(_user))
            {
                var p = gridViewProdutos.GetFocusedRow<Produto>();

                if (p != null)
                {
                    new XFrmDetalhesProduto(p, _user).ShowDialog();
                    //atualize os dados do grid
                    gridViewProdutos.RefreshData();
                }
            }
        }

        private void gridViewProdutos_DoubleClick(object sender, EventArgs e)
        {
            barBtnEditarProduto_ItemClick(null, null);
        }

        private void btnAjustaEstoque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var produtos = gridViewProdutos.GetSelectedItens<Produto>();
            if (produtos.Exists(p => p.TipoItemProduto == Entidades.Enumeradores.TypeItemProduto.Servico))
            {
                XMessageIts.Mensagem("Produtos do tipo item não pode ter estoque");
            }
            else
            {
                if (_lc.AcessOrLogin(_user))
                {
                    new XFrmAjustarEstoque(produtos).ShowDialog();
                    gridViewProdutos.RefreshData();
                }
            }

            //var dialog = XMessageIts.Confirmacao("O estoque dos produtos selecionados serão"
            //    + " recalculados com base nas transações existentes, deseja prosseguir?");
            //if(dialog == DialogResult.Yes)
            //{
            //    foreach (var prd in XGridViewUtil.GetSelectedItens<Produto>(gridViewProdutos))
            //    {
            //        new ProdutoDaoManager().SetQuantidadeAtualProduto(prd.IdProduto);
            //    }
            //}
        }

        private void XFrmGerenciarProdutoNovo_Shown(object sender, EventArgs e)
        {
            barBtnAtualizar_ItemClick(null, null);
        }

        private void btnAddProduto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //congela a instancia anterior
            new XFrmProdutoSimplesView().ShowDialog();
            gridViewProdutos.RefreshData();
        }

        private void gridViewProdutos_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                for (int i = 0; i < gridViewProdutos.DataRowCount; i++)
                {
                    var category = View.GetFocusedRow() as Produto;
                    if (category.QuantidadeProduto <= 1M || category.QuantidadeProduto == 0M)
                    {
                        e.Appearance.BackColor = Color.Salmon;
                        e.Appearance.BackColor2 = Color.SeaShell;
                    }
                }

            }
        }

        private void gridViewProdutos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (_lc.UserManager.IsSuperUser(_user)
                && _user.NomeUtilizador == "admin")
            {
                var row = gridViewProdutos.GetFocusedRow<Produto>();
                if (row != null)
                {
                    var ctx = new BalcaoContext();
                    var current = ctx.ProdutoDao.Find(row.IdProduto);

                    //se existe um produto com o codigo
                    // e produto é diferente do q estou editando
                    if (e.Column == colCodigoBarras)
                    {

                        string codigoBarras = e.Value.ToString();
                        var find = new ProdutoDaoManager().GetProdutoByCodigoBarras(codigoBarras);

                        if (find != null && row.IdProduto != find.IdProduto)
                        {
                            XMessageIts.Advertencia("Código de barras " + codigoBarras + " já utilizado !");

                            gridViewProdutos.SetFocusedValue(current.CodigoBarras);
                        }
                        else
                        {
                            //atualize com os dados da celula
                            current.Update(row);
                            //efetiva transacao
                            ctx.ProdutoDao.Update(current);
                            gridViewProdutos.RefreshRow(e.RowHandle);
                        }
                    }
                    else
                    {


                        //atualize com os dados da celula
                        current.Update(row);

                        ctx.ProdutoDao.Update(current);
                        gridViewProdutos.RefreshRow(e.RowHandle);
                        row.Update(current);

                    }
                }
            }
        }

        private void barBtnEditarGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //se tem permissao mas deseja desativar
            if (_lc.AcessOrLogin(_user, "Permissão para editar na tabela")
                && barBtnEditarGrid.Caption.StartsWith("Edição") && _user.NomeUtilizador == "admin")
            {
                this.gridViewProdutos.OptionsBehavior.Editable = true;
                this.barBtnEditarGrid.Caption = "Desativar edição na tabela";
            }
            else
            {
                this.gridViewProdutos.OptionsBehavior.Editable = false;
                this.barBtnEditarGrid.Caption = "Edição na tabela";
            }
        }

        private void gridViewProdutos_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column == colMargemLucro)
                e.DisplayText = e.Value + "%";
        }


        private async void searchControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = "" + searchControl1.EditValue;
                if (!string.IsNullOrEmpty(search))
                {
                    using (var ctx = new BalcaoContext())
                    {
                        ctx.LazyLoading(false);

                        //carregando apenas o cliente do lancamento
                        var lista = await ctx.Produtos
                                              .Include(p => p.CategoriaProduto)
                                              .Include(p => p.UnidadeMedida)
                                              .Where(p => p.DescricaoProduto.Contains(search))
                                              .ToListAsync();
                        var cats = new List<CategoriaProduto>();
                        var unds = new List<UnidadeMedida>();
                        foreach (var p in lista)
                        {
                            cats.Add(p.CategoriaProduto);
                            unds.Add(p.UnidadeMedida);
                        }

                        repSearchLookUpCat.DataSource = cats;
                        repSearchLookUpUnd.DataSource = unds;
                        this.gridViewProdutos.FindFilterText = search;
                        gridControlProdutos.DataSource = lista;

                    }

                }

            }
        }

        private void searchControl1_EditValueChanged(object sender, EventArgs e)
        {
            string search = "" + searchControl1.EditValue;

            if (string.IsNullOrEmpty(search))
            {
                barBtnAtualizar_ItemClick(null, null);
            }
        }

        private void gridViewProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && !this.gridViewProdutos.OptionsBehavior.Editable)
            {
                //se tem permissao mas deseja desativar
                if (_lc.AcessOrLogin(_user, "Permissão para editar na tabela"))
                {
                    this.gridViewProdutos.OptionsBehavior.Editable = true;
                    this.barBtnEditarGrid.Caption = "Desativar edição na tabela";
                }
            }
        }

        private void barBtnSaldoCusto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var p = gridViewProdutos.GetFocusedRow<Produto>();

            if (p != null)
            {
                new XFrmConsultaEstoque(p).ShowDialog();
            }
        }

        private void propriedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barBtnEditarProduto_ItemClick(null, null);
        }

        private void saldosECustosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barBtnSaldoCusto_ItemClick(null, null);
        }

        #region IITSTransaction
        public IITSTools ITSTools { get; set; }
        public string GetTransactionText()
        {
            if (TransactionInfo != null)
                return TransactionInfo.TransactionDescription;
            else
                return this.Text;
        }
        public string TransactionShortcut
        {
            get
            {
                if (TransactionInfo != null)
                    return TransactionInfo.TransactionShortcut;
                else
                    return "PRODUTO";
            }
        }

        public TransactionInfo TransactionInfo
        {
            get
            {
                return new TransactionInfo()
                {
                    TransactionDescription = this.Text,
                    TransactionShortcut = "PRODUTO"
                };
            }
            set
            { }
        }


        #endregion
    }
}