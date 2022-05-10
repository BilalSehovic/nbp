using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models.ArtWorks
{
    public class ArtWorkAudit : ArtWorkBase
    {
        public string TriggerMethod { get; set; }
        public string TriggerUser { get; set; }
        public DateTimeOffset? TriggerTime { get; set; }
        public Guid ArtWorkId { get; set; }
    }
}
