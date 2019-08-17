using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.Entidades.DaoManager;
using ITE.Entidades.POCO.Sales;
using ITSolution.Framework.Beans.Forms;
using ITSolution.Framework.Beans.ProgressBar;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

/**
 * Copyright (produto) 2013, ITSolution Business Intelligence. Todos os direitos reservados. ITE
 * SOFTWARE/CONFIDENCIAL. O Uso está sujeito aos termos.
 * Ajustar o estoque do produto ou dos produtos selecionados no grid
 * se o parametro "grv_alter_produto_ajuste_estoque" estiver como true o objeto Produto é serializado e armazenado
 * no banco de dados em formato binario. Nota-se uma pequena perda de performance 
 * 
 */

namespace ITE.Vendas.Forms.Util
{
    public partial class XFrmAjustarEstoque : DevExpress.XtraEditors.XtraForm
    {         
        private List<Produto> produtoList;

        private XFrmAjustarEstoque()
        {
            InitializeComponent();
        }

        public XFrmAjustarEstoque(List<Produto> produtoList)
            : this()
        {
            this.produtoList = produtoList;
        }
      
        private void ajustarEstoque_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEstoque.Text))
            {
                var estoque = ParseUtil.ToDecimal(txtEstoque.Text);
                var op = XMessageIts.Confirmacao("Atenção o estoque será ajustado\n\n Confirmar operação ?",
                    "Operação Irreversível !!!");

                if (op == DialogResult.Yes)
                {
                    ajustarEstoque(estoque);
                }
            }else
            {
                XMessageIts.Advertencia("Quantidade informada inválida !");
            }
        }

        private async void ajustarEstoque(decimal estoque)
        {
            var m = new ProdutoDaoManager();

            var result = await XFrmWait.StartTask(Task.Run(() 
                => m.AjustarEstoque(produtoList, estoque)), "Ajustando estoque");

            if (result)
            {
                var msg = "O estoque do(s) produto(s) selecionado(s) foi atualizado!";
                XFrmOptionPane.ShowListTextArea(produtoList, msg);
                this.Dispose();
            }
        }

        private void txtEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                ajustarEstoque_Click(null, null);
        }
    }
}