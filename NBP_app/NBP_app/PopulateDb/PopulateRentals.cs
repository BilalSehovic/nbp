using NBP_app.Models;
using NBP_app.Models.Rentals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.PopulateDb
{
    public static partial class PopulateDb
    {
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
    }
}
