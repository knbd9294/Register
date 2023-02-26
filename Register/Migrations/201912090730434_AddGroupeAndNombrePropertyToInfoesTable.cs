namespace Register.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupeAndNombrePropertyToInfoesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.infoes", "Groupe", c => c.Boolean(nullable: false));
            AddColumn("dbo.infoes", "Nombre", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.infoes", "Nombre");
            DropColumn("dbo.infoes", "Groupe");
        }
    }
}
