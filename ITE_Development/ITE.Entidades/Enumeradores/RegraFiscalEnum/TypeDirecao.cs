using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.Enumeradores.RegraFiscalEnum
{
    /// <summary>
    /// Indica se é para entrada ou saída. Verificar o tipo da NF, se for do tipo Entrada nao deixar utilizar
    /// um tipo de movimento Saida, e ao contrário tbm.
    /// </summary>
    public enum TypeDirecao
    {
        Entrada = 0,
        Saída = 1
    }
}
