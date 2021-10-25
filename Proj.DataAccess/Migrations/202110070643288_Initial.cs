namespace Proj.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Expensetyps",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MonthlyPayments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MonthName = c.String(),
                        ProductId = c.Guid(nullable: false),
                        Paid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
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
                        ContractNO = c.Int(nullable: false, identity: true),
                        RegistrationDate = c.DateTime(nullable: false),
                        EmployeeWhoConnects = c.String(),
                        EmployeeWhoSells = c.String(),
                        TypeOfPayment = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServicePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SellesPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WrittenByOrxan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        İnfo = c.String(),
                        PaymentStatus = c.String(),
                        InitialPayment = c.Boolean(nullable: false),
                        OfficeMncPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceDebt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SendDate = c.DateTime(),
                        UnpaidMonths = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmployeeName = c.String(),
                        EmployeeSurname = c.String(),
                        Position = c.String(),
                        Number = c.String(),
                        ProductId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        UserName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "ProductId", "dbo.Products");
            DropForeignKey("dbo.MonthlyPayments", "ProductId", "dbo.Products");
            DropIndex("dbo.Phones", new[] { "ProductId" });
            DropIndex("dbo.MonthlyPayments", new[] { "ProductId" });
            DropTable("dbo.Users");
            DropTable("dbo.Phones");
            DropTable("dbo.Products");
            DropTable("dbo.MonthlyPayments");
            DropTable("dbo.Logs");
            DropTable("dbo.Expensetyps");
            DropTable("dbo.Expenses");
        }
    }
}
