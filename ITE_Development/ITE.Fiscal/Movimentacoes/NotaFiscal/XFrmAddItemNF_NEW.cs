using System;
using System.Collections.Generic;
using System.Linq;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.GuiUtil;
using ITSolution.Framework.Util;
using ITSolution.Framework.Enumeradores;
using ITE.Entidades.POCO.Fiscal;
using ITSolution.Framework.Mensagem;

namespace ITE.Fiscal.Movimentacoes.NotaFiscal
{

    public partial class XFrmAddItemNF_NEW : DevExpress.XtraEditors.XtraForm
    {
        private XFrmNotaFiscal XFrmNotaFiscal;
        private FormTypeAction formTypeAction;

        //lista vazia de impostos do item que está sendo adicionado
        public List<ImpostoItemMovimento> impostosItem = new List<ImpostoItemMovimento>();
        //lista vazia de impostos que foram removidos.
        public XFrmNotaFiscal formPai;

        public ItemMovimento itemSelect;

        #region Construtores
        public XFrmAddItemNF_NEW()
        {
            InitializeComponent();
            new TextEditUtil(txtVlrTotal).CustomizeNumberField();
            new TextEditUtil(txtQtde).CustomizeNumberField();
            new TextEditUtil(txtVlrUnitario).CustomizeNumberField();

        }
        public XFrmAddItemNF_NEW(XFrmNotaFiscal xFrmNotaFiscal) : this()
        {
            this.XFrmNotaFiscal = xFrmNotaFiscal;
        }

        //Edição do item em uma nota fiscal que está sendo criada
        public XFrmAddItemNF_NEW(ItemMovimento itemSelect) : this()
        {
            this.itemSelect = itemSelect;
            //indexarCampos();
        }

        //Edicao do item de uma nota já salva
        public XFrmAddItemNF_NEW(ItemMovimento itemSelect, FormTypeAction formTypeAction, XFrmNotaFiscal formPai) : this()
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
        }


        private ItemMovimento indexarItemNotaFiscal()
        {
            var produto = lookUpProduto1.Produto;
            var regraFiscal = lookUpRegraFiscal1.RegraFiscal;
            
            if (produto != null && regraFiscal != null)
            {
                
                var quantidade = ParseUtil.ToDecimal(txtQtde.Text.Replace(".",""), 3);
                var valorUnitario = ParseUtil.ToDecimal(txtVlrUnitario.Text);
                var cfopItem = lookUpCfop1.CFOP;
                var itemNF = new ItemMovimento(produto, valorUnitario, quantidade, impostosItem, cfopItem);
                itemNF.IdRegraFiscal = regraFiscal.IdRegraFiscal;
                itemNF.RegraFiscal = regraFiscal;
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

            var qtd = ParseUtil.ToDecimal(txtQtde.Text.Replace(".",""), 3);            
            var vlrUnitario = ParseUtil.ToDecimal(txtVlrUnitario.Text);
            var vlrTotal = qtd * vlrUnitario;

            return vlrTotal;
        }

        //preenche os controles com o produto em edicao
        private void indexarCampos()
        {
            if (itemSelect != null)
            {
                impostosItem = itemSelect.ImpostosItemMovimento != null ?
                    itemSelect.ImpostosItemMovimento.ToList() : impostosItem = null;
                
                lookUpCfop1.FindSetCfop(itemSelect.Cfop.CodigoCfop);
                lookUpProduto1.FindSetProduto(itemSelect.IdProduto);
                lookUpRegraFiscal1.FindSetCfop(itemSelect.RegraFiscal.CodigoRegraFiscal);
                txtVlrUnitario.Text = itemSelect.ValorUnitario.ToString("n2");
                txtVlrTotal.Text = itemSelect.TotalItem.ToString("N2");
                txtQtde.Text = itemSelect.Quantidade.ToString("N2");               

                atualizarGridImpostos();
            }
        }

        private void atualizarGridImpostos()
        {
            gridControlImpostos.DataSource = impostosItem;
            gridControlImpostos.RefreshDataSource();
            gridControlImpostos.Refresh();
        }

        #endregion

        #region Eventos gerais
        private void btnTotItem_Click(object sender, EventArgs e)
        {
            txtVlrTotal.Text = calcularItem().ToString("n2");
        }

        private void txtQtde_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtVlrUnitario.Text) && chkTotalizar.Checked)
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
                var regraFiscal = lookUpRegraFiscal1.RegraFiscal;
                var updItem = indexarItemNotaFiscal();
                if (updItem != null && regraFiscal != null)
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
        private void barBtnAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var baseCalculoItem = ParseUtil.ToDecimal(txtVlrTotal.Text);
            //new XFrmAddImpostoItemNf(this, baseCalculoItem).ShowDialog();
            //atualizar o grid dps de fechar o form
            barBtnAtualizarDados_ItemClick(null, null);
        }
        //remover o imposto selecionado
        private void barBtnRemoveItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var impostoSelect = GridViewUtil.GetFocusedRow<ImpostoItemMovimento>(gridViewImpostos);
            if (impostoSelect != null)
            {
                formPai.impostosRemovidos.Add(impostoSelect);
                impostosItem.Remove(impostoSelect);
                atualizarGridImpostos();
            }

        }
        //atualiza lista de impostos no grid.
        private void barBtnAtualizarDados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            atualizarGridImpostos();
        }
        private void barBtnEditarItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var impSel = GridViewUtil.GetFocusedRow<ImpostoItemMovimento>(gridViewImpostos);
            if (impSel != null)
                new XFrmAddImpostoItemNf(impSel, FormTypeAction.Alterar).ShowDialog();
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

        private void txtVlrUnitario_Leave(object sender, EventArgs e)
        {
            txtQtde_EditValueChanged(null, null);
        }
    }
}