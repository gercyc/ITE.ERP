using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITSolution.Framework.Entities;

namespace ITE.Entidades.POCO.CE
{
    public class AttachmentCusteio : AbstractAttach
    {

        [Key]//pk
        [Column]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAnexo { get; set; }

        public int IdCusteio { get; set; }

        [ForeignKey("IdCusteio ")]
        public Custeio Custeio { get; set; }

        public AttachmentCusteio()
        {
        }

        public AttachmentCusteio(string path)
            :base(path)
        {
        }

        public void Update(AttachmentCusteio anexo)
        {
            base.Update(anexo);
            this.IdCusteio = anexo.IdCusteio;
        }

    }
}
