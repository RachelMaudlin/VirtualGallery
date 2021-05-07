using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VirtualGallery.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
        public Guid ClientOwnderId { get; set; }
        [Required]
        public string ClientFristName { get; set; }
        [Required]
        public string ClientLastName { get; set; }
        [Required]
        public string ClientEmail { get; set; }
        public string ShippingAddress { get; set; }
        public DateTimeOffset ClientCreatedUTC { get; set; }
        public DateTimeOffset ClientModifiedUTC { get; set; }

    }
}