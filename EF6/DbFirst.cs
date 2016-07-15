namespace EF6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbFirst : DbContext
    {
        public DbFirst()
            : base("name=DbFirst")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teams>()
                .HasMany(e => e.Players)
                .WithOptional(e => e.Teams)
                .HasForeignKey(e => e.Team_TeamId);
        }
    }
}
