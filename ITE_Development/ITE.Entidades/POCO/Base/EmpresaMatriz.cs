using ITE.Entidades.POCO.Contabil;
using ITSolution.Framework.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO
{
    [Table("EmpresaMatriz")]
    public class EmpresaMatriz : AbstractCompany
    {
        [Key]//pk
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        [Column("IdMatriz")]
        public int IdMatriz { get; set; }

        [Display(Name = "Código Matriz")]
        [Required(ErrorMessage = "Código da matriz deve conter 5 caracteres!")]
        [StringLength(5, MinimumLength = 1)]
        public string CodigoMatriz { get; set; }

        public ICollection<EmpresaFilial> EmpresaFilial { get; set; }
        public ICollection<ContaContabil> ContasContabil { get; set; }
        public ICollection<CentroCusto> CentrosCusto { get; set; }
        public ICollection<LancamentoContabil> LancamentosContabeis { get; set; }
        public ICollection<LoteContabil> LotesContabeis { get; set; }

        #region Mapeamento do JSON
        [JsonProperty("atividade_principal")]
        public ICollection<AtividadePrincipalEmpresaMatriz> AtividadesPrincipais { get; set; }

        [JsonProperty("atividades_secundarias")]
        public ICollection<AtividadeSecundariaEmpresaMatriz> AtividadesSecundarias { get; set; }
        #endregion 
        
        public EmpresaMatriz()
        {
            this.EmpresaFilial = new HashSet<EmpresaFilial>();
            this.ContasContabil = new HashSet<ContaContabil>();
            this.CentrosCusto = new HashSet<CentroCusto>();
            this.AtividadesPrincipais = new HashSet<AtividadePrincipalEmpresaMatriz>();
            this.AtividadesSecundarias = new HashSet<AtividadeSecundariaEmpresaMatriz>();
            this.LancamentosContabeis = new HashSet<LancamentoContabil>();
            this.LotesContabeis = new HashSet<LoteContabil>();
        }

        public EmpresaMatriz(string razaoSocial, string nomeFantasia, string cnpj,
            DateTime dtReg, DateTime dtCadastro, string CodMatriz)
            : base(razaoSocial, nomeFantasia, cnpj,  dtReg, dtCadastro)
        {
            this.CodigoMatriz = CodMatriz;
        }
        /// <summary>
        /// Seta os dados do endereço com um endereço informado
        /// </summary>
        /// <param name="endereco"></param>
        public void SetEndereco(EnderecoCliFor endereco)
        {
            if (endereco != null)
            {
                this.NomeEndereco = endereco.NomeEndereco;
                this.NumeroEndereco = endereco.NumeroEndereco;
                this.TipoEndereco = endereco.TipoEndereco;
                this.Bairro = endereco.Bairro;
                this.Complemento = endereco.Complemento;
                this.Cidade = endereco.Cidade;
                this.Uf = endereco.Uf;
                this.Cep = endereco.Cep;
            }
        }

        public override string ToString()
        {
            return this.CodigoMatriz + " - " + this.RazaoSocial;
        }


        public void Update(EmpresaMatriz novo)
        {
            this.Cnpj = novo.Cnpj;
            this.Cidade = novo.Cidade;
            this.NomeEndereco = novo.NomeEndereco;
            this.NumeroEndereco = novo.NumeroEndereco;
            this.RazaoSocial = novo.RazaoSocial;
            this.NomeFantasia = novo.NomeFantasia;
            this.Bairro = novo.Bairro;
            this.Cep = novo.Cep;
            this.Cidade = novo.Cidade;
            this.Uf = novo.Uf;
            this.Cnpj = novo.Cnpj;
            this.Complemento = novo.Complemento;
            this.DtCadastro = novo.DtCadastro;
            this.DtRegtroJuntaCom = novo.DtRegtroJuntaCom;
            this.Email = novo.Email;
            this.CodigoMatriz = novo.CodigoMatriz;
            this.Telefone = novo.Telefone;
            this.Fax = novo.Fax;

            this.Logo = novo.Logo;

        }
    }
}
