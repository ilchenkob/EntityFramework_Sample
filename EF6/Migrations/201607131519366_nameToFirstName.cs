namespace EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameToFirstName : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Players", "Name", "FirstName");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Players", "FirstName", "Name");
        }
    }
}
