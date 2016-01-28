using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCuartoDia.Controllers
{
    public class Default2Controller : Controller
    {
        // GET: Default2
        public ActionResult AlgunaOtraAccion()
        {
            string str = Convert.ToString(TempData["VueltaCompleta"]);
            string str2 = Session["sesion1"].ToString();
            string str3 = Convert.ToString(ViewData["MyValor"]);
            ViewData["MyValor"] = "Controlador a Vista";
            ViewBag.MyValor = "Controlador a Vista Colección";
            return View("VistaDatos");
        }
    }
}