using AutomatedTellerMachine.Models;
using AutomatedTellerMachine.Services;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        private IApplicationDbContext _db;

        public TransactionController()
        {
            _db = new ApplicationDbContext();
        }


        //with this constructor we pass a mock dbcontext to the controller
        public TransactionController(IApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

    

        //GET: Transaction/Deposit
        public ActionResult Deposit(int checkingAccountId) //For tutorial purposes just passing in the query string param
        {
            return View();
        }


        //POST: Transaction/Deposit
        [HttpPost]
        public ActionResult Deposit(Transaction transaction)
        {
            if (!ModelState.IsValid) return View();
            _db.Transactions.Add(transaction);
            _db.SaveChanges();
            var checkingAccountService = new CheckingAccountService(_db);
            checkingAccountService.UpdateBalance(transaction.CheckingAccountId);
            return RedirectToAction("Index", "Home");
        }

        // GET: Transaction
        public ActionResult Index()
        {
            return View();
        }

        // GET: Transaction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Transaction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transaction/Create
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

        // GET: Transaction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transaction/Edit/5
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

        // GET: Transaction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transaction/Delete/5
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
