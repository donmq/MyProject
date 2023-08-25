
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class Position
    {
        [Key]
        public int PositionID { get; set; }
        [StringLength(100)]
        public string PositionName { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string PositionSym { get; set; }
    }
}