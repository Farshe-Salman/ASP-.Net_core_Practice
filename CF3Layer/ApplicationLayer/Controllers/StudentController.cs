using Microsoft.AspNetCore.Mvc;

namespace ApplicationLayer.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
