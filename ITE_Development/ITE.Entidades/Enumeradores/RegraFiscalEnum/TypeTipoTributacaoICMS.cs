using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.Enumeradores.RegraFiscalEnum
{
    /// <summary>
    /// Indicadores para o tipo de tributação do ICMS
    /// </summary>
    public enum TypeTipoTributacaoICMS
    {
        Tributado = 0,
        Outros = 1,
        Diferido = 2,
        Isento = 3,

        [Description("Não incidência")]
        NãoIncidência = 4,

        Suspenso = 5,

        [Description("Sem ICMS")]
        SemICMS = 6

    }
}
