using ASP_MVC_Basic.Models;
using BasicASPTutorial.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Basic.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _db;

        public StudentController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            Student s1 = new Student();
            s1.Student_Id = "1";
            s1.Name = "test";
            s1.Score = 1;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
