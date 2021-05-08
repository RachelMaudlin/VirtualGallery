using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VirtualGallery.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string ClientFristName { get; set; }
        [Required]
        [Display(Name ="Last Name")]
        public string ClientLastName { get; set; }
        [Required]
        [Display(Name ="Email")]
        public string ClientEmail { get; set; }
        [Display(Name ="Shipping Address")]
        public string ShippingAddress { get; set; }
    }

    public class ClientsDbContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; }
    }
}