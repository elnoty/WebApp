using MVCday4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVCday4.Controllers
{
    public class StudentController : Controller
    {
        ITIContext DBContext = new ITIContext();

        public ActionResult Index()
        {
            return View(DBContext.Student.Include(s=>s.Department));
        }
        public ActionResult Create()
        {
            ViewBag.DeptID = new SelectList(DBContext.Department, "ID", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                DBContext.Student.Add(s);
                DBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();     
        }

        [HttpGet]
        public ActionResult Update(int id) //To return data of id in the form -update-
        {
            Student s = DBContext.Student.FirstOrDefault(ss => ss.ID == id);
            ViewBag.DeptID = new SelectList(DBContext.Department, "ID", "Name",s.DeptID);
            return View(s);
        }
        [HttpPost]
        public ActionResult Update(Student s)
        {
            if (ModelState.IsValid)
            {
                DBContext.Entry<Student>(s).State = EntityState.Modified;   //Update Data-Base
                DBContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DeptID = new SelectList(DBContext.Department, "ID", "Name", s.DeptID);
            return View(s);
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                TempData["NullID"] = "Enter ID to remove";
                return RedirectToAction("Index");
            }
            DBContext.Student.Remove(DBContext.Student.Find(id));
            DBContext.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}