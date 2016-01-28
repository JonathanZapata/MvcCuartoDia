using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCuartoDia.Models;

namespace MvcCuartoDia.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public JsonResult  getJson()
        {
            Customer objCustomer = new Customer();
            objCustomer.CustomerCode = "c001";
            return Json(objCustomer, JsonRequestBehavior.AllowGet );
        }

        public ActionResult MostrarJson()
        {
            return View("AprenderJquery");
        }
    }
}