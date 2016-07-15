using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6.Entity
{
    public class Player
    {
        public int PlayerId { get; set; }
        
        public string FirstName { get; set; }

        public int Order { get; set; }
    }
}
