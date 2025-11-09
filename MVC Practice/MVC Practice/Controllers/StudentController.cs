using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.S1F = "Kalman";
            ViewBag.S1L = "Dalman";
            ViewBag.S1E = "Kalman@gmail.com";
            ViewBag.S2F = "jalman";
            ViewBag.S2L = "lalman";
            ViewBag.S2E = "jalman@gmail.com";
            return View();
        }

        public ActionResult Create()
        {
            return View();   
        }
    }
}