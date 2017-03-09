using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Having trouble? Send us a message!";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string msg)
        {
            ViewBag.Message = "Thanks! We got your message!";

            return View();
        }
    }
}