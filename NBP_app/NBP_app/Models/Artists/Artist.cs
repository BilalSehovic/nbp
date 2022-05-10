using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models.Artists
{
    public class Artist : ArtistBase
    {
        public Guid? PlaceId { get; set; }
        [ForeignKey("PlaceId")]
        public virtual Place Place { get; set; }
        public virtual ICollection<ArtWork> ArtWorks { get; set; }
    }
}
