using Microsoft.AspNetCore.Mvc;

namespace test_project.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
