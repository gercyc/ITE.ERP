using ITE.Entidades.Enumeradores;
using ITSolution.Framework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ITE.Entidades.POCO.TI
{

    [Serializable]
    [Table("Atendimento")]
    public class Atendimento
    {
        [Key]//pk                  
        [Display(Name = "ID Atendimento")]
        [Column("IdAtendimento", Order = 0)] //Indice da coluna no NomeBanco de dados->Sera atendimento primeira coluna da tabela
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdAtendimento { get; set; }

        [Display(Name = "Cliente")]
        [Range(1, int.MaxValue, ErrorMessage = "Cliente não informado")]
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public virtual CliFor Cliente { get; set; }

        public TypeStatusAtendimento StatusAtendimento { get; set; }

        [Required]
        [Display(Name = "Relatório do atendimento")]
        public string RelatorioAtendimento { get; set; }

        [Required]
        [Display(Name = "Tipo de Atendimento")]
        [Range(0, int.MaxValue, ErrorMessage = "Tipo de atendimento não informado")]
        public TypeAtendimento TipoColeta { get; set; }

        [Required]
        [Display(Name = "Data da coleta")]
        public DateTime DataColeta { get; set; }

        public virtual Endereco Endereco { get; set; }

        [StringLength(45)]
        public string Responsavel { get; set; }

        [StringLength(45)]
        public string Telefone { get; set; }

        [StringLength(45)]
        public string Celular { get; set; }

        #region Nao mapeado - Utilizado somente para controle interno

        [NotMapped]
        public Image Image
        {
            get
            {
                switch (this.StatusAtendimento)
                {
                    case TypeStatusAtendimento.Comunicado:
                        return Properties.Resources.about_16x16;

                    case TypeStatusAtendimento.Andamento:
                        return Properties.Resources.status_16x16;

                    case TypeStatusAtendimento.Encerrado:
                        return Properties.Resources.apply_16x16;

                    case TypeStatusAtendimento.Cancelado:
                        return Properties.Resources.cancel_16x16;

                    default:
                        return Properties.Resources.apply_16x16;
                }
            }
        }

        #endregion Nao mapeado - Utilizado somente para controle interno

        public ICollection<Manutencao> Manutencoes { get; set; }

        public Atendimento()
        {
            this.Manutencoes = new HashSet<Manutencao>();

        }

        public Atendimento(CliFor c, TypeAtendimento tp, DateTime dtColeta,
            TypeStatusAtendimento status, string relatorio)
        {
            this.IdCliente = c != null ? c.IdCliFor : 0;
            this.TipoColeta = tp;
            this.StatusAtendimento = TypeStatusAtendimento.Comunicado;
            this.DataColeta = dtColeta;
            this.RelatorioAtendimento = relatorio;
        }

        public Atendimento(CliFor c, TypeAtendimento tp, DateTime dtColeta,
            TypeStatusAtendimento status, string relatorio, Endereco endereco)
            : this(c, tp, dtColeta, status, relatorio)
        {
            this.Endereco = endereco;
        }

        public override string ToString()
        {
            return IdAtendimento + "\n" + DataColeta + "\n" + RelatorioAtendimento;
        }

        public void Update(Atendimento a)
        {
            this.IdCliente = a.IdCliente;
            this.TipoColeta = a.TipoColeta;
            this.StatusAtendimento = a.StatusAtendimento;
            this.DataColeta = a.DataColeta;
            this.RelatorioAtendimento = a.RelatorioAtendimento;
            this.Endereco.Update( a.Endereco);
            this.Telefone = a.Telefone;
            this.Celular = a.Celular;
            this.Responsavel = a.Responsavel;
        }
    }
}
