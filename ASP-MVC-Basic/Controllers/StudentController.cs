using ASP_MVC_Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_Basic.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student s1 = new Student();
            s1.Student_Id = "1";
            s1.Name = "test";
            s1.Score = 1;
            return View(s1);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
