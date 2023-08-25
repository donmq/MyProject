﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public partial class DatePickerManager
    {
        [Key]
        public int ID { get; set; }
        public bool? EnableMonthPrevious { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateTime { get; set; }
        public int? UserID { get; set; }
        public int? Type { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
    }
}