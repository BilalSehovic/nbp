using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models
{
    public class Nft
    {
        public Nft()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        public string NftHash { get; set; }
        public Guid ArtWorkId { get; set; }
        [ForeignKey("ArtWorkId")]
        public virtual ArtWork ArtWork { get; set; }
        public virtual ICollection<NftOwnerHistory> NftOwnerHistories { get; set; }
    }
}
