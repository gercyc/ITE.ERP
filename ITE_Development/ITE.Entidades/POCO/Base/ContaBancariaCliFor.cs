using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE.Entidades.POCO
{
    /*
    22/03/2017 - Task 91
    
    Implementação de contas bancarias por clifor.
    Cada clifor poderá ter 1 ou N contas bancarias relacionadas. 
    Funcionalidade utilizada pelo financeiro para visualizar ou emitir pagamentos para os clifors
        */
    public class ContaBancariaCliFor
    {
        [Key]//pk
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdContaCliFor { get; set; }
        public int IdCliFor { get; set; }

        [StringLength(50)]
        public string NomeBanco { get; set; }

        [StringLength(5)]
        public string Agencia { get; set; }

        [StringLength(10)]
        public string ContaBancaria { get; set; }

        //Aqui nao pode ser virtual pq nao se vai BO
        //Vai carregar os dois lados Cliente e Conta
        [ForeignKey("IdCliFor")]
        public CliFor CliFor { get; set; }

        public ContaBancariaCliFor()
        {

        }
        public ContaBancariaCliFor(string banco, string agencia, string conta)
        {
            this.NomeBanco = banco;
            this.Agencia = agencia;
            this.ContaBancaria = conta;
        }
        public void Update(ContaBancariaCliFor contaAnt)
        {
            this.Agencia = contaAnt.Agencia;
            this.NomeBanco = contaAnt.NomeBanco;
            this.ContaBancaria = contaAnt.ContaBancaria;
        }
    }
}
