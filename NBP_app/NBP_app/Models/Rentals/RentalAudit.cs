using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models.Rentals
{
    public class RentalAudit : RentalBase
    {
        public string TriggerMethod { get; set; }
        public string TriggerUser { get; set; }
        public DateTimeOffset? TriggerTime { get; set; }
        public Guid RentalId { get; set; }
    }
}
