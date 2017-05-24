namespace FitAndSweet.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMealTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MealTypes (Id,Name) VALUES (1, 'Breakfast')");
            Sql("INSERT INTO MealTypes (Id,Name) VALUES (2, 'MainCourse')");
            Sql("INSERT INTO MealTypes (Id,Name) VALUES (3, 'Soup')");
            Sql("INSERT INTO MealTypes (Id,Name) VALUES (4, 'Snack')");
            Sql("INSERT INTO MealTypes (Id,Name) VALUES (5, 'Salad')");
            Sql("INSERT INTO MealTypes (Id,Name) VALUES (6, 'Supper')");
        }

        public override void Down()
        {
            Sql("DELETE FROM MealTypes WHERE Id IN(1,2,3,4,5,6)");
        }
    }
}
