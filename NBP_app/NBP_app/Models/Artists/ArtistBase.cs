using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models.Artists
{
    public abstract class ArtistBase : BackupEntity
    {
        public ArtistBase()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string PhoneNumber { get; set; }
        public string Style { get; set; }
    }
}
