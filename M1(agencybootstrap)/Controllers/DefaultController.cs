using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M1_agencybootstrap_.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        public ActionResult Takim()
        {
            return View();
        }
        public ActionResult Servis()
        {
            return View();
        }
        public ActionResult Portfoy()
        {
            return View();
        }
    }
}