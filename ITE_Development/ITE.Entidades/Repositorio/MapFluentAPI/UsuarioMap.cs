using System.Data.Entity.ModelConfiguration;
using ITE.Entidades.POCO;

namespace ITE.Entidades.Repositorio.MapFluentAPI
{
    class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {


            this
                .Property(e => e.NomeUsuario)
                .IsUnicode(false);

            this
                .Property(e => e.NomeUtilizador)
                .IsUnicode(false);

            this
                .Property(e => e.Senha).IsUnicode(false);

            this
                .Property(e => e.Skin)
                .IsUnicode(false);

            }
    }
}
