using FormProcessingAgain.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormProcessingAgain.Controllers
{
    public class STController : Controller
    {
        UniversityDBEntities2 db = new UniversityDBEntities2();
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var data = db.Students.Find(id);
            db.Students.Remove(data);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }


        [HttpPost]
        public ActionResult Update(Student st)
        {
            var exObj = db.Students.Find(st.ID);
            exObj.Name = st.Name;
            exObj.Age = st.Age;
            exObj.Department = st.Department;
            exObj.DeptID = st.DeptID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Search(string ID)
        {
            var data = from s in db.Students
                       where s.Name.Contains(ID)
                       select s;
            return View(data);
        }




    }
}