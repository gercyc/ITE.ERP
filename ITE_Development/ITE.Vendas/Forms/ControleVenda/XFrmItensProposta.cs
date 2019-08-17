using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;
using ITE.Entidades.POCO.Sales;

namespace ITE.Vendas.Forms.ControleVenda
{
    /// <summary>
    /// </summary>
    public partial class XFrmItensProposta : DevExpress.XtraEditors.XtraForm
    {
        //O item do tipo será convertido no momento da transação com banco
        private List<ItemVenda> _itensVenda;
        private XFrmVenda _xFrmVenda;

        public XFrmItensProposta()
        {
            InitializeComponent();
            this._itensVenda = new List<ItemVenda>();
            updateFocusGridView();
        }
        public XFrmItensProposta(List<ItemVenda> itens)
        {
            InitializeComponent();
            this._itensVenda = new List<ItemVenda>(itens);
            updateFocusGridView();
        }


        /// <summary>
        /// Inicia a instancia de itens da proposta informada passando o form da proposta
        /// </summary>
        /// <param name="xFrmProposta"></param>
        public XFrmItensProposta(XFrmVenda xFrmProposta)
            : this()
        {
            this._xFrmVenda = xFrmProposta;
        }

        private void XFrmItensVenda_Shown(object sender, EventArgs e)
        {
            updateFocusGridView();
        }

        public void Run()
        {
            this.ShowDialog();
        }

        public List<ItemVenda> GetItensProposta()
        {
            return _itensVenda;
        }

        public Decimal CalculaTotalProposta()
        {
            Decimal total = 0;
            foreach (var i in _itensVenda)
            {
                //total += i.Produto.PrecoVenda * i.Quantidade;
                total += i.ValorUnitario * i.Quantidade;
            }
            return total;
        }

        public bool AddItem(Produto p)
        {
            
            var o = GetItensProposta().Find(i => i.Produto.DescricaoProduto.Equals(p.DescricaoProduto));

            if (o != null)
            {
                MessageBoxBlack.Advertencia("Produto \"" + p.DescricaoProduto
                    + "\" já incluso !");
                return false;
            }
            //insere no topo da pilha
            this._itensVenda.Add(new ItemVenda(p));
            this.gridControlItensVenda.DataSource = _itensVenda;
            return true;

        }

        /// <summary>
        /// Add uma coleção de elementos no gridControl
        /// </summary>
        /// <param name="itens"></param>
        public void AddListaItem(ICollection<ItemVenda> itens)
        {
            this._itensVenda = new List<ItemVenda>(itens);
            this.gridControlItensVenda.DataSource = _itensVenda;
        }

        private void updateFocusGridView()
        {
            this.gridViewItensVenda.RefreshData();
            this.gridViewItensVenda.Focus();
            gridViewItensVenda.SelectRow(0);
            this.gridViewItensVenda.FocusedColumn = colQuantidade;
        }

        private void gridViewItensVenda_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colQuantidade || e.Column == colValorUnitario)
            {
                //esse value eh disparado automaticamente na data do gridControl
                var x = ParseUtil.ToDecimal( e.Value);
 
                //linha que houve a ocorrencia
                var item = gridViewItensVenda.GetFocusedRow() as ItemVenda;

                //se nao esta disponivel em estoque
                if (x <= 0 || !_xFrmVenda.IsQuantidade(item.Produto, item.Quantidade) 
                    //e nao eh um servico (servicos nao possui quantidade limite)
                    && item.Produto.TipoItemProduto!= Entidades.Enumeradores.TypeItemProduto.Servico)
                {
                    //atribua a quantidade minima
                    item.Quantidade = 1;
                     
                    gridViewItensVenda.SetFocusedRowCellValue(colQuantidade, 1);                    

                }

                //se for informado 0, sera considerado preco de proposta do produto
                if (item.ValorUnitario == 0 )
                {
                    //atribua o preco de proposta
                    item.ValorUnitario = item.Produto.PrecoVenda;
                    gridViewItensVenda.SetFocusedRowCellValue(colValorUnitario, item.ValorUnitario);
                }

                item.TotalItem = item.Quantidade * item.ValorUnitario;
                //atualize a quantidade do produto
                item.Produto.QuantidadeProduto = item.Quantidade;

                item.Produto.PrecoVenda = item.ValorUnitario;

                gridViewItensVenda.SetFocusedRowCellValue(colTotalItem, item.TotalItem);

                gridViewItensVenda.RefreshData();

                _xFrmVenda.atualizarTotalVenda();
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var item = gridViewItensVenda.GetFocusedRow() as ItemVenda;
                if (item != null)
                {
                    //remove do grid e atualiza o datasource
                    gridViewItensVenda.DeleteSelectedRows();
                    
                    //remove da lista 
                    this._itensVenda.Remove(item);
                    
                    //sera atualizado apos o dispose

                    //atualizando o grid
                    //gridControlItensVenda.DataSource = this.itensVenda;

                    //gridViewItensVenda.RefreshData();
                }
                _xFrmVenda.atualizarTotalVenda();
            }
        }

        private void XFrmItensVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (this._xFrmVenda != null)
                    this.Close();
                else
                    this.Dispose();
            }
        }

        private void XFrmItensProposta_FormClosing(object sender, FormClosingEventArgs e)
        {
            //atualiza a lista
            if(_xFrmVenda != null)
                _xFrmVenda.atualizarTotalVenda();            
        }
    }
}