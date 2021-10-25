namespace Proj.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Surname : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Surname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Surname", c => c.String());
        }
    }
}
