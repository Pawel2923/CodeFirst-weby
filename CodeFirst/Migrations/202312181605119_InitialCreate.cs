namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kontakts",
                c => new
                    {
                        KontaktId = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false),
                        Nazwisko = c.String(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.KontaktId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kontakts");
        }
    }
}
