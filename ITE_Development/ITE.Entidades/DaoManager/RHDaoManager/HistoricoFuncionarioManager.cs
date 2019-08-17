using ITE.Entidades.POCO.RH;
using ITE.Entidades.Repositorio;
using ITE.RH.Enumeradores;
using System;

namespace ITE.Entidades.DaoManager.RHDaoManager
{
    public class HistoricoFuncionarioManager
    {

        public bool UpdateSituacao(Funcionario func, HistoricoSituacao historico)
        {
            using (var ctx = new BalcaoContext())
            {

                var current = ctx.FuncionarioDao.Find(func.IdFuncionario);

                current.Situacao = historico.Situacao;
                current.HistoricoSituacao.Add(historico);

                //atualiza o objeto de onde foi chamado
                func.Update(current);

                return ctx.FuncionarioDao.Update(current);
            }
        }

        public bool UpdateSalario(Funcionario func, HistoricoSalarial historico)
        {
            using (var ctx = new BalcaoContext())
            {

                var current = ctx.FuncionarioDao.Find(func.IdFuncionario);

                current.Salario = historico.Salario;
                current.HistoricoSalarial.Add(historico);

                //atualiza o objeto de onde foi chamado
                func.Update(current);

                return ctx.FuncionarioDao.Update(current);
            }
        }

        public bool DemitirFuncionario(Funcionario func, string motivo, Nullable<DateTime> dtDemissao = null)
        {
            using (var ctx = new BalcaoContext())
            {

                var current = ctx.FuncionarioDao.Find(func.IdFuncionario);
                current.Situacao = TypeSituacaoFuncionario.Demitido;

                var historico = new HistoricoSituacao(func.IdFilial,
                    func.DataAdmissao, current.Situacao, motivo);

                historico.DataDemissao = dtDemissao;

                current.HistoricoSituacao.Add(historico);

                return ctx.FuncionarioDao.Update(current);
            }
        }

        public bool UpdateFuncao(Funcionario func, HistoricoFuncao historico)
        {
            using (var ctx = new BalcaoContext())
            {

                var current = ctx.FuncionarioDao.Find(func.IdFuncionario);

                current.IdFuncao = historico.IdFuncao;
                current.HistoricoFuncao.Add(historico);

                //atualiza o objeto de onde foi chamado
                func.Update(current);
                return ctx.FuncionarioDao.Update(current);
            }
        }

        public bool UpdateDepartamento(Funcionario func, HistoricoDepartamento historico)
        {
            using (var ctx = new BalcaoContext())
            {

                var current = ctx.FuncionarioDao.Find(func.IdFuncionario);

                current.IdDepartamento = historico.IdDepartamento;
                current.HistoricoDepartamento.Add(historico);

                return ctx.FuncionarioDao.Update(current);
            }
        }

    }
}
