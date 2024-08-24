using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test_project.Models;
using test_project.Db.Models;
using test_project.Db.Repositories;

namespace test_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository productsStorage;
        private readonly ICategoriesRepository categoriesStorage;

        public HomeController(IProductsRepository productsStorage, ICategoriesRepository categoriesStorage)
        {
            this.productsStorage = productsStorage;
            this.categoriesStorage = categoriesStorage;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Categories()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult AddCategory()
        {
            return View();
        }
    }
}
