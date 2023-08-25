
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class AreaLang
    {
        [Key]
        public int AreaLangID { get; set; }
        [StringLength(100)]
        public string AreaName { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string LanguageID { get; set; }
        public int? AreaID { get; set; }
    }
}