using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VirtualGallery.Models
{
    public class Exhibition
    {
        [Required]
        [ForeignKey(nameof(AdminUser))]
        public int AdminId { get; set; }
        [Key]
        public int ExhibitionId { get; set; }
        [Required]
        public string ExhibitionName { get; set; }
        [Required]
        public string ExhibitionDescription { get; set; }
        [Required]
        public  string ExhibitionDate { get; set; }
    }
}