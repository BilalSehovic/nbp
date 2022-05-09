using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models
{
    public abstract class BackupEntity
    {
        public DateTimeOffset UpdateTime { get; set; }

        protected BackupEntity()
        {
            UpdateTime = DateTimeOffset.Now;
        }
    }
}
