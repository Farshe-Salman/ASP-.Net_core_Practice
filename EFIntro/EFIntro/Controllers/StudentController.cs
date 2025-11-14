using Antlr.Runtime.Tree;
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

        public ActionResult Details(int id)
        {
            var data= db.Students.Find(id);
            return View(data);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Update(Student student)
        {
            var editData = db.Students.Find(student.ID);
            editData.Name = student.Name;
            editData.Age = student.Age;
            editData.Department = student.Department;
            db.SaveChanges();
            TempData["msg"] = "Student Updated Successfully";
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var data = db.Students.Find(id);
            db.Students.Remove(data);
            db.SaveChanges();
            TempData["msg"] = "Student Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}