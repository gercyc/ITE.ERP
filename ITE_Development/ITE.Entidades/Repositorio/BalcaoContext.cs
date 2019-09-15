using ITE.Entidades.POCO;
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.POCO.RH;
using ITE.Entidades.POCO.RH.Folha;
using ITE.Entidades.POCO.Financeiro;
using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using ITE.Entidades.POCO.Bordero;
using ITSolution.Framework.Entities;
using ITE.Entidades.POCO.TI;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.Financeiro.POCO;
using ITE.Entidades.POCO.CE;
using ITE.Entidades.POCO.Logistica;
using ITE.Entidades.POCO.Fiscal.NFe;
using ITSolution.Framework.Entities.POCO;
using System.Collections.Generic;
using ITSolution.Framework.Dao.Contexto;
using ITSolution.Framework.Dao.Repositorio.Base;
using ITSolution.Framework.Web.Bacen;
using ITSolution.Framework.BaseClasses.License.POCO;
using ITSolution.Framework.Mensagem;
using ITSolution.Framework.Util;

namespace ITE.Entidades.Repositorio
{
    /// <summary>
    /// Introdução do padrão Singleton
    /// Controle do banco de dados.
    /// DDL - Data Definition Language 
    /// Comandos do tipo DDL: CREATE, ALTER ou DROP
    /// Usandos na criação dos objeto: tabelas, procedures, índices, relacionamentos etc.
    /// 
    /// DML - Data Manipulation Language
    /// Comandos dos tipos DML SELECT, INSERT, UPDATE e DELETE. 
    /// Usandos para manipular os dados.
    /// 
    /// Data Control Language (DCL). Os comandos GRANT e REVOKE.
    /// 
    /// Observação EF:
    /// 
    /// A palavra chave virtual quando utilizada em uma propriedade habilita o Lazy Loading. 
    /// Desta forma os relacionamentos são carregados apenas quando vc carrega-las explicitamente.
    /// Esta pratica de utilizar um atributo privado, sendo encapsulado por suas propriedades, não é mais necessário.
    /// Este é um recurso que esta disponível desde o .Net Framwork 3.0. 
    /// 
    /// </summary>
    public class BalcaoContext : DbContextIts
    {
        #region Propriedades controle de persistencia

        #region Dao - Principais

        public Dao<AtividadePrincipalCliFor> AtividadePrincipalCliForDao { get { return new Dao<AtividadePrincipalCliFor>(this); } }
        public Dao<AtividadePrincipalEmpresaFilial> AtividadePrincipalEmpresaFilialDao { get { return new Dao<AtividadePrincipalEmpresaFilial>(this); } }
        public Dao<AtividadePrincipalEmpresaMatriz> AtividadePrincipalEmpresaMatrizDao { get { return new Dao<AtividadePrincipalEmpresaMatriz>(this); } }
        public Dao<AtividadeSecundariaCliFor> AtividadeSecundariaCliForDao { get { return new Dao<AtividadeSecundariaCliFor>(this); } }
        public Dao<AtividadeSecundariaEmpresaFilial> AtividadeSecundariaEmpresaFilialDao { get { return new Dao<AtividadeSecundariaEmpresaFilial>(this); } }
        public Dao<AtividadeSecundariaEmpresaMatriz> AtividadeSecundariaEmpresaMatrizDao { get { return new Dao<AtividadeSecundariaEmpresaMatriz>(this); } }
        public Dao<CliFor> CliForDao { get { return new Dao<CliFor>(this); } }
        public Dao<ContaBancariaCliFor> ContaBancariaCliForDao { get { return new Dao<ContaBancariaCliFor>(this); } }
        public Dao<EmpresaFilial> EmpresaFilialDao { get { return new Dao<EmpresaFilial>(this); } }
        public Dao<EmpresaMatriz> EmpresaMatrizDao { get { return new Dao<EmpresaMatriz>(this); } }
        public Dao<EnderecoCliFor> EnderecoCliForDao { get { return new Dao<EnderecoCliFor>(this); } }
        public Dao<GrupoUsuario> GrupoUsuarioDao { get { return new Dao<GrupoUsuario>(this); } }
        public Dao<Usuario> UsuarioDao { get { return new Dao<Usuario>(this); } }

        #endregion

        #region Dao - Vendas
        public Dao<AlteracaoProduto> AlteracaoProdutoDao { get { return new Dao<AlteracaoProduto>(this); } }
        public Dao<AtributoProduto> AtributoProdutoDao { get { return new Dao<AtributoProduto>(this); } }
        public Dao<CategoriaProduto> CategoriaProdutoDao { get { return new Dao<CategoriaProduto>(this); } }
        public Dao<FormaPagamento> FormaPagamentoDao { get { return new Dao<FormaPagamento>(this); } }
        public Dao<ItemVenda> ItemVendaDao { get { return new Dao<ItemVenda>(this); } }
        public Dao<Produto> ProdutoDao { get { return new Dao<Produto>(this); } }
        public Dao<TransacoesProduto> TransacoesProdutoDao { get { return new Dao<TransacoesProduto>(this); } }
        public Dao<UnidadeMedida> UnidadeMedidaDao { get { return new Dao<UnidadeMedida>(this); } }
        public Dao<Venda> VendaDao { get { return new Dao<Venda>(this); } }

        #endregion

        #region Dao - Financeiro 

        public Dao<AnexoLancamento> AnexoLancamentoDao { get { return new Dao<AnexoLancamento>(this); } }
        public Dao<Baixa> BaixaDao { get { return new Dao<Baixa>(this); } }
        public Dao<Cheque> ChequeDao { get { return new Dao<Cheque>(this); } }
        public Dao<ContaBancaria> ContaBancariaDao { get { return new Dao<ContaBancaria>(this); } }
        public Dao<CreditoCliente> CreditoClienteDao { get { return new Dao<CreditoCliente>(this); } }
        public Dao<ExtratoBancario> ExtratoBancarioDao { get { return new Dao<ExtratoBancario>(this); } }
        public Dao<LancamentoFinanceiro> LancamentoFinanceiroDao { get { return new Dao<LancamentoFinanceiro>(this); } }
        public Dao<MovimentoCaixa> MovimentoCaixaDao { get { return new Dao<MovimentoCaixa>(this); } }

        public Dao<ComissaoVendaUsuario> ComissaoVendaUsuarioDao { get { return new Dao<ComissaoVendaUsuario>(this); } }
        #endregion

        #region Dao - Contabil
        public Dao<CentroCusto> CentroCustoDao { get { return new Dao<CentroCusto>(this); } }
        public Dao<ContaContabil> ContaContabilDao { get { return new Dao<ContaContabil>(this); } }
        public Dao<LancamentoContabil> LancamentoContabilDao { get { return new Dao<LancamentoContabil>(this); } }
        public Dao<LoteContabil> LoteContabilDao { get { return new Dao<LoteContabil>(this); } }
        public Dao<PartidaContabil> PartidaContabilDao { get { return new Dao<PartidaContabil>(this); } }
        public Dao<TipoMovimento> TipoMovimentoDao { get { return new Dao<TipoMovimento>(this); } }
        public Dao<Moeda> MoedaDao { get { return new Dao<Moeda>(this); } }

        #endregion

        #region Dao - Fiscal

        public Dao<Cfops> CfopsDao { get { return new Dao<Cfops>(this); } }
        public Dao<ImpostoItemMovimento> ImpostoItemMovimentoDao { get { return new Dao<ImpostoItemMovimento>(this); } }
        public Dao<ImpostosRegraFiscal> ImpostosRegraFiscalDao { get { return new Dao<ImpostosRegraFiscal>(this); } }
        public Dao<InscricaoStFilial> InscricaoStFilialDao { get { return new Dao<InscricaoStFilial>(this); } }
        public Dao<ItemMovimento> ItemMovimentoDao { get { return new Dao<ItemMovimento>(this); } }
        public Dao<LocalEstoque> LocalEstoqueDao { get { return new Dao<LocalEstoque>(this); } }
        public Dao<ModeloDocumentoFiscal> ModeloDocumentoFiscalDao { get { return new Dao<ModeloDocumentoFiscal>(this); } }
        public Dao<Movimento> MovimentoDao { get { return new Dao<Movimento>(this); } }
        public Dao<NFeEstadual> NFeEstadualDao { get { return new Dao<NFeEstadual>(this); } }
        public Dao<LoteEnvioNFe> LoteEnvioNFeDao { get { return new Dao<LoteEnvioNFe>(this); } }
        public Dao<TransportadorMovimento> TransportadorMovDao { get { return new Dao<TransportadorMovimento>(this); } }
        public Dao<Municipios> MunicipiosDao { get { return new Dao<Municipios>(this); } }
        public Dao<Ncms> NcmsDao { get { return new Dao<Ncms>(this); } }
        public Dao<Pais> PaisDao { get { return new Dao<Pais>(this); } }
        public Dao<RegraFiscal> RegraFiscalDao { get { return new Dao<RegraFiscal>(this); } }
        public Dao<SituacaoDocumentoFiscal> SituacaoDocumentoFiscalDao { get { return new Dao<SituacaoDocumentoFiscal>(this); } }
        public Dao<SituacaoTributaria> SituacaoTributariaDao { get { return new Dao<SituacaoTributaria>(this); } }
        public Dao<TipoImposto> TipoImpostoDao { get { return new Dao<TipoImposto>(this); } }
        public Dao<UnidadeFederacao> UnidadeFederacaoDao { get { return new Dao<UnidadeFederacao>(this); } }

        #endregion

        #region Dao - RH
        public Dao<Departamento> DepartamentoDao { get { return new Dao<Departamento>(this); } }
        public Dao<Evento> EventoDao { get { return new Dao<Evento>(this); } }
        public Dao<Funcao> FuncaoDao { get { return new Dao<Funcao>(this); } }
        public Dao<Funcionario> FuncionarioDao { get { return new Dao<Funcionario>(this); } }
        public Dao<HistoricoDepartamento> HistoricoDepartamentoDao { get { return new Dao<HistoricoDepartamento>(this); } }
        public Dao<HistoricoFuncao> HistoricoFuncaoDao { get { return new Dao<HistoricoFuncao>(this); } }
        public Dao<HistoricoSalarial> HistoricoSalarialDao { get { return new Dao<HistoricoSalarial>(this); } }
        public Dao<HistoricoSituacao> HistoricoSituacaoDao { get { return new Dao<HistoricoSituacao>(this); } }
        public Dao<CompetenciaFolha> CompetenciaFolhaDao { get { return new Dao<CompetenciaFolha>(this); } }
        public Dao<EventosGrupo> EventosGrupoDao { get { return new Dao<EventosGrupo>(this); } }
        public Dao<EventoFuncionario> EventosFuncionarioDao { get { return new Dao<EventoFuncionario>(this); } }
        public Dao<FaixaContribuicaoSalarial> FaixaContribuicaoSalarialDao { get { return new Dao<FaixaContribuicaoSalarial>(this); } }
        public Dao<FichaFinanceiraFuncionario> FichaFinanceiraFuncionarioDao { get { return new Dao<FichaFinanceiraFuncionario>(this); } }
        public Dao<FuncionarioCompetencia> FuncionarioCompetenciaDao { get { return new Dao<FuncionarioCompetencia>(this); } }
        public Dao<GrupoEvento> GrupoEventoDao { get { return new Dao<GrupoEvento>(this); } }
        #endregion Propriedades de controle de persistencia

        #region Dao - Manutencao 

        public Dao<Atendimento> AtendimentoDao { get; private set; }
        public Dao<Computador> ComputadorDao { get; private set; }
        public Dao<ItemManutencao> ItemManutencaoDao { get; private set; }
        public Dao<Manutencao> ManutencaoDao { get; private set; }

        #endregion

        #region Dao - Ardosia

        public Dao<Custeio> CusteioDao { get { return new Dao<Custeio>(this); } }
        public Dao<ItemCusteio> ItemCusteioDao { get { return new Dao<ItemCusteio>(this); } }
        public Dao<DespesaCusteio> DespesaCusteioDao { get { return new Dao<DespesaCusteio>(this); } }
        public Dao<CotacaoCusteio> CotacaoCusteioDao { get { return new Dao<CotacaoCusteio>(this); } }
        public Dao<Transporte> TransporteDao { get { return new Dao<Transporte>(this); } }

        #endregion

        public Dao<Parametro> ParametroDao { get { return new Dao<Parametro>(this); } }
        //ver essa classe depois se ela ira pro contexto do ITSolutionContext
        public Dao<SkinDevExpress> SkinDevExpressDao { get { return new Dao<SkinDevExpress>(this); } }
        public Dao<TipoLogradouro> TipoLogradouroDao { get { return new Dao<TipoLogradouro>(this); } }
        public Dao<ItsContrato> ContratoDao { get { return new Dao<ItsContrato>(this); } }
        public Dao<ItsMenu> ItsMenuDao { get { return new Dao<ItsMenu>(this); } }
        public Dao<ItsLicense> LicenseDao { get { return new Dao<ItsLicense>(this); } }


        #endregion

        public BalcaoContext(string connectionStringOrDatabase)
          : base(connectionStringOrDatabase)
        {

        }

        public BalcaoContext()
            : base(AppConfigManager.Configuration.ConnectionString)

        {
            //impedir que o EF trunque os valores decimais > 2 casas
            SqlProviderServices.TruncateDecimalsToScale = false;
            try
            {
                base.Set<Produto>().AsNoTracking();
            }
            catch (Exception ex)
            {
                string msg = "A versão do sua base de dados foi alterada !\n" +
                                "Verifique se você possui a versão mais recente da aplicação." +
                                "Contate o administrador para atualização ou correção do problema.\n\n";
                XMessageIts.Erro(msg + "Erro: " + ex.Message, "Atenção !!!");
                LoggerUtilIts.GenerateLogs(ex, msg);
                Environment.Exit(0);
            }



        }

        public BalcaoContext(bool lazy) : this()
        {
            this.LazyLoading(lazy);
        }

        #region Fluent API

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Venda(modelBuilder);

            Fiscal(modelBuilder);

            RH(modelBuilder);

            Financeiro(modelBuilder);

            Contabil(modelBuilder);

            TI(modelBuilder);
        }

        private void Venda(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpresaMatriz>()
                .HasMany(e => e.EmpresaFilial)
                .WithRequired(e => e.Matriz)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AlteracaoProduto>()
                .Property(e => e.TipoAlteracao)
                .IsUnicode(false);

            modelBuilder.Entity<AlteracaoProduto>()
                .Property(e => e.QtdAnterior)
                .HasPrecision(18, 3);

            modelBuilder.Entity<CliFor>()
                .HasMany(e => e.Enderecos)
                .WithRequired(e => e.CliFor)
                .HasForeignKey(e => e.IdCliForEndereco);
            //task 91
            modelBuilder.Entity<CliFor>()
                .HasMany(e => e.ContasBancariasCliFor)
                .WithRequired(e => e.CliFor)
                .HasForeignKey(e => e.IdCliFor);

            modelBuilder.Entity<CliFor>()
                .HasMany(e => e.NotasFiscaisCapa)
                .WithRequired(e => e.CliFor)
                .HasForeignKey(e => e.IdCliFor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CliFor>()
                .HasMany((System.Linq.Expressions.Expression<Func<CliFor, System.Collections.Generic.ICollection<Venda>>>)(e => e.Vendas))
                .WithRequired((System.Linq.Expressions.Expression<Func<Venda, CliFor>>)((Venda e) => e.CliFor))
                .HasForeignKey((Venda e) => e.IdCliForVenda);

            modelBuilder.Entity<CliFor>()
                .HasMany(e => e.AtividadesPrincipais)
                .WithRequired(e => e.CliFor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CliFor>()
                .HasMany(e => e.AtividadesSecundarias)
                .WithRequired(e => e.CliFor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpresaFilial>()
                .HasMany(e => e.LocaisEstoque)
                .WithRequired(e => e.Filial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormaPagamento>()
                .HasMany((System.Linq.Expressions.Expression<Func<FormaPagamento, System.Collections.Generic.ICollection<Venda>>>)(e => e.Vendas))
                .WithRequired((System.Linq.Expressions.Expression<Func<Venda, FormaPagamento>>)((Venda e) => e.FormaPagamentoVenda))
                .HasForeignKey((Venda e) => e.IdFormaPagamentoVenda);

            //modelBuilder.Entity<FormaPagamento>()
            //    .HasMany(e => e.MovimentosCaixa)
            //    .WithRequired(e => e.FormaPagamento)
            //    .HasForeignKey(e => e.IdFormaPagto)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemVenda>()
                .Property(e => e.Quantidade)
                .HasPrecision(18, 3);

            modelBuilder.Entity<LancamentoFinanceiro>()
                .HasMany(e => e.Baixas)
                .WithRequired(e => e.LancamentoFinanceiro)
                .HasForeignKey(e => e.IdLancamento)
                .WillCascadeOnDelete(true);//se o lançamento se for a baixa ja era

            modelBuilder.Entity<Produto>()
                .Property(e => e.QuantidadeProduto)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.ItensVenda)
                .WithRequired(e => e.Produto)
                .HasForeignKey(e => e.IdProduto)
                .WillCascadeOnDelete(true);//deletei o produto o item ja era


            modelBuilder.Entity<UnidadeMedida>()
                .HasMany(e => e.Produto)
                .WithRequired(e => e.UnidadeMedida)
                .HasForeignKey(e => e.IdUnidadeMedidaProduto);

            modelBuilder.Entity<Usuario>()
                .HasMany((System.Linq.Expressions.Expression<Func<Usuario, System.Collections.Generic.ICollection<Venda>>>)(e => e.Venda))
                .WithRequired((System.Linq.Expressions.Expression<Func<Venda, Usuario>>)((Venda e) => e.Usuario))
                .HasForeignKey((Venda e) => e.IdUsuarioVenda);

            modelBuilder.Entity<Usuario>()
                           .HasMany(e => e.Competencias)
                           .WithRequired(e => e.Usuario)
                           .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.LancamentosCreatedBy)
                .WithRequired(e => e.UsuarioRecCreatedBy)
                .HasForeignKey(e => e.RecCreatedBy);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.LancamentosRecModifyBy)
                .WithOptional(e => e.UsuarioRecModifyBy)
                .HasForeignKey(e => e.RecModifyBy);

            modelBuilder.Entity<Usuario>()
                .HasMany((System.Linq.Expressions.Expression<Func<Usuario, System.Collections.Generic.ICollection<Venda>>>)(e => e.Venda))
                .WithRequired((System.Linq.Expressions.Expression<Func<Venda, Usuario>>)((Venda e) => e.Usuario))
                .HasForeignKey((Venda e) => e.IdUsuarioVenda)
                .WillCascadeOnDelete((bool)false);


            modelBuilder.Entity<Venda>()
                .HasMany(e => e.ItensVendas)
                .WithRequired(e => e.Venda)
                .HasForeignKey(e => e.IdVenda)
                .WillCascadeOnDelete(true);//se eu dropar a venda o item ja era


            modelBuilder.Entity<EmpresaFilial>()
               .HasMany(e => e.AtividadesPrincipais)
               .WithRequired(e => e.EmpresaFilial)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpresaFilial>()
                .HasMany(e => e.AtividadesSecundarias)
                .WithRequired(e => e.EmpresaFilial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpresaMatriz>()
               .HasMany(e => e.AtividadesPrincipais)
               .WithRequired(e => e.Matriz)
               .HasForeignKey(e => e.IdMatriz)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpresaMatriz>()
                .HasMany(e => e.AtividadesSecundarias)
                .WithRequired(e => e.Matriz)
                .HasForeignKey(e => e.IdMatriz)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpresaFilial>()
                .HasMany(e => e.ContasBancaria)
                .WithRequired(e => e.Filial)
                .WillCascadeOnDelete(false);

        }

        private void Fiscal(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UnidadeFederacao>()
                .HasMany(e => e.Municipios)
                .WithRequired(e => e.UnidadeFederacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpresaFilial>()
                .HasMany(e => e.NotasFiscais)
                .WithRequired(e => e.EmpresaFilial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.NotasFiscaisItens)
                .WithRequired(e => e.Produto)
                .WillCascadeOnDelete(true);//se dropar a nota apague os produtos

            modelBuilder.Entity<ModeloDocumentoFiscal>()
                .HasMany(e => e.NotasFiscaisCapa)
                .WithRequired(e => e.ModeloDocumentoFiscal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movimento>()
                .HasMany(e => e.ItensMovimento)
                .WithRequired(e => e.Movimento)
                .WillCascadeOnDelete(true);//se dropar uma nota os itens ja eram

            modelBuilder.Entity<Movimento>()
                .HasMany(e => e.TransacoesProdutos)
                .WithOptional(e => e.Movimento)
                .HasForeignKey(e => e.IdMovimento);

            modelBuilder.Entity<Movimento>()
                .HasMany(e => e.Parcelas)
                .WithOptional(e => e.NotaFiscal)
                .HasForeignKey(e => e.IdNotaFiscal);

            modelBuilder.Entity<Movimento>()
                .HasOptional<TransportadorMovimento>(e => e.Transportador)
                .WithRequired(e => e.Movimento);

            modelBuilder.Entity<ItemMovimento>()
                .Property(e => e.Quantidade)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ItemMovimento>()
                .HasMany(e => e.ImpostosItemMovimento)
                .WithRequired(e => e.NotaFiscalItem)
                .WillCascadeOnDelete(true);//se dropar a nota fiscal os itens ja eram


            modelBuilder.Entity<SituacaoDocumentoFiscal>()
                .HasMany(e => e.NotasFiscaisCapa)
                .WithRequired(e => e.SituacaoDocumentoFiscal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoImposto>()
                .HasMany(e => e.SituacaoTributaria)
                .WithRequired(e => e.TipoImposto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnidadeFederacao>()
                .HasMany(e => e.InscricaoStFilial)
                .WithRequired(e => e.UnidadeFederacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RegraFiscal>()
                .HasMany(e => e.ImpostosRegraFiscal)
                .WithRequired(e => e.RegraFiscal)
                .WillCascadeOnDelete(true);//se a regra se for o imposto ja era


            modelBuilder.Entity<CentroCusto>()
                .HasMany(e => e.NotasFiscais)
                .WithRequired(e => e.CentroCusto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoMovimento>()
                .HasMany(e => e.Movimentos)
                .WithRequired(e => e.TipoMovimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LocalEstoque>()
                .HasMany(e => e.Movimentos)
                .WithRequired(e => e.LocalEstoque)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFeEstadual>()
                .HasKey(e => e.IdNfe)
                .HasRequired(e => e.Movimento);

            modelBuilder.Entity<LoteEnvioNFe>()
                .HasKey(e => e.IdLoteNfe);

        }

        private void RH(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>()
             .HasMany(e => e.HistoricoSituacao)
             .WithRequired(e => e.Funcionario)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.HistoricoDepartamento)
                .WithRequired(e => e.Funcionario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.HistoricoFuncao)
                .WithRequired(e => e.Funcionario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Funcionario>()
                .HasMany(e => e.HistoricoSalarial)
                .WithRequired(e => e.Funcionario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Funcionario>()
               .HasMany(e => e.FuncionarioCompetencias)
               .WithRequired(e => e.Funcionario)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Departamento>()
                .HasMany(e => e.HistoricoDepartamentos)
                .WithRequired(e => e.Departamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Funcao>()
                .HasMany(e => e.HistoricoFuncao)
                .WithRequired(e => e.Funcao)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Funcionario>()
               .HasMany(e => e.FuncionarioCompetencias)
               .WithRequired(e => e.Funcionario)
               .WillCascadeOnDelete(false);


            modelBuilder.Entity<Evento>()
                .HasMany(e => e.EventosGrupo)
                .WithRequired(e => e.Evento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.FichasFinanceira)
                .WithRequired(e => e.Evento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompetenciaFolha>()
                .Property(e => e.Periodo)
                .IsUnicode(false);

            modelBuilder.Entity<GrupoEvento>()
                .HasMany(e => e.EventosGrupo)
                .WithRequired(e => e.Grupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.EventosGrupo)
                .WithRequired(e => e.Evento)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Competencias)
                .WithRequired(e => e.Usuario)
                .WillCascadeOnDelete(false);

        }

        private void Financeiro(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Venda>()
                .HasMany(e => e.Parcelas)
                .WithOptional(e => e.Venda)
                .HasForeignKey(e => e.IdVenda)
                .WillCascadeOnDelete(true);//na falta da venda nao existe mais parcelas

            modelBuilder.Entity<Venda>()
                .HasMany(e => e.MovimentosCaixa)
                .WithOptional(e => e.Venda)
                .HasForeignKey(e => e.IdVenda)
                  .WillCascadeOnDelete(true);//dropei a venda os movimento ja eram

            //modelBuilder.Entity<ControleCaixa>()
            //    .HasMany(e => e.MovimentoCaixa)
            //    .WithRequired(e => e.Usuario)
            //    .WillCascadeOnDelete(false);
        }

        private void TI(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Atendimento>()
            //    .HasMany(e => e.Manutencoes)
            //    .WithRequired(e => e.Atendimento)
            //    .HasForeignKey(e => e.IdAtendimento)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<CliFor>()
                .HasMany(e => e.Atendimentos)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CliFor>()
                .HasMany(e => e.Enderecos)
                .WithRequired(e => e.CliFor)
                .HasForeignKey(e => e.IdCliForEndereco)
                  .WillCascadeOnDelete(true);//dropei o cliente o endereco ja era


            modelBuilder.Entity<Manutencao>()
                .HasMany(e => e.ItensManutencao)
                .WithRequired(e => e.Manutencao)
                .HasForeignKey(e => e.IdManutencao)
                .WillCascadeOnDelete(true);//dropei a manutencao os itens ja eram

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.ItensManutencao)
                .WithRequired(e => e.Produto)
                .HasForeignKey(e => e.IdProdutoManutencao)
                .WillCascadeOnDelete(true);//dropei o produto os itens ja eram


            modelBuilder.Entity<Manutencao>()
               .HasMany(e => e.Computadores)
               .WithRequired(e => e.Manutencao)
               .HasForeignKey(e => e.IdManutencao)
               .WillCascadeOnDelete(false);//dropei a manutencao os pcs ja eram


            modelBuilder.Entity<CentroCusto>()
                .HasMany(e => e.Manutencoes)
                .WithRequired(e => e.CentroCusto)
                .WillCascadeOnDelete(false);

            //base 2 de estudos
            //http://netcoders.com.br/blog/mapeamento-com-entity-framework-code-first-fluent-api-parte-2/

        }

        private void Contabil(DbModelBuilder modelBuilder)
        {
            //1 matriz, n centros
            modelBuilder.Entity<EmpresaMatriz>()
                .HasMany(e => e.CentrosCusto)
                .WithRequired(e => e.Matriz)
                .HasForeignKey(e => e.IdMatriz)
                .WillCascadeOnDelete(false);

            //1 matriz, n contas contabeis
            modelBuilder.Entity<EmpresaMatriz>()
                .HasMany(e => e.ContasContabil)
                .WithRequired(e => e.Matriz)
                .HasForeignKey(e => e.IdMatriz)
                .WillCascadeOnDelete(false);

            //1 matriz, n lotes
            //modelBuilder.Entity<EmpresaMatriz>()
            //    .HasMany(e => e.LotesContabeis)
            //    .WithRequired(e => e.Matriz)
            //    .HasForeignKey(e => e.IdMatriz)
            //    .WillCascadeOnDelete(false);

            //1 matriz, n lancamentos
            modelBuilder.Entity<EmpresaMatriz>()
                .HasMany(e => e.LancamentosContabeis)
                .WithRequired(e => e.Matriz)
                .HasForeignKey(e => e.IdMatriz)
                .WillCascadeOnDelete(false);

            //1 lote, N lançamentos
            modelBuilder.Entity<LoteContabil>()
                .HasMany(e => e.LancamentosLote)
                .WithOptional(e => e.LoteOrigem)
                .HasForeignKey(e => e.IdLoteOrigem)
                .WillCascadeOnDelete(false);

            //1 lançamento, N partidas
            modelBuilder.Entity<LancamentoContabil>()
                .HasMany(e => e.Partidas)
                .WithRequired(e => e.LancamentoContabil)
                .HasForeignKey(e => e.IdLancamentoContabil)
                .WillCascadeOnDelete(true);

        }

        #endregion

        #region DbSet - Entidades explicítas p/criação das tabelas
        public virtual DbSet<Parametro> Parametros { get; set; }
        public virtual DbSet<CliFor> CliFors { get; set; }
        public virtual DbSet<AtividadePrincipalCliFor> AtividadesPrincipaisCliFor { get; set; }
        public virtual DbSet<AtividadeSecundariaCliFor> AtividadesSecundariasCliFor { get; set; }
        public virtual DbSet<GrupoUsuario> GruposUsuarios { get; set; }
        public virtual DbSet<UnidadeMedida> UnidadesMedidas { get; set; }
        public virtual DbSet<CategoriaProduto> CategoriaProdutos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }
        public virtual DbSet<ItemVenda> ItensVendas { get; set; }
        public virtual DbSet<LancamentoFinanceiro> LancamentosFinanceiros { get; set; }
        public virtual DbSet<AnexoLancamento> AnexosLancamentos { get; set; }
        public virtual DbSet<Baixa> Baixas { get; set; }
        public virtual DbSet<FormaPagamento> FormasPagamentos { get; set; }
        public virtual DbSet<EmpresaFilial> EmpresasFiliais { get; set; }
        public virtual DbSet<AtividadePrincipalEmpresaFilial> AtividadesPrincipaisEmpresaFilial { get; set; }
        public virtual DbSet<AtividadeSecundariaEmpresaFilial> AtividadesSecundariasEmpresaFilial { get; set; }

        public virtual DbSet<EmpresaMatriz> EmpresaMatrizes { get; set; }
        public virtual DbSet<AtividadePrincipalEmpresaMatriz> AtividadesPrincipaisEmpresaMatriz { get; set; }
        public virtual DbSet<AtividadeSecundariaEmpresaMatriz> AtividadesSecundariasEmpresaMatriz { get; set; }

        public virtual DbSet<MovimentoCaixa> MovimentoCaixas { get; set; }
        public virtual DbSet<CreditoCliente> CreditosClientes { get; set; }
        public virtual DbSet<TipoLogradouro> TiposLogradouros { get; set; }
        public virtual DbSet<TransacoesProduto> TransacoesProdutos { get; set; }

        #region Financeiro/Contabil

        public DbSet<CentroCusto> CentrosCustos { get; set; }
        public DbSet<ContaContabil> ContasContabil { get; set; }
        public DbSet<ContaBancaria> ContasBancaria { get; set; }
        public DbSet<ExtratoBancario> ExtratosBancario { get; set; }
        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<LoteContabil> LotesContabeis { get; set; }
        public DbSet<LancamentoContabil> LancamentosContabeis { get; set; }
        public DbSet<PartidaContabil> PartidasContabeis { get; set; }
        #endregion
        public virtual DbSet<ComissaoVendaUsuario> ComissoesVenda { get; internal set; }


        #region Fiscal  

        public virtual DbSet<Cfops> Cfops { get; set; }
        public virtual DbSet<InscricaoStFilial> InscricoesStFilial { get; set; }
        public virtual DbSet<ModeloDocumentoFiscal> ModelosDocumentosFiscais { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Ncms> Ncms { get; set; }
        public virtual DbSet<Movimento> MovimentoSet { get; set; }
        public virtual DbSet<NFeEstadual> NFeEstadualSet { get; set; }
        public virtual DbSet<LoteEnvioNFe> LoteEnvioNFeSet { get; set; }
        public virtual DbSet<TransportadorMovimento> TransportadorMovimentoSet { get; set; }
        public virtual DbSet<ItemMovimento> ItemMovimentoSet { get; set; }
        public virtual DbSet<ImpostoItemMovimento> ImpostosItemMovimentoSet { get; set; }
        public virtual DbSet<SituacaoDocumentoFiscal> SituacaoDocumentoFiscalSet { get; set; }
        public virtual DbSet<SituacaoTributaria> SituacoesTributarias { get; set; }
        public virtual DbSet<TipoImposto> TiposImpostos { get; set; }
        public virtual DbSet<UnidadeFederacao> UnidadesFederacoes { get; set; }
        public virtual DbSet<LocalEstoque> LocaisEstoque { get; set; }
        public virtual DbSet<RegraFiscal> RegraisFiscais { get; set; }
        public virtual DbSet<ImpostosRegraFiscal> ImpostosRegraisFiscais { get; set; }
        public virtual DbSet<TipoMovimento> TiposMovimentos { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }

        #endregion


        #region Manutencao

        public virtual DbSet<Atendimento> Atendimentos { get; set; }
        public virtual DbSet<Manutencao> Manutencoes { get; set; }
        public virtual DbSet<Computador> ComputadoresManutencoes { get; set; }
        public virtual DbSet<ItemManutencao> ItensManutencoes { get; set; }

        #endregion 


        #region RH

        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<FichaFinanceiraFuncionario> FichaFinanceiraFuncionarios { get; set; }
        public virtual DbSet<Funcao> Funcoes { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<HistoricoDepartamento> HistoricoDepartamentos { get; set; }
        public virtual DbSet<HistoricoFuncao> HistoricoFuncoes { get; set; }
        public virtual DbSet<HistoricoSalarial> HistoricoSalariaais { get; set; }
        public virtual DbSet<HistoricoSituacao> HistoricoSituacoes { get; set; }
        public virtual DbSet<CompetenciaFolha> CompetenciaFolha { get; set; }
        public virtual DbSet<FuncionarioCompetencia> FuncionarioCompetencia { get; set; }
        public virtual DbSet<GrupoEvento> GrupoEvento { get; set; }
        public virtual DbSet<EventosGrupo> EventosGrupo { get; set; }
        public virtual DbSet<EventoFuncionario> EventosFuncionario { get; set; }
        public virtual DbSet<FaixaContribuicaoSalarial> FaixaContribuicaoSalarial { get; set; }

        #endregion

        public virtual DbSet<Custeio> Custeios { get; set; }

        public virtual DbSet<ItemCusteio> ItensCusteios { get; set; }

        public virtual DbSet<DespesaCusteio> DespesasCusteio { get; set; }

        public virtual DbSet<CotacaoCusteio> CotacaoCusteio { get; set; }

        public virtual DbSet<Transporte> Transporte { get; set; }

        public virtual DbSet<SkinDevExpress> SkinsDevExpress { get; set; }
        public virtual DbSet<ItsMenu> MenuIts { get; set; }
        public virtual DbSet<ItsLicense> LicenseIts { get; set; }
        public virtual DbSet<ItsContrato> ContratoIts { get; set; }


        #endregion

    }
}

