namespace Register.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.infos", "HeureEntrer", c => c.DateTime());
        }

        public override void Down()
        {
            AlterColumn("dbo.infos", "HeureEntrer", c => c.DateTime(nullable: false));
        }
    }
}