
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class BuildLang
    {
        [Key]
        public int BuildLangID { get; set; }
        [StringLength(100)]
        public string BuildingName { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string LanguageID { get; set; }
        public int? BuildingID { get; set; }
    }
}