using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models
{
    public class NftOwnerHistory
    {
        public NftOwnerHistory()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string Owner { get; set; }
        public DateTime Date { get; set; }
        public Guid NftId { get; set; }
        [ForeignKey("NftId")]
        public virtual Nft Nft { get; set; }
    }
}
