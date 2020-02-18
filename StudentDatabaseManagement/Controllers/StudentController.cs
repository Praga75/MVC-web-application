using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentDatabase.Entity;
using StudentDatabase.Repository;
namespace StudentDatabaseManagement.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository studentRepository = new StudentRepository();
        // GET: Student
        public ActionResult Index()
        {
            IEnumerable<Student> students = studentRepository.GetStudentInfo();
            ViewData["student"] = students;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}