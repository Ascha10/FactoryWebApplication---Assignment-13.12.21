using FactoryWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryWebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        public ActionResult DisplayEmployeeName()
        {
            ViewBag.EmployeeName = "Bob";
            return View();
        }
        public ActionResult DisplayEployee()
        {
            return View(CreatEmployee());
        }

        public ActionResult DisplayEployeesNames()
        {
            ViewBag.EdeployeesNames = EmployeeNames();
            return View();
        }
        public ActionResult DisplayAllEmployees()
        {
            return View(CreateListOfEmployees());
        }

        private static string[] EmployeeNames()
        {
            return new string[] { "kali", "sid", "rotem", "sivan", "avi", "david" };
        }

        private static Employee CreatEmployee()
        {
            return new Employee("bob", "eran", 1978, "05479813");
        }

        public static List<Employee> CreateListOfEmployees()
        {
            List<Employee> listOfEmployees = new List<Employee>();
            listOfEmployees.Add(new Employee("yoni", "shir", 1989, "054798933"));
            listOfEmployees.Add(new Employee("sil", "zilda", 1972, "054789631"));
            listOfEmployees.Add(new Employee("kol", "rob", 1645, "0126841651"));
            listOfEmployees.Add(new Employee("zer", "adoc", 1645, "0534186945"));
            listOfEmployees.Add(new Employee("vilan", "sad", 1635, "078418465"));
            listOfEmployees.Add(new Employee("ford", "asir", 1635, "03484598"));
            return listOfEmployees;
        }
    }
}