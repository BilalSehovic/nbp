namespace NBP_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class artist_audit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArtistAudits", "ArtistId", c => c.Guid(nullable: false));
            AddColumn("dbo.ArtistAudits", "FirstName", c => c.String());
            AddColumn("dbo.ArtistAudits", "LastName", c => c.String());
            AddColumn("dbo.ArtistAudits", "BirthDate", c => c.DateTimeOffset(precision: 7));
            AddColumn("dbo.ArtistAudits", "BirthPlace", c => c.String());
            AddColumn("dbo.ArtistAudits", "PhoneNumber", c => c.String());
            AddColumn("dbo.ArtistAudits", "Style", c => c.String());
            AddColumn("dbo.ArtistAudits", "UpdateTime", c => c.DateTimeOffset(nullable: false, precision: 7));
            DropColumn("dbo.ArtistAudits", "TriggerProperty");
            DropColumn("dbo.ArtistAudits", "OldValue");
            DropColumn("dbo.ArtistAudits", "NewValue");
            DropColumn("dbo.ArtistAudits", "Table");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ArtistAudits", "Table", c => c.String());
            AddColumn("dbo.ArtistAudits", "NewValue", c => c.String());
            AddColumn("dbo.ArtistAudits", "OldValue", c => c.String());
            AddColumn("dbo.ArtistAudits", "TriggerProperty", c => c.String());
            DropColumn("dbo.ArtistAudits", "UpdateTime");
            DropColumn("dbo.ArtistAudits", "Style");
            DropColumn("dbo.ArtistAudits", "PhoneNumber");
            DropColumn("dbo.ArtistAudits", "BirthPlace");
            DropColumn("dbo.ArtistAudits", "BirthDate");
            DropColumn("dbo.ArtistAudits", "LastName");
            DropColumn("dbo.ArtistAudits", "FirstName");
            DropColumn("dbo.ArtistAudits", "ArtistId");
        }
    }
}
