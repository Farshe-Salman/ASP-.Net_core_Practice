using MVC_Practice.Models;
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
            //viewbag
            ViewBag.S1F = "Kalman";
            ViewBag.S1L = "Dalman";
            ViewBag.S1E = "Kalman@gmail.com";

            ViewBag.S2F = "jalman";
            ViewBag.S2L = "lalman";
            ViewBag.S2E = "jalman@gmail.com";

            //viewdata
            ViewData["S3F"] = "Palman";
            ViewData["S3L"] = "Talman";
            ViewData["S3E"] = "palman@gmail.com";
            return View();
        }

        public ActionResult Create()
        {
            return View();   
        }

        public ActionResult Login()
        {
            if(true) 
            {
                //Temp data
                TempData["Message"] = "create a new account";

                //redirect to internal link in same controller
                return RedirectToAction("Create");  
            }
        }

        public ActionResult HomeIndex()
        {
             if(true)
            {
                //redirect to internal link in different controller
                return RedirectToAction("Index", "Home");  
            }
        }

        public ActionResult Aiub()
        {
            if(true)
            {
                return Redirect("https://www.aiub.edu");    //redirect to external link
            }
        }

        public ActionResult Details()
        {
            //modelBinding
            var s1 = new Student()
            {
                FirstName = "Kalman",
                LastName = "Dalman",
                Email = "Kalman@gmail.com"
            };

            return View(s1);
        }
    }
}