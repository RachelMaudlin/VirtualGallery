using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualGallery.Models;

namespace VirtualGallery.Controllers
{
    public class ExhibitionController : Controller
    {
        private ExhibitionDbContext _db = new ExhibitionDbContext();
        // GET: Exhibition
        public ActionResult ExhibitionIndex()
        {
            return View(_db.Exhibitions.ToList());
        }

        //GET : Exhibition/Create
        public ActionResult CreateExhibition()
        {
            return View();
        }
       //POST: Exhibition/Create
       [HttpPost]
       [ValidateAntiForgeryToken]
       public ActionResult CreateExhibition(Exhibition exhibition)
        {
            if (ModelState.IsValid)
            {
                _db.Exhibitions.Add(exhibition);
                _db.SaveChanges();
                return RedirectToAction("ExhibitionIndex");
            }
            return View(exhibition);
        }
    }
}