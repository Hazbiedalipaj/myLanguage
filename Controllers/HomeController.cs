using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLanguage__.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Παρακάτω σας παρουσιάζουμε τους σκοπούς της σελίδας μας:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Για ερωτήσεις σχετικά με τα μαθήματά μας, επικοινωνήστε μαζί μας ηλεκτρονικά ή τηλεφωνήστε μας";

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Επιλέξτε την γλώσσα που θέλετε για να ξεκινήσει το τεστ";

            return View();
        }
    }
}