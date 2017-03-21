using AutomatedTellerMachine.Models;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class CheckingAccountController : Controller
    {
        private ApplicationDbContext _db;

        public CheckingAccountController()
        {
            _db = new ApplicationDbContext();
        }

        public CheckingAccountController(ApplicationDbContext context)
        {
            _db = context;
        }
        // GET: CheckingAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: CheckingAccount/Details/5
        public ActionResult Details() //working from memory currently, hence no 'int id'
        {

            var userId = User.Identity.GetUserId();
            var checkingAccount = _db.CheckingAccounts.Where(u => u.ApplicationUserId == userId).First();

            if (checkingAccount == null)
            {
                return HttpNotFound();
            }

            return View(checkingAccount);
        }

        // GET: CheckingAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CheckingAccount/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckingAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CheckingAccount/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckingAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckingAccount/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
