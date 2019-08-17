using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

/**
 * Copyright (produto) 2013, ITSolution Business Intelligence. Todos os direitos reservados. ITE
 * SOFTWARE/CONFIDENCIAL. O Uso está sujeito aos termos.
 * Adicionar promocao ao produto ou nos produtos selecionados no grid
 * se o parametro "grv_alter_produto_promocao" estiver como true o objeto Produto é serializado e armazenado
 * no banco de dados em formato binario. Nota-se uma pequena perda de performance 
 * 
 */


namespace ITE.Vendas.Forms.Util
{
    public partial class XFrmAddPromocao : DevExpress.XtraEditors.XtraForm
    {
        private List<Produto> list;

        public XFrmAddPromocao()
        {
            InitializeComponent();
        }

        public XFrmAddPromocao(List<Produto> list)
            : this()
        {
            this.list = list;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal percent = ParseUtil.ToDecimal(txtPorcetagemPromocao.Text);
                var ctx = new BalcaoContext();
                int vCount = list.Count;
                int i = 0;
                foreach (var p in list)
                {
                    var pFind = ctx.ProdutoDao.Find(p.IdProduto);
                    var alteracao = new AlteracaoProduto(p.IdProduto, "P", percent, DateTime.Now,
                        p.PrecoVenda, p.PrecoCompra, p.QuantidadeProduto);
                    pFind.PrecoVenda = pFind.PrecoVenda - ((pFind.PrecoVenda * percent) / 100);
                    pFind.MargemLucro = pFind.CalcularMargemLucro(pFind.PrecoVenda, pFind.PrecoCompra);
                    pFind.AlteracoesProduto.Add(alteracao);
                    ctx.ProdutoDao.Update(pFind);
                    i++;
                }
                if (i == vCount)
                {
                    XMessageIts.Mensagem("Promoção Lançada "+
                        "=> Devemos criar um estrategia para voltar todos os itens ao normal apos um determinado periodo");
                        
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
            
        }


        private Object DeserializeObject(byte[] bytes)
        {
            Object obj = new Object();
            var binaryFormatter = new BinaryFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.Write(bytes, 0, bytes.Length);
                memoryStream.Position = 0;
                obj = binaryFormatter.Deserialize(memoryStream);
                return obj;
            }
        }

        private byte[] SerializeObject(Object obj)
        {
            if (obj != null)
            {
                var binaryFormatter = new BinaryFormatter();

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    binaryFormatter.Serialize(memoryStream, obj);

                    return memoryStream.GetBuffer();
                }
            }
            else
                return null;

        }
    }
}