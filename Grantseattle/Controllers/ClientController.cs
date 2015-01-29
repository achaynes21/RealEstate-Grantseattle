using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryERP.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        // GET: Client
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AboutUs()
        {
            return View("Aboutus");
        }
        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult News()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Blog()
        {
            return View();
        }
        [HttpGet]
        public ActionResult OurService()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MyFavourite()
        {
            return View();
        }
        
    }
}
