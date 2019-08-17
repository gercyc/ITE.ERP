using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.TI
{
    public class SistemaOperacional
    {

        [Required]
        [Column("NomeSistemaOperacional")]
        [Display(Name = "Nome do Sistema Operacional")]
        [StringLength(50, MinimumLength = 5)]
        public string NomeSistema { get; set; }

        [Required]
        [Column("Arquitetura")]
        [Display(Name = "Arquitetura")]
        [StringLength(50, MinimumLength = 3)]
        public string Arquitetura { get; set; }


        public SistemaOperacional()
        {
        }

        public SistemaOperacional(string arq, string so )
        {
            this.Arquitetura = arq;
            this.NomeSistema = so;            
        }

        public override string ToString()
        {
            return NomeSistema + " " + Arquitetura;
        }
    }
}
