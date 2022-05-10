using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models.ArtWorks
{
    public class ArtWorkBase : BackupEntity
    {
        public ArtWorkBase()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
    }
}
