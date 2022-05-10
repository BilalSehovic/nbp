using NBP_app.Models;
using NBP_app.Models.Artists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.PopulateDb
{
    public static partial class PopulateDb
    {
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
    }
}
