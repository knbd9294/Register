namespace Register.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.infoes", "Date", c => c.DateTime());
        }

        public override void Down()
        {
            AlterColumn("dbo.infoes", "Date", c => c.DateTime(nullable: false));
        }
    }
}