using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.Enumeradores.RegraFiscalEnum
{
    /// <summary>
    /// Indicadores para o tipo de tributação do IPI
    /// </summary>
    public enum TypeTipoTributacaoIPI
    {

        Tributado = 0,

        [Description("Tributado 50%")]
        Tributado50 = 1,

        [Description("Alíquota zero")]
        AliquotaZero = 2,

        Diferido = 3,

        Isento = 4,

        [Description("Não incidência")]
        NaoIncidencia = 5,

        Outros = 6,

        Suspenso = 7,

        [Description("Sem IPI")]
        SemIpi  = 8,

        Imune = 9

    }
}
