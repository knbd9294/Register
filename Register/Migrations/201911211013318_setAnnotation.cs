namespace Register.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class setAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.infoes", "FingerPrint", c => c.String(nullable: false));
            AlterColumn("dbo.infoes", "Name", c => c.String(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.infoes", "Name", c => c.String());
            AlterColumn("dbo.infoes", "FingerPrint", c => c.String());
        }
    }
}