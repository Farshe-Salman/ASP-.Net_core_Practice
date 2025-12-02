using System;
using System.Collections.Generic;
using FormProcessingAgain.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormProcessingAgain.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View(new Signin() { });
        }

        [HttpPost]
        public ActionResult Register(Signin signin)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View(signin);
            }
        }
    }
}