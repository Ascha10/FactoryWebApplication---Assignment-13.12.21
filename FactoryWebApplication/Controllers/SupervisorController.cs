using FactoryWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryWebApplication.Controllers
{
    public class SupervisorController : Controller
    {
        // GET: Supervisor
        public ActionResult DisplaySupervisorName()
        {
            ViewBag.SupervisorName = "Root";
            return View();
        }
        public ActionResult DisplaySupervisor()
        {
            return View(CreatEmployee());
        }

        public ActionResult DisplaySupervisorsNames()
        {
            ViewBag.SupervisorsNames = SupervisorsNames();
            return View();
        }
        public ActionResult DisplayAllSupervisors()
        {
            return View(CreateListOfSupervisors());
        }

        private static string[] SupervisorsNames()
        {
            return new string[] { "ron", "gil", "asi", "elsa", "json", "avital" };
        }
        private static Supervisor CreatEmployee()
        {
            return new Supervisor("Eden", "zelda", 1982, 12);
        }

        public static List<Supervisor> CreateListOfSupervisors()
        {
            List<Supervisor> listOfSupervisors = new List<Supervisor>();
            listOfSupervisors.Add(new Supervisor("filla", "choen", 1972, 4));
            listOfSupervisors.Add(new Supervisor("sida", "zil", 1986, 10));
            listOfSupervisors.Add(new Supervisor("golan", "ronen", 1689, 25));
            listOfSupervisors.Add(new Supervisor("dilan", "fresh", 1648, 45));
            return listOfSupervisors;
        }
    }
}