using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCuartoDia.Controllers
{
    public class Default1Controller : Controller
    {
        // GET: Default1
        public ActionResult Index()
        {
            Session["sesion1"] = "HastaCerrarNavegador";
            TempData["VueltaCompleta"] = "VueltaCompleta";
            ViewData["MyValor"] = "ControladoraVista";
            ViewBag.MyValor = "ControladoraVista";
            return RedirectToAction("AlgunaOtraAccion", "Default2");
        }
    }
}