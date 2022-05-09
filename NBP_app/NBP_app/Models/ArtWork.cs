using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models
{
    public class ArtWork : BackupEntity
    {
        public ArtWork()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int? Year { get; set; }
        public double? Price { get; set; }
        public string Description { get; set; }
        public Guid ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Nft> Nfts { get; set; }
        public virtual ICollection<ArtExhibition> ArtExhibitions { get; set; }
        public virtual ICollection<OrderToBuy> OrderToBuys { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
