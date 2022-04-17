using NBP_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Populate();

            Console.WriteLine("TEST");
            Console.ReadLine();
        }

        static void Populate()
        {
            var context = new NbpContext();
            PopulateDb.Populate(context);
            //context.Artists.Add(new Artist
            //{
            //    FirstName = "bili",
            //    BirthDate = new DateTime(1881, 10, 25)
            //});
            context.SaveChanges();
        }
    }
}
