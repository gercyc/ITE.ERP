using System.Data.Entity.ModelConfiguration;
using ITE.Entidades.POCO;

namespace ITE.Entidades.Repositorio.MapFluentAPI
{
    class GrupoUsuarioMap : EntityTypeConfiguration<GrupoUsuario>
    {

        public GrupoUsuarioMap()
        {
         this.Property(e => e.NomeGrupoUsuario)
         .IsUnicode(false);

            this.HasMany(e => e.Usuarios)
                .WithRequired(e => e.GrupoUsuario)
                .HasForeignKey(e => e.IdGrupoUsuario)
                //na falta do grupo as tuplas sao deletadas
                .WillCascadeOnDelete(true);
        }
    }
}
