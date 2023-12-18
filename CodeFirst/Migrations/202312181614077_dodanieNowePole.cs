namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodanieNowePole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kontakts", "NowePole", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kontakts", "NowePole");
        }
    }
}
