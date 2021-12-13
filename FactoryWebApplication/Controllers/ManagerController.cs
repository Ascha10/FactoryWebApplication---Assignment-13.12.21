using FactoryWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryWebApplication.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult DisplayManagerName()
        {
            ViewBag.ManagerName = "Kevin";
            return View();
        }
        public ActionResult DisplayManager()
        {
            return View(CreatManager());
        }

        public ActionResult DisplayManagersNames()
        {
            ViewBag.ManagersNames = ManagersNames();
            return View();
        }
        public ActionResult DisplayAllManagers()
        {
            return View(CreateListOfManagers());
        }

        private static string[] ManagersNames()
        {
            return new string[] { "roby", "soly", "eli", "biter", "sami", "aviva" };
        }
        private static Manager CreatManager()
        {
            return new Manager("sod", "gil", "Development");
        }
        public static List<Manager> CreateListOfManagers()
        {
            List<Manager> listOfManagers = new List<Manager>();
            listOfManagers.Add(new Manager("filla", "choen", "marketing"));
            listOfManagers.Add(new Manager("sida", "zil", "security"));
            return listOfManagers;
        }

    }
}