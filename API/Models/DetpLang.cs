
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class DetpLang
    {
        [Key]
        public int DeptLangID { get; set; }
        [StringLength(100)]
        public string DeptName { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string LanguageID { get; set; }
        public int? DeptID { get; set; }
    }
}