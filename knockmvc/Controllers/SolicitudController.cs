using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using knockmvc.Models;

namespace knockmvc.Controllers
{
    public class SolicitudController : Controller
    {
        
        //
        // GET: /Solicitud/
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAll()
        {
            
            return Json(RepositorySolicitud.GetSolicitud(),JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult NuevaDependencia(SolicitudDependencia sol)
        {

           
            //guardo la solicitud
            int s = 0;
            sol.Nombre = "Nueva";
            return Json(sol);
        }

       
	}
}