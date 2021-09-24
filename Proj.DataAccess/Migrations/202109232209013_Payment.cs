namespace Proj.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Payment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "PaymentStatus", c => c.String());
            AddColumn("dbo.Products", "InitialPayment", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Products", "RegistrationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "RegistrationDate", c => c.String());
            DropColumn("dbo.Products", "InitialPayment");
            DropColumn("dbo.Products", "PaymentStatus");
        }
    }
}
