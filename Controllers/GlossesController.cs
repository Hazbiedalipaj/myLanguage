using MyLanguage__.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyLanguage__.Controllers
{
    public class GlossesController : Controller
    {
        // GET: Glosses/Albanika
        public ActionResult Albanika()
        {
            var glossa = new Glosses() { Name = "Αλβανικά" };

            return View(glossa);
        }

        // GET: Glosses/Agglika
        public ActionResult Agglika()
        {
            var glossa = new Glosses() { Name = "Αγγλικά" };

            return View(glossa);
        }

        // GET: Glosses/Gallika
        public ActionResult Gallika()
        {
            var glossa = new Glosses() { Name = "Γαλλικά" };

            return View(glossa);
        }

        // GET: Glosses/Germanika
        public ActionResult Germanika()
        {
            var glossa = new Glosses() { Name = "Γερμανικά" };

            return View(glossa);
        }

        // GET: Glosses/Ispanika
        public ActionResult Ispanika()
        {
            var glossa = new Glosses() { Name = "Ισπανικά" };

            return View(glossa);
        }

        // GET: Glosses/Italika
        public ActionResult Italika()
        {
            var glossa = new Glosses() { Name = "Ιταλικά" };

            return View(glossa);
        }

        // GET: Glosses/Kinezika
        public ActionResult Kinezika()
        {
            var glossa = new Glosses() { Name = "Κινέζικα" };

            return View(glossa);
        }

        // GET: Glosses/Koreatika
        public ActionResult Koreatika()
        {
            var glossa = new Glosses() { Name = "Κορεάτικα" };

            return View(glossa);
        }

        // GET: Glosses/Rosika
        public ActionResult Rosika()
        {
            var glossa = new Glosses() { Name = "Ρώσικα" };

            return View(glossa);
        }

        // GET: Glosses/Tourkika
        public ActionResult Tourkika()
        {
            var glossa = new Glosses() { Name = "Τούρκικα" };

            return View(glossa);
        }
    }

}