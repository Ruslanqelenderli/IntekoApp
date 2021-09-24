namespace Proj.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product_And_Phone : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmployeeName = c.String(),
                        EmployeeSurname = c.String(),
                        Position = c.String(),
                        Number = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        CompanyName = c.String(),
                        VoenPassword = c.String(),
                        District = c.String(),
                        Address = c.String(),
                        ApproximateLocation = c.String(),
                        CashireModel = c.String(),
                        ContractNO = c.String(),
                        RegistrationDate = c.String(),
                        EmployeeWhoConnects = c.String(),
                        EmployeeWhoSells = c.String(),
                        PhoneId = c.Guid(nullable: false),
                        TypeOfPayment = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServicePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellesPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WrittenByOrxan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxInterest = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phones", t => t.PhoneId, cascadeDelete: true)
                .Index(t => t.PhoneId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "PhoneId", "dbo.Phones");
            DropIndex("dbo.Products", new[] { "PhoneId" });
            DropTable("dbo.Products");
            DropTable("dbo.Phones");
        }
    }
}
