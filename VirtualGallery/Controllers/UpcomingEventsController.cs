using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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

        //GET : Upcoming Events/Delete/{id}
        public ActionResult DeleteEvent(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UpcomingEvents upcomingEvents = _db.Events.Find(id);
            if (upcomingEvents == null)
            {
                return HttpNotFound();
            }
            return View(upcomingEvents);
        }

        //POST : Upcoming Events/Delete/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEvent(int id)
        {
            UpcomingEvents upcomingEvents = _db.Events.Find(id);
            _db.Events.Remove(upcomingEvents);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET : Upcoming Events/Edit/{id}
        public ActionResult EditEvent(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UpcomingEvents upcomingEvents = _db.Events.Find(id);
            if(upcomingEvents == null)
            {
                return HttpNotFound();
            }
            return View(upcomingEvents);
        }

        //GET : Upcoming Events/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEvent(UpcomingEvents upcomingEvents)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(upcomingEvents).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(upcomingEvents);
        }

    }
}