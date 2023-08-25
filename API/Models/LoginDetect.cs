using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public partial class LoginDetect
    {
        [Key]
        public int DetectID { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string LoggedByIP { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LoggedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Expires { get; set; }
    }
}
