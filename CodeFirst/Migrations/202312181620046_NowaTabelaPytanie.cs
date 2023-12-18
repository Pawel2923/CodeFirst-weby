namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NowaTabelaPytanie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pytanies",
                c => new
                    {
                        PytanieId = c.Int(nullable: false, identity: true),
                        TrescPytania = c.String(),
                        SkruconaTresc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PytanieId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pytanies");
        }
    }
}
