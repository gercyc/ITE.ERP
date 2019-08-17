using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITE.Entidades.POCO.Ardosia.Minning;
using ITE.Entidades.POCO.Ardosia.ProductionSlate;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Slate.Forms.ControleCarga.View
{
    /// <summary>
    /// </summary>
    public partial class XFrmItensCarga : DevExpress.XtraEditors.XtraForm
    {
        //O item do tipo será convertido no momento da transação com banco
        private List<ItemOrdemCarga> _itensVenda;
        private XFrmOrdemCarga _xFrmVenda;
        public decimal MetrosQuadrados { get; private set; }

        public XFrmItensCarga()
        {
            InitializeComponent();
            this._itensVenda = new List<ItemOrdemCarga>();
            updateFocusGridView();
        }
        public XFrmItensCarga(List<ItemOrdemCarga> itens)
        {
            InitializeComponent();
            this._itensVenda = new List<ItemOrdemCarga>(itens);
            updateFocusGridView();
        }


        /// <summary>
        /// Inicia a instancia de itens da proposta informada passando o form da proposta
        /// </summary>
        /// <param name="xFrmProposta"></param>
        public XFrmItensCarga(XFrmOrdemCarga xFrmProposta)
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

        public List<ItemOrdemCarga> GetItensCarga()
        {
            return _itensVenda;
        }

        public decimal CalculaTotalProposta()
        {
            decimal total = 0;
            this.MetrosQuadrados = 0;

            foreach (var i in _itensVenda)
            {
                total += i.TotalUnitario;
                this.MetrosQuadrados += i.MetrosQuadrado;
            }
            return total;
        }

        public ItemOrdemCarga AddItem(MaterialSerra mat,int qtde)
        {
            var o = this._itensVenda.Find(i => i.Material.NomeMaterial.Equals(mat.NomeMaterial));

            if (o != null)
            {
                MessageBoxBlack.Advertencia("Material \"" + mat.NomeMaterial
                    + "\" já incluso !");
                return null;
            }

            var item = new ItemOrdemCarga(mat, qtde);
            //garante a consistencia em caso de lajinha
            item.Update(item);
            this._itensVenda.Add(item);
            this.gridControlItensVenda.DataSource = _itensVenda;
            return item;

        }

        /// <summary>
        /// Add uma coleção de elementos no gridControl
        /// </summary>
        /// <param name="itens"></param>
        public void AddListaItem(ICollection<ItemOrdemCarga> itens)
        {
            this._itensVenda = new List<ItemOrdemCarga>(itens);
            this.gridControlItensVenda.DataSource = _itensVenda;
        }

        private void updateFocusGridView()
        {
            this.gridViewItensVenda.RefreshData();
            this.gridViewItensVenda.Focus();
            gridViewItensVenda.SelectRow(0);
            this.gridViewItensVenda.FocusedColumn = colQuantidadePecas;
        }

        private void gridViewItensVenda_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colQuantidadePecas || e.Column == colValorUnitario)
            {
                //esse value eh disparado automaticamente na data do gridControl
                var x = ParseUtil.ToDecimal( e.Value);
             
                //linha que houve a ocorrencia
                var item = gridViewItensVenda.GetFocusedRow<ItemOrdemCarga>();

                //se nao esta disponivel em estoque
                if (x <= 0 || !_xFrmVenda.IsQuantidade(item))
                {
                    //atribua a quantidade minima
                    item.QuantidadePeca = 1;

                    gridViewItensVenda.SetFocusedRowCellValue(colQuantidadePecas, 1);
                }
                //recalcula o item
                item.Update(item);

                gridViewItensVenda.SetFocusedRowCellValue(colTotalItem, item.TotalUnitario);

                gridViewItensVenda.RefreshData();

                _xFrmVenda.atualizarTotalVenda(true);
            }
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var item = gridViewItensVenda.GetFocusedRow() as ItemOrdemCarga;
                if (item != null)
                {
                    //remove do grid e atualiza o datasource
                    gridViewItensVenda.DeleteSelectedRows();
                    
                    //remove da lista 
                    this._itensVenda.Remove(item);
                    
                    //sera atualizado apos o dispose

                    //gridViewItensVenda.RefreshData();
                }
                _xFrmVenda.atualizarTotalVenda(true);
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