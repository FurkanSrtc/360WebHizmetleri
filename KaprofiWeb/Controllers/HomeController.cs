using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KaprofiWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [Route("hakkimizda")]
        public ActionResult Hakkimizda()
        {
            return View();
        }

        [Route("hizmetlerimiz")]
        public ActionResult Hizmetlerimiz()
        {
            return View();
        }

        [Route("referanslar")]
        public ActionResult Referanslar()
        {
            return View();
        }

        public ActionResult WhyUs()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult Clients()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        
    }
}