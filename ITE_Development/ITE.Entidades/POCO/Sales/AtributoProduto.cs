using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ITE.Entidades.POCO.Sales
{
    public class AtributoProduto
    {

        [Column("Comprimento")]
        [Range(0, int.MaxValue, ErrorMessage = "Comprimento não informado.")]
        public decimal Comprimento { get; set; }

        [Column("Largura")]
        [Range(0, int.MaxValue, ErrorMessage = "Largura não informada.")]
        public decimal Largura { get; set; }

        [Column("Espessura1")]
        //Pode ser 1,5 a 2,5 por isso 1,5 a 2,5
        [Range(0, int.MaxValue, ErrorMessage = "Espessura 1 não informada.")]
        public decimal Espessura1 { get; set; }


        [Column("Espessura2")]
        [Range(0, int.MaxValue, ErrorMessage = "Espessura 2 não informada.")]
        public decimal Espessura2 { get; set; }

        [Column("Cor")]
        [StringLength(40)]
        public string Cor { get; set; }

        [Column("Acabamento")]
        [StringLength(100)]
        public string Acabamento { get; set; }

        [Column("Peso")]
        public decimal Peso { get; set; }

        [NotMapped]
        public decimal ValorMetroQuadrado { get; set; }

        [NotMapped]
        public string NomeMaterial { get; set; }


        public AtributoProduto()
        {
            this.Comprimento = 0;
            this.Largura = 0;
            this.Espessura1 = 0;
            this.Espessura2 = 0;
            this.Peso = 0;
        }


        public void Update(Produto novo)
        {
            var attrib = novo.Atributos;

            this.Comprimento = attrib.Comprimento;
            this.Largura = attrib.Largura;
            this.Espessura1 = attrib.Espessura1;
            this.Espessura2 = attrib.Espessura2;
            this.Acabamento = attrib.Acabamento;
            this.Cor = attrib.Cor;
            this.Peso = attrib.Peso;

            var sb = new StringBuilder();

            if (novo.IdProduto != 999 || !novo.DescricaoProduto.Equals("Lajinha"))
            {
                sb.Append(Comprimento);
                sb.Append(" x ");
                sb.Append(Largura);
                sb.Append(" x ");
                sb.Append(Espessura1);
                sb.Append(" ~ ");
                sb.Append(Espessura2);
            }

            if (attrib.Comprimento != 0 && attrib.Largura != 0)
                novo.DescricaoProduto = sb.ToString();

            
        }


    }
}
