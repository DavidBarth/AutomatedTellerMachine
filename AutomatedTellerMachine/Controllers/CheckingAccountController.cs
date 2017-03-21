using AutomatedTellerMachine.Models;
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

        public CheckingAccountController(ApplicationDbContext Context)
        {
            _db = Context;
        }
        // GET: CheckingAccount
        public ActionResult Index()
        {
            return View();
        }

        // GET: CheckingAccount/Details/5
        public ActionResult Details() //working from memory currently, hence no 'int id'
        {
         
          
            //supplying test data and passing it to view
            var testData = new CheckingAccount
            {
                
                AccountNumber = "00001234",
                FirstName = "David",
                LastName = "Barth"
            }; 

            return View(testData);
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
