using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyLanguage__.Models;

namespace MyLanguage__.Controllers
{
    public class TestController : Controller
    {
        // GET: Test/Agglika
        public ActionResult Agglika()
        {
            var test = new Test() { Name = "Τεστ στα Αγγλικά" };
            return View(test);
        }
        // GET: Test/Alvanika
        public ActionResult Alvanika()
        {
            var test = new Test() { Name = "Τεστ στα Αλβανικά" };
            return View(test);
        }
        // GET: Test/Gallika
        public ActionResult Gallika()
        {
            var test = new Test() { Name = "Τεστ στα Γαλλικά" };
            return View(test);
        }
        // GET: Test/Gallika
        public ActionResult Germanika()
        {
            var test = new Test() { Name = "Τεστ στα Γερμανικά" };
            return View(test);
        }
        // GET: Test/Ispanika
        public ActionResult Ispanika()
        {
            var test = new Test() { Name = "Τεστ στα Ισπανικά" };
            return View(test);
    }
        // GET: Test/Italika
        public ActionResult Italika()
        {
            var test = new Test() { Name = "Τεστ στα Ιταλικά" };
            return View(test);
        }
        // GET: Test/Kinezika
        public ActionResult Kinezika()
        {
            var test = new Test() { Name = "Τεστ στα Κινέζικα" };
            return View(test);
        }
        // GET: Test/Koreatika
        public ActionResult Koreatika()
        {
            var test = new Test() { Name = "Τεστ στα Κορεάτικα" };
            return View(test);
        }
        // GET: Test/Rosika
        public ActionResult Rosika()
        {
            var test = new Test() { Name = "Τεστ στα Ρώσικα" };
            return View(test);
        }
        // GET: Test/Tourkika
        public ActionResult Tourkika()
        {
            var test = new Test() { Name = "Τεστ στα Τούρκικα" };
            return View(test);
        }
    }
}