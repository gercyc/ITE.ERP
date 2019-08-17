using ITE.Entidades.POCO.RH.Folha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.DaoManager.RHDaoManager
{
    /*
     Arquivo para criar as exceptions customizadas para o fechamento/processos da folha de pagamento ou RH.
         */
    public class CompetenciaExistente : Exception
    {
        public override string Message { get; }
        public CompetenciaExistente()
        {
            this.Message = "Já existe uma competência com o mesmo período e periodicidade cadastrada. Por favor selecione outro período";
        }
    }
    public class GrupoEventoVazio : Exception
    {
        public override string Message { get; }
        public GrupoEventoVazio()
        {
            this.Message = "O grupo de eventos selecionado não possui eventos. Por favor selecione um grupo válido \n ou adione eventos ao grupo selecionado.";
        }
    }
    //public class CompetenciaEventoValorZero : Exception
    //{
    //    public override string Message { get; }
    //    public string Orientacao { get; }
    //    public CompetenciaEventoValorZero(CompetenciaFolha competencia)
    //    {

    //        this.Message = "A competência possui funcionários com eventos lançados com valor zerado. ";
    //        this.Orientacao = "Revise os eventos de cada funcionários para conferir se possui algum com valor 0,00";
    //    }
        
    //}
}
