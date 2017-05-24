namespace FitAndSweet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForRecipeAndMealType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Recipes", "Author_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Recipes", "Type_Id", "dbo.MealTypes");
            DropIndex("dbo.Recipes", new[] { "Author_Id" });
            DropIndex("dbo.Recipes", new[] { "Type_Id" });
            AlterColumn("dbo.MealTypes", "Name", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.Recipes", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Recipes", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Recipes", "Author_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Recipes", "Type_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Recipes", "Author_Id");
            CreateIndex("dbo.Recipes", "Type_Id");
            AddForeignKey("dbo.Recipes", "Author_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Recipes", "Type_Id", "dbo.MealTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "Type_Id", "dbo.MealTypes");
            DropForeignKey("dbo.Recipes", "Author_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Recipes", new[] { "Type_Id" });
            DropIndex("dbo.Recipes", new[] { "Author_Id" });
            AlterColumn("dbo.Recipes", "Type_Id", c => c.Byte());
            AlterColumn("dbo.Recipes", "Author_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Recipes", "Description", c => c.String());
            AlterColumn("dbo.Recipes", "Name", c => c.String());
            AlterColumn("dbo.MealTypes", "Name", c => c.String());
            CreateIndex("dbo.Recipes", "Type_Id");
            CreateIndex("dbo.Recipes", "Author_Id");
            AddForeignKey("dbo.Recipes", "Type_Id", "dbo.MealTypes", "Id");
            AddForeignKey("dbo.Recipes", "Author_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
