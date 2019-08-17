
using ITE.Entidades.POCO.Contabil;
using ITE.Entidades.POCO.TI;
using ITE.Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace ITE.Entidades.POCO.TI
{
    [Serializable]
    [Table("Manutencao")]
    public class Manutencao
    {

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//sera auto increment
        public int IdManutencao { get; set; }

        [Column(Order = 1)]
        //nao sera auto increment
        [Range(1, int.MaxValue, ErrorMessage ="Cliente não foi informado")]
        public int IdCliente { get; set; }

        [Display(Name = "Cliente")]
        [ForeignKey("IdCliente")]
        public virtual CliFor Cliente { get; set; }

        [Column(Order = 2)]
        //nao sera auto increment
        public Nullable<int> IdAtendimento { get; set; }

        [Display(Name = "Atendimento")]
        [ForeignKey("IdAtendimento")]
        public virtual Atendimento Atendimento { get; set; }

        [Display(Name = "Centro de Custo")]
        [ForeignKey("IdCentroCusto")]
        public virtual CentroCusto CentroCusto { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Centro de Custo não informado")]
        public int IdCentroCusto { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Filial não informada")]
        public int IdFilial { get; set; }

        [Display(Name = "Filial")]
        [ForeignKey("IdFilial")]
        public virtual EmpresaFilial Filial { get; set; }

        [Required]
        [Display(Name = "Relatório de manutencão")]
        [StringLength(int.MaxValue, MinimumLength = 5)]
        [Column(TypeName = "Text")]
        public string RelatorioManutencao { get; set; }

        public DateTime Data { get; set; }

        [Required]
        //[Column(TypeName = "date")]
        public DateTime DataInicial { get; set; }

        [Required]
        //[Column(TypeName = "date")]
        public DateTime DataTermino { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataEntrega { get; set; }

        [Required]
        [Column()]
        public TimeSpan Duracao { get; set; }

        [Required]
        //[Column()]
        [Range(10, int.MaxValue, ErrorMessage = "Valor minímo da manutenção é R$ 10,00")]
        public decimal ValorManutencao { get; set; }

        [Required]
        [Column()]
        public decimal Desconto { get; set; }


        [Range(0, int.MaxValue, ErrorMessage = "Status da Manutenção não informado")]
        public TypeStatusManutencao StatusManutencao { get; set; }

        public virtual ICollection<Computador> Computadores { get; set; }

        public virtual ICollection<ItemManutencao> ItensManutencao { get; set; }

        #region Nao mapeado - Utilizado somente para controle interno

        [NotMapped]
        public Image Image
        {
            get
            {
                switch (this.StatusManutencao)
                {
                    case TypeStatusManutencao.AtendimentoLocal:
                        return Properties.Resources.status_16x16;

                    case TypeStatusManutencao.Andamento:
                        return Properties.Resources.about_16x16;

                    case TypeStatusManutencao.Encerrado:
                        return Properties.Resources.apply_16x16;

                    case TypeStatusManutencao.Cancelado:
                        return Properties.Resources.cancel_16x16;

                    case TypeStatusManutencao.Pendente:
                        return Properties.Resources.index_16x16;

                    default:
                        return Properties.Resources.apply_16x16;
                }
            }
        }




        #endregion Nao mapeado - Utilizado somente para controle interno

        public Manutencao()
        {
            this.ItensManutencao = new HashSet<ItemManutencao>();
            this.Computadores = new HashSet<Computador>();
            this.RelatorioManutencao = null;
            DateTime data = DateTime.Now;
            this.Data = data;
            this.DataInicial = data;
            this.DataTermino = data;
            this.DataEntrega = data;
            this.Duracao = new TimeSpan(0, 0, 0);
            this.ValorManutencao = 0;
            this.Desconto = 0;
        }

        public Manutencao(Atendimento atendimento, String relatorio, DateTime dtInicial, DateTime dtTermino, DateTime dtEntrega, TimeSpan duracao, decimal valor, decimal desconto)
                : this()
        {
            this.IdAtendimento = atendimento != null ? atendimento.IdAtendimento : 0;

            this.RelatorioManutencao = relatorio;
            this.DataInicial = dtInicial;
            this.DataTermino = dtTermino;
            this.DataEntrega = dtEntrega;
            this.Duracao = duracao;
            this.ValorManutencao = valor;
            this.Desconto = desconto;
        }

        public void Update(Manutencao novo)
        {
            this.RelatorioManutencao = novo.RelatorioManutencao;
            this.DataInicial = novo.DataInicial;
            this.DataTermino = novo.DataTermino;
            this.DataEntrega = novo.DataEntrega;
            this.Duracao = novo.Duracao;
            this.ValorManutencao = novo.ValorManutencao;
            this.Desconto = novo.Desconto;
            this.StatusManutencao = novo.StatusManutencao;
        }


        public override string ToString()
        {
            return "" + IdManutencao + " " + ValorManutencao;
        }

    }
}
