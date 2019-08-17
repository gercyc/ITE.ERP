using ITE.Entidades.Enumeradores;
using ITE.RH.Enumeradores;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH
{

    [Table("HistoricoSituacao")]
    public class HistoricoSituacao
    {

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHistoricoSituacao { get; set; }

        [Column(Order = 1)]
        public int IdFuncionario { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Filial não informada")]
        public int IdFilial { get; set; }

        [Column(Order = 2, TypeName = "date")]
        public DateTime DataAdmissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataDemissao { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Situação não informada")]
        [Column(Order = 3)]
        public TypeSituacaoFuncionario Situacao { get; set; }

        [Required]
        [Column(Order = 4, TypeName = "date")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Informe o motivo da alteração da situação")]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Motivo { get; set; }

        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }

        [ForeignKey("IdFilial")]
        public virtual EmpresaFilial Filial { get; set; }

        public HistoricoSituacao(int idFilial, DateTime dtAdmissao, TypeSituacaoFuncionario situacao, string motivo)
        {
            this.IdFilial = idFilial;
            this.Data = DateTime.Today;
            this.Situacao = situacao;
            this.Motivo = motivo;
            this.DataAdmissao = dtAdmissao;
        }

        public HistoricoSituacao(int idFilial, DateTime dtAdmissao, DateTime dtDemissao, TypeSituacaoFuncionario situacao, string motivo)
            : this(idFilial, dtAdmissao, situacao, motivo)
        {
            this.DataDemissao = dtDemissao;
        }

        public HistoricoSituacao()
        {

        }
    }
}
