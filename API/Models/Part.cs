
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class Part
    {
        [Key]
        public int PartID { get; set; }
        [StringLength(200)]
        public string PartName { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string PartSym { get; set; }
        [StringLength(16)]
        [Unicode(false)]
        public string PartCode { get; set; }
        public int? Number { get; set; }
        public int? DeptID { get; set; }
        public bool? Visible { get; set; }
    }
}