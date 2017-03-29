using AutomatedTellerMachine.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var checkingAccountId = db.CheckingAccounts.First(c => c.ApplicationUserId == userId).Id;
            ViewBag.CheckingAccountId = checkingAccountId; 
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

            return PartialView("_contactThanks");
        }
    }
}