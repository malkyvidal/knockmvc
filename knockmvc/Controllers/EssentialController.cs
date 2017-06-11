using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace knockmvc.Controllers
{
    public class EssentialController : Controller
    {
        //
        // GET: /Essential/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Colecciones()
        {
            return View();
        }
	}
}