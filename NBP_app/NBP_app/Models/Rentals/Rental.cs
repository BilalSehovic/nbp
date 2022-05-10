using NBP_app.Models.ArtWorks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models.Rentals
{
    public class Rental : RentalBase
    {
        public Guid? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public Guid? ArtWorkId { get; set; }
        [ForeignKey("ArtWorkId")]
        public virtual ArtWork ArtWork { get; set; }
    }
}
