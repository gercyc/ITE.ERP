using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.Enumeradores.RHEnum
{
    public enum TypeGeracaoFinanceiroFolha
    {
        /// <summary>
        /// Gera 1 lançamento financeiro por competencia
        /// </summary>
        Sintetico = 0,
        /// <summary>
        /// Gera N lançamentos, 1 pra cada funcionario
        /// </summary>
        Analitico = 1
    }
}
