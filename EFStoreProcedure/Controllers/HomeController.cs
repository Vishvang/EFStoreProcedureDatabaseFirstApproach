using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFStoreProcedure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Connection String Name
            EFMVCDemoEntities employeeDBContext = new EFMVCDemoEntities();
            return View(employeeDBContext.Func_displayEmployee());
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
    }
}