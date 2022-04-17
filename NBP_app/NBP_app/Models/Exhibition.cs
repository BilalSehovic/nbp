using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models
{
    public class Exhibition
    {
        public Exhibition()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string NameGallery { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? PlaceId { get; set; }
        [ForeignKey("PlaceId")]
        public virtual Place Place { get; set; }
        public virtual ICollection<ArtExhibition> ArtExhibitions { get; set; }
    }
}
