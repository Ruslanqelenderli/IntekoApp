namespace Proj.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class No : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "No", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "No");
        }
    }
}
