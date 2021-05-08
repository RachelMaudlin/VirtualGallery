using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualGallery.Controllers
{
    public class ExhibitionController : Controller
    {
        // GET: Exhibition
        public ActionResult ExhibitionIndex()
        {
            return View();
        }
    }
}