using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VirtualGallery.Models
{
    public class AdminUser
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string AdminEmail { get; set; }

    }

    public class AdminUserDbContext : DbContext
    {
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}