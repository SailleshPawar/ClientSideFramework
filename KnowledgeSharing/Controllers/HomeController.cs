using KnowledgeSharing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeSharing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var employees = new EmployeeVM();
            return View(employees);
        }

        public ActionResult GetEmployees()
        {
            var employees = new EmployeeVM();
            employees.Employees = HomeController.GetEmployee();
            return View("Index",employees);

        }

        public JsonResult GetEmployeeÀPI()
        {
            return new JsonResult
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = HomeController.GetEmployee(),
                MaxJsonLength = int.MaxValue
            };
        }

        public static List<Employee> GetEmployee()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    Age="22",
                    EmCode="102",
                    FirstName="Asad",
                    LastName="Shaikh",
                    Profile="B1"
                },
                 new Employee()
                {
                    Age="22",
                    EmCode="103",
                    FirstName="Kaushal",
                    LastName="Tirawdekar",
                    Profile="B1"
                },
                  new Employee()
                {
                    Age="22",
                    EmCode="104",
                    FirstName="Amit",
                    LastName="Pathare",
                    Profile="B1"
                },
                   new Employee()
                {
                    Age="28",
                    EmCode="106",
                    FirstName="Nikhil",
                    LastName="Mayekar",
                    Profile="B2"
                },
                    new Employee()
                {
                    Age="30",
                    EmCode="6429",
                    FirstName="Saillesh",
                    LastName="Pawar",
                    Profile="B2"
                },
                     new Employee()
                {
                    Age="33",
                    EmCode="6430",
                    FirstName="Snehal",
                    LastName="Thube",
                    Profile="C1"
                },
                      new Employee()
                {
                    Age="40",
                    EmCode="6431",
                    FirstName="Avanish",
                    LastName="Gupta",
                    Profile="C2"
                },
            };
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Countries(List<string> CountryNames)
        {
            return View(CountryNames);
        }

        [NonAction]
        public string GetResult()
        {
            return "Saillesh";
        }

        public PartialViewResult GetPartial()
        {
            List<string> CountryNames = new List<string>() { "US", "UK", "INDIA", "CHINA" };
            return PartialView("GetPartial", CountryNames);
        }

    }
}