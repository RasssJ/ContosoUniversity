using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
