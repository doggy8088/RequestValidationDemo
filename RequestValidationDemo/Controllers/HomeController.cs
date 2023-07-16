using RequestValidationDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RequestValidationDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult ValidateInputDemo()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ValidateInputDemo(ValidateInputDemoVM data)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(data);
        }


        public ActionResult AllowHtmlDemo()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(true)]
        public ActionResult AllowHtmlDemo(AllowHtmlDemoVM data)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(data);
        }
    }
}