using ITSolution.Framework.Mensagem;
using ITE.Entidades.Repositorio;
using System;
using System.Linq;
using ITE.Entidades.POCO.TI;

namespace ITE.Entidades.DaoManager.TIDaoManager
{
    public class AtendimentoDaoManager
    {
        /// <summary>
        /// O último atendimento agendado
        /// </summary>
        /// <returns>O último registro da tabela</returns> 
        public Atendimento GetLast()
        {
            Atendimento a = new Atendimento();
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    a = ctx.Atendimentos.OrderByDescending(p => p.IdAtendimento).Take(1).First();
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }
            return a;
        }
    }
}
