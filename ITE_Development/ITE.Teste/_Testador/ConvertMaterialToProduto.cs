using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Repositorio;
using System.Collections.Generic;
using System.Linq;

namespace ITE.Teste._Testador
{
    public class ConvertMaterialToProduto
    {

        public void Convert()
        {

            var ctx = new BalcaoContext();
            var ctxSlate = new SlateContext();

            var materiais = ctxSlate.MaterialSerraDao.FindAll();

            foreach (var m in materiais)
            {
                var attrib = new AtributoProduto(m);
                try
                {
                    var p = ctx.ProdutoDao.Find(m.IdMaterial);
                    //atualiza os atributos
                    p.Atributos = attrib;

                    p.PrecoVenda = attrib.ValorMetroQuadrado;
                    p.DescricaoProduto = attrib.NomeMaterial;

                    ctx.ProdutoDao.Update(p);
                }
                catch (System.Exception)
                {
                    //recupra o primeiro produto
                    var p = ctx.ProdutoDao.Find(1);
                    var newProduto = new Produto();
                    p.Atributos = attrib;

                    newProduto.Update(p);
                    newProduto.IdProduto = 0;
                    newProduto.CategoriaProduto = null;
                    newProduto.UnidadeMedida = null;
                    newProduto.AlteracoesProduto = new List<AlteracaoProduto>();
                    newProduto.TransacoesProduto = new List<TransacoesProduto>();

                    newProduto.CodigoBarras = "000" + (ctx.Produtos.Count() + 1);

                    ctx.ProdutoDao.Save(newProduto);
                }

            }

        }

    }
}

