using System.Data.Entity.ModelConfiguration;
using ITE.Entidades.POCO.CE;

namespace ITE.Entidades.Repositorio.MapFluentAPI
{
    class CusteioMap : EntityTypeConfiguration<Custeio>
    {
        public CusteioMap()
        {
            this.HasMany(e => e.ItensCusteio)
                .WithRequired(e => e.Custeio)
                .WillCascadeOnDelete(true);

        }
    }
}
