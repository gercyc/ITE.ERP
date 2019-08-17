using System;
using System.Collections.Generic;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;
using ITSolution.Framework.Enumeradores;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Mensagem;

namespace ITE.Fiscal.Movimentacoes.OutrasMovimentacoes
{

    public partial class XFrmAddItemPedidoCotacao : DevExpress.XtraEditors.XtraForm
    {
        private XFrmPedidoCompraCotacao XFrmNotaFiscal;
        private FormTypeAction formTypeAction;

        //lista vazia de impostos do item que está sendo adicionado
        public List<ImpostoItemMovimento> impostosItem = new List<ImpostoItemMovimento>();
        //lista vazia de impostos que foram removidos.
        public XFrmPedidoCompraCotacao formPai;

        public ItemMovimento itemSelect;

        #region Construtores
        public XFrmAddItemPedidoCotacao()
        {
            InitializeComponent();
            new TextEditUtil(txtVlrTotal).CustomizeNumberField();
            new TextEditUtil(txtQtde).CustomizeNumberField();
            new TextEditUtil(txtVlrUnitario).CustomizeNumberField();

        }
        public XFrmAddItemPedidoCotacao(XFrmPedidoCompraCotacao xFrmNotaFiscal) : this()
        {
            this.XFrmNotaFiscal = xFrmNotaFiscal;
        }

        //Edição do item em uma nota fiscal que está sendo criada
        public XFrmAddItemPedidoCotacao(ItemMovimento itemSelect) : this()
        {
            this.itemSelect = itemSelect;
            //indexarCampos();
        }

        //Edicao do item de uma nota já salva
        public XFrmAddItemPedidoCotacao(ItemMovimento itemSelect, FormTypeAction formTypeAction, XFrmPedidoCompraCotacao formPai) : this()
        {
            this.formPai = formPai;
            this.itemSelect = itemSelect;
            this.formTypeAction = formTypeAction;
            indexarCampos();
        }


        #endregion

        #region Métodos


        //carrega os dados para o cache do form
        private void carregarDados()
        {
            var ctx = new BalcaoContext();
            var cfops = ctx.CfopsDao.FindAll();
            var tiposMov = ctx.RegraFiscalDao.FindAll();
        }


        private ItemMovimento indexarItemNotaFiscal()
        {
            var produto = lookUpProduto1.Produto;

            if (produto != null)
            {

                var quantidade = ParseUtil.ToDecimal(txtQtde.Text.Replace(".", ""), 3);
                var valorUnitario = ParseUtil.ToDecimal(txtVlrUnitario.Text);
                var itemNF = new ItemMovimento(produto, valorUnitario, quantidade);
                return itemNF;
            }
            else
            {
                XMessageIts.Advertencia("Selecione um produto!");
            }
            return null;
        }

        //Calcula o total do item com base nos campos de texto
        private Decimal calcularItem()
        {

            var qtd = ParseUtil.ToDecimal(txtQtde.Text.Replace(".", ""), 3);
            var vlrUnitario = ParseUtil.ToDecimal(txtVlrUnitario.Text);
            var vlrTotal = qtd * vlrUnitario;

            return vlrTotal;
        }

        //preenche os controles com o produto em edicao
        private void indexarCampos()
        {
            if (itemSelect != null)
            {
                lookUpProduto1.FindSetProduto(itemSelect.IdProduto);
                txtVlrUnitario.Text = itemSelect.ValorUnitario.ToString("n2");
                txtVlrTotal.Text = itemSelect.TotalItem.ToString("N2");
                txtQtde.Text = itemSelect.Quantidade.ToString("N2");
            }
        }


        #endregion

        #region Eventos gerais
        private void btnTotItem_Click(object sender, EventArgs e)
        {
            txtVlrTotal.Text = calcularItem().ToString("n2");
        }

        private void txtQtde_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtVlrUnitario.Text))
            {
                txtVlrTotal.Text = calcularItem().ToString("n2");
            }
        }
        private void txtQtde_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtVlrUnitario.Text))
            {
                txtVlrTotal.Text = calcularItem().ToString("n2");
            }
        }
        //Salvar o item em edição ou para adição à NF
        private void salvarItem()
        {
            //se estiver editando a NF este botao irá atualizar o item em edicao
            if (formTypeAction == FormTypeAction.Alterar) //se estiver editando o item
            {
                var updItem = indexarItemNotaFiscal();
                if (updItem != null)
                {
                    itemSelect.Update(updItem);
                    this.Dispose();
                }
                else
                    XMessageIts.Advertencia("Selecione um produto ou verifique se a regra fiscal foi selecionada!");

            }
            else //se estiver adicionando
            {
                if (!String.IsNullOrEmpty(txtVlrUnitario.Text) &&
                    !String.IsNullOrEmpty(txtQtde.Text)) //se nenhum dos txts for nulo
                {
                    txtVlrTotal.Text = calcularItem().ToString("n2");
                    this.XFrmNotaFiscal.itensNota.Add(indexarItemNotaFiscal());
                    this.Dispose();
                }
                else
                {
                    XMessageIts.Advertencia("Informe o valor unitário e quantidade do item!");
                }
            }
        }

        private void XFrmAddItemNF_Shown(object sender, EventArgs e)
        {
            carregarDados();
            indexarCampos();
        }
        private void barBtnEditarItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void gridViewImpostos_DoubleClick(object sender, EventArgs e)
        {
            barBtnEditarItem_ItemClick(null, null);
        }

        private void btnSalvarN_Click(object sender, EventArgs e)
        {
            salvarItem();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion


    }
}