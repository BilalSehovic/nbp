using NBP_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.PopulateDb
{
    public static partial class PopulateDb
    {
        #region side tables
        public static void PopulatePlaces(NbpContext context)
        {
            context.Places.Add(new Place
            {
                Address = "Louvre Museum",
                City = "Paris",
                Country = "France"
            });
            context.Places.Add(new Place
            {
                Address = "British Museum",
                City = "London",
                Country = "United Kingdom"
            });
            context.Places.Add(new Place
            {
                Address = "The Metropolitan Museum",
                City = "New York",
                Country = "United States"
            });
        }

        public static void PopulateCustomers(NbpContext context)
        {
            context.Customers.Add(new Customer
            {
                FirstName = "Emma",
                LastName = "Martin",
                PlaceId = context.Places.FirstOrDefault(e => e.City == "Paris").Id
            });
            context.Customers.Add(new Customer
            {
                FirstName = "Oliver",
                LastName = "Smith",
                PlaceId = context.Places.FirstOrDefault(e => e.City == "London").Id
            });
            context.Customers.Add(new Customer
            {
                FirstName = "Nancy",
                LastName = "Williams",
                PlaceId = context.Places.FirstOrDefault(e => e.City == "New York").Id
            });
        }

        public static void PopulateNfts(NbpContext context)
        {
            context.Nfts.Add(new Nft
            {
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Starry Night").Id,
                NftHash = "random_hash_23313"
            });
            context.Nfts.Add(new Nft
            {
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Mona Lisa").Id,
                NftHash = "random_hash_41414"
            });
            context.Nfts.Add(new Nft
            {
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "The Night Watch").Id,
                NftHash = "random_hash_51515"
            });
        }

        public static void PopulateNftOwnerHistories(NbpContext context)
        {
            context.NftOwnerHistories.Add(new NftOwnerHistory
            {
                Date = DateTime.Now.AddDays(-50),
                Owner = "Angela Merkel",
                NftId = context.Nfts.FirstOrDefault(e => e.NftHash == "random_hash_23313").Id
            });
            context.NftOwnerHistories.Add(new NftOwnerHistory
            {
                Date = DateTime.Now.AddDays(-20),
                Owner = "Christian Schilling",
                NftId = context.Nfts.FirstOrDefault(e => e.NftHash == "random_hash_23313").Id
            });
            context.NftOwnerHistories.Add(new NftOwnerHistory
            {
                Date = DateTime.Now.AddDays(-5),
                Owner = "Christian Schmidt",
                NftId = context.Nfts.FirstOrDefault(e => e.NftHash == "random_hash_23313").Id
            });
        }

        public static void PopulateExhibitions(NbpContext context)
        {
            context.Exhibitions.Add(new Exhibition
            {
                NameGallery = "Louvre Museum",
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                PlaceId = context.Places.FirstOrDefault(e => e.City == "Paris").Id
            });
            context.Exhibitions.Add(new Exhibition
            {
                NameGallery = "British Museum",
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                PlaceId = context.Places.FirstOrDefault(e => e.City == "London").Id
            });
            context.Exhibitions.Add(new Exhibition
            {
                NameGallery = "The Metropolitan Museum",
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                PlaceId = context.Places.FirstOrDefault(e => e.City == "New York").Id
            });
        }

        public static void PopulateArtExhibitions(NbpContext context)
        {
            context.ArtExhibitions.Add(new ArtExhibition
            {
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Starry Night").Id,
                ExhibitionId = context.Exhibitions.FirstOrDefault(e => e.NameGallery == "Louvre Museum").Id
            });
            context.ArtExhibitions.Add(new ArtExhibition
            {
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Mona Lisa").Id,
                ExhibitionId = context.Exhibitions.FirstOrDefault(e => e.NameGallery == "British Museum").Id
            });
            context.ArtExhibitions.Add(new ArtExhibition
            {
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "The Night Watch").Id,
                ExhibitionId = context.Exhibitions.FirstOrDefault(e => e.NameGallery == "The Metropolitan Museum").Id
            });
        }

        public static void PopulateOrderToBuys(NbpContext context)
        {
            context.OrderToBuys.Add(new OrderToBuy
            {
                Price = 1000000000.00,
                Date = DateTime.Now,
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Starry Night").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Emma").Id
            });
            context.OrderToBuys.Add(new OrderToBuy
            {
                Price = 1000000000.00,
                Date = DateTime.Now,
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Mona Lisa").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Oliver").Id,
            });
            context.OrderToBuys.Add(new OrderToBuy
            {
                Price = 1000000000.00,
                Date = DateTime.Now,
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "The Night Watch").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Nancy").Id
            });
        }
        #endregion
    }
}
