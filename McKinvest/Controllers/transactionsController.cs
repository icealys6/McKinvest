using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace McKinvest.Controllers
{
    public class TransactionsController : Controller
    {
        // GET: transactions
        public ActionResult Transactions()
        {
            return View();
        }
    }
}