using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VirtualGallery.Models
{
    public class Composition
    {
        [Required]
        [ForeignKey(nameof(Exhibition))]
        public int ExhibitionId { get; set; }
        [Key]
        public int CompositionId { get; set; }
        [Required]
        [Display(Name ="Name of Composition")]
        public string CompositionName { get; set; }
        [Display(Name ="Composition Description")]
        public string CompositionDescription { get; set; }
        [Display(Name ="Composition Medium")]
        public string CompositionMedium { get; set; }
        [Display(Name = "Date of Composition Creation")]
        public string CompositionCreation { get; set; }
        public byte[] CompositionImage { get; set; }
    }

    public class CompositionsDbContext : DbContext
    {
        public DbSet<Composition> Composition { get; set; }
    }
}