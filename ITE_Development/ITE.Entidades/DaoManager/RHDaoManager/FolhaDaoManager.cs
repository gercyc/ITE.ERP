using ITE.Entidades.POCO;
using ITE.Entidades.POCO.RH.Folha;
using ITE.Entidades.Enumeradores;
using ITE.Entidades.Repositorio;
using ITE.RH.Enumeradores;
using ITSolution.Framework.Mensagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ITSolution.Framework.Util;
using System.Threading.Tasks;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.Enumeradores.RHEnum;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.DaoManager.FinanceiroDaoManager;
using ITSolution.Scheduler.EntidadesBd;
using ITSolution.Scheduler.Manager;
using ITSolution.Scheduler.Repositorio;
using ITSolution.Framework.Beans.Forms;

namespace ITE.Entidades.DaoManager.RHDaoManager
{
    public class FolhaDaoManager : ITSolution.Scheduler.Manager.SchedulerControl
    {
        private SchedulerControl server;
        private TaskIts itsTask;

        public FolhaDaoManager()
        {
            if (this.server == null)
            {
                this.server = new SchedulerControl();
            }
        }
        public FolhaDaoManager(string idTask) : this()
        {
            try
            {
                var ctx = SchedulerContextGeneric<TaskIts>.Instance;
                var ts = ctx.Dao.Find(idTask);
                this.itsTask = ts;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
            }

        }

        #region Metodos privados
        private decimal obtemDiasFolha(TypeTipoFechamentoFolha p_tipoFechamento)
        {
            var qtd = 0M;
            if (p_tipoFechamento == TypeTipoFechamentoFolha.Mensal)
                qtd = 30;
            else if (p_tipoFechamento == TypeTipoFechamentoFolha.Quinzenal)
                qtd = 15;
            else if (p_tipoFechamento == TypeTipoFechamentoFolha.Semanal)
                qtd = 7;

            return qtd;
        }
        private void VerificaSuspensao(bool IsCancellationRequested)
        {
            if (IsCancellationRequested)
                throw new OperationCanceledException();
        }
        //Gerar ficha financeira de cada funcionario.
        private ICollection<FichaFinanceiraFuncionario> GerarFichaFinanceira(FuncionarioCompetencia funcionario, GrupoEvento grupo, TypeTipoFechamentoFolha p_tipoFechamento)
        {
            var dataRef = funcionario.Competencia.DataFinalCompetencia;

            foreach (var evento in grupo.EventosGrupo)
            {
                //salario contratual
                if (evento.Evento.CodigoCalculo == TypeCodigoCalculo.SalarioBase)
                {
                    var qtd = obtemDiasFolha(p_tipoFechamento);

                    var salario = GetSalarioCompetencia(p_tipoFechamento, funcionario);

                    FichaFinanceiraFuncionario fichaFin = new FichaFinanceiraFuncionario(funcionario,
                        evento.Evento, salario, evento.Evento.TipoReferencia, dataRef, qtd);
                    fichaFin.Evento = evento.Evento;
                    if (fichaFin.ValorMovimento > 0M)
                        funcionario.FichaFinanceiraFuncionario.Add(fichaFin);
                }
                //calculo do INSS
                else if (evento.Evento.CodigoCalculo == TypeCodigoCalculo.INSS)
                {
                    FichaFinanceiraFuncionario fichaFin = new FichaFinanceiraFuncionario(
                        funcionarioComp: funcionario,
                        evento: evento.Evento,
                        valor: ValorInss(funcionario),
                        tipoReferencia: evento.Evento.TipoReferencia,
                        dataRef: dataRef,
                        quantidade: GetAliquotaInss(funcionario));

                    fichaFin.Evento = evento.Evento;

                    if (fichaFin.ValorMovimento > 0M)
                        funcionario.FichaFinanceiraFuncionario.Add(fichaFin);
                }
                //valor do FGTS no mês. Aliquota sempre é 8%
                else if (evento.Evento.CodigoCalculo == TypeCodigoCalculo.FGTS)
                {
                    decimal vlrFGTS = (funcionario.Funcionario.Salario * 8) / 100;
                    funcionario.ValorFgts = vlrFGTS;
                    FichaFinanceiraFuncionario fichaFin = new FichaFinanceiraFuncionario(funcionario,
                        evento.Evento, vlrFGTS, evento.Evento.TipoReferencia, dataRef, 8);
                    fichaFin.Evento = evento.Evento;
                    if (fichaFin.ValorMovimento > 0M)
                        funcionario.FichaFinanceiraFuncionario.Add(fichaFin);
                }
                //Valor do IRRF no mês, lanca o evento somente se aliquota for maior que 0
                else if (evento.Evento.CodigoCalculo == TypeCodigoCalculo.IRRF)
                {
                    var aliqIRRF = GetAliquotaIrrf(funcionario);

                    if (aliqIRRF > 0)
                    {
                        decimal vlrIRRF = (funcionario.Funcionario.Salario - ValorInss(funcionario)) *
                                          aliqIRRF / 100;

                        vlrIRRF -= GetDeducaoIrrf(funcionario);

                        FichaFinanceiraFuncionario fichaFin = new FichaFinanceiraFuncionario(funcionario,
                            evento.Evento, vlrIRRF, evento.Evento.TipoReferencia, dataRef, aliqIRRF);
                        fichaFin.Evento = evento.Evento;
                        funcionario.FichaFinanceiraFuncionario.Add(fichaFin);
                    }
                }
                else //qualquer outro codigo de calculo não tratado especificamente igual os acima...
                {
                    FichaFinanceiraFuncionario fichaFin = new FichaFinanceiraFuncionario(
                        funcionarioComp: funcionario,
                        evento: evento.Evento,
                        valor: 0M, //valor eh 0 pq é pra ser editado na folha
                        tipoReferencia: evento.Evento.TipoReferencia,
                        dataRef: dataRef,
                        quantidade: GetAliquotaInss(funcionario));

                    fichaFin.Evento = evento.Evento;
                    funcionario.FichaFinanceiraFuncionario.Add(fichaFin);
                }



            }

            //percorrendo eventos cadastrados para o funcionario
            foreach (var eventoFunc in funcionario.Funcionario.Eventos)
            {
                FichaFinanceiraFuncionario fichaFin = new FichaFinanceiraFuncionario(funcionario,
                        eventoFunc.Evento, eventoFunc.Valor, eventoFunc.Evento.TipoReferencia, dataRef, 0M);
                fichaFin.Evento = eventoFunc.Evento;
                funcionario.FichaFinanceiraFuncionario.Add(fichaFin);
            }

            return funcionario.FichaFinanceiraFuncionario;
        }

        /// <summary>
        /// Obtem a aliquota do inss conforme o salario do funcionario
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        private decimal GetAliquotaInss(FuncionarioCompetencia funcionario)
        {
            using (var ctx = new BalcaoContext())
            {
                var salarioFun = funcionario.Funcionario.Salario;
                var aliquota = 0M;
                var encargos = ctx.FaixaContribuicaoSalarialDao.Where(
                    e => e.TipoContribuicao == TypeEncargoSalarial.INSS
                         && e.ValorInicial <= salarioFun && e.ValorFinal >= salarioFun);

                //se não achou nada, o salario do cara é maior que a faixa dos 11%, então use a aliquota = 11%
                if (encargos.Count() == 0)
                    aliquota = 11M;
                else //senao recupera a aliquota da faixa salarial do sujeito
                    aliquota = encargos.FirstOrDefault().AliquotaEncargo;

                return aliquota;
            }
        }
        /// <summary>
        /// Obtem o valor do INSS do funcionario de acordo com o valor do salario
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        private decimal ValorInss(FuncionarioCompetencia funcionario)
        {
            using (var ctx = new BalcaoContext())
            {
                var dtCompetencia = funcionario.Competencia.DataInicialCompetencia.Date;
                var salarioFun = funcionario.Funcionario.Salario;
                var encargos = ctx.FaixaContribuicaoSalarialDao.Where(
                    e =>
                    (e.TipoContribuicao == TypeEncargoSalarial.INSS && e.VigenciaInicial.Date >= dtCompetencia && e.ValorInicial <= salarioFun && e.ValorFinal >= salarioFun)
                            || (!e.VigenciaFinal.HasValue && e.TipoContribuicao == TypeEncargoSalarial.INSS && e.ValorInicial <= salarioFun && e.ValorFinal >= salarioFun)).FirstOrDefault();

                //se nao achou o engargo para o INSS, o candango paga o TETO
                if (encargos == null)
                {
                    salarioFun = ctx.FaixaContribuicaoSalarialDao
                        .Where(e => e.TipoContribuicao == TypeEncargoSalarial.INSS).OrderBy(e => e.ValorFinal).Last().ValorFinal;
                }
                decimal vlrInss = (salarioFun * GetAliquotaInss(funcionario)) / 100;
                return vlrInss;
            }
        }

        /// <summary>
        /// Obtem o valor da aliquota IRRF do funcionario de acordo com o valor do salario
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        private decimal GetAliquotaIrrf(FuncionarioCompetencia funcionario)
        {
            using (var ctx = new BalcaoContext())
            {

                //pega o salario bruto - vlr inss, pois é contribuicao entao ja deduz no irrf
                var salarioFun = funcionario.Funcionario.Salario - ValorInss(funcionario);

                var aliquota = 0M;

                var encargos = ctx.FaixaContribuicaoSalarialDao.Where(
                    e => e.TipoContribuicao == TypeEncargoSalarial.IRRF
                         && e.ValorInicial <= salarioFun && e.ValorFinal >= salarioFun);

                //se não achou nada, o salario do cara é maior que a faixa dos 11%, então use a aliquota = 11%
                if (encargos.Count() == 0)
                    aliquota = 0M;
                else //senao recupera a aliquota da faixa salarial do sujeito
                    aliquota = encargos.FirstOrDefault().AliquotaEncargo;

                return aliquota;
            }
        }

        /// <summary>
        /// Obtem o valor da deducao do IRRF do funcionario de acordo com o valor do salario.
        /// </summary>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        private decimal GetDeducaoIrrf(FuncionarioCompetencia funcionario)
        {
            using (var ctx = new BalcaoContext())
            {
                //pega o salario bruto - vlr inss, pois é contribuicao entao ja deduz no irrf
                var salarioFun = funcionario.Funcionario.Salario - ValorInss(funcionario);
                var deducao = 0M;
                var encargos = ctx.FaixaContribuicaoSalarialDao.Where(
                    e => e.TipoContribuicao == TypeEncargoSalarial.IRRF
                         && e.ValorInicial <= salarioFun && e.ValorFinal >= salarioFun);

                //se não achou nada, o salario do cara é maior que a faixa dos 11%, então use a aliquota = 11%
                if (encargos.Count() == 0)
                    deducao = 0M;
                else //senao recupera a aliquota da faixa salarial do sujeito
                    deducao = encargos.FirstOrDefault().ValorDeducao;

                return deducao;
            }
        }

        #endregion

        /// <summary>
        /// Executa o calculo da folha de pagamento do periodo selecionado. Insere uma nova competencia, se não houver uma.
        /// Indice: Periodo, TipoFechamento (Indice unico da tabela)
        /// </summary>
        /// <param name="periodo"></param>
        /// <param name="usuario"></param>
        /// <param name="tipoFechamento"></param>
        /// <param name="grupoEvento"></param>
        /// <param name="cts"></param>
        /// <returns></returns>
        public bool ExecutaCalculoFolha2(int id, DateTime periodo, object usuario, object tipoFechamento,
            object grupoEvento, bool considerGrpFunc, CancellationTokenSource cts)
        {
            //base.CreateTask()
            using (var ctx = new BalcaoContext())
            {
                Usuario p_usuario = usuario as Usuario;
                TypeTipoFechamentoFolha p_tipoFechamento = tipoFechamento != null
                    ? (TypeTipoFechamentoFolha)tipoFechamento
                    : TypeTipoFechamentoFolha.Mensal;
                GrupoEvento p_grupoEvento = grupoEvento as GrupoEvento;

                try
                {
                    //busca os funcionarios que irão entrar no calculo da folha
                    var funcionariosFolha = ctx.FuncionarioDao.Where(f => (f.Situacao == TypeSituacaoFuncionario.Admitido
                                                                     || f.Situacao == TypeSituacaoFuncionario.Ferias)
                                                                     && f.DataAdmissao.Date <= periodo)
                                                                     .ToList();
                    //criando a competencia
                    var competencia = new CompetenciaFolha(DataUtil.GetDataFinalDoMes(periodo), p_usuario, p_tipoFechamento);

                    #region validacoes
                    if (funcionariosFolha.Count == 0)
                        throw new Exception("Não foram encontrados funcionários ativos na competência selecionada.");

                    //verifica se ja existe competencia com o mesmo periodo e periodicidade criada.
                    if (IsCompetenciaExistente(competencia))
                    {
                        throw new Exception("Competencia ja existente!");
                    }

                    if (p_grupoEvento.EventosGrupo.Count == 0)
                        throw new GrupoEventoVazio();

                    #endregion

                    //Adiciona um funcionario à competencia
                    funcionariosFolha.ForEach(fu =>
                    {
                        competencia.FuncionariosCompetencia.Add(new FuncionarioCompetencia(fu) { Competencia = competencia });
                    });

                    ICollection<FichaFinanceiraFuncionario> teste;

                    foreach (var funcComp in competencia.FuncionariosCompetencia.ToList())
                    {
                        //verifica se foi cancelada a cada passada no laço
                        VerificaSuspensao(cts.IsCancellationRequested);

                        GrupoEvento grupo;

                        if (considerGrpFunc && funcComp.Funcionario.GrupoDefault != null)
                            grupo = funcComp.Funcionario.GrupoDefault;
                        else
                            grupo = p_grupoEvento;

                        teste = GerarFichaFinanceira(funcComp, grupo, p_tipoFechamento);

                        teste.ToList().ForEach(ff => { funcComp.FichaFinanceiraFuncionario.Add(ff); });
                    }

                    //manipulacao do funcionarioCompetencia, dentro do .ForEach
                    foreach (var funcionario in competencia.FuncionariosCompetencia)
                    {
                        //verifica se foi cancelada a cada passada no laço
                        VerificaSuspensao(cts.IsCancellationRequested);

                        foreach (var ficha in funcionario.FichaFinanceiraFuncionario)
                        {
                            if (ficha.Evento.SomaBaseINSS)
                            {
                                funcionario.ValorBaseInss += ficha.ValorMovimento;
                            }
                            if (ficha.Evento.SomaBaseIRRF)
                            {
                                funcionario.ValorBaseIrrf += ficha.ValorMovimento;
                            }

                            funcionario.ValorAliquotaIrrf = GetAliquotaIrrf(funcionario);

                            //zera a referencia
                            ficha.Evento = null;
                        }
                    }

                    var rt = ctx.CompetenciaFolhaDao.Save(competencia);

                    return rt;

                }
                catch (Exception ex)
                {
                    throw ex;

                    //XMessageIts.Advertencia(ex.Message);
                }
            }
        }

        public bool ExecutaCalculoFolha(DateTime periodo, object usuario, object tipoFechamento,
    object grupoEvento, bool considerGrpFunc, CancellationTokenSource cts)
        {
            
            using (var ctx = new BalcaoContext())
            {
                Usuario p_usuario = usuario as Usuario;
                TypeTipoFechamentoFolha p_tipoFechamento = tipoFechamento != null
                    ? (TypeTipoFechamentoFolha)tipoFechamento
                    : TypeTipoFechamentoFolha.Mensal;
                GrupoEvento p_grupoEvento = grupoEvento as GrupoEvento;

                try
                {
                    server.InsertLogTask(new LogIts(this.itsTask.IdTask, "Buscando funcionarios...."));
                    //busca os funcionarios que irão entrar no calculo da folha
                    var funcionariosFolha = ctx.FuncionarioDao.Where(f => (f.Situacao == TypeSituacaoFuncionario.Admitido
                                                                     || f.Situacao == TypeSituacaoFuncionario.Ferias)
                                                                     && f.DataAdmissao.Date <= periodo)
                                                                     .ToList();
                    //criando a competencia
                    var competencia = new CompetenciaFolha(DataUtil.GetDataFinalDoMes(periodo), p_usuario, p_tipoFechamento);

                    #region validacoes
                    if (funcionariosFolha.Count == 0)
                        throw new Exception("Não foram encontrados funcionários ativos na competência selecionada.");

                    //verifica se ja existe competencia com o mesmo periodo e periodicidade criada.
                    if (IsCompetenciaExistente(competencia))
                    {
                        throw new Exception("Competencia ja existente!");
                    }

                    if (p_grupoEvento.EventosGrupo.Count == 0)
                        throw new GrupoEventoVazio();

                    #endregion

                    //Adiciona um funcionario à competencia
                    server.InsertLogTask(new LogIts(this.itsTask.IdTask, "Adicionando funcionarios na competencia em criacao..."));
                    funcionariosFolha.ForEach(fu =>
                    {
                        competencia.FuncionariosCompetencia.Add(new FuncionarioCompetencia(fu) { Competencia = competencia });
                    });

                    ICollection<FichaFinanceiraFuncionario> teste;

                    foreach (var funcComp in competencia.FuncionariosCompetencia.ToList())
                    {
                        //verifica se foi cancelada a cada passada no laço
                        VerificaSuspensao(cts.IsCancellationRequested);

                        GrupoEvento grupo;

                        if (considerGrpFunc && funcComp.Funcionario.GrupoDefault != null)
                            grupo = funcComp.Funcionario.GrupoDefault;
                        else
                            grupo = p_grupoEvento;

                        teste = GerarFichaFinanceira(funcComp, grupo, p_tipoFechamento);

                        teste.ToList().ForEach(ff => { funcComp.FichaFinanceiraFuncionario.Add(ff); });
                    }

                    //manipulacao do funcionarioCompetencia, dentro do .ForEach
                    foreach (var funcionario in competencia.FuncionariosCompetencia)
                    {
                        //verifica se foi cancelada a cada passada no laço
                        VerificaSuspensao(cts.IsCancellationRequested);

                        foreach (var ficha in funcionario.FichaFinanceiraFuncionario)
                        {
                            if (ficha.Evento.SomaBaseINSS)
                            {
                                funcionario.ValorBaseInss += ficha.ValorMovimento;
                            }
                            if (ficha.Evento.SomaBaseIRRF)
                            {
                                funcionario.ValorBaseIrrf += ficha.ValorMovimento;
                            }

                            funcionario.ValorAliquotaIrrf = GetAliquotaIrrf(funcionario);

                            //zera a referencia
                            ficha.Evento = null;
                        }
                    }
                    server.InsertLogTask(new LogIts(this.itsTask.IdTask, "Gravando dados...."));
                    var rt = ctx.CompetenciaFolhaDao.Save(competencia);
                    server.InsertLogTask(new LogIts(this.itsTask.IdTask, "Finalizando processo..."));
                    server.InsertLogTask(new LogIts(this.itsTask.IdTask, competencia.FuncionariosCompetencia.Count +
                        " funcionarios na competencia criada.."));

                    server.InsertLogTask(new LogIts(this.itsTask.IdTask, "Processo finalizado."));
                    return rt;

                }
                catch (Exception ex)
                {
                    throw ex;

                    //XMessageIts.Advertencia(ex.Message);
                }
            }
        }


        /// <summary>
        /// Salva a edição da competência da tela.
        /// </summary>
        /// <param name="novaCompetencia"></param>
        /// <param name="movsRemovidos"></param>
        /// <returns></returns>
        public bool SalvarMovimentoEditado(CompetenciaFolha novaCompetencia, List<FichaFinanceiraFuncionario> movsRemovidos = null)
        {
            try
            {
                //verifica se a competencia é valida. se não é retorne falso
                if (!IsCompetenciaValid(novaCompetencia))
                    return false;

                using (var ctx = new BalcaoContext())
                {
                    var compCurrent = ctx.CompetenciaFolhaDao.Find(novaCompetencia.IdCompetencia);

                    //se a qtd de itens for igual, somente atualize cada item
                    if (compCurrent.FuncionariosCompetencia.Count == novaCompetencia.FuncionariosCompetencia.Count)
                    {

                        foreach (var func in compCurrent.FuncionariosCompetencia)
                        {
                            if (movsRemovidos.Count > 0)
                            {
                                foreach (var evtRemovidos in movsRemovidos)
                                {
                                    var del = compCurrent.FuncionariosCompetencia.ToList()
                                        .Where(funcR => funcR.IdFuncionarioCompetencia ==
                                                        evtRemovidos.IdFuncionarioCompetencia)
                                        .FirstOrDefault()
                                        .FichaFinanceiraFuncionario
                                        .Where(fic => fic.IdFichaFinanFunc == evtRemovidos.IdFichaFinanFunc)
                                        .FirstOrDefault();
                                    ctx.FichaFinanceiraFuncionarioDao.Delete(del);
                                }
                            }
                            // \/
                        }

                        foreach (var funcCompCurrent in compCurrent.FuncionariosCompetencia)
                        {
                            //atualiza os valores do funcionario da competencia em edicao
                            funcCompCurrent
                                .Update(novaCompetencia.FuncionariosCompetencia
                                    .Where(fc => fc.IdFuncionarioCompetencia == funcCompCurrent.IdFuncionarioCompetencia)
                                    .FirstOrDefault());

                            //percorre a ficha financeira do funcionario e atualiza cada evento com o valor novo
                            foreach (var ficha in funcCompCurrent.FichaFinanceiraFuncionario)
                            {
                                var fichaNova = novaCompetencia.FuncionariosCompetencia
                                    .Where(f => f.IdCompetencia == funcCompCurrent.IdCompetencia
                                            && f.IdFuncionarioCompetencia == funcCompCurrent.IdFuncionarioCompetencia)
                                            .FirstOrDefault().FichaFinanceiraFuncionario
                                    .Where(fi => fi.IdFuncionarioCompetencia == funcCompCurrent.IdFuncionarioCompetencia
                                    && fi.IdEvento == ficha.IdEvento)
                                    .FirstOrDefault();
                                if (fichaNova != null)
                                    ficha.Update(fichaNova);
                                else
                                {
                                    fichaNova = novaCompetencia.FuncionariosCompetencia
                                    .Where(f => f.IdCompetencia == funcCompCurrent.IdCompetencia
                                            && f.IdFuncionarioCompetencia == funcCompCurrent.IdFuncionarioCompetencia)
                                            .FirstOrDefault().FichaFinanceiraFuncionario
                                    .Where(fi => fi.IdFuncionarioCompetencia == funcCompCurrent.IdFuncionarioCompetencia
                                    && fi.IdFichaFinanFunc == 0 && fi.IdEvento == ficha.IdEvento)
                                    .FirstOrDefault();

                                    //funcCompCurrent.FichaFinanceiraFuncionario.Add(fichaNova);
                                }

                            }

                        }
                    }
                    return ctx.CompetenciaFolhaDao.Update(compCurrent);
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionJustMessage(ex);
                return false;
            }

        }
        /// <summary>
        /// Obtem o valor do salario conforme o tipo de fechamento da competencia.
        /// </summary>
        /// <param name="tipoFechcompetencia"></param>
        /// <param name="funcionario"></param>
        /// <returns></returns>
        public decimal GetSalarioCompetencia(TypeTipoFechamentoFolha tipoFechcompetencia, FuncionarioCompetencia funcionario)
        {
            var salarioFechamento = 0M;
            var func = funcionario.Funcionario;
            //se for mensal, serao 30 dias trabalhados
            if (tipoFechcompetencia == TypeTipoFechamentoFolha.Mensal && func.TipoRecebimento == TypeRecebimento.Mensalista)
            {
                salarioFechamento = func.Salario;
                return salarioFechamento;
            }
            //[...] quinzenal, 15 dias...
            else if (tipoFechcompetencia == TypeTipoFechamentoFolha.Quinzenal && func.TipoRecebimento == TypeRecebimento.Mensalista)
            {
                salarioFechamento = (func.Salario / 30) * 15;
                return salarioFechamento;
            }
            //[...] e semanal 7 dias trabalhados
            else if (tipoFechcompetencia == TypeTipoFechamentoFolha.Semanal && func.TipoRecebimento == TypeRecebimento.Mensalista)
            {
                salarioFechamento = (func.Salario / 30) * 7;
                return salarioFechamento;
            }
            //se nenhum acima, retorna o salario
            else
                return func.Salario;
        }
        /// <summary>
        /// Obtem data source para o relatorio
        /// </summary>
        /// <param name="idCompetencia"></param>
        /// <returns></returns>
        public IQueryable GetDataSource(int idCompetencia)
        {
            using (var ctx = new BalcaoContext())
            {
                return ctx.CompetenciaFolhaDao.Where(c => c.IdCompetencia == idCompetencia);
            }
        }
        public bool EncerramentoCompetencia(CompetenciaFolha competencia, bool gerarFinanceiro = false)
        {

            try
            {

                //verifica se a competencia é valida. se não é retorne falso
                if (!IsCompetenciaValid(competencia))
                    return false;

                using (var ctx = new BalcaoContext())
                {

                    var compUpdate = ctx.CompetenciaFolhaDao.Find(competencia.IdCompetencia);

                    compUpdate.DataFechamento = DateTime.Now;
                    compUpdate.ValorLiquidoFechamento = compUpdate.FuncionariosCompetencia.Sum(f => f.ValorLiquido);

                    compUpdate.Status = gerarFinanceiro == true ? TypeStatusCompetencia.EncerradaFinanceiro : TypeStatusCompetencia.Encerrada;

                    var ok = ctx.CompetenciaFolhaDao.Update(compUpdate);
                    if (ok)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
                return false;
            }

        }
        public decimal GetLiquidoCompetencia(CompetenciaFolha competencia)
        {

            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var compUpdate = ctx.CompetenciaFolhaDao.Find(competencia.IdCompetencia);

                    var valorLiquidoFolha = compUpdate.FuncionariosCompetencia.Sum(f => f.ValorLiquido);
                    return valorLiquidoFolha;
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
                return 0M;
            }


        }
        /// <summary>
        /// Obtem a lista com todas as competencias que estao em edicao/pendente de fechamento.
        /// </summary>
        /// <returns></returns>
        public List<CompetenciaFolha> GetCompetenciasEmEdicao()
        {
            using (var ctx = new BalcaoContext())
            {
                try
                {
                    var listComp = ctx.CompetenciaFolhaDao.Where(c => c.Status == TypeStatusCompetencia.EmEdicao);
                    return listComp.ToList();
                }
                catch (Exception)
                {
                    //lista vazia
                    return new List<CompetenciaFolha>();
                }

            }
        }
        /// <summary>
        /// Verifica se existe uma competencia. Retorna TRUE se exisir, FALSE se não encontrar
        /// </summary>
        /// <param name="competencia"></param>
        /// <returns></returns>
        public bool IsCompetenciaExistente(CompetenciaFolha competencia)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    //localiza a competencia
                    var comp = ctx.CompetenciaFolhaDao.Where(c => c.Periodo == competencia.Periodo && c.TipoFechamento == competencia.TipoFechamento).First();

                    //se encontrou, dispara exception e retorna falso, indica que nao pode continuar com o fechamento.
                    if (comp != null)
                    {
                        throw new CompetenciaExistente();
                    }

                    return false;
                }
            }
            catch (CompetenciaExistente)
            {
                //XMessageIts.Advertencia(compEx.Message);
                return true;
            }
            catch (Exception)
            {
                //se o First retornou exception indica que nao encontrou nada, então deixa continuar.
                return false;
            }

        }
        /// <summary>
        /// Verifica se a competencia para salvar/atualizar é valida. 
        /// Regra 1: Todos os eventos devem possuir valor > 0
        /// </summary>
        /// <param name="competencia"></param>
        /// <returns></returns>
        public bool IsCompetenciaValid(CompetenciaFolha competencia)
        {
            var funcFichaInvalida = new List<FuncionarioCompetencia>();

            foreach (var funcionario in competencia.FuncionariosCompetencia)
            {
                var r = funcionario.FichaFinanceiraFuncionario.Where(f => f.ValorMovimento <= 0).FirstOrDefault();

                if (r != null)
                {
                    funcFichaInvalida.Add(funcionario);
                }
            }

            if (funcFichaInvalida.Count > 0)
            {
                XFrmOptionPane.ShowListTextArea(funcFichaInvalida, "Funcionários com algum evento de valor zerado. Por favor verifique.");
                return false;
            }
            return true;
        }

        public bool ExcluirCompetencia(CompetenciaFolha competencia)
        {

            try
            {
                using (var ctx = new BalcaoContext())
                {

                    foreach (var funcionario in competencia.FuncionariosCompetencia)
                    {
                        foreach (var fichaFuncionario in funcionario.FichaFinanceiraFuncionario)
                        {
                            var fichaRemover = ctx.FichaFinanceiraFuncionarioDao.Find(fichaFuncionario.IdFichaFinanFunc);
                            ctx.FichaFinanceiraFuncionarioDao.Delete(fichaRemover);
                        }
                        var funcRemover = ctx.FuncionarioCompetenciaDao.Find(funcionario.IdFuncionarioCompetencia);
                        ctx.FuncionarioCompetenciaDao.Delete(funcRemover);
                    }

                    var compRemover = ctx.CompetenciaFolhaDao.Find(competencia.IdCompetencia);
                    var ok = ctx.CompetenciaFolhaDao.Delete(compRemover);

                    if (ok)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
                return false;
            }

        }
        public bool ReabrirCompetencia(CompetenciaFolha competencia)
        {

            try
            {

                //verifica se a competencia é valida. se não é retorne falso
                if (!IsCompetenciaValid(competencia))
                    return false;

                using (var ctx = new BalcaoContext())
                {

                    var compUpdate = ctx.CompetenciaFolhaDao.Find(competencia.IdCompetencia);

                    compUpdate.DataFechamento = null;
                    //compUpdate.ValorLiquidoFechamento = compUpdate.FuncionariosCompetencia.Sum(f => f.ValorLiquido);
                    compUpdate.Status = TypeStatusCompetencia.EmEdicao;

                    var ok = ctx.CompetenciaFolhaDao.Update(compUpdate);
                    if (ok)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessage(ex);
                return false;
            }

        }

        public async Task<bool> GerarFinanceiro(ParamsGerarFinanceiro parametros)
        {
            int success = 1;
            int saveOk = 0;
            var competencia = parametros.Competencia;
            var lancamentoManager = new LancamentoDaoManager();

            List<LancamentoFinanceiro> lancamentosFinanceiros = new List<LancamentoFinanceiro>();

            #region processamento/criacao dos lancs. financeiros
            if (parametros.TipoGeracao == TypeGeracaoFinanceiroFolha.Analitico)
            {
                foreach (var funcionario in competencia.FuncionariosCompetencia)
                {
                    var nome = funcionario.Funcionario.NomeFuncionario;

                    LancamentoFinanceiro l = new LancamentoFinanceiro()
                    {
                        DataLancamento = parametros.Data,
                        IdCliFor = parametros.CliFor.IdCliFor,
                        IdCentroCusto = parametros.CentroCusto.IdCentroCusto,
                        IdFilial = parametros.Filial.IdFilial,
                        DataPagamento = parametros.Data,
                        DataVencimento = parametros.DataVencimento,
                        Observacao = "Pagamento funcionario " + nome + " periodo " + competencia.Periodo,
                        QuantidadeAnexos = 0,
                        RecCreatedBy = parametros.Usuario.IdUsuario,
                        RecCreatedDate = DateTime.Now,
                        TipoLancamento = TypeLancamentoFinanceiro.Pagar,
                        DiasPrazo = DataUtil.CalcularDias(parametros.Data, parametros.DataVencimento),
                        StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto,
                        ValorLancamento = funcionario.ValorLiquido,
                        SequencialParcela = success
                    };
                    lancamentosFinanceiros.Add(l);
                    success++;
                }
            }
            else
            {
                LancamentoFinanceiro l = new LancamentoFinanceiro()
                {
                    DataLancamento = parametros.Data,
                    IdCliFor = parametros.CliFor.IdCliFor,
                    IdCentroCusto = parametros.CentroCusto.IdCentroCusto,
                    IdFilial = parametros.Filial.IdFilial,
                    DataVencimento = parametros.DataVencimento,
                    Observacao = "Pagamento folha periodo " + competencia.Periodo,
                    QuantidadeAnexos = 0,
                    RecCreatedBy = parametros.Usuario.IdUsuario,
                    RecCreatedDate = DateTime.Now,
                    TipoLancamento = TypeLancamentoFinanceiro.Pagar,
                    DiasPrazo = DataUtil.CalcularDias(parametros.Data, parametros.DataVencimento),
                    StatusLancamento = TypeStatusLancamentoFinanceiro.Aberto,
                    ValorLancamento = competencia.ValorLiquidoFechamento.Value,
                    SequencialParcela = 1
                };
                lancamentosFinanceiros.Add(l);
            }
            #endregion

            //se a lista foi preenchida com os lancamentos financeiros, grave cada um no banco
            if (lancamentosFinanceiros.Count > 0)
            {
                using (var ctx = new BalcaoContext())
                {
                    foreach (var lancFinanceiro in lancamentosFinanceiros)
                    {
                        var result = await ctx.LancamentoFinanceiroDao.SaveAsync(lancFinanceiro);

                        if (result)
                            saveOk++;
                    }

                    //se foi tudo salvo ok, verifica se foi marcado para baixar os lancamentos e os baixe.
                    if (saveOk == lancamentosFinanceiros.Count)
                    {
                        if (parametros.BaixarLancamento)
                        {
                            lancamentoManager.BaixarLancamentos(lancamentosFinanceiros, parametros.ContaBancaria,
                                parametros.DataBaixa, parametros.FormaPagamento);
                        }
                        //atualiza a competencia informando que teve seus lancamentos gerados
                        var compCurrent = ctx.CompetenciaFolhaDao.Find(competencia.IdCompetencia);
                        if (compCurrent.Status == TypeStatusCompetencia.Encerrada)
                            compCurrent.Status = TypeStatusCompetencia.EncerradaFinanceiro;

                        ctx.CompetenciaFolhaDao.Update(compCurrent);

                        return true;
                    }
                }
            }
            return false;

        }
        public class ParamsGerarFinanceiro
        {
            public EmpresaFilial Filial { get; set; }
            public CompetenciaFolha Competencia { get; set; }
            public DateTime Data { get; set; }
            public DateTime DataVencimento { get; set; }
            public CliFor CliFor { get; set; }
            public CentroCusto CentroCusto { get; set; }
            public TypeGeracaoFinanceiroFolha TipoGeracao { get; set; }
            public Usuario Usuario { get; set; }


            #region dados financeiros
            public bool BaixarLancamento { get; set; }
            public DateTime DataBaixa { get; set; }
            public ContaBancaria ContaBancaria { get; set; }
            public FormaPagamento FormaPagamento { get; set; }
            #endregion
        }

    }
}
