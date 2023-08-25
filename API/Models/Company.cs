
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [StringLength(200)]
        public string CompanyName { get; set; }
        [StringLength(400)]
        public string CompanyInfo { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string CompanySym { get; set; }
        public int? Number { get; set; }
        public bool? Visible { get; set; }
    }
}