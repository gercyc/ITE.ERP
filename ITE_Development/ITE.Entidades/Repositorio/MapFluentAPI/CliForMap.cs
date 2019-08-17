using System.Data.Entity.ModelConfiguration;
using ITE.Entidades.POCO;

namespace ITE.Entidades.Repositorio.MapFluentAPI
{
    class ClienteMap : EntityTypeConfiguration<CliFor>
    {
        public ClienteMap()
        {
            this .HasMany(e => e.Invoices)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);
        }
    }
}
