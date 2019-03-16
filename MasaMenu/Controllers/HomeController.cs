using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MasaMenu.Models;

namespace MasaMenu.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        MasaMenuEntities db = new MasaMenuEntities();
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Login");
            }

            return View();
        }
        [HttpPost]
        public ActionResult Index(string urun,string masa)
        {
            siparis sp = new siparis();
            sp.masa_id =Convert.ToInt32(masa);
            sp.urun_id = Convert.ToInt32(urun);
            db.siparis.Add(sp);
            db.SaveChanges();
            return View();
        }
    }
}