using ITE.Entidades.POCO.Financeiro;
using ITE.Entidades.POCO.RH.Folha;
using ITE.Entidades.POCO.Sales;
using ITSolution.Framework.Entities;
using ITSolution.Framework.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITE.Entidades.POCO.CE;

namespace ITE.Entidades.POCO
{
    [Serializable]
    [Table("Usuario")]
    public class Usuario : AbstractUser
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdUsuario { get; set; }

        [Display(Name = "ID Grupo Usuário")]
        [Range(1, int.MaxValue, ErrorMessage = "Grupo de usuário não informado")]
        public int IdGrupoUsuario { get; set; }

        [ForeignKey("IdGrupoUsuario")]
        [Display(Name = "Grupo Usuário")]
        public virtual GrupoUsuario GrupoUsuario { get; set; }

        public decimal PorcentagemComissao { get; internal set; }


        #region Modo EAGER

        public ICollection<Venda> Venda { get; set; }

        public ICollection<CompetenciaFolha> Competencias { get; set; }

        public ICollection<LancamentoFinanceiro> LancamentosCreatedBy { get; set; }

        public ICollection<LancamentoFinanceiro> LancamentosRecModifyBy { get; set; }

        public ICollection<Custeio> Custeios { get; set; }

        #endregion


        public Usuario()
        {
            this.Venda = new HashSet<Venda>();
            this.Competencias = new HashSet<CompetenciaFolha>();
            this.LancamentosCreatedBy = new HashSet<LancamentoFinanceiro>();
            this.LancamentosRecModifyBy = new HashSet<LancamentoFinanceiro>();
            this.Custeios = new HashSet<Custeio>();
        }

        public Usuario(string nomeUsuario, string nomeUtil, string senha, 
            string senhaConfirmacao, GrupoUsuario grupo)
        {
            this.NomeUsuario = nomeUsuario;
            this.NomeUtilizador = nomeUtil;
            
            //criptografa a senha
            this.Senha = ASCIIEncodingIts.Coded(senha);
            //criptografa a senha de confirmacao
            this.ConfirmarSenha = ASCIIEncodingIts.Coded(senhaConfirmacao);

            this.IdGrupoUsuario = grupo != null ? grupo.IdGrupoUsuario : 0;
            this.DataInclusao = DateTime.Now;
        }

        public override void Update(AbstractUser current)
        {
            //sobrecarga
            base.Update(current);

            var user = current as Usuario ;
            if (user != null)
            {
                this.IdGrupoUsuario = user.IdGrupoUsuario;

                //ja chega criptografada
                this.Senha = user.Senha;
                this.ConfirmarSenha = user.ConfirmarSenha;
            }
        }

        #region Controle de usuario

        public bool IsGerente
        {
            get
            {

                var grupo = this.GrupoUsuario != null ? this.GrupoUsuario.NomeGrupoUsuario : "";

                return grupo == "Gerente";
            }

        }


        public bool IsAdmin
        {
            get

            {
                var grupo = this.GrupoUsuario != null ? this.GrupoUsuario.NomeGrupoUsuario : "";

                return grupo == "Gerente" || grupo == "Administrador";
            }
        }

        public bool IsVendedor
        {
            get

            {
                var grupo = this.GrupoUsuario != null ? this.GrupoUsuario.NomeGrupoUsuario : "";

                return grupo == "Vendedor";
            }
        }


        #endregion

    }
}
