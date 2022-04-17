using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models
{
    public class Artist
    {
        public Artist()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string PhoneNumber { get; set; }
        public string Style { get; set; }
        public Guid? PlaceId { get; set; }
        [ForeignKey("PlaceId")]
        public virtual Place Place { get; set; }
        public virtual ICollection<ArtWork> ArtWorks { get; set; }
    }
}
