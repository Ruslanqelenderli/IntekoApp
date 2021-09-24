namespace Proj.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mistake : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "PhoneId", "dbo.Phones");
            DropIndex("dbo.Products", new[] { "PhoneId" });
            AddColumn("dbo.Phones", "ProductId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Phones", "ProductId");
            AddForeignKey("dbo.Phones", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "PhoneId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "PhoneId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Phones", "ProductId", "dbo.Products");
            DropIndex("dbo.Phones", new[] { "ProductId" });
            DropColumn("dbo.Phones", "ProductId");
            CreateIndex("dbo.Products", "PhoneId");
            AddForeignKey("dbo.Products", "PhoneId", "dbo.Phones", "Id", cascadeDelete: true);
        }
    }
}
