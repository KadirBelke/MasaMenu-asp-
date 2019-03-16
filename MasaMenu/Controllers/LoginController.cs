using MasaMenu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasaMenu.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            MasaMenuEntities dab = new MasaMenuEntities();
            var giris = (from p in dab.personel where p.pName == name && p.pPass == password select p).FirstOrDefault();
            if (giris != null)
            {
                Session["user"] = new personel() { pId = giris.pId, yetki = giris.yetki };
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}