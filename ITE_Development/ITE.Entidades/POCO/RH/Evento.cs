using ITE.Entidades.POCO.RH.Folha;
using ITE.RH.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITE.Entidades.POCO.RH
{
    [Serializable]
    [Table("Evento")]
    public class Evento
    {
        [Key]
        [Column("IdEvento")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvento { get; set; }

        [Required]
        [StringLength(10)]
        public string CodigoEvento { get; set; }

        [Required]
        [StringLength(200)]
        public string DescricaoEvento { get; set; }

        public TypeEvento TipoEvento { get; set; }

        public TypeReferenciaEvento TipoReferencia { get; set; }
        public TypeCodigoCalculo CodigoCalculo { get; set; }

        public bool SomaBaseIRRF { get; set; }

        public bool SomaBaseFGTS { get; set; }

        public bool SomaBaseINSS { get; set; }

        public ICollection<EventosGrupo> EventosGrupo { get; set; }

        public ICollection<FichaFinanceiraFuncionario> FichasFinanceira { get; set; }

        public Evento()
        {
            this.FichasFinanceira = new HashSet<FichaFinanceiraFuncionario>();
            this.EventosGrupo = new HashSet<EventosGrupo>();
        }

        public Evento(string codigo, string descricao, bool baseIRRF, bool baseFGTS, bool baseINSS)
        {
            this.CodigoEvento = codigo;
            this.DescricaoEvento = descricao;
            this.SomaBaseIRRF = baseIRRF;
            this.SomaBaseFGTS = baseFGTS;
            this.SomaBaseINSS = baseINSS;
        }
        public Evento(string codigo, string descricao, bool baseIRRF, bool baseFGTS, 
            bool baseINSS, TypeEvento te, TypeReferenciaEvento tre)
        {
            this.CodigoEvento = codigo;
            this.DescricaoEvento = descricao;
            this.SomaBaseIRRF = baseIRRF;
            this.SomaBaseFGTS = baseFGTS;
            this.SomaBaseINSS = baseINSS;
            this.TipoEvento = te;
            this.TipoReferencia = tre;
        }


        public override string ToString()
        {
            return this.DescricaoEvento;
        }

        public void Update(Evento novo)
        {
            this.CodigoEvento= novo.CodigoEvento;
            this.DescricaoEvento = novo.DescricaoEvento;
            this.TipoReferencia= novo.TipoReferencia;
            this.TipoEvento = novo.TipoEvento;
            this.CodigoCalculo = novo.CodigoCalculo;
            this.SomaBaseIRRF = novo.SomaBaseIRRF;
            this.SomaBaseINSS = novo.SomaBaseINSS;
            this.SomaBaseFGTS = novo.SomaBaseFGTS;
        }

    }
}
