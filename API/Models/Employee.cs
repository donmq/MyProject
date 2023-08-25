
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class Employee
    {
        [Key]
        public int EmpID { get; set; }
        [StringLength(200)]
        public string? EmpName { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? EmpNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateIn { get; set; }
        public int? PositionID { get; set; }
        [StringLength(400)]
        public string? Descript { get; set; }
        public int? GBID { get; set; }
        public bool? Visible { get; set; }
        public int? PartID { get; set; }
    }
}