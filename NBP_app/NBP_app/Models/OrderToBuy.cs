using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models
{
    public class OrderToBuy
    {
        public OrderToBuy()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public double? Price { get; set; }
        public DateTimeOffset Date { get; set; }
        public Guid CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public Guid ArtWorkId { get; set; }
        [ForeignKey("ArtWorkId")]
        public virtual ArtWork ArtWork { get; set; }
    }
}
