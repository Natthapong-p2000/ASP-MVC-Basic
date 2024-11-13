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
            IEnumerable<Student> allStudent = _db.Students;
            return View(allStudent);
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
