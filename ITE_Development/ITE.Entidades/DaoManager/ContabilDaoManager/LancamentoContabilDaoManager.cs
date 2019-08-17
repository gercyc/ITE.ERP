using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Mensagem;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.DaoManager.ContabilDaoManager
{
    public class LancamentoContabilDaoManager
    {
        public bool SaveLancamento(LancamentoContabil lancamento)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var clone = lancamento.Clone();
                    var mat = ctx.EmpresaMatrizDao.Find(lancamento.IdMatriz);
                    clone.NumeroLancamento = GetNewLancamentoNumber(mat.CodigoMatriz);
                    clone.Matriz = null;
                    //clone.LoteOrigem = null;
                    clone.Usuario = null;
                    clone.UsuarioAlteracao = null;
                    foreach (var p in clone.Partidas)
                    {
                        //if (p.IdPartida != null)
                        //    p.IdPartida = p.newGuidID();

                        p.CentroCusto = null;
                        p.ContaContabilCredito = null;
                        p.ContaContabilDebito = null;
                        p.LancamentoContabil = null;
                        p.MoedaEstrangeira = null;
                        p.MoedaPrincipal = null;
                        p.Participante = null;
                        //p.IdLancamentoContabil = clone.IdLancamentoContabil;
                    }
                    return ctx.LancamentoContabilDao.Save(clone);
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Ocorreu um erro ao salvar o lançamento.", "Erro");
                return false;
            }
        }

        public bool Update(LancamentoContabil novo)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var current = ctx.LancamentoContabilDao.Find(novo.IdLancamentoContabil);
                    current.Update(novo);
                    ctx.LogTransation(true);
                    var partidaManager = new PartidaoDaoManager();
                    partidaManager.UpdatePartidas(current, novo);
                    ClearRefUpdate(current);
                    return ctx.LancamentoContabilDao.Update(current);
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Ocorreu um erro ao salvar o lote.", "Erro");
                return false;
            }
        }


        public bool UpdateOld(LancamentoContabil novo)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {
                    var current = ctx.LancamentoContabilDao.Find(novo.IdLancamentoContabil);
                    current.Update(novo);

                    //atualizando as partidas
                    //foreach (var pUpdate in current.Partidas)
                    //{
                    //    foreach (var pNew in novo.Partidas.Where(p => p.IdPartida == pUpdate.IdPartida))
                    //    {
                    //        pUpdate.Update(pNew);
                    //    }
                    //}
                    //Adicionando partidas
                    foreach (var p in novo.Partidas.Where(p => p.IdPartida == 0))
                    {
                        //p.IdPartida = Guid.NewGuid();
                        //p.LancamentoContabil = current;
                        //p.IdLancamentoContabil = current.IdLancamentoContabil;


                        var pInclude = new PartidaContabil()
                        {
                            ContaContabilDebito = p.ContaContabilDebito,
                            IdContaContabilDeb = p.IdContaContabilDeb,
                            ContaContabilCredito = p.ContaContabilCredito,
                            IdContaContabilCred = p.IdContaContabilCred,
                            Historico = p.Historico,
                            MoedaPrincipal = p.MoedaPrincipal,
                            IdMoeda = p.IdMoeda,
                            SequencialPartida = p.SequencialPartida,
                            ValorPartida = p.ValorPartida,
                            //LancamentoContabil = current,
                            //IdLancamentoContabil = current.IdLancamentoContabil,
                            LocalizacaoFisDoc = p.Historico,
                            //IdPartida = Guid.NewGuid()
                        };

                        current.Partidas.Add(pInclude);
                    }

                    current.Valor = novo.GetValor();
                    current.ValorDebito = novo.GetValoresDebito();
                    current.ValorCredito = novo.GetValoresCredito();


                    //var debito = ctx.ContaContabilDao.Find(160);
                    //var crebito = ctx.ContaContabilDao.Find(161);
                    //var moeda = ctx.MoedaDao.Find(10);

                    //current.Partidas.Add(pInclude);
                    ClearRefUpdate(current);

                    return ctx.LancamentoContabilDao.Update(current);
                }
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Ocorreu um erro ao salvar o lote.", "Erro");
                return false;
            }
        }


        private void ClearRefUpdate(LancamentoContabil lancamento)
        {
            lancamento.Matriz = null;
            //lancamento.LoteOrigem = null;
            lancamento.Usuario = null;
            lancamento.UsuarioAlteracao = null;
            foreach (var p in lancamento.Partidas)
            {
                p.CentroCusto = null;
                p.ContaContabilCredito = null;
                p.ContaContabilDebito = null;
                //p.LancamentoContabil = null;
                p.MoedaEstrangeira = null;
                p.MoedaPrincipal = null;
                p.Participante = null;
                //p.IdLancamentoContabil = lancamento.IdLancamentoContabil;
            }
        }

        //gerar numero do lancamento, sera <MATRIZ><NUM.SEQUENCE>. EX: ITS000000019
        private string GetNewLancamentoNumber(string codMatriz)
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {

                    var nextNumber = ctx.ConnectionSql.ExecuteQueryDataTable("SELECT NEXT VALUE FOR SEQ_NUM_LANCAMENTO").Rows[0][0];

                    var strNumber = String.Format("{0:000000000}", nextNumber);
                    return codMatriz + strNumber;
                }
            }
            catch (SqlException ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Falha ao obter a numeração do lançamento.", "Erro ao obter sequência");
                return string.Empty;
            }
        }
    }
}
