namespace NBP_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class audit_all : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArtWorkAudits",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TriggerMethod = c.String(),
                        TriggerUser = c.String(),
                        TriggerTime = c.DateTimeOffset(precision: 7),
                        ArtWorkId = c.Guid(nullable: false),
                        Title = c.String(),
                        Year = c.Int(),
                        Price = c.Double(),
                        Description = c.String(),
                        UpdateTime = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RentalAudits",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TriggerMethod = c.String(),
                        TriggerUser = c.String(),
                        TriggerTime = c.DateTimeOffset(precision: 7),
                        RentalId = c.Guid(nullable: false),
                        StartDate = c.DateTimeOffset(precision: 7),
                        EndDate = c.DateTimeOffset(precision: 7),
                        Price = c.Double(),
                        UpdateTime = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RentalAudits");
            DropTable("dbo.ArtWorkAudits");
        }
    }
}
