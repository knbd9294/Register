namespace Register.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class telephAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.infoes", "Tel", c => c.Int());
        }

        public override void Down()
        {
            DropColumn("dbo.infoes", "Tel");
        }
    }
}