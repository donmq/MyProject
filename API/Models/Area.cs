
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class Area
    {
        [Key]
        public int AreaID { get; set; }
        [StringLength(150)]
        public string AreaName { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string AreaSym { get; set; }
        [StringLength(16)]
        [Unicode(false)]
        public string AreaCode { get; set; }
        public int? CompanyID { get; set; }
        public int? Number { get; set; }
        public bool? Visible { get; set; }
    }
}