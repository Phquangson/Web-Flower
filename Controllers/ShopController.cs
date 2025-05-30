using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template_Flower.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Shop()
        {
            return View();
        }

        public  ActionResult Product()
        {
            return View();
        }
        public ActionResult Page404()
        {
            return View();
        }
        public ActionResult ComparePage()
        {
            return View();
        }
        public ActionResult CartPage()
        {
            return View();
        }

    }
}