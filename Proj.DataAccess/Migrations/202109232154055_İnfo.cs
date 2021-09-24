namespace Proj.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class İnfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "İnfo", c => c.String());
            AlterColumn("dbo.Products", "ContractNO", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ContractNO", c => c.String());
            DropColumn("dbo.Products", "İnfo");
        }
    }
}
