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
            var _context = new NbpContext();
            var exhibitions = _context.Exhibitions.ToList();
            Console.WriteLine(exhibitions.FirstOrDefault()?.Place?.City);

            Console.WriteLine("TEST");
            Console.ReadLine();
        }
    }
}
