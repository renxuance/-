using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseManager.Models
{
    public class SideBars
    {
        [Key]
        public int Id { get;set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Contorller { get; set; }
        [Required]
        [StringLength(20)]
        public string Actio { get; set; }
    }
}