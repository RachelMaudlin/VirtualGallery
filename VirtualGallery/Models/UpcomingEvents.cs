using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VirtualGallery.Models
{
    public class UpcomingEvents
    {
        [Required]
        [ForeignKey(nameof(User))]
        public int Userid { get; set; }
        [Required]
        [Key]
        public int EventId { get; set; }
        [Required]
        public string NameOfEvent { get; set; }
        [Required]
        public string EventDescription { get; set; }
        [Required]
        public string EventAddress { get; set; }
        [Required]
        public DateTime EventDate { get; set; }

    }

    public class UpcomingEventsDbContext : DbContext
    {
        public DbSet<UpcomingEvents> Events { get; set; }
    }
}