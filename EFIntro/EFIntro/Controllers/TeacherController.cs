using EFIntro.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFIntro.Controllers
{
    public class TeacherController : Controller
    {
        UniversityDBEntities db = new UniversityDBEntities();
        // GET: Teacher
        public ActionResult Index()
        {
            
            var data = db.Teachers.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Teacher t)
        {
            db.Teachers.Add(t);
            db.SaveChanges();
            TempData["Msg"] = "Teacher Added Successfully";
            return RedirectToAction("Index");
        }

        
        public ActionResult About(int id)
        {
            var data = db.Teachers.Find(id);
            return View(data);
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult St()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        }
}