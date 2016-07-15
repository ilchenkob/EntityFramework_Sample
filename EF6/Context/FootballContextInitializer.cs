using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF6.Entity;

namespace EF6.Context
{
    public class FootballContextInitializer : DropCreateDatabaseIfModelChanges<FootballContext>
    {
        protected override void Seed(FootballContext context)
        {
            var t1 = new Team
            {
                Name = "SeedTeam1"
            };
            context.Teams.Add(t1);
            context.SaveChanges();
        }
    }
}
