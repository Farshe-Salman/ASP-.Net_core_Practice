using From_Processing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace From_Processing.Controllers
{
    public class LoginRegistrationController : Controller
    {
        //*HTTP request based

        //public ActionResult Login()
        //{

        //    return View();
        //}

        //*passing empty class
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Msg = TempData["Msg"];
            return View(new Login() { });
        }


        //*Form collection objecct based

        //[HttpPost]
        //public ActionResult Login(FormCollection form)
        //{
        //    string username = form["username"];
        //    string password = form["password"];
        //    ViewBag.Username = username;
        //    ViewBag.Password = password;
        //    return View();
        //}


        //*Variable name mapping based
        //[HttpPost]
        //public ActionResult Login(string username, string password)
        //{
        //    ViewBag.Username = username;
        //    ViewBag.Password = password;
        //    return View();
        //}

        //*Model binding based*/
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Registration");
            }
            ViewBag.Username = login.Username;
            ViewBag.Password = login.Password;
            return View(login);
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Student s)
        {
            if (ModelState.IsValid)
            {
                TempData["Msg"] = "Registration Successful";
                return RedirectToAction("Login");
            }
            return View(s);
        }
    }
}