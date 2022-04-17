namespace NBP_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationshipsfixes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderToBuyArtWorks", "OrderToBuy_Id", "dbo.OrderToBuys");
            DropForeignKey("dbo.OrderToBuyArtWorks", "ArtWork_Id", "dbo.ArtWorks");
            DropForeignKey("dbo.RentalArtWorks", "Rental_Id", "dbo.Rentals");
            DropForeignKey("dbo.RentalArtWorks", "ArtWork_Id", "dbo.ArtWorks");
            DropForeignKey("dbo.ArtWorks", "ArtistId", "dbo.Artists");
            DropIndex("dbo.ArtWorks", new[] { "ArtistId" });
            DropIndex("dbo.OrderToBuyArtWorks", new[] { "OrderToBuy_Id" });
            DropIndex("dbo.OrderToBuyArtWorks", new[] { "ArtWork_Id" });
            DropIndex("dbo.RentalArtWorks", new[] { "Rental_Id" });
            DropIndex("dbo.RentalArtWorks", new[] { "ArtWork_Id" });
            AddColumn("dbo.OrderToBuys", "ArtWorkId", c => c.Guid(nullable: false));
            AddColumn("dbo.Rentals", "ArtWorkId", c => c.Guid());
            AlterColumn("dbo.ArtWorks", "ArtistId", c => c.Guid(nullable: false));
            CreateIndex("dbo.ArtWorks", "ArtistId");
            CreateIndex("dbo.OrderToBuys", "ArtWorkId");
            CreateIndex("dbo.Rentals", "ArtWorkId");
            AddForeignKey("dbo.OrderToBuys", "ArtWorkId", "dbo.ArtWorks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rentals", "ArtWorkId", "dbo.ArtWorks", "Id");
            AddForeignKey("dbo.ArtWorks", "ArtistId", "dbo.Artists", "Id", cascadeDelete: true);
            DropTable("dbo.OrderToBuyArtWorks");
            DropTable("dbo.RentalArtWorks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RentalArtWorks",
                c => new
                    {
                        Rental_Id = c.Guid(nullable: false),
                        ArtWork_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rental_Id, t.ArtWork_Id });
            
            CreateTable(
                "dbo.OrderToBuyArtWorks",
                c => new
                    {
                        OrderToBuy_Id = c.Guid(nullable: false),
                        ArtWork_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderToBuy_Id, t.ArtWork_Id });
            
            DropForeignKey("dbo.ArtWorks", "ArtistId", "dbo.Artists");
            DropForeignKey("dbo.Rentals", "ArtWorkId", "dbo.ArtWorks");
            DropForeignKey("dbo.OrderToBuys", "ArtWorkId", "dbo.ArtWorks");
            DropIndex("dbo.Rentals", new[] { "ArtWorkId" });
            DropIndex("dbo.OrderToBuys", new[] { "ArtWorkId" });
            DropIndex("dbo.ArtWorks", new[] { "ArtistId" });
            AlterColumn("dbo.ArtWorks", "ArtistId", c => c.Guid());
            DropColumn("dbo.Rentals", "ArtWorkId");
            DropColumn("dbo.OrderToBuys", "ArtWorkId");
            CreateIndex("dbo.RentalArtWorks", "ArtWork_Id");
            CreateIndex("dbo.RentalArtWorks", "Rental_Id");
            CreateIndex("dbo.OrderToBuyArtWorks", "ArtWork_Id");
            CreateIndex("dbo.OrderToBuyArtWorks", "OrderToBuy_Id");
            CreateIndex("dbo.ArtWorks", "ArtistId");
            AddForeignKey("dbo.ArtWorks", "ArtistId", "dbo.Artists", "Id");
            AddForeignKey("dbo.RentalArtWorks", "ArtWork_Id", "dbo.ArtWorks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RentalArtWorks", "Rental_Id", "dbo.Rentals", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderToBuyArtWorks", "ArtWork_Id", "dbo.ArtWorks", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OrderToBuyArtWorks", "OrderToBuy_Id", "dbo.OrderToBuys", "Id", cascadeDelete: true);
        }
    }
}
