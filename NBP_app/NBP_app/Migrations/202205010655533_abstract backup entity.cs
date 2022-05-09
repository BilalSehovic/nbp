namespace NBP_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abstractbackupentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArtWorks", "UpdateTime", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Artists", "UpdateTime", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.Rentals", "UpdateTime", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "UpdateTime");
            DropColumn("dbo.Artists", "UpdateTime");
            DropColumn("dbo.ArtWorks", "UpdateTime");
        }
    }
}
