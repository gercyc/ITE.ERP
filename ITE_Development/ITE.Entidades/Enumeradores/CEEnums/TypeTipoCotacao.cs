using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.Enumeradores.CEEnums
{
    public enum TypeTipoCotacao
    {
        [Description("Taxa de conversão padrão")]
        TaxaPadrao = 0,
        [Description("Taxa de conversão frete")]
        TaxaFrete = 1,
        [Description("Outras taxas de conversão")]
        Outras = 2
    }
}
