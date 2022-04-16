using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBP_app.Models
{
    public class ArtExhibition
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ArtWorkId { get; set; }
        public Guid ExhibitionId { get; set; }
        [ForeignKey("ArtWorkId")]
        public virtual ArtWork ArtWork { get; set; }
        [ForeignKey("ExhibitionId")]
        public virtual Exhibition Exhibition { get; set; }
    }
}
