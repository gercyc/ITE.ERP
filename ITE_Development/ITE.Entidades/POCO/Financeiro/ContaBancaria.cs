using ITE.Entidades.Enumeradores.BorderoEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITSolution.Framework.Entities;
using ITSolution.Framework.Enumeradores;

namespace ITE.Entidades.POCO.Financeiro
{
    [Table("ContaBancaria")]
    public class ContaBancaria : AbstractContaBancaria
    {
        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdContaBancaria { get; set; }

        public int IdFilial { get; set; }

        [ForeignKey("IdFilial")]
        public virtual EmpresaFilial Filial { get; set; }

        public ICollection<ExtratoBancario> ExtratosBancario { get; set; }

        public ContaBancaria()
        {

        }
  
        public ContaBancaria(int idFilial, string codigoContaBancaria, string descricaoContaBancaria,
            decimal saldoInicial, DateTime dataAbertura) : base(codigoContaBancaria, descricaoContaBancaria,
            saldoInicial, dataAbertura)
        {
            this.IdFilial = idFilial;

        }
        public ContaBancaria(EmpresaFilial filial, string codigoContaBancaria, string descricaoContaBancaria,
            decimal saldoInicial, DateTime dataAbertura) :
        base(codigoContaBancaria, descricaoContaBancaria, saldoInicial, dataAbertura)
        {
            //this.Matriz = matriz;
            this.IdFilial = filial.IdFilial;

        }

   
        public override void Update(AbstractContaBancaria conta)
        {
            var c = conta as ContaBancaria;
            base.Update(c);
            this.Filial = c.Filial;
            this.IdFilial = c.IdFilial;

        }
        public override string ToString()
        {
            return this.CodigoContaBancaria + " - " + DescricaoContaBancaria;
        }
    }
}
