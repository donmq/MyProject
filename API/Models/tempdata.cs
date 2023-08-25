
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [Keyless]
    public partial class tempdata
    {
        public double? stt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ngay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ngay1 { get; set; }
        [Column("so the")]
        [StringLength(10)]
        public string so_the { get; set; }
        [StringLength(255)]
        public string dv { get; set; }
        [Column("ly do")]
        [StringLength(255)]
        public string ly_do { get; set; }
        public double? F7 { get; set; }
        public double? F8 { get; set; }
        public double? F9 { get; set; }
    }
}