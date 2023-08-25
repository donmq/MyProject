﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public partial class CommentArchive
    {
        [Key]
        public int CommentArchiveID { get; set; }
        public int? Value { get; set; }
        [StringLength(250)]
        public string Comment { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public int? UserID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; }
    }
}