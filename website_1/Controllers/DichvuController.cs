using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website_1.Models;

namespace website_1.Controllers
{
    public class DichvuController : Controller
    {
        datawebsiteDataContext db = new datawebsiteDataContext();
        // GET: Dichvu
        public ActionResult Index()
        {
          
            List<DICHVU> dICHVUs = db.DICHVUs.ToList();
            return View(dICHVUs);
        }
        public ActionResult dv()
        {
            return View();
        }
    }
}