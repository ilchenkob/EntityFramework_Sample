using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.Entity
{
    public class Team
    {
        public int TeamId { get; set; }
        
        public string Name { get; set; }

        public List<Player> Players { get; set; }
    }
}
