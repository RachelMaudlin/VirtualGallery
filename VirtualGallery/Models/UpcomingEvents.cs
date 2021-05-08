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
       
        
        [Key]
        public int EventId { get; set; }
       [Required]
       [Display(Name = "Name of Event")]
        public string NameOfEvent { get; set; }
        [Required]
        [Display(Name ="Event Description")]
        public string EventDescription { get; set; }
        [Required]
        [Display(Name ="Event Address")]
        public string EventAddress { get; set; }
        [Required]
        [Display(Name ="Event Date")]
        public DateTime EventDate { get; set; }

    }

    public class UpcomingEventsDbContext : DbContext
    {
        public DbSet<UpcomingEvents> Events { get; set; }
    }
}