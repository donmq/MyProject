
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Keyless]
    public partial class tempuser
    {
        [StringLength(255)]
        public string PartCode { get; set; }
        [StringLength(255)]
        public string NumberID { get; set; }
        [StringLength(255)]
        public string Fullname { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateIn { get; set; }
        [StringLength(255)]
        public string EmpPosition { get; set; }
        [StringLength(255)]
        public string EmpGroup { get; set; }
        public double? PhepNam { get; set; }
        public double? PNSapXepDaNghi { get; set; }
        public double? PNCaNhanDaNghi { get; set; }
        public double? TongPhepDaNghi { get; set; }
        public double? VoHieu { get; set; }
        public double? CreateAccount { get; set; }
        public double? Year { get; set; }
    }
}