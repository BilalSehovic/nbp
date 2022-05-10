using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models.Artists
{
    public class ArtistAudit : ArtistBase
    {
        public Guid ArtistId { get; set; }
        public string TriggerUser { get; set; }
        public DateTimeOffset? TriggerTime { get; set; }
    }
}
