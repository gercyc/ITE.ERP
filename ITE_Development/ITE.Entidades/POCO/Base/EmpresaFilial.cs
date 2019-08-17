using ITE.Entidades.POCO.Sales;
using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.Fiscal;
using ITE.Entidades.POCO.RH;
using ITE.Entidades.POCO.TI;
using ITSolution.Framework.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO
{
    [Serializable]
    [Table("EmpresaFilial")] 
    public class EmpresaFilial : AbstractCompany
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdFilial")]
        public int IdFilial { get; set; }[Required]
        [Range(1, int.MaxValue, ErrorMessage ="Matriz não foi informado.")]
        [Display(Name = "Matriz")]
        public int IdMatriz { get; set; }

        [Display(Name = "Código Filial")]
        [Required(ErrorMessage = "Código da Filial deve conter 5 caracteres!")]
        [StringLength(5)]
        public String CodigoFilial { get; set; }

        [StringLength(30)]
        [Display(Name="Inscrição Suframa-> Add ")]
        public string InscricaoSuframa { get; set; }

        [ForeignKey("IdMatriz")]
        public virtual EmpresaMatriz Matriz { get; set; }

        //removido virtual nao sera carregado
        public ICollection<Movimento> NotasFiscais { get; set; }

        //removido virtual nao sera carregado
        public ICollection<LocalEstoque> LocaisEstoque { get; set; }

        public ICollection<ContaBancaria> ContasBancaria { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }

        //Funcionario pode mudar de filial entao eu vou registrar essa mudanca
        public ICollection<HistoricoSituacao> HistoricoSituacoes { get; set; }

        public ICollection<InscricaoStFilial> InscricoesStFilial { get; set; }

        public ICollection<LancamentoFinanceiro> LancamentosFinanceiro { get; internal set; }

        public ICollection<Manutencao> Manutencoes { get; set; }

        public ICollection<Venda> Vendas { get; internal set; }

        #region Mapeamento do JSON
        [JsonProperty("atividade_principal")]
        public ICollection<AtividadePrincipalEmpresaFilial> AtividadesPrincipais { get; set; }

        [JsonProperty("atividades_secundarias")]
        public ICollection<AtividadeSecundariaEmpresaFilial> AtividadesSecundarias { get; set; }

        #endregion


        public EmpresaFilial()
        {
            this.Funcionarios = new HashSet<Funcionario>();
            this.NotasFiscais = new HashSet<Movimento>();
            this.ContasBancaria = new HashSet<ContaBancaria>();
            this.LocaisEstoque = new HashSet<LocalEstoque>();

            this.Vendas = new HashSet<Venda>();
            this.Manutencoes = new HashSet<Manutencao>();

            this.LancamentosFinanceiro = new HashSet<LancamentoFinanceiro>();
            this.InscricoesStFilial = new HashSet<InscricaoStFilial>();
            this.AtividadesPrincipais = new HashSet<AtividadePrincipalEmpresaFilial>();
            this.AtividadesSecundarias = new HashSet<AtividadeSecundariaEmpresaFilial>();
        }

        public EmpresaFilial(string razaoSocial, string nomeFantasia, string cnpj, string inscricaoEstadual,
        DateTime dtReg, DateTime dtCadastro, string telefone, string fax, string email, string codigoFilial)
            : base(razaoSocial, nomeFantasia, cnpj, 
            dtReg, dtCadastro)
        {
            this.InscricaoEstadual = inscricaoEstadual;
            this.Telefone = telefone;
            this.Fax = fax;
            this.Email = email;
            this.CodigoFilial = codigoFilial;
        }
        public void Update(EmpresaFilial filial)
        {
            this.Bairro = filial.Bairro;
            this.Cep = filial.Cep;
            this.Cidade = filial.Cidade;
            this.Cnpj = filial.Cnpj;
            this.Complemento = filial.Complemento;
            this.DtCadastro = filial.DtCadastro;
            this.DtRegtroJuntaCom = filial.DtRegtroJuntaCom;
            this.Email = filial.Email;
            this.Fax = filial.Fax;
            this.IdMatriz = filial.IdMatriz;
            this.InscricaoEstadual = filial.InscricaoEstadual;
            this.InscricaoSuframa = filial.InscricaoSuframa;
            this.NomeEndereco = filial.NomeEndereco;
            this.NomeFantasia = filial.NomeFantasia;
            this.NumeroEndereco = filial.NumeroEndereco;
            this.RazaoSocial = filial.RazaoSocial;
            this.Telefone = filial.Telefone;
            this.Fax = filial.Fax;
            this.TipoEndereco = filial.TipoEndereco;
            this.Uf = filial.Uf;
            this.CodigoFilial = filial.CodigoFilial;
        }


    }
}
