using NBP_app.Models.Artists;
using NBP_app.Models.Rentals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models.ArtWorks
{
    public class ArtWork : ArtWorkBase
    {
        public Guid ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public virtual Artist Artist { get; set; }
        public virtual ICollection<Nft> Nfts { get; set; }
        public virtual ICollection<ArtExhibition> ArtExhibitions { get; set; }
        public virtual ICollection<OrderToBuy> OrderToBuys { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
