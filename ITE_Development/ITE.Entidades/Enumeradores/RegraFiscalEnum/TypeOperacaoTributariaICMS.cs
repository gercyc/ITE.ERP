using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.Enumeradores.RegraFiscalEnum
{
    /// <summary>
    /// Indica se é alguma situação especial de ICMS
    /// </summary>
    public enum TypeOperacaoTributariaICMS
    {
        [Description("Não se aplica")]
        NaoSeAplica = 0,
        [Description("Substituição tributária")]
        SubstituicaoTributaria = 1,
        [Description("Diferencial de alíquota")]
        Difal = 2
    }
}
