using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using ITE.Entidades.DaoManager.VendasDaoManager;
using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.Repositorio;
using ITSolution.Framework.Enumeradores;
using ITSolution.Framework.Mensagem;
using System.Transactions;
using System.Data.SqlClient;
using ITE.Entidades.Enumeradores.RegraFiscalEnum;
using ITSolution.Scheduler.Manager;
using System.ServiceModel;

namespace ITE.Entidades.DaoManager.FiscalDaoManager
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class MovimentoDaoManager : IMovimentoDaoManager, IDisposable
    {
        public bool UpdateMovimentoFiscal(Movimento movimento, Movimento novoMovimento, List<ItemMovimento> itensRemovidos, Usuario user)
        {
            using (var ctx = new BalcaoContext())
            {

                try
                {
                    ctx.Database.Log = Console.WriteLine;

                    var nf = ctx.MovimentoSet.Find(movimento.IdMovimento);//recupera a NF do banco
                    var itemNfDaoManager = new ItemMovimentoDaoManager();
                    var impostoItemMovDaoManager = new ImpostoItemMovimentoDaoManager();
                    var itensNota = movimento.ItensMovimento.ToList();

                    if (movimento.TipoMovimento.GerarFaturamento)
                    {
                        //vou mexer nas parcelas somente se houver alteracao da forma de pagamento
                        if (movimento.IdFormaPagamento != novoMovimento.IdFormaPagamento)
                        {
                            nf.Parcelas.ToList().ForEach(ctx.LancamentoFinanceiroDao.Entry.SetStateDeleted);
                            //limpa as parcelas
                            nf.Parcelas.Clear();

                            ctx.MovimentoDao.Update(nf);

                            //cria as parcelas
                            nf.GerarParcelas(novoMovimento);
                        }
                        //atualizar as parcelas
                        else
                        {
                            nf.Parcelas.ToList().ForEach(p => p.Update(novoMovimento));
                        }
                    }

                    //atualiza tudo da nota
                    nf.Update(novoMovimento, true);



                    var clone = nf.Clone(nf);

                    impostoItemMovDaoManager.UpdateItens(nf, novoMovimento, ctx);
                    itemNfDaoManager.UpdateItens(nf, novoMovimento, ctx);


                    nf.CalculaValoresIcms();

                    //persiste no banco
                    nf.CliFor = null;// ctx.CliForDao.Find(nf.IdCliFor);
                    nf.CentroCusto = null;// ctx.CentroCustoDao.Find(nf.IdCentroCusto);
                    nf.EmpresaFilial = null;//ctx.EmpresaFilialDao.Find(nf.IdFilial);
                    nf.FormaPagamento = null;//ctx.FormaPagamentoDao.Find(nf.IdFormaPagamento);
                    nf.ModeloDocumentoFiscal = null;//ctx.ModeloDocumentoFiscalDao.Find(nf.IdModelo);
                    nf.SituacaoDocumentoFiscal = null;//ctx.SituacaoDocumentoFiscalDao.Find(nf.IdSituacao);
                    nf.Usuario = null;//ctx.UsuarioDao.Find(nf.IdUsuario);
                    nf.TipoMovimento = null;//ctx.TipoMovimento.Find(nf.IdTipoMovimento);
                    nf.LocalEstoque = null;


                    var traUpdate = ctx.MovimentoDao.Update(nf);

                    if (traUpdate)
                    {
                        itensRemovidos.ForEach(ir => nf.ItensMovimento.ToList().Remove(ir));

                        XMessageIts.Mensagem("Nota fiscal atualizada com sucesso!", "SUCESSO!!", MessageBoxIcon.Information);
                        new ProdutoDaoManager().AddMovimentacaoProduto(nf, nf.IdMovimento, true);
                    }
                    return traUpdate;
                }
                catch (Exception ex)
                {
                    XMessageIts.ExceptionMessage(ex);
                    return false;
                }

            }
        }


        public bool SalvarMovimento(Movimento movimento)
        {
            using (var ctx = new BalcaoContext())
            {

                try
                {
                    var movSave = movimento.Clone(movimento);

                    if (movimento.TipoMovimento != null && movimento.TipoMovimento.GeraMovimentoFiscal)
                    {
                        //cria os impostos
                        movSave.ItensMovimento.ToList().ForEach(it => { CriarImpostosItemNF(it); });
                        //calcula o icms que fica na capa
                        movSave.CalculaValoresIcms();
                    }

                    //cancela as referencias para o Save
                    CancelarReferenciaNfInclusao(movSave);

                    var transaction = ctx.MovimentoDao.Save(movSave);

                    if (transaction)
                    {
                        new ProdutoDaoManager().AddMovimentacaoProduto(movimento, movSave.IdMovimento);
                        XMessageIts.Mensagem("Nota fiscal cadastrada com sucesso!", "SUCESSO!!",
                            MessageBoxIcon.Information);

                    }
                    return transaction;
                }
                catch (DbUpdateException db)
                {
                    XMessageIts.ExceptionMessageDetails(db,
                        "Dados em duplicidade! Vefique todos os campos e se já não existe uma nota fiscal com os mesmos dados!");
                    return false;
                }
                catch (Exception ex)
                {
                    XMessageIts.ExceptionMessageDetails(ex, "Ocorreu um erro na inclusão/atualização da nota fiscal");
                    return false;
                }
            }
        }
        public bool TransferirEstoque(List<Movimento> movimentos)
        {

            try
            {
                using (
                    TransactionScope ts =
                    new TransactionScope(TransactionScopeOption.Required,
                                        new TransactionOptions { IsolationLevel = IsolationLevel.Serializable }))
                {
                    var i = 0;
                    var result = false;
                    foreach (var movimento in movimentos)
                    {
                        if (movimento.TipoMovimento != null && movimento.TipoMovimento.GeraMovimentoFiscal)
                        {
                            //cria os impostos
                            movimento.ItensMovimento.ToList().ForEach(it => { CriarImpostosItemNF(it); });
                            //calcula o icms que fica na capa
                            movimento.CalculaValoresIcms();
                        }

                        //cancela as referencias para o Save
                        CancelarReferenciaNfInclusao(movimento);
                        var ctx = new BalcaoContext();
                        var transaction = ctx.MovimentoDao.Save(movimento);

                        if (transaction)
                        {
                            new ProdutoDaoManager().AddMovimentacaoProduto(movimento, movimento.IdMovimento);
                            i++;
                        }
                    }

                    if (i == movimentos.Count)
                    {

                        ts.Complete();
                        result = true;
                    }

                    return result;
                }
            }
            catch (DbUpdateException db)
            {
                XMessageIts.ExceptionMessageDetails(db,
                    "Dados em duplicidade! Vefique todos os campos e se já não existe uma nota fiscal com os mesmos dados!");
                return false;
            }
            catch (Exception ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Ocorreu um erro na inclusão/atualização da nota fiscal");
                return false;
            }

        }

        #region Validações do movimento fiscal
        /// <summary>
        /// Valida a nota fiscal e retorna a lista de erros
        /// </summary>
        /// <param name="nota"></param>
        /// <returns></returns>
        public List<string> ValidarNotaFiscalInclusao(Movimento nota, FormTypeAction acao)
        {
            List<string> listaErros = new List<string>();
            var msg = "";

            //se a chave nao for valida, adicione a mensagem a lista de erros da validacao
            if (!ValidaTamanhoChaveAcesso(nota))
            {
                msg = "Tamanho da chave de acesso menor que 44 caracteres!";
                listaErros.Add(msg);
            }

            foreach (var item in nota.ItensMovimento)
            {
                //valida a regra fiscal
                if (!ValidarRegraFiscal(item))
                {
                    msg = "Regra fiscal não informada! Verifique todos os itens!";
                    listaErros.Add(msg);
                }
                //valida a operação
                if (!ValidaOperacaoEntradaSaida(nota.DirecaoMovimento, item.RegraFiscal))
                {
                    msg = "Operação inválida! Tipo da nota é de 'Saída' mas o tipo de movimento escolhido e para 'Entrada'.";
                    listaErros.Add(msg);
                }
                //valida o CFOP
                if (!ValidarCFOP(item))
                {
                    msg = "CFOP inválido ou não informado! Verifique todos os itens!";
                    listaErros.Add(msg);
                }

            }

            //validar o numero da nota somente se estiver criando uma nova. casos de update nao é necessario validar este ponto.
            if (acao != FormTypeAction.Visualizar)
            {
                string nfNum = ValidarNumeroNotaFiscal(nota);

                if (nfNum != null)
                    listaErros.Add(nfNum);
            }

            return listaErros;
        }
        public string ValidarNumeroNotaFiscal(Movimento nota)
        {
            var ctx = new BalcaoContext();

            try
            {
                if (string.IsNullOrWhiteSpace(nota.NumeroMovimento))
                    return "Informe o número da nota fiscal";

                var r = ctx.MovimentoSet.Where(n => n.NumeroMovimento == nota.NumeroMovimento).First();

                return "Número da fiscal " + r.NumeroMovimento + " já existe.";

            }
            catch (Exception)
            {

                return null;
            }
        }
        private bool ValidaOperacaoEntradaSaida(TypeDirecao direcaoNota, RegraFiscal tipoMovimento)
        {
            var operValida = true;
            if (tipoMovimento != null)
            {
                //se o tipo da nota for saida e tipo Movimento for entrada: falso
                if (direcaoNota == TypeDirecao.Saída && tipoMovimento.TipoNatureza == Entidades.Enumeradores.RegraFiscalEnum.TypeDirecao.Entrada)
                    operValida = false;
                else if (direcaoNota == TypeDirecao.Entrada && tipoMovimento.TipoNatureza == Entidades.Enumeradores.RegraFiscalEnum.TypeDirecao.Saída)
                    operValida = false;
            }
            return operValida;
        }
        private bool ValidaTamanhoChaveAcesso(Movimento notaChave)
        {
            var chaveValida = true;
            //somente se for modelo 55
            if (notaChave.IdModelo == 31)
            {
                if (notaChave.ChaveAcessoNf.Length < 44)
                    chaveValida = false;
            }

            return chaveValida;
        }
        private bool ValidarCFOP(ItemMovimento item)
        {
            var cfopValido = true;
            if (item.Cfop == null && item.IdCfop == 0 && item.IdCfop == null)
            {
                cfopValido = false;
            }
            return cfopValido;
        }
        private bool ValidarRegraFiscal(ItemMovimento item)
        {
            var regraValida = true;
            if (item.RegraFiscal == null)
            {
                regraValida = false;
            }
            return regraValida;
        }
        #endregion

        public Movimento CancelarReferenciaNfInclusao(Movimento notaInclusao)
        {
            notaInclusao.EmpresaFilial = null;
            notaInclusao.CliFor = null;
            notaInclusao.ModeloDocumentoFiscal = null;
            notaInclusao.SituacaoDocumentoFiscal = null;
            notaInclusao.CentroCusto = null;
            notaInclusao.FormaPagamento = null;
            notaInclusao.Usuario = null;
            notaInclusao.TipoMovimento = null;
            notaInclusao.LocalEstoque = null;
            foreach (var item in notaInclusao.ItensMovimento)
            {
                item.Produto = null;
                item.Cfop = null;
                item.RegraFiscal = null;

                foreach (var imposto in item.ImpostosItemMovimento)
                {
                    imposto.TipoImposto = null;
                    imposto.SituacaoTributaria = null;
                }
            }
            return notaInclusao;
        }

        public void RemoveImpostosItemEdicao(ItemMovimento item)
        {
            var ctx = new BalcaoContext();

            foreach (var imposto in item.ImpostosItemMovimento)
            {
                var impRem = ctx.ImpostoItemMovimentoDao.Find(imposto.IdItemImposto);
                ctx.ImpostoItemMovimentoDao.Delete(impRem);
                item.ImpostosItemMovimento.Remove(impRem);
            }
        }
        public void CriarImpostosItemNF(ItemMovimento item)
        {
            foreach (var impostoTipoMov in item.RegraFiscal.ImpostosRegraFiscal)
            {
                ImpostoItemMovimento impostoAdd = new ImpostoItemMovimento();
                impostoAdd.Aliquota = impostoTipoMov.Aliquota;
                impostoAdd.BaseCalculo = item.TotalItem;
                impostoAdd.IdCst = impostoTipoMov.IdCst;
                impostoAdd.SituacaoTributaria = impostoAdd.SituacaoTributaria;
                impostoAdd.IdImposto = impostoTipoMov.IdImposto;
                impostoAdd.TipoImposto = impostoTipoMov.TipoImposto;
                impostoAdd.TpSitImposto = impostoTipoMov.TipoLancImposto;
                impostoAdd.ValorImposto = impostoAdd.CalcularVlrImposto();
                impostoAdd.SituacaoTributaria = impostoTipoMov.SituacaoTributaria;
                item.ImpostosItemMovimento.Add(impostoAdd);
            }
        }
        /// <summary>
        /// Obtem uma numeracao para o movimento com base na sequence do banco de dados
        /// </summary>
        /// <returns></returns>
        public string GetNewMovimentoNumber()
        {
            try
            {
                using (var ctx = new BalcaoContext())
                {

                    var nextNumber = ctx.ConnectionSql.ExecuteQueryDataTable("SELECT NEXT VALUE FOR SEQ_NUM_MOVIMENTO").Rows[0][0];

                    var strNumber = String.Format("{0:000000000}", nextNumber);
                    return strNumber;
                }
            }
            catch (SqlException ex)
            {
                XMessageIts.ExceptionMessageDetails(ex, "Falha ao obter a numeração do movimento.", "Erro ao obter sequência");
                return string.Empty;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
