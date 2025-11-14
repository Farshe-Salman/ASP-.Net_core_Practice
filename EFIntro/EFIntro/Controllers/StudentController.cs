using EFIntro.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFIntro.Controllers
{
    public class StudentController : Controller
    {
        UniversityDBEntities db = new UniversityDBEntities();
        public ActionResult Index()
        {
            var data=db.Students.ToList();
            return View(data);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            TempData["msg"] = "Student Created Successfully";
            return RedirectToAction("Index");

        }

        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}