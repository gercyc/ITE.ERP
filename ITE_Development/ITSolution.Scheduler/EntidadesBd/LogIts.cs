using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ITSolution.Scheduler.EntidadesBd
{
    [Table("ITS_SCHEDULER_LOG")]
    public class LogIts
    {
      
        [Key]
        [StringLength(38)]
        public string IdLog { get; set; }

        [Required]
        [StringLength(38)]
        public string IdTask { get; set; }

        [StringLength(20)]
        public string Thread { get; set; }

        public DateTime DataLog { get; set; }

        //[Required]
        [StringLength(1000)]
        public string Mensagem { get; set; }

        [StringLength(1000)]
        public string ErrorMsg { get; set; }

        [ForeignKey("IdTask")]
        public virtual TaskIts TaskIts { get; set; }


        public LogIts()
        {

        }
        public LogIts(string idTask, string thread, string mensagem, string errorMsg)
        {
            this.IdLog = Guid.NewGuid().ToString();
            this.IdTask = idTask;
            this.DataLog = DateTime.Now;
            this.Thread = thread;
            this.Mensagem = mensagem;
            this.ErrorMsg = errorMsg;
        }
        public override string ToString()
        {
            var isErro = this.ErrorMsg == "" ?
                 "" : " - " + this.ErrorMsg;

            return this.DataLog
                +  " - "  + this.Mensagem
                + isErro;
        }
    }
}
