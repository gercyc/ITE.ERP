using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using System.Diagnostics;
using ITSolution.Framework.Util;
using ITSolution.Framework.GuiUtil;
using ITE.Entidades.POCO;
using ITSolution.Framework.Mensagem;
using System.Data;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Validador;
using ITE.Entidades.POCO.Sales;

namespace ITE.DataControl.Company.LSC
{
    public class ProdutoImport
    {
        private static readonly List<String> COLUMNS = 
            new List<string> { "COD_PRO", "GRUPO", "DESC_PRO", "VR_VENDA", "CUSTO", "MARGEM", "UNID", "QTE_PRO" };

        public void ImportToDatabase(DataTable dadosOrigem)
        {
            if (dadosOrigem != null)
            {
                var ctx = new BalcaoContext();
                List<Produto> produtoSave = new List<Produto>();
                int i = 0;
                try
                {
                    Produto pAnt = null;
                    foreach (var produtoItg in dadosOrigem.AsEnumerable())
                    {
                        Produto p = new Produto();
                        p.IdCategoriaProduto = 18;
                        p.CodigoBarras = produtoItg["COD_PRO"].ToString();
                        p.DataCadastro = DateTime.Now;
                        p.DescricaoProduto = produtoItg["DESC_PRO"].ToString();
                        p.IdUnidadeMedidaProduto = 1;
                        p.Observacao = "IMPORTADO SISTEMA LSC";
                        p.PrecoVenda = ParseUtil.ToDecimal(produtoItg["VR_VENDA"]);
                        p.PrecoCompra = ParseUtil.ToDecimal(produtoItg["CUSTO"]);
                        p.QuantidadeProduto = ParseUtil.ToDecimal(produtoItg["QTE_PRO"]);
                        p.MargemLucro = ParseUtil.ToDecimal(produtoItg["MARGEM"]);
                        produtoSave.Add(p);

                        if(pAnt != null)
                        {
                            if (pAnt.DescricaoProduto.Equals(p.DescricaoProduto))
                            {
                                continue;
                            }
                        }
                        if (ValidadorDTO.ValidateWarningAll(p))
                        {
                            bool s = ctx.ProdutoDao.Save(p);
                            pAnt = p;
                            if (s) i++;
                        }
                    }
                    if (produtoSave.Count == i)
                    {
                       XMessageIts.Mensagem("Clientes importados com sucesso!");
                    }
                }
                catch (Exception)
                {

                    throw;
                    
                }
            }
        }

        public void ExportDatabase(GridView gridView, String file)
        {
            try
            {

                //implementar
                ConnectionDbf cdbf = new ConnectionDbf(file);

                var dt = cdbf.GetDataTable();

                var lista = DataGridViewUtil.ConvertToList<Produto>(dt);

                foreach (var item in lista)
                {
                    foreach (var c in COLUMNS)
                    {
                        //terminar
                    }
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }

            //return Task.Run(()delegate);
        }

        public void GetColumnsName(GridView gridView)
        {
            var columns = gridView.Columns;

            foreach (GridColumn item in columns)
            {
                string column = item.Name.Replace("col", "");
                // Console.WriteLine("string " + column + " = \"" + column + "\";" );
                Console.WriteLine("\"" + column + "\",");
            }
        }
        /// <summary>
        /// Exportar os dados do grid para o excel
        /// </summary>
        /// <param name="gridControlimport"></param>
        public void ExportExcel(GridControl gridControl)
        {

            try
            {
                var sv = new SaveFileDialog();
                //caminho temporario
                var path = Application.StartupPath + "\\excel_temp.xlsx";

                gridControl.ExportToXlsx(path);

                Process.Start(path);

            }
            catch (Exception ex)
            {
                LoggerUtilIts.ShowExceptionLogs(ex);
                //throw;
            }

        }


        private static readonly List<String> ALL_COLUMNS = new List<string>{ "COD_PRO",
                                                "GRUPO",
                                                "DESC_PRO",
                                                "NLOJA",
                                                "VR_VENDA",
                                                "CUS_LETRA",
                                                "COD_ORI",
                                                "CUSTO",
                                                "MARGEM",
                                                "TAMANHO",
                                                "INDICE",
                                                "UNID",
                                                "PESO",
                                                "ATIVO",
                                                "FRA_UND",
                                                "FRA_CAP",
                                                "FRA_CUS",
                                                "FRA_CME",
                                                "MINIMO",
                                                "MAXIMO",
                                                "QTE_PRO",
                                                "Q_LCA",
                                                "CMEDIO",
                                                "COD_FOR",
                                                "PROMOC",
                                                "PROMO_POR",
                                                "PROMO_TIP",
                                                "DT_ULT",
                                                "DT_CUSTO",
                                                "FOR_ULT",
                                                "ALT_PRE",
                                                "ALT_CUS",
                                                "PORC",
                                                "REFER",
                                                "PRATELEI",
                                                "BAIXA",
                                                "DISCRIMI",
                                                "VR_TEMP",
                                                "EMBALAG",
                                                "NOVO_CUS",
                                                "NOVO_PRE",
                                                "SUBSTT",
                                                "MPRIMA",
                                                "C1",
                                                "C2",
                                                "MARCA",
                                                "Q_CBARRA1",
                                                "Q_CBARRA2",
                                                "NCM", };
    }
}
