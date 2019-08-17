using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Teste;

namespace ITSolution.Framework.Entities
{
    
    public partial class ModelRules : DbContext
    {
        public ModelRules()
            : base("name=ModelRules")
        {
        }

        public virtual DbSet<ITS_GROUP_RELATION_RULES> ITS_GROUP_RELATION_RULES { get; set; }
        public virtual DbSet<ITS_USER_RULES> ITS_USER_RULES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ITS_GROUP_RELATION_RULES>()
                .Property(e => e.IdRegra)
                .IsUnicode(false);

            modelBuilder.Entity<ITS_USER_RULES>()
                .Property(e => e.IdRegra)
                .IsUnicode(false);

            modelBuilder.Entity<ITS_USER_RULES>()
                .Property(e => e.CodigoRegra)
                .IsUnicode(false);

            modelBuilder.Entity<ITS_USER_RULES>()
                .Property(e => e.NomeRegra)
                .IsUnicode(false);

            modelBuilder.Entity<ITS_USER_RULES>()
                .Property(e => e.DescricaoRegra)
                .IsUnicode(false);

            modelBuilder.Entity<ITS_USER_RULES>()
                .HasMany(e => e.ITS_GROUP_RELATION_RULES)
                .WithRequired(e => e.ITS_USER_RULES)
                .WillCascadeOnDelete(false);
        }
    }
}
