namespace NBP_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime2datetimeoffset : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NftOwnerHistories", "Date", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.OrderToBuys", "Date", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Rentals", "StartDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Rentals", "EndDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Exhibitions", "StartDate", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.Exhibitions", "EndDate", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Exhibitions", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Exhibitions", "StartDate", c => c.DateTime());
            AlterColumn("dbo.Rentals", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Rentals", "StartDate", c => c.DateTime());
            AlterColumn("dbo.OrderToBuys", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NftOwnerHistories", "Date", c => c.DateTime(nullable: false));
        }
    }
}
