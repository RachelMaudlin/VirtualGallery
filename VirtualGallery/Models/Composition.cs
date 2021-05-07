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
        public string CompositionName { get; set; }
        public string CompositionDescription { get; set; }
        public string CompositionCreationDate { get; set; }
    }

    public class CompositionsDbContext : DbContext
    {
        public DbSet<Composition> Compositions { get; set; }
    }
}