
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class GroupLang
    {
        [Key]
        public int GroupLangID { get; set; }
        [StringLength(100)]
        public string BaseName { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string LanguageID { get; set; }
        public int? GBID { get; set; }
    }
}