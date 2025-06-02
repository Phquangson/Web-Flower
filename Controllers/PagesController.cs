using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Win32;

namespace Template_Flower.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult MyAccount()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
            public ActionResult Register()
        {
            return View();
        }
    }
}