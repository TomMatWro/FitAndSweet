namespace FitAndSweet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRecipeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MealTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Photo = c.String(),
                        Author_Id = c.String(maxLength: 128),
                        Type_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Author_Id)
                .ForeignKey("dbo.MealTypes", t => t.Type_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Type_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "Type_Id", "dbo.MealTypes");
            DropForeignKey("dbo.Recipes", "Author_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Recipes", new[] { "Type_Id" });
            DropIndex("dbo.Recipes", new[] { "Author_Id" });
            DropTable("dbo.Recipes");
            DropTable("dbo.MealTypes");
        }
    }
}
