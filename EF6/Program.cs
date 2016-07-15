using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF6.Context;
using EF6.Entity;

namespace EF6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FootballContext())
            {
                try
                {
                    var p1 = new Player
                    {
                        FirstName = "Player1"
                    };

                    var p2 = new Player
                    {
                        FirstName = "Player2"
                    };

                    var t1 = new Team()
                    {
                        Name = "Team1",
                        Players = new List<Player>() {p1,p2 }
                        
                    };
                    context.Teams.Add(t1);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                }
            }
        }
    }
}
