using EntityframeworkTest.Models;
using Newtonsoft.Json;
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

            NORTHWNDEntities en = new NORTHWNDEntities();


            var customer = (from c in en.Customers
                            select new {
                                CustomerID = c.CustomerID,
                                CompanyName = c.CompanyName,
                                ContactName = c.ContactName,
                                ContactTitle = c.ContactTitle,
                                Address = c.Address,
                                City = c.City,
                                Region = c.Region,
                                PostalCode = c.PostalCode,
                                Country = c.Country,
                                Phone = c.Phone,
                                Fax = c.Fax
                            }).ToList();

            en.Dispose();

            string json = JsonConvert.SerializeObject(customer);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}