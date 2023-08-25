
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class Category
    {
        [Key]
        public int CateID { get; set; }
        [StringLength(100)]
        public string CateName { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string CateSym { get; set; }
        public bool? exhibit { get; set; }
        public bool? Visible { get; set; }
        public int? orderby { get; set; }
    }
}