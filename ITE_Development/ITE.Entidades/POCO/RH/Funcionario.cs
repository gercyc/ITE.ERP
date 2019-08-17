using ITE.Entidades.POCO.RH.Documentos;
using ITE.Entidades.POCO.RH.Folha;
using ITE.RH.Enumeradores;
using ITSolution.Framework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ITE.Entidades.POCO.RH
{


    [Table("Funcionario")]
    public class Funcionario
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFuncionario { get; set; }

        [StringLength(10)]
        public string CodigoFuncionario { get; set; }

        [Required(ErrorMessage = "Nome do Funcionário não foi informado")]
        [StringLength(100)]
        public string NomeFuncionario { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "CPF deve conter 11 digítos")]
        [StringLength(18, MinimumLength = 0)]
        [Index("Cpf", 1, IsUnique = true)]//Restrição UNIQUE
        public string CPF { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataNascimento { get; set; }

        public int Idade { get; set; }

        [Required(ErrorMessage = "Informa a data que o funcionário foi admitido")]
        [Column(TypeName = "date")]
        public DateTime DataAdmissao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Situação não informada")]
        [Required(ErrorMessage = "Situação funcionario")]
        public TypeSituacaoFuncionario Situacao { get; set; }

        [Required]
        [Display(Name = "Salário")]
        [Range(10, int.MaxValue, ErrorMessage = "Salário não pode ser inferior a R$ 10,00")]
        public decimal Salario { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Estado Civil não informado")]
        [Required(ErrorMessage = "Estado Civil")]
        public TypeEstadoCivil EstadoCivil { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Tipo de recebimento informado")]
        [Required(ErrorMessage = "Tipo de Recebimento")]
        public TypeRecebimento TipoRecebimento { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Departamento não informado")]
        public int IdDepartamento { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Função não informada")]
        public int IdFuncao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Filial do Funcionário não foi informada")]
        public int IdFilial { get; set; }

        [Display(Name = "Telefone Fixo")]
        [StringLength(20)]
        public string TelefoneFixo { get; set; }

        [StringLength(20)]
        public string Celular { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public byte[] Foto { get; set; }

        [Display(Name = "Grupo de eventos padrão")]
        public int? DefaultGroupEvt { get; set; } //task 132

        [ForeignKey("IdDepartamento")]
        public virtual Departamento Departamento { get; set; }

        [ForeignKey("IdFuncao")]
        public virtual Funcao Funcao { get; set; }

        [ForeignKey("IdFilial")]
        public virtual EmpresaFilial Filial { get; set; }

        [ForeignKey("DefaultGroupEvt")]
        public virtual GrupoEvento GrupoDefault { get; set; }

        #region Atributos embutidos

        public virtual RegistroGeral RegistroGeral { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual CTPS CTPS { get; set; }

        public virtual CNH CNH { get; set; }

        public virtual TituloEleitor TituloEleitor { get; set; }

        public virtual CertificadoReservista CertificadoReservista { get; set; }

        #endregion Atributos embutidos

        public virtual ICollection<FuncionarioCompetencia> FuncionarioCompetencias { get; set; }

        public virtual ICollection<HistoricoSituacao> HistoricoSituacao { get; set; }

        public virtual ICollection<HistoricoDepartamento> HistoricoDepartamento { get; set; }

        public virtual ICollection<HistoricoFuncao> HistoricoFuncao { get; set; }

        public virtual ICollection<HistoricoSalarial> HistoricoSalarial { get; set; }

        public virtual ICollection<EventoFuncionario> Eventos { get; set; }

        //public virtual ICollection<FichaFinanceiraFuncionario> FichaFinaceiraFuncionario { get; set; }

        #region Não mapeados

        #endregion

        public Funcionario()
        {
            this.Endereco = new Endereco();
            this.RegistroGeral = new RegistroGeral();
            this.CTPS = new CTPS();
            this.CNH = new CNH();
            this.TituloEleitor = new TituloEleitor();
            this.CertificadoReservista = new CertificadoReservista();

            this.FuncionarioCompetencias = new HashSet<FuncionarioCompetencia>();
            this.HistoricoDepartamento = new HashSet<HistoricoDepartamento>();
            this.HistoricoFuncao = new HashSet<HistoricoFuncao>();
            this.HistoricoSalarial = new HashSet<HistoricoSalarial>();
            this.HistoricoSituacao = new HashSet<HistoricoSituacao>();
            this.Eventos = new HashSet<EventoFuncionario>();

            //this.FichaFinaceiraFuncionario = new HashSet<FichaFinanceiraFuncionario>();

        }

        public Funcionario(string codigo, string nomeFuncionario, string cpfCnpj, DateTime dtNasc,
            string telefoneFixo, string celular, string email, DateTime dataAdmissao,
            Departamento departamento, Funcao funcao, decimal salario,
            byte[] foto) : this()
        {
            //TypeSituacaoFuncionario situacao, TypeEstadoCivil estadoCivil,TypeRecebimento tipoReceb,

            this.CodigoFuncionario = codigo;
            this.NomeFuncionario = nomeFuncionario;
            this.CPF = cpfCnpj;
            this.DataAdmissao = dataAdmissao;
            this.DataNascimento = dtNasc;
            this.TelefoneFixo = telefoneFixo;
            this.Celular = celular;
            this.Email = email;
            //this.TipoRecebimento = tipoReceb;
            //this.EstadoCivil = estadoCivil;
            //this.Situacao = situacao;

            this.IdDepartamento = departamento != null ? departamento.IdDepartamento : -1;
            this.IdFuncao = funcao != null ? funcao.IdFuncao : -1;

            this.Salario = salario;
            this.Foto = foto;
        }

        public void Update(Funcionario novo)
        {
            this.CodigoFuncionario = novo.CodigoFuncionario;
            this.NomeFuncionario = novo.NomeFuncionario;
            this.CPF = novo.CPF;
            this.TipoRecebimento = novo.TipoRecebimento;
            this.DataNascimento = novo.DataNascimento;
            this.EstadoCivil = novo.EstadoCivil;
            this.TelefoneFixo = novo.TelefoneFixo;
            this.Celular = novo.Celular;
            this.Email = novo.Email;
            this.DataAdmissao = novo.DataAdmissao;
            this.IdDepartamento = novo.IdDepartamento;
            this.IdFuncao = novo.IdFuncao;
            this.Situacao = novo.Situacao;
            this.Salario = novo.Salario;
            this.Foto = novo.Foto;
            this.DefaultGroupEvt = novo.DefaultGroupEvt;

            //endereco
            this.Endereco = novo.Endereco;

            //Registro Geral
            this.RegistroGeral = novo.RegistroGeral;

            // Dados da CTPS
            this.CTPS = novo.CTPS;

            //CNH
            this.CNH = novo.CNH;

            //Titulo Eleitor
            this.TituloEleitor = novo.TituloEleitor;

            //Cert. Reservista
            this.CertificadoReservista = novo.CertificadoReservista;

            //eventos..
            foreach (var evt in novo.Eventos)
            {
                if (evt.IdRegistro == 0)
                    this.Eventos.Add(evt);
                else
                    foreach (var currEvt in this.Eventos.Where(e => e.IdRegistro == evt.IdRegistro))
                    {
                        currEvt.Update(evt);
                    }
            }
        }

        public override string ToString()
        {
            return this.NomeFuncionario;
        }
    }
}
