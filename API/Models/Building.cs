
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class Building
    {
        [Key]
        public int BuildingID { get; set; }
        [StringLength(150)]
        public string BuildingName { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string BuildingSym { get; set; }
        [StringLength(16)]
        [Unicode(false)]
        public string BuildingCode { get; set; }
        public int? AreaID { get; set; }
        public int? Number { get; set; }
        public bool? Visible { get; set; }
    }
}