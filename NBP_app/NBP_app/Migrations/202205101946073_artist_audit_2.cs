namespace NBP_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class artist_audit_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArtistAudits", "TriggerMethod", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ArtistAudits", "TriggerMethod");
        }
    }
}
