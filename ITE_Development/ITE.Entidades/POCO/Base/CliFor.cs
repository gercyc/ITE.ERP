using System.Linq;
using ITE.Entidades.POCO.Sales;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.POCO.TI;
using ITE.Entidades.Enumeradores;
using ITSolution.Framework.Entities;
using ITSolution.Framework.Enumeradores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITE.Entidades.POCO.CE;
using ITE.Entidades.POCO.Financeiro;
using ITSolution.Framework.Entities.POCO;

namespace ITE.Entidades.POCO
{
    [Serializable]
    [Table("CliFor")]
    public class CliFor : AbstractClient
    {

        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdCliFor { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Classificação do cliente não foi informada.")]
        [Display(Name = "Classificação")]
        public TypeClassificaoCliente Classificacao { get; set; }

        [StringLength(300)]
        public String HistoricoCliente { get; set; }

        public TypeReputacaoCliFor Reputacao { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }

        public virtual ICollection<EnderecoCliFor> Enderecos { get; set; }

        public virtual ICollection<ContaBancariaCliFor> ContasBancariasCliFor { get; set; }

        public ICollection<CreditoCliente> CreditosCliente { get; set; }

        public ICollection<Movimento> NotasFiscaisCapa { get; set; }

        public ICollection<Manutencao> Manutencoes { get; set; }

        public ICollection<Atendimento> Atendimentos { get; set; }

        public ICollection<Custeio> Invoices { get; set; }

        public ICollection<ItsContrato> ContratosSoftware { get; set; }

        //public ICollection<Transporte> Fretes { get; set; }

        #region Atividades Juridicas - Mapeamento JSON

        [JsonProperty("atividade_principal")]
        public virtual ICollection<AtividadePrincipalCliFor> AtividadesPrincipais { get; set; }

        [JsonProperty("atividades_secundarias")]
        public virtual ICollection<AtividadeSecundariaCliFor> AtividadesSecundarias { get; set; }
        public HashSet<LancamentoFinanceiro> LancamentosFinanceiros { get; private set; }

        #endregion

        public CliFor()
        {
            this.DtCadastro = DateTime.Now;
            this.Vendas = new HashSet<Venda>();
            this.Enderecos = new HashSet<EnderecoCliFor>();
            this.CreditosCliente = new HashSet<CreditoCliente>();
            this.ContratosSoftware = new HashSet<ItsContrato>();
            this.Atendimentos = new HashSet<Atendimento>();
            this.Manutencoes = new HashSet<Manutencao>();
            this.Reputacao = TypeReputacaoCliFor.Razoavel;

            this.NotasFiscaisCapa = new HashSet<Movimento>();
            this.LancamentosFinanceiros = new HashSet<LancamentoFinanceiro>();

            this.AtividadesPrincipais = new HashSet<AtividadePrincipalCliFor>();
            this.AtividadesSecundarias = new HashSet<AtividadeSecundariaCliFor>();
            this.ContasBancariasCliFor = new HashSet<ContaBancariaCliFor>();
            this.Invoices = new HashSet<Custeio>();
            //this.Fretes = new HashSet<Transporte>();

        }

        public CliFor(string nomeCliFor, string rg, string cpfCnpj, DateTime? dtDataNasc, TypeCliente tipoCliente,
             string telefone, string celular, string telComercial, TypeClassificaoCliente classificacao)
            : base(nomeCliFor, rg, cpfCnpj, dtDataNasc, tipoCliente, telefone, celular, telComercial)
        {
            this.Vendas = new HashSet<Venda>();
            this.Enderecos = new HashSet<EnderecoCliFor>();
            this.CreditosCliente = new HashSet<CreditoCliente>();

            this.Atendimentos = new HashSet<Atendimento>();
            this.Manutencoes = new HashSet<Manutencao>();

            this.AtividadesPrincipais = new HashSet<AtividadePrincipalCliFor>();
            this.AtividadesSecundarias = new HashSet<AtividadeSecundariaCliFor>();
            this.Classificacao = classificacao;
        }

        public CliFor(string nomeCliFor, string rg, string cpfCnpj, DateTime? dtDataNasc, TypeCliente tipoCliente,
                                    string telefone, string celular, string telComercial, List<EnderecoCliFor> enderecos, TypeClassificaoCliente classificacao)
                    : this(nomeCliFor, rg, cpfCnpj, dtDataNasc, tipoCliente, telefone, celular,
                        telComercial, classificacao)
        {

            foreach (var a in enderecos)
            {
                this.Enderecos.Add(a);

                if (a.TipoEndereco == "Comercial")
                {

                    this.NumeroEndereco = a.NumeroEndereco;
                    this.NomeEndereco = a.NomeEndereco;
                    this.Cep = a.Cep.Replace(".", "");
                    this.Cidade = a.Cidade;
                    this.Uf = a.Uf;
                    this.Complemento = a.Complemento;
                    this.TipoEndereco = a.TipoEndereco;
                    this.Bairro = a.Bairro;

                }

            }

        }

        public CliFor(int idCliFor)
        {
            this.IdCliFor = idCliFor;
        }

        /// <summary>
        /// Atualiza os dados CliFor com o CliFor informado
        /// </summary>
        /// <param name="novo"></param>
        public void Update(CliFor novo)
        {
            this.RazaoSocial = novo.RazaoSocial;
            this.RG = novo.RG;
            this.CpfCnpj = novo.CpfCnpj;
            this.DataNascimento = novo.DataNascimento;
            this.Email = novo.Email;
            this.Telefone = novo.Telefone;
            this.Celular = novo.Celular;
            this.TelefoneComercial = novo.TelefoneComercial;
            this.TipoCliente = novo.TipoCliente;
            this.Classificacao = novo.Classificacao;

            this.Reputacao = novo.Reputacao;

            this.NumeroEndereco = novo.NumeroEndereco;
            this.NomeEndereco = novo.NomeEndereco;
            this.Cep = novo.Cep;
            this.Cidade = novo.Cidade;
            this.Uf = novo.Uf;
            this.Complemento = novo.Complemento;
            this.TipoEndereco = novo.TipoEndereco;
            this.Bairro = novo.Bairro;


            //dados juridicos

            this.NaturezaJuridica = novo.NaturezaJuridica;

            this.Abertura = novo.Abertura;

            this.NomeFantasia = novo.NomeFantasia;
            this.Tipo = novo.Tipo;
            this.SituacaoJuridica = novo.SituacaoJuridica;
            this.DataSituacao = novo.DataSituacao;
            this.Efr = novo.Efr;
            this.StatusCliente = novo.StatusCliente;
            this.SituacaoEspecial = novo.SituacaoEspecial;
            this.MotivoSituacao = novo.MotivoSituacao;
            this.DataSituacaoEspecial = novo.DataSituacaoEspecial;
            this.UltimaAtualizacao = novo.UltimaAtualizacao;
            this.InscricaoEstadual = novo.InscricaoEstadual;
            this.InscricaoMunicipal = novo.InscricaoMunicipal;




        }

        public void UpdateEnderecoPrincipal()
        {
            //se eu tenho um endereco na lista
            
            
            //se eu tenho um endereco principal
            //ele sera o primeiro endereço da lista
            if ( !string.IsNullOrEmpty(this.NomeEndereco))
            {
                //atualize o primeiro endereco
                //ou seja o primeiro endereço é o endereço principal
                var endPrin = new EnderecoCliFor();
                //atualiza o endereco da lista
                endPrin.NomeEndereco = this.NomeEndereco;
                endPrin.NumeroEndereco = this.NumeroEndereco;
                endPrin.Bairro = this.Bairro;
                endPrin.Cidade = this.Cidade;
                endPrin.Uf = this.Uf;
                endPrin.Complemento = this.Complemento;
                endPrin.Cep = this.Cep;
                endPrin.TipoEndereco = this.TipoEndereco;

                if (this.Enderecos.Count == 0)
                    this.Enderecos.Add(endPrin);
                else
                {
                    this.Enderecos.First().Update(endPrin);
                }

            }
            //ele sera o principal
            if (this.Enderecos.Count > 0)
            {

                //atualize o primeiro endereco
                //ou seja o primeiro endereço é o endereço principal
                var endPrin = this.Enderecos.First();

                //atualiza o endereco principal
                this.NomeEndereco = endPrin.NomeEndereco;
                this.NumeroEndereco = endPrin.NumeroEndereco;
                this.Bairro = endPrin.Bairro;
                this.Cidade = endPrin.Cidade;
                this.Uf = endPrin.Uf;
                this.Complemento = endPrin.Complemento;
                this.Cep = endPrin.Cep;
                this.TipoEndereco = endPrin.TipoEndereco;

            }
        }

    }
}