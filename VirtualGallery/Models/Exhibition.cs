using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VirtualGallery.Models
{
    public class Exhibition
    {
        [Key]
        public int ExhibitionId { get; set; }
        [Required]
        [Display(Name ="Name of Exhibition")]
        public string ExhibitionName { get; set; }
        [Required]
        [Display(Name ="Exhibition Description")]
        public string ExhibitionDescription { get; set; }
        [Required]
        [Display(Name ="Exhibition Date")]
        public  string ExhibitionDate { get; set; }
        [Display(Name ="Exhibition Location")]
        public string ExhibitionLocation { get; set; }
    }

    public class ExhibitionDbContext : DbContext
    {
        public DbSet<Exhibition> Exhibitions { get; set; }
    }
}