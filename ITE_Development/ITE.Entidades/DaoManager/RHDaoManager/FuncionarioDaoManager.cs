using ITE.Entidades.POCO.RH;
using ITE.Entidades.Repositorio;
using ITE.RH.Enumeradores;
using System;
using System.Linq;

namespace ITE.Entidades.DaoManager.RHDaoManager
{
    public class FuncionarioDaoManager
    {
        public bool SaveFuncionario(Funcionario func)
        {
            using (var ctx = new BalcaoContext())
            {

                func.HistoricoSalarial.Add(new HistoricoSalarial(func.Salario, "Salário Inicial"));

                func.HistoricoSituacao.Add(new HistoricoSituacao(func.IdFilial, DateTime.Today,
                                    TypeSituacaoFuncionario.Admitido, "Admissão"));

                func.HistoricoDepartamento.Add(new HistoricoDepartamento(func.IdDepartamento, "Admissão"));

                func.HistoricoFuncao.Add(new HistoricoFuncao(func.IdFuncao, "Admissão"));

                return ctx.FuncionarioDao.Save(func);
            }

        }

        public bool UpdateFuncionario(Funcionario novo)
        {
            using (var ctx = new BalcaoContext())
            {
                var current = ctx.FuncionarioDao.Find(novo.IdFuncionario);

                current.Update(novo);

                //remova os eventos marcados para remocao.
                RemoveEventos(novo);
                foreach (var evt in current.Eventos)
                {
                    evt.Evento = null; //nulo para nao criar outro evento no banco
                }

                return ctx.FuncionarioDao.Update(current);
            }
        }

        private void RemoveEventos(Funcionario f)
        {
            using(var ctx = new BalcaoContext())
            {
                foreach (var evt in f.Eventos)
                {
                    if (evt.Removed)
                    {
                        var r = ctx.EventosFuncionarioDao.Find(evt.IdRegistro);
                        ctx.EventosFuncionarioDao.Delete(r);
                    }
                }
            }
        }

        public bool FindByCpf(Funcionario func)
        {

            using (var ctx = new BalcaoContext())
            {
                //se existe funcionario
                if (func.IdFuncionario != 0)
                {
                    var f = ctx.FuncionarioDao.Find(func.IdFuncionario);
                    //se o id for diferente entao existe no banco de outra pessoa
                    if (f.CPF == func.CPF && f.IdFuncionario != func.IdFuncionario)
                        return true;
                }
                //nao existe
                else
                {
                    try
                    {
                        ctx.FuncionarioDao.Where(f => f.CPF.Equals(func.CPF)).First();
                        return true;
                    }
                    catch
                    {
                        //na importa
                    }

                }
                return false;
            }


        }
    }
}
