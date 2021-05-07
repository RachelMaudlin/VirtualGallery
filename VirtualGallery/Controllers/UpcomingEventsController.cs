using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualGallery.Models;

namespace VirtualGallery.Controllers
{
    public class UpcomingEventsController : Controller
    {
        private UpcomingEventsDbContext _db = new UpcomingEventsDbContext();
        // GET: UpcomingEvents
        public ActionResult Index()
        {
            return View(_db.Events.ToList());
        }

        //GET: Upcoming Events/Create
        public ActionResult CreateEvent()
        {
            return View();
        }

        //POST: Upcoming Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEvent(UpcomingEvents upcomingevent)
        {
            if (ModelState.IsValid)
            {
                _db.Events.Add(upcomingevent);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(upcomingevent);
        }

    }
}