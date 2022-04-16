namespace NBP_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArtExhibitions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ArtWorkId = c.Guid(nullable: false),
                        ExhibitionId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArtWorks", t => t.ArtWorkId, cascadeDelete: true)
                .ForeignKey("dbo.Exhibitions", t => t.ExhibitionId, cascadeDelete: true)
                .Index(t => t.ArtWorkId)
                .Index(t => t.ExhibitionId);
            
            CreateTable(
                "dbo.ArtWorks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Year = c.Int(),
                        Price = c.Double(),
                        Description = c.String(),
                        ArtistId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artists", t => t.ArtistId)
                .Index(t => t.ArtistId);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(),
                        BirthPlace = c.String(),
                        PhoneNumber = c.String(),
                        Style = c.String(),
                        PlaceId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Places", t => t.PlaceId)
                .Index(t => t.PlaceId);
            
            CreateTable(
                "dbo.Nfts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NftHash = c.String(),
                        ArtWorkId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArtWorks", t => t.ArtWorkId, cascadeDelete: true)
                .Index(t => t.ArtWorkId);
            
            CreateTable(
                "dbo.NftOwnerHistories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Owner = c.String(),
                        Date = c.DateTime(nullable: false),
                        NftId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nfts", t => t.NftId, cascadeDelete: true)
                .Index(t => t.NftId);
            
            CreateTable(
                "dbo.OrderToBuys",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Price = c.Double(),
                        Date = c.DateTime(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        PlaceId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Places", t => t.PlaceId)
                .Index(t => t.PlaceId);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        Price = c.Double(),
                        CustomerId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Exhibitions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NameGallery = c.String(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        PlaceId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Places", t => t.PlaceId)
                .Index(t => t.PlaceId);
            
            CreateTable(
                "dbo.OrderToBuyArtWorks",
                c => new
                    {
                        OrderToBuy_Id = c.Guid(nullable: false),
                        ArtWork_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderToBuy_Id, t.ArtWork_Id })
                .ForeignKey("dbo.OrderToBuys", t => t.OrderToBuy_Id, cascadeDelete: true)
                .ForeignKey("dbo.ArtWorks", t => t.ArtWork_Id, cascadeDelete: true)
                .Index(t => t.OrderToBuy_Id)
                .Index(t => t.ArtWork_Id);
            
            CreateTable(
                "dbo.RentalArtWorks",
                c => new
                    {
                        Rental_Id = c.Guid(nullable: false),
                        ArtWork_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rental_Id, t.ArtWork_Id })
                .ForeignKey("dbo.Rentals", t => t.Rental_Id, cascadeDelete: true)
                .ForeignKey("dbo.ArtWorks", t => t.ArtWork_Id, cascadeDelete: true)
                .Index(t => t.Rental_Id)
                .Index(t => t.ArtWork_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exhibitions", "PlaceId", "dbo.Places");
            DropForeignKey("dbo.ArtExhibitions", "ExhibitionId", "dbo.Exhibitions");
            DropForeignKey("dbo.Rentals", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.RentalArtWorks", "ArtWork_Id", "dbo.ArtWorks");
            DropForeignKey("dbo.RentalArtWorks", "Rental_Id", "dbo.Rentals");
            DropForeignKey("dbo.Customers", "PlaceId", "dbo.Places");
            DropForeignKey("dbo.OrderToBuys", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderToBuyArtWorks", "ArtWork_Id", "dbo.ArtWorks");
            DropForeignKey("dbo.OrderToBuyArtWorks", "OrderToBuy_Id", "dbo.OrderToBuys");
            DropForeignKey("dbo.NftOwnerHistories", "NftId", "dbo.Nfts");
            DropForeignKey("dbo.Nfts", "ArtWorkId", "dbo.ArtWorks");
            DropForeignKey("dbo.Artists", "PlaceId", "dbo.Places");
            DropForeignKey("dbo.ArtWorks", "ArtistId", "dbo.Artists");
            DropForeignKey("dbo.ArtExhibitions", "ArtWorkId", "dbo.ArtWorks");
            DropIndex("dbo.RentalArtWorks", new[] { "ArtWork_Id" });
            DropIndex("dbo.RentalArtWorks", new[] { "Rental_Id" });
            DropIndex("dbo.OrderToBuyArtWorks", new[] { "ArtWork_Id" });
            DropIndex("dbo.OrderToBuyArtWorks", new[] { "OrderToBuy_Id" });
            DropIndex("dbo.Exhibitions", new[] { "PlaceId" });
            DropIndex("dbo.Rentals", new[] { "CustomerId" });
            DropIndex("dbo.Customers", new[] { "PlaceId" });
            DropIndex("dbo.OrderToBuys", new[] { "CustomerId" });
            DropIndex("dbo.NftOwnerHistories", new[] { "NftId" });
            DropIndex("dbo.Nfts", new[] { "ArtWorkId" });
            DropIndex("dbo.Artists", new[] { "PlaceId" });
            DropIndex("dbo.ArtWorks", new[] { "ArtistId" });
            DropIndex("dbo.ArtExhibitions", new[] { "ExhibitionId" });
            DropIndex("dbo.ArtExhibitions", new[] { "ArtWorkId" });
            DropTable("dbo.RentalArtWorks");
            DropTable("dbo.OrderToBuyArtWorks");
            DropTable("dbo.Exhibitions");
            DropTable("dbo.Rentals");
            DropTable("dbo.Customers");
            DropTable("dbo.OrderToBuys");
            DropTable("dbo.NftOwnerHistories");
            DropTable("dbo.Nfts");
            DropTable("dbo.Artists");
            DropTable("dbo.ArtWorks");
            DropTable("dbo.ArtExhibitions");
        }
    }
}
