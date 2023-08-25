
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class GroupBase
    {
        public GroupBase()
        {
            SetApproveGroupBase = new HashSet<SetApproveGroupBase>();
        }

        [Key]
        public int GBID { get; set; }
        [StringLength(100)]
        public string BaseName { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string BaseSym { get; set; }

        [InverseProperty("GB")]
        public virtual ICollection<SetApproveGroupBase> SetApproveGroupBase { get; set; }
    }
}