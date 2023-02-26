namespace Register.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.infoes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FingerPrint = c.String(),
                    Date = c.DateTime(nullable: false),
                    Name = c.String(),
                    Surname = c.String(),
                    Cni = c.String(),
                    Qualite = c.String(),
                    MotifVisite = c.String(),
                    ServiceVisite = c.String(),
                    HeureEntrer = c.DateTime(nullable: false),
                    HeureSortie = c.DateTime(),
                    Note = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.infoes");
        }
    }
}