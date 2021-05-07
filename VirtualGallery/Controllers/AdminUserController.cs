using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualGallery.Models;

namespace VirtualGallery.Controllers
{
    public class AdminUserController : Controller
    {
        private AdminUserDbContext _db = new AdminUserDbContext();
        // GET: AdminUser
        public ActionResult Index()
        {
            return View(_db.AdminUsers.ToList());
        }
    }
}