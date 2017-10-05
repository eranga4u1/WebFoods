namespace WebFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuName = c.String(),
                        MenuDescription = c.String(),
                        MenuImage = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumberOfPersonsForDish = c.Int(nullable: false),
                        Ingredient = c.String(),
                        store_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Stores", t => t.store_ID)
                .Index(t => t.store_ID);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StoreName = c.String(),
                        StoreLogo = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        StoreCoverImage = c.String(),
                        StroreCoverImageOnTextOne = c.String(),
                        StroreCoverImageOnTextTwo = c.String(),
                        StroreCoverImageOnTextThree = c.String(),
                        StroreAboutUsTitle = c.String(),
                        StroreAboutUsDescription = c.String(),
                        StroreAboutUsImage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menus", "store_ID", "dbo.Stores");
            DropIndex("dbo.Menus", new[] { "store_ID" });
            DropTable("dbo.Stores");
            DropTable("dbo.Menus");
        }
    }
}
