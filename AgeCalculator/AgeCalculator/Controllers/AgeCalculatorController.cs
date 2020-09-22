using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgeCalculator.Controllers
{
    public class AgeCalculatorController : Controller
    {
        // GET: AgeCalculator
        public ActionResult Calculation()
        {
            return View();
        }
    }
}