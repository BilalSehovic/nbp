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
    }
}
