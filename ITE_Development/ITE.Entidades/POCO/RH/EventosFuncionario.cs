using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO.RH
{
    public class EventoFuncionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRegistro { get; set; }
        public int IdEvento { get; set; }
        public int IdFuncionario { get; set; }
        public decimal Valor { get; set; }
        [NotMapped]
        public bool Removed
        {
            get; set;
        }
        [ForeignKey("IdEvento")]
        public virtual Evento Evento { get; set; }
        [ForeignKey("IdFuncionario")]
        public virtual Funcionario Funcionario { get; set; }

        public EventoFuncionario()
        {

        }
        public EventoFuncionario(Funcionario f, Evento evento)
        {
            this.IdEvento = evento.IdEvento;
            this.IdFuncionario = f.IdFuncionario;
            this.Evento = evento;
            this.Removed = false;
        }
        public EventoFuncionario(Evento evento)
        {
            this.IdEvento = evento.IdEvento;
            this.Evento = evento;
            this.Removed = false;
        }
        public void Update(EventoFuncionario novo)
        {
            this.Valor = novo.Valor;
        }
    }
}
