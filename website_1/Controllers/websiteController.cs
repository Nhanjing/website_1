using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website_1.Models;

namespace website_1.Controllers
{
    public class websiteController : Controller
    {
        datawebsiteDataContext db = new datawebsiteDataContext();
        // GET: website
        public ActionResult Index()
        {
            List<TINTUC> tINTUCs = db.TINTUCs.ToList();
            return View(tINTUCs);
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
    }
}