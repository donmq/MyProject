
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class Department
    {
        [Key]
        public int DeptID { get; set; }
        [StringLength(150)]
        public string DeptName { get; set; }
        public int? AreaID { get; set; }
        public int? BuildingID { get; set; }
        [StringLength(16)]
        [Unicode(false)]
        public string DeptCode { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string DeptSym { get; set; }
        public int? Number { get; set; }
        public int? Shift_Time { get; set; }
        public bool? Visible { get; set; }
    }
}