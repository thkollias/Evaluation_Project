using Microsoft.AspNetCore.Mvc;

namespace UniversityApp.Controllers
{
    public class AdminStudentsController : Controller
    {
        [HttpGet]
        public IActionResult Students()
        {
            return View();
        }
    }
}
