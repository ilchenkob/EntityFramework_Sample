using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF6.Entity;
using EF6.Migrations;

namespace EF6.Context
{
    public class FootballContext: DbContext
    {
        public FootballContext() : base("FootballContext")
        {
            //Database.SetInitializer<FootballContext>(new FootballContextInitializer());
            Database.SetInitializer<FootballContext>(new MigrateDatabaseToLatestVersion<FootballContext, Configuration>());
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Team>().HasOptional(x => x.Player).WithRequired(p => p.Team);


        //}
    }
}
