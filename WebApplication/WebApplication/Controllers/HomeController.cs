using System;
using System.Configuration;
using System.Web.Mvc;
using ClassLibrary;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var x = new CustomerDataAccess();
            var y = x.ReadData<Customer>();


            ViewBag.Environment = ConfigurationManager.AppSettings["Environment"];
            ViewBag.Region = ConfigurationManager.AppSettings["Region"];
            ViewBag.MachineName = Environment.MachineName;
            return View();
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