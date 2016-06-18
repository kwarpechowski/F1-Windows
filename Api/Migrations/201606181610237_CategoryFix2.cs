namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryFix2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Orders", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Orders", new[] { "Category_Id" });
            DropIndex("dbo.Categories", new[] { "Category_Id" });
            DropColumn("dbo.Orders", "Category_Id");
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "Category_Id", c => c.Int());
            CreateIndex("dbo.Categories", "Category_Id");
            CreateIndex("dbo.Orders", "Category_Id");
            AddForeignKey("dbo.Orders", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Categories", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
