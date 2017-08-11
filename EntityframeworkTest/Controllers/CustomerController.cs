using EntityframeworkTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityframeworkTest.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index() {
            return View();
        }

        public JsonResult GetCustomers() {

            northwindEntities en = new northwindEntities();

            return Json(customers);
        }
    }
}