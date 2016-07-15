namespace EF6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderToPlayer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Order", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Order");
        }
    }
}
