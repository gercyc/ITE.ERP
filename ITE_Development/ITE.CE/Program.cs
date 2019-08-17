using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITE.CE.Forms.View;
using ITE.Entidades.DaoManager.CEManager;
using ITE.Entidades.Enumeradores.CEEnums;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.CE;
using ITE.Entidades.Repositorio;

namespace ITE.CE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var ctx = new BalcaoContext())
            {
                Application.Run(new XFrmCusteio(ctx.CusteioDao.First()));
            }
        }


        public static void testeSave()
        {
            using (var ctx = new BalcaoContext())
            {
                var custeio = new Custeio
                {
                    IdCliente = ctx.CliForDao.First().IdCliFor,
                    IdUsuario = ctx.UsuarioDao.First().IdUsuario,
                    DataCalculo = DateTime.Now,
                    NumeroProcesso = "ITS0001",
                    ValorFobTotal = 100,
                    ValorCapatazia = 800,
                    ValorCif = 100,
                    Fabricante = "RF Valves, Hanover, MD, USA – 21079",
                    Exportador = "RF Valves, Hanover, MD, USA – 21079",
                    Incoterms = "N/A",
                    PortoOrigem = "BALTIMORE",
                    PortoDestino = "SANTOS",
                    PaisOrigem = "UNITED STATE",
                    PaisDestino = "GERMANY",
                    Observacao = "NADA A DECLARAR",
                    ValorMoedaReais = 3.254m,
                    ValorMoedaEstrangeira = 1,
                    QuantideContainer = 1,
                    Container = "20 DRY",
                    PISTotal = 10,
                    CofinsTotal = 10,
                    ICMSTotal = 10,
                    IITotal = 10,
                    IPITotal = 10,
                    ICMSSTTotal = 100,
                    TotalCusteio = 100
                };

                custeio.ItensCusteio.Add(new ItemCusteio("84818093",
                    "Vale VGR (Progen) - RFV1976 - PFF Filtration",
                    1000, 1, 10, 100, 3.254M, 18, 18, 1, 18
                    ));

               custeio.DespesasCusteio.Add(new DespesaCusteio("Frete Internacional", 575, 0, TypeDespesaCusteio.Aduaneira));

                custeio.CotacoesMoeda.Add(new CotacaoCusteio()
                {
                    IdMoeda = 1,
                    ValorMoeda = 3.33m,
                    DataCotacao = DateTime.Now.Date,
                    TipoCotacao = TypeTipoCotacao.Outras
                });

                var manager = new CusteioDaoManager();
                manager.SaveUpdate(custeio);

                var current = ctx.CusteioDao.Last();
          

                custeio.ItensCusteio.Add(new ItemCusteio("84818093",
                "Vale VGR (Progen) - RFV1976 - PFF Filtration",
                1000, 1, 10, 100, 3.254M, 18, 18, 1, 18
                ));

                 custeio.DespesasCusteio.Add(new DespesaCusteio("Seguro", 
                     360, 0, TypeDespesaCusteio.Aduaneira));

          
                manager.SaveUpdate(current);
            }


        }
    }
}
