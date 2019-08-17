using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH
{

    [Table("HistoricoFuncao")]
    public class HistoricoFuncao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHistoricoFuncao { get; set; }

        public int IdFuncionario { get; set; }

        public int IdFuncao { get; set; }

        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Informe o motivo da alteração da função")]
        [StringLength(100)]
        public string Motivo { get; set; }

        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }

        [ForeignKey("IdFuncao")]
        public virtual Funcao Funcao { get; set; }

        public HistoricoFuncao(int idFuncao, string motivo)
        {
            this.Data = DateTime.Today;
            this.IdFuncao = idFuncao;
            this.Motivo = motivo;
        }

        public HistoricoFuncao(Funcao funcao, string motivo)
        {
            this.Data = DateTime.Today;
            this.IdFuncao = funcao != null ? funcao.IdFuncao : 0;
            this.Motivo = motivo;
        }

        public HistoricoFuncao()
        {

        }
    }
}
