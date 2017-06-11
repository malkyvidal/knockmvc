using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace knockmvc.Controllers
{
    public class PersonalController : Controller
    {
        //
        // GET: /Personal/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Observable()
        {
            int d = 0;
            return View();
        }
	}
}