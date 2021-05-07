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
       
        public string NameOfEvent { get; set; }
        
        public string EventDescription { get; set; }
        
        public string EventAddress { get; set; }
        
        public DateTime EventDate { get; set; }

    }

    public class UpcomingEventsDbContext : DbContext
    {
        public DbSet<UpcomingEvents> Events { get; set; }
    }
}