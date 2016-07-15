namespace EF6
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Players
    {
        [Key]
        public int PlayerId { get; set; }

        public string FirstName { get; set; }

        public int? Team_TeamId { get; set; }

        public int Order { get; set; }

        public virtual Teams Teams { get; set; }
    }
}
