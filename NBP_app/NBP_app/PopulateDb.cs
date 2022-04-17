using NBP_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app
{
    public static class PopulateDb
    {
        public static void Populate(NbpContext context)
        {
            FlushDb(context);
            context.SaveChanges();

            PopulateArtists(context);
            context.SaveChanges();
            PopulateArtWorks(context);
            context.SaveChanges();
            PopulatePlaces(context);
            context.SaveChanges();
            PopulateCustomers(context);
            context.SaveChanges();
            PopulateRentals(context);
            context.SaveChanges();
            PopulateExhibitions(context);
            context.SaveChanges();
            PopulateArtExhibitions(context);
            context.SaveChanges();
            PopulateOrderToBuys(context);
            context.SaveChanges();
            PopulateNfts(context);
            context.SaveChanges();
            PopulateNftOwnerHistories(context);
            context.SaveChanges();
        }

        #region main tables
        public static void PopulateArtists(NbpContext context)
        {
            context.Artists.Add(new Artist
            {
                FirstName = "Pablo",
                LastName = "Picasso",
                BirthDate = new DateTime(1881, 10, 25),
                BirthPlace = "Malaga, Spain"
            });
            context.SaveChanges();
            context.Artists.Add(new Artist
            {
                FirstName = "Vincent",
                LastName = "van Gogh",
                BirthDate = new DateTime(1853, 3, 30),
                BirthPlace = "Zundert, Netherlands"
            });
            context.SaveChanges();
            context.Artists.Add(new Artist
            {
                FirstName = "Leonardo",
                LastName = "da Vinci",
                BirthDate = new DateTime(1452, 4, 15),
                BirthPlace = "Anchiano, Italy"
            });
            context.SaveChanges();
            context.Artists.Add(new Artist
            {
                FirstName = "Michelangelo",
                LastName = "di Lodovico Buonarroti Simoni",
                BirthDate = new DateTime(1475, 3, 6),
                BirthPlace = "Arezzo, Republic of Florence"
            });
            context.SaveChanges();
            context.Artists.Add(new Artist
            {
                FirstName = "Salvador",
                LastName = "Dali",
                BirthDate = new DateTime(1904, 5, 11),
                BirthPlace = "Figueres, Spain"
            });
            context.SaveChanges();
            context.Artists.Add(new Artist
            {
                FirstName = "Frida",
                LastName = "Kahlo",
                BirthDate = new DateTime(1907, 7, 6),
                BirthPlace = "Mexico City, Mexico"
            });
            context.SaveChanges();
            context.Artists.Add(new Artist
            {
                FirstName = "Claude",
                LastName = "Monet",
                BirthDate = new DateTime(1840, 11, 14),
                BirthPlace = "Paris, France"
            });
            context.SaveChanges();
            context.Artists.Add(new Artist
            {
                FirstName = "Henri",
                LastName = "Matisse",
                BirthDate = new DateTime(1869, 12, 31),
                BirthPlace = "Le Cateau-Cambresis, France"
            });
            context.SaveChanges();
            context.Artists.Add(new Artist
            {
                FirstName = "Georgia",
                LastName = "O'Keeffe",
                BirthDate = new DateTime(1887, 11, 15),
                BirthPlace = "Sun Prairie, Wisconsin, United States"
            });
            context.SaveChanges();
            context.Artists.Add(new Artist
            {
                FirstName = "Rembrandt",
                LastName = "Harmenszoon van Rijn",
                BirthDate = new DateTime(1606, 7, 15),
                BirthPlace = "Leiden, Netherlands"
            });
            context.SaveChanges();
        }

        public static void PopulateArtWorks(NbpContext context)
        {  
            context.ArtWorks.Add(new ArtWork
            {
                Title = "Guernica",
                Year = 1937,
                Price = 200000000.00,
                Description = "Its depiction of an aerial bombing raid on the Basque town of Guernica in April 1937, during the Spanish Civil War, was an eerie visual prelude to the coming atrocities of World War II.",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Pablo").Id
            });
            context.ArtWorks.Add(new ArtWork
            {
                Title = "Starry Night",
                Year = 1889,
                Price = 100000000.00,
                Description = "it depicts the view from the east-facing window of his asylum room at Saint-Rémy-de-Provence, just before sunrise, with the addition of an imaginary village.",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Vincent").Id
            });
            context.ArtWorks.Add(new ArtWork
            {
                Title = "Mona Lisa",
                Year = 1503,
                Price = 850000000.00,
                Description = "the piece features a portrait of a seated woman set against an imaginary landscape",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Leonardo").Id
            });
            context.ArtWorks.Add(new ArtWork
            {
                Title = "David",
                Year = 1504,
                Price = 200000000.00,
                Description = "Standing 13'5″ tall, the double life-sized David is depicted patiently waiting for battle, prepped with slingshot in one hand and stone in the other",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Michelangelo").Id
            });
            context.ArtWorks.Add(new ArtWork
            {
                Title = "The Persistence of Memory",
                Year = 1931,
                Price = 100000000.00,
                Description = "a dream that Dalí himself had experienced, and the clocks may symbolize the passing of time as one experiences it in sleep or the persistence of time in the eyes of the dreamer",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Salvador").Id
            });
            context.ArtWorks.Add(new ArtWork
            {
                Title = "The Two Fridas",
                Year = 1939,
                Price = 1000.00,
                Description = "painting has different meanings, but it was painted when Kahlo was going through a divorce with her husband Diego Rivera, depicting her heartbreak and sadness",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Frida").Id
            });
            context.ArtWorks.Add(new ArtWork
            {
                Title = "Sunrise",
                Year = 1872,
                Price = 200000000.00,
                Description = "depicts the port of Le Havre, Monet's hometown. It is now displayed at the Musée Marmottan Monet in Paris",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Claude").Id
            });
            context.ArtWorks.Add(new ArtWork
            {
                Title = "Le bonheur de vivre",
                Year = 1906,
                Price = 0.00,
                Description = "In the painting, nude women and men cavort, play music, and dance in a landscape drenched with vivid color. In the central background of the piece is a group of figures that is similar to the group depicted in his painting The Dance",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Henri").Id
            });
            context.ArtWorks.Add(new ArtWork
            {
                Title = "Jimson Weed",
                Year = 1936,
                Price = 44000000.00,
                Description = "O'Keeffe reiterated the pinwheel-shaped flowers' structure in the tight placement of the four blossoms in the painting. Her use of rhythmic light and shade and a simplified palette underscores their fresh, simple beauty",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Georgia").Id
            });
            context.ArtWorks.Add(new ArtWork
            {
                Title = "The Night Watch",
                Year = 1642,
                Price = 925000.00,
                Description = "It is a group portrait of a militia company. These were groups of able-bodied men who, if the need arose, could be called upon to defend the city or put down riots",
                ArtistId = context.Artists.FirstOrDefault(e => e.FirstName == "Rembrandt").Id
            });
        }

        public static void PopulateRentals(NbpContext context)
        {
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Guernica").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Emma").Id
            });
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Starry Night").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Emma").Id
            });
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Mona Lisa").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Emma").Id
            });
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "David").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Oliver").Id
            });
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "The Persistence of Memory").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Oliver").Id
            });
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "The Two Fridas").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Oliver").Id
            });
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Sunrise").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Nancy").Id
            });
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Le bonheur de vivre").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Nancy").Id
            });
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "Jimson Weed").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Nancy").Id
            });
            context.Rentals.Add(new Rental
            {
                StartDate = new DateTime(2022, 1, 5),
                EndDate = new DateTime(2022, 12, 25),
                ArtWorkId = context.ArtWorks.FirstOrDefault(e => e.Title == "The Night Watch").Id,
                CustomerId = context.Customers.FirstOrDefault(e => e.FirstName == "Nancy").Id
            });
        }
        #endregion

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

        public static void FlushDb(NbpContext context)
        {
            context.Artists.RemoveRange(context.Artists);
            context.ArtWorks.RemoveRange(context.ArtWorks);
            context.Places.RemoveRange(context.Places);
            context.Customers.RemoveRange(context.Customers);
            context.Rentals.RemoveRange(context.Rentals);
            context.Exhibitions.RemoveRange(context.Exhibitions);
            context.ArtExhibitions.RemoveRange(context.ArtExhibitions);
            context.OrderToBuys.RemoveRange(context.OrderToBuys);
            context.Nfts.RemoveRange(context.Nfts);
            context.NftOwnerHistories.RemoveRange(context.NftOwnerHistories);
            context.SaveChanges();
        }
    }
}
