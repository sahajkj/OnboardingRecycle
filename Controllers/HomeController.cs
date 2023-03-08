using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnboardingRecycle.Models;
using System.Net;

namespace OnboardingRecycle.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();
        public ActionResult Index(string searchString)
        {
            var items = from m in db.Items select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.name.Contains(searchString));
            }
            return View(items);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ViewPage1()
        {
            return View();
        }
    }    
}