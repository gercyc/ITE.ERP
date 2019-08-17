using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ITE.Entidades.POCO.CE
{
    /// <summary>
    /// Cálculos dos impostos de importação
    /// </summary>
    public static class ImpostoCusteio
    {
        #region Impostos em ME
        /// <summary>
        /// II em moeda estrangeira
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcIITotalEstrangeira(this Custeio custeio)
        {

            return custeio.IITotalEstrangeira * custeio.ValorMoedaEstrangeira;
        }
        /// <summary>
        /// IPI em moeda estrangeira
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcIPITotalEstrangeira(this Custeio custeio)
        {

            return custeio.IPITotalEstrangeira * custeio.ValorMoedaEstrangeira;
        }
        /// <summary>
        /// PIS em moeda estrangeira
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcPISTotalEstrangeira(this Custeio custeio)
        {

            return custeio.PISTotalEstrangeira * custeio.ValorMoedaEstrangeira;
        }
        /// <summary>
        /// COFINS em moeda estrangeira
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcCofinsTotalEstrangeira(this Custeio custeio)
        {

            return custeio.CofinsTotalEstrangeira * custeio.ValorMoedaEstrangeira;
        }
        /// <summary>
        /// ICMS em moeda estrangeira
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcICMSMoedaEstrangeira(this Custeio custeio)
        {
            return custeio.ICMSTotal * custeio.ValorMoedaEstrangeira;
        }
        /// <summary>
        /// ICMS-ST em moeda estrangeira
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcICMSSTMoedaEstrangeira(this Custeio custeio)
        {
            return custeio.ICMSSTTotal * custeio.ValorMoedaEstrangeira;
        }
        /// <summary>
        /// Capatazia em moeda estrangeira
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcCapataziaEstrangeira(this Custeio custeio)
        {
            return custeio.ValorCapatazia * custeio.ValorMoedaEstrangeira;
        }
        #endregion

        #region Impostos em Reais BRL
        /// <summary>
        /// II em moeda nacional
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcIITotalBrl(this Custeio custeio)
        {
            var vlrII = custeio.ItensCusteio.Sum(i => i.II);
            return vlrII;
        }

        /// <summary>
        /// IPI em moeda nacional
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcIPITotalBrl(this Custeio custeio)
        {
            var vlrIPI = custeio.ItensCusteio.Sum(i => i.IPI);
            return vlrIPI;
        }

        /// <summary>
        /// PIS em moeda nacional
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcPISTotalBrl(this Custeio custeio)
        {
            var vlrPIS = custeio.ItensCusteio.Sum(i => i.PIS);
            return vlrPIS;
        }

        /// <summary>
        /// COFINS em moeda nacional
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcCofinsTotalBrl(this Custeio custeio)
        {
            var vlrCOFINS = custeio.ItensCusteio.Sum(i => i.Cofins);
            return vlrCOFINS;
        }

        /// <summary>
        /// ICMS em moeda nacional
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcICMSTotalBrl(this Custeio custeio)
        {
            var vlrICMS = custeio.ItensCusteio.Sum(i => i.ICMS);
            return vlrICMS;
        }

        /// <summary>
        /// ICMS-ST em moeda nacional
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcICMSSTTotalBrl(this Custeio custeio)
        {
            var vlrICMSST = custeio.ItensCusteio.Sum(i => i.ICMSST);
            return vlrICMSST;
        }

        #endregion

        #region Calculos
        /// <summary>
        /// Valor FOB em moeda nacional
        /// </summary>
        /// <param name="custeio"></param>
        /// <returns></returns>
        public static decimal CalcFobTotal(this Custeio custeio)
        {
            var vlrFobItens = custeio.ItensCusteio.Sum(i => i.TotalFob);
            var vlrFobDespesas = custeio.DespesasCusteio.Sum(i => i.ValorDespesa) * custeio.ValorMoedaEstrangeira;
            return vlrFobItens + vlrFobDespesas;
        }
        
        #endregion



        public static decimal CalcTotalCusteioReais(this Custeio custeio)
        {
            return custeio.TotalCusteio = custeio.ItensCusteio.Sum(i => i.ValorReais);
        }
        public static decimal CalcTotalCusteioME(this Custeio custeio)
        {
            return custeio.ValorMoedaEstrangeira = custeio.ItensCusteio.Sum(i => i.ValorMoedaEstrangeira);
        }
    }
}